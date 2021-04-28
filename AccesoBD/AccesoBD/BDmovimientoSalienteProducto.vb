
Imports MySql.Data.MySqlClient
Public Class BDmovimientoSalienteProducto

    Private bd As BD

    Sub New(parServidor As String, parBD As String, parUsuario As String, parContrasenia As String)

        bd = New BD(parServidor, parBD, parUsuario, parContrasenia)
    End Sub

    Public Function obtenerTodas() As DataTable
        Return bd.obtenerDatos(consulta)
    End Function

    Public Function obtenerPorID(paramId As Integer) As DataTable

        Dim mySqlCommand As New MySqlCommand
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.CommandText = consulta() & " AND idMovimientoSalienteProducto = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Function obtenerPorVenta(paramId As Integer) As DataTable

        Dim mySqlCommand As New MySqlCommand
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.CommandText = consulta() & " AND idVenta = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Function obtenerPorProducto(paramId As Integer) As DataTable

        Dim mySqlCommand As New MySqlCommand
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.CommandText = consulta() & " AND idProducto = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function
    Public Sub agregar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
          ParamValorsalidaproducto As Decimal,
  ParamCantidadsalidaproducto As Decimal,
  ParamIdproducto As Integer)


        mySqlCommand.CommandText &= " INSERT INTO `movimientoSalienteProducto` (" & _
        "`valorSalidaProducto`, " & _
        "`cantidadSalidaProducto`, " & _
        "`idProducto`, " & _
        "`idVenta` " & _
        ") " & _
        "VALUES( " & _
        "@valorSalidaProducto" & indiceParametro & ", " & _
        "@cantidadSalidaProducto" & indiceParametro & ", " & _
        "@idProducto" & indiceParametro & ", " & _
        "@idVenta ); "         'se obtiene el idVenta mediante un set anteriormente definido en mysql
        mySqlCommand.Parameters.AddWithValue("@valorSalidaProducto" & indiceParametro, ParamValorsalidaproducto)
        mySqlCommand.Parameters.AddWithValue("@cantidadSalidaProducto" & indiceParametro, ParamCantidadsalidaproducto)
        mySqlCommand.Parameters.AddWithValue("@idProducto" & indiceParametro, ParamIdproducto)


        indiceParametro += 1
    End Sub

    Public Sub actualizar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                                   ParamValorsalidaproducto As Decimal,
           ParamCantidadsalidaproducto As Decimal,
           ParamIdproducto As Integer,
           ParamIdmovimientosalienteproducto As Integer)


        mySqlCommand.CommandText &= " UPDATE `movimientoSalienteProducto` SET " & _
        "`valorSalidaProducto`  = @valorSalidaProducto" & indiceParametro & ", " & _
        "`cantidadSalidaProducto`  = @cantidadSalidaProducto" & indiceParametro & ", " & _
        "`idProducto`  = @idProducto" & indiceParametro & " " & _
        " WHERE `idMovimientoSalienteProducto` = @idMovimientoSalienteProducto" & indiceParametro & ";"

        mySqlCommand.Parameters.AddWithValue("@valorSalidaProducto" & indiceParametro, ParamValorsalidaproducto)
        mySqlCommand.Parameters.AddWithValue("@cantidadSalidaProducto" & indiceParametro, ParamCantidadsalidaproducto)
        mySqlCommand.Parameters.AddWithValue("@idProducto" & indiceParametro, ParamIdproducto)
        mySqlCommand.Parameters.AddWithValue("@idMovimientoSalienteProducto" & indiceParametro, ParamIdmovimientosalienteproducto)


        indiceParametro += 1
    End Sub

    Public Sub borrar(ByRef sqlcommand As MySqlCommand, ByRef indiceParametro As Integer,
    ParamidMovimientoSalienteProducto As Integer)

        sqlcommand.CommandText &= "UPDATE `movimientoSalienteProducto` SET IS_DELETED = 'Y' " & _
        " WHERE idMovimientoSalienteProducto = @idMovimientoSalienteProducto" & indiceParametro & ";"

        sqlcommand.Parameters.AddWithValue("@idMovimientoSalienteProducto" & indiceParametro, ParamIdmovimientosalienteproducto)

        indiceParametro += 1
    End Sub

    Public Function calcularTotalSalidasUnProducto(ParamIdProducto As Integer) As Decimal
        Dim mySqlCommand As New MySqlCommand
        mySqlCommand.CommandType = CommandType.Text

        mySqlCommand.CommandText = "select IFNULL(( " & _
        "select sum(`cantidadSalidaProducto`) " & _
        "from ( SELECT `cantidadSalidaProducto` FROM " & _
        "		(SELECT `cantidadSalidaProducto`, `idVenta`  FROM `movimientosalienteproducto` " & _
        "										WHERE `idProducto` = @idProducto ) " & _
        "										as movimientosUnProducto" & _
        "		inner join (SELECT `idVenta`    " & _
        "					FROM `venta` " & _
        "						WHERE `IS_DELETED` = 'N'" & _
        "						AND     `entregado` = true" & _
        "						AND     `anulada` = false" & _
        "					) as idsVentasRecibidasNoAnuladas " & _
        "on movimientosUnProducto.idVenta = idsVentasRecibidasNoAnuladas.idVenta) as cantidadesUnProductoMovimientosValidos " & _
        "), 0 ); "

        mySqlCommand.Parameters.AddWithValue("@idProducto", ParamIdProducto)

        Return bd.obtenerDatos(mySqlCommand).Rows(0).Item(0)

    End Function

    Private Function consulta() As String

        Dim query As String

        query = "SELECT " & _
        "`valorSalidaProducto`, " & _
        "`cantidadSalidaProducto`, " & _
        "`idProducto`, " & _
        "`idVenta`, " & _
        "`idMovimientoSalienteProducto` " & _
        "FROM `movimientoSalienteProducto`" & _
        " WHERE IS_DELETED = 'N' "

        Return query

    End Function
End Class