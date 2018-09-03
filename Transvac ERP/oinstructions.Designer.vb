<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oinstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(oinstructions))
        Me.headsve_but = New System.Windows.Forms.Button()
        Me.headingabt_but = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headsve_but
        '
        Me.headsve_but.Location = New System.Drawing.Point(510, 234)
        Me.headsve_but.Name = "headsve_but"
        Me.headsve_but.Size = New System.Drawing.Size(75, 27)
        Me.headsve_but.TabIndex = 40
        Me.headsve_but.Text = "SAVE"
        Me.headsve_but.UseVisualStyleBackColor = True
        '
        'headingabt_but
        '
        Me.headingabt_but.Location = New System.Drawing.Point(58, 234)
        Me.headingabt_but.Name = "headingabt_but"
        Me.headingabt_but.Size = New System.Drawing.Size(75, 27)
        Me.headingabt_but.TabIndex = 39
        Me.headingabt_but.Text = "ABORT"
        Me.headingabt_but.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(58, 57)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(527, 162)
        Me.TextBox1.TabIndex = 38
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(24, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'oinstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 296)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.headsve_but)
        Me.Controls.Add(Me.headingabt_but)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "oinstructions"
        Me.Text = "Order Instructions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents headsve_but As Button
    Friend WithEvents headingabt_but As Button
    Friend WithEvents TextBox1 As TextBox
End Class
