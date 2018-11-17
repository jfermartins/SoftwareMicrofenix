Imports System.Data.SqlClient

Public Class CadastrarDisciplina

    Private Sub btnCadastroDisciplina_Click(sender As Object, e As EventArgs) Handles btnCadastroDisciplina.Click

        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then


       
            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

            Dim con As SqlConnection = New SqlConnection(str)


            'dedinindo o comando do sql q será utilizado

            Dim cmd As SqlCommand = New SqlCommand()



            'chamando uma stored procedure
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pi_Disciplina"


            'definindo valores (parametros)
            cmd.Parameters.AddWithValue("nomeDisciplina", txtDisciplina.Text)
            cmd.Parameters.AddWithValue("docenteDisciplina", txtDocente.Text)
            cmd.Parameters.AddWithValue("cargaHorariaDisciplina", txtCargaHr.Text)
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


        txtDisciplina.Text = ""
        txtDocente.Text = ""
        txtCargaHr.Text = ""

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Dim sair, cancel As String

        sair = MsgBox("Deseja realmente sair?", vbYesNo + vbExclamation, " Atenção ")

        If sair = vbYes Then
            Close()
        Else
            cancel = True
        End If
    End Sub

    Private Sub CadastrarDisciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomeFuncionario.Text = Principal.nomeFuncionario
    End Sub

    Private Sub txtDisciplina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisciplina.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDocente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocente.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtCargaHr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCargaHr.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtNomeFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub

   
End Class