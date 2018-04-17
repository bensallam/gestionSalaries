<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Se_Connecter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Se_Connecter))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_LOGIN = New System.Windows.Forms.TextBox()
        Me.TXT_MP = New System.Windows.Forms.TextBox()
        Me.BT_Connexion = New System.Windows.Forms.Button()
        Me.LK_Aide = New System.Windows.Forms.LinkLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AUTHENTIFICATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Par defaut >>> Login = Admin / Mot de passe = 12345"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Mot de passe"
        '
        'TXT_LOGIN
        '
        Me.TXT_LOGIN.Location = New System.Drawing.Point(236, 142)
        Me.TXT_LOGIN.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TXT_LOGIN.Name = "TXT_LOGIN"
        Me.TXT_LOGIN.Size = New System.Drawing.Size(209, 25)
        Me.TXT_LOGIN.TabIndex = 3
        '
        'TXT_MP
        '
        Me.TXT_MP.Location = New System.Drawing.Point(236, 192)
        Me.TXT_MP.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TXT_MP.Name = "TXT_MP"
        Me.TXT_MP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_MP.Size = New System.Drawing.Size(209, 25)
        Me.TXT_MP.TabIndex = 3
        '
        'BT_Connexion
        '
        Me.BT_Connexion.Location = New System.Drawing.Point(215, 312)
        Me.BT_Connexion.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_Connexion.Name = "BT_Connexion"
        Me.BT_Connexion.Size = New System.Drawing.Size(121, 35)
        Me.BT_Connexion.TabIndex = 5
        Me.BT_Connexion.Text = "Connexion"
        Me.BT_Connexion.UseVisualStyleBackColor = True
        '
        'LK_Aide
        '
        Me.LK_Aide.AutoSize = True
        Me.LK_Aide.Location = New System.Drawing.Point(491, 352)
        Me.LK_Aide.Name = "LK_Aide"
        Me.LK_Aide.Size = New System.Drawing.Size(42, 17)
        Me.LK_Aide.TabIndex = 6
        Me.LK_Aide.TabStop = True
        Me.LK_Aide.Text = "Aide !"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(320, 222)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(169, 21)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Afficher le mot de passe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Se_Connecter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 378)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LK_Aide)
        Me.Controls.Add(Me.BT_Connexion)
        Me.Controls.Add(Me.TXT_MP)
        Me.Controls.Add(Me.TXT_LOGIN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Se_Connecter"
        Me.Text = "Se Connecter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_LOGIN As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MP As System.Windows.Forms.TextBox
    Friend WithEvents BT_Connexion As System.Windows.Forms.Button
    Friend WithEvents LK_Aide As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
