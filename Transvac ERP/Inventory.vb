Public Class Inventory
    Private Sub TrandescBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TrandescBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub

    Private Function TableAdapterManager() As Object
        Throw New NotImplementedException()
    End Function

    Private Function TrandescBindingSource() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TrandescTableAdapter1.Fill(Me.TransvacDataV2DataSet1.trandesc)
    End Sub

    Private Function TrandescTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles markup_but.Click

    End Sub

    Private Sub PcodeLook_Click(sender As Object, e As EventArgs) Handles PcodeLook.Click, PcodeTextBox1.TextChanged
        Me.TrandescTableAdapter1.FillByPcodelookup(Me.TransvacDataV2DataSet1.trandesc, PcodeTextBox1.Text)
    End Sub

    Private Sub TrandescBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TrandescBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TrandescBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub

    Private Sub Movenxt_Click(sender As Object, e As EventArgs) Handles Movenxt.Click
        Me.TrandescBindingSource1.MoveNext()
    End Sub

    Private Sub MovePrev_Click(sender As Object, e As EventArgs) Handles MovePrev.Click
        Me.TrandescBindingSource1.MovePrevious()
    End Sub

    Private Sub MoveStr_Click(sender As Object, e As EventArgs) Handles MoveStr.Click
        Me.TrandescBindingSource1.MoveFirst()
    End Sub

    Private Sub MoveEnd_Click(sender As Object, e As EventArgs) Handles MoveEnd.Click
        Me.TrandescBindingSource1.MoveLast()
    End Sub
End Class