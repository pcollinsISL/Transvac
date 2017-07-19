Public Class enquiry

    Dim ExitYN As System.Windows.Forms.DialogResult

    Private Sub btnabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabt.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub
End Class