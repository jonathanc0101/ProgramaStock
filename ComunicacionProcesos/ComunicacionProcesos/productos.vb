Public Class productos

    Public Shared nombreModulo As String = "PRL"

    Public Shared Sub Abrir(paramBuscarProceso As Boolean, paramCerrarProcesosAnteriores As Boolean)
        abrirProceso(nombreModulo, paramBuscarProceso, paramCerrarProcesosAnteriores, "")
    End Sub

End Class