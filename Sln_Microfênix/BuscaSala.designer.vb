<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaSala
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscaSala))
        Me.btnDisciplina = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.dgvSala = New System.Windows.Forms.DataGridView()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtSalaBusca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvSala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisciplina
        '
        Me.btnDisciplina.BackColor = System.Drawing.Color.Maroon
        Me.btnDisciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisciplina.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDisciplina.Location = New System.Drawing.Point(172, 195)
        Me.btnDisciplina.Name = "btnDisciplina"
        Me.btnDisciplina.Size = New System.Drawing.Size(71, 31)
        Me.btnDisciplina.TabIndex = 186
        Me.btnDisciplina.Text = "Buscar"
        Me.btnDisciplina.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Maroon
        Me.btnOk.Enabled = False
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(263, 195)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(41, 31)
        Me.btnOk.TabIndex = 185
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'dgvSala
        '
        Me.dgvSala.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSala.Location = New System.Drawing.Point(15, 60)
        Me.dgvSala.Name = "dgvSala"
        Me.dgvSala.Size = New System.Drawing.Size(392, 118)
        Me.dgvSala.TabIndex = 2
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Maroon
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSair.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(310, 194)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(48, 32)
        Me.btnSair.TabIndex = 183
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'txtSalaBusca
        '
        Me.txtSalaBusca.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalaBusca.Location = New System.Drawing.Point(59, 22)
        Me.txtSalaBusca.Name = "txtSalaBusca"
        Me.txtSalaBusca.Size = New System.Drawing.Size(348, 22)
        Me.txtSalaBusca.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "Sala:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-108, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 189
        Me.PictureBox1.TabStop = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(292, 235)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 213
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BuscaSala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(419, 254)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtSalaBusca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisciplina)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dgvSala)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscaSala"
        Me.Text = "BuscaSala"
        CType(Me.dgvSala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisciplina As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents dgvSala As System.Windows.Forms.DataGridView
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents txtSalaBusca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
