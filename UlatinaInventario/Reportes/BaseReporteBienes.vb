Public Class BaseReporteBienes

    Private Sub BaseReporteBienes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'UlatinaDataSet.Vp_Bienes' Puede moverla o quitarla según sea necesario.
        Me.Vp_BienesTableAdapter.Fill(Me.UlatinaDataSet.Vp_Bienes)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class