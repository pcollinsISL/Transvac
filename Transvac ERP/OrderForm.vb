Public Class OrderForm

    Private Sub OrderheadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.orderhead' table. You can move, or remove it, as needed.
        Me.OrderheadTableAdapter.Fill(Me.TransvacDataV2DataSet1.orderhead)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.orderline' table. You can move, or remove it, as needed.
        Me.OrderlineTableAdapter.Fill(Me.TransvacDataV2DataSet1.orderline)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.quotedetail' table. You can move, or remove it, as needed.
        Me.QuotedetailTableAdapter.Fill(Me.TransvacDataV2DataSet1.quotedetail)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.tranbins' table. You can move, or remove it, as needed.
        Me.TranbinsTableAdapter.Fill(Me.TransvacDataV2DataSet1.tranbins)

    End Sub

    Private Sub PARTNOTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub QTYRECTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class