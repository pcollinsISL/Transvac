Public Class qheading
    Private Sub headingabt_but_Click(sender As Object, e As EventArgs) Handles headingabt_but.Click
        Dim response As Integer
        response = MsgBox(Prompt:="All changes to wording will be lost. Are you sure you want to Abort?", Buttons:=vbYesNo)
        If response = vbYes Then
            Me.Hide()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub headsve_but_Click(sender As Object, e As EventArgs) Handles headsve_but.Click
        Me.Close()
    End Sub
End Class