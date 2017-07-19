<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class delivery
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
        Me.deltb = New System.Windows.Forms.TextBox()
        Me.delsavebut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'deltb
        '
        Me.deltb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deltb.Location = New System.Drawing.Point(40, 39)
        Me.deltb.Multiline = True
        Me.deltb.Name = "deltb"
        Me.deltb.Size = New System.Drawing.Size(700, 175)
        Me.deltb.TabIndex = 0
        Me.deltb.Text = " "
        '
        'delsavebut
        '
        Me.delsavebut.Location = New System.Drawing.Point(344, 227)
        Me.delsavebut.Name = "delsavebut"
        Me.delsavebut.Size = New System.Drawing.Size(75, 23)
        Me.delsavebut.TabIndex = 3
        Me.delsavebut.Text = "SAVE"
        Me.delsavebut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Delivery Note"
        '
        'delivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(784, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.delsavebut)
        Me.Controls.Add(Me.deltb)
        Me.Name = "delivery"
        Me.Text = "Delivery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deltb As TextBox
    Friend WithEvents delsavebut As Button
    Friend WithEvents Label1 As Label
End Class
