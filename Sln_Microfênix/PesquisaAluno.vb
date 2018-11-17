Imports System.Data.SqlClient

Public Class PesquisaAluno


    Private Sub btnMatriculaPesquisa_Click(sender As Object, e As EventArgs) Handles btnMatriculaPesquisa.Click
        Dim F As MatriculaAluno = New MatriculaAluno

        F.MdiParent = Principal
        F.txtBuscaMatricula.Text = txtBuscaPesquisa.Text
        F.Show()
        Me.Close()

    End Sub

    Private Sub btnBuscaPesquisa_Click(sender As Object, e As EventArgs) Handles btnBuscaPesquisa.Click

        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)
        Dim cmd As SqlCommand = New SqlCommand()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_PesquisaAluno"

        cmd.Parameters.AddWithValue("cpfAluno", txtBuscaPesquisa.Text)

        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()

        dr = cmd.ExecuteReader

        If dr.Read() Then

            txtAlunoPesquisa.Text = dr("nomeAluno")
            txtCpfPesquisa.Text = dr("cpfAluno")

            If Not IsDBNull(dr("idMatriculaAluno")) Then
                txtMatriculaPesquisa.Text = dr("idMatriculaAluno")
            End If


            btnBuscaPesquisa.Enabled = False
            btnCadastroPesquisa.Visible = True
            btnMatriculaPesquisa.Visible = True

        Else

            MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtBuscaPesquisa.Text = String.Empty

            btnBuscaPesquisa.Enabled = True
            btnCadastroPesquisa.Visible = False
            btnMatriculaPesquisa.Visible = False

        End If

        con.Close()

    End Sub

    Private Sub btnLimpaPesquisa_Click(sender As Object, e As EventArgs) Handles btnLimpaPesquisa.Click

        txtAlunoPesquisa.Text = String.Empty
        txtCpfPesquisa.Text = String.Empty
        txtMatriculaPesquisa.Text = String.Empty
        txtBuscaPesquisa.Text = String.Empty

        btnBuscaPesquisa.Enabled = True
        btnCadastroPesquisa.Visible = False
        btnMatriculaPesquisa.Visible = False

    End Sub

    Private Sub btnCadastroPesquisa_Click(sender As Object, e As EventArgs) Handles btnCadastroPesquisa.Click

        Dim F As CadastroAluno = New CadastroAluno

        F.MdiParent = Principal
        F.txtBuscaCadastro.Text = txtBuscaPesquisa.Text
        F.Show()
        Me.Close()

    End Sub

    Private Sub txtBuscaPesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscaPesquisa.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtAlunoPesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlunoPesquisa.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtCpfPesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCpfPesquisa.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtMatriculaPesquisa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMatriculaPesquisa.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class