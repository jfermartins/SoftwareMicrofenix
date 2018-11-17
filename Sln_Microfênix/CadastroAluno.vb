Imports System.Data.SqlClient

Public Class CadastroAluno

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCadastroAluno.Click
        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then


            If txtNomeAluno.Text = "" Or txtRgAluno.Text = "" Or mskCpfAluno.Text = "" Or mskDnAluno.Text = "" Or txtEnderecoAluno.Text = "" Or mskTelefoneAluno.Text = "" Then

                MessageBox.Show("Preenchimento obrigatório dos campos: nome, RG, CPF, data de nascimento, endereço e telefone residencial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


                Dim con As SqlConnection = New SqlConnection(str)

                Dim cmd As SqlCommand = New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure


                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "pi_CadastroAluno"

                cmd.Parameters.AddWithValue("nomeAluno", txtNomeAluno.Text)
                cmd.Parameters.AddWithValue("rgAluno", txtRgAluno.Text)
                cmd.Parameters.AddWithValue("cpfAluno", Replace(Replace(mskCpfAluno.Text, ",", ""), "-", ""))
                cmd.Parameters.AddWithValue("dnAluno", mskDnAluno.Text)
                cmd.Parameters.AddWithValue("estadoCivilAluno", cmbEcAluno.Text)
                cmd.Parameters.AddWithValue("generoAluno", cmbGeneroAluno.Text)
                cmd.Parameters.AddWithValue("enderecoAluno", txtEnderecoAluno.Text)
                cmd.Parameters.AddWithValue("telResAluno", Replace(Replace(Replace(Replace(mskTelefoneAluno.Text, "(", ""), ")", ""), "-", ""), " ", ""))
                Dim celular As String = Replace(Replace(Replace(Replace(mskCelularAluno.Text, "(", ""), ")", ""), "-", ""), " ", "")

                If celular.Length > 0 Then
                    cmd.Parameters.AddWithValue("celAluno", celular)
                End If

                Dim whats As String = Replace(Replace(Replace(Replace(mskCelularAluno.Text, "(", ""), ")", ""), "-", ""), " ", "")

                If whats.Length > 0 Then
                    cmd.Parameters.AddWithValue("whatsAluno", whats)
                End If

                cmd.Parameters.AddWithValue("emailAluno", txtEmailAluno.Text)
                cmd.Parameters.AddWithValue("obsAluno", txtObsAluno.Text)

                cmd.Connection = con
                con.Open()

                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Cadastro concluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
            End If

        Else
            cancel = True
        End If
        txtNomeAluno.Text = String.Empty
        txtRgAluno.Text = String.Empty
        mskCpfAluno.Text = String.Empty
        mskDnAluno.Text = ""
        cmbEcAluno.Text = ""
        cmbGeneroAluno.Text = ""
        txtEnderecoAluno.Text = String.Empty
        mskTelefoneAluno.Text = String.Empty
        txtEmailAluno.Text = ""
        txtObsAluno.Text = ""
        mskCelularAluno.Text = ""
        mskWhatsAluno.Text = ""



    End Sub

   

    Private Sub btnBuscaMatricula_Click(sender As Object, e As EventArgs) Handles btnBuscaCadastro.Click

        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_CadastroAluno"

        cmd.Parameters.AddWithValue("cpfAluno", txtBuscaCadastro.Text)

        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()

        dr = cmd.ExecuteReader

        If dr.Read() Then

            txtNomeAluno.Text = dr("nomeAluno")
            txtRgAluno.Text = dr("rgAluno")
            mskCpfAluno.Text = dr("cpfAluno")
            mskDnAluno.Text = dr("dnAluno")
            cmbEcAluno.Text = dr("estadoCivilAluno")
            cmbGeneroAluno.Text = dr("generoAluno")
            txtEnderecoAluno.Text = dr("enderecoAluno")
            mskTelefoneAluno.Text = dr("telResAluno")

            If Not IsDBNull(dr("celAluno")) Then
                mskCelularAluno.Text = dr("celAluno")
            End If

            If Not IsDBNull(dr("whatsAluno")) Then
                mskWhatsAluno.Text = dr("whatsAluno")
            End If

            txtEmailAluno.Text = dr("emailAluno")
            txtObsAluno.Text = dr("obsAluno")

            btnCadastroAluno.Enabled = False
            btnExcluiCadastro.Visible = True
            btnAlteraCadastro.Enabled = True
            btnBuscaCadastro.Enabled = False
            btnLimpaCadastro.Enabled = True

        Else
            MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        con.Close()

    End Sub

    Private Sub btnLimpaCadastro_Click(sender As Object, e As EventArgs) Handles btnLimpaCadastro.Click

        txtNomeAluno.Text = String.Empty
        txtRgAluno.Text = String.Empty
        mskCpfAluno.Text = ""
        mskDnAluno.Text = ""
        cmbEcAluno.Text = String.Empty
        cmbGeneroAluno.Text = String.Empty
        txtEnderecoAluno.Text = String.Empty
        mskTelefoneAluno.Text = String.Empty
        mskCelularAluno.Text = ""
        mskWhatsAluno.Text = ""
        txtEmailAluno.Text = String.Empty
        txtObsAluno.Text = String.Empty
        txtBuscaCadastro.Text = String.Empty


        btnCadastroAluno.Visible = True
        btnExcluiCadastro.Visible = False
        btnAlteraCadastro.Visible = False
        btnBuscaCadastro.Enabled = True
        btnLimpaCadastro.Enabled = True

    End Sub

    Private Sub btnAlteraCadastro_Click(sender As Object, e As EventArgs) Handles btnAlteraCadastro.Click
       

            If txtNomeAluno.Text = "" Or txtRgAluno.Text = "" Or mskCpfAluno.Text = "" Or mskDnAluno.Text = "" Or txtEnderecoAluno.Text = "" Or mskTelefoneAluno.Text = "" Then

                MessageBox.Show("Preenchimento obrigatório dos campos: nome, RG, CPF, data de nascimento, endereço e telefone residencial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
            Dim alterar, cancel As String

            alterar = MsgBox("Deseja realmente atualizar?", vbYesNo + vbExclamation, " Atenção ")


            If alterar = vbYes Then
                Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


                Dim con As SqlConnection = New SqlConnection(str)
                Dim cmd As SqlCommand = New SqlCommand()

                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "pu_CadastroAluno"

                cmd.Parameters.AddWithValue("nomeAluno", txtNomeAluno.Text)
                cmd.Parameters.AddWithValue("rgAluno", txtRgAluno.Text)
                cmd.Parameters.AddWithValue("cpfAluno", Replace(Replace(mskCpfAluno.Text, ",", ""), "-", ""))
                cmd.Parameters.AddWithValue("dnAluno", mskDnAluno.Text)
                cmd.Parameters.AddWithValue("estadoCivilAluno", cmbEcAluno.Text)
                cmd.Parameters.AddWithValue("generoAluno", cmbGeneroAluno.Text)
                cmd.Parameters.AddWithValue("enderecoAluno", txtEnderecoAluno.Text)
                cmd.Parameters.AddWithValue("telResAluno", Replace(Replace(Replace(Replace(mskTelefoneAluno.Text, "(", ""), ")", ""), "-", ""), " ", ""))
                Dim celular As String = Replace(Replace(Replace(Replace(mskCelularAluno.Text, "(", ""), ")", ""), "-", ""), " ", "")

                If celular.Length > 0 Then
                    cmd.Parameters.AddWithValue("celAluno", celular)
                End If

                Dim whats As String = Replace(Replace(Replace(Replace(mskCelularAluno.Text, "(", ""), ")", ""), "-", ""), " ", "")

                If whats.Length > 0 Then
                    cmd.Parameters.AddWithValue("whatsAluno", whats)
                End If

                cmd.Parameters.AddWithValue("emailAluno", txtEmailAluno.Text)
                cmd.Parameters.AddWithValue("obsAluno", txtObsAluno.Text)

                cmd.Connection = con
                con.Open()

                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Cadastro alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                cancel = True

            End If


        End If

        txtNomeAluno.Text = String.Empty
        txtRgAluno.Text = String.Empty
        mskCpfAluno.Text = String.Empty
        mskDnAluno.Text = ""
        cmbEcAluno.Text = ""
        cmbGeneroAluno.Text = ""
        txtEnderecoAluno.Text = String.Empty
        mskTelefoneAluno.Text = String.Empty
        txtEmailAluno.Text = ""
        txtObsAluno.Text = ""
        mskCelularAluno.Text = ""
        mskWhatsAluno.Text = ""
        txtBuscaCadastro.Text = String.Empty

        btnCadastroAluno.Visible = True
        btnCadastroAluno.Enabled = True
        btnExcluiCadastro.Visible = False
        btnAlteraCadastro.Visible = False
        btnBuscaCadastro.Enabled = True
        btnLimpaCadastro.Enabled = True


    End Sub

    Private Sub btnExcluiCadastro_Click(sender As Object, e As EventArgs) Handles btnExcluiCadastro.Click
        Dim excluir, cancel As String

        excluir = MsgBox("Deseja realmente excluir?", vbYesNo + vbExclamation, " Atenção ")


        If excluir = vbYes Then

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)
            Dim cmd As SqlCommand = New SqlCommand()

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pd_CadastroAluno"

            cmd.Parameters.AddWithValue("cpfAluno", txtBuscaCadastro.Text)

            cmd.Connection = con
            con.Open()

            cmd.ExecuteNonQuery()

            con.Close()

            MessageBox.Show("Cadastro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True

        End If

        txtNomeAluno.Text = String.Empty
        txtRgAluno.Text = String.Empty
        mskCpfAluno.Text = String.Empty
        mskDnAluno.Text = ""
        cmbEcAluno.Text = ""
        cmbGeneroAluno.Text = ""
        txtEnderecoAluno.Text = String.Empty
        mskTelefoneAluno.Text = String.Empty
        txtEmailAluno.Text = ""
        txtObsAluno.Text = ""
        mskCelularAluno.Text = ""
        mskWhatsAluno.Text = ""
        txtBuscaCadastro.Text = String.Empty

        btnCadastroAluno.Visible = True
        btnCadastroAluno.Enabled = True
        btnExcluiCadastro.Visible = False
        btnAlteraCadastro.Visible = False
        btnBuscaCadastro.Enabled = True
        btnLimpaCadastro.Enabled = True


    End Sub

    Private Sub txtBuscaCadastro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscaCadastro.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtNomeAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtRgAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRgAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub mskCpfAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskCpfAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub mskDnAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskDnAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub cmbEcAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEcAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub cmbGeneroAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbGeneroAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtEnderecoAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnderecoAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub mskTelefoneAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskTelefoneAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub mskCelularAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskCelularAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub mskWhatsAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskWhatsAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtEmailAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmailAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtObsAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObsAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class
