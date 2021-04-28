Imports System.Windows.Forms
Imports System.Globalization


Public Class CustomDecimalTextBox
    Inherits TextBox

    Sub New()
        Application.CurrentCulture = New CultureInfo("EN-US")
        Me.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub validateDecimalTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        If SelectedText = Me.Text Then

            If (e.KeyChar = "," And textBox.Text.IndexOf(",") < 0 And textBox.Text.IndexOf(".") < 0) Then
                e.KeyChar = "."
            End If
        Else

            If (e.KeyChar = "," And textBox.Text.IndexOf(",") < 0 And textBox.Text.IndexOf(".") < 0) Then
                e.KeyChar = "."
            End If

            If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or
                    (e.KeyChar = "." And textBox.Text.IndexOf(".") < 0) Or
                    (e.KeyChar = "-" And textBox.Text.IndexOf("-") < 0)) Then

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub CustomDecimalTextBox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If Not IsNumeric(Me.Text) Then
            Me.Text = 0.0
        Else
            'Me.Text = Convert.ToDouble(Me.Text)
        End If
    End Sub
End Class