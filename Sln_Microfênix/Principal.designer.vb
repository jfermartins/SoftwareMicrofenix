<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mFuncionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCadastrarFuncionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBuscarFuncionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAlterarFuncionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAluno = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCadastrarAluno = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMatricularAluno = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBuscarAluno = New System.Windows.Forms.ToolStripMenuItem()
        Me.mDisciplina = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCadastrarDisciplina = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBuscarDisciplina = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAlterarDisciplina = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAtividade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCadastrarAtividade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBuscarAtividade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mNotasDisciplina = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAtribuirNota = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBuscarNota = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCronograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCadastrarCronograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBuscarCronograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAlterarCronograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.mExcluirCronograma = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMateriais = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCadastrarMateriais = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBuscarMateriais = New System.Windows.Forms.ToolStripMenuItem()
        Me.mLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCadastroLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mOcorrenciaLaboratorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mOcorrencias = New System.Windows.Forms.ToolStripMenuItem()
        Me.mOcorrenciaGeral = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mLogin, Me.mFuncionario, Me.mAluno, Me.mDisciplina, Me.mAtividade, Me.mNotasDisciplina, Me.mCronograma, Me.mMateriais, Me.mLaboratorio, Me.mOcorrencias, Me.mSair})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mLogin
        '
        Me.mLogin.Name = "mLogin"
        Me.mLogin.Size = New System.Drawing.Size(56, 20)
        Me.mLogin.Text = "Acesso"
        '
        'mFuncionario
        '
        Me.mFuncionario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mCadastrarFuncionario, Me.mBuscarFuncionario, Me.mAlterarFuncionario})
        Me.mFuncionario.Name = "mFuncionario"
        Me.mFuncionario.Size = New System.Drawing.Size(82, 20)
        Me.mFuncionario.Text = "Funcionário"
        Me.mFuncionario.Visible = False
        '
        'mCadastrarFuncionario
        '
        Me.mCadastrarFuncionario.Name = "mCadastrarFuncionario"
        Me.mCadastrarFuncionario.Size = New System.Drawing.Size(124, 22)
        Me.mCadastrarFuncionario.Text = "Cadastrar"
        Me.mCadastrarFuncionario.Visible = False
        '
        'mBuscarFuncionario
        '
        Me.mBuscarFuncionario.Name = "mBuscarFuncionario"
        Me.mBuscarFuncionario.Size = New System.Drawing.Size(124, 22)
        Me.mBuscarFuncionario.Text = "Buscar"
        Me.mBuscarFuncionario.Visible = False
        '
        'mAlterarFuncionario
        '
        Me.mAlterarFuncionario.Name = "mAlterarFuncionario"
        Me.mAlterarFuncionario.Size = New System.Drawing.Size(124, 22)
        Me.mAlterarFuncionario.Text = "Alterar"
        Me.mAlterarFuncionario.Visible = False
        '
        'mAluno
        '
        Me.mAluno.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mCadastrarAluno, Me.mMatricularAluno, Me.mBuscarAluno})
        Me.mAluno.Name = "mAluno"
        Me.mAluno.Size = New System.Drawing.Size(51, 20)
        Me.mAluno.Text = "Aluno"
        Me.mAluno.Visible = False
        '
        'mCadastrarAluno
        '
        Me.mCadastrarAluno.Name = "mCadastrarAluno"
        Me.mCadastrarAluno.Size = New System.Drawing.Size(128, 22)
        Me.mCadastrarAluno.Text = "Cadastrar"
        Me.mCadastrarAluno.Visible = False
        '
        'mMatricularAluno
        '
        Me.mMatricularAluno.Name = "mMatricularAluno"
        Me.mMatricularAluno.Size = New System.Drawing.Size(128, 22)
        Me.mMatricularAluno.Text = "Matricular"
        Me.mMatricularAluno.Visible = False
        '
        'mBuscarAluno
        '
        Me.mBuscarAluno.Name = "mBuscarAluno"
        Me.mBuscarAluno.Size = New System.Drawing.Size(128, 22)
        Me.mBuscarAluno.Text = "Buscar"
        Me.mBuscarAluno.Visible = False
        '
        'mDisciplina
        '
        Me.mDisciplina.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mCadastrarDisciplina, Me.mBuscarDisciplina, Me.mAlterarDisciplina})
        Me.mDisciplina.Name = "mDisciplina"
        Me.mDisciplina.Size = New System.Drawing.Size(70, 20)
        Me.mDisciplina.Text = "Disciplina"
        Me.mDisciplina.Visible = False
        '
        'mCadastrarDisciplina
        '
        Me.mCadastrarDisciplina.Name = "mCadastrarDisciplina"
        Me.mCadastrarDisciplina.Size = New System.Drawing.Size(124, 22)
        Me.mCadastrarDisciplina.Text = "Cadastrar"
        '
        'mBuscarDisciplina
        '
        Me.mBuscarDisciplina.Name = "mBuscarDisciplina"
        Me.mBuscarDisciplina.Size = New System.Drawing.Size(124, 22)
        Me.mBuscarDisciplina.Text = "Buscar"
        Me.mBuscarDisciplina.Visible = False
        '
        'mAlterarDisciplina
        '
        Me.mAlterarDisciplina.Name = "mAlterarDisciplina"
        Me.mAlterarDisciplina.Size = New System.Drawing.Size(124, 22)
        Me.mAlterarDisciplina.Text = "Alterar"
        Me.mAlterarDisciplina.Visible = False
        '
        'mAtividade
        '
        Me.mAtividade.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mCadastrarAtividade, Me.mBuscarAtividade})
        Me.mAtividade.Name = "mAtividade"
        Me.mAtividade.Size = New System.Drawing.Size(69, 20)
        Me.mAtividade.Text = "Atividade"
        Me.mAtividade.Visible = False
        '
        'mCadastrarAtividade
        '
        Me.mCadastrarAtividade.Name = "mCadastrarAtividade"
        Me.mCadastrarAtividade.Size = New System.Drawing.Size(124, 22)
        Me.mCadastrarAtividade.Text = "Cadastrar"
        Me.mCadastrarAtividade.Visible = False
        '
        'mBuscarAtividade
        '
        Me.mBuscarAtividade.Name = "mBuscarAtividade"
        Me.mBuscarAtividade.Size = New System.Drawing.Size(124, 22)
        Me.mBuscarAtividade.Text = "Buscar"
        Me.mBuscarAtividade.Visible = False
        '
        'mNotasDisciplina
        '
        Me.mNotasDisciplina.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mAtribuirNota, Me.mBuscarNota})
        Me.mNotasDisciplina.Name = "mNotasDisciplina"
        Me.mNotasDisciplina.Size = New System.Drawing.Size(104, 20)
        Me.mNotasDisciplina.Text = "Notas Disciplina"
        Me.mNotasDisciplina.Visible = False
        '
        'mAtribuirNota
        '
        Me.mAtribuirNota.Name = "mAtribuirNota"
        Me.mAtribuirNota.Size = New System.Drawing.Size(114, 22)
        Me.mAtribuirNota.Text = "Atribuir"
        Me.mAtribuirNota.Visible = False
        '
        'mBuscarNota
        '
        Me.mBuscarNota.Name = "mBuscarNota"
        Me.mBuscarNota.Size = New System.Drawing.Size(114, 22)
        Me.mBuscarNota.Text = "Buscar"
        Me.mBuscarNota.Visible = False
        '
        'mCronograma
        '
        Me.mCronograma.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mCadastrarCronograma, Me.mBuscarCronograma, Me.mAlterarCronograma, Me.mExcluirCronograma})
        Me.mCronograma.Name = "mCronograma"
        Me.mCronograma.Size = New System.Drawing.Size(115, 20)
        Me.mCronograma.Text = "Cronograma Salas"
        Me.mCronograma.Visible = False
        '
        'mCadastrarCronograma
        '
        Me.mCadastrarCronograma.Name = "mCadastrarCronograma"
        Me.mCadastrarCronograma.Size = New System.Drawing.Size(124, 22)
        Me.mCadastrarCronograma.Text = "Cadastrar"
        Me.mCadastrarCronograma.Visible = False
        '
        'mBuscarCronograma
        '
        Me.mBuscarCronograma.Name = "mBuscarCronograma"
        Me.mBuscarCronograma.Size = New System.Drawing.Size(124, 22)
        Me.mBuscarCronograma.Text = "Buscar"
        Me.mBuscarCronograma.Visible = False
        '
        'mAlterarCronograma
        '
        Me.mAlterarCronograma.Name = "mAlterarCronograma"
        Me.mAlterarCronograma.Size = New System.Drawing.Size(124, 22)
        Me.mAlterarCronograma.Text = "Alterar"
        Me.mAlterarCronograma.Visible = False
        '
        'mExcluirCronograma
        '
        Me.mExcluirCronograma.Name = "mExcluirCronograma"
        Me.mExcluirCronograma.Size = New System.Drawing.Size(124, 22)
        Me.mExcluirCronograma.Text = "Excluir"
        Me.mExcluirCronograma.Visible = False
        '
        'mMateriais
        '
        Me.mMateriais.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mCadastrarMateriais, Me.mBuscarMateriais})
        Me.mMateriais.Name = "mMateriais"
        Me.mMateriais.Size = New System.Drawing.Size(67, 20)
        Me.mMateriais.Text = "Materiais"
        Me.mMateriais.Visible = False
        '
        'mCadastrarMateriais
        '
        Me.mCadastrarMateriais.Name = "mCadastrarMateriais"
        Me.mCadastrarMateriais.Size = New System.Drawing.Size(124, 22)
        Me.mCadastrarMateriais.Text = "Cadastrar"
        Me.mCadastrarMateriais.Visible = False
        '
        'mBuscarMateriais
        '
        Me.mBuscarMateriais.Name = "mBuscarMateriais"
        Me.mBuscarMateriais.Size = New System.Drawing.Size(124, 22)
        Me.mBuscarMateriais.Text = "Buscar"
        Me.mBuscarMateriais.Visible = False
        '
        'mLaboratorio
        '
        Me.mLaboratorio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mCadastroLaboratorio, Me.mOcorrenciaLaboratorio})
        Me.mLaboratorio.Name = "mLaboratorio"
        Me.mLaboratorio.Size = New System.Drawing.Size(80, 20)
        Me.mLaboratorio.Text = "Laboratório"
        Me.mLaboratorio.Visible = False
        '
        'mCadastroLaboratorio
        '
        Me.mCadastroLaboratorio.Name = "mCadastroLaboratorio"
        Me.mCadastroLaboratorio.Size = New System.Drawing.Size(132, 22)
        Me.mCadastroLaboratorio.Text = "Cadastro"
        Me.mCadastroLaboratorio.Visible = False
        '
        'mOcorrenciaLaboratorio
        '
        Me.mOcorrenciaLaboratorio.Name = "mOcorrenciaLaboratorio"
        Me.mOcorrenciaLaboratorio.Size = New System.Drawing.Size(132, 22)
        Me.mOcorrenciaLaboratorio.Text = "Ocorrência"
        Me.mOcorrenciaLaboratorio.Visible = False
        '
        'mOcorrencias
        '
        Me.mOcorrencias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mOcorrenciaGeral})
        Me.mOcorrencias.Name = "mOcorrencias"
        Me.mOcorrencias.Size = New System.Drawing.Size(117, 20)
        Me.mOcorrencias.Text = "Ocorrências Gerais"
        Me.mOcorrencias.Visible = False
        '
        'mOcorrenciaGeral
        '
        Me.mOcorrenciaGeral.Name = "mOcorrenciaGeral"
        Me.mOcorrenciaGeral.Size = New System.Drawing.Size(121, 22)
        Me.mOcorrenciaGeral.Text = "Cadastro"
        Me.mOcorrenciaGeral.Visible = False
        '
        'mSair
        '
        Me.mSair.Name = "mSair"
        Me.mSair.Size = New System.Drawing.Size(38, 20)
        Me.mSair.Text = "Sair"
        Me.mSair.Visible = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "MICROFÊNIX"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mDisciplina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBuscarDisciplina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCadastrarDisciplina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mAlterarDisciplina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mAtividade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCadastrarAtividade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBuscarAtividade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mNotasDisciplina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mAtribuirNota As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBuscarNota As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mFuncionario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCadastrarFuncionario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBuscarFuncionario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMateriais As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCadastrarMateriais As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBuscarMateriais As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mLaboratorio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCadastroLaboratorio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mOcorrenciaLaboratorio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mOcorrencias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mOcorrenciaGeral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCronograma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCadastrarCronograma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBuscarCronograma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mAlterarCronograma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mExcluirCronograma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mAluno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCadastrarAluno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMatricularAluno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBuscarAluno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mAlterarFuncionario As System.Windows.Forms.ToolStripMenuItem
End Class
