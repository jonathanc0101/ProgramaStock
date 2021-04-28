
Imports AccesoBD

Public Class proveedor

    Property email As String
    Property numeroDeTelefono As String
    Property detalleProveedor As String
    Property nombre As String
    Property idProveedor As Integer

    Property compras As compras

    Private Servidor As String
    Private NombreBD As String
    Private Usuario As String
    Private Contrasenia As String

    Sub New(parServidor As String, parBD As String, parUsuario As String, parContrasenia As String)

        Servidor = parServidor
        NombreBD = parBD
        Usuario = parUsuario
        Contrasenia = parContrasenia

        Me.resetear()

    End Sub


    Public Sub cargarPorId(id As Integer)
        Dim datos As DataTable
        Dim bdObjeto As New BDproveedor(Servidor, NombreBD, Usuario, Contrasenia)

        datos = bdObjeto.obtenerPorID(id)

        If datos.Rows.Count > 0 Then

            cargar(datos.Rows(0))

        End If
    End Sub

    Public Sub cargarCompletoPorId(id As Integer)
        cargarPorId(id)
        cargarObjetos()
    End Sub


    Friend Sub cargar(row As DataRow)
        email = row.Item("email")
        numeroDeTelefono = row.Item("numeroDeTelefono")
        detalleProveedor = row.Item("detalleProveedor")
        nombre = row.Item("nombre")
        idProveedor = row.Item("idProveedor")

    End Sub




    Public Sub agregar(guardador As Guardador)

        Dim bdObjeto As New BDproveedor(Servidor, NombreBD, Usuario, Contrasenia)

        bdObjeto.agregar(guardador.mySqlCommand, guardador.indiceParametro,
                email,
                numeroDeTelefono,
                detalleProveedor,
                nombre)

    End Sub

    Public Sub actualizar(guardador As Guardador)

        Dim bdObj As New BDproveedor(Servidor, NombreBD, Usuario, Contrasenia)

        bdObj.actualizar(guardador.mySqlCommand, guardador.indiceParametro,
                email,
                numeroDeTelefono,
                detalleProveedor,
                nombre,
                idProveedor)

    End Sub

    Public Sub borrar()
        If idProveedor <> 0 Then

            Try
                Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
                Dim bdObj As New BDproveedor(Servidor, NombreBD, Usuario, Contrasenia)

                bdObj.borrar(guardador.mySqlCommand, guardador.indiceParametro,
                                                    idProveedor)
                guardador.guardar()

            Catch ex As Exception
                Throw New Exception("No se pudo eliminar: proveedor.")
            End Try
        End If
    End Sub


    Public Sub guardar()


        Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
        Dim nuevoRegistro As Boolean = False

        If idProveedor = 0 Then

            nuevoRegistro = True
            agregar(guardador)
        Else
            actualizar(guardador)
        End If

        Try
            guardador.guardar()

        Catch ex As Exception

            If nuevoRegistro Then
                Me.resetear()
            End If

            Throw New Exception(ex.Message)
        End Try
    End Sub


    Private Sub resetear()
        email = ""
        numeroDeTelefono = ""
        detalleProveedor = ""
        nombre = ""
        idProveedor = 0

        resetearObjetos()

    End Sub

    Private Sub cargarObjetos()
        cargarComprasPorIdProveedor(Me.idProveedor)
    End Sub
    Private Sub cargarComprasPorIdProveedor(id As Integer)
        If id <> 0 Then
            compras.cargarListaPorProveedor(id)

        End If
    End Sub
    Private Sub resetearObjetos()
        compras = New compras(Servidor, NombreBD, Usuario, Contrasenia)
    End Sub

End Class
