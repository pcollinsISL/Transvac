<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class findquote
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
        Me.CustomerNameBox = New System.Windows.Forms.TextBox()
        Me.CustomerBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.QuoteNOBox = New System.Windows.Forms.TextBox()
        Me.SalesPersonBox = New System.Windows.Forms.TextBox()
        Me.StatusBox = New System.Windows.Forms.TextBox()
        Me.QuoteNoBtn = New System.Windows.Forms.Button()
        Me.SalesPersonBtn = New System.Windows.Forms.Button()
        Me.StatusBtn = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SelectBtn = New System.Windows.Forms.Button()
        Me.EnquiryDataGridView = New System.Windows.Forms.DataGridView()
        Me.EnquiryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TransvacDataV2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnquiryTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.enquiryTableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.Tran2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tran2TableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.tran2TableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ememo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ship_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobtel_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fax_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.etype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EnquiryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tran2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerNameBox
        '
        Me.CustomerNameBox.Location = New System.Drawing.Point(140, 85)
        Me.CustomerNameBox.Name = "CustomerNameBox"
        Me.CustomerNameBox.Size = New System.Drawing.Size(207, 20)
        Me.CustomerNameBox.TabIndex = 0
        '
        'CustomerBtn
        '
        Me.CustomerBtn.Location = New System.Drawing.Point(359, 84)
        Me.CustomerBtn.Name = "CustomerBtn"
        Me.CustomerBtn.Size = New System.Drawing.Size(61, 23)
        Me.CustomerBtn.TabIndex = 1
        Me.CustomerBtn.Text = "SEARCH"
        Me.CustomerBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quote No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sales Person:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Status:"
        '
        'QuoteNOBox
        '
        Me.QuoteNOBox.Location = New System.Drawing.Point(140, 121)
        Me.QuoteNOBox.Name = "QuoteNOBox"
        Me.QuoteNOBox.Size = New System.Drawing.Size(134, 20)
        Me.QuoteNOBox.TabIndex = 7
        '
        'SalesPersonBox
        '
        Me.SalesPersonBox.Location = New System.Drawing.Point(140, 156)
        Me.SalesPersonBox.Name = "SalesPersonBox"
        Me.SalesPersonBox.Size = New System.Drawing.Size(134, 20)
        Me.SalesPersonBox.TabIndex = 8
        '
        'StatusBox
        '
        Me.StatusBox.Location = New System.Drawing.Point(140, 192)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.Size = New System.Drawing.Size(134, 20)
        Me.StatusBox.TabIndex = 9
        '
        'QuoteNoBtn
        '
        Me.QuoteNoBtn.Location = New System.Drawing.Point(287, 120)
        Me.QuoteNoBtn.Name = "QuoteNoBtn"
        Me.QuoteNoBtn.Size = New System.Drawing.Size(61, 23)
        Me.QuoteNoBtn.TabIndex = 10
        Me.QuoteNoBtn.Text = "SEARCH"
        Me.QuoteNoBtn.UseVisualStyleBackColor = True
        '
        'SalesPersonBtn
        '
        Me.SalesPersonBtn.Location = New System.Drawing.Point(286, 155)
        Me.SalesPersonBtn.Name = "SalesPersonBtn"
        Me.SalesPersonBtn.Size = New System.Drawing.Size(61, 23)
        Me.SalesPersonBtn.TabIndex = 11
        Me.SalesPersonBtn.Text = "SEARCH"
        Me.SalesPersonBtn.UseVisualStyleBackColor = True
        '
        'StatusBtn
        '
        Me.StatusBtn.Location = New System.Drawing.Point(286, 190)
        Me.StatusBtn.Name = "StatusBtn"
        Me.StatusBtn.Size = New System.Drawing.Size(61, 23)
        Me.StatusBtn.TabIndex = 12
        Me.StatusBtn.Text = "SEARCH"
        Me.StatusBtn.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(37, 563)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "ABORT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'SelectBtn
        '
        Me.SelectBtn.Location = New System.Drawing.Point(133, 563)
        Me.SelectBtn.Name = "SelectBtn"
        Me.SelectBtn.Size = New System.Drawing.Size(75, 23)
        Me.SelectBtn.TabIndex = 14
        Me.SelectBtn.Text = "SELECT"
        Me.SelectBtn.UseVisualStyleBackColor = True
        '
        'EnquiryDataGridView
        '
        Me.EnquiryDataGridView.AllowUserToAddRows = False
        Me.EnquiryDataGridView.AllowUserToDeleteRows = False
        Me.EnquiryDataGridView.AllowUserToOrderColumns = True
        Me.EnquiryDataGridView.AutoGenerateColumns = False
        Me.EnquiryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EnquiryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EnquiryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EnquiryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn13, Me.accno, Me.ememo, Me.ship_name, Me.email, Me.mobtel_no, Me.fax_no, Me.tel_no, Me.contact, Me.edate, Me.etype})
        Me.EnquiryDataGridView.DataSource = Me.EnquiryBindingSource
        Me.EnquiryDataGridView.Location = New System.Drawing.Point(37, 243)
        Me.EnquiryDataGridView.Name = "EnquiryDataGridView"
        Me.EnquiryDataGridView.ReadOnly = True
        Me.EnquiryDataGridView.Size = New System.Drawing.Size(638, 305)
        Me.EnquiryDataGridView.TabIndex = 14
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "FIND ENQUIRY"
        '
        'TransvacDataV2DataSetBindingSource
        '
        Me.TransvacDataV2DataSetBindingSource.DataSource = Me.TransvacDataV2DataSet1
        Me.TransvacDataV2DataSetBindingSource.Position = 0
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
        Me.TableAdapterManager.AddressRecordTypeTableAdapter = Nothing
        Me.TableAdapterManager.ASSETSNEWTableAdapter = Nothing
        Me.TableAdapterManager.assetsTableAdapter = Nothing
        Me.TableAdapterManager.atransTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.binallocTableAdapter = Nothing
        Me.TableAdapterManager.catTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.trandescTableAdapter = Nothing
        Me.TableAdapterManager.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Tran2BindingSource
        '
        Me.Tran2BindingSource.DataMember = "tran2"
        Me.Tran2BindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'Tran2TableAdapter
        '
        Me.Tran2TableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cname"
        Me.DataGridViewTextBoxColumn3.FillWeight = 449.2386!
        Me.DataGridViewTextBoxColumn3.HeaderText = "CUSTOMER NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ref_no"
        Me.DataGridViewTextBoxColumn5.FillWeight = 18.88221!
        Me.DataGridViewTextBoxColumn5.HeaderText = "CUST REF"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 85
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "quote_no"
        Me.DataGridViewTextBoxColumn1.FillWeight = 19.94671!
        Me.DataGridViewTextBoxColumn1.HeaderText = "QUOTE NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 89
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ewho"
        Me.DataGridViewTextBoxColumn15.FillWeight = 5.966253!
        Me.DataGridViewTextBoxColumn15.HeaderText = "SALES PERSON"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 105
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn13.FillWeight = 5.966253!
        Me.DataGridViewTextBoxColumn13.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 75
        '
        'accno
        '
        Me.accno.DataPropertyName = "accno"
        Me.accno.HeaderText = "accno"
        Me.accno.Name = "accno"
        Me.accno.ReadOnly = True
        Me.accno.Visible = False
        '
        'ememo
        '
        Me.ememo.DataPropertyName = "ememo"
        Me.ememo.HeaderText = "ememo"
        Me.ememo.Name = "ememo"
        Me.ememo.ReadOnly = True
        Me.ememo.Visible = False
        '
        'ship_name
        '
        Me.ship_name.DataPropertyName = "ship_name"
        Me.ship_name.HeaderText = "ship_name"
        Me.ship_name.Name = "ship_name"
        Me.ship_name.ReadOnly = True
        Me.ship_name.Visible = False
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Visible = False
        '
        'mobtel_no
        '
        Me.mobtel_no.DataPropertyName = "mobtel_no"
        Me.mobtel_no.HeaderText = "mobtel_no"
        Me.mobtel_no.Name = "mobtel_no"
        Me.mobtel_no.ReadOnly = True
        Me.mobtel_no.Visible = False
        '
        'fax_no
        '
        Me.fax_no.DataPropertyName = "fax_no"
        Me.fax_no.HeaderText = "fax_no"
        Me.fax_no.Name = "fax_no"
        Me.fax_no.ReadOnly = True
        Me.fax_no.Visible = False
        '
        'tel_no
        '
        Me.tel_no.DataPropertyName = "tel_no"
        Me.tel_no.HeaderText = "tel_no"
        Me.tel_no.Name = "tel_no"
        Me.tel_no.ReadOnly = True
        Me.tel_no.Visible = False
        '
        'contact
        '
        Me.contact.DataPropertyName = "contact"
        Me.contact.HeaderText = "contact"
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        Me.contact.Visible = False
        '
        'edate
        '
        Me.edate.DataPropertyName = "edate"
        Me.edate.HeaderText = "edate"
        Me.edate.Name = "edate"
        Me.edate.ReadOnly = True
        Me.edate.Visible = False
        '
        'etype
        '
        Me.etype.DataPropertyName = "etype"
        Me.etype.HeaderText = "etype"
        Me.etype.Name = "etype"
        Me.etype.ReadOnly = True
        Me.etype.Visible = False
        '
        'findquote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1063, 606)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EnquiryDataGridView)
        Me.Controls.Add(Me.SelectBtn)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.StatusBtn)
        Me.Controls.Add(Me.SalesPersonBtn)
        Me.Controls.Add(Me.QuoteNoBtn)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.SalesPersonBox)
        Me.Controls.Add(Me.QuoteNOBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerBtn)
        Me.Controls.Add(Me.CustomerNameBox)
        Me.Name = "findquote"
        Me.Text = "Find Enquiry"
        CType(Me.EnquiryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tran2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameBox As TextBox
    Friend WithEvents CustomerBtn As Button
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TransvacDataV2DataSetBindingSource As BindingSource
    Friend WithEvents EnquiryBindingSource As BindingSource
    Friend WithEvents EnquiryTableAdapter As TransvacDataV2DataSet1TableAdapters.enquiryTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents QuoteNOBox As TextBox
    Friend WithEvents SalesPersonBox As TextBox
    Friend WithEvents StatusBox As TextBox
    Friend WithEvents QuoteNoBtn As Button
    Friend WithEvents SalesPersonBtn As Button
    Friend WithEvents StatusBtn As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents SelectBtn As Button
    Friend WithEvents EnquiryDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tran2BindingSource As BindingSource
    Friend WithEvents Tran2TableAdapter As TransvacDataV2DataSet1TableAdapters.tran2TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents accno As DataGridViewTextBoxColumn
    Friend WithEvents ememo As DataGridViewTextBoxColumn
    Friend WithEvents ship_name As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents mobtel_no As DataGridViewTextBoxColumn
    Friend WithEvents fax_no As DataGridViewTextBoxColumn
    Friend WithEvents tel_no As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents edate As DataGridViewTextBoxColumn
    Friend WithEvents etype As DataGridViewTextBoxColumn
End Class
