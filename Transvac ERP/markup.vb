Public Class markup
    Private Sub markup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MarkupTableAdapter.Fill(Me.TransvacDataV2DataSet1.markup)

    End Sub

    Private Sub abortbtn_Click(sender As Object, e As EventArgs) Handles abortbtn.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Inventory As New Inventory
        Inventory.TopLevel = False
        Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
        Inventory.Show()
        Me.Close()
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Try
            If MessageBox.Show("Are you sure you wish to delete this Record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                Exit Sub
            End If
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            Me.MarkupTableAdapter.Update(Me.TransvacDataV2DataSet1.markup)
            MsgBox("Delete successful")
            Me.MarkupTableAdapter.Fill(Me.TransvacDataV2DataSet1.markup)
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table: " & ex.Message, "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        Me.MarkupTableAdapter.Update(Me.TransvacDataV2DataSet1.markup)
        MsgBox("Save successful")
        Me.MarkupTableAdapter.Fill(Me.TransvacDataV2DataSet1.markup)
    End Sub
End Class