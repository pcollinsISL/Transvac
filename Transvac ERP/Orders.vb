Public Class Orders

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub BinallocBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.orderhead' table. You can move, or remove it, as needed.
        Me.OrderheadTableAdapter.Fill(Me.TransvacDataV2DataSet1.orderhead)


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OrderheadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrderheadBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrderheadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub
End Class
