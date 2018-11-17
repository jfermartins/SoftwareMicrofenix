<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroAluno))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeAluno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEnderecoAluno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmailAluno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCadastroAluno = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbEcAluno = New System.Windows.Forms.ComboBox()
        Me.cmbGeneroAluno = New System.Windows.Forms.ComboBox()
        Me.txtObsAluno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mskCpfAluno = New System.Windows.Forms.MaskedTextBox()
        Me.mskDnAluno = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelefoneAluno = New System.Windows.Forms.MaskedTextBox()
        Me.mskCelularAluno = New System.Windows.Forms.MaskedTextBox()
        Me.mskWhatsAluno = New System.Windows.Forms.MaskedTextBox()
        Me.txtRgAluno = New System.Windows.Forms.TextBox()
        Me.btnBuscaCadastro = New System.Windows.Forms.Button()
        Me.btnLimpaCadastro = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBuscaCadastro = New System.Windows.Forms.TextBox()
        Me.btnAlteraCadastro = New System.Windows.Forms.Button()
        Me.btnExcluiCadastro = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(21, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome*:"
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeAluno.Location = New System.Drawing.Point(91, 83)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(464, 22)
        Me.txtNomeAluno.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(21, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "R.G. (apenas nº)*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(21, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "C.P.F. (apenas nº)*:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(21, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data de Nascimento (dd/mm/aaaa)*:"
        '
        'txtEnderecoAluno
        '
        Me.txtEnderecoAluno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnderecoAluno.Location = New System.Drawing.Point(99, 314)
        Me.txtEnderecoAluno.Name = "txtEnderecoAluno"
        Me.txtEnderecoAluno.Size = New System.Drawing.Size(456, 22)
        Me.txtEnderecoAluno.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(21, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Endereço*:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(21, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telefone residencial (apenas nº)*:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(21, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Celular (apenas nº):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(21, 430)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "WhatsApp (apenas nº):"
        '
        'txtEmailAluno
        '
        Me.txtEmailAluno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAluno.Location = New System.Drawing.Point(91, 467)
        Me.txtEmailAluno.Name = "txtEmailAluno"
        Me.txtEmailAluno.Size = New System.Drawing.Size(464, 22)
        Me.txtEmailAluno.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(21, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "E-mail:"
        '
        'btnCadastroAluno
        '
        Me.btnCadastroAluno.BackColor = System.Drawing.Color.Maroon
        Me.btnCadastroAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCadastroAluno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastroAluno.ForeColor = System.Drawing.Color.White
        Me.btnCadastroAluno.Location = New System.Drawing.Point(188, 604)
        Me.btnCadastroAluno.Name = "btnCadastroAluno"
        Me.btnCadastroAluno.Size = New System.Drawing.Size(117, 32)
        Me.btnCadastroAluno.TabIndex = 16
        Me.btnCadastroAluno.Text = "Cadastrar"
        Me.btnCadastroAluno.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 550)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(21, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Gênero*:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(21, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Estado Civil*:"
        '
        'cmbEcAluno
        '
        Me.cmbEcAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEcAluno.FormattingEnabled = True
        Me.cmbEcAluno.Items.AddRange(New Object() {"", "Casado(a)", "Solteiro(a)", "União estável", "Separado(a) judicialmente", "Divorciado(a)", "Viúvo(a)"})
        Me.cmbEcAluno.Location = New System.Drawing.Point(126, 237)
        Me.cmbEcAluno.Name = "cmbEcAluno"
        Me.cmbEcAluno.Size = New System.Drawing.Size(429, 21)
        Me.cmbEcAluno.TabIndex = 8
        '
        'cmbGeneroAluno
        '
        Me.cmbGeneroAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneroAluno.FormattingEnabled = True
        Me.cmbGeneroAluno.Items.AddRange(New Object() {"", "Masculino", "Feminino"})
        Me.cmbGeneroAluno.Location = New System.Drawing.Point(91, 276)
        Me.cmbGeneroAluno.Name = "cmbGeneroAluno"
        Me.cmbGeneroAluno.Size = New System.Drawing.Size(464, 21)
        Me.cmbGeneroAluno.TabIndex = 9
        '
        'txtObsAluno
        '
        Me.txtObsAluno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsAluno.Location = New System.Drawing.Point(114, 506)
        Me.txtObsAluno.Multiline = True
        Me.txtObsAluno.Name = "txtObsAluno"
        Me.txtObsAluno.Size = New System.Drawing.Size(441, 82)
        Me.txtObsAluno.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(21, 509)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Observação:"
        '
        'mskCpfAluno
        '
        Me.mskCpfAluno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCpfAluno.Location = New System.Drawing.Point(160, 157)
        Me.mskCpfAluno.Mask = "000.000.000-00"
        Me.mskCpfAluno.Name = "mskCpfAluno"
        Me.mskCpfAluno.Size = New System.Drawing.Size(395, 13)
        Me.mskCpfAluno.TabIndex = 6
        '
        'mskDnAluno
        '
        Me.mskDnAluno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskDnAluno.Location = New System.Drawing.Point(263, 203)
        Me.mskDnAluno.Mask = "00/00/0000"
        Me.mskDnAluno.Name = "mskDnAluno"
        Me.mskDnAluno.Size = New System.Drawing.Size(292, 13)
        Me.mskDnAluno.TabIndex = 7
        '
        'mskTelefoneAluno
        '
        Me.mskTelefoneAluno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskTelefoneAluno.Location = New System.Drawing.Point(248, 357)
        Me.mskTelefoneAluno.Mask = "(00) 0000-0000"
        Me.mskTelefoneAluno.Name = "mskTelefoneAluno"
        Me.mskTelefoneAluno.Size = New System.Drawing.Size(307, 13)
        Me.mskTelefoneAluno.TabIndex = 11
        '
        'mskCelularAluno
        '
        Me.mskCelularAluno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskCelularAluno.Location = New System.Drawing.Point(160, 395)
        Me.mskCelularAluno.Mask = "(00) 00000-0000"
        Me.mskCelularAluno.Name = "mskCelularAluno"
        Me.mskCelularAluno.Size = New System.Drawing.Size(395, 13)
        Me.mskCelularAluno.TabIndex = 12
        '
        'mskWhatsAluno
        '
        Me.mskWhatsAluno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskWhatsAluno.Location = New System.Drawing.Point(178, 433)
        Me.mskWhatsAluno.Mask = "(00) 00000-0000"
        Me.mskWhatsAluno.Name = "mskWhatsAluno"
        Me.mskWhatsAluno.Size = New System.Drawing.Size(377, 13)
        Me.mskWhatsAluno.TabIndex = 13
        '
        'txtRgAluno
        '
        Me.txtRgAluno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRgAluno.Location = New System.Drawing.Point(141, 121)
        Me.txtRgAluno.Name = "txtRgAluno"
        Me.txtRgAluno.Size = New System.Drawing.Size(414, 22)
        Me.txtRgAluno.TabIndex = 5
        '
        'btnBuscaCadastro
        '
        Me.btnBuscaCadastro.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscaCadastro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaCadastro.ForeColor = System.Drawing.Color.White
        Me.btnBuscaCadastro.Location = New System.Drawing.Point(240, 34)
        Me.btnBuscaCadastro.Name = "btnBuscaCadastro"
        Me.btnBuscaCadastro.Size = New System.Drawing.Size(150, 32)
        Me.btnBuscaCadastro.TabIndex = 2
        Me.btnBuscaCadastro.Text = "Buscar"
        Me.btnBuscaCadastro.UseVisualStyleBackColor = False
        '
        'btnLimpaCadastro
        '
        Me.btnLimpaCadastro.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpaCadastro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpaCadastro.ForeColor = System.Drawing.Color.White
        Me.btnLimpaCadastro.Location = New System.Drawing.Point(405, 34)
        Me.btnLimpaCadastro.Name = "btnLimpaCadastro"
        Me.btnLimpaCadastro.Size = New System.Drawing.Size(150, 32)
        Me.btnLimpaCadastro.TabIndex = 3
        Me.btnLimpaCadastro.Text = "Limpar"
        Me.btnLimpaCadastro.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(21, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 16)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "C.P.F. do Aluno:"
        '
        'txtBuscaCadastro
        '
        Me.txtBuscaCadastro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaCadastro.Location = New System.Drawing.Point(135, 6)
        Me.txtBuscaCadastro.Name = "txtBuscaCadastro"
        Me.txtBuscaCadastro.Size = New System.Drawing.Size(420, 22)
        Me.txtBuscaCadastro.TabIndex = 1
        '
        'btnAlteraCadastro
        '
        Me.btnAlteraCadastro.BackColor = System.Drawing.Color.Maroon
        Me.btnAlteraCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlteraCadastro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlteraCadastro.ForeColor = System.Drawing.Color.White
        Me.btnAlteraCadastro.Location = New System.Drawing.Point(321, 604)
        Me.btnAlteraCadastro.Name = "btnAlteraCadastro"
        Me.btnAlteraCadastro.Size = New System.Drawing.Size(106, 32)
        Me.btnAlteraCadastro.TabIndex = 17
        Me.btnAlteraCadastro.Text = "Alterar"
        Me.btnAlteraCadastro.UseVisualStyleBackColor = False
        '
        'btnExcluiCadastro
        '
        Me.btnExcluiCadastro.BackColor = System.Drawing.Color.Maroon
        Me.btnExcluiCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluiCadastro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluiCadastro.ForeColor = System.Drawing.Color.White
        Me.btnExcluiCadastro.Location = New System.Drawing.Point(450, 604)
        Me.btnExcluiCadastro.Name = "btnExcluiCadastro"
        Me.btnExcluiCadastro.Size = New System.Drawing.Size(106, 32)
        Me.btnExcluiCadastro.TabIndex = 18
        Me.btnExcluiCadastro.Text = "Excluir"
        Me.btnExcluiCadastro.UseVisualStyleBackColor = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(458, 646)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 169
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CadastroAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 667)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnAlteraCadastro)
        Me.Controls.Add(Me.btnExcluiCadastro)
        Me.Controls.Add(Me.btnBuscaCadastro)
        Me.Controls.Add(Me.btnLimpaCadastro)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtBuscaCadastro)
        Me.Controls.Add(Me.mskWhatsAluno)
        Me.Controls.Add(Me.mskCelularAluno)
        Me.Controls.Add(Me.mskTelefoneAluno)
        Me.Controls.Add(Me.mskDnAluno)
        Me.Controls.Add(Me.mskCpfAluno)
        Me.Controls.Add(Me.txtObsAluno)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbGeneroAluno)
        Me.Controls.Add(Me.cmbEcAluno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnCadastroAluno)
        Me.Controls.Add(Me.txtEmailAluno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEnderecoAluno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRgAluno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomeAluno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastroAluno"
        Me.Text = "CadastroAluno"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEnderecoAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmailAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCadastroAluno As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbEcAluno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGeneroAluno As System.Windows.Forms.ComboBox
    Friend WithEvents txtObsAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mskCpfAluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskDnAluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelefoneAluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCelularAluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskWhatsAluno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRgAluno As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscaCadastro As System.Windows.Forms.Button
    Friend WithEvents btnLimpaCadastro As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBuscaCadastro As System.Windows.Forms.TextBox
    Friend WithEvents btnAlteraCadastro As System.Windows.Forms.Button
    Friend WithEvents btnExcluiCadastro As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
