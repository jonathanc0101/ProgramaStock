
Imports MySql.Data.MySqlClient
Public Class BDmovimientoEntranteProducto

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
        mySqlCommand.CommandText = consulta() & " AND idMovimientoEntranteProducto = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Function obtenerPorCompra(paramId As Integer) As DataTable

        Dim mySqlCommand As New MySqlCommand
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.CommandText = consulta() & " AND idCompra = @id"
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
              ParamIdcompra As Integer,
      ParamIdproducto As Integer,
      ParamValorentradaproducto As Decimal,
      ParamCantidadentradaproducto As Decimal)


        If ParamIdcompra = 0 Then
            mySqlCommand.CommandText &= " SET @idCompra = 0 ;"
        End If

        mySqlCommand.CommandText &= " INSERT INTO `movimientoEntranteProducto` (" & _
        "`idCompra`, " & _
        "`idProducto`, " & _
        "`valorEntradaProducto`, " & _
        "`cantidadEntradaProducto` " & _
        ") " & _
        "VALUES( " & _
        "@idCompra, " & _
        "@idProducto" & indiceParametro & ", " & _
        "@valorEntradaProducto" & indiceParametro & ", " & _
        "@cantidadEntradaProducto" & indiceParametro & "); "
        'se obtiene el idcompra mediante un set anteriormente definido en mysql
        mySqlCommand.Parameters.AddWithValue("@idProducto" & indiceParametro, ParamIdproducto)
        mySqlCommand.Parameters.AddWithValue("@valorEntradaProducto" & indiceParametro, ParamValorentradaproducto)
        mySqlCommand.Parameters.AddWithValue("@cantidadEntradaProducto" & indiceParametro, ParamCantidadentradaproducto)


        indiceParametro += 1
    End Sub

    Public Sub actualizar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
           ParamIdproducto As Integer,
           ParamValorentradaproducto As Decimal,
           ParamCantidadentradaproducto As Decimal,
           ParamIdmovimientoentranteproducto As Integer)


        mySqlCommand.CommandText &= " UPDATE `movimientoEntranteProducto` SET " & _
        "`idProducto`  = @idProducto" & indiceParametro & ", " & _
        "`valorEntradaProducto`  = @valorEntradaProducto" & indiceParametro & ", " & _
        "`cantidadEntradaProducto`  = @cantidadEntradaProducto" & indiceParametro & " " & _
        " WHERE `idMovimientoEntranteProducto` = @idMovimientoEntranteProducto" & indiceParametro & ";"

        mySqlCommand.Parameters.AddWithValue("@idProducto" & indiceParametro, ParamIdproducto)
        mySqlCommand.Parameters.AddWithValue("@valorEntradaProducto" & indiceParametro, ParamValorentradaproducto)
        mySqlCommand.Parameters.AddWithValue("@cantidadEntradaProducto" & indiceParametro, ParamCantidadentradaproducto)
        mySqlCommand.Parameters.AddWithValue("@idMovimientoEntranteProducto" & indiceParametro, ParamIdmovimientoentranteproducto)


        indiceParametro += 1
    End Sub

    Public Sub borrar(ByRef sqlcommand As MySqlCommand, ByRef indiceParametro As Integer,
    ParamidMovimientoEntranteProducto As Integer)

        sqlcommand.CommandText &= "UPDATE `movimientoEntranteProducto` SET IS_DELETED = 'Y' " & _
        " WHERE idMovimientoEntranteProducto = @idMovimientoEntranteProducto" & indiceParametro & ";"

        sqlcommand.Parameters.AddWithValue("@idMovimientoEntranteProducto" & indiceParametro, ParamIdmovimientoentranteproducto)

        indiceParametro += 1
    End Sub

    Public Function calcularTotalEntradasUnProducto(ParamIdProducto As Integer) As Decimal
        Dim mySqlCommand As New MySqlCommand
        mySqlCommand.CommandType = CommandType.Text

        mySqlCommand.CommandText = "select IFNULL(( " & _
        "select sum(`cantidadEntradaProducto`) " & _
        "from ( SELECT `cantidadEntradaProducto` FROM " & _
        "		(SELECT `cantidadEntradaProducto`, `idCompra`  FROM `movimientoentranteproducto` " & _
        "										WHERE `idProducto` = @idProducto ) " & _
        "										as movimientosUnProducto" & _
        "		inner join (SELECT `idCompra`    " & _
        "					FROM `compra` " & _
        "						WHERE `IS_DELETED` = 'N'" & _
        "						AND     `recibido` = true" & _
        "						AND     `anulada` = false" & _
        "					) as idsComprasRecibidasNoAnuladas " & _
        "on movimientosUnProducto.idCompra = idsComprasRecibidasNoAnuladas.idCompra) as cantidadesUnProductoMovimientosValidos " & _
        "), 0 );"

        mySqlCommand.Parameters.AddWithValue("@idProducto", ParamIdProducto)

        Return bd.obtenerDatos(mySqlCommand).Rows(0).Item(0)
    End Function

    Private Function consulta() As String

        Dim query As String

        query = "SELECT " & _
        "`idCompra`, " & _
        "`idProducto`, " & _
        "`valorEntradaProducto`, " & _
        "`cantidadEntradaProducto`, " & _
        "`idMovimientoEntranteProducto` " & _
        "FROM `movimientoEntranteProducto`" & _
        " WHERE IS_DELETED = 'N' "

        Return query

    End Function
End Class