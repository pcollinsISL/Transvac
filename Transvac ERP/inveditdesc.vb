Public Class inveditdesc
    Private Sub TrandescBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TrandescBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub

    Private Sub inveditdesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TrandescTableAdapter.FillByPcodelookup(Me.TransvacDataV2DataSet1.trandesc, PcodeTextBox.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As Integer
        response = MsgBox(Prompt:="All changes to wording will be lost. Are you sure you want to Abort?", Buttons:=vbYesNo)
        If response = vbYes Then
            Me.Hide()
            TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
            Dim Inventory As New Inventory
            Inventory.TopLevel = False
            Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
            Inventory.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TrandescBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Inventory As New Inventory
        Inventory.TopLevel = False
        Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
        Inventory.Show()
        Me.Close()
    End Sub
End Class