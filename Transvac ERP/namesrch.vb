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
End Class