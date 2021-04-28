Imports System.Xml

Public Class CFGServidor

    ' Conection String
    Property Servidor As String
    Property Usuario As String
    Property pass As String
    Property BD As String

    Sub New(nuevo As Boolean)

        Me.resetear()
    End Sub

    Sub New()

        Me.resetear()

        cargar()
    End Sub

    Public Sub cargar()

        Dim XMLDoc As New XmlDocument
        XMLDoc = cargarXML()

        cargar(XMLDoc)
    End Sub

    Public Sub cargar(ByRef documento As XmlDocument)

        obtenerNodo(documento, "/root/ConnectionString")
        Servidor = obtenerNodo(documento, "/root/ConnectionString/Servidor").InnerText
        Usuario = obtenerNodo(documento, "/root/ConnectionString/Usuario").InnerText
        pass = obtenerNodo(documento, "/root/ConnectionString/Pass").InnerText
        BD = obtenerNodo(documento, "/root/ConnectionString/BD").InnerText

    End Sub

    Public Sub guardar()

        Dim XMLDoc As New XmlDocument
        XMLDoc = cargarXML()
        guardar(XMLDoc)
        guardarXML(XMLDoc)
    End Sub


    Public Sub guardar(ByRef documento As XmlDocument)

        obtenerNodo(documento, "/root/ConnectionString/Servidor").InnerText = Servidor
        obtenerNodo(documento, "/root/ConnectionString/Usuario").InnerText = Usuario
        obtenerNodo(documento, "/root/ConnectionString/Pass").InnerText = pass
        obtenerNodo(documento, "/root/ConnectionString/BD").InnerText = BD

    End Sub

    Private Sub resetear()
        Servidor = ""
        Usuario = ""
        pass = ""
        BD = ""

    End Sub

End Class
