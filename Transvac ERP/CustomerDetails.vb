Public Class CustomerDetails
    Private Sub Tran2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tran2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.tran2' table. You can move, or remove it, as needed.
        Me.Tran2TableAdapter.FillByAccountID(Me.TransvacDataV2DataSet1.tran2, accountnum.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class