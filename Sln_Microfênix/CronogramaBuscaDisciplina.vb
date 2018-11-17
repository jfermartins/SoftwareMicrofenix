

Imports System.Data.SqlClient

Public Class CronogramaBuscaDisciplina
    








    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim f As cronogramaSala = New cronogramaSala
        f.MdiParent = Principal
        f.Show()
        Me.Close()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Dim sair, cancel As String

        sair = MsgBox("Deseja realmente sair?", vbYesNo + vbExclamation, " Atenção ")

        If sair = vbYes Then
            Close()
        Else
            cancel = True
        End If
    End Sub






    Private Sub dgvCronograma_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCronograma.CellContentClick
        Principal.nomeDisciplina = (dgvCronograma.Rows(e.RowIndex).Cells(1).Value.ToString)
        Principal.idDisciplina = (dgvCronograma.Rows(e.RowIndex).Cells(0).Value.ToString)


        btnOk.Enabled = True
    End Sub

    Private Sub btnDisciplina_Click(sender As Object, e As EventArgs) Handles btnDisciplina.Click
        
        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        'cmd.CommandText = "select*from Funcionario where nomeFunc like '" & txtNome.Text & "%'"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_BuscaCronograma"
        cmd.Parameters.AddWithValue("nomeDisciplina", txtDisciplinaCronograma.Text)



        cmd.Connection = con
        'exige método construtor
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()
        con.Open()

        adap.Fill(ds, "Disciplina")

        con.Close()

        dgvCronograma.DataSource = ds

        dgvCronograma.DataMember = "Disciplina"







    End Sub

    Private Sub txtDisciplinaCronograma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisciplinaCronograma.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub

    
End Class