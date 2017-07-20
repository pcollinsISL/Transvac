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

    Dim ExitYN As System.Windows.Forms.DialogResult
    'Declare Message Box '

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub btnrptby_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnrptby.Click
        'Show the fomr as a modaless window.
        Dim x As selstatus = New selstatus
        x.Show()
    End Sub

    Private Sub enqmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
