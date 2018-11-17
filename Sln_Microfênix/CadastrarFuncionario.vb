Imports System.Data.SqlClient
Public Class CadastrarFuncionario

   




    Private Sub btnCadastrarFuncionario_Click(sender As Object, e As EventArgs) Handles btnCadastrarFuncionario.Click

        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then



            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"



            Dim con As SqlConnection = New SqlConnection(str)
            Dim cmd As SqlCommand = New SqlCommand

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pi_Funcionario2"

            cmd.Parameters.AddWithValue("nomeFuncionario", txtNomeFuncionario.Text)
            cmd.Parameters.AddWithValue("rgFuncionario", txtRGFuncionario.Text)
            cmd.Parameters.AddWithValue("cpfFuncionario", txtCPFFuncionario.Text)
            cmd.Parameters.AddWithValue("dtNascFuncionario", txtDataDeNascimentoFuncionario.Text)
            cmd.Parameters.AddWithValue("endFuncionario", txtEnderecoFuncionario.Text)
            cmd.Parameters.AddWithValue("telFuncionario", txtTelefoneFuncionario.Text)
            cmd.Parameters.AddWithValue("whatsFuncionario", txtWhatsAppFuncionario.Text)
            cmd.Parameters.AddWithValue("emailFuncionario", txtEmailFuncionario.Text)
            cmd.Parameters.AddWithValue("escolaridadeFuncionario", txtEscolaridadeFuncionario.Text)
            cmd.Parameters.AddWithValue("cargoFuncionario", txtCargoFuncionario.Text)
            cmd.Parameters.AddWithValue("dtemissao", txtDataDeEmissaoFuncionario.Text)

            If txtDataDemissaoFuncionario.TextLength > 0 Then
                cmd.Parameters.AddWithValue("dtDemissao", CDate(txtDataDemissaoFuncionario.Text))
            Else
                cmd.Parameters.AddWithValue("dtDemissao", 0)
            End If

            cmd.Parameters.AddWithValue("sexoFuncionario", txtSexoFuncionario.Text)
            cmd.Parameters.AddWithValue("estcivilFuncionario", txtEstadoFuncionario.Text)
            cmd.Parameters.AddWithValue("dtPgtoFuncionario", txtDtPagamento.Text)
            cmd.Parameters.AddWithValue("valorSalarioFuncionario", txtValorSalario.Text)
            cmd.Parameters.AddWithValue("usuarioFuncionario", txtUsuarioFuncionario.Text)
            cmd.Parameters.AddWithValue("senhaFuncionario", txtSenhaFuncionario.Text)

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("Cadastro concluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True
        End If

        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Or TypeOf a Is ComboBox Then
                a.Text = ""
            End If

        Next




    End Sub

    Private Sub txtNomeFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtRGFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRGFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtCPFFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPFFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtEnderecoFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnderecoFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDataDeNascimentoFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataDeNascimentoFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtTelefoneFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefoneFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtWhatsAppFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWhatsAppFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtEmailFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmailFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtEscolaridadeFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEscolaridadeFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDataDeEmissaoFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataDeEmissaoFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDataDemissaoFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataDemissaoFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtCargoFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCargoFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtSexoFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSexoFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtEstadoFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstadoFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDtPagamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDtPagamento.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtValorSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorSalario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtUsuarioFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuarioFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtSenhaFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenhaFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class