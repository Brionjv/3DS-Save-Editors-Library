<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AR_Games
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AR_Games))
        Me.TLSE_logo_update = New System.Windows.Forms.PictureBox()
        Me._3DSARG_header = New System.Windows.Forms.Panel()
        Me._3DSARG_title = New System.Windows.Forms.Label()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.Fea_unlockgames = New System.Windows.Forms.PictureBox()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.Panel_jksm = New System.Windows.Forms.Panel()
        Me.Icon_jksm = New System.Windows.Forms.PictureBox()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._3DSARG_header.SuspendLayout()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fea_unlockgames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_description.SuspendLayout()
        Me.Panel_jksm.SuspendLayout()
        CType(Me.Icon_jksm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLSE_logo_update
        '
        Me.TLSE_logo_update.BackColor = System.Drawing.Color.Transparent
        Me.TLSE_logo_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_logo_update.Cursor = System.Windows.Forms.Cursors.Default
        Me.TLSE_logo_update.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.icon_3DSARG
        Me.TLSE_logo_update.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_logo_update.Name = "TLSE_logo_update"
        Me.TLSE_logo_update.Size = New System.Drawing.Size(60, 60)
        Me.TLSE_logo_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TLSE_logo_update.TabIndex = 30
        Me.TLSE_logo_update.TabStop = False
        '
        '_3DSARG_header
        '
        Me._3DSARG_header.BackColor = System.Drawing.Color.White
        Me._3DSARG_header.Controls.Add(Me._3DSARG_title)
        Me._3DSARG_header.Controls.Add(Me.Closebutton)
        Me._3DSARG_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me._3DSARG_header.Location = New System.Drawing.Point(60, 0)
        Me._3DSARG_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me._3DSARG_header.Name = "_3DSARG_header"
        Me._3DSARG_header.Size = New System.Drawing.Size(376, 30)
        Me._3DSARG_header.TabIndex = 31
        '
        '_3DSARG_title
        '
        Me._3DSARG_title.Location = New System.Drawing.Point(12, 9)
        Me._3DSARG_title.Name = "_3DSARG_title"
        Me._3DSARG_title.Size = New System.Drawing.Size(233, 13)
        Me._3DSARG_title.TabIndex = 3
        Me._3DSARG_title.Text = "3DS AR Games Save Editor"
        Me._3DSARG_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.close
        Me.Closebutton.Location = New System.Drawing.Point(330, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 30)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'Fea_unlockgames
        '
        Me.Fea_unlockgames.BackColor = System.Drawing.Color.Transparent
        Me.Fea_unlockgames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Fea_unlockgames.Image = CType(resources.GetObject("Fea_unlockgames.Image"), System.Drawing.Image)
        Me.Fea_unlockgames.Location = New System.Drawing.Point(157, 75)
        Me.Fea_unlockgames.Name = "Fea_unlockgames"
        Me.Fea_unlockgames.Size = New System.Drawing.Size(123, 124)
        Me.Fea_unlockgames.TabIndex = 32
        Me.Fea_unlockgames.TabStop = False
        '
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Gold
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 211)
        Me.Panel_description.Name = "Panel_description"
        Me.Panel_description.Size = New System.Drawing.Size(436, 35)
        Me.Panel_description.TabIndex = 45
        Me.Panel_description.Visible = False
        '
        'Text_description
        '
        Me.Text_description.BackColor = System.Drawing.Color.Transparent
        Me.Text_description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_description.ForeColor = System.Drawing.Color.White
        Me.Text_description.Location = New System.Drawing.Point(0, 0)
        Me.Text_description.Name = "Text_description"
        Me.Text_description.Size = New System.Drawing.Size(436, 35)
        Me.Text_description.TabIndex = 33
        Me.Text_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_jksm
        '
        Me.Panel_jksm.BackColor = System.Drawing.Color.Transparent
        Me.Panel_jksm.BackgroundImage = CType(resources.GetObject("Panel_jksm.BackgroundImage"), System.Drawing.Image)
        Me.Panel_jksm.Controls.Add(Me.Icon_jksm)
        Me.Panel_jksm.Location = New System.Drawing.Point(403, 35)
        Me.Panel_jksm.Name = "Panel_jksm"
        Me.Panel_jksm.Size = New System.Drawing.Size(31, 25)
        Me.Panel_jksm.TabIndex = 59
        '
        'Icon_jksm
        '
        Me.Icon_jksm.Cursor = System.Windows.Forms.Cursors.Help
        Me.Icon_jksm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_jksm.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.compat_jksm
        Me.Icon_jksm.Location = New System.Drawing.Point(0, 0)
        Me.Icon_jksm.Name = "Icon_jksm"
        Me.Icon_jksm.Size = New System.Drawing.Size(31, 25)
        Me.Icon_jksm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_jksm.TabIndex = 0
        Me.Icon_jksm.TabStop = False
        '
        'AR_Games
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(436, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_jksm)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Fea_unlockgames)
        Me.Controls.Add(Me._3DSARG_header)
        Me.Controls.Add(Me.TLSE_logo_update)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AR_Games"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AR_Games"
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        Me._3DSARG_header.ResumeLayout(False)
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fea_unlockgames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_description.ResumeLayout(False)
        Me.Panel_jksm.ResumeLayout(False)
        CType(Me.Icon_jksm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLSE_logo_update As System.Windows.Forms.PictureBox
    Friend WithEvents _3DSARG_header As System.Windows.Forms.Panel
    Friend WithEvents _3DSARG_title As System.Windows.Forms.Label
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Fea_unlockgames As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_description As System.Windows.Forms.Panel
    Friend WithEvents Text_description As System.Windows.Forms.Label
    Friend WithEvents Panel_jksm As System.Windows.Forms.Panel
    Friend WithEvents Icon_jksm As System.Windows.Forms.PictureBox
End Class
