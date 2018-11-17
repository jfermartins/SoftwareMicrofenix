Imports System.Data.SqlClient

Public Class MatriculaAluno
    

    Dim idAluno As Integer = 0
    Dim idDisciplina As Integer

    Private Sub MatriculaAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdDisciplina.Text = Principal.idDisciplina
        txtNomeDisciplina.Text = Principal.nomeDisciplina

        'If txtBuscaMatricula.TextLength > 0 Then
        '    'rodar um select para preencher os dados nos campos
        'End If

    End Sub

    Private Sub btnAlteraMatricula_Click(sender As Object, e As EventArgs) Handles btnAlteraMatricula.Click

        If txtAlunoMatricula.Text = "" Or mskCpfMatricula.Text = "" Or mskDataMatricula.Text = "" Or txtPagtoMatricula.Text = "" Or cmbFormaPagtoMatricula.Text = "" Or cmbModoPagtoMatricula.Text = "" Then

            MessageBox.Show("Preenchimento obrigatório de todos os campos, exceto o campo de Observação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


            Dim con As SqlConnection = New SqlConnection(str)
            Dim cmd As SqlCommand = New SqlCommand()

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pu_MatriculaAluno"


            cmd.Parameters.AddWithValue("dataMatriculaAluno", mskDataMatricula.Text)
            cmd.Parameters.AddWithValue("valorTotalPagtoAluno", Replace(Replace(txtPagtoMatricula.Text, ",", ""), "-", ""))
            cmd.Parameters.AddWithValue("formaPagtoAluno", cmbFormaPagtoMatricula.Text)
            cmd.Parameters.AddWithValue("modoPagtoParcelado", cmbModoPagtoMatricula.Text)
            cmd.Parameters.AddWithValue("obsMatriculaAluno", txtObsMatricula.Text)

            cmd.Connection = con
            con.Open()

            cmd.ExecuteNonQuery()

            con.Close()

            MessageBox.Show("Matrícula alterada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtAlunoMatricula.Text = String.Empty
            mskCpfMatricula.Text = ""
            mskDataMatricula.Text = ""
            txtPagtoMatricula.Text = String.Empty
            cmbFormaPagtoMatricula.Text = String.Empty
            cmbModoPagtoMatricula.Text = String.Empty
            txtObsMatricula.Text = String.Empty
            txtBuscaMatricula.Text = String.Empty

            btnMatricular.Enabled = True
            btnExcluiMatricula.Visible = False
            btnAlteraMatricula.Enabled = False
            btnBuscaMatricula.Enabled = True
            btnLimpaMatricula.Enabled = True

        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscaMatricula.Click

        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ps_MatriculaAluno"

        cmd.Parameters.AddWithValue("cpfAluno", txtBuscaMatricula.Text)

        Dim dr As SqlDataReader

        cmd.Connection = con

        con.Open()

        dr = cmd.ExecuteReader

        If dr.Read() Then

            idAluno = dr("idAluno")

            txtAlunoMatricula.Text = dr("nomeAluno")
            mskCpfMatricula.Text = dr("cpfAluno")

            If Not IsDBNull(dr("dataMatriculaAluno")) Then
                mskDataMatricula.Text = dr("dataMatriculaAluno")
            End If

            If Not IsDBNull(dr("valorTotalPagtoAluno")) Then
                txtPagtoMatricula.Text = dr("valorTotalPagtoAluno")
            End If

            If Not IsDBNull(dr("formaPagtoAluno")) Then
                cmbFormaPagtoMatricula.Text = dr("formaPagtoAluno")
            End If

            If Not IsDBNull(dr("modoPagtoParcelado")) Then
                cmbModoPagtoMatricula.Text = dr("modoPagtoParcelado")
            End If

            If Not IsDBNull(dr("obsMatriculaAluno")) Then
                txtObsMatricula.Text = dr("obsMatriculaAluno")
            End If


            btnMatricular.Enabled = True
            btnExcluiMatricula.Visible = True
            btnAlteraMatricula.Enabled = True
            btnBuscaMatricula.Enabled = False
            btnLimpaMatricula.Enabled = True

        Else
            MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        con.Close()


    End Sub

    Private Sub btnLimpaMatricula_Click(sender As Object, e As EventArgs) Handles btnLimpaMatricula.Click

        txtAlunoMatricula.Text = String.Empty
        mskCpfMatricula.Text = ""
        mskDataMatricula.Text = ""
        txtPagtoMatricula.Text = String.Empty
        cmbFormaPagtoMatricula.Text = String.Empty
        cmbModoPagtoMatricula.Text = String.Empty
        txtObsMatricula.Text = String.Empty
        txtBuscaMatricula.Text = String.Empty

        btnMatricular.Enabled = True
        btnExcluiMatricula.Visible = False
        btnAlteraMatricula.Enabled = False
        btnBuscaMatricula.Enabled = True
        btnLimpaMatricula.Enabled = True

    End Sub

    Private Sub btnMatricular_Click(sender As Object, e As EventArgs) Handles btnMatricular.Click



        If txtAlunoMatricula.Text = "" Or mskCpfMatricula.Text = "" Or mskDataMatricula.Text = "" Or txtPagtoMatricula.Text = "" Or cmbFormaPagtoMatricula.Text = "" Or cmbModoPagtoMatricula.Text = "" Then

            MessageBox.Show("Preenchimento obrigatório de todos os campos, exceto o campo de Observação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim cadastrar, cancel As String

            cadastrar = MsgBox("Deseja realmente cadastrar?", vbYesNo + vbExclamation, " Atenção ")


            If cadastrar = vbYes Then

                Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


                Dim con As SqlConnection = New SqlConnection(str)
                Dim cmd As SqlCommand = New SqlCommand()

                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "pi_MatriculaAluno"

                Dim valor As Double = CDbl(txtPagtoMatricula.Text)

                cmd.Parameters.AddWithValue("dataMatriculaAluno", mskDataMatricula.Text)
                cmd.Parameters.AddWithValue("valorTotalPagtoAluno", valor)
                cmd.Parameters.AddWithValue("formaPagtoAluno", cmbFormaPagtoMatricula.Text)
                cmd.Parameters.AddWithValue("modoPagtoParcelado", cmbModoPagtoMatricula.Text)
                cmd.Parameters.AddWithValue("obsMatriculaAluno", txtObsMatricula.Text)
                cmd.Parameters.AddWithValue("idAluno", idAluno)
                cmd.Parameters.AddWithValue("idDisciplina", txtIdDisciplina.Text)


                cmd.Connection = con
                con.Open()

                cmd.ExecuteNonQuery()

                con.Close()

                MessageBox.Show("Matrícula realizada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                cancel = True
            End If

            txtAlunoMatricula.Text = String.Empty
            mskCpfMatricula.Text = ""
            mskDataMatricula.Text = ""
            txtPagtoMatricula.Text = String.Empty
            cmbFormaPagtoMatricula.Text = String.Empty
            cmbModoPagtoMatricula.Text = String.Empty
            txtObsMatricula.Text = String.Empty
            txtBuscaMatricula.Text = String.Empty

            btnMatricular.Enabled = True
            btnExcluiMatricula.Visible = False
            btnAlteraMatricula.Enabled = False
            btnBuscaMatricula.Enabled = True
            btnLimpaMatricula.Enabled = True

        End If


    End Sub

    Private Sub btnExcluiMatricula_Click(sender As Object, e As EventArgs) Handles btnExcluiMatricula.Click

        Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"


        Dim con As SqlConnection = New SqlConnection(str)
        Dim cmd As SqlCommand = New SqlCommand()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "pd_CadastroAluno"

        cmd.Parameters.AddWithValue("cpfAluno", txtBuscaMatricula.Text)

        cmd.Connection = con
        con.Open()

        cmd.ExecuteNonQuery()

        con.Close()

        MessageBox.Show("Matrícula excluída com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtAlunoMatricula.Text = String.Empty
        mskCpfMatricula.Text = ""
        mskDataMatricula.Text = ""
        txtPagtoMatricula.Text = String.Empty
        cmbFormaPagtoMatricula.Text = String.Empty
        cmbModoPagtoMatricula.Text = String.Empty
        txtObsMatricula.Text = String.Empty
        txtBuscaMatricula.Text = String.Empty

        btnMatricular.Enabled = True
        btnExcluiMatricula.Visible = False
        btnAlteraMatricula.Visible = False
        btnBuscaMatricula.Enabled = True
        btnLimpaMatricula.Enabled = True

    End Sub

    Private Sub txtBuscaMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscaMatricula.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtAlunoMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlunoMatricula.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub mskCpfMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskCpfMatricula.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub mskDataMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskDataMatricula.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtPagtoMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagtoMatricula.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub cmbFormaPagtoMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFormaPagtoMatricula.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub cmbModoPagtoMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbModoPagtoMatricula.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtObsMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObsMatricula.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub


    Private Sub btnDisciplina_Click(sender As Object, e As EventArgs) Handles btnDisciplina.Click
        Dim F As BuscaDisciplinaMatricula = New BuscaDisciplinaMatricula


        F.MdiParent = Principal

        F.Show()
        Me.Close()
    End Sub
End Class