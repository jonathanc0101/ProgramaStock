<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venCargando
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(venCargando))
        Me.textoCargando = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textoCargando
        '
        Me.textoCargando.AutoSize = True
        Me.textoCargando.Location = New System.Drawing.Point(86, 40)
        Me.textoCargando.Name = "textoCargando"
        Me.textoCargando.Size = New System.Drawing.Size(136, 13)
        Me.textoCargando.TabIndex = 1
        Me.textoCargando.Text = "Cargando, por favor espere"
        '
        'venCargando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 92)
        Me.ControlBox = False
        Me.Controls.Add(Me.textoCargando)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "venCargando"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargando"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textoCargando As System.Windows.Forms.Label
End Class
