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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MovePrev = New System.Windows.Forms.Button()
        Me.Movenxt = New System.Windows.Forms.Button()
        Me.MoveEnd = New System.Windows.Forms.Button()
        Me.MoveStr = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.findesc_but = New System.Windows.Forms.Button()
        Me.deldesc_but = New System.Windows.Forms.Button()
        Me.editdesc_but = New System.Windows.Forms.Button()
        Me.newdesc_but = New System.Windows.Forms.Button()
        Me.quit_but = New System.Windows.Forms.Button()
        Me.avgtotval_but = New System.Windows.Forms.Button()
        Me.stockadj_but = New System.Windows.Forms.Button()
        Me.bincode_but = New System.Windows.Forms.Button()
        Me.nwbin_but = New System.Windows.Forms.Button()
        Me.editbin_but = New System.Windows.Forms.Button()
        Me.delbin_but = New System.Windows.Forms.Button()
        Me.markup_but = New System.Windows.Forms.Button()
        Me.alloc_but = New System.Windows.Forms.Button()
        Me.stkmovmt_but = New System.Windows.Forms.Button()
        Me.xchange_but = New System.Windows.Forms.Button()
        Me.orderd_but = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.TrandescBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrandescBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.idcode = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TrandescBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TranbinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrandescTableAdapter1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.trandescTableAdapter()
        Me.TableAdapterManager1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.TranbinsTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter()
        Me.LocatebinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourcecdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantybinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrcycdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IiupdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatalogdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListView2 = New System.Windows.Forms.ListView()
        DescriptnLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrandescBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrandescBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.TrandescBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Label4.Location = New System.Drawing.Point(863, 122)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(107, 13)
        Label4.TabIndex = 175
        Label4.Text = "Min Order Commodity"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(863, 149)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 13)
        Label5.TabIndex = 176
        Label5.Text = "Min Stock"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(863, 95)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(81, 13)
        Label6.TabIndex = 177
        Label6.Text = "Stock Checked"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(842, 375)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 13)
        Me.Label30.TabIndex = 85
        Me.Label30.Text = "MARKUP %"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(912, 375)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 13)
        Me.Label29.TabIndex = 84
        Me.Label29.Text = "WQTY"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(958, 375)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 13)
        Me.Label28.TabIndex = 83
        Me.Label28.Text = "WEIGHT"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(570, 375)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 13)
        Me.Label27.TabIndex = 82
        Me.Label27.Text = "UNIT £ COST"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(717, 375)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 13)
        Me.Label26.TabIndex = 81
        Me.Label26.Text = "CAT DATE"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(783, 375)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 13)
        Me.Label25.TabIndex = 80
        Me.Label25.Text = "RETAIL £"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(417, 375)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 13)
        Me.Label24.TabIndex = 79
        Me.Label24.Text = "CURRENCY"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(490, 375)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 13)
        Me.Label23.TabIndex = 78
        Me.Label23.Text = "UNIT £ COST"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(652, 375)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 77
        Me.Label22.Text = "UPDATED"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(277, 375)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "UNIT VALUE"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(209, 375)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "QUANTITY"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(192, 375)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(354, 375)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "SUP DISC"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(134, 375)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "SOURCE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(53, 375)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(70, 375)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "BIN CODE"
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
        'MovePrev
        '
        Me.MovePrev.Image = Global.Transvac_ERP.My.Resources.Resources.bindingNavigatorMovePreviousItem_Image
        Me.MovePrev.Location = New System.Drawing.Point(128, 546)
        Me.MovePrev.Name = "MovePrev"
        Me.MovePrev.Size = New System.Drawing.Size(68, 23)
        Me.MovePrev.TabIndex = 152
        Me.MovePrev.UseVisualStyleBackColor = True
        '
        'Movenxt
        '
        Me.Movenxt.Image = Global.Transvac_ERP.My.Resources.Resources.bindingNavigatorMoveNextItem_Image
        Me.Movenxt.Location = New System.Drawing.Point(202, 546)
        Me.Movenxt.Name = "Movenxt"
        Me.Movenxt.Size = New System.Drawing.Size(68, 23)
        Me.Movenxt.TabIndex = 151
        Me.Movenxt.UseVisualStyleBackColor = True
        '
        'MoveEnd
        '
        Me.MoveEnd.Image = Global.Transvac_ERP.My.Resources.Resources.bindingNavigatorMoveLastItem_Image
        Me.MoveEnd.Location = New System.Drawing.Point(276, 546)
        Me.MoveEnd.Name = "MoveEnd"
        Me.MoveEnd.Size = New System.Drawing.Size(68, 23)
        Me.MoveEnd.TabIndex = 150
        Me.MoveEnd.UseVisualStyleBackColor = True
        '
        'MoveStr
        '
        Me.MoveStr.Image = Global.Transvac_ERP.My.Resources.Resources.bindingNavigatorMoveFirstItem_Image
        Me.MoveStr.Location = New System.Drawing.Point(54, 546)
        Me.MoveStr.Name = "MoveStr"
        Me.MoveStr.Size = New System.Drawing.Size(68, 23)
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
        'findesc_but
        '
        Me.findesc_but.Location = New System.Drawing.Point(511, 171)
        Me.findesc_but.Name = "findesc_but"
        Me.findesc_but.Size = New System.Drawing.Size(75, 41)
        Me.findesc_but.TabIndex = 153
        Me.findesc_but.Text = "Find Desc"
        Me.findesc_but.UseVisualStyleBackColor = True
        '
        'deldesc_but
        '
        Me.deldesc_but.Location = New System.Drawing.Point(716, 150)
        Me.deldesc_but.Name = "deldesc_but"
        Me.deldesc_but.Size = New System.Drawing.Size(75, 23)
        Me.deldesc_but.TabIndex = 154
        Me.deldesc_but.Text = "Delete Desc"
        Me.deldesc_but.UseVisualStyleBackColor = True
        '
        'editdesc_but
        '
        Me.editdesc_but.Location = New System.Drawing.Point(716, 120)
        Me.editdesc_but.Name = "editdesc_but"
        Me.editdesc_but.Size = New System.Drawing.Size(75, 23)
        Me.editdesc_but.TabIndex = 155
        Me.editdesc_but.Text = "Edit Desc"
        Me.editdesc_but.UseVisualStyleBackColor = True
        '
        'newdesc_but
        '
        Me.newdesc_but.Location = New System.Drawing.Point(716, 90)
        Me.newdesc_but.Name = "newdesc_but"
        Me.newdesc_but.Size = New System.Drawing.Size(75, 23)
        Me.newdesc_but.TabIndex = 156
        Me.newdesc_but.Text = "New Desc"
        Me.newdesc_but.UseVisualStyleBackColor = True
        '
        'quit_but
        '
        Me.quit_but.Location = New System.Drawing.Point(52, 597)
        Me.quit_but.Name = "quit_but"
        Me.quit_but.Size = New System.Drawing.Size(70, 51)
        Me.quit_but.TabIndex = 157
        Me.quit_but.Text = "Quit"
        Me.quit_but.UseVisualStyleBackColor = True
        '
        'avgtotval_but
        '
        Me.avgtotval_but.Location = New System.Drawing.Point(217, 597)
        Me.avgtotval_but.Name = "avgtotval_but"
        Me.avgtotval_but.Size = New System.Drawing.Size(96, 23)
        Me.avgtotval_but.TabIndex = 158
        Me.avgtotval_but.Text = "Avg/Total Value"
        Me.avgtotval_but.UseVisualStyleBackColor = True
        '
        'stockadj_but
        '
        Me.stockadj_but.Location = New System.Drawing.Point(319, 597)
        Me.stockadj_but.Name = "stockadj_but"
        Me.stockadj_but.Size = New System.Drawing.Size(107, 23)
        Me.stockadj_but.TabIndex = 159
        Me.stockadj_but.Text = "Stock Adjustment"
        Me.stockadj_but.UseVisualStyleBackColor = True
        '
        'bincode_but
        '
        Me.bincode_but.Location = New System.Drawing.Point(432, 596)
        Me.bincode_but.Name = "bincode_but"
        Me.bincode_but.Size = New System.Drawing.Size(102, 23)
        Me.bincode_but.TabIndex = 160
        Me.bincode_but.Text = "Bin Code"
        Me.bincode_but.UseVisualStyleBackColor = True
        '
        'nwbin_but
        '
        Me.nwbin_but.Location = New System.Drawing.Point(568, 596)
        Me.nwbin_but.Name = "nwbin_but"
        Me.nwbin_but.Size = New System.Drawing.Size(75, 23)
        Me.nwbin_but.TabIndex = 161
        Me.nwbin_but.Text = "New Bin"
        Me.nwbin_but.UseVisualStyleBackColor = True
        '
        'editbin_but
        '
        Me.editbin_but.Location = New System.Drawing.Point(568, 654)
        Me.editbin_but.Name = "editbin_but"
        Me.editbin_but.Size = New System.Drawing.Size(75, 23)
        Me.editbin_but.TabIndex = 162
        Me.editbin_but.Text = "Edit Bin"
        Me.editbin_but.UseVisualStyleBackColor = True
        '
        'delbin_but
        '
        Me.delbin_but.Location = New System.Drawing.Point(568, 625)
        Me.delbin_but.Name = "delbin_but"
        Me.delbin_but.Size = New System.Drawing.Size(75, 23)
        Me.delbin_but.TabIndex = 163
        Me.delbin_but.Text = "Delete Bin"
        Me.delbin_but.UseVisualStyleBackColor = True
        '
        'markup_but
        '
        Me.markup_but.Location = New System.Drawing.Point(217, 625)
        Me.markup_but.Name = "markup_but"
        Me.markup_but.Size = New System.Drawing.Size(96, 23)
        Me.markup_but.TabIndex = 164
        Me.markup_but.Text = "MarkUp"
        Me.markup_but.UseVisualStyleBackColor = True
        '
        'alloc_but
        '
        Me.alloc_but.Location = New System.Drawing.Point(501, 697)
        Me.alloc_but.Name = "alloc_but"
        Me.alloc_but.Size = New System.Drawing.Size(75, 23)
        Me.alloc_but.TabIndex = 165
        Me.alloc_but.Text = "Allocated"
        Me.alloc_but.UseVisualStyleBackColor = True
        '
        'stkmovmt_but
        '
        Me.stkmovmt_but.Location = New System.Drawing.Point(319, 625)
        Me.stkmovmt_but.Name = "stkmovmt_but"
        Me.stkmovmt_but.Size = New System.Drawing.Size(107, 23)
        Me.stkmovmt_but.TabIndex = 166
        Me.stkmovmt_but.Text = "Stock Movement"
        Me.stkmovmt_but.UseVisualStyleBackColor = True
        '
        'xchange_but
        '
        Me.xchange_but.Location = New System.Drawing.Point(432, 625)
        Me.xchange_but.Name = "xchange_but"
        Me.xchange_but.Size = New System.Drawing.Size(102, 23)
        Me.xchange_but.TabIndex = 167
        Me.xchange_but.Text = "Xchange Rate"
        Me.xchange_but.UseVisualStyleBackColor = True
        '
        'orderd_but
        '
        Me.orderd_but.Location = New System.Drawing.Point(501, 726)
        Me.orderd_but.Name = "orderd_but"
        Me.orderd_but.Size = New System.Drawing.Size(75, 23)
        Me.orderd_but.TabIndex = 168
        Me.orderd_but.Text = "Ordered"
        Me.orderd_but.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.PeachPuff
        Me.TextBox2.Location = New System.Drawing.Point(582, 699)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(61, 20)
        Me.TextBox2.TabIndex = 170
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.TextBox1.Location = New System.Drawing.Point(582, 728)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 171
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "descmemo", True))
        Me.TextBox3.Location = New System.Drawing.Point(673, 560)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(335, 131)
        Me.TextBox3.TabIndex = 172
        '
        'editmem_but
        '
        Me.editmem_but.Location = New System.Drawing.Point(672, 702)
        Me.editmem_but.Name = "editmem_but"
        Me.editmem_but.Size = New System.Drawing.Size(76, 31)
        Me.editmem_but.TabIndex = 173
        Me.editmem_but.Text = "Edit Memo"
        Me.editmem_but.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(1011, 559)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(16, 132)
        Me.VScrollBar1.TabIndex = 174
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(945, 526)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(82, 20)
        Me.TextBox5.TabIndex = 181
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(860, 529)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Avg/Total Sale"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(754, 526)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(82, 20)
        Me.TextBox4.TabIndex = 183
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(669, 529)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "Avg/Total Cost"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(865, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 188
        Me.Label9.Text = "Bin Code"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(158, 154)
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
        Me.DataGridView1.Location = New System.Drawing.Point(34, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1204, 150)
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
        Me.IdcodeTextBox.Location = New System.Drawing.Point(980, 173)
        Me.IdcodeTextBox.Name = "IdcodeTextBox"
        Me.IdcodeTextBox.Size = New System.Drawing.Size(66, 20)
        Me.IdcodeTextBox.TabIndex = 195
        '
        'MinstockTextBox
        '
        Me.MinstockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "minstock", True))
        Me.MinstockTextBox.Location = New System.Drawing.Point(980, 147)
        Me.MinstockTextBox.Name = "MinstockTextBox"
        Me.MinstockTextBox.Size = New System.Drawing.Size(66, 20)
        Me.MinstockTextBox.TabIndex = 196
        '
        'MinorderTextBox
        '
        Me.MinorderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrandescBindingSource1, "minorder", True))
        Me.MinorderTextBox.Location = New System.Drawing.Point(980, 119)
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
        'TrandescBindingSource1BindingNavigator
        '
        Me.TrandescBindingSource1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TrandescBindingSource1BindingNavigator.BindingSource = Me.TrandescBindingSource1
        Me.TrandescBindingSource1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TrandescBindingSource1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TrandescBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TrandescBindingSource1BindingNavigatorSaveItem})
        Me.TrandescBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TrandescBindingSource1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TrandescBindingSource1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TrandescBindingSource1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TrandescBindingSource1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TrandescBindingSource1BindingNavigator.Name = "TrandescBindingSource1BindingNavigator"
        Me.TrandescBindingSource1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TrandescBindingSource1BindingNavigator.Size = New System.Drawing.Size(1270, 25)
        Me.TrandescBindingSource1BindingNavigator.TabIndex = 199
        Me.TrandescBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TrandescBindingSource1BindingNavigatorSaveItem
        '
        Me.TrandescBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TrandescBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("TrandescBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TrandescBindingSource1BindingNavigatorSaveItem.Name = "TrandescBindingSource1BindingNavigatorSaveItem"
        Me.TrandescBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TrandescBindingSource1BindingNavigatorSaveItem.Text = "Save Data"
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(980, 93)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 201
        '
        'TrandescBindingSource1
        '
        Me.TrandescBindingSource1.DataMember = "trandesc"
        Me.TrandescBindingSource1.DataSource = Me.TransvacDataV2DataSet1
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(70, 388)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(954, 132)
        Me.ListView2.TabIndex = 67
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1270, 769)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.idcode)
        Me.Controls.Add(Me.TrandescBindingSource1BindingNavigator)
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
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.orderd_but)
        Me.Controls.Add(Me.xchange_but)
        Me.Controls.Add(Me.stkmovmt_but)
        Me.Controls.Add(Me.alloc_but)
        Me.Controls.Add(Me.markup_but)
        Me.Controls.Add(Me.delbin_but)
        Me.Controls.Add(Me.editbin_but)
        Me.Controls.Add(Me.nwbin_but)
        Me.Controls.Add(Me.bincode_but)
        Me.Controls.Add(Me.stockadj_but)
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
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ListView2)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrandescBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrandescBindingSource1BindingNavigator.ResumeLayout(False)
        Me.TrandescBindingSource1BindingNavigator.PerformLayout()
        CType(Me.TrandescBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
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
    Friend WithEvents stockadj_but As Button
    Friend WithEvents bincode_but As Button
    Friend WithEvents nwbin_but As Button
    Friend WithEvents editbin_but As Button
    Friend WithEvents delbin_but As Button
    Friend WithEvents markup_but As Button
    Friend WithEvents alloc_but As Button
    Friend WithEvents stkmovmt_but As Button
    Friend WithEvents xchange_but As Button
    Friend WithEvents orderd_but As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
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
    Friend WithEvents TrandescBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TrandescBindingSource1BindingNavigatorSaveItem As ToolStripButton
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
    Friend WithEvents ListView2 As ListView
End Class
