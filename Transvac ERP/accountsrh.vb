Public Class accountsrch

    Private Sub accountsrh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub acctabt_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acctabt_but.Click
        Me.Hide()
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

        REM form1.ACCOUNTTextBox1.Text = Tran2DataGridView.Item(1, Tran2DataGridView.CurrentRow.Index).Value
        Me.Hide()
        X.Show()
    End Sub
End Class
