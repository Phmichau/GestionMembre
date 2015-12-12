<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeMembre
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MembresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsMembres = New GestionMembre.dsMembres()
        Me.rpvListeMembre = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MembresTableAdapter = New GestionMembre.dsMembresTableAdapters.MembresTableAdapter()
        CType(Me.MembresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsMembres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MembresBindingSource
        '
        Me.MembresBindingSource.DataMember = "Membres"
        Me.MembresBindingSource.DataSource = Me.dsMembres
        '
        'dsMembres
        '
        Me.dsMembres.DataSetName = "dsMembres"
        Me.dsMembres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpvListeMembre
        '
        Me.rpvListeMembre.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "datasetMembres"
        ReportDataSource1.Value = Me.MembresBindingSource
        Me.rpvListeMembre.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvListeMembre.LocalReport.ReportEmbeddedResource = "GestionMembre.rptListeMembre.rdlc"
        Me.rpvListeMembre.Location = New System.Drawing.Point(0, 0)
        Me.rpvListeMembre.Name = "rpvListeMembre"
        Me.rpvListeMembre.Size = New System.Drawing.Size(856, 461)
        Me.rpvListeMembre.TabIndex = 0
        '
        'MembresTableAdapter
        '
        Me.MembresTableAdapter.ClearBeforeFill = True
        '
        'frmListeMembre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 461)
        Me.Controls.Add(Me.rpvListeMembre)
        Me.Name = "frmListeMembre"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des membres"
        CType(Me.MembresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsMembres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpvListeMembre As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MembresBindingSource As BindingSource
    Friend WithEvents dsMembres As dsMembres
    Friend WithEvents MembresTableAdapter As dsMembresTableAdapters.MembresTableAdapter
End Class
