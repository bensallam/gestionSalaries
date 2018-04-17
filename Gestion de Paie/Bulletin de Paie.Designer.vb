<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bultain_de_Paie
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BT_Enreg = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGV_Retenus = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGV_Pointage = New System.Windows.Forms.DataGridView()
        Me.GB_Salarié = New System.Windows.Forms.GroupBox()
        Me.CBO_Matricule = New System.Windows.Forms.ComboBox()
        Me.labell = New System.Windows.Forms.Label()
        Me.TXT_Fonction = New System.Windows.Forms.TextBox()
        Me.TXT_Prénom = New System.Windows.Forms.TextBox()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_Retenus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Pointage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Salarié.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BT_Enreg)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GB_Salarié)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 653)
        Me.Panel1.TabIndex = 0
        '
        'BT_Enreg
        '
        Me.BT_Enreg.Location = New System.Drawing.Point(23, 601)
        Me.BT_Enreg.Name = "BT_Enreg"
        Me.BT_Enreg.Size = New System.Drawing.Size(124, 40)
        Me.BT_Enreg.TabIndex = 6
        Me.BT_Enreg.Text = "Enregistrer"
        Me.BT_Enreg.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGV_Retenus)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 423)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(467, 171)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Retenus"
        '
        'DGV_Retenus
        '
        Me.DGV_Retenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Retenus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8})
        Me.DGV_Retenus.Location = New System.Drawing.Point(8, 22)
        Me.DGV_Retenus.Name = "DGV_Retenus"
        Me.DGV_Retenus.Size = New System.Drawing.Size(446, 141)
        Me.DGV_Retenus.TabIndex = 0
        '
        'Column6
        '
        Me.Column6.HeaderText = "Retenus"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.HeaderText = "Taux"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 130
        '
        'Column8
        '
        Me.Column8.HeaderText = "Valeur"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV_Pointage)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(723, 208)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pointage"
        '
        'DGV_Pointage
        '
        Me.DGV_Pointage.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Pointage.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Pointage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pointage.Location = New System.Drawing.Point(8, 23)
        Me.DGV_Pointage.Name = "DGV_Pointage"
        Me.DGV_Pointage.Size = New System.Drawing.Size(709, 173)
        Me.DGV_Pointage.TabIndex = 0
        '
        'GB_Salarié
        '
        Me.GB_Salarié.Controls.Add(Me.CBO_Matricule)
        Me.GB_Salarié.Controls.Add(Me.labell)
        Me.GB_Salarié.Controls.Add(Me.TXT_Fonction)
        Me.GB_Salarié.Controls.Add(Me.TXT_Prénom)
        Me.GB_Salarié.Controls.Add(Me.TXT_NOM)
        Me.GB_Salarié.Controls.Add(Me.Label3)
        Me.GB_Salarié.Controls.Add(Me.Label2)
        Me.GB_Salarié.Controls.Add(Me.Label1)
        Me.GB_Salarié.Location = New System.Drawing.Point(14, 14)
        Me.GB_Salarié.Name = "GB_Salarié"
        Me.GB_Salarié.Size = New System.Drawing.Size(213, 155)
        Me.GB_Salarié.TabIndex = 0
        Me.GB_Salarié.TabStop = False
        Me.GB_Salarié.Text = "Info Salarié"
        '
        'CBO_Matricule
        '
        Me.CBO_Matricule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_Matricule.FormattingEnabled = True
        Me.CBO_Matricule.Location = New System.Drawing.Point(85, 20)
        Me.CBO_Matricule.Name = "CBO_Matricule"
        Me.CBO_Matricule.Size = New System.Drawing.Size(116, 23)
        Me.CBO_Matricule.TabIndex = 3
        '
        'labell
        '
        Me.labell.AutoSize = True
        Me.labell.Location = New System.Drawing.Point(8, 120)
        Me.labell.Name = "labell"
        Me.labell.Size = New System.Drawing.Size(54, 15)
        Me.labell.TabIndex = 2
        Me.labell.Text = "Fonction"
        '
        'TXT_Fonction
        '
        Me.TXT_Fonction.Location = New System.Drawing.Point(85, 117)
        Me.TXT_Fonction.Name = "TXT_Fonction"
        Me.TXT_Fonction.Size = New System.Drawing.Size(116, 23)
        Me.TXT_Fonction.TabIndex = 1
        '
        'TXT_Prénom
        '
        Me.TXT_Prénom.Location = New System.Drawing.Point(85, 83)
        Me.TXT_Prénom.Name = "TXT_Prénom"
        Me.TXT_Prénom.Size = New System.Drawing.Size(116, 23)
        Me.TXT_Prénom.TabIndex = 1
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Location = New System.Drawing.Point(85, 51)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(116, 23)
        Me.TXT_NOM.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricule"
        '
        'Bultain_de_Paie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 653)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Bultain_de_Paie"
        Me.Text = "Bulletin de Paie"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGV_Retenus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_Pointage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Salarié.ResumeLayout(False)
        Me.GB_Salarié.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BT_Enreg As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Retenus As System.Windows.Forms.DataGridView
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Pointage As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Salarié As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_Fonction As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Prénom As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NOM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labell As System.Windows.Forms.Label
    Friend WithEvents CBO_Matricule As System.Windows.Forms.ComboBox
End Class
