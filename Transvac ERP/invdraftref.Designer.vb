<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class invdraftref
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Accountnum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.qut_btn = New System.Windows.Forms.Button()
        Me.sel_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Enter draft Invoice reference"
        '
        'Accountnum
        '
        Me.Accountnum.Location = New System.Drawing.Point(190, 101)
        Me.Accountnum.Name = "Accountnum"
        Me.Accountnum.Size = New System.Drawing.Size(105, 20)
        Me.Accountnum.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Continue working on a draft"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'qut_btn
        '
        Me.qut_btn.Location = New System.Drawing.Point(43, 168)
        Me.qut_btn.Name = "qut_btn"
        Me.qut_btn.Size = New System.Drawing.Size(75, 23)
        Me.qut_btn.TabIndex = 37
        Me.qut_btn.Text = "QUIT"
        Me.qut_btn.UseVisualStyleBackColor = True
        '
        'sel_btn
        '
        Me.sel_btn.Location = New System.Drawing.Point(220, 168)
        Me.sel_btn.Name = "sel_btn"
        Me.sel_btn.Size = New System.Drawing.Size(75, 23)
        Me.sel_btn.TabIndex = 36
        Me.sel_btn.Text = "SELECT"
        Me.sel_btn.UseVisualStyleBackColor = True
        '
        'invdraftref
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 221)
        Me.Controls.Add(Me.qut_btn)
        Me.Controls.Add(Me.sel_btn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Accountnum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "invdraftref"
        Me.Text = "CONTINUE WORKING ON A DRAFT"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Accountnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents qut_btn As Button
    Friend WithEvents sel_btn As Button
End Class
