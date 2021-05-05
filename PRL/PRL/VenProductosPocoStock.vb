Public Class VenProductosPocoStock
    Private listadoObjetos As ObjetosDeNegocio.productos
    Public Sub New(ByVal ParamListado As ObjetosDeNegocio.productos)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        listadoObjetos = ParamListado

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub venPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Productos con stock menor al mínimo"

        listadoObjetos.cargarListaProductosBajosDeStock()
        ProductoBindingSource.DataSource = listadoObjetos.Lista

        ponerDatosEnPantalla()
    End Sub

    Private Sub ponerDatosEnPantalla()
        TextBoxFechaActual.Text = Today
        TextBoxCantidadProductosConPocoStock.Text = listadoObjetos.Lista.Count
    End Sub
    Private Sub actualizar()
        Me.Cursor = Cursors.WaitCursor

        listadoObjetos.cargarListaProductosBajosDeStock()
        ProductoBindingSource.DataSource = listadoObjetos.Lista

        ponerDatosEnPantalla()

        Me.Refresh()

        Me.Cursor = Cursors.Default


    End Sub


#Region "eventos"
    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        actualizar()
    End Sub

    Private Sub GenerarPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarPDFToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub VenProductosPocoStock_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#End Region

End Class