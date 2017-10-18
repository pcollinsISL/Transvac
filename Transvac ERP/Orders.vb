Public Class Orders

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub BinallocBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.BinallocBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FOXPROSQLDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FOXPROSQLDataSet.orddetail' table. You can move, or remove it, as needed.
        Me.OrddetailTableAdapter.Fill(Me.FOXPROSQLDataSet.orddetail)
        'TODO: This line of code loads data into the 'FOXPROSQLDataSet.binalloc' table. You can move, or remove it, as needed.
        Me.BinallocTableAdapter.Fill(Me.FOXPROSQLDataSet.binalloc)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class
