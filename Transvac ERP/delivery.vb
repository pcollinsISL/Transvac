Public Class delivery
    Private Sub delabt_but_Click(sender As Object, e As EventArgs) Handles delabt_but.Click
        Dim response As Integer
        response = MsgBox(Prompt:="All changes to wording will be lost. Are you sure you want to Abort?", Buttons:=vbYesNo)
        If response = vbYes Then
            Me.Hide()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub deliverysve_but_Click(sender As Object, e As EventArgs) Handles deliverysve_but.Click

    End Sub
End Class