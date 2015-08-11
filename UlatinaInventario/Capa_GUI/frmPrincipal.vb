Public Class frmPrincipal

    Private Sub AsstesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsstesToolStripMenuItem.Click
        Try



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IngresoDeBienesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeBienesToolStripMenuItem.Click
        Try
            frmIngresoBienes.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            CrearConexion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   


    Private Sub ConsultaXNombre(ByVal nombre As String)

        Try

            Dim strSQL As String = Nothing
            Dim datos As DataSet = Nothing

            strSQL = "exec Sp_Cns_bienes_X_nombre '" & nombre & "'"
            datos = cnx_conexion.obtenerEsquema(strSQL)

            Me.DataGridView1.DataSource = datos.Tables(0)
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.Refresh()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Try

            Me.ConsultaXNombre(Me.TextBox1.Text.Trim)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub IngresoDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeUsuariosToolStripMenuItem.Click
        Try

            frmRegistroUsuario.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RegistroDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeDepartamentosToolStripMenuItem.Click
        Try

            frmRegistroDepartamento.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RegistroDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeUsuariosToolStripMenuItem.Click
        Try
            frmRegistroUsuario.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ReporteDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeUsuariosToolStripMenuItem.Click
        Try
            BaseReportesUsuarios.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class