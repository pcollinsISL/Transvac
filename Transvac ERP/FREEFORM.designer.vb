﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FREEFORM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FREEFORM))
        Me.alighcb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nolabtb = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.printbut = New System.Windows.Forms.Button()
        Me.printpwbut = New System.Windows.Forms.Button()
        Me.frrtb = New System.Windows.Forms.TextBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'alighcb
        '
        Me.alighcb.FormattingEnabled = True
        Me.alighcb.Items.AddRange(New Object() {"Centre", "Left", "Right"})
        Me.alighcb.Location = New System.Drawing.Point(178, 268)
        Me.alighcb.Margin = New System.Windows.Forms.Padding(2)
        Me.alighcb.Name = "alighcb"
        Me.alighcb.Size = New System.Drawing.Size(65, 21)
        Me.alighcb.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 224)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NO OF LABLES"
        '
        'nolabtb
        '
        Me.nolabtb.Location = New System.Drawing.Point(307, 222)
        Me.nolabtb.Margin = New System.Windows.Forms.Padding(2)
        Me.nolabtb.Name = "nolabtb"
        Me.nolabtb.Size = New System.Drawing.Size(48, 20)
        Me.nolabtb.TabIndex = 14
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'printbut
        '
        Me.printbut.Location = New System.Drawing.Point(272, 319)
        Me.printbut.Margin = New System.Windows.Forms.Padding(2)
        Me.printbut.Name = "printbut"
        Me.printbut.Size = New System.Drawing.Size(83, 26)
        Me.printbut.TabIndex = 15
        Me.printbut.Text = "PRINT"
        Me.printbut.UseVisualStyleBackColor = True
        '
        'printpwbut
        '
        Me.printpwbut.Location = New System.Drawing.Point(247, 268)
        Me.printpwbut.Margin = New System.Windows.Forms.Padding(2)
        Me.printpwbut.Name = "printpwbut"
        Me.printpwbut.Size = New System.Drawing.Size(110, 25)
        Me.printpwbut.TabIndex = 16
        Me.printpwbut.Text = "PRINT PREVIEW"
        Me.printpwbut.UseVisualStyleBackColor = True
        '
        'frrtb
        '
        Me.frrtb.Location = New System.Drawing.Point(38, 29)
        Me.frrtb.Margin = New System.Windows.Forms.Padding(2)
        Me.frrtb.Multiline = True
        Me.frrtb.Name = "frrtb"
        Me.frrtb.Size = New System.Drawing.Size(317, 177)
        Me.frrtb.TabIndex = 17
        Me.frrtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 319)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 26)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "MAIN MENU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FREEFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(390, 367)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.frrtb)
        Me.Controls.Add(Me.printpwbut)
        Me.Controls.Add(Me.printbut)
        Me.Controls.Add(Me.nolabtb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.alighcb)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FREEFORM"
        Me.Text = "FREEFORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents alighcb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nolabtb As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents printbut As Button
    Friend WithEvents printpwbut As Button
    Friend WithEvents frrtb As TextBox
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Button1 As Button
End Class
