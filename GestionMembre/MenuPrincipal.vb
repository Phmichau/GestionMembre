Public Class MenuPrincipal
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub ListeDesMembresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesMembresToolStripMenuItem.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        frmListeMembre.MdiParent = Me
        frmListeMembre.WindowState = System.Windows.Forms.FormWindowState.Maximized
        frmListeMembre.Show()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class
