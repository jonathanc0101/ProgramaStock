Imports ObjetosDeNegocio

Public Class venGuardando

    Private registro As venta
    Property Configuracion As configuracion.venta

    Property Guardado As Boolean = False

    Public Sub New(ByRef ParamRegistro As venta, paramConfiguracion As configuracion.venta)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        registro = ParamRegistro
        Configuracion = paramConfiguracion

    End Sub

    Private Sub venGuardando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Iconos.My.Resources.Programa

    End Sub

    Private Sub VenGuardar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Refresh()

        Try
            registro.guardar()

            Guardado = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally
            Me.Close()
        End Try
    End Sub
End Class



