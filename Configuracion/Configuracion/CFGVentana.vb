Imports System.Xml
Imports System.Drawing

Public Class CFGVentana

    Property X As Integer
    Property Y As Integer
    Property Ancho As Integer
    Property Alto As Integer
    Property EstadoVentana As Windows.Forms.FormWindowState

    Private ConfiguracionServidor As CFGServidor

    Public ReadOnly Property Servidor As String
        Get
            Return ConfiguracionServidor.Servidor
        End Get
    End Property

    Public ReadOnly Property BD As String
        Get
            Return ConfiguracionServidor.BD
        End Get
    End Property

    Public ReadOnly Property Usuario As String
        Get
            Return ConfiguracionServidor.Usuario
        End Get
    End Property

    Public ReadOnly Property pass As String
        Get
            Return ConfiguracionServidor.pass
        End Get
    End Property

    Private Ventana As Windows.Forms.Form

    Sub New()

        X = valorXporDefecto
        Y = valorYporDefecto
        Ancho = valorAnchoporDefecto
        Alto = valorAltoporDefecto

        EstadoVentana = valorEstadoporDefecto
    End Sub

    Public Sub cargarVentana(ByRef XMLDoc As XmlDocument, ubicacionNodo As String)

        obtenerNodo(XMLDoc, Left(ubicacionNodo, ubicacionNodo.Length - 1))
        obtenerNodo(XMLDoc, ubicacionNodo & "Ventana")

        X = obtenerValorNodo(obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/X"), valorXporDefecto)
        Y = obtenerValorNodo(obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/Y"), valorYporDefecto)
        Ancho = obtenerValorNodo(obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/Ancho"), valorAnchoporDefecto)
        Alto = obtenerValorNodo(obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/Alto"), valorAltoporDefecto)
        EstadoVentana = obtenerValorNodo(obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/EstadoVentana"), valorEstadoporDefecto)

        revisarValores()

        ConfiguracionServidor = New CFGServidor(True)
        ConfiguracionServidor.cargar(XMLDoc)
    End Sub

    Public Sub guardarVentana(ByRef XMLDoc As XmlDocument, ubicacionNodo As String)

        revisarValores()

        obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/X").InnerText = X
        obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/Y").InnerText = Y
        obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/Ancho").InnerText = Ancho
        obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/Alto").InnerText = Alto

        obtenerNodo(XMLDoc, ubicacionNodo & "Ventana/EstadoVentana").InnerText = EstadoVentana
    End Sub

    Private Sub revisarValores()

        If X < 0 Then
            X = valorXporDefecto
        End If
        If Y < 0 Then
            Y = valorYporDefecto
        End If
        If Ancho <= 200 Then
            Ancho = valorAnchoporDefecto
        End If
        If Alto <= 200 Then
            Alto = valorAltoporDefecto
        End If


    End Sub

    Public Sub setearVentana(ByRef paramVentana As Windows.Forms.Form)
        Ventana = paramVentana
        Ventana.Location = New Point(Me.X, Me.Y)
        Ventana.Size = New Size(Me.Ancho, Me.Alto)

        Ventana.WindowState = Me.EstadoVentana

        AddHandler Ventana.ResizeEnd, AddressOf cambioTamanioVentana
        AddHandler Ventana.SizeChanged, AddressOf cambioMaximizadoVentana
    End Sub

    Private Sub cambioTamanioVentana()
        X = Ventana.Location.X
        Y = Ventana.Location.Y

        If Me.EstadoVentana = Windows.Forms.FormWindowState.Normal Then
            Ancho = Ventana.Size.Width
            Alto = Ventana.Size.Height
        End If

        EstadoVentana = Windows.Forms.FormWindowState.Normal
    End Sub

    Private Sub cambioMaximizadoVentana()
        If Ventana.WindowState = Windows.Forms.FormWindowState.Maximized Or Ventana.WindowState = Windows.Forms.FormWindowState.Normal Then
            EstadoVentana = Ventana.WindowState
        End If
    End Sub

End Class
