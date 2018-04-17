Public Class Bultain_de_Paie
    '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ Remplir CBO_SAlarié $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    Sub Remplir_Cbo_Salarié()
        Dim rsql As String = "select * from Salarie"
        cmd = New SqlCommand(rsql, conn)
        dr = cmd.ExecuteReader
        CBO_Matricule.Items.Clear()
        While dr.Read
            CBO_Matricule.Items.Add(dr(1))
        End While
        cmd.Dispose()
        dr.Close()
    End Sub
    '$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ Remplir Champs_Salarié $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
    Sub Remplir_Champs_Salarié()
        Dim rsql As String = "Select* from Salarie where Matricule_Salarie='" & CBO_Matricule.Text & "'"
        cmd = New SqlCommand(rsql, conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            TXT_NOM.Text = dr(2)
            TXT_Prénom.Text = dr(3)
            TXT_Fonction.Text = dr(4)
        End If
        cmd.Dispose()
        dr.Close()
    End Sub
    Private Sub Bultain_de_Paie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir_Cbo_Salarié()
    End Sub
    Private Sub CBO_Matricule_TextChanged(sender As Object, e As EventArgs) Handles CBO_Matricule.TextChanged
        Remplir_Champs_Salarié()
    End Sub

    Private Sub BT_Enreg_Click(sender As Object, e As EventArgs) Handles BT_Enreg.Click

    End Sub
    Sub Remplir_Dgv()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("Select p.Date_P,P.Heure_E,p.Heure_S,s.Matricule_Salarie,s.Nom,s.Prenom from Pointage p , Salarie s where p.ID_SAL = s.ID_SAL and  s.Matricule_Salarie = '" & CBO_Matricule.Text & "'  ", conn)
        da.Fill(ds, "Tab")
        DGV_Pointage.DataSource = ds.Tables("Tab")
        
    End Sub
    Private Sub CBO_Matricule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_Matricule.SelectedIndexChanged
        Remplir_Dgv()
    End Sub
End Class