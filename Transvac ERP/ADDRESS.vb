Public Class Form2
    Private Sub addbut_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) _
                          Handles addbut.Click
        ' Show the form as a modaless window.
        REM Dim x As address = New address
        REM x.Show()
    End Sub

    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub quitbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitbut.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub mainbut_Click(sender As Object, e As EventArgs) Handles mainbut.Click
        Me.Close()
    End Sub

    Private Sub addtb_TextChanged(sender As Object, e As EventArgs) Handles addtb.TextChanged

    End Sub
End Class
