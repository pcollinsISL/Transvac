<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invnewbin
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
        Dim QuantybinLabel As System.Windows.Forms.Label
        Dim WqtyLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim Catalog_dtLabel As System.Windows.Forms.Label
        Dim Unit_valueLabel As System.Windows.Forms.Label
        Dim Currcy_cdeLabel As System.Windows.Forms.Label
        Dim AllocLabel As System.Windows.Forms.Label
        Dim SourcecdeLabel As System.Windows.Forms.Label
        Dim AssuredLabel As System.Windows.Forms.Label
        Dim LocatebinLabel As System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.QuantybinTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WqtyTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.Catalog_dtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Unit_valueTextBox = New System.Windows.Forms.TextBox()
        Me.Currcy_cdeTextBox = New System.Windows.Forms.TextBox()
        Me.AllocTextBox = New System.Windows.Forms.TextBox()
        Me.SourcecdeTextBox = New System.Windows.Forms.TextBox()
        Me.AssuredTextBox = New System.Windows.Forms.TextBox()
        Me.LocatebinTextBox = New System.Windows.Forms.TextBox()
        QuantybinLabel = New System.Windows.Forms.Label()
        WqtyLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        Catalog_dtLabel = New System.Windows.Forms.Label()
        Unit_valueLabel = New System.Windows.Forms.Label()
        Currcy_cdeLabel = New System.Windows.Forms.Label()
        AllocLabel = New System.Windows.Forms.Label()
        SourcecdeLabel = New System.Windows.Forms.Label()
        AssuredLabel = New System.Windows.Forms.Label()
        LocatebinLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(717, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "ABORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'QuantybinLabel
        '
        QuantybinLabel.AutoSize = True
        QuantybinLabel.Location = New System.Drawing.Point(253, 227)
        QuantybinLabel.Name = "QuantybinLabel"
        QuantybinLabel.Size = New System.Drawing.Size(57, 13)
        QuantybinLabel.TabIndex = 44
        QuantybinLabel.Text = "Stock Qty:"
        '
        'QuantybinTextBox
        '
        Me.QuantybinTextBox.Location = New System.Drawing.Point(315, 224)
        Me.QuantybinTextBox.Name = "QuantybinTextBox"
        Me.QuantybinTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantybinTextBox.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'WqtyLabel
        '
        WqtyLabel.AutoSize = True
        WqtyLabel.Location = New System.Drawing.Point(438, 282)
        WqtyLabel.Name = "WqtyLabel"
        WqtyLabel.Size = New System.Drawing.Size(37, 13)
        WqtyLabel.TabIndex = 41
        WqtyLabel.Text = "WQty:"
        '
        'WqtyTextBox
        '
        Me.WqtyTextBox.Location = New System.Drawing.Point(517, 282)
        Me.WqtyTextBox.Name = "WqtyTextBox"
        Me.WqtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WqtyTextBox.TabIndex = 42
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(269, 282)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 39
        WeightLabel.Text = "Weight:"
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Location = New System.Drawing.Point(316, 279)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WeightTextBox.TabIndex = 40
        '
        'Catalog_dtLabel
        '
        Catalog_dtLabel.AutoSize = True
        Catalog_dtLabel.Location = New System.Drawing.Point(514, 61)
        Catalog_dtLabel.Name = "Catalog_dtLabel"
        Catalog_dtLabel.Size = New System.Drawing.Size(72, 13)
        Catalog_dtLabel.TabIndex = 37
        Catalog_dtLabel.Text = "Catalog Date:"
        '
        'Catalog_dtDateTimePicker
        '
        Me.Catalog_dtDateTimePicker.Location = New System.Drawing.Point(592, 61)
        Me.Catalog_dtDateTimePicker.Name = "Catalog_dtDateTimePicker"
        Me.Catalog_dtDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Catalog_dtDateTimePicker.TabIndex = 38
        '
        'Unit_valueLabel
        '
        Unit_valueLabel.AutoSize = True
        Unit_valueLabel.Location = New System.Drawing.Point(438, 171)
        Unit_valueLabel.Name = "Unit_valueLabel"
        Unit_valueLabel.Size = New System.Drawing.Size(59, 13)
        Unit_valueLabel.TabIndex = 35
        Unit_valueLabel.Text = "Unit Value:"
        '
        'Unit_valueTextBox
        '
        Me.Unit_valueTextBox.Location = New System.Drawing.Point(517, 168)
        Me.Unit_valueTextBox.Name = "Unit_valueTextBox"
        Me.Unit_valueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_valueTextBox.TabIndex = 36
        '
        'Currcy_cdeLabel
        '
        Currcy_cdeLabel.AutoSize = True
        Currcy_cdeLabel.Location = New System.Drawing.Point(230, 124)
        Currcy_cdeLabel.Name = "Currcy_cdeLabel"
        Currcy_cdeLabel.Size = New System.Drawing.Size(80, 13)
        Currcy_cdeLabel.TabIndex = 33
        Currcy_cdeLabel.Text = "Currency Code:"
        '
        'Currcy_cdeTextBox
        '
        Me.Currcy_cdeTextBox.Location = New System.Drawing.Point(316, 121)
        Me.Currcy_cdeTextBox.Name = "Currcy_cdeTextBox"
        Me.Currcy_cdeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Currcy_cdeTextBox.TabIndex = 34
        '
        'AllocLabel
        '
        AllocLabel.AutoSize = True
        AllocLabel.Location = New System.Drawing.Point(438, 231)
        AllocLabel.Name = "AllocLabel"
        AllocLabel.Size = New System.Drawing.Size(73, 13)
        AllocLabel.TabIndex = 31
        AllocLabel.Text = "Allocated Qty:"
        '
        'AllocTextBox
        '
        Me.AllocTextBox.Location = New System.Drawing.Point(517, 224)
        Me.AllocTextBox.Name = "AllocTextBox"
        Me.AllocTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AllocTextBox.TabIndex = 32
        '
        'SourcecdeLabel
        '
        SourcecdeLabel.AutoSize = True
        SourcecdeLabel.Location = New System.Drawing.Point(30, 124)
        SourcecdeLabel.Name = "SourcecdeLabel"
        SourcecdeLabel.Size = New System.Drawing.Size(41, 13)
        SourcecdeLabel.TabIndex = 29
        SourcecdeLabel.Text = "Source"
        '
        'SourcecdeTextBox
        '
        Me.SourcecdeTextBox.Location = New System.Drawing.Point(96, 121)
        Me.SourcecdeTextBox.Name = "SourcecdeTextBox"
        Me.SourcecdeTextBox.Size = New System.Drawing.Size(129, 20)
        Me.SourcecdeTextBox.TabIndex = 30
        '
        'AssuredLabel
        '
        AssuredLabel.AutoSize = True
        AssuredLabel.Location = New System.Drawing.Point(438, 120)
        AssuredLabel.Name = "AssuredLabel"
        AssuredLabel.Size = New System.Drawing.Size(45, 13)
        AssuredLabel.TabIndex = 27
        AssuredLabel.Text = "Assured"
        '
        'AssuredTextBox
        '
        Me.AssuredTextBox.Location = New System.Drawing.Point(517, 117)
        Me.AssuredTextBox.Name = "AssuredTextBox"
        Me.AssuredTextBox.Size = New System.Drawing.Size(40, 20)
        Me.AssuredTextBox.TabIndex = 28
        '
        'LocatebinLabel
        '
        LocatebinLabel.AutoSize = True
        LocatebinLabel.Location = New System.Drawing.Point(251, 171)
        LocatebinLabel.Name = "LocatebinLabel"
        LocatebinLabel.Size = New System.Drawing.Size(53, 13)
        LocatebinLabel.TabIndex = 25
        LocatebinLabel.Text = "Bin Code:"
        '
        'LocatebinTextBox
        '
        Me.LocatebinTextBox.Location = New System.Drawing.Point(316, 168)
        Me.LocatebinTextBox.Name = "LocatebinTextBox"
        Me.LocatebinTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocatebinTextBox.TabIndex = 26
        '
        'invnewbin
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 463)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(QuantybinLabel)
        Me.Controls.Add(Me.QuantybinTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(WqtyLabel)
        Me.Controls.Add(Me.WqtyTextBox)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(Catalog_dtLabel)
        Me.Controls.Add(Me.Catalog_dtDateTimePicker)
        Me.Controls.Add(Unit_valueLabel)
        Me.Controls.Add(Me.Unit_valueTextBox)
        Me.Controls.Add(Currcy_cdeLabel)
        Me.Controls.Add(Me.Currcy_cdeTextBox)
        Me.Controls.Add(AllocLabel)
        Me.Controls.Add(Me.AllocTextBox)
        Me.Controls.Add(SourcecdeLabel)
        Me.Controls.Add(Me.SourcecdeTextBox)
        Me.Controls.Add(AssuredLabel)
        Me.Controls.Add(Me.AssuredTextBox)
        Me.Controls.Add(LocatebinLabel)
        Me.Controls.Add(Me.LocatebinTextBox)
        Me.Name = "invnewbin"
        Me.Text = "Inventory New Bin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents QuantybinTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WqtyTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents Catalog_dtDateTimePicker As DateTimePicker
    Friend WithEvents Unit_valueTextBox As TextBox
    Friend WithEvents Currcy_cdeTextBox As TextBox
    Friend WithEvents AllocTextBox As TextBox
    Friend WithEvents SourcecdeTextBox As TextBox
    Friend WithEvents AssuredTextBox As TextBox
    Friend WithEvents LocatebinTextBox As TextBox
End Class
