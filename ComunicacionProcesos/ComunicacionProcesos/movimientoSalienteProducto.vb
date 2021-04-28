Public Class movimientoSalienteProducto


    Public Shared nombreModulo As String = "MSP"
    Public Shared Sub Nueva()
        abrirProceso(nombreModulo, False, False, "")
    End Sub

    Public Shared Sub EditarPorID(ID As Integer)
        abrirProceso(nombreModulo, False, False, "abrirPorID " & ID)
    End Sub

    Public Shared Sub AgregarNuevoAVenta(idVenta As Integer)
        abrirProceso(nombreModulo, False, False, "abrirNuevoConIdVenta " & idVenta)
    End Sub


End Class
