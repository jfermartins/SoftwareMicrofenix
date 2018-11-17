<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterarFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlterarFuncionario))
        Me.txtEstadoFuncionario = New System.Windows.Forms.ComboBox()
        Me.txtSexoFuncionario = New System.Windows.Forms.ComboBox()
        Me.txtCargoFuncionario = New System.Windows.Forms.ComboBox()
        Me.txtSenhaFuncionario = New System.Windows.Forms.TextBox()
        Me.txtUsuarioFuncionario = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAlterarFuncionario = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtValorSalario = New System.Windows.Forms.TextBox()
        Me.txtDtPagamento = New System.Windows.Forms.TextBox()
        Me.txtDataDemissaoFuncionario = New System.Windows.Forms.TextBox()
        Me.txtDataDeEmissaoFuncionario = New System.Windows.Forms.TextBox()
        Me.txtEscolaridadeFuncionario = New System.Windows.Forms.TextBox()
        Me.txtEmailFuncionario = New System.Windows.Forms.TextBox()
        Me.txtWhatsAppFuncionario = New System.Windows.Forms.TextBox()
        Me.txtTelefoneFuncionario = New System.Windows.Forms.TextBox()
        Me.txtEnderecoFuncionario = New System.Windows.Forms.TextBox()
        Me.txtDataDeNascimentoFuncionario = New System.Windows.Forms.TextBox()
        Me.txtCPFFuncionario = New System.Windows.Forms.TextBox()
        Me.txtRGFuncionario = New System.Windows.Forms.TextBox()
        Me.txtNomeFuncionario = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEstadoFuncionario
        '
        Me.txtEstadoFuncionario.FormattingEnabled = True
        Me.txtEstadoFuncionario.Items.AddRange(New Object() {"Casado(a)", "Solteiro(a)", "Divorciado(a)", "Viúvo(a)"})
        Me.txtEstadoFuncionario.Location = New System.Drawing.Point(384, 83)
        Me.txtEstadoFuncionario.Name = "txtEstadoFuncionario"
        Me.txtEstadoFuncionario.Size = New System.Drawing.Size(229, 21)
        Me.txtEstadoFuncionario.TabIndex = 14
        '
        'txtSexoFuncionario
        '
        Me.txtSexoFuncionario.FormattingEnabled = True
        Me.txtSexoFuncionario.Items.AddRange(New Object() {"Masculino", "Feminino", "Outros"})
        Me.txtSexoFuncionario.Location = New System.Drawing.Point(346, 47)
        Me.txtSexoFuncionario.Name = "txtSexoFuncionario"
        Me.txtSexoFuncionario.Size = New System.Drawing.Size(267, 21)
        Me.txtSexoFuncionario.TabIndex = 13
        '
        'txtCargoFuncionario
        '
        Me.txtCargoFuncionario.FormattingEnabled = True
        Me.txtCargoFuncionario.Items.AddRange(New Object() {"Diretoria", "Administração", "Rh", "Secretaria", "Professor"})
        Me.txtCargoFuncionario.Location = New System.Drawing.Point(346, 15)
        Me.txtCargoFuncionario.Name = "txtCargoFuncionario"
        Me.txtCargoFuncionario.Size = New System.Drawing.Size(267, 21)
        Me.txtCargoFuncionario.TabIndex = 12
        '
        'txtSenhaFuncionario
        '
        Me.txtSenhaFuncionario.Location = New System.Drawing.Point(358, 219)
        Me.txtSenhaFuncionario.Name = "txtSenhaFuncionario"
        Me.txtSenhaFuncionario.Size = New System.Drawing.Size(255, 20)
        Me.txtSenhaFuncionario.TabIndex = 18
        '
        'txtUsuarioFuncionario
        '
        Me.txtUsuarioFuncionario.Location = New System.Drawing.Point(358, 184)
        Me.txtUsuarioFuncionario.Name = "txtUsuarioFuncionario"
        Me.txtUsuarioFuncionario.Size = New System.Drawing.Size(255, 20)
        Me.txtUsuarioFuncionario.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Maroon
        Me.Label20.Location = New System.Drawing.Point(296, 220)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 16)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Senha"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Maroon
        Me.Label19.Location = New System.Drawing.Point(296, 186)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 16)
        Me.Label19.TabIndex = 85
        Me.Label19.Text = "Usuário"
        '
        'btnAlterarFuncionario
        '
        Me.btnAlterarFuncionario.BackColor = System.Drawing.Color.Maroon
        Me.btnAlterarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlterarFuncionario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterarFuncionario.ForeColor = System.Drawing.Color.White
        Me.btnAlterarFuncionario.Location = New System.Drawing.Point(496, 301)
        Me.btnAlterarFuncionario.Name = "btnAlterarFuncionario"
        Me.btnAlterarFuncionario.Size = New System.Drawing.Size(117, 37)
        Me.btnAlterarFuncionario.TabIndex = 83
        Me.btnAlterarFuncionario.Text = "Alterar"
        Me.btnAlterarFuncionario.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(207, 356)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "(dd/mm/aaaa)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(207, 325)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "(dd/mm/aaaa)"
        '
        'txtValorSalario
        '
        Me.txtValorSalario.Location = New System.Drawing.Point(395, 149)
        Me.txtValorSalario.Name = "txtValorSalario"
        Me.txtValorSalario.Size = New System.Drawing.Size(218, 20)
        Me.txtValorSalario.TabIndex = 16
        '
        'txtDtPagamento
        '
        Me.txtDtPagamento.Location = New System.Drawing.Point(407, 115)
        Me.txtDtPagamento.Name = "txtDtPagamento"
        Me.txtDtPagamento.Size = New System.Drawing.Size(206, 20)
        Me.txtDtPagamento.TabIndex = 15
        '
        'txtDataDemissaoFuncionario
        '
        Me.txtDataDemissaoFuncionario.Location = New System.Drawing.Point(111, 353)
        Me.txtDataDemissaoFuncionario.Name = "txtDataDemissaoFuncionario"
        Me.txtDataDemissaoFuncionario.Size = New System.Drawing.Size(90, 20)
        Me.txtDataDemissaoFuncionario.TabIndex = 11
        '
        'txtDataDeEmissaoFuncionario
        '
        Me.txtDataDeEmissaoFuncionario.Location = New System.Drawing.Point(127, 322)
        Me.txtDataDeEmissaoFuncionario.Name = "txtDataDeEmissaoFuncionario"
        Me.txtDataDeEmissaoFuncionario.Size = New System.Drawing.Size(84, 20)
        Me.txtDataDeEmissaoFuncionario.TabIndex = 10
        '
        'txtEscolaridadeFuncionario
        '
        Me.txtEscolaridadeFuncionario.Location = New System.Drawing.Point(94, 290)
        Me.txtEscolaridadeFuncionario.Name = "txtEscolaridadeFuncionario"
        Me.txtEscolaridadeFuncionario.Size = New System.Drawing.Size(189, 20)
        Me.txtEscolaridadeFuncionario.TabIndex = 9
        '
        'txtEmailFuncionario
        '
        Me.txtEmailFuncionario.Location = New System.Drawing.Point(49, 253)
        Me.txtEmailFuncionario.Name = "txtEmailFuncionario"
        Me.txtEmailFuncionario.Size = New System.Drawing.Size(234, 20)
        Me.txtEmailFuncionario.TabIndex = 8
        '
        'txtWhatsAppFuncionario
        '
        Me.txtWhatsAppFuncionario.Location = New System.Drawing.Point(83, 220)
        Me.txtWhatsAppFuncionario.Name = "txtWhatsAppFuncionario"
        Me.txtWhatsAppFuncionario.Size = New System.Drawing.Size(200, 20)
        Me.txtWhatsAppFuncionario.TabIndex = 7
        '
        'txtTelefoneFuncionario
        '
        Me.txtTelefoneFuncionario.Location = New System.Drawing.Point(67, 185)
        Me.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario"
        Me.txtTelefoneFuncionario.Size = New System.Drawing.Size(216, 20)
        Me.txtTelefoneFuncionario.TabIndex = 6
        '
        'txtEnderecoFuncionario
        '
        Me.txtEnderecoFuncionario.Location = New System.Drawing.Point(82, 116)
        Me.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario"
        Me.txtEnderecoFuncionario.Size = New System.Drawing.Size(201, 20)
        Me.txtEnderecoFuncionario.TabIndex = 4
        '
        'txtDataDeNascimentoFuncionario
        '
        Me.txtDataDeNascimentoFuncionario.Location = New System.Drawing.Point(142, 149)
        Me.txtDataDeNascimentoFuncionario.Name = "txtDataDeNascimentoFuncionario"
        Me.txtDataDeNascimentoFuncionario.Size = New System.Drawing.Size(141, 20)
        Me.txtDataDeNascimentoFuncionario.TabIndex = 5
        '
        'txtCPFFuncionario
        '
        Me.txtCPFFuncionario.Location = New System.Drawing.Point(41, 14)
        Me.txtCPFFuncionario.Name = "txtCPFFuncionario"
        Me.txtCPFFuncionario.Size = New System.Drawing.Size(242, 20)
        Me.txtCPFFuncionario.TabIndex = 1
        '
        'txtRGFuncionario
        '
        Me.txtRGFuncionario.Location = New System.Drawing.Point(40, 82)
        Me.txtRGFuncionario.Name = "txtRGFuncionario"
        Me.txtRGFuncionario.Size = New System.Drawing.Size(242, 20)
        Me.txtRGFuncionario.TabIndex = 3
        '
        'txtNomeFuncionario
        '
        Me.txtNomeFuncionario.Location = New System.Drawing.Point(59, 47)
        Me.txtNomeFuncionario.Name = "txtNomeFuncionario"
        Me.txtNomeFuncionario.Size = New System.Drawing.Size(223, 20)
        Me.txtNomeFuncionario.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(296, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 16)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Valor Salário"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(296, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 16)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Data Pagamento"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(296, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 16)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Estado Civil"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(293, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 16)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Sexo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(8, 356)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 16)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Data Demissão"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(8, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 16)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Data de Admissão"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(293, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 16)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Cargo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(8, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Escolaridade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(8, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(8, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "WhatsApp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(8, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Telefone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(8, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Endereço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(9, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 16)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Data de Nascimento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(8, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "RG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nome"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(207, 256)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(367, 301)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(117, 37)
        Me.btnBuscar.TabIndex = 90
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(500, 394)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 210
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'AlterarFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(635, 417)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtEstadoFuncionario)
        Me.Controls.Add(Me.txtSexoFuncionario)
        Me.Controls.Add(Me.txtCargoFuncionario)
        Me.Controls.Add(Me.txtSenhaFuncionario)
        Me.Controls.Add(Me.txtUsuarioFuncionario)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnAlterarFuncionario)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtValorSalario)
        Me.Controls.Add(Me.txtDtPagamento)
        Me.Controls.Add(Me.txtDataDemissaoFuncionario)
        Me.Controls.Add(Me.txtDataDeEmissaoFuncionario)
        Me.Controls.Add(Me.txtEscolaridadeFuncionario)
        Me.Controls.Add(Me.txtEmailFuncionario)
        Me.Controls.Add(Me.txtWhatsAppFuncionario)
        Me.Controls.Add(Me.txtTelefoneFuncionario)
        Me.Controls.Add(Me.txtEnderecoFuncionario)
        Me.Controls.Add(Me.txtDataDeNascimentoFuncionario)
        Me.Controls.Add(Me.txtCPFFuncionario)
        Me.Controls.Add(Me.txtRGFuncionario)
        Me.Controls.Add(Me.txtNomeFuncionario)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AlterarFuncionario"
        Me.Text = "AlterarFuncionario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEstadoFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents txtSexoFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents txtCargoFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents txtSenhaFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnAlterarFuncionario As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtValorSalario As System.Windows.Forms.TextBox
    Friend WithEvents txtDtPagamento As System.Windows.Forms.TextBox
    Friend WithEvents txtDataDemissaoFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtDataDeEmissaoFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtEscolaridadeFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtWhatsAppFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefoneFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtEnderecoFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtDataDeNascimentoFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtCPFFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtRGFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
