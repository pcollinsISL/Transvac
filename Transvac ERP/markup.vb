Public Class markup
    Private Sub markup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.markup' table. You can move, or remove it, as needed.
        Me.MarkupTableAdapter.Fill(Me.TransvacDataV2DataSet1.markup)

    End Sub
End Class