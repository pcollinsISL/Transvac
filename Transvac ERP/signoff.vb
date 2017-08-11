Public Class signoff
    Private Sub signoffabt_but_Click(sender As Object, e As EventArgs) Handles signoffabt_but.Click
        Dim response As Integer
        response = MsgBox(Prompt:="All changes to wording will be lost. Are you sure you want to Abort?", Buttons:=vbYesNo)
        If response = vbYes Then
            Me.Hide()
            Exit Sub
        Else
        End If
    End Sub
End Class