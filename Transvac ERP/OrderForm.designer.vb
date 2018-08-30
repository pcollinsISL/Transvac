<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OHEADERLabel.Location = New System.Drawing.Point(31, 247)
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
        Me.Label2.Location = New System.Drawing.Point(978, 678)
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
        Me.coadd5.Location = New System.Drawing.Point(797, 221)
        Me.coadd5.Name = "coadd5"
        Me.coadd5.Size = New System.Drawing.Size(367, 20)
        Me.coadd5.TabIndex = 24
        '
        'cOHeader
        '
        Me.cOHeader.Location = New System.Drawing.Point(129, 243)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(849, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 59)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "NON STOCK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ORDERNOTextBox
        '
        Me.ORDERNOTextBox.Location = New System.Drawing.Point(1047, 20)
        Me.ORDERNOTextBox.Name = "ORDERNOTextBox"
        Me.ORDERNOTextBox.Size = New System.Drawing.Size(120, 20)
        Me.ORDERNOTextBox.TabIndex = 45
        '
        'LOLINEMEMOTextBox2
        '
        Me.LOLINEMEMOTextBox2.Location = New System.Drawing.Point(128, 334)
        Me.LOLINEMEMOTextBox2.Multiline = True
        Me.LOLINEMEMOTextBox2.Name = "LOLINEMEMOTextBox2"
        Me.LOLINEMEMOTextBox2.Size = New System.Drawing.Size(631, 75)
        Me.LOLINEMEMOTextBox2.TabIndex = 55
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1046, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 58
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(33, 668)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "ABORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(152, 668)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 23)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "DELETE LINE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(435, 668)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 23)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "ORDER DETAIL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(565, 668)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 23)
        Me.Button5.TabIndex = 62
        Me.Button5.Text = "VIEW ORDER"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(831, 668)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 23)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "SAVE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1037, 537)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(171, 23)
        Me.Button7.TabIndex = 64
        Me.Button7.Text = "HEADING"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1037, 596)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(171, 23)
        Me.Button8.TabIndex = 65
        Me.Button8.Text = "DESPATCH"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1037, 567)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(171, 23)
        Me.Button9.TabIndex = 66
        Me.Button9.Text = "INSTRUCT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(1037, 625)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(171, 23)
        Me.Button10.TabIndex = 67
        Me.Button10.Text = "DELIVERY"
        Me.Button10.UseVisualStyleBackColor = True
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
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 537)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(992, 111)
        Me.DataGridView1.TabIndex = 88
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(34, 429)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1174, 102)
        Me.DataGridView2.TabIndex = 89
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(1090, 671)
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
        Me.ListBox1.Size = New System.Drawing.Size(241, 95)
        Me.ListBox1.TabIndex = 93
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
        Me.ClientSize = New System.Drawing.Size(1265, 740)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LOLINEMEMOLabel2)
        Me.Controls.Add(Me.LOLINEMEMOTextBox2)
        Me.Controls.Add(Me.ORDERNOTextBox)
        Me.Controls.Add(Me.Button1)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
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
End Class
