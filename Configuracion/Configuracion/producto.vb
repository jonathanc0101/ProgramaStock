Imports System.Xml

Public Class producto
    Inherits CFGVentana

    Private Ubicacion As String = "/root/producto/"
    Sub New()

        Dim XMLDoc As New XmlDocument
        XMLDoc = cargarXML()
        cargarVentana(XMLDoc, Ubicacion)

    End Sub

    Public Sub guardar()

        Dim XMLDoc As New XmlDocument
        XMLDoc = cargarXML()

        guardarVentana(XMLDoc, Ubicacion)
        guardarXML(XMLDoc)
    End Sub

End Class