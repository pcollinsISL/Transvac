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
        Me.components = New System.ComponentModel.Container()
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
        Me.savebtn = New System.Windows.Forms.Button()
        Me.aboutbtn = New System.Windows.Forms.Button()
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
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TranbinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranbinsTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter()
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
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'WqtyLabel
        '
        WqtyLabel.AutoSize = True
        WqtyLabel.Location = New System.Drawing.Point(438, 282)
        WqtyLabel.Name = "WqtyLabel"
        WqtyLabel.Size = New System.Drawing.Size(37, 13)
        WqtyLabel.TabIndex = 41
        WqtyLabel.Text = "WQty:"
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
        'Catalog_dtLabel
        '
        Catalog_dtLabel.AutoSize = True
        Catalog_dtLabel.Location = New System.Drawing.Point(514, 61)
        Catalog_dtLabel.Name = "Catalog_dtLabel"
        Catalog_dtLabel.Size = New System.Drawing.Size(72, 13)
        Catalog_dtLabel.TabIndex = 37
        Catalog_dtLabel.Text = "Catalog Date:"
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
        'Currcy_cdeLabel
        '
        Currcy_cdeLabel.AutoSize = True
        Currcy_cdeLabel.Location = New System.Drawing.Point(230, 124)
        Currcy_cdeLabel.Name = "Currcy_cdeLabel"
        Currcy_cdeLabel.Size = New System.Drawing.Size(80, 13)
        Currcy_cdeLabel.TabIndex = 33
        Currcy_cdeLabel.Text = "Currency Code:"
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
        'SourcecdeLabel
        '
        SourcecdeLabel.AutoSize = True
        SourcecdeLabel.Location = New System.Drawing.Point(30, 124)
        SourcecdeLabel.Name = "SourcecdeLabel"
        SourcecdeLabel.Size = New System.Drawing.Size(41, 13)
        SourcecdeLabel.TabIndex = 29
        SourcecdeLabel.Text = "Source"
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
        'LocatebinLabel
        '
        LocatebinLabel.AutoSize = True
        LocatebinLabel.Location = New System.Drawing.Point(251, 171)
        LocatebinLabel.Name = "LocatebinLabel"
        LocatebinLabel.Size = New System.Drawing.Size(53, 13)
        LocatebinLabel.TabIndex = 25
        LocatebinLabel.Text = "Bin Code:"
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(717, 333)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(75, 23)
        Me.savebtn.TabIndex = 47
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'aboutbtn
        '
        Me.aboutbtn.Location = New System.Drawing.Point(96, 333)
        Me.aboutbtn.Name = "aboutbtn"
        Me.aboutbtn.Size = New System.Drawing.Size(75, 23)
        Me.aboutbtn.TabIndex = 46
        Me.aboutbtn.Text = "ABORT"
        Me.aboutbtn.UseVisualStyleBackColor = True
        '
        'QuantybinTextBox
        '
        Me.QuantybinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "quantybin", True))
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
        'WqtyTextBox
        '
        Me.WqtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "wqty", True))
        Me.WqtyTextBox.Location = New System.Drawing.Point(517, 282)
        Me.WqtyTextBox.Name = "WqtyTextBox"
        Me.WqtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WqtyTextBox.TabIndex = 42
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(316, 279)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WeightTextBox.TabIndex = 40
        '
        'Catalog_dtDateTimePicker
        '
        Me.Catalog_dtDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TranbinsBindingSource, "catalog_dt", True))
        Me.Catalog_dtDateTimePicker.Location = New System.Drawing.Point(592, 61)
        Me.Catalog_dtDateTimePicker.Name = "Catalog_dtDateTimePicker"
        Me.Catalog_dtDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Catalog_dtDateTimePicker.TabIndex = 38
        '
        'Unit_valueTextBox
        '
        Me.Unit_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "unit_value", True))
        Me.Unit_valueTextBox.Location = New System.Drawing.Point(517, 168)
        Me.Unit_valueTextBox.Name = "Unit_valueTextBox"
        Me.Unit_valueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_valueTextBox.TabIndex = 36
        '
        'Currcy_cdeTextBox
        '
        Me.Currcy_cdeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "currcy_cde", True))
        Me.Currcy_cdeTextBox.Location = New System.Drawing.Point(316, 121)
        Me.Currcy_cdeTextBox.Name = "Currcy_cdeTextBox"
        Me.Currcy_cdeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Currcy_cdeTextBox.TabIndex = 34
        '
        'AllocTextBox
        '
        Me.AllocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "alloc", True))
        Me.AllocTextBox.Location = New System.Drawing.Point(517, 224)
        Me.AllocTextBox.Name = "AllocTextBox"
        Me.AllocTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AllocTextBox.TabIndex = 32
        '
        'SourcecdeTextBox
        '
        Me.SourcecdeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "sourcecde", True))
        Me.SourcecdeTextBox.Location = New System.Drawing.Point(96, 121)
        Me.SourcecdeTextBox.Name = "SourcecdeTextBox"
        Me.SourcecdeTextBox.Size = New System.Drawing.Size(129, 20)
        Me.SourcecdeTextBox.TabIndex = 30
        '
        'AssuredTextBox
        '
        Me.AssuredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "assured", True))
        Me.AssuredTextBox.Location = New System.Drawing.Point(517, 117)
        Me.AssuredTextBox.Name = "AssuredTextBox"
        Me.AssuredTextBox.Size = New System.Drawing.Size(40, 20)
        Me.AssuredTextBox.TabIndex = 28
        '
        'LocatebinTextBox
        '
        Me.LocatebinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "locatebin", True))
        Me.LocatebinTextBox.Location = New System.Drawing.Point(316, 168)
        Me.LocatebinTextBox.Name = "LocatebinTextBox"
        Me.LocatebinTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocatebinTextBox.TabIndex = 26
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TranbinsBindingSource
        '
        Me.TranbinsBindingSource.DataMember = "tranbins"
        Me.TranbinsBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'TranbinsTableAdapter
        '
        Me.TranbinsTableAdapter.ClearBeforeFill = True
        '
        'invnewbin
        '
        Me.AcceptButton = Me.savebtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 463)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.aboutbtn)
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
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents savebtn As Button
    Friend WithEvents aboutbtn As Button
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
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TranbinsBindingSource As BindingSource
    Friend WithEvents TranbinsTableAdapter As TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter
End Class
