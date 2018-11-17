Imports System.Data.SqlClient
Public Class Cadastro_Ocorrencia_Geral


    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click
        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pi_OcorrenciaGeral"

            cmd.Parameters.AddWithValue("codOcorrencia", txtCodOcorrencia.Text)
            cmd.Parameters.AddWithValue("dtOcorrencia", txtDtOc.Text)
            cmd.Parameters.AddWithValue("hrOcorrencia", txtH.Text)
            cmd.Parameters.AddWithValue("dtAtendOcorrencia", TxtDtaA.Text)
            cmd.Parameters.AddWithValue("hrAtendOcorrencia", txtHorAt.Text)
            cmd.Parameters.AddWithValue("descrOcorrencia", txtDesc.Text)
            cmd.Parameters.AddWithValue("nomeTecOcorrencia", txtNomeT.Text)
            cmd.Parameters.AddWithValue("regTecOcorrencia", txtRg.Text)
            cmd.Parameters.AddWithValue("setorTecOcorrencia", txtSetorT.Text)
            cmd.Parameters.AddWithValue("descrEquipOcorrencia", txtDE.Text)
            cmd.Parameters.AddWithValue("qtdEquipOcorrencia", txtQtdEqp.Text)
            cmd.Parameters.AddWithValue("nomeEnvOcorrencia", txtEnvO.Text)
            cmd.Parameters.AddWithValue("medidaOcorrencia", txtMedO.Text)
            cmd.Parameters.AddWithValue("solucaoOcorrencia", txtSol.Text)


            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cadastro concluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True
        End If

    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_OcorrenciaGeral"

        cmd.Parameters.AddWithValue("codOcorrencia", txtCodOcorrencia.Text)


        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()


        dr = cmd.ExecuteReader


        If dr.Read() Then

            txtCodOcorrencia.Text = dr("codOcorrencia")
            txtDtOc.Text = dr("dtOcorrencia")
            txtH.Text = dr("hrOcorrencia")
            txtDesc.Text = dr("descrOcorrencia")
            txtNomeT.Text = dr("nomeTecOcorrencia")
            txtRg.Text = dr("regTecOcorrencia")
            txtSetorT.Text = dr("setorTecOcorrencia")
            txtDE.Text = dr("descrEquipOcorrencia")
            txtQtdEqp.Text = dr("qtdEquipOcorrencia")
            txtEnvO.Text = dr("nomeEnvOcorrencia")
            txtMedO.Text = dr("medidaOcorrencia")
            txtSol.Text = dr("solucaoOcorrencia")

        Else

            MsgBox("Usuário não encontrado!")

        End If

        con.Close()



    End Sub

    Private Sub btnEx_Click(sender As Object, e As EventArgs) Handles btnEx.Click

        Dim excluir, cancel As String

        excluir = MsgBox("Deseja realmente excluir?", vbYesNo + vbExclamation, " Atenção ")


        If excluir = vbYes Then


            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)


            Dim cmd As SqlCommand = New SqlCommand()

            cmd.CommandType = CommandType.StoredProcedure

            cmd.CommandText = "pd_OcorrenciaGeral"


            cmd.Parameters.AddWithValue("codOcorrencia", txtCodOcorrencia.Text)

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
        txtCodOcorrencia.Enabled = False



            Dim alterar, cancel As String

            alterar = MsgBox("Deseja realmente atualizar?", vbYesNo + vbExclamation, " Atenção ")


            If alterar = vbYes Then


                'definindo conexão

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"



                'Dim str As String = "Server=SAN0522362W10-1\BD_BLUE;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

                Dim con As SqlConnection = New SqlConnection(str)


                'dedinindo o comando do sql q será utilizado
                Dim cmd As SqlCommand = New SqlCommand()


                'chamando uma stored procedure
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "pu_OcorrenciaGeral"

                'definindo valores (parametros)

                cmd.Parameters.AddWithValue("codOcorrencia", txtCodOcorrencia.Text)
                cmd.Parameters.AddWithValue("dtOcorrencia", txtDtOc.Text)
                cmd.Parameters.AddWithValue("hrOcorrencia", txtH.Text)
                cmd.Parameters.AddWithValue("dtAtendOcorrencia", TxtDtaA.Text)
                cmd.Parameters.AddWithValue("hrAtendOcorrencia", txtHorAt.Text)
                cmd.Parameters.AddWithValue("descrOcorrencia", txtDesc.Text)
                cmd.Parameters.AddWithValue("nomeTecOcorrencia", txtNomeT.Text)
                cmd.Parameters.AddWithValue("regTecOcorrencia", txtRg.Text)
                cmd.Parameters.AddWithValue("setorTecOcorrencia", txtSetorT.Text)
                cmd.Parameters.AddWithValue("descrEquipOcorrencia", txtDE.Text)
                cmd.Parameters.AddWithValue("qtdEquipOcorrencia", txtQtdEqp.Text)
                cmd.Parameters.AddWithValue("nomeEnvOcorrencia", txtEnvO.Text)
                cmd.Parameters.AddWithValue("medidaOcorrencia", txtMedO.Text)
                cmd.Parameters.AddWithValue("solucaoOcorrencia", txtSol.Text)


                'definir quem é a conexão
                cmd.Connection = con


                'abrir a conexão
                con.Open()

                'executar o comando sql
                cmd.ExecuteNonQuery()


                'fechar a conexão
                con.Close()
               
                MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                cancel = True

            End If
            txtCodOcorrencia.Text = ""
            txtDtOc.Text = ""
            txtH.Text = ""
            TxtDtaA.Text = ""
            txtHorAt.Text = ""
            txtDesc.Text = ""
            txtNomeT.Text = ""
            txtRg.Text = ""
            txtSetorT.Text = ""
            txtDE.Text = ""
            txtQtdEqp.Text = ""
            txtEnvO.Text = ""
            txtMedO.Text = ""
            txtSol.Text = ""



      
    End Sub



    Private Sub txtCodOcorrencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodOcorrencia.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDtOc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDtOc.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtH.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesc.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtNomeT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeT.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtRg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRg.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtSetorT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSetorT.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDE.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtQtdEqp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdEqp.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtEnvO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnvO.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtRgE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRgE.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtMedO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMedO.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtSol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSol.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TxtDtaA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDtaA.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtHorAt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHorAt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class