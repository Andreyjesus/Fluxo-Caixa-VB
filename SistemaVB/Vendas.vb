Imports System.Data.SqlClient

Public Class frmVendas
    Private Sub frmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DesabilitarCampos()

        CarregarProduto()
        CarregarClientes()

        btnSalvar.Enabled = False
        Listar()

        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        totalVenda()
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("SELECT V.ID_VENDA, V.NUM_VENDA, P.NOME, C.NOME, P.VALOR, V.QUANTIDADE, 
			                                 V.VALOR, V.FUNCIONARIO, V.DATA_VENDA, V.ID_PRODUTO, V.ID_CLIENTE 

		                                    FROM VENDA V
	                                     INNER JOIN PRODUTOS P 
		                                    ON V.ID_PRODUTO = P.ID_PRODUTO
				
                                         INNER JOIN CLIENTES C
                                            ON V.ID_CLIENTE = C.ID_CLIENTE 
	                                    order by NUM_VENDA desc", conectar) 'da: carregar informarções da tabela, 

            da.Fill(dt) 'fill: preenche o datagrid
            dgvVenda.DataSource = dt

            FormatarDg()
            ContarLinhas()


        Catch ex As Exception
            MessageBox.Show("erro ao listar " + ex.Message)
            fechar()
        End Try
    End Sub



    Private Sub FormatarDg()
        dgvVenda.Columns(0).Visible = False
        dgvVenda.Columns(9).Visible = False
        dgvVenda.Columns(10).Visible = False


        dgvVenda.Columns(1).HeaderText = "Nº Venda"
        dgvVenda.Columns(2).HeaderText = "Produto"
        dgvVenda.Columns(3).HeaderText = "Cliente"
        dgvVenda.Columns(4).HeaderText = "ValorUnit"
        dgvVenda.Columns(5).HeaderText = "Quantidade"
        dgvVenda.Columns(6).HeaderText = "Valor Total"
        dgvVenda.Columns(7).HeaderText = "Funcionário"
        dgvVenda.Columns(8).HeaderText = "Data Venda"

        dgvVenda.Columns(4).Width = 80
        dgvVenda.Columns(5).Width = 80
        dgvVenda.Columns(6).Width = 90

    End Sub

    Private Sub DesabilitarCampos()
        cboProduto.Enabled = False
        cboCliente.Enabled = False
        txtVenda.Enabled = False
        txtQuantidade.Enabled = False
        txtValor.Enabled = False
        txtEstoque.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        cboProduto.Enabled = True
        cboCliente.Enabled = True
        txtVenda.Enabled = True
        txtQuantidade.Enabled = True
        'txtValor.Enabled = True
        'txtEstoque.Enabled = True

    End Sub

    Private Sub Limpar()
        txtVenda.Focus()

        txtVenda.Text = ""
        cboProduto.Text = ""
        cboCliente.Text = ""
        txtQuantidade.Text = ""
        txtBuscar.Text = ""
        txtValor.Text = ""
        txtEstoque.Text = ""

    End Sub

    Private Sub ContarLinhas()

        Dim total As Integer = dgvVenda.Rows.Count
        lblTotalVenda.Text = CInt(total)
    End Sub

    Sub CarregarProduto()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM PRODUTOS", conectar)
            da.Fill(dt)
            cboProduto.DisplayMember = "NOME"
            cboProduto.ValueMember = "ID_PRODUTO"
            cboProduto.DataSource = dt

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
        fechar()
    End Sub

    Sub CarregarClientes()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM CLIENTES", conectar)
            da.Fill(dt)
            cboCliente.DisplayMember = "NOME"
            cboCliente.ValueMember = "ID_CLIENTE"
            cboCliente.DataSource = dt

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
        fechar()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True




    End Sub

    Private Sub cboProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduto.SelectedIndexChanged
        Dim cmd As New SqlCommand("BUSCARVALORPRODU", conectar)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@ID_PRODUTO", cboProduto.SelectedValue)
            cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Direction = 2
            cmd.ExecuteNonQuery()

            Dim valor As Decimal = cmd.Parameters("@VALOR").Value
            txtValor.Text = CStr(valor)

            Dim quantidade As Int32 = cmd.Parameters("@QUANTIDADE").Value
            txtEstoque.Text = CStr(quantidade)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtVenda.Text <> "" Then
            Dim total As Decimal
            Dim valor As Decimal
            Dim qtd As Decimal

            valor = txtValor.Text
            qtd = txtQuantidade.Text

            total = valor * qtd

            Try
                abrir()
                cmd = New SqlCommand("SP_SALVAVENDA", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@NUM_VENDA", txtVenda.Text)
                cmd.Parameters.AddWithValue("@ID_PRODUTO", cboProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@ID_CLIENTE", cboCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@VALOR", total)
                cmd.Parameters.AddWithValue("@FUNCIONARIO", userName)
                cmd.Parameters.AddWithValue("@DATA_VENDA", Now.Date())

                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2

                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                totalVenda()

                cboCliente.Enabled = False
                txtVenda.Enabled = False

                txtQuantidade.Text = ""

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If txtVenda.Text <> "" Then
            Dim total As Decimal
            Dim valor As Decimal
            Dim qtd As Decimal

            valor = txtValor.Text
            qtd = txtQuantidade.Text

            total = valor * qtd

            Try
                abrir()
                cmd = New SqlCommand("SP_EDITAVENDA", conectar)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ID_VENDA", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@NUM_VENDA", txtVenda.Text)
                cmd.Parameters.AddWithValue("@ID_PRODUTO", cboProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@QUANTIDADE", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@VALOR", total)


                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2

                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()
                totalVenda()

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
                cmd = New SqlCommand("SP_EXCLUIRVENDA", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID_VENDA", txtCodigo.Text)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2

                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Listar()
                Limpar()
                totalVenda()

                btnSalvar.Enabled = False
                btnEditar.Enabled = False
                btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub dgvVenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVenda.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()

        txtCodigo.Text = dgvVenda.CurrentRow.Cells(0).Value
        txtVenda.Text = dgvVenda.CurrentRow.Cells(1).Value
        cboProduto.SelectedValue = dgvVenda.CurrentRow.Cells(9).Value
        cboCliente.SelectedValue = dgvVenda.CurrentRow.Cells(10).Value
        txtQuantidade.Text = dgvVenda.CurrentRow.Cells(5).Value

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        If txtBuscar.Text = "" And dgvVenda.Rows.Count > 0 Then
            Listar()
            totalVenda()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("SP_BUSCAVENDA", conectar) 'da: carrega informações da tabela com base no cpf 

                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NUM_VENDA", txtBuscar.Text)

                da.Fill(dt) 'fill: preenche o datagrid
                dgvVenda.DataSource = dt

                ContarLinhas()
                totalVenda()

            Catch ex As Exception
                MessageBox.Show("erro ao listar " + ex.Message)
                fechar()
            End Try

        End If

    End Sub

    Private Sub totalVenda()
        Dim total As Decimal

        For Each lin As DataGridViewRow In dgvVenda.Rows
            total = total + lin.Cells(6).Value
        Next

        lblValorTotal.Text = total

    End Sub

End Class