Public Class Mon_Compte
    Dim Settings As New My.MySettings
    Private Sub BT_Modifier_Click(sender As Object, e As EventArgs) Handles BT_Modifier.Click
        If My.Settings.username = TXT_Login.Text And My.Settings.password = TXT_MP.Text Then
            If TXT_NMP.Text = TXT_RNMP.Text Then
                My.Settings.Password = TXT_NMP.Text
                My.Settings.Save()
                Else
                    MsgBox("Le mot de passe ne correspondent pas", MsgBoxStyle.Critical)
            End If
            ElseIf TXT_Login.Text = "" Or TXT_MP.Text = "" Then
                MsgBox("Veiller saisir votre nom d'utilisateur et votre mot de passe", MsgBoxStyle.Exclamation)
                TXT_MP.Clear()
                TXT_Login.Clear()
            Else
                MsgBox("Le mot de passe ou le nom d'utilisateur sont incorrect",MsgBoxStyle.Critical)
        End If
    End Sub
End Class