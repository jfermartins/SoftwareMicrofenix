Imports System.Data.SqlClient
Public Class AlterarCronograma
   


    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        Dim alterar, cancel As String

        alterar = MsgBox("Deseja realmente atualizar?", vbYesNo + vbExclamation, " Atenção ")


        If alterar = vbYes Then


            'definindo conexão

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"



            'Dim str As String = "Server=SAN0522362W10-1\MSSQLSERVER2;Database=MICROFENIX;User Id=fernanda.martins;Password=vscnqpmo6f@;"

            Dim con As SqlConnection = New SqlConnection(str)


            'dedinindo o comando do sql q será utilizado
            Dim cmd As SqlCommand = New SqlCommand()


            'chamando uma stored procedure
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pu_CronogramaSala"


            'definindo valores (parametros)



            cmd.Parameters.AddWithValue("dtHrSala", mskDataHoraCronograma.Text)
            cmd.Parameters.AddWithValue("nomeDocenteSala", txtDocenteCronograma.Text)
            cmd.Parameters.AddWithValue("disciplinaSala", txtDisciplinaCronograma.Text)
            cmd.Parameters.AddWithValue("turmaSala", txtTurmaCronograma.Text)
            cmd.Parameters.AddWithValue("dadosSala", txtSalaCronograma.Text)
            cmd.Parameters.AddWithValue("idDisciplina", Principal.idDisciplina)
            cmd.Parameters.AddWithValue("idFuncionario", Principal.idFuncionario)
            cmd.Parameters.AddWithValue("idCronograma", Principal.idCronograma)






            'definir quem é a conexão
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()
            MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            mskDataHoraCronograma.Text = String.Empty
            txtDocenteCronograma.Text = String.Empty
            txtDisciplinaCronograma.Text = String.Empty
            txtTurmaCronograma.Text = String.Empty
            txtSalaCronograma.Text = String.Empty
            txtSalaCronograma.Text = String.Empty
            txtIdDisciplina.Text = String.Empty


        Else
            cancel = True

        End If
    End Sub

    Private Sub AlterarCronograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisciplinaCronograma.Text = Principal.nomeDisciplina
        txtDocenteCronograma.Text = Principal.nomeDocenteSala
        txtTurmaCronograma.Text = Principal.TurmaSala
        mskDataHoraCronograma.Text = Principal.dtHrSala
        txtSalaCronograma.Text = Principal.dadosSala
        txtIdDisciplina.Text = Principal.idDisciplina
        txtFuncionario.Text = Principal.nomeFuncionario
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim F As BuscaSala = New BuscaSala


        F.MdiParent = Principal

        F.Show()
        Me.Close()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        mskDataHoraCronograma.Text = String.Empty
        txtDocenteCronograma.Text = String.Empty
        txtDisciplinaCronograma.Text = String.Empty
        txtTurmaCronograma.Text = String.Empty
        txtSalaCronograma.Text = String.Empty
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

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim excluir, cancel As String

        excluir = MsgBox("Deseja realmente excluir?", vbYesNo + vbExclamation, " Atenção ")


        If excluir = vbYes Then

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            'Dim str As String = "Server=SAN0522362W10-1\MSSQLSERVER2;Database=MICROFENIX;User Id=fernanda.martins;Password=vscnqpmo6f@;"

            Dim con As SqlConnection = New SqlConnection(str)


            'dedinindo o comando do sql q será utilizado
            Dim cmd As SqlCommand = New SqlCommand()


            'chamando uma stored procedure
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pd_Cronograma"



            cmd.Parameters.AddWithValue("idCronograma", Principal.idCronograma)



            'definir quem é a conexão
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()

            MessageBox.Show("Cadastro excluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            mskDataHoraCronograma.Text = String.Empty
            txtDocenteCronograma.Text = String.Empty
            txtDisciplinaCronograma.Text = String.Empty
            txtTurmaCronograma.Text = String.Empty
            txtSalaCronograma.Text = String.Empty
            txtIdDisciplina.Text = String.Empty

        Else
            cancel = True

        End If
    End Sub

    Private Sub txtSalaCronograma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalaCronograma.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtIdDisciplina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdDisciplina.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDisciplinaCronograma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisciplinaCronograma.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDocenteCronograma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocenteCronograma.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtTurmaCronograma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTurmaCronograma.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub mskDataHoraCronograma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskDataHoraCronograma.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        txtData.Text = Now

        txtData.Show()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub


End Class