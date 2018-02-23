Public Class namesrch
    Private Sub namesrch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fndabt_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fndabt_but.Click
        Me.Hide()
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage2
        Dim form1 As New form1
        form1.TopLevel = False
        form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(1).Controls.Add(form1)
        form1.Show()
    End Sub
    Private Sub Button1_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles namesrch_but.Click
        Me.Tran2TableAdapter.FillByName(Me.TransvacDataV2DataSet1.tran2, NameBox.Text)
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage2
        form1.TopLevel = False
        form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(1).Controls.Add(form1)
        form1.ACCOUNTTextBox1.Text = FNameDataGridView.Item(1, FNameDataGridView.CurrentRow.Index).Value
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub FNameDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FNameDataGridView.CellContentClick

    End Sub
End Class