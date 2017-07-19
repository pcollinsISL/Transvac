<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class heading
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
        Me.headtb = New System.Windows.Forms.TextBox()
        Me.headsavebut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'headtb
        '
        Me.headtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headtb.Location = New System.Drawing.Point(41, 42)
        Me.headtb.Multiline = True
        Me.headtb.Name = "headtb"
        Me.headtb.Size = New System.Drawing.Size(700, 175)
        Me.headtb.TabIndex = 0
        '
        'headsavebut
        '
        Me.headsavebut.Location = New System.Drawing.Point(344, 226)
        Me.headsavebut.Name = "headsavebut"
        Me.headsavebut.Size = New System.Drawing.Size(75, 23)
        Me.headsavebut.TabIndex = 2
        Me.headsavebut.Text = "SAVE"
        Me.headsavebut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Heading"
        '
        'heading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(784, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.headsavebut)
        Me.Controls.Add(Me.headtb)
        Me.Name = "heading"
        Me.Text = "Heading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headtb As TextBox
    Friend WithEvents headsavebut As Button
    Friend WithEvents Label1 As Label
End Class
