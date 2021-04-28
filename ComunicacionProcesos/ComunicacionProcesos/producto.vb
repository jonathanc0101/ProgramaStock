
Public Class producto

    Public Shared nombreModulo As String = "PR"
    Public Shared Sub Nueva()
        abrirProceso(nombreModulo, False, False, "")
    End Sub

    Public Shared Sub EditarPorID(ID As Integer)
        abrirProceso(nombreModulo, False, False, "abrirPorID " & ID)
    End Sub

End Class
