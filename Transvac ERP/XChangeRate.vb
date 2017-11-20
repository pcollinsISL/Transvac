Public Class XChangeRate
    Private Sub CountryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CountryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub XChangeRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.country' table. You can move, or remove it, as needed.
        Me.CountryTableAdapter.Fill(Me.TransvacDataV2DataSet1.country)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles abortbtn.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Inventory As New Inventory
        Inventory.TopLevel = False
        Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
        Inventory.Show()
        Me.Close()
    End Sub
End Class