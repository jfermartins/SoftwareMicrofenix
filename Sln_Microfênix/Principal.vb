Public Class Principal
    Public idFuncionario As Integer
    Public idAtividade As Integer = 0
    Public nomeFuncionario As String = ""
    Public nomeDisciplina As String = ""
    Public docenteDisciplina As String = ""
    Public cargaHorariaDisciplina As Double = 0
    Public idDisciplina As Integer = 0
    Public nomeAtividade As String = ""
    Public conteudoAtividade As String = ""
    Public dtHrAtividade As String = ""
    Public DocenteAtividade As String = ""
    Public mencaoAtividade As Double = 0
    Public faltasAtividade As Integer = 0
    Public media As Double = 0
    Public Faltas As Integer = 0
    Public TurmaSala As String = ""
    Public dtHrSala As String = ""
    Public dadosSala As String = ""
    Public nomeDocenteSala As String = ""
    Public idCronograma As Integer = 0
    Public nomeLaboratorio As String = ""
    Public HrLaboratorio As String = ""
    Public tecnicoLaboratorio As String = ""
    Public rgTecnicoLaboratorio As String = ""
    Public nomeAluno As String = ""
    Public idAluno As Integer = 0




    Private Sub AcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mLogin.Click
        Dim f As Acesso = New Acesso()

        f.MdiParent = Me

        f.Show()
    End Sub


   

    Private Sub mSair_Click(sender As Object, e As EventArgs) Handles mSair.Click
        mLogin.Visible = True
        mCadastrarFuncionario.Visible = False
        mBuscarFuncionario.Visible = False
        mCadastrarDisciplina.Visible = False
        mBuscarDisciplina.Visible = False
        mAlterarDisciplina.Visible = False
        mCadastrarAtividade.Visible = False
        mBuscarAtividade.Visible = False
        mAtribuirNota.Visible = False
        mBuscarNota.Visible = False
        mCadastrarMateriais.Visible = False
        mBuscarMateriais.Visible = False
        mFuncionario.Visible = False
        mDisciplina.Visible = False
        mAtividade.Visible = False
        mNotasDisciplina.Visible = False
        mMateriais.Visible = False
        mAluno.Visible = False
        mCadastrarAluno.Visible = False
        mMatricularAluno.Visible = False
        mBuscarAluno.Visible = False
        mCadastroLaboratorio.Visible = False
        mOcorrenciaGeral.Visible = False
        mOcorrenciaLaboratorio.Visible = False
        mCadastrarCronograma.Visible = False
        mBuscarCronograma.Visible = False
        mAlterarCronograma.Visible = False
        mExcluirCronograma.Visible = False
        mCronograma.Visible = False
        mLaboratorio.Visible = False
        mOcorrencias.Visible = False
        mAlterarFuncionario.Visible = False
        mSair.Visible = False

        For Each f As Form In Me.MdiChildren
            If TypeOf f Is Form Then
                f.Close()
            End If

        Next

    End Sub

    

   

    
  
  
    Private Sub mBuscarDisciplina_Click_1(sender As Object, e As EventArgs) Handles mBuscarDisciplina.Click
        Dim f As BuscarDisciplina = New BuscarDisciplina()
        f.MdiParent = Me
        f.Show()
    End Sub


    Private Sub AlrerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mAlterarDisciplina.Click
        Dim f As Atualizacao_e_Exclusao_Disciplina = New Atualizacao_e_Exclusao_Disciplina()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mDisciplina_Click(sender As Object, e As EventArgs) Handles mCadastrarDisciplina.Click
        Dim f As CadastrarDisciplina = New CadastrarDisciplina()
        f.MdiParent = Me
        f.Show()
    End Sub

    
   
    Private Sub mCadastrarAtividade_Click(sender As Object, e As EventArgs) Handles mCadastrarAtividade.Click
        Dim f As Cadastro_Atividade = New Cadastro_Atividade
        f.MdiParent = Me
        f.Show()
    End Sub

 
    Private Sub mBuscar_Click(sender As Object, e As EventArgs) Handles mBuscarAtividade.Click
        Dim f As BuscarAtividade = New BuscarAtividade
        f.MdiParent = Me
        f.Show()
    End Sub

 
  
    Private Sub mAtribuirNota_Click(sender As Object, e As EventArgs) Handles mAtribuirNota.Click

        Dim f As notas_Faltas = New notas_Faltas
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mBuscarNota_Click(sender As Object, e As EventArgs) Handles mBuscarNota.Click
        Dim f As consultasMedia = New consultasMedia
        f.MdiParent = Me
        f.Show()
    End Sub

    
  
   
    Private Sub mCadastrarFuncionario_Click(sender As Object, e As EventArgs) Handles mCadastrarFuncionario.Click
        Dim f As CadastrarFuncionario = New CadastrarFuncionario()

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mBuscarFuncionario.Click

        Dim f As PesquisaFuncionario = New PesquisaFuncionario()

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mCadastrarMateriais_Click(sender As Object, e As EventArgs) Handles mCadastrarMateriais.Click

        Dim f As CadastroM = New CadastroM()

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mBuscarMateriais_Click(sender As Object, e As EventArgs) Handles mBuscarMateriais.Click

        Dim f As Pesquisa = New Pesquisa()

        f.MdiParent = Me

        f.Show()
    End Sub



   
    Private Sub mCadastroLaboratorio_Click(sender As Object, e As EventArgs) Handles mCadastroLaboratorio.Click
        Dim f As CadastroLaboratorio = New CadastroLaboratorio

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mOcorrenciaLaboratorio_Click(sender As Object, e As EventArgs) Handles mOcorrenciaLaboratorio.Click
        Dim f As Ocorrencia = New Ocorrencia

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mOcorrenciaGeral_Click(sender As Object, e As EventArgs) Handles mOcorrenciaGeral.Click
        Dim f As Cadastro_Ocorrencia_Geral = New Cadastro_Ocorrencia_Geral

        f.MdiParent = Me

        f.Show()
    End Sub

   
    
  
    Private Sub mCastrarCronograma_Click(sender As Object, e As EventArgs) Handles mCadastrarCronograma.Click
        Dim f As cronogramaSala = New cronogramaSala

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mBuscarCronograma_Click(sender As Object, e As EventArgs) Handles mBuscarCronograma.Click
        Dim f As BuscaSala = New BuscaSala

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mAlterarCronograma_Click(sender As Object, e As EventArgs) Handles mAlterarCronograma.Click
        Dim f As AlterarCronograma = New AlterarCronograma

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mCadastrarAluno_Click(sender As Object, e As EventArgs) Handles mCadastrarAluno.Click
        Dim f As CadastroAluno = New CadastroAluno
        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mMatricularAluno_Click(sender As Object, e As EventArgs) Handles mMatricularAluno.Click
        Dim f As MatriculaAluno = New MatriculaAluno

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mBuscarAluno_Click(sender As Object, e As EventArgs) Handles mBuscarAluno.Click
        Dim f As PesquisaAluno = New PesquisaAluno
        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub mExcluirCronograma_Click(sender As Object, e As EventArgs) Handles mExcluirCronograma.Click
        Dim f As AlterarCronograma = New AlterarCronograma

        f.MdiParent = Me

        f.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mAlterarFuncionario.Click
        Dim f As AlterarFuncionario = New AlterarFuncionario

        f.MdiParent = Me

        f.Show()
    End Sub

   
    
   
    
   

End Class