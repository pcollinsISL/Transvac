Public Class PARTLABEL

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
End Class