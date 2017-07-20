Public Class form1
    Private Sub Tran2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tran2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tran2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)

    End Sub

    Private Sub Addressbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.addnotes' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'ADDRESSBKDataSet.tran2' table. You can move, or remove it, as needed.
        Me.Tran2TableAdapter.Fill(Me.ADDRESSBKDataSet.tran2)
        Me.AddnotesTableAdapter.FillByMemo(Me.TransvacDataV2DataSet1.addnotes, ACCOUNTTextBox1.Text)
    End Sub

    Private Sub newbut_Click(sender As Object, e As EventArgs) Handles newbut.Click
        Me.Tran2BindingSource.AddNew()
    End Sub

    Private Sub but6_Click(sender As Object, e As EventArgs) Handles but6.Click
        Me.Tran2BindingSource.MoveNext()
        Me.AddnotesTableAdapter.FillByMemo(Me.TransvacDataV2DataSet1.addnotes, ACCOUNTTextBox1.Text)
    End Sub

    Private Sub but4_Click(sender As Object, e As EventArgs) Handles but4.Click
        Me.Tran2BindingSource.MoveFirst()
        Me.AddnotesTableAdapter.FillByMemo(Me.TransvacDataV2DataSet1.addnotes, ACCOUNTTextBox1.Text)
    End Sub

    Private Sub but5_Click(sender As Object, e As EventArgs) Handles but5.Click
        Me.Tran2BindingSource.MovePrevious()
        Me.AddnotesTableAdapter.FillByMemo(Me.TransvacDataV2DataSet1.addnotes, ACCOUNTTextBox1.Text)
    End Sub

    Private Sub but7_Click(sender As Object, e As EventArgs) Handles but7.Click
        Me.Tran2BindingSource.MoveLast()
        Me.AddnotesTableAdapter.FillByMemo(Me.TransvacDataV2DataSet1.addnotes, ACCOUNTTextBox1.Text)
    End Sub

    Private Sub delbut_Click(sender As Object, e As EventArgs) Handles delbut.Click

    End Sub

    Private Sub selectbut_Click(sender As Object, e As EventArgs) Handles selectbut.Click
        Dim X As enquiry = enquiry
        enquiry.AccnoTextBox.Text = ACCOUNTTextBox1.Text
        enquiry.CnameTextBox.Text = NAMETextBox1.Text
        enquiry.Add1TextBox.Text = AD1TextBox1.Text
        enquiry.Add2TextBox.Text = AD2TextBox1.Text
        enquiry.Add3TextBox.Text = AD3TextBox.Text
        enquiry.Add4TextBox.Text = AD4TextBox.Text
        enquiry.Add5TextBox.Text = AD5TextBox.Text
        enquiry.Tel_noTextBox.Text = PHONETextBox.Text
        enquiry.Mobtel_noTextBox.Text = TELEXTextBox.Text
        enquiry.Fax_noTextBox.Text = FAXTextBox.Text
        enquiry.EmailTextBox.Text = EMAILTextBox.Text
        enquiry.EmemoTextBox.Text = ADDMEMOTextBox.Text
        Me.Hide()
        X.Show()
    End Sub

    Private Sub NAMELabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ADDMEMOTextBox_TextChanged(sender As Object, e As EventArgs) Handles ADDMEMOTextBox.TextChanged
        REM Me.AddnotesTableAdapter.FillByMemo(Me.TransvacDataV2DataSet1.addnotes, ACCOUNTTextBox1.Text)
    End Sub

    Private Sub osequencelb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles osequencelb.SelectedIndexChanged

    End Sub

    Private Sub membut_Click(sender As Object, e As EventArgs) Handles membut.Click
        Dim x As updatemem = updatemem
        REM updatemem.Memobox.Text = ADDMEMOTextBox.Text
        x.Show()
    End Sub
End Class
