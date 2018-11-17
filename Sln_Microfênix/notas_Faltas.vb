Imports System.Data.SqlClient
Public Class notas_Faltas
    




    Private Sub notas_Faltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdAluno.Text = Principal.idAluno
        txtIdDisciplina.Text = Principal.idDisciplina
        txtAlunoNota.Text = Principal.nomeAluno
        txtDisciplinaNota.Text = Principal.nomeDisciplina
        txtMedia.Text = Principal.media
        txtFaltas.Text = Principal.Faltas
       

    End Sub

    Private Sub btnBuscarAlunoDisciplinaAtividade_Click(sender As Object, e As EventArgs) Handles btnBuscarAlunoDisciplinaAtividade.Click

        Dim F As consultasMedia = New consultasMedia


        F.MdiParent = Principal

        F.Show()

        Me.Close()
    End Sub

    Private Sub btnSairCadastroDisciplina_Click(sender As Object, e As EventArgs) Handles btnSairCadastroDisciplina.Click
        Dim sair, cancel As String

        sair = MsgBox("Deseja realmente sair?", vbYesNo + vbExclamation, " Atenção ")

        If sair = vbYes Then
            Close()
        Else
            cancel = True
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        ''    'definindo conexão
        ''Dim str As String = "Server=SAN0522362W10-1\BD_BLUE;Database=RHYNO;User Id=jane.fernanda;Password=vscnqpmo6f@;"



        'Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

        'Dim con As SqlConnection = New SqlConnection(str)

        'Dim cmd As SqlCommand = New SqlCommand()
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.CommandText = "ps_Notas"

        'cmd.Parameters.AddWithValue("idAluno", txtIdAluno.Text)

        ''processo novo que é usado para select
        ''objeto data reader não existe método construtor
        'Dim dr As SqlDataReader

        'cmd.Connection = con

        'con.Open()

        ''diferenças (em vez de execute non query  usa se execute reader
        ''executando uma consulta que posuui retorno de dados e guardando os valores no sql
        'dr = cmd.ExecuteReader

        ''verificando se encontro algum dado na consulta que executamos no sql



        'If dr.Read() Then
        '    'associando valores que encontramos na consulta nos campos do form
        '    txtIdAluno.Text = dr("idAluno")
        '    txtAlunoNota.Text = dr("nomeAluno")
        '    txtIdDisciplina = dr("idDisciplina")
        '    txtDisciplinaNota = dr("nomeDisciplina")
        '    txtMedia = dr("media")
        '    txtFaltas = dr("Faltas")




        'Else
        '    'retorno caso a consulta não encontre valores no sql
        '    MessageBox.Show("Usuário não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        'con.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadastrar, cancel As String

        cadastrar = MsgBox("Deseja realmente atribuir nota?", vbYesNo + vbExclamation, " Atenção ")


        If cadastrar = vbYes Then


         
            Dim str As String = "Server=NANDA\SQLEXPRESS;Database=MICROFENIX;User Id=sistema.microfenix;Password=microfenixsee;"

            Dim con As SqlConnection = New SqlConnection(str)


            'dedinindo o comando do sql q será utilizado

            Dim cmd As SqlCommand = New SqlCommand()



            'chamando uma stored procedure
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "pi_MediaeFaltas"


            'definindo valores (parametros)
            cmd.Parameters.AddWithValue("notaMediaeFaltas", CDec(txtMedia.Text))
            cmd.Parameters.AddWithValue("faltasMediaeFaltas", txtFaltas.Text)
            cmd.Parameters.AddWithValue("idAluno", txtIdAluno.Text)
            cmd.Parameters.AddWithValue("idDisciplina", txtIdDisciplina.Text)





            'definir quem é a conexão
            cmd.Connection = con



            'abrir a conexão
            con.Open()


            'executar o comando sql
            cmd.ExecuteNonQuery()


            'fechar a conexão
            con.Close()

            MessageBox.Show("Nota atribuida com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            cancel = True
        End If

        txtIdAluno.Text = String.Empty
        txtIdDisciplina.Text = String.Empty
        txtAlunoNota.Text = String.Empty
        txtDisciplinaNota.Text = String.Empty
        txtMedia.Text = String.Empty
        txtFaltas.Text = String.Empty

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtIdAluno.Text = String.Empty
        txtIdDisciplina.Text = String.Empty
        txtAlunoNota.Text = String.Empty
        txtDisciplinaNota.Text = String.Empty
        txtMedia.Text = String.Empty
        txtFaltas.Text = String.Empty
       
    End Sub

   

    Private Sub txtIdAluno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdAluno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtIdDisciplina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdDisciplina.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtAlunoNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlunoNota.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtDisciplinaNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisciplinaNota.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtMedia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMedia.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtFaltas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFaltas.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True : SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtData.Text = Now

        txtData.Show()
    End Sub
End Class