Public Class Inventory
    Private Sub TrandescBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TrandescBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub

    Private Function TableAdapterManager() As Object
        Throw New NotImplementedException()
    End Function

    Private Function TrandescBindingSource() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransvacDataV2DataSet1.tranbins' table. You can move, or remove it, as needed.
        Me.TranbinsTableAdapter.Fill(Me.TransvacDataV2DataSet1.tranbins)
        Me.TrandescTableAdapter1.Fill(Me.TransvacDataV2DataSet1.trandesc)
        idcode.Visible = False
    End Sub

    Private Function TrandescTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles markup_but.Click

    End Sub

    Private Sub PcodeLook_Click(sender As Object, e As EventArgs) Handles PcodeLook.Click, PcodeTextBox1.TextChanged
        REM Me.TrandescTableAdapter1.FillByPcodelookup(Me.TransvacDataV2DataSet1.trandesc, PcodeTextBox1.Text)
        Me.TranbinsTableAdapter.FillByIDCode(Me.TransvacDataV2DataSet1.tranbins, idcode.Text)
    End Sub

    Private Sub TrandescBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TrandescBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TrandescBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub

    Private Sub Movenxt_Click(sender As Object, e As EventArgs) Handles Movenxt.Click
        Me.TrandescBindingSource1.MoveNext()
    End Sub

    Private Sub MovePrev_Click(sender As Object, e As EventArgs) Handles MovePrev.Click
        Me.TrandescBindingSource1.MovePrevious()
    End Sub

    Private Sub MoveStr_Click(sender As Object, e As EventArgs) Handles MoveStr.Click
        Me.TrandescBindingSource1.MoveFirst()
    End Sub

    Private Sub MoveEnd_Click(sender As Object, e As EventArgs) Handles MoveEnd.Click
        Me.TrandescBindingSource1.MoveLast()
    End Sub

    Private Sub findesc_but_Click(sender As Object, e As EventArgs) Handles findesc_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Invfdesc As New Invfdesc
        Invfdesc.TopLevel = False
        Invfdesc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Invfdesc)
        Invfdesc.Show()
    End Sub

    Private Sub editdesc_but_Click(sender As Object, e As EventArgs) Handles editdesc_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Inveditdesc As New inveditdesc
        Inveditdesc.TopLevel = False
        Inveditdesc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inveditdesc)
        Inveditdesc.Show()
    End Sub

    Private Sub newdesc_but_Click(sender As Object, e As EventArgs) Handles newdesc_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Invnewdesc As New invnewdesc
        Invnewdesc.TopLevel = False
        Invnewdesc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Invnewdesc)
        Invnewdesc.Show()
    End Sub
End Class