﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.OSUPPLIERLabel = New System.Windows.Forms.Label()
        Me.OCURRLabel = New System.Windows.Forms.Label()
        Me.OSEMAILLabel = New System.Windows.Forms.Label()
        Me.OSTELNOLabel = New System.Windows.Forms.Label()
        Me.OSFAXNOLabel = New System.Windows.Forms.Label()
        Me.OSCONTACTLabel = New System.Windows.Forms.Label()
        Me.OSNAMELabel = New System.Windows.Forms.Label()
        Me.OHEADERLabel = New System.Windows.Forms.Label()
        Me.LODATELabel = New System.Windows.Forms.Label()
        Me.LQTYORDLabel = New System.Windows.Forms.Label()
        Me.LPRICELabel = New System.Windows.Forms.Label()
        Me.LEPRICELabel = New System.Windows.Forms.Label()
        Me.LPARTNOLabel = New System.Windows.Forms.Label()
        Me.LDESCLabel = New System.Windows.Forms.Label()
        Me.LOLINEMEMOLabel2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.LODATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LQTYORDTextBox = New System.Windows.Forms.TextBox()
        Me.LPRICETextBox = New System.Windows.Forms.TextBox()
        Me.LEPRICETextBox = New System.Windows.Forms.TextBox()
        Me.LPARTNOTextBox = New System.Windows.Forms.TextBox()
        Me.LDESCTextBox = New System.Windows.Forms.TextBox()
        Me.nonstk_but = New System.Windows.Forms.Button()
        Me.ORDERNOTextBox = New System.Windows.Forms.TextBox()
        Me.LOLINEMEMOTextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ordabort_but = New System.Windows.Forms.Button()
        Me.deline_but = New System.Windows.Forms.Button()
        Me.orddet_but = New System.Windows.Forms.Button()
        Me.vwsave_but = New System.Windows.Forms.Button()
        Me.ordsave_but = New System.Windows.Forms.Button()
        Me.ordhead_but = New System.Windows.Forms.Button()
        Me.orddesp_but = New System.Windows.Forms.Button()
        Me.ordinstr_but = New System.Windows.Forms.Button()
        Me.orddel_but = New System.Windows.Forms.Button()
        Me.ord_but = New System.Windows.Forms.Button()
        Me.edt_but = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IicodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourcecdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssuredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocatebinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantybinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrcycdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatalogdtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IiupdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RectypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnwhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinuseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sup_discpcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Retail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mupercentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranbinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TranbinsTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter()
        Me.QuotedetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotedetailTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.quotedetailTableAdapter()
        Me.OrderlineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderlineTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.orderlineTableAdapter()
        Me.OrderheadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderheadTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.orderheadTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.UniqueIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtendedPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qpart_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quote_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quote_sufDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotedetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderlineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderheadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OSUPPLIERLabel
        '
        Me.OSUPPLIERLabel.AutoSize = True
        Me.OSUPPLIERLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSUPPLIERLabel.Location = New System.Drawing.Point(31, 70)
        Me.OSUPPLIERLabel.Name = "OSUPPLIERLabel"
        Me.OSUPPLIERLabel.Size = New System.Drawing.Size(68, 13)
        Me.OSUPPLIERLabel.TabIndex = 1
        Me.OSUPPLIERLabel.Text = "SUPPLIER"
        '
        'OCURRLabel
        '
        Me.OCURRLabel.AutoSize = True
        Me.OCURRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OCURRLabel.Location = New System.Drawing.Point(364, 70)
        Me.OCURRLabel.Name = "OCURRLabel"
        Me.OCURRLabel.Size = New System.Drawing.Size(75, 13)
        Me.OCURRLabel.TabIndex = 3
        Me.OCURRLabel.Text = "CURRENCY"
        '
        'OSEMAILLabel
        '
        Me.OSEMAILLabel.AutoSize = True
        Me.OSEMAILLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSEMAILLabel.Location = New System.Drawing.Point(31, 109)
        Me.OSEMAILLabel.Name = "OSEMAILLabel"
        Me.OSEMAILLabel.Size = New System.Drawing.Size(48, 13)
        Me.OSEMAILLabel.TabIndex = 5
        Me.OSEMAILLabel.Text = "E-MAIL"
        '
        'OSTELNOLabel
        '
        Me.OSTELNOLabel.AutoSize = True
        Me.OSTELNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSTELNOLabel.Location = New System.Drawing.Point(31, 137)
        Me.OSTELNOLabel.Name = "OSTELNOLabel"
        Me.OSTELNOLabel.Size = New System.Drawing.Size(81, 13)
        Me.OSTELNOLabel.TabIndex = 7
        Me.OSTELNOLabel.Text = "TELEPHONE"
        '
        'OSFAXNOLabel
        '
        Me.OSFAXNOLabel.AutoSize = True
        Me.OSFAXNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSFAXNOLabel.Location = New System.Drawing.Point(31, 164)
        Me.OSFAXNOLabel.Name = "OSFAXNOLabel"
        Me.OSFAXNOLabel.Size = New System.Drawing.Size(52, 13)
        Me.OSFAXNOLabel.TabIndex = 9
        Me.OSFAXNOLabel.Text = "FAX NO"
        '
        'OSCONTACTLabel
        '
        Me.OSCONTACTLabel.AutoSize = True
        Me.OSCONTACTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSCONTACTLabel.Location = New System.Drawing.Point(31, 193)
        Me.OSCONTACTLabel.Name = "OSCONTACTLabel"
        Me.OSCONTACTLabel.Size = New System.Drawing.Size(65, 13)
        Me.OSCONTACTLabel.TabIndex = 11
        Me.OSCONTACTLabel.Text = "CONTACT"
        '
        'OSNAMELabel
        '
        Me.OSNAMELabel.AutoSize = True
        Me.OSNAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSNAMELabel.Location = New System.Drawing.Point(722, 90)
        Me.OSNAMELabel.Name = "OSNAMELabel"
        Me.OSNAMELabel.Size = New System.Drawing.Size(66, 13)
        Me.OSNAMELabel.TabIndex = 13
        Me.OSNAMELabel.Text = "ADDRESS"
        '
        'OHEADERLabel
        '
        Me.OHEADERLabel.AutoSize = True
        Me.OHEADERLabel.Location = New System.Drawing.Point(31, 258)
        Me.OHEADERLabel.Name = "OHEADERLabel"
        Me.OHEADERLabel.Size = New System.Drawing.Size(52, 13)
        Me.OHEADERLabel.TabIndex = 24
        Me.OHEADERLabel.Text = "HEADER"
        '
        'LODATELabel
        '
        Me.LODATELabel.AutoSize = True
        Me.LODATELabel.Location = New System.Drawing.Point(978, 20)
        Me.LODATELabel.Name = "LODATELabel"
        Me.LODATELabel.Size = New System.Drawing.Size(65, 13)
        Me.LODATELabel.TabIndex = 26
        Me.LODATELabel.Text = "ORDER NO"
        '
        'LQTYORDLabel
        '
        Me.LQTYORDLabel.AutoSize = True
        Me.LQTYORDLabel.Location = New System.Drawing.Point(31, 288)
        Me.LQTYORDLabel.Name = "LQTYORDLabel"
        Me.LQTYORDLabel.Size = New System.Drawing.Size(92, 13)
        Me.LQTYORDLabel.TabIndex = 34
        Me.LQTYORDLabel.Text = "QTY TO ORDER:"
        '
        'LPRICELabel
        '
        Me.LPRICELabel.AutoSize = True
        Me.LPRICELabel.Location = New System.Drawing.Point(967, 258)
        Me.LPRICELabel.Name = "LPRICELabel"
        Me.LPRICELabel.Size = New System.Drawing.Size(77, 13)
        Me.LPRICELabel.TabIndex = 37
        Me.LPRICELabel.Text = "UNIT PRICE £"
        '
        'LEPRICELabel
        '
        Me.LEPRICELabel.AutoSize = True
        Me.LEPRICELabel.Location = New System.Drawing.Point(933, 283)
        Me.LEPRICELabel.Name = "LEPRICELabel"
        Me.LEPRICELabel.Size = New System.Drawing.Size(110, 13)
        Me.LEPRICELabel.TabIndex = 39
        Me.LEPRICELabel.Text = "EXTENDED PRICE £"
        '
        'LPARTNOLabel
        '
        Me.LPARTNOLabel.AutoSize = True
        Me.LPARTNOLabel.Location = New System.Drawing.Point(170, 288)
        Me.LPARTNOLabel.Name = "LPARTNOLabel"
        Me.LPARTNOLabel.Size = New System.Drawing.Size(55, 13)
        Me.LPARTNOLabel.TabIndex = 40
        Me.LPARTNOLabel.Text = "PARTNO:"
        '
        'LDESCLabel
        '
        Me.LDESCLabel.AutoSize = True
        Me.LDESCLabel.Location = New System.Drawing.Point(347, 291)
        Me.LDESCLabel.Name = "LDESCLabel"
        Me.LDESCLabel.Size = New System.Drawing.Size(80, 13)
        Me.LDESCLabel.TabIndex = 41
        Me.LDESCLabel.Text = "DESCRIPTION"
        '
        'LOLINEMEMOLabel2
        '
        Me.LOLINEMEMOLabel2.AutoSize = True
        Me.LOLINEMEMOLabel2.Location = New System.Drawing.Point(30, 366)
        Me.LOLINEMEMOLabel2.Name = "LOLINEMEMOLabel2"
        Me.LOLINEMEMOLabel2.Size = New System.Drawing.Size(81, 13)
        Me.LOLINEMEMOLabel2.TabIndex = 54
        Me.LOLINEMEMOLabel2.Text = "LOLINEMEMO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(927, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "REQUIRED BY DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(978, 715)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "ORDER VALUE ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(968, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "DESC MEMO:"
        '
        'cosupplier
        '
        Me.cosupplier.Location = New System.Drawing.Point(129, 66)
        Me.cosupplier.Name = "cosupplier"
        Me.cosupplier.Size = New System.Drawing.Size(187, 20)
        Me.cosupplier.TabIndex = 2
        '
        'cocurr
        '
        Me.cocurr.Location = New System.Drawing.Point(465, 67)
        Me.cocurr.Name = "cocurr"
        Me.cocurr.Size = New System.Drawing.Size(55, 20)
        Me.cocurr.TabIndex = 4
        '
        'cosemail
        '
        Me.cosemail.Location = New System.Drawing.Point(128, 105)
        Me.cosemail.Name = "cosemail"
        Me.cosemail.Size = New System.Drawing.Size(311, 20)
        Me.cosemail.TabIndex = 6
        '
        'costelno
        '
        Me.costelno.Location = New System.Drawing.Point(128, 131)
        Me.costelno.Name = "costelno"
        Me.costelno.Size = New System.Drawing.Size(311, 20)
        Me.costelno.TabIndex = 8
        '
        'cosfaxno
        '
        Me.cosfaxno.Location = New System.Drawing.Point(128, 158)
        Me.cosfaxno.Name = "cosfaxno"
        Me.cosfaxno.Size = New System.Drawing.Size(311, 20)
        Me.cosfaxno.TabIndex = 10
        '
        'coscontact
        '
        Me.coscontact.Location = New System.Drawing.Point(128, 185)
        Me.coscontact.Name = "coscontact"
        Me.coscontact.Size = New System.Drawing.Size(209, 20)
        Me.coscontact.TabIndex = 12
        '
        'cosname
        '
        Me.cosname.Location = New System.Drawing.Point(796, 86)
        Me.cosname.Name = "cosname"
        Me.cosname.Size = New System.Drawing.Size(367, 20)
        Me.cosname.TabIndex = 14
        '
        'coadd1
        '
        Me.coadd1.Location = New System.Drawing.Point(796, 113)
        Me.coadd1.Name = "coadd1"
        Me.coadd1.Size = New System.Drawing.Size(367, 20)
        Me.coadd1.TabIndex = 16
        '
        'coadd2
        '
        Me.coadd2.Location = New System.Drawing.Point(796, 139)
        Me.coadd2.Name = "coadd2"
        Me.coadd2.Size = New System.Drawing.Size(367, 20)
        Me.coadd2.TabIndex = 18
        '
        'coadd3
        '
        Me.coadd3.Location = New System.Drawing.Point(796, 166)
        Me.coadd3.Name = "coadd3"
        Me.coadd3.Size = New System.Drawing.Size(367, 20)
        Me.coadd3.TabIndex = 20
        '
        'coadd4
        '
        Me.coadd4.Location = New System.Drawing.Point(796, 192)
        Me.coadd4.Name = "coadd4"
        Me.coadd4.Size = New System.Drawing.Size(367, 20)
        Me.coadd4.TabIndex = 22
        '
        'coadd5
        '
        Me.coadd5.Location = New System.Drawing.Point(796, 218)
        Me.coadd5.Name = "coadd5"
        Me.coadd5.Size = New System.Drawing.Size(367, 20)
        Me.coadd5.TabIndex = 24
        '
        'cOHeader
        '
        Me.cOHeader.Location = New System.Drawing.Point(128, 255)
        Me.cOHeader.Name = "cOHeader"
        Me.cOHeader.Size = New System.Drawing.Size(429, 20)
        Me.cOHeader.TabIndex = 25
        '
        'LODATEDateTimePicker
        '
        Me.LODATEDateTimePicker.Location = New System.Drawing.Point(643, 20)
        Me.LODATEDateTimePicker.Name = "LODATEDateTimePicker"
        Me.LODATEDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.LODATEDateTimePicker.TabIndex = 27
        '
        'LQTYORDTextBox
        '
        Me.LQTYORDTextBox.Location = New System.Drawing.Point(129, 285)
        Me.LQTYORDTextBox.Name = "LQTYORDTextBox"
        Me.LQTYORDTextBox.Size = New System.Drawing.Size(35, 20)
        Me.LQTYORDTextBox.TabIndex = 35
        '
        'LPRICETextBox
        '
        Me.LPRICETextBox.Location = New System.Drawing.Point(1060, 251)
        Me.LPRICETextBox.Name = "LPRICETextBox"
        Me.LPRICETextBox.Size = New System.Drawing.Size(103, 20)
        Me.LPRICETextBox.TabIndex = 38
        '
        'LEPRICETextBox
        '
        Me.LEPRICETextBox.Location = New System.Drawing.Point(1060, 277)
        Me.LEPRICETextBox.Name = "LEPRICETextBox"
        Me.LEPRICETextBox.Size = New System.Drawing.Size(103, 20)
        Me.LEPRICETextBox.TabIndex = 40
        '
        'LPARTNOTextBox
        '
        Me.LPARTNOTextBox.Location = New System.Drawing.Point(231, 285)
        Me.LPARTNOTextBox.Name = "LPARTNOTextBox"
        Me.LPARTNOTextBox.Size = New System.Drawing.Size(110, 20)
        Me.LPARTNOTextBox.TabIndex = 41
        '
        'LDESCTextBox
        '
        Me.LDESCTextBox.Location = New System.Drawing.Point(435, 285)
        Me.LDESCTextBox.Name = "LDESCTextBox"
        Me.LDESCTextBox.Size = New System.Drawing.Size(408, 20)
        Me.LDESCTextBox.TabIndex = 42
        '
        'nonstk_but
        '
        Me.nonstk_but.Location = New System.Drawing.Point(849, 328)
        Me.nonstk_but.Name = "nonstk_but"
        Me.nonstk_but.Size = New System.Drawing.Size(68, 59)
        Me.nonstk_but.TabIndex = 44
        Me.nonstk_but.Text = "NON STOCK"
        Me.nonstk_but.UseVisualStyleBackColor = True
        '
        'ORDERNOTextBox
        '
        Me.ORDERNOTextBox.Location = New System.Drawing.Point(1047, 20)
        Me.ORDERNOTextBox.Name = "ORDERNOTextBox"
        Me.ORDERNOTextBox.Size = New System.Drawing.Size(117, 20)
        Me.ORDERNOTextBox.TabIndex = 45
        '
        'LOLINEMEMOTextBox2
        '
        Me.LOLINEMEMOTextBox2.Location = New System.Drawing.Point(131, 320)
        Me.LOLINEMEMOTextBox2.Multiline = True
        Me.LOLINEMEMOTextBox2.Name = "LOLINEMEMOTextBox2"
        Me.LOLINEMEMOTextBox2.Size = New System.Drawing.Size(631, 75)
        Me.LOLINEMEMOTextBox2.TabIndex = 55
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1046, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 58
        '
        'ordabort_but
        '
        Me.ordabort_but.Location = New System.Drawing.Point(33, 715)
        Me.ordabort_but.Name = "ordabort_but"
        Me.ordabort_but.Size = New System.Drawing.Size(75, 23)
        Me.ordabort_but.TabIndex = 59
        Me.ordabort_but.Text = "ABORT"
        Me.ordabort_but.UseVisualStyleBackColor = True
        '
        'deline_but
        '
        Me.deline_but.Location = New System.Drawing.Point(152, 715)
        Me.deline_but.Name = "deline_but"
        Me.deline_but.Size = New System.Drawing.Size(107, 23)
        Me.deline_but.TabIndex = 60
        Me.deline_but.Text = "DELETE LINE"
        Me.deline_but.UseVisualStyleBackColor = True
        '
        'orddet_but
        '
        Me.orddet_but.Location = New System.Drawing.Point(435, 715)
        Me.orddet_but.Name = "orddet_but"
        Me.orddet_but.Size = New System.Drawing.Size(107, 23)
        Me.orddet_but.TabIndex = 61
        Me.orddet_but.Text = "ORDER DETAIL"
        Me.orddet_but.UseVisualStyleBackColor = True
        '
        'vwsave_but
        '
        Me.vwsave_but.Location = New System.Drawing.Point(565, 715)
        Me.vwsave_but.Name = "vwsave_but"
        Me.vwsave_but.Size = New System.Drawing.Size(107, 23)
        Me.vwsave_but.TabIndex = 62
        Me.vwsave_but.Text = "VIEW ORDER"
        Me.vwsave_but.UseVisualStyleBackColor = True
        '
        'ordsave_but
        '
        Me.ordsave_but.Location = New System.Drawing.Point(833, 715)
        Me.ordsave_but.Name = "ordsave_but"
        Me.ordsave_but.Size = New System.Drawing.Size(101, 23)
        Me.ordsave_but.TabIndex = 63
        Me.ordsave_but.Text = "SAVE"
        Me.ordsave_but.UseVisualStyleBackColor = True
        '
        'ordhead_but
        '
        Me.ordhead_but.Location = New System.Drawing.Point(1037, 582)
        Me.ordhead_but.Name = "ordhead_but"
        Me.ordhead_but.Size = New System.Drawing.Size(141, 23)
        Me.ordhead_but.TabIndex = 64
        Me.ordhead_but.Text = "HEADING"
        Me.ordhead_but.UseVisualStyleBackColor = True
        '
        'orddesp_but
        '
        Me.orddesp_but.Location = New System.Drawing.Point(1037, 641)
        Me.orddesp_but.Name = "orddesp_but"
        Me.orddesp_but.Size = New System.Drawing.Size(141, 23)
        Me.orddesp_but.TabIndex = 65
        Me.orddesp_but.Text = "DESPATCH"
        Me.orddesp_but.UseVisualStyleBackColor = True
        '
        'ordinstr_but
        '
        Me.ordinstr_but.Location = New System.Drawing.Point(1037, 612)
        Me.ordinstr_but.Name = "ordinstr_but"
        Me.ordinstr_but.Size = New System.Drawing.Size(141, 23)
        Me.ordinstr_but.TabIndex = 66
        Me.ordinstr_but.Text = "INSTRUCT"
        Me.ordinstr_but.UseVisualStyleBackColor = True
        '
        'orddel_but
        '
        Me.orddel_but.Location = New System.Drawing.Point(1037, 670)
        Me.orddel_but.Name = "orddel_but"
        Me.orddel_but.Size = New System.Drawing.Size(141, 23)
        Me.orddel_but.TabIndex = 67
        Me.orddel_but.Text = "DELIVERY"
        Me.orddel_but.UseVisualStyleBackColor = True
        '
        'ord_but
        '
        Me.ord_but.Location = New System.Drawing.Point(768, 320)
        Me.ord_but.Name = "ord_but"
        Me.ord_but.Size = New System.Drawing.Size(75, 31)
        Me.ord_but.TabIndex = 73
        Me.ord_but.Text = "ADD"
        Me.ord_but.UseVisualStyleBackColor = True
        '
        'edt_but
        '
        Me.edt_but.Location = New System.Drawing.Point(767, 365)
        Me.edt_but.Name = "edt_but"
        Me.edt_but.Size = New System.Drawing.Size(75, 30)
        Me.edt_but.TabIndex = 74
        Me.edt_but.Text = "EDIT"
        Me.edt_but.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(1091, 712)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 90
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(967, 328)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(211, 95)
        Me.ListBox1.TabIndex = 93
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IicodeDataGridViewTextBoxColumn, Me.SourcecdeDataGridViewTextBoxColumn, Me.AssuredDataGridViewTextBoxColumn, Me.LocatebinDataGridViewTextBoxColumn, Me.QuantybinDataGridViewTextBoxColumn, Me.AllocDataGridViewTextBoxColumn, Me.CurrcycdeDataGridViewTextBoxColumn, Me.UnitvalueDataGridViewTextBoxColumn, Me.CatalogdtDataGridViewTextBoxColumn, Me.IiupdateDataGridViewTextBoxColumn, Me.RectypeDataGridViewTextBoxColumn, Me.SnwhoDataGridViewTextBoxColumn, Me.SinuseDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.WqtyDataGridViewTextBoxColumn, Me.UniqueIDDataGridViewTextBoxColumn, Me.sup_discpcDataGridViewTextBoxColumn, Me.UnitCost, Me.Retail, Me.mupercentDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.TranbinsBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(34, 426)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(1144, 150)
        Me.DataGridView3.TabIndex = 100
        '
        'IicodeDataGridViewTextBoxColumn
        '
        Me.IicodeDataGridViewTextBoxColumn.DataPropertyName = "iicode"
        Me.IicodeDataGridViewTextBoxColumn.HeaderText = "iicode"
        Me.IicodeDataGridViewTextBoxColumn.Name = "IicodeDataGridViewTextBoxColumn"
        Me.IicodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SourcecdeDataGridViewTextBoxColumn
        '
        Me.SourcecdeDataGridViewTextBoxColumn.DataPropertyName = "sourcecde"
        Me.SourcecdeDataGridViewTextBoxColumn.HeaderText = "sourcecde"
        Me.SourcecdeDataGridViewTextBoxColumn.Name = "SourcecdeDataGridViewTextBoxColumn"
        Me.SourcecdeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AssuredDataGridViewTextBoxColumn
        '
        Me.AssuredDataGridViewTextBoxColumn.DataPropertyName = "assured"
        Me.AssuredDataGridViewTextBoxColumn.HeaderText = "assured"
        Me.AssuredDataGridViewTextBoxColumn.Name = "AssuredDataGridViewTextBoxColumn"
        Me.AssuredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocatebinDataGridViewTextBoxColumn
        '
        Me.LocatebinDataGridViewTextBoxColumn.DataPropertyName = "locatebin"
        Me.LocatebinDataGridViewTextBoxColumn.HeaderText = "locatebin"
        Me.LocatebinDataGridViewTextBoxColumn.Name = "LocatebinDataGridViewTextBoxColumn"
        Me.LocatebinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantybinDataGridViewTextBoxColumn
        '
        Me.QuantybinDataGridViewTextBoxColumn.DataPropertyName = "quantybin"
        Me.QuantybinDataGridViewTextBoxColumn.HeaderText = "quantybin"
        Me.QuantybinDataGridViewTextBoxColumn.Name = "QuantybinDataGridViewTextBoxColumn"
        Me.QuantybinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AllocDataGridViewTextBoxColumn
        '
        Me.AllocDataGridViewTextBoxColumn.DataPropertyName = "alloc"
        Me.AllocDataGridViewTextBoxColumn.HeaderText = "alloc"
        Me.AllocDataGridViewTextBoxColumn.Name = "AllocDataGridViewTextBoxColumn"
        Me.AllocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrcycdeDataGridViewTextBoxColumn
        '
        Me.CurrcycdeDataGridViewTextBoxColumn.DataPropertyName = "currcy_cde"
        Me.CurrcycdeDataGridViewTextBoxColumn.HeaderText = "currcy_cde"
        Me.CurrcycdeDataGridViewTextBoxColumn.Name = "CurrcycdeDataGridViewTextBoxColumn"
        Me.CurrcycdeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitvalueDataGridViewTextBoxColumn
        '
        Me.UnitvalueDataGridViewTextBoxColumn.DataPropertyName = "unit_value"
        Me.UnitvalueDataGridViewTextBoxColumn.HeaderText = "unit_value"
        Me.UnitvalueDataGridViewTextBoxColumn.Name = "UnitvalueDataGridViewTextBoxColumn"
        Me.UnitvalueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CatalogdtDataGridViewTextBoxColumn
        '
        Me.CatalogdtDataGridViewTextBoxColumn.DataPropertyName = "catalog_dt"
        Me.CatalogdtDataGridViewTextBoxColumn.HeaderText = "catalog_dt"
        Me.CatalogdtDataGridViewTextBoxColumn.Name = "CatalogdtDataGridViewTextBoxColumn"
        Me.CatalogdtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IiupdateDataGridViewTextBoxColumn
        '
        Me.IiupdateDataGridViewTextBoxColumn.DataPropertyName = "iiupdate"
        Me.IiupdateDataGridViewTextBoxColumn.HeaderText = "iiupdate"
        Me.IiupdateDataGridViewTextBoxColumn.Name = "IiupdateDataGridViewTextBoxColumn"
        Me.IiupdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RectypeDataGridViewTextBoxColumn
        '
        Me.RectypeDataGridViewTextBoxColumn.DataPropertyName = "rec_type"
        Me.RectypeDataGridViewTextBoxColumn.HeaderText = "rec_type"
        Me.RectypeDataGridViewTextBoxColumn.Name = "RectypeDataGridViewTextBoxColumn"
        Me.RectypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SnwhoDataGridViewTextBoxColumn
        '
        Me.SnwhoDataGridViewTextBoxColumn.DataPropertyName = "snwho"
        Me.SnwhoDataGridViewTextBoxColumn.HeaderText = "snwho"
        Me.SnwhoDataGridViewTextBoxColumn.Name = "SnwhoDataGridViewTextBoxColumn"
        Me.SnwhoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SinuseDataGridViewTextBoxColumn
        '
        Me.SinuseDataGridViewTextBoxColumn.DataPropertyName = "sinuse"
        Me.SinuseDataGridViewTextBoxColumn.HeaderText = "sinuse"
        Me.SinuseDataGridViewTextBoxColumn.Name = "SinuseDataGridViewTextBoxColumn"
        Me.SinuseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WqtyDataGridViewTextBoxColumn
        '
        Me.WqtyDataGridViewTextBoxColumn.DataPropertyName = "wqty"
        Me.WqtyDataGridViewTextBoxColumn.HeaderText = "wqty"
        Me.WqtyDataGridViewTextBoxColumn.Name = "WqtyDataGridViewTextBoxColumn"
        Me.WqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UniqueIDDataGridViewTextBoxColumn
        '
        Me.UniqueIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn.HeaderText = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn.Name = "UniqueIDDataGridViewTextBoxColumn"
        Me.UniqueIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'sup_discpcDataGridViewTextBoxColumn
        '
        Me.sup_discpcDataGridViewTextBoxColumn.DataPropertyName = "sup_discpc"
        Me.sup_discpcDataGridViewTextBoxColumn.HeaderText = "Sup Disc"
        Me.sup_discpcDataGridViewTextBoxColumn.Name = "sup_discpcDataGridViewTextBoxColumn"
        Me.sup_discpcDataGridViewTextBoxColumn.ReadOnly = True
        Me.sup_discpcDataGridViewTextBoxColumn.Width = 50
        '
        'UnitCost
        '
        Me.UnitCost.HeaderText = "Unit Cost"
        Me.UnitCost.Name = "UnitCost"
        Me.UnitCost.ReadOnly = True
        Me.UnitCost.Width = 80
        '
        'Retail
        '
        Me.Retail.HeaderText = "Retail "
        Me.Retail.Name = "Retail"
        Me.Retail.ReadOnly = True
        Me.Retail.Width = 80
        '
        'mupercentDataGridViewTextBoxColumn
        '
        Me.mupercentDataGridViewTextBoxColumn.DataPropertyName = "mupercent"
        Me.mupercentDataGridViewTextBoxColumn.HeaderText = "Markup"
        Me.mupercentDataGridViewTextBoxColumn.Name = "mupercentDataGridViewTextBoxColumn"
        Me.mupercentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TranbinsBindingSource
        '
        Me.TranbinsBindingSource.DataMember = "tranbins"
        Me.TranbinsBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TranbinsTableAdapter
        '
        Me.TranbinsTableAdapter.ClearBeforeFill = True
        '
        'QuotedetailBindingSource
        '
        Me.QuotedetailBindingSource.DataMember = "quotedetail"
        Me.QuotedetailBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'QuotedetailTableAdapter
        '
        Me.QuotedetailTableAdapter.ClearBeforeFill = True
        '
        'OrderlineBindingSource
        '
        Me.OrderlineBindingSource.DataMember = "orderline"
        Me.OrderlineBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'OrderlineTableAdapter
        '
        Me.OrderlineTableAdapter.ClearBeforeFill = True
        '
        'OrderheadBindingSource
        '
        Me.OrderheadBindingSource.DataMember = "orderhead"
        Me.OrderheadBindingSource.DataSource = Me.TransvacDataV2DataSet1
        '
        'OrderheadTableAdapter
        '
        Me.OrderheadTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowDrop = True
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UniqueIDDataGridViewTextBoxColumn1, Me.ExtendedPrice, Me.qpart_no, Me.quote_no, Me.quote_sufDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.OrderlineBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(33, 582)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(981, 123)
        Me.DataGridView2.TabIndex = 101
        '
        'UniqueIDDataGridViewTextBoxColumn1
        '
        Me.UniqueIDDataGridViewTextBoxColumn1.DataPropertyName = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn1.HeaderText = "UniqueID"
        Me.UniqueIDDataGridViewTextBoxColumn1.Name = "UniqueIDDataGridViewTextBoxColumn1"
        Me.UniqueIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ExtendedPrice
        '
        Me.ExtendedPrice.HeaderText = "ExtendedPrice"
        Me.ExtendedPrice.Name = "ExtendedPrice"
        '
        'qpart_no
        '
        Me.qpart_no.DataPropertyName = "qpart_no"
        Me.qpart_no.HeaderText = "qpart_no"
        Me.qpart_no.Name = "qpart_no"
        '
        'quote_no
        '
        Me.quote_no.DataPropertyName = "quote_no"
        Me.quote_no.HeaderText = "QUOTENO"
        Me.quote_no.Name = "quote_no"
        '
        'quote_sufDataGridViewTextBoxColumn
        '
        Me.quote_sufDataGridViewTextBoxColumn.DataPropertyName = "quote_suf"
        Me.quote_sufDataGridViewTextBoxColumn.HeaderText = "Quote SUF"
        Me.quote_sufDataGridViewTextBoxColumn.Name = "quote_sufDataGridViewTextBoxColumn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1244, 769)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.edt_but)
        Me.Controls.Add(Me.ord_but)
        Me.Controls.Add(Me.orddel_but)
        Me.Controls.Add(Me.ordinstr_but)
        Me.Controls.Add(Me.orddesp_but)
        Me.Controls.Add(Me.ordhead_but)
        Me.Controls.Add(Me.ordsave_but)
        Me.Controls.Add(Me.vwsave_but)
        Me.Controls.Add(Me.orddet_but)
        Me.Controls.Add(Me.deline_but)
        Me.Controls.Add(Me.ordabort_but)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LOLINEMEMOLabel2)
        Me.Controls.Add(Me.LOLINEMEMOTextBox2)
        Me.Controls.Add(Me.ORDERNOTextBox)
        Me.Controls.Add(Me.nonstk_but)
        Me.Controls.Add(Me.LDESCLabel)
        Me.Controls.Add(Me.LDESCTextBox)
        Me.Controls.Add(Me.LPARTNOLabel)
        Me.Controls.Add(Me.LPARTNOTextBox)
        Me.Controls.Add(Me.LEPRICELabel)
        Me.Controls.Add(Me.LEPRICETextBox)
        Me.Controls.Add(Me.LPRICELabel)
        Me.Controls.Add(Me.LPRICETextBox)
        Me.Controls.Add(Me.LQTYORDLabel)
        Me.Controls.Add(Me.LQTYORDTextBox)
        Me.Controls.Add(Me.LODATELabel)
        Me.Controls.Add(Me.LODATEDateTimePicker)
        Me.Controls.Add(Me.OHEADERLabel)
        Me.Controls.Add(Me.cOHeader)
        Me.Controls.Add(Me.coadd5)
        Me.Controls.Add(Me.coadd4)
        Me.Controls.Add(Me.coadd3)
        Me.Controls.Add(Me.coadd2)
        Me.Controls.Add(Me.coadd1)
        Me.Controls.Add(Me.OSNAMELabel)
        Me.Controls.Add(Me.cosname)
        Me.Controls.Add(Me.OSCONTACTLabel)
        Me.Controls.Add(Me.coscontact)
        Me.Controls.Add(Me.OSFAXNOLabel)
        Me.Controls.Add(Me.cosfaxno)
        Me.Controls.Add(Me.OSTELNOLabel)
        Me.Controls.Add(Me.costelno)
        Me.Controls.Add(Me.OSEMAILLabel)
        Me.Controls.Add(Me.cosemail)
        Me.Controls.Add(Me.OCURRLabel)
        Me.Controls.Add(Me.cocurr)
        Me.Controls.Add(Me.OSUPPLIERLabel)
        Me.Controls.Add(Me.cosupplier)
        Me.Name = "OrderForm"
        Me.Text = "Orders Form"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TranbinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotedetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderlineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderheadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents LODATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LQTYORDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LPRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LEPRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LPARTNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LDESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nonstk_but As System.Windows.Forms.Button
    Friend WithEvents ORDERNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LOLINEMEMOTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ordabort_but As Button
    Friend WithEvents deline_but As Button
    Friend WithEvents orddet_but As Button
    Friend WithEvents vwsave_but As Button
    Friend WithEvents ordsave_but As Button
    Friend WithEvents ordhead_but As Button
    Friend WithEvents orddesp_but As Button
    Friend WithEvents ordinstr_but As Button
    Friend WithEvents orddel_but As Button
    Friend WithEvents ord_but As Button
    Friend WithEvents edt_but As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents OSUPPLIERLabel As Label
    Friend WithEvents OCURRLabel As Label
    Friend WithEvents OSEMAILLabel As Label
    Friend WithEvents OSTELNOLabel As Label
    Friend WithEvents OSFAXNOLabel As Label
    Friend WithEvents OSCONTACTLabel As Label
    Friend WithEvents OSNAMELabel As Label
    Friend WithEvents OHEADERLabel As Label
    Friend WithEvents LODATELabel As Label
    Friend WithEvents LQTYORDLabel As Label
    Friend WithEvents LPRICELabel As Label
    Friend WithEvents LEPRICELabel As Label
    Friend WithEvents LPARTNOLabel As Label
    Friend WithEvents LDESCLabel As Label
    Friend WithEvents LOLINEMEMOLabel2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents sup_discpcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitCost As DataGridViewTextBoxColumn
    Friend WithEvents Retail As DataGridViewTextBoxColumn
    Friend WithEvents mupercentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents TranbinsBindingSource As BindingSource
    Friend WithEvents TranbinsTableAdapter As TransvacDataV2DataSet1TableAdapters.tranbinsTableAdapter
    Friend WithEvents IicodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SourcecdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssuredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocatebinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantybinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrcycdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitvalueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatalogdtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IiupdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RectypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnwhoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SinuseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WqtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniqueIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuotedetailBindingSource As BindingSource
    Friend WithEvents QuotedetailTableAdapter As TransvacDataV2DataSet1TableAdapters.quotedetailTableAdapter
    Friend WithEvents OrderlineBindingSource As BindingSource
    Friend WithEvents OrderlineTableAdapter As TransvacDataV2DataSet1TableAdapters.orderlineTableAdapter
    Friend WithEvents OrderheadBindingSource As BindingSource
    Friend WithEvents OrderheadTableAdapter As TransvacDataV2DataSet1TableAdapters.orderheadTableAdapter
    Public WithEvents DataGridView2 As DataGridView
    Friend WithEvents ExtendedPrice As DataGridViewTextBoxColumn
    Friend WithEvents qpart_no As DataGridViewTextBoxColumn
    Friend WithEvents quote_no As DataGridViewTextBoxColumn
    Friend WithEvents quote_sufDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniqueIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
