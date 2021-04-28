
Imports ObjetosDeNegocio

Public Class venPrincipal

    Private registro As venta
    Private configuracion As configuracion.venta

    Private empleados As empleados

    Private titulo As String

    Private cambios As Boolean
    Private guardo As Boolean = False


    Public Sub New(ByRef ParamRegistro As venta, ByRef ParamCfg As Configuracion.venta)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Me.registro = ParamRegistro
        Me.configuracion = ParamCfg


    End Sub

    Private Sub venPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.empleados = New empleados(configuracion.Servidor, configuracion.BD, configuracion.Usuario, configuracion.pass)
        ponerIconos()

        setearTitulo()

        ponerDatosEnPantalla()
        ponerConfiguracion()
        'ponemos los empleados en el combobox de empleados
        ponerEmpleados()
        agregarHandlersCambiosHechos()


        elegirModo()

        llenarGrillas()

        sinCambioshechos()

    End Sub

#Region "METODOS"
    Private Sub ponerEmpleados()
        empleados.cargarLista()
        ComboBoxNombreEmpleado.DataSource = empleados.Lista

        ComboBoxNombreEmpleado.DisplayMember = "nombre"

        If registro.idEmpleado <> 0 Then
            ComboBoxNombreEmpleado.Text = registro.empleado.nombre
        Else
            ComboBoxNombreEmpleado.Text = Nothing
        End If

    End Sub

    Private Sub elegirModo()
        CheckBoxCobrado.AutoCheck = Not (registro.cobrado)
        CheckBoxEntregado.AutoCheck = Not (registro.entregado)

        If registro.entregado Or registro.cobrado Then
            quitarDragDrop()
            quitarFuncionalidadABMItems()
            quitarModificacionEmpleado()
        End If

        If (registro.cobrado And registro.entregado) = True Then
            DateTimePickerFecha.Enabled = False
        End If

        If registro.anulada Then
            DateTimePickerFecha.Enabled = False

            quitarDragDrop()
        End If
    End Sub

    Private Sub quitarDragDrop()
        RemoveHandler Me.DragDrop, AddressOf VenPrincipal_DragDrop
    End Sub

    Private Sub quitarFuncionalidadABMItems()
        cmsFila.Enabled = False
        cmsFondo.Enabled = False

        ToolStripButtonNuevo.Enabled = False
        ToolStripButtonEliminar.Enabled = False
    End Sub

    Private Sub quitarModificacionEmpleado()
        ComboBoxNombreEmpleado.Enabled = False
    End Sub
    Private Sub ponerIconos()

        Me.Icon = Iconos.My.Resources.programa
        ToolStripButtonEliminar.Image = Iconos.My.Resources.eliminarIMG
        ToolStripButtonNuevo.Image = Iconos.My.Resources.nuevoIMG
    End Sub
    Private Sub setearTitulo()
        If registro.idVenta = 0 Then
            titulo = "Nueva" & " - " & "Venta"
        Else
            titulo = registro.idVenta & " - " & "Venta"
        End If
    End Sub

    Private Sub ponerDatosEnPantalla()

        DateTimePickerFecha.Value = registro.fecha
        cargarEmpleadoEnPantalla()
        If registro.idVenta <> 0 Then
            TextBoxCodigoVenta.Text = registro.idVenta
        Else
            TextBoxCodigoVenta.Text = Nothing
        End If
        CustomDecimalTextBoxMonto.Text = registro.montoTotal

        CheckBoxCobrado.Checked = registro.cobrado
        CheckBoxEntregado.Checked = registro.entregado
    End Sub

    Private Sub cargarEmpleado()
        Try
            registro.cargarEmpleadoPorId(ComboBoxNombreEmpleado.SelectedItem.idEmpleado)
        Catch ex As Exception
            MessageBox.Show("Error al cargar el/la empleado/a: " & ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ponerEmpleados()
        End Try
    End Sub
    Private Sub cargarEmpleadoEnPantalla()
        If registro.idEmpleado <> 0 Then
            TextBoxCodigoEmpleado.Text = registro.idEmpleado
        Else
            TextBoxCodigoEmpleado.Text = Nothing
        End If
    End Sub
    Private Sub llenarRegistro()

        If CheckBoxCobrado.Checked Then
            registro.fecha = DateTimePickerFecha.Value
        End If

        registro.montoTotal = CDec(CustomDecimalTextBoxMonto.Text)

        registro.cobrado = CheckBoxCobrado.Checked

        registro.entregado = CheckBoxEntregado.Checked

    End Sub

    Private Sub llenarGrillas()
        MovimientoSalienteProductoBindingSource.DataSource = registro.items.Lista

        Me.Refresh()
    End Sub

    Private Sub cambiosHechos()
        cambios = True
        Me.Text = titulo & "*"

        recalcularTotal()
    End Sub

    Private Sub sinCambioshechos()
        cambios = False
        Me.Text = titulo

    End Sub

    Private Sub guardarConfiguracion()
        configuracion.guardar()
    End Sub

    Private Sub ponerConfiguracion()
        configuracion.setearVentana(Me)
    End Sub

    Private Sub agregarHandlersCambiosHechos()

        AddHandler TextBoxCodigoEmpleado.TextChanged, AddressOf cambiosHechos

        AddHandler CheckBoxCobrado.CheckedChanged, AddressOf cambiosHechos
        AddHandler CheckBoxEntregado.CheckedChanged, AddressOf cambiosHechos

        'añadimos tambien el handler que haga que al guardar la compra se impacte en stock
        AddHandler CheckBoxEntregado.CheckedChanged, AddressOf registro.impactarEnStock

        AddHandler CustomDecimalTextBoxMonto.TextChanged, AddressOf cambiosHechos
        AddHandler registro.items.Lista.ListChanged, AddressOf cambiosHechos

        AddHandler DataGridViewItems.Rows.CollectionChanged, AddressOf cambiosHechos

        'comboboxEmpleado
        AddHandler ComboBoxNombreEmpleado.SelectedValueChanged, AddressOf cargarEmpleado
        AddHandler ComboBoxNombreEmpleado.SelectedValueChanged, AddressOf cargarEmpleadoEnPantalla
        AddHandler ComboBoxNombreEmpleado.SelectedValueChanged, AddressOf cambiosHechos
    End Sub


    Private Function valoresValidos() As Boolean
        'Se retorna Comprobación de valores
        Return TextBoxCodigoEmpleado.Text <> 0 And registro.items.Lista.Count > 0
    End Function
    Private Sub nuevoItem()
        Dim ventanaNuevoMovimientoSaliente As New venNuevoMovimientoSaliente(registro)
        ventanaNuevoMovimientoSaliente.ShowDialog()

        actualizar()
    End Sub

    Private Sub nuevoItem(idProducto As Integer)
        Dim ventanaNuevoMovimientoSaliente As New venNuevoMovimientoSaliente(registro, idProducto)
        ventanaNuevoMovimientoSaliente.ShowDialog()

        recalcularTotal()
        actualizarLista()
    End Sub

    Private Sub eliminarRegistros()

        registro.resetearItems()

        llenarGrillas()
        recalcularTotal()
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

                        llenarGrillas()

                        elegirModo()

                    Else
                        MessageBox.Show("No se puede guardar la Venta ", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        llenarRegistro()
                    End If

                Catch ex As Exception
                    Throw New Exception(ex.Message & " Venta ")
                End Try
            Else
                MessageBox.Show("No se puede guardar la Venta ", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No hay cambios hechos", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'listados
    Private Sub actualizarLista()
        ComunicacionProcesos.ComunicacionesProcesos.mandarKey("VL", Keys.F5)
        ComunicacionProcesos.ComunicacionesProcesos.mandarKey("PRL", Keys.F5)
    End Sub

    Private Sub guardarYCerrar()
        Guardar()
        Me.Close()
    End Sub

    Private Sub actualizar()
        llenarGrillas()
        recalcularTotal()
        ponerDatosEnPantalla()
    End Sub

    Private Sub recalcularTotal()
        registro.recalcularTotal()
        CustomDecimalTextBoxMonto.Text = registro.montoTotal
    End Sub

#End Region

#Region "EVENTOS"


    Private Sub VenPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If cambios Then

            Dim VenSalir As New InterfazUsuario.ventanaSalir()
            VenSalir.ShowDialog()

            If VenSalir.resultado = InterfazUsuario.ventanaSalir.ResultadoSalir.Grabar Then

                Guardar()
                If Not guardo Then
                    e.Cancel = True
                Else
                    ponerDatosEnPantalla()
                End If

            ElseIf VenSalir.resultado = InterfazUsuario.ventanaSalir.ResultadoSalir.Quedarse Then
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

    Private Sub ToolStripButtonNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNuevo.Click
        nuevoItem()
    End Sub

    Private Sub ToolStripButtonEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEliminar.Click
        eliminarRegistros()
    End Sub

    Private Sub ToolStripMenuItemGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemGuardar.Click
        Guardar()
    End Sub

    Private Sub ToolStripMenuItemSalir_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItemActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemActualizar.Click
        actualizar()
    End Sub

    Private Sub ToolStripMenuItemEmpleados_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEmpleados.Click
        ComunicacionProcesos.empleados.Abrir(True, False)
    End Sub

    Private Sub ToolStripMenuItemProductos_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemProductos.Click
        ComunicacionProcesos.productos.Abrir(True, False)
    End Sub

    Private Sub ToolStripMenuItemNuevo_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        nuevoItem()
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminarRegistros()
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        nuevoItem()
    End Sub

#End Region

#Region "D'A'D"

    Private Sub VenPrincipal_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter

        Try
            If e.Data.GetDataPresent(DataFormats.Text) And
                    Microsoft.VisualBasic.Left(e.Data.GetData(DataFormats.Text).ToString, 8) = "empleado" Or _
                    Microsoft.VisualBasic.Left(e.Data.GetData(DataFormats.Text).ToString, 8) = "producto" Then

                e.Effect = DragDropEffects.All
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, " Venta ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub VenPrincipal_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop


        If e.Data.GetDataPresent(DataFormats.Text) Then

            If Microsoft.VisualBasic.Left(e.Data.GetData(DataFormats.Text).ToString, 8) = "empleado" Then

                Me.Activate()
                registro.cargarEmpleadoPorId(CInt(e.Data.GetData(DataFormats.Text).ToString.Substring(8)))

                cargarEmpleadoEnPantalla()

            ElseIf Microsoft.VisualBasic.Left(e.Data.GetData(DataFormats.Text).ToString, 8) = "producto" Then
                Me.Activate()
                nuevoItem(CInt(e.Data.GetData(DataFormats.Text).ToString.Substring(8)))

            End If

        End If

        'metodo que coloca en pantalla los cambios posibles 
        llenarGrillas()

    End Sub

#End Region





End Class

