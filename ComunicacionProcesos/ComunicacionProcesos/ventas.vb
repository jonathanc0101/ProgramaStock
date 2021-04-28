
Public Class ventas

    Public Shared nombreModulo As String = "VL"

    Public Shared Sub Abrir(paramBuscarProceso As Boolean, paramCerrarProcesosAnteriores As Boolean)
        abrirProceso(nombreModulo, paramBuscarProceso, paramCerrarProcesosAnteriores, "")
    End Sub

End Class