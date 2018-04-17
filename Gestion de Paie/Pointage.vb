Public Class Pointage
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Remplir DGV_Pointage--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Sub Remplir_Dgv()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("Select p.Date_P,P.Heure_E,p.Heure_S,s.Matricule_Salarie,s.Nom,s.Prenom from Pointage p , Salarie s where p.ID_SAL = s.ID_SAL and  Date_P = '" & DTP_Pointage.Text & "'", conn)
        da.Fill(ds, "Tab")
        DGV_Pointage.DataSource = ds.Tables("Tab")
    End Sub
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Remplir CBO_ID_SALARIE--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Sub remplir_Cbo_Pointage()
        Dim rsql As String = "select * from Salarie"
        cmd = New SqlCommand(rsql, conn)
        dr = cmd.ExecuteReader
        CBO_IDSAL.Items.Clear()
        While dr.Read
            CBO_IDSAL.Items.Add(dr(1))
        End While
        cmd.Dispose()
        dr.Close()
    End Sub
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Procedure Ajouter--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Function ID_SALARIE(ByVal Matricule_Salarie As String) As Integer
        Dim rsql2 As String
        Dim cmd2 As SqlCommand
        Dim dr2 As SqlDataReader
        rsql2 = "Select ID_SAL from Salarie where Matricule_Salarie=@Matricule_Salarie"
        cmd2 = New SqlCommand(rsql2, conn)
        cmd2.Parameters.AddWithValue("@Matricule_Salarie", Matricule_Salarie)
        dr2 = cmd2.ExecuteReader
        If dr2.Read = False Then
            dr2.Close()
            cmd2.Dispose()
            Return 0
        End If
        Dim ID As Integer = dr2(0)
        cmd2.Dispose()
        dr2.Close()
        Return ID
    End Function
    Sub Ajouter_Pointage(ByVal ID_SAL As Integer, ByVal Date_P As Date, ByVal Heure_E As String, ByVal Heure_S As String, ByVal Periode As String)
        Dim rsql As String = "insert into Pointage(Date_P,Heure_E,Heure_S,Periode,ID_SAL) values(@Date_P,@Heure_E,@Heure_S,@Periode,@ID_SAL)"
        cmd = New SqlCommand(rsql, conn)
        With cmd.Parameters
            .AddWithValue("@ID_SAL", ID_SAL)
            .AddWithValue("@Date_P", DTP_Pointage.Text)
            .AddWithValue("@Heure_E", MSK_HE.Text)
            .AddWithValue("@Heure_S", MSK_HS.Text)
            .AddWithValue("@Periode", CBO_Période.Text)
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        CBO_IDSAL.Text = ""
        DTP_Pointage.Text = ""
        MSK_HE.Clear()
        MSK_HS.Clear()
        CBO_Période.Text = ""
    End Sub
    'Sub Ajout_Pointage(ByVal ID_Pointage As String, ByVal Date_P As Date, ByVal Heure_E As String, ByVal Heure_S As String, ByVal Periode As String)

    'End Sub
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Button Ajouter--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Private Sub BT_Ajouter_Click(sender As Object, e As EventArgs) Handles BT_Ajouter.Click
        Ajouter_Pointage(ID_SALARIE(CBO_IDSAL.Text), DTP_Pointage.Text, MSK_HE.Text, MSK_HS.Text, CBO_Période.Text)
    End Sub
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Procedure Modifier--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    '§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§--Remplir Les Champs--§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§
    Private Sub DGV_Pointage_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Pointage.CellDoubleClick
        CBO_IDSAL.Text = DGV_Pointage.Item(0, DGV_Pointage.CurrentRow.Index).Value
        DTP_Pointage.Value = DGV_Pointage.Item(1, DGV_Pointage.CurrentRow.Index).Value
        MSK_HE.Text = DGV_Pointage.Item(2, DGV_Pointage.CurrentRow.Index).Value
        MSK_HS.Text = DGV_Pointage.Item(3, DGV_Pointage.CurrentRow.Index).Value
        CBO_Période.Text = DGV_Pointage.Item(4, DGV_Pointage.CurrentRow.Index).Value
    End Sub
    Private Sub Pointage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = F_MP
        'MessageBox.Show("")
        remplir_Cbo_Pointage()
        Remplir_Dgv()
    End Sub
    Function ConvertToEnglish(mydate As Date) As String
        Dim day As String = mydate.Day.ToString
        Dim Month As String = mydate.Month.ToString
        Dim Year As String = mydate.Year.ToString
        Return Month + "/" + day + "/" + Year
    End Function
    Private Sub DTP_Pointage_ValueChanged(sender As Object, e As EventArgs) Handles DTP_Pointage.ValueChanged
        Remplir_Dgv()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class