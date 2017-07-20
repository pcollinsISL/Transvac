Public Class updatemem
    Private addressbook As Object
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Hide()
    End Sub

    Private Sub updatemem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.addnotes' table. You can move, or remove it, as needed.
        REM AddnotesTableAdapter.FillByMemo(TransvacDataV2DataSet1.addnotes, addressbook.ACCOUNTTextBox1.text)

    End Sub

    Private Sub AddnotesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AddnotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub MemoBox_TextChanged(sender As Object, e As EventArgs) Handles MemoBox.TextChanged

    End Sub
End Class