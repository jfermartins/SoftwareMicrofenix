Imports System.Data.SqlClient
Public Class Atualizacao_e_Exclusao_Disciplina
   



    Private Sub btnCadastroDisciplina_Click(sender As Object, e As EventArgs)

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

    Private Sub Disciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisciplina.Enabled = False

        txtDisciplina.Text = Principal.nomeDisciplina
        txtDocente.Text = Principal.docenteDisciplina
        txtCargaHr.Text = Principal.cargaHorariaDisciplina

        txtNomeFuncionario.Text = Principal.nomeFuncionario


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


        Dim F As BuscarDisciplina = New BuscarDisciplina


        F.MdiParent = Principal

        F.Show()

        Me.Close()


    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        txtDisciplina.Text = ""
        txtDocente.Text = ""
        txtCargaHr.Text = ""


    End Sub

    Private Sub btnSairCadastroDisciplina_Click(sender As Object, e As EventArgs) Handles btnSairCadastroDisciplina.Click


        Dim sair, cancel As String

        sair = MsgBox("Deseja realmente sair?", vbYesNo + vbExclamation, " Atenção ")

        If sair = vbYes Then
            txtDisciplina.Text = ""
            txtDocente.Text = ""
            txtCargaHr.Text = ""
            Close()
        Else
            cancel = True
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        txtDisciplina.Enabled = False

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
            cmd.CommandText = "pu_Disciplina"


            'definindo valores (parametros)



            cmd.Parameters.AddWithValue("docenteDisciplina", txtDocente.Text)
            cmd.Parameters.AddWithValue("cargaHorariaDisciplina", txtCargaHr.Text)
            cmd.Parameters.AddWithValue("idFuncionario", Principal.idFuncionario)
            cmd.Parameters.AddWithValue("idDisciplina", Principal.idDisciplina)





            'definir quem é a conexão
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()
            MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtDisciplina.Text = ""
            txtDocente.Text = ""
            txtCargaHr.Text = ""




        Else
            cancel = True

        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        txtDisciplina.Enabled = False
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
            cmd.CommandText = "pd_Disciplina"



            cmd.Parameters.AddWithValue("idDisciplina", Principal.idDisciplina)



            'definir quem é a conexão
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()

            MessageBox.Show("Cadastro excluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtDisciplina.Text = String.Empty

            txtDocente.Text = String.Empty
            txtCargaHr.Text = String.Empty


        Else
            cancel = True

        End If
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
