Imports System.Data.SqlClient

Public Class frmProdutos
    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()

        btnSalvar.Enabled = False '
        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("SELECT * FROM PRODUTOS", conectar) 'da: carregar informarções da tabela, 
            da.Fill(dt) 'fill: preenche o datagrid
            dgvProduto.DataSource = dt

            FormatarDg()
            ContarLinhas()


        Catch ex As Exception
            MessageBox.Show("erro ao listar " + ex.Message)
            fechar()
        End Try
    End Sub



    Private Sub FormatarDg()
        dgvProduto.Columns(0).Visible = False
        'dgvClientes.Columns(8).Visible = False

        dgvProduto.Columns(1).HeaderText = "Nome"
        dgvProduto.Columns(2).HeaderText = "Descrição"
        dgvProduto.Columns(3).HeaderText = "Quantidade"
        dgvProduto.Columns(4).HeaderText = "Valor"

        dgvProduto.Columns(2).Width = 130


    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtDescricao.Enabled = False
        txtQuantidade.Enabled = False
        txtValor.Enabled = False


    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        txtDescricao.Enabled = True
        txtQuantidade.Enabled = True
        txtValor.Enabled = True

    End Sub

    Private Sub Limpar()
        txtNome.Text = ""
        txtDescricao.Text = ""
        txtQuantidade.Text = ""
        txtValor.Text = ""

        txtBuscar_Produto.Text = ""
        'dtpData_contratacao.Value = Now
        dgvProduto.Text = ""
    End Sub



    Private Sub ContarLinhas()

        Dim total As Integer = dgvProduto.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("SP_SALVAPRODUTO", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@VALOR", txtValor.Text)


                cmd.Parameters.AddWithValue("@DATA_CADASTRO", Now.Date())

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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("SP_EDITAPRODUTO", conectar)
                cmd.CommandType = CommandType.StoredProcedure


                cmd.Parameters.AddWithValue("@ID_PRODUTO", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text)
                cmd.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@VALOR", txtValor.Text)
                cmd.Parameters.AddWithValue("@DATA_CADASTRO", Now.Date())
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

        If txtCodigo.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("SP_EXCLUIRPRODUTO", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID_PRODUTO", txtCodigo.Text)
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

    Private Sub txtBuscar_Produto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar_Produto.TextChanged
        If txtBuscar_Produto.Text = "" And dgvProduto.Rows.Count > 0 Then
            Listar()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("SP_BUSCAPRODUTO", conectar) 'da: carrega informações da tabela com base no cpf 

                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NOME", txtBuscar_Produto.Text)

                da.Fill(dt) 'fill: preenche o datagrid
                dgvProduto.DataSource = dt


                ContarLinhas()


            Catch ex As Exception
                MessageBox.Show("erro ao listar " + ex.Message)
                fechar()
            End Try

        End If
    End Sub

    Private Sub dgvProduto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduto.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()

        txtCodigo.Text = dgvProduto.CurrentRow.Cells(0).Value

        txtNome.Text = dgvProduto.CurrentRow.Cells(1).Value
        txtDescricao.Text = dgvProduto.CurrentRow.Cells(2).Value
        txtQuantidade.Text = dgvProduto.CurrentRow.Cells(3).Value
        txtValor.Text = dgvProduto.CurrentRow.Cells(4).Value
    End Sub
End Class