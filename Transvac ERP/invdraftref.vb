Public Class invdraftref
    Private Sub invdraftref_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub qut_btn_Click(sender As Object, e As EventArgs) Handles qut_btn.Click
        Me.Hide()
    End Sub

    Private Sub sel_btn_Click(sender As Object, e As EventArgs) Handles sel_btn.Click
        Dim x As Selecttype = New Selecttype
        x.Show()
    End Sub
End Class