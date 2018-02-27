Public Class invoicemain
    Private Sub InvworkBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.InvworkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub invoicemain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.invwork' table. You can move, or remove it, as needed.
        Me.InvworkTableAdapter.Fill(Me.TransvacDataV2DataSet1.invwork)

    End Sub
End Class