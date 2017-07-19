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
        Dim EdateLabel As System.Windows.Forms.Label
        Dim CnameLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim Ref_noLabel As System.Windows.Forms.Label
        Dim Tel_noLabel As System.Windows.Forms.Label
        Dim Fax_noLabel As System.Windows.Forms.Label
        Dim Mobtel_noLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Ship_nameLabel As System.Windows.Forms.Label
        Dim AccnoLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim EtypeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.TransvacDataV2DataSet = New ENQUIRYNEW.TransvacDataV2DataSet()
        Me.EnquiryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnquiryTableAdapter = New ENQUIRYNEW.TransvacDataV2DataSetTableAdapters.enquiryTableAdapter()
        Me.TableAdapterManager = New ENQUIRYNEW.TransvacDataV2DataSetTableAdapters.TableAdapterManager()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        EdateLabel = New System.Windows.Forms.Label()
        CnameLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        Ref_noLabel = New System.Windows.Forms.Label()
        Tel_noLabel = New System.Windows.Forms.Label()
        Fax_noLabel = New System.Windows.Forms.Label()
        Mobtel_noLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Ship_nameLabel = New System.Windows.Forms.Label()
        AccnoLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        EtypeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.TransvacDataV2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EdateLabel
        '
        EdateLabel.AutoSize = True
        EdateLabel.Location = New System.Drawing.Point(488, 97)
        EdateLabel.Name = "EdateLabel"
        EdateLabel.Size = New System.Drawing.Size(73, 13)
        EdateLabel.TabIndex = 1
        EdateLabel.Text = "Date Created:"
        '
        'CnameLabel
        '
        CnameLabel.AutoSize = True
        CnameLabel.Location = New System.Drawing.Point(72, 124)
        CnameLabel.Name = "CnameLabel"
        CnameLabel.Size = New System.Drawing.Size(85, 13)
        CnameLabel.TabIndex = 3
        CnameLabel.Text = "Customer Name:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(408, 122)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(47, 13)
        ContactLabel.TabIndex = 5
        ContactLabel.Text = "Contact:"
        '
        'Ref_noLabel
        '
        Ref_noLabel.AutoSize = True
        Ref_noLabel.Location = New System.Drawing.Point(407, 158)
        Ref_noLabel.Name = "Ref_noLabel"
        Ref_noLabel.Size = New System.Drawing.Size(44, 13)
        Ref_noLabel.TabIndex = 7
        Ref_noLabel.Text = "Ref No:"
        '
        'Tel_noLabel
        '
        Tel_noLabel.AutoSize = True
        Tel_noLabel.Location = New System.Drawing.Point(406, 186)
        Tel_noLabel.Name = "Tel_noLabel"
        Tel_noLabel.Size = New System.Drawing.Size(40, 13)
        Tel_noLabel.TabIndex = 9
        Tel_noLabel.Text = "Tel no:"
        '
        'Fax_noLabel
        '
        Fax_noLabel.AutoSize = True
        Fax_noLabel.Location = New System.Drawing.Point(406, 210)
        Fax_noLabel.Name = "Fax_noLabel"
        Fax_noLabel.Size = New System.Drawing.Size(42, 13)
        Fax_noLabel.TabIndex = 11
        Fax_noLabel.Text = "Fax no:"
        '
        'Mobtel_noLabel
        '
        Mobtel_noLabel.AutoSize = True
        Mobtel_noLabel.Location = New System.Drawing.Point(407, 236)
        Mobtel_noLabel.Name = "Mobtel_noLabel"
        Mobtel_noLabel.Size = New System.Drawing.Size(58, 13)
        Mobtel_noLabel.TabIndex = 13
        Mobtel_noLabel.Text = "Mobile No:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(409, 264)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(39, 13)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "E-Mail:"
        '
        'Ship_nameLabel
        '
        Ship_nameLabel.AutoSize = True
        Ship_nameLabel.Location = New System.Drawing.Point(407, 293)
        Ship_nameLabel.Name = "Ship_nameLabel"
        Ship_nameLabel.Size = New System.Drawing.Size(62, 13)
        Ship_nameLabel.TabIndex = 17
        Ship_nameLabel.Text = "Ship Name:"
        '
        'AccnoLabel
        '
        AccnoLabel.AutoSize = True
        AccnoLabel.Location = New System.Drawing.Point(488, 71)
        AccnoLabel.Name = "AccnoLabel"
        AccnoLabel.Size = New System.Drawing.Size(96, 13)
        AccnoLabel.TabIndex = 21
        AccnoLabel.Text = "Customer Acct No:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(100, 457)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 23
        StatusLabel.Text = "Status:"
        '
        'EtypeLabel
        '
        EtypeLabel.AutoSize = True
        EtypeLabel.Location = New System.Drawing.Point(104, 485)
        EtypeLabel.Name = "EtypeLabel"
        EtypeLabel.Size = New System.Drawing.Size(34, 13)
        EtypeLabel.TabIndex = 28
        EtypeLabel.Text = "Type:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(72, 324)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 13)
        Label1.TabIndex = 48
        Label1.Text = "Account Type"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(266, 322)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(31, 13)
        Label2.TabIndex = 49
        Label2.Text = "Days"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(72, 196)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(48, 13)
        Label3.TabIndex = 51
        Label3.Text = "Address:"
        '
        'TransvacDataV2DataSet
        '
        Me.TransvacDataV2DataSet.DataSetName = "TransvacDataV2DataSet"
        Me.TransvacDataV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EnquiryBindingSource
        '
        Me.EnquiryBindingSource.DataMember = "enquiry"
        Me.EnquiryBindingSource.DataSource = Me.TransvacDataV2DataSet
        '
        'EnquiryTableAdapter
        '
        Me.EnquiryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accctlTableAdapter = Nothing
        Me.TableAdapterManager.accountTableAdapter = Nothing
        Me.TableAdapterManager.addnotesTableAdapter = Nothing
        Me.TableAdapterManager.assetsnewTableAdapter = Nothing
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
        Me.TableAdapterManager.tran2TableAdapter = Nothing
        Me.TableAdapterManager.tranbinsTableAdapter = Nothing
        Me.TableAdapterManager.tranctlTableAdapter = Nothing
        Me.TableAdapterManager.trandescTableAdapter = Nothing
        Me.TableAdapterManager.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ENQUIRYNEW.TransvacDataV2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "contact", True))
        Me.ContactTextBox.Location = New System.Drawing.Point(491, 120)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(208, 20)
        Me.ContactTextBox.TabIndex = 6
        '
        'Ref_noTextBox
        '
        Me.Ref_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "ref_no", True))
        Me.Ref_noTextBox.Location = New System.Drawing.Point(490, 155)
        Me.Ref_noTextBox.Name = "Ref_noTextBox"
        Me.Ref_noTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Ref_noTextBox.TabIndex = 8
        '
        'Tel_noTextBox
        '
        Me.Tel_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "tel_no", True))
        Me.Tel_noTextBox.Location = New System.Drawing.Point(490, 181)
        Me.Tel_noTextBox.Name = "Tel_noTextBox"
        Me.Tel_noTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Tel_noTextBox.TabIndex = 10
        '
        'Fax_noTextBox
        '
        Me.Fax_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "fax_no", True))
        Me.Fax_noTextBox.Location = New System.Drawing.Point(490, 207)
        Me.Fax_noTextBox.Name = "Fax_noTextBox"
        Me.Fax_noTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Fax_noTextBox.TabIndex = 12
        '
        'Mobtel_noTextBox
        '
        Me.Mobtel_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "mobtel_no", True))
        Me.Mobtel_noTextBox.Location = New System.Drawing.Point(490, 233)
        Me.Mobtel_noTextBox.Name = "Mobtel_noTextBox"
        Me.Mobtel_noTextBox.Size = New System.Drawing.Size(209, 20)
        Me.Mobtel_noTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(490, 259)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(209, 20)
        Me.EmailTextBox.TabIndex = 16
        '
        'Ship_nameTextBox
        '
        Me.Ship_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "ship_name", True))
        Me.Ship_nameTextBox.Location = New System.Drawing.Point(489, 285)
        Me.Ship_nameTextBox.Name = "Ship_nameTextBox"
        Me.Ship_nameTextBox.Size = New System.Drawing.Size(210, 20)
        Me.Ship_nameTextBox.TabIndex = 18
        '
        'EmemoTextBox
        '
        Me.EmemoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "ememo", True))
        Me.EmemoTextBox.Location = New System.Drawing.Point(163, 356)
        Me.EmemoTextBox.Multiline = True
        Me.EmemoTextBox.Name = "EmemoTextBox"
        Me.EmemoTextBox.Size = New System.Drawing.Size(537, 80)
        Me.EmemoTextBox.TabIndex = 20
        '
        'AccnoTextBox
        '
        Me.AccnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "accno", True))
        Me.AccnoTextBox.Location = New System.Drawing.Point(584, 68)
        Me.AccnoTextBox.Name = "AccnoTextBox"
        Me.AccnoTextBox.Size = New System.Drawing.Size(116, 20)
        Me.AccnoTextBox.TabIndex = 22
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"ENQUIRY", "AWAITING DETAILS", "REJECTED", "SUPPLIER QUOTE", "QUOTED", "INVOICED", "STRAIGHT ORDER", "COMPLETED", "ARCHIVED"})
        Me.StatusComboBox.Location = New System.Drawing.Point(163, 454)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StatusComboBox.TabIndex = 24
        '
        'EtypeComboBox
        '
        Me.EtypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "etype", True))
        Me.EtypeComboBox.FormattingEnabled = True
        Me.EtypeComboBox.Items.AddRange(New Object() {"TELEPHONE", "FAX", "E-MAIL", "POST", "WEBSITE"})
        Me.EtypeComboBox.Location = New System.Drawing.Point(163, 482)
        Me.EtypeComboBox.Name = "EtypeComboBox"
        Me.EtypeComboBox.Size = New System.Drawing.Size(122, 21)
        Me.EtypeComboBox.TabIndex = 29
        '
        'btnabt
        '
        Me.btnabt.Location = New System.Drawing.Point(163, 518)
        Me.btnabt.Name = "btnabt"
        Me.btnabt.Size = New System.Drawing.Size(75, 23)
        Me.btnabt.TabIndex = 30
        Me.btnabt.Text = "ABORT"
        Me.btnabt.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(244, 518)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(642, 319)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "PRINT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(489, 319)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 23)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "CONTINUATION"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "ENQUIRY"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "FIND ADDRESS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "contact", True))
        Me.TextBox2.Location = New System.Drawing.Point(163, 123)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(208, 20)
        Me.TextBox2.TabIndex = 40
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "contact", True))
        Me.TextBox3.Location = New System.Drawing.Point(163, 293)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(208, 20)
        Me.TextBox3.TabIndex = 41
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "contact", True))
        Me.TextBox5.Location = New System.Drawing.Point(163, 267)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(208, 20)
        Me.TextBox5.TabIndex = 43
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "contact", True))
        Me.TextBox6.Location = New System.Drawing.Point(163, 241)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(208, 20)
        Me.TextBox6.TabIndex = 44
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "contact", True))
        Me.TextBox7.Location = New System.Drawing.Point(163, 215)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(208, 20)
        Me.TextBox7.TabIndex = 45
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "contact", True))
        Me.TextBox8.Location = New System.Drawing.Point(163, 189)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(208, 20)
        Me.TextBox8.TabIndex = 46
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "etype", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"TELEPHONE", "FAX", "E-MAIL", "POST", "WEBSITE"})
        Me.ComboBox1.Location = New System.Drawing.Point(163, 319)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(76, 21)
        Me.ComboBox1.TabIndex = 47
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "accno", True))
        Me.TextBox4.Location = New System.Drawing.Point(318, 319)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(53, 20)
        Me.TextBox4.TabIndex = 50
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(607, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 50)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "GENERATE QUOTATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnquiryBindingSource, "accno", True))
        Me.TextBox1.Location = New System.Drawing.Point(584, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 52
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(507, 442)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(84, 23)
        Me.Button14.TabIndex = 71
        Me.Button14.Text = "QUOTE LIST"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ENQUIRYNEW.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'enquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(761, 590)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnabt)
        Me.Controls.Add(EtypeLabel)
        Me.Controls.Add(Me.EtypeComboBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(AccnoLabel)
        Me.Controls.Add(Me.AccnoTextBox)
        Me.Controls.Add(Me.EmemoTextBox)
        Me.Controls.Add(Ship_nameLabel)
        Me.Controls.Add(Me.Ship_nameTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Mobtel_noLabel)
        Me.Controls.Add(Me.Mobtel_noTextBox)
        Me.Controls.Add(Fax_noLabel)
        Me.Controls.Add(Me.Fax_noTextBox)
        Me.Controls.Add(Tel_noLabel)
        Me.Controls.Add(Me.Tel_noTextBox)
        Me.Controls.Add(Ref_noLabel)
        Me.Controls.Add(Me.Ref_noTextBox)
        Me.Controls.Add(ContactLabel)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(CnameLabel)
        Me.Controls.Add(EdateLabel)
        Me.Name = "enquiry"
        Me.Text = "Enquiry"
        CType(Me.TransvacDataV2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TransvacDataV2DataSet As TransvacDataV2DataSet
    Friend WithEvents EnquiryBindingSource As BindingSource
    Friend WithEvents EnquiryTableAdapter As TransvacDataV2DataSetTableAdapters.enquiryTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button14 As Button
End Class
