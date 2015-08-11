<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseReporteBienes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Vp_BienesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UlatinaDataSet = New UlatinaInventario.UlatinaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Vp_BienesTableAdapter = New UlatinaInventario.UlatinaDataSetTableAdapters.Vp_BienesTableAdapter()
        CType(Me.Vp_BienesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UlatinaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vp_BienesBindingSource
        '
        Me.Vp_BienesBindingSource.DataMember = "Vp_Bienes"
        Me.Vp_BienesBindingSource.DataSource = Me.UlatinaDataSet
        '
        'UlatinaDataSet
        '
        Me.UlatinaDataSet.DataSetName = "UlatinaDataSet"
        Me.UlatinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetReporteBienes1"
        ReportDataSource1.Value = Me.Vp_BienesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UlatinaInventario.ReporteBienes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(674, 409)
        Me.ReportViewer1.TabIndex = 0
        '
        'Vp_BienesTableAdapter
        '
        Me.Vp_BienesTableAdapter.ClearBeforeFill = True
        '
        'BaseReporteBienes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 409)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BaseReporteBienes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaseReporteBienes"
        CType(Me.Vp_BienesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UlatinaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Vp_BienesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UlatinaDataSet As UlatinaInventario.UlatinaDataSet
    Friend WithEvents Vp_BienesTableAdapter As UlatinaInventario.UlatinaDataSetTableAdapters.Vp_BienesTableAdapter
End Class
