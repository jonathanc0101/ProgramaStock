
Public Class venta

    Public Shared nombreModulo As String = "V"
    Public Shared Sub Nueva()
        abrirProceso(nombreModulo, False, False, "")
    End Sub

    Public Shared Sub EditarPorID(ID As Integer)
        abrirProceso(nombreModulo, False, False, "abrirPorID " & ID)
    End Sub



End Class