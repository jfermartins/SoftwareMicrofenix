<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_Ocorrencia_Geral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_Ocorrencia_Geral))
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.txtHorAt = New System.Windows.Forms.TextBox()
        Me.TxtDtaA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQtdEqp = New System.Windows.Forms.TextBox()
        Me.txtSetorT = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCodOcorrencia = New System.Windows.Forms.TextBox()
        Me.btnEx = New System.Windows.Forms.Button()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.txtSol = New System.Windows.Forms.TextBox()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.txtDtOc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEnvO = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRgE = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMedO = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAlt
        '
        Me.btnAlt.BackColor = System.Drawing.Color.Maroon
        Me.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlt.ForeColor = System.Drawing.Color.White
        Me.btnAlt.Location = New System.Drawing.Point(609, 458)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(118, 30)
        Me.btnAlt.TabIndex = 18
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = False
        '
        'txtHorAt
        '
        Me.txtHorAt.Location = New System.Drawing.Point(758, 422)
        Me.txtHorAt.Name = "txtHorAt"
        Me.txtHorAt.Size = New System.Drawing.Size(117, 20)
        Me.txtHorAt.TabIndex = 16
        '
        'TxtDtaA
        '
        Me.TxtDtaA.Location = New System.Drawing.Point(460, 422)
        Me.TxtDtaA.Name = "TxtDtaA"
        Me.TxtDtaA.Size = New System.Drawing.Size(234, 20)
        Me.TxtDtaA.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(700, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Horário:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(327, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Data Atendida:"
        '
        'txtQtdEqp
        '
        Me.txtQtdEqp.Location = New System.Drawing.Point(460, 268)
        Me.txtQtdEqp.Name = "txtQtdEqp"
        Me.txtQtdEqp.Size = New System.Drawing.Size(415, 20)
        Me.txtQtdEqp.TabIndex = 10
        '
        'txtSetorT
        '
        Me.txtSetorT.Location = New System.Drawing.Point(460, 198)
        Me.txtSetorT.Name = "txtSetorT"
        Me.txtSetorT.Size = New System.Drawing.Size(415, 20)
        Me.txtSetorT.TabIndex = 8
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(460, 131)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(415, 20)
        Me.txtDesc.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(250, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Quantidade Equipamentos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(330, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Setor Técnico:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(356, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Descrição:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(299, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Código Ocorrência:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(773, 47)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 32)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtCodOcorrencia
        '
        Me.txtCodOcorrencia.Location = New System.Drawing.Point(460, 47)
        Me.txtCodOcorrencia.Name = "txtCodOcorrencia"
        Me.txtCodOcorrencia.Size = New System.Drawing.Size(307, 20)
        Me.txtCodOcorrencia.TabIndex = 1
        '
        'btnEx
        '
        Me.btnEx.BackColor = System.Drawing.Color.Maroon
        Me.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEx.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEx.ForeColor = System.Drawing.Color.White
        Me.btnEx.Location = New System.Drawing.Point(750, 458)
        Me.btnEx.Name = "btnEx"
        Me.btnEx.Size = New System.Drawing.Size(125, 30)
        Me.btnEx.TabIndex = 19
        Me.btnEx.Text = "Excluir"
        Me.btnEx.UseVisualStyleBackColor = False
        '
        'btnCad
        '
        Me.btnCad.BackColor = System.Drawing.Color.Maroon
        Me.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCad.ForeColor = System.Drawing.Color.White
        Me.btnCad.Location = New System.Drawing.Point(460, 458)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(118, 30)
        Me.btnCad.TabIndex = 17
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = False
        '
        'txtSol
        '
        Me.txtSol.Location = New System.Drawing.Point(460, 378)
        Me.txtSol.Name = "txtSol"
        Me.txtSol.Size = New System.Drawing.Size(415, 20)
        Me.txtSol.TabIndex = 14
        '
        'txtH
        '
        Me.txtH.Location = New System.Drawing.Point(757, 89)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(118, 20)
        Me.txtH.TabIndex = 4
        '
        'txtDtOc
        '
        Me.txtDtOc.Location = New System.Drawing.Point(460, 89)
        Me.txtDtOc.Name = "txtDtOc"
        Me.txtDtOc.Size = New System.Drawing.Size(234, 20)
        Me.txtDtOc.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(362, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Solução: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(700, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Horário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(295, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Data da Ocorrência:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-15, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 678)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(327, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nome Técnico:"
        '
        'txtNomeT
        '
        Me.txtNomeT.Location = New System.Drawing.Point(460, 163)
        Me.txtNomeT.Name = "txtNomeT"
        Me.txtNomeT.Size = New System.Drawing.Size(234, 20)
        Me.txtNomeT.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(701, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 16)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "RG:"
        '
        'txtRg
        '
        Me.txtRg.Location = New System.Drawing.Point(733, 164)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(139, 20)
        Me.txtRg.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(262, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 16)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Descrição Equipamentos:"
        '
        'txtDE
        '
        Me.txtDE.Location = New System.Drawing.Point(460, 232)
        Me.txtDE.Name = "txtDE"
        Me.txtDE.Size = New System.Drawing.Size(415, 20)
        Me.txtDE.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(282, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 16)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Envolvido Ocorrência:"
        '
        'txtEnvO
        '
        Me.txtEnvO.Location = New System.Drawing.Point(460, 304)
        Me.txtEnvO.Name = "txtEnvO"
        Me.txtEnvO.Size = New System.Drawing.Size(207, 20)
        Me.txtEnvO.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(673, 309)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 16)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "RG Envolvido:"
        '
        'txtRgE
        '
        Me.txtRgE.Location = New System.Drawing.Point(773, 305)
        Me.txtRgE.Name = "txtRgE"
        Me.txtRgE.Size = New System.Drawing.Size(102, 20)
        Me.txtRgE.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(297, 345)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 16)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Medida Ocorrência:"
        '
        'txtMedO
        '
        Me.txtMedO.Location = New System.Drawing.Point(460, 341)
        Me.txtMedO.Name = "txtMedO"
        Me.txtMedO.Size = New System.Drawing.Size(415, 20)
        Me.txtMedO.TabIndex = 13
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(736, 502)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 171
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Cadastro_Ocorrencia_Geral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(908, 661)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtMedO)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtRgE)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtEnvO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDE)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRg)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNomeT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.txtHorAt)
        Me.Controls.Add(Me.TxtDtaA)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQtdEqp)
        Me.Controls.Add(Me.txtSetorT)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodOcorrencia)
        Me.Controls.Add(Me.btnEx)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.txtSol)
        Me.Controls.Add(Me.txtH)
        Me.Controls.Add(Me.txtDtOc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastro_Ocorrencia_Geral"
        Me.Text = "Cadastro_Ocorrência_Geral"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAlt As System.Windows.Forms.Button
    Friend WithEvents txtHorAt As System.Windows.Forms.TextBox
    Friend WithEvents TxtDtaA As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtQtdEqp As System.Windows.Forms.TextBox
    Friend WithEvents txtSetorT As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtCodOcorrencia As System.Windows.Forms.TextBox
    Friend WithEvents btnEx As System.Windows.Forms.Button
    Friend WithEvents btnCad As System.Windows.Forms.Button
    Friend WithEvents txtSol As System.Windows.Forms.TextBox
    Friend WithEvents txtH As System.Windows.Forms.TextBox
    Friend WithEvents txtDtOc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeT As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRg As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDE As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEnvO As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtRgE As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMedO As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
