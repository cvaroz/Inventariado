Public Class BaseReportesUsuarios

    Private Sub BaseReportesUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UlatinaDataSet1.Tbl_usuarios' Puede moverla o quitarla según sea necesario.
        Me.Tbl_usuariosTableAdapter.Fill(Me.UlatinaDataSet1.Tbl_usuarios)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class