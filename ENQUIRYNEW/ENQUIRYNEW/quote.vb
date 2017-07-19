Public Class quote
    Private Sub TranmemoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TranmemoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet)

    End Sub

    Private Function TranmemoBindingSource() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub quote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.tranmemo' table. You can move, or remove it, as needed.
        Me.TranmemoTableAdapter.Fill(Me.TransvacDataV2DataSet.tranmemo)

    End Sub

    Private Function TranmemoTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class