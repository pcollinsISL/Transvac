Public Class findquote
    Private Sub findquote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet.enquiry' table. You can move, or remove it, as needed.
        Me.EnquiryTableAdapter.Fill(Me.TransvacDataV2DataSet.enquiry)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EnquiryDataGridView.DataSource = Me.TransvacDataV2DataSet.enquiry.Select("cname like'" & TextBox1.Text & "'")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        EnquiryDataGridView.DataSource = Me.TransvacDataV2DataSet.enquiry.Select("quote_no like'" & TextBox2.Text & "'")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        EnquiryDataGridView.DataSource = Me.TransvacDataV2DataSet.enquiry.Select("ewho like'" & TextBox3.Text & "'")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        EnquiryDataGridView.DataSource = Me.TransvacDataV2DataSet.enquiry.Select("status like'" & TextBox4.Text & "'")
    End Sub

    Dim ExitYN As System.Windows.Forms.DialogResult
    'Declare Message Box '

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

