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
        Me.MarkupTableAdapter.Fill(Me.TransvacDataV2DataSet1.markup)
        If PcodeTextBox1.Text = "" Then
            Me.TrandescTableAdapter1.Fill(Me.TransvacDataV2DataSet1.trandesc)
            Me.TrandescTableAdapter1.Fill(Me.TransvacDataV2DataSet1.trandesc)
        Else
            Me.TrandescTableAdapter1.FillByPcodelookup(Me.TransvacDataV2DataSet1.trandesc, PcodeTextBox1.Text)
        End If
        Me.TranbinsTableAdapter.FillByIDCode(Me.TransvacDataV2DataSet1.tranbins, idcode.Text)
        Me.MarkupTableAdapter.FillBySupplier(Me.TransvacDataV2DataSet1.markup, PsupplierTextBox1.Text)
        unitvaluebox.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        markupDecimail.Text = Val(supdiscbox.Text) / 100
        unitcostsum.Text = Val(unitvaluebox.Text) * Val(markupDecimail.Text)
        unitcostbox.Text = Val(unitvaluebox.Text) - Val(unitcostsum.Text)
        markupsum.Text = Val(markupbox.Text) / 100
        retailsum.Text = Val(unitcostbox.Text) * Val(markupsum.Text)
        retailbox.Text = Val(unitcostbox.Text) + Val(retailsum.Text)
        idcode.Visible = False
        markupDecimail.Visible = False
        markupsum.Visible = False
        unitcostsum.Visible = False
        retailsum.Visible = False
    End Sub

    Private Function TrandescTableAdapter() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles markup_but.Click

    End Sub

    Private Sub PcodeLook_Click(sender As Object, e As EventArgs) Handles PcodeLook.Click, PcodeTextBox1.TextChanged

        Me.TranbinsTableAdapter.FillByIDCode(Me.TransvacDataV2DataSet1.tranbins, idcode.Text)
    End Sub

    Private Sub TrandescBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TrandescBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TrandescBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.TransvacDataV2DataSet1)
    End Sub

    Private Sub Movenxt_Click(sender As Object, e As EventArgs) Handles Movenxt.Click
        Me.TrandescBindingSource1.MoveNext()
        Me.MarkupTableAdapter.FillBySupplier(Me.TransvacDataV2DataSet1.markup, PsupplierTextBox1.Text)
        unitvaluebox.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        markupDecimail.Text = Val(supdiscbox.Text) / 100
        unitcostsum.Text = Val(unitvaluebox.Text) * Val(markupDecimail.Text)
        unitcostbox.Text = Val(unitvaluebox.Text) - Val(unitcostsum.Text)
        markupsum.Text = Val(markupbox.Text) / 100
        retailsum.Text = Val(unitcostbox.Text) * Val(markupsum.Text)
        retailbox.Text = Val(unitcostbox.Text) + Val(retailsum.Text)
    End Sub

    Private Sub MovePrev_Click(sender As Object, e As EventArgs) Handles MovePrev.Click
        Me.TrandescBindingSource1.MovePrevious()
        Me.MarkupTableAdapter.FillBySupplier(Me.TransvacDataV2DataSet1.markup, PsupplierTextBox1.Text)
        unitvaluebox.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        markupDecimail.Text = Val(supdiscbox.Text) / 100
        unitcostsum.Text = Val(unitvaluebox.Text) * Val(markupDecimail.Text)
        unitcostbox.Text = Val(unitvaluebox.Text) - Val(unitcostsum.Text)
        markupsum.Text = Val(markupbox.Text) / 100
        retailsum.Text = Val(unitcostbox.Text) * Val(markupsum.Text)
        retailbox.Text = Val(unitcostbox.Text) + Val(retailsum.Text)
    End Sub
    Private Sub MoveStr_Click(sender As Object, e As EventArgs) Handles MoveStr.Click
        Me.TrandescBindingSource1.MoveFirst()
        Me.MarkupTableAdapter.FillBySupplier(Me.TransvacDataV2DataSet1.markup, PsupplierTextBox1.Text)
        unitvaluebox.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        markupDecimail.Text = Val(supdiscbox.Text) / 100
        unitcostsum.Text = Val(unitvaluebox.Text) * Val(markupDecimail.Text)
        unitcostbox.Text = Val(unitvaluebox.Text) - Val(unitcostsum.Text)
        markupsum.Text = Val(markupbox.Text) / 100
        retailsum.Text = Val(unitcostbox.Text) * Val(markupsum.Text)
        retailbox.Text = Val(unitcostbox.Text) + Val(retailsum.Text)
    End Sub

    Private Sub MoveEnd_Click(sender As Object, e As EventArgs) Handles MoveEnd.Click
        Me.TrandescBindingSource1.MoveLast()
        Me.MarkupTableAdapter.FillBySupplier(Me.TransvacDataV2DataSet1.markup, PsupplierTextBox1.Text)
        unitvaluebox.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        markupDecimail.Text = Val(supdiscbox.Text) / 100
        unitcostsum.Text = Val(unitvaluebox.Text) * Val(markupDecimail.Text)
        unitcostbox.Text = Val(unitvaluebox.Text) - Val(unitcostsum.Text)
        markupsum.Text = Val(markupbox.Text) / 100
        retailsum.Text = Val(unitcostbox.Text) * Val(markupsum.Text)
        retailbox.Text = Val(unitcostbox.Text) + Val(retailsum.Text)
    End Sub
    Private Sub findesc_but_Click(sender As Object, e As EventArgs) Handles findesc_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Invfdesc As New Invfdesc
        Invfdesc.TopLevel = False
        Invfdesc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Invfdesc)
        Invfdesc.Show()
        Me.Hide()
    End Sub

    Private Sub editdesc_but_Click(sender As Object, e As EventArgs) Handles editdesc_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Inveditdesc As New inveditdesc
        Inveditdesc.TopLevel = False
        Inveditdesc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Inveditdesc)
        Inveditdesc.PcodeTextBox.Text = PcodeTextBox1.Text
        Inveditdesc.Show()
        Me.Hide()
    End Sub

    Private Sub newdesc_but_Click(sender As Object, e As EventArgs) Handles newdesc_but.Click
        TransPortal.TabControl1.SelectedTab = TransPortal.TabPage6
        Dim Invnewdesc As New invnewdesc
        Invnewdesc.TopLevel = False
        Invnewdesc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        TransPortal.TabControl1.TabPages(5).Controls.Add(Invnewdesc)
        Invnewdesc.Show()
        Me.Hide()
    End Sub

    Private Sub deldesc_but_Click(sender As Object, e As EventArgs) Handles deldesc_but.Click
        Try
            If MessageBox.Show("Are you sure you wish to delete this Address?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                Exit Sub
            End If
            TrandescTableAdapter1.trandescDeleteQuery(PcodeTextBox1.Text)
            MsgBox("Delete successful")
            Me.TrandescTableAdapter.Fill(Me.TransvacDataV2DataSet1.trandesc)
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table: " & ex.Message, "Deleted Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class