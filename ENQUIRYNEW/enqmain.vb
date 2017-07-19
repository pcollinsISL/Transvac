Public Class enqmain
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnneweq_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) Handles btnneweq.Click
        ' Show the form as a modaless window.
        Dim x As enquiry = New enquiry
        x.Show()
    End Sub

    Private Sub btnfindeq_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) Handles btnfindeq.Click
        ' Show the form as a modaless window.
        Dim x As findquote = New findquote
        x.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click

    End Sub
End Class
