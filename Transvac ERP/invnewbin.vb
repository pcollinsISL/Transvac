Public Class invnewbin
    Private Sub aboutbtn_Click(sender As Object, e As EventArgs) Handles aboutbtn.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Inventory As New Inventory
        Inventory.TopLevel = False
        Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
        Inventory.Show()
        Me.Close()
    End Sub

    Private Sub invnewbin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Me.Validate()
        Me.TranbinsBindingSource.EndEdit()
        Me.TranbinsTableAdapter.Update(Me.TransvacDataV2DataSet1)
    End Sub
End Class