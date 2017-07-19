<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selstatus
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
        Me.CustdiscBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSetCustDisc = New ENQUIRYNEW.TransvacDataV2DataSetCustDisc()
        Me.CustdiscTableAdapter = New ENQUIRYNEW.TransvacDataV2DataSetCustDiscTableAdapters.custdiscTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.CustdiscBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSetCustDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustdiscBindingSource
        '
        Me.CustdiscBindingSource.DataMember = "custdisc"
        Me.CustdiscBindingSource.DataSource = Me.TransvacDataV2DataSetCustDisc
        '
        'TransvacDataV2DataSetCustDisc
        '
        Me.TransvacDataV2DataSetCustDisc.DataSetName = "TransvacDataV2DataSetCustDisc"
        Me.TransvacDataV2DataSetCustDisc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustdiscTableAdapter
        '
        Me.CustdiscTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"ENQUIRY", "AWAITING DETAILS", "REJECTED", "SUPPLIER QUOTE", "QUOTED", "INVOICED", "STRAIGHT ORDER", "COMPLETED", "ARCHIVED"})
        Me.ListBox1.Location = New System.Drawing.Point(86, 117)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(135, 121)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Status Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(86, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(135, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SELECT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ENQUIRYNEW.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'selstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(265, 315)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "selstatus"
        Me.Text = "Select Status"
        CType(Me.CustdiscBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSetCustDisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TransvacDataV2DataSetCustDisc As TransvacDataV2DataSetCustDisc
    Friend WithEvents CustdiscBindingSource As BindingSource
    Friend WithEvents CustdiscTableAdapter As TransvacDataV2DataSetCustDiscTableAdapters.custdiscTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
