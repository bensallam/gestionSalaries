<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mon_Compte
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_MP = New System.Windows.Forms.TextBox()
        Me.TXT_Login = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_RNMP = New System.Windows.Forms.TextBox()
        Me.TXT_NMP = New System.Windows.Forms.TextBox()
        Me.BT_Modifier = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modification du compte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mot de passe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nouveau mot de passe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Retapez votre mot de passe"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_MP)
        Me.GroupBox1.Controls.Add(Me.TXT_Login)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'TXT_MP
        '
        Me.TXT_MP.Location = New System.Drawing.Point(154, 66)
        Me.TXT_MP.Name = "TXT_MP"
        Me.TXT_MP.Size = New System.Drawing.Size(161, 20)
        Me.TXT_MP.TabIndex = 3
        '
        'TXT_Login
        '
        Me.TXT_Login.Location = New System.Drawing.Point(154, 25)
        Me.TXT_Login.Name = "TXT_Login"
        Me.TXT_Login.Size = New System.Drawing.Size(161, 20)
        Me.TXT_Login.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_RNMP)
        Me.GroupBox2.Controls.Add(Me.TXT_NMP)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 106)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'TXT_RNMP
        '
        Me.TXT_RNMP.Location = New System.Drawing.Point(276, 66)
        Me.TXT_RNMP.Name = "TXT_RNMP"
        Me.TXT_RNMP.Size = New System.Drawing.Size(161, 20)
        Me.TXT_RNMP.TabIndex = 3
        '
        'TXT_NMP
        '
        Me.TXT_NMP.Location = New System.Drawing.Point(276, 19)
        Me.TXT_NMP.Name = "TXT_NMP"
        Me.TXT_NMP.Size = New System.Drawing.Size(161, 20)
        Me.TXT_NMP.TabIndex = 3
        '
        'BT_Modifier
        '
        Me.BT_Modifier.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Modifier.Location = New System.Drawing.Point(187, 353)
        Me.BT_Modifier.Name = "BT_Modifier"
        Me.BT_Modifier.Size = New System.Drawing.Size(135, 39)
        Me.BT_Modifier.TabIndex = 5
        Me.BT_Modifier.Text = "Modifier"
        Me.BT_Modifier.UseVisualStyleBackColor = True
        '
        'Mon_Compte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(589, 405)
        Me.Controls.Add(Me.BT_Modifier)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mon_Compte"
        Me.Text = "Mon compte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_MP As System.Windows.Forms.TextBox
    Friend WithEvents TXT_Login As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_RNMP As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NMP As System.Windows.Forms.TextBox
    Friend WithEvents BT_Modifier As System.Windows.Forms.Button
End Class
