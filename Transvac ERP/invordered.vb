Public Class invordered
    Private Sub QuotedetailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.QuotedetailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub invordered_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.orddetail' table. You can move, or remove it, as needed.
        Me.OrddetailTableAdapter.FillByPcode(Me.TransvacDataV2DataSet1.orddetail, pcode.Text)
        pcode.Visible = False
        Dim total As Integer
        For Each row As DataGridViewRow In OrddetailDataGridView.Rows
            total += row.Cells("Ordered").Value
        Next
        totalordered.Text = total
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Inventory As New Inventory
        Inventory.TopLevel = False
        Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
        Inventory.Show()
        Me.Close()
    End Sub
End Class