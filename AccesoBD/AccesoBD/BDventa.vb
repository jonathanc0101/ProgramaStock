
Imports MySql.Data.MySqlClient
Public Class BDventa

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
        mySqlCommand.CommandText = consulta() & " AND idVenta = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Function obtenerPorEmpleado(paramId As Integer) As DataTable

        Dim mySqlCommand As New MySqlCommand
        mySqlCommand.CommandType = CommandType.Text
        mySqlCommand.CommandText = consulta() & " AND idEmpleado = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Sub agregar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                ParamAnulada As Boolean,
        ParamFecha As DateTime,
        ParamEntregado As Boolean,
        ParamCobrado As Boolean,
        ParamMontototal As Decimal,
        ParamIdempleado As Integer)


        mySqlCommand.CommandText &= "INSERT INTO `venta` (" & _
        "`anulada`, " & _
        "`fecha`, " & _
        "`entregado`, " & _
        "`cobrado`, " & _
        "`montoTotal`, " & _
        "`idEmpleado` " & _
        ") " & _
        "VALUES( " & _
        "@anulada" & indiceParametro & ", " & _
        "@fecha" & indiceParametro & ", " & _
        "@entregado" & indiceParametro & ", " & _
        "@cobrado" & indiceParametro & ", " & _
        "@montoTotal" & indiceParametro & ", " & _
        "@idEmpleado" & indiceParametro & "); " & _
        " SET @idVenta = last_insert_id(); "
        mySqlCommand.Parameters.AddWithValue("@anulada" & indiceParametro, ParamAnulada)
        mySqlCommand.Parameters.AddWithValue("@fecha" & indiceParametro, ParamFecha)
        mySqlCommand.Parameters.AddWithValue("@entregado" & indiceParametro, ParamEntregado)
        mySqlCommand.Parameters.AddWithValue("@cobrado" & indiceParametro, ParamCobrado)
        mySqlCommand.Parameters.AddWithValue("@montoTotal" & indiceParametro, ParamMontototal)
        mySqlCommand.Parameters.AddWithValue("@idEmpleado" & indiceParametro, ParamIdempleado)


        indiceParametro += 1
    End Sub

    Public Sub actualizar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                                   ParamAnulada As Boolean,
           ParamFecha As DateTime,
           ParamEntregado As Boolean,
           ParamCobrado As Boolean,
           ParamMontototal As Decimal,
           ParamIdempleado As Integer,
           ParamIdventa As Integer)


        mySqlCommand.CommandText &= "UPDATE `venta` SET " & _
        "`anulada`  = @anulada" & indiceParametro & ", " & _
        "`fecha`  = @fecha" & indiceParametro & ", " & _
        "`entregado`  = @entregado" & indiceParametro & ", " & _
        "`cobrado`  = @cobrado" & indiceParametro & ", " & _
        "`montoTotal`  = @montoTotal" & indiceParametro & ", " & _
        "`idEmpleado`  = @idEmpleado" & indiceParametro & " " & _
        " WHERE `idVenta` = @idVenta" & indiceParametro & ";"

        mySqlCommand.Parameters.AddWithValue("@anulada" & indiceParametro, ParamAnulada)
        mySqlCommand.Parameters.AddWithValue("@fecha" & indiceParametro, ParamFecha)
        mySqlCommand.Parameters.AddWithValue("@entregado" & indiceParametro, ParamEntregado)
        mySqlCommand.Parameters.AddWithValue("@cobrado" & indiceParametro, ParamCobrado)
        mySqlCommand.Parameters.AddWithValue("@montoTotal" & indiceParametro, ParamMontototal)
        mySqlCommand.Parameters.AddWithValue("@idEmpleado" & indiceParametro, ParamIdempleado)
        mySqlCommand.Parameters.AddWithValue("@idVenta" & indiceParametro, ParamIdventa)


        indiceParametro += 1
    End Sub

    Public Sub borrar(ByRef sqlcommand As MySqlCommand, ByRef indiceParametro As Integer,
    ParamidVenta As Integer)

        sqlcommand.CommandText &= "UPDATE `venta` SET IS_DELETED = 'Y' " & _
        " WHERE idVenta = @idVenta" & indiceParametro & ";"

        sqlcommand.Parameters.AddWithValue("@idVenta" & indiceParametro, ParamIdventa)

        indiceParametro += 1
    End Sub

    Private Function consulta() As String

        Dim query As String

        query = "SELECT " & _
        "`anulada`, " & _
        "`fecha`, " & _
        "`entregado`, " & _
        "`cobrado`, " & _
        "`montoTotal`, " & _
        "`idEmpleado`, " & _
        "`idVenta` " & _
        "FROM `venta`" & _
        " WHERE IS_DELETED = 'N' "

        Return query

    End Function
End Class

