Public Class BAEFORM

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles rdddt.ValueChanged

    End Sub
    Dim ExitYN As System.Windows.Forms.DialogResult
    Public Property PrintForm1 As Object
    Public Property PrintForm2 As Object

    Private Sub quitbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TextBox6_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub printbut_Click(sender As Object, e As EventArgs) Handles printbut.Click
        PrintDocument1.Print()

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub printpwbut_Click(sender As Object, e As EventArgs) Handles printpwbut.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
    End Sub

    Private Sub printbut_Click_1(sender As Object, e As EventArgs) Handles printbut.Click

    End Sub

    Private Sub fromtb_TextChanged(sender As Object, e As EventArgs) Handles fromtb.TextChanged

    End Sub

    Private Sub totb_TextChanged(sender As Object, e As EventArgs) Handles totb.TextChanged

    End Sub

    Private Sub demantb_TextChanged(sender As Object, e As EventArgs) Handles demandtb1.TextChanged

    End Sub

    Private Sub descptb_TextChanged(sender As Object, e As EventArgs) Handles descptb.TextChanged

    End Sub

    Private Sub piecetb_TextChanged(sender As Object, e As EventArgs) Handles piecetb.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
