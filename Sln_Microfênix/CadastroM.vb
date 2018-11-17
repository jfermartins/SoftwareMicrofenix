Imports System.Data.SqlClient
Public Class CadastroM

    Private Sub CadastroM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFuncionario.Text = Principal.idFuncionario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then


            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)
            Dim cmd As SqlCommand = New SqlCommand

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pi_Material"

            cmd.Parameters.AddWithValue("nomeMaterial", txtNomeMaterial.Text)
            cmd.Parameters.AddWithValue("qtdMaterial", txtQuantidadeMaterial.Text)
            cmd.Parameters.AddWithValue("marcaMaterial", txtMarcaMaterial.Text)
            cmd.Parameters.AddWithValue("modeloMaterial", txtModeloMaterial.Text)
            cmd.Parameters.AddWithValue("valorMaterial", txtValorMaterial.Text)

            If txtDataEntradaMaterial.TextLength > 0 Then
                cmd.Parameters.AddWithValue("dtEntradaMaterial", CDate(txtDataEntradaMaterial.Text))
            Else
                cmd.Parameters.AddWithValue("dtEntradaMaterial", 0)
            End If

            If txtHoraEntradaMaterial.TextLength > 0 Then
                cmd.Parameters.AddWithValue("hrEntradaMaterial", CDate(txtHoraEntradaMaterial.Text))
            Else
                cmd.Parameters.AddWithValue("hrEntradaMaterial", 0)
            End If

            If txtDataSaidaMaterial.TextLength > 0 Then
                cmd.Parameters.AddWithValue("dtSaidaMaterial", CDate(txtDataSaidaMaterial.Text))
            Else
                cmd.Parameters.AddWithValue("dtSaidaMaterial", 0)
            End If

            If txtHoraSaidaMaterial.TextLength > 0 Then
                cmd.Parameters.AddWithValue("hrSaidaMaterial", CDate(txtHoraSaidaMaterial.Text))
            Else
                cmd.Parameters.AddWithValue("hrSaidaMaterial", 0)
            End If

            cmd.Parameters.AddWithValue("nfMaterial", txtNotaFiscalMaterial.Text)
            cmd.Parameters.AddWithValue("nomeFornecedor", txtNomeFornecedor.Text)
            cmd.Parameters.AddWithValue("cnpjFornecedor", txtCnpjFornecedor.Text)

            If txtInscricaoFornecedor.TextLength > 0 Then
                cmd.Parameters.AddWithValue("ieFornecedor", txtInscricaoFornecedor.Text)
            Else
                cmd.Parameters.AddWithValue("ieFornecedor", 0)
            End If

            cmd.Parameters.AddWithValue("endFornecedor", txtEnderecoFornecedor.Text)
            cmd.Parameters.AddWithValue("telFornecedor", txtTelefoneFornecedor.Text)
            cmd.Parameters.AddWithValue("idFuncionario", txtFuncionario.Text)

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("Cadastro concluído com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True
        End If

        Dim a As Control

        For Each a In GroupBox1.Controls

            If TypeOf a Is TextBox Then
                a.Text = ""
            End If

        Next

        For Each a In GroupBox2.Controls

            If TypeOf a Is TextBox Then
                a.Text = ""
            End If

        Next

    End Sub

    Private Sub txtNomeMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtQuantidadeMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidadeMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtMarcaMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarcaMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtModeloMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtModeloMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtValorMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDataEntradaMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataEntradaMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtHoraEntradaMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHoraEntradaMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDataSaidaMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataSaidaMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtHoraSaidaMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHoraSaidaMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtNotaFiscalMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotaFiscalMaterial.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtNomeFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeFornecedor.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtCnpjFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCnpjFornecedor.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtInscricaoFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInscricaoFornecedor.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtEnderecoFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnderecoFornecedor.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtTelefoneFornecedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefoneFornecedor.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtFuncionario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFuncionario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class
