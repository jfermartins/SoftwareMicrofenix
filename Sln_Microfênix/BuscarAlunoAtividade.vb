Imports System.Data.SqlClient
Public Class BuscarAlunoAtividade
   


    Private Sub dgvBuscarAlunoAtividade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscarAlunoAtividade.CellContentClick
        Principal.nomeAluno = (dgvBuscarAlunoAtividade.Rows(e.RowIndex).Cells(0).Value.ToString)
        Principal.nomeDisciplina = (dgvBuscarAlunoAtividade.Rows(e.RowIndex).Cells(1).Value.ToString)
        Principal.idAluno = (dgvBuscarAlunoAtividade.Rows(e.RowIndex).Cells(2).Value.ToString)
        Principal.idDisciplina = (dgvBuscarAlunoAtividade.Rows(e.RowIndex).Cells(3).Value.ToString)

        btnOk.Enabled = True
    End Sub


    Private Sub btnBuscarAlunoDisciplinaAtividade_Click(sender As Object, e As EventArgs) Handles btnBuscarAlunoDisciplinaAtividade.Click
        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        

        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        'cmd.CommandText = "select*from Funcionario where nomeFunc like '" & txtNome.Text & "%'"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_BuscaAlunoDisciplina"
        cmd.Parameters.AddWithValue("nomeAluno", txtAlunoAtividade.Text)

        cmd.Connection = con
        'exige método construtor
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()
        con.Open()

        adap.Fill(ds, "Aluno")

        con.Close()

        dgvBuscarAlunoAtividade.DataSource = ds

        dgvBuscarAlunoAtividade.DataMember = "Aluno"
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

    Private Sub txtAlunoAtividade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlunoAtividade.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub



    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub

   
End Class