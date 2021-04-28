<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(venPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemImprimirPresupuesto = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewItems = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadSalidaProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorSalidaProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMovimientoSalienteProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsFondo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoSalienteProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmsFila = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomDecimalTextBoxMonto = New InterfazUsuario.CustomDecimalTextBox()
        Me.TextBoxCodigoVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxCobrado = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxEntregado = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBoxNombreEmpleado = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFondo.SuspendLayout()
        CType(Me.MovimientoSalienteProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFila.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(965, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemActualizar, Me.ToolStripMenuItemGuardar, Me.ToolStripSeparator2, Me.ToolStripMenuItemImprimirPresupuesto, Me.ToolStripSeparator6, Me.ToolStripMenuItemEmpleados, Me.ToolStripMenuItemProductos, Me.ToolStripSeparator5, Me.ToolStripMenuItemSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ToolStripMenuItemActualizar
        '
        Me.ToolStripMenuItemActualizar.Name = "ToolStripMenuItemActualizar"
        Me.ToolStripMenuItemActualizar.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ToolStripMenuItemActualizar.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItemActualizar.Text = "Actualizar"
        '
        'ToolStripMenuItemGuardar
        '
        Me.ToolStripMenuItemGuardar.Name = "ToolStripMenuItemGuardar"
        Me.ToolStripMenuItemGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.ToolStripMenuItemGuardar.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItemGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'ToolStripMenuItemImprimirPresupuesto
        '
        Me.ToolStripMenuItemImprimirPresupuesto.Enabled = False
        Me.ToolStripMenuItemImprimirPresupuesto.Name = "ToolStripMenuItemImprimirPresupuesto"
        Me.ToolStripMenuItemImprimirPresupuesto.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItemImprimirPresupuesto.Text = "Imprimir presupuesto"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(185, 6)
        '
        'ToolStripMenuItemEmpleados
        '
        Me.ToolStripMenuItemEmpleados.Name = "ToolStripMenuItemEmpleados"
        Me.ToolStripMenuItemEmpleados.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItemEmpleados.Text = "Empleados/as"
        '
        'ToolStripMenuItemProductos
        '
        Me.ToolStripMenuItemProductos.Name = "ToolStripMenuItemProductos"
        Me.ToolStripMenuItemProductos.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItemProductos.Text = "Productos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(185, 6)
        '
        'ToolStripMenuItemSalir
        '
        Me.ToolStripMenuItemSalir.Name = "ToolStripMenuItemSalir"
        Me.ToolStripMenuItemSalir.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItemSalir.Text = "Salir"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(965, 498)
        Me.TableLayoutPanel2.TabIndex = 28
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(819, 448)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 35)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 29)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 29)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 70)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(965, 378)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewItems)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(957, 352)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Items"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewItems
        '
        Me.DataGridViewItems.AllowUserToAddRows = False
        Me.DataGridViewItems.AllowUserToDeleteRows = False
        Me.DataGridViewItems.AllowUserToResizeRows = False
        Me.DataGridViewItems.AutoGenerateColumns = False
        Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.DescripcionProductoDataGridViewTextBoxColumn, Me.CantidadSalidaProductoDataGridViewTextBoxColumn, Me.ValorSalidaProductoDataGridViewTextBoxColumn, Me.IdMovimientoSalienteProductoDataGridViewTextBoxColumn, Me.IdVentaDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridViewItems.ContextMenuStrip = Me.cmsFondo
        Me.DataGridViewItems.DataSource = Me.MovimientoSalienteProductoBindingSource
        Me.DataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewItems.Location = New System.Drawing.Point(3, 28)
        Me.DataGridViewItems.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridViewItems.Name = "DataGridViewItems"
        Me.DataGridViewItems.ReadOnly = True
        Me.DataGridViewItems.RowHeadersVisible = False
        Me.DataGridViewItems.RowTemplate.ContextMenuStrip = Me.cmsFila
        Me.DataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewItems.Size = New System.Drawing.Size(951, 321)
        Me.DataGridViewItems.TabIndex = 3
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "Cód. Producto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionProductoDataGridViewTextBoxColumn
        '
        Me.DescripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "descripcionProducto"
        Me.DescripcionProductoDataGridViewTextBoxColumn.FillWeight = 130.0!
        Me.DescripcionProductoDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionProductoDataGridViewTextBoxColumn.Name = "DescripcionProductoDataGridViewTextBoxColumn"
        Me.DescripcionProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionProductoDataGridViewTextBoxColumn.Width = 150
        '
        'CantidadSalidaProductoDataGridViewTextBoxColumn
        '
        Me.CantidadSalidaProductoDataGridViewTextBoxColumn.DataPropertyName = "cantidadSalidaProducto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CantidadSalidaProductoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CantidadSalidaProductoDataGridViewTextBoxColumn.HeaderText = "Cant.U"
        Me.CantidadSalidaProductoDataGridViewTextBoxColumn.Name = "CantidadSalidaProductoDataGridViewTextBoxColumn"
        Me.CantidadSalidaProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorSalidaProductoDataGridViewTextBoxColumn
        '
        Me.ValorSalidaProductoDataGridViewTextBoxColumn.DataPropertyName = "valorSalidaProducto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.ValorSalidaProductoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ValorSalidaProductoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.ValorSalidaProductoDataGridViewTextBoxColumn.Name = "ValorSalidaProductoDataGridViewTextBoxColumn"
        Me.ValorSalidaProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdMovimientoSalienteProductoDataGridViewTextBoxColumn
        '
        Me.IdMovimientoSalienteProductoDataGridViewTextBoxColumn.DataPropertyName = "idMovimientoSalienteProducto"
        Me.IdMovimientoSalienteProductoDataGridViewTextBoxColumn.HeaderText = "idMovimientoSalienteProducto"
        Me.IdMovimientoSalienteProductoDataGridViewTextBoxColumn.Name = "IdMovimientoSalienteProductoDataGridViewTextBoxColumn"
        Me.IdMovimientoSalienteProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMovimientoSalienteProductoDataGridViewTextBoxColumn.Visible = False
        '
        'IdVentaDataGridViewTextBoxColumn
        '
        Me.IdVentaDataGridViewTextBoxColumn.DataPropertyName = "idVenta"
        Me.IdVentaDataGridViewTextBoxColumn.HeaderText = "idVenta"
        Me.IdVentaDataGridViewTextBoxColumn.Name = "IdVentaDataGridViewTextBoxColumn"
        Me.IdVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdVentaDataGridViewTextBoxColumn.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'cmsFondo
        '
        Me.cmsFondo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1})
        Me.cmsFondo.Name = "cmsFondo"
        Me.cmsFondo.Size = New System.Drawing.Size(110, 26)
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'MovimientoSalienteProductoBindingSource
        '
        Me.MovimientoSalienteProductoBindingSource.DataSource = GetType(ObjetosDeNegocio.movimientoSalienteProducto)
        '
        'cmsFila
        '
        Me.cmsFila.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.cmsFila.Name = "cmsFila"
        Me.cmsFila.Size = New System.Drawing.Size(118, 48)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNuevo, Me.ToolStripSeparator3, Me.ToolStripButtonEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(951, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonNuevo
        '
        Me.ToolStripButtonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNuevo.Image = CType(resources.GetObject("ToolStripButtonNuevo.Image"), System.Drawing.Image)
        Me.ToolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNuevo.Name = "ToolStripButtonNuevo"
        Me.ToolStripButtonNuevo.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonEliminar
        '
        Me.ToolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonEliminar.Image = CType(resources.GetObject("ToolStripButtonEliminar.Image"), System.Drawing.Image)
        Me.ToolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEliminar.Name = "ToolStripButtonEliminar"
        Me.ToolStripButtonEliminar.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonEliminar.Text = "Eliminar todo"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox5, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(965, 70)
        Me.TableLayoutPanel5.TabIndex = 31
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(320, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(645, 70)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 10
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.CustomDecimalTextBoxMonto, 7, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxCodigoVenta, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.CheckBoxCobrado, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 7, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 9, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.DateTimePickerFecha, 9, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.CheckBoxEntregado, 5, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 5, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 13)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 6
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(645, 57)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'CustomDecimalTextBoxMonto
        '
        Me.CustomDecimalTextBoxMonto.Dock = System.Windows.Forms.DockStyle.Left
        Me.CustomDecimalTextBoxMonto.Location = New System.Drawing.Point(274, 20)
        Me.CustomDecimalTextBoxMonto.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomDecimalTextBoxMonto.Name = "CustomDecimalTextBoxMonto"
        Me.CustomDecimalTextBoxMonto.ReadOnly = True
        Me.CustomDecimalTextBoxMonto.Size = New System.Drawing.Size(97, 20)
        Me.CustomDecimalTextBoxMonto.TabIndex = 3
        Me.CustomDecimalTextBoxMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxCodigoVenta
        '
        Me.TextBoxCodigoVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxCodigoVenta.Location = New System.Drawing.Point(20, 20)
        Me.TextBoxCodigoVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxCodigoVenta.MaxLength = 50
        Me.TextBoxCodigoVenta.Name = "TextBoxCodigoVenta"
        Me.TextBoxCodigoVenta.ReadOnly = True
        Me.TextBoxCodigoVenta.Size = New System.Drawing.Size(97, 20)
        Me.TextBoxCodigoVenta.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Cobrado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBoxCobrado
        '
        Me.CheckBoxCobrado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxCobrado.AutoSize = True
        Me.CheckBoxCobrado.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxCobrado.Location = New System.Drawing.Point(142, 20)
        Me.CheckBoxCobrado.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxCobrado.Name = "CheckBoxCobrado"
        Me.CheckBoxCobrado.Size = New System.Drawing.Size(48, 20)
        Me.CheckBoxCobrado.TabIndex = 2
        Me.CheckBoxCobrado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Código de venta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Monto total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Fecha de pago"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(381, 20)
        Me.DateTimePickerFecha.Margin = New System.Windows.Forms.Padding(0)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePickerFecha.TabIndex = 4
        '
        'CheckBoxEntregado
        '
        Me.CheckBoxEntregado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxEntregado.AutoSize = True
        Me.CheckBoxEntregado.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxEntregado.Location = New System.Drawing.Point(200, 20)
        Me.CheckBoxEntregado.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxEntregado.Name = "CheckBoxEntregado"
        Me.CheckBoxEntregado.Size = New System.Drawing.Size(66, 20)
        Me.CheckBoxEntregado.TabIndex = 35
        Me.CheckBoxEntregado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Entregado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Size = New System.Drawing.Size(320, 70)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vendedor/a"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxCodigoEmpleado, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxNombreEmpleado, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 13)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(320, 57)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TextBoxCodigoEmpleado
        '
        Me.TextBoxCodigoEmpleado.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxCodigoEmpleado.Location = New System.Drawing.Point(252, 20)
        Me.TextBoxCodigoEmpleado.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxCodigoEmpleado.MaxLength = 50
        Me.TextBoxCodigoEmpleado.Name = "TextBoxCodigoEmpleado"
        Me.TextBoxCodigoEmpleado.ReadOnly = True
        Me.TextBoxCodigoEmpleado.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxCodigoEmpleado.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 3)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nombre"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(252, 3)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Código"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxNombreEmpleado
        '
        Me.ComboBoxNombreEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNombreEmpleado.FormattingEnabled = True
        Me.ComboBoxNombreEmpleado.Location = New System.Drawing.Point(20, 20)
        Me.ComboBoxNombreEmpleado.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxNombreEmpleado.Name = "ComboBoxNombreEmpleado"
        Me.ComboBoxNombreEmpleado.Size = New System.Drawing.Size(221, 21)
        Me.ComboBoxNombreEmpleado.TabIndex = 37
        '
        'venPrincipal
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 522)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "venPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFondo.ResumeLayout(False)
        CType(Me.MovimientoSalienteProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFila.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents MovimientoSalienteProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripMenuItemGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemImprimirPresupuesto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsFila As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFondo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewItems As System.Windows.Forms.DataGridView
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadSalidaProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorSalidaProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdMovimientoSalienteProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CustomDecimalTextBoxMonto As InterfazUsuario.CustomDecimalTextBox
    Friend WithEvents TextBoxCodigoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxCobrado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxEntregado As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBoxCodigoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNombreEmpleado As System.Windows.Forms.ComboBox
End Class
