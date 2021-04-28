Imports System.Xml

Public Class ventas
    Inherits CFGLista

    Private Ubicacion As String = "/root/ventas/"

    Sub New()

        Dim XMLDoc As New XmlDocument
        XMLDoc = cargarXML()
        cargarLista(XMLDoc, Ubicacion)
    End Sub

    Public Sub guardar()

        Dim XMLDoc As New XmlDocument
        XMLDoc = cargarXML()

        guardarLista(XMLDoc, Ubicacion)

        guardarXML(XMLDoc)
    End Sub
End Class