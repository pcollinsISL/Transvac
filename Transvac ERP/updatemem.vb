Public Class updatemem
    Private addressbook As Object
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Hide()
    End Sub

    Private Sub updatemem_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub AddnotesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AddnotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)

    End Sub

    Private Sub MemoBox_TextChanged(sender As Object, e As EventArgs) Handles MemoBox.TextChanged

    End Sub

    Private Sub AddnotesBindingNavigator1SaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AddnotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Me.Validate()
        Me.AddnotesBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)
    End Sub
End Class