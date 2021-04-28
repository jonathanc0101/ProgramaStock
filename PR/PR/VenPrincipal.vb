
Imports ObjetosDeNegocio

Public Class venPrincipal

    Private registro As producto
    Private configuracion As configuracion.producto

    Private titulo As String

    Private cambios As Boolean
    Private guardo As Boolean = False

    Private stockInicialAlAbrirVentana As Decimal = 0

    Public Sub New(ByRef ParamRegistro As producto, ByRef ParamCfg As Configuracion.producto)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Me.registro = ParamRegistro
        Me.configuracion = ParamCfg

    End Sub

    Private Sub venPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ponerIconos()

        setearTitulo()

        ponerDatosEnPantalla()
        ponerConfiguracion()
        agregarHandlersTextChanged()

        elegirModo()

        sinCambioshechos()

        acomodarAnchoYAlto(578, 229)

    End Sub

#Region "METODOS"

    Private Sub elegirModo()
        If registro.idProducto <> 0 Then
            CustomDecimalTextBoxStockActual.ReadOnly = True
        End If
    End Sub
    Private Sub acomodarAnchoYAlto(ancho As Integer, alto As Integer)
        Me.Width = ancho
        Me.Height = alto
    End Sub

    Private Sub ponerIconos()

        Me.Icon = Iconos.My.Resources.Programa
    End Sub
    Private Sub setearTitulo()
        If registro.idProducto = 0 Then
            titulo = "Nuevo" & " - " & "Producto"
        Else
            titulo = registro.idProducto & " - " & "Producto"
        End If
    End Sub

    Private Sub ponerDatosEnPantalla()

        'stock / mpe - mps
        CustomDecimalTextBoxStockActual.Text = registro.cantidadUnidadesEnStock
        CustomDecimalTextBoxStockMinimo.Text = registro.cantidadUnidadesMinimasEnStock

        TextBoxCategoria.text = registro.categoria
        TextBoxDescripcionProducto.Text = registro.descripcionProducto

        TextBoxDetalleDosProducto.Text = registro.detalleDosProducto
        TextBoxDetalleUnoProducto.Text = registro.detalleUnoProducto
        TextBoxCodigo.Text = registro.idProducto

        'precio/Lista de venta
        CustomDecimalTextBoxPrecioVenta.Text = registro.precioUnitario

        TextBoxUnidadProducto.Text = registro.unidadProducto



    End Sub


    Private Sub llenarRegistro()
        registro.descripcionProducto = TextBoxDescripcionProducto.text
        registro.detalleUnoProducto = TextBoxDetalleUnoProducto.text
        registro.detalleDosProducto = TextBoxDetalleDosProducto.text
        registro.unidadProducto = TextBoxUnidadProducto.Text
        registro.categoria = TextBoxCategoria.Text

        registro.cantidadUnidadesMinimasEnStock = CDec(CustomDecimalTextBoxStockMinimo.Text)
        registro.precioUnitario = CDec(CustomDecimalTextBoxPrecioVenta.Text)

        If registro.idProducto = 0 Then
            registro.cantidadUnidadesEnStock = CDec(CustomDecimalTextBoxStockActual.Text)
        End If
    End Sub


    Private Sub cambiosHechos()
        cambios = True
        Me.Text = titulo & "*"
    End Sub

    Private Sub sinCambioshechos()
        cambios = False
        Me.Text = titulo
    End Sub

    Private Sub guardarConfiguracion()
        Configuracion.guardar()
    End Sub

    Private Sub ponerConfiguracion()
        Configuracion.setearVentana(Me)
    End Sub

    Private Sub agregarHandlersTextChanged()

        AddHandler TextBoxDescripcionProducto.TextChanged, AddressOf cambiosHechos
        AddHandler TextBoxDetalleUnoProducto.TextChanged, AddressOf cambiosHechos
        AddHandler TextBoxDetalleDosProducto.TextChanged, AddressOf cambiosHechos
        AddHandler TextBoxUnidadProducto.TextChanged, AddressOf cambiosHechos
        AddHandler TextBoxCategoria.TextChanged, AddressOf cambiosHechos
        AddHandler CustomDecimalTextBoxStockMinimo.TextChanged, AddressOf cambiosHechos
        AddHandler CustomDecimalTextBoxPrecioVenta.TextChanged, AddressOf cambiosHechos

    End Sub


    Private Function valoresValidos() As Boolean
        'Se retorna Comprobación de valores
        Return TextBoxDescripcionProducto.Text.Length > 0 And TextBoxUnidadProducto.Text.Length > 0
    End Function

    Private Sub Guardar()
        If cambios Then

            If valoresValidos() Then

                llenarRegistro()
                Try
                    Dim ventanaGuardar As New venGuardando(registro, configuracion)
                    ventanaGuardar.ShowDialog()
                    guardo = ventanaGuardar.Guardado

                    If guardo Then
                        setearTitulo()
                        sinCambioshechos()

                        actualizarLista()

                        'llenarGrillas()

                    Else
                        MessageBox.Show("No se puede guardar el Producto ", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        llenarRegistro()
                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message & " Producto ")
                End Try
            End If
        End If
    End Sub

    'listados
    Private Sub actualizarLista()
        ComunicacionProcesos.ComunicacionesProcesos.mandarKey("PRL", Keys.F5)
    End Sub

    Private Sub guardarYCerrar()
        Guardar()
        Me.Close()
    End Sub

#End Region

#Region "EVENTOS"

    'ciclo de vida de la ventana
    Private Sub venPrincipal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If registro.idProducto <> 0 Then

        End If
    End Sub

    Private Sub VenPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If cambios Then

            Dim VenSalir As New InterfazUsuario.VentanaSalir()
            VenSalir.ShowDialog()

            If VenSalir.resultado = InterfazUsuario.VentanaSalir.ResultadoSalir.Grabar Then

                Guardar()
                If Not guardo Then
                    e.Cancel = True
                Else
                    ponerDatosEnPantalla()
                End If

            ElseIf VenSalir.resultado = InterfazUsuario.VentanaSalir.ResultadoSalir.Quedarse Then
                e.Cancel = True
            End If
        End If
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

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        guardarYCerrar()
    End Sub


#End Region


End Class

