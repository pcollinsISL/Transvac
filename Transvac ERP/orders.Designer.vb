<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim OSUPPLIERLabel As System.Windows.Forms.Label
        Dim OCURRLabel As System.Windows.Forms.Label
        Dim OSEMAILLabel As System.Windows.Forms.Label
        Dim OSTELNOLabel As System.Windows.Forms.Label
        Dim OSFAXNOLabel As System.Windows.Forms.Label
        Dim OSCONTACTLabel As System.Windows.Forms.Label
        Dim OSNAMELabel As System.Windows.Forms.Label
        Dim OHEADERLabel As System.Windows.Forms.Label
        Dim LODATELabel As System.Windows.Forms.Label
        Dim LQTYORDLabel As System.Windows.Forms.Label
        Dim LPRICELabel As System.Windows.Forms.Label
        Dim LEPRICELabel As System.Windows.Forms.Label
        Dim LPARTNOLabel As System.Windows.Forms.Label
        Dim LDESCLabel As System.Windows.Forms.Label
        Dim LOLINEMEMOLabel2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim Label3 As System.Windows.Forms.Label

        Me.OrderheadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderheadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OrderheadBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cosupplier = New System.Windows.Forms.TextBox()
        Me.cocurr = New System.Windows.Forms.TextBox()
        Me.cosemail = New System.Windows.Forms.TextBox()
        Me.costelno = New System.Windows.Forms.TextBox()
        Me.cosfaxno = New System.Windows.Forms.TextBox()
        Me.coscontact = New System.Windows.Forms.TextBox()
        Me.cosname = New System.Windows.Forms.TextBox()
        Me.coadd1 = New System.Windows.Forms.TextBox()
        Me.coadd2 = New System.Windows.Forms.TextBox()
        Me.coadd3 = New System.Windows.Forms.TextBox()
        Me.coadd4 = New System.Windows.Forms.TextBox()
        Me.coadd5 = New System.Windows.Forms.TextBox()
        Me.cOHeader = New System.Windows.Forms.TextBox()
        Me.OrderlineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LODATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OrddetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LQTYORDTextBox = New System.Windows.Forms.TextBox()
        Me.LPRICETextBox = New System.Windows.Forms.TextBox()
        Me.LEPRICETextBox = New System.Windows.Forms.TextBox()
        Me.LPARTNOTextBox = New System.Windows.Forms.TextBox()
        Me.LDESCTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ORDERNOTextBox = New System.Windows.Forms.TextBox()
        Me.LOLINEMEMOTextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuffixTB = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LORDERNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LLINENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LQTYORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPARTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LQTYPARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LQTYRECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIICODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LLOCATEBINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOLINEMEMODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNONSTOCKDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LODATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LRDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBACK2BACKDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LocatebinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourcecdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssuredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantybinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrcycdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IicodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IiupdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatalogdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RectypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnwhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinuseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranbinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TransvacDataV2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrandescBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        OSUPPLIERLabel = New System.Windows.Forms.Label()
        OCURRLabel = New System.Windows.Forms.Label()
        OSEMAILLabel = New System.Windows.Forms.Label()
        OSTELNOLabel = New System.Windows.Forms.Label()
        OSFAXNOLabel = New System.Windows.Forms.Label()
        OSCONTACTLabel = New System.Windows.Forms.Label()
        OSNAMELabel = New System.Windows.Forms.Label()
        OHEADERLabel = New System.Windows.Forms.Label()
        LODATELabel = New System.Windows.Forms.Label()
        LQTYORDLabel = New System.Windows.Forms.Label()
        LPRICELabel = New System.Windows.Forms.Label()
        LEPRICELabel = New System.Windows.Forms.Label()
        LPARTNOLabel = New System.Windows.Forms.Label()
        LDESCLabel = New System.Windows.Forms.Label()
        LOLINEMEMOLabel2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.OrderheadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderheadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderheadBindingNavigator.SuspendLayout()
        CType(Me.OrderlineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrddetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrandescBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OSUPPLIERLabel
        '
        OSUPPLIERLabel.AutoSize = True
        OSUPPLIERLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OSUPPLIERLabel.Location = New System.Drawing.Point(31, 66)
        OSUPPLIERLabel.Name = "OSUPPLIERLabel"
        OSUPPLIERLabel.Size = New System.Drawing.Size(68, 13)
        OSUPPLIERLabel.TabIndex = 1
        OSUPPLIERLabel.Text = "SUPPLIER"
        '
        'OCURRLabel
        '
        OCURRLabel.AutoSize = True
        OCURRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OCURRLabel.Location = New System.Drawing.Point(311, 67)
        OCURRLabel.Name = "OCURRLabel"
        OCURRLabel.Size = New System.Drawing.Size(75, 13)
        OCURRLabel.TabIndex = 3
        OCURRLabel.Text = "CURRENCY"
        '
        'OSEMAILLabel
        '
        OSEMAILLabel.AutoSize = True
        OSEMAILLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OSEMAILLabel.Location = New System.Drawing.Point(31, 105)
        OSEMAILLabel.Name = "OSEMAILLabel"
        OSEMAILLabel.Size = New System.Drawing.Size(48, 13)
        OSEMAILLabel.TabIndex = 5
        OSEMAILLabel.Text = "E-MAIL"
        '
        'OSTELNOLabel
        '
        OSTELNOLabel.AutoSize = True
        OSTELNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OSTELNOLabel.Location = New System.Drawing.Point(31, 133)
        OSTELNOLabel.Name = "OSTELNOLabel"
        OSTELNOLabel.Size = New System.Drawing.Size(81, 13)
        OSTELNOLabel.TabIndex = 7
        OSTELNOLabel.Text = "TELEPHONE"
        '
        'OSFAXNOLabel
        '
        OSFAXNOLabel.AutoSize = True
        OSFAXNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OSFAXNOLabel.Location = New System.Drawing.Point(31, 160)
        OSFAXNOLabel.Name = "OSFAXNOLabel"
        OSFAXNOLabel.Size = New System.Drawing.Size(52, 13)
        OSFAXNOLabel.TabIndex = 9
        OSFAXNOLabel.Text = "FAX NO"
        '
        'OSCONTACTLabel
        '
        OSCONTACTLabel.AutoSize = True
        OSCONTACTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OSCONTACTLabel.Location = New System.Drawing.Point(31, 189)
        OSCONTACTLabel.Name = "OSCONTACTLabel"
        OSCONTACTLabel.Size = New System.Drawing.Size(65, 13)
        OSCONTACTLabel.TabIndex = 11
        OSCONTACTLabel.Text = "CONTACT"
        '
        'OSNAMELabel
        '
        OSNAMELabel.AutoSize = True
        OSNAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OSNAMELabel.Location = New System.Drawing.Point(694, 72)
        OSNAMELabel.Name = "OSNAMELabel"
        OSNAMELabel.Size = New System.Drawing.Size(66, 13)
        OSNAMELabel.TabIndex = 13
        OSNAMELabel.Text = "ADDRESS"
        '
        'OHEADERLabel
        '
        OHEADERLabel.AutoSize = True
        OHEADERLabel.Location = New System.Drawing.Point(31, 247)
        OHEADERLabel.Name = "OHEADERLabel"
        OHEADERLabel.Size = New System.Drawing.Size(52, 13)
        OHEADERLabel.TabIndex = 24
        OHEADERLabel.Text = "HEADER"
        '
        'LODATELabel
        '
        LODATELabel.AutoSize = True
        LODATELabel.Location = New System.Drawing.Point(562, 246)
        LODATELabel.Name = "LODATELabel"
        LODATELabel.Size = New System.Drawing.Size(65, 13)
        LODATELabel.TabIndex = 26
        LODATELabel.Text = "ORDER NO"
        '
        'LQTYORDLabel
        '
        LQTYORDLabel.AutoSize = True
        LQTYORDLabel.Location = New System.Drawing.Point(31, 288)
        LQTYORDLabel.Name = "LQTYORDLabel"
        LQTYORDLabel.Size = New System.Drawing.Size(62, 13)
        LQTYORDLabel.TabIndex = 34
        LQTYORDLabel.Text = "LQTYORD:"
        '
        'LPRICELabel
        '
        LPRICELabel.AutoSize = True
        LPRICELabel.Location = New System.Drawing.Point(767, 288)
        LPRICELabel.Name = "LPRICELabel"
        LPRICELabel.Size = New System.Drawing.Size(77, 13)
        LPRICELabel.TabIndex = 37
        LPRICELabel.Text = "UNIT PRICE £"
        '
        'LEPRICELabel
        '
        LEPRICELabel.AutoSize = True
        LEPRICELabel.Location = New System.Drawing.Point(935, 286)
        LEPRICELabel.Name = "LEPRICELabel"
        LEPRICELabel.Size = New System.Drawing.Size(110, 13)
        LEPRICELabel.TabIndex = 39
        LEPRICELabel.Text = "EXTENDED PRICE £"
        '
        'LPARTNOLabel
        '
        LPARTNOLabel.AutoSize = True
        LPARTNOLabel.Location = New System.Drawing.Point(159, 286)
        LPARTNOLabel.Name = "LPARTNOLabel"
        LPARTNOLabel.Size = New System.Drawing.Size(61, 13)
        LPARTNOLabel.TabIndex = 40
        LPARTNOLabel.Text = "LPARTNO:"
        '
        'LDESCLabel
        '
        LDESCLabel.AutoSize = True
        LDESCLabel.Location = New System.Drawing.Point(337, 286)
        LDESCLabel.Name = "LDESCLabel"
        LDESCLabel.Size = New System.Drawing.Size(45, 13)
        LDESCLabel.TabIndex = 41
        LDESCLabel.Text = "LDESC:"
        '
        'LOLINEMEMOLabel2
        '
        LOLINEMEMOLabel2.AutoSize = True
        LOLINEMEMOLabel2.Location = New System.Drawing.Point(30, 366)
        LOLINEMEMOLabel2.Name = "LOLINEMEMOLabel2"
        LOLINEMEMOLabel2.Size = New System.Drawing.Size(81, 13)
        LOLINEMEMOLabel2.TabIndex = 54
        LOLINEMEMOLabel2.Text = "LOLINEMEMO:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(1034, 244)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(116, 13)
        Label1.TabIndex = 57
        Label1.Text = "REQUIRED BY DATE:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(1067, 709)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(93, 13)
        Label2.TabIndex = 91
        Label2.Text = "ORDER VALUE ="
        '
        'FOXPROSQLDataSet
        '
        '
        Me.OrderheadBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OrderheadBindingNavigator.BindingSource = Me.OrderheadBindingSource
        Me.OrderheadBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OrderheadBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OrderheadBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OrderheadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OrderheadBindingNavigatorSaveItem})
        Me.OrderheadBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OrderheadBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OrderheadBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OrderheadBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OrderheadBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OrderheadBindingNavigator.Name = "OrderheadBindingNavigator"
        Me.OrderheadBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OrderheadBindingNavigator.Size = New System.Drawing.Size(1300, 27)
        Me.OrderheadBindingNavigator.TabIndex = 0
        Me.OrderheadBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'OrderheadBindingNavigatorSaveItem
        '
        Me.OrderheadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OrderheadBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrderheadBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrderheadBindingNavigatorSaveItem.Name = "OrderheadBindingNavigatorSaveItem"
        Me.OrderheadBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.OrderheadBindingNavigatorSaveItem.Text = "Save Data"
        '
        'cosupplier
        '
        Me.cosupplier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OSUPPLIER", True))
        Me.cosupplier.Location = New System.Drawing.Point(119, 63)
        Me.cosupplier.Name = "cosupplier"
        Me.cosupplier.Size = New System.Drawing.Size(187, 20)
        Me.cosupplier.TabIndex = 2
        '
        'cocurr
        '
        Me.cocurr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OCURR", True))
        Me.cocurr.Location = New System.Drawing.Point(386, 65)
        Me.cocurr.Name = "cocurr"
        Me.cocurr.Size = New System.Drawing.Size(43, 20)
        Me.cocurr.TabIndex = 4
        '
        'cosemail
        '
        Me.cosemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OSEMAIL", True))
        Me.cosemail.Location = New System.Drawing.Point(118, 102)
        Me.cosemail.Name = "cosemail"
        Me.cosemail.Size = New System.Drawing.Size(311, 20)
        Me.cosemail.TabIndex = 6
        '
        'costelno
        '
        Me.costelno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OSTELNO", True))
        Me.costelno.Location = New System.Drawing.Point(118, 128)
        Me.costelno.Name = "costelno"
        Me.costelno.Size = New System.Drawing.Size(311, 20)
        Me.costelno.TabIndex = 8
        '
        'cosfaxno
        '
        Me.cosfaxno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OSFAXNO", True))
        Me.cosfaxno.Location = New System.Drawing.Point(118, 155)
        Me.cosfaxno.Name = "cosfaxno"
        Me.cosfaxno.Size = New System.Drawing.Size(311, 20)
        Me.cosfaxno.TabIndex = 10
        '
        'coscontact
        '
        Me.coscontact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OSCONTACT", True))
        Me.coscontact.Location = New System.Drawing.Point(118, 182)
        Me.coscontact.Name = "coscontact"
        Me.coscontact.Size = New System.Drawing.Size(209, 20)
        Me.coscontact.TabIndex = 12
        '
        'cosname
        '
        Me.cosname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OSNAME", True))
        Me.cosname.Location = New System.Drawing.Point(768, 68)
        Me.cosname.Name = "cosname"
        Me.cosname.Size = New System.Drawing.Size(367, 20)
        Me.cosname.TabIndex = 14
        '
        'coadd1
        '
        Me.coadd1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OADD1", True))
        Me.coadd1.Location = New System.Drawing.Point(768, 95)
        Me.coadd1.Name = "coadd1"
        Me.coadd1.Size = New System.Drawing.Size(367, 20)
        Me.coadd1.TabIndex = 16
        '
        'coadd2
        '
        Me.coadd2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OADD2", True))
        Me.coadd2.Location = New System.Drawing.Point(768, 121)
        Me.coadd2.Name = "coadd2"
        Me.coadd2.Size = New System.Drawing.Size(367, 20)
        Me.coadd2.TabIndex = 18
        '
        'coadd3
        '
        Me.coadd3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OADD3", True))
        Me.coadd3.Location = New System.Drawing.Point(768, 148)
        Me.coadd3.Name = "coadd3"
        Me.coadd3.Size = New System.Drawing.Size(367, 20)
        Me.coadd3.TabIndex = 20
        '
        'coadd4
        '
        Me.coadd4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OADD4", True))
        Me.coadd4.Location = New System.Drawing.Point(768, 174)
        Me.coadd4.Name = "coadd4"
        Me.coadd4.Size = New System.Drawing.Size(367, 20)
        Me.coadd4.TabIndex = 22
        '
        'coadd5
        '
        Me.coadd5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OADD5", True))
        Me.coadd5.Location = New System.Drawing.Point(768, 200)
        Me.coadd5.Name = "coadd5"
        Me.coadd5.Size = New System.Drawing.Size(367, 20)
        Me.coadd5.TabIndex = 24
        '
        'cOHeader
        '
        Me.cOHeader.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "OHEADER", True))
        Me.cOHeader.Location = New System.Drawing.Point(118, 244)
        Me.cOHeader.Name = "cOHeader"
        Me.cOHeader.Size = New System.Drawing.Size(429, 20)
        Me.cOHeader.TabIndex = 25
        '
        'LODATEDateTimePicker
        '
        Me.LODATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrderlineBindingSource, "LODATE", True))
        Me.LODATEDateTimePicker.Location = New System.Drawing.Point(728, 244)
        Me.LODATEDateTimePicker.Name = "LODATEDateTimePicker"
        Me.LODATEDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.LODATEDateTimePicker.TabIndex = 27
        '
        'LQTYORDTextBox
        '
        Me.LQTYORDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderlineBindingSource, "LQTYORD", True))
        Me.LQTYORDTextBox.Location = New System.Drawing.Point(118, 283)
        Me.LQTYORDTextBox.Name = "LQTYORDTextBox"
        Me.LQTYORDTextBox.Size = New System.Drawing.Size(35, 20)
        Me.LQTYORDTextBox.TabIndex = 35
        '
        'LPRICETextBox
        '
        Me.LPRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderlineBindingSource, "LPRICE", True))
        Me.LPRICETextBox.Location = New System.Drawing.Point(850, 283)
        Me.LPRICETextBox.Name = "LPRICETextBox"
        Me.LPRICETextBox.Size = New System.Drawing.Size(79, 20)
        Me.LPRICETextBox.TabIndex = 38
        '
        'LEPRICETextBox
        '
        Me.LEPRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderlineBindingSource, "LEPRICE", True))
        Me.LEPRICETextBox.Location = New System.Drawing.Point(1051, 282)
        Me.LEPRICETextBox.Name = "LEPRICETextBox"
        Me.LEPRICETextBox.Size = New System.Drawing.Size(79, 20)
        Me.LEPRICETextBox.TabIndex = 40
        '
        'LPARTNOTextBox
        '
        Me.LPARTNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderlineBindingSource, "LPARTNO", True))
        Me.LPARTNOTextBox.Location = New System.Drawing.Point(226, 283)
        Me.LPARTNOTextBox.Name = "LPARTNOTextBox"
        Me.LPARTNOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LPARTNOTextBox.TabIndex = 41
        '
        'LDESCTextBox
        '
        Me.LDESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderlineBindingSource, "LDESC", True))
        Me.LDESCTextBox.Location = New System.Drawing.Point(386, 283)
        Me.LDESCTextBox.Name = "LDESCTextBox"
        Me.LDESCTextBox.Size = New System.Drawing.Size(374, 20)
        Me.LDESCTextBox.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.OrderlineBindingSource, "LNONSTOCK", True))
        Me.Button1.Location = New System.Drawing.Point(875, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 51)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "NON STOCK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ORDERNOTextBox
        '
        Me.ORDERNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderheadBindingSource, "ORDERNO", True))
        Me.ORDERNOTextBox.Location = New System.Drawing.Point(630, 244)
        Me.ORDERNOTextBox.Name = "ORDERNOTextBox"
        Me.ORDERNOTextBox.Size = New System.Drawing.Size(89, 20)
        Me.ORDERNOTextBox.TabIndex = 45
        '
        'LOLINEMEMOTextBox2
        '
        Me.LOLINEMEMOTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderlineBindingSource, "LOLINEMEMO", True))
        Me.LOLINEMEMOTextBox2.Location = New System.Drawing.Point(117, 325)
        Me.LOLINEMEMOTextBox2.Multiline = True
        Me.LOLINEMEMOTextBox2.Name = "LOLINEMEMOTextBox2"
        Me.LOLINEMEMOTextBox2.Size = New System.Drawing.Size(642, 78)
        Me.LOLINEMEMOTextBox2.TabIndex = 55
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderlineBindingSource, "LQTYORD", True))
        Me.TextBox1.Location = New System.Drawing.Point(1152, 244)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(79, 20)
        Me.TextBox1.TabIndex = 58
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(37, 664)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "ABORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(152, 664)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 23)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "DELETE LINE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(288, 663)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 23)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "ORDER DETAIL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(748, 663)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 23)
        Me.Button5.TabIndex = 62
        Me.Button5.Text = "VIEW ORDER"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(951, 663)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "SAVE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1156, 537)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 64
        Me.Button7.Text = "HEADING"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1156, 596)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 65
        Me.Button8.Text = "DESPATCH"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1156, 567)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 66
        Me.Button9.Text = "INSTRUCT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(1156, 625)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 67
        Me.Button10.Text = "DELIVERY"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'SuffixTB
        '
        Me.SuffixTB.Location = New System.Drawing.Point(850, 244)
        Me.SuffixTB.Name = "SuffixTB"
        Me.SuffixTB.Size = New System.Drawing.Size(42, 20)
        Me.SuffixTB.TabIndex = 70
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(768, 328)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 31)
        Me.Button11.TabIndex = 73
        Me.Button11.Text = "ADD"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(767, 373)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 30)
        Me.Button12.TabIndex = 74
        Me.Button12.Text = "EDIT"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LORDERNODataGridViewTextBoxColumn, Me.LLINENODataGridViewTextBoxColumn, Me.LQTYORDDataGridViewTextBoxColumn, Me.LPARTNODataGridViewTextBoxColumn, Me.LDESCDataGridViewTextBoxColumn, Me.LPRICEDataGridViewTextBoxColumn, Me.LEPRICEDataGridViewTextBoxColumn, Me.LQTYPARTDataGridViewTextBoxColumn, Me.LQTYRECDataGridViewTextBoxColumn, Me.LIICODEDataGridViewTextBoxColumn, Me.LLOCATEBINDataGridViewTextBoxColumn, Me.LOLINEMEMODataGridViewTextBoxColumn, Me.LNONSTOCKDataGridViewCheckBoxColumn, Me.LODATEDataGridViewTextBoxColumn, Me.LRDATEDataGridViewTextBoxColumn, Me.LBACK2BACKDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderlineBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(34, 537)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(992, 111)
        Me.DataGridView1.TabIndex = 88
        '
        'LORDERNODataGridViewTextBoxColumn
        '
        Me.LORDERNODataGridViewTextBoxColumn.DataPropertyName = "LORDERNO"
        Me.LORDERNODataGridViewTextBoxColumn.HeaderText = "LORDERNO"
        Me.LORDERNODataGridViewTextBoxColumn.Name = "LORDERNODataGridViewTextBoxColumn"
        Me.LORDERNODataGridViewTextBoxColumn.ReadOnly = True
        Me.LORDERNODataGridViewTextBoxColumn.Visible = False
        '
        'LLINENODataGridViewTextBoxColumn
        '
        Me.LLINENODataGridViewTextBoxColumn.DataPropertyName = "LLINENO"
        Me.LLINENODataGridViewTextBoxColumn.HeaderText = "LLINENO"
        Me.LLINENODataGridViewTextBoxColumn.Name = "LLINENODataGridViewTextBoxColumn"
        Me.LLINENODataGridViewTextBoxColumn.ReadOnly = True
        '
        'LQTYORDDataGridViewTextBoxColumn
        '
        Me.LQTYORDDataGridViewTextBoxColumn.DataPropertyName = "LQTYORD"
        Me.LQTYORDDataGridViewTextBoxColumn.HeaderText = "LQTYORD"
        Me.LQTYORDDataGridViewTextBoxColumn.Name = "LQTYORDDataGridViewTextBoxColumn"
        Me.LQTYORDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LPARTNODataGridViewTextBoxColumn
        '
        Me.LPARTNODataGridViewTextBoxColumn.DataPropertyName = "LPARTNO"
        Me.LPARTNODataGridViewTextBoxColumn.HeaderText = "LPARTNO"
        Me.LPARTNODataGridViewTextBoxColumn.Name = "LPARTNODataGridViewTextBoxColumn"
        Me.LPARTNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'LDESCDataGridViewTextBoxColumn
        '
        Me.LDESCDataGridViewTextBoxColumn.DataPropertyName = "LDESC"
        Me.LDESCDataGridViewTextBoxColumn.HeaderText = "LDESC"
        Me.LDESCDataGridViewTextBoxColumn.Name = "LDESCDataGridViewTextBoxColumn"
        Me.LDESCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LPRICEDataGridViewTextBoxColumn
        '
        Me.LPRICEDataGridViewTextBoxColumn.DataPropertyName = "LPRICE"
        Me.LPRICEDataGridViewTextBoxColumn.HeaderText = "LPRICE"
        Me.LPRICEDataGridViewTextBoxColumn.Name = "LPRICEDataGridViewTextBoxColumn"
        Me.LPRICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LEPRICEDataGridViewTextBoxColumn
        '
        Me.LEPRICEDataGridViewTextBoxColumn.DataPropertyName = "LEPRICE"
        Me.LEPRICEDataGridViewTextBoxColumn.HeaderText = "LEPRICE"
        Me.LEPRICEDataGridViewTextBoxColumn.Name = "LEPRICEDataGridViewTextBoxColumn"
        Me.LEPRICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LQTYPARTDataGridViewTextBoxColumn
        '
        Me.LQTYPARTDataGridViewTextBoxColumn.DataPropertyName = "LQTYPART"
        Me.LQTYPARTDataGridViewTextBoxColumn.HeaderText = "LQTYPART"
        Me.LQTYPARTDataGridViewTextBoxColumn.Name = "LQTYPARTDataGridViewTextBoxColumn"
        Me.LQTYPARTDataGridViewTextBoxColumn.ReadOnly = True
        Me.LQTYPARTDataGridViewTextBoxColumn.Visible = False
        '
        'LQTYRECDataGridViewTextBoxColumn
        '
        Me.LQTYRECDataGridViewTextBoxColumn.DataPropertyName = "LQTYREC"
        Me.LQTYRECDataGridViewTextBoxColumn.HeaderText = "LQTYREC"
        Me.LQTYRECDataGridViewTextBoxColumn.Name = "LQTYRECDataGridViewTextBoxColumn"
        Me.LQTYRECDataGridViewTextBoxColumn.ReadOnly = True
        Me.LQTYRECDataGridViewTextBoxColumn.Visible = False
        '
        'LIICODEDataGridViewTextBoxColumn
        '
        Me.LIICODEDataGridViewTextBoxColumn.DataPropertyName = "LIICODE"
        Me.LIICODEDataGridViewTextBoxColumn.HeaderText = "LIICODE"
        Me.LIICODEDataGridViewTextBoxColumn.Name = "LIICODEDataGridViewTextBoxColumn"
        Me.LIICODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.LIICODEDataGridViewTextBoxColumn.Visible = False
        '
        'LLOCATEBINDataGridViewTextBoxColumn
        '
        Me.LLOCATEBINDataGridViewTextBoxColumn.DataPropertyName = "LLOCATEBIN"
        Me.LLOCATEBINDataGridViewTextBoxColumn.HeaderText = "LLOCATEBIN"
        Me.LLOCATEBINDataGridViewTextBoxColumn.Name = "LLOCATEBINDataGridViewTextBoxColumn"
        Me.LLOCATEBINDataGridViewTextBoxColumn.ReadOnly = True
        Me.LLOCATEBINDataGridViewTextBoxColumn.Visible = False
        '
        'LOLINEMEMODataGridViewTextBoxColumn
        '
        Me.LOLINEMEMODataGridViewTextBoxColumn.DataPropertyName = "LOLINEMEMO"
        Me.LOLINEMEMODataGridViewTextBoxColumn.HeaderText = "LOLINEMEMO"
        Me.LOLINEMEMODataGridViewTextBoxColumn.Name = "LOLINEMEMODataGridViewTextBoxColumn"
        Me.LOLINEMEMODataGridViewTextBoxColumn.ReadOnly = True
        Me.LOLINEMEMODataGridViewTextBoxColumn.Visible = False
        '
        'LNONSTOCKDataGridViewCheckBoxColumn
        '
        Me.LNONSTOCKDataGridViewCheckBoxColumn.DataPropertyName = "LNONSTOCK"
        Me.LNONSTOCKDataGridViewCheckBoxColumn.HeaderText = "LNONSTOCK"
        Me.LNONSTOCKDataGridViewCheckBoxColumn.Name = "LNONSTOCKDataGridViewCheckBoxColumn"
        Me.LNONSTOCKDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'LODATEDataGridViewTextBoxColumn
        '
        Me.LODATEDataGridViewTextBoxColumn.DataPropertyName = "LODATE"
        Me.LODATEDataGridViewTextBoxColumn.HeaderText = "LODATE"
        Me.LODATEDataGridViewTextBoxColumn.Name = "LODATEDataGridViewTextBoxColumn"
        Me.LODATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.LODATEDataGridViewTextBoxColumn.Visible = False
        '
        'LRDATEDataGridViewTextBoxColumn
        '
        Me.LRDATEDataGridViewTextBoxColumn.DataPropertyName = "LRDATE"
        Me.LRDATEDataGridViewTextBoxColumn.HeaderText = "LRDATE"
        Me.LRDATEDataGridViewTextBoxColumn.Name = "LRDATEDataGridViewTextBoxColumn"
        Me.LRDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.LRDATEDataGridViewTextBoxColumn.Visible = False
        '
        'LBACK2BACKDataGridViewCheckBoxColumn
        '
        Me.LBACK2BACKDataGridViewCheckBoxColumn.DataPropertyName = "LBACK2BACK"
        Me.LBACK2BACKDataGridViewCheckBoxColumn.HeaderText = "LBACK2BACK"
        Me.LBACK2BACKDataGridViewCheckBoxColumn.Name = "LBACK2BACKDataGridViewCheckBoxColumn"
        Me.LBACK2BACKDataGridViewCheckBoxColumn.ReadOnly = True
        Me.LBACK2BACKDataGridViewCheckBoxColumn.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocatebinDataGridViewTextBoxColumn, Me.SourcecdeDataGridViewTextBoxColumn, Me.AssuredDataGridViewTextBoxColumn, Me.QuantybinDataGridViewTextBoxColumn, Me.CurrcycdeDataGridViewTextBoxColumn, Me.UnitvalueDataGridViewTextBoxColumn, Me.IicodeDataGridViewTextBoxColumn, Me.IiupdateDataGridViewTextBoxColumn, Me.CatalogdtDataGridViewTextBoxColumn, Me.AllocDataGridViewTextBoxColumn, Me.RectypeDataGridViewTextBoxColumn, Me.SnwhoDataGridViewTextBoxColumn, Me.WqtyDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.SinuseDataGridViewTextBoxColumn, Me.UniqueIDDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TranbinsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(34, 429)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1197, 102)
        Me.DataGridView2.TabIndex = 89
        '
        'LocatebinDataGridViewTextBoxColumn
        '
        Me.LocatebinDataGridViewTextBoxColumn.DataPropertyName = "locatebin"
        Me.LocatebinDataGridViewTextBoxColumn.HeaderText = "locatebin"
        Me.LocatebinDataGridViewTextBoxColumn.Name = "LocatebinDataGridViewTextBoxColumn"
        '
        'SourcecdeDataGridViewTextBoxColumn
        '
        Me.SourcecdeDataGridViewTextBoxColumn.DataPropertyName = "sourcecde"
        Me.SourcecdeDataGridViewTextBoxColumn.HeaderText = "sourcecde"
        Me.SourcecdeDataGridViewTextBoxColumn.Name = "SourcecdeDataGridViewTextBoxColumn"
        '
        'AssuredDataGridViewTextBoxColumn
        '
        Me.AssuredDataGridViewTextBoxColumn.DataPropertyName = "assured"
        Me.AssuredDataGridViewTextBoxColumn.HeaderText = "assured"
        Me.AssuredDataGridViewTextBoxColumn.Name = "AssuredDataGridViewTextBoxColumn"
        '
        'QuantybinDataGridViewTextBoxColumn
        '
        Me.QuantybinDataGridViewTextBoxColumn.DataPropertyName = "quantybin"
        Me.QuantybinDataGridViewTextBoxColumn.HeaderText = "quantybin"
        Me.QuantybinDataGridViewTextBoxColumn.Name = "QuantybinDataGridViewTextBoxColumn"
        Me.QuantybinDataGridViewTextBoxColumn.Visible = False
        '
        'CurrcycdeDataGridViewTextBoxColumn
        '
        Me.CurrcycdeDataGridViewTextBoxColumn.DataPropertyName = "currcy_cde"
        Me.CurrcycdeDataGridViewTextBoxColumn.HeaderText = "currcy_cde"
        Me.CurrcycdeDataGridViewTextBoxColumn.Name = "CurrcycdeDataGridViewTextBoxColumn"
        '
        'UnitvalueDataGridViewTextBoxColumn
        '
        Me.UnitvalueDataGridViewTextBoxColumn.DataPropertyName = "unit_value"
        Me.UnitvalueDataGridViewTextBoxColumn.HeaderText = "unit_value"
        Me.UnitvalueDataGridViewTextBoxColumn.Name = "UnitvalueDataGridViewTextBoxColumn"
        '
        'IicodeDataGridViewTextBoxColumn
        '
        Me.IicodeDataGridViewTextBoxColumn.DataPropertyName = "iicode"
        Me.IicodeDataGridViewTextBoxColumn.HeaderText = "iicode"
        Me.IicodeDataGridViewTextBoxColumn.Name = "IicodeDataGridViewTextBoxColumn"
        '
        'IiupdateDataGridViewTextBoxColumn
        '
        Me.IiupdateDataGridViewTextBoxColumn.DataPropertyName = "iiupdate"
        Me.IiupdateDataGridViewTextBoxColumn.HeaderText = "iiupdate"
        Me.IiupdateDataGridViewTextBoxColumn.Name = "IiupdateDataGridViewTextBoxColumn"
        '
        'CatalogdtDataGridViewTextBoxColumn
        '
        Me.CatalogdtDataGridViewTextBoxColumn.DataPropertyName = "catalog_dt"
        Me.CatalogdtDataGridViewTextBoxColumn.HeaderText = "catalog_dt"
        Me.CatalogdtDataGridViewTextBoxColumn.Name = "CatalogdtDataGridViewTextBoxColumn"
        '
        'AllocDataGridViewTextBoxColumn
        '
        Me.AllocDataGridViewTextBoxColumn.DataPropertyName = "alloc"
        Me.AllocDataGridViewTextBoxColumn.HeaderText = "alloc"
        Me.AllocDataGridViewTextBoxColumn.Name = "AllocDataGridViewTextBoxColumn"
        '
        'RectypeDataGridViewTextBoxColumn
        '
        Me.RectypeDataGridViewTextBoxColumn.DataPropertyName = "rec_type"
        Me.RectypeDataGridViewTextBoxColumn.HeaderText = "rec_type"
        Me.RectypeDataGridViewTextBoxColumn.Name = "RectypeDataGridViewTextBoxColumn"
        Me.RectypeDataGridViewTextBoxColumn.Visible = False
        '
        'SnwhoDataGridViewTextBoxColumn
        '
        Me.SnwhoDataGridViewTextBoxColumn.DataPropertyName = "snwho"
        Me.SnwhoDataGridViewTextBoxColumn.HeaderText = "snwho"
        Me.SnwhoDataGridViewTextBoxColumn.Name = "SnwhoDataGridViewTextBoxColumn"
        Me.SnwhoDataGridViewTextBoxColumn.Visible = False
        '
        'WqtyDataGridViewTextBoxColumn
        '
        Me.WqtyDataGridViewTextBoxColumn.DataPropertyName = "wqty"
        Me.WqtyDataGridViewTextBoxColumn.HeaderText = "wqty"
        Me.WqtyDataGridViewTextBoxColumn.Name = "WqtyDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'SinuseDataGridViewTextBoxColumn
        '
        Me.SinuseDataGridViewTextBoxColumn.DataPropertyName = "sinuse"
        Me.SinuseDataGridViewTextBoxColumn.HeaderText = "sinuse"
        Me.SinuseDataGridViewTextBoxColumn.Name = "SinuseDataGridViewTextBoxColumn"
        Me.SinuseDataGridViewTextBoxColumn.Visible = False
        '
        'UniqueIDDataGridViewTextBoxColumn
        '
        Me.UniqueIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn.HeaderText = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn.Name = "UniqueIDDataGridViewTextBoxColumn"
        Me.UniqueIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UniqueIDDataGridViewTextBoxColumn.Visible = False
        '
        'TranbinsBindingSource
        '
        Me.TranbinsBindingSource.DataMember = "tranbins"
        Me.TranbinsBindingSource.DataSource = Me.TransvacDataV2DataSet
        '
        'TransvacDataV2DataSet
        '
        Me.TransvacDataV2DataSet.DataSetName = "TransvacDataV2DataSet"
        Me.TransvacDataV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1166, 703)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(65, 20)
        Me.TextBox2.TabIndex = 90
        '
        'Button13
        '
        Me.Button13.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.OrderlineBindingSource, "LNONSTOCK", True))
        Me.Button13.Location = New System.Drawing.Point(1136, 270)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(95, 53)
        Me.Button13.TabIndex = 92
        Me.Button13.Text = "FIND DESC"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.TrandescBindingSource
        Me.ListBox1.DisplayMember = "descmemo"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(990, 337)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(241, 69)
        Me.ListBox1.TabIndex = 93
        '
        'TransvacDataV2DataSetBindingSource
        '
        Me.TransvacDataV2DataSetBindingSource.DataSource = Me.TransvacDataV2DataSet
        Me.TransvacDataV2DataSetBindingSource.Position = 0
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
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
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(996, 323)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 13)
        Label3.TabIndex = 94
        Label3.Text = "DESC MEMO:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1300, 740)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.SuffixTB)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(LOLINEMEMOLabel2)
        Me.Controls.Add(Me.LOLINEMEMOTextBox2)
        Me.Controls.Add(Me.ORDERNOTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(LDESCLabel)
        Me.Controls.Add(Me.LDESCTextBox)
        Me.Controls.Add(LPARTNOLabel)
        Me.Controls.Add(Me.LPARTNOTextBox)
        Me.Controls.Add(LEPRICELabel)
        Me.Controls.Add(Me.LEPRICETextBox)
        Me.Controls.Add(LPRICELabel)
        Me.Controls.Add(Me.LPRICETextBox)
        Me.Controls.Add(LQTYORDLabel)
        Me.Controls.Add(Me.LQTYORDTextBox)
        Me.Controls.Add(LODATELabel)
        Me.Controls.Add(Me.LODATEDateTimePicker)
        Me.Controls.Add(OHEADERLabel)
        Me.Controls.Add(Me.cOHeader)
        Me.Controls.Add(Me.coadd5)
        Me.Controls.Add(Me.coadd4)
        Me.Controls.Add(Me.coadd3)
        Me.Controls.Add(Me.coadd2)
        Me.Controls.Add(Me.coadd1)
        Me.Controls.Add(OSNAMELabel)
        Me.Controls.Add(Me.cosname)
        Me.Controls.Add(OSCONTACTLabel)
        Me.Controls.Add(Me.coscontact)
        Me.Controls.Add(OSFAXNOLabel)
        Me.Controls.Add(Me.cosfaxno)
        Me.Controls.Add(OSTELNOLabel)
        Me.Controls.Add(Me.costelno)
        Me.Controls.Add(OSEMAILLabel)
        Me.Controls.Add(Me.cosemail)
        Me.Controls.Add(OCURRLabel)
        Me.Controls.Add(Me.cocurr)
        Me.Controls.Add(OSUPPLIERLabel)
        Me.Controls.Add(Me.cosupplier)
        Me.Controls.Add(Me.OrderheadBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Order Form"
        CType(Me.OrderheadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderheadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderheadBindingNavigator.ResumeLayout(False)
        Me.OrderheadBindingNavigator.PerformLayout()
        CType(Me.OrderlineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrddetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrandescBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderheadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderheadBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OrderheadBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents cosupplier As System.Windows.Forms.TextBox
    Friend WithEvents cocurr As System.Windows.Forms.TextBox
    Friend WithEvents cosemail As System.Windows.Forms.TextBox
    Friend WithEvents costelno As System.Windows.Forms.TextBox
    Friend WithEvents cosfaxno As System.Windows.Forms.TextBox
    Friend WithEvents coscontact As System.Windows.Forms.TextBox
    Friend WithEvents cosname As System.Windows.Forms.TextBox
    Friend WithEvents coadd1 As System.Windows.Forms.TextBox
    Friend WithEvents coadd2 As System.Windows.Forms.TextBox
    Friend WithEvents coadd3 As System.Windows.Forms.TextBox
    Friend WithEvents coadd4 As System.Windows.Forms.TextBox
    Friend WithEvents coadd5 As System.Windows.Forms.TextBox
    Friend WithEvents cOHeader As System.Windows.Forms.TextBox
    Friend WithEvents OrderlineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LODATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OrddetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LQTYORDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LPRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LEPRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LPARTNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LDESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ORDERNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LOLINEMEMOTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents SuffixTB As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TransvacDataV2DataSet As TransvacDataV2DataSet
    Friend WithEvents TranbinsBindingSource As BindingSource
    Friend WithEvents LocatebinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SourcecdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssuredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantybinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrcycdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitvalueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IicodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IiupdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatalogdtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RectypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnwhoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SinuseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniqueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LORDERNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LLINENODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LQTYORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LPARTNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LEPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LQTYPARTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LQTYRECDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LIICODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LLOCATEBINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOLINEMEMODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNONSTOCKDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LODATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LRDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LBACK2BACKDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button13 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TransvacDataV2DataSetBindingSource As BindingSource
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TrandescBindingSource As BindingSource
    Friend WithEvents TrandescTableAdapter As TransvacDataV2DataSet1TableAdapters.trandescTableAdapter
End Class
