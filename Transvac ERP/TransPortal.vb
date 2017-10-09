Public Class TransPortal
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EnquiryBTN_Click(sender As Object, e As EventArgs) Handles EnquiryBTN.Click
        TabControl1.SelectedTab = TabPage1
        Dim enqmain As New enqmain
        enqmain.TopLevel = False
        enqmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(0).Controls.Add(enqmain)
        enqmain.Show()
    End Sub

    Private Sub AddressbookBTN_Click(sender As Object, e As EventArgs) Handles AddressbookBTN.Click
        Dim form1 As New form1
        TabControl1.SelectedTab = TabPage2
        form1.TopLevel = False
        form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(1).Controls.Add(form1)
        form1.Show()
    End Sub

    Private Sub InvoicingBTN_Click(sender As Object, e As EventArgs) Handles InvoicingBTN.Click
        Dim builddraftinv As New Builddraftinv
        builddraftinv.TopLevel = False
        builddraftinv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(0).Controls.Add(builddraftinv)
        builddraftinv.Show()
    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class