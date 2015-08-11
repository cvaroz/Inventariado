<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoBienes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnIngresoInventario = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ComboCondicion = New System.Windows.Forms.ComboBox()
        Me.LblCondicion = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ComboDepartamentos = New System.Windows.Forms.ComboBox()
        Me.LblDepartamento = New System.Windows.Forms.Label()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.RichDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lblNseri = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 307)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(792, 185)
        Me.DataGridView1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnIngresoInventario)
        Me.Panel1.Location = New System.Drawing.Point(12, 247)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 42)
        Me.Panel1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(516, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(347, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnIngresoInventario
        '
        Me.btnIngresoInventario.Location = New System.Drawing.Point(188, 16)
        Me.btnIngresoInventario.Name = "btnIngresoInventario"
        Me.btnIngresoInventario.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresoInventario.TabIndex = 0
        Me.btnIngresoInventario.Text = "Insertar"
        Me.btnIngresoInventario.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.ComboCondicion)
        Me.Panel2.Controls.Add(Me.LblCondicion)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.ComboDepartamentos)
        Me.Panel2.Controls.Add(Me.LblDepartamento)
        Me.Panel2.Controls.Add(Me.TxtColor)
        Me.Panel2.Controls.Add(Me.lblColor)
        Me.Panel2.Controls.Add(Me.RichDescripcion)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtNombre)
        Me.Panel2.Controls.Add(Me.LblNombre)
        Me.Panel2.Controls.Add(Me.TxtModelo)
        Me.Panel2.Controls.Add(Me.LblModelo)
        Me.Panel2.Controls.Add(Me.txtMarca)
        Me.Panel2.Controls.Add(Me.LblMarca)
        Me.Panel2.Controls.Add(Me.txtSerie)
        Me.Panel2.Controls.Add(Me.lblNseri)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 214)
        Me.Panel2.TabIndex = 10
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(27, 179)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(94, 13)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Reporte de bienes"
        '
        'ComboCondicion
        '
        Me.ComboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCondicion.FormattingEnabled = True
        Me.ComboCondicion.Items.AddRange(New Object() {"Buen estado", "Regular estado ", "Mal estado"})
        Me.ComboCondicion.Location = New System.Drawing.Point(473, 113)
        Me.ComboCondicion.Name = "ComboCondicion"
        Me.ComboCondicion.Size = New System.Drawing.Size(157, 21)
        Me.ComboCondicion.TabIndex = 13
        '
        'LblCondicion
        '
        Me.LblCondicion.AutoSize = True
        Me.LblCondicion.Location = New System.Drawing.Point(393, 121)
        Me.LblCondicion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCondicion.Name = "LblCondicion"
        Me.LblCondicion.Size = New System.Drawing.Size(57, 13)
        Me.LblCondicion.TabIndex = 12
        Me.LblCondicion.Text = "Condicion:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(669, 150)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 13)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ingresar"
        '
        'ComboDepartamentos
        '
        Me.ComboDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDepartamentos.FormattingEnabled = True
        Me.ComboDepartamentos.Items.AddRange(New Object() {"Direccion"})
        Me.ComboDepartamentos.Location = New System.Drawing.Point(474, 147)
        Me.ComboDepartamentos.Name = "ComboDepartamentos"
        Me.ComboDepartamentos.Size = New System.Drawing.Size(173, 21)
        Me.ComboDepartamentos.TabIndex = 15
        '
        'LblDepartamento
        '
        Me.LblDepartamento.AutoSize = True
        Me.LblDepartamento.Location = New System.Drawing.Point(374, 155)
        Me.LblDepartamento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDepartamento.Name = "LblDepartamento"
        Me.LblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.LblDepartamento.TabIndex = 14
        Me.LblDepartamento.Text = "Departamento:"
        '
        'TxtColor
        '
        Me.TxtColor.Location = New System.Drawing.Point(95, 138)
        Me.TxtColor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(202, 20)
        Me.TxtColor.TabIndex = 9
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(25, 141)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 8
        Me.lblColor.Text = "Color:"
        '
        'RichDescripcion
        '
        Me.RichDescripcion.Location = New System.Drawing.Point(473, 17)
        Me.RichDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.RichDescripcion.Name = "RichDescripcion"
        Me.RichDescripcion.Size = New System.Drawing.Size(288, 83)
        Me.RichDescripcion.TabIndex = 11
        Me.RichDescripcion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Descripcion:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(95, 55)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(202, 20)
        Me.TxtNombre.TabIndex = 7
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(25, 58)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 6
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(94, 81)
        Me.TxtModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(203, 20)
        Me.TxtModelo.TabIndex = 5
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Location = New System.Drawing.Point(25, 84)
        Me.LblModelo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(45, 13)
        Me.LblModelo.TabIndex = 4
        Me.LblModelo.Text = "Modelo:"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(95, 109)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(202, 20)
        Me.txtMarca.TabIndex = 3
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(25, 112)
        Me.LblMarca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(40, 13)
        Me.LblMarca.TabIndex = 2
        Me.LblMarca.Text = "Marca:"
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtSerie.Location = New System.Drawing.Point(95, 19)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(120, 20)
        Me.txtSerie.TabIndex = 1
        '
        'lblNseri
        '
        Me.lblNseri.AutoSize = True
        Me.lblNseri.Location = New System.Drawing.Point(25, 20)
        Me.lblNseri.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNseri.Name = "lblNseri"
        Me.lblNseri.Size = New System.Drawing.Size(49, 13)
        Me.lblNseri.TabIndex = 0
        Me.lblNseri.Text = "N° Serie:"
        '
        'frmIngresoBienes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 504)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngresoBienes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de bienes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnIngresoInventario As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents LblModelo As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents LblMarca As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents lblNseri As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ComboDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents LblDepartamento As System.Windows.Forms.Label
    Friend WithEvents TxtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents RichDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboCondicion As System.Windows.Forms.ComboBox
    Friend WithEvents LblCondicion As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
End Class
