Public Class InvoiceType
    Private Sub Accountnum_TextChanged(sender As Object, e As EventArgs) Handles Accountnum.TextChanged

    End Sub

    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage4
        Dim selecttype As New Selecttype
        selecttype.TopLevel = False
        selecttype.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(3).Controls.Add(selecttype)
        selecttype.Accountno.Text = Accountnum.Text
        selecttype.Show()
        Me.Close()
    End Sub
End Class