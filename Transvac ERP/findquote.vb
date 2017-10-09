Public Class findquote
    Private Sub findquote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerBtn.Click
        Me.EnquiryTableAdapter.FillByName(Me.TransvacDataV2DataSet1.enquiry, CustomerNameBox.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.EnquiryTableAdapter.FillByQuoteNO(Me.TransvacDataV2DataSet1.enquiry, QuoteNOBox.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesPersonBtn.Click
        Me.EnquiryTableAdapter.FillBySalePer(Me.TransvacDataV2DataSet1.enquiry, SalesPersonBox.Text)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBtn.Click
        Me.EnquiryTableAdapter.FillByStatus(Me.TransvacDataV2DataSet1.enquiry, StatusBox.Text)
    End Sub

    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim enqmain As New enqmain
        enqmain.TopLevel = False
        enqmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(enqmain)
        enqmain.Show()
    End Sub

    Private Sub QuoteNObtn_Click(sender As Object, e As EventArgs) Handles QuoteNoBtn.Click
        Me.EnquiryTableAdapter.FillByQuoteNO(Me.TransvacDataV2DataSet1.enquiry, QuoteNOBox.Text)
    End Sub

    Private Sub SalesPerson(sender As Object, e As EventArgs) Handles SalesPersonBox.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CustomerNameBox.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles StatusBox.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles SelectBtn.Click
        Dim X As enquiry = enquiry
        enquiry.CnameTextBox.Text = EnquiryDataGridView.Item(0, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Ref_noTextBox.Text = EnquiryDataGridView.Item(1, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.qotenoTextBox.Text = EnquiryDataGridView.Item(2, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.StatusComboBox.Text = EnquiryDataGridView.Item(4, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.AccnoTextBox.Text = EnquiryDataGridView.Item(5, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.EmemoTextBox.Text = EnquiryDataGridView.Item(6, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Ship_nameTextBox.Text = EnquiryDataGridView.Item(7, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Tel_noTextBox.Text = EnquiryDataGridView.Item(7, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.EmailTextBox.Text = EnquiryDataGridView.Item(8, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Mobtel_noTextBox.Text = EnquiryDataGridView.Item(9, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Fax_noTextBox.Text = EnquiryDataGridView.Item(10, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Tel_noTextBox.Text = EnquiryDataGridView.Item(11, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.ContactTextBox.Text = EnquiryDataGridView.Item(12, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.DateCreaTextBox.Text = EnquiryDataGridView.Item(13, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.EtypeComboBox.Text = EnquiryDataGridView.Item(14, EnquiryDataGridView.CurrentRow.Index).Value
        Me.Hide()
        X.Show()
    End Sub

    Private Sub EnquiryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EnquiryDataGridView.CellContentClick
        Dim X As enquiry = enquiry
        enquiry.CnameTextBox.Text = EnquiryDataGridView.Item(0, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Ref_noTextBox.Text = EnquiryDataGridView.Item(1, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.qotenoTextBox.Text = EnquiryDataGridView.Item(2, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.StatusComboBox.Text = EnquiryDataGridView.Item(4, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.AccnoTextBox.Text = EnquiryDataGridView.Item(5, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.EmemoTextBox.Text = EnquiryDataGridView.Item(6, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Ship_nameTextBox.Text = EnquiryDataGridView.Item(7, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Tel_noTextBox.Text = EnquiryDataGridView.Item(7, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.EmailTextBox.Text = EnquiryDataGridView.Item(8, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Mobtel_noTextBox.Text = EnquiryDataGridView.Item(9, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Fax_noTextBox.Text = EnquiryDataGridView.Item(10, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.Tel_noTextBox.Text = EnquiryDataGridView.Item(11, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.ContactTextBox.Text = EnquiryDataGridView.Item(12, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.DateCreaTextBox.Text = EnquiryDataGridView.Item(13, EnquiryDataGridView.CurrentRow.Index).Value
        enquiry.EtypeComboBox.Text = EnquiryDataGridView.Item(14, EnquiryDataGridView.CurrentRow.Index).Value
        Me.Hide()
        X.Show()
    End Sub

    Private Sub EnquiryBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles EnquiryBindingSource.CurrentChanged

    End Sub

    Private Sub QuoteNOBox_TextChanged(sender As Object, e As EventArgs) Handles QuoteNOBox.TextChanged

    End Sub
End Class

