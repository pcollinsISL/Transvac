Public Class selstatus
    Private Sub discview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustdiscTableAdapter.Fill(Me.TransvacDataV2DataSetCustDisc.custdisc)
    End Sub
    Private Sub CustdiscBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CustdiscBindingSource.CurrentChanged
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage1
        Dim enqmain As New enqmain
        enqmain.TopLevel = False
        enqmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(0).Controls.Add(enqmain)
        enqmain.Show()
    End Sub
End Class