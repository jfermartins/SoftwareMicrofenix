Imports System.Data.SqlClient

Public Class Ocorrencia


    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click

        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pi_OcorrenciaLaboratorio"

            cmd.Parameters.AddWithValue("natOcorLaboratorio ", txtNocorrencia.Text)
            cmd.Parameters.AddWithValue("dtOcorLaboratorio", txtdtocorrencia.Text)
            cmd.Parameters.AddWithValue("hrOcorLaboratorio", txthOcorrencia.Text)
            cmd.Parameters.AddWithValue("provOcrLaboratorio", txtProv.Text)
            cmd.Parameters.AddWithValue("solucaoOcorLaboratorio", txtSol.Text)


            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cadastro concluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True
        End If


    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click


        Dim excluir, cancel As String

        excluir = MsgBox("Deseja realmente excluir?", vbYesNo + vbExclamation, " Atenção ")


        If excluir = vbYes Then



            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)


        Dim cmd As SqlCommand = New SqlCommand()

        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = "pd_OcorrenciaLaboratorio"


        cmd.Parameters.AddWithValue("natOcorLaboratorio", txtNocorrencia.Text)

        cmd.Connection = con

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

            MessageBox.Show("Cadastro excluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True

        End If
    End Sub

    Private Sub btnAlt_Click(sender As Object, e As EventArgs) Handles btnAlt.Click
        txtNocorrencia.Enabled = False

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
            cmd.CommandText = "pu_Ocorrencia"

            'definindo valores (parametros)

            cmd.Parameters.AddWithValue("naturezaOcorrencia", txtNocorrencia.Text)
            cmd.Parameters.AddWithValue("dataOcorrencia", txtdtocorrencia.Text)
            cmd.Parameters.AddWithValue("horaOcorrencia", txthOcorrencia.Text)
            cmd.Parameters.AddWithValue("providenciasOcorrencia", txtProv.Text)


            'definir quem é a conexão
            cmd.Connection = con


            'abrir a conexão
            con.Open()

            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()
            MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtNocorrencia.Text = ""
            txtdtocorrencia.Text = ""
            txthOcorrencia.Text = ""
            txtProv.Text = ""



        Else
            cancel = True

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_OcorrenciaLaboratorio"

        cmd.Parameters.AddWithValue("natOcorLaboratorio", txtNocorrencia.Text)


        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()


        dr = cmd.ExecuteReader


        If dr.Read() Then

            txtNocorrencia.Text = dr("natOcorLaboratorio")
            txtdtocorrencia.Text = dr("dtOcorLaboratorio")
            txthOcorrencia.Text = dr("hrOcorLaboratorio")
            txtProv.Text = dr("provOcrLaboratorio")
            txtSol.Text = dr("solucaoOcorLaboratorio")


        Else

            MsgBox("Usuário não encontrado!")

        End If

        con.Close()
    End Sub

   

    Private Sub txtNocorrencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNocorrencia.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtdtocorrencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdtocorrencia.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txthOcorrencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthOcorrencia.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProv.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtSol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSol.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub

End Class