Public Class Selecttype
    Private Sub click_Click(sender As Object, e As EventArgs) Handles click.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage4
        Dim customerdetails As New CustomerDetails
        customerdetails.TopLevel = False
        customerdetails.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(3).Controls.Add(customerdetails)
        customerdetails.accountnum.Text = Accountno.Text
        customerdetails.Show()
        Me.Close()
    End Sub
End Class

