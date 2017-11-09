Public Class invnewdesc
    Private Sub invnewdesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TrandescBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim response As Integer
        response = MsgBox(Prompt:="All changes to wording will be lost. Are you sure you want to Abort?", Buttons:=vbYesNo)
        If response = vbYes Then
            Dim Inventory As New Inventory
            Inventory.TopLevel = False
            Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
            Inventory.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        Me.Validate()
        Me.TrandescBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)
        Dim Inventory As New Inventory
        Inventory.TopLevel = False
        Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inventory)
        Inventory.PcodeTextBox1.Text = TextBox6.Text
        Inventory.Show()
        Me.Close()
    End Sub

    Private Sub TrandescBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TrandescBindingSource.CurrentChanged

    End Sub
End Class