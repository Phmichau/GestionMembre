﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsMembres = New GestionMembre.dsMembres()
        Me.MembresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembresTableAdapter = New GestionMembre.dsMembresTableAdapters.MembresTableAdapter()
        CType(Me.dsMembres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Top
        ReportDataSource1.Name = "datasetMembres"
        ReportDataSource1.Value = Me.MembresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GestionMembre.rptListeMembre.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'dsMembres
        '
        Me.dsMembres.DataSetName = "dsMembres"
        Me.dsMembres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembresBindingSource
        '
        Me.MembresBindingSource.DataMember = "Membres"
        Me.MembresBindingSource.DataSource = Me.dsMembres
        '
        'MembresTableAdapter
        '
        Me.MembresTableAdapter.ClearBeforeFill = True
        '
        'frmListeMembre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmListeMembre"
        Me.Text = "Liste des membres"
        CType(Me.dsMembres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MembresBindingSource As BindingSource
    Friend WithEvents dsMembres As dsMembres
    Friend WithEvents MembresTableAdapter As dsMembresTableAdapters.MembresTableAdapter
End Class
