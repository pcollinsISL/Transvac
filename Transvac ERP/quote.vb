Public Class quote
    Dim table As New DataTable("table")
    Dim index As Integer
    Private Sub TranmemoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TranmemoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub

    Private Function TranmemoBindingSource() As Object
        Throw New NotImplementedException()
    End Function
    Private Sub quote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SuffixTB.Text = "" Then
            Me.QuoteheadBindingSource1.AddNew()
            REM Me.QuotedetailBindingSource1.AddNew()
            qute_tb.Text = quote_nu.Text
        ElseIf Me.QuoteheadTableAdapter.FillByQuotesuf(Me.TransvacDataV2DataSet1.quotehead, qute_tb.Text) Then
            Me.QuotedetailTableAdapter.FillByQuoteSuf(Me.TransvacDataV2DataSet1.quotedetail, qute_tb.Text, SuffixTB.Text)
        End If
        quote_nu.Visible = False
        idcode.Visible = False
        accountno.Visible = False
        REM table.Columns.Add("qline_no")
        REM table.Columns.Add("quantity")
        REM line_but  table.Columns.Add("qpart_no")
        REM  table.Columns.Add("qdesc")
        REM  table.Columns.Add("qvalue")
        REM table.Columns.Add("quote_no")
        REM table.Columns.Add("quote_suf")
        REM table.Columns(0).AutoIncrement = True
        REM table.Columns(0).AutoIncrementSeed = 1
        REM DataGridView1.DataSource = table
    End Sub

    Private Function TranmemoTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles qty_tb.TextChanged

    End Sub

    Private Sub chstock_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As Inventory = New Inventory
        x.Show()
    End Sub

    Private Sub heading_but_Click(sender As Object, e As EventArgs) Handles heading_but.Click
        Dim x As Heading = New Heading
        x.Show()
    End Sub

    Private Sub delivery_but_Click(sender As Object, e As EventArgs) Handles delivery_but.Click
        Dim x As delivery = New delivery
        x.Show()
    End Sub

    Private Sub terms_but_Click(sender As Object, e As EventArgs) Handles terms_but.Click
        Dim x As Terms = New Terms
        x.Show()
    End Sub

    Private Sub signoff_but_Click(sender As Object, e As EventArgs) Handles signoff_but.Click
        Dim x As signoff = New signoff
        x.Show()
    End Sub

    Private Sub fnd_but_Click(sender As Object, e As EventArgs) Handles fndesc_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage5
        Dim quotefdesc As New Quotefdesc
        quotefdesc.TopLevel = False
        quotefdesc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(4).Controls.Add(quotefdesc)
        quotefdesc.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub abt_butt_Click(sender As Object, e As EventArgs) Handles abt_butt.Click
        Me.Hide()
    End Sub

    Private Sub Pcodelookup_Click(sender As Object, e As EventArgs) Handles Pcodelookup.Click, partno_tb.Leave
        Me.TrandescTableAdapter.FillByPcode(Me.TransvacDataV2DataSet1.trandesc, partno_tb.Text)
        Me.TranbinsTableAdapter.FillByIDCode(Me.TransvacDataV2DataSet1.tranbins, idcode.Text)
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
        qute_tb.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub header_tb_TextChanged(sender As Object, e As EventArgs) Handles header_tb.TextChanged

    End Sub

    Private Sub order_but_Click(sender As Object, e As EventArgs) Handles order_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage4
        Dim invoicetype As New InvoiceType
        invoicetype.TopLevel = False
        invoicetype.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(3).Controls.Add(invoicetype)
        invoicetype.Accountnum.Text = accountno.Text
        invoicetype.Show()
        Me.Close()
    End Sub

    Private Sub add_but_Click(sender As Object, e As EventArgs) Handles add_but.Click
        Dim rowcount As Integer = DataGridView1.Rows.Count
        Dim count As Integer = 0
        DataGridView1.DataSource.AddNew()
        REM If e.rowIndex >= 0 Then
        REM DataGridView1.Rows(e.rowindex).Cells(0).Value = e.RowIndex + 1
        REM  End If
        DataGridView1.Rows(rowcount - 1).Cells(1).Value = qty_tb.Text
        DataGridView1.Rows(rowcount - 1).Cells(2).Value = partno_tb.Text
        DataGridView1.Rows(rowcount - 1).Cells(3).Value = descrip_tb.Text
        DataGridView1.Rows(rowcount - 1).Cells(4).Value = unitprice_tb.Text
        DataGridView1.Rows(rowcount - 1).Cells(5).Value = SuffixTB.Text
        DataGridView1.Rows(rowcount - 1).Cells(6).Value = quote_nu.Text
        DataGridView1.DataSource.endedit()

        REM Me.QuotedetailBindingSource1.AddNew()
        REM DataGridView1.Rows(qdesc)
        REM Dim r As DataRow = CType(DataGridView1.DataSource, DataTable).NewRow
        REM r("quantity") = qty_tb.Text
        REM r("qpart_no") = partno_tb.Text
        REM r("qdesc") = descrip_tb.Text
        REM  r("qvalue") = unitprice_tb.Text
        REM table.Rows.Add(r)
        REM DataGridView1.DataSource = table
        REM DataGridView1.DataSource.endedit()
        REM  CType(DataGridView1.DataSource, DataTable).Rows.Add(r)
        REM Dim newRow As DataRowView = DirectCast(QuotedetailBindingSource1.AddNew(), DataRowView)
        REM newRow.BeginEdit()
        REM newRow.Row.BeginEdit()
        REM Dim r As DataRow = table.NewRow
        REM newRow("quantity") = qty_tb.Text
        REM QuotedetailBindingSource1.EndEdit()
        REM newRow("qpart_no") = partno_tb.Text
        REM newRow("qdesc") = descrip_tb.Text
        REM newRow("qvalue") = unitprice_tb.Text
        REM newRow("quote_no") = qute_tb.Text
        REM newRow("quote_suf") = SuffixTB.Text
        REM Rows.Add(newRow)
        REM newRow.Row.EndEdit()
        REM newRow.DataView.Table.Rows.Add(newRow.Row)
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

    Private Sub sve_but_Click(sender As Object, e As EventArgs) Handles sve_but.Click
        If SuffixTB.Text = "" Then
            SuffixTB.Text = "01"
        ElseIf SuffixTB.Text = "01" Then
            SuffixTB.Text = "02"
        ElseIf SuffixTB.Text = "02" Then
            SuffixTB.Text = "03"
        ElseIf SuffixTB.Text = "03" Then
            SuffixTB.Text = "04"
        ElseIf SuffixTB.Text = "04" Then
            SuffixTB.Text = "05"
        ElseIf SuffixTB.Text = "05" Then
            SuffixTB.Text = "06"
        ElseIf SuffixTB.Text = "06" Then
            SuffixTB.Text = "07"
        ElseIf SuffixTB.Text = "07" Then
            SuffixTB.Text = "08"
        ElseIf SuffixTB.Text = "08" Then
            SuffixTB.Text = "09"
        ElseIf SuffixTB.Text = "09" Then
            SuffixTB.Text = "10"
        End If
        Validate()
        Me.QuoteheadBindingSource1.EndEdit()
        Me.QuotedetailBindingSource1.EndEdit()
        Me.QuoteheadTableAdapter.Update(TransvacDataV2DataSet1)
        Me.QuotedetailTableAdapter.Update(TransvacDataV2DataSet1)
        MsgBox("Save Sucsesful")
    End Sub

    Private Sub SuffixTB_TextChanged(sender As Object, e As EventArgs) Handles SuffixTB.TextChanged

    End Sub

End Class