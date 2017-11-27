<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim DescriptnLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.findesc_but = New System.Windows.Forms.Button()
        Me.deldesc_but = New System.Windows.Forms.Button()
        Me.editdesc_but = New System.Windows.Forms.Button()
        Me.newdesc_but = New System.Windows.Forms.Button()
        Me.quit_but = New System.Windows.Forms.Button()
        Me.avgtotval_but = New System.Windows.Forms.Button()
        Me.bincode_but = New System.Windows.Forms.Button()
        Me.nwbin_but = New System.Windows.Forms.Button()
        Me.editbin_but = New System.Windows.Forms.Button()
        Me.markup_but = New System.Windows.Forms.Button()
        Me.alloc_but = New System.Windows.Forms.Button()
        Me.xchange_but = New System.Windows.Forms.Button()
        Me.orderd_but = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.editmem_but = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PsupplierTextBox1 = New System.Windows.Forms.TextBox()
        Me.PcodeTextBox1 = New System.Windows.Forms.TextBox()
        Me.DescriptnTextBox1 = New System.Windows.Forms.TextBox()
        Me.IdcodeTextBox = New System.Windows.Forms.TextBox()
        Me.MinstockTextBox = New System.Windows.Forms.TextBox()
        Me.MinorderTextBox = New System.Windows.Forms.TextBox()
        Me.PcodeLook = New System.Windows.Forms.Button()
        Me.idcode = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.supdiscbox = New System.Windows.Forms.TextBox()
        Me.markupbox = New System.Windows.Forms.TextBox()
        Me.unitcostbox = New System.Windows.Forms.TextBox()
        Me.retailbox = New System.Windows.Forms.TextBox()
        Me.SupDisc = New System.Windows.Forms.Label()
        Me.unitcost = New System.Windows.Forms.Label()
        Me.retail = New System.Windows.Forms.Label()
        Me.markup = New System.Windows.Forms.Label()
        Me.unitvaluebox = New System.Windows.Forms.TextBox()
        Me.unitvalue = New System.Windows.Forms.Label()
        Me.markupDecimail = New System.Windows.Forms.TextBox()
        Me.unitcostsum = New System.Windows.Forms.TextBox()
        Me.markupsum = New System.Windows.Forms.TextBox()
        Me.retailsum = New System.Windows.Forms.TextBox()
        Me.MovePrev = New System.Windows.Forms.Button()
        Me.Movenxt = New System.Windows.Forms.Button()
        Me.MoveEnd = New System.Windows.Forms.Button()
        Me.MoveStr = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MarkupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TrandescBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocatebinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourcecdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantybinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrcycdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IiupdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatalogdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranbinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrandescTableAdapter1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.trandescTableAdapter()
        Me.TableAdapterManager1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.TranbinsTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter()
        Me.MarkupTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.markupTableAdapter()
        Me.OrddetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrddetailTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.orddetailTableAdapter()
        DescriptnLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrandescBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrddetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptnLabel
        '
        DescriptnLabel.AutoSize = True
        DescriptnLabel.Location = New System.Drawing.Point(71, 189)
        DescriptnLabel.Name = "DescriptnLabel"
        DescriptnLabel.Size = New System.Drawing.Size(60, 13)
        DescriptnLabel.TabIndex = 92
        DescriptnLabel.Text = "Description"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(779, 103)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(107, 13)
        Label4.TabIndex = 175
        Label4.Text = "Min Order Commodity"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(779, 130)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 13)
        Label5.TabIndex = 176
        Label5.Text = "Min Stock"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(779, 76)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(81, 13)
        Label6.TabIndex = 177
        Label6.Text = "Stock Checked"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Part No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "INVENTORY"
        '
        'findesc_but
        '
        Me.findesc_but.Location = New System.Drawing.Point(490, 175)
        Me.findesc_but.Name = "findesc_but"
        Me.findesc_but.Size = New System.Drawing.Size(94, 41)
        Me.findesc_but.TabIndex = 153
        Me.findesc_but.Text = "Find Desc"
        Me.findesc_but.UseVisualStyleBackColor = True
        '
        'deldesc_but
        '
        Me.deldesc_but.Location = New System.Drawing.Point(632, 131)
        Me.deldesc_but.Name = "deldesc_but"
        Me.deldesc_but.Size = New System.Drawing.Size(75, 23)
        Me.deldesc_but.TabIndex = 154
        Me.deldesc_but.Text = "Delete Desc"
        Me.deldesc_but.UseVisualStyleBackColor = True
        '
        'editdesc_but
        '
        Me.editdesc_but.Location = New System.Drawing.Point(632, 101)
        Me.editdesc_but.Name = "editdesc_but"
        Me.editdesc_but.Size = New System.Drawing.Size(75, 23)
        Me.editdesc_but.TabIndex = 155
        Me.editdesc_but.Text = "Edit Desc"
        Me.editdesc_but.UseVisualStyleBackColor = True
        '
        'newdesc_but
        '
        Me.newdesc_but.Location = New System.Drawing.Point(632, 71)
        Me.newdesc_but.Name = "newdesc_but"
        Me.newdesc_but.Size = New System.Drawing.Size(75, 23)
        Me.newdesc_but.TabIndex = 156
        Me.newdesc_but.Text = "New Desc"
        Me.newdesc_but.UseVisualStyleBackColor = True
        '
        'quit_but
        '
        Me.quit_but.Location = New System.Drawing.Point(32, 526)
        Me.quit_but.Name = "quit_but"
        Me.quit_but.Size = New System.Drawing.Size(70, 37)
        Me.quit_but.TabIndex = 157
        Me.quit_but.Text = "Quit"
        Me.quit_but.UseVisualStyleBackColor = True
        '
        'avgtotval_but
        '
        Me.avgtotval_but.Location = New System.Drawing.Point(238, 526)
        Me.avgtotval_but.Name = "avgtotval_but"
        Me.avgtotval_but.Size = New System.Drawing.Size(102, 23)
        Me.avgtotval_but.TabIndex = 158
        Me.avgtotval_but.Text = "Avg/Total Value"
        Me.avgtotval_but.UseVisualStyleBackColor = True
        '
        'bincode_but
        '
        Me.bincode_but.Location = New System.Drawing.Point(238, 583)
        Me.bincode_but.Name = "bincode_but"
        Me.bincode_but.Size = New System.Drawing.Size(102, 23)
        Me.bincode_but.TabIndex = 160
        Me.bincode_but.Text = "Bin Code"
        Me.bincode_but.UseVisualStyleBackColor = True
        '
        'nwbin_but
        '
        Me.nwbin_but.Location = New System.Drawing.Point(546, 504)
        Me.nwbin_but.Name = "nwbin_but"
        Me.nwbin_but.Size = New System.Drawing.Size(75, 23)
        Me.nwbin_but.TabIndex = 161
        Me.nwbin_but.Text = "New Bin"
        Me.nwbin_but.UseVisualStyleBackColor = True
        '
        'editbin_but
        '
        Me.editbin_but.Location = New System.Drawing.Point(546, 533)
        Me.editbin_but.Name = "editbin_but"
        Me.editbin_but.Size = New System.Drawing.Size(75, 23)
        Me.editbin_but.TabIndex = 162
        Me.editbin_but.Text = "Edit Bin"
        Me.editbin_but.UseVisualStyleBackColor = True
        '
        'markup_but
        '
        Me.markup_but.Location = New System.Drawing.Point(238, 554)
        Me.markup_but.Name = "markup_but"
        Me.markup_but.Size = New System.Drawing.Size(102, 23)
        Me.markup_but.TabIndex = 164
        Me.markup_but.Text = "MarkUp"
        Me.markup_but.UseVisualStyleBackColor = True
        '
        'alloc_but
        '
        Me.alloc_but.Location = New System.Drawing.Point(839, 658)
        Me.alloc_but.Name = "alloc_but"
        Me.alloc_but.Size = New System.Drawing.Size(75, 23)
        Me.alloc_but.TabIndex = 165
        Me.alloc_but.Text = "Allocated"
        Me.alloc_but.UseVisualStyleBackColor = True
        '
        'xchange_but
        '
        Me.xchange_but.Location = New System.Drawing.Point(238, 612)
        Me.xchange_but.Name = "xchange_but"
        Me.xchange_but.Size = New System.Drawing.Size(102, 23)
        Me.xchange_but.TabIndex = 167
        Me.xchange_but.Text = "Xchange Rate"
        Me.xchange_but.UseVisualStyleBackColor = True
        '
        'orderd_but
        '
        Me.orderd_but.Location = New System.Drawing.Point(839, 687)
        Me.orderd_but.Name = "orderd_but"
        Me.orderd_but.Size = New System.Drawing.Size(75, 23)
        Me.orderd_but.TabIndex = 168
        Me.orderd_but.Text = "Ordered"
        Me.orderd_but.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "descmemo", True))
        Me.TextBox3.Location = New System.Drawing.Point(627, 504)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(335, 131)
        Me.TextBox3.TabIndex = 172
        '
        'editmem_but
        '
        Me.editmem_but.Location = New System.Drawing.Point(627, 638)
        Me.editmem_but.Name = "editmem_but"
        Me.editmem_but.Size = New System.Drawing.Size(76, 46)
        Me.editmem_but.TabIndex = 173
        Me.editmem_but.Text = "Edit Memo"
        Me.editmem_but.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(965, 503)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(16, 132)
        Me.VScrollBar1.TabIndex = 174
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(785, 466)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(86, 20)
        Me.TextBox5.TabIndex = 181
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(709, 469)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Avg/Total Sale"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(607, 466)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 183
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(522, 469)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "Avg/Total Cost"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(781, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 188
        Me.Label9.Text = "Bin Code"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(158, 157)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(173, 20)
        Me.TextBox10.TabIndex = 190
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 189
        Me.Label10.Text = "Nato Stock No"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocatebinDataGridViewTextBoxColumn, Me.SourcecdeDataGridViewTextBoxColumn, Me.QuantybinDataGridViewTextBoxColumn, Me.UnitvalueDataGridViewTextBoxColumn, Me.CurrcycdeDataGridViewTextBoxColumn, Me.IiupdateDataGridViewTextBoxColumn, Me.CatalogdtDataGridViewTextBoxColumn, Me.WqtyDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TranbinsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(34, 226)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(948, 150)
        Me.DataGridView1.TabIndex = 191
        '
        'PsupplierTextBox1
        '
        Me.PsupplierTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "psupplier", True))
        Me.PsupplierTextBox1.Location = New System.Drawing.Point(158, 100)
        Me.PsupplierTextBox1.Name = "PsupplierTextBox1"
        Me.PsupplierTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PsupplierTextBox1.TabIndex = 192
        '
        'PcodeTextBox1
        '
        Me.PcodeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "pcode", True))
        Me.PcodeTextBox1.Location = New System.Drawing.Point(158, 129)
        Me.PcodeTextBox1.Name = "PcodeTextBox1"
        Me.PcodeTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PcodeTextBox1.TabIndex = 193
        '
        'DescriptnTextBox1
        '
        Me.DescriptnTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "descriptn", True))
        Me.DescriptnTextBox1.Location = New System.Drawing.Point(158, 186)
        Me.DescriptnTextBox1.Name = "DescriptnTextBox1"
        Me.DescriptnTextBox1.Size = New System.Drawing.Size(326, 20)
        Me.DescriptnTextBox1.TabIndex = 194
        '
        'IdcodeTextBox
        '
        Me.IdcodeTextBox.Location = New System.Drawing.Point(896, 154)
        Me.IdcodeTextBox.Name = "IdcodeTextBox"
        Me.IdcodeTextBox.Size = New System.Drawing.Size(66, 20)
        Me.IdcodeTextBox.TabIndex = 195
        '
        'MinstockTextBox
        '
        Me.MinstockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "minstock", True))
        Me.MinstockTextBox.Location = New System.Drawing.Point(896, 128)
        Me.MinstockTextBox.Name = "MinstockTextBox"
        Me.MinstockTextBox.Size = New System.Drawing.Size(66, 20)
        Me.MinstockTextBox.TabIndex = 196
        '
        'MinorderTextBox
        '
        Me.MinorderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "minorder", True))
        Me.MinorderTextBox.Location = New System.Drawing.Point(896, 100)
        Me.MinorderTextBox.Name = "MinorderTextBox"
        Me.MinorderTextBox.Size = New System.Drawing.Size(66, 20)
        Me.MinorderTextBox.TabIndex = 197
        '
        'PcodeLook
        '
        Me.PcodeLook.Location = New System.Drawing.Point(265, 129)
        Me.PcodeLook.Name = "PcodeLook"
        Me.PcodeLook.Size = New System.Drawing.Size(75, 19)
        Me.PcodeLook.TabIndex = 198
        Me.PcodeLook.Text = "PcodeLook"
        Me.PcodeLook.UseVisualStyleBackColor = True
        Me.PcodeLook.Visible = False
        '
        'idcode
        '
        Me.idcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "idcode", True))
        Me.idcode.Location = New System.Drawing.Point(347, 129)
        Me.idcode.Name = "idcode"
        Me.idcode.Size = New System.Drawing.Size(79, 20)
        Me.idcode.TabIndex = 200
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TrandescBindingSource1, "idupdate", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(896, 74)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 201
        '
        'supdiscbox
        '
        Me.supdiscbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarkupBindingSource, "sup_discpc", True))
        Me.supdiscbox.Location = New System.Drawing.Point(87, 387)
        Me.supdiscbox.Name = "supdiscbox"
        Me.supdiscbox.Size = New System.Drawing.Size(100, 20)
        Me.supdiscbox.TabIndex = 202
        '
        'markupbox
        '
        Me.markupbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarkupBindingSource, "mupercent", True))
        Me.markupbox.Location = New System.Drawing.Point(244, 387)
        Me.markupbox.Name = "markupbox"
        Me.markupbox.Size = New System.Drawing.Size(100, 20)
        Me.markupbox.TabIndex = 203
        '
        'unitcostbox
        '
        Me.unitcostbox.Location = New System.Drawing.Point(607, 387)
        Me.unitcostbox.Name = "unitcostbox"
        Me.unitcostbox.Size = New System.Drawing.Size(100, 20)
        Me.unitcostbox.TabIndex = 204
        '
        'retailbox
        '
        Me.retailbox.Location = New System.Drawing.Point(771, 387)
        Me.retailbox.Name = "retailbox"
        Me.retailbox.Size = New System.Drawing.Size(100, 20)
        Me.retailbox.TabIndex = 205
        '
        'SupDisc
        '
        Me.SupDisc.AutoSize = True
        Me.SupDisc.Location = New System.Drawing.Point(31, 390)
        Me.SupDisc.Name = "SupDisc"
        Me.SupDisc.Size = New System.Drawing.Size(50, 13)
        Me.SupDisc.TabIndex = 206
        Me.SupDisc.Text = "Sup Disc"
        '
        'unitcost
        '
        Me.unitcost.AutoSize = True
        Me.unitcost.Location = New System.Drawing.Point(551, 390)
        Me.unitcost.Name = "unitcost"
        Me.unitcost.Size = New System.Drawing.Size(50, 13)
        Me.unitcost.TabIndex = 207
        Me.unitcost.Text = "Unit Cost"
        '
        'retail
        '
        Me.retail.AutoSize = True
        Me.retail.Location = New System.Drawing.Point(727, 390)
        Me.retail.Name = "retail"
        Me.retail.Size = New System.Drawing.Size(34, 13)
        Me.retail.TabIndex = 208
        Me.retail.Text = "Retail"
        '
        'markup
        '
        Me.markup.AutoSize = True
        Me.markup.Location = New System.Drawing.Point(199, 390)
        Me.markup.Name = "markup"
        Me.markup.Size = New System.Drawing.Size(43, 13)
        Me.markup.TabIndex = 209
        Me.markup.Text = "Markup"
        '
        'unitvaluebox
        '
        Me.unitvaluebox.Location = New System.Drawing.Point(426, 387)
        Me.unitvaluebox.Name = "unitvaluebox"
        Me.unitvaluebox.Size = New System.Drawing.Size(100, 20)
        Me.unitvaluebox.TabIndex = 210
        '
        'unitvalue
        '
        Me.unitvalue.AutoSize = True
        Me.unitvalue.Location = New System.Drawing.Point(364, 390)
        Me.unitvalue.Name = "unitvalue"
        Me.unitvalue.Size = New System.Drawing.Size(56, 13)
        Me.unitvalue.TabIndex = 211
        Me.unitvalue.Text = "Unit Value"
        '
        'markupDecimail
        '
        Me.markupDecimail.Location = New System.Drawing.Point(87, 409)
        Me.markupDecimail.Name = "markupDecimail"
        Me.markupDecimail.Size = New System.Drawing.Size(100, 20)
        Me.markupDecimail.TabIndex = 212
        '
        'unitcostsum
        '
        Me.unitcostsum.Location = New System.Drawing.Point(607, 409)
        Me.unitcostsum.Name = "unitcostsum"
        Me.unitcostsum.Size = New System.Drawing.Size(100, 20)
        Me.unitcostsum.TabIndex = 213
        '
        'markupsum
        '
        Me.markupsum.Location = New System.Drawing.Point(244, 409)
        Me.markupsum.Name = "markupsum"
        Me.markupsum.Size = New System.Drawing.Size(100, 20)
        Me.markupsum.TabIndex = 214
        '
        'retailsum
        '
        Me.retailsum.Location = New System.Drawing.Point(771, 409)
        Me.retailsum.Name = "retailsum"
        Me.retailsum.Size = New System.Drawing.Size(100, 20)
        Me.retailsum.TabIndex = 215
        '
        'MovePrev
        '
        Me.MovePrev.Image = Global.Transvac_ERP.My.Resources.Resources.bindingNavigatorMovePreviousItem_Image
        Me.MovePrev.Location = New System.Drawing.Point(108, 466)
        Me.MovePrev.Name = "MovePrev"
        Me.MovePrev.Size = New System.Drawing.Size(68, 33)
        Me.MovePrev.TabIndex = 152
        Me.MovePrev.UseVisualStyleBackColor = True
        '
        'Movenxt
        '
        Me.Movenxt.Image = Global.Transvac_ERP.My.Resources.Resources.bindingNavigatorMoveNextItem_Image
        Me.Movenxt.Location = New System.Drawing.Point(182, 466)
        Me.Movenxt.Name = "Movenxt"
        Me.Movenxt.Size = New System.Drawing.Size(68, 33)
        Me.Movenxt.TabIndex = 151
        Me.Movenxt.UseVisualStyleBackColor = True
        '
        'MoveEnd
        '
        Me.MoveEnd.Image = Global.Transvac_ERP.My.Resources.Resources.bindingNavigatorMoveLastItem_Image
        Me.MoveEnd.Location = New System.Drawing.Point(256, 466)
        Me.MoveEnd.Name = "MoveEnd"
        Me.MoveEnd.Size = New System.Drawing.Size(68, 33)
        Me.MoveEnd.TabIndex = 150
        Me.MoveEnd.UseVisualStyleBackColor = True
        '
        'MoveStr
        '
        Me.MoveStr.Image = Global.Transvac_ERP.My.Resources.Resources.bindingNavigatorMoveFirstItem_Image
        Me.MoveStr.Location = New System.Drawing.Point(34, 466)
        Me.MoveStr.Name = "MoveStr"
        Me.MoveStr.Size = New System.Drawing.Size(68, 33)
        Me.MoveStr.TabIndex = 149
        Me.MoveStr.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
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
        'TrandescBindingSource1
        '
        Me.TrandescBindingSource1.DataMember = "trandesc"
        Me.TrandescBindingSource1.DataSource = Me.TransvacDataV2DataSet1
        '
        'LocatebinDataGridViewTextBoxColumn
        '
        Me.LocatebinDataGridViewTextBoxColumn.DataPropertyName = "locatebin"
        Me.LocatebinDataGridViewTextBoxColumn.HeaderText = "BIN CODE"
        Me.LocatebinDataGridViewTextBoxColumn.Name = "LocatebinDataGridViewTextBoxColumn"
        Me.LocatebinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SourcecdeDataGridViewTextBoxColumn
        '
        Me.SourcecdeDataGridViewTextBoxColumn.DataPropertyName = "sourcecde"
        Me.SourcecdeDataGridViewTextBoxColumn.HeaderText = "SOURCE"
        Me.SourcecdeDataGridViewTextBoxColumn.Name = "SourcecdeDataGridViewTextBoxColumn"
        Me.SourcecdeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantybinDataGridViewTextBoxColumn
        '
        Me.QuantybinDataGridViewTextBoxColumn.DataPropertyName = "quantybin"
        Me.QuantybinDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QuantybinDataGridViewTextBoxColumn.Name = "QuantybinDataGridViewTextBoxColumn"
        Me.QuantybinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitvalueDataGridViewTextBoxColumn
        '
        Me.UnitvalueDataGridViewTextBoxColumn.DataPropertyName = "unit_value"
        Me.UnitvalueDataGridViewTextBoxColumn.HeaderText = "UNIT VALUE"
        Me.UnitvalueDataGridViewTextBoxColumn.Name = "UnitvalueDataGridViewTextBoxColumn"
        Me.UnitvalueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrcycdeDataGridViewTextBoxColumn
        '
        Me.CurrcycdeDataGridViewTextBoxColumn.DataPropertyName = "currcy_cde"
        Me.CurrcycdeDataGridViewTextBoxColumn.HeaderText = "CURRENCY"
        Me.CurrcycdeDataGridViewTextBoxColumn.Name = "CurrcycdeDataGridViewTextBoxColumn"
        Me.CurrcycdeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IiupdateDataGridViewTextBoxColumn
        '
        Me.IiupdateDataGridViewTextBoxColumn.DataPropertyName = "iiupdate"
        Me.IiupdateDataGridViewTextBoxColumn.HeaderText = "UPDATED"
        Me.IiupdateDataGridViewTextBoxColumn.Name = "IiupdateDataGridViewTextBoxColumn"
        Me.IiupdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CatalogdtDataGridViewTextBoxColumn
        '
        Me.CatalogdtDataGridViewTextBoxColumn.DataPropertyName = "catalog_dt"
        Me.CatalogdtDataGridViewTextBoxColumn.HeaderText = "CAT DATE"
        Me.CatalogdtDataGridViewTextBoxColumn.Name = "CatalogdtDataGridViewTextBoxColumn"
        Me.CatalogdtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WqtyDataGridViewTextBoxColumn
        '
        Me.WqtyDataGridViewTextBoxColumn.DataPropertyName = "wqty"
        Me.WqtyDataGridViewTextBoxColumn.HeaderText = "WGTY"
        Me.WqtyDataGridViewTextBoxColumn.Name = "WqtyDataGridViewTextBoxColumn"
        Me.WqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "WEIGHT"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TranbinsBindingSource
        '
        Me.TranbinsBindingSource.DataMember = "tranbins"
        Me.TranbinsBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'TrandescTableAdapter1
        '
        Me.TrandescTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.accctlTableAdapter = Nothing
        Me.TableAdapterManager1.accountTableAdapter = Nothing
        Me.TableAdapterManager1.addnotesTableAdapter = Nothing
        Me.TableAdapterManager1.AddressRecordTypeTableAdapter = Nothing
        Me.TableAdapterManager1.ASSETSNEWTableAdapter = Nothing
        Me.TableAdapterManager1.assetsTableAdapter = Nothing
        Me.TableAdapterManager1.atransTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.binallocTableAdapter = Nothing
        Me.TableAdapterManager1.catTableAdapter = Nothing
        Me.TableAdapterManager1.countryTableAdapter = Nothing
        Me.TableAdapterManager1.custdiscTableAdapter = Nothing
        Me.TableAdapterManager1.dummy_TableAdapter = Nothing
        Me.TableAdapterManager1.enquiryTableAdapter = Nothing
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
        Me.TableAdapterManager1.trandescTableAdapter = Me.TrandescTableAdapter1
        Me.TableAdapterManager1.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TranbinsTableAdapter
        '
        Me.TranbinsTableAdapter.ClearBeforeFill = True
        '
        'MarkupTableAdapter
        '
        Me.MarkupTableAdapter.ClearBeforeFill = True
        '
        'OrddetailBindingSource
        '
        Me.OrddetailBindingSource.DataMember = "orddetail"
        Me.OrddetailBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'OrddetailTableAdapter
        '
        Me.OrddetailTableAdapter.ClearBeforeFill = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1068, 939)
        Me.Controls.Add(Me.retailsum)
        Me.Controls.Add(Me.markupsum)
        Me.Controls.Add(Me.unitcostsum)
        Me.Controls.Add(Me.markupDecimail)
        Me.Controls.Add(Me.unitvalue)
        Me.Controls.Add(Me.unitvaluebox)
        Me.Controls.Add(Me.markup)
        Me.Controls.Add(Me.retail)
        Me.Controls.Add(Me.unitcost)
        Me.Controls.Add(Me.SupDisc)
        Me.Controls.Add(Me.retailbox)
        Me.Controls.Add(Me.unitcostbox)
        Me.Controls.Add(Me.markupbox)
        Me.Controls.Add(Me.supdiscbox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.idcode)
        Me.Controls.Add(Me.PcodeLook)
        Me.Controls.Add(Me.MinorderTextBox)
        Me.Controls.Add(Me.MinstockTextBox)
        Me.Controls.Add(Me.IdcodeTextBox)
        Me.Controls.Add(Me.DescriptnTextBox1)
        Me.Controls.Add(Me.PcodeTextBox1)
        Me.Controls.Add(Me.PsupplierTextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.editmem_but)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.orderd_but)
        Me.Controls.Add(Me.xchange_but)
        Me.Controls.Add(Me.alloc_but)
        Me.Controls.Add(Me.markup_but)
        Me.Controls.Add(Me.editbin_but)
        Me.Controls.Add(Me.nwbin_but)
        Me.Controls.Add(Me.bincode_but)
        Me.Controls.Add(Me.avgtotval_but)
        Me.Controls.Add(Me.quit_but)
        Me.Controls.Add(Me.newdesc_but)
        Me.Controls.Add(Me.editdesc_but)
        Me.Controls.Add(Me.deldesc_but)
        Me.Controls.Add(Me.findesc_but)
        Me.Controls.Add(Me.MovePrev)
        Me.Controls.Add(Me.Movenxt)
        Me.Controls.Add(Me.MoveEnd)
        Me.Controls.Add(Me.MoveStr)
        Me.Controls.Add(DescriptnLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrandescBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrddetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MovePrev As Button
    Friend WithEvents Movenxt As Button
    Friend WithEvents MoveEnd As Button
    Friend WithEvents MoveStr As Button
    Friend WithEvents findesc_but As Button
    Friend WithEvents deldesc_but As Button
    Friend WithEvents editdesc_but As Button
    Friend WithEvents newdesc_but As Button
    Friend WithEvents quit_but As Button
    Friend WithEvents avgtotval_but As Button
    Friend WithEvents bincode_but As Button
    Friend WithEvents nwbin_but As Button
    Friend WithEvents editbin_but As Button
    Friend WithEvents markup_but As Button
    Friend WithEvents alloc_but As Button
    Friend WithEvents xchange_but As Button
    Friend WithEvents orderd_but As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents editmem_but As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PsupplierTextBox1 As TextBox
    Friend WithEvents PcodeTextBox1 As TextBox
    Friend WithEvents DescriptnTextBox1 As TextBox
    Friend WithEvents IdcodeTextBox As TextBox
    Friend WithEvents MinstockTextBox As TextBox
    Friend WithEvents MinorderTextBox As TextBox
    Friend WithEvents PcodeLook As Button
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TrandescBindingSource1 As BindingSource
    Friend WithEvents TrandescTableAdapter1 As TransvacDataV2DataSet1TableAdapters.trandescTableAdapter
    Friend WithEvents TableAdapterManager1 As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents idcode As TextBox
    Friend WithEvents TranbinsBindingSource As BindingSource
    Friend WithEvents TranbinsTableAdapter As TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LocatebinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SourcecdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantybinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitvalueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrcycdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IiupdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatalogdtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarkupBindingSource As BindingSource
    Friend WithEvents MarkupTableAdapter As TransvacDataV2DataSet1TableAdapters.markupTableAdapter
    Friend WithEvents supdiscbox As TextBox
    Friend WithEvents markupbox As TextBox
    Friend WithEvents unitcostbox As TextBox
    Friend WithEvents retailbox As TextBox
    Friend WithEvents SupDisc As Label
    Friend WithEvents unitcost As Label
    Friend WithEvents retail As Label
    Friend WithEvents markup As Label
    Friend WithEvents unitvaluebox As TextBox
    Friend WithEvents unitvalue As Label
    Friend WithEvents markupDecimail As TextBox
    Friend WithEvents unitcostsum As TextBox
    Friend WithEvents markupsum As TextBox
    Friend WithEvents retailsum As TextBox
    Friend WithEvents OrddetailBindingSource As BindingSource
    Friend WithEvents OrddetailTableAdapter As TransvacDataV2DataSet1TableAdapters.orddetailTableAdapter
End Class
