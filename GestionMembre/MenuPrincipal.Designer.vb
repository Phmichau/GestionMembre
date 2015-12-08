<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesMembresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvoiDeCourrielToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÀProposDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.MembresToolStripMenuItem, Me.ImpressionToolStripMenuItem, Me.EnvoiDeCourrielToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'MembresToolStripMenuItem
        '
        Me.MembresToolStripMenuItem.Name = "MembresToolStripMenuItem"
        Me.MembresToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MembresToolStripMenuItem.Text = "Membres"
        '
        'ImpressionToolStripMenuItem
        '
        Me.ImpressionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesMembresToolStripMenuItem})
        Me.ImpressionToolStripMenuItem.Name = "ImpressionToolStripMenuItem"
        Me.ImpressionToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ImpressionToolStripMenuItem.Text = "Impression"
        '
        'ListeDesMembresToolStripMenuItem
        '
        Me.ListeDesMembresToolStripMenuItem.Name = "ListeDesMembresToolStripMenuItem"
        Me.ListeDesMembresToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ListeDesMembresToolStripMenuItem.Text = "Liste des membres"
        '
        'EnvoiDeCourrielToolStripMenuItem
        '
        Me.EnvoiDeCourrielToolStripMenuItem.Name = "EnvoiDeCourrielToolStripMenuItem"
        Me.EnvoiDeCourrielToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.EnvoiDeCourrielToolStripMenuItem.Text = "Envoi de courriel"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÀProposDeToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'ÀProposDeToolStripMenuItem
        '
        Me.ÀProposDeToolStripMenuItem.Name = "ÀProposDeToolStripMenuItem"
        Me.ÀProposDeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ÀProposDeToolStripMenuItem.Text = "À propos de ..."
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.Text = "Planète Fitness Gym - Gestion des Membres"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpressionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesMembresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvoiDeCourrielToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÀProposDeToolStripMenuItem As ToolStripMenuItem
End Class
