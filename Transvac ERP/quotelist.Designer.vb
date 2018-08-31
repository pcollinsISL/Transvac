<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class quotelist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.abort_but = New System.Windows.Forms.Button()
        Me.editqu_but = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TransvacDataV2DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuoteheadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuoteheadTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.quoteheadTableAdapter()
        Me.delqut_but = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.QuoteheadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.quotenotextbox = New System.Windows.Forms.TextBox()
        Me.CustdiscTableAdapter1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.custdiscTableAdapter()
        Me.accountno = New System.Windows.Forms.TextBox()
        Me.QuotenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotesufDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QheaderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QwhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qmemo1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qmemo2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qmemo3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qmemo4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QdiscDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.QinitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimestampcolumnDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteheadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteheadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'abort_but
        '
        Me.abort_but.Location = New System.Drawing.Point(29, 387)
        Me.abort_but.Name = "abort_but"
        Me.abort_but.Size = New System.Drawing.Size(95, 38)
        Me.abort_but.TabIndex = 0
        Me.abort_but.Text = "ABORT"
        Me.abort_but.UseVisualStyleBackColor = True
        '
        'editqu_but
        '
        Me.editqu_but.Location = New System.Drawing.Point(617, 387)
        Me.editqu_but.Name = "editqu_but"
        Me.editqu_but.Size = New System.Drawing.Size(94, 38)
        Me.editqu_but.TabIndex = 1
        Me.editqu_but.Text = "EDIT QUOTE"
        Me.editqu_but.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Quote List"
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransvacDataV2DataSet1BindingSource
        '
        Me.TransvacDataV2DataSet1BindingSource.DataSource = Me.TransvacDataV2DataSet1
        Me.TransvacDataV2DataSet1BindingSource.Position = 0
        '
        'QuoteheadBindingSource
        '
        Me.QuoteheadBindingSource.DataMember = "quotehead"
        Me.QuoteheadBindingSource.DataSource = Me.TransvacDataV2DataSet1BindingSource
        '
        'QuoteheadTableAdapter
        '
        Me.QuoteheadTableAdapter.ClearBeforeFill = True
        '
        'delqut_but
        '
        Me.delqut_but.Location = New System.Drawing.Point(172, 387)
        Me.delqut_but.Name = "delqut_but"
        Me.delqut_but.Size = New System.Drawing.Size(118, 38)
        Me.delqut_but.TabIndex = 3
        Me.delqut_but.Text = "DELETE QUOTE"
        Me.delqut_but.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QuotenoDataGridViewTextBoxColumn, Me.QuotesufDataGridViewTextBoxColumn, Me.QdateDataGridViewTextBoxColumn, Me.QheaderDataGridViewTextBoxColumn, Me.QwhoDataGridViewTextBoxColumn, Me.Qmemo1DataGridViewTextBoxColumn, Me.Qmemo2DataGridViewTextBoxColumn, Me.Qmemo3DataGridViewTextBoxColumn, Me.Qmemo4DataGridViewTextBoxColumn, Me.QdiscDataGridViewCheckBoxColumn, Me.QinitsDataGridViewTextBoxColumn, Me.TimestampcolumnDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.QuoteheadBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(29, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(688, 267)
        Me.DataGridView1.TabIndex = 11
        '
        'QuoteheadBindingSource1
        '
        Me.QuoteheadBindingSource1.DataMember = "quotehead"
        Me.QuoteheadBindingSource1.DataSource = Me.TransvacDataV2DataSet1BindingSource
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox2.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'quotenotextbox
        '
        Me.quotenotextbox.Location = New System.Drawing.Point(617, 12)
        Me.quotenotextbox.Name = "quotenotextbox"
        Me.quotenotextbox.Size = New System.Drawing.Size(100, 20)
        Me.quotenotextbox.TabIndex = 13
        '
        'CustdiscTableAdapter1
        '
        Me.CustdiscTableAdapter1.ClearBeforeFill = True
        '
        'accountno
        '
        Me.accountno.Location = New System.Drawing.Point(487, 12)
        Me.accountno.Name = "accountno"
        Me.accountno.Size = New System.Drawing.Size(100, 20)
        Me.accountno.TabIndex = 14
        '
        'QuotenoDataGridViewTextBoxColumn
        '
        Me.QuotenoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QuotenoDataGridViewTextBoxColumn.DataPropertyName = "quote_no"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotenoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.QuotenoDataGridViewTextBoxColumn.HeaderText = "QUOTE NO"
        Me.QuotenoDataGridViewTextBoxColumn.Name = "QuotenoDataGridViewTextBoxColumn"
        Me.QuotenoDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuotenoDataGridViewTextBoxColumn.Width = 89
        '
        'QuotesufDataGridViewTextBoxColumn
        '
        Me.QuotesufDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuotesufDataGridViewTextBoxColumn.DataPropertyName = "quote_suf"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotesufDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.QuotesufDataGridViewTextBoxColumn.HeaderText = "SUFFIX"
        Me.QuotesufDataGridViewTextBoxColumn.Name = "QuotesufDataGridViewTextBoxColumn"
        Me.QuotesufDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QdateDataGridViewTextBoxColumn
        '
        Me.QdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QdateDataGridViewTextBoxColumn.DataPropertyName = "qdate"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.QdateDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.QdateDataGridViewTextBoxColumn.Name = "QdateDataGridViewTextBoxColumn"
        Me.QdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QheaderDataGridViewTextBoxColumn
        '
        Me.QheaderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QheaderDataGridViewTextBoxColumn.DataPropertyName = "qheader"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QheaderDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.QheaderDataGridViewTextBoxColumn.HeaderText = "QUOTE HEADER"
        Me.QheaderDataGridViewTextBoxColumn.Name = "QheaderDataGridViewTextBoxColumn"
        Me.QheaderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QwhoDataGridViewTextBoxColumn
        '
        Me.QwhoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QwhoDataGridViewTextBoxColumn.DataPropertyName = "qwho"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QwhoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.QwhoDataGridViewTextBoxColumn.HeaderText = "WHO"
        Me.QwhoDataGridViewTextBoxColumn.Name = "QwhoDataGridViewTextBoxColumn"
        Me.QwhoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Qmemo1DataGridViewTextBoxColumn
        '
        Me.Qmemo1DataGridViewTextBoxColumn.DataPropertyName = "qmemo1"
        Me.Qmemo1DataGridViewTextBoxColumn.HeaderText = "qmemo1"
        Me.Qmemo1DataGridViewTextBoxColumn.Name = "Qmemo1DataGridViewTextBoxColumn"
        Me.Qmemo1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Qmemo1DataGridViewTextBoxColumn.Visible = False
        Me.Qmemo1DataGridViewTextBoxColumn.Width = 72
        '
        'Qmemo2DataGridViewTextBoxColumn
        '
        Me.Qmemo2DataGridViewTextBoxColumn.DataPropertyName = "qmemo2"
        Me.Qmemo2DataGridViewTextBoxColumn.HeaderText = "qmemo2"
        Me.Qmemo2DataGridViewTextBoxColumn.Name = "Qmemo2DataGridViewTextBoxColumn"
        Me.Qmemo2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Qmemo2DataGridViewTextBoxColumn.Visible = False
        Me.Qmemo2DataGridViewTextBoxColumn.Width = 72
        '
        'Qmemo3DataGridViewTextBoxColumn
        '
        Me.Qmemo3DataGridViewTextBoxColumn.DataPropertyName = "qmemo3"
        Me.Qmemo3DataGridViewTextBoxColumn.HeaderText = "qmemo3"
        Me.Qmemo3DataGridViewTextBoxColumn.Name = "Qmemo3DataGridViewTextBoxColumn"
        Me.Qmemo3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Qmemo3DataGridViewTextBoxColumn.Visible = False
        Me.Qmemo3DataGridViewTextBoxColumn.Width = 72
        '
        'Qmemo4DataGridViewTextBoxColumn
        '
        Me.Qmemo4DataGridViewTextBoxColumn.DataPropertyName = "qmemo4"
        Me.Qmemo4DataGridViewTextBoxColumn.HeaderText = "qmemo4"
        Me.Qmemo4DataGridViewTextBoxColumn.Name = "Qmemo4DataGridViewTextBoxColumn"
        Me.Qmemo4DataGridViewTextBoxColumn.ReadOnly = True
        Me.Qmemo4DataGridViewTextBoxColumn.Visible = False
        Me.Qmemo4DataGridViewTextBoxColumn.Width = 72
        '
        'QdiscDataGridViewCheckBoxColumn
        '
        Me.QdiscDataGridViewCheckBoxColumn.DataPropertyName = "qdisc"
        Me.QdiscDataGridViewCheckBoxColumn.HeaderText = "qdisc"
        Me.QdiscDataGridViewCheckBoxColumn.Name = "QdiscDataGridViewCheckBoxColumn"
        Me.QdiscDataGridViewCheckBoxColumn.ReadOnly = True
        Me.QdiscDataGridViewCheckBoxColumn.Visible = False
        Me.QdiscDataGridViewCheckBoxColumn.Width = 38
        '
        'QinitsDataGridViewTextBoxColumn
        '
        Me.QinitsDataGridViewTextBoxColumn.DataPropertyName = "qinits"
        Me.QinitsDataGridViewTextBoxColumn.HeaderText = "qinits"
        Me.QinitsDataGridViewTextBoxColumn.Name = "QinitsDataGridViewTextBoxColumn"
        Me.QinitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.QinitsDataGridViewTextBoxColumn.Visible = False
        Me.QinitsDataGridViewTextBoxColumn.Width = 56
        '
        'TimestampcolumnDataGridViewImageColumn
        '
        Me.TimestampcolumnDataGridViewImageColumn.DataPropertyName = "timestamp_column"
        Me.TimestampcolumnDataGridViewImageColumn.HeaderText = "timestamp_column"
        Me.TimestampcolumnDataGridViewImageColumn.Name = "TimestampcolumnDataGridViewImageColumn"
        Me.TimestampcolumnDataGridViewImageColumn.ReadOnly = True
        Me.TimestampcolumnDataGridViewImageColumn.Visible = False
        '
        'quotelist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 456)
        Me.Controls.Add(Me.accountno)
        Me.Controls.Add(Me.quotenotextbox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.delqut_but)
        Me.Controls.Add(Me.editqu_but)
        Me.Controls.Add(Me.abort_but)
        Me.Name = "quotelist"
        Me.Text = "Quotelist"
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteheadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteheadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents abort_but As Button
    Friend WithEvents editqu_but As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TransvacDataV2DataSet1BindingSource As BindingSource
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents QuoteheadBindingSource As BindingSource
    Friend WithEvents QuoteheadTableAdapter As TransvacDataV2DataSet1TableAdapters.quoteheadTableAdapter
    Friend WithEvents delqut_but As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents quotenotextbox As TextBox
    Friend WithEvents CustdiscTableAdapter1 As TransvacDataV2DataSet1TableAdapters.custdiscTableAdapter
    Friend WithEvents accountno As TextBox
    Friend WithEvents QuoteheadBindingSource1 As BindingSource
    Friend WithEvents QuotenoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuotesufDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QheaderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QwhoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Qmemo1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Qmemo2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Qmemo3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Qmemo4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QdiscDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents QinitsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimestampcolumnDataGridViewImageColumn As DataGridViewImageColumn
End Class
