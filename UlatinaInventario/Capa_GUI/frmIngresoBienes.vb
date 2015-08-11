Imports System.Data.SqlClient
Public Class frmIngresoBienes

    Private var_bienes As UlatinaInventario.Assets

    Private Property Assets As Assets

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try


        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnIngresoInventario.Click
        Try

            If Not Me.existe(Me.txtSerie.Text.Trim) Then



                If MessageBox.Show("Desea registar el bien con los siguientes datos" & vbCrLf &
                                   "" & vbCrLf &
                            "Numero de serie: " + txtSerie.Text & vbCrLf &
                            "Marca: " + txtMarca.Text & vbCrLf &
                            "Modelo: " + TxtModelo.Text & vbCrLf &
                            "Nombre: " + TxtNombre.Text & vbCrLf &
                            "Descripcion: " + RichDescripcion.Text & vbCrLf &
                            "Color: " + TxtColor.Text & vbCrLf &
                            "Departamento: " + ComboDepartamentos.Text & vbCrLf &
                        "Condicion: " + ComboCondicion.Text, "Informacion de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then




                    'Me.txtSerie.Text.Trim,
                    ''Var_usuario esta declarado en el inicio de este formulario
                    var_bienes = New UlatinaInventario.Assets(Me.txtMarca.Text.Trim, _
                                                                       Me.TxtModelo.Text.Trim, Me.TxtNombre.Text.Trim, _
                                                                       Me.RichDescripcion.Text.Trim, Me.TxtColor.Text.Trim, _
                                                                       Me.ComboDepartamentos.Text.Trim, Me.ComboCondicion.Text.Trim)
                    Me.registrarClientes(var_bienes)
                    Me.limpiar()
                    CargarBienes()
                    MessageBox.Show("Bien registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DataGridView1.Visible = True
                End If




            Else

                MessageBox.Show("Ya se encuentra registrado el bien con el numero de serie: " + txtSerie.Text, "Error en el  ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & "si el error persiste comuniquese con el encargado del sistema ",
                        "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtSerie.Focus()


            'Throw ex
        End Try
    End Sub

    Private Sub frmIngresoBienes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            limpiar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CrearConexion()

            ComboDepartamentos.SelectedIndex = 0
            ComboCondicion.SelectedIndex = 0
            CargarBienes()
            txtSerie.Enabled = False

            If DataGridView1.RowCount < 1 Then

                DataGridView1.Visible = False


            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub registrarClientes(var_estudiante As UlatinaInventario.Assets)
        Try

            cnx_conexion.abrirCnx()

            '@biene_serie,

            Dim cmd As New SqlClient.SqlCommand("exec Sp_Ins_bienes @biene_marca, @biene_modelo,@biene_nombre,@biene_descripcion,@biene_color,@biene_departamento,@biene_codicion", cnx_conexion.conexion)

            With cmd

                '.Parameters.Add(New SqlClient.SqlParameter("@biene_serie", SqlDbType.VarChar, 15)).Value = Me.txtSerie.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_marca", SqlDbType.VarChar, 15)).Value = Me.txtMarca.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_modelo", SqlDbType.VarChar, 15)).Value = Me.TxtModelo.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_nombre", SqlDbType.VarChar, 15)).Value = Me.TxtNombre.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_descripcion", SqlDbType.VarChar, 30)).Value = Me.RichDescripcion.Text
                .Parameters.Add(New SqlClient.SqlParameter("@biene_color", SqlDbType.VarChar, 10)).Value = Me.TxtColor.Text
                .Parameters.Add(New SqlClient.SqlParameter("@biene_departamento", SqlDbType.VarChar, 12)).Value = Me.ComboDepartamentos.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_codicion", SqlDbType.VarChar, 15)).Value = Me.ComboCondicion.Text

            End With

            cmd.ExecuteNonQuery()
            cnx_conexion.conexion.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub limpiar()

        txtSerie.Text = ""
        TxtColor.Text = ""
        txtMarca.Text = ""
        TxtNombre.Text = ""
        TxtModelo.Text = ""
        RichDescripcion.Text = ""
        ComboCondicion.Text = "Buen estado"
        ComboDepartamentos.Text = ""


    End Sub


    Private Sub CargarBienes()

        Try

            Dim datos As DataSet = Nothing
            Dim strSQL As String = Nothing
            strSQL = "select * from [Vp_Bienes]"
            datos = cnx_conexion.obtenerEsquema(strSQL)
            Me.DataGridView1.DataSource = datos.Tables(0)
            Me.DataGridView1.ReadOnly = True

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Try
            If Me.DataGridView1.SelectedRows.Count <= 0 Then

                Throw New Exception("seleccione la fila del Paciente que desea consultar ")

            End If

            Me.txtSerie.Text = Me.DataGridView1.SelectedRows(0).Cells("serie").Value.ToString.Trim
            Me.ConsultarBien(Me.txtSerie.Text.Trim)
            'Me.TabControl1.SelectedTab = Me.TabPage1
            txtSerie.Enabled = False


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub ConsultarBien(ByVal serie As String)

        Try

            Dim strSQL As String = Nothing
            Dim datos As SqlClient.SqlDataReader = Nothing

            strSQL = "exec [Sp_Cns_Bienes] '" & serie & "'"
            datos = cnx_conexion.consultarSQL(strSQL)

            If datos.Read Then

                Me.txtSerie.Text = serie
                Me.txtMarca.Text = datos.Item("biene_marca").ToString.Trim
                Me.TxtModelo.Text = datos.Item("biene_modelo").ToString.Trim
                Me.TxtNombre.Text = datos.Item("biene_nombre").ToString.Trim
                Me.TxtColor.Text = datos.Item("biene_color").ToString.Trim
                Me.RichDescripcion.Text = datos.Item("biene_descripcion").ToString.Trim
                Me.ComboCondicion.Text = datos.Item("biene_codicion").ToString.Trim
                Me.ComboDepartamentos.Text = datos.Item("biene_departamento").ToString.Trim


            Else
                Throw New Exception("No existe registrado en el sistema ningun bien con el numero de serie : " & serie)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function existe(ByVal serie As String) As Boolean

        Try

            Dim registrado As Boolean = False
            Dim consulta As SqlClient.SqlDataReader = Nothing
            Dim strSQL As String = Nothing
            strSQL = "exec [Sp_Cns_Bienes] '" & serie & "'"
            consulta = cnx_conexion.consultarSQL(strSQL)

            If consulta.Read Then

                registrado = True

            End If

            Return registrado

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If Me.txtSerie.Text.Trim.Equals("") Then
                Throw New Exception("Digite el nùmero de serie de el bien que desea Modificar")
            End If

            If MessageBox.Show("Desea Modificar los datos del bien?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Assets = New UlatinaInventario.Assets(Me.txtMarca.Text.Trim, _
                                                                       Me.TxtModelo.Text.Trim, Me.TxtNombre.Text.Trim, _
                                                                       Me.RichDescripcion.Text.Trim, Me.TxtColor.Text.Trim, _
                                                                       Me.ComboDepartamentos.Text.Trim, Me.ComboCondicion.Text.Trim)

                'Me.txtSerie.Text.Trim, 

                Me.ModificarBien(Me.txtSerie.Text.Trim, Assets)
                MessageBox.Show("Bien Modificado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.limpiar()
                Me.CargarBienes()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & "si el error persiste comuniquese con el encargado del sistema ",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ModificarBien(ByVal cedula As String, ByVal paciente As Assets)

        Try

            cnx_conexion.abrirCnx()

            Dim cmd As New SqlClient.SqlCommand("exec Sp_Upd_Bien @biene_serie,@biene_marca, @biene_modelo,@biene_nombre,@biene_descripcion,@biene_color,@biene_departamento,@biene_codicion", cnx_conexion.conexion)

            With cmd


                .Parameters.Add(New SqlClient.SqlParameter("@biene_serie", SqlDbType.VarChar, 15)).Value = Me.txtSerie.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_marca", SqlDbType.VarChar, 15)).Value = Me.txtMarca.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_modelo", SqlDbType.VarChar, 15)).Value = Me.TxtModelo.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_nombre", SqlDbType.VarChar, 15)).Value = Me.TxtNombre.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_descripcion", SqlDbType.VarChar, 30)).Value = Me.RichDescripcion.Text
                .Parameters.Add(New SqlClient.SqlParameter("@biene_color", SqlDbType.VarChar, 10)).Value = Me.TxtColor.Text
                .Parameters.Add(New SqlClient.SqlParameter("@biene_departamento", SqlDbType.VarChar, 12)).Value = Me.ComboDepartamentos.Text.Trim
                .Parameters.Add(New SqlClient.SqlParameter("@biene_codicion", SqlDbType.VarChar, 15)).Value = Me.ComboCondicion.Text

            End With

            cmd.ExecuteNonQuery()
            cnx_conexion.conexion.Close()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            ConsultarBien(Me.txtSerie.Text.Trim)

            If Me.txtSerie.Text.Trim.Equals("") Then
                Throw New Exception("Digite el numero de usuario del bien a eliminar")
            End If

            If MessageBox.Show(" Desea eliminar los datos del bien registrado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Me.EliminarBien(Me.txtSerie.Text.Trim)
                MessageBox.Show("Bien liminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.limpiar()
                Me.CargarBienes()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & " si el error persiste comuniquese con el encargado del sistema ",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub EliminarBien(ByVal serie As String)

        Try

            Dim strSQL As String = Nothing
            strSQL = "exec [Sp_Del_Bienes] '" & serie & "'"
            cnx_conexion.ejecutarSQL(strSQL)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            BaseReporteBienes.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try

            frmRegistroDepartamento.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LblMarca_Click(sender As Object, e As EventArgs) Handles LblMarca.Click

    End Sub
End Class