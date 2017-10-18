Public Class OrderForm

    Private Sub OrderheadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.OrderheadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FOXPROSQLDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.trandesc' table. You can move, or remove it, as needed.
        Me.TrandescTableAdapter.Fill(Me.TransvacDataV2DataSet1.trandesc)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.tranbins' table. You can move, or remove it, as needed.
        Me.TranbinsTableAdapter.Fill(Me.TransvacDataV2DataSet.tranbins)
        'TODO: This line of code loads data into the 'FOXPROSQLDataSet.orddetail' table. You can move, or remove it, as needed.
        Me.OrddetailTableAdapter.Fill(Me.FOXPROSQLDataSet.orddetail)
        'TODO: This line of code loads data into the 'FOXPROSQLDataSet.orderline' table. You can move, or remove it, as needed.
        Me.OrderlineTableAdapter.Fill(Me.FOXPROSQLDataSet.orderline)
        'TODO: This line of code loads data into the 'FOXPROSQLDataSet.orderhead' table. You can move, or remove it, as needed.
        Me.OrderheadTableAdapter.Fill(Me.FOXPROSQLDataSet.orderhead)

    End Sub

    Private Sub PARTNOTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub QTYRECTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class