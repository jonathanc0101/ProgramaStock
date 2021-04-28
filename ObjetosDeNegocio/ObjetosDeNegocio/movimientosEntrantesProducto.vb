
Imports AccesoBD

Public Class movimientosEntrantesProducto

    Property Lista As CustomSortableBindingList(Of movimientoEntranteProducto)

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

        Dim bdObj As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerTodas()

        Lista.Clear()

        meterRegistrosEnLista(dt)

    End Sub
    Public Sub cargarListaPorCompra(ParamIdVenta As Integer)

        Dim bdObj As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerPorCompra(ParamIdVenta)

        meterRegistrosEnLista(dt)

    End Sub

    Public Sub cargarListaPorProducto(ParamIdProducto As Integer)

        Dim bdObj As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)
        Dim dt As DataTable = bdObj.obtenerPorProducto(ParamIdProducto)

        meterRegistrosEnLista(dt)
    End Sub
    Private Sub meterRegistrosEnLista(dt As DataTable)
        Lista.Clear()

        For Each item As DataRow In dt.Rows

            Dim registro As New movimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)
            registro.cargar(item)
            registro.cargarProducto()

            Lista.Add(registro)
        Next
    End Sub

    Public Sub eliminar(ByVal ParamID As Integer)
        Try

            Dim registroAEliminar As movimientoEntranteProducto

            registroAEliminar = Lista.Find("idMovimientoEntranteProducto", ParamID)

            If IsNothing(registroAEliminar) Then

                registroAEliminar = New movimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)
                registroAEliminar.cargarPorId(ParamID)

            End If

            registroAEliminar.borrar()

            Lista.Remove(registroAEliminar)

        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub eliminar(ParamRegistro As movimientoEntranteProducto)
        Lista.Remove(ParamRegistro)
    End Sub

    Friend Function calcularTotal() As Decimal
        Dim total As Decimal = 0.0

        For Each movimiento As movimientoEntranteProducto In Lista
            total += movimiento.valorEntradaProducto
        Next

        Return total

    End Function


    Public Sub guardarListado(guardador As Guardador)
        For Each movimiento As movimientoEntranteProducto In Lista
            If movimiento.idMovimientoEntranteProducto = 0 Then
                movimiento.agregar(guardador)
            Else
                movimiento.actualizar(guardador)
            End If
        Next
    End Sub

    Public Sub resetear()
        Lista = New CustomSortableBindingList(Of movimientoEntranteProducto)
    End Sub

    Public Sub nuevo(item As movimientoEntranteProducto)
        Dim listaFiltrada As New CustomSortableBindingList(Of movimientoEntranteProducto)
        Dim registro As movimientoEntranteProducto

        registro = item

        'chequeamos por duplicados identicos
        listaFiltrada.AddRange(Lista.Where(Function(x) x.idProducto = item.idProducto And _
                                              x.cantidadEntradaProducto = item.cantidadEntradaProducto And _
                                              x.valorEntradaProducto = item.valorEntradaProducto _
                                              ).ToList)

        If listaFiltrada.Count > 1 Then
            'sumamos los registros iguales, lo unico que cambia es que se multiplican los valores
            registro.cantidadEntradaProducto *= listaFiltrada.Count
            registro.valorEntradaProducto *= listaFiltrada.Count
            'eliminamos los registros duplicados
            For Each movimiento As movimientoEntranteProducto In listaFiltrada
                Lista.Remove(movimiento)
                If movimiento.idMovimientoEntranteProducto <> 0 Then
                    movimiento.borrar()
                End If
            Next
            'añadimos el item ya fusionado
            Lista.Add(registro)
        Else
            'añadimos el item nuevo como está ya que no hubo duplicados identicos
            Lista.Add(registro)
        End If

        'ahora chequeamos por registros identicos (con el mismo valor) salvo por el campo cantidadEntradaProducto
        listaFiltrada = New CustomSortableBindingList(Of movimientoEntranteProducto)
        'chequeamos por duplicados identicos
        listaFiltrada.AddRange(Lista.Where(Function(x) x.idProducto = item.idProducto And _
                                              (x.valorEntradaProducto / x.cantidadEntradaProducto) = (item.valorEntradaProducto / item.cantidadEntradaProducto)
                                              ).ToList)

        If listaFiltrada.Count > 1 Then
            'creamos un nuevo registro vacio
            Dim nuevoRegistro As New movimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)
            nuevoRegistro.descripcionProducto = item.descripcionProducto
            nuevoRegistro.idCompra = item.idCompra
            nuevoRegistro.idMovimientoEntranteProducto = item.idMovimientoEntranteProducto
            nuevoRegistro.idProducto = item.idProducto
            nuevoRegistro.producto = item.producto

            nuevoRegistro.cantidadEntradaProducto = 0
            nuevoRegistro.valorEntradaProducto = 0

            'fusionamos los duplicados
            For Each movimiento As movimientoEntranteProducto In listaFiltrada
                nuevoRegistro.cantidadEntradaProducto += movimiento.cantidadEntradaProducto
                nuevoRegistro.valorEntradaProducto += movimiento.valorEntradaProducto

                Lista.Remove(movimiento)
                If movimiento.idMovimientoEntranteProducto <> 0 Then
                    movimiento.borrar()
                End If

            Next
            'añadimos el nuevo registro
            Lista.Add(nuevoRegistro)
        End If

        'si no hubo mas de uno entonces no se hace nada.
    End Sub
    Public Function calcularTotalItemsCompradosUnProducto(idProducto As Integer) As Decimal
        Dim bdObj As New BDmovimientoEntranteProducto(Servidor, NombreBD, Usuario, Contrasenia)

        Return bdObj.calcularTotalEntradasUnProducto(idProducto)

    End Function

    Friend Sub resetearLista()
        Me.resetear()
    End Sub

End Class