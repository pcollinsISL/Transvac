Public Class TransPortal
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EnquiryBTN_Click(sender As Object, e As EventArgs) Handles EnquiryBTN.Click
        TabControl1.SelectedTab = TabPage1
        Dim enqmain As New enqmain
        enqmain.TopLevel = False
        enqmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(0).Controls.Add(enqmain)
        enqmain.Show()
    End Sub

    Private Sub AddressbookBTN_Click(sender As Object, e As EventArgs) Handles AddressbookBTN.Click
        Dim form1 As New form1
        TabControl1.SelectedTab = TabPage2
        form1.TopLevel = False
        form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(1).Controls.Add(form1)
        form1.Show()
    End Sub

    Private Sub InvoicingBTN_Click(sender As Object, e As EventArgs) Handles InvoicingBTN.Click
        Dim invoicemain As New invoicemain
        TabControl1.SelectedTab = TabPage4
        invoicemain.TopLevel = False
        invoicemain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(3).Controls.Add(invoicemain)
        invoicemain.Show()
    End Sub

    Private Sub TabPage1_Click_1(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles InventoryBttn.Click
        TabControl1.SelectedTab = TabPage6
        Dim Inventory As New Inventory
        Inventory.TopLevel = False
        Inventory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(5).Controls.Add(Inventory)
        Inventory.Show()
    End Sub


    Private Sub orders_but_Click(sender As Object, e As EventArgs) Handles OrdersBTN.Click
        TabControl1.SelectedTab = TabPage7()
        Dim quote As New quote
        OrderForm.TopLevel = False
        OrderForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.TabControl1.TabPages(6).Controls.Add(OrderForm)
        OrderForm.Show()
    End Sub

    Private Function TabPage7() As TabPage
        Throw New NotImplementedException()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class