<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesquisa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pesquisa))
        Me.txtNotaFiscalMaterial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExcluirFuncionario = New System.Windows.Forms.Button()
        Me.btnLimparUsuario = New System.Windows.Forms.Button()
        Me.btnBuscarUsuario = New System.Windows.Forms.Button()
        Me.txtValorMaterial = New System.Windows.Forms.TextBox()
        Me.txtNomeMaterial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeFornecedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMarcaMaterial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuantidadeMaterial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNotaFiscalMaterial
        '
        Me.txtNotaFiscalMaterial.Location = New System.Drawing.Point(106, 193)
        Me.txtNotaFiscalMaterial.Name = "txtNotaFiscalMaterial"
        Me.txtNotaFiscalMaterial.Size = New System.Drawing.Size(207, 20)
        Me.txtNotaFiscalMaterial.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(9, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nota Fiscal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(319, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'btnExcluirFuncionario
        '
        Me.btnExcluirFuncionario.BackColor = System.Drawing.Color.Maroon
        Me.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluirFuncionario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluirFuncionario.ForeColor = System.Drawing.Color.White
        Me.btnExcluirFuncionario.Location = New System.Drawing.Point(413, 318)
        Me.btnExcluirFuncionario.Name = "btnExcluirFuncionario"
        Me.btnExcluirFuncionario.Size = New System.Drawing.Size(93, 38)
        Me.btnExcluirFuncionario.TabIndex = 26
        Me.btnExcluirFuncionario.Text = "Excluir"
        Me.btnExcluirFuncionario.UseVisualStyleBackColor = False
        '
        'btnLimparUsuario
        '
        Me.btnLimparUsuario.BackColor = System.Drawing.Color.Maroon
        Me.btnLimparUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimparUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparUsuario.ForeColor = System.Drawing.Color.White
        Me.btnLimparUsuario.Location = New System.Drawing.Point(470, 32)
        Me.btnLimparUsuario.Name = "btnLimparUsuario"
        Me.btnLimparUsuario.Size = New System.Drawing.Size(88, 35)
        Me.btnLimparUsuario.TabIndex = 25
        Me.btnLimparUsuario.Text = "Limpar"
        Me.btnLimparUsuario.UseVisualStyleBackColor = False
        '
        'btnBuscarUsuario
        '
        Me.btnBuscarUsuario.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnBuscarUsuario.Location = New System.Drawing.Point(348, 32)
        Me.btnBuscarUsuario.Name = "btnBuscarUsuario"
        Me.btnBuscarUsuario.Size = New System.Drawing.Size(93, 35)
        Me.btnBuscarUsuario.TabIndex = 24
        Me.btnBuscarUsuario.Text = "Buscar"
        Me.btnBuscarUsuario.UseVisualStyleBackColor = False
        '
        'txtValorMaterial
        '
        Me.txtValorMaterial.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorMaterial.Location = New System.Drawing.Point(106, 159)
        Me.txtValorMaterial.Name = "txtValorMaterial"
        Me.txtValorMaterial.Size = New System.Drawing.Size(207, 22)
        Me.txtValorMaterial.TabIndex = 3
        '
        'txtNomeMaterial
        '
        Me.txtNomeMaterial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeMaterial.Location = New System.Drawing.Point(106, 39)
        Me.txtNomeMaterial.Name = "txtNomeMaterial"
        Me.txtNomeMaterial.Size = New System.Drawing.Size(207, 22)
        Me.txtNomeMaterial.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(31, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Valor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(18, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nome"
        '
        'txtNomeFornecedor
        '
        Me.txtNomeFornecedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFornecedor.Location = New System.Drawing.Point(106, 122)
        Me.txtNomeFornecedor.Name = "txtNomeFornecedor"
        Me.txtNomeFornecedor.Size = New System.Drawing.Size(207, 22)
        Me.txtNomeFornecedor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(5, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Fornecedor"
        '
        'txtMarcaMaterial
        '
        Me.txtMarcaMaterial.Location = New System.Drawing.Point(106, 231)
        Me.txtMarcaMaterial.Name = "txtMarcaMaterial"
        Me.txtMarcaMaterial.Size = New System.Drawing.Size(207, 20)
        Me.txtMarcaMaterial.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(31, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Marca"
        '
        'txtQuantidadeMaterial
        '
        Me.txtQuantidadeMaterial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeMaterial.Location = New System.Drawing.Point(106, 266)
        Me.txtQuantidadeMaterial.Name = "txtQuantidadeMaterial"
        Me.txtQuantidadeMaterial.Size = New System.Drawing.Size(207, 22)
        Me.txtQuantidadeMaterial.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(9, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Quantidade"
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(456, 367)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 191
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Pesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(587, 391)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtQuantidadeMaterial)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMarcaMaterial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomeFornecedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNotaFiscalMaterial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExcluirFuncionario)
        Me.Controls.Add(Me.btnLimparUsuario)
        Me.Controls.Add(Me.btnBuscarUsuario)
        Me.Controls.Add(Me.txtValorMaterial)
        Me.Controls.Add(Me.txtNomeMaterial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pesquisa"
        Me.Text = "Pesquisa"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNotaFiscalMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcluirFuncionario As System.Windows.Forms.Button
    Friend WithEvents btnLimparUsuario As System.Windows.Forms.Button
    Friend WithEvents btnBuscarUsuario As System.Windows.Forms.Button
    Friend WithEvents txtValorMaterial As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMarcaMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
