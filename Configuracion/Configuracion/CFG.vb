Imports System.Windows.Forms
Imports System.Xml

Friend Module CFG

    Friend valorXporDefecto As Integer = 0
    Friend valorYporDefecto As Integer = 0
    Friend valorAltoporDefecto As Integer = 150
    Friend valorAnchoporDefecto As Integer = 150
    Friend valorEstadoporDefecto As Integer = 0

    Friend nombreArchivo As String = "Config.xml"

    Friend Function cargarXML() As XmlDocument

        Dim XMLDoc As New XmlDocument
        While True

            Try

                XMLDoc.Load(nombreArchivo)
                Exit While
            Catch ex As IO.FileNotFoundException

                MessageBox.Show("Archivo de configuración " & nombreArchivo & " no encontrado",
                                "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information)

                crearEsquemaXML()
                XMLDoc.Load(nombreArchivo)
                Exit While
            Catch ex As XmlException

                MessageBox.Show("Archivo de configuración " & nombreArchivo & " dañado ",
                                "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If System.IO.File.Exists(nombreArchivo) = True Then
                    System.IO.File.Delete(nombreArchivo)
                End If

                crearEsquemaXML()
                XMLDoc.Load(nombreArchivo)
                Exit While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End While
        Return XMLDoc
    End Function

    Private Sub crearEsquemaXML()

        Dim doc As New XDocument(New XDeclaration("1.0", "UTF-8", String.Empty),
                 New XElement("root",
                     New XElement("ConnectionString",
                         New XElement("Servidor", ""),
                         New XElement("Usuario", ""),
                         New XElement("Pass", ""),
                         New XElement("BD", ""))
                     )
                 )
        doc.Save(nombreArchivo)
    End Sub

    Friend Sub guardarXML(ByRef XMLdoc As XmlDocument)
        XMLdoc.Save(nombreArchivo)
    End Sub

    Friend Function obtenerNodo(ByRef XMLdoc As XmlDocument, ubicacion As String) As XmlElement

        Dim nodoActual As XmlElement
        nodoActual = XMLdoc.SelectSingleNode(ubicacion)

        If nodoActual Is Nothing Then

            Dim nodos As List(Of String) = ubicacion.Split("/").ToList
            For i = 1 To nodos.Count
                nodos.Remove("")
            Next

            Dim ubicacionNodoPadre As String = "/"
            For i = 0 To nodos.Count - 2
                ubicacionNodoPadre &= nodos(i) & "/"
            Next
            ubicacionNodoPadre = Left(ubicacionNodoPadre, ubicacionNodoPadre.Count - 1)

            Dim nodoPadre As XmlElement
            nodoPadre = XMLdoc.SelectSingleNode(ubicacionNodoPadre)
            nodoActual = XMLdoc.CreateElement(nodos(nodos.Count - 1))
            nodoActual.InnerText = ""
            nodoPadre.AppendChild(nodoActual)

            guardarXML(XMLdoc)
        End If

        Return nodoActual
    End Function

    Friend Function obtenerValorNodo(ByRef nodo As XmlNode, valorDefecto As Object)

        If nodo.InnerText = "" Then
            Return valorDefecto
        Else
            Return nodo.InnerText
        End If
    End Function
End Module
