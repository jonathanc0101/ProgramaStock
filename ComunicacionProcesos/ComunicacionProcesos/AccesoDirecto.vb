
Public Module AccesoDirecto


    Public Sub crearEnEscritorio(TargetName As String, ShortCutName As String, areaTrabajo As String, argumentos As String)

        For Each c As Char In System.IO.Path.GetInvalidFileNameChars
            ShortCutName = ShortCutName.Replace(c, "_")
        Next

        Dim oShell As Object
        Dim oLink As Object
        'you don’t need to import anything in the project reference to create the Shell Object

        oShell = CreateObject("WScript.Shell")
        oLink = oShell.CreateShortcut(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & ShortCutName & ".lnk")
        oLink.Arguments = argumentos
        oLink.TargetPath = TargetName
        oLink.WorkingDirectory = areaTrabajo
        oLink.WindowStyle = 1
        oLink.Save()
    End Sub
End Module
