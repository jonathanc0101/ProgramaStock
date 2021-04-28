<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventanaSalir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonGrabar = New System.Windows.Forms.Button()
        Me.ButtonDescartar = New System.Windows.Forms.Button()
        Me.ButtonQuedarse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "¿Desea guardar los cambios?"
        '
        'ButtonGrabar
        '
        Me.ButtonGrabar.Location = New System.Drawing.Point(132, 53)
        Me.ButtonGrabar.Name = "ButtonGrabar"
        Me.ButtonGrabar.Size = New System.Drawing.Size(68, 23)
        Me.ButtonGrabar.TabIndex = 2
        Me.ButtonGrabar.Text = "Guardar"
        Me.ButtonGrabar.UseVisualStyleBackColor = True
        '
        'ButtonDescartar
        '
        Me.ButtonDescartar.Location = New System.Drawing.Point(58, 53)
        Me.ButtonDescartar.Name = "ButtonDescartar"
        Me.ButtonDescartar.Size = New System.Drawing.Size(68, 23)
        Me.ButtonDescartar.TabIndex = 1
        Me.ButtonDescartar.Text = "Salir"
        Me.ButtonDescartar.UseVisualStyleBackColor = True
        '
        'ButtonQuedarse
        '
        Me.ButtonQuedarse.Location = New System.Drawing.Point(206, 53)
        Me.ButtonQuedarse.Name = "ButtonQuedarse"
        Me.ButtonQuedarse.Size = New System.Drawing.Size(68, 23)
        Me.ButtonQuedarse.TabIndex = 3
        Me.ButtonQuedarse.Text = "Quedarse"
        Me.ButtonQuedarse.UseVisualStyleBackColor = True
        '
        'ventanaSalir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 87)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonQuedarse)
        Me.Controls.Add(Me.ButtonDescartar)
        Me.Controls.Add(Me.ButtonGrabar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ventanaSalir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonGrabar As System.Windows.Forms.Button
    Friend WithEvents ButtonDescartar As System.Windows.Forms.Button
    Friend WithEvents ButtonQuedarse As System.Windows.Forms.Button
End Class
