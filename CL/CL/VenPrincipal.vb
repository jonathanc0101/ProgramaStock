
Imports ObjetosDeNegocio

Public Class venPrincipal

    Private listadoObjetos As ObjetosDeNegocio.compras
    Private Configuracion As Configuracion.compras
    Private listaFiltrada As CustomSortableBindingList(Of ObjetosDeNegocio.compra)

    Sub New(ByRef ParamListado As ObjetosDeNegocio.compras, ByRef ParamCfg As Configuracion.compras)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        listadoObjetos = ParamListado
        Configuracion = ParamCfg
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub venPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Compras"
        RegistroToolStripMenuItem.Text = "Compra"

        ponerIconos()

        listaFiltrada = listadoObjetos.Lista
        CompraBindingSource.DataSource = listaFiltrada

        ponerConfiguracion()
    End Sub

#Region "Metodos"
    Private Sub buscar(paramGuardarEstado As Boolean)

        If paramGuardarEstado Then
            grilla.guardarConfiguracionGrilla()
        End If

        listaFiltrada = New CustomSortableBindingList(Of ObjetosDeNegocio.compra)

        If CustomTextBoxBuscador.Text = "" Then
            listaFiltrada.AddRange(listadoObjetos.Lista)
        Else
            listaFiltrada.AddRange(listadoObjetos.Lista.Where(Function(x) x.fecha.ToShortDateString.ToLower Like "*" & CustomTextBoxBuscador.Text.ToLower & "*" _
                                                                    Or x.idProveedor.ToString.ToLower Like "*" & CustomTextBoxBuscador.Text.ToLower & "*" _
                                                                    Or x.montoTotal.ToString.ToLower Like "*" & CustomTextBoxBuscador.Text.ToLower & "*" _
                                                                    ).ToList)


        End If

        CompraBindingSource.DataSource = listaFiltrada

        If paramGuardarEstado Then
            grilla.ponerConfiguracionGrilla()
        End If

    End Sub

    Private Sub nuevoRegistro()
        ComunicacionProcesos.compra.Nueva()
    End Sub

    Private Sub editarRegistro()

        If grilla.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In grilla.SelectedRows
                ComunicacionProcesos.compra.EditarPorID(row.Cells("idCompraDataGridViewTextBoxColumn").Value)
            Next
        End If

    End Sub

    Private Sub eliminarRegistro()
        If grilla.SelectedRows.Count > 0 Then
            Dim mensaje As String

            If grilla.SelectedRows.Count > 1 Then
                mensaje = "¿Desea eliminar los " & grilla.SelectedRows.Count.ToString & " registros?"
            Else
                mensaje = "¿Desea eliminar el registro con Cód.Compra: " & grilla.SelectedRows(0).Cells.Item("IdCompraDataGridViewTextBoxColumn").Value.ToString & "? "
            End If

            If MessageBox.Show(mensaje, "Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                For Each row As DataGridViewRow In grilla.SelectedRows
                    Try

                        listadoObjetos.eliminar(row.Cells("idCompraDataGridViewTextBoxColumn").Value)

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next

                grilla.ClearSelection()

                actualizar()
            End If
        End If
    End Sub

    Private Sub actualizar()

        Me.Cursor = Cursors.WaitCursor
        grilla.guardarConfiguracionGrilla()
        CompraBindingSource.DataSource = Nothing

        listadoObjetos.cargarLista()
        listaFiltrada = listadoObjetos.Lista

        CompraBindingSource.DataSource = listaFiltrada
        grilla.ponerConfiguracionGrilla()

        If CustomTextBoxBuscador.Text <> "" Then
            buscar(False)
        End If

        Me.Refresh()

        Me.Cursor = Cursors.Default
    End Sub

    Private Function obtenerID() As String
        Return "compra " & Me.grilla.CurrentRow.Cells("idCompraDataGridViewTextBoxColumn").Value
    End Function

    Private Sub guardarConfiguracion()
        Configuracion.guardar()
    End Sub

    Private Sub ponerConfiguracion()
        Configuracion.setearVentana(Me)
    End Sub
    Private Sub ponerIconos()
        NuevoToolStripMenuItem.Image = Iconos.My.Resources.nuevoIMG
        EditarToolStripMenuItem.Image = Iconos.My.Resources.editarIMG
        EliminarToolStripMenuItem.Image = Iconos.My.Resources.eliminarIMG

        ToolStripButton1.Image = Iconos.My.Resources.nuevoIMG
        ToolStripButton2.Image = Iconos.My.Resources.editarIMG
        ToolStripButton3.Image = Iconos.My.Resources.eliminarIMG

        NuevoToolStripMenuItem1.Image = Iconos.My.Resources.nuevoIMG
        EditarToolStripMenuItem1.Image = Iconos.My.Resources.editarIMG
        EliminarToolStripMenuItem1.Image = Iconos.My.Resources.eliminarIMG

        NuevoToolStripMenuItem2.Image = Iconos.My.Resources.nuevoIMG

        Me.Icon = Iconos.My.Resources.programa
    End Sub

#End Region


#Region "DragN'Drop"

    Private Sub grilla_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grilla.MouseDown

        Dim info As DataGridView.HitTestInfo = Me.grilla.HitTest(e.X, e.Y)

        If info.Type = DataGridViewHitTestType.Cell And e.Button = Windows.Forms.MouseButtons.Left Then

            If e.Clicks = 2 Then
                editarRegistro()
            Else
                If Not (Control.ModifierKeys = Keys.Shift Or Control.ModifierKeys = Keys.Control) And grilla.SelectedRows.Count <= 1 Then
                    Me.grilla.CurrentCell = grilla.Rows(info.RowIndex).Cells("idCompraDataGridViewTextBoxColumn")
                End If

                Me.grilla.DoDragDrop(obtenerID(), DragDropEffects.All)
            End If

        End If

    End Sub

#End Region

#Region "Eventos"

    Private Sub venPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CustomTextBoxButtonMovimientosRealizados_PreviewKeyDown_1(sender As Object, e As EventArgs) Handles CustomTextBoxBuscador.PreviewKeyDown
        Me.TimerBuscador.Stop()
        Me.TimerBuscador.Start()
    End Sub

    Private Sub CustomTextBoxBuscador_TextChanged(sender As Object, e As EventArgs) Handles CustomTextBoxBuscador.TextChanged
        TimerBuscador.Stop()
        TimerBuscador.Start()
    End Sub

    Private Sub TimerBuscador_Tick(sender As Object, e As EventArgs) Handles TimerBuscador.Tick
        buscar(True)
        TimerBuscador.Stop()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        nuevoRegistro()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        editarRegistro()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminarRegistro()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        nuevoRegistro()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        editarRegistro()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        eliminarRegistro()
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem2.Click
        nuevoRegistro()
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        nuevoRegistro()
    End Sub

    Private Sub EditarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem1.Click
        editarRegistro()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        eliminarRegistro()
    End Sub


    Private Sub CustomDataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles grilla.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            editarRegistro()
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        actualizar()
    End Sub

    Private Sub venPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        guardarConfiguracion()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

End Class