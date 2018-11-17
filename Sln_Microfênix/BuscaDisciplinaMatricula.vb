Imports System.Data.SqlClient

Public Class BuscaDisciplinaMatricula
  

    Private Sub btnDisciplina_Click(sender As Object, e As EventArgs) Handles btnDisciplina.Click
       
        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        'cmd.CommandText = "select*from Funcionario where nomeFunc like '" & txtNome.Text & "%'"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_BuscaDisciplinaMatricula"
        cmd.Parameters.AddWithValue("nomeDisciplina", txtbuscaDisciplinaMatricula.Text)

        cmd.Connection = con
        'exige método construtor
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()
        con.Open()

        adap.Fill(ds, "Disciplina")

        con.Close()

        dgvBuscaDisciplinaMatricula.DataSource = ds

        dgvBuscaDisciplinaMatricula.DataMember = "Disciplina"
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim f As MatriculaAluno = New MatriculaAluno
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

    Private Sub dgvBuscaDisciplinaMatricula_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscaDisciplinaMatricula.CellContentClick
        Principal.idDisciplina = (dgvBuscaDisciplinaMatricula.Rows(e.RowIndex).Cells(0).Value.ToString)
        Principal.nomeDisciplina = (dgvBuscaDisciplinaMatricula.Rows(e.RowIndex).Cells(1).Value.ToString)

        btnOk.Enabled = True
    End Sub

   
End Class