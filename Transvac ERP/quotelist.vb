Public Class quotelist
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abort_but.Click
        Me.Hide()
    End Sub

    Private Sub quotelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.quotehead' table. You can move, or remove it, as needed.
        quotenotextbox.Text = enquiry.addvar
        Me.QuoteheadTableAdapter.FillByQuotes(Me.TransvacDataV2DataSet1.quotehead, quotenotextbox.Text)
    End Sub

    Private Sub QuoteheadBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub newqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newqu_but.Click
        'Show the forms as a modaless window.
        Dim x As quote = New quote
        x.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles editqu_but.Click
        Dim x As quote = New quote
        x.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delqut_but.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles quotenotextbox.TextChanged

    End Sub
End Class