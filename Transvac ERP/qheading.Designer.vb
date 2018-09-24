<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qheading
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
        Me.headsve_but = New System.Windows.Forms.Button()
        Me.headingabt_but = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(46, 48)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(494, 104)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Dear Sir/Madam," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thank you for your enquiry in which you requested price and de" &
    "livery time for the items below"
        '
        'headsve_but
        '
        Me.headsve_but.Location = New System.Drawing.Point(465, 178)
        Me.headsve_but.Name = "headsve_but"
        Me.headsve_but.Size = New System.Drawing.Size(75, 23)
        Me.headsve_but.TabIndex = 33
        Me.headsve_but.Text = "SAVE"
        Me.headsve_but.UseVisualStyleBackColor = True
        '
        'headingabt_but
        '
        Me.headingabt_but.Location = New System.Drawing.Point(46, 178)
        Me.headingabt_but.Name = "headingabt_but"
        Me.headingabt_but.Size = New System.Drawing.Size(75, 23)
        Me.headingabt_but.TabIndex = 32
        Me.headingabt_but.Text = "ABORT"
        Me.headingabt_but.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Heading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(616, 250)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.headsve_but)
        Me.Controls.Add(Me.headingabt_but)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Heading"
        Me.Text = "Heading"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents headsve_but As Button
    Friend WithEvents headingabt_but As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
