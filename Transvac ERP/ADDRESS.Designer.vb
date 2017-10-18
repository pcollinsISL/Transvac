<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.custtb = New System.Windows.Forms.TextBox()
        Me.addtb = New System.Windows.Forms.TextBox()
        Me.ordtb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nolabtb = New System.Windows.Forms.TextBox()
        Me.mainbut = New System.Windows.Forms.Button()
        Me.printbut = New System.Windows.Forms.Button()
        Me.addbut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.alighcb = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.quitbut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'custtb
        '
        Me.custtb.Location = New System.Drawing.Point(167, 60)
        Me.custtb.Name = "custtb"
        Me.custtb.Size = New System.Drawing.Size(366, 22)
        Me.custtb.TabIndex = 0
        '
        'addtb
        '
        Me.addtb.Location = New System.Drawing.Point(167, 98)
        Me.addtb.Multiline = True
        Me.addtb.Name = "addtb"
        Me.addtb.Size = New System.Drawing.Size(366, 165)
        Me.addtb.TabIndex = 1
        '
        'ordtb
        '
        Me.ordtb.Location = New System.Drawing.Point(167, 288)
        Me.ordtb.Name = "ordtb"
        Me.ordtb.Size = New System.Drawing.Size(366, 22)
        Me.ordtb.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "NO OF LABLES"
        '
        'nolabtb
        '
        Me.nolabtb.Location = New System.Drawing.Point(167, 328)
        Me.nolabtb.Name = "nolabtb"
        Me.nolabtb.Size = New System.Drawing.Size(100, 22)
        Me.nolabtb.TabIndex = 56
        '
        'mainbut
        '
        Me.mainbut.Location = New System.Drawing.Point(31, 364)
        Me.mainbut.Name = "mainbut"
        Me.mainbut.Size = New System.Drawing.Size(104, 23)
        Me.mainbut.TabIndex = 58
        Me.mainbut.Text = "MAIN MENU"
        Me.mainbut.UseVisualStyleBackColor = True
        '
        'printbut
        '
        Me.printbut.Location = New System.Drawing.Point(420, 378)
        Me.printbut.Name = "printbut"
        Me.printbut.Size = New System.Drawing.Size(113, 24)
        Me.printbut.TabIndex = 59
        Me.printbut.Text = "PRINT LABEL"
        Me.printbut.UseVisualStyleBackColor = True
        '
        'addbut
        '
        Me.addbut.Location = New System.Drawing.Point(387, 12)
        Me.addbut.Name = "addbut"
        Me.addbut.Size = New System.Drawing.Size(146, 25)
        Me.addbut.TabIndex = 60
        Me.addbut.Text = "ADDRESS LOOKUP"
        Me.addbut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "CUSTOMER NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "ADDRESS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "ORDER NO:"
        '
        'alighcb
        '
        Me.alighcb.FormattingEnabled = True
        Me.alighcb.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.alighcb.Location = New System.Drawing.Point(284, 328)
        Me.alighcb.Name = "alighcb"
        Me.alighcb.Size = New System.Drawing.Size(80, 24)
        Me.alighcb.TabIndex = 65
        '
        'quitbut
        '
        Me.quitbut.Location = New System.Drawing.Point(31, 393)
        Me.quitbut.Name = "quitbut"
        Me.quitbut.Size = New System.Drawing.Size(75, 23)
        Me.quitbut.TabIndex = 66
        Me.quitbut.Text = "QUIT"
        Me.quitbut.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(590, 428)
        Me.Controls.Add(Me.quitbut)
        Me.Controls.Add(Me.alighcb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addbut)
        Me.Controls.Add(Me.printbut)
        Me.Controls.Add(Me.mainbut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nolabtb)
        Me.Controls.Add(Me.ordtb)
        Me.Controls.Add(Me.addtb)
        Me.Controls.Add(Me.custtb)
        Me.Name = "Form2"
        Me.Text = "TRANSVAC ADDRESS LABEL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents custtb As TextBox
    Friend WithEvents addtb As TextBox
    Friend WithEvents ordtb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nolabtb As TextBox
    Friend WithEvents mainbut As Button
    Friend WithEvents printbut As Button
    Friend WithEvents addbut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents alighcb As ComboBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents quitbut As Button
End Class
