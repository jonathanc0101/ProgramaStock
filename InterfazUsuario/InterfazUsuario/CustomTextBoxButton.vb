Imports System.Windows.Forms
''' <summary>
''' (BETA) Permite ingresar texto junto con un boton con imagen, por defecto viene preseteado para ser un cuadro de busqueda.
''' </summary>
Public Class CustomTextBoxButton
    ''' <summary>
    ''' Obtiene o setea el texto del control.
    ''' </summary>
    Public Overrides Property Text As String
        Get
            Return TextBox1.Text
        End Get
        Set(value As String)
            TextBox1.Text = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene o setea el objeto que controla la imagen dentro del control.
    ''' </summary>
    Public Property TextBox As TextBox
        Get
            Return TextBox1
        End Get
        Set(value As TextBox)
            TextBox1 = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene el objeto que controla la imagen del control.
    ''' </summary>
    Public Property Imagen As PictureBox
        Get
            Return PictureBox1
        End Get
        Set(value As PictureBox)
            PictureBox1 = value
        End Set
    End Property

    Public Shadows Event TextChanged(sender As Object, e As EventArgs)
    Public Shadows Event PreviewKeyDown(sender As Object, e As EventArgs)
    'Public Shadows Event GotFocus(sender As Object, e As EventArgs)
    Public Event ButtonClicked(sender As Object, e As EventArgs)

    Private Sub UserControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        TextBox1.Focus()
        Me.Label1.Visible = False
    End Sub

    Private Sub UserControl1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Me.Label1.Visible = False
    End Sub

    'Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
    '    RaiseEvent GotFocus(Me, e)
    'End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Me.PictureBox1.Visible = True
            Me.Label1.Visible = False
        Else
            Me.PictureBox1.Visible = False
            Me.Label1.Visible = True
        End If
        RaiseEvent TextChanged(Me, e)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If TextBox1.Text <> "" Then
            Me.Label1.Visible = False
        End If
        RaiseEvent PreviewKeyDown(Me, e)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.TextBox1.Text = ""
        'RaiseEvent ButtonClicked(Me, e)
        RaiseEvent PreviewKeyDown(Nothing, Nothing)
    End Sub

    Public Overrides Sub ResetText()
        MyBase.ResetText()
        TextBox1.ResetText()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.TextBox1.Focus()
        Me.Label1.Visible = False
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If Me.TextBox1.Text = "" Then
            Me.Label1.Visible = True
        End If
    End Sub

    Public Sub SelectAll()
        TextBox1.SelectAll()
    End Sub
End Class
