Imports System.Xml

Public Class Grilla

    Public Enum EnumTipoFiltroGrilla
        HaceDias
        DesdeHasta
        Hoy
    End Enum

    Property nombreColumnaOrdenada As String
    Property orden As Integer
    Property FilasSeleccionadasPorID As List(Of Integer)
    Property indiceDeScroll As Integer
    Property TipoFiltro As EnumTipoFiltroGrilla
    Property FechaDesde As Date
    Property FechaHasta As Date

    Private _CantidadDias As Integer
    Public Property CantidadDias As Integer
        Get
            Return _CantidadDias
        End Get
        Set(ByVal value As Integer)
            _CantidadDias = value

            If TipoFiltro = EnumTipoFiltroGrilla.HaceDias Then
                FechaHasta = Now.ToShortDateString
                FechaDesde = FechaHasta.AddDays(CantidadDias * -1).ToShortDateString
            End If
        End Set
    End Property


    Sub New()

        nombreColumnaOrdenada = ""
        orden = 0
        FilasSeleccionadasPorID = New List(Of Integer)
        indiceDeScroll = 0

        TipoFiltro = EnumTipoFiltroGrilla.HaceDias
        FechaDesde = Now
        FechaHasta = Now
        CantidadDias = 1
    End Sub

    Public Sub setearFilasSeleccionadas(paramFilas As Windows.Forms.DataGridViewSelectedRowCollection, paramNombreColumnaID As String)

        FilasSeleccionadasPorID = New List(Of Integer)

        If paramFilas.Count > 0 Then
            For Each row As Windows.Forms.DataGridViewRow In paramFilas
                FilasSeleccionadasPorID.Add(row.Cells(paramNombreColumnaID).Value)
            Next
        End If
    End Sub

    Friend Sub cargar(ByRef XMLDoc As XmlDocument, paramUbicacion As String)

        nombreColumnaOrdenada = obtenerValorNodo(obtenerNodo(XMLDoc, paramUbicacion & "nombreColumnaOrdenada"), "")
        orden = obtenerValorNodo(obtenerNodo(XMLDoc, paramUbicacion & "orden"), 0)
        setearFilasSeleccionadas(obtenerValorNodo(obtenerNodo(XMLDoc, paramUbicacion & "FilasSeleccionadasPorID"), ""))
        indiceDeScroll = obtenerValorNodo(obtenerNodo(XMLDoc, paramUbicacion & "indiceDeScroll"), 0)
        TipoFiltro = obtenerValorNodo(obtenerNodo(XMLDoc, paramUbicacion & "TipoFiltro"), 0)
        FechaDesde = Convert.ToDateTime(obtenerValorNodo(obtenerNodo(XMLDoc, paramUbicacion & "FechaDesde"), Now))
        FechaHasta = Convert.ToDateTime(obtenerValorNodo(obtenerNodo(XMLDoc, paramUbicacion & "FechaHasta"), Now))
        CantidadDias = obtenerValorNodo(obtenerNodo(XMLDoc, paramUbicacion & "CantidadDias"), 1)
    End Sub

    Friend Sub guardar(ByRef XMLDoc As XmlDocument, paramUbicacion As String)

        obtenerNodo(XMLDoc, paramUbicacion & "nombreColumnaOrdenada").InnerText = nombreColumnaOrdenada
        obtenerNodo(XMLDoc, paramUbicacion & "orden").InnerText = orden
        obtenerNodo(XMLDoc, paramUbicacion & "FilasSeleccionadasPorID").InnerText = filasSeleccionadasAstring()
        obtenerNodo(XMLDoc, paramUbicacion & "indiceDeScroll").InnerText = indiceDeScroll
        obtenerNodo(XMLDoc, paramUbicacion & "TipoFiltro").InnerText = TipoFiltro
        obtenerNodo(XMLDoc, paramUbicacion & "FechaDesde").InnerText = FechaDesde.ToShortDateString
        obtenerNodo(XMLDoc, paramUbicacion & "FechaHasta").InnerText = FechaHasta.ToShortDateString
        obtenerNodo(XMLDoc, paramUbicacion & "CantidadDias").InnerText = CantidadDias
    End Sub

    Friend Sub setearFilasSeleccionadas(Wstr As String)

        FilasSeleccionadasPorID = New List(Of Integer)

        If Wstr.Replace(" ", "") <> "" Then
            For Each Witem As Integer In Wstr.Split
                FilasSeleccionadasPorID.Add(Witem)
            Next
        End If

    End Sub

    Friend Function filasSeleccionadasAstring()

        Dim res As String = ""

        If FilasSeleccionadasPorID.Count > 0 Then
            For Each item As Integer In FilasSeleccionadasPorID
                res &= item & " "
            Next
            res = Left(res, res.Length - 1)
        End If

        Return res
    End Function
End Class
