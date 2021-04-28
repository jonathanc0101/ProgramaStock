Public Class empleados

    Public Shared nombreModulo As String = "EMPL"

    Public Shared Sub Abrir(paramBuscarProceso As Boolean, paramCerrarProcesosAnteriores As Boolean)
        abrirProceso(nombreModulo, paramBuscarProceso, paramCerrarProcesosAnteriores, "")
    End Sub

End Class
