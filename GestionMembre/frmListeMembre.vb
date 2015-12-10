Public Class frmListeMembre
    Private Sub frmListeMembre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsMembres.Membres' table. You can move, or remove it, as needed.
        Me.MembresTableAdapter.Fill(Me.dsMembres.Membres)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class