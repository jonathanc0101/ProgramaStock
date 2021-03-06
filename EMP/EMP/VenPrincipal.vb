Imports ObjetosDeNegocio

Public Class venPrincipal

    Private registro As empleado
    Private configuracion As configuracion.empleado

    Private titulo As String

    Private cambios As Boolean
    Private guardo As Boolean = False


    Public Sub New(ByRef ParamRegistro As empleado, ByRef ParamCfg As Configuracion.empleado)
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

        cargarGrilla()

        sinCambioshechos()

    End Sub

#Region "METODOS"
    Private Sub cargarGrilla()
        VentaBindingSource.DataSource = registro.ventas.Lista
    End Sub
    Private Sub acomodarAnchoYAlto(ancho As Integer, alto As Integer)
        Me.Width = ancho
        Me.Height = alto
    End Sub
    Private Sub ponerIconos()

        Me.Icon = Iconos.My.Resources.programa
    End Sub
    Private Sub setearTitulo()
        If registro.idEmpleado = 0 Then
            titulo = "Nuevo" & " - " & "empleado"
        Else
            titulo = registro.idEmpleado & " - " & "empleado"
        End If
    End Sub

    Private Sub ponerDatosEnPantalla()

        TextBoxNombre.Text = registro.nombre
        TextBoxCodigo.Text = registro.idEmpleado
    End Sub


    Private Sub llenarRegistro()
        registro.nombre = TextBoxNombre.Text
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

        AddHandler TextBoxNombre.TextChanged, AddressOf cambiosHechos
        AddHandler TextBoxCodigo.TextChanged, AddressOf cambiosHechos
    End Sub

    Private Function valoresValidos() As Boolean
        Return TextBoxCodigo.Text.Length > 0
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
                    Else
                        MessageBox.Show("No se puede guardar el empleado ", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        llenarRegistro()
                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message & " empleado ")
                End Try
            Else
                MessageBox.Show("Por favor ingrese valores validos", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'listados
    Private Sub actualizarLista()
        ComunicacionProcesos.ComunicacionesProcesos.mandarKey("EMPL", Keys.F5)
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

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        If DataGridViewVentas.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridViewVentas.SelectedRows
                ComunicacionProcesos.venta.EditarPorID(row.Cells("IdVentaDataGridViewTextBoxColumn").Value)
            Next
        End If
    End Sub

#End Region





    Private Sub DataGridViewVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVentas.CellContentClick

    End Sub
End Class
