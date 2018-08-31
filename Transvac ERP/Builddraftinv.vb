Public Class Builddraftinv
    Private Sub Builddraftinv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.quotedetail' table. You can move, or remove it, as needed.
        Me.QuotedetailTableAdapter.Fill(Me.TransvacDataV2DataSet1.quotedetail)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.trandesc' table. You can move, or remove it, as needed.
        Me.TrandescTableAdapter.Fill(Me.TransvacDataV2DataSet1.trandesc)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.tranbins' table. You can move, or remove it, as needed.
        Me.TranbinsTableAdapter.Fill(Me.TransvacDataV2DataSet1.tranbins)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.qictrl' table. You can move, or remove it, as needed.
        Me.QictrlTableAdapter.Fill(Me.TransvacDataV2DataSet1.qictrl)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.invline' table. You can move, or remove it, as needed.
        Me.InvlineTableAdapter.Fill(Me.TransvacDataV2DataSet1.invline)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.binalloc' table. You can move, or remove it, as needed.
        Me.BinallocTableAdapter.Fill(Me.TransvacDataV2DataSet1.binalloc)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.invtrans' table. You can move, or remove it, as needed.
        Me.InvtransTableAdapter.Fill(Me.TransvacDataV2DataSet1.invtrans)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.invwork' table. You can move, or remove it, as needed.
        Me.InvworkTableAdapter.Fill(Me.TransvacDataV2DataSet1.invwork)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub QuotedetailBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles QuotedetailBindingSource.CurrentChanged

    End Sub
End Class