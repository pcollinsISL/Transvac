<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PARTLABEL
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.partnotb = New System.Windows.Forms.TextBox()
        Me.mainbut = New System.Windows.Forms.Button()
        Me.printbut = New System.Windows.Forms.Button()
        Me.alighcb = New System.Windows.Forms.ComboBox()
        Me.descptb = New System.Windows.Forms.TextBox()
        Me.cdatedt = New System.Windows.Forms.DateTimePicker()
        Me.qtytb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nolabtb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.quitbut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DESCRIPTION:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PART NO:"
        '
        'partnotb
        '
        Me.partnotb.Location = New System.Drawing.Point(134, 181)
        Me.partnotb.Name = "partnotb"
        Me.partnotb.Size = New System.Drawing.Size(356, 22)
        Me.partnotb.TabIndex = 5
        '
        'mainbut
        '
        Me.mainbut.Location = New System.Drawing.Point(40, 315)
        Me.mainbut.Name = "mainbut"
        Me.mainbut.Size = New System.Drawing.Size(101, 33)
        Me.mainbut.TabIndex = 6
        Me.mainbut.Text = "MAIN MENU"
        Me.mainbut.UseVisualStyleBackColor = True
        '
        'printbut
        '
        Me.printbut.Location = New System.Drawing.Point(425, 271)
        Me.printbut.Name = "printbut"
        Me.printbut.Size = New System.Drawing.Size(65, 33)
        Me.printbut.TabIndex = 7
        Me.printbut.Text = "PRINT"
        Me.printbut.UseVisualStyleBackColor = True
        '
        'alighcb
        '
        Me.alighcb.BackColor = System.Drawing.SystemColors.HighlightText
        Me.alighcb.FormattingEnabled = True
        Me.alighcb.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.alighcb.Location = New System.Drawing.Point(410, 218)
        Me.alighcb.Name = "alighcb"
        Me.alighcb.Size = New System.Drawing.Size(80, 24)
        Me.alighcb.TabIndex = 13
        '
        'descptb
        '
        Me.descptb.Location = New System.Drawing.Point(134, 57)
        Me.descptb.Multiline = True
        Me.descptb.Name = "descptb"
        Me.descptb.Size = New System.Drawing.Size(356, 109)
        Me.descptb.TabIndex = 14
        '
        'cdatedt
        '
        Me.cdatedt.Location = New System.Drawing.Point(134, 218)
        Me.cdatedt.Name = "cdatedt"
        Me.cdatedt.Size = New System.Drawing.Size(155, 22)
        Me.cdatedt.TabIndex = 15
        '
        'qtytb
        '
        Me.qtytb.Location = New System.Drawing.Point(151, 246)
        Me.qtytb.Name = "qtytb"
        Me.qtytb.Size = New System.Drawing.Size(38, 22)
        Me.qtytb.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "QTY:"
        '
        'nolabtb
        '
        Me.nolabtb.Location = New System.Drawing.Point(151, 284)
        Me.nolabtb.Name = "nolabtb"
        Me.nolabtb.Size = New System.Drawing.Size(100, 22)
        Me.nolabtb.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "NO OF LABLES"
        '
        'quitbut
        '
        Me.quitbut.Location = New System.Drawing.Point(40, 354)
        Me.quitbut.Name = "quitbut"
        Me.quitbut.Size = New System.Drawing.Size(75, 23)
        Me.quitbut.TabIndex = 57
        Me.quitbut.Text = "QUIT"
        Me.quitbut.UseVisualStyleBackColor = True
        '
        'PARTLABEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(561, 382)
        Me.Controls.Add(Me.quitbut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nolabtb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.qtytb)
        Me.Controls.Add(Me.cdatedt)
        Me.Controls.Add(Me.descptb)
        Me.Controls.Add(Me.alighcb)
        Me.Controls.Add(Me.printbut)
        Me.Controls.Add(Me.mainbut)
        Me.Controls.Add(Me.partnotb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PARTLABEL"
        Me.Text = "TRANSVAC PART LABEL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents partnotb As TextBox
    Friend WithEvents mainbut As Button
    Friend WithEvents printbut As Button
    Friend WithEvents alighcb As ComboBox
    Friend WithEvents descptb As TextBox
    Friend WithEvents cdatedt As DateTimePicker
    Friend WithEvents qtytb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nolabtb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents quitbut As Button
End Class
