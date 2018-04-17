Public Class F_MP
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub OuvrirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem1.Click
        Dim Pointage As New Pointage
        Pointage.Show()
    End Sub
    Private Sub OuvrirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem2.Click
        Dim BP As New Bultain_de_Paie
        BP.Show()
    End Sub
    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        Dim Salarié As New Salarié
        Salarié.Show()
    End Sub
    Private Sub F_MP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        conn = New SqlConnection("Data Source=.;Initial Catalog= GestionPaie;Integrated Security=True")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SeConnecterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeConnecterToolStripMenuItem.Click
        Dim Connxion As New Se_Connecter
        Connxion.Show()
        Me.Close()
    End Sub
    Private Sub AideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AideToolStripMenuItem.Click
        Dim aide As New Aide
        aide.Show()
    End Sub
    Private Sub MonCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonCompteToolStripMenuItem.Click
        Dim Compte As New Mon_Compte
        Compte.Show()
    End Sub
End Class