Public Class inveditbin
    Private Sub TranbinsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TranbinsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub

    Private Sub inveditbin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TranbinsTableAdapter.FillByIDCode(Me.TransvacDataV2DataSet1.tranbins, idcode.Text)
        idcode.Visible = False
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TranbinsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub
End Class