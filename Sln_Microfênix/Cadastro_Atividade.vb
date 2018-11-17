Imports System.Data.SqlClient

Public Class Cadastro_Atividade
   


    Private Sub btnCadastrarAtividade_Click(sender As Object, e As EventArgs) Handles btnCadastrarAtividade.Click

        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then


         
            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

            Dim con As SqlConnection = New SqlConnection(str)


            'dedinindo o comando do sql q será utilizado

            Dim cmd As SqlCommand = New SqlCommand()



            'chamando uma stored procedure
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pi_Atividade"


            'definindo valores (parametros)
            cmd.Parameters.AddWithValue("nomeAtividade", txtAtividade.Text)
            cmd.Parameters.AddWithValue("conteudoAtividade", txtConteudo.Text)
            cmd.Parameters.AddWithValue("dtHrAtividade", CDate(txtDataHr.Text))
            cmd.Parameters.AddWithValue("docenteAtividade", txtDocente.Text)
            cmd.Parameters.AddWithValue("mencaoAtividade", CDbl(txtMencao.Text))
            cmd.Parameters.AddWithValue("faltasAtividade", CInt(txtFaltas.Text))
            cmd.Parameters.AddWithValue("idAluno", Principal.idAluno)
            cmd.Parameters.AddWithValue("idDisciplina", Principal.idDisciplina)
            cmd.Parameters.AddWithValue("idFuncionario", Principal.idFuncionario)





            'definir quem é a conexão
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()

            MessageBox.Show("Cadastro concluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True
        End If

        txtAtividade.Text = String.Empty
        txtConteudo.Text = String.Empty
        txtDataHr.Text = String.Empty
        txtDocente.Text = String.Empty
        txtMencao.Text = String.Empty
        txtFaltas.Text = String.Empty
        txtAlunoAtividade.Text = String.Empty
        txtDisciplinaAtividade.Text = String.Empty



    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarAlunoAtividade.Click

        Dim F As BuscarAlunoAtividade = New BuscarAlunoAtividade


        F.MdiParent = Principal

        F.Show()

        Me.Close()

    End Sub


    Private Sub btnDisciplina_Click(sender As Object, e As EventArgs)
        Dim F As BuscarAtividade = New BuscarAtividade


        F.MdiParent = Principal

        F.Show()
        Me.Close()
    End Sub

    Private Sub Cadastro_Atividade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAtividade.Text = Principal.nomeAtividade
        txtConteudo.Text = Principal.conteudoAtividade
        txtDataHr.Text = Principal.dtHrAtividade
        txtDocente.Text = Principal.DocenteAtividade
        txtMencao.Text = Principal.mencaoAtividade
        txtFaltas.Text = Principal.faltasAtividade
        txtFuncionario.Text = Principal.nomeFuncionario
        txtAlunoAtividade.Text = Principal.nomeAluno
        txtDisciplinaAtividade.Text = Principal.nomeDisciplina



    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim F As BuscarAtividade = New BuscarAtividade


        F.MdiParent = Principal

        F.Show()
        Me.Close()
    End Sub

    Private Sub btnSairCadastroDisciplina_Click(sender As Object, e As EventArgs) Handles btnSairCadastroDisciplina.Click

        Dim sair, cancel As String

        sair = MsgBox("Deseja realmente sair?", vbYesNo + vbExclamation, " Atenção ")

        If sair = vbYes Then
            Close()
        Else
            cancel = True
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtAtividade.Text = String.Empty
        txtConteudo.Text = String.Empty
        txtDataHr.Text = String.Empty
        txtDocente.Text = String.Empty
        txtMencao.Text = String.Empty
        txtFaltas.Text = String.Empty
        txtAlunoAtividade.Text = String.Empty
        txtDisciplinaAtividade.Text = String.Empty
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        txtAtividade.Enabled = False

        Dim alterar, cancel As String

        alterar = MsgBox("Deseja realmente atualizar?", vbYesNo + vbExclamation, " Atenção ")


        If alterar = vbYes Then


            'definindo conexão

         

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

            Dim con As SqlConnection = New SqlConnection(str)


            'dedinindo o comando do sql q será utilizado
            Dim cmd As SqlCommand = New SqlCommand()


            'chamando uma stored procedure
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pu_Atividade"


            'definindo valores (parametros)



            cmd.Parameters.AddWithValue("nomeAtividade", txtAtividade.Text)
            cmd.Parameters.AddWithValue("conteudoAtividade", txtConteudo.Text)
            cmd.Parameters.AddWithValue("dtHrAtividade", txtDataHr.Text)
            cmd.Parameters.AddWithValue("docenteAtividade", txtDocente.Text)
            cmd.Parameters.AddWithValue("mencaoAtividade", txtMencao.Text)
            cmd.Parameters.AddWithValue("faltasAtividade", txtFaltas.Text)
            cmd.Parameters.AddWithValue("idAluno", Principal.idAluno)
            cmd.Parameters.AddWithValue("idDisciplina", Principal.idDisciplina)
            cmd.Parameters.AddWithValue("idFuncionario", Principal.idFuncionario)
            cmd.Parameters.AddWithValue("idAtividade", Principal.idAtividade)






            'definir quem é a conexão
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()
            MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtAtividade.Text = String.Empty
            txtConteudo.Text = String.Empty
            txtDataHr.Text = String.Empty
            txtDocente.Text = String.Empty
            txtMencao.Text = String.Empty
            txtFaltas.Text = String.Empty
            txtAlunoAtividade.Text = String.Empty
            txtDisciplinaAtividade.Text = String.Empty



        Else
            cancel = True

        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        txtAtividade.Enabled = False
        'pedir confirmação de exclusão para o cliente e depois exibir a opção que ele escolher
        Dim excluir, cancel As String

        excluir = MsgBox("Deseja realmente excluir?", vbYesNo + vbExclamation, " Atenção ")


        If excluir = vbYes Then

            

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

            Dim con As SqlConnection = New SqlConnection(str)


            'dedinindo o comando do sql q será utilizado
            Dim cmd As SqlCommand = New SqlCommand()


            'chamando uma stored procedure
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pd_Atividade"


            '
            cmd.Parameters.AddWithValue("idAtividade", Principal.idAtividade)



            'definir quem é a conexão
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()

            MessageBox.Show("Cadastro excluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtAtividade.Text = String.Empty
            txtConteudo.Text = String.Empty
            txtDataHr.Text = String.Empty
            txtDocente.Text = String.Empty
            txtMencao.Text = String.Empty
            txtFaltas.Text = String.Empty
            txtAlunoAtividade.Text = String.Empty
            txtDisciplinaAtividade.Text = String.Empty

        Else
            cancel = True

        End If
    End Sub


    Private Sub txtAlunoAtividade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlunoAtividade.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtAtividade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAtividade.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtConteudo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConteudo.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDataHr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataHr.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDocente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocente.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDisciplinaAtividade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisciplinaAtividade.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtMencao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMencao.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtFaltas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFaltas.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class