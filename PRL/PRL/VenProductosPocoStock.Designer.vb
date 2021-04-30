<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VenProductosPocoStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VenProductosPocoStock))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDosProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleUnoProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadUnidadesFaltantesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaVacia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFechaActual = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidadProductosConPocoStock = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(979, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarToolStripMenuItem, Me.GenerarPDFToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'GenerarPDFToolStripMenuItem
        '
        Me.GenerarPDFToolStripMenuItem.Enabled = False
        Me.GenerarPDFToolStripMenuItem.Name = "GenerarPDFToolStripMenuItem"
        Me.GenerarPDFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GenerarPDFToolStripMenuItem.Text = "Generar PDF"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeyDisplayString = "Esc"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(979, 725)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.DescripcionProductoDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.UnidadProductoDataGridViewTextBoxColumn, Me.DetalleDosProductoDataGridViewTextBoxColumn, Me.DetalleUnoProductoDataGridViewTextBoxColumn, Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn, Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn, Me.CantidadUnidadesFaltantesDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.columnaVacia})
        Me.DataGridView1.DataSource = Me.ProductoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(973, 670)
        Me.DataGridView1.TabIndex = 0
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
        'DetalleDosProductoDataGridViewTextBoxColumn
        '
        Me.DetalleDosProductoDataGridViewTextBoxColumn.DataPropertyName = "detalleDosProducto"
        Me.DetalleDosProductoDataGridViewTextBoxColumn.HeaderText = "Detalle 2"
        Me.DetalleDosProductoDataGridViewTextBoxColumn.Name = "DetalleDosProductoDataGridViewTextBoxColumn"
        Me.DetalleDosProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetalleUnoProductoDataGridViewTextBoxColumn
        '
        Me.DetalleUnoProductoDataGridViewTextBoxColumn.DataPropertyName = "detalleUnoProducto"
        Me.DetalleUnoProductoDataGridViewTextBoxColumn.HeaderText = "Detalle 1"
        Me.DetalleUnoProductoDataGridViewTextBoxColumn.Name = "DetalleUnoProductoDataGridViewTextBoxColumn"
        Me.DetalleUnoProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadUnidadesEnStockDataGridViewTextBoxColumn
        '
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.DataPropertyName = "cantidadUnidadesEnStock"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.HeaderText = "Stock actual"
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.Name = "CantidadUnidadesEnStockDataGridViewTextBoxColumn"
        Me.CantidadUnidadesEnStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn
        '
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.DataPropertyName = "cantidadUnidadesMinimasEnStock"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.HeaderText = "Stock minimo"
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.Name = "CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn"
        Me.CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadUnidadesFaltantesDataGridViewTextBoxColumn
        '
        Me.CantidadUnidadesFaltantesDataGridViewTextBoxColumn.DataPropertyName = "cantidadUnidadesFaltantes"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.CantidadUnidadesFaltantesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CantidadUnidadesFaltantesDataGridViewTextBoxColumn.HeaderText = "Stock faltante para mínimo"
        Me.CantidadUnidadesFaltantesDataGridViewTextBoxColumn.Name = "CantidadUnidadesFaltantesDataGridViewTextBoxColumn"
        Me.CantidadUnidadesFaltantesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio de venta"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'columnaVacia
        '
        Me.columnaVacia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.columnaVacia.HeaderText = ""
        Me.columnaVacia.Name = "columnaVacia"
        Me.columnaVacia.ReadOnly = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataSource = GetType(ObjetosDeNegocio.producto)
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxFechaActual, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxCantidadProductosConPocoStock, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(973, 43)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad de productos con poco stock"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxFechaActual
        '
        Me.TextBoxFechaActual.Location = New System.Drawing.Point(0, 20)
        Me.TextBoxFechaActual.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxFechaActual.Name = "TextBoxFechaActual"
        Me.TextBoxFechaActual.ReadOnly = True
        Me.TextBoxFechaActual.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFechaActual.TabIndex = 1
        Me.TextBoxFechaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxCantidadProductosConPocoStock
        '
        Me.TextBoxCantidadProductosConPocoStock.Location = New System.Drawing.Point(125, 20)
        Me.TextBoxCantidadProductosConPocoStock.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxCantidadProductosConPocoStock.Name = "TextBoxCantidadProductosConPocoStock"
        Me.TextBoxCantidadProductosConPocoStock.ReadOnly = True
        Me.TextBoxCantidadProductosConPocoStock.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCantidadProductosConPocoStock.TabIndex = 3
        Me.TextBoxCantidadProductosConPocoStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'VenProductosPocoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 749)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(600, 726)
        Me.Name = "VenProductosPocoStock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleDosProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleUnoProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadUnidadesEnStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadUnidadesMinimasEnStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadUnidadesFaltantesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnaVacia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFechaActual As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCantidadProductosConPocoStock As System.Windows.Forms.TextBox
End Class
