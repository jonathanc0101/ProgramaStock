Friend Module Metodos

    Public ubicacion As String = IO.Path.GetDirectoryName(Windows.Forms.Application.ExecutablePath)

    Public Sub abrirProceso(nombreModulo As String, buscarProceso As Boolean, cerrarProcesos As Boolean, parametros As String)

        Try

            If buscarProceso Then

                Dim encontrado As Boolean = False
                Dim id As Integer

                For Each process As Process In process.GetProcesses
                    If process.ProcessName = nombreModulo Then
                        id = process.Id
                        encontrado = True
                        Exit For
                    End If
                Next

                If encontrado Then
                    AppActivate(id)
                Else
                    Process.Start(ubicacion & "\" & nombreModulo & ".exe", parametros)
                End If

            ElseIf cerrarProcesos Then

                For Each p In Process.GetProcesses()
                    If p.ProcessName = nombreModulo Then
                        p.Kill()
                    End If
                Next
                Process.Start(ubicacion & "\" & nombreModulo & ".exe", parametros)

            Else
                Process.Start(ubicacion & "\" & nombreModulo & ".exe", parametros)
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("No se encontro el ejecutable", "Ejecutable", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub abrirProcesoYEsperar(nombreModulo As String, parametros As String)

        Try
            Process.Start(ubicacion & "\" & nombreModulo & ".exe", parametros).WaitForExit()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("No se encontro el ejecutable", "Ejecutable", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End Try

    End Sub

End Module
