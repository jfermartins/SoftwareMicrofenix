Imports System.Data.SqlClient
Public Class BuscaSala
   


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim f As AlterarCronograma = New AlterarCronograma
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

    Private Sub dgvSala_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSala.CellContentClick
        Principal.nomeDisciplina = (dgvSala.Rows(e.RowIndex).Cells(1).Value.ToString)
        Principal.nomeDocenteSala = (dgvSala.Rows(e.RowIndex).Cells(2).Value.ToString)
        Principal.TurmaSala = (dgvSala.Rows(e.RowIndex).Cells(4).Value.ToString)
        Principal.dtHrSala = (dgvSala.Rows(e.RowIndex).Cells(3).Value.ToString)
        Principal.dadosSala = (dgvSala.Rows(e.RowIndex).Cells(0).Value.ToString)
        Principal.nomeFuncionario = (dgvSala.Rows(e.RowIndex).Cells(6).Value.ToString)
        Principal.idDisciplina = (dgvSala.Rows(e.RowIndex).Cells(5).Value.ToString)
        Principal.idFuncionario = (dgvSala.Rows(e.RowIndex).Cells(7).Value.ToString)
        Principal.idCronograma = (dgvSala.Rows(e.RowIndex).Cells(8).Value.ToString)


        btnOk.Enabled = True
    End Sub

    Private Sub btnDisciplina_Click(sender As Object, e As EventArgs) Handles btnDisciplina.Click
       
        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        'cmd.CommandText = "select*from Funcionario where nomeFunc like '" & txtNome.Text & "%'"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_Sala"
        cmd.Parameters.AddWithValue("dadosSala", txtSalaBusca.Text)

        cmd.Connection = con
        'exige método construtor
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()
        con.Open()

        adap.Fill(ds, "CronogramaSala")

        con.Close()

        dgvSala.DataSource = ds

        dgvSala.DataMember = "CronogramaSala"
    End Sub


    Private Sub txtSalaBusca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalaBusca.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub

  
End Class