Public Class StockMovement
    Private Sub TranbinsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TranbinsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub StockMovement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.tranbins' table. You can move, or remove it, as needed.
        Me.TranbinsTableAdapter.Fill(Me.TransvacDataV2DataSet1.tranbins)

    End Sub
End Class