Public Class enquiry
    Dim ExitYN As System.Windows.Forms.DialogResult
    Public addvar As String
    Private Sub btnabt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabt.Click
        Me.Close()
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim enqmain As New enqmain
        enqmain.TopLevel = False
        enqmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(enqmain)
        enqmain.Show()
    End Sub

    Private Sub Btnquote_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnquote.Click
        addvar = qotenoTextBox.Text
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim quotelist As New quotelist
        quotelist.TopLevel = False
        quotelist.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(quotelist)
        quotelist.Show()
        Me.Hide()
    End Sub

    Private Sub Btnquotegen_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnquotegen.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim quote As New quote
        quote.TopLevel = False
        quote.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(form1)
        quote.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAddressbook_click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Btnaddressbook.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage2
        Dim form1 As New form1
        form1.TopLevel = False
        form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(1).Controls.Add(form1)
        form1.Show()
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
        If AccnoTextBox.Text = "" Then
            Me.Tran2TableAdapter.ClearBeforeFill = True
        Else
            Me.EnquiryTableAdapter.FillByName(Me.TransvacDataV2DataSet.enquiry, CnameTextBox.Text)
        End If
    End Sub

    Private Sub Ref_noTextBox_TextChanged(sender As Object, e As EventArgs) Handles Ref_noTextBox.TextChanged

    End Sub

    Private Sub Add1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Add1TextBox.TextChanged

    End Sub

    Private Sub CnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CnameTextBox.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class


