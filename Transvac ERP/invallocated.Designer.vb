<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invallocated
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.BinallocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BinallocTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.binallocTableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.BinallocDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinallocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BinallocDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BinallocBindingSource
        '
        Me.BinallocBindingSource.DataMember = "binalloc"
        Me.BinallocBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'BinallocTableAdapter
        '
        Me.BinallocTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.binallocTableAdapter = Me.BinallocTableAdapter
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
        Me.TableAdapterManager.trandescTableAdapter = Nothing
        Me.TableAdapterManager.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BinallocDataGridView
        '
        Me.BinallocDataGridView.AutoGenerateColumns = False
        Me.BinallocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BinallocDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.BinallocDataGridView.DataSource = Me.BinallocBindingSource
        Me.BinallocDataGridView.Location = New System.Drawing.Point(57, 77)
        Me.BinallocDataGridView.Name = "BinallocDataGridView"
        Me.BinallocDataGridView.Size = New System.Drawing.Size(445, 354)
        Me.BinallocDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "bininvno"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Draft Inv No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "binalloc"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Allocated"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "binwho"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Who"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "bindate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "binpart"
        Me.DataGridViewTextBoxColumn1.HeaderText = "binpart"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "bincode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "bincode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "binref"
        Me.DataGridViewTextBoxColumn3.HeaderText = "binref"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "binsup"
        Me.DataGridViewTextBoxColumn2.HeaderText = "binsup"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "binrecno"
        Me.DataGridViewTextBoxColumn5.HeaderText = "binrecno"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "binordno"
        Me.DataGridViewTextBoxColumn10.HeaderText = "binordno"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "bline"
        Me.DataGridViewTextBoxColumn11.HeaderText = "bline"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "UniqueID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "UniqueID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'invallocated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 513)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BinallocDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "invallocated"
        Me.Text = "Allocated"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinallocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BinallocDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents BinallocBindingSource As BindingSource
    Friend WithEvents BinallocTableAdapter As TransvacDataV2DataSet1TableAdapters.binallocTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents BinallocDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
