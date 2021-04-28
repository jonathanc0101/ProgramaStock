
Imports AccesoBD

Public Class venta


    Property anulada As Boolean
    Property fecha As DateTime
    Property entregado As Boolean
    Property cobrado As Boolean
    Property montoTotal As Decimal
    Property idEmpleado As Integer
    Property idVenta As Integer

    Private _impactarEnStock As Boolean 'solo se activa una vez, cuando llamemos a impactar en stock
    Public Sub impactarEnStock()
        _impactarEnStock = True
    End Sub

    Property items As movimientosSalientesProducto
    Property empleado As empleado

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
        Dim bdObjeto As New BDventa(Servidor, NombreBD, Usuario, Contrasenia)

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
        anulada = row.Item("anulada")
        fecha = row.Item("fecha")
        entregado = row.Item("entregado")
        cobrado = row.Item("cobrado")
        montoTotal = row.Item("montoTotal")
        idEmpleado = row.Item("idEmpleado")
        idVenta = row.Item("idVenta")

    End Sub



    Public Sub agregar(guardador As Guardador)

        Dim bdObjeto As New BDventa(Servidor, NombreBD, Usuario, Contrasenia)

        bdObjeto.agregar(guardador.mySqlCommand, guardador.indiceParametro,
                anulada,
                fecha,
                entregado,
                cobrado,
                montoTotal,
                idEmpleado)


    End Sub



    Public Sub actualizar(guardador As Guardador)

        Dim bdObj As New BDventa(Servidor, NombreBD, Usuario, Contrasenia)

        bdObj.actualizar(guardador.mySqlCommand, guardador.indiceParametro,
                anulada,
                fecha,
                entregado,
                cobrado,
                montoTotal,
                idEmpleado,
                idVenta)

    End Sub


    Public Sub borrar()
        If idVenta <> 0 Then

            Try
                Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
                Dim bdObj As New BDventa(Servidor, NombreBD, Usuario, Contrasenia)

                bdObj.borrar(guardador.mySqlCommand, guardador.indiceParametro,
                                                    idVenta)
                guardador.guardar()

            Catch ex As Exception
                Throw New Exception("No se pudo eliminar: venta.")
            End Try
        End If
    End Sub



    Public Sub guardar()


        Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
        Dim nuevoRegistro As Boolean = False

        If idVenta = 0 Then

            nuevoRegistro = True
            agregar(guardador)

        Else
            actualizar(guardador)
        End If

        Try
            If _impactarEnStock Then
                impactarMovimientosEnStock(guardador)
            End If

            items.guardarListado(guardador)

            guardador.guardar()

        Catch ex As Exception

            If nuevoRegistro Then
                Me.resetear()
            End If

            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub impactarMovimientosEnStock(guardador As Guardador)
        For Each movimiento As movimientoSalienteProducto In items.Lista
            movimiento.producto.cantidadUnidadesEnStock -= movimiento.cantidadSalidaProducto
            movimiento.producto.actualizar(guardador)
        Next
    End Sub
    Private Sub resetear()
        anulada = False
        fecha = Now
        entregado = False
        cobrado = False
        montoTotal = 0.0
        idEmpleado = 0
        idVenta = 0
        _impactarEnStock = False

        resetearObjetos()
    End Sub

    Public Sub recalcularTotal()
        montoTotal = items.calcularTotal()
    End Sub
    Private Sub cargarObjetos()
        cargarItemsPorVenta(Me.idVenta)
        cargarEmpleadoPorId(Me.idEmpleado)
    End Sub

    Private Sub resetearObjetos()
        items = New movimientosSalientesProducto(Servidor, NombreBD, Usuario, Contrasenia)
        empleado = New empleado(Servidor, NombreBD, Usuario, Contrasenia)
    End Sub

    Public Sub cargarItemsPorVenta(ParamIdVenta As Integer)
        items.cargarListaPorVenta(ParamIdVenta)
        Me.montoTotal = items.calcularTotal
    End Sub
    Public Sub cargarEmpleadoPorId(paramIdEmpleado As Integer)
        empleado.cargarPorId(paramIdEmpleado)

        Me.idEmpleado = empleado.idEmpleado

    End Sub

    Public Sub agregarItemDeVenta(item As movimientoSalienteProducto)
        Me.items.nuevo(item)
        montoTotal = items.calcularTotal()
    End Sub

    Public Sub resetearItems()
        Me.items.resetearLista()
    End Sub

End Class
