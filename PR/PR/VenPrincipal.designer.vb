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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(venPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxUnidadProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.TextBoxDetalleDosProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxDetalleUnoProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomDecimalTextBoxStockActual = New InterfazUsuario.CustomDecimalTextBox()
        Me.CustomDecimalTextBoxStockMinimo = New InterfazUsuario.CustomDecimalTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CustomDecimalTextBoxPrecioVenta = New InterfazUsuario.CustomDecimalTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(559, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.ToolStripSeparator4, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(155, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(559, 166)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 119)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(559, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(393, 8)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 39)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 8)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 8)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(559, 119)
        Me.FlowLayoutPanel1.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 110)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxUnidadProducto, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxCategoria, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDetalleDosProducto, 4, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxCodigo, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDescripcionProducto, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDetalleUnoProducto, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 4, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 2, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 8
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(344, 91)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TextBoxUnidadProducto
        '
        Me.TextBoxUnidadProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxUnidadProducto.Location = New System.Drawing.Point(230, 20)
        Me.TextBoxUnidadProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxUnidadProducto.MaxLength = 45
        Me.TextBoxUnidadProducto.Name = "TextBoxUnidadProducto"
        Me.TextBoxUnidadProducto.Size = New System.Drawing.Size(101, 20)
        Me.TextBoxUnidadProducto.TabIndex = 3
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxCategoria.Location = New System.Drawing.Point(122, 20)
        Me.TextBoxCategoria.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxCategoria.MaxLength = 45
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxCategoria.TabIndex = 2
        '
        'TextBoxDetalleDosProducto
        '
        Me.TextBoxDetalleDosProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxDetalleDosProducto.Location = New System.Drawing.Point(230, 60)
        Me.TextBoxDetalleDosProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxDetalleDosProducto.MaxLength = 45
        Me.TextBoxDetalleDosProducto.Name = "TextBoxDetalleDosProducto"
        Me.TextBoxDetalleDosProducto.Size = New System.Drawing.Size(101, 20)
        Me.TextBoxDetalleDosProducto.TabIndex = 5
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxCodigo.Location = New System.Drawing.Point(0, 60)
        Me.TextBoxCodigo.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxCodigo.MaxLength = 50
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.ReadOnly = True
        Me.TextBoxCodigo.Size = New System.Drawing.Size(97, 20)
        Me.TextBoxCodigo.TabIndex = 1000
        '
        'TextBoxDescripcionProducto
        '
        Me.TextBoxDescripcionProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxDescripcionProducto.Location = New System.Drawing.Point(0, 20)
        Me.TextBoxDescripcionProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxDescripcionProducto.MaxLength = 135
        Me.TextBoxDescripcionProducto.Name = "TextBoxDescripcionProducto"
        Me.TextBoxDescripcionProducto.Size = New System.Drawing.Size(101, 20)
        Me.TextBoxDescripcionProducto.TabIndex = 1
        '
        'TextBoxDetalleUnoProducto
        '
        Me.TextBoxDetalleUnoProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxDetalleUnoProducto.Location = New System.Drawing.Point(122, 60)
        Me.TextBoxDetalleUnoProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxDetalleUnoProducto.MaxLength = 45
        Me.TextBoxDetalleUnoProducto.Name = "TextBoxDetalleUnoProducto"
        Me.TextBoxDetalleUnoProducto.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxDetalleUnoProducto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Descripción"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 3)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Unidad"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Categoría"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Detalle dos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Detalle uno"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(359, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(100, 110)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stock"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.42553!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.574468!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.CustomDecimalTextBoxStockActual, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.CustomDecimalTextBoxStockMinimo, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(94, 91)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'CustomDecimalTextBoxStockActual
        '
        Me.CustomDecimalTextBoxStockActual.Dock = System.Windows.Forms.DockStyle.Left
        Me.CustomDecimalTextBoxStockActual.Location = New System.Drawing.Point(0, 20)
        Me.CustomDecimalTextBoxStockActual.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomDecimalTextBoxStockActual.Name = "CustomDecimalTextBoxStockActual"
        Me.CustomDecimalTextBoxStockActual.Size = New System.Drawing.Size(75, 20)
        Me.CustomDecimalTextBoxStockActual.TabIndex = 1
        Me.CustomDecimalTextBoxStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CustomDecimalTextBoxStockMinimo
        '
        Me.CustomDecimalTextBoxStockMinimo.Dock = System.Windows.Forms.DockStyle.Left
        Me.CustomDecimalTextBoxStockMinimo.Location = New System.Drawing.Point(0, 60)
        Me.CustomDecimalTextBoxStockMinimo.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomDecimalTextBoxStockMinimo.Name = "CustomDecimalTextBoxStockMinimo"
        Me.CustomDecimalTextBoxStockMinimo.Size = New System.Drawing.Size(75, 20)
        Me.CustomDecimalTextBoxStockMinimo.TabIndex = 2
        Me.CustomDecimalTextBoxStockMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 43)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Cant. U. Mín."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Cant. U. Actual"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(465, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 110)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Precio unitario"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.CustomDecimalTextBoxPrecioVenta, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(83, 91)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 3)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Venta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomDecimalTextBoxPrecioVenta
        '
        Me.CustomDecimalTextBoxPrecioVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.CustomDecimalTextBoxPrecioVenta.Location = New System.Drawing.Point(0, 20)
        Me.CustomDecimalTextBoxPrecioVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomDecimalTextBoxPrecioVenta.Name = "CustomDecimalTextBoxPrecioVenta"
        Me.CustomDecimalTextBoxPrecioVenta.Size = New System.Drawing.Size(82, 20)
        Me.CustomDecimalTextBoxPrecioVenta.TabIndex = 1
        Me.CustomDecimalTextBoxPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'venPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 190)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(575, 229)
        Me.MinimumSize = New System.Drawing.Size(575, 229)
        Me.Name = "venPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBoxDetalleDosProducto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDescripcionProducto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetalleUnoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CustomDecimalTextBoxStockActual As InterfazUsuario.CustomDecimalTextBox
    Friend WithEvents CustomDecimalTextBoxStockMinimo As InterfazUsuario.CustomDecimalTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CustomDecimalTextBoxPrecioVenta As InterfazUsuario.CustomDecimalTextBox
    Friend WithEvents TextBoxCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TextBoxUnidadProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
