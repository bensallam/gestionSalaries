<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salarié
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_Supprimer = New System.Windows.Forms.Button()
        Me.BT_Modifier = New System.Windows.Forms.Button()
        Me.BT_Ajouter = New System.Windows.Forms.Button()
        Me.GB_Info = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_ID_SAL = New System.Windows.Forms.TextBox()
        Me.TXT_MAT_Salarié = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_Fonction = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LBL_ID = New System.Windows.Forms.Label()
        Me.DTP_DE = New System.Windows.Forms.DateTimePicker()
        Me.CBO_TC = New System.Windows.Forms.ComboBox()
        Me.CBO_SF = New System.Windows.Forms.ComboBox()
        Me.DTP_DN = New System.Windows.Forms.DateTimePicker()
        Me.MSK_Tél = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_TH = New System.Windows.Forms.TextBox()
        Me.TXT_Prénom = New System.Windows.Forms.TextBox()
        Me.TXT_Nbrenfant = New System.Windows.Forms.TextBox()
        Me.TXT_Adresse = New System.Windows.Forms.TextBox()
        Me.TXT_Nom = New System.Windows.Forms.TextBox()
        Me.DGV_Salarié = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB_Info.SuspendLayout()
        CType(Me.DGV_Salarié, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Adresse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tél"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Date Embauche"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Date Naissance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(380, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nbre Enfant"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Situation Familiale"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(380, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Type Contrat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(380, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Taux Horraire"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GB_Info)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1420, 433)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BT_Supprimer)
        Me.GroupBox1.Controls.Add(Me.BT_Modifier)
        Me.GroupBox1.Controls.Add(Me.BT_Ajouter)
        Me.GroupBox1.Location = New System.Drawing.Point(947, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(175, 171)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'BT_Supprimer
        '
        Me.BT_Supprimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Supprimer.Location = New System.Drawing.Point(8, 117)
        Me.BT_Supprimer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Supprimer.Name = "BT_Supprimer"
        Me.BT_Supprimer.Size = New System.Drawing.Size(161, 44)
        Me.BT_Supprimer.TabIndex = 3
        Me.BT_Supprimer.Text = "Supprimer"
        Me.BT_Supprimer.UseVisualStyleBackColor = True
        '
        'BT_Modifier
        '
        Me.BT_Modifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Modifier.Location = New System.Drawing.Point(7, 64)
        Me.BT_Modifier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Modifier.Name = "BT_Modifier"
        Me.BT_Modifier.Size = New System.Drawing.Size(161, 45)
        Me.BT_Modifier.TabIndex = 3
        Me.BT_Modifier.Text = "Modifer"
        Me.BT_Modifier.UseVisualStyleBackColor = True
        '
        'BT_Ajouter
        '
        Me.BT_Ajouter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_Ajouter.Location = New System.Drawing.Point(7, 14)
        Me.BT_Ajouter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Ajouter.Name = "BT_Ajouter"
        Me.BT_Ajouter.Size = New System.Drawing.Size(161, 44)
        Me.BT_Ajouter.TabIndex = 3
        Me.BT_Ajouter.Text = "Ajouter"
        Me.BT_Ajouter.UseVisualStyleBackColor = True
        '
        'GB_Info
        '
        Me.GB_Info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Info.Controls.Add(Me.Label13)
        Me.GB_Info.Controls.Add(Me.TXT_ID_SAL)
        Me.GB_Info.Controls.Add(Me.TXT_MAT_Salarié)
        Me.GB_Info.Controls.Add(Me.Label12)
        Me.GB_Info.Controls.Add(Me.TXT_Fonction)
        Me.GB_Info.Controls.Add(Me.Label11)
        Me.GB_Info.Controls.Add(Me.LBL_ID)
        Me.GB_Info.Controls.Add(Me.Label5)
        Me.GB_Info.Controls.Add(Me.DTP_DE)
        Me.GB_Info.Controls.Add(Me.Label9)
        Me.GB_Info.Controls.Add(Me.CBO_TC)
        Me.GB_Info.Controls.Add(Me.CBO_SF)
        Me.GB_Info.Controls.Add(Me.Label10)
        Me.GB_Info.Controls.Add(Me.DTP_DN)
        Me.GB_Info.Controls.Add(Me.MSK_Tél)
        Me.GB_Info.Controls.Add(Me.TXT_TH)
        Me.GB_Info.Controls.Add(Me.TXT_Prénom)
        Me.GB_Info.Controls.Add(Me.TXT_Nbrenfant)
        Me.GB_Info.Controls.Add(Me.TXT_Adresse)
        Me.GB_Info.Controls.Add(Me.TXT_Nom)
        Me.GB_Info.Controls.Add(Me.Label4)
        Me.GB_Info.Controls.Add(Me.Label3)
        Me.GB_Info.Controls.Add(Me.Label2)
        Me.GB_Info.Controls.Add(Me.Label8)
        Me.GB_Info.Controls.Add(Me.Label1)
        Me.GB_Info.Controls.Add(Me.Label6)
        Me.GB_Info.Controls.Add(Me.Label7)
        Me.GB_Info.Location = New System.Drawing.Point(21, 15)
        Me.GB_Info.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GB_Info.Name = "GB_Info"
        Me.GB_Info.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GB_Info.Size = New System.Drawing.Size(884, 401)
        Me.GB_Info.TabIndex = 2
        Me.GB_Info.TabStop = False
        Me.GB_Info.Text = "Info Personnel"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(493, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 15)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Label13"
        '
        'TXT_ID_SAL
        '
        Me.TXT_ID_SAL.Location = New System.Drawing.Point(278, 26)
        Me.TXT_ID_SAL.Name = "TXT_ID_SAL"
        Me.TXT_ID_SAL.Size = New System.Drawing.Size(0, 23)
        Me.TXT_ID_SAL.TabIndex = 12
        '
        'TXT_MAT_Salarié
        '
        Me.TXT_MAT_Salarié.Location = New System.Drawing.Point(131, 26)
        Me.TXT_MAT_Salarié.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_MAT_Salarié.Name = "TXT_MAT_Salarié"
        Me.TXT_MAT_Salarié.Size = New System.Drawing.Size(136, 23)
        Me.TXT_MAT_Salarié.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Matricule Salarié"
        '
        'TXT_Fonction
        '
        Me.TXT_Fonction.Location = New System.Drawing.Point(132, 151)
        Me.TXT_Fonction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Fonction.Name = "TXT_Fonction"
        Me.TXT_Fonction.Size = New System.Drawing.Size(136, 23)
        Me.TXT_Fonction.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Fonction"
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LBL_ID.Location = New System.Drawing.Point(275, 57)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(0, 15)
        Me.LBL_ID.TabIndex = 7
        '
        'DTP_DE
        '
        Me.DTP_DE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_DE.Location = New System.Drawing.Point(496, 29)
        Me.DTP_DE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTP_DE.MaxDate = New Date(2016, 5, 20, 0, 0, 0, 0)
        Me.DTP_DE.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.DTP_DE.Name = "DTP_DE"
        Me.DTP_DE.Size = New System.Drawing.Size(101, 23)
        Me.DTP_DE.TabIndex = 4
        Me.DTP_DE.Value = New Date(2016, 5, 2, 0, 0, 0, 0)
        '
        'CBO_TC
        '
        Me.CBO_TC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_TC.FormattingEnabled = True
        Me.CBO_TC.Items.AddRange(New Object() {"Les contrats à durée indéterminée (CDI)", "Les contrats à durée déterminée (CDD)", "Les contrats de travail à temps partiel", "Les contrats d’apprentissage", "Les contrats de stage formation-insertion professionnel"})
        Me.CBO_TC.Location = New System.Drawing.Point(496, 147)
        Me.CBO_TC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBO_TC.Name = "CBO_TC"
        Me.CBO_TC.Size = New System.Drawing.Size(340, 23)
        Me.CBO_TC.TabIndex = 5
        '
        'CBO_SF
        '
        Me.CBO_SF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_SF.FormattingEnabled = True
        Me.CBO_SF.Items.AddRange(New Object() {"Célibataire", "Marié", "Divorsé", "Veuf"})
        Me.CBO_SF.Location = New System.Drawing.Point(496, 106)
        Me.CBO_SF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBO_SF.Name = "CBO_SF"
        Me.CBO_SF.Size = New System.Drawing.Size(136, 23)
        Me.CBO_SF.TabIndex = 5
        '
        'DTP_DN
        '
        Me.DTP_DN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_DN.Location = New System.Drawing.Point(131, 356)
        Me.DTP_DN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTP_DN.MaxDate = New Date(1996, 12, 31, 0, 0, 0, 0)
        Me.DTP_DN.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.DTP_DN.Name = "DTP_DN"
        Me.DTP_DN.Size = New System.Drawing.Size(101, 23)
        Me.DTP_DN.TabIndex = 4
        Me.DTP_DN.Value = New Date(1996, 1, 1, 0, 0, 0, 0)
        '
        'MSK_Tél
        '
        Me.MSK_Tél.Location = New System.Drawing.Point(131, 315)
        Me.MSK_Tél.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MSK_Tél.Mask = "00-00-00-00-00"
        Me.MSK_Tél.Name = "MSK_Tél"
        Me.MSK_Tél.Size = New System.Drawing.Size(101, 23)
        Me.MSK_Tél.TabIndex = 3
        '
        'TXT_TH
        '
        Me.TXT_TH.Location = New System.Drawing.Point(496, 188)
        Me.TXT_TH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_TH.Name = "TXT_TH"
        Me.TXT_TH.Size = New System.Drawing.Size(67, 23)
        Me.TXT_TH.TabIndex = 2
        '
        'TXT_Prénom
        '
        Me.TXT_Prénom.Location = New System.Drawing.Point(132, 108)
        Me.TXT_Prénom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Prénom.Name = "TXT_Prénom"
        Me.TXT_Prénom.Size = New System.Drawing.Size(136, 23)
        Me.TXT_Prénom.TabIndex = 2
        '
        'TXT_Nbrenfant
        '
        Me.TXT_Nbrenfant.Location = New System.Drawing.Point(496, 68)
        Me.TXT_Nbrenfant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Nbrenfant.MaxLength = 2
        Me.TXT_Nbrenfant.Name = "TXT_Nbrenfant"
        Me.TXT_Nbrenfant.Size = New System.Drawing.Size(67, 23)
        Me.TXT_Nbrenfant.TabIndex = 2
        '
        'TXT_Adresse
        '
        Me.TXT_Adresse.Location = New System.Drawing.Point(131, 191)
        Me.TXT_Adresse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Adresse.Multiline = True
        Me.TXT_Adresse.Name = "TXT_Adresse"
        Me.TXT_Adresse.Size = New System.Drawing.Size(234, 101)
        Me.TXT_Adresse.TabIndex = 2
        '
        'TXT_Nom
        '
        Me.TXT_Nom.Location = New System.Drawing.Point(132, 68)
        Me.TXT_Nom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_Nom.Name = "TXT_Nom"
        Me.TXT_Nom.Size = New System.Drawing.Size(136, 23)
        Me.TXT_Nom.TabIndex = 2
        '
        'DGV_Salarié
        '
        Me.DGV_Salarié.AllowUserToAddRows = False
        Me.DGV_Salarié.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Salarié.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Salarié.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column12, Me.Nom, Me.Column2, Me.Column10, Me.Column3, Me.Column4, Me.Column6, Me.Column5, Me.Column7, Me.Column8, Me.Column9, Me.Column11})
        Me.DGV_Salarié.Location = New System.Drawing.Point(14, 455)
        Me.DGV_Salarié.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_Salarié.Name = "DGV_Salarié"
        Me.DGV_Salarié.ReadOnly = True
        Me.DGV_Salarié.Size = New System.Drawing.Size(1418, 262)
        Me.DGV_Salarié.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID_SAL"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column12
        '
        Me.Column12.HeaderText = "Matricule Salarié"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Prénom"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Fonction"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Adresse"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tél"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Date Embauche"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date Naissance"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Nbre Enfant"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Situation Familiale"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Type Contrat"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Taux Horraire"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Salarié
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 730)
        Me.Controls.Add(Me.DGV_Salarié)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Salarié"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salarié"
        Me.Panel1.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GB_Info.ResumeLayout(false)
        Me.GB_Info.PerformLayout
        CType(Me.DGV_Salarié,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GB_Info As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_Prénom As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Adresse As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Nom As System.Windows.Forms.TextBox
    Friend WithEvents DTP_DN As System.Windows.Forms.DateTimePicker
    Friend WithEvents MSK_Tél As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CBO_SF As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_Nbrenfant As System.Windows.Forms.TextBox
    Friend WithEvents DTP_DE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBO_TC As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_TH As System.Windows.Forms.TextBox
    Friend WithEvents BT_Supprimer As System.Windows.Forms.Button
    Friend WithEvents BT_Ajouter As System.Windows.Forms.Button
    Friend WithEvents BT_Modifier As System.Windows.Forms.Button
    Friend WithEvents DGV_Salarié As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBL_ID As System.Windows.Forms.Label
    Friend WithEvents TXT_Fonction As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXT_MAT_Salarié As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXT_ID_SAL As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
