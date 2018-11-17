Imports System.Data.SqlClient
Public Class BuscarAtividade
  



    Private Sub btnDisciplina_Click(sender As Object, e As EventArgs) Handles btnDisciplina.Click
      
        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        'cmd.CommandText = "select*from Funcionario where nomeFunc like '" & txtNome.Text & "%'"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_Atividade"
        cmd.Parameters.AddWithValue("nomeAtividade", txtAtividade.Text)

        cmd.Connection = con
        'exige método construtor
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()
        con.Open()

        adap.Fill(ds, "Atividade")

        con.Close()

        dgvAtividade.DataSource = ds

        dgvAtividade.DataMember = "Atividade"
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim f As Cadastro_Atividade = New Cadastro_Atividade
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

  

    Private Sub txtAtividade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAtividade.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub

   
   
   
   

    Private Sub dgvAtividade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAtividade.CellContentClick
        Principal.nomeAtividade = (dgvAtividade.Rows(e.RowIndex).Cells(0).Value.ToString)
        Principal.conteudoAtividade = (dgvAtividade.Rows(e.RowIndex).Cells(3).Value.ToString)
        Principal.dtHrAtividade = (dgvAtividade.Rows(e.RowIndex).Cells(4).Value.ToString)
        Principal.DocenteAtividade = (dgvAtividade.Rows(e.RowIndex).Cells(5).Value.ToString)
        Principal.mencaoAtividade = (dgvAtividade.Rows(e.RowIndex).Cells(6).Value.ToString)
        Principal.faltasAtividade = (dgvAtividade.Rows(e.RowIndex).Cells(7).Value.ToString)
        Principal.nomeAluno = (dgvAtividade.Rows(e.RowIndex).Cells(1).Value.ToString)
        Principal.nomeDisciplina = (dgvAtividade.Rows(e.RowIndex).Cells(2).Value.ToString)
        Principal.idAtividade = (dgvAtividade.Rows(e.RowIndex).Cells(8).Value.ToString)
        Principal.idAluno = (dgvAtividade.Rows(e.RowIndex).Cells(10).Value.ToString)
        Principal.idDisciplina = (dgvAtividade.Rows(e.RowIndex).Cells(9).Value.ToString)


        btnOk.Enabled = True
    End Sub
End Class