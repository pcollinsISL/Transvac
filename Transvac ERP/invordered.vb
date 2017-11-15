Public Class invordered
    Private Sub QuotedetailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.QuotedetailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub invordered_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.orddetail' table. You can move, or remove it, as needed.
        Me.OrddetailTableAdapter.Fill(Me.TransvacDataV2DataSet1.orddetail)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.quotedetail' table. You can move, or remove it, as needed.
        Me.QuotedetailTableAdapter.Fill(Me.TransvacDataV2DataSet1.quotedetail)

    End Sub
End Class