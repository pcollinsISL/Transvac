﻿Public Class Quotefdesc
    Private Sub Quotefdesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_but_Click(sender As Object, e As EventArgs) Handles Button2_but.Click
        Me.TrandescTableAdapter1.FillByDesc(Me.TransvacDataV2DataSet1.trandesc, acctextBox.Text)
    End Sub

    Private Function TrandescTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quote As New quote
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage4
        quote.TopLevel = False
        quote.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(3).Controls.Add(quote)
        quote.partno_tb.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        quote.descrip_tb.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        quote.Show()
        Me.Close()
    End Sub

    Private Sub acctabt_but_Click(sender As Object, e As EventArgs) Handles acctabt_but.Click
        Me.Hide()
    End Sub
End Class