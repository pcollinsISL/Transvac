Public Class Invfdesc
    Private Sub acctabt_but_Click(sender As Object, e As EventArgs) Handles acctabt_but.Click
        Me.Hide()
    End Sub

    Private Sub TrandescBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TrandescBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub Invfdesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.trandesc' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button2_but_Click(sender As Object, e As EventArgs) Handles searchbutt.Click
        Me.TrandescTableAdapter.FillByDesc(Me.TransvacDataV2DataSet1.trandesc, acctextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Selectbtn.Click
        Dim inventory As New Inventory
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        inventory.TopLevel = False
        inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(inventory)
        inventory.PcodeTextBox1.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        inventory.Show()
        Me.Close()
    End Sub
End Class