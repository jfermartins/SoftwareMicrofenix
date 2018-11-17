Imports System.Data.SqlClient

Public Class CadastroLaboratorio


    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click
        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pi_Laboratorio"

            cmd.Parameters.AddWithValue("nomeLaboratorio", txtNLaboratorio.Text)
            cmd.Parameters.AddWithValue("horarioLaboratorio", txtHorario.Text)
            cmd.Parameters.AddWithValue("nomeTecLaboratorio", txtTecnico.Text)
            cmd.Parameters.AddWithValue("rgTecLaboratorio", txtRG.Text)


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

            cmd.CommandText = "pd_Laboratorio"


            cmd.Parameters.AddWithValue("nomeLaboratorio", txtNLaboratorio.Text)

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
        txtNLaboratorio.Enabled = False

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
            cmd.CommandText = "pu_Laboratorio"

            'definindo valores (parametros)

            cmd.Parameters.AddWithValue("nomeLaboratorio", txtNLaboratorio.Text)
            cmd.Parameters.AddWithValue("horarioLaboratorio", txtHorario.Text)
            cmd.Parameters.AddWithValue("tecnicoLaboratorio", txtTecnico)
            cmd.Parameters.AddWithValue("rgLaboratorio", txtRG)


            'definir quem é a conexão
            cmd.Connection = con


            'abrir a conexão
            con.Open()

            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()
            MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtNLaboratorio.Text = ""
            txtHorario.Text = ""
            txtTecnico.Text = ""
            txtRG.Text = ""




        Else
            cancel = True

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnBuscarNlab_Click(sender As Object, e As EventArgs) Handles btnBuscarNlab.Click

        Dim F As BuscaLaboratorio = New BuscaLaboratorio


        F.MdiParent = Principal

        F.Show()

        Me.Close()





        'Dim str As String = "Server=SAN0522362W10-1\MSSQLSERVER2;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        'Dim con As SqlConnection = New SqlConnection(str)

        'Dim cmd As SqlCommand = New SqlCommand()
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.CommandText = "ps_Laboratorio"

        'cmd.Parameters.AddWithValue("nomeLaboratorio", txtNLaboratorio.Text)


        'Dim dr As SqlDataReader

        'cmd.Connection = con

        'con.Open()


        'dr = cmd.ExecuteReader


        'If dr.Read() Then

        '    txtNLaboratorio.Text = dr("nomeLaboratorio")
        '    txtHorario.Text = dr("horarioLaboratorio")
        '    txtTecnico.Text = dr("nomeTecLaboratorio")
        '    txtRG.Text = dr("rgTecLaboratorio")



        'Else

        '    MsgBox("Usuário não encontrado!")

        'End If

        'con.Close()
    End Sub

   

    Private Sub txtNLaboratorio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNLaboratorio.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtHorario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHorario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtTecnico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTecnico.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtRG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRG.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub

   
End Class