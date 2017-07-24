<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updatemem
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
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.MemoBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ADDRESSBKDataSet = New Transvac_ERP.ADDRESSBKDataSet()
        Me.AddnotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddnotesTableAdapter = New Transvac_ERP.ADDRESSBKDataSetTableAdapters.addnotesTableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.ADDRESSBKDataSetTableAdapters.TableAdapterManager()
        Me.AddnotesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddnotesTableAdapter1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.addnotesTableAdapter()
        Me.TableAdapterManager1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADDRESSBKDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddnotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddnotesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(145, 262)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "ABORT"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(496, 262)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(75, 23)
        Me.UpdateBtn.TabIndex = 1
        Me.UpdateBtn.Text = "UPDATE"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'MemoBox
        '
        Me.MemoBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddnotesBindingSource, "actmemo", True))
        Me.MemoBox.Location = New System.Drawing.Point(145, 85)
        Me.MemoBox.Multiline = True
        Me.MemoBox.Name = "MemoBox"
        Me.MemoBox.Size = New System.Drawing.Size(426, 154)
        Me.MemoBox.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ADDRESSBKDataSet
        '
        Me.ADDRESSBKDataSet.DataSetName = "ADDRESSBKDataSet"
        Me.ADDRESSBKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddnotesBindingSource
        '
        Me.AddnotesBindingSource.DataMember = "addnotes"
        Me.AddnotesBindingSource.DataSource = Me.ADDRESSBKDataSet
        '
        'AddnotesTableAdapter
        '
        Me.AddnotesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.addnotesTableAdapter = Me.AddnotesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tran2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Transvac_ERP.ADDRESSBKDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddnotesTableAdapter1
        '
        Me.AddnotesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.accctlTableAdapter = Nothing
        Me.TableAdapterManager1.accountTableAdapter = Nothing
        Me.TableAdapterManager1.addnotesTableAdapter = Me.AddnotesTableAdapter1
        Me.TableAdapterManager1.ASSETSNEWTableAdapter = Nothing
        Me.TableAdapterManager1.assetsTableAdapter = Nothing
        Me.TableAdapterManager1.atransTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.binallocTableAdapter = Nothing
        Me.TableAdapterManager1.catTableAdapter = Nothing
        Me.TableAdapterManager1.countryTableAdapter = Nothing
        Me.TableAdapterManager1.custdiscTableAdapter = Nothing
        Me.TableAdapterManager1.dummy_TableAdapter = Nothing
        Me.TableAdapterManager1.eventTableAdapter = Nothing
        Me.TableAdapterManager1.foxuserTableAdapter = Nothing
        Me.TableAdapterManager1.invlineTableAdapter = Nothing
        Me.TableAdapterManager1.invoiceheadTableAdapter = Nothing
        Me.TableAdapterManager1.invtransold6TableAdapter = Nothing
        Me.TableAdapterManager1.invtransoldTableAdapter = Nothing
        Me.TableAdapterManager1.invtransTableAdapter = Nothing
        Me.TableAdapterManager1.invworkoldTableAdapter = Nothing
        Me.TableAdapterManager1.invworkTableAdapter = Nothing
        Me.TableAdapterManager1.issueTableAdapter = Nothing
        Me.TableAdapterManager1.locationTableAdapter = Nothing
        Me.TableAdapterManager1.mainTableAdapter = Nothing
        Me.TableAdapterManager1.markupTableAdapter = Nothing
        Me.TableAdapterManager1.namesTableAdapter = Nothing
        Me.TableAdapterManager1.orddetailTableAdapter = Nothing
        Me.TableAdapterManager1.orderheadTableAdapter = Nothing
        Me.TableAdapterManager1.orderlineTableAdapter = Nothing
        Me.TableAdapterManager1.qictrlnewTableAdapter = Nothing
        Me.TableAdapterManager1.qictrlold6TableAdapter = Nothing
        Me.TableAdapterManager1.qictrloldTableAdapter = Nothing
        Me.TableAdapterManager1.qictrlTableAdapter = Nothing
        Me.TableAdapterManager1.quotedetailTableAdapter = Nothing
        Me.TableAdapterManager1.quoteheadTableAdapter = Nothing
        Me.TableAdapterManager1.statusTableAdapter = Nothing
        Me.TableAdapterManager1.teventsTableAdapter = Nothing
        Me.TableAdapterManager1.tran2TableAdapter = Nothing
        Me.TableAdapterManager1.tranbinsTableAdapter = Nothing
        Me.TableAdapterManager1.tranctlTableAdapter = Nothing
        Me.TableAdapterManager1.trandescTableAdapter = Nothing
        Me.TableAdapterManager1.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'updatemem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 339)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MemoBox)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Name = "updatemem"
        Me.Text = "Update Memo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADDRESSBKDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddnotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddnotesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents MemoBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddnotesBindingNavigator As BindingNavigator
    Friend WithEvents AddnotesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ADDRESSBKDataSet As ADDRESSBKDataSet
    Friend WithEvents AddnotesBindingSource As BindingSource
    Friend WithEvents AddnotesTableAdapter As ADDRESSBKDataSetTableAdapters.addnotesTableAdapter
    Friend WithEvents TableAdapterManager As ADDRESSBKDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AddnotesBindingSource1 As BindingSource
    Friend WithEvents AddnotesTableAdapter1 As TransvacDataV2DataSet1TableAdapters.addnotesTableAdapter
    Friend WithEvents TableAdapterManager1 As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
End Class
