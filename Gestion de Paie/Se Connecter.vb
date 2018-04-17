Public Class Se_Connecter
    Private Sub BT_connxion(sender As Object, e As EventArgs) Handles BT_Connexion.Click
        Dim MP As New F_MP
        Me.Hide()
        If TXT_LOGIN.Text = "PAY" And TXT_MP.Text = "SAVE" Then
            TXT_MP.Clear()
            TXT_LOGIN.Clear()
            MP.Show()
            Me.Hide()
        ElseIf TXT_LOGIN.Text = "" Or TXT_MP.Text = "" Then
            MsgBox("Veiller saisir votre nom d'utilisateur et votre mot de passe", MsgBoxStyle.Exclamation)
            TXT_MP.Clear()
            TXT_LOGIN.Clear()
            Dim seconncter As New Se_Connecter
            seconncter.Show()
        Else
            Dim seconncter As New Se_Connecter
            TXT_LOGIN.Text = ""
            MsgBox("Votre nom d'utilisateur ou votre mot de passe sont incorrecte", MsgBoxStyle.Critical)
            TXT_MP.Clear()
            TXT_LOGIN.Clear()
            seconncter.Show()
        End If
    End Sub
    Private Sub LK_Aide_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LK_Aide.LinkClicked
        Dim Aide As New Aide
        Aide.Show()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TXT_MP.PasswordChar = "*"
        Else
            TXT_MP.PasswordChar = ""
        End If
    End Sub
End Class