Imports System.Data.SqlClient

Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()

        btnSalvar.Enabled = False
        mtbBusca_CPF.Visible = False
        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        rbtNome.Checked = True
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("SELECT * FROM CLIENTES", conectar) 'da: carregar informarções da tabela, 
            da.Fill(dt) 'fill: preenche o datagrid
            dgvClientes.DataSource = dt

            FormatarDg()
            ContarLinhas()


        Catch ex As Exception
            MessageBox.Show("erro ao listar " + ex.Message)
            fechar()
        End Try
    End Sub



    Private Sub FormatarDg()
        dgvClientes.Columns(0).Visible = False
        'dgvClientes.Columns(8).Visible = False

        dgvClientes.Columns(1).HeaderText = "Nome"
        dgvClientes.Columns(2).HeaderText = "Sexo"
        dgvClientes.Columns(3).HeaderText = "Endereço"
        dgvClientes.Columns(4).HeaderText = "Telefone"
        dgvClientes.Columns(5).HeaderText = "Email"

        dgvClientes.Columns(6).HeaderText = "Data Contratação"
        dgvClientes.Columns(7).HeaderText = "CPF"

        dgvClientes.Columns(5).Width = 130
        dgvClientes.Columns(6).Width = 80




    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        cboSexo.Enabled = False
        mtbCPF.Enabled = False
        txtEndereco.Enabled = False
        mtbTelefone.Enabled = False
        txtEmail.Enabled = False
        'cboTurno.Enabled = False
        'dtpData_contratacao.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        cboSexo.Enabled = True
        mtbCPF.Enabled = True
        txtEndereco.Enabled = True
        mtbTelefone.Enabled = True
        txtEmail.Enabled = True
        'cboTurno.Enabled = True
        'dtpData_contratacao.Enabled = True

    End Sub

    Private Sub Limpar()
        txtNome.Text = ""
        cboSexo.Text = ""
        mtbCPF.Text = ""
        txtEndereco.Text = ""
        mtbTelefone.Text = ""
        txtEmail.Text = ""
        'cboTurno.Text = ""
        txtBuscar_Nome.Text = ""
        'dtpData_contratacao.Value = Now
        dgvClientes.Text = ""
    End Sub



    Private Sub ContarLinhas()

        Dim total As Integer = dgvClientes.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub


    Private Sub rbtNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNome.CheckedChanged
        mtbBusca_CPF.Text = ""
        txtBuscar_Nome.Text = ""

        txtBuscar_Nome.Visible = True
        mtbBusca_CPF.Visible = False
        txtBuscar_Nome.Focus()
        Listar()
    End Sub

    Private Sub rbtCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCPF.CheckedChanged
        txtBuscar_Nome.Text = ""
        mtbBusca_CPF.Text = ""

        mtbBusca_CPF.Visible = True
        txtBuscar_Nome.Visible = False
        mtbBusca_CPF.Focus()
        Listar()
    End Sub


    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If mtbCPF.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("SP_SALVACLIENTE", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@SEXO", cboSexo.Text)
                cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@TELEFONE", mtbTelefone.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)

                cmd.Parameters.AddWithValue("@DATA_CADASTRO", Now.Date())
                cmd.Parameters.AddWithValue("@CPF", mtbCPF.Text)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2

                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()
        mtbCPF.Enabled = False

        txtNome.Text = dgvClientes.CurrentRow.Cells(1).Value
        cboSexo.Text = dgvClientes.CurrentRow.Cells(2).Value
        txtEndereco.Text = dgvClientes.CurrentRow.Cells(3).Value
        mtbTelefone.Text = dgvClientes.CurrentRow.Cells(4).Value
        txtEmail.Text = dgvClientes.CurrentRow.Cells(5).Value

        'dtpData_cadastro.Text = dgvClientes.CurrentRow.Cells(6).Value
        mtbCPF.Text = dgvClientes.CurrentRow.Cells(7).Value
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If mtbCPF.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("SP_EDITACLIENTE", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@SEXO", cboSexo.Text)
                cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@TELEFONE", mtbTelefone.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)


                cmd.Parameters.AddWithValue("@CPF", mtbCPF.Text)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2

                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnSalvar.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados" + ex.Message)
                fechar()
            End Try
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If mtbCPF.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("SP_EXCLUIRCLIENTE", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CPF", mtbCPF.Text)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2

                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()

                btnSalvar.Enabled = False
                btnEditar.Enabled = False
                btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub mtbBusca_CPF_TextChanged(sender As Object, e As EventArgs) Handles mtbBusca_CPF.TextChanged
        If mtbBusca_CPF.Text = "   .   .   -" And dgvClientes.Rows.Count > 0 Then
            Listar()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("SP_BUSCACPFCLIENTE", conectar) 'da: carrega informações da tabela com base no cpf 

                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@CPF", mtbBusca_CPF.Text)

                da.Fill(dt) 'fill: preenche o datagrid
                dgvClientes.DataSource = dt


                ContarLinhas()


            Catch ex As Exception
                MessageBox.Show("erro ao listar " + ex.Message)
                fechar()
            End Try

        End If
    End Sub

    Private Sub txtBuscar_Nome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar_Nome.TextChanged
        If txtBuscar_Nome.Text = "" And dgvClientes.Rows.Count > 0 Then
            Listar()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("SP_BUSCACLIENTE", conectar) 'da: carrega informações da tabela com base no cpf 

                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NOME", txtBuscar_Nome.Text)

                da.Fill(dt) 'fill: preenche o datagrid
                dgvClientes.DataSource = dt


                ContarLinhas()


            Catch ex As Exception
                MessageBox.Show("erro ao listar " + ex.Message)
                fechar()
            End Try

        End If
    End Sub
End Class


