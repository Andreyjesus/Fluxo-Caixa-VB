Imports System.Data.SqlClient

Module Conexao
    Public conectar As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SistemaVB;Data Source=LAPTOP-F3TQGP4H")

    Sub abrir()
        If conectar.State = 0 Then 'verifica se estado da conexão é igual a 0 se sim então ele abre a conexão 
            conectar.Open()
        End If
    End Sub

    Sub fechar()
        If conectar.State = 1 Then 'verifica se estado da conexão é igual a 1 se sim então ele fecha a conexão
            conectar.Close()
        End If
    End Sub

    Public userName As String

End Module
