
Imports objetosDeNegocio

Public Class venNuevoMovimientoSaliente

    Private venta As venta
    Private configuracion As Configuracion.movimientoSalienteProducto

    Private registro As movimientoSalienteProducto

    Private titulo As String

    Private guardo As Boolean = False

    Private productos As productos
    Public Sub New(ByRef ParamRegistro As venta)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Me.configuracion = New Configuracion.movimientoSalienteProducto
        Me.registro = New movimientoSalienteProducto(configuracion.Servidor, configuracion.BD, configuracion.Usuario, configuracion.pass)

        Me.venta = ParamRegistro


    End Sub


    Public Sub New(ByRef ParamRegistro As venta, idProducto As Integer)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Me.configuracion = New Configuracion.movimientoSalienteProducto
        Me.registro = New movimientoSalienteProducto(configuracion.Servidor, configuracion.BD, configuracion.Usuario, configuracion.pass)

        Me.registro.cargarProductoPorId(idProducto)

        Me.venta = ParamRegistro

    End Sub

    Private Sub venPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.productos = New productos(configuracion.Servidor, configuracion.BD, configuracion.Usuario, configuracion.pass)
        ponerIconos()

        setearTitulo()

        ponerDatosEnPantalla()
        ponerProductos()
        ponerConfiguracion()
        agregarHandlersCambiosHechos()

    End Sub

#Region "METODOS"

    Private Sub ponerProductos()
        productos.cargarLista()

        ComboBoxProductoDescripcion.DataSource = productos.Lista
        ComboBoxProductoDescripcion.DisplayMember = "descripcionProducto"

        If registro.idProducto <> 0 Then
            ComboBoxProductoDescripcion.Text = registro.producto.descripcionProducto
        Else
            ComboBoxProductoDescripcion.Text = Nothing
        End If

    End Sub

    Private Sub ponerIconos()

        Me.Icon = Iconos.My.Resources.Programa
    End Sub
    Private Sub setearTitulo()
            titulo = "Nuevo" & " - " & "Item de venta"
    End Sub

    Private Sub ponerDatosEnPantalla()

        TextBoxCodigoProducto.Text = registro.producto.idProducto
        CustomDecimalTextBoxPrecioUnitario.Text = registro.producto.precioUnitario
        TextBoxUnidadProducto.Text = registro.producto.unidadProducto
        TextBoxCategoriaProducto.Text = registro.producto.categoria
        TextBoxDetalleUnoProducto.Text = registro.producto.detalleUnoProducto
        TextBoxDetalleDosProducto.Text = registro.producto.detalleDosProducto

        CustomDecimalTextBoxCantidadUnidades.Text = registro.cantidadSalidaProducto

        colocarTotalEnPantalla()

    End Sub

    Private Sub colocarTotalEnPantalla()
        If registro.producto.idProducto <> 0 And IsNumeric(CustomDecimalTextBoxCantidadUnidades.Text) And IsNumeric(CustomDecimalTextBoxCantidadUnidades.Text) Then
            CustomDecimalTextBoxTotal.Text = registro.producto.precioUnitario * CDec(CustomDecimalTextBoxCantidadUnidades.Text)
        End If
    End Sub

    Private Sub llenarRegistro()

        registro.cantidadSalidaProducto = CDec(CustomDecimalTextBoxCantidadUnidades.Text)
        registro.valorSalidaProducto = CDec(CustomDecimalTextBoxTotal.Text)

    End Sub


    Private Sub ponerConfiguracion()
        Me.Location = New Point(configuracion.X, configuracion.Y)
        Me.Size = New Size(configuracion.Ancho, configuracion.Alto)
    End Sub

    Private Sub agregarHandlersCambiosHechos()

        AddHandler CustomDecimalTextBoxCantidadUnidades.TextChanged, AddressOf colocarTotalEnPantalla
        AddHandler TextBoxCodigoProducto.TextChanged, AddressOf colocarTotalEnPantalla

        AddHandler ComboBoxProductoDescripcion.SelectedValueChanged, AddressOf cambiarProducto
        AddHandler ComboBoxProductoDescripcion.SelectedValueChanged, AddressOf colocarTotalEnPantalla
    End Sub

    Private Sub cambiarProducto()
        Try
            registro.cargarProductoPorId(ComboBoxProductoDescripcion.SelectedItem.idProducto)
            ponerDatosEnPantalla()

        Catch ex As Exception
            MessageBox.Show("Error al cargar el producto: " & ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ponerProductos()
        End Try
    End Sub
    Private Function valoresValidos() As Boolean
        'Se retorna Comprobación de valores

        Return registro.producto.idProducto <> 0 And CDec(CustomDecimalTextBoxCantidadUnidades.Text) > 0
    End Function

    Private Sub guardarYCerrar()

        If valoresValidos() Then

            llenarRegistro()
            venta.agregarItemDeVenta(registro)
            Me.Close()
        Else
            MessageBox.Show("Por favor ingrese datos válidos", "Item de venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub guardarConfiguracion()
        configuracion.X = Me.Location.X
        configuracion.Y = Me.Location.Y

        configuracion.Ancho = Me.Size.Width
        configuracion.Alto = Me.Size.Height

        configuracion.guardar()
    End Sub

    'listados
    Private Sub actualizarLista()
        ComunicacionProcesos.ComunicacionesProcesos.mandarKey("V", Keys.F5)
    End Sub


    Private Sub cargarProducto(idProducto As Integer)
        registro.cargarProductoPorId(idProducto)
    End Sub
#End Region

#Region "EVENTOS"

    'ciclo de vida de la ventana
    Private Sub venPrincipal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.CustomDecimalTextBoxCantidadUnidades.Focus()
    End Sub

    Private Sub venPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        guardarConfiguracion()
    End Sub

    Private Sub venPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then

            e.SuppressKeyPress = True
            Me.Close()
        ElseIf e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            guardarYCerrar()
        End If

    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        guardarYCerrar()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        ComunicacionProcesos.productos.Abrir(vbTuesday, False)
    End Sub
#End Region

#Region "D'A'D"

    Private Sub VenPrincipal_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter

        Try
            If e.Data.GetDataPresent(DataFormats.Text) And
                    Microsoft.VisualBasic.Left(e.Data.GetData(DataFormats.Text).ToString, 8) = "producto" Then

                e.Effect = DragDropEffects.All
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, " Venta de item ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub VenPrincipal_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop


        If e.Data.GetDataPresent(DataFormats.Text) Then

            If Microsoft.VisualBasic.Left(e.Data.GetData(DataFormats.Text).ToString, 8) = "producto" Then

                Me.Activate()
                cargarProducto(CInt(e.Data.GetData(DataFormats.Text).ToString.Substring(8)))

            End If

        End If

        ponerDatosEnPantalla()

    End Sub

#End Region

End Class

