Public Class Inventory
    Private Sub TrandescBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TrandescBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet)

    End Sub

    Private Function TableAdapterManager() As Object
        Throw New NotImplementedException()
    End Function

    Private Function TrandescBindingSource() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.trandesc' table. You can move, or remove it, as needed.
        REM Me.TrandescTableAdapter1.Fill(Me.TransvacDataV2DataSet.trandesc)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.tranbins' table. You can move, or remove it, as needed.
        REM Me.TranbinsTableAdapter.Fill(Me.TransvacDataV2DataSet.tranbins)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.trandesc' table. You can move, or remove it, as needed.
        REM Me.TrandescTableAdapter.Fill(Me.TransvacDataV2DataSet.trandesc)

    End Sub

    Private Function TrandescTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles markup_but.Click

    End Sub

    Private Sub newdesc_but_Click(sender As Object, e As EventArgs) Handles newdesc_but.Click
        Dim x As invnewdesc = New invnewdesc
        x.Show()
    End Sub

    Private Sub editdesc_but_Click(sender As Object, e As EventArgs) Handles editdesc_but.Click
        Dim x As inveditdesc = New inveditdesc
        x.Show()
    End Sub

    Private Sub findesc_but_Click(sender As Object, e As EventArgs) Handles findesc_but.Click
        Dim x As Invfdesc = New Invfdesc
        x.Show()
    End Sub
End Class