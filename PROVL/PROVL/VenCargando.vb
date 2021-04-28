Public Class venCargando

    Private Sub venCargando_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = Iconos.My.Resources.programa
    End Sub

    Private Sub venCargando_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Refresh()

        Try
            Dim cfg As New Configuracion.proveedores
            Dim listado As New ObjetosDeNegocio.proveedores(cfg.Servidor, cfg.BD, cfg.Usuario, cfg.pass)

            listado.cargarLista()

            Dim venPrincipal As New venPrincipal(listado, cfg)
            venPrincipal.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Close()
        End Try

    End Sub
End Class
