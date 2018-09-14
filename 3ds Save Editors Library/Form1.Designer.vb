<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class N3DSSE_library
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(N3DSSE_library))
        Me.N3DSSEL_header = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.N3DSSEL_logo_update = New System.Windows.Forms.PictureBox()
        Me.Menu_icon_settings = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Info_3DSSEL = New System.Windows.Forms.Label()
        Me.Icon_3DSS3DSCSE = New System.Windows.Forms.PictureBox()
        Me.Icon_TKCDSE = New System.Windows.Forms.PictureBox()
        Me.N3DSSEL_logo = New System.Windows.Forms.PictureBox()
        Me.N3DSSEL_title = New System.Windows.Forms.PictureBox()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.Text_N3DSSEL_version = New System.Windows.Forms.Label()
        Me.N3DSSEL_header.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N3DSSEL_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_icon_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon_3DSS3DSCSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_TKCDSE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N3DSSEL_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N3DSSEL_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N3DSSEL_header
        '
        Me.N3DSSEL_header.BackColor = System.Drawing.Color.White
        Me.N3DSSEL_header.Controls.Add(Me.N3DSSEL_title)
        Me.N3DSSEL_header.Controls.Add(Me.Closebutton)
        Me.N3DSSEL_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.N3DSSEL_header.Location = New System.Drawing.Point(86, 0)
        Me.N3DSSEL_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.N3DSSEL_header.Name = "N3DSSEL_header"
        Me.N3DSSEL_header.Size = New System.Drawing.Size(563, 30)
        Me.N3DSSEL_header.TabIndex = 26
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global._3ds_Save_Editors_Library.My.Resources.Resources.bg_blue
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.icon_settings
        Me.PictureBox2.Location = New System.Drawing.Point(624, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'N3DSSEL_logo_update
        '
        Me.N3DSSEL_logo_update.BackColor = System.Drawing.Color.White
        Me.N3DSSEL_logo_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.N3DSSEL_logo_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.N3DSSEL_logo_update.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources._3DSSEL_logo_update
        Me.N3DSSEL_logo_update.Location = New System.Drawing.Point(0, 0)
        Me.N3DSSEL_logo_update.Name = "N3DSSEL_logo_update"
        Me.N3DSSEL_logo_update.Size = New System.Drawing.Size(86, 80)
        Me.N3DSSEL_logo_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.N3DSSEL_logo_update.TabIndex = 31
        Me.N3DSSEL_logo_update.TabStop = False
        '
        'Menu_icon_settings
        '
        Me.Menu_icon_settings.BackColor = System.Drawing.Color.Transparent
        Me.Menu_icon_settings.BackgroundImage = CType(resources.GetObject("Menu_icon_settings.BackgroundImage"), System.Drawing.Image)
        Me.Menu_icon_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Menu_icon_settings.Enabled = False
        Me.Menu_icon_settings.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.icon_settings
        Me.Menu_icon_settings.Location = New System.Drawing.Point(624, 30)
        Me.Menu_icon_settings.Name = "Menu_icon_settings"
        Me.Menu_icon_settings.Size = New System.Drawing.Size(25, 25)
        Me.Menu_icon_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Menu_icon_settings.TabIndex = 30
        Me.Menu_icon_settings.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Info_3DSSEL)
        Me.Panel1.Controls.Add(Me.Icon_3DSS3DSCSE)
        Me.Panel1.Controls.Add(Me.Icon_TKCDSE)
        Me.Panel1.Location = New System.Drawing.Point(0, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 366)
        Me.Panel1.TabIndex = 29
        '
        'Info_3DSSEL
        '
        Me.Info_3DSSEL.AutoSize = True
        Me.Info_3DSSEL.BackColor = System.Drawing.Color.Transparent
        Me.Info_3DSSEL.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_3DSSEL.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_3DSSEL.ForeColor = System.Drawing.Color.Blue
        Me.Info_3DSSEL.Location = New System.Drawing.Point(631, 342)
        Me.Info_3DSSEL.Name = "Info_3DSSEL"
        Me.Info_3DSSEL.Size = New System.Drawing.Size(14, 20)
        Me.Info_3DSSEL.TabIndex = 163
        Me.Info_3DSSEL.Text = "i"
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
        'N3DSSEL_logo
        '
        Me.N3DSSEL_logo.BackColor = System.Drawing.Color.White
        Me.N3DSSEL_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.N3DSSEL_logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.N3DSSEL_logo.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources._3DSSEL_logo_2
        Me.N3DSSEL_logo.Location = New System.Drawing.Point(0, 0)
        Me.N3DSSEL_logo.Name = "N3DSSEL_logo"
        Me.N3DSSEL_logo.Size = New System.Drawing.Size(86, 80)
        Me.N3DSSEL_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.N3DSSEL_logo.TabIndex = 27
        Me.N3DSSEL_logo.TabStop = False
        '
        'N3DSSEL_title
        '
        Me.N3DSSEL_title.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.title_3DSSEL
        Me.N3DSSEL_title.Location = New System.Drawing.Point(48, 3)
        Me.N3DSSEL_title.Name = "N3DSSEL_title"
        Me.N3DSSEL_title.Size = New System.Drawing.Size(427, 24)
        Me.N3DSSEL_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.N3DSSEL_title.TabIndex = 3
        Me.N3DSSEL_title.TabStop = False
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.close
        Me.Closebutton.Location = New System.Drawing.Point(518, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 30)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'Text_N3DSSEL_version
        '
        Me.Text_N3DSSEL_version.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Text_N3DSSEL_version.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_N3DSSEL_version.ForeColor = System.Drawing.Color.White
        Me.Text_N3DSSEL_version.Location = New System.Drawing.Point(86, 30)
        Me.Text_N3DSSEL_version.Name = "Text_N3DSSEL_version"
        Me.Text_N3DSSEL_version.Size = New System.Drawing.Size(100, 25)
        Me.Text_N3DSSEL_version.TabIndex = 33
        Me.Text_N3DSSEL_version.Text = "Version 1.0.0"
        Me.Text_N3DSSEL_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'N3DSSE_library
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.Text_N3DSSEL_version)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.N3DSSEL_logo_update)
        Me.Controls.Add(Me.Menu_icon_settings)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.N3DSSEL_logo)
        Me.Controls.Add(Me.N3DSSEL_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "N3DSSE_library"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.N3DSSEL_header.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N3DSSEL_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_icon_settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Icon_3DSS3DSCSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_TKCDSE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N3DSSEL_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N3DSSEL_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents N3DSSEL_logo As System.Windows.Forms.PictureBox
    Friend WithEvents N3DSSEL_header As System.Windows.Forms.Panel
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Icon_TKCDSE As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Icon_3DSS3DSCSE As System.Windows.Forms.PictureBox
    Friend WithEvents Menu_icon_settings As System.Windows.Forms.PictureBox
    Friend WithEvents N3DSSEL_title As System.Windows.Forms.PictureBox
    Friend WithEvents N3DSSEL_logo_update As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Info_3DSSEL As System.Windows.Forms.Label
    Friend WithEvents Text_N3DSSEL_version As System.Windows.Forms.Label

End Class
