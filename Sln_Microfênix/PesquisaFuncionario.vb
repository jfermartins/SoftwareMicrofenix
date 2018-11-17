Imports System.Data.SqlClient
Public Class PesquisaFuncionario

    Private Sub Pesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCadastrarFunc_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles btnBuscarUsuario.Click

        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_Funcionario2"

        cmd.Parameters.AddWithValue("usuarioFuncionario", txtUsuarioFunc.Text)
        

        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()


        dr = cmd.ExecuteReader


        If dr.Read() Then

            txtNomeFuncionario.Text = dr("nomeFuncionario")
            txtUsuarioFunc.Text = dr("usuarioFuncionario")
            txtSenhaFuncionario.Text = dr("senhaFuncionario")
            txtCPFFuncionario.Text = dr("cpfFuncionario")

        Else

            MsgBox("Usuário não encontrado!")

        End If

        con.Close()



    End Sub

    Private Sub btnLimparUsuario_Click(sender As Object, e As EventArgs) Handles btnLimparUsuario.Click

        txtUsuarioFunc.Text = String.Empty
        txtNomeFuncionario.Text = String.Empty
        txtUsuarioFunc.Text = String.Empty
        txtSenhaFuncionario.Text = String.Empty
        txtCPFFuncionario.Text = String.Empty

    End Sub

    Private Sub btnExcluirFuncionario_Click(sender As Object, e As EventArgs) Handles btnExcluirFuncionario.Click
        Dim excluir, cancel As String

        excluir = MsgBox("Deseja realmente excluir?", vbYesNo + vbExclamation, " Atenção ")


        If excluir = vbYes Then

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)


            Dim cmd As SqlCommand = New SqlCommand()

            cmd.CommandType = CommandType.StoredProcedure

            cmd.CommandText = "pd_Funcionario2"


            cmd.Parameters.AddWithValue("usuarioFuncionario", txtUsuarioFunc.Text)

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Cadastro excluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True

        End If

    End Sub

    

    Private Sub txtUsuarioFunc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuarioFunc.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtNomeFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtSenhaFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenhaFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtCPFFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPFFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class