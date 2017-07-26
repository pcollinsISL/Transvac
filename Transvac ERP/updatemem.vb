Public Class updatemem
    Private addressbook As Object
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Hide()
    End Sub

    Private Sub updatemem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ADDRESSBKDataSet.tran2' table. You can move, or remove it, as needed.
        REM Me.Tran2TableAdapter.Fill(Me.ADDRESSBKDataSet.tran2)


    End Sub

    Private Sub AddnotesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tran2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)

    End Sub

    Private Sub MemoBox_TextChanged(sender As Object, e As EventArgs) Handles MemoBox.TextChanged

    End Sub

    Private Sub AddnotesBindingNavigator1SaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tran2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Me.Validate()
        Me.Tran2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)
    End Sub
End Class