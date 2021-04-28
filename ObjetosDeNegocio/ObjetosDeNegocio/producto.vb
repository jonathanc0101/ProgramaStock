
Imports AccesoBD

Public Class producto

    Property cantidadUnidadesMinimasEnStock As Decimal
    Property cantidadUnidadesEnStock As Decimal
    Property precioUnitario As Decimal
    Property unidadProducto As String
    Property detalleDosProducto As String
    Property detalleUnoProducto As String
    Property descripcionProducto As String
    Property categoria As String
    Property idProducto As Integer

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
        Dim bdObjeto As New BDproducto(Servidor, NombreBD, Usuario, Contrasenia)

        datos = bdObjeto.obtenerPorID(id)

        If datos.Rows.Count > 0 Then

            cargar(datos.Rows(0))

        End If
    End Sub


    Friend Sub cargar(row As DataRow)
        cantidadUnidadesMinimasEnStock = row.Item("cantidadUnidadesMinimasEnStock")
        cantidadUnidadesEnStock = row.Item("cantidadUnidadesEnStock")
        precioUnitario = row.Item("precioUnitario")
        unidadProducto = row.Item("unidadProducto")
        detalleDosProducto = row.Item("detalleDosProducto")
        detalleUnoProducto = row.Item("detalleUnoProducto")
        descripcionProducto = row.Item("descripcionProducto")
        categoria = row.Item("categoria")
        idProducto = row.Item("idProducto")

    End Sub


    Public Sub cargarCompletoPorId(id As Integer)
        cargarPorId(id)
        cargarStock()
    End Sub

    Private Sub cargarStock()
        Dim BDMovimientosEntrantes As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)
        Dim BDMovimientosSalientes As New BDmovimientoSalienteProducto(Servidor, NombreBD, Usuario, Contrasenia)

        cantidadUnidadesEnStock = BDMovimientosEntrantes.calcularTotalEntradasUnProducto(Me.idProducto) - _
                                     BDMovimientosSalientes.calcularTotalSalidasUnProducto(Me.idProducto)
    End Sub
    Public Sub agregar(guardador As Guardador)

        Dim bdObjeto As New BDproducto(Servidor, NombreBD, Usuario, Contrasenia)

        bdObjeto.agregar(guardador.mySqlCommand, guardador.indiceParametro,
                cantidadUnidadesMinimasEnStock,
                cantidadUnidadesEnStock,
                precioUnitario,
                unidadProducto,
                detalleDosProducto,
                detalleUnoProducto,
                descripcionProducto,
                categoria)

    End Sub



    Public Sub actualizar(guardador As Guardador)

        Dim bdObj As New BDproducto(Servidor, NombreBD, Usuario, Contrasenia)

        bdObj.actualizar(guardador.mySqlCommand, guardador.indiceParametro,
                cantidadUnidadesMinimasEnStock,
                cantidadUnidadesEnStock,
                precioUnitario,
                unidadProducto,
                detalleDosProducto,
                detalleUnoProducto,
                descripcionProducto,
                categoria,
                idProducto)

    End Sub




    Public Sub borrar()
        If idProducto <> 0 Then

            Try
                Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
                Dim bdObj As New BDproducto(Servidor, NombreBD, Usuario, Contrasenia)

                bdObj.borrar(guardador.mySqlCommand, guardador.indiceParametro,
                                                    idProducto)
                guardador.guardar()

            Catch ex As Exception
                Throw New Exception("No se pudo eliminar: producto.")
            End Try
        End If
    End Sub



    Public Sub guardar()


        Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
        Dim nuevoRegistro As Boolean = False

        If idProducto = 0 Then

            nuevoRegistro = True
            agregar(guardador)
        Else
            actualizar(guardador)
        End If

        Try
            guardador.guardar()


            If Me.cantidadUnidadesEnStock > 0 And nuevoRegistro Then
                Me.idProducto = guardador.BD.obtenerUltimoIDInsertado()
                generarStockDefault()
            End If

        Catch ex As Exception

            If nuevoRegistro Then
                Me.resetear()
            End If

            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub resetear()
        cantidadUnidadesMinimasEnStock = 0.0
        cantidadUnidadesEnStock = 0.0
        precioUnitario = 0.0
        unidadProducto = ""
        detalleDosProducto = ""
        detalleUnoProducto = ""
        descripcionProducto = ""
        categoria = ""
        idProducto = 0

    End Sub


    Private Sub generarStockDefault()

        Dim nuevoMov As New movimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)

        nuevoMov.idCompra = 0 'id de la compra por default
        nuevoMov.idProducto = Me.idProducto
        nuevoMov.cantidadEntradaProducto = Me.cantidadUnidadesEnStock

        nuevoMov.guardar()
    End Sub

End Class
