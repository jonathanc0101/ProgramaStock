Imports System.Xml

Public Class proveedores
    Inherits CFGLista

    Private Ubicacion As String = "/root/proveedores/"

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