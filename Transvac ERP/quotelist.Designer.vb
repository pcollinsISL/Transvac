﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.abort_but = New System.Windows.Forms.Button()
        Me.editqu_but = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.TransvacDataV2DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuoteheadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuoteheadTableAdapter = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.quoteheadTableAdapter()
        Me.newqu_but = New System.Windows.Forms.Button()
        Me.delqut_but = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteheadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'abort_but
        '
        Me.abort_but.Location = New System.Drawing.Point(29, 358)
        Me.abort_but.Name = "abort_but"
        Me.abort_but.Size = New System.Drawing.Size(95, 38)
        Me.abort_but.TabIndex = 0
        Me.abort_but.Text = "ABORT"
        Me.abort_but.UseVisualStyleBackColor = True
        '
        'editqu_but
        '
        Me.editqu_but.Location = New System.Drawing.Point(493, 358)
        Me.editqu_but.Name = "editqu_but"
        Me.editqu_but.Size = New System.Drawing.Size(94, 38)
        Me.editqu_but.TabIndex = 1
        Me.editqu_but.Text = "EDIT QUOTE"
        Me.editqu_but.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(38, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Quote List"
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
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
        'newqu_but
        '
        Me.newqu_but.Location = New System.Drawing.Point(617, 358)
        Me.newqu_but.Name = "newqu_but"
        Me.newqu_but.Size = New System.Drawing.Size(94, 38)
        Me.newqu_but.TabIndex = 2
        Me.newqu_but.Text = "NEW QUOTE"
        Me.newqu_but.UseVisualStyleBackColor = True
        '
        'delqut_but
        '
        Me.delqut_but.Location = New System.Drawing.Point(150, 358)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QuotenoDataGridViewTextBoxColumn, Me.QuotesufDataGridViewTextBoxColumn, Me.QdateDataGridViewTextBoxColumn, Me.QheaderDataGridViewTextBoxColumn, Me.QwhoDataGridViewTextBoxColumn, Me.Qmemo1DataGridViewTextBoxColumn, Me.Qmemo2DataGridViewTextBoxColumn, Me.Qmemo3DataGridViewTextBoxColumn, Me.Qmemo4DataGridViewTextBoxColumn, Me.QdiscDataGridViewCheckBoxColumn, Me.QinitsDataGridViewTextBoxColumn, Me.TimestampcolumnDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.QuoteheadBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(29, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(682, 267)
        Me.DataGridView1.TabIndex = 11
        '
        'QuotenoDataGridViewTextBoxColumn
        '
        Me.QuotenoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.QuotenoDataGridViewTextBoxColumn.DataPropertyName = "quote_no"
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotenoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.QuotenoDataGridViewTextBoxColumn.HeaderText = "QUOTE NO"
        Me.QuotenoDataGridViewTextBoxColumn.Name = "QuotenoDataGridViewTextBoxColumn"
        Me.QuotenoDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuotenoDataGridViewTextBoxColumn.Width = 89
        '
        'QuotesufDataGridViewTextBoxColumn
        '
        Me.QuotesufDataGridViewTextBoxColumn.DataPropertyName = "quote_suf"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotesufDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.QuotesufDataGridViewTextBoxColumn.HeaderText = "SUFFIX"
        Me.QuotesufDataGridViewTextBoxColumn.Name = "QuotesufDataGridViewTextBoxColumn"
        Me.QuotesufDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuotesufDataGridViewTextBoxColumn.Width = 69
        '
        'QdateDataGridViewTextBoxColumn
        '
        Me.QdateDataGridViewTextBoxColumn.DataPropertyName = "qdate"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.QdateDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.QdateDataGridViewTextBoxColumn.Name = "QdateDataGridViewTextBoxColumn"
        Me.QdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.QdateDataGridViewTextBoxColumn.Width = 61
        '
        'QheaderDataGridViewTextBoxColumn
        '
        Me.QheaderDataGridViewTextBoxColumn.DataPropertyName = "qheader"
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QheaderDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.QheaderDataGridViewTextBoxColumn.HeaderText = "QUOTE HEADER"
        Me.QheaderDataGridViewTextBoxColumn.Name = "QheaderDataGridViewTextBoxColumn"
        Me.QheaderDataGridViewTextBoxColumn.ReadOnly = True
        Me.QheaderDataGridViewTextBoxColumn.Width = 118
        '
        'QwhoDataGridViewTextBoxColumn
        '
        Me.QwhoDataGridViewTextBoxColumn.DataPropertyName = "qwho"
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QwhoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.QwhoDataGridViewTextBoxColumn.HeaderText = "WHO"
        Me.QwhoDataGridViewTextBoxColumn.Name = "QwhoDataGridViewTextBoxColumn"
        Me.QwhoDataGridViewTextBoxColumn.ReadOnly = True
        Me.QwhoDataGridViewTextBoxColumn.Width = 59
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
        Me.ClientSize = New System.Drawing.Size(746, 416)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.delqut_but)
        Me.Controls.Add(Me.newqu_but)
        Me.Controls.Add(Me.editqu_but)
        Me.Controls.Add(Me.abort_but)
        Me.Name = "quotelist"
        Me.Text = "Quotelist"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteheadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents abort_but As Button
    Friend WithEvents editqu_but As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TransvacDataV2DataSet1BindingSource As BindingSource
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents QuoteheadBindingSource As BindingSource
    Friend WithEvents QuoteheadTableAdapter As TransvacDataV2DataSet1TableAdapters.quoteheadTableAdapter
    Friend WithEvents newqu_but As Button
    Friend WithEvents delqut_but As Button
    Friend WithEvents DataGridView1 As DataGridView
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