
Imports AccesoBD

Public Class ventas

    Property Lista As CustomSortableBindingList(Of venta)

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

        Dim bdObj As New BDventa(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerTodas()

        MeterRegistrosEnLista(dt)

    End Sub

    Public Sub cargarListaPorEmpleado(IdEmpleado As Integer)

        Dim bdObj As New BDventa(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerPorEmpleado(IdEmpleado)

        MeterRegistrosEnLista(dt)

    End Sub



    Private Sub MeterRegistrosEnLista(dt As DataTable)
        Lista.Clear()

        For Each item As DataRow In dt.Rows

            Dim registro As New venta(Servidor, NombreBD, Usuario, Contrasenia)
            registro.cargar(item)

            Lista.Add(registro)
        Next
    End Sub

    Public Sub eliminar(ByVal ParamID As String)
        Try

            Dim registroAEliminar As venta

            registroAEliminar = Lista.Find("idVenta", ParamID)

            If IsNothing(registroAEliminar) Then

                registroAEliminar = New venta(Servidor, NombreBD, Usuario, Contrasenia)
                registroAEliminar.cargarPorId(ParamID)

            End If

            registroAEliminar.borrar()

            Lista.Remove(registroAEliminar)

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub resetear()
        Lista = New CustomSortableBindingList(Of venta)
    End Sub
End Class