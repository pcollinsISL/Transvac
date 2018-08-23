Public Class CustomerDetails
    Private Sub Tran2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tran2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)

    End Sub

    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tran2TableAdapter.FillByAccountID(Me.TransvacDataV2DataSet1.tran2, accountnum.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Compose.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage4
        Dim builddraftinv As New Builddraftinv
        builddraftinv.TopLevel = False
        builddraftinv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(3).Controls.Add(builddraftinv)
        builddraftinv.AccontNum.Text = accountnum.Text
        builddraftinv.custref.Text = custref.Text
        builddraftinv.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Me.Close()
    End Sub
End Class