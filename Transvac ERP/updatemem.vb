Public Class updatemem
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage2
        Dim from1 As New form1
        form1.TopLevel = False
        form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(form1)
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