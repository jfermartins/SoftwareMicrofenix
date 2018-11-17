Imports System.Data.SqlClient
Public Class Pesquisa

    Private Sub btnLimparUsuario_Click(sender As Object, e As EventArgs) Handles btnLimparUsuario.Click

        txtNomeMaterial.Text = String.Empty
        txtNomeFornecedor.Text = String.Empty
        txtValorMaterial.Text = String.Empty
        txtNotaFiscalMaterial.Text = String.Empty
        txtMarcaMaterial.Text = String.Empty
        txtQuantidadeMaterial.Text = String.Empty

    End Sub

    Private Sub btnExcluirFuncionario_Click(sender As Object, e As EventArgs) Handles btnExcluirFuncionario.Click
        Dim excluir, cancel As String

        excluir = MsgBox("Deseja realmente excluir?", vbYesNo + vbExclamation, " Atenção ")


        If excluir = vbYes Then

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)


            Dim cmd As SqlCommand = New SqlCommand()

            cmd.CommandType = CommandType.StoredProcedure

            cmd.CommandText = "pd_Material"


            cmd.Parameters.AddWithValue("nomeMaterial", txtNomeMaterial.Text)

            cmd.Connection = con

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("Cadastro excluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True

        End If

    End Sub

   

    Private Sub btnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles btnBuscarUsuario.Click

        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_Material"

        cmd.Parameters.AddWithValue("nomeMaterial", txtNomeMaterial.Text)


        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()


        dr = cmd.ExecuteReader


        If dr.Read() Then

            txtNomeMaterial.Text = dr("nomeMaterial")
            txtNomeFornecedor.Text = dr("nomeFornecedor")
            txtValorMaterial.Text = dr("valorMaterial")
            txtNotaFiscalMaterial.Text = dr("nfMaterial")
            txtMarcaMaterial.Text = dr("marcaMaterial")
            txtQuantidadeMaterial.Text = dr("qtdMaterial")

        Else

            MsgBox("Usuário não encontrado!")

        End If

        con.Close()


    End Sub

    Private Sub txtNomeMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtNomeFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeFornecedor.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtValorMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtNotaFiscalMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotaFiscalMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtMarcaMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarcaMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtQuantidadeMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidadeMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class