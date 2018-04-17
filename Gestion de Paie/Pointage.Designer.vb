<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pointage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBO_IDSAL = New System.Windows.Forms.ComboBox()
        Me.DGV_Pointage = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_Ajouter = New System.Windows.Forms.Button()
        Me.CBO_Période = New System.Windows.Forms.ComboBox()
        Me.MSK_HE = New System.Windows.Forms.MaskedTextBox()
        Me.MSK_HS = New System.Windows.Forms.MaskedTextBox()
        Me.DTP_Pointage = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Pointage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date de Pointage"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CBO_IDSAL)
        Me.Panel1.Controls.Add(Me.DGV_Pointage)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.CBO_Période)
        Me.Panel1.Controls.Add(Me.MSK_HE)
        Me.Panel1.Controls.Add(Me.MSK_HS)
        Me.Panel1.Controls.Add(Me.DTP_Pointage)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 504)
        Me.Panel1.TabIndex = 1
        '
        'CBO_IDSAL
        '
        Me.CBO_IDSAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_IDSAL.FormattingEnabled = True
        Me.CBO_IDSAL.Location = New System.Drawing.Point(146, 21)
        Me.CBO_IDSAL.Name = "CBO_IDSAL"
        Me.CBO_IDSAL.Size = New System.Drawing.Size(215, 40)
        Me.CBO_IDSAL.TabIndex = 10
        '
        'DGV_Pointage
        '
        Me.DGV_Pointage.AllowUserToAddRows = False
        Me.DGV_Pointage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Pointage.Location = New System.Drawing.Point(14, 248)
        Me.DGV_Pointage.Name = "DGV_Pointage"
        Me.DGV_Pointage.Size = New System.Drawing.Size(684, 242)
        Me.DGV_Pointage.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_Ajouter)
        Me.GroupBox1.Location = New System.Drawing.Point(521, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 76)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'BT_Ajouter
        '
        Me.BT_Ajouter.Location = New System.Drawing.Point(7, 16)
        Me.BT_Ajouter.Name = "BT_Ajouter"
        Me.BT_Ajouter.Size = New System.Drawing.Size(161, 44)
        Me.BT_Ajouter.TabIndex = 5
        Me.BT_Ajouter.Text = "Ajouter"
        Me.BT_Ajouter.UseVisualStyleBackColor = True
        '
        'CBO_Période
        '
        Me.CBO_Période.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_Période.FormattingEnabled = True
        Me.CBO_Période.Items.AddRange(New Object() {"Matin", "Aprés Midi", "Soir"})
        Me.CBO_Période.Location = New System.Drawing.Point(128, 197)
        Me.CBO_Période.Name = "CBO_Période"
        Me.CBO_Période.Size = New System.Drawing.Size(233, 40)
        Me.CBO_Période.TabIndex = 4
        '
        'MSK_HE
        '
        Me.MSK_HE.Location = New System.Drawing.Point(128, 118)
        Me.MSK_HE.Mask = "00:00"
        Me.MSK_HE.Name = "MSK_HE"
        Me.MSK_HE.Size = New System.Drawing.Size(33, 39)
        Me.MSK_HE.TabIndex = 3
        Me.MSK_HE.ValidatingType = GetType(Date)
        '
        'MSK_HS
        '
        Me.MSK_HS.Location = New System.Drawing.Point(128, 155)
        Me.MSK_HS.Mask = "00:00"
        Me.MSK_HS.Name = "MSK_HS"
        Me.MSK_HS.Size = New System.Drawing.Size(33, 39)
        Me.MSK_HS.TabIndex = 3
        Me.MSK_HS.ValidatingType = GetType(Date)
        '
        'DTP_Pointage
        '
        Me.DTP_Pointage.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Pointage.Location = New System.Drawing.Point(128, 80)
        Me.DTP_Pointage.Name = "DTP_Pointage"
        Me.DTP_Pointage.Size = New System.Drawing.Size(233, 39)
        Me.DTP_Pointage.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Heure de Sortie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Période"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Heure d'Entrée"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Matricule salarié"
        '
        'Pointage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Pointage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pointage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_Pointage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BT_Ajouter As System.Windows.Forms.Button
    Friend WithEvents CBO_Période As System.Windows.Forms.ComboBox
    Friend WithEvents MSK_HE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MSK_HS As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DTP_Pointage As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Pointage As System.Windows.Forms.DataGridView
    Friend WithEvents CBO_IDSAL As System.Windows.Forms.ComboBox
End Class
