Partial Class EnquiryDataSet
    Partial Public Class enquiryDataTable
        Private Sub enquiryDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.cnameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace EnquiryDataSetTableAdapters

    Partial Public Class enquiryTableAdapter
    End Class
End Namespace
