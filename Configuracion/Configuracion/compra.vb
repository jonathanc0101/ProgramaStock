Imports System.Xml

Public Class compra
    Inherits CFGVentana

    Private Ubicacion As String = "/root/compra/"
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
