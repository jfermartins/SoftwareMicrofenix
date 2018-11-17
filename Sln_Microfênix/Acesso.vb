Imports System.Data.SqlClient
Public Class Acesso
    Public idFuncionario As Integer
    Public nomeFuncionario As String
    

    Private Sub btnAcessar_Click(sender As Object, e As EventArgs) Handles btnAcessar.Click

        'Dim str As String = "Server=SAN0522362W10-1\MSSQLSERVER2;Database=MICROFENIX;User Id=fernanda.martins;Password=vscnqpmo6f@;"


        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure


        cmd.CommandText = "ps_loginFuncionario"

        cmd.Parameters.AddWithValue("usuarioFuncionario", txtLogin.Text)
        cmd.Parameters.AddWithValue("senhaFuncionario", txtSenha.Text)

    
        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()

        dr = cmd.ExecuteReader()

        If dr.Read Then

            Principal.idFuncionario = dr("idFuncionario")
            Principal.nomeFuncionario = dr("nomeFuncionario")
            txtNomeFuncionario.Text = Principal.nomeFuncionario


            If dr("cargoFuncionario") = "Admin" Then

                MessageBox.Show("         Bem vindo (a)  " & txtNomeFuncionario.Text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Principal.mLogin.Visible = False
                Principal.mCadastrarFuncionario.Visible = True
                Principal.mBuscarFuncionario.Visible = True
                Principal.mCadastrarDisciplina.Visible = True
                Principal.mBuscarDisciplina.Visible = True
                Principal.mAlterarDisciplina.Visible = True
                Principal.mCadastrarAtividade.Visible = True
                Principal.mBuscarAtividade.Visible = True
                Principal.mAtribuirNota.Visible = True
                Principal.mBuscarNota.Visible = True
                Principal.mCadastrarMateriais.Visible = True
                Principal.mBuscarMateriais.Visible = True
                Principal.mFuncionario.Visible = True
                Principal.mDisciplina.Visible = True
                Principal.mAtividade.Visible = True
                Principal.mNotasDisciplina.Visible = True
                Principal.mMateriais.Visible = True

                Principal.mCadastrarAluno.Visible = True
                Principal.mMatricularAluno.Visible = True
                Principal.mBuscarAluno.Visible = True
                Principal.mCadastroLaboratorio.Visible = True
                Principal.mOcorrenciaGeral.Visible = True
                Principal.mOcorrenciaLaboratorio.Visible = True
                Principal.mCadastrarCronograma.Visible = True
                Principal.mBuscarCronograma.Visible = True
                Principal.mAlterarCronograma.Visible = True
                Principal.mExcluirCronograma.Visible = True
                Principal.mCronograma.Visible = True
                Principal.mLaboratorio.Visible = True
                Principal.mOcorrencias.Visible = True
                Principal.mAluno.visible = True
                Principal.mAlterarFuncionario.Visible = True

                Principal.mSair.Visible = True

                Me.Close()

            ElseIf dr("cargoFuncionario") = "Administração" Then

                MessageBox.Show("         Bem vindo (a)  " & txtNomeFuncionario.Text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Principal.mLogin.Visible = False
                Principal.mCadastrarFuncionario.Visible = True
                Principal.mBuscarFuncionario.Visible = True
                Principal.mCadastrarDisciplina.Visible = True
                Principal.mBuscarDisciplina.Visible = True
                Principal.mAlterarDisciplina.Visible = True
                Principal.mCadastrarAtividade.Visible = True
                Principal.mBuscarAtividade.Visible = True
                Principal.mAtribuirNota.Visible = True
                Principal.mBuscarNota.Visible = True
                Principal.mCadastrarMateriais.Visible = True
                Principal.mBuscarMateriais.Visible = True
                Principal.mFuncionario.Visible = True
                Principal.mDisciplina.Visible = True
                Principal.mAtividade.Visible = True
                Principal.mNotasDisciplina.Visible = True
                Principal.mMateriais.Visible = True
                Principal.mAluno.Visible = True
                Principal.mCadastrarAluno.Visible = True
                Principal.mMatricularAluno.Visible = True
                Principal.mBuscarAluno.Visible = True
                Principal.mCadastroLaboratorio.Visible = True
                Principal.mOcorrenciaGeral.Visible = True
                Principal.mOcorrenciaLaboratorio.Visible = True
                Principal.mCadastrarCronograma.Visible = True
                Principal.mBuscarCronograma.Visible = True
                Principal.mAlterarCronograma.Visible = True
                Principal.mExcluirCronograma.Visible = True
                Principal.mCronograma.Visible = True
                Principal.mLaboratorio.Visible = True
                Principal.mOcorrencias.Visible = True
                Principal.mAlterarFuncionario.Visible = True

                Principal.mSair.Visible = True

                Me.Close()


            ElseIf dr("cargoFuncionario") = "Diretoria" Then

                MessageBox.Show("         Bem vindo (a)  " & txtNomeFuncionario.Text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Principal.mLogin.Visible = False
                Principal.mCadastrarFuncionario.Visible = True
                Principal.mBuscarFuncionario.Visible = True
                Principal.mCadastrarDisciplina.Visible = True
                Principal.mBuscarDisciplina.Visible = True
                Principal.mAlterarDisciplina.Visible = True
                Principal.mCadastrarAtividade.Visible = True
                Principal.mBuscarAtividade.Visible = True
                Principal.mAtribuirNota.Visible = True
                Principal.mBuscarNota.Visible = True
                Principal.mCadastrarMateriais.Visible = True
                Principal.mBuscarMateriais.Visible = True
                Principal.mFuncionario.Visible = True
                Principal.mDisciplina.Visible = True
                Principal.mAtividade.Visible = True
                Principal.mNotasDisciplina.Visible = True
                Principal.mMateriais.Visible = True
                Principal.mAluno.Visible = True
                Principal.mCadastrarAluno.Visible = True
                Principal.mMatricularAluno.Visible = True
                Principal.mBuscarAluno.Visible = True
                Principal.mCadastroLaboratorio.Visible = True
                Principal.mOcorrenciaGeral.Visible = True
                Principal.mOcorrenciaLaboratorio.Visible = True
                Principal.mCadastrarCronograma.Visible = True
                Principal.mBuscarCronograma.Visible = True
                Principal.mAlterarCronograma.Visible = True
                Principal.mExcluirCronograma.Visible = True
                Principal.mCronograma.Visible = True
                Principal.mLaboratorio.Visible = True
                Principal.mOcorrencias.Visible = True
                Principal.mAlterarFuncionario.Visible = True
                Principal.mSair.Visible = True
                

                Me.Close()

            ElseIf dr("cargoFuncionario") = "Técnico" Then

                MessageBox.Show("         Bem vindo (a)  " & txtNomeFuncionario.Text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Principal.mLogin.Visible = False
                Principal.mCadastrarFuncionario.Visible = False
                Principal.mBuscarFuncionario.Visible = False
                Principal.mCadastrarDisciplina.Visible = False
                Principal.mBuscarDisciplina.Visible = False
                Principal.mAlterarDisciplina.Visible = False
                Principal.mCadastrarAtividade.Visible = False
                Principal.mBuscarAtividade.Visible = False
                Principal.mAtribuirNota.Visible = False
                Principal.mBuscarNota.Visible = False
                Principal.mCadastrarMateriais.Visible = False
                Principal.mBuscarMateriais.Visible = False
                Principal.mFuncionario.Visible = False
                Principal.mDisciplina.Visible = False
                Principal.mAtividade.Visible = False
                Principal.mNotasDisciplina.Visible = False
                Principal.mMateriais.Visible = False
                Principal.mAluno.Visible = False
                Principal.mCadastrarAluno.Visible = False
                Principal.mMatricularAluno.Visible = False
                Principal.mBuscarAluno.Visible = False
                Principal.mCadastroLaboratorio.Visible = True
                Principal.mOcorrenciaGeral.Visible = True
                Principal.mOcorrenciaLaboratorio.Visible = True
                Principal.mCadastrarCronograma.Visible = False
                Principal.mBuscarCronograma.Visible = False
                Principal.mAlterarCronograma.Visible = False
                Principal.mExcluirCronograma.Visible = False
                Principal.mCronograma.Visible = False
                Principal.mLaboratorio.Visible = True
                Principal.mOcorrencias.Visible = True
                Principal.mAlterarFuncionario.Visible = False

                Principal.mSair.Visible = True

                Me.Close()

            ElseIf dr("cargoFuncionario") = "Rh" Then

                MessageBox.Show("         Bem vindo (a)  " & txtNomeFuncionario.Text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Principal.mLogin.Visible = False
                Principal.mCadastrarFuncionario.Visible = True
                Principal.mBuscarFuncionario.Visible = True
                Principal.mCadastrarDisciplina.Visible = False
                Principal.mBuscarDisciplina.Visible = False
                Principal.mAlterarDisciplina.Visible = False
                Principal.mCadastrarAtividade.Visible = False
                Principal.mBuscarAtividade.Visible = False
                Principal.mAtribuirNota.Visible = False
                Principal.mBuscarNota.Visible = False
                Principal.mCadastrarMateriais.Visible = False
                Principal.mBuscarMateriais.Visible = False
                Principal.mFuncionario.Visible = True
                Principal.mDisciplina.Visible = False
                Principal.mAtividade.Visible = False
                Principal.mNotasDisciplina.Visible = False
                Principal.mMateriais.Visible = False
                Principal.mAluno.Visible = False
                Principal.mCadastrarAluno.Visible = True
                Principal.mMatricularAluno.Visible = True
                Principal.mBuscarAluno.Visible = True
                Principal.mCadastroLaboratorio.Visible = False
                Principal.mOcorrenciaGeral.Visible = False
                Principal.mOcorrenciaLaboratorio.Visible = False
                Principal.mCadastrarCronograma.Visible = False
                Principal.mBuscarCronograma.Visible = False
                Principal.mAlterarCronograma.Visible = False
                Principal.mExcluirCronograma.Visible = False
                Principal.mCronograma.Visible = False
                Principal.mLaboratorio.Visible = False
                Principal.mOcorrencias.Visible = False
                Principal.mAlterarFuncionario.Visible = True
                Principal.mSair.Visible = True
                



                Me.Close()

            ElseIf dr("cargoFuncionario") = "Professor" Then


                MessageBox.Show("         Bem vindo (a)  " & txtNomeFuncionario.Text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Principal.mLogin.Visible = False
                Principal.mCadastrarFuncionario.Visible = False
                Principal.mBuscarFuncionario.Visible = False
                Principal.mCadastrarDisciplina.Visible = False
                Principal.mBuscarDisciplina.Visible = False
                Principal.mAlterarDisciplina.Visible = False
                Principal.mCadastrarAtividade.Visible = True
                Principal.mBuscarAtividade.Visible = True
                Principal.mAtribuirNota.Visible = True
                Principal.mBuscarNota.Visible = True
                Principal.mCadastrarMateriais.Visible = False
                Principal.mBuscarMateriais.Visible = False
                Principal.mFuncionario.Visible = True
                Principal.mDisciplina.Visible = False
                Principal.mAtividade.Visible = True
                Principal.mNotasDisciplina.Visible = True
                Principal.mMateriais.Visible = False
                Principal.mAluno.Visible = True
                Principal.mCadastrarAluno.Visible = False
                Principal.mMatricularAluno.Visible = False
                Principal.mBuscarAluno.Visible = False
                Principal.mCadastroLaboratorio.Visible = False
                Principal.mOcorrenciaGeral.Visible = False
                Principal.mOcorrenciaLaboratorio.Visible = False
                Principal.mCadastrarCronograma.Visible = False
                Principal.mBuscarCronograma.Visible = False
                Principal.mAlterarCronograma.Visible = False
                Principal.mExcluirCronograma.Visible = False
                Principal.mCronograma.Visible = False
                Principal.mLaboratorio.Visible = False
                Principal.mOcorrencias.Visible = False
                Principal.mAlterarFuncionario.Visible = False
                Principal.mSair.Visible = True

                

                Me.Close()

            ElseIf dr("cargoFuncionario") = "Secretaria" Then


                MessageBox.Show("         Bem vindo (a)  " & txtNomeFuncionario.Text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Principal.mLogin.Visible = False
                Principal.mCadastrarFuncionario.Visible = False
                Principal.mBuscarFuncionario.Visible = False
                Principal.mCadastrarDisciplina.Visible = False
                Principal.mBuscarDisciplina.Visible = True
                Principal.mAlterarDisciplina.Visible = False
                Principal.mCadastrarAtividade.Visible = False
                Principal.mBuscarAtividade.Visible = True
                Principal.mAtribuirNota.Visible = False
                Principal.mBuscarNota.Visible = True
                Principal.mCadastrarMateriais.Visible = False
                Principal.mBuscarMateriais.Visible = False
                Principal.mFuncionario.Visible = False
                Principal.mDisciplina.Visible = True
                Principal.mAtividade.Visible = True
                Principal.mNotasDisciplina.Visible = True
                Principal.mMateriais.Visible = False
                Principal.mAluno.Visible = True
                Principal.mCadastrarAluno.Visible = True
                Principal.mMatricularAluno.Visible = True
                Principal.mBuscarAluno.Visible = True
                Principal.mCadastroLaboratorio.Visible = False
                Principal.mOcorrenciaGeral.Visible = False
                Principal.mOcorrenciaLaboratorio.Visible = False
                Principal.mCadastrarCronograma.Visible = True
                Principal.mBuscarCronograma.Visible = True
                Principal.mAlterarCronograma.Visible = True
                Principal.mExcluirCronograma.Visible = True
                Principal.mCronograma.Visible = True
                Principal.mLaboratorio.Visible = False
                Principal.mOcorrencias.Visible = False
                Principal.mAlterarFuncionario.Visible = False
                Principal.mSair.Visible = True

               
                Me.Close()
            End If



        Else
            MessageBox.Show("Usuário e/ou senha incorreto(s).", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


            con.Close()
    End Sub


    Private Sub txtLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLogin.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    
   
End Class
