Public Class selstatus
    Private Sub discview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSetCustDisc.custdisc' table. You can move, or remove it, as needed.
        Me.CustdiscTableAdapter.Fill(Me.TransvacDataV2DataSetCustDisc.custdisc)

    End Sub

    Private Sub CustdiscBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CustdiscBindingSource.CurrentChanged

    End Sub
End Class