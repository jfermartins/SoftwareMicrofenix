<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastrarDisciplina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastrarDisciplina))
        Me.txtDisciplina = New System.Windows.Forms.TextBox()
        Me.txtNomeFuncionario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCadastroDisciplina = New System.Windows.Forms.Button()
        Me.txtCargaHr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDocente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDisciplina
        '
        Me.txtDisciplina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisciplina.Location = New System.Drawing.Point(128, 65)
        Me.txtDisciplina.Name = "txtDisciplina"
        Me.txtDisciplina.Size = New System.Drawing.Size(464, 22)
        Me.txtDisciplina.TabIndex = 1
        '
        'txtNomeFuncionario
        '
        Me.txtNomeFuncionario.Enabled = False
        Me.txtNomeFuncionario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFuncionario.Location = New System.Drawing.Point(128, 209)
        Me.txtNomeFuncionario.Name = "txtNomeFuncionario"
        Me.txtNomeFuncionario.Size = New System.Drawing.Size(464, 22)
        Me.txtNomeFuncionario.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(7, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Funcionário :"
        '
        'btnCadastroDisciplina
        '
        Me.btnCadastroDisciplina.BackColor = System.Drawing.Color.Maroon
        Me.btnCadastroDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCadastroDisciplina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastroDisciplina.ForeColor = System.Drawing.Color.White
        Me.btnCadastroDisciplina.Location = New System.Drawing.Point(154, 280)
        Me.btnCadastroDisciplina.Name = "btnCadastroDisciplina"
        Me.btnCadastroDisciplina.Size = New System.Drawing.Size(150, 32)
        Me.btnCadastroDisciplina.TabIndex = 144
        Me.btnCadastroDisciplina.Text = "Cadastrar"
        Me.btnCadastroDisciplina.UseVisualStyleBackColor = False
        '
        'txtCargaHr
        '
        Me.txtCargaHr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargaHr.Location = New System.Drawing.Point(128, 162)
        Me.txtCargaHr.Name = "txtCargaHr"
        Me.txtCargaHr.Size = New System.Drawing.Size(80, 22)
        Me.txtCargaHr.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(7, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Carga Horária:"
        '
        'txtDocente
        '
        Me.txtDocente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocente.Location = New System.Drawing.Point(128, 116)
        Me.txtDocente.Name = "txtDocente"
        Me.txtDocente.Size = New System.Drawing.Size(464, 22)
        Me.txtDocente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(7, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Docente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(7, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Nome Disciplina:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-81, 237)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(447, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 145
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(188, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 24)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "Cadastro de Disciplinas"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Maroon
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSair.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(394, 280)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(150, 32)
        Me.btnSair.TabIndex = 150
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(470, 338)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 151
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CadastrarDisciplina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(598, 363)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDisciplina)
        Me.Controls.Add(Me.txtNomeFuncionario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCadastroDisciplina)
        Me.Controls.Add(Me.txtCargaHr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDocente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastrarDisciplina"
        Me.Text = "CadastrarDisciplina"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisciplina As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCadastroDisciplina As System.Windows.Forms.Button
    Friend WithEvents txtCargaHr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDocente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
