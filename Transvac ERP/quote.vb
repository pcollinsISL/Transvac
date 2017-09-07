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
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.trandesc' table. You can move, or remove it, as needed.
        REM Me.TrandescTableAdapter.Fill(Me.TransvacDataV2DataSet1.trandesc)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.quotehead' table. You can move, or remove it, as needed.
        REM  Me.QuoteheadTableAdapter.Fill(Me.TransvacDataV2DataSet.quotehead)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.tranbins' table. You can move, or remove it, as needed.
        REM Me.TranbinsTableAdapter.Fill(Me.TransvacDataV2DataSet.tranbins)
        Me.QuotedetailTableAdapter.FillByQuoteSuf(Me.TransvacDataV2DataSet.quotedetail, qute_tb.Text, SuffixTB.Text)
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.tranmemo' table. You can move, or remove it, as needed.
        REM Me.TranmemoTableAdapter.Fill(Me.TransvacDataV2DataSet.tranmemo)

    End Sub

    Private Function TranmemoTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles qty_tb.TextChanged

    End Sub

    Private Sub chstock_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
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

    Private Sub Label8_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub abt_butt_Click(sender As Object, e As EventArgs) Handles abt_butt.Click
        Me.Hide()
    End Sub

    Private Sub Pcodelookup_Click(sender As Object, e As EventArgs) Handles Pcodelookup.Click, partno_tb.Leave
        Me.TrandescTableAdapter.FillByPcode(Me.TransvacDataV2DataSet1.trandesc, partno_tb.Text)
        Me.TranbinsTableAdapter.FillByIDCode(Me.TransvacDataV2DataSet.tranbins, idcode.Text)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class