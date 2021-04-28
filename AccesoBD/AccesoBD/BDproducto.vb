
Imports MySql.Data.MySqlClient
Public Class BDproducto

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
        mySqlCommand.CommandText = consulta() & " AND idProducto = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Sub agregar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                ParamCantidadunidadesminimasenstock As Decimal,
        ParamCantidadunidadesenstock As Decimal,
        ParamPreciounitario As Decimal,
        ParamUnidadproducto As String,
        ParamDetalledosproducto As String,
        ParamDetalleunoproducto As String,
        ParamDescripcionproducto As String,
        ParamCategoria As String)


        mySqlCommand.CommandText &= "INSERT INTO `producto` (" & _
        "`cantidadUnidadesMinimasEnStock`, " & _
        "`cantidadUnidadesEnStock`, " & _
        "`precioUnitario`, " & _
        "`unidadProducto`, " & _
        "`detalleDosProducto`, " & _
        "`detalleUnoProducto`, " & _
        "`descripcionProducto`, " & _
        "`categoria` " & _
        ") " & _
        "VALUES( " & _
        "@cantidadUnidadesMinimasEnStock" & indiceParametro & ", " & _
        "@cantidadUnidadesEnStock" & indiceParametro & ", " & _
        "@precioUnitario" & indiceParametro & ", " & _
        "@unidadProducto" & indiceParametro & ", " & _
        "@detalleDosProducto" & indiceParametro & ", " & _
        "@detalleUnoProducto" & indiceParametro & ", " & _
        "@descripcionProducto" & indiceParametro & ", " & _
        "@categoria" & indiceParametro & "); "
        mySqlCommand.Parameters.AddWithValue("@cantidadUnidadesMinimasEnStock" & indiceParametro, ParamCantidadunidadesminimasenstock)
        mySqlCommand.Parameters.AddWithValue("@cantidadUnidadesEnStock" & indiceParametro, ParamCantidadunidadesenstock)
        mySqlCommand.Parameters.AddWithValue("@precioUnitario" & indiceParametro, ParamPreciounitario)
        mySqlCommand.Parameters.AddWithValue("@unidadProducto" & indiceParametro, ParamUnidadproducto)
        mySqlCommand.Parameters.AddWithValue("@detalleDosProducto" & indiceParametro, ParamDetalledosproducto)
        mySqlCommand.Parameters.AddWithValue("@detalleUnoProducto" & indiceParametro, ParamDetalleunoproducto)
        mySqlCommand.Parameters.AddWithValue("@descripcionProducto" & indiceParametro, ParamDescripcionproducto)
        mySqlCommand.Parameters.AddWithValue("@categoria" & indiceParametro, ParamCategoria)


        indiceParametro += 1
    End Sub

    Public Sub actualizar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                                   ParamCantidadunidadesminimasenstock As Decimal,
           ParamCantidadunidadesenstock As Decimal,
           ParamPreciounitario As Decimal,
           ParamUnidadproducto As String,
           ParamDetalledosproducto As String,
           ParamDetalleunoproducto As String,
           ParamDescripcionproducto As String,
           ParamCategoria As String,
           ParamIdproducto As Integer)


        mySqlCommand.CommandText &= "UPDATE `producto` SET " & _
        "`cantidadUnidadesMinimasEnStock`  = @cantidadUnidadesMinimasEnStock" & indiceParametro & ", " & _
        "`cantidadUnidadesEnStock`  = @cantidadUnidadesEnStock" & indiceParametro & ", " & _
        "`precioUnitario`  = @precioUnitario" & indiceParametro & ", " & _
        "`unidadProducto`  = @unidadProducto" & indiceParametro & ", " & _
        "`detalleDosProducto`  = @detalleDosProducto" & indiceParametro & ", " & _
        "`detalleUnoProducto`  = @detalleUnoProducto" & indiceParametro & ", " & _
        "`descripcionProducto`  = @descripcionProducto" & indiceParametro & ", " & _
        "`categoria`  = @categoria" & indiceParametro & ", " & _
        "`idProducto`  = @idProducto" & indiceParametro & _
" WHERE `idProducto` = @idProducto" & indiceParametro & ";"

        mySqlCommand.Parameters.AddWithValue("@cantidadUnidadesMinimasEnStock" & indiceParametro, ParamCantidadunidadesminimasenstock)
        mySqlCommand.Parameters.AddWithValue("@cantidadUnidadesEnStock" & indiceParametro, ParamCantidadunidadesenstock)
        mySqlCommand.Parameters.AddWithValue("@precioUnitario" & indiceParametro, ParamPreciounitario)
        mySqlCommand.Parameters.AddWithValue("@unidadProducto" & indiceParametro, ParamUnidadproducto)
        mySqlCommand.Parameters.AddWithValue("@detalleDosProducto" & indiceParametro, ParamDetalledosproducto)
        mySqlCommand.Parameters.AddWithValue("@detalleUnoProducto" & indiceParametro, ParamDetalleunoproducto)
        mySqlCommand.Parameters.AddWithValue("@descripcionProducto" & indiceParametro, ParamDescripcionproducto)
        mySqlCommand.Parameters.AddWithValue("@categoria" & indiceParametro, ParamCategoria)
        mySqlCommand.Parameters.AddWithValue("@idProducto" & indiceParametro, ParamIdproducto)


        indiceParametro += 1
    End Sub

    Public Sub borrar(ByRef sqlcommand As MySqlCommand, ByRef indiceParametro As Integer,
    ParamidProducto As Integer)

        sqlcommand.CommandText &= "UPDATE `producto` SET IS_DELETED = 'Y' " & _
        " WHERE idProducto = @idProducto" & indiceParametro & ";"

        sqlcommand.Parameters.AddWithValue("@idProducto" & indiceParametro, ParamIdproducto)

        indiceParametro += 1
    End Sub

    Private Function consulta() As String

        Dim query As String

        query = "SELECT " & _
        "`cantidadUnidadesMinimasEnStock`, " & _
        "`cantidadUnidadesEnStock`, " & _
        "`precioUnitario`, " & _
        "`unidadProducto`, " & _
        "`detalleDosProducto`, " & _
        "`detalleUnoProducto`, " & _
        "`descripcionProducto`, " & _
        "`categoria`, " & _
        "`idProducto` " & _
        "FROM `producto`" & _
        " WHERE IS_DELETED = 'N' "

        Return query

    End Function
End Class