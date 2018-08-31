<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rorderform
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LOLINEMEMOLabel2 = New System.Windows.Forms.Label()
        Me.LOLINEMEMOTextBox2 = New System.Windows.Forms.TextBox()
        Me.ORDERNOTextBox = New System.Windows.Forms.TextBox()
        Me.LDESCLabel = New System.Windows.Forms.Label()
        Me.LDESCTextBox = New System.Windows.Forms.TextBox()
        Me.LPARTNOLabel = New System.Windows.Forms.Label()
        Me.LPARTNOTextBox = New System.Windows.Forms.TextBox()
        Me.LQTYORDLabel = New System.Windows.Forms.Label()
        Me.LQTYORDTextBox = New System.Windows.Forms.TextBox()
        Me.LODATELabel = New System.Windows.Forms.Label()
        Me.LODATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OHEADERLabel = New System.Windows.Forms.Label()
        Me.cOHeader = New System.Windows.Forms.TextBox()
        Me.coadd5 = New System.Windows.Forms.TextBox()
        Me.coadd4 = New System.Windows.Forms.TextBox()
        Me.coadd3 = New System.Windows.Forms.TextBox()
        Me.coadd2 = New System.Windows.Forms.TextBox()
        Me.coadd1 = New System.Windows.Forms.TextBox()
        Me.OSNAMELabel = New System.Windows.Forms.Label()
        Me.cosname = New System.Windows.Forms.TextBox()
        Me.OSCONTACTLabel = New System.Windows.Forms.Label()
        Me.coscontact = New System.Windows.Forms.TextBox()
        Me.OSFAXNOLabel = New System.Windows.Forms.Label()
        Me.cosfaxno = New System.Windows.Forms.TextBox()
        Me.OSTELNOLabel = New System.Windows.Forms.Label()
        Me.costelno = New System.Windows.Forms.TextBox()
        Me.OSEMAILLabel = New System.Windows.Forms.Label()
        Me.cosemail = New System.Windows.Forms.TextBox()
        Me.OCURRLabel = New System.Windows.Forms.Label()
        Me.cocurr = New System.Windows.Forms.TextBox()
        Me.OSUPPLIERLabel = New System.Windows.Forms.Label()
        Me.cosupplier = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(46, 492)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1130, 77)
        Me.DataGridView2.TabIndex = 147
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 575)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1130, 111)
        Me.DataGridView1.TabIndex = 146
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1074, 706)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 40)
        Me.Button6.TabIndex = 139
        Me.Button6.Text = "SAVE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(447, 706)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 40)
        Me.Button4.TabIndex = 137
        Me.Button4.Text = "ORDER DETAIL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(45, 706)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 135
        Me.Button2.Text = "ABORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(939, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "REQUIRED BY DATE:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1058, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 134
        '
        'LOLINEMEMOLabel2
        '
        Me.LOLINEMEMOLabel2.AutoSize = True
        Me.LOLINEMEMOLabel2.Location = New System.Drawing.Point(42, 404)
        Me.LOLINEMEMOLabel2.Name = "LOLINEMEMOLabel2"
        Me.LOLINEMEMOLabel2.Size = New System.Drawing.Size(70, 13)
        Me.LOLINEMEMOLabel2.TabIndex = 131
        Me.LOLINEMEMOLabel2.Text = "LINE MEMO:"
        '
        'LOLINEMEMOTextBox2
        '
        Me.LOLINEMEMOTextBox2.Location = New System.Drawing.Point(140, 372)
        Me.LOLINEMEMOTextBox2.Multiline = True
        Me.LOLINEMEMOTextBox2.Name = "LOLINEMEMOTextBox2"
        Me.LOLINEMEMOTextBox2.Size = New System.Drawing.Size(715, 75)
        Me.LOLINEMEMOTextBox2.TabIndex = 132
        '
        'ORDERNOTextBox
        '
        Me.ORDERNOTextBox.Location = New System.Drawing.Point(1059, 21)
        Me.ORDERNOTextBox.Name = "ORDERNOTextBox"
        Me.ORDERNOTextBox.Size = New System.Drawing.Size(117, 20)
        Me.ORDERNOTextBox.TabIndex = 130
        '
        'LDESCLabel
        '
        Me.LDESCLabel.AutoSize = True
        Me.LDESCLabel.Location = New System.Drawing.Point(359, 329)
        Me.LDESCLabel.Name = "LDESCLabel"
        Me.LDESCLabel.Size = New System.Drawing.Size(80, 13)
        Me.LDESCLabel.TabIndex = 126
        Me.LDESCLabel.Text = "DESCRIPTION"
        '
        'LDESCTextBox
        '
        Me.LDESCTextBox.Location = New System.Drawing.Point(447, 323)
        Me.LDESCTextBox.Name = "LDESCTextBox"
        Me.LDESCTextBox.Size = New System.Drawing.Size(391, 20)
        Me.LDESCTextBox.TabIndex = 128
        '
        'LPARTNOLabel
        '
        Me.LPARTNOLabel.AutoSize = True
        Me.LPARTNOLabel.Location = New System.Drawing.Point(182, 326)
        Me.LPARTNOLabel.Name = "LPARTNOLabel"
        Me.LPARTNOLabel.Size = New System.Drawing.Size(55, 13)
        Me.LPARTNOLabel.TabIndex = 124
        Me.LPARTNOLabel.Text = "PARTNO:"
        '
        'LPARTNOTextBox
        '
        Me.LPARTNOTextBox.Location = New System.Drawing.Point(243, 323)
        Me.LPARTNOTextBox.Name = "LPARTNOTextBox"
        Me.LPARTNOTextBox.Size = New System.Drawing.Size(110, 20)
        Me.LPARTNOTextBox.TabIndex = 127
        '
        'LQTYORDLabel
        '
        Me.LQTYORDLabel.AutoSize = True
        Me.LQTYORDLabel.Location = New System.Drawing.Point(43, 326)
        Me.LQTYORDLabel.Name = "LQTYORDLabel"
        Me.LQTYORDLabel.Size = New System.Drawing.Size(32, 13)
        Me.LQTYORDLabel.TabIndex = 119
        Me.LQTYORDLabel.Text = "QTY:"
        '
        'LQTYORDTextBox
        '
        Me.LQTYORDTextBox.Location = New System.Drawing.Point(141, 323)
        Me.LQTYORDTextBox.Name = "LQTYORDTextBox"
        Me.LQTYORDTextBox.Size = New System.Drawing.Size(35, 20)
        Me.LQTYORDTextBox.TabIndex = 120
        '
        'LODATELabel
        '
        Me.LODATELabel.AutoSize = True
        Me.LODATELabel.Location = New System.Drawing.Point(990, 21)
        Me.LODATELabel.Name = "LODATELabel"
        Me.LODATELabel.Size = New System.Drawing.Size(65, 13)
        Me.LODATELabel.TabIndex = 117
        Me.LODATELabel.Text = "ORDER NO"
        '
        'LODATEDateTimePicker
        '
        Me.LODATEDateTimePicker.Location = New System.Drawing.Point(655, 21)
        Me.LODATEDateTimePicker.Name = "LODATEDateTimePicker"
        Me.LODATEDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.LODATEDateTimePicker.TabIndex = 118
        '
        'OHEADERLabel
        '
        Me.OHEADERLabel.AutoSize = True
        Me.OHEADERLabel.Location = New System.Drawing.Point(43, 285)
        Me.OHEADERLabel.Name = "OHEADERLabel"
        Me.OHEADERLabel.Size = New System.Drawing.Size(52, 13)
        Me.OHEADERLabel.TabIndex = 115
        Me.OHEADERLabel.Text = "HEADER"
        '
        'cOHeader
        '
        Me.cOHeader.Location = New System.Drawing.Point(141, 281)
        Me.cOHeader.Name = "cOHeader"
        Me.cOHeader.Size = New System.Drawing.Size(429, 20)
        Me.cOHeader.TabIndex = 116
        '
        'coadd5
        '
        Me.coadd5.Location = New System.Drawing.Point(809, 222)
        Me.coadd5.Name = "coadd5"
        Me.coadd5.Size = New System.Drawing.Size(367, 20)
        Me.coadd5.TabIndex = 114
        '
        'coadd4
        '
        Me.coadd4.Location = New System.Drawing.Point(808, 193)
        Me.coadd4.Name = "coadd4"
        Me.coadd4.Size = New System.Drawing.Size(367, 20)
        Me.coadd4.TabIndex = 113
        '
        'coadd3
        '
        Me.coadd3.Location = New System.Drawing.Point(808, 167)
        Me.coadd3.Name = "coadd3"
        Me.coadd3.Size = New System.Drawing.Size(367, 20)
        Me.coadd3.TabIndex = 112
        '
        'coadd2
        '
        Me.coadd2.Location = New System.Drawing.Point(808, 140)
        Me.coadd2.Name = "coadd2"
        Me.coadd2.Size = New System.Drawing.Size(367, 20)
        Me.coadd2.TabIndex = 111
        '
        'coadd1
        '
        Me.coadd1.Location = New System.Drawing.Point(808, 114)
        Me.coadd1.Name = "coadd1"
        Me.coadd1.Size = New System.Drawing.Size(367, 20)
        Me.coadd1.TabIndex = 110
        '
        'OSNAMELabel
        '
        Me.OSNAMELabel.AutoSize = True
        Me.OSNAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSNAMELabel.Location = New System.Drawing.Point(734, 91)
        Me.OSNAMELabel.Name = "OSNAMELabel"
        Me.OSNAMELabel.Size = New System.Drawing.Size(66, 13)
        Me.OSNAMELabel.TabIndex = 108
        Me.OSNAMELabel.Text = "ADDRESS"
        '
        'cosname
        '
        Me.cosname.Location = New System.Drawing.Point(808, 87)
        Me.cosname.Name = "cosname"
        Me.cosname.Size = New System.Drawing.Size(367, 20)
        Me.cosname.TabIndex = 109
        '
        'OSCONTACTLabel
        '
        Me.OSCONTACTLabel.AutoSize = True
        Me.OSCONTACTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSCONTACTLabel.Location = New System.Drawing.Point(43, 194)
        Me.OSCONTACTLabel.Name = "OSCONTACTLabel"
        Me.OSCONTACTLabel.Size = New System.Drawing.Size(65, 13)
        Me.OSCONTACTLabel.TabIndex = 106
        Me.OSCONTACTLabel.Text = "CONTACT"
        '
        'coscontact
        '
        Me.coscontact.Location = New System.Drawing.Point(140, 186)
        Me.coscontact.Name = "coscontact"
        Me.coscontact.Size = New System.Drawing.Size(209, 20)
        Me.coscontact.TabIndex = 107
        '
        'OSFAXNOLabel
        '
        Me.OSFAXNOLabel.AutoSize = True
        Me.OSFAXNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSFAXNOLabel.Location = New System.Drawing.Point(43, 165)
        Me.OSFAXNOLabel.Name = "OSFAXNOLabel"
        Me.OSFAXNOLabel.Size = New System.Drawing.Size(52, 13)
        Me.OSFAXNOLabel.TabIndex = 104
        Me.OSFAXNOLabel.Text = "FAX NO"
        '
        'cosfaxno
        '
        Me.cosfaxno.Location = New System.Drawing.Point(140, 159)
        Me.cosfaxno.Name = "cosfaxno"
        Me.cosfaxno.Size = New System.Drawing.Size(311, 20)
        Me.cosfaxno.TabIndex = 105
        '
        'OSTELNOLabel
        '
        Me.OSTELNOLabel.AutoSize = True
        Me.OSTELNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSTELNOLabel.Location = New System.Drawing.Point(43, 138)
        Me.OSTELNOLabel.Name = "OSTELNOLabel"
        Me.OSTELNOLabel.Size = New System.Drawing.Size(81, 13)
        Me.OSTELNOLabel.TabIndex = 102
        Me.OSTELNOLabel.Text = "TELEPHONE"
        '
        'costelno
        '
        Me.costelno.Location = New System.Drawing.Point(140, 132)
        Me.costelno.Name = "costelno"
        Me.costelno.Size = New System.Drawing.Size(311, 20)
        Me.costelno.TabIndex = 103
        '
        'OSEMAILLabel
        '
        Me.OSEMAILLabel.AutoSize = True
        Me.OSEMAILLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSEMAILLabel.Location = New System.Drawing.Point(43, 110)
        Me.OSEMAILLabel.Name = "OSEMAILLabel"
        Me.OSEMAILLabel.Size = New System.Drawing.Size(48, 13)
        Me.OSEMAILLabel.TabIndex = 100
        Me.OSEMAILLabel.Text = "E-MAIL"
        '
        'cosemail
        '
        Me.cosemail.Location = New System.Drawing.Point(140, 106)
        Me.cosemail.Name = "cosemail"
        Me.cosemail.Size = New System.Drawing.Size(311, 20)
        Me.cosemail.TabIndex = 101
        '
        'OCURRLabel
        '
        Me.OCURRLabel.AutoSize = True
        Me.OCURRLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OCURRLabel.Location = New System.Drawing.Point(376, 71)
        Me.OCURRLabel.Name = "OCURRLabel"
        Me.OCURRLabel.Size = New System.Drawing.Size(75, 13)
        Me.OCURRLabel.TabIndex = 98
        Me.OCURRLabel.Text = "CURRENCY"
        '
        'cocurr
        '
        Me.cocurr.Location = New System.Drawing.Point(477, 68)
        Me.cocurr.Name = "cocurr"
        Me.cocurr.Size = New System.Drawing.Size(55, 20)
        Me.cocurr.TabIndex = 99
        '
        'OSUPPLIERLabel
        '
        Me.OSUPPLIERLabel.AutoSize = True
        Me.OSUPPLIERLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSUPPLIERLabel.Location = New System.Drawing.Point(43, 71)
        Me.OSUPPLIERLabel.Name = "OSUPPLIERLabel"
        Me.OSUPPLIERLabel.Size = New System.Drawing.Size(68, 13)
        Me.OSUPPLIERLabel.TabIndex = 96
        Me.OSUPPLIERLabel.Text = "SUPPLIER"
        '
        'cosupplier
        '
        Me.cosupplier.Location = New System.Drawing.Point(141, 67)
        Me.cosupplier.Name = "cosupplier"
        Me.cosupplier.Size = New System.Drawing.Size(187, 20)
        Me.cosupplier.TabIndex = 97
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(935, 322)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(47, 20)
        Me.TextBox3.TabIndex = 153
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(844, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "RECIEVED QTY:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(14, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 152
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1009, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 155
        Me.Button1.Text = "CONFIRM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1090, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 67)
        Me.Button3.TabIndex = 156
        Me.Button3.Text = "RECEIVE ALL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Receive Order"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(932, 401)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "BACK 2 BACK"
        '
        'rorderform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1223, 758)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LOLINEMEMOLabel2)
        Me.Controls.Add(Me.LOLINEMEMOTextBox2)
        Me.Controls.Add(Me.ORDERNOTextBox)
        Me.Controls.Add(Me.LDESCLabel)
        Me.Controls.Add(Me.LDESCTextBox)
        Me.Controls.Add(Me.LPARTNOLabel)
        Me.Controls.Add(Me.LPARTNOTextBox)
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
        Me.Name = "rorderform"
        Me.Text = "Recieve Order Form"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LOLINEMEMOLabel2 As Label
    Friend WithEvents LOLINEMEMOTextBox2 As TextBox
    Friend WithEvents ORDERNOTextBox As TextBox
    Friend WithEvents LDESCLabel As Label
    Friend WithEvents LDESCTextBox As TextBox
    Friend WithEvents LPARTNOLabel As Label
    Friend WithEvents LPARTNOTextBox As TextBox
    Friend WithEvents LQTYORDLabel As Label
    Friend WithEvents LQTYORDTextBox As TextBox
    Friend WithEvents LODATELabel As Label
    Friend WithEvents LODATEDateTimePicker As DateTimePicker
    Friend WithEvents OHEADERLabel As Label
    Friend WithEvents cOHeader As TextBox
    Friend WithEvents coadd5 As TextBox
    Friend WithEvents coadd4 As TextBox
    Friend WithEvents coadd3 As TextBox
    Friend WithEvents coadd2 As TextBox
    Friend WithEvents coadd1 As TextBox
    Friend WithEvents OSNAMELabel As Label
    Friend WithEvents cosname As TextBox
    Friend WithEvents OSCONTACTLabel As Label
    Friend WithEvents coscontact As TextBox
    Friend WithEvents OSFAXNOLabel As Label
    Friend WithEvents cosfaxno As TextBox
    Friend WithEvents OSTELNOLabel As Label
    Friend WithEvents costelno As TextBox
    Friend WithEvents OSEMAILLabel As Label
    Friend WithEvents cosemail As TextBox
    Friend WithEvents OCURRLabel As Label
    Friend WithEvents cocurr As TextBox
    Friend WithEvents OSUPPLIERLabel As Label
    Friend WithEvents cosupplier As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
