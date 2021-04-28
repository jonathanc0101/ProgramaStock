
Imports AccesoBD

Public Class productos

    Property Lista As CustomSortableBindingList(Of producto)

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

        Dim bdObj As New BDproducto(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerTodas()

        Lista.Clear()

        For Each item As DataRow In dt.Rows

            Dim registro As New producto(Servidor, NombreBD, Usuario, Contrasenia)
            registro.cargar(item)

            Lista.Add(registro)
        Next
    End Sub

    Public Sub eliminar(ByVal ParamID As String)
        Try

            Dim registroAEliminar As producto

            registroAEliminar = Lista.Find("idProducto", ParamID)

            If IsNothing(registroAEliminar) Then

                registroAEliminar = New producto(Servidor, NombreBD, Usuario, Contrasenia)
                registroAEliminar.cargarPorId(ParamID)

            End If

            registroAEliminar.borrar()

            Lista.Remove(registroAEliminar)

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub resetear()
        Lista = New CustomSortableBindingList(Of producto)
    End Sub
End Class