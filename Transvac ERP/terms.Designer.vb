<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Terms))
        Me.terms_tb = New System.Windows.Forms.TextBox()
        Me.termssve_but = New System.Windows.Forms.Button()
        Me.termsabt_but = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OrddetailTableAdapter1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.orddetailTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'terms_tb
        '
        Me.terms_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terms_tb.Location = New System.Drawing.Point(54, 52)
        Me.terms_tb.Multiline = True
        Me.terms_tb.Name = "terms_tb"
        Me.terms_tb.Size = New System.Drawing.Size(857, 493)
        Me.terms_tb.TabIndex = 2
        Me.terms_tb.Text = resources.GetString("terms_tb.Text")
        '
        'termssve_but
        '
        Me.termssve_but.Location = New System.Drawing.Point(836, 570)
        Me.termssve_but.Name = "termssve_but"
        Me.termssve_but.Size = New System.Drawing.Size(75, 23)
        Me.termssve_but.TabIndex = 37
        Me.termssve_but.Text = "SAVE"
        Me.termssve_but.UseVisualStyleBackColor = True
        '
        'termsabt_but
        '
        Me.termsabt_but.Location = New System.Drawing.Point(54, 570)
        Me.termsabt_but.Name = "termsabt_but"
        Me.termsabt_but.Size = New System.Drawing.Size(75, 23)
        Me.termsabt_but.TabIndex = 36
        Me.termsabt_but.Text = "ABORT"
        Me.termsabt_but.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'OrddetailTableAdapter1
        '
        Me.OrddetailTableAdapter1.ClearBeforeFill = True
        '
        'Terms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(967, 611)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.termssve_but)
        Me.Controls.Add(Me.termsabt_but)
        Me.Controls.Add(Me.terms_tb)
        Me.Name = "Terms"
        Me.Text = "Terms"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents terms_tb As TextBox
    Friend WithEvents termssve_but As Button
    Friend WithEvents termsabt_but As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OrddetailTableAdapter1 As TransvacDataV2DataSet1TableAdapters.orddetailTableAdapter
End Class
