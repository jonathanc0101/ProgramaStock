
Public Class Guardador

    Property BD As accesoBD.BD
    Property mySqlCommand As MySql.Data.MySqlClient.MySqlCommand
    Property indiceParametro As Integer


    Private Servidor As String
    Private NombreBD As String
    Private Usuario As String
    Private Contrasenia As String

    Sub New(parServidor As String, parBD As String, parUsuario As String, parContrasenia As String)

        Servidor = parServidor
        NombreBD = parBD
        Usuario = parUsuario
        Contrasenia = parContrasenia

        BD = New AccesoBD.BD(Servidor, NombreBD, Usuario, Contrasenia)

        mySqlCommand = New MySql.Data.MySqlClient.MySqlCommand
        mySqlCommand.CommandType = CommandType.Text

        mySqlCommand.CommandText = "START TRANSACTION;  
        indiceParametro = 0
    End Sub

    Public Sub guardar()
        Try
            mySqlCommand.CommandText += " COMMIT;"
            BD.ejecutarNonQuery(mySqlCommand)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try



    End Sub
End Class
