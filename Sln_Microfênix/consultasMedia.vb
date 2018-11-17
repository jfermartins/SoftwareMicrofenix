Imports System.Data.SqlClient
Public Class consultasMedia
   

    Private Sub dgvConsultasMedia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsultasMedia.CellContentClick
        Principal.nomeDisciplina = (dgvConsultasMedia.Rows(e.RowIndex).Cells(3).Value.ToString)
        Principal.nomeAluno = (dgvConsultasMedia.Rows(e.RowIndex).Cells(1).Value.ToString)
        Principal.idDisciplina = (dgvConsultasMedia.Rows(e.RowIndex).Cells(2).Value.ToString)
        Principal.idAluno = (dgvConsultasMedia.Rows(e.RowIndex).Cells(0).Value.ToString)
        Principal.media = (dgvConsultasMedia.Rows(e.RowIndex).Cells(5).Value.ToString)
        Principal.Faltas = (dgvConsultasMedia.Rows(e.RowIndex).Cells(6).Value.ToString)
        btnOk.Enabled = True
    End Sub

    Private Sub btnDisciplina_Click(sender As Object, e As EventArgs) Handles btnDisciplina.Click
    
        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_NotasDGV"

        cmd.Parameters.AddWithValue("nomeAluno", txtNomeAluno.Text)



        cmd.Connection = con
        'exige método construtor
        Dim adap As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()
        con.Open()

        adap.Fill(ds, "Atividade")

        con.Close()

        dgvConsultasMedia.DataSource = ds

        dgvConsultasMedia.DataMember = "Atividade"










    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim f As notas_Faltas = New notas_Faltas
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


   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class