<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class delivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(delivery))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.deliverysve_but = New System.Windows.Forms.Button()
        Me.delabt_but = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(53, 54)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(544, 179)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'deliverysve_but
        '
        Me.deliverysve_but.Location = New System.Drawing.Point(522, 255)
        Me.deliverysve_but.Name = "deliverysve_but"
        Me.deliverysve_but.Size = New System.Drawing.Size(75, 23)
        Me.deliverysve_but.TabIndex = 35
        Me.deliverysve_but.Text = "SAVE"
        Me.deliverysve_but.UseVisualStyleBackColor = True
        '
        'delabt_but
        '
        Me.delabt_but.Location = New System.Drawing.Point(53, 255)
        Me.delabt_but.Name = "delabt_but"
        Me.delabt_but.Size = New System.Drawing.Size(75, 23)
        Me.delabt_but.TabIndex = 34
        Me.delabt_but.Text = "ABORT"
        Me.delabt_but.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'delivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(643, 316)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.deliverysve_but)
        Me.Controls.Add(Me.delabt_but)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "delivery"
        Me.Text = "Delivery"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents deliverysve_but As Button
    Friend WithEvents delabt_but As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
