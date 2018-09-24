Public Class quotelist
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abort_but.Click
        Me.Hide()
    End Sub

    Private Sub quotelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.QuoteheadTableAdapter.Fill(Me.TransvacDataV2DataSet1.quotehead)
        Me.QuoteheadTableAdapter.FillByQuotes(Me.TransvacDataV2DataSet1.quotehead, quotenotextbox.Text)
        quotenotextbox.Visible = False
        accountno.Visible = False
    End Sub

    Private Sub QuoteheadBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub newqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage5
        Dim quote As New quote
        quote.TopLevel = False
        quote.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(4).Controls.Add(quote)
        quote.accountno.Text = accountno.Text
        quote.quote_nu.Text = quotenotextbox.Text
        quote.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles editqu_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage5
        Dim quote As New quote
        quote.TopLevel = False
        quote.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(4).Controls.Add(quote)
        quote.qute_tb.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        quote.quote_nu.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        quote.SuffixTB.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        quote.quotesfx.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        quote.header_tb.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        quote.accountno.Text = accountno.Text
        quote.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delqut_but.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles quotenotextbox.TextChanged

    End Sub
End Class