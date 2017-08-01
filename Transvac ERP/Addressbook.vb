Public Class form1

    Private Sub Tran2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tran2BindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)
    End Sub

    Private Sub Addressbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tran2TableAdapter.Fill(Me.ADDRESSBKDataSet.tran2)
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
            Tran2TableAdapter.AddressDeleteQuery(ACCOUNTTextBox1.Text)
            MsgBox("Delete successful")
            Me.Tran2TableAdapter.Fill(Me.ADDRESSBKDataSet.tran2)
            Me.AddnotesTableAdapter.FillByMemo(Me.TransvacDataV2DataSet1.addnotes, ACCOUNTTextBox1.Text)

        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table: " & ex.Message, "Deleted Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
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
        REM enquiry.EmemoTextBox.Text = ADDMEMOTextBox.Text
        enquiry.acctTextBox.Text = EntrytypeComboBox.Text
        enquiry.termsTextBox.Text = TERMDAYSTextBox.Text

        Me.Hide()
        X.Show()
    End Sub

    Private Sub NAMELabel_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub fndact_but_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles fndact_but.Click
        Dim x As accountsrch = New accountsrch
        x.Show()
        Me.Hide()
    End Sub

    Private Sub fndname_but_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles fndname_but.Click
        Dim x As namesrch = New namesrch
        x.Show()
        Me.Hide()
    End Sub

    Private Sub membut_Click(sender As Object, e As EventArgs) Handles membut.Click
        Dim x As updatemem = updatemem
        updatemem.MemoBox.Text = ADDMEMOTextBox.Text
        x.Show()
        Me.Hide()
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
        Me.Validate()
        Me.Tran2BindingSource1.EndEdit()
        Me.AddnotesBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ADDRESSBKDataSet)
        MsgBox("Save Sucsesful")
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

    Private Sub EntrytypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EntrytypeComboBox.SelectedIndexChanged

    End Sub

    Private Sub TERMDAYSTextBox_TextChanged(sender As Object, e As EventArgs) Handles TERMDAYSTextBox.TextChanged

    End Sub
End Class
