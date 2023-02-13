Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFuncionarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar_Nome = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblDataContratação = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.cboTurno = New System.Windows.Forms.ComboBox()
        Me.dtpData_contratacao = New System.Windows.Forms.DateTimePicker()
        Me.mtbTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCPF = New System.Windows.Forms.MaskedTextBox()
        Me.dgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.rbtNome = New System.Windows.Forms.RadioButton()
        Me.rbtCPF = New System.Windows.Forms.RadioButton()
        Me.mtbBusca_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(551, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'txtBuscar_Nome
        '
        Me.txtBuscar_Nome.Location = New System.Drawing.Point(621, 17)
        Me.txtBuscar_Nome.Name = "txtBuscar_Nome"
        Me.txtBuscar_Nome.Size = New System.Drawing.Size(148, 20)
        Me.txtBuscar_Nome.TabIndex = 1
        Me.txtBuscar_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(109, 77)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(148, 20)
        Me.txtNome.TabIndex = 1
        Me.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(54, 81)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(46, 16)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome:"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(263, 81)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(41, 16)
        Me.lblSexo.TabIndex = 4
        Me.lblSexo.Text = "Sexo:"
        Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(470, 78)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(38, 16)
        Me.lblCPF.TabIndex = 6
        Me.lblCPF.Text = "CPF:"
        Me.lblCPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(56, 181)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(44, 16)
        Me.lblTurno.TabIndex = 8
        Me.lblTurno.Text = "Turno:"
        Me.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataContratação
        '
        Me.lblDataContratação.AutoSize = True
        Me.lblDataContratação.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataContratação.Location = New System.Drawing.Point(269, 181)
        Me.lblDataContratação.Name = "lblDataContratação"
        Me.lblDataContratação.Size = New System.Drawing.Size(39, 16)
        Me.lblDataContratação.TabIndex = 10
        Me.lblDataContratação.Text = "Data:"
        Me.lblDataContratação.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(310, 138)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(148, 20)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(263, 142)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(39, 142)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefone.TabIndex = 14
        Me.lblTelefone.Text = "Telefone:"
        Me.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(109, 108)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(553, 20)
        Me.txtEndereco.TabIndex = 4
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(39, 109)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(67, 16)
        Me.lblEndereco.TabIndex = 12
        Me.lblEndereco.Text = "Endereço:"
        Me.lblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Feminino", "Masculino", "Outros"})
        Me.cboSexo.Location = New System.Drawing.Point(310, 76)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(148, 21)
        Me.cboSexo.TabIndex = 2
        '
        'cboTurno
        '
        Me.cboTurno.FormattingEnabled = True
        Me.cboTurno.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite", "Madrugada"})
        Me.cboTurno.Location = New System.Drawing.Point(109, 178)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(148, 21)
        Me.cboTurno.TabIndex = 7
        '
        'dtpData_contratacao
        '
        Me.dtpData_contratacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpData_contratacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData_contratacao.Location = New System.Drawing.Point(310, 178)
        Me.dtpData_contratacao.Name = "dtpData_contratacao"
        Me.dtpData_contratacao.Size = New System.Drawing.Size(148, 20)
        Me.dtpData_contratacao.TabIndex = 8
        Me.dtpData_contratacao.Value = New Date(2021, 8, 21, 0, 0, 0, 0)
        '
        'mtbTelefone
        '
        Me.mtbTelefone.Location = New System.Drawing.Point(109, 141)
        Me.mtbTelefone.Mask = "(00) 00000-0000"
        Me.mtbTelefone.Name = "mtbTelefone"
        Me.mtbTelefone.Size = New System.Drawing.Size(148, 20)
        Me.mtbTelefone.TabIndex = 5
        Me.mtbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtbCPF
        '
        Me.mtbCPF.Location = New System.Drawing.Point(514, 77)
        Me.mtbCPF.Mask = "000,000,000-00"
        Me.mtbCPF.Name = "mtbCPF"
        Me.mtbCPF.Size = New System.Drawing.Size(148, 20)
        Me.mtbCPF.TabIndex = 3
        Me.mtbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvFuncionarios
        '
        Me.dgvFuncionarios.AllowUserToAddRows = False
        Me.dgvFuncionarios.AllowUserToDeleteRows = False
        Me.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuncionarios.Location = New System.Drawing.Point(13, 236)
        Me.dgvFuncionarios.Name = "dgvFuncionarios"
        Me.dgvFuncionarios.ReadOnly = True
        Me.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFuncionarios.Size = New System.Drawing.Size(808, 209)
        Me.dgvFuncionarios.TabIndex = 23
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNovo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Location = New System.Drawing.Point(42, 12)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 9
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalvar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(123, 12)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Orange
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(204, 12)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Red
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExcluir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(288, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'rbtNome
        '
        Me.rbtNome.AutoSize = True
        Me.rbtNome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNome.Location = New System.Drawing.Point(621, 43)
        Me.rbtNome.Name = "rbtNome"
        Me.rbtNome.Size = New System.Drawing.Size(54, 18)
        Me.rbtNome.TabIndex = 28
        Me.rbtNome.TabStop = True
        Me.rbtNome.Text = "Nome"
        Me.rbtNome.UseVisualStyleBackColor = True
        '
        'rbtCPF
        '
        Me.rbtCPF.AutoSize = True
        Me.rbtCPF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCPF.Location = New System.Drawing.Point(722, 43)
        Me.rbtCPF.Name = "rbtCPF"
        Me.rbtCPF.Size = New System.Drawing.Size(47, 18)
        Me.rbtCPF.TabIndex = 29
        Me.rbtCPF.TabStop = True
        Me.rbtCPF.Text = "CPF"
        Me.rbtCPF.UseVisualStyleBackColor = True
        '
        'mtbBusca_CPF
        '
        Me.mtbBusca_CPF.Location = New System.Drawing.Point(621, 17)
        Me.mtbBusca_CPF.Mask = "000,000,000-00"
        Me.mtbBusca_CPF.Name = "mtbBusca_CPF"
        Me.mtbBusca_CPF.Size = New System.Drawing.Size(148, 20)
        Me.mtbBusca_CPF.TabIndex = 0
        Me.mtbBusca_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(811, 220)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 31
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(746, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 14)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Total:"
        '
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(833, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.mtbBusca_CPF)
        Me.Controls.Add(Me.rbtCPF)
        Me.Controls.Add(Me.rbtNome)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dgvFuncionarios)
        Me.Controls.Add(Me.mtbCPF)
        Me.Controls.Add(Me.mtbTelefone)
        Me.Controls.Add(Me.dtpData_contratacao)
        Me.Controls.Add(Me.cboTurno)
        Me.Controls.Add(Me.cboSexo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblDataContratação)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtBuscar_Nome)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(849, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(849, 489)
        Me.Name = "frmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionarios"
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar_Nome As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents lblCPF As Label
    Friend WithEvents lblTurno As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lblDataContratação As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents cboSexo As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cboTurno As ComboBox
    Friend WithEvents dtpData_contratacao As DateTimePicker
    Friend WithEvents mtbTelefone As MaskedTextBox
    Friend WithEvents mtbCPF As MaskedTextBox
    Friend WithEvents dgvFuncionarios As DataGridView
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button

    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        dtpData_contratacao.Value = Now
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

            da = New SqlDataAdapter("SELECT * FROM FUNCIONARIOS", conectar) 'da: carregar informarções da tabela, 
            da.Fill(dt) 'fill: preenche o datagrid
            dgvFuncionarios.DataSource = dt

            FormatarDg()
            ContarLinhas()


        Catch ex As Exception
            MessageBox.Show("erro ao listar " + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDg()
        dgvFuncionarios.Columns(0).Visible = False
        dgvFuncionarios.Columns(8).Visible = False

        dgvFuncionarios.Columns(1).HeaderText = "Nome"
        dgvFuncionarios.Columns(2).HeaderText = "Sexo"
        dgvFuncionarios.Columns(3).HeaderText = "Endereço"
        dgvFuncionarios.Columns(4).HeaderText = "Telefone"
        dgvFuncionarios.Columns(5).HeaderText = "Email"
        dgvFuncionarios.Columns(6).HeaderText = "Turno"
        dgvFuncionarios.Columns(7).HeaderText = "Data Contratação"
        dgvFuncionarios.Columns(8).HeaderText = "CPF"

        dgvFuncionarios.Columns(5).Width = 130
        dgvFuncionarios.Columns(6).Width = 80




    End Sub

    Private Sub DesabilitarCampos()
        txtNome.Enabled = False
        cboSexo.Enabled = False
        mtbCPF.Enabled = False
        txtEndereco.Enabled = False
        mtbTelefone.Enabled = False
        txtEmail.Enabled = False
        cboTurno.Enabled = False
        dtpData_contratacao.Enabled = False


    End Sub

    Private Sub HabilitarCampos()
        txtNome.Enabled = True
        cboSexo.Enabled = True
        mtbCPF.Enabled = True
        txtEndereco.Enabled = True
        mtbTelefone.Enabled = True
        txtEmail.Enabled = True
        cboTurno.Enabled = True
        dtpData_contratacao.Enabled = True

    End Sub

    Private Sub Limpar()
        txtNome.Text = ""
        cboSexo.Text = ""
        mtbCPF.Text = ""
        txtEndereco.Text = ""
        mtbTelefone.Text = ""
        txtEmail.Text = ""
        cboTurno.Text = ""
        txtBuscar_Nome.Text = ""
        dtpData_contratacao.Value = Now
        dgvFuncionarios.Text = ""
    End Sub

    Friend WithEvents rbtNome As RadioButton
    Friend WithEvents rbtCPF As RadioButton
    Friend WithEvents mtbBusca_CPF As MaskedTextBox

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True

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

    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If mtbCPF.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("SP_SALVARFUNC", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@SEXO", cboSexo.Text)
                cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@TELEFONE", mtbTelefone.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                cmd.Parameters.AddWithValue("@TURNO", cboTurno.Text)
                cmd.Parameters.AddWithValue("@DATA_CONTRATADO", dtpData_contratacao.Text)
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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand

        If mtbCPF.Text <> "" And txtNome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("SP_EDITARFUNC", conectar)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@SEXO", cboSexo.Text)
                cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@TELEFONE", mtbTelefone.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                cmd.Parameters.AddWithValue("@TURNO", cboTurno.Text)
                cmd.Parameters.AddWithValue("@DATA_CONTRATADO", dtpData_contratacao.Text)
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

    Private Sub dgvFuncionarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionarios.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()
        mtbCPF.Enabled = False

        txtNome.Text = dgvFuncionarios.CurrentRow.Cells(1).Value
        cboSexo.Text = dgvFuncionarios.CurrentRow.Cells(2).Value
        txtEndereco.Text = dgvFuncionarios.CurrentRow.Cells(3).Value
        mtbTelefone.Text = dgvFuncionarios.CurrentRow.Cells(4).Value
        txtEmail.Text = dgvFuncionarios.CurrentRow.Cells(5).Value
        cboTurno.Text = dgvFuncionarios.CurrentRow.Cells(6).Value
        dtpData_contratacao.Text = dgvFuncionarios.CurrentRow.Cells(7).Value
        mtbCPF.Text = dgvFuncionarios.CurrentRow.Cells(8).Value
    End Sub

    Private Sub mtbBusca_CPF_TextChanged(sender As Object, e As EventArgs) Handles mtbBusca_CPF.TextChanged
        If mtbBusca_CPF.Text = "   .   .   -" And dgvFuncionarios.Rows.Count > 0 Then
            Listar()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("sp_buscarFuncCpf", conectar) 'da: carrega informações da tabela com base no cpf 

                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@CPF", mtbBusca_CPF.Text)

                da.Fill(dt) 'fill: preenche o datagrid
                dgvFuncionarios.DataSource = dt


                ContarLinhas()


            Catch ex As Exception
                MessageBox.Show("erro ao listar " + ex.Message)
                fechar()
            End Try

        End If
    End Sub

    Private Sub ContarLinhas()

        Dim total As Integer = dgvFuncionarios.Rows.Count
        lblTotal.Text = CInt(total)
    End Sub

    Private Sub txtBuscar_Nome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar_Nome.TextChanged
        If txtBuscar_Nome.Text = "" And dgvFuncionarios.Rows.Count > 0 Then
            Listar()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()

                da = New SqlDataAdapter("sp_buscarFuncNome", conectar) 'da: carrega informações da tabela com base no cpf 

                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NOME", txtBuscar_Nome.Text)

                da.Fill(dt) 'fill: preenche o datagrid
                dgvFuncionarios.DataSource = dt


                ContarLinhas()


            Catch ex As Exception
                MessageBox.Show("erro ao listar " + ex.Message)
                fechar()
            End Try

        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If mtbCPF.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_excluirFunc", conectar)
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
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub


End Class
