<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ocorrencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ocorrencia))
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.txthOcorrencia = New System.Windows.Forms.TextBox()
        Me.txtdtocorrencia = New System.Windows.Forms.TextBox()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNocorrencia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSol = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.btnAlt.Location = New System.Drawing.Point(506, 359)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(97, 33)
        Me.btnAlt.TabIndex = 25
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = False
        '
        'txtProv
        '
        Me.txtProv.Location = New System.Drawing.Point(312, 144)
        Me.txtProv.Multiline = True
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(357, 88)
        Me.txtProv.TabIndex = 4
        '
        'txthOcorrencia
        '
        Me.txthOcorrencia.Location = New System.Drawing.Point(311, 108)
        Me.txthOcorrencia.Name = "txthOcorrencia"
        Me.txthOcorrencia.Size = New System.Drawing.Size(358, 20)
        Me.txthOcorrencia.TabIndex = 3
        '
        'txtdtocorrencia
        '
        Me.txtdtocorrencia.Location = New System.Drawing.Point(311, 66)
        Me.txtdtocorrencia.Name = "txtdtocorrencia"
        Me.txtdtocorrencia.Size = New System.Drawing.Size(358, 20)
        Me.txtdtocorrencia.TabIndex = 2
        '
        'btnCad
        '
        Me.btnCad.BackColor = System.Drawing.Color.Maroon
        Me.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCad.ForeColor = System.Drawing.Color.White
        Me.btnCad.Location = New System.Drawing.Point(312, 359)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(97, 33)
        Me.btnCad.TabIndex = 24
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Maroon
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Location = New System.Drawing.Point(678, 359)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(101, 33)
        Me.btnExcluir.TabIndex = 26
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(206, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Providências:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(258, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Hora:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(259, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Data:"
        '
        'txtNocorrencia
        '
        Me.txtNocorrencia.Location = New System.Drawing.Point(311, 33)
        Me.txtNocorrencia.Name = "txtNocorrencia"
        Me.txtNocorrencia.Size = New System.Drawing.Size(357, 20)
        Me.txtNocorrencia.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(157, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Natureza Ocorrência:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 448)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(224, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Solução:"
        '
        'txtSol
        '
        Me.txtSol.Location = New System.Drawing.Point(312, 254)
        Me.txtSol.Multiline = True
        Me.txtSol.Name = "txtSol"
        Me.txtSol.Size = New System.Drawing.Size(357, 87)
        Me.txtSol.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(678, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 27)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(669, 399)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 191
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Ocorrencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(799, 532)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.txtProv)
        Me.Controls.Add(Me.txthOcorrencia)
        Me.Controls.Add(Me.txtdtocorrencia)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNocorrencia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ocorrencia"
        Me.Text = "Ocorrência"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAlt As System.Windows.Forms.Button
    Friend WithEvents txtProv As System.Windows.Forms.TextBox
    Friend WithEvents txthOcorrencia As System.Windows.Forms.TextBox
    Friend WithEvents txtdtocorrencia As System.Windows.Forms.TextBox
    Friend WithEvents btnCad As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNocorrencia As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSol As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
