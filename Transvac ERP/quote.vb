Public Class quote
    Dim dt As New DataTable

    Private Sub TranmemoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TranmemoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet)
    End Sub

    Private Function TranmemoBindingSource() As Object
        Throw New NotImplementedException()
    End Function
    Private Sub quote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.QuotedetailTableAdapter.FillByQuoteSuf(Me.TransvacDataV2DataSet.quotedetail, qute_tb.Text, SuffixTB.Text)
        idcode.Visible = False
        dt.Columns.Add("qline_no")
        dt.Columns.Add("quantity")
        dt.Columns.Add("qpart_no")
        dt.Columns.Add("qdesc")
        dt.Columns.Add("qvalue")
        dt.Columns(0).AutoIncrement = True
        dt.Columns(0).AutoIncrementStep = 1
        dt.Columns(0).AutoIncrementSeed = 1


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

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        qty_tb.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        partno_tb.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        descrip_tb.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        unitprice_tb.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub header_tb_TextChanged(sender As Object, e As EventArgs) Handles header_tb.TextChanged

    End Sub

    Private Sub order_but_Click(sender As Object, e As EventArgs) Handles order_but.Click
        Dim x As InvoiceType = New InvoiceType
        x.Show()
    End Sub

    Private Sub add_but_Click(sender As Object, e As EventArgs) Handles add_but.Click
        Dim r As DataRow = dt.NewRow
        r("quantity") = qty_tb.Text
        r("qpart_no") = partno_tb.Text
        r("qdesc") = descrip_tb.Text
        r("qvalue") = unitprice_tb.Text
        dt.Rows.Add(r)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub chkstockbtn_Click(sender As Object, e As EventArgs) Handles chkstockbtn.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Inventory As New Inventory
        Inventory.TopLevel = False
        Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
        Inventory.Show()
    End Sub

    Private Sub remline_but_Click(sender As Object, e As EventArgs) Handles remline_but.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub
End Class