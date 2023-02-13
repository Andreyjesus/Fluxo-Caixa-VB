Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim login As String = txtLogin.Text
        Dim password As String = mtbPassword.Text



        If login = "" Or password = "" Then
            MsgBox("Preencha os campos")
            lblAviso.Text = "Preencha os campos"
        Else

            Dim cmd As New SqlCommand("login", conectar)

            Try
                abrir()

                cmd.CommandType = 4

                With cmd.Parameters
                    .AddWithValue("@NOME", login)
                    .AddWithValue("@CPF", password)
                    .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                userName = txtLogin.Text

                Dim msg As String = cmd.Parameters("@msg").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados incorretos") Then
                    txtLogin.Clear()
                    mtbPassword.Clear()
                    txtLogin.Focus()
                Else
                    Dim form = New frmPrincipal
                    Me.Hide()
                    form.ShowDialog()
                End If

            Catch ex As Exception
                MessageBox.Show("erro ao listar " + ex.Message)
                fechar()
            End Try

        End If



    End Sub
End Class
