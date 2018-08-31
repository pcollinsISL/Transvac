Public Class quote
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
            qute_tb.Text = quote_nu.Text
            quotesfx.Text = SuffixTB.Text
        ElseIf Me.QuoteheadTableAdapter.FillByQuotesuf(Me.TransvacDataV2DataSet1.quotehead, qute_tb.Text) Then
            Me.QuotedetailTableAdapter.FillByQuoteSuf(Me.TransvacDataV2DataSet1.quotedetail, qute_tb.Text, SuffixTB.Text)
        End If
        If quotesfx.Text = "" Then
            quotesfx.Text = "01"
        ElseIf quotesfx.Text = "01" Then
            quotesfx.Text = "02"
        ElseIf quotesfx.Text = "02" Then
            quotesfx.Text = "03"
        ElseIf quotesfx.Text = "03" Then
            quotesfx.Text = "04"
        ElseIf quotesfx.Text = "04" Then
            quotesfx.Text = "05"
        ElseIf quotesfx.Text = "05" Then
            quotesfx.Text = "06"
        ElseIf quotesfx.Text = "06" Then
            quotesfx.Text = "07"
        ElseIf quotesfx.Text = "07" Then
            quotesfx.Text = "08"
        ElseIf quotesfx.Text = "08" Then
            quotesfx.Text = "09"
        ElseIf quotesfx.Text = "09" Then
            quotesfx.Text = "10"
        End If
        quote_nu.Visible = False
        quotesfx.Visible = False
        idcode.Visible = False
        accountno.Visible = False
        DateTimePicker1.Visible = False
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
        DataGridView2.Item(6, DataGridView2.CurrentRow.Index).Value = Val(DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value)
        DataGridView2.Item(9, DataGridView2.CurrentRow.Index).Value = Val(DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value) * Val(DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value)
        Ext_tb.Text = qty_tb.Text * unitprice_tb.Text

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
        quotesfx.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        REM DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value = Val(DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value) * Val(DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value)
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
    Private Sub DataGridView1_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For i As Integer = e.RowIndex To (e.RowIndex + e.RowCount - 1)
            Me.DataGridView1.Rows(i).Cells(0).Value = i
        Next
    End Sub
    Private Sub add_but_Click(sender As Object, e As EventArgs) Handles add_but.Click
        Dim rowcount As Integer = DataGridView1.Rows.Count
        Dim count As Integer = 0
        DataGridView1.DataSource.AddNew()
        DataGridView1.Rows(rowcount - 1).Cells(1).Value = qty_tb.Text
        DataGridView1.Rows(rowcount - 1).Cells(2).Value = partno_tb.Text
        DataGridView1.Rows(rowcount - 1).Cells(3).Value = descrip_tb.Text
        DataGridView1.Rows(rowcount - 1).Cells(4).Value = unitprice_tb.Text
        DataGridView1.Rows(rowcount - 1).Cells(5).Value = quote_nu.Text
        DataGridView1.Rows(rowcount - 1).Cells(6).Value = quotesfx.Text
        For Each line As DataGridViewRow In DataGridView1.Rows
            line.Cells(6).Value = quotesfx.Text
        Next
        DataGridView1.DataSource.endedit()
    End Sub
    REM Private Sub chkstockbtn_Click(sender As Object, e As EventArgs) Handles chkstockbtn.Click
    REM   TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
    REM Dim Inventory As New Inventory
    REM  Inventory.TopLevel = False
    REM Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    REM TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
    REM Inventory.Show()
    REM End Sub
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

    Private Sub partno_tb_TextChanged(sender As Object, e As EventArgs) Handles partno_tb.TextChanged

    End Sub
End Class