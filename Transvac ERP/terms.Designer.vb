<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class terms
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
        Me.termtb = New System.Windows.Forms.TextBox()
        Me.termsavebut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'termtb
        '
        Me.termtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termtb.Location = New System.Drawing.Point(42, 42)
        Me.termtb.Multiline = True
        Me.termtb.Name = "termtb"
        Me.termtb.Size = New System.Drawing.Size(700, 175)
        Me.termtb.TabIndex = 0
        '
        'termsavebut
        '
        Me.termsavebut.Location = New System.Drawing.Point(343, 226)
        Me.termsavebut.Name = "termsavebut"
        Me.termsavebut.Size = New System.Drawing.Size(75, 23)
        Me.termsavebut.TabIndex = 2
        Me.termsavebut.Text = "SAVE"
        Me.termsavebut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Terms Of Business"
        '
        'terms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(784, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.termsavebut)
        Me.Controls.Add(Me.termtb)
        Me.Name = "terms"
        Me.Text = "Terms of Business"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents termtb As TextBox
    Friend WithEvents termsavebut As Button
    Friend WithEvents Label1 As Label
End Class
