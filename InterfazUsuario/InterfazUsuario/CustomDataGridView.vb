Imports System.Windows.Forms

Public Class CustomDataGridView
    Inherits DataGridView

    Property pintarCelda As Boolean
    Property FilasSeleccionadas As List(Of Integer)
    Property FilasSeleccionadasPorID As List(Of Integer)

    Property NombreColumnaOrdenada As String
    Property Orden As System.ComponentModel.ListSortDirection
    Property IndiceScroll As Integer

    Public Sub New()

        Me.RowHeadersVisible = False
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.AllowUserToResizeRows = False
        Me.Dock = DockStyle.Fill
        Me.DoubleBuffered = True
        Me.AllowUserToResizeColumns = False

        pintarCelda = False
    End Sub

    Private Sub me_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Me.CellFormatting

        If Me.CurrentCell IsNot Nothing And pintarCelda Then

            If e.RowIndex = Me.CurrentCell.RowIndex And e.ColumnIndex = Me.CurrentCell.ColumnIndex Then
                e.CellStyle.SelectionBackColor = Drawing.Color.Blue
            Else
                e.CellStyle.SelectionBackColor = Me.DefaultCellStyle.SelectionBackColor
            End If
        End If
    End Sub

    Private Sub CustomDataGridView_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Me.CellMouseDown

        If e.Button = MouseButtons.Right And e.RowIndex >= 0 Then
            'And e.RowIndex >= 0
            If Not (ModifierKeys = Keys.Control Or ModifierKeys = Keys.Shift) And SelectedRows.Count <= 1 Then
                Me.ClearSelection()
            End If
            Me.Rows(e.RowIndex).Selected = True
        End If

    End Sub

    Private Sub CustomDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Me.DataError

        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            Me.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
        End If
    End Sub

    Private Sub CustomDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        'Si clickea el fondo termina la edicion
        Dim ht As DataGridView.HitTestInfo
        ht = Me.HitTest(e.X, e.Y)
        If ht.Type = DataGridViewHitTestType.None Then
            Me.EndEdit()
            ClearSelection()
        End If
    End Sub

    Public Sub guardarConfiguracionGrilla()

        FilasSeleccionadas = New List(Of Integer)
        If Me.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Me.SelectedRows
                FilasSeleccionadas.Add(row.Index)
            Next
        End If

        guardarEstadoGrilla()
    End Sub

    ''' <summary>
    ''' nombre de la columna id del datagridview
    ''' </summary>
    ''' <param name="paramNombreColumnaID"></param>
    ''' <remarks></remarks>
    Public Sub guardarEstadoGrillaPorIDs(paramNombreColumnaID As String)

        FilasSeleccionadasPorID = New List(Of Integer)

        If Me.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In Me.SelectedRows
                FilasSeleccionadasPorID.Add(row.Cells(paramNombreColumnaID).Value)
            Next
        End If

        guardarEstadoGrilla()
    End Sub

    Private Sub guardarEstadoGrilla()

        If IsNothing(Me.SortedColumn) Then

            NombreColumnaOrdenada = ""
            Orden = System.ComponentModel.ListSortDirection.Ascending
        Else

            NombreColumnaOrdenada = Me.SortedColumn.Name

            If Me.SortOrder = Windows.Forms.SortOrder.Ascending Then
                Orden = System.ComponentModel.ListSortDirection.Ascending
            Else
                Orden = System.ComponentModel.ListSortDirection.Descending
            End If
        End If

        If FirstDisplayedScrollingRowIndex < 0 Then
            IndiceScroll = 0
        Else
            IndiceScroll = Me.FirstDisplayedScrollingRowIndex
        End If

    End Sub

    Public Sub ponerConfiguracionGrilla()

        ponerEstadoGrilla()

        For Each indice As Integer In FilasSeleccionadas
            Try
                CurrentCell = Rows(FilasSeleccionadas.Last).Cells(Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index)
            Catch ex As Exception
            End Try

            Try
                Me.Rows(indice).Selected = True
            Catch ex As Exception
            End Try
        Next

    End Sub

    ''' <summary>
    ''' nombre columna id del binding source
    ''' </summary>
    ''' <param name="paramNombreColumnaID"></param>
    ''' <param name="paramBinding"></param>
    ''' <remarks></remarks>
    Public Sub ponerConfiguracionGrillaPorIDs(paramNombreColumnaID As String, ByRef paramBinding As BindingSource)

        ponerEstadoGrilla()

        If FilasSeleccionadasPorID.Count > 0 Then

            Try
                Dim Windice As Integer = paramBinding.Find(paramNombreColumnaID, FilasSeleccionadasPorID.Last())
                CurrentCell = Rows(Windice).Cells(Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index)
            Catch ex As Exception
            End Try

            For Each Witem As Integer In FilasSeleccionadasPorID
                Try
                    Dim Windice As Integer = paramBinding.Find(paramNombreColumnaID, Witem)
                    If Windice >= 0 Then
                        Me.Rows(Windice).Selected = True
                    End If
                Catch ex As Exception
                End Try
            Next


        End If

    End Sub

    Private Sub ponerEstadoGrilla()

        If NombreColumnaOrdenada <> "" Then
            Me.Sort(Me.Columns(NombreColumnaOrdenada), Orden)
        End If

        If Me.Rows.Count > 0 Then
            If IndiceScroll <= Me.Rows.Count - 1 Then
                Me.FirstDisplayedScrollingRowIndex = IndiceScroll
            Else
                Me.FirstDisplayedScrollingRowIndex = Me.Rows.Count - 1
            End If
        End If


        Me.ClearSelection()
    End Sub
End Class