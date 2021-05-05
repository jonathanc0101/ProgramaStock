
Imports AccesoBD

Public Class movimientoEntranteProducto

    Property idCompra As Integer
    Property idProducto As Integer
    Property valorEntradaProducto As Decimal
    Property cantidadEntradaProducto As Decimal
    Property idMovimientoEntranteProducto As Integer

    Public Property descripcionProducto() As String
        Get
            Return producto.descripcionProducto
        End Get
        Set(value As String)
        End Set
    End Property

    Property producto As producto

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
        Dim bdObjeto As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)

        datos = bdObjeto.obtenerPorID(id)

        If datos.Rows.Count > 0 Then

            cargar(datos.Rows(0))

            cargarProducto()

        End If
    End Sub


     Friend Sub cargar(row As DataRow) 
        idCompra = row.Item("idCompra")
        idProducto = row.Item("idProducto")
        valorEntradaProducto = row.Item("valorEntradaProducto")
        cantidadEntradaProducto = row.Item("cantidadEntradaProducto")
        idMovimientoEntranteProducto = row.Item("idMovimientoEntranteProducto")

    End Sub



    Public Sub agregar(guardador As Guardador)

        Dim bdObjeto As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)

        bdObjeto.agregar(guardador.mySqlCommand, guardador.indiceParametro,
                idCompra,
                idProducto,
                valorEntradaProducto,
                cantidadEntradaProducto)


    End Sub



    Public Sub actualizar(guardador As Guardador)

        Dim bdObj As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)

        bdObj.actualizar(guardador.mySqlCommand, guardador.indiceParametro,
                idCompra,
                idProducto,
                valorEntradaProducto,
                cantidadEntradaProducto)

    End Sub



    Public Sub borrar()
        If idMovimientoEntranteProducto <> 0 Then

            Try
                Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
                Dim bdObj As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)

                bdObj.borrar(guardador.mySqlCommand, guardador.indiceParametro,
                                                    idMovimientoEntranteProducto)
                guardador.guardar()

            Catch ex As Exception
                Throw New Exception("No se pudo eliminar: movimientoEntranteProducto.")
            End Try
        End If
    End Sub

    Public Sub borrar(ByRef guardador As Guardador)
        If idMovimientoEntranteProducto <> 0 Then

            Try
                Dim bdObj As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)

                bdObj.borrar(guardador.mySqlCommand, guardador.indiceParametro,
                                                    idMovimientoEntranteProducto)

            Catch ex As Exception
                Throw New Exception("No se pudo eliminar: movimientoEntranteProducto.")
            End Try
        End If
    End Sub

    Public Sub guardar()


        Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
        Dim nuevoRegistro As Boolean = False

        If idMovimientoEntranteProducto = 0 Then

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

    Public Sub cargarProducto()
        cargarProductoPorId(Me.idProducto)
    End Sub
    Public Sub cargarProductoPorId(paramId As Integer)
        producto.cargarCompletoPorId(paramId)
        Me.idProducto = producto.idProducto
    End Sub
    Private Sub resetearObjetos()
        producto = New producto(Servidor, NombreBD, Usuario, Contrasenia)
    End Sub


    Private Sub resetear()
        idCompra = 0
        idProducto = 0
        valorEntradaProducto = 0.0
        cantidadEntradaProducto = 0.0
        idMovimientoEntranteProducto = 0

        resetearObjetos()

    End Sub



End Class
