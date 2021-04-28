Public Class compras

    Public Shared nombreModulo As String = "CL"

    Public Shared Sub Abrir(paramBuscarProceso As Boolean, paramCerrarProcesosAnteriores As Boolean)
        abrirProceso(nombreModulo, paramBuscarProceso, paramCerrarProcesosAnteriores, "")
    End Sub

End Class