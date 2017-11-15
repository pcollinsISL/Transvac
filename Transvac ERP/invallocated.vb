Public Class invallocated
    Private Sub BinallocBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.BinallocBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub invallocated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.binalloc' table. You can move, or remove it, as needed.
        Me.BinallocTableAdapter.Fill(Me.TransvacDataV2DataSet1.binalloc)

    End Sub
End Class