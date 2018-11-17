<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaDisciplinaMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscaDisciplinaMatricula))
        Me.txtData = New System.Windows.Forms.Label()
        Me.btnDisciplina = New System.Windows.Forms.Button()
        Me.txtbuscaDisciplinaMatricula = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.dgvBuscaDisciplinaMatricula = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvBuscaDisciplinaMatricula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(310, 261)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 194
        '
        'btnDisciplina
        '
        Me.btnDisciplina.BackColor = System.Drawing.Color.Maroon
        Me.btnDisciplina.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisciplina.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDisciplina.Location = New System.Drawing.Point(236, 224)
        Me.btnDisciplina.Name = "btnDisciplina"
        Me.btnDisciplina.Size = New System.Drawing.Size(72, 34)
        Me.btnDisciplina.TabIndex = 192
        Me.btnDisciplina.Text = "Buscar"
        Me.btnDisciplina.UseVisualStyleBackColor = False
        '
        'txtbuscaDisciplinaMatricula
        '
        Me.txtbuscaDisciplinaMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscaDisciplinaMatricula.Location = New System.Drawing.Point(81, 6)
        Me.txtbuscaDisciplinaMatricula.Name = "txtbuscaDisciplinaMatricula"
        Me.txtbuscaDisciplinaMatricula.Size = New System.Drawing.Size(346, 22)
        Me.txtbuscaDisciplinaMatricula.TabIndex = 187
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Maroon
        Me.btnOk.Enabled = False
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(314, 224)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(41, 31)
        Me.btnOk.TabIndex = 191
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'dgvBuscaDisciplinaMatricula
        '
        Me.dgvBuscaDisciplinaMatricula.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvBuscaDisciplinaMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscaDisciplinaMatricula.Location = New System.Drawing.Point(10, 34)
        Me.dgvBuscaDisciplinaMatricula.Name = "dgvBuscaDisciplinaMatricula"
        Me.dgvBuscaDisciplinaMatricula.Size = New System.Drawing.Size(417, 170)
        Me.dgvBuscaDisciplinaMatricula.TabIndex = 188
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "Disciplina:"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Maroon
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSair.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(361, 223)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(48, 32)
        Me.btnSair.TabIndex = 189
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-68, 210)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(309, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 193
        Me.PictureBox2.TabStop = False
        '
        'BuscaDisciplinaMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(443, 299)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnDisciplina)
        Me.Controls.Add(Me.txtbuscaDisciplinaMatricula)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dgvBuscaDisciplinaMatricula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "BuscaDisciplinaMatricula"
        Me.Text = "BuscaDisciplinaMatricula"
        CType(Me.dgvBuscaDisciplinaMatricula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents btnDisciplina As System.Windows.Forms.Button
    Friend WithEvents txtbuscaDisciplinaMatricula As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents dgvBuscaDisciplinaMatricula As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
