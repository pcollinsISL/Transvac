<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class markup
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountrycdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupdiscpcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MupercentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LupdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultiDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.MarkupTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.markupTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.abortbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierDataGridViewTextBoxColumn, Me.CountrycdeDataGridViewTextBoxColumn, Me.SupdiscpcDataGridViewTextBoxColumn, Me.MupercentDataGridViewTextBoxColumn, Me.WhoDataGridViewTextBoxColumn, Me.LupdateDataGridViewTextBoxColumn, Me.AccountDataGridViewTextBoxColumn, Me.MultiDataGridViewCheckBoxColumn, Me.DdaysDataGridViewTextBoxColumn, Me.UniqueIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MarkupBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(61, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 417)
        Me.DataGridView1.TabIndex = 0
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "supplier"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "Supplier Code"
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        '
        'CountrycdeDataGridViewTextBoxColumn
        '
        Me.CountrycdeDataGridViewTextBoxColumn.DataPropertyName = "countrycde"
        Me.CountrycdeDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CountrycdeDataGridViewTextBoxColumn.Name = "CountrycdeDataGridViewTextBoxColumn"
        '
        'SupdiscpcDataGridViewTextBoxColumn
        '
        Me.SupdiscpcDataGridViewTextBoxColumn.DataPropertyName = "sup_discpc"
        Me.SupdiscpcDataGridViewTextBoxColumn.HeaderText = "Supplier Discount %"
        Me.SupdiscpcDataGridViewTextBoxColumn.Name = "SupdiscpcDataGridViewTextBoxColumn"
        '
        'MupercentDataGridViewTextBoxColumn
        '
        Me.MupercentDataGridViewTextBoxColumn.DataPropertyName = "mupercent"
        Me.MupercentDataGridViewTextBoxColumn.HeaderText = "Markup %"
        Me.MupercentDataGridViewTextBoxColumn.Name = "MupercentDataGridViewTextBoxColumn"
        '
        'WhoDataGridViewTextBoxColumn
        '
        Me.WhoDataGridViewTextBoxColumn.DataPropertyName = "who"
        Me.WhoDataGridViewTextBoxColumn.HeaderText = "User"
        Me.WhoDataGridViewTextBoxColumn.Name = "WhoDataGridViewTextBoxColumn"
        '
        'LupdateDataGridViewTextBoxColumn
        '
        Me.LupdateDataGridViewTextBoxColumn.DataPropertyName = "lupdate"
        Me.LupdateDataGridViewTextBoxColumn.HeaderText = "Updated"
        Me.LupdateDataGridViewTextBoxColumn.Name = "LupdateDataGridViewTextBoxColumn"
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "account"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "Account"
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        '
        'MultiDataGridViewCheckBoxColumn
        '
        Me.MultiDataGridViewCheckBoxColumn.DataPropertyName = "multi"
        Me.MultiDataGridViewCheckBoxColumn.HeaderText = "multi"
        Me.MultiDataGridViewCheckBoxColumn.Name = "MultiDataGridViewCheckBoxColumn"
        Me.MultiDataGridViewCheckBoxColumn.Visible = False
        '
        'DdaysDataGridViewTextBoxColumn
        '
        Me.DdaysDataGridViewTextBoxColumn.DataPropertyName = "ddays"
        Me.DdaysDataGridViewTextBoxColumn.HeaderText = "Delivery Days"
        Me.DdaysDataGridViewTextBoxColumn.Name = "DdaysDataGridViewTextBoxColumn"
        '
        'UniqueIDDataGridViewTextBoxColumn
        '
        Me.UniqueIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn.HeaderText = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn.Name = "UniqueIDDataGridViewTextBoxColumn"
        Me.UniqueIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UniqueIDDataGridViewTextBoxColumn.Visible = False
        '
        'MarkupBindingSource
        '
        Me.MarkupBindingSource.DataMember = "markup"
        Me.MarkupBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarkupTableAdapter
        '
        Me.MarkupTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'abortbtn
        '
        Me.abortbtn.Location = New System.Drawing.Point(61, 501)
        Me.abortbtn.Name = "abortbtn"
        Me.abortbtn.Size = New System.Drawing.Size(75, 23)
        Me.abortbtn.TabIndex = 10
        Me.abortbtn.Text = "ABORT"
        Me.abortbtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Location = New System.Drawing.Point(298, 501)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(75, 23)
        Me.Editbtn.TabIndex = 11
        Me.Editbtn.Text = "SAVE"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Location = New System.Drawing.Point(830, 501)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 23)
        Me.deletebtn.TabIndex = 13
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'markup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 549)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.abortbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "markup"
        Me.Text = "Markup View"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents MarkupBindingSource As BindingSource
    Friend WithEvents MarkupTableAdapter As TransvacDataV2DataSet1TableAdapters.markupTableAdapter
    Friend WithEvents SupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountrycdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupdiscpcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MupercentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WhoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LupdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MultiDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DdaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniqueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents abortbtn As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents deletebtn As Button
End Class
