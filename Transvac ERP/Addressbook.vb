Public Class form1
    Private Sub Tran2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tran2BindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)
    End Sub

    Private Sub Addressbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AddressRecordTypeTableAdapter.Fill(Me.TransvacDataV2DataSet1.AddressRecordType)
        If ACCOUNTTextBox1.Text = "" Then
            Me.Tran2TableAdapter.Fill(Me.ADDRESSBKDataSet.tran2)
        Else
            Me.Tran2TableAdapter.FillByAccountNumber(Me.ADDRESSBKDataSet.tran2, ACCOUNTTextBox1.Text)
        End If
    End Sub

    Private Sub newbut_Click(sender As Object, e As EventArgs) Handles newbut.Click
        Me.Tran2BindingSource1.AddNew()
        Me.AddnotesBindingSource.AddNew()
    End Sub

    Private Sub but6_Click(sender As Object, e As EventArgs) Handles but6.Click
        Me.Tran2BindingSource1.MoveNext()
    End Sub

    Private Sub but4_Click(sender As Object, e As EventArgs) Handles but4.Click
        Me.Tran2BindingSource1.MoveFirst()
    End Sub

    Private Sub but5_Click(sender As Object, e As EventArgs) Handles but5.Click
        Me.Tran2BindingSource1.MovePrevious()
    End Sub

    Private Sub but7_Click(sender As Object, e As EventArgs) Handles but7.Click
        Me.Tran2BindingSource1.MoveLast()
    End Sub

    Private Sub delbut_Click(sender As Object, e As EventArgs) Handles delbut.Click
        Try
            If MessageBox.Show("Are you sure you wish to delete this Address?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                Exit Sub
            End If
            Me.Tran2TableAdapter.AddressDeleteQuery(ACCOUNTTextBox1.Text)
            MsgBox("Delete successful")
            Me.Tran2TableAdapter.Fill(Me.ADDRESSBKDataSet.tran2)
            Me.AddnotesTableAdapter.FillByMemo(Me.TransvacDataV2DataSet1.addnotes, ACCOUNTTextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table: " & ex.Message, "Deleted Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub selectbut_Click(sender As Object, e As EventArgs) Handles selectbut.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim enquiry As New enquiry
        enquiry.TopLevel = False
        enquiry.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(enquiry)
        enquiry.Show()
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
        enquiry.AcctComboBox.Text = EntrytypeComboBox.Text
        enquiry.termsTextBox.Text = TERMDAYSTextBox.Text
        Me.Hide()
    End Sub

    Private Sub NAMELabel_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub fndact_but_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles fndact_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage2
        Dim accountsrch As New accountsrch
        accountsrch.TopLevel = False
        accountsrch.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(1).Controls.Add(accountsrch)
        accountsrch.Show()
        Me.Hide()
    End Sub

    Private Sub fndname_but_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles fndname_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage2
        Dim namesrch As New namesrch
        namesrch.TopLevel = False
        namesrch.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(1).Controls.Add(namesrch)
        namesrch.Show()
        Me.Hide()
    End Sub

    Private Sub membut_Click(sender As Object, e As EventArgs)
        updatemem.MemoBox.Text = ADDMEMOTextBox.Text
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage2
        Dim x As updatemem = updatemem
        updatemem.TopLevel = False
        updatemem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(1).Controls.Add(updatemem)
        updatemem.Show()

    End Sub

    Private Sub abortbut_Click(sender As Object, e As EventArgs) Handles abortbut.Click
        Dim response As Integer
        response = MsgBox(Prompt:="All unsaved data will be lost are you sure you want to close?", Buttons:=vbYesNo)
        If response = vbYes Then
            Me.Hide()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub savebtn(sender As Object, e As EventArgs) Handles savebut.Click
        If NAMETextBox1.Text = "" Or
                AD1TextBox1.Text = "" Or
                AD2TextBox1.Text = "" Or
                AD3TextBox.Text = "" Or
                AD4TextBox.Text = "" Or
                PHONETextBox.Text = "" Or
                TELEXTextBox.Text = "" Or
                EMAILTextBox.Text = "" Or
                TERMDAYSTextBox.Text = "" Or
                EUROVATTextBox.Text = "" Or
                EntrytypeComboBox.Text = "" Then
            MessageBox.Show("Please complete all required fields")
        Else
            New_updDateTimePicker.Value = DateTime.Now
            Me.Validate()
            Me.Tran2BindingSource1.EndEdit()
            Me.AddnotesBindingSource1.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)
            MsgBox("Save Succsesful")
        End If
    End Sub
    Private Sub printbutton_Click(sender As Object, e As EventArgs) Handles printbutton.Click
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
    End Sub

    Private Sub ADDMEMOTextBox_TextChanged(sender As Object, e As EventArgs) Handles ADDMEMOTextBox.TextChanged

    End Sub

    Private Sub AD1TextBox1_TextChanged(sender As Object, e As EventArgs) Handles AD1TextBox1.TextChanged

    End Sub

    Private Sub EntrytypeComboBox_textChanged(sender As Object, e As EventArgs) Handles EntrytypeComboBox.TextChanged

    End Sub

    Private Sub TERMDAYSTextBox_TextChanged(sender As Object, e As EventArgs) Handles TERMDAYSTextBox.TextChanged

    End Sub

    Private Sub NAMETextBox1_TextChanged(sender As Object, e As EventArgs) Handles NAMETextBox1.TextChanged

    End Sub

    Private Sub New_updDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles New_updDateTimePicker.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
