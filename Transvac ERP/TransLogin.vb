Imports System.Data.SqlClient
Public Class TransLogin
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Server= sql01; Database = TransvacDataV2; Integrated Security = true")

        Dim command As New SqlCommand("select * from users where Username = @username and Password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = username.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = password.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Username Or Password Are Invalid")

        Else

            'MessageBox.Show("Login Successfully")

            Dim Transportal As New TransPortal()
            Me.Hide()
            Transportal.Show()

        End If
    End Sub
End Class




