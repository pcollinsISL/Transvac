<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inveditbin
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
        Dim LocatebinLabel As System.Windows.Forms.Label
        Dim AssuredLabel As System.Windows.Forms.Label
        Dim SourcecdeLabel As System.Windows.Forms.Label
        Dim AllocLabel As System.Windows.Forms.Label
        Dim Currcy_cdeLabel As System.Windows.Forms.Label
        Dim Unit_valueLabel As System.Windows.Forms.Label
        Dim Catalog_dtLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim WqtyLabel As System.Windows.Forms.Label
        Dim QuantybinLabel As System.Windows.Forms.Label
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TranbinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TranbinsTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.LocatebinTextBox = New System.Windows.Forms.TextBox()
        Me.AssuredTextBox = New System.Windows.Forms.TextBox()
        Me.SourcecdeTextBox = New System.Windows.Forms.TextBox()
        Me.AllocTextBox = New System.Windows.Forms.TextBox()
        Me.Currcy_cdeTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_valueTextBox = New System.Windows.Forms.TextBox()
        Me.Catalog_dtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.WqtyTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.QuantybinTextBox = New System.Windows.Forms.TextBox()
        Me.abortbtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.idcode = New System.Windows.Forms.TextBox()
        LocatebinLabel = New System.Windows.Forms.Label()
        AssuredLabel = New System.Windows.Forms.Label()
        SourcecdeLabel = New System.Windows.Forms.Label()
        AllocLabel = New System.Windows.Forms.Label()
        Currcy_cdeLabel = New System.Windows.Forms.Label()
        Unit_valueLabel = New System.Windows.Forms.Label()
        Catalog_dtLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        WqtyLabel = New System.Windows.Forms.Label()
        QuantybinLabel = New System.Windows.Forms.Label()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LocatebinLabel
        '
        LocatebinLabel.AutoSize = True
        LocatebinLabel.Location = New System.Drawing.Point(258, 168)
        LocatebinLabel.Name = "LocatebinLabel"
        LocatebinLabel.Size = New System.Drawing.Size(53, 13)
        LocatebinLabel.TabIndex = 1
        LocatebinLabel.Text = "Bin Code:"
        '
        'AssuredLabel
        '
        AssuredLabel.AutoSize = True
        AssuredLabel.Location = New System.Drawing.Point(445, 117)
        AssuredLabel.Name = "AssuredLabel"
        AssuredLabel.Size = New System.Drawing.Size(45, 13)
        AssuredLabel.TabIndex = 3
        AssuredLabel.Text = "Assured"
        '
        'SourcecdeLabel
        '
        SourcecdeLabel.AutoSize = True
        SourcecdeLabel.Location = New System.Drawing.Point(37, 121)
        SourcecdeLabel.Name = "SourcecdeLabel"
        SourcecdeLabel.Size = New System.Drawing.Size(41, 13)
        SourcecdeLabel.TabIndex = 5
        SourcecdeLabel.Text = "Source"
        '
        'AllocLabel
        '
        AllocLabel.AutoSize = True
        AllocLabel.Location = New System.Drawing.Point(445, 228)
        AllocLabel.Name = "AllocLabel"
        AllocLabel.Size = New System.Drawing.Size(73, 13)
        AllocLabel.TabIndex = 7
        AllocLabel.Text = "Allocated Qty:"
        '
        'Currcy_cdeLabel
        '
        Currcy_cdeLabel.AutoSize = True
        Currcy_cdeLabel.Location = New System.Drawing.Point(237, 121)
        Currcy_cdeLabel.Name = "Currcy_cdeLabel"
        Currcy_cdeLabel.Size = New System.Drawing.Size(80, 13)
        Currcy_cdeLabel.TabIndex = 9
        Currcy_cdeLabel.Text = "Currency Code:"
        '
        'Unit_valueLabel
        '
        Unit_valueLabel.AutoSize = True
        Unit_valueLabel.Location = New System.Drawing.Point(445, 168)
        Unit_valueLabel.Name = "Unit_valueLabel"
        Unit_valueLabel.Size = New System.Drawing.Size(59, 13)
        Unit_valueLabel.TabIndex = 11
        Unit_valueLabel.Text = "Unit Value:"
        '
        'Catalog_dtLabel
        '
        Catalog_dtLabel.AutoSize = True
        Catalog_dtLabel.Location = New System.Drawing.Point(521, 58)
        Catalog_dtLabel.Name = "Catalog_dtLabel"
        Catalog_dtLabel.Size = New System.Drawing.Size(72, 13)
        Catalog_dtLabel.TabIndex = 13
        Catalog_dtLabel.Text = "Catalog Date:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(276, 279)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 17
        WeightLabel.Text = "Weight:"
        '
        'WqtyLabel
        '
        WqtyLabel.AutoSize = True
        WqtyLabel.Location = New System.Drawing.Point(445, 279)
        WqtyLabel.Name = "WqtyLabel"
        WqtyLabel.Size = New System.Drawing.Size(37, 13)
        WqtyLabel.TabIndex = 19
        WqtyLabel.Text = "WQty:"
        '
        'QuantybinLabel
        '
        QuantybinLabel.AutoSize = True
        QuantybinLabel.Location = New System.Drawing.Point(260, 224)
        QuantybinLabel.Name = "QuantybinLabel"
        QuantybinLabel.Size = New System.Drawing.Size(57, 13)
        QuantybinLabel.TabIndex = 21
        QuantybinLabel.Text = "Stock Qty:"
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
        Me.TableAdapterManager.tranbinsTableAdapter = Me.TranbinsTableAdapter
        Me.TableAdapterManager.tranctlTableAdapter = Nothing
        Me.TableAdapterManager.trandescTableAdapter = Nothing
        Me.TableAdapterManager.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LocatebinTextBox
        '
        Me.LocatebinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "locatebin", True))
        Me.LocatebinTextBox.Location = New System.Drawing.Point(323, 165)
        Me.LocatebinTextBox.Name = "LocatebinTextBox"
        Me.LocatebinTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocatebinTextBox.TabIndex = 2
        '
        'AssuredTextBox
        '
        Me.AssuredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "assured", True))
        Me.AssuredTextBox.Location = New System.Drawing.Point(524, 114)
        Me.AssuredTextBox.Name = "AssuredTextBox"
        Me.AssuredTextBox.Size = New System.Drawing.Size(40, 20)
        Me.AssuredTextBox.TabIndex = 4
        '
        'SourcecdeTextBox
        '
        Me.SourcecdeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "sourcecde", True))
        Me.SourcecdeTextBox.Location = New System.Drawing.Point(103, 118)
        Me.SourcecdeTextBox.Name = "SourcecdeTextBox"
        Me.SourcecdeTextBox.Size = New System.Drawing.Size(129, 20)
        Me.SourcecdeTextBox.TabIndex = 6
        '
        'AllocTextBox
        '
        Me.AllocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "alloc", True))
        Me.AllocTextBox.Location = New System.Drawing.Point(524, 221)
        Me.AllocTextBox.Name = "AllocTextBox"
        Me.AllocTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AllocTextBox.TabIndex = 8
        '
        'Currcy_cdeTextBox
        '
        Me.Currcy_cdeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "currcy_cde", True))
        Me.Currcy_cdeTextBox.Location = New System.Drawing.Point(323, 118)
        Me.Currcy_cdeTextBox.Name = "Currcy_cdeTextBox"
        Me.Currcy_cdeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Currcy_cdeTextBox.TabIndex = 10
        '
        'Unit_valueTextBox
        '
        Me.Unit_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "unit_value", True))
        Me.Unit_valueTextBox.Location = New System.Drawing.Point(524, 165)
        Me.Unit_valueTextBox.Name = "Unit_valueTextBox"
        Me.Unit_valueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Unit_valueTextBox.TabIndex = 12
        '
        'Catalog_dtDateTimePicker
        '
        Me.Catalog_dtDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TranbinsBindingSource, "catalog_dt", True))
        Me.Catalog_dtDateTimePicker.Location = New System.Drawing.Point(599, 58)
        Me.Catalog_dtDateTimePicker.Name = "Catalog_dtDateTimePicker"
        Me.Catalog_dtDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Catalog_dtDateTimePicker.TabIndex = 14
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(323, 276)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WeightTextBox.TabIndex = 18
        '
        'WqtyTextBox
        '
        Me.WqtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "wqty", True))
        Me.WqtyTextBox.Location = New System.Drawing.Point(524, 279)
        Me.WqtyTextBox.Name = "WqtyTextBox"
        Me.WqtyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WqtyTextBox.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'QuantybinTextBox
        '
        Me.QuantybinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TranbinsBindingSource, "quantybin", True))
        Me.QuantybinTextBox.Location = New System.Drawing.Point(322, 221)
        Me.QuantybinTextBox.Name = "QuantybinTextBox"
        Me.QuantybinTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantybinTextBox.TabIndex = 22
        '
        'abortbtn
        '
        Me.abortbtn.Location = New System.Drawing.Point(103, 330)
        Me.abortbtn.Name = "abortbtn"
        Me.abortbtn.Size = New System.Drawing.Size(75, 23)
        Me.abortbtn.TabIndex = 23
        Me.abortbtn.Text = "ABORT"
        Me.abortbtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(724, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'idcode
        '
        Me.idcode.Location = New System.Drawing.Point(119, 168)
        Me.idcode.Name = "idcode"
        Me.idcode.Size = New System.Drawing.Size(100, 20)
        Me.idcode.TabIndex = 25
        '
        'inveditbin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 393)
        Me.Controls.Add(Me.idcode)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.abortbtn)
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
        Me.Name = "inveditbin"
        Me.Text = "Inventory Edit Bin"
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TranbinsBindingSource As BindingSource
    Friend WithEvents TranbinsTableAdapter As TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents LocatebinTextBox As TextBox
    Friend WithEvents AssuredTextBox As TextBox
    Friend WithEvents SourcecdeTextBox As TextBox
    Friend WithEvents AllocTextBox As TextBox
    Friend WithEvents Currcy_cdeTextBox As TextBox
    Friend WithEvents Unit_valueTextBox As TextBox
    Friend WithEvents Catalog_dtDateTimePicker As DateTimePicker
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents WqtyTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents QuantybinTextBox As TextBox
    Friend WithEvents abortbtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents idcode As TextBox
End Class
