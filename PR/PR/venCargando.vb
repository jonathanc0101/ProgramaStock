
Imports ObjetosDeNegocio
Public Class venCargando

    Private Sub venCargando_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = Iconos.My.Resources.programa

    End Sub

    Private Sub venCargando_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Me.Refresh()

        Try

            Dim cfg As New Configuracion.producto
            Dim registro As New producto(cfg.Servidor, cfg.BD, cfg.Usuario, cfg.pass)

            If My.Application.CommandLineArgs.Count > 0 Then

                If My.Application.CommandLineArgs(0) = "abrirPorID" Then

                    registro.cargarCompletoPorId(CInt(My.Application.CommandLineArgs(1)))
                    comprobarRegistro(registro)
                End If
            End If

            Dim principal As New venPrincipal(registro, cfg)
            principal.Show()

        Catch ex As Exception
            MessageBox.Show("Error al obtener los datos." & vbCrLf & "Compruebe su conexión e intente nuevamente." & vbCrLf & _
                                        "La aplicación se cerrará." & vbCrLf & ex.Message, " Producto ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Close()
        End Try

    End Sub


    Private Sub comprobarRegistro(ByRef registro As producto)

        If registro.idProducto = 0 Then
            MessageBox.Show("No existe Producto, la aplicación se cerrará.", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub
End Class
