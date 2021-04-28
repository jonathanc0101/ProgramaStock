
Imports MySql.Data.MySqlClient
Public Class BDproveedor

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
        mySqlCommand.CommandText = consulta() & " AND idProveedor = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Sub agregar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                ParamEmail As String,
        ParamNumerodetelefono As String,
        ParamDetalleproveedor As String,
        ParamNombre As String)


        mySqlCommand.CommandText &= "INSERT INTO `proveedor` (" & _
        "`email`, " & _
        "`numeroDeTelefono`, " & _
        "`detalleProveedor`, " & _
        "`nombre` " & _
        ") " & _
        "VALUES( " & _
        "@email" & indiceParametro & ", " & _
        "@numeroDeTelefono" & indiceParametro & ", " & _
        "@detalleProveedor" & indiceParametro & ", " & _
        "@nombre" & indiceParametro & "); "
        mySqlCommand.Parameters.AddWithValue("@email" & indiceParametro, ParamEmail)
        mySqlCommand.Parameters.AddWithValue("@numeroDeTelefono" & indiceParametro, ParamNumerodetelefono)
        mySqlCommand.Parameters.AddWithValue("@detalleProveedor" & indiceParametro, ParamDetalleproveedor)
        mySqlCommand.Parameters.AddWithValue("@nombre" & indiceParametro, ParamNombre)


        indiceParametro += 1
    End Sub

    Public Sub actualizar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                                   ParamEmail As String,
           ParamNumerodetelefono As String,
           ParamDetalleproveedor As String,
           ParamNombre As String,
           ParamIdproveedor As Integer)


        mySqlCommand.CommandText &= "UPDATE `proveedor` SET " & _
        "`email`  = @email" & indiceParametro & ", " & _
        "`numeroDeTelefono`  = @numeroDeTelefono" & indiceParametro & ", " & _
        "`detalleProveedor`  = @detalleProveedor" & indiceParametro & ", " & _
        "`nombre`  = @nombre" & indiceParametro & ", " & _
        "`idProveedor`  = @idProveedor" & indiceParametro & _
        " WHERE `idProveedor` = @idProveedor" & indiceParametro & ";"

        mySqlCommand.Parameters.AddWithValue("@email" & indiceParametro, ParamEmail)
        mySqlCommand.Parameters.AddWithValue("@numeroDeTelefono" & indiceParametro, ParamNumerodetelefono)
        mySqlCommand.Parameters.AddWithValue("@detalleProveedor" & indiceParametro, ParamDetalleproveedor)
        mySqlCommand.Parameters.AddWithValue("@nombre" & indiceParametro, ParamNombre)
        mySqlCommand.Parameters.AddWithValue("@idProveedor" & indiceParametro, ParamIdproveedor)


        indiceParametro += 1
    End Sub

    Public Sub borrar(ByRef sqlcommand As MySqlCommand, ByRef indiceParametro As Integer,
    ParamidProveedor As Integer)

        sqlcommand.CommandText &= "UPDATE `proveedor` SET IS_DELETED = 'Y' " & _
        " WHERE idProveedor = @idProveedor" & indiceParametro & ";"

        sqlcommand.Parameters.AddWithValue("@idProveedor" & indiceParametro, ParamIdproveedor)

        indiceParametro += 1
    End Sub

    Private Function consulta() As String

        Dim query As String

        query = "SELECT " & _
        "`email`, " & _
        "`numeroDeTelefono`, " & _
        "`detalleProveedor`, " & _
        "`nombre`, " & _
        "`idProveedor` " & _
        "FROM `proveedor`" & _
        " WHERE IS_DELETED = 'N' "

        Return query

    End Function
End Class