Imports System.Data.SqlClient

Public Class frmPrincipal
    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmFuncionarios.Click
        Dim form = New frmFuncionarios
        form.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New frmClientes
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Dim form = New frmProdutos
        form.ShowDialog()
    End Sub

    Private Sub DesabilitarCampos()

        tsmFuncionarios.Enabled = False

    End Sub
    Private Sub HabilitarCampos()

        tsmFuncionarios.Enabled = True

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = userName
        Listar()
        totalVenda()

        If userName = "Admin" Then
            HabilitarCampos()
        Else
            DesabilitarCampos()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = Now.ToLongTimeString()
        lblData.Text = Now.ToShortDateString()
    End Sub

    Private Sub RegistrarVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVendasToolStripMenuItem.Click
        Dim form = New frmVendas
        form.ShowDialog()
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("SELECT V.ID_VENDA, V.NUM_VENDA, P.NOME, C.NOME, P.VALOR, V.QUANTIDADE, 
			                                 V.VALOR, V.FUNCIONARIO, V.DATA_VENDA, V.ID_PRODUTO, V.ID_CLIENTE 

		                                    FROM VENDAS V
	                                     INNER JOIN PRODUTOS P 
		                                    ON V.ID_PRODUTO = P.ID_PRODUTO
				
                                         INNER JOIN CLIENTES C
                                            ON V.ID_CLIENTE = C.ID_CLIENTE 
	                                    order by NUM_VENDA desc", conectar) 'da: carregar informarções da tabela, 

            da.Fill(dt) 'fill: preenche o datagrid
            dgvVenda.DataSource = dt

            FormatarDg()
            'ContarLinhas()


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

    Private Sub totalVenda()
        Dim total As Decimal

        For Each lin As DataGridViewRow In dgvVenda.Rows
            total = total + lin.Cells(6).Value
        Next

        lblValorTotal.Text = total

    End Sub

End Class