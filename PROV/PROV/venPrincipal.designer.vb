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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(venPrincipal))
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxdetalleProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNumeroDeTelefono = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewCompras = New System.Windows.Forms.DataGridView()
        Me.IdCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecibidoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PagadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AnuladaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosEntrantesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1036, 496)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(887, 464)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 435.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxIdProveedor, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxNombre, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxdetalleProveedor, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxEmail, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxNumeroDeTelefono, 2, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1030, 86)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TextBoxIdProveedor
        '
        Me.TextBoxIdProveedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxIdProveedor.Location = New System.Drawing.Point(268, 20)
        Me.TextBoxIdProveedor.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxIdProveedor.MaxLength = 50
        Me.TextBoxIdProveedor.Name = "TextBoxIdProveedor"
        Me.TextBoxIdProveedor.ReadOnly = True
        Me.TextBoxIdProveedor.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxIdProveedor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 3)
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
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Detalle"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxdetalleProveedor
        '
        Me.TextBoxdetalleProveedor.Location = New System.Drawing.Point(355, 20)
        Me.TextBoxdetalleProveedor.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxdetalleProveedor.MaxLength = 90
        Me.TextBoxdetalleProveedor.Name = "TextBoxdetalleProveedor"
        Me.TextBoxdetalleProveedor.Size = New System.Drawing.Size(435, 20)
        Me.TextBoxdetalleProveedor.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Correo electrónico"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(20, 60)
        Me.TextBoxEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxEmail.MaxLength = 60
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(239, 20)
        Me.TextBoxEmail.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Teléfono"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxNumeroDeTelefono
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.TextBoxNumeroDeTelefono, 2)
        Me.TextBoxNumeroDeTelefono.Location = New System.Drawing.Point(268, 60)
        Me.TextBoxNumeroDeTelefono.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxNumeroDeTelefono.MaxLength = 45
        Me.TextBoxNumeroDeTelefono.Name = "TextBoxNumeroDeTelefono"
        Me.TextBoxNumeroDeTelefono.Size = New System.Drawing.Size(288, 20)
        Me.TextBoxNumeroDeTelefono.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 95)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1030, 363)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewCompras)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1022, 337)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Compras"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewCompras
        '
        Me.DataGridViewCompras.AllowUserToAddRows = False
        Me.DataGridViewCompras.AllowUserToDeleteRows = False
        Me.DataGridViewCompras.AllowUserToOrderColumns = True
        Me.DataGridViewCompras.AutoGenerateColumns = False
        Me.DataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCompraDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn, Me.RecibidoDataGridViewCheckBoxColumn, Me.PagadoDataGridViewCheckBoxColumn, Me.AnuladaDataGridViewCheckBoxColumn, Me.IdProveedorDataGridViewTextBoxColumn, Me.MovimientosEntrantesDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridViewCompras.DataSource = Me.CompraBindingSource
        Me.DataGridViewCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewCompras.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewCompras.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridViewCompras.Name = "DataGridViewCompras"
        Me.DataGridViewCompras.ReadOnly = True
        Me.DataGridViewCompras.RowHeadersVisible = False
        Me.DataGridViewCompras.Size = New System.Drawing.Size(1016, 331)
        Me.DataGridViewCompras.TabIndex = 0
        '
        'IdCompraDataGridViewTextBoxColumn
        '
        Me.IdCompraDataGridViewTextBoxColumn.DataPropertyName = "idCompra"
        Me.IdCompraDataGridViewTextBoxColumn.HeaderText = "Cód.Compra"
        Me.IdCompraDataGridViewTextBoxColumn.Name = "IdCompraDataGridViewTextBoxColumn"
        Me.IdCompraDataGridViewTextBoxColumn.ReadOnly = True
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.MontoTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        Me.MontoTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecibidoDataGridViewCheckBoxColumn
        '
        Me.RecibidoDataGridViewCheckBoxColumn.DataPropertyName = "recibido"
        Me.RecibidoDataGridViewCheckBoxColumn.HeaderText = "recibida"
        Me.RecibidoDataGridViewCheckBoxColumn.Name = "RecibidoDataGridViewCheckBoxColumn"
        Me.RecibidoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PagadoDataGridViewCheckBoxColumn
        '
        Me.PagadoDataGridViewCheckBoxColumn.DataPropertyName = "pagado"
        Me.PagadoDataGridViewCheckBoxColumn.HeaderText = "pagada"
        Me.PagadoDataGridViewCheckBoxColumn.Name = "PagadoDataGridViewCheckBoxColumn"
        Me.PagadoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'AnuladaDataGridViewCheckBoxColumn
        '
        Me.AnuladaDataGridViewCheckBoxColumn.DataPropertyName = "anulada"
        Me.AnuladaDataGridViewCheckBoxColumn.HeaderText = "anulada"
        Me.AnuladaDataGridViewCheckBoxColumn.Name = "AnuladaDataGridViewCheckBoxColumn"
        Me.AnuladaDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'MovimientosEntrantesDataGridViewTextBoxColumn
        '
        Me.MovimientosEntrantesDataGridViewTextBoxColumn.DataPropertyName = "movimientosEntrantes"
        Me.MovimientosEntrantesDataGridViewTextBoxColumn.HeaderText = "movimientosEntrantes"
        Me.MovimientosEntrantesDataGridViewTextBoxColumn.Name = "MovimientosEntrantesDataGridViewTextBoxColumn"
        Me.MovimientosEntrantesDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovimientosEntrantesDataGridViewTextBoxColumn.Visible = False
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'CompraBindingSource
        '
        Me.CompraBindingSource.DataSource = GetType(ObjetosDeNegocio.compra)
        '
        'venPrincipal
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 496)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "venPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumeroDeTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxdetalleProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewCompras As System.Windows.Forms.DataGridView
    Friend WithEvents CompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecibidoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PagadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AnuladaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientosEntrantesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
