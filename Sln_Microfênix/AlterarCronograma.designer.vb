<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterarCronograma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlterarCronograma))
        Me.txtSalaCronograma = New System.Windows.Forms.TextBox()
        Me.txtSala = New System.Windows.Forms.Label()
        Me.btnSairCadastroDisciplina = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.txtFuncionario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskDataHoraCronograma = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTurmaCronograma = New System.Windows.Forms.TextBox()
        Me.txtDocenteCronograma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDisciplinaCronograma = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtIdDisciplina = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSalaCronograma
        '
        Me.txtSalaCronograma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalaCronograma.Location = New System.Drawing.Point(99, 60)
        Me.txtSalaCronograma.Name = "txtSalaCronograma"
        Me.txtSalaCronograma.Size = New System.Drawing.Size(100, 22)
        Me.txtSalaCronograma.TabIndex = 1
        '
        'txtSala
        '
        Me.txtSala.AutoSize = True
        Me.txtSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSala.ForeColor = System.Drawing.Color.Maroon
        Me.txtSala.Location = New System.Drawing.Point(12, 63)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(41, 16)
        Me.txtSala.TabIndex = 206
        Me.txtSala.Text = "Sala:"
        '
        'btnSairCadastroDisciplina
        '
        Me.btnSairCadastroDisciplina.BackColor = System.Drawing.Color.Maroon
        Me.btnSairCadastroDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSairCadastroDisciplina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSairCadastroDisciplina.ForeColor = System.Drawing.Color.White
        Me.btnSairCadastroDisciplina.Location = New System.Drawing.Point(282, 394)
        Me.btnSairCadastroDisciplina.Name = "btnSairCadastroDisciplina"
        Me.btnSairCadastroDisciplina.Size = New System.Drawing.Size(150, 32)
        Me.btnSairCadastroDisciplina.TabIndex = 203
        Me.btnSairCadastroDisciplina.Text = "Sair"
        Me.btnSairCadastroDisciplina.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Maroon
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExcluir.Location = New System.Drawing.Point(113, 345)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(150, 32)
        Me.btnExcluir.TabIndex = 202
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.Maroon
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.White
        Me.btnAlterar.Location = New System.Drawing.Point(113, 295)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(150, 32)
        Me.btnAlterar.TabIndex = 201
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(282, 345)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(150, 32)
        Me.btnLimpar.TabIndex = 200
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'txtFuncionario
        '
        Me.txtFuncionario.Enabled = False
        Me.txtFuncionario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuncionario.Location = New System.Drawing.Point(99, 245)
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.Size = New System.Drawing.Size(333, 22)
        Me.txtFuncionario.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(12, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 196
        Me.Label5.Text = "Funcionário:"
        '
        'mskDataHoraCronograma
        '
        Me.mskDataHoraCronograma.Location = New System.Drawing.Point(309, 201)
        Me.mskDataHoraCronograma.Mask = "00/00/0000 00:00"
        Me.mskDataHoraCronograma.Name = "mskDataHoraCronograma"
        Me.mskDataHoraCronograma.Size = New System.Drawing.Size(123, 20)
        Me.mskDataHoraCronograma.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(216, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "Data e Hora:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(12, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "Turma:"
        '
        'txtTurmaCronograma
        '
        Me.txtTurmaCronograma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurmaCronograma.Location = New System.Drawing.Point(99, 199)
        Me.txtTurmaCronograma.Name = "txtTurmaCronograma"
        Me.txtTurmaCronograma.Size = New System.Drawing.Size(100, 22)
        Me.txtTurmaCronograma.TabIndex = 5
        '
        'txtDocenteCronograma
        '
        Me.txtDocenteCronograma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocenteCronograma.Location = New System.Drawing.Point(99, 152)
        Me.txtDocenteCronograma.Name = "txtDocenteCronograma"
        Me.txtDocenteCronograma.Size = New System.Drawing.Size(333, 22)
        Me.txtDocenteCronograma.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Docente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(86, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 22)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Alterar/Excluir Cronograma Sala"
        '
        'txtDisciplinaCronograma
        '
        Me.txtDisciplinaCronograma.Enabled = False
        Me.txtDisciplinaCronograma.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisciplinaCronograma.Location = New System.Drawing.Point(99, 106)
        Me.txtDisciplinaCronograma.Name = "txtDisciplinaCronograma"
        Me.txtDisciplinaCronograma.Size = New System.Drawing.Size(333, 22)
        Me.txtDisciplinaCronograma.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(12, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "Disciplina:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 295)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 204
        Me.PictureBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(282, 295)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(150, 32)
        Me.btnBuscar.TabIndex = 199
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtIdDisciplina
        '
        Me.txtIdDisciplina.Enabled = False
        Me.txtIdDisciplina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDisciplina.Location = New System.Drawing.Point(325, 60)
        Me.txtIdDisciplina.Name = "txtIdDisciplina"
        Me.txtIdDisciplina.Size = New System.Drawing.Size(107, 22)
        Me.txtIdDisciplina.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(216, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "Cod Disciplina:"
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(307, 432)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 209
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AlterarCronograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(451, 462)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtIdDisciplina)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSalaCronograma)
        Me.Controls.Add(Me.txtSala)
        Me.Controls.Add(Me.btnSairCadastroDisciplina)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnBuscar)
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
        Me.Name = "AlterarCronograma"
        Me.Text = "AlterarCronograma"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSalaCronograma As System.Windows.Forms.TextBox
    Friend WithEvents txtSala As System.Windows.Forms.Label
    Friend WithEvents btnSairCadastroDisciplina As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents txtFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mskDataHoraCronograma As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTurmaCronograma As System.Windows.Forms.TextBox
    Friend WithEvents txtDocenteCronograma As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDisciplinaCronograma As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtIdDisciplina As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
