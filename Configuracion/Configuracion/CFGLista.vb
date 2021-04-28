Imports System.Xml

Public Class CFGLista
    Inherits CFGVentana

    Property Grilla As Grilla


    Sub New()

        Grilla = New Grilla
    End Sub

    Public Sub cargarLista(ByRef XMLDoc As XmlDocument, ubicacionNodo As String)

        cargarVentana(XMLDoc, ubicacionNodo)
        Grilla.cargar(XMLDoc, ubicacionNodo)
    End Sub

    Public Sub guardarLista(ByRef XMLDoc As XmlDocument, ubicacionNodo As String)

        Grilla.guardar(XMLDoc, ubicacionNodo)
        guardarVentana(XMLDoc, ubicacionNodo)
    End Sub


End Class
