
Imports AccesoBD

Public Class compra

    Property fecha As DateTime
    Property anulada As Boolean
    Property recibido As Boolean
    Property pagado As Boolean
    Property idProveedor As Integer
    Property montoTotal As Decimal
    Property idCompra As Integer

    Property detalle As String

    Private _impactarEnStock As Boolean 'solo se activa una vez, cuando llamemos a impactar en stock
    Public Sub impactarEnStock()
        _impactarEnStock = True
    End Sub

    Property movimientosEntrantes As movimientosEntrantesProducto
    Property proveedor As proveedor

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
        Dim bdObjeto As New BDcompra(Servidor, NombreBD, Usuario, Contrasenia)

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
        fecha = row.Item("fecha")
        anulada = row.Item("anulada")
        recibido = row.Item("recibido")
        pagado = row.Item("pagado")
        idProveedor = row.Item("idProveedor")
        montoTotal = row.Item("montoTotal")
        idCompra = row.Item("idCompra")
        detalle = row.Item("descripcion")
    End Sub



    Public Sub agregar(guardador As Guardador)

        Dim bdObjeto As New BDcompra(Servidor, NombreBD, Usuario, Contrasenia)

        bdObjeto.agregar(guardador.mySqlCommand, guardador.indiceParametro,
                fecha,
                anulada,
                recibido,
                pagado,
                idProveedor,
                montoTotal,
                detalle)


    End Sub


    Public Sub actualizar(guardador As Guardador)

        Dim bdObj As New BDcompra(Servidor, NombreBD, Usuario, Contrasenia)

        bdObj.actualizar(guardador.mySqlCommand, guardador.indiceParametro,
                fecha,
                anulada,
                recibido,
                pagado,
                idProveedor,
                montoTotal,
                idCompra,
                detalle)

    End Sub


    Public Sub guardar()


        Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
        Dim nuevoRegistro As Boolean = False

        If idCompra = 0 Then

            nuevoRegistro = True
            agregar(guardador)
        Else
            actualizar(guardador)
        End If
        Me.movimientosEntrantes.guardarListado(guardador)

        Try
            If _impactarEnStock Then
                impactarMovimientosEnStock(guardador)
            End If
            guardador.guardar()

        Catch ex As Exception

            If nuevoRegistro Then
                Me.resetear()
            End If

            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub impactarMovimientosEnStock(guardador As Guardador)
        For Each movimiento As movimientoEntranteProducto In movimientosEntrantes.Lista
            movimiento.producto.cantidadUnidadesEnStock += movimiento.cantidadEntradaProducto
            movimiento.producto.actualizar(guardador)
        Next
    End Sub

    Public Sub borrar()
        If idCompra <> 0 Then

            Try
                Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
                Dim bdObj As New BDcompra(Servidor, NombreBD, Usuario, Contrasenia)

                bdObj.borrar(guardador.mySqlCommand, guardador.indiceParametro,
                                                    idCompra)
                guardador.guardar()

            Catch ex As Exception
                Throw New Exception("No se pudo eliminar: compra.")
            End Try
        End If
    End Sub


    Private Sub resetear()
        fecha = Now
        anulada = False
        recibido = False
        pagado = False
        idProveedor = 0
        montoTotal = 0.0
        idCompra = 0
        _impactarEnStock = False
        detalle = ""

        resetearObjetos()
    End Sub

    Private Sub cargarObjetos()
        cargarMovimientosEntrantes(Me.idCompra)
        cargarProveedorPorId(Me.idProveedor)
    End Sub
    Private Sub resetearObjetos()
        movimientosEntrantes = New movimientosEntrantesProducto(Servidor, NombreBD, Usuario, Contrasenia)
        proveedor = New proveedor(Servidor, NombreBD, Usuario, Contrasenia)
    End Sub

    Public Sub cargarMovimientosEntrantes(ParamIdCompra As Integer)
        movimientosEntrantes.cargarListaPorCompra(ParamIdCompra)
        Me.montoTotal = movimientosEntrantes.calcularTotal
    End Sub

    Public Sub agregarItemDeCompra(itemNuevo As movimientoEntranteProducto)

        Me.movimientosEntrantes.nuevo(itemNuevo)
        montoTotal = movimientosEntrantes.calcularTotal()

    End Sub

    Public Sub eliminarItemDeCompra(ByRef item As movimientoEntranteProducto)
        movimientosEntrantes.aniadirAColaEliminar(item)
    End Sub

    Public Sub recalcularTotal()
        montoTotal = movimientosEntrantes.calcularTotal()
    End Sub


    Public Sub cargarItemsPorCompra(ParamIdVenta As Integer)
        movimientosEntrantes.cargarListaPorCompra(ParamIdVenta)
        Me.montoTotal = movimientosEntrantes.calcularTotal
    End Sub
    Public Sub cargarProveedorPorId(paramIdProveedor As Integer)
        proveedor.cargarPorId(paramIdProveedor)

        Me.idProveedor = proveedor.idProveedor

    End Sub

    Public Sub resetearItems()
        Me.movimientosEntrantes.resetearLista()
    End Sub

End Class
