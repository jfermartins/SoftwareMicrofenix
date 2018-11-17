<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PesquisaAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PesquisaAluno))
        Me.btnBuscaPesquisa = New System.Windows.Forms.Button()
        Me.btnLimpaPesquisa = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBuscaPesquisa = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtMatriculaPesquisa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCpfPesquisa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlunoPesquisa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMatriculaPesquisa = New System.Windows.Forms.Button()
        Me.btnCadastroPesquisa = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscaPesquisa
        '
        Me.btnBuscaPesquisa.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscaPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscaPesquisa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaPesquisa.ForeColor = System.Drawing.Color.White
        Me.btnBuscaPesquisa.Location = New System.Drawing.Point(249, 39)
        Me.btnBuscaPesquisa.Name = "btnBuscaPesquisa"
        Me.btnBuscaPesquisa.Size = New System.Drawing.Size(150, 32)
        Me.btnBuscaPesquisa.TabIndex = 2
        Me.btnBuscaPesquisa.Text = "Buscar"
        Me.btnBuscaPesquisa.UseVisualStyleBackColor = False
        '
        'btnLimpaPesquisa
        '
        Me.btnLimpaPesquisa.BackColor = System.Drawing.Color.Maroon
        Me.btnLimpaPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpaPesquisa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpaPesquisa.ForeColor = System.Drawing.Color.White
        Me.btnLimpaPesquisa.Location = New System.Drawing.Point(414, 39)
        Me.btnLimpaPesquisa.Name = "btnLimpaPesquisa"
        Me.btnLimpaPesquisa.Size = New System.Drawing.Size(150, 32)
        Me.btnLimpaPesquisa.TabIndex = 3
        Me.btnLimpaPesquisa.Text = "Limpar"
        Me.btnLimpaPesquisa.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(30, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "C.P.F. do Aluno:"
        '
        'txtBuscaPesquisa
        '
        Me.txtBuscaPesquisa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscaPesquisa.Location = New System.Drawing.Point(144, 11)
        Me.txtBuscaPesquisa.Name = "txtBuscaPesquisa"
        Me.txtBuscaPesquisa.Size = New System.Drawing.Size(420, 22)
        Me.txtBuscaPesquisa.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 154)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'txtMatriculaPesquisa
        '
        Me.txtMatriculaPesquisa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaPesquisa.Location = New System.Drawing.Point(249, 170)
        Me.txtMatriculaPesquisa.Name = "txtMatriculaPesquisa"
        Me.txtMatriculaPesquisa.Size = New System.Drawing.Size(315, 22)
        Me.txtMatriculaPesquisa.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(121, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "C.P.F. (apenas nº):"
        '
        'txtCpfPesquisa
        '
        Me.txtCpfPesquisa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCpfPesquisa.Location = New System.Drawing.Point(249, 132)
        Me.txtCpfPesquisa.Name = "txtCpfPesquisa"
        Me.txtCpfPesquisa.Size = New System.Drawing.Size(315, 22)
        Me.txtCpfPesquisa.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(134, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nº de Matrícula:"
        '
        'txtAlunoPesquisa
        '
        Me.txtAlunoPesquisa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlunoPesquisa.Location = New System.Drawing.Point(249, 94)
        Me.txtAlunoPesquisa.Name = "txtAlunoPesquisa"
        Me.txtAlunoPesquisa.Size = New System.Drawing.Size(315, 22)
        Me.txtAlunoPesquisa.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(194, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Aluno:"
        '
        'btnMatriculaPesquisa
        '
        Me.btnMatriculaPesquisa.BackColor = System.Drawing.Color.Maroon
        Me.btnMatriculaPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMatriculaPesquisa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatriculaPesquisa.ForeColor = System.Drawing.Color.White
        Me.btnMatriculaPesquisa.Location = New System.Drawing.Point(414, 235)
        Me.btnMatriculaPesquisa.Name = "btnMatriculaPesquisa"
        Me.btnMatriculaPesquisa.Size = New System.Drawing.Size(150, 43)
        Me.btnMatriculaPesquisa.TabIndex = 8
        Me.btnMatriculaPesquisa.Text = "Matricula"
        Me.btnMatriculaPesquisa.UseVisualStyleBackColor = False
        Me.btnMatriculaPesquisa.Visible = False
        '
        'btnCadastroPesquisa
        '
        Me.btnCadastroPesquisa.BackColor = System.Drawing.Color.Maroon
        Me.btnCadastroPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCadastroPesquisa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastroPesquisa.ForeColor = System.Drawing.Color.White
        Me.btnCadastroPesquisa.Location = New System.Drawing.Point(249, 235)
        Me.btnCadastroPesquisa.Name = "btnCadastroPesquisa"
        Me.btnCadastroPesquisa.Size = New System.Drawing.Size(150, 43)
        Me.btnCadastroPesquisa.TabIndex = 7
        Me.btnCadastroPesquisa.Text = "Cadastro"
        Me.btnCadastroPesquisa.UseVisualStyleBackColor = False
        Me.btnCadastroPesquisa.Visible = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(458, 280)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 191
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PesquisaAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 301)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnCadastroPesquisa)
        Me.Controls.Add(Me.btnMatriculaPesquisa)
        Me.Controls.Add(Me.btnBuscaPesquisa)
        Me.Controls.Add(Me.btnLimpaPesquisa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBuscaPesquisa)
        Me.Controls.Add(Me.txtMatriculaPesquisa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCpfPesquisa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAlunoPesquisa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PesquisaAluno"
        Me.Text = "Pesquisar Aluno"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscaPesquisa As System.Windows.Forms.Button
    Friend WithEvents btnLimpaPesquisa As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBuscaPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtMatriculaPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCpfPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlunoPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMatriculaPesquisa As System.Windows.Forms.Button
    Friend WithEvents btnCadastroPesquisa As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
