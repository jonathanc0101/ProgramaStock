
Imports AccesoBD

Public Class movimientosSalientesProducto

    Property Lista As CustomSortableBindingList(Of movimientoSalienteProducto)

    Private Servidor As String
    Private NombreBD As String
    Private Usuario As String
    Private Contrasenia As String

    Sub New(parServidor As String, parBD As String, parUsuario As String, ParContrasenia As String)

        Servidor = parServidor
        NombreBD = parBD
        Usuario = parUsuario
        Contrasenia = ParContrasenia

        Me.resetear()

    End Sub


    Public Sub cargarLista()

        Dim bdObj As New BDmovimientoSalienteProducto(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerTodas()

        Lista.Clear()

        meterRegistrosEnLista(dt)
    End Sub

    Public Sub cargarListaPorVenta(ParamIdVenta As Integer)

        Dim bdObj As New BDmovimientoSalienteProducto(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerPorVenta(ParamIdVenta)

        meterRegistrosEnLista(dt)

    End Sub
    Public Sub cargarListaPorProducto(ParamIdProducto As Integer)

        Dim bdObj As New BDmovimientoSalienteProducto(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerPorProducto(ParamIdProducto)

        meterRegistrosEnLista(dt)

    End Sub


    Private Sub meterRegistrosEnLista(dt As DataTable)
        Lista.Clear()

        For Each item As DataRow In dt.Rows

            Dim registro As New movimientoSalienteProducto(Servidor, NombreBD, Usuario, Contrasenia)
            registro.cargar(item)
            registro.cargarProducto()

            Lista.Add(registro)
        Next
    End Sub

    Public Sub eliminar(ByVal ParamID As String)
        Try

            Dim registroAEliminar As movimientoSalienteProducto

            registroAEliminar = Lista.Find("idMovimientoSalienteProducto", ParamID)

            If IsNothing(registroAEliminar) Then

                registroAEliminar = New movimientoSalienteProducto(Servidor, NombreBD, Usuario, Contrasenia)
                registroAEliminar.cargarPorId(ParamID)

            End If

            registroAEliminar.borrar()

            Lista.Remove(registroAEliminar)

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Friend Function calcularTotal() As Decimal
        Dim total As Decimal = 0.0

        For Each movimiento As movimientoSalienteProducto In Lista
            total += movimiento.valorSalidaProducto
        Next

        Return total

    End Function

    Public Sub nuevo(item As movimientoSalienteProducto)
        Lista.Add(item)
    End Sub

    Public Sub resetear()
        Lista = New CustomSortableBindingList(Of movimientoSalienteProducto)
    End Sub

    Public Sub guardarListado(guardador As Guardador)
        For Each movimiento As movimientoSalienteProducto In Lista
            If movimiento.idMovimientoSalienteProducto = 0 Then
                movimiento.agregar(guardador)
            Else
                movimiento.actualizar(guardador)
            End If
        Next
    End Sub

    Public Function calcularTotalItemsVendidosUnProducto(idProducto As Integer) As Decimal
        Dim bdObj As New BDmovimientoSalienteProducto(Servidor, NombreBD, Usuario, Contrasenia)

        Return bdObj.calcularTotalSalidasUnProducto(idProducto)

    End Function

    Friend Sub resetearLista()
        Me.resetear()
    End Sub

End Class