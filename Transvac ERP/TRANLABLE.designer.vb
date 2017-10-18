<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TRANLABLE
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
        Me.partbut = New System.Windows.Forms.Button()
        Me.addbut = New System.Windows.Forms.Button()
        Me.modpbut = New System.Windows.Forms.Button()
        Me.freebut = New System.Windows.Forms.Button()
        Me.quitbut = New System.Windows.Forms.Button()
        Me.baeshbut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'partbut
        '
        Me.partbut.Location = New System.Drawing.Point(84, 52)
        Me.partbut.Name = "partbut"
        Me.partbut.Size = New System.Drawing.Size(201, 23)
        Me.partbut.TabIndex = 0
        Me.partbut.Text = "TRANSVAC PART LABEL"
        Me.partbut.UseVisualStyleBackColor = True
        '
        'addbut
        '
        Me.addbut.Location = New System.Drawing.Point(84, 112)
        Me.addbut.Name = "addbut"
        Me.addbut.Size = New System.Drawing.Size(213, 23)
        Me.addbut.TabIndex = 1
        Me.addbut.Text = "TRANSVAC ADDRESS LABEL"
        Me.addbut.UseVisualStyleBackColor = True
        '
        'modpbut
        '
        Me.modpbut.Location = New System.Drawing.Point(84, 171)
        Me.modpbut.Name = "modpbut"
        Me.modpbut.Size = New System.Drawing.Size(219, 23)
        Me.modpbut.TabIndex = 2
        Me.modpbut.Text = "TRANSVAC MOD PART LABEL"
        Me.modpbut.UseVisualStyleBackColor = True
        '
        'freebut
        '
        Me.freebut.Location = New System.Drawing.Point(84, 230)
        Me.freebut.Name = "freebut"
        Me.freebut.Size = New System.Drawing.Size(150, 23)
        Me.freebut.TabIndex = 3
        Me.freebut.Text = "FREEFORM LABEL"
        Me.freebut.UseVisualStyleBackColor = True
        '
        'quitbut
        '
        Me.quitbut.Location = New System.Drawing.Point(29, 346)
        Me.quitbut.Name = "quitbut"
        Me.quitbut.Size = New System.Drawing.Size(75, 23)
        Me.quitbut.TabIndex = 4
        Me.quitbut.Text = "QUIT"
        Me.quitbut.UseVisualStyleBackColor = True
        '
        'baeshbut
        '
        Me.baeshbut.Location = New System.Drawing.Point(84, 291)
        Me.baeshbut.Name = "baeshbut"
        Me.baeshbut.Size = New System.Drawing.Size(128, 23)
        Me.baeshbut.TabIndex = 5
        Me.baeshbut.Text = "BAE SHIP FORM"
        Me.baeshbut.UseVisualStyleBackColor = True
        '
        'TRANLABLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(381, 414)
        Me.Controls.Add(Me.baeshbut)
        Me.Controls.Add(Me.quitbut)
        Me.Controls.Add(Me.freebut)
        Me.Controls.Add(Me.modpbut)
        Me.Controls.Add(Me.addbut)
        Me.Controls.Add(Me.partbut)
        Me.Name = "TRANLABLE"
        Me.Text = "LABEL MENU"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents partbut As Button
    Friend WithEvents addbut As Button
    Friend WithEvents modpbut As Button
    Friend WithEvents freebut As Button
    Friend WithEvents quitbut As Button
    Friend WithEvents baeshbut As Button
End Class
