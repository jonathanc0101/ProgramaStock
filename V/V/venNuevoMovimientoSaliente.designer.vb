<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venNuevoMovimientoSaliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(venNuevoMovimientoSaliente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomDecimalTextBoxCantidadUnidades = New InterfazUsuario.CustomDecimalTextBox()
        Me.CustomDecimalTextBoxTotal = New InterfazUsuario.CustomDecimalTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CustomDecimalTextBoxPrecioUnitario = New InterfazUsuario.CustomDecimalTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxCategoriaProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxUnidadProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxDetalleDosProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxCodigoProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxDetalleUnoProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxProductoDescripcion = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(694, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(694, 165)
        Me.TableLayoutPanel2.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 125)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(694, 40)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(536, 13)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(158, 27)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(85, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(6, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 492.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(688, 113)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(495, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 107)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Venta"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.CustomDecimalTextBoxCantidadUnidades, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.CustomDecimalTextBoxTotal, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.CustomDecimalTextBoxPrecioUnitario, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 2, 0)
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
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(184, 88)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'CustomDecimalTextBoxCantidadUnidades
        '
        Me.CustomDecimalTextBoxCantidadUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDecimalTextBoxCantidadUnidades.Location = New System.Drawing.Point(0, 20)
        Me.CustomDecimalTextBoxCantidadUnidades.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomDecimalTextBoxCantidadUnidades.Name = "CustomDecimalTextBoxCantidadUnidades"
        Me.CustomDecimalTextBoxCantidadUnidades.Size = New System.Drawing.Size(88, 20)
        Me.CustomDecimalTextBoxCantidadUnidades.TabIndex = 1
        Me.CustomDecimalTextBoxCantidadUnidades.Text = "0"
        Me.CustomDecimalTextBoxCantidadUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CustomDecimalTextBoxTotal
        '
        Me.CustomDecimalTextBoxTotal.Dock = System.Windows.Forms.DockStyle.Left
        Me.CustomDecimalTextBoxTotal.Location = New System.Drawing.Point(101, 20)
        Me.CustomDecimalTextBoxTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomDecimalTextBoxTotal.Name = "CustomDecimalTextBoxTotal"
        Me.CustomDecimalTextBoxTotal.ReadOnly = True
        Me.CustomDecimalTextBoxTotal.Size = New System.Drawing.Size(76, 20)
        Me.CustomDecimalTextBoxTotal.TabIndex = 2
        Me.CustomDecimalTextBoxTotal.Text = "0"
        Me.CustomDecimalTextBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 3)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cant. Unid."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomDecimalTextBoxPrecioUnitario
        '
        Me.CustomDecimalTextBoxPrecioUnitario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomDecimalTextBoxPrecioUnitario.Location = New System.Drawing.Point(0, 60)
        Me.CustomDecimalTextBoxPrecioUnitario.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomDecimalTextBoxPrecioUnitario.Name = "CustomDecimalTextBoxPrecioUnitario"
        Me.CustomDecimalTextBoxPrecioUnitario.ReadOnly = True
        Me.CustomDecimalTextBoxPrecioUnitario.Size = New System.Drawing.Size(88, 20)
        Me.CustomDecimalTextBoxPrecioUnitario.TabIndex = 3
        Me.CustomDecimalTextBoxPrecioUnitario.Text = "0"
        Me.CustomDecimalTextBoxPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 43)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Precio Unitario"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(101, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 107)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxCategoriaProducto, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxUnidadProducto, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDetalleDosProducto, 3, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxCodigoProducto, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDetalleUnoProducto, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 3, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ComboBoxProductoDescripcion, 0, 1)
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
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(480, 88)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TextBoxCategoriaProducto
        '
        Me.TextBoxCategoriaProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxCategoriaProducto.Location = New System.Drawing.Point(210, 60)
        Me.TextBoxCategoriaProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxCategoriaProducto.MaxLength = 50
        Me.TextBoxCategoriaProducto.Name = "TextBoxCategoriaProducto"
        Me.TextBoxCategoriaProducto.ReadOnly = True
        Me.TextBoxCategoriaProducto.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxCategoriaProducto.TabIndex = 5
        '
        'TextBoxUnidadProducto
        '
        Me.TextBoxUnidadProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxUnidadProducto.Location = New System.Drawing.Point(210, 20)
        Me.TextBoxUnidadProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxUnidadProducto.MaxLength = 50
        Me.TextBoxUnidadProducto.Name = "TextBoxUnidadProducto"
        Me.TextBoxUnidadProducto.ReadOnly = True
        Me.TextBoxUnidadProducto.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxUnidadProducto.TabIndex = 2
        '
        'TextBoxDetalleDosProducto
        '
        Me.TextBoxDetalleDosProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxDetalleDosProducto.Location = New System.Drawing.Point(341, 60)
        Me.TextBoxDetalleDosProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxDetalleDosProducto.MaxLength = 50
        Me.TextBoxDetalleDosProducto.Name = "TextBoxDetalleDosProducto"
        Me.TextBoxDetalleDosProducto.ReadOnly = True
        Me.TextBoxDetalleDosProducto.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxDetalleDosProducto.TabIndex = 6
        '
        'TextBoxCodigoProducto
        '
        Me.TextBoxCodigoProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxCodigoProducto.Location = New System.Drawing.Point(0, 60)
        Me.TextBoxCodigoProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxCodigoProducto.MaxLength = 50
        Me.TextBoxCodigoProducto.Name = "TextBoxCodigoProducto"
        Me.TextBoxCodigoProducto.ReadOnly = True
        Me.TextBoxCodigoProducto.Size = New System.Drawing.Size(97, 20)
        Me.TextBoxCodigoProducto.TabIndex = 4
        '
        'TextBoxDetalleUnoProducto
        '
        Me.TextBoxDetalleUnoProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxDetalleUnoProducto.Location = New System.Drawing.Point(341, 20)
        Me.TextBoxDetalleUnoProducto.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxDetalleUnoProducto.MaxLength = 50
        Me.TextBoxDetalleUnoProducto.Name = "TextBoxDetalleUnoProducto"
        Me.TextBoxDetalleUnoProducto.ReadOnly = True
        Me.TextBoxDetalleUnoProducto.Size = New System.Drawing.Size(131, 20)
        Me.TextBoxDetalleUnoProducto.TabIndex = 3
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
        Me.Label6.Location = New System.Drawing.Point(210, 3)
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
        Me.Label5.Location = New System.Drawing.Point(210, 43)
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
        Me.Label4.Location = New System.Drawing.Point(341, 43)
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
        Me.Label2.Location = New System.Drawing.Point(341, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Detalle uno"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxProductoDescripcion
        '
        Me.ComboBoxProductoDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProductoDescripcion.FormattingEnabled = True
        Me.ComboBoxProductoDescripcion.Location = New System.Drawing.Point(0, 20)
        Me.ComboBoxProductoDescripcion.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxProductoDescripcion.Name = "ComboBoxProductoDescripcion"
        Me.ComboBoxProductoDescripcion.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxProductoDescripcion.TabIndex = 31
        '
        'venNuevoMovimientoSaliente
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 189)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "venNuevoMovimientoSaliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CustomDecimalTextBoxCantidadUnidades As InterfazUsuario.CustomDecimalTextBox
    Friend WithEvents CustomDecimalTextBoxTotal As InterfazUsuario.CustomDecimalTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CustomDecimalTextBoxPrecioUnitario As InterfazUsuario.CustomDecimalTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBoxCategoriaProducto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUnidadProducto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetalleDosProducto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetalleUnoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxProductoDescripcion As System.Windows.Forms.ComboBox
End Class
