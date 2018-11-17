Imports System.Data.SqlClient
Public Class AlterarFuncionario

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        
        Dim con As SqlConnection = New SqlConnection(str)
        Dim cmd As SqlCommand = New SqlCommand()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_buscarFuncionario"

        cmd.Parameters.AddWithValue("cpfFuncionario", txtCPFFuncionario.Text)

        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()

        dr = cmd.ExecuteReader

        If dr.Read() Then

            txtNomeFuncionario.Text = dr("nomeFuncionario")
            txtRGFuncionario.Text = dr("rgFuncionario")
            txtCPFFuncionario.Text = dr("cpfFuncionario")
            txtEnderecoFuncionario.Text = dr("endFuncionario")
            txtDataDeNascimentoFuncionario.Text = dr("dtNascFuncionario")
            txtTelefoneFuncionario.Text = dr("telFuncionario")
            txtWhatsAppFuncionario.Text = dr("WhatsFuncionario")
            txtEmailFuncionario.Text = dr("emailFuncionario")
            txtEscolaridadeFuncionario.Text = dr("escolaridadeFuncionario")
            txtDataDeEmissaoFuncionario.Text = dr("dtemissao")
            txtDataDemissaoFuncionario.Text = dr("dtDemissao")
            txtCargoFuncionario.Text = dr("cargoFuncionario")
            txtSexoFuncionario.Text = dr("sexoFuncionario")
            txtEstadoFuncionario.Text = dr("estCivilFuncionario")
            txtDtPagamento.Text = dr("dtPgtoFuncionario")
            txtValorSalario.Text = dr("valorSalarioFuncionario")
            txtUsuarioFuncionario.Text = dr("usuarioFuncionario")
            txtSenhaFuncionario.Text = dr("senhaFuncionario")
        Else

            MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

           
        End If

        con.Close()

    End Sub


    Private Sub btnAlterarFuncionario_Click(sender As Object, e As EventArgs) Handles btnAlterarFuncionario.Click
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
            cmd.CommandText = "pu_Funcionario"


            'definindo valores (parametros)



            cmd.Parameters.AddWithValue("nomeFuncionario", txtNomeFuncionario.Text)
            cmd.Parameters.AddWithValue("rgFuncionario", txtRGFuncionario.Text)
            cmd.Parameters.AddWithValue("cpfFuncionario", CDbl(txtCPFFuncionario.Text))
            cmd.Parameters.AddWithValue("endFuncionario", txtEnderecoFuncionario.Text)
            cmd.Parameters.AddWithValue("dtNascFuncionario", CDate(txtDataDeNascimentoFuncionario.Text))
            cmd.Parameters.AddWithValue("telFuncionario", CDbl(txtTelefoneFuncionario.Text))
            cmd.Parameters.AddWithValue("WhatsFuncionario", CDbl(txtWhatsAppFuncionario.Text))
            cmd.Parameters.AddWithValue("emailFuncionario", txtEmailFuncionario.Text)
            cmd.Parameters.AddWithValue("escolaridadeFuncionario", txtEscolaridadeFuncionario.Text)
            cmd.Parameters.AddWithValue("dtemissao", CDate(txtDataDeEmissaoFuncionario.Text))
            cmd.Parameters.AddWithValue("dtDemissao", CDate(txtDataDemissaoFuncionario.Text))
            cmd.Parameters.AddWithValue("cargoFuncionario", txtCargoFuncionario.Text)
            cmd.Parameters.AddWithValue("sexoFuncionario", txtSexoFuncionario.Text)
            cmd.Parameters.AddWithValue("estCivilFuncionario", txtEstadoFuncionario.Text)
            cmd.Parameters.AddWithValue("dtPgtoFuncionario", CDate(txtDtPagamento.Text))
            cmd.Parameters.AddWithValue("valorSalarioFuncionario", CDec(txtValorSalario.Text))
            cmd.Parameters.AddWithValue("usuarioFuncionario", txtUsuarioFuncionario.Text)
            cmd.Parameters.AddWithValue("senhaFuncionario", txtSenhaFuncionario.Text)





            'definir quem é a conexão cmd.Parameters.AddWithValue("
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()
            MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNomeFuncionario.Text = String.Empty
            txtRGFuncionario.Text = String.Empty
            txtCPFFuncionario.Text = String.Empty
            txtEnderecoFuncionario.Text = String.Empty
            txtTelefoneFuncionario.Text = String.Empty
            txtDataDeNascimentoFuncionario.Text = String.Empty
            txtWhatsAppFuncionario.Text = String.Empty
            txtEmailFuncionario.Text = String.Empty
            txtEscolaridadeFuncionario.Text = String.Empty
            txtDataDeEmissaoFuncionario.Text = String.Empty
            txtDataDemissaoFuncionario.Text = String.Empty
            txtCargoFuncionario.Text = String.Empty
            txtSexoFuncionario.Text = String.Empty
            txtEstadoFuncionario.Text = String.Empty
            txtDtPagamento.Text = String.Empty
            txtValorSalario.Text = String.Empty
            txtUsuarioFuncionario.Text = String.Empty
            txtSenhaFuncionario.Text = String.Empty


        Else
                cancel = True

        End If
    End Sub

    Private Sub txtCPFFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPFFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
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