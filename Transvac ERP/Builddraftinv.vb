Public Class Builddraftinv
    Private Sub Builddraftinv_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub custref_TextChanged(sender As Object, e As EventArgs) Handles custref.TextChanged

    End Sub

    Private Sub Pcodelookup_Click(sender As Object, e As EventArgs) Handles Pcodelookup.Click, partno_tb.Leave
        Me.TrandescTableAdapter.FillByPcode(Me.TransvacDataV2DataSet1.trandesc, partno_tb.Text)
        Me.TranbinsTableAdapter.FillByIDCode(Me.TransvacDataV2DataSet1.tranbins, idcode.Text)
    End Sub
End Class