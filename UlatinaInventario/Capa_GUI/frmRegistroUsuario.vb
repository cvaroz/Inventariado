Public Class frmRegistroUsuario

    Private var_users As UlatinaInventario.Users

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            'If Not Me.existe(Me.txtidentificacion.Text.Trim) Then



            If MessageBox.Show("Desea registar el usuario con los siguientes datos" & vbCrLf &
                               "" & vbCrLf &
                        "Numero de identificacion: " + txtidentificacion.Text & vbCrLf &
                        "Nombre: " + txtnombre.Text & vbCrLf &
                        "Nombre de usuario: " + txtNombreUsuario.Text & vbCrLf &
                       "Edad: " + ComboEdad.Text & vbCrLf &
                        "Sexo: " + ComboBoSexo.Text & vbCrLf &
                        "Telefono: " + MskTelefono.Text & vbCrLf &
                    "E-mail: " + Txtemail.Text & vbCrLf & "Contraseña: " + txtContraseña.Text, "Informacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then




                'Me.txtSerie.Text.Trim,
                ''Var_usuario esta declarado en el inicio de este formulario
                var_users = New UlatinaInventario.Users(Me.txtidentificacion.Text.Trim, _
                                                                   Me.txtnombre.Text.Trim, Me.txtNombreUsuario.Text.Trim, _
                                                                   Me.ComboEdad.Text, Me.ComboBoSexo.Text.Trim, _
                                                                   Me.MskTelefono.Text.Trim, Me.Txtemail.Text.Trim, txtContraseña.Text.Trim)
                Me.registrarUsuarios(var_users)
                'Me.limpiar()
                'CargarBienes()
                MessageBox.Show("Usuario registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'DataGridView1.Visible = True
            End If




            'Else

            'MessageBox.Show("Ya se encuentra registrado el bien con el numero de serie: " + txtSerie.Text, "Error en el  ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)


            'End If



        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & "si el error persiste comuniquese con el encargado del sistema ",
                        "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub frmRegistroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub registrarUsuarios(var_users As UlatinaInventario.Users)
        Try

            cnx_conexion.abrirCnx()


            Dim cmd As New SqlClient.SqlCommand("exec Sp_Ins_usuarios @usua_identificacion, @usua_nombre,@usua_nombreusuario,@usua_edad,@usua_sexo,@usua_telefono,@usua_email,@usua_contraseña", cnx_conexion.conexion)

            With cmd


                .Parameters.Add(New SqlClient.SqlParameter("@usua_identificacion", SqlDbType.VarChar, 30)).Value = Me.txtidentificacion.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@usua_nombre", SqlDbType.VarChar, 30)).Value = Me.txtnombre.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@usua_nombreusuario", SqlDbType.VarChar, 30)).Value = Me.txtNombreUsuario.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@usua_edad", SqlDbType.Int)).Value = Me.ComboEdad.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@usua_sexo", SqlDbType.VarChar, 30)).Value = Me.ComboBoSexo.Text
                .Parameters.Add(New SqlClient.SqlParameter("@usua_telefono", SqlDbType.VarChar, 30)).Value = Me.MskTelefono.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@usua_email", SqlDbType.VarChar, 50)).Value = Me.Txtemail.Text
                .Parameters.Add(New SqlClient.SqlParameter("@usua_contraseña", SqlDbType.VarChar, 30)).Value = Me.txtContraseña.Text

            End With

            cmd.ExecuteNonQuery()
            cnx_conexion.conexion.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

   

End Class