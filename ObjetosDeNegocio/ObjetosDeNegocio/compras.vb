
Imports AccesoBD

Public Class compras

    Property Lista As CustomSortableBindingList(Of compra)

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

        Dim bdObj As New BDcompra(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerTodas()

        meterRegistrosEnLista(dt)
    End Sub


    Public Sub cargarListaPorProveedor(paramIdProveedor As Integer)

        Dim bdObj As New BDcompra(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerPorProveedor(paramIdProveedor)

        meterRegistrosEnLista(dt)
    End Sub

    Private Sub meterRegistrosEnLista(dt As DataTable)

        Lista.Clear()

        For Each item As DataRow In dt.Rows
            Dim registro As New compra(Servidor, NombreBD, Usuario, Contrasenia)
            registro.cargar(item)

            'tenemos en cuenta que las compras no sean compras sino cargas nuevas al stock desde el mismo proveedor
            If registro.idProveedor <> 0 Then
                Lista.Add(registro)
            End If
        Next
    End Sub

    Public Sub eliminar(ByVal ParamID As String)
        Try

            Dim registroAEliminar As compra

            registroAEliminar = Lista.Find("idCompra", ParamID)

            If IsNothing(registroAEliminar) Then

                registroAEliminar = New compra(Servidor, NombreBD, Usuario, Contrasenia)
                registroAEliminar.cargarPorId(ParamID)

            End If

            registroAEliminar.borrar()

            Lista.Remove(registroAEliminar)

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub resetear()
        Lista = New CustomSortableBindingList(Of compra)
    End Sub
End Class