
Imports MySql.Data.MySqlClient
Public Class BDcompra

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
        mySqlCommand.CommandText = consulta() & " AND idCompra = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Function obtenerPorProveedor(paramId As Integer) As DataTable

        Dim mySqlCommand As New MySqlCommand
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.CommandText = consulta() & " AND idProveedor = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Sub agregar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                ParamFecha As DateTime,
        ParamAnulada As Boolean,
        ParamRecibido As Boolean,
        ParamPagado As Boolean,
        ParamIdproveedor As Integer,
        ParamMontototal As Decimal,
        ParamDescripcion As String)


        mySqlCommand.CommandText &= "INSERT INTO `compra` (" & _
        "`fecha`, " & _
        "`anulada`, " & _
        "`recibido`, " & _
        "`pagado`, " & _
        "`idProveedor`, " & _
        "`montoTotal` ," & _
        " `Descripcion` " & _
        ") " & _
        "VALUES( " & _
        "@fecha" & indiceParametro & ", " & _
        "@anulada" & indiceParametro & ", " & _
        "@recibido" & indiceParametro & ", " & _
        "@pagado" & indiceParametro & ", " & _
        "@idProveedor" & indiceParametro & ", " & _
        "@montoTotal" & indiceParametro & ", " & _
        "@Descripcion" & indiceParametro & ");" & _
        " SET @idCompra = last_insert_id(); "
        mySqlCommand.Parameters.AddWithValue("@fecha" & indiceParametro, ParamFecha)
        mySqlCommand.Parameters.AddWithValue("@anulada" & indiceParametro, ParamAnulada)
        mySqlCommand.Parameters.AddWithValue("@recibido" & indiceParametro, ParamRecibido)
        mySqlCommand.Parameters.AddWithValue("@pagado" & indiceParametro, ParamPagado)
        mySqlCommand.Parameters.AddWithValue("@idProveedor" & indiceParametro, ParamIdproveedor)
        mySqlCommand.Parameters.AddWithValue("@montoTotal" & indiceParametro, ParamMontototal)
        mySqlCommand.Parameters.AddWithValue("@Descripcion" & indiceParametro, ParamDescripcion)

        indiceParametro += 1
    End Sub

    Public Sub actualizar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                                   ParamFecha As DateTime,
           ParamAnulada As Boolean,
           ParamRecibido As Boolean,
           ParamPagado As Boolean,
           ParamIdproveedor As Integer,
           ParamMontototal As Decimal,
           ParamIdcompra As Integer,
           ParamDescripcion As String)


        mySqlCommand.CommandText &= "UPDATE `compra` SET " & _
        "`fecha`  = @fecha" & indiceParametro & ", " & _
        "`anulada`  = @anulada" & indiceParametro & ", " & _
        "`recibido`  = @recibido" & indiceParametro & ", " & _
        "`pagado`  = @pagado" & indiceParametro & ", " & _
        "`idProveedor`  = @idProveedor" & indiceParametro & ", " & _
        "`montoTotal`  = @montoTotal" & indiceParametro & ", " & _
        "`Descripcion` = @Descripcion" & indiceParametro & " " & _
        " WHERE `idCompra` = @idCompra" & indiceParametro & ";" & _
        "  SET @idCompra = @idCompra" & indiceParametro & ";"

        mySqlCommand.Parameters.AddWithValue("@fecha" & indiceParametro, ParamFecha)
        mySqlCommand.Parameters.AddWithValue("@anulada" & indiceParametro, ParamAnulada)
        mySqlCommand.Parameters.AddWithValue("@recibido" & indiceParametro, ParamRecibido)
        mySqlCommand.Parameters.AddWithValue("@pagado" & indiceParametro, ParamPagado)
        mySqlCommand.Parameters.AddWithValue("@idProveedor" & indiceParametro, ParamIdproveedor)
        mySqlCommand.Parameters.AddWithValue("@montoTotal" & indiceParametro, ParamMontototal)
        mySqlCommand.Parameters.AddWithValue("@idCompra" & indiceParametro, ParamIdcompra)
        mySqlCommand.Parameters.AddWithValue("@Descripcion" & indiceParametro, ParamDescripcion)

        indiceParametro += 1
    End Sub

    Public Sub borrar(ByRef sqlcommand As MySqlCommand, ByRef indiceParametro As Integer,
    ParamidCompra As Integer)

        sqlcommand.CommandText &= "UPDATE `compra` SET IS_DELETED = 'Y' " & _
        " WHERE idCompra = @idCompra" & indiceParametro & ";"

        sqlcommand.Parameters.AddWithValue("@idCompra" & indiceParametro, ParamidCompra)

        indiceParametro += 1
    End Sub

    Private Function consulta() As String

        Dim query As String

        query = "SELECT " & _
        "`fecha`, " & _
        "`anulada`, " & _
        "`recibido`, " & _
        "`pagado`, " & _
        "`idProveedor`, " & _
        "`montoTotal`, " & _
        "`idCompra` ," & _
        "`Descripcion` " & _
        "FROM `compra`" & _
        " WHERE IS_DELETED = 'N' "

        Return query

    End Function
End Class