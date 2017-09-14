<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuotationRPT
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
        Me.TableAdapterManager1 = New Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager()
        Me.SuspendLayout()
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.accctlTableAdapter = Nothing
        Me.TableAdapterManager1.accountTableAdapter = Nothing
        Me.TableAdapterManager1.addnotesTableAdapter = Nothing
        Me.TableAdapterManager1.ASSETSNEWTableAdapter = Nothing
        Me.TableAdapterManager1.assetsTableAdapter = Nothing
        Me.TableAdapterManager1.atransTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.binallocTableAdapter = Nothing
        Me.TableAdapterManager1.catTableAdapter = Nothing
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.countryTableAdapter = Nothing
        Me.TableAdapterManager1.custdiscTableAdapter = Nothing
        Me.TableAdapterManager1.dummy_TableAdapter = Nothing
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
        Me.TableAdapterManager1.trandescTableAdapter = Nothing
        Me.TableAdapterManager1.tranmemoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Transvac_ERP.TransvacDataV2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QuotationRPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 361)
        Me.Name = "QuotationRPT"
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableAdapterManager1 As TransvacDataV2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
