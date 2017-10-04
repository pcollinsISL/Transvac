Public Class TransPortal
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub EnquiryBTN_Click(sender As Object, e As EventArgs) Handles EnquiryBTN.Click
        TabControl1.TabPages.Add("Enquiry")
        Dim enqmain As New enqmain
        enqmain.TopLevel = False
        enqmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.SelectedTab = enquiry
        Me.TabControl1.TabPages(1).Controls.Add(enqmain)
        enqmain.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Newtabbtn.Click
        REM TabPage TabPage1 = New TabPage("Tab page")
        TabControl1.TabPages.Add(TabPage1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles RemoveTabbtn.Click
        TabControl1.TabPages.Remove(TabControl1.SelectedTab)
    End Sub

    Private Sub RemoveAllTabsbtn_Click(sender As Object, e As EventArgs) Handles RemoveAllTabsbtn.Click
        TabControl1.TabPages.Clear()
    End Sub

    Private Sub AddressbookBTN_Click(sender As Object, e As EventArgs) Handles AddressbookBTN.Click
        TabControl1.TabPages.Add("AddressBook")
        Dim form1 As New form1
        form1.TopLevel = False
        form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(0).Controls.Add(form1)
        form1.Show()
    End Sub

    Private Sub InvoicingBTN_Click(sender As Object, e As EventArgs) Handles InvoicingBTN.Click
        Dim builddraftinv As New Builddraftinv
        builddraftinv.TopLevel = False
        builddraftinv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(0).Controls.Add(builddraftinv)
        builddraftinv.Show()
    End Sub
End Class