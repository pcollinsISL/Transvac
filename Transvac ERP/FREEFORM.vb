Public Class FREEFORM
    Public Property ContentAligment As Object

    Private Sub FREEFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub aligncb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles alighcb.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub printpwbut_Click(sender As Object, e As EventArgs) Handles printpwbut.Click

        If frrtb.Text = "" Then
            MsgBox("Please enter some Text")

        Else
            PrintPreviewDialog1.ShowDialog()
        End If


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim font1 As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(frrtb.Text, font1, Brushes.Black, 100, 100)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles printbut.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frrtb_TextChanged(sender As Object, e As EventArgs) Handles frrtb.TextChanged

    End Sub
    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub quitbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
