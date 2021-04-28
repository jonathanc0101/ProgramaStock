Public Class proveedores

    Public Shared nombreModulo As String = "PROVL"

    Public Shared Sub Abrir(paramBuscarProceso As Boolean, paramCerrarProcesosAnteriores As Boolean)
        abrirProceso(nombreModulo, paramBuscarProceso, paramCerrarProcesosAnteriores, "")
    End Sub

End Class

