
Imports ObjetosDeNegocio

Public Class venPrincipal

    Private registro As proveedor
    Private configuracion As configuracion.proveedor

    Private titulo As String

    Private cambios As Boolean
    Private guardo As Boolean = False


    Public Sub New(ByRef ParamRegistro As proveedor, ByRef ParamCfg As Configuracion.proveedor)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Me.registro = ParamRegistro
        Me.configuracion = ParamCfg

    End Sub

    Private Sub venPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ponerConfiguracion()

        ponerIconos()

        setearTitulo()

        ponerDatosEnPantalla()
        agregarHandlersTextChanged()

        sinCambioshechos()

        cargarGrilla()


    End Sub

#Region "METODOS"
    Private Sub cargarGrilla()
        CompraBindingSource.DataSource = registro.compras.Lista
    End Sub
    Private Sub acomodarAnchoYAlto(ancho As Integer, alto As Integer)
        Me.Width = ancho
        Me.Height = alto
    End Sub

    Private Sub ponerIconos()

        Me.Icon = Iconos.My.Resources.Programa
    End Sub
    Private Sub setearTitulo()
        If registro.idProveedor = 0 Then
            titulo = "Nuevo" & " - " & "proveedor"
        Else
            titulo = registro.idProveedor & " - " & "proveedor"
        End If
    End Sub

    Private Sub ponerDatosEnPantalla()

        TextBoxdetalleProveedor.text = registro.detalleProveedor
        TextBoxEmail.text = registro.email
        TextBoxIdProveedor.Text = registro.idProveedor
        TextBoxNombre.Text = registro.nombre
        TextBoxNumeroDeTelefono.text = registro.numeroDeTelefono


    End Sub


    Private Sub llenarRegistro()

        registro.detalleProveedor = TextBoxdetalleProveedor.text
        registro.email = TextBoxEmail.Text
        registro.nombre = TextBoxNombre.Text
        registro.numeroDeTelefono = TextBoxNumeroDeTelefono.text

    End Sub

    Private Sub cambiosHechos()
        cambios = True
        Me.Text = titulo & "*"
    End Sub

    Private Sub sinCambioshechos()
        cambios = False
        Me.Text = titulo
    End Sub

    Private Sub agregarHandlersTextChanged()

        AddHandler TextBoxdetalleProveedor.TextChanged, AddressOf cambiosHechos
        AddHandler TextBoxEmail.TextChanged, AddressOf cambiosHechos
        AddHandler TextBoxNombre.TextChanged, AddressOf cambiosHechos
        AddHandler TextBoxNumeroDeTelefono.TextChanged, AddressOf cambiosHechos

    End Sub
    Private Function valoresValidos() As Boolean
        'Se retorna Comprobación de valores
        Return True
    End Function


    Private Sub guardarConfiguracion()
        Configuracion.guardar()
    End Sub

    Private Sub ponerConfiguracion()
        Configuracion.setearVentana(Me)
    End Sub

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

                    Else
                        MessageBox.Show("No se puede guardar la proveedor ", "proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        llenarRegistro()
                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message & " proveedor ")
                End Try
            End If
        End If
    End Sub

    'listados
    Private Sub actualizarLista()
        ComunicacionProcesos.ComunicacionesProcesos.mandarKey("PROVL", Keys.F5)
    End Sub

    Private Sub guardarYCerrar()
        Guardar()
        Me.Close()
    End Sub

#End Region

#Region "EVENTOS"

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

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        guardarYCerrar()
    End Sub


#End Region


End Class

