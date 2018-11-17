<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatriculaAluno
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MatriculaAluno))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExcluiMatricula = New System.Windows.Forms.Button()
        Me.txtObsMatricula = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAlunoMatricula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFormaPagtoMatricula = New System.Windows.Forms.ComboBox()
        Me.cmbModoPagtoMatricula = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLimpaMatricula = New System.Windows.Forms.Button()
        Me.btnBuscaMatricula = New System.Windows.Forms.Button()
        Me.btnAlteraMatricula = New System.Windows.Forms.Button()
        Me.btnMatricular = New System.Windows.Forms.Button()
        Me.mskCpfMatricula = New System.Windows.Forms.MaskedTextBox()
        Me.txtBuscaMatricula = New System.Windows.Forms.TextBox()
        Me.mskDataMatricula = New System.Windows.Forms.MaskedTextBox()
        Me.txtPagtoMatricula = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdDisciplina = New System.Windows.Forms.TextBox()
        Me.txtNomeDisciplina = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDisciplina = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 424)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'btnExcluiMatricula
        '
        Me.btnExcluiMatricula.BackColor = System.Drawing.Color.Maroon
        Me.btnExcluiMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluiMatricula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluiMatricula.ForeColor = System.Drawing.Color.White
        Me.btnExcluiMatricula.Location = New System.Drawing.Point(444, 478)
        Me.btnExcluiMatricula.Name = "btnExcluiMatricula"
        Me.btnExcluiMatricula.Size = New System.Drawing.Size(106, 32)
        Me.btnExcluiMatricula.TabIndex = 13
        Me.btnExcluiMatricula.Text = "Excluir"
        Me.btnExcluiMatricula.UseVisualStyleBackColor = False
        '
        'txtObsMatricula
        '
        Me.txtObsMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsMatricula.Location = New System.Drawing.Point(109, 356)
        Me.txtObsMatricula.Multiline = True
        Me.txtObsMatricula.Name = "txtObsMatricula"
        Me.txtObsMatricula.Size = New System.Drawing.Size(441, 107)
        Me.txtObsMatricula.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(16, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Modo de Pagamento Parcelado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(16, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Forma de Pagamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(16, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Valor Total do Pagamento R$:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(16, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Data da Matrícula (dd/mm/aaaa):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(16, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "C.P.F. (apenas nº):"
        '
        'txtAlunoMatricula
        '
        Me.txtAlunoMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlunoMatricula.Location = New System.Drawing.Point(70, 129)
        Me.txtAlunoMatricula.Name = "txtAlunoMatricula"
        Me.txtAlunoMatricula.Size = New System.Drawing.Size(479, 22)
        Me.txtAlunoMatricula.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(16, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Aluno:"
        '
        'cmbFormaPagtoMatricula
        '
        Me.cmbFormaPagtoMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaPagtoMatricula.FormattingEnabled = True
        Me.cmbFormaPagtoMatricula.Items.AddRange(New Object() {"À vista", "Parcelado - até 5x", "Parcelado - acima de 6x"})
        Me.cmbFormaPagtoMatricula.Location = New System.Drawing.Point(184, 283)
        Me.cmbFormaPagtoMatricula.Name = "cmbFormaPagtoMatricula"
        Me.cmbFormaPagtoMatricula.Size = New System.Drawing.Size(366, 21)
        Me.cmbFormaPagtoMatricula.TabIndex = 8
        '
        'cmbModoPagtoMatricula
        '
        Me.cmbModoPagtoMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModoPagtoMatricula.FormattingEnabled = True
        Me.cmbModoPagtoMatricula.Items.AddRange(New Object() {"Cartão de crédito", "Cheque", "Boleto"})
        Me.cmbModoPagtoMatricula.Location = New System.Drawing.Point(235, 320)
        Me.cmbModoPagtoMatricula.Name = "cmbModoPagtoMatricula"
        Me.cmbModoPagtoMatricula.Size = New System.Drawing.Size(315, 21)
        Me.cmbModoPagtoMatricula.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(16, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Observação:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(16, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "C.P.F. do Aluno:"
        '
        'btnLimpaMatricula
        '
        Me.btnLimpaMatricula.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpaMatricula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpaMatricula.ForeColor = System.Drawing.Color.White
        Me.btnLimpaMatricula.Location = New System.Drawing.Point(400, 48)
        Me.btnLimpaMatricula.Name = "btnLimpaMatricula"
        Me.btnLimpaMatricula.Size = New System.Drawing.Size(150, 32)
        Me.btnLimpaMatricula.TabIndex = 3
        Me.btnLimpaMatricula.Text = "Limpar"
        Me.btnLimpaMatricula.UseVisualStyleBackColor = False
        '
        'btnBuscaMatricula
        '
        Me.btnBuscaMatricula.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscaMatricula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaMatricula.ForeColor = System.Drawing.Color.White
        Me.btnBuscaMatricula.Location = New System.Drawing.Point(235, 48)
        Me.btnBuscaMatricula.Name = "btnBuscaMatricula"
        Me.btnBuscaMatricula.Size = New System.Drawing.Size(150, 32)
        Me.btnBuscaMatricula.TabIndex = 2
        Me.btnBuscaMatricula.Text = "Buscar"
        Me.btnBuscaMatricula.UseVisualStyleBackColor = False
        '
        'btnAlteraMatricula
        '
        Me.btnAlteraMatricula.BackColor = System.Drawing.Color.Maroon
        Me.btnAlteraMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlteraMatricula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlteraMatricula.ForeColor = System.Drawing.Color.White
        Me.btnAlteraMatricula.Location = New System.Drawing.Point(323, 478)
        Me.btnAlteraMatricula.Name = "btnAlteraMatricula"
        Me.btnAlteraMatricula.Size = New System.Drawing.Size(106, 32)
        Me.btnAlteraMatricula.TabIndex = 12
        Me.btnAlteraMatricula.Text = "Alterar"
        Me.btnAlteraMatricula.UseVisualStyleBackColor = False
        '
        'btnMatricular
        '
        Me.btnMatricular.BackColor = System.Drawing.Color.Maroon
        Me.btnMatricular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMatricular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatricular.ForeColor = System.Drawing.Color.White
        Me.btnMatricular.Location = New System.Drawing.Point(198, 478)
        Me.btnMatricular.Name = "btnMatricular"
        Me.btnMatricular.Size = New System.Drawing.Size(106, 32)
        Me.btnMatricular.TabIndex = 11
        Me.btnMatricular.Text = "Matricular"
        Me.btnMatricular.UseVisualStyleBackColor = False
        '
        'mskCpfMatricula
        '
        Me.mskCpfMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCpfMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCpfMatricula.ForeColor = System.Drawing.Color.Maroon
        Me.mskCpfMatricula.Location = New System.Drawing.Point(144, 169)
        Me.mskCpfMatricula.Mask = "000.000.000-00"
        Me.mskCpfMatricula.Name = "mskCpfMatricula"
        Me.mskCpfMatricula.Size = New System.Drawing.Size(406, 15)
        Me.mskCpfMatricula.TabIndex = 5
        '
        'txtBuscaMatricula
        '
        Me.txtBuscaMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaMatricula.Location = New System.Drawing.Point(130, 12)
        Me.txtBuscaMatricula.Name = "txtBuscaMatricula"
        Me.txtBuscaMatricula.Size = New System.Drawing.Size(420, 22)
        Me.txtBuscaMatricula.TabIndex = 0
        '
        'mskDataMatricula
        '
        Me.mskDataMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskDataMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskDataMatricula.ForeColor = System.Drawing.Color.Maroon
        Me.mskDataMatricula.Location = New System.Drawing.Point(238, 209)
        Me.mskDataMatricula.Mask = "00/00/0000"
        Me.mskDataMatricula.Name = "mskDataMatricula"
        Me.mskDataMatricula.Size = New System.Drawing.Size(312, 15)
        Me.mskDataMatricula.TabIndex = 6
        '
        'txtPagtoMatricula
        '
        Me.txtPagtoMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagtoMatricula.Location = New System.Drawing.Point(219, 246)
        Me.txtPagtoMatricula.Name = "txtPagtoMatricula"
        Me.txtPagtoMatricula.Size = New System.Drawing.Size(331, 22)
        Me.txtPagtoMatricula.TabIndex = 7
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(426, 534)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 189
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Cód Disciplina"
        '
        'txtIdDisciplina
        '
        Me.txtIdDisciplina.Enabled = False
        Me.txtIdDisciplina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDisciplina.Location = New System.Drawing.Point(121, 93)
        Me.txtIdDisciplina.Name = "txtIdDisciplina"
        Me.txtIdDisciplina.Size = New System.Drawing.Size(92, 22)
        Me.txtIdDisciplina.TabIndex = 191
        '
        'txtNomeDisciplina
        '
        Me.txtNomeDisciplina.Enabled = False
        Me.txtNomeDisciplina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeDisciplina.Location = New System.Drawing.Point(305, 93)
        Me.txtNomeDisciplina.Name = "txtNomeDisciplina"
        Me.txtNomeDisciplina.Size = New System.Drawing.Size(206, 22)
        Me.txtNomeDisciplina.TabIndex = 193
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(232, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "Disciplina"
        '
        'btnDisciplina
        '
        Me.btnDisciplina.BackgroundImage = CType(resources.GetObject("btnDisciplina.BackgroundImage"), System.Drawing.Image)
        Me.btnDisciplina.Location = New System.Drawing.Point(518, 84)
        Me.btnDisciplina.Name = "btnDisciplina"
        Me.btnDisciplina.Size = New System.Drawing.Size(32, 33)
        Me.btnDisciplina.TabIndex = 194
        Me.btnDisciplina.UseVisualStyleBackColor = True
        '
        'MatriculaAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 563)
        Me.Controls.Add(Me.btnDisciplina)
        Me.Controls.Add(Me.txtNomeDisciplina)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIdDisciplina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtPagtoMatricula)
        Me.Controls.Add(Me.mskDataMatricula)
        Me.Controls.Add(Me.mskCpfMatricula)
        Me.Controls.Add(Me.btnMatricular)
        Me.Controls.Add(Me.btnAlteraMatricula)
        Me.Controls.Add(Me.btnBuscaMatricula)
        Me.Controls.Add(Me.btnLimpaMatricula)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBuscaMatricula)
        Me.Controls.Add(Me.txtObsMatricula)
        Me.Controls.Add(Me.cmbModoPagtoMatricula)
        Me.Controls.Add(Me.cmbFormaPagtoMatricula)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExcluiMatricula)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAlunoMatricula)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MatriculaAluno"
        Me.Text = "Matricula"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcluiMatricula As System.Windows.Forms.Button
    Friend WithEvents txtObsMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAlunoMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFormaPagtoMatricula As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModoPagtoMatricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnLimpaMatricula As System.Windows.Forms.Button
    Friend WithEvents btnBuscaMatricula As System.Windows.Forms.Button
    Friend WithEvents btnAlteraMatricula As System.Windows.Forms.Button
    Friend WithEvents btnMatricular As System.Windows.Forms.Button
    Friend WithEvents mskCpfMatricula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBuscaMatricula As System.Windows.Forms.TextBox
    Friend WithEvents mskDataMatricula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPagtoMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdDisciplina As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeDisciplina As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnDisciplina As System.Windows.Forms.Button
End Class
