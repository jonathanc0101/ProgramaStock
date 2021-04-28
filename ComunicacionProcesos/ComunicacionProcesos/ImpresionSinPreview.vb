Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class ImpresionSinPreview
    Implements IDisposable

    Private report As New LocalReport()

    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Private parametros() As ReportParameter
    Private ubicacion As String

    Private nombreDocumento As String

    Private altoPagina As Double
    Private anchoPagina As Double

    Private margenTop As Double
    Private margenBot As Double
    Private margenLeft As Double
    Private margenRight As Double

    'Property CantidadCopias As Integer = 1
    Property UnidadDeMedida As String = "cm"

    Sub New(_nombreDocumento As String, _parametros() As ReportParameter, _ubicacion As String,
        _altoPagina As Double,
        _anchoPagina As Double,
        _margenTop As Double,
        _margenBot As Double,
        _margenLeft As Double,
        _margenRight As Double)


        nombreDocumento = _nombreDocumento
        parametros = _parametros
        ubicacion = _ubicacion

        altoPagina = _altoPagina
        anchoPagina = _anchoPagina
        margenTop = _margenTop
        margenBot = _margenBot
        margenLeft = _margenLeft
        margenRight = _margenRight
    End Sub

    Public Sub cargarDataSet(_nombreDataSet As String, _dataSet As Object)

        report.DataSources.Add(New ReportDataSource(_nombreDataSet, _dataSet))
    End Sub

    ' Routine to provide to the report renderer, in order to
    ' save an image for each page of the report.
    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        m_streams.Add(stream)
        Return stream
    End Function

    ' Export the given report as an EMF (Enhanced Metafile) file.
    Private Sub Export(ByVal report As LocalReport) '"<OutputFormat>EMF</OutputFormat>" & _
        Dim deviceInfo As String = "<DeviceInfo>" & _
            "<OutputFormat>EMF</OutputFormat>" & _
            "<PageWidth>" & anchoPagina.ToString & UnidadDeMedida & "</PageWidth>" & _
            "<PageHeight>" & altoPagina.ToString & UnidadDeMedida & "</PageHeight>" & _
            "<MarginTop>" & margenTop.ToString & UnidadDeMedida & "</MarginTop>" & _
            "<MarginLeft>" & margenLeft.ToString & UnidadDeMedida & "</MarginLeft>" & _
            "<MarginRight>" & margenRight.ToString & UnidadDeMedida & "</MarginRight>" & _
            "<MarginBottom>" & margenBot.ToString & UnidadDeMedida & "</MarginBottom>" & _
            "</DeviceInfo>"

        Dim warnings As Warning()
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        For Each stream As Stream In m_streams
            stream.Position = 0
        Next
    End Sub

    ' Handler for PrintPageEvents
    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

        ' Adjust rectangular area with printer margins.
        Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX), _
                                          ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY), _
                                          ev.PageBounds.Width, _
                                          ev.PageBounds.Height)

        ' Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

        ' Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect)

        ' Prepare for the next page. Make sure we haven't hit the end.
        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub prePrint()
        If m_streams Is Nothing OrElse m_streams.Count = 0 Then
            Throw New Exception("Error: no stream to print.")
        End If
    End Sub

    Private Sub Print()
        prePrint()
        Dim printDoc As New PrintDocument()
        If Not printDoc.PrinterSettings.IsValid Then
            Throw New Exception("Error: cannot find the default printer.")
        Else
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            m_currentPageIndex = 0
            'printDoc.DefaultPageSettings.Landscape = False
            'printDoc.PrinterSettings.Copies = CantidadCopias
            printDoc.Print()
        End If
    End Sub

    ' Sobrecarga del metodo de impresion, recibe el indice de papel requerido, y el indice de bandeja para obtener los recursos.
    Private Sub Print(papel As Integer, bandeja As Integer)
        prePrint()
        Dim printDoc As New PrintDocument()
        If Not printDoc.PrinterSettings.IsValid Then
            Throw New Exception("Error: cannot find the default printer.")
        Else
            printDoc.DefaultPageSettings.PaperSize = printDoc.PrinterSettings.PaperSizes.Item(papel)
            printDoc.DefaultPageSettings.PaperSource = printDoc.PrinterSettings.PaperSources.Item(bandeja)
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            m_currentPageIndex = 0
            'printDoc.DefaultPageSettings.Landscape = False
            'printDoc.PrinterSettings.Copies = CantidadCopias
            printDoc.Print()
        End If
    End Sub

    Private Sub preRun()
        report.ReportPath = ubicacion '"..\..\Reporte1.rdlc"
        If Not IsNothing(parametros) Then
            report.SetParameters(parametros)
        End If
        Export(report)
        report.DisplayName = nombreDocumento
    End Sub

    ' Create a local report for Report.rdlc, load the data,
    ' export the report to an .emf file, and print it.
    Public Sub Run()
        preRun()
        Print()
    End Sub

    Public Sub Run(papel As Integer, bandeja As Integer)
        preRun()
        Print(papel, bandeja)
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If m_streams IsNot Nothing Then
            For Each stream As Stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub

    Public Sub setearUnidadDeMedida(paramUnidad As Unidad)

        Select Case paramUnidad

            Case Unidad.Centrimetros
                UnidadDeMedida = "cm"
            Case Unidad.Milimetros
                UnidadDeMedida = "mm"
            Case Else
                UnidadDeMedida = "cm"
        End Select
    End Sub

    Public Enum Unidad
        Centrimetros
        Milimetros
    End Enum
End Class
