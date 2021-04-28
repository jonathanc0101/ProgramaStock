Imports System.Windows.Forms
Public Class ventanaSalir

    Property resultado As ResultadoSalir

    Public Enum ResultadoSalir As Integer
        Imprimir = 0
        Descartar = 1
        Grabar = 2
        Quedarse = 3
    End Enum

    Private Sub ventanaSalir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonGrabar.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub ButtonGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGrabar.Click
        resultado = ResultadoSalir.Grabar
        Me.Close()
    End Sub

    Private Sub ButtonQuedarse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuedarse.Click
        resultado = ResultadoSalir.Quedarse
        Me.Close()
    End Sub

    Private Sub ButtonDescartar_Click(sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDescartar.Click
        resultado = ResultadoSalir.Descartar
        Me.Close()
    End Sub

    Private Sub ventanaSalir_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            resultado = ResultadoSalir.Quedarse
            Me.Close()
        End If
    End Sub

End Class