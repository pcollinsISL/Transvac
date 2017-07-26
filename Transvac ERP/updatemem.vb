Public Class updatemem
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        form1.Refresh()
        form1.Show()
        form1.ADDMEMOTextBox.Text = MemoBox.Text
        Me.Hide()
    End Sub

    Private Sub updatemem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddnotesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MemoBox_TextChanged(sender As Object, e As EventArgs) Handles MemoBox.TextChanged

    End Sub

    Private Sub AddnotesBindingNavigator1SaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs)

    End Sub
End Class