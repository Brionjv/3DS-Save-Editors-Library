<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TLSE_header = New System.Windows.Forms.Panel()
        Me.Menu_icon_settings = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Icon_3DSS3DSCSE = New System.Windows.Forms.PictureBox()
        Me.Icon_TKCDSE = New System.Windows.Forms.PictureBox()
        Me.TLSE_logo_update = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.TLSE_header.SuspendLayout()
        CType(Me.Menu_icon_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon_3DSS3DSCSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_TKCDSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLSE_header
        '
        Me.TLSE_header.BackColor = System.Drawing.Color.White
        Me.TLSE_header.Controls.Add(Me.PictureBox1)
        Me.TLSE_header.Controls.Add(Me.Closebutton)
        Me.TLSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.TLSE_header.Location = New System.Drawing.Point(64, 0)
        Me.TLSE_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TLSE_header.Name = "TLSE_header"
        Me.TLSE_header.Size = New System.Drawing.Size(496, 30)
        Me.TLSE_header.TabIndex = 26
        '
        'Menu_icon_settings
        '
        Me.Menu_icon_settings.BackColor = System.Drawing.Color.Transparent
        Me.Menu_icon_settings.BackgroundImage = CType(resources.GetObject("Menu_icon_settings.BackgroundImage"), System.Drawing.Image)
        Me.Menu_icon_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Menu_icon_settings.Enabled = False
        Me.Menu_icon_settings.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.icon_settings
        Me.Menu_icon_settings.Location = New System.Drawing.Point(529, 31)
        Me.Menu_icon_settings.Name = "Menu_icon_settings"
        Me.Menu_icon_settings.Size = New System.Drawing.Size(30, 30)
        Me.Menu_icon_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Menu_icon_settings.TabIndex = 30
        Me.Menu_icon_settings.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Icon_3DSS3DSCSE)
        Me.Panel1.Controls.Add(Me.Icon_TKCDSE)
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 323)
        Me.Panel1.TabIndex = 29
        '
        'Icon_3DSS3DSCSE
        '
        Me.Icon_3DSS3DSCSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_3DSS3DSCSE.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.N3DSCS_icon
        Me.Icon_3DSS3DSCSE.Location = New System.Drawing.Point(57, 3)
        Me.Icon_3DSS3DSCSE.Name = "Icon_3DSS3DSCSE"
        Me.Icon_3DSS3DSCSE.Size = New System.Drawing.Size(48, 48)
        Me.Icon_3DSS3DSCSE.TabIndex = 29
        Me.Icon_3DSS3DSCSE.TabStop = False
        '
        'Icon_TKCDSE
        '
        Me.Icon_TKCDSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_TKCDSE.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.TKCD_icon
        Me.Icon_TKCDSE.Location = New System.Drawing.Point(3, 3)
        Me.Icon_TKCDSE.Name = "Icon_TKCDSE"
        Me.Icon_TKCDSE.Size = New System.Drawing.Size(48, 48)
        Me.Icon_TKCDSE.TabIndex = 28
        Me.Icon_TKCDSE.TabStop = False
        '
        'TLSE_logo_update
        '
        Me.TLSE_logo_update.BackColor = System.Drawing.Color.White
        Me.TLSE_logo_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_logo_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLSE_logo_update.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.icon_3dssl
        Me.TLSE_logo_update.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_logo_update.Name = "TLSE_logo_update"
        Me.TLSE_logo_update.Size = New System.Drawing.Size(66, 60)
        Me.TLSE_logo_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_logo_update.TabIndex = 27
        Me.TLSE_logo_update.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.title_3DSSEL
        Me.PictureBox1.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.close
        Me.Closebutton.Location = New System.Drawing.Point(450, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 30)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.Menu_icon_settings)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TLSE_logo_update)
        Me.Controls.Add(Me.TLSE_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TLSE_header.ResumeLayout(False)
        CType(Me.Menu_icon_settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Icon_3DSS3DSCSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_TKCDSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLSE_logo_update As System.Windows.Forms.PictureBox
    Friend WithEvents TLSE_header As System.Windows.Forms.Panel
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Icon_TKCDSE As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Icon_3DSS3DSCSE As System.Windows.Forms.PictureBox
    Friend WithEvents Menu_icon_settings As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
