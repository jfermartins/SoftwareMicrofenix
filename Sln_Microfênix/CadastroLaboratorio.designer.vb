<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroLaboratorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroLaboratorio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.txtTecnico = New System.Windows.Forms.TextBox()
        Me.txtHorario = New System.Windows.Forms.TextBox()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNLaboratorio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.btnBuscarNlab = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(773, 448)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(290, 161)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(357, 20)
        Me.txtRG.TabIndex = 4
        '
        'txtTecnico
        '
        Me.txtTecnico.Location = New System.Drawing.Point(289, 123)
        Me.txtTecnico.Name = "txtTecnico"
        Me.txtTecnico.Size = New System.Drawing.Size(358, 20)
        Me.txtTecnico.TabIndex = 3
        '
        'txtHorario
        '
        Me.txtHorario.Location = New System.Drawing.Point(289, 87)
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(358, 20)
        Me.txtHorario.TabIndex = 2
        '
        'btnCad
        '
        Me.btnCad.BackColor = System.Drawing.Color.Maroon
        Me.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCad.ForeColor = System.Drawing.Color.White
        Me.btnCad.Location = New System.Drawing.Point(289, 202)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(97, 33)
        Me.btnCad.TabIndex = 5
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Maroon
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Location = New System.Drawing.Point(653, 202)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(101, 33)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(252, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "RG:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(221, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Técnico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(222, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Horário: "
        '
        'txtNLaboratorio
        '
        Me.txtNLaboratorio.Location = New System.Drawing.Point(290, 53)
        Me.txtNLaboratorio.Name = "txtNLaboratorio"
        Me.txtNLaboratorio.Size = New System.Drawing.Size(357, 20)
        Me.txtNLaboratorio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(152, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nome Laboratório:"
        '
        'btnAlt
        '
        Me.btnAlt.BackColor = System.Drawing.Color.Maroon
        Me.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlt.ForeColor = System.Drawing.Color.White
        Me.btnAlt.Location = New System.Drawing.Point(478, 202)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(97, 33)
        Me.btnAlt.TabIndex = 6
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = False
        '
        'btnBuscarNlab
        '
        Me.btnBuscarNlab.BackColor = System.Drawing.Color.Maroon
        Me.btnBuscarNlab.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarNlab.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarNlab.ForeColor = System.Drawing.Color.White
        Me.btnBuscarNlab.Location = New System.Drawing.Point(653, 53)
        Me.btnBuscarNlab.Name = "btnBuscarNlab"
        Me.btnBuscarNlab.Size = New System.Drawing.Size(100, 24)
        Me.btnBuscarNlab.TabIndex = 20
        Me.btnBuscarNlab.Text = "Buscar"
        Me.btnBuscarNlab.UseVisualStyleBackColor = False
        '
        'txtData
        '
        Me.txtData.AutoSize = True
        Me.txtData.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.ForeColor = System.Drawing.Color.Maroon
        Me.txtData.Location = New System.Drawing.Point(636, 251)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(0, 16)
        Me.txtData.TabIndex = 170
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'CadastroLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 392)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnBuscarNlab)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.txtTecnico)
        Me.Controls.Add(Me.txtHorario)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNLaboratorio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastroLaboratorio"
        Me.Text = "Cadastro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents txtTecnico As System.Windows.Forms.TextBox
    Friend WithEvents txtHorario As System.Windows.Forms.TextBox
    Friend WithEvents btnCad As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNLaboratorio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAlt As System.Windows.Forms.Button
    Friend WithEvents btnBuscarNlab As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
