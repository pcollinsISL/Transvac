<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quotefdesc
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
        Me.Button2_but = New System.Windows.Forms.Button()
        Me.acctextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransvacDataV2DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransvacDataV2DataSet1 = New Transvac_ERP.TransvacDataV2DataSet1()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.acctabt_but = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TrandescBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrandescTableAdapter1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.trandescTableAdapter()
        Me.PcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PsupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TransvacDataV2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrandescBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2_but
        '
        Me.Button2_but.Location = New System.Drawing.Point(524, 97)
        Me.Button2_but.Name = "Button2_but"
        Me.Button2_but.Size = New System.Drawing.Size(75, 36)
        Me.Button2_but.TabIndex = 6
        Me.Button2_but.Text = "SEARCH"
        Me.Button2_but.UseVisualStyleBackColor = True
        '
        'acctextBox
        '
        Me.acctextBox.Location = New System.Drawing.Point(174, 100)
        Me.acctextBox.Name = "acctextBox"
        Me.acctextBox.Size = New System.Drawing.Size(286, 20)
        Me.acctextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Description"
        '
        'TransvacDataV2DataSet1BindingSource
        '
        Me.TransvacDataV2DataSet1BindingSource.DataSource = Me.TransvacDataV2DataSet1
        Me.TransvacDataV2DataSet1BindingSource.Position = 0
        '
        'TransvacDataV2DataSet1
        '
        Me.TransvacDataV2DataSet1.DataSetName = "TransvacDataV2DataSet1"
        Me.TransvacDataV2DataSet1.EnforceConstraints = False
        Me.TransvacDataV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transvac_ERP.My.Resources.Resources.new_transvac_logo_Environmental
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(524, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "SELECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'acctabt_but
        '
        Me.acctabt_but.Location = New System.Drawing.Point(63, 442)
        Me.acctabt_but.Name = "acctabt_but"
        Me.acctabt_but.Size = New System.Drawing.Size(75, 34)
        Me.acctabt_but.TabIndex = 11
        Me.acctabt_but.Text = "ABORT"
        Me.acctabt_but.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PcodeDataGridViewTextBoxColumn, Me.PsupplierDataGridViewTextBoxColumn, Me.DescriptnDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrandescBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(63, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(536, 287)
        Me.DataGridView1.TabIndex = 13
        '
        'TrandescBindingSource
        '
        Me.TrandescBindingSource.DataMember = "trandesc"
        Me.TrandescBindingSource.DataSource = Me.TransvacDataV2DataSet1BindingSource
        '
        'TrandescTableAdapter1
        '
        Me.TrandescTableAdapter1.ClearBeforeFill = True
        '
        'PcodeDataGridViewTextBoxColumn
        '
        Me.PcodeDataGridViewTextBoxColumn.DataPropertyName = "pcode"
        Me.PcodeDataGridViewTextBoxColumn.HeaderText = "Part Number"
        Me.PcodeDataGridViewTextBoxColumn.Name = "PcodeDataGridViewTextBoxColumn"
        Me.PcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PcodeDataGridViewTextBoxColumn.Width = 150
        '
        'PsupplierDataGridViewTextBoxColumn
        '
        Me.PsupplierDataGridViewTextBoxColumn.DataPropertyName = "psupplier"
        Me.PsupplierDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.PsupplierDataGridViewTextBoxColumn.Name = "PsupplierDataGridViewTextBoxColumn"
        Me.PsupplierDataGridViewTextBoxColumn.ReadOnly = True
        Me.PsupplierDataGridViewTextBoxColumn.Width = 150
        '
        'DescriptnDataGridViewTextBoxColumn
        '
        Me.DescriptnDataGridViewTextBoxColumn.DataPropertyName = "descriptn"
        Me.DescriptnDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptnDataGridViewTextBoxColumn.Name = "DescriptnDataGridViewTextBoxColumn"
        Me.DescriptnDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptnDataGridViewTextBoxColumn.Width = 290
        '
        'Quotefdesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(646, 502)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.acctabt_but)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2_but)
        Me.Controls.Add(Me.acctextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Quotefdesc"
        Me.Text = "Quote Find Description"
        CType(Me.TransvacDataV2DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransvacDataV2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrandescBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2_but As Button
    Friend WithEvents acctextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TransvacDataV2DataSet1BindingSource As BindingSource
    Friend WithEvents TransvacDataV2DataSet1 As TransvacDataV2DataSet1
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents acctabt_but As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TrandescBindingSource As BindingSource
    Friend WithEvents TrandescTableAdapter1 As TransvacDataV2DataSet1TableAdapters.trandescTableAdapter
    Friend WithEvents PcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PsupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
