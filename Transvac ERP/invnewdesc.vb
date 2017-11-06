Public Class invnewdesc
    Private Sub invnewdesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.trandesc' table. You can move, or remove it, as needed.
        Me.TrandescTableAdapter.Fill(Me.TransvacDataV2DataSet1.trandesc)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim response As Integer
        response = MsgBox(Prompt:="All changes to wording will be lost. Are you sure you want to Abort?", Buttons:=vbYesNo)
        If response = vbYes Then
            Me.Hide()
        End If
    End Sub
End Class