Public Class namesrch
    Private Sub namesrch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.tran2' table. You can move, or remove it, as needed.
        REM Me.Tran2TableAdapter.Fill(Me.TransvacDataV2DataSet1.tran2)

    End Sub

    Private Sub fndabt_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fndabt_but.Click
        Me.Hide()
    End Sub
    Private Sub namesrch_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles namesrch_but.Click
        Me.Tran2TableAdapter.FillByName(Me.TransvacDataV2DataSet1.tran2, NameBox.Text)
    End Sub

End Class