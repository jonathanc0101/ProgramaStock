
Imports MySql.Data.MySqlClient
Public Class BDempleado

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
        mySqlCommand.CommandText = consulta() & " AND idEmpleado = @id"
        mySqlCommand.Parameters.AddWithValue("@id", paramId)

        Return bd.obtenerDatos(mySqlCommand)
    End Function

    Public Sub agregar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                ParamNombre As String)


        mySqlCommand.CommandText &= "INSERT INTO `empleado` (" & _
        "`nombre` " & _
        ") " & _
        "VALUES( " & _
        "@nombre" & indiceParametro & "); "
        mySqlCommand.Parameters.AddWithValue("@nombre" & indiceParametro, ParamNombre)


        indiceParametro += 1
    End Sub

    Public Sub actualizar(ByRef mySqlCommand As MySqlCommand, ByRef indiceParametro As Integer,
                                   ParamNombre As String,
           ParamIdempleado As Integer)


        mySqlCommand.CommandText &= "UPDATE `empleado` SET " & _
        "`nombre`  = @nombre" & indiceParametro & ", " & _
        "`idEmpleado`  = @idEmpleado" & indiceParametro & _
" WHERE `idEmpleado` = @idEmpleado" & indiceParametro & ";"

        mySqlCommand.Parameters.AddWithValue("@nombre" & indiceParametro, ParamNombre)
        mySqlCommand.Parameters.AddWithValue("@idEmpleado" & indiceParametro, ParamIdempleado)


        indiceParametro += 1
    End Sub

    Public Sub borrar(ByRef sqlcommand As MySqlCommand, ByRef indiceParametro As Integer,
    ParamidEmpleado As Integer)

        sqlcommand.CommandText &= "UPDATE `empleado` SET IS_DELETED = 'Y' " & _
        " WHERE idEmpleado = @idEmpleado" & indiceParametro & ";"

        sqlcommand.Parameters.AddWithValue("@idEmpleado" & indiceParametro, ParamIdempleado)

        indiceParametro += 1
    End Sub

    Private Function consulta() As String

        Dim query As String

        query = "SELECT " & _
        "`nombre`, " & _
        "`idEmpleado` " & _
        "FROM `empleado`" & _
        " WHERE IS_DELETED = 'N' "

        Return query

    End Function
End Class