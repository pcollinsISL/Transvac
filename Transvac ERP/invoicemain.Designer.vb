<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoicemain
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
        Me.cwkdftbtn = New System.Windows.Forms.Button()
        Me.dltbtn = New System.Windows.Forms.Button()
        Me.bkinvbtn = New System.Windows.Forms.Button()
        Me.lstpegbtn = New System.Windows.Forms.Button()
        Me.curinvbtn = New System.Windows.Forms.Button()
        Me.revbtn = New System.Windows.Forms.Button()
        Me.srvebtn = New System.Windows.Forms.Button()
        Me.quitbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sltdftbtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.InvworkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvworkTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.invworkTableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.InvworkDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvworkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvworkDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cwkdftbtn
        '
        Me.cwkdftbtn.Location = New System.Drawing.Point(65, 86)
        Me.cwkdftbtn.Name = "cwkdftbtn"
        Me.cwkdftbtn.Size = New System.Drawing.Size(255, 33)
        Me.cwkdftbtn.TabIndex = 0
        Me.cwkdftbtn.Text = "CONTINUE WORKING ON DRAFT ITEM"
        Me.cwkdftbtn.UseVisualStyleBackColor = True
        '
        'dltbtn
        '
        Me.dltbtn.Location = New System.Drawing.Point(65, 181)
        Me.dltbtn.Name = "dltbtn"
        Me.dltbtn.Size = New System.Drawing.Size(144, 33)
        Me.dltbtn.TabIndex = 1
        Me.dltbtn.Text = "DELETE DRAFT ITEM"
        Me.dltbtn.UseVisualStyleBackColor = True
        '
        'bkinvbtn
        '
        Me.bkinvbtn.Location = New System.Drawing.Point(65, 231)
        Me.bkinvbtn.Name = "bkinvbtn"
        Me.bkinvbtn.Size = New System.Drawing.Size(255, 33)
        Me.bkinvbtn.TabIndex = 2
        Me.bkinvbtn.Text = "VIEW BOOKED INVOICE/CREDIT NOTE"
        Me.bkinvbtn.UseVisualStyleBackColor = True
        '
        'lstpegbtn
        '
        Me.lstpegbtn.Location = New System.Drawing.Point(65, 280)
        Me.lstpegbtn.Name = "lstpegbtn"
        Me.lstpegbtn.Size = New System.Drawing.Size(255, 46)
        Me.lstpegbtn.TabIndex = 3
        Me.lstpegbtn.Text = "LIST A CUSTOMERS INVOICES IN PEGASUS"
        Me.lstpegbtn.UseVisualStyleBackColor = True
        '
        'curinvbtn
        '
        Me.curinvbtn.Location = New System.Drawing.Point(65, 342)
        Me.curinvbtn.Name = "curinvbtn"
        Me.curinvbtn.Size = New System.Drawing.Size(255, 41)
        Me.curinvbtn.TabIndex = 4
        Me.curinvbtn.Text = "SEE CURRENT STATEMENT OF ACCOUNTS"
        Me.curinvbtn.UseVisualStyleBackColor = True
        '
        'revbtn
        '
        Me.revbtn.Location = New System.Drawing.Point(65, 398)
        Me.revbtn.Name = "revbtn"
        Me.revbtn.Size = New System.Drawing.Size(255, 41)
        Me.revbtn.TabIndex = 5
        Me.revbtn.Text = "RESERVE A BOOKED INVOICE"
        Me.revbtn.UseVisualStyleBackColor = True
        '
        'srvebtn
        '
        Me.srvebtn.Location = New System.Drawing.Point(65, 454)
        Me.srvebtn.Name = "srvebtn"
        Me.srvebtn.Size = New System.Drawing.Size(255, 41)
        Me.srvebtn.TabIndex = 6
        Me.srvebtn.Text = "SERVICE/CUSTOMS INVOICE"
        Me.srvebtn.UseVisualStyleBackColor = True
        '
        'quitbtn
        '
        Me.quitbtn.Location = New System.Drawing.Point(65, 550)
        Me.quitbtn.Name = "quitbtn"
        Me.quitbtn.Size = New System.Drawing.Size(131, 41)
        Me.quitbtn.TabIndex = 8
        Me.quitbtn.Text = "QUIT"
        Me.quitbtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'sltdftbtn
        '
        Me.sltdftbtn.Location = New System.Drawing.Point(65, 133)
        Me.sltdftbtn.Name = "sltdftbtn"
        Me.sltdftbtn.Size = New System.Drawing.Size(255, 33)
        Me.sltdftbtn.TabIndex = 93
        Me.sltdftbtn.Text = "SELECT A DRAFT ITEM FROM LIST"
        Me.sltdftbtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(65, 508)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 94
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvworkBindingSource
        '
        Me.InvworkBindingSource.DataMember = "invwork"
        Me.InvworkBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'InvworkTableAdapter
        '
        Me.InvworkTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.invworkTableAdapter = Me.InvworkTableAdapter
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
        '
        'InvworkDataGridView
        '
        Me.InvworkDataGridView.AutoGenerateColumns = False
        Me.InvworkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvworkDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.InvworkDataGridView.DataSource = Me.InvworkBindingSource
        Me.InvworkDataGridView.Location = New System.Drawing.Point(382, 133)
        Me.InvworkDataGridView.Name = "InvworkDataGridView"
        Me.InvworkDataGridView.Size = New System.Drawing.Size(345, 388)
        Me.InvworkDataGridView.TabIndex = 95
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "doc_ref"
        Me.DataGridViewTextBoxColumn1.HeaderText = "doc_ref"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ddate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ddate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "rec_type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "rec_type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "line_no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "line_no"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "partid"
        Me.DataGridViewTextBoxColumn5.HeaderText = "partid"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "iicode"
        Me.DataGridViewTextBoxColumn6.HeaderText = "iicode"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "qty_ord"
        Me.DataGridViewTextBoxColumn7.HeaderText = "qty_ord"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "qty_sent"
        Me.DataGridViewTextBoxColumn8.HeaderText = "qty_sent"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "assured"
        Me.DataGridViewTextBoxColumn9.HeaderText = "assured"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "desc_area"
        Me.DataGridViewTextBoxColumn10.HeaderText = "desc_area"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "uprice"
        Me.DataGridViewTextBoxColumn11.HeaderText = "uprice"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "pc_disc"
        Me.DataGridViewTextBoxColumn12.HeaderText = "pc_disc"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "up_disc"
        Me.DataGridViewTextBoxColumn13.HeaderText = "up_disc"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "curcyprice"
        Me.DataGridViewTextBoxColumn14.HeaderText = "curcyprice"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "currency"
        Me.DataGridViewTextBoxColumn15.HeaderText = "currency"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "bin_ref"
        Me.DataGridViewTextBoxColumn16.HeaderText = "bin_ref"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "bin_recd"
        Me.DataGridViewTextBoxColumn17.HeaderText = "bin_recd"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "iwho"
        Me.DataGridViewTextBoxColumn18.HeaderText = "WHO"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ldate"
        Me.DataGridViewTextBoxColumn19.HeaderText = "ldate"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "order_"
        Me.DataGridViewTextBoxColumn20.HeaderText = "order_"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "supplier"
        Me.DataGridViewTextBoxColumn21.HeaderText = "supplier"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "UniqueID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "UniqueID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'invoicemain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 625)
        Me.Controls.Add(Me.InvworkDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.sltdftbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.quitbtn)
        Me.Controls.Add(Me.srvebtn)
        Me.Controls.Add(Me.revbtn)
        Me.Controls.Add(Me.curinvbtn)
        Me.Controls.Add(Me.lstpegbtn)
        Me.Controls.Add(Me.bkinvbtn)
        Me.Controls.Add(Me.dltbtn)
        Me.Controls.Add(Me.cwkdftbtn)
        Me.Name = "invoicemain"
        Me.Text = "Invoicing & Credit Notes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvworkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvworkDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cwkdftbtn As Button
    Friend WithEvents dltbtn As Button
    Friend WithEvents bkinvbtn As Button
    Friend WithEvents lstpegbtn As Button
    Friend WithEvents curinvbtn As Button
    Friend WithEvents revbtn As Button
    Friend WithEvents srvebtn As Button
    Friend WithEvents quitbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents sltdftbtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents InvworkBindingSource As BindingSource
    Friend WithEvents InvworkTableAdapter As TransvacDataV2DataSet1TableAdapters.invworkTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents InvworkDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
End Class
