<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invfdesc
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
        Me.Selectbtn = New System.Windows.Forms.Button()
        Me.acctabt_but = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.searchbutt = New System.Windows.Forms.Button()
        Me.acctextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TrandescBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrandescTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.trandescTableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.PcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PsupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrandescBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Selectbtn
        '
        Me.Selectbtn.Location = New System.Drawing.Point(629, 402)
        Me.Selectbtn.Name = "Selectbtn"
        Me.Selectbtn.Size = New System.Drawing.Size(75, 34)
        Me.Selectbtn.TabIndex = 22
        Me.Selectbtn.Text = "SELECT"
        Me.Selectbtn.UseVisualStyleBackColor = True
        '
        'acctabt_but
        '
        Me.acctabt_but.Location = New System.Drawing.Point(87, 402)
        Me.acctabt_but.Name = "acctabt_but"
        Me.acctabt_but.Size = New System.Drawing.Size(75, 34)
        Me.acctabt_but.TabIndex = 21
        Me.acctabt_but.Text = "ABORT"
        Me.acctabt_but.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(23, -53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PcodeDataGridViewTextBoxColumn, Me.PsupplierDataGridViewTextBoxColumn, Me.DescriptnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrandescBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(87, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(617, 273)
        Me.DataGridView1.TabIndex = 19
        '
        'searchbutt
        '
        Me.searchbutt.Location = New System.Drawing.Point(629, 55)
        Me.searchbutt.Name = "searchbutt"
        Me.searchbutt.Size = New System.Drawing.Size(75, 36)
        Me.searchbutt.TabIndex = 18
        Me.searchbutt.Text = "SEARCH"
        Me.searchbutt.UseVisualStyleBackColor = True
        '
        'acctextBox
        '
        Me.acctextBox.Location = New System.Drawing.Point(198, 60)
        Me.acctextBox.Name = "acctextBox"
        Me.acctextBox.Size = New System.Drawing.Size(286, 20)
        Me.acctextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Enter Description"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
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
        'PcodeDataGridViewTextBoxColumn
        '
        Me.PcodeDataGridViewTextBoxColumn.DataPropertyName = "pcode"
        Me.PcodeDataGridViewTextBoxColumn.HeaderText = "PART NUMBER"
        Me.PcodeDataGridViewTextBoxColumn.MinimumWidth = 15
        Me.PcodeDataGridViewTextBoxColumn.Name = "PcodeDataGridViewTextBoxColumn"
        Me.PcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PcodeDataGridViewTextBoxColumn.Width = 125
        '
        'PsupplierDataGridViewTextBoxColumn
        '
        Me.PsupplierDataGridViewTextBoxColumn.DataPropertyName = "psupplier"
        Me.PsupplierDataGridViewTextBoxColumn.HeaderText = "SUPPLIER"
        Me.PsupplierDataGridViewTextBoxColumn.Name = "PsupplierDataGridViewTextBoxColumn"
        Me.PsupplierDataGridViewTextBoxColumn.ReadOnly = True
        Me.PsupplierDataGridViewTextBoxColumn.Width = 145
        '
        'DescriptnDataGridViewTextBoxColumn
        '
        Me.DescriptnDataGridViewTextBoxColumn.DataPropertyName = "descriptn"
        Me.DescriptnDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION"
        Me.DescriptnDataGridViewTextBoxColumn.Name = "DescriptnDataGridViewTextBoxColumn"
        Me.DescriptnDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptnDataGridViewTextBoxColumn.Width = 275
        '
        'Invfdesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 675)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Selectbtn)
        Me.Controls.Add(Me.acctabt_but)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.searchbutt)
        Me.Controls.Add(Me.acctextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Invfdesc"
        Me.Text = "Find Description"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrandescBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Selectbtn As Button
    Friend WithEvents acctabt_but As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchbutt As Button
    Friend WithEvents acctextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TrandescBindingSource As BindingSource
    Friend WithEvents TrandescTableAdapter As TransvacDataV2DataSet1TableAdapters.trandescTableAdapter
    Friend WithEvents TableAdapterManager As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PsupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
