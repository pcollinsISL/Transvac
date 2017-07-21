<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class namesrch
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.namesrch_but = New System.Windows.Forms.Button()
        Me.fndabt_but = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FNameDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tran2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.Tran2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tran2TableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.tran2TableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ad1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ad2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ad3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ad4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ad5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EurovatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VatpayableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IfmemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProformaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntrytypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NwhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InuseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewupdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PegpactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeglsaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XcardDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PromoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ADDMEMODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FNameDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tran2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tran2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Description/Name"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(184, 93)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(265, 20)
        Me.NameBox.TabIndex = 1
        '
        'namesrch_but
        '
        Me.namesrch_but.Location = New System.Drawing.Point(457, 91)
        Me.namesrch_but.Name = "namesrch_but"
        Me.namesrch_but.Size = New System.Drawing.Size(75, 23)
        Me.namesrch_but.TabIndex = 7
        Me.namesrch_but.Text = "SEARCH"
        Me.namesrch_but.UseVisualStyleBackColor = True
        '
        'fndabt_but
        '
        Me.fndabt_but.Location = New System.Drawing.Point(49, 420)
        Me.fndabt_but.Name = "fndabt_but"
        Me.fndabt_but.Size = New System.Drawing.Size(75, 23)
        Me.fndabt_but.TabIndex = 6
        Me.fndabt_but.Text = "ABORT"
        Me.fndabt_but.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FNameDataGridView
        '
        Me.FNameDataGridView.AllowUserToAddRows = False
        Me.FNameDataGridView.AllowUserToDeleteRows = False
        Me.FNameDataGridView.AutoGenerateColumns = False
        Me.FNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FNameDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.AccountDataGridViewTextBoxColumn, Me.Ad1DataGridViewTextBoxColumn, Me.Ad2DataGridViewTextBoxColumn, Me.Ad3DataGridViewTextBoxColumn, Me.Ad4DataGridViewTextBoxColumn, Me.Ad5DataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.TelexDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.EurovatDataGridViewTextBoxColumn, Me.VatpayableDataGridViewCheckBoxColumn, Me.IfmemoDataGridViewTextBoxColumn, Me.ProformaDataGridViewTextBoxColumn, Me.UdateDataGridViewTextBoxColumn, Me.TermdaysDataGridViewTextBoxColumn, Me.EntrytypeDataGridViewTextBoxColumn, Me.NwhoDataGridViewTextBoxColumn, Me.InuseDataGridViewTextBoxColumn, Me.NewupdDataGridViewTextBoxColumn, Me.PegpactDataGridViewTextBoxColumn, Me.PeglsaleDataGridViewTextBoxColumn, Me.XcardDataGridViewCheckBoxColumn, Me.PromoDataGridViewCheckBoxColumn, Me.ADDMEMODataGridViewTextBoxColumn})
        Me.FNameDataGridView.DataSource = Me.Tran2BindingSource
        Me.FNameDataGridView.Location = New System.Drawing.Point(49, 131)
        Me.FNameDataGridView.Name = "FNameDataGridView"
        Me.FNameDataGridView.ReadOnly = True
        Me.FNameDataGridView.Size = New System.Drawing.Size(702, 275)
        Me.FNameDataGridView.TabIndex = 10
        '
        'Tran2BindingSource
        '
        Me.Tran2BindingSource.DataMember = "tran2"
        Me.Tran2BindingSource.DataSource = Me.TransvacDataV2DataSet1BindingSource
        '
        'TransvacDataV2DataSet1BindingSource
        '
        Me.TransvacDataV2DataSet1BindingSource.DataSource = Me.TransvacDataV2DataSet1
        Me.TransvacDataV2DataSet1BindingSource.Position = 0
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tran2BindingSource1
        '
        Me.Tran2BindingSource1.DataMember = "tran2"
        Me.Tran2BindingSource1.DataSource = Me.TransvacDataV2DataSet1BindingSource
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(676, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "SELECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tran2TableAdapter
        '
        Me.Tran2TableAdapter.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "account"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "ACCOUNT ID"
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        Me.AccountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Ad1DataGridViewTextBoxColumn
        '
        Me.Ad1DataGridViewTextBoxColumn.DataPropertyName = "ad1"
        Me.Ad1DataGridViewTextBoxColumn.HeaderText = "ad1"
        Me.Ad1DataGridViewTextBoxColumn.Name = "Ad1DataGridViewTextBoxColumn"
        Me.Ad1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ad1DataGridViewTextBoxColumn.Visible = False
        '
        'Ad2DataGridViewTextBoxColumn
        '
        Me.Ad2DataGridViewTextBoxColumn.DataPropertyName = "ad2"
        Me.Ad2DataGridViewTextBoxColumn.HeaderText = "ad2"
        Me.Ad2DataGridViewTextBoxColumn.Name = "Ad2DataGridViewTextBoxColumn"
        Me.Ad2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ad2DataGridViewTextBoxColumn.Visible = False
        '
        'Ad3DataGridViewTextBoxColumn
        '
        Me.Ad3DataGridViewTextBoxColumn.DataPropertyName = "ad3"
        Me.Ad3DataGridViewTextBoxColumn.HeaderText = "ad3"
        Me.Ad3DataGridViewTextBoxColumn.Name = "Ad3DataGridViewTextBoxColumn"
        Me.Ad3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ad3DataGridViewTextBoxColumn.Visible = False
        '
        'Ad4DataGridViewTextBoxColumn
        '
        Me.Ad4DataGridViewTextBoxColumn.DataPropertyName = "ad4"
        Me.Ad4DataGridViewTextBoxColumn.HeaderText = "ad4"
        Me.Ad4DataGridViewTextBoxColumn.Name = "Ad4DataGridViewTextBoxColumn"
        Me.Ad4DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ad4DataGridViewTextBoxColumn.Visible = False
        '
        'Ad5DataGridViewTextBoxColumn
        '
        Me.Ad5DataGridViewTextBoxColumn.DataPropertyName = "ad5"
        Me.Ad5DataGridViewTextBoxColumn.HeaderText = "ad5"
        Me.Ad5DataGridViewTextBoxColumn.Name = "Ad5DataGridViewTextBoxColumn"
        Me.Ad5DataGridViewTextBoxColumn.ReadOnly = True
        Me.Ad5DataGridViewTextBoxColumn.Visible = False
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneDataGridViewTextBoxColumn.Visible = False
        '
        'TelexDataGridViewTextBoxColumn
        '
        Me.TelexDataGridViewTextBoxColumn.DataPropertyName = "telex"
        Me.TelexDataGridViewTextBoxColumn.HeaderText = "telex"
        Me.TelexDataGridViewTextBoxColumn.Name = "TelexDataGridViewTextBoxColumn"
        Me.TelexDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelexDataGridViewTextBoxColumn.Visible = False
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        Me.FaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.FaxDataGridViewTextBoxColumn.Visible = False
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Visible = False
        '
        'EurovatDataGridViewTextBoxColumn
        '
        Me.EurovatDataGridViewTextBoxColumn.DataPropertyName = "eurovat"
        Me.EurovatDataGridViewTextBoxColumn.HeaderText = "eurovat"
        Me.EurovatDataGridViewTextBoxColumn.Name = "EurovatDataGridViewTextBoxColumn"
        Me.EurovatDataGridViewTextBoxColumn.ReadOnly = True
        Me.EurovatDataGridViewTextBoxColumn.Visible = False
        '
        'VatpayableDataGridViewCheckBoxColumn
        '
        Me.VatpayableDataGridViewCheckBoxColumn.DataPropertyName = "vatpayable"
        Me.VatpayableDataGridViewCheckBoxColumn.HeaderText = "vatpayable"
        Me.VatpayableDataGridViewCheckBoxColumn.Name = "VatpayableDataGridViewCheckBoxColumn"
        Me.VatpayableDataGridViewCheckBoxColumn.ReadOnly = True
        Me.VatpayableDataGridViewCheckBoxColumn.Visible = False
        '
        'IfmemoDataGridViewTextBoxColumn
        '
        Me.IfmemoDataGridViewTextBoxColumn.DataPropertyName = "ifmemo"
        Me.IfmemoDataGridViewTextBoxColumn.HeaderText = "ifmemo"
        Me.IfmemoDataGridViewTextBoxColumn.Name = "IfmemoDataGridViewTextBoxColumn"
        Me.IfmemoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IfmemoDataGridViewTextBoxColumn.Visible = False
        '
        'ProformaDataGridViewTextBoxColumn
        '
        Me.ProformaDataGridViewTextBoxColumn.DataPropertyName = "proforma"
        Me.ProformaDataGridViewTextBoxColumn.HeaderText = "PROFORMA"
        Me.ProformaDataGridViewTextBoxColumn.Name = "ProformaDataGridViewTextBoxColumn"
        Me.ProformaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UdateDataGridViewTextBoxColumn
        '
        Me.UdateDataGridViewTextBoxColumn.DataPropertyName = "udate"
        Me.UdateDataGridViewTextBoxColumn.HeaderText = "udate"
        Me.UdateDataGridViewTextBoxColumn.Name = "UdateDataGridViewTextBoxColumn"
        Me.UdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.UdateDataGridViewTextBoxColumn.Visible = False
        '
        'TermdaysDataGridViewTextBoxColumn
        '
        Me.TermdaysDataGridViewTextBoxColumn.DataPropertyName = "termdays"
        Me.TermdaysDataGridViewTextBoxColumn.HeaderText = "TERMDAYS"
        Me.TermdaysDataGridViewTextBoxColumn.Name = "TermdaysDataGridViewTextBoxColumn"
        Me.TermdaysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntrytypeDataGridViewTextBoxColumn
        '
        Me.EntrytypeDataGridViewTextBoxColumn.DataPropertyName = "entrytype"
        Me.EntrytypeDataGridViewTextBoxColumn.HeaderText = "entrytype"
        Me.EntrytypeDataGridViewTextBoxColumn.Name = "EntrytypeDataGridViewTextBoxColumn"
        Me.EntrytypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntrytypeDataGridViewTextBoxColumn.Visible = False
        '
        'NwhoDataGridViewTextBoxColumn
        '
        Me.NwhoDataGridViewTextBoxColumn.DataPropertyName = "nwho"
        Me.NwhoDataGridViewTextBoxColumn.HeaderText = "nwho"
        Me.NwhoDataGridViewTextBoxColumn.Name = "NwhoDataGridViewTextBoxColumn"
        Me.NwhoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NwhoDataGridViewTextBoxColumn.Visible = False
        '
        'InuseDataGridViewTextBoxColumn
        '
        Me.InuseDataGridViewTextBoxColumn.DataPropertyName = "inuse"
        Me.InuseDataGridViewTextBoxColumn.HeaderText = "inuse"
        Me.InuseDataGridViewTextBoxColumn.Name = "InuseDataGridViewTextBoxColumn"
        Me.InuseDataGridViewTextBoxColumn.ReadOnly = True
        Me.InuseDataGridViewTextBoxColumn.Visible = False
        '
        'NewupdDataGridViewTextBoxColumn
        '
        Me.NewupdDataGridViewTextBoxColumn.DataPropertyName = "new_upd"
        Me.NewupdDataGridViewTextBoxColumn.HeaderText = "new_upd"
        Me.NewupdDataGridViewTextBoxColumn.Name = "NewupdDataGridViewTextBoxColumn"
        Me.NewupdDataGridViewTextBoxColumn.ReadOnly = True
        Me.NewupdDataGridViewTextBoxColumn.Visible = False
        '
        'PegpactDataGridViewTextBoxColumn
        '
        Me.PegpactDataGridViewTextBoxColumn.DataPropertyName = "peg_pact"
        Me.PegpactDataGridViewTextBoxColumn.HeaderText = "peg_pact"
        Me.PegpactDataGridViewTextBoxColumn.Name = "PegpactDataGridViewTextBoxColumn"
        Me.PegpactDataGridViewTextBoxColumn.ReadOnly = True
        Me.PegpactDataGridViewTextBoxColumn.Visible = False
        '
        'PeglsaleDataGridViewTextBoxColumn
        '
        Me.PeglsaleDataGridViewTextBoxColumn.DataPropertyName = "peg_lsale"
        Me.PeglsaleDataGridViewTextBoxColumn.HeaderText = "peg_lsale"
        Me.PeglsaleDataGridViewTextBoxColumn.Name = "PeglsaleDataGridViewTextBoxColumn"
        Me.PeglsaleDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeglsaleDataGridViewTextBoxColumn.Visible = False
        '
        'XcardDataGridViewCheckBoxColumn
        '
        Me.XcardDataGridViewCheckBoxColumn.DataPropertyName = "xcard"
        Me.XcardDataGridViewCheckBoxColumn.HeaderText = "xcard"
        Me.XcardDataGridViewCheckBoxColumn.Name = "XcardDataGridViewCheckBoxColumn"
        Me.XcardDataGridViewCheckBoxColumn.ReadOnly = True
        Me.XcardDataGridViewCheckBoxColumn.Visible = False
        '
        'PromoDataGridViewCheckBoxColumn
        '
        Me.PromoDataGridViewCheckBoxColumn.DataPropertyName = "promo"
        Me.PromoDataGridViewCheckBoxColumn.HeaderText = "promo"
        Me.PromoDataGridViewCheckBoxColumn.Name = "PromoDataGridViewCheckBoxColumn"
        Me.PromoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PromoDataGridViewCheckBoxColumn.Visible = False
        '
        'ADDMEMODataGridViewTextBoxColumn
        '
        Me.ADDMEMODataGridViewTextBoxColumn.DataPropertyName = "ADDMEMO"
        Me.ADDMEMODataGridViewTextBoxColumn.HeaderText = "ADDMEMO"
        Me.ADDMEMODataGridViewTextBoxColumn.Name = "ADDMEMODataGridViewTextBoxColumn"
        Me.ADDMEMODataGridViewTextBoxColumn.ReadOnly = True
        Me.ADDMEMODataGridViewTextBoxColumn.Visible = False
        '
        'namesrch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FNameDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.namesrch_but)
        Me.Controls.Add(Me.fndabt_but)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "namesrch"
        Me.Text = "Find Name"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FNameDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tran2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tran2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents namesrch_but As Button
    Friend WithEvents fndabt_but As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TransvacDataV2DataSet1BindingSource As BindingSource
    Friend WithEvents FNameDataGridView As DataGridView
    Friend WithEvents Tran2BindingSource As BindingSource
    Friend WithEvents Tran2TableAdapter As TransvacDataV2DataSet1TableAdapters.tran2TableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Tran2BindingSource1 As BindingSource
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ad1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ad2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ad3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ad4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ad5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EurovatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VatpayableDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IfmemoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProformaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TermdaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntrytypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NwhoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InuseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewupdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PegpactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeglsaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents XcardDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PromoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ADDMEMODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
