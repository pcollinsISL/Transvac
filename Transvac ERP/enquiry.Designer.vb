<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class enquiry
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
        Me.EdateLabel = New System.Windows.Forms.Label()
        Me.CnameLabel = New System.Windows.Forms.Label()
        Me.ContactLabel = New System.Windows.Forms.Label()
        Me.Ref_noLabel = New System.Windows.Forms.Label()
        Me.Tel_noLabel = New System.Windows.Forms.Label()
        Me.Fax_noLabel = New System.Windows.Forms.Label()
        Me.Mobtel_noLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.Ship_nameLabel = New System.Windows.Forms.Label()
        Me.AccnoLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.EtypeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.EnquiryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.Ref_noTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_noTextBox = New System.Windows.Forms.TextBox()
        Me.Fax_noTextBox = New System.Windows.Forms.TextBox()
        Me.Mobtel_noTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Ship_nameTextBox = New System.Windows.Forms.TextBox()
        Me.EmemoTextBox = New System.Windows.Forms.TextBox()
        Me.AccnoTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.EtypeComboBox = New System.Windows.Forms.ComboBox()
        Me.btnabt = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnaddressbook = New System.Windows.Forms.Button()
        Me.CnameTextBox = New System.Windows.Forms.TextBox()
        Me.Add5TextBox = New System.Windows.Forms.TextBox()
        Me.Tran2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Add4TextBox = New System.Windows.Forms.TextBox()
        Me.Add3TextBox = New System.Windows.Forms.TextBox()
        Me.Add2TextBox = New System.Windows.Forms.TextBox()
        Me.Add1TextBox = New System.Windows.Forms.TextBox()
        Me.termsTextBox = New System.Windows.Forms.TextBox()
        Me.Btnquotegen = New System.Windows.Forms.Button()
        Me.Btnquote = New System.Windows.Forms.Button()
        Me.qotenoLabel = New System.Windows.Forms.Label()
        Me.qotenoTextBox = New System.Windows.Forms.TextBox()
        Me.DateCreaTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Tran2TableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.tran2TableAdapter()
        Me.AccountTableAdapter1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.accountTableAdapter()
        Me.EnquiryTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.enquiryTableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.AcctComboBox = New System.Windows.Forms.ComboBox()
        Me.TransvacDataV2DataSet11 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TransvacDataV2DataSet11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet11BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressRecordTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressRecordTypeTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.AddressRecordTypeTableAdapter()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tran2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet11BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressRecordTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EdateLabel
        '
        Me.EdateLabel.AutoSize = True
        Me.EdateLabel.Location = New System.Drawing.Point(565, 123)
        Me.EdateLabel.Name = "EdateLabel"
        Me.EdateLabel.Size = New System.Drawing.Size(73, 13)
        Me.EdateLabel.TabIndex = 1
        Me.EdateLabel.Text = "Date Created:"
        '
        'CnameLabel
        '
        Me.CnameLabel.AutoSize = True
        Me.CnameLabel.Location = New System.Drawing.Point(44, 156)
        Me.CnameLabel.Name = "CnameLabel"
        Me.CnameLabel.Size = New System.Drawing.Size(85, 13)
        Me.CnameLabel.TabIndex = 3
        Me.CnameLabel.Text = "Customer Name:"
        '
        'ContactLabel
        '
        Me.ContactLabel.AutoSize = True
        Me.ContactLabel.Location = New System.Drawing.Point(428, 159)
        Me.ContactLabel.Name = "ContactLabel"
        Me.ContactLabel.Size = New System.Drawing.Size(47, 13)
        Me.ContactLabel.TabIndex = 5
        Me.ContactLabel.Text = "Contact:"
        '
        'Ref_noLabel
        '
        Me.Ref_noLabel.AutoSize = True
        Me.Ref_noLabel.Location = New System.Drawing.Point(427, 218)
        Me.Ref_noLabel.Name = "Ref_noLabel"
        Me.Ref_noLabel.Size = New System.Drawing.Size(44, 13)
        Me.Ref_noLabel.TabIndex = 7
        Me.Ref_noLabel.Text = "Ref No:"
        '
        'Tel_noLabel
        '
        Me.Tel_noLabel.AutoSize = True
        Me.Tel_noLabel.Location = New System.Drawing.Point(426, 246)
        Me.Tel_noLabel.Name = "Tel_noLabel"
        Me.Tel_noLabel.Size = New System.Drawing.Size(40, 13)
        Me.Tel_noLabel.TabIndex = 9
        Me.Tel_noLabel.Text = "Tel no:"
        '
        'Fax_noLabel
        '
        Me.Fax_noLabel.AutoSize = True
        Me.Fax_noLabel.Location = New System.Drawing.Point(426, 271)
        Me.Fax_noLabel.Name = "Fax_noLabel"
        Me.Fax_noLabel.Size = New System.Drawing.Size(42, 13)
        Me.Fax_noLabel.TabIndex = 11
        Me.Fax_noLabel.Text = "Fax no:"
        '
        'Mobtel_noLabel
        '
        Me.Mobtel_noLabel.AutoSize = True
        Me.Mobtel_noLabel.Location = New System.Drawing.Point(427, 296)
        Me.Mobtel_noLabel.Name = "Mobtel_noLabel"
        Me.Mobtel_noLabel.Size = New System.Drawing.Size(58, 13)
        Me.Mobtel_noLabel.TabIndex = 13
        Me.Mobtel_noLabel.Text = "Mobile No:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(429, 324)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(39, 13)
        Me.EmailLabel.TabIndex = 15
        Me.EmailLabel.Text = "E-Mail:"
        '
        'Ship_nameLabel
        '
        Me.Ship_nameLabel.AutoSize = True
        Me.Ship_nameLabel.Location = New System.Drawing.Point(427, 348)
        Me.Ship_nameLabel.Name = "Ship_nameLabel"
        Me.Ship_nameLabel.Size = New System.Drawing.Size(62, 13)
        Me.Ship_nameLabel.TabIndex = 17
        Me.Ship_nameLabel.Text = "Ship Name:"
        '
        'AccnoLabel
        '
        Me.AccnoLabel.AutoSize = True
        Me.AccnoLabel.Location = New System.Drawing.Point(566, 58)
        Me.AccnoLabel.Name = "AccnoLabel"
        Me.AccnoLabel.Size = New System.Drawing.Size(96, 13)
        Me.AccnoLabel.TabIndex = 21
        Me.AccnoLabel.Text = "Customer Acct No:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(73, 529)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(40, 13)
        Me.StatusLabel.TabIndex = 23
        Me.StatusLabel.Text = "Status:"
        '
        'EtypeLabel
        '
        Me.EtypeLabel.AutoSize = True
        Me.EtypeLabel.Location = New System.Drawing.Point(77, 557)
        Me.EtypeLabel.Name = "EtypeLabel"
        Me.EtypeLabel.Size = New System.Drawing.Size(34, 13)
        Me.EtypeLabel.TabIndex = 28
        Me.EtypeLabel.Text = "Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Account Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "TERMS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Address:"
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(506, 157)
        Me.ContactTextBox.MaxLength = 20
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(258, 20)
        Me.ContactTextBox.TabIndex = 6
        '
        'EnquiryBindingSource
        '
        Me.EnquiryBindingSource.DataMember = "enquiry"
        Me.EnquiryBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ref_noTextBox
        '
        Me.Ref_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "ref_no", True))
        Me.Ref_noTextBox.Location = New System.Drawing.Point(505, 215)
        Me.Ref_noTextBox.MaxLength = 20
        Me.Ref_noTextBox.Name = "Ref_noTextBox"
        Me.Ref_noTextBox.Size = New System.Drawing.Size(259, 20)
        Me.Ref_noTextBox.TabIndex = 8
        '
        'Tel_noTextBox
        '
        Me.Tel_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "tel_no", True))
        Me.Tel_noTextBox.Location = New System.Drawing.Point(505, 241)
        Me.Tel_noTextBox.MaxLength = 20
        Me.Tel_noTextBox.Name = "Tel_noTextBox"
        Me.Tel_noTextBox.Size = New System.Drawing.Size(259, 20)
        Me.Tel_noTextBox.TabIndex = 10
        '
        'Fax_noTextBox
        '
        Me.Fax_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "fax_no", True))
        Me.Fax_noTextBox.Location = New System.Drawing.Point(505, 267)
        Me.Fax_noTextBox.MaxLength = 20
        Me.Fax_noTextBox.Name = "Fax_noTextBox"
        Me.Fax_noTextBox.Size = New System.Drawing.Size(259, 20)
        Me.Fax_noTextBox.TabIndex = 12
        '
        'Mobtel_noTextBox
        '
        Me.Mobtel_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "mobtel_no", True))
        Me.Mobtel_noTextBox.Location = New System.Drawing.Point(505, 293)
        Me.Mobtel_noTextBox.MaxLength = 25
        Me.Mobtel_noTextBox.Name = "Mobtel_noTextBox"
        Me.Mobtel_noTextBox.Size = New System.Drawing.Size(259, 20)
        Me.Mobtel_noTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(505, 319)
        Me.EmailTextBox.MaxLength = 50
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(259, 20)
        Me.EmailTextBox.TabIndex = 16
        '
        'Ship_nameTextBox
        '
        Me.Ship_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "ship_name", True))
        Me.Ship_nameTextBox.Location = New System.Drawing.Point(506, 346)
        Me.Ship_nameTextBox.MaxLength = 20
        Me.Ship_nameTextBox.Name = "Ship_nameTextBox"
        Me.Ship_nameTextBox.Size = New System.Drawing.Size(258, 20)
        Me.Ship_nameTextBox.TabIndex = 18
        '
        'EmemoTextBox
        '
        Me.EmemoTextBox.Location = New System.Drawing.Point(136, 427)
        Me.EmemoTextBox.Multiline = True
        Me.EmemoTextBox.Name = "EmemoTextBox"
        Me.EmemoTextBox.Size = New System.Drawing.Size(628, 80)
        Me.EmemoTextBox.TabIndex = 20
        '
        'AccnoTextBox
        '
        Me.AccnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "accno", True))
        Me.AccnoTextBox.Location = New System.Drawing.Point(685, 55)
        Me.AccnoTextBox.MaxLength = 6
        Me.AccnoTextBox.Name = "AccnoTextBox"
        Me.AccnoTextBox.Size = New System.Drawing.Size(79, 20)
        Me.AccnoTextBox.TabIndex = 22
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"ENQUIRY", "AWAITING DETAILS", "REJECTED", "SUPPLIER QUOTE", "QUOTED", "INVOICED", "STRAIGHT ORDER", "COMPLETED", "ARCHIVED"})
        Me.StatusComboBox.Location = New System.Drawing.Point(136, 524)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(106, 21)
        Me.StatusComboBox.TabIndex = 24
        '
        'EtypeComboBox
        '
        Me.EtypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "etype", True))
        Me.EtypeComboBox.FormattingEnabled = True
        Me.EtypeComboBox.Items.AddRange(New Object() {"TELEPHONE", "FAX", "E-MAIL", "POST", "WEBSITE"})
        Me.EtypeComboBox.Location = New System.Drawing.Point(136, 552)
        Me.EtypeComboBox.Name = "EtypeComboBox"
        Me.EtypeComboBox.Size = New System.Drawing.Size(106, 21)
        Me.EtypeComboBox.TabIndex = 29
        '
        'btnabt
        '
        Me.btnabt.Location = New System.Drawing.Point(136, 588)
        Me.btnabt.Name = "btnabt"
        Me.btnabt.Size = New System.Drawing.Size(75, 32)
        Me.btnabt.TabIndex = 30
        Me.btnabt.Text = "ABORT"
        Me.btnabt.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(217, 588)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 32)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(692, 376)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 31)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "PRINT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(504, 376)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 31)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "CONTINUATION"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "ENQUIRY"
        '
        'Btnaddressbook
        '
        Me.Btnaddressbook.Location = New System.Drawing.Point(136, 204)
        Me.Btnaddressbook.Name = "Btnaddressbook"
        Me.Btnaddressbook.Size = New System.Drawing.Size(106, 34)
        Me.Btnaddressbook.TabIndex = 37
        Me.Btnaddressbook.Text = "FIND ADDRESS"
        Me.Btnaddressbook.UseVisualStyleBackColor = True
        '
        'CnameTextBox
        '
        Me.CnameTextBox.Location = New System.Drawing.Point(136, 155)
        Me.CnameTextBox.MaxLength = 300
        Me.CnameTextBox.Name = "CnameTextBox"
        Me.CnameTextBox.Size = New System.Drawing.Size(237, 20)
        Me.CnameTextBox.TabIndex = 40
        '
        'Add5TextBox
        '
        Me.Add5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "ad5", True))
        Me.Add5TextBox.Location = New System.Drawing.Point(136, 348)
        Me.Add5TextBox.Name = "Add5TextBox"
        Me.Add5TextBox.Size = New System.Drawing.Size(237, 20)
        Me.Add5TextBox.TabIndex = 41
        '
        'Tran2BindingSource
        '
        Me.Tran2BindingSource.DataMember = "tran2"
        Me.Tran2BindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'Add4TextBox
        '
        Me.Add4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "ad4", True))
        Me.Add4TextBox.Location = New System.Drawing.Point(136, 322)
        Me.Add4TextBox.Name = "Add4TextBox"
        Me.Add4TextBox.Size = New System.Drawing.Size(237, 20)
        Me.Add4TextBox.TabIndex = 43
        '
        'Add3TextBox
        '
        Me.Add3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "ad3", True))
        Me.Add3TextBox.Location = New System.Drawing.Point(136, 296)
        Me.Add3TextBox.Name = "Add3TextBox"
        Me.Add3TextBox.Size = New System.Drawing.Size(237, 20)
        Me.Add3TextBox.TabIndex = 44
        '
        'Add2TextBox
        '
        Me.Add2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "ad2", True))
        Me.Add2TextBox.Location = New System.Drawing.Point(136, 270)
        Me.Add2TextBox.Name = "Add2TextBox"
        Me.Add2TextBox.Size = New System.Drawing.Size(237, 20)
        Me.Add2TextBox.TabIndex = 45
        '
        'Add1TextBox
        '
        Me.Add1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "ad1", True))
        Me.Add1TextBox.Location = New System.Drawing.Point(136, 244)
        Me.Add1TextBox.Name = "Add1TextBox"
        Me.Add1TextBox.Size = New System.Drawing.Size(237, 20)
        Me.Add1TextBox.TabIndex = 46
        '
        'termsTextBox
        '
        Me.termsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "termdays", True))
        Me.termsTextBox.Location = New System.Drawing.Point(314, 377)
        Me.termsTextBox.Name = "termsTextBox"
        Me.termsTextBox.Size = New System.Drawing.Size(59, 20)
        Me.termsTextBox.TabIndex = 50
        '
        'Btnquotegen
        '
        Me.Btnquotegen.Location = New System.Drawing.Point(671, 570)
        Me.Btnquotegen.Name = "Btnquotegen"
        Me.Btnquotegen.Size = New System.Drawing.Size(93, 50)
        Me.Btnquotegen.TabIndex = 31
        Me.Btnquotegen.Text = "GENERATE QUOTATION"
        Me.Btnquotegen.UseVisualStyleBackColor = True
        '
        'Btnquote
        '
        Me.Btnquote.Location = New System.Drawing.Point(581, 580)
        Me.Btnquote.Name = "Btnquote"
        Me.Btnquote.Size = New System.Drawing.Size(84, 30)
        Me.Btnquote.TabIndex = 71
        Me.Btnquote.Text = "QUOTE LIST"
        Me.Btnquote.UseVisualStyleBackColor = True
        '
        'qotenoLabel
        '
        Me.qotenoLabel.AutoSize = True
        Me.qotenoLabel.Location = New System.Drawing.Point(566, 81)
        Me.qotenoLabel.Name = "qotenoLabel"
        Me.qotenoLabel.Size = New System.Drawing.Size(56, 13)
        Me.qotenoLabel.TabIndex = 72
        Me.qotenoLabel.Text = "Quote No:"
        '
        'qotenoTextBox
        '
        Me.qotenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "quote_no", True))
        Me.qotenoTextBox.Location = New System.Drawing.Point(685, 81)
        Me.qotenoTextBox.MaxLength = 6
        Me.qotenoTextBox.Name = "qotenoTextBox"
        Me.qotenoTextBox.Size = New System.Drawing.Size(79, 20)
        Me.qotenoTextBox.TabIndex = 73
        '
        'DateCreaTextBox
        '
        Me.DateCreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "edate", True))
        Me.DateCreaTextBox.Location = New System.Drawing.Point(685, 117)
        Me.DateCreaTextBox.Name = "DateCreaTextBox"
        Me.DateCreaTextBox.Size = New System.Drawing.Size(79, 20)
        Me.DateCreaTextBox.TabIndex = 52
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'Tran2TableAdapter
        '
        Me.Tran2TableAdapter.ClearBeforeFill = True
        '
        'AccountTableAdapter1
        '
        Me.AccountTableAdapter1.ClearBeforeFill = True
        '
        'EnquiryTableAdapter
        '
        Me.EnquiryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accctlTableAdapter = Nothing
        Me.TableAdapterManager.accountTableAdapter = Me.AccountTableAdapter1
        Me.TableAdapterManager.addnotesTableAdapter = Nothing
        Me.TableAdapterManager.ASSETSNEWTableAdapter = Nothing
        Me.TableAdapterManager.assetsTableAdapter = Nothing
        Me.TableAdapterManager.atransTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.binallocTableAdapter = Nothing
        Me.TableAdapterManager.catTableAdapter = Nothing
        Me.TableAdapterManager.countryTableAdapter = Nothing
        Me.TableAdapterManager.custdiscTableAdapter = Nothing
        Me.TableAdapterManager.dummy_TableAdapter = Nothing
        Me.TableAdapterManager.enquiryTableAdapter = Me.EnquiryTableAdapter
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
        Me.TableAdapterManager.tran2TableAdapter = Me.Tran2TableAdapter
        Me.TableAdapterManager.tranbinsTableAdapter = Nothing
        Me.TableAdapterManager.tranctlTableAdapter = Nothing
        Me.TableAdapterManager.trandescTableAdapter = Nothing
        Me.TableAdapterManager.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AcctComboBox
        '
        Me.AcctComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tran2BindingSource, "entrytype", True))
        Me.AcctComboBox.DataSource = Me.AddressRecordTypeBindingSource
        Me.AcctComboBox.DisplayMember = "RecordTypeNew"
        Me.AcctComboBox.FormattingEnabled = True
        Me.AcctComboBox.Location = New System.Drawing.Point(136, 377)
        Me.AcctComboBox.Name = "AcctComboBox"
        Me.AcctComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AcctComboBox.TabIndex = 75
        Me.AcctComboBox.ValueMember = "RecordTypeOld"
        '
        'TransvacDataV2DataSet11
        '
        Me.TransvacDataV2DataSet11.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet11.EnforceConstraints = False
        Me.TransvacDataV2DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransvacDataV2DataSet11BindingSource
        '
        Me.TransvacDataV2DataSet11BindingSource.DataSource = Me.TransvacDataV2DataSet11
        Me.TransvacDataV2DataSet11BindingSource.Position = 0
        '
        'TransvacDataV2DataSet11BindingSource1
        '
        Me.TransvacDataV2DataSet11BindingSource1.DataSource = Me.TransvacDataV2DataSet11
        Me.TransvacDataV2DataSet11BindingSource1.Position = 0
        '
        'AddressRecordTypeBindingSource
        '
        Me.AddressRecordTypeBindingSource.DataMember = "AddressRecordType"
        Me.AddressRecordTypeBindingSource.DataSource = Me.TransvacDataV2DataSet11BindingSource
        '
        'AddressRecordTypeTableAdapter
        '
        Me.AddressRecordTypeTableAdapter.ClearBeforeFill = True
        '
        'enquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(813, 640)
        Me.Controls.Add(Me.AcctComboBox)
        Me.Controls.Add(Me.qotenoTextBox)
        Me.Controls.Add(Me.qotenoLabel)
        Me.Controls.Add(Me.Btnquote)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DateCreaTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.termsTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Add1TextBox)
        Me.Controls.Add(Me.Add2TextBox)
        Me.Controls.Add(Me.Add3TextBox)
        Me.Controls.Add(Me.Add4TextBox)
        Me.Controls.Add(Me.Add5TextBox)
        Me.Controls.Add(Me.CnameTextBox)
        Me.Controls.Add(Me.Btnaddressbook)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Btnquotegen)
        Me.Controls.Add(Me.btnabt)
        Me.Controls.Add(Me.EtypeLabel)
        Me.Controls.Add(Me.EtypeComboBox)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.AccnoLabel)
        Me.Controls.Add(Me.AccnoTextBox)
        Me.Controls.Add(Me.EmemoTextBox)
        Me.Controls.Add(Me.Ship_nameLabel)
        Me.Controls.Add(Me.Ship_nameTextBox)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Mobtel_noLabel)
        Me.Controls.Add(Me.Mobtel_noTextBox)
        Me.Controls.Add(Me.Fax_noLabel)
        Me.Controls.Add(Me.Fax_noTextBox)
        Me.Controls.Add(Me.Tel_noLabel)
        Me.Controls.Add(Me.Tel_noTextBox)
        Me.Controls.Add(Me.Ref_noLabel)
        Me.Controls.Add(Me.Ref_noTextBox)
        Me.Controls.Add(Me.ContactLabel)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Me.CnameLabel)
        Me.Controls.Add(Me.EdateLabel)
        Me.Name = "enquiry"
        Me.Text = "+"
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tran2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet11BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressRecordTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents Ref_noTextBox As TextBox
    Friend WithEvents Tel_noTextBox As TextBox
    Friend WithEvents Fax_noTextBox As TextBox
    Friend WithEvents Mobtel_noTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Ship_nameTextBox As TextBox
    Friend WithEvents EmemoTextBox As TextBox
    Friend WithEvents AccnoTextBox As TextBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents EtypeComboBox As ComboBox
    Friend WithEvents btnabt As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Btnaddressbook As Button
    Friend WithEvents CnameTextBox As TextBox
    Friend WithEvents Add5TextBox As TextBox
    Friend WithEvents Add4TextBox As TextBox
    Friend WithEvents Add3TextBox As TextBox
    Friend WithEvents Add2TextBox As TextBox
    Friend WithEvents Add1TextBox As TextBox
    Friend WithEvents termsTextBox As TextBox
    Friend WithEvents Btnquotegen As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btnquote As Button
    Friend WithEvents qotenoLabel As Label
    Friend WithEvents qotenoTextBox As TextBox
    Friend WithEvents Tran2BindingSource As BindingSource
    Friend WithEvents Tran2TableAdapter As TransvacDataV2DataSet1TableAdapters.tran2TableAdapter
    Friend WithEvents AccountTableAdapter1 As TransvacDataV2DataSet1TableAdapters.accountTableAdapter
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents DateCreaTextBox As TextBox
    Friend WithEvents EdateLabel As Label
    Friend WithEvents CnameLabel As Label
    Friend WithEvents ContactLabel As Label
    Friend WithEvents Ref_noLabel As Label
    Friend WithEvents Tel_noLabel As Label
    Friend WithEvents Fax_noLabel As Label
    Friend WithEvents Mobtel_noLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents Ship_nameLabel As Label
    Friend WithEvents AccnoLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents EtypeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EnquiryBindingSource As BindingSource
    Friend WithEvents EnquiryTableAdapter As TransvacDataV2DataSet1TableAdapters.enquiryTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AcctComboBox As ComboBox
    Friend WithEvents TransvacDataV2DataSet11BindingSource1 As BindingSource
    Friend WithEvents TransvacDataV2DataSet11 As TransvacDataV2DataSet1
    Friend WithEvents TransvacDataV2DataSet11BindingSource As BindingSource
    Friend WithEvents AddressRecordTypeBindingSource As BindingSource
    Friend WithEvents AddressRecordTypeTableAdapter As TransvacDataV2DataSet1TableAdapters.AddressRecordTypeTableAdapter
End Class
