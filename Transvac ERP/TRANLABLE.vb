Public Class TRANLABLE
    Private Sub baeshbut_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) _
                          Handles baeshbut.Click
        ' Show the form as a modaless window.
        Dim x As form1 = New form1
        x.Show()
    End Sub

    Private Sub freebut_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) _
                          Handles freebut.Click
        ' Show the form as a modaless window.
        Dim x As FREEFORM = New FREEFORM
        x.Show()
    End Sub



    Private Shared Function form1() As Object
        Throw New NotImplementedException()
    End Function

    Dim ExitYN As System.Windows.Forms.DialogResult

    Private Sub quitbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitbut.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub partbut_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) _
                          Handles partbut.Click
        ' Show the form as a modaless window.
        Dim x As PARTLABEL = New PARTLABEL
        x.Show()
    End Sub

    Private Sub addbut_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) _
                          Handles addbut.Click
        ' Show the form as a modaless window.
        Dim x As Form2 = New Form2
        x.Show()
    End Sub

    Private Sub modpbut_Click(ByVal sender As System.Object,
                          ByVal e As System.EventArgs) _
                          Handles modpbut.Click
        ' Show the form as a modaless window.
        Dim x As MODFORM = New MODFORM
        x.Show()
    End Sub
End Class