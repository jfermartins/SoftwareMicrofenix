
Imports System.Data.SqlClient
Public Class cronogramaSala
    


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
            cmd.CommandText = "pi_CronogramaSala"


            'definindo valores (parametros)


            'cmd.Parameters.AddWithValue("nomeAtividade", txtAtividade.Text)
            cmd.Parameters.AddWithValue("dtHrSala", mskDataHoraCronograma.Text)
            cmd.Parameters.AddWithValue("nomeDocenteSala", txtDocenteCronograma.Text)
            cmd.Parameters.AddWithValue("disciplinaSala", txtDisciplinaCronograma.Text)
            cmd.Parameters.AddWithValue("turmaSala", txtTurmaCronograma.Text)
            cmd.Parameters.AddWithValue("dadosSala", txtSalaCronograma.Text)
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
        mskDataHoraCronograma.Text = String.Empty
        txtDocenteCronograma.Text = String.Empty
        txtDisciplinaCronograma.Text = String.Empty
        txtTurmaCronograma.Text = String.Empty
        txtSalaCronograma.Text = String.Empty
        txtIdDisciplina.Text = String.Empty

        
    End Sub

    Private Sub btnDisciplina_Click(sender As Object, e As EventArgs) Handles btnDisciplina.Click
        Dim f As CronogramaBuscaDisciplina = New CronogramaBuscaDisciplina
        f.MdiParent = Principal
        f.Show()
        Me.Close()
    End Sub

    Private Sub cronogramaSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisciplinaCronograma.Text = Principal.nomeDisciplina

        txtIdDisciplina.Text = Principal.idDisciplina
        txtFuncionario.Text = Principal.nomeFuncionario
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        mskDataHoraCronograma.Text = String.Empty
        txtDocenteCronograma.Text = String.Empty
        txtDisciplinaCronograma.Text = String.Empty
        txtTurmaCronograma.Text = String.Empty
        txtSalaCronograma.Text = String.Empty
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim F As BuscaSala = New BuscaSala


        F.MdiParent = Principal

        F.Show()
        Me.Close()
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click


        Dim f As AlterarCronograma = New AlterarCronograma
        f.Show()
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

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click


        Dim f As AlterarCronograma = New AlterarCronograma
        f.Show()
        Me.Close()

    End Sub

    Private Sub txtDisciplinaCronograma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisciplinaCronograma.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class