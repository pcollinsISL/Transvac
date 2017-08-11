Public Class Terms
    Private Sub termsabt_but_Click(sender As Object, e As EventArgs) Handles termsabt_but.Click
        Dim response As Integer
        response = MsgBox(Prompt:="All changes to wording will be lost. Are you sure you want to Abort?", Buttons:=vbYesNo)
        If response = vbYes Then
            Me.Hide()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub termssve_but_Click(sender As Object, e As EventArgs) Handles termssve_but.Click

End Sub

    Private Sub terms_tb_TextChanged(sender As Object, e As EventArgs) Handles terms_tb.TextChanged

    End Sub
End Class