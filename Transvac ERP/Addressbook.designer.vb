<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Dim PROFORMALabel As System.Windows.Forms.Label
        Dim NEW_UPDLabel As System.Windows.Forms.Label
        Dim INUSELabel As System.Windows.Forms.Label
        Dim NWHOLabel As System.Windows.Forms.Label
        Dim ENTRYTYPELabel As System.Windows.Forms.Label
        Dim TERMDAYSLabel As System.Windows.Forms.Label
        Dim EUROVATLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim FAXLabel As System.Windows.Forms.Label
        Dim TELEXLabel As System.Windows.Forms.Label
        Dim PHONELabel As System.Windows.Forms.Label
        Dim NAMELabel As System.Windows.Forms.Label
        Dim ACCOUNTLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.PROFORMATextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.osequencelb = New System.Windows.Forms.ListBox()
        Me.findbut = New System.Windows.Forms.Button()
        Me.membut = New System.Windows.Forms.Button()
        Me.savebut = New System.Windows.Forms.Button()
        Me.editbut = New System.Windows.Forms.Button()
        Me.abortbut = New System.Windows.Forms.Button()
        Me.printbutton = New System.Windows.Forms.Button()
        Me.delbut = New System.Windows.Forms.Button()
        Me.newbut = New System.Windows.Forms.Button()
        Me.but5 = New System.Windows.Forms.Button()
        Me.but6 = New System.Windows.Forms.Button()
        Me.but7 = New System.Windows.Forms.Button()
        Me.but4 = New System.Windows.Forms.Button()
        Me.PROMOCheckBox = New System.Windows.Forms.CheckBox()
        Me.XCARDCheckBox = New System.Windows.Forms.CheckBox()
        Me.NEW_UPDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.INUSETextBox = New System.Windows.Forms.TextBox()
        Me.NWHOTextBox = New System.Windows.Forms.TextBox()
        Me.ENTRYTYPETextBox = New System.Windows.Forms.TextBox()
        Me.Tran2BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tran2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADDRESSBKDataSet = New Transvac_ERP.ADDRESSBKDataSet()
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
        Me.Tran2BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NAMETextBox1 = New System.Windows.Forms.TextBox()
        Me.AD1TextBox1 = New System.Windows.Forms.TextBox()
        Me.AD2TextBox1 = New System.Windows.Forms.TextBox()
        Me.AD3TextBox = New System.Windows.Forms.TextBox()
        Me.AD4TextBox = New System.Windows.Forms.TextBox()
        Me.AD5TextBox = New System.Windows.Forms.TextBox()
        Me.PHONETextBox = New System.Windows.Forms.TextBox()
        Me.TELEXTextBox = New System.Windows.Forms.TextBox()
        Me.FAXTextBox = New System.Windows.Forms.TextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.VATPAYABLECheckBox1 = New System.Windows.Forms.CheckBox()
        Me.EUROVATTextBox = New System.Windows.Forms.TextBox()
        Me.TERMDAYSTextBox = New System.Windows.Forms.TextBox()
        Me.ACCOUNTTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.selectbut = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tran2TableAdapter = New Transvac_ERP.ADDRESSBKDataSetTableAdapters.tran2TableAdapter()
        Me.TableAdapterManager = New Transvac_ERP.ADDRESSBKDataSetTableAdapters.TableAdapterManager()
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.AddnotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddnotesTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.addnotesTableAdapter()
        Me.ADDMEMOTextBox = New System.Windows.Forms.TextBox()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActmemoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimestampcolumnDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.UniqueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fndact_but = New System.Windows.Forms.Button()
        Me.fndname_but = New System.Windows.Forms.Button()
        PROFORMALabel = New System.Windows.Forms.Label()
        NEW_UPDLabel = New System.Windows.Forms.Label()
        INUSELabel = New System.Windows.Forms.Label()
        NWHOLabel = New System.Windows.Forms.Label()
        ENTRYTYPELabel = New System.Windows.Forms.Label()
        TERMDAYSLabel = New System.Windows.Forms.Label()
        EUROVATLabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        FAXLabel = New System.Windows.Forms.Label()
        TELEXLabel = New System.Windows.Forms.Label()
        PHONELabel = New System.Windows.Forms.Label()
        NAMELabel = New System.Windows.Forms.Label()
        ACCOUNTLabel = New System.Windows.Forms.Label()
        CType(Me.Tran2BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tran2BindingNavigator.SuspendLayout()
        CType(Me.Tran2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADDRESSBKDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddnotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PROFORMALabel
        '
        PROFORMALabel.AutoSize = True
        PROFORMALabel.Location = New System.Drawing.Point(268, 373)
        PROFORMALabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PROFORMALabel.Name = "PROFORMALabel"
        PROFORMALabel.Size = New System.Drawing.Size(71, 13)
        PROFORMALabel.TabIndex = 161
        PROFORMALabel.Text = "PROFORMA:"
        '
        'NEW_UPDLabel
        '
        NEW_UPDLabel.AutoSize = True
        NEW_UPDLabel.Location = New System.Drawing.Point(604, 90)
        NEW_UPDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NEW_UPDLabel.Name = "NEW_UPDLabel"
        NEW_UPDLabel.Size = New System.Drawing.Size(71, 13)
        NEW_UPDLabel.TabIndex = 141
        NEW_UPDLabel.Text = "Last Updated"
        '
        'INUSELabel
        '
        INUSELabel.AutoSize = True
        INUSELabel.Location = New System.Drawing.Point(489, 348)
        INUSELabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        INUSELabel.Name = "INUSELabel"
        INUSELabel.Size = New System.Drawing.Size(43, 13)
        INUSELabel.TabIndex = 139
        INUSELabel.Text = "INUSE:"
        '
        'NWHOLabel
        '
        NWHOLabel.AutoSize = True
        NWHOLabel.Location = New System.Drawing.Point(743, 90)
        NWHOLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NWHOLabel.Name = "NWHOLabel"
        NWHOLabel.Size = New System.Drawing.Size(22, 13)
        NWHOLabel.TabIndex = 137
        NWHOLabel.Text = "By:"
        '
        'ENTRYTYPELabel
        '
        ENTRYTYPELabel.AutoSize = True
        ENTRYTYPELabel.Location = New System.Drawing.Point(266, 397)
        ENTRYTYPELabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ENTRYTYPELabel.Name = "ENTRYTYPELabel"
        ENTRYTYPELabel.Size = New System.Drawing.Size(59, 13)
        ENTRYTYPELabel.TabIndex = 135
        ENTRYTYPELabel.Text = "PAYTYPE:"
        '
        'TERMDAYSLabel
        '
        TERMDAYSLabel.AutoSize = True
        TERMDAYSLabel.Location = New System.Drawing.Point(292, 246)
        TERMDAYSLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TERMDAYSLabel.Name = "TERMDAYSLabel"
        TERMDAYSLabel.Size = New System.Drawing.Size(39, 13)
        TERMDAYSLabel.TabIndex = 133
        TERMDAYSLabel.Text = "Terms:"
        '
        'EUROVATLabel
        '
        EUROVATLabel.AutoSize = True
        EUROVATLabel.Location = New System.Drawing.Point(294, 271)
        EUROVATLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EUROVATLabel.Name = "EUROVATLabel"
        EUROVATLabel.Size = New System.Drawing.Size(53, 13)
        EUROVATLabel.TabIndex = 129
        EUROVATLabel.Text = "EuroVAT:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(294, 221)
        EMAILLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(39, 13)
        EMAILLabel.TabIndex = 127
        EMAILLabel.Text = "E-Mail:"
        '
        'FAXLabel
        '
        FAXLabel.AutoSize = True
        FAXLabel.Location = New System.Drawing.Point(293, 194)
        FAXLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FAXLabel.Name = "FAXLabel"
        FAXLabel.Size = New System.Drawing.Size(44, 13)
        FAXLabel.TabIndex = 125
        FAXLabel.Text = "Fax No:"
        '
        'TELEXLabel
        '
        TELEXLabel.AutoSize = True
        TELEXLabel.Location = New System.Drawing.Point(291, 168)
        TELEXLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TELEXLabel.Name = "TELEXLabel"
        TELEXLabel.Size = New System.Drawing.Size(72, 13)
        TELEXLabel.TabIndex = 123
        TELEXLabel.Text = "Telex/Mobile:"
        '
        'PHONELabel
        '
        PHONELabel.AutoSize = True
        PHONELabel.Location = New System.Drawing.Point(291, 140)
        PHONELabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PHONELabel.Name = "PHONELabel"
        PHONELabel.Size = New System.Drawing.Size(48, 13)
        PHONELabel.TabIndex = 121
        PHONELabel.Text = "Tele No:"
        '
        'NAMELabel
        '
        NAMELabel.AutoSize = True
        NAMELabel.Location = New System.Drawing.Point(93, 120)
        NAMELabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NAMELabel.Name = "NAMELabel"
        NAMELabel.Size = New System.Drawing.Size(78, 13)
        NAMELabel.TabIndex = 114
        NAMELabel.Text = "Contact Name "
        AddHandler NAMELabel.Click, AddressOf Me.NAMELabel_Click
        '
        'ACCOUNTLabel
        '
        ACCOUNTLabel.AutoSize = True
        ACCOUNTLabel.Location = New System.Drawing.Point(30, 120)
        ACCOUNTLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ACCOUNTLabel.Name = "ACCOUNTLabel"
        ACCOUNTLabel.Size = New System.Drawing.Size(46, 13)
        ACCOUNTLabel.TabIndex = 112
        ACCOUNTLabel.Text = "Acct No"
        '
        'PROFORMATextBox
        '
        Me.PROFORMATextBox.Location = New System.Drawing.Point(338, 370)
        Me.PROFORMATextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PROFORMATextBox.Name = "PROFORMATextBox"
        Me.PROFORMATextBox.Size = New System.Drawing.Size(76, 20)
        Me.PROFORMATextBox.TabIndex = 162
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(114, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 13)
        Me.Label16.TabIndex = 160
        Me.Label16.Text = "Transvac Systems Address Book"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Address (5 Lines)"
        '
        'osequencelb
        '
        Me.osequencelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.osequencelb.FormattingEnabled = True
        Me.osequencelb.ItemHeight = 16
        Me.osequencelb.Items.AddRange(New Object() {"Account", "Name"})
        Me.osequencelb.Location = New System.Drawing.Point(470, 470)
        Me.osequencelb.Name = "osequencelb"
        Me.osequencelb.Size = New System.Drawing.Size(74, 36)
        Me.osequencelb.TabIndex = 158
        '
        'findbut
        '
        Me.findbut.Location = New System.Drawing.Point(550, 483)
        Me.findbut.Name = "findbut"
        Me.findbut.Size = New System.Drawing.Size(74, 23)
        Me.findbut.TabIndex = 157
        Me.findbut.Text = "FIND"
        Me.findbut.UseVisualStyleBackColor = True
        '
        'membut
        '
        Me.membut.Location = New System.Drawing.Point(541, 285)
        Me.membut.Name = "membut"
        Me.membut.Size = New System.Drawing.Size(112, 23)
        Me.membut.TabIndex = 156
        Me.membut.Text = "Memo Update"
        Me.membut.UseVisualStyleBackColor = True
        '
        'savebut
        '
        Me.savebut.Location = New System.Drawing.Point(68, 359)
        Me.savebut.Name = "savebut"
        Me.savebut.Size = New System.Drawing.Size(74, 21)
        Me.savebut.TabIndex = 154
        Me.savebut.Text = "SAVE"
        Me.savebut.UseVisualStyleBackColor = True
        '
        'editbut
        '
        Me.editbut.Location = New System.Drawing.Point(150, 332)
        Me.editbut.Name = "editbut"
        Me.editbut.Size = New System.Drawing.Size(74, 23)
        Me.editbut.TabIndex = 153
        Me.editbut.Text = "EDIT"
        Me.editbut.UseVisualStyleBackColor = True
        '
        'abortbut
        '
        Me.abortbut.Location = New System.Drawing.Point(150, 358)
        Me.abortbut.Name = "abortbut"
        Me.abortbut.Size = New System.Drawing.Size(74, 23)
        Me.abortbut.TabIndex = 152
        Me.abortbut.Text = "ABORT"
        Me.abortbut.UseVisualStyleBackColor = True
        '
        'printbutton
        '
        Me.printbutton.Location = New System.Drawing.Point(108, 391)
        Me.printbutton.Name = "printbutton"
        Me.printbutton.Size = New System.Drawing.Size(75, 23)
        Me.printbutton.TabIndex = 151
        Me.printbutton.Text = "PRINT"
        Me.printbutton.UseVisualStyleBackColor = True
        '
        'delbut
        '
        Me.delbut.Location = New System.Drawing.Point(746, 49)
        Me.delbut.Name = "delbut"
        Me.delbut.Size = New System.Drawing.Size(76, 23)
        Me.delbut.TabIndex = 150
        Me.delbut.Text = "DELETE"
        Me.delbut.UseVisualStyleBackColor = True
        '
        'newbut
        '
        Me.newbut.Location = New System.Drawing.Point(68, 332)
        Me.newbut.Name = "newbut"
        Me.newbut.Size = New System.Drawing.Size(74, 23)
        Me.newbut.TabIndex = 149
        Me.newbut.Text = "NEW"
        Me.newbut.UseVisualStyleBackColor = True
        '
        'but5
        '
        Me.but5.Location = New System.Drawing.Point(86, 446)
        Me.but5.Name = "but5"
        Me.but5.Size = New System.Drawing.Size(45, 23)
        Me.but5.TabIndex = 148
        Me.but5.Text = "<"
        Me.but5.UseVisualStyleBackColor = True
        '
        'but6
        '
        Me.but6.Location = New System.Drawing.Point(142, 446)
        Me.but6.Name = "but6"
        Me.but6.Size = New System.Drawing.Size(45, 23)
        Me.but6.TabIndex = 147
        Me.but6.Text = ">"
        Me.but6.UseVisualStyleBackColor = True
        '
        'but7
        '
        Me.but7.Location = New System.Drawing.Point(196, 446)
        Me.but7.Name = "but7"
        Me.but7.Size = New System.Drawing.Size(45, 23)
        Me.but7.TabIndex = 146
        Me.but7.Text = "|>"
        Me.but7.UseVisualStyleBackColor = True
        '
        'but4
        '
        Me.but4.Location = New System.Drawing.Point(32, 446)
        Me.but4.Name = "but4"
        Me.but4.Size = New System.Drawing.Size(45, 23)
        Me.but4.TabIndex = 145
        Me.but4.Text = "|<"
        Me.but4.UseVisualStyleBackColor = True
        '
        'PROMOCheckBox
        '
        Me.PROMOCheckBox.Location = New System.Drawing.Point(757, 290)
        Me.PROMOCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PROMOCheckBox.Name = "PROMOCheckBox"
        Me.PROMOCheckBox.Size = New System.Drawing.Size(78, 20)
        Me.PROMOCheckBox.TabIndex = 144
        Me.PROMOCheckBox.Text = "PROMO:"
        Me.PROMOCheckBox.UseVisualStyleBackColor = True
        '
        'XCARDCheckBox
        '
        Me.XCARDCheckBox.Location = New System.Drawing.Point(757, 311)
        Me.XCARDCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.XCARDCheckBox.Name = "XCARDCheckBox"
        Me.XCARDCheckBox.Size = New System.Drawing.Size(78, 20)
        Me.XCARDCheckBox.TabIndex = 143
        Me.XCARDCheckBox.Text = "XCARD:"
        Me.XCARDCheckBox.UseVisualStyleBackColor = True
        '
        'NEW_UPDDateTimePicker
        '
        Me.NEW_UPDDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NEW_UPDDateTimePicker.Location = New System.Drawing.Point(607, 105)
        Me.NEW_UPDDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.NEW_UPDDateTimePicker.Name = "NEW_UPDDateTimePicker"
        Me.NEW_UPDDateTimePicker.Size = New System.Drawing.Size(102, 20)
        Me.NEW_UPDDateTimePicker.TabIndex = 142
        '
        'INUSETextBox
        '
        Me.INUSETextBox.Location = New System.Drawing.Point(541, 343)
        Me.INUSETextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.INUSETextBox.Name = "INUSETextBox"
        Me.INUSETextBox.Size = New System.Drawing.Size(72, 20)
        Me.INUSETextBox.TabIndex = 140
        '
        'NWHOTextBox
        '
        Me.NWHOTextBox.Location = New System.Drawing.Point(746, 105)
        Me.NWHOTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NWHOTextBox.Name = "NWHOTextBox"
        Me.NWHOTextBox.Size = New System.Drawing.Size(76, 20)
        Me.NWHOTextBox.TabIndex = 138
        '
        'ENTRYTYPETextBox
        '
        Me.ENTRYTYPETextBox.Location = New System.Drawing.Point(338, 393)
        Me.ENTRYTYPETextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ENTRYTYPETextBox.Name = "ENTRYTYPETextBox"
        Me.ENTRYTYPETextBox.Size = New System.Drawing.Size(141, 20)
        Me.ENTRYTYPETextBox.TabIndex = 136
        '
        'Tran2BindingNavigator
        '
        Me.Tran2BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tran2BindingNavigator.BindingSource = Me.Tran2BindingSource
        Me.Tran2BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tran2BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tran2BindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tran2BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tran2BindingNavigatorSaveItem, Me.PrintToolStripButton})
        Me.Tran2BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tran2BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tran2BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tran2BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tran2BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tran2BindingNavigator.Name = "Tran2BindingNavigator"
        Me.Tran2BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tran2BindingNavigator.Size = New System.Drawing.Size(870, 27)
        Me.Tran2BindingNavigator.TabIndex = 163
        Me.Tran2BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Tran2BindingSource
        '
        Me.Tran2BindingSource.DataMember = "tran2"
        Me.Tran2BindingSource.DataSource = Me.ADDRESSBKDataSet
        '
        'ADDRESSBKDataSet
        '
        Me.ADDRESSBKDataSet.DataSetName = "ADDRESSBKDataSet"
        Me.ADDRESSBKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Tran2BindingNavigatorSaveItem
        '
        Me.Tran2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tran2BindingNavigatorSaveItem.Image = CType(resources.GetObject("Tran2BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tran2BindingNavigatorSaveItem.Name = "Tran2BindingNavigatorSaveItem"
        Me.Tran2BindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.Tran2BindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'NAMETextBox1
        '
        Me.NAMETextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "NAME", True))
        Me.NAMETextBox1.Location = New System.Drawing.Point(95, 137)
        Me.NAMETextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.NAMETextBox1.Name = "NAMETextBox1"
        Me.NAMETextBox1.Size = New System.Drawing.Size(172, 20)
        Me.NAMETextBox1.TabIndex = 164
        '
        'AD1TextBox1
        '
        Me.AD1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "AD1", True))
        Me.AD1TextBox1.Location = New System.Drawing.Point(32, 185)
        Me.AD1TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.AD1TextBox1.Name = "AD1TextBox1"
        Me.AD1TextBox1.Size = New System.Drawing.Size(235, 20)
        Me.AD1TextBox1.TabIndex = 165
        '
        'AD2TextBox1
        '
        Me.AD2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "AD2", True))
        Me.AD2TextBox1.Location = New System.Drawing.Point(32, 211)
        Me.AD2TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.AD2TextBox1.Name = "AD2TextBox1"
        Me.AD2TextBox1.Size = New System.Drawing.Size(235, 20)
        Me.AD2TextBox1.TabIndex = 166
        '
        'AD3TextBox
        '
        Me.AD3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "AD3", True))
        Me.AD3TextBox.Location = New System.Drawing.Point(32, 237)
        Me.AD3TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AD3TextBox.Name = "AD3TextBox"
        Me.AD3TextBox.Size = New System.Drawing.Size(235, 20)
        Me.AD3TextBox.TabIndex = 167
        '
        'AD4TextBox
        '
        Me.AD4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "AD4", True))
        Me.AD4TextBox.Location = New System.Drawing.Point(32, 264)
        Me.AD4TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AD4TextBox.Name = "AD4TextBox"
        Me.AD4TextBox.Size = New System.Drawing.Size(235, 20)
        Me.AD4TextBox.TabIndex = 168
        '
        'AD5TextBox
        '
        Me.AD5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "AD5", True))
        Me.AD5TextBox.Location = New System.Drawing.Point(32, 291)
        Me.AD5TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AD5TextBox.Name = "AD5TextBox"
        Me.AD5TextBox.Size = New System.Drawing.Size(235, 20)
        Me.AD5TextBox.TabIndex = 169
        '
        'PHONETextBox
        '
        Me.PHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "PHONE", True))
        Me.PHONETextBox.Location = New System.Drawing.Point(361, 137)
        Me.PHONETextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PHONETextBox.Name = "PHONETextBox"
        Me.PHONETextBox.Size = New System.Drawing.Size(171, 20)
        Me.PHONETextBox.TabIndex = 170
        '
        'TELEXTextBox
        '
        Me.TELEXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "TELEX", True))
        Me.TELEXTextBox.Location = New System.Drawing.Point(361, 163)
        Me.TELEXTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TELEXTextBox.Name = "TELEXTextBox"
        Me.TELEXTextBox.Size = New System.Drawing.Size(171, 20)
        Me.TELEXTextBox.TabIndex = 171
        '
        'FAXTextBox
        '
        Me.FAXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "FAX", True))
        Me.FAXTextBox.Location = New System.Drawing.Point(361, 189)
        Me.FAXTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FAXTextBox.Name = "FAXTextBox"
        Me.FAXTextBox.Size = New System.Drawing.Size(171, 20)
        Me.FAXTextBox.TabIndex = 172
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(361, 215)
        Me.EMAILTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(171, 20)
        Me.EMAILTextBox.TabIndex = 173
        '
        'VATPAYABLECheckBox1
        '
        Me.VATPAYABLECheckBox1.Checked = True
        Me.VATPAYABLECheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VATPAYABLECheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tran2BindingSource, "VATPAYABLE", True))
        Me.VATPAYABLECheckBox1.Location = New System.Drawing.Point(361, 301)
        Me.VATPAYABLECheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.VATPAYABLECheckBox1.Name = "VATPAYABLECheckBox1"
        Me.VATPAYABLECheckBox1.Size = New System.Drawing.Size(96, 20)
        Me.VATPAYABLECheckBox1.TabIndex = 174
        Me.VATPAYABLECheckBox1.Text = "VAT Payable"
        Me.VATPAYABLECheckBox1.UseVisualStyleBackColor = True
        '
        'EUROVATTextBox
        '
        Me.EUROVATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "EUROVAT", True))
        Me.EUROVATTextBox.Location = New System.Drawing.Point(361, 267)
        Me.EUROVATTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EUROVATTextBox.Name = "EUROVATTextBox"
        Me.EUROVATTextBox.Size = New System.Drawing.Size(93, 20)
        Me.EUROVATTextBox.TabIndex = 175
        '
        'TERMDAYSTextBox
        '
        Me.TERMDAYSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "TERMDAYS", True))
        Me.TERMDAYSTextBox.Location = New System.Drawing.Point(361, 241)
        Me.TERMDAYSTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TERMDAYSTextBox.Name = "TERMDAYSTextBox"
        Me.TERMDAYSTextBox.Size = New System.Drawing.Size(171, 20)
        Me.TERMDAYSTextBox.TabIndex = 176
        '
        'ACCOUNTTextBox1
        '
        Me.ACCOUNTTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tran2BindingSource, "ACCOUNT", True))
        Me.ACCOUNTTextBox1.Location = New System.Drawing.Point(32, 137)
        Me.ACCOUNTTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ACCOUNTTextBox1.Name = "ACCOUNTTextBox1"
        Me.ACCOUNTTextBox1.Size = New System.Drawing.Size(65, 20)
        Me.ACCOUNTTextBox1.TabIndex = 177
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 493)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 13)
        Me.Label15.TabIndex = 178
        Me.Label15.Text = "Sales Ledger Address Book"
        '
        'selectbut
        '
        Me.selectbut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectbut.ForeColor = System.Drawing.Color.MidnightBlue
        Me.selectbut.Location = New System.Drawing.Point(721, 446)
        Me.selectbut.Name = "selectbut"
        Me.selectbut.Size = New System.Drawing.Size(101, 49)
        Me.selectbut.TabIndex = 180
        Me.selectbut.Text = "SELECT"
        Me.selectbut.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(7, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 181
        Me.PictureBox1.TabStop = False
        '
        'Tran2TableAdapter
        '
        Me.Tran2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.addnotesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tran2TableAdapter = Me.Tran2TableAdapter
        Me.TableAdapterManager.UpdateOrder = Transvac_ERP.ADDRESSBKDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddnotesBindingSource
        '
        Me.AddnotesBindingSource.DataMember = "addnotes"
        Me.AddnotesBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'AddnotesTableAdapter
        '
        Me.AddnotesTableAdapter.ClearBeforeFill = True
        '
        'ADDMEMOTextBox
        '
        Me.ADDMEMOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AddnotesBindingSource, "actmemo", True))
        Me.ADDMEMOTextBox.Location = New System.Drawing.Point(541, 135)
        Me.ADDMEMOTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ADDMEMOTextBox.Multiline = True
        Me.ADDMEMOTextBox.Name = "ADDMEMOTextBox"
        Me.ADDMEMOTextBox.Size = New System.Drawing.Size(281, 145)
        Me.ADDMEMOTextBox.TabIndex = 132
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "account"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "account"
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        '
        'ActmemoDataGridViewTextBoxColumn
        '
        Me.ActmemoDataGridViewTextBoxColumn.DataPropertyName = "actmemo"
        Me.ActmemoDataGridViewTextBoxColumn.HeaderText = "actmemo"
        Me.ActmemoDataGridViewTextBoxColumn.Name = "ActmemoDataGridViewTextBoxColumn"
        '
        'TimestampcolumnDataGridViewImageColumn
        '
        Me.TimestampcolumnDataGridViewImageColumn.DataPropertyName = "timestamp_column"
        Me.TimestampcolumnDataGridViewImageColumn.HeaderText = "timestamp_column"
        Me.TimestampcolumnDataGridViewImageColumn.Name = "TimestampcolumnDataGridViewImageColumn"
        Me.TimestampcolumnDataGridViewImageColumn.ReadOnly = True
        '
        'UniqueIDDataGridViewTextBoxColumn
        '
        Me.UniqueIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn.HeaderText = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn.Name = "UniqueIDDataGridViewTextBoxColumn"
        Me.UniqueIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'fndact_but
        '
        Me.fndact_but.Location = New System.Drawing.Point(721, 370)
        Me.fndact_but.Name = "fndact_but"
        Me.fndact_but.Size = New System.Drawing.Size(103, 23)
        Me.fndact_but.TabIndex = 182
        Me.fndact_but.Text = "FIND ACCOUNT"
        Me.fndact_but.UseVisualStyleBackColor = True
        '
        'fndname_but
        '
        Me.fndname_but.Location = New System.Drawing.Point(721, 399)
        Me.fndname_but.Name = "fndname_but"
        Me.fndname_but.Size = New System.Drawing.Size(103, 23)
        Me.fndname_but.TabIndex = 183
        Me.fndname_but.Text = "FIND NAME"
        Me.fndname_but.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(870, 542)
        Me.Controls.Add(Me.fndname_but)
        Me.Controls.Add(Me.fndact_but)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.selectbut)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ACCOUNTTextBox1)
        Me.Controls.Add(Me.TERMDAYSTextBox)
        Me.Controls.Add(Me.EUROVATTextBox)
        Me.Controls.Add(Me.VATPAYABLECheckBox1)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(Me.FAXTextBox)
        Me.Controls.Add(Me.TELEXTextBox)
        Me.Controls.Add(Me.PHONETextBox)
        Me.Controls.Add(Me.AD5TextBox)
        Me.Controls.Add(Me.AD4TextBox)
        Me.Controls.Add(Me.AD3TextBox)
        Me.Controls.Add(Me.AD2TextBox1)
        Me.Controls.Add(Me.AD1TextBox1)
        Me.Controls.Add(Me.NAMETextBox1)
        Me.Controls.Add(Me.Tran2BindingNavigator)
        Me.Controls.Add(PROFORMALabel)
        Me.Controls.Add(Me.PROFORMATextBox)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.osequencelb)
        Me.Controls.Add(Me.findbut)
        Me.Controls.Add(Me.membut)
        Me.Controls.Add(Me.savebut)
        Me.Controls.Add(Me.editbut)
        Me.Controls.Add(Me.abortbut)
        Me.Controls.Add(Me.printbutton)
        Me.Controls.Add(Me.delbut)
        Me.Controls.Add(Me.newbut)
        Me.Controls.Add(Me.but5)
        Me.Controls.Add(Me.but6)
        Me.Controls.Add(Me.but7)
        Me.Controls.Add(Me.but4)
        Me.Controls.Add(Me.PROMOCheckBox)
        Me.Controls.Add(Me.XCARDCheckBox)
        Me.Controls.Add(NEW_UPDLabel)
        Me.Controls.Add(Me.NEW_UPDDateTimePicker)
        Me.Controls.Add(INUSELabel)
        Me.Controls.Add(Me.INUSETextBox)
        Me.Controls.Add(NWHOLabel)
        Me.Controls.Add(Me.NWHOTextBox)
        Me.Controls.Add(ENTRYTYPELabel)
        Me.Controls.Add(Me.ENTRYTYPETextBox)
        Me.Controls.Add(TERMDAYSLabel)
        Me.Controls.Add(Me.ADDMEMOTextBox)
        Me.Controls.Add(EUROVATLabel)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(FAXLabel)
        Me.Controls.Add(TELEXLabel)
        Me.Controls.Add(PHONELabel)
        Me.Controls.Add(NAMELabel)
        Me.Controls.Add(ACCOUNTLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form1"
        Me.Text = "ADDRESS BOOK"
        CType(Me.Tran2BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tran2BindingNavigator.ResumeLayout(False)
        Me.Tran2BindingNavigator.PerformLayout()
        CType(Me.Tran2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADDRESSBKDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddnotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PROFORMATextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents osequencelb As ListBox
    Friend WithEvents findbut As Button
    Friend WithEvents membut As Button
    Friend WithEvents savebut As Button
    Friend WithEvents editbut As Button
    Friend WithEvents abortbut As Button
    Friend WithEvents printbutton As Button
    Friend WithEvents delbut As Button
    Friend WithEvents newbut As Button
    Friend WithEvents but5 As Button
    Friend WithEvents but6 As Button
    Friend WithEvents but7 As Button
    Friend WithEvents but4 As Button
    Friend WithEvents PROMOCheckBox As CheckBox
    Friend WithEvents XCARDCheckBox As CheckBox
    Friend WithEvents NEW_UPDDateTimePicker As DateTimePicker
    Friend WithEvents INUSETextBox As TextBox
    Friend WithEvents NWHOTextBox As TextBox
    Friend WithEvents ENTRYTYPETextBox As TextBox
    Friend WithEvents ADDRESSBKDataSet As ADDRESSBKDataSet
    Friend WithEvents Tran2BindingSource As BindingSource
    Friend WithEvents Tran2TableAdapter As ADDRESSBKDataSetTableAdapters.tran2TableAdapter
    Friend WithEvents TableAdapterManager As ADDRESSBKDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tran2BindingNavigator As BindingNavigator
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
    Friend WithEvents Tran2BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NAMETextBox1 As TextBox
    Friend WithEvents AD1TextBox1 As TextBox
    Friend WithEvents AD2TextBox1 As TextBox
    Friend WithEvents AD3TextBox As TextBox
    Friend WithEvents AD4TextBox As TextBox
    Friend WithEvents AD5TextBox As TextBox
    Friend WithEvents PHONETextBox As TextBox
    Friend WithEvents TELEXTextBox As TextBox
    Friend WithEvents FAXTextBox As TextBox
    Friend WithEvents EMAILTextBox As TextBox
    Friend WithEvents VATPAYABLECheckBox1 As CheckBox
    Friend WithEvents EUROVATTextBox As TextBox
    Friend WithEvents TERMDAYSTextBox As TextBox
    Friend WithEvents ACCOUNTTextBox1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents selectbut As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents AddnotesBindingSource As BindingSource
    Friend WithEvents AddnotesTableAdapter As TransvacDataV2DataSet1TableAdapters.addnotesTableAdapter
    Friend WithEvents ADDMEMOTextBox As TextBox
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActmemoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimestampcolumnDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents UniqueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents fndact_but As Button
    Friend WithEvents fndname_but As Button
End Class
