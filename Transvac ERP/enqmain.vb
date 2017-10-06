Public Class enqmain
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnneweq_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) Handles btnneweq.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim enquiry As New enquiry
        enquiry.TopLevel = False
        enquiry.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(enquiry)
        enquiry.Show()
        Me.Hide()
    End Sub

    Private Sub btnfindeq_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) Handles btnfindeq.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim findquote As New findquote
        findquote.TopLevel = False
        findquote.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(findquote)
        findquote.Show()
        Me.Hide()
    End Sub

    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Hide()
    End Sub
    Private Sub btnrptby_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnrptby.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim selstatus As New selstatus
        selstatus.TopLevel = False
        selstatus.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(selstatus)
        selstatus.Show()
        Me.Hide()
    End Sub

    Private Sub enqmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
