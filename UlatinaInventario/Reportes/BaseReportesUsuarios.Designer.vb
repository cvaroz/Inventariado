<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseReportesUsuarios
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
        Me.Tbl_usuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UlatinaDataSet1 = New UlatinaInventario.UlatinaDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tbl_usuariosTableAdapter = New UlatinaInventario.UlatinaDataSet1TableAdapters.Tbl_usuariosTableAdapter()
        CType(Me.Tbl_usuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UlatinaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tbl_usuariosBindingSource
        '
        Me.Tbl_usuariosBindingSource.DataMember = "Tbl_usuarios"
        Me.Tbl_usuariosBindingSource.DataSource = Me.UlatinaDataSet1
        '
        'UlatinaDataSet1
        '
        Me.UlatinaDataSet1.DataSetName = "UlatinaDataSet1"
        Me.UlatinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetUsuarios1"
        ReportDataSource1.Value = Me.Tbl_usuariosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UlatinaInventario.ReporteUsuarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(762, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'Tbl_usuariosTableAdapter
        '
        Me.Tbl_usuariosTableAdapter.ClearBeforeFill = True
        '
        'BaseReportesUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BaseReportesUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaseReportesUsuarios"
        CType(Me.Tbl_usuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UlatinaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tbl_usuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UlatinaDataSet1 As UlatinaInventario.UlatinaDataSet1
    Friend WithEvents Tbl_usuariosTableAdapter As UlatinaInventario.UlatinaDataSet1TableAdapters.Tbl_usuariosTableAdapter
End Class
