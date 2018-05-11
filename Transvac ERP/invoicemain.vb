Public Class invoicemain

    Private Sub invoicemain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cwkdftbtn_Click(sender As Object, e As EventArgs) Handles cwkdftbtn.Click
        Dim x As invdraftref = New invdraftref
        x.Show()
    End Sub

    Private Sub bkinvbtn_Click(sender As Object, e As EventArgs) Handles bkinvbtn.Click
        Dim x As invbkcreditnote = New invbkcreditnote
        x.Show()
    End Sub

    Private Sub dltbtn_Click(sender As Object, e As EventArgs) Handles dltbtn.Click
        Dim x As invdeldraft = New invdeldraft
        x.Show()
    End Sub

    Private Sub revbtn_Click(sender As Object, e As EventArgs) Handles revbtn.Click
        Dim x As invrevbookinv = New invrevbookinv
        x.Show()
    End Sub

    Private Sub curinvbtn_Click(sender As Object, e As EventArgs) Handles curinvbtn.Click
        Dim x As invcurstatacc = New invcurstatacc
        x.Show()
    End Sub

    Private Sub lstpegbtn_Click(sender As Object, e As EventArgs) Handles lstpegbtn.Click
        Dim x As invcustpeg = New invcustpeg
        x.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As invrevcredit = New invrevcredit
        x.Show()
    End Sub

    Private Sub sltdftbtn_Click(sender As Object, e As EventArgs) Handles sltdftbtn.Click
        Dim x As invgencredit = New invgencredit
        x.Show()
    End Sub

    Private Sub srvebtn_Click(sender As Object, e As EventArgs) Handles srvebtn.Click
        Dim x As invsercust = New invsercust
        x.Show()
    End Sub

    Private Sub quitbtn_Click(sender As Object, e As EventArgs) Handles quitbtn.Click
        Me.Hide()
    End Sub
End Class