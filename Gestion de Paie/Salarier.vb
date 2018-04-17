Public Class Salarié
    
    Sub Ajout_Salarié1(ByVal Matricule_Salarie As String, ByVal Nom As String, ByVal Prenom As String, ByVal Fonction As String, ByVal Adresse As String, ByVal Tel As String, ByVal Date_Embauche As Date, ByVal Date_Naissance As Date, ByVal Nbre_Enfant As Single, ByVal Situation_Familiale As String, ByVal Type_Contrat As String, ByVal Taux_Horaire As Single)
        Dim rsql As String = "insert into Salarie(Matricule_Salarie,Nom,Prenom,Fonction,Adresse,Tel,Date_Embauche,Date_Naissance,Nbre_Enfant,Situation_Familiale,Type_Contrat,Taux_Horaire) values (@Matricule_Salarie,@Nom,@Prenom,@Fonction,@Adresse,@Tel,@Date_Embauche,@Date_Naissance,@Nbre_Enfant,@Situation_Familiale,@Type_Contrat,@Taux_Horaire)"
        cmd = New SqlCommand(rsql, conn)
        With cmd.Parameters

            .AddWithValue("@Matricule_Salarie", TXT_MAT_Salarié.Text)
            .AddWithValue("@Nom", TXT_Nom.Text)
            .AddWithValue("@Prenom", TXT_Prénom.Text)
            .AddWithValue("@Fonction", TXT_Fonction.Text)
            .AddWithValue("@Adresse", TXT_Adresse.Text)
            .AddWithValue("@Tel", MSK_Tél.Text)
            .AddWithValue("@Date_Embauche", ConvertToEnglish(CDate(DTP_DE.Value)))
            .AddWithValue("@Date_Naissance", ConvertToEnglish(CDate(DTP_DN.Value)))
            .AddWithValue("@Nbre_Enfant", TXT_Nbrenfant.Text)
            .AddWithValue("@Situation_Familiale", CBO_SF.Text)
            .AddWithValue("@Type_Contrat", CBO_TC.Text)
            .AddWithValue("@Taux_Horaire", TXT_TH.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
        End Try
        TXT_MAT_Salarié.Clear()
        TXT_Nom.Clear()
        TXT_Prénom.Clear()
        TXT_Fonction.Clear()
        TXT_Adresse.Clear()
        TXT_Nbrenfant.Clear()
        MSK_Tél.Clear()
        TXT_TH.Clear()
        DTP_DE.Text = ""
        DTP_DN.Text = ""
        CBO_SF.Text = ""
        CBO_TC.Text = ""
    End Sub
    Function ConvertToEnglish(mydate As Date) As String
        Dim day As String = mydate.Day.ToString
        Dim Month As String = mydate.Month.ToString
        Dim Year As String = mydate.Year.ToString
        Return Month + "/" + day + "/" + Year
    End Function
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Button Ajouter--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click
        'Ajouté_Salarié(TXT_MAT_Salarié.Text, TXT_Nom.Text, TXT_Prénom.Text, TXT_Fonction.Text, TXT_Adresse.Text, MSK_Tél.Text, DTP_DE.Text, DTP_DN.Text, TXT_Nbrenfant.Text, CBO_SF.Text, CBO_TC.Text, TXT_TH.Text)
        Ajout_Salarié1(TXT_MAT_Salarié.Text, TXT_Nom.Text, TXT_Prénom.Text, TXT_Fonction.Text, TXT_Adresse.Text, MSK_Tél.Text, DTP_DE.Text, DTP_DN.Text, TXT_Nbrenfant.Text, CBO_SF.Text, CBO_TC.Text, TXT_TH.Text)
        remplir_dgvsalarie()
    End Sub
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Button Modifier--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Private Sub BT_Modifier_Click(sender As Object, e As EventArgs) Handles BT_Modifier.Click
        Dim rsql As String = "update Salarie set Nom=@Nom,Prenom=@Prenom,Fonction=@Fonction,Adresse=@Adresse,Tel=@Tel,Date_Embauche=@Date_Embauche,Date_Naissance=@Date_Naissance,Nbre_Enfant=@Nbre_Enfant,Situation_Familiale=@Situation_Familiale,Type_Contrat=@Type_Contrat,Taux_Horaire=@Taux_Horaire where Matricule_Salarie LIKE @Matricule_Salarie"
        cmd = New SqlCommand(rsql, conn)
        With cmd.Parameters
            .AddWithValue("@Matricule_Salarie", TXT_MAT_Salarié.Text)
            .AddWithValue("@Nom", TXT_Nom.Text)
            .AddWithValue("@Prenom", TXT_Prénom.Text)
            .AddWithValue("@Fonction", TXT_Fonction.Text)
            .AddWithValue("@Tel", MSK_Tél.Text)
            .AddWithValue("@Adresse", TXT_Adresse.Text)
            .AddWithValue("@Date_Embauche", CDate(DTP_DE.Text))
            .AddWithValue("@Date_Naissance", CDate(DTP_DN.Text))
            .AddWithValue("@Nbre_Enfant", TXT_Nbrenfant.Text)
            .AddWithValue("@Situation_Familiale", CBO_SF.Text)
            .AddWithValue("@Type_Contrat", CBO_TC.Text)
            .AddWithValue("@Taux_Horaire", TXT_TH.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
        End Try
        TXT_MAT_Salarié.Clear()
        TXT_Nom.Clear()
        TXT_Prénom.Clear()
        TXT_Fonction.Clear()
        TXT_Adresse.Clear()
        TXT_Nbrenfant.Clear()
        MSK_Tél.Clear()
        TXT_TH.Clear()
        DTP_DE.Text = ""
        DTP_DN.Text = ""
        CBO_SF.Text = ""
        CBO_TC.Text = ""
        remplir_dgvsalarie()
    End Sub
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Remplir DGV_Salarie--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Function existSalari() As Boolean
        Dim Rsql As String = "select * from Salarie where Matricule_Salarie = '" & TXT_MAT_Salarié.Text & "'"
        cmd = New SqlCommand(Rsql, conn)
        dr = cmd.ExecuteReader

        While dr.Read
            cmd.Dispose()
            dr.Close()
            Return True
        End While
        cmd.Dispose()
        dr.Close()
        Return False
    End Function
    Sub remplir_dgvsalarie()
        Dim Rsql As String = "select * from Salarie"
        cmd = New SqlCommand(Rsql, conn)
        dr = cmd.ExecuteReader
        DGV_Salarié.Rows.Clear()
        While dr.Read
            DGV_Salarié.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12))
        End While
        cmd.Dispose()
        dr.Close()
    End Sub
    'Sub ID()
    '    Dim rsql As String = "select ID_SAL from Salarie"
    '    cmd = New SqlCommand(rsql, conn)
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        Label13.Text = dr(0)
    '    End While
    '    cmd.Dispose()
    '    dr.Close()
    'End Sub
    Private Sub Salarié_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplir_dgvsalarie()

    End Sub
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Remplir Les Champs--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Private Sub DGV_Salarié_DoubleClick(sender As Object, e As EventArgs) Handles DGV_Salarié.DoubleClick
        TXT_MAT_Salarié.Text = DGV_Salarié.Item(1, DGV_Salarié.CurrentRow.Index).Value
        TXT_Nom.Text = DGV_Salarié.Item(2, DGV_Salarié.CurrentRow.Index).Value
        TXT_Prénom.Text = DGV_Salarié.Item(3, DGV_Salarié.CurrentRow.Index).Value
        TXT_Fonction.Text = DGV_Salarié.Item(4, DGV_Salarié.CurrentRow.Index).Value
        TXT_Adresse.Text = DGV_Salarié.Item(5, DGV_Salarié.CurrentRow.Index).Value
        MSK_Tél.Text = DGV_Salarié.Item(6, DGV_Salarié.CurrentRow.Index).Value
        DTP_DE.Text = DGV_Salarié.Item(7, DGV_Salarié.CurrentRow.Index).Value
        DTP_DN.Text = DGV_Salarié.Item(8, DGV_Salarié.CurrentRow.Index).Value
        TXT_Nbrenfant.Text = DGV_Salarié.Item(9, DGV_Salarié.CurrentRow.Index).Value
        CBO_SF.Text = DGV_Salarié.Item(10, DGV_Salarié.CurrentRow.Index).Value
        CBO_TC.Text = DGV_Salarié.Item(11, DGV_Salarié.CurrentRow.Index).Value
        TXT_TH.Text = DGV_Salarié.Item(12, DGV_Salarié.CurrentRow.Index).Value
    End Sub
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Button Supprimer--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Private Sub BT_Supprimer_Click(sender As Object, e As EventArgs) Handles BT_Supprimer.Click
        Dim rsql As String = "Delete from Salarie where Matricule_Salarie='" & TXT_MAT_Salarié.Text & "'"
        cmd = New SqlCommand(rsql, conn)
        With cmd.Parameters
            .AddWithValue("@Matricule_Salarie", TXT_MAT_Salarié.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
        End Try
        TXT_MAT_Salarié.Clear()
        TXT_Nom.Clear()
        TXT_Prénom.Clear()
        TXT_Fonction.Clear()
        TXT_Adresse.Clear()
        MSK_Tél.Clear()
        DTP_DE.Text = ""
        DTP_DN.Text = ""
        TXT_Nbrenfant.Clear()
        CBO_SF.Text = ""
        CBO_TC.Text = ""
        TXT_TH.Clear()
        remplir_dgvsalarie()
    End Sub

    Private Sub TXT_MAT_Salarié_TextChanged(sender As Object, e As EventArgs) Handles TXT_MAT_Salarié.TextChanged
        If existSalari() Then
            BT_Ajouter.Enabled = False
            BT_Modifier.Enabled = True
            BT_Supprimer.Enabled = True
        Else
            BT_Ajouter.Enabled = True
            BT_Modifier.Enabled = False
            BT_Supprimer.Enabled = False
        End If
    End Sub
End Class