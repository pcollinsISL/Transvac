﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signoff
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.sve_but = New System.Windows.Forms.Button()
        Me.signoffabt_but = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(34, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(508, 100)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "I hope this is to your satisfaction and if you require any further information pl" &
    "ease do not hesitate to contact me." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thank You and Kind Regards." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'sve_but
        '
        Me.sve_but.Location = New System.Drawing.Point(467, 197)
        Me.sve_but.Name = "sve_but"
        Me.sve_but.Size = New System.Drawing.Size(75, 23)
        Me.sve_but.TabIndex = 37
        Me.sve_but.Text = "SAVE"
        Me.sve_but.UseVisualStyleBackColor = True
        '
        'signoffabt_but
        '
        Me.signoffabt_but.Location = New System.Drawing.Point(34, 197)
        Me.signoffabt_but.Name = "signoffabt_but"
        Me.signoffabt_but.Size = New System.Drawing.Size(75, 23)
        Me.signoffabt_but.TabIndex = 36
        Me.signoffabt_but.Text = "ABORT"
        Me.signoffabt_but.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'signoff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(579, 258)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.sve_but)
        Me.Controls.Add(Me.signoffabt_but)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "signoff"
        Me.Text = "Sign Off"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents sve_but As Button
    Friend WithEvents signoffabt_but As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
