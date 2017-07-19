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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TransvacDataV2DataSet = New ENQUIRYNEW.TransvacDataV2DataSet()
        Me.TransvacDataV2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnquiryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnquiryTableAdapter = New ENQUIRYNEW.TransvacDataV2DataSetTableAdapters.enquiryTableAdapter()
        Me.TableAdapterManager = New ENQUIRYNEW.TransvacDataV2DataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.EnquiryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TransvacDataV2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnquiryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TransvacDataV2DataSet
        '
        Me.TransvacDataV2DataSet.DataSetName = "TransvacDataV2DataSet"
        Me.TransvacDataV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransvacDataV2DataSetBindingSource
        '
        Me.TransvacDataV2DataSetBindingSource.DataSource = Me.TransvacDataV2DataSet
        Me.TransvacDataV2DataSetBindingSource.Position = 0
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
        Me.Label2.Location = New System.Drawing.Point(35, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quote No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sales Person:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Status:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(140, 146)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(134, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(140, 178)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(134, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(280, 144)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(280, 176)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(37, 543)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(133, 543)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "SELECT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'EnquiryDataGridView
        '
        Me.EnquiryDataGridView.AllowUserToOrderColumns = True
        Me.EnquiryDataGridView.AutoGenerateColumns = False
        Me.EnquiryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EnquiryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EnquiryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EnquiryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn13})
        Me.EnquiryDataGridView.DataSource = Me.EnquiryBindingSource
        Me.EnquiryDataGridView.Location = New System.Drawing.Point(37, 214)
        Me.EnquiryDataGridView.Name = "EnquiryDataGridView"
        Me.EnquiryDataGridView.Size = New System.Drawing.Size(844, 313)
        Me.EnquiryDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CUSTOMER NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ref_no"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CUST REF"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "quote_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "QUOTE NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ewho"
        Me.DataGridViewTextBoxColumn15.HeaderText = "SALES PERSON"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn13.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ENQUIRYNEW.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
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
        'findquote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(936, 590)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EnquiryDataGridView)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "findquote"
        Me.Text = "Find Enquiry"
        CType(Me.TransvacDataV2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquiryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnquiryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TransvacDataV2DataSet As TransvacDataV2DataSet
    Friend WithEvents TransvacDataV2DataSetBindingSource As BindingSource
    Friend WithEvents EnquiryBindingSource As BindingSource
    Friend WithEvents EnquiryTableAdapter As TransvacDataV2DataSetTableAdapters.enquiryTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents EnquiryDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
