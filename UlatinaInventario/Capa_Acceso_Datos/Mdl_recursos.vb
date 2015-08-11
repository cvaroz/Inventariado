Module Mdl_recursos



    Public cnx_conexion As New Cls_conexion.Cls_conexion
    Public Sub CrearConexion()

        Try

            cnx_conexion.usuario = "cvaros"
            cnx_conexion.clave = "12345"
            cnx_conexion.dataBase = "Ulatina"
            cnx_conexion.servidor = "localhost"

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


End Module
