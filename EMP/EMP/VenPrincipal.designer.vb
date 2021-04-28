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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(venPrincipal))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.IdVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CobradoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AnuladaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdEmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStripVentas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripVentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(535, 389)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.15385!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.84615!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(684, 421)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxCodigo, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxNombre, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(678, 47)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxCodigo.Location = New System.Drawing.Point(228, 20)
        Me.TextBoxCodigo.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxCodigo.MaxLength = 50
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.ReadOnly = True
        Me.TextBoxCodigo.Size = New System.Drawing.Size(166, 20)
        Me.TextBoxCodigo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxNombre.Location = New System.Drawing.Point(20, 20)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxNombre.MaxLength = 45
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(195, 20)
        Me.TextBoxNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 61)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(684, 318)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewVentas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 292)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ventas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AllowUserToAddRows = False
        Me.DataGridViewVentas.AllowUserToDeleteRows = False
        Me.DataGridViewVentas.AllowUserToResizeRows = False
        Me.DataGridViewVentas.AutoGenerateColumns = False
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVentaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn, Me.EntregadoDataGridViewCheckBoxColumn, Me.CobradoDataGridViewCheckBoxColumn, Me.AnuladaDataGridViewCheckBoxColumn, Me.IdEmpleadoDataGridViewTextBoxColumn, Me.ItemsDataGridViewTextBoxColumn, Me.EmpleadoDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridViewVentas.DataSource = Me.VentaBindingSource
        Me.DataGridViewVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewVentas.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewVentas.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.ReadOnly = True
        Me.DataGridViewVentas.RowHeadersVisible = False
        Me.DataGridViewVentas.RowTemplate.ContextMenuStrip = Me.ContextMenuStripVentas
        Me.DataGridViewVentas.Size = New System.Drawing.Size(670, 286)
        Me.DataGridViewVentas.TabIndex = 0
        '
        'IdVentaDataGridViewTextBoxColumn
        '
        Me.IdVentaDataGridViewTextBoxColumn.DataPropertyName = "idVenta"
        Me.IdVentaDataGridViewTextBoxColumn.HeaderText = "Cód.Venta"
        Me.IdVentaDataGridViewTextBoxColumn.Name = "IdVentaDataGridViewTextBoxColumn"
        Me.IdVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoTotalDataGridViewTextBoxColumn
        '
        Me.MontoTotalDataGridViewTextBoxColumn.DataPropertyName = "montoTotal"
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        Me.MontoTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntregadoDataGridViewCheckBoxColumn
        '
        Me.EntregadoDataGridViewCheckBoxColumn.DataPropertyName = "entregado"
        Me.EntregadoDataGridViewCheckBoxColumn.HeaderText = "entregada"
        Me.EntregadoDataGridViewCheckBoxColumn.Name = "EntregadoDataGridViewCheckBoxColumn"
        Me.EntregadoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CobradoDataGridViewCheckBoxColumn
        '
        Me.CobradoDataGridViewCheckBoxColumn.DataPropertyName = "cobrado"
        Me.CobradoDataGridViewCheckBoxColumn.HeaderText = "cobrada"
        Me.CobradoDataGridViewCheckBoxColumn.Name = "CobradoDataGridViewCheckBoxColumn"
        Me.CobradoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'AnuladaDataGridViewCheckBoxColumn
        '
        Me.AnuladaDataGridViewCheckBoxColumn.DataPropertyName = "anulada"
        Me.AnuladaDataGridViewCheckBoxColumn.HeaderText = "anulada"
        Me.AnuladaDataGridViewCheckBoxColumn.Name = "AnuladaDataGridViewCheckBoxColumn"
        Me.AnuladaDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'IdEmpleadoDataGridViewTextBoxColumn
        '
        Me.IdEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado"
        Me.IdEmpleadoDataGridViewTextBoxColumn.Name = "IdEmpleadoDataGridViewTextBoxColumn"
        Me.IdEmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpleadoDataGridViewTextBoxColumn.Visible = False
        '
        'ItemsDataGridViewTextBoxColumn
        '
        Me.ItemsDataGridViewTextBoxColumn.DataPropertyName = "items"
        Me.ItemsDataGridViewTextBoxColumn.HeaderText = "items"
        Me.ItemsDataGridViewTextBoxColumn.Name = "ItemsDataGridViewTextBoxColumn"
        Me.ItemsDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemsDataGridViewTextBoxColumn.Visible = False
        '
        'EmpleadoDataGridViewTextBoxColumn
        '
        Me.EmpleadoDataGridViewTextBoxColumn.DataPropertyName = "empleado"
        Me.EmpleadoDataGridViewTextBoxColumn.HeaderText = "empleado"
        Me.EmpleadoDataGridViewTextBoxColumn.Name = "EmpleadoDataGridViewTextBoxColumn"
        Me.EmpleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpleadoDataGridViewTextBoxColumn.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataSource = GetType(ObjetosDeNegocio.venta)
        '
        'ContextMenuStripVentas
        '
        Me.ContextMenuStripVentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem})
        Me.ContextMenuStripVentas.Name = "ContextMenuStripVentas"
        Me.ContextMenuStripVentas.Size = New System.Drawing.Size(101, 26)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'venPrincipal
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 421)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "venPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripVentas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBoxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewVentas As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStripVentas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendidoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntregadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CobradoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AnuladaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdEmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
End Class
