<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_MP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_MP))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeConnecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalarierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BultainDePaieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.SalarierToolStripMenuItem, Me.PointageToolStripMenuItem, Me.BultainDePaieToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeConnecterToolStripMenuItem, Me.MonCompteToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'SeConnecterToolStripMenuItem
        '
        Me.SeConnecterToolStripMenuItem.Name = "SeConnecterToolStripMenuItem"
        Me.SeConnecterToolStripMenuItem.Size = New System.Drawing.Size(214, 30)
        Me.SeConnecterToolStripMenuItem.Text = "Se déconnecter"
        '
        'MonCompteToolStripMenuItem
        '
        Me.MonCompteToolStripMenuItem.Name = "MonCompteToolStripMenuItem"
        Me.MonCompteToolStripMenuItem.Size = New System.Drawing.Size(214, 30)
        Me.MonCompteToolStripMenuItem.Text = "Mon compte"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(214, 30)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'SalarierToolStripMenuItem
        '
        Me.SalarierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem})
        Me.SalarierToolStripMenuItem.Name = "SalarierToolStripMenuItem"
        Me.SalarierToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.SalarierToolStripMenuItem.Text = "Salarié"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(149, 30)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir..."
        '
        'PointageToolStripMenuItem
        '
        Me.PointageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem1})
        Me.PointageToolStripMenuItem.Name = "PointageToolStripMenuItem"
        Me.PointageToolStripMenuItem.Size = New System.Drawing.Size(99, 29)
        Me.PointageToolStripMenuItem.Text = "Pointage"
        '
        'OuvrirToolStripMenuItem1
        '
        Me.OuvrirToolStripMenuItem1.Name = "OuvrirToolStripMenuItem1"
        Me.OuvrirToolStripMenuItem1.Size = New System.Drawing.Size(149, 30)
        Me.OuvrirToolStripMenuItem1.Text = "Ouvrir..."
        '
        'BultainDePaieToolStripMenuItem
        '
        Me.BultainDePaieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem2})
        Me.BultainDePaieToolStripMenuItem.Name = "BultainDePaieToolStripMenuItem"
        Me.BultainDePaieToolStripMenuItem.Size = New System.Drawing.Size(155, 29)
        Me.BultainDePaieToolStripMenuItem.Text = "Bulletin de Paie"
        '
        'OuvrirToolStripMenuItem2
        '
        Me.OuvrirToolStripMenuItem2.Name = "OuvrirToolStripMenuItem2"
        Me.OuvrirToolStripMenuItem2.Size = New System.Drawing.Size(149, 30)
        Me.OuvrirToolStripMenuItem2.Text = "Ouvrir..."
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(62, 29)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'F_MP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(669, 284)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "F_MP"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeConnecterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalarierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PointageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BultainDePaieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonCompteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
