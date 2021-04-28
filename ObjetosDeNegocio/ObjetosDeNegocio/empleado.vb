
Imports AccesoBD

Public Class empleado

    Property nombre As String
    Property idEmpleado As Integer

    Property ventas As ventas

    Private Servidor As String
    Private NombreBD As String
    Private Usuario As String
    Private Contrasenia As String

    Sub New(parServidor As String, parBD As String, parUsuario As String, parContrasenia As String)

        Servidor = parServidor
        NombreBD = parBD
        Usuario = parUsuario
        Contrasenia = parContrasenia

        Me.resetear()

    End Sub


    Public Sub cargarPorId(id As Integer)
        Dim datos As DataTable
        Dim bdObjeto As New BDempleado(Servidor, NombreBD, Usuario, Contrasenia)

        datos = bdObjeto.obtenerPorID(id)

        If datos.Rows.Count > 0 Then

            cargar(datos.Rows(0))

        End If
    End Sub

    Public Sub cargarCompletoPorId(id As Integer)
        cargarPorId(id)
        cargarObjetos()
    End Sub


    Friend Sub cargar(row As DataRow)
        nombre = row.Item("nombre")
        idEmpleado = row.Item("idEmpleado")

    End Sub



    Public Sub agregar(guardador As Guardador)

        Dim bdObjeto As New BDempleado(Servidor, NombreBD, Usuario, Contrasenia)

        bdObjeto.agregar(guardador.mySqlCommand, guardador.indiceParametro,
                nombre)


    End Sub



    Public Sub actualizar(guardador As Guardador)

        Dim bdObj As New BDempleado(Servidor, NombreBD, Usuario, Contrasenia)

        bdObj.actualizar(guardador.mySqlCommand, guardador.indiceParametro,
                nombre,
                idEmpleado)

    End Sub




    Public Sub borrar()
        If idEmpleado <> 0 Then

            Try
                Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
                Dim bdObj As New BDempleado(Servidor, NombreBD, Usuario, Contrasenia)

                bdObj.borrar(guardador.mySqlCommand, guardador.indiceParametro,
                                                    idEmpleado)
                guardador.guardar()

            Catch ex As Exception
                Throw New Exception("No se pudo eliminar: empleado.")
            End Try
        End If
    End Sub



    Public Sub guardar()


        Dim guardador As New Guardador(Servidor, NombreBD, Usuario, Contrasenia)
        Dim nuevoRegistro As Boolean = False

        If idEmpleado = 0 Then

            nuevoRegistro = True
            agregar(guardador)
        Else
            actualizar(guardador)
        End If

        Try
            guardador.guardar()

        Catch ex As Exception

            If nuevoRegistro Then
                Me.resetear()
            End If

            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub cargarObjetos()
        cargarVentasPorIdEmpleado(Me.idEmpleado)
    End Sub
    Private Sub cargarVentasPorIdEmpleado(id As Integer)
        If id <> 0 Then
            ventas.cargarListaPorEmpleado(id)
        End If
    End Sub
    Private Sub resetearObjetos()
        ventas = New ventas(Servidor, NombreBD, Usuario, Contrasenia)
    End Sub

    Private Sub resetear()
        nombre = ""
        idEmpleado = 0

        resetearObjetos()

    End Sub



End Class
