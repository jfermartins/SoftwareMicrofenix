<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cronogramaSala
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cronogramaSala))
        Me.txtDisciplinaCronograma = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocenteCronograma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTurmaCronograma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskDataHoraCronograma = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFuncionario = New System.Windows.Forms.TextBox()
        Me.btnSairCadastroDisciplina = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCadastrarAtividade = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDisciplina = New System.Windows.Forms.Button()
        Me.txtSala = New System.Windows.Forms.Label()
        Me.txtSalaCronograma = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdDisciplina = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDisciplinaCronograma
        '
        Me.txtDisciplinaCronograma.Enabled = False
        Me.txtDisciplinaCronograma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisciplinaCronograma.Location = New System.Drawing.Point(110, 62)
        Me.txtDisciplinaCronograma.Name = "txtDisciplinaCronograma"
        Me.txtDisciplinaCronograma.Size = New System.Drawing.Size(295, 22)
        Me.txtDisciplinaCronograma.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(30, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 165
        Me.Label9.Text = "Disciplina:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 22)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Cronograma Sala"
        '
        'txtDocenteCronograma
        '
        Me.txtDocenteCronograma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocenteCronograma.Location = New System.Drawing.Point(110, 139)
        Me.txtDocenteCronograma.Name = "txtDocenteCronograma"
        Me.txtDocenteCronograma.Size = New System.Drawing.Size(333, 22)
        Me.txtDocenteCronograma.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(30, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Docente:"
        '
        'txtTurmaCronograma
        '
        Me.txtTurmaCronograma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurmaCronograma.Location = New System.Drawing.Point(110, 181)
        Me.txtTurmaCronograma.Name = "txtTurmaCronograma"
        Me.txtTurmaCronograma.Size = New System.Drawing.Size(100, 22)
        Me.txtTurmaCronograma.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(30, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "Turma:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(227, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Data e Hora:"
        '
        'mskDataHoraCronograma
        '
        Me.mskDataHoraCronograma.Location = New System.Drawing.Point(320, 183)
        Me.mskDataHoraCronograma.Mask = "00/00/0000 00:00"
        Me.mskDataHoraCronograma.Name = "mskDataHoraCronograma"
        Me.mskDataHoraCronograma.Size = New System.Drawing.Size(123, 20)
        Me.mskDataHoraCronograma.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(30, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Funcionário:"
        '
        'txtFuncionario
        '
        Me.txtFuncionario.Enabled = False
        Me.txtFuncionario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuncionario.Location = New System.Drawing.Point(124, 224)
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.Size = New System.Drawing.Size(319, 22)
        Me.txtFuncionario.TabIndex = 7
        '
        'btnSairCadastroDisciplina
        '
        Me.btnSairCadastroDisciplina.BackColor = System.Drawing.Color.Maroon
        Me.btnSairCadastroDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSairCadastroDisciplina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSairCadastroDisciplina.ForeColor = System.Drawing.Color.White
        Me.btnSairCadastroDisciplina.Location = New System.Drawing.Point(255, 355)
        Me.btnSairCadastroDisciplina.Name = "btnSairCadastroDisciplina"
        Me.btnSairCadastroDisciplina.Size = New System.Drawing.Size(150, 32)
        Me.btnSairCadastroDisciplina.TabIndex = 181
        Me.btnSairCadastroDisciplina.Text = "Sair"
        Me.btnSairCadastroDisciplina.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Maroon
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExcluir.Location = New System.Drawing.Point(99, 355)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(150, 32)
        Me.btnExcluir.TabIndex = 180
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.Maroon
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(99, 310)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(150, 32)
        Me.btnAlterar.TabIndex = 179
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(255, 310)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(150, 32)
        Me.btnLimpar.TabIndex = 178
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(255, 266)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(150, 32)
        Me.btnBuscar.TabIndex = 177
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnCadastrarAtividade
        '
        Me.btnCadastrarAtividade.BackColor = System.Drawing.Color.Maroon
        Me.btnCadastrarAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCadastrarAtividade.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarAtividade.ForeColor = System.Drawing.Color.White
        Me.btnCadastrarAtividade.Location = New System.Drawing.Point(99, 266)
        Me.btnCadastrarAtividade.Name = "btnCadastrarAtividade"
        Me.btnCadastrarAtividade.Size = New System.Drawing.Size(150, 32)
        Me.btnCadastrarAtividade.TabIndex = 176
        Me.btnCadastrarAtividade.Text = "Cadastrar"
        Me.btnCadastrarAtividade.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-64, 323)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(393, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 182
        Me.PictureBox1.TabStop = False
        '
        'btnDisciplina
        '
        Me.btnDisciplina.BackgroundImage = CType(resources.GetObject("btnDisciplina.BackgroundImage"), System.Drawing.Image)
        Me.btnDisciplina.Location = New System.Drawing.Point(411, 57)
        Me.btnDisciplina.Name = "btnDisciplina"
        Me.btnDisciplina.Size = New System.Drawing.Size(32, 33)
        Me.btnDisciplina.TabIndex = 184
        Me.btnDisciplina.UseVisualStyleBackColor = True
        '
        'txtSala
        '
        Me.txtSala.AutoSize = True
        Me.txtSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSala.ForeColor = System.Drawing.Color.Maroon
        Me.txtSala.Location = New System.Drawing.Point(30, 105)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(41, 16)
        Me.txtSala.TabIndex = 185
        Me.txtSala.Text = "Sala:"
        '
        'txtSalaCronograma
        '
        Me.txtSalaCronograma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalaCronograma.Location = New System.Drawing.Point(110, 102)
        Me.txtSalaCronograma.Name = "txtSalaCronograma"
        Me.txtSalaCronograma.Size = New System.Drawing.Size(100, 22)
        Me.txtSalaCronograma.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(227, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 187
        Me.Label6.Text = "Cod Disciplina:"
        '
        'txtIdDisciplina
        '
        Me.txtIdDisciplina.Enabled = False
        Me.txtIdDisciplina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDisciplina.Location = New System.Drawing.Point(336, 102)
        Me.txtIdDisciplina.Name = "txtIdDisciplina"
        Me.txtIdDisciplina.Size = New System.Drawing.Size(107, 22)
        Me.txtIdDisciplina.TabIndex = 3
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(359, 446)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 188
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cronogramaSala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(487, 470)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtIdDisciplina)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSalaCronograma)
        Me.Controls.Add(Me.txtSala)
        Me.Controls.Add(Me.btnDisciplina)
        Me.Controls.Add(Me.btnSairCadastroDisciplina)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCadastrarAtividade)
        Me.Controls.Add(Me.txtFuncionario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mskDataHoraCronograma)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTurmaCronograma)
        Me.Controls.Add(Me.txtDocenteCronograma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDisciplinaCronograma)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cronogramaSala"
        Me.Text = "cronogramaSala"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisciplinaCronograma As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDocenteCronograma As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTurmaCronograma As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mskDataHoraCronograma As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents btnSairCadastroDisciplina As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarAtividade As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDisciplina As System.Windows.Forms.Button
    Friend WithEvents txtSala As System.Windows.Forms.Label
    Friend WithEvents txtSalaCronograma As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIdDisciplina As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
