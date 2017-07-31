Public Class enquiry

    Dim ExitYN As System.Windows.Forms.DialogResult

    Private Sub btnabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabt.Click
        Me.Close()
    End Sub

    Private Sub Btnquote_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnquote.click
        'Show the fomrs as a modaless window.
        Dim x As quotelist = New quotelist
        x.Show()
    End Sub

    Private Sub Btnquotegen_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnquotegen.Click
        'Show the forms as a modaless window.
        Dim x As quote = New quote
        x.Show()
    End Sub

    Private Sub BtnAddressbook_click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BtnAddressbook.Click
        'Show the forms as a modaless window.
        Dim x As form1 = New form1
        x.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles DateCreaTextBox.TextChanged

    End Sub

    Private Sub ContactTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactTextBox.TextChanged

    End Sub

    Private Sub StatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusComboBox.SelectedIndexChanged

    End Sub

    Private Sub Btnaddressbook_Click_1(sender As Object, e As EventArgs) Handles Btnaddressbook.Click

        Me.Close()
    End Sub

    Private Sub enquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tran2TableAdapter.ClearBeforeFill = True
        Me.Tran2TableAdapter.FillByAccountID(Me.TransvacDataV2DataSet.tran2, AccnoTextBox.Text)
        Me.EnquiryTableAdapter.FillByName(Me.TransvacDataV2DataSet.enquiry, CnameTextBox.Text)
    End Sub
End Class


