<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class enqmain
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
        Me.btnfindeq = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnneweq = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfindeq
        '
        Me.btnfindeq.Location = New System.Drawing.Point(56, 135)
        Me.btnfindeq.Name = "btnfindeq"
        Me.btnfindeq.Size = New System.Drawing.Size(156, 33)
        Me.btnfindeq.TabIndex = 1
        Me.btnfindeq.Text = "FIND ENQUIRY"
        Me.btnfindeq.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(56, 220)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(59, 27)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ENQUIRY MENU"
        '
        'btnneweq
        '
        Me.btnneweq.Location = New System.Drawing.Point(56, 87)
        Me.btnneweq.Name = "btnneweq"
        Me.btnneweq.Size = New System.Drawing.Size(156, 33)
        Me.btnneweq.TabIndex = 7
        Me.btnneweq.Text = "NEW ENQUIRY"
        Me.btnneweq.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'enqmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(247, 283)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnneweq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnfindeq)
        Me.Name = "enqmain"
        Me.Text = "Enquiries"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnfindeq As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnneweq As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
