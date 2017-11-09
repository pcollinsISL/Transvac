<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inveditdesc
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
        Me.components = New System.ComponentModel.Container()
        Dim PcodeLabel As System.Windows.Forms.Label
        Dim PsupplierLabel As System.Windows.Forms.Label
        Dim MinstockLabel As System.Windows.Forms.Label
        Dim MinorderLabel As System.Windows.Forms.Label
        Dim DescriptnLabel As System.Windows.Forms.Label
        Dim CcodeLabel As System.Windows.Forms.Label
        Dim IdupdateLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TrandescBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrandescTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.trandescTableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.PcodeTextBox = New System.Windows.Forms.TextBox()
        Me.PsupplierListBox = New System.Windows.Forms.ListBox()
        Me.MinstockTextBox = New System.Windows.Forms.TextBox()
        Me.MinorderTextBox = New System.Windows.Forms.TextBox()
        Me.IfmemoTextBox = New System.Windows.Forms.TextBox()
        Me.ObsoleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.DescriptnTextBox = New System.Windows.Forms.TextBox()
        Me.CcodeTextBox = New System.Windows.Forms.TextBox()
        Me.IdupdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        PcodeLabel = New System.Windows.Forms.Label()
        PsupplierLabel = New System.Windows.Forms.Label()
        MinstockLabel = New System.Windows.Forms.Label()
        MinorderLabel = New System.Windows.Forms.Label()
        DescriptnLabel = New System.Windows.Forms.Label()
        CcodeLabel = New System.Windows.Forms.Label()
        IdupdateLabel = New System.Windows.Forms.Label()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrandescBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PcodeLabel
        '
        PcodeLabel.AutoSize = True
        PcodeLabel.Location = New System.Drawing.Point(35, 87)
        PcodeLabel.Name = "PcodeLabel"
        PcodeLabel.Size = New System.Drawing.Size(54, 13)
        PcodeLabel.TabIndex = 13
        PcodeLabel.Text = "Part Code"
        '
        'PsupplierLabel
        '
        PsupplierLabel.AutoSize = True
        PsupplierLabel.Location = New System.Drawing.Point(630, 157)
        PsupplierLabel.Name = "PsupplierLabel"
        PsupplierLabel.Size = New System.Drawing.Size(45, 13)
        PsupplierLabel.TabIndex = 14
        PsupplierLabel.Text = "Supplier"
        '
        'MinstockLabel
        '
        MinstockLabel.AutoSize = True
        MinstockLabel.Location = New System.Drawing.Point(35, 170)
        MinstockLabel.Name = "MinstockLabel"
        MinstockLabel.Size = New System.Drawing.Size(55, 13)
        MinstockLabel.TabIndex = 15
        MinstockLabel.Text = "Min Stock"
        '
        'MinorderLabel
        '
        MinorderLabel.AutoSize = True
        MinorderLabel.Location = New System.Drawing.Point(35, 206)
        MinorderLabel.Name = "MinorderLabel"
        MinorderLabel.Size = New System.Drawing.Size(53, 13)
        MinorderLabel.TabIndex = 16
        MinorderLabel.Text = "Min Order"
        '
        'DescriptnLabel
        '
        DescriptnLabel.AutoSize = True
        DescriptnLabel.Location = New System.Drawing.Point(35, 120)
        DescriptnLabel.Name = "DescriptnLabel"
        DescriptnLabel.Size = New System.Drawing.Size(60, 13)
        DescriptnLabel.TabIndex = 20
        DescriptnLabel.Text = "Description"
        '
        'CcodeLabel
        '
        CcodeLabel.AutoSize = True
        CcodeLabel.Location = New System.Drawing.Point(506, 124)
        CcodeLabel.Name = "CcodeLabel"
        CcodeLabel.Size = New System.Drawing.Size(58, 13)
        CcodeLabel.TabIndex = 21
        CcodeLabel.Text = "Commodity"
        '
        'IdupdateLabel
        '
        IdupdateLabel.AutoSize = True
        IdupdateLabel.Location = New System.Drawing.Point(506, 91)
        IdupdateLabel.Name = "IdupdateLabel"
        IdupdateLabel.Size = New System.Drawing.Size(81, 13)
        IdupdateLabel.TabIndex = 22
        IdupdateLabel.Text = "Stock Checked"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 12
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrandescBindingSource
        '
        Me.TrandescBindingSource.DataMember = "trandesc"
        Me.TrandescBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'TrandescTableAdapter
        '
        Me.TrandescTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accctlTableAdapter = Nothing
        Me.TableAdapterManager.accountTableAdapter = Nothing
        Me.TableAdapterManager.addnotesTableAdapter = Nothing
        Me.TableAdapterManager.AddressRecordTypeTableAdapter = Nothing
        Me.TableAdapterManager.ASSETSNEWTableAdapter = Nothing
        Me.TableAdapterManager.assetsTableAdapter = Nothing
        Me.TableAdapterManager.atransTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.binallocTableAdapter = Nothing
        Me.TableAdapterManager.catTableAdapter = Nothing
        Me.TableAdapterManager.countryTableAdapter = Nothing
        Me.TableAdapterManager.custdiscTableAdapter = Nothing
        Me.TableAdapterManager.dummy_TableAdapter = Nothing
        Me.TableAdapterManager.enquiryTableAdapter = Nothing
        Me.TableAdapterManager.eventTableAdapter = Nothing
        Me.TableAdapterManager.foxuserTableAdapter = Nothing
        Me.TableAdapterManager.invlineTableAdapter = Nothing
        Me.TableAdapterManager.invoiceheadTableAdapter = Nothing
        Me.TableAdapterManager.invtransold6TableAdapter = Nothing
        Me.TableAdapterManager.invtransoldTableAdapter = Nothing
        Me.TableAdapterManager.invtransTableAdapter = Nothing
        Me.TableAdapterManager.invworkoldTableAdapter = Nothing
        Me.TableAdapterManager.invworkTableAdapter = Nothing
        Me.TableAdapterManager.issueTableAdapter = Nothing
        Me.TableAdapterManager.locationTableAdapter = Nothing
        Me.TableAdapterManager.mainTableAdapter = Nothing
        Me.TableAdapterManager.markupTableAdapter = Nothing
        Me.TableAdapterManager.namesTableAdapter = Nothing
        Me.TableAdapterManager.orddetailTableAdapter = Nothing
        Me.TableAdapterManager.orderheadTableAdapter = Nothing
        Me.TableAdapterManager.orderlineTableAdapter = Nothing
        Me.TableAdapterManager.qictrlnewTableAdapter = Nothing
        Me.TableAdapterManager.qictrlold6TableAdapter = Nothing
        Me.TableAdapterManager.qictrloldTableAdapter = Nothing
        Me.TableAdapterManager.qictrlTableAdapter = Nothing
        Me.TableAdapterManager.quotedetailTableAdapter = Nothing
        Me.TableAdapterManager.quoteheadTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.teventsTableAdapter = Nothing
        Me.TableAdapterManager.tran2TableAdapter = Nothing
        Me.TableAdapterManager.tranbinsTableAdapter = Nothing
        Me.TableAdapterManager.tranctlTableAdapter = Nothing
        Me.TableAdapterManager.trandescTableAdapter = Me.TrandescTableAdapter
        Me.TableAdapterManager.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PcodeTextBox
        '
        Me.PcodeTextBox.Location = New System.Drawing.Point(108, 84)
        Me.PcodeTextBox.Name = "PcodeTextBox"
        Me.PcodeTextBox.Size = New System.Drawing.Size(182, 20)
        Me.PcodeTextBox.TabIndex = 14
        '
        'PsupplierListBox
        '
        Me.PsupplierListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TrandescBindingSource, "psupplier", True))
        Me.PsupplierListBox.FormattingEnabled = True
        Me.PsupplierListBox.Location = New System.Drawing.Point(633, 183)
        Me.PsupplierListBox.Name = "PsupplierListBox"
        Me.PsupplierListBox.Size = New System.Drawing.Size(120, 147)
        Me.PsupplierListBox.TabIndex = 15
        '
        'MinstockTextBox
        '
        Me.MinstockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource, "minstock", True))
        Me.MinstockTextBox.Location = New System.Drawing.Point(108, 167)
        Me.MinstockTextBox.Name = "MinstockTextBox"
        Me.MinstockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MinstockTextBox.TabIndex = 16
        '
        'MinorderTextBox
        '
        Me.MinorderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource, "minorder", True))
        Me.MinorderTextBox.Location = New System.Drawing.Point(106, 203)
        Me.MinorderTextBox.Name = "MinorderTextBox"
        Me.MinorderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MinorderTextBox.TabIndex = 17
        '
        'IfmemoTextBox
        '
        Me.IfmemoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource, "ifmemo", True))
        Me.IfmemoTextBox.Location = New System.Drawing.Point(230, 167)
        Me.IfmemoTextBox.Multiline = True
        Me.IfmemoTextBox.Name = "IfmemoTextBox"
        Me.IfmemoTextBox.Size = New System.Drawing.Size(334, 128)
        Me.IfmemoTextBox.TabIndex = 18
        '
        'ObsoleteCheckBox
        '
        Me.ObsoleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TrandescBindingSource, "obsolete", True))
        Me.ObsoleteCheckBox.Location = New System.Drawing.Point(505, 301)
        Me.ObsoleteCheckBox.Name = "ObsoleteCheckBox"
        Me.ObsoleteCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ObsoleteCheckBox.TabIndex = 19
        Me.ObsoleteCheckBox.Text = "Obsolete"
        Me.ObsoleteCheckBox.UseVisualStyleBackColor = True
        '
        'DescriptnTextBox
        '
        Me.DescriptnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource, "descriptn", True))
        Me.DescriptnTextBox.Location = New System.Drawing.Point(108, 117)
        Me.DescriptnTextBox.Name = "DescriptnTextBox"
        Me.DescriptnTextBox.Size = New System.Drawing.Size(324, 20)
        Me.DescriptnTextBox.TabIndex = 21
        '
        'CcodeTextBox
        '
        Me.CcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource, "ccode", True))
        Me.CcodeTextBox.Location = New System.Drawing.Point(593, 124)
        Me.CcodeTextBox.Name = "CcodeTextBox"
        Me.CcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CcodeTextBox.TabIndex = 22
        '
        'IdupdateDateTimePicker
        '
        Me.IdupdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TrandescBindingSource, "idupdate", True))
        Me.IdupdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IdupdateDateTimePicker.Location = New System.Drawing.Point(593, 85)
        Me.IdupdateDateTimePicker.Name = "IdupdateDateTimePicker"
        Me.IdupdateDateTimePicker.Size = New System.Drawing.Size(160, 20)
        Me.IdupdateDateTimePicker.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "ABORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(678, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'inveditdesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 396)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdupdateLabel)
        Me.Controls.Add(Me.IdupdateDateTimePicker)
        Me.Controls.Add(CcodeLabel)
        Me.Controls.Add(Me.CcodeTextBox)
        Me.Controls.Add(DescriptnLabel)
        Me.Controls.Add(Me.DescriptnTextBox)
        Me.Controls.Add(Me.ObsoleteCheckBox)
        Me.Controls.Add(Me.IfmemoTextBox)
        Me.Controls.Add(MinorderLabel)
        Me.Controls.Add(Me.MinorderTextBox)
        Me.Controls.Add(MinstockLabel)
        Me.Controls.Add(Me.MinstockTextBox)
        Me.Controls.Add(PsupplierLabel)
        Me.Controls.Add(Me.PsupplierListBox)
        Me.Controls.Add(PcodeLabel)
        Me.Controls.Add(Me.PcodeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "inveditdesc"
        Me.Text = "Edit Description"
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrandescBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TrandescBindingSource As BindingSource
    Friend WithEvents TrandescTableAdapter As TransvacDataV2DataSet1TableAdapters.trandescTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PcodeTextBox As TextBox
    Friend WithEvents PsupplierListBox As ListBox
    Friend WithEvents MinstockTextBox As TextBox
    Friend WithEvents MinorderTextBox As TextBox
    Friend WithEvents IfmemoTextBox As TextBox
    Friend WithEvents ObsoleteCheckBox As CheckBox
    Friend WithEvents DescriptnTextBox As TextBox
    Friend WithEvents CcodeTextBox As TextBox
    Friend WithEvents IdupdateDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
