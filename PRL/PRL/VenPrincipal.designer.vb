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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(venPrincipal))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomTextBoxBuscador = New InterfazUsuario.CustomTextBoxButton()
        Me.grilla = New InterfazUsuario.CustomDataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleUnoProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDosProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsFondo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObjetosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmsFila = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerBuscador = New System.Windows.Forms.Timer(Me.components)
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFondo.SuspendLayout()
        CType(Me.ObjetosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFila.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.ToolTipText = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.ToolTipText = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.ToolTipText = "Eliminar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.CompraToolStripMenuItem, Me.VentaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeyDisplayString = "Esc"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ToolStripSeparator2, Me.EliminarToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.RegistroToolStripMenuItem.Text = "¨Producto"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.ShortcutKeyDisplayString = "Enter"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CustomTextBoxBuscador, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grilla, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 49)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 523)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'CustomTextBoxBuscador
        '
        Me.CustomTextBoxBuscador.BackColor = System.Drawing.SystemColors.Window
        Me.CustomTextBoxBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomTextBoxBuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CustomTextBoxBuscador.Dock = System.Windows.Forms.DockStyle.Left
        Me.CustomTextBoxBuscador.Location = New System.Drawing.Point(3, 3)
        Me.CustomTextBoxBuscador.Name = "CustomTextBoxBuscador"
        Me.CustomTextBoxBuscador.Size = New System.Drawing.Size(167, 24)
        Me.CustomTextBoxBuscador.TabIndex = 5
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AllowUserToResizeColumns = False
        Me.grilla.AllowUserToResizeRows = False
        Me.grilla.AutoGenerateColumns = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.DescripcionProductoDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.UnidadProductoDataGridViewTextBoxColumn, Me.DetalleUnoProductoDataGridViewTextBoxColumn, Me.DetalleDosProductoDataGridViewTextBoxColumn, Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn, Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.Column1})
        Me.grilla.ContextMenuStrip = Me.cmsFondo
        Me.grilla.DataSource = Me.ObjetosBindingSource
        Me.grilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grilla.FilasSeleccionadas = Nothing
        Me.grilla.FilasSeleccionadasPorID = Nothing
        Me.grilla.IndiceScroll = 0
        Me.grilla.Location = New System.Drawing.Point(3, 33)
        Me.grilla.Name = "grilla"
        Me.grilla.NombreColumnaOrdenada = Nothing
        Me.grilla.Orden = System.ComponentModel.ListSortDirection.Ascending
        Me.grilla.pintarCelda = False
        Me.grilla.ReadOnly = True
        Me.grilla.RowHeadersVisible = False
        Me.grilla.RowTemplate.ContextMenuStrip = Me.cmsFila
        Me.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla.Size = New System.Drawing.Size(788, 487)
        Me.grilla.TabIndex = 0
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Width = 70
        '
        'DescripcionProductoDataGridViewTextBoxColumn
        '
        Me.DescripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "descripcionProducto"
        Me.DescripcionProductoDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionProductoDataGridViewTextBoxColumn.Name = "DescripcionProductoDataGridViewTextBoxColumn"
        Me.DescripcionProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoría"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadProductoDataGridViewTextBoxColumn
        '
        Me.UnidadProductoDataGridViewTextBoxColumn.DataPropertyName = "unidadProducto"
        Me.UnidadProductoDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadProductoDataGridViewTextBoxColumn.Name = "UnidadProductoDataGridViewTextBoxColumn"
        Me.UnidadProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetalleUnoProductoDataGridViewTextBoxColumn
        '
        Me.DetalleUnoProductoDataGridViewTextBoxColumn.DataPropertyName = "detalleUnoProducto"
        Me.DetalleUnoProductoDataGridViewTextBoxColumn.HeaderText = "Detalle 1"
        Me.DetalleUnoProductoDataGridViewTextBoxColumn.Name = "DetalleUnoProductoDataGridViewTextBoxColumn"
        Me.DetalleUnoProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetalleDosProductoDataGridViewTextBoxColumn
        '
        Me.DetalleDosProductoDataGridViewTextBoxColumn.DataPropertyName = "detalleDosProducto"
        Me.DetalleDosProductoDataGridViewTextBoxColumn.HeaderText = "Detalle 2"
        Me.DetalleDosProductoDataGridViewTextBoxColumn.Name = "DetalleDosProductoDataGridViewTextBoxColumn"
        Me.DetalleDosProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadUnidadesEnStockDataGridViewTextBoxColumn
        '
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.DataPropertyName = "cantidadUnidadesEnStock"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.HeaderText = "Stock actual"
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.Name = "CantidadUnidadesEnStockDataGridViewTextBoxColumn"
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn
        '
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.DataPropertyName = "cantidadUnidadesMinimasEnStock"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.HeaderText = "Stock mínimo"
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.Name = "CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn"
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precioUnitario"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio U."
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmsFondo
        '
        Me.cmsFondo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem2})
        Me.cmsFondo.Name = "cmsFondo"
        Me.cmsFondo.Size = New System.Drawing.Size(110, 26)
        '
        'NuevoToolStripMenuItem2
        '
        Me.NuevoToolStripMenuItem2.Name = "NuevoToolStripMenuItem2"
        Me.NuevoToolStripMenuItem2.Size = New System.Drawing.Size(109, 22)
        Me.NuevoToolStripMenuItem2.Text = "Nuevo"
        '
        'ObjetosBindingSource
        '
        Me.ObjetosBindingSource.DataSource = GetType(ObjetosDeNegocio.producto)
        '
        'cmsFila
        '
        Me.cmsFila.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.EditarToolStripMenuItem1, Me.ToolStripSeparator3, Me.EliminarToolStripMenuItem1})
        Me.cmsFila.Name = "ContextMenuStrip1"
        Me.cmsFila.Size = New System.Drawing.Size(118, 76)
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(114, 6)
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'TimerBuscador
        '
        Me.TimerBuscador.Interval = 400
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaCompraToolStripMenuItem})
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem1})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'NuevaCompraToolStripMenuItem
        '
        Me.NuevaCompraToolStripMenuItem.Name = "NuevaCompraToolStripMenuItem"
        Me.NuevaCompraToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaCompraToolStripMenuItem.Text = "Nueva"
        '
        'NuevaVentaToolStripMenuItem1
        '
        Me.NuevaVentaToolStripMenuItem1.Name = "NuevaVentaToolStripMenuItem1"
        Me.NuevaVentaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NuevaVentaToolStripMenuItem1.Text = "Nueva"
        '
        'venPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "venPrincipal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFondo.ResumeLayout(False)
        CType(Me.ObjetosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFila.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFila As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsFondo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents NuevoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerBuscador As System.Windows.Forms.Timer
    Friend WithEvents ObjetosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomTextBoxBuscador As InterfazUsuario.CustomTextBoxButton
    Friend WithEvents grilla As InterfazUsuario.CustomDataGridView
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleUnoProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDosProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadUnidadesEnStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
