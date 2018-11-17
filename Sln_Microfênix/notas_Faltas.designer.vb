<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notas_Faltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notas_Faltas))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAlunoNota = New System.Windows.Forms.TextBox()
        Me.btnBuscarAlunoDisciplinaAtividade = New System.Windows.Forms.Button()
        Me.txtDisciplinaNota = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFaltas = New System.Windows.Forms.TextBox()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSairCadastroDisciplina = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtIdAluno = New System.Windows.Forms.TextBox()
        Me.txtIdDisciplina = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(35, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Aluno :"
        '
        'txtAlunoNota
        '
        Me.txtAlunoNota.Enabled = False
        Me.txtAlunoNota.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlunoNota.Location = New System.Drawing.Point(116, 30)
        Me.txtAlunoNota.Name = "txtAlunoNota"
        Me.txtAlunoNota.Size = New System.Drawing.Size(337, 22)
        Me.txtAlunoNota.TabIndex = 3
        '
        'btnBuscarAlunoDisciplinaAtividade
        '
        Me.btnBuscarAlunoDisciplinaAtividade.BackgroundImage = CType(resources.GetObject("btnBuscarAlunoDisciplinaAtividade.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarAlunoDisciplinaAtividade.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarAlunoDisciplinaAtividade.Location = New System.Drawing.Point(459, 26)
        Me.btnBuscarAlunoDisciplinaAtividade.Name = "btnBuscarAlunoDisciplinaAtividade"
        Me.btnBuscarAlunoDisciplinaAtividade.Size = New System.Drawing.Size(32, 31)
        Me.btnBuscarAlunoDisciplinaAtividade.TabIndex = 169
        Me.btnBuscarAlunoDisciplinaAtividade.UseVisualStyleBackColor = True
        '
        'txtDisciplinaNota
        '
        Me.txtDisciplinaNota.Enabled = False
        Me.txtDisciplinaNota.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisciplinaNota.Location = New System.Drawing.Point(116, 69)
        Me.txtDisciplinaNota.Name = "txtDisciplinaNota"
        Me.txtDisciplinaNota.Size = New System.Drawing.Size(375, 22)
        Me.txtDisciplinaNota.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(12, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 16)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "Disciplina :"
        '
        'txtFaltas
        '
        Me.txtFaltas.Enabled = False
        Me.txtFaltas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaltas.Location = New System.Drawing.Point(96, 158)
        Me.txtFaltas.Name = "txtFaltas"
        Me.txtFaltas.Size = New System.Drawing.Size(68, 22)
        Me.txtFaltas.TabIndex = 6
        '
        'txtMedia
        '
        Me.txtMedia.Enabled = False
        Me.txtMedia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedia.Location = New System.Drawing.Point(96, 118)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(68, 22)
        Me.txtMedia.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(35, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Média :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(36, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "Faltas :"
        '
        'btnSairCadastroDisciplina
        '
        Me.btnSairCadastroDisciplina.BackColor = System.Drawing.Color.Maroon
        Me.btnSairCadastroDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSairCadastroDisciplina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSairCadastroDisciplina.ForeColor = System.Drawing.Color.White
        Me.btnSairCadastroDisciplina.Location = New System.Drawing.Point(341, 176)
        Me.btnSairCadastroDisciplina.Name = "btnSairCadastroDisciplina"
        Me.btnSairCadastroDisciplina.Size = New System.Drawing.Size(150, 32)
        Me.btnSairCadastroDisciplina.TabIndex = 178
        Me.btnSairCadastroDisciplina.Text = "Sair"
        Me.btnSairCadastroDisciplina.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(341, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 32)
        Me.Button1.TabIndex = 179
        Me.Button1.Text = "Atribuir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtIdAluno
        '
        Me.txtIdAluno.Enabled = False
        Me.txtIdAluno.Location = New System.Drawing.Point(116, 4)
        Me.txtIdAluno.Name = "txtIdAluno"
        Me.txtIdAluno.Size = New System.Drawing.Size(104, 20)
        Me.txtIdAluno.TabIndex = 1
        '
        'txtIdDisciplina
        '
        Me.txtIdDisciplina.Enabled = False
        Me.txtIdDisciplina.Location = New System.Drawing.Point(387, 4)
        Me.txtIdDisciplina.Name = "txtIdDisciplina"
        Me.txtIdDisciplina.Size = New System.Drawing.Size(104, 20)
        Me.txtIdDisciplina.TabIndex = 2
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(341, 138)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(150, 32)
        Me.btnLimpar.TabIndex = 182
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(26, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Cód Aluno :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(269, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "Cód Disciplina :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 185
        Me.PictureBox1.TabStop = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(377, 224)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 190
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'notas_Faltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(510, 246)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.txtIdDisciplina)
        Me.Controls.Add(Me.txtIdAluno)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSairCadastroDisciplina)
        Me.Controls.Add(Me.txtFaltas)
        Me.Controls.Add(Me.txtMedia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDisciplinaNota)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnBuscarAlunoDisciplinaAtividade)
        Me.Controls.Add(Me.txtAlunoNota)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "notas_Faltas"
        Me.Text = "notas_Faltas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAlunoNota As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarAlunoDisciplinaAtividade As System.Windows.Forms.Button
    Friend WithEvents txtDisciplinaNota As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFaltas As System.Windows.Forms.TextBox
    Friend WithEvents txtMedia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSairCadastroDisciplina As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtIdAluno As System.Windows.Forms.TextBox
    Friend WithEvents txtIdDisciplina As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
