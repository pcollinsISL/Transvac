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
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.tranbins' table. You can move, or remove it, as needed.
        Me.TranbinsTableAdapter.Fill(Me.TransvacDataV2DataSet.tranbins)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.quotedetail' table. You can move, or remove it, as needed.
        REM Me.QuotedetailTableAdapter.Fill(Me.TransvacDataV2DataSet.quotedetail)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.tranmemo' table. You can move, or remove it, as needed.
        REM Me.TranmemoTableAdapter.Fill(Me.TransvacDataV2DataSet.tranmemo)

    End Sub

    Private Function TranmemoTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles qty_tb.TextChanged

    End Sub

    Private Sub chstock_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chstock_but.Click
        ' Show the form as a modaless window.
        Dim x As Inventory = New Inventory
        x.Show()
    End Sub

    Private Sub heading_but_Click(sender As Object, e As EventArgs) Handles heading_but.Click
        ' Show the form as a modaless window.
        Dim x As Heading = New Heading
        x.Show()
    End Sub

    Private Sub delivery_but_Click(sender As Object, e As EventArgs) Handles delivery_but.Click
        ' Show the form as a modaless window.
        Dim x As delivery = New delivery
        x.Show()
    End Sub

    Private Sub terms_but_Click(sender As Object, e As EventArgs) Handles terms_but.Click
        ' Show the form as a modaless window.
        Dim x As Terms = New Terms
        x.Show()
    End Sub

    Private Sub signoff_but_Click(sender As Object, e As EventArgs) Handles signoff_but.Click
        ' Show the form as a modaless window.
        Dim x As signoff = New signoff
        x.Show()
    End Sub

    Private Sub fnd_but_Click(sender As Object, e As EventArgs) Handles fndesc_but.Click

    End Sub
End Class