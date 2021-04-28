Imports MySql.Data.MySqlClient
Public Class BD
    Private CnnStr As String

    Public Sub New(direccionMiServer As String, miBD As String, miUsuario As String, miContrasenia As String)
        CnnStr = "Server=" & direccionMiServer & ";" _
            & "Database=" & miBD & ";" _
            & "Uid=" & miUsuario & ";" _
            & "Pwd=" & miContrasenia & ";" _
            & ";Allow User Variables=True;"

    End Sub

    Public Function EjecutarScalar(query As String)
        Try
            Dim conexion As New MySqlConnection(Me.CnnStr)
            Dim comando As New MySqlCommand
            conexion.Open()
            comando = New MySqlCommand(query)
            comando.Connection = conexion
            comando.CommandTimeout = 300
            Dim resultado As String
            resultado = comando.ExecuteScalar()
            conexion.Close()

            Return resultado
        Catch ex As Exception
            Throw New Exception("Error al ejecutar método EjecutarScalar." & vbCrLf & ex.Message)
        End Try
    End Function
    Public Function obtenerDatos(query As String) As DataTable

        Dim DT As New DataTable

        Try
            Using cnn As New MySqlConnection(Me.CnnStr)
                cnn.Open()
                Using dad As New MySqlDataAdapter(query, cnn)
                    dad.Fill(DT)
                End Using
                cnn.Close()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al ejecutar método ObtenerDatos." & vbCrLf & ex.Message)
        End Try

        Return DT

    End Function

    Public Sub ejecutarNonQuery(comando As MySqlCommand)
        Dim conexion As New MySqlConnection(Me.CnnStr)
        comando.Connection = conexion
        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New Exception("Error al ejecutar método ejecutarNonQuery." & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub ejecutarNonQuery(query As String)
        Dim conexion As New MySqlConnection(Me.CnnStr)
        Dim comando As New MySqlCommand
        comando.Connection = conexion
        comando.CommandText = query
        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New Exception("Error al ejecutar método ejecutarNonQuery." & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Function obtenerDatos(comando As MySqlCommand) As DataTable
        Dim dt As New DataTable
        Dim conexion As New MySqlConnection(Me.CnnStr)
        comando.Connection = conexion
        comando.CommandTimeout = 300
        Dim adapter As New MySqlDataAdapter(comando)
        Try
            conexion.Open()
            adapter.Fill(dt)
        Catch ex As Exception
            Throw New Exception("Error al ejecutar método obtenerDatos." & vbCrLf & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return dt
    End Function

    Public Function obtenerUltimoIDInsertado() As Integer
        Return obtenerDatos("SELECT last_insert_id()").Rows(0).Item(0)
    End Function
End Class
