Public Class accountsrch

    Private Sub accountsrh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub acctabt_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acctabt_but.Click
        Me.Hide()
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage2
        Dim form1 As New form1
        form1.TopLevel = False
        form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(1).Controls.Add(form1)
        form1.Show()
    End Sub

    Private Sub Button2_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2_but.Click
        Me.Tran2TableAdapter.FillByAccountID(Me.TransvacDataV2DataSet1.tran2, acctextBox.Text)
    End Sub

    Private Sub Tran2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub accountsrch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tran2TableAdapter1.Fill(Me.ADDRESSBKDataSet.tran2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As form1 = form1
        form1.ACCOUNTTextBox1.Text = Tran2DataGridView.Item(1, Tran2DataGridView.CurrentRow.Index).Value
        form1.Tran2TableAdapter.FillByAccountNumber(Me.ADDRESSBKDataSet.tran2, form1.ACCOUNTTextBox1.Text)
        Me.Hide()
        x.Show()
    End Sub

    Private Sub acctextBox_TextChanged(sender As Object, e As EventArgs) Handles acctextBox.TextChanged

    End Sub
End Class
