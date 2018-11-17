<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarAlunoAtividade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarAlunoAtividade))
        Me.txtAlunoAtividade = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.dgvBuscarAlunoAtividade = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnBuscarAlunoDisciplinaAtividade = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvBuscarAlunoAtividade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAlunoAtividade
        '
        Me.txtAlunoAtividade.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlunoAtividade.Location = New System.Drawing.Point(67, 12)
        Me.txtAlunoAtividade.Name = "txtAlunoAtividade"
        Me.txtAlunoAtividade.Size = New System.Drawing.Size(343, 22)
        Me.txtAlunoAtividade.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Maroon
        Me.btnOk.Enabled = False
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(302, 195)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(41, 31)
        Me.btnOk.TabIndex = 137
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'dgvBuscarAlunoAtividade
        '
        Me.dgvBuscarAlunoAtividade.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvBuscarAlunoAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscarAlunoAtividade.Location = New System.Drawing.Point(12, 40)
        Me.dgvBuscarAlunoAtividade.Name = "dgvBuscarAlunoAtividade"
        Me.dgvBuscarAlunoAtividade.Size = New System.Drawing.Size(398, 109)
        Me.dgvBuscarAlunoAtividade.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Aluno:"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Maroon
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSair.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(362, 195)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(48, 32)
        Me.btnSair.TabIndex = 134
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnBuscarAlunoDisciplinaAtividade
        '
        Me.btnBuscarAlunoDisciplinaAtividade.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscarAlunoDisciplinaAtividade.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarAlunoDisciplinaAtividade.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBuscarAlunoDisciplinaAtividade.Location = New System.Drawing.Point(217, 194)
        Me.btnBuscarAlunoDisciplinaAtividade.Name = "btnBuscarAlunoDisciplinaAtividade"
        Me.btnBuscarAlunoDisciplinaAtividade.Size = New System.Drawing.Size(69, 32)
        Me.btnBuscarAlunoDisciplinaAtividade.TabIndex = 168
        Me.btnBuscarAlunoDisciplinaAtividade.Text = "Buscar"
        Me.btnBuscarAlunoDisciplinaAtividade.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-52, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 169
        Me.PictureBox1.TabStop = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(300, 232)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 212
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BuscarAlunoAtividade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(423, 251)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnBuscarAlunoDisciplinaAtividade)
        Me.Controls.Add(Me.txtAlunoAtividade)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dgvBuscarAlunoAtividade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscarAlunoAtividade"
        Me.Text = "BuscarAlunoAtividade"
        CType(Me.dgvBuscarAlunoAtividade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAlunoAtividade As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents dgvBuscarAlunoAtividade As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnBuscarAlunoDisciplinaAtividade As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
