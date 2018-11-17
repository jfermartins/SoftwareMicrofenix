<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesquisaFuncionario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsuarioFunc = New System.Windows.Forms.TextBox()
        Me.txtNomeFuncionario = New System.Windows.Forms.TextBox()
        Me.txtSenhaFuncionario = New System.Windows.Forms.TextBox()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.btnLimparUsuario = New System.Windows.Forms.Button()
        Me.btnExcluirFuncionario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPFFuncionario = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Senha"
        '
        'txtUsuarioFunc
        '
        Me.txtUsuarioFunc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioFunc.Location = New System.Drawing.Point(87, 22)
        Me.txtUsuarioFunc.Name = "txtUsuarioFunc"
        Me.txtUsuarioFunc.Size = New System.Drawing.Size(194, 22)
        Me.txtUsuarioFunc.TabIndex = 1
        '
        'txtNomeFuncionario
        '
        Me.txtNomeFuncionario.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFuncionario.Location = New System.Drawing.Point(87, 103)
        Me.txtNomeFuncionario.Name = "txtNomeFuncionario"
        Me.txtNomeFuncionario.Size = New System.Drawing.Size(196, 22)
        Me.txtNomeFuncionario.TabIndex = 2
        '
        'txtSenhaFuncionario
        '
        Me.txtSenhaFuncionario.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhaFuncionario.Location = New System.Drawing.Point(87, 139)
        Me.txtSenhaFuncionario.Name = "txtSenhaFuncionario"
        Me.txtSenhaFuncionario.Size = New System.Drawing.Size(196, 22)
        Me.txtSenhaFuncionario.TabIndex = 4
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(318, 15)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(93, 35)
        Me.btnBuscarUsuario.TabIndex = 10
        Me.btnBuscarUsuario.Text = "Buscar"
        Me.btnBuscarUsuario.UseVisualStyleBackColor = False
        '
        'btnLimparUsuario
        '
        Me.btnLimparUsuario.BackColor = System.Drawing.Color.Maroon
        Me.btnLimparUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimparUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparUsuario.ForeColor = System.Drawing.Color.White
        Me.btnLimparUsuario.Location = New System.Drawing.Point(435, 15)
        Me.btnLimparUsuario.Name = "btnLimparUsuario"
        Me.btnLimparUsuario.Size = New System.Drawing.Size(88, 35)
        Me.btnLimparUsuario.TabIndex = 11
        Me.btnLimparUsuario.Text = "Limpar"
        Me.btnLimparUsuario.UseVisualStyleBackColor = False
        '
        'btnExcluirFuncionario
        '
        Me.btnExcluirFuncionario.BackColor = System.Drawing.Color.Maroon
        Me.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluirFuncionario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluirFuncionario.ForeColor = System.Drawing.Color.White
        Me.btnExcluirFuncionario.Location = New System.Drawing.Point(429, 232)
        Me.btnExcluirFuncionario.Name = "btnExcluirFuncionario"
        Me.btnExcluirFuncionario.Size = New System.Drawing.Size(93, 38)
        Me.btnExcluirFuncionario.TabIndex = 12
        Me.btnExcluirFuncionario.Text = "Excluir"
        Me.btnExcluirFuncionario.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(309, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CPF"
        '
        'txtCPFFuncionario
        '
        Me.txtCPFFuncionario.Location = New System.Drawing.Point(87, 173)
        Me.txtCPFFuncionario.Name = "txtCPFFuncionario"
        Me.txtCPFFuncionario.Size = New System.Drawing.Size(194, 20)
        Me.txtCPFFuncionario.TabIndex = 17
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(419, 280)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 192
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PesquisaFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 302)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtCPFFuncionario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExcluirFuncionario)
        Me.Controls.Add(Me.btnLimparUsuario)
        Me.Controls.Add(Me.btnBuscarUsuario)
        Me.Controls.Add(Me.txtSenhaFuncionario)
        Me.Controls.Add(Me.txtNomeFuncionario)
        Me.Controls.Add(Me.txtUsuarioFunc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PesquisaFuncionario"
        Me.Text = "Pesquisa"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioFunc As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtSenhaFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnLimparUsuario As System.Windows.Forms.Button
    Friend WithEvents btnExcluirFuncionario As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCPFFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
