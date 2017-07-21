Public Class accountsrch
    Private Sub acctabt_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acctabt_but.Click
        Me.Hide()
    End Sub

    Private Sub Tran2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tran2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub accountsrch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.tran2' table. You can move, or remove it, as needed.
        REM Me.Tran2TableAdapter.Fill(Me.TransvacDataV2DataSet1.tran2)

    End Sub
End Class