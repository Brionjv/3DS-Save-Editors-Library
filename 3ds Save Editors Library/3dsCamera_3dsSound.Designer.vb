<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3dsCamera_3dsSound
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_3dsCamera_3dsSound))
        Me.N3DSS3DSC_header = New System.Windows.Forms.Panel()
        Me.N3DSS3DSC_title = New System.Windows.Forms.Label()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Text_camera_fea_tipsun = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Text_sound_fea_tipsun = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TLSE_logo_update = New System.Windows.Forms.PictureBox()
        Me.Panel_jksm = New System.Windows.Forms.Panel()
        Me.Icon_jksm = New System.Windows.Forms.PictureBox()
        Me.Panel_description = New System.Windows.Forms.Panel()
        Me.Text_description = New System.Windows.Forms.Label()
        Me.Panel_jksm_1 = New System.Windows.Forms.Panel()
        Me.Icon_jksm_1 = New System.Windows.Forms.PictureBox()
        Me.N3DSS3DSC_header.SuspendLayout()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_jksm.SuspendLayout()
        CType(Me.Icon_jksm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_description.SuspendLayout()
        Me.Panel_jksm_1.SuspendLayout()
        CType(Me.Icon_jksm_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N3DSS3DSC_header
        '
        Me.N3DSS3DSC_header.BackColor = System.Drawing.Color.White
        Me.N3DSS3DSC_header.Controls.Add(Me.N3DSS3DSC_title)
        Me.N3DSS3DSC_header.Controls.Add(Me.Closebutton)
        Me.N3DSS3DSC_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.N3DSS3DSC_header.Location = New System.Drawing.Point(59, 0)
        Me.N3DSS3DSC_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.N3DSS3DSC_header.Name = "N3DSS3DSC_header"
        Me.N3DSS3DSC_header.Size = New System.Drawing.Size(631, 30)
        Me.N3DSS3DSC_header.TabIndex = 30
        '
        'N3DSS3DSC_title
        '
        Me.N3DSS3DSC_title.Location = New System.Drawing.Point(7, 9)
        Me.N3DSS3DSC_title.Name = "N3DSS3DSC_title"
        Me.N3DSS3DSC_title.Size = New System.Drawing.Size(573, 13)
        Me.N3DSS3DSC_title.TabIndex = 3
        Me.N3DSS3DSC_title.Text = "3ds Sound and 3ds Camera Save Editor"
        Me.N3DSS3DSC_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.close
        Me.Closebutton.Location = New System.Drawing.Point(586, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 30)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(5, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 304)
        Me.Panel1.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global._3ds_Save_Editors_Library.My.Resources.Resources.bg_orange
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(343, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(330, 294)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Text_camera_fea_tipsun)
        Me.Panel5.Location = New System.Drawing.Point(81, 225)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(169, 59)
        Me.Panel5.TabIndex = 2
        '
        'Text_camera_fea_tipsun
        '
        Me.Text_camera_fea_tipsun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_camera_fea_tipsun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_camera_fea_tipsun.Location = New System.Drawing.Point(0, 0)
        Me.Text_camera_fea_tipsun.Name = "Text_camera_fea_tipsun"
        Me.Text_camera_fea_tipsun.Size = New System.Drawing.Size(169, 59)
        Me.Text_camera_fea_tipsun.TabIndex = 1
        Me.Text_camera_fea_tipsun.Text = "Unlock all Tips"
        Me.Text_camera_fea_tipsun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(82, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 216)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global._3ds_Save_Editors_Library.My.Resources.Resources.bg_blue
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(8, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 294)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Text_sound_fea_tipsun)
        Me.Panel4.Location = New System.Drawing.Point(81, 225)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(169, 59)
        Me.Panel4.TabIndex = 1
        '
        'Text_sound_fea_tipsun
        '
        Me.Text_sound_fea_tipsun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_sound_fea_tipsun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_sound_fea_tipsun.Location = New System.Drawing.Point(0, 0)
        Me.Text_sound_fea_tipsun.Name = "Text_sound_fea_tipsun"
        Me.Text_sound_fea_tipsun.Size = New System.Drawing.Size(169, 59)
        Me.Text_sound_fea_tipsun.TabIndex = 0
        Me.Text_sound_fea_tipsun.Text = "Unlock all Tips"
        Me.Text_sound_fea_tipsun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(82, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TLSE_logo_update
        '
        Me.TLSE_logo_update.BackColor = System.Drawing.Color.Transparent
        Me.TLSE_logo_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_logo_update.Cursor = System.Windows.Forms.Cursors.Default
        Me.TLSE_logo_update.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.N3DSCS_icon1
        Me.TLSE_logo_update.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_logo_update.Name = "TLSE_logo_update"
        Me.TLSE_logo_update.Size = New System.Drawing.Size(60, 60)
        Me.TLSE_logo_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TLSE_logo_update.TabIndex = 31
        Me.TLSE_logo_update.TabStop = False
        '
        'Panel_jksm
        '
        Me.Panel_jksm.BackColor = System.Drawing.Color.Transparent
        Me.Panel_jksm.BackgroundImage = Global._3ds_Save_Editors_Library.My.Resources.Resources.bg_menu
        Me.Panel_jksm.Controls.Add(Me.Icon_jksm)
        Me.Panel_jksm.Location = New System.Drawing.Point(647, 35)
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
        'Panel_description
        '
        Me.Panel_description.BackColor = System.Drawing.Color.Transparent
        Me.Panel_description.BackgroundImage = Global._3ds_Save_Editors_Library.My.Resources.Resources.bg_blue
        Me.Panel_description.Controls.Add(Me.Text_description)
        Me.Panel_description.Location = New System.Drawing.Point(0, 373)
        Me.Panel_description.Name = "Panel_description"
        Me.Panel_description.Size = New System.Drawing.Size(690, 33)
        Me.Panel_description.TabIndex = 60
        Me.Panel_description.Visible = False
        '
        'Text_description
        '
        Me.Text_description.BackColor = System.Drawing.Color.Transparent
        Me.Text_description.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_description.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Text_description.Location = New System.Drawing.Point(0, 0)
        Me.Text_description.Name = "Text_description"
        Me.Text_description.Size = New System.Drawing.Size(690, 33)
        Me.Text_description.TabIndex = 0
        Me.Text_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_jksm_1
        '
        Me.Panel_jksm_1.BackColor = System.Drawing.Color.Transparent
        Me.Panel_jksm_1.BackgroundImage = Global._3ds_Save_Editors_Library.My.Resources.Resources.bg_menu
        Me.Panel_jksm_1.Controls.Add(Me.Icon_jksm_1)
        Me.Panel_jksm_1.Location = New System.Drawing.Point(313, 35)
        Me.Panel_jksm_1.Name = "Panel_jksm_1"
        Me.Panel_jksm_1.Size = New System.Drawing.Size(31, 25)
        Me.Panel_jksm_1.TabIndex = 62
        '
        'Icon_jksm_1
        '
        Me.Icon_jksm_1.Cursor = System.Windows.Forms.Cursors.Help
        Me.Icon_jksm_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_jksm_1.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.compat_jksm
        Me.Icon_jksm_1.Location = New System.Drawing.Point(0, 0)
        Me.Icon_jksm_1.Name = "Icon_jksm_1"
        Me.Icon_jksm_1.Size = New System.Drawing.Size(31, 25)
        Me.Icon_jksm_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_jksm_1.TabIndex = 0
        Me.Icon_jksm_1.TabStop = False
        '
        '_3dsCamera_3dsSound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._3ds_Save_Editors_Library.My.Resources.Resources.bg_main
        Me.ClientSize = New System.Drawing.Size(691, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_jksm_1)
        Me.Controls.Add(Me.Panel_description)
        Me.Controls.Add(Me.Panel_jksm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TLSE_logo_update)
        Me.Controls.Add(Me.N3DSS3DSC_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "_3dsCamera_3dsSound"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_3dsCamera_3dsSound"
        Me.N3DSS3DSC_header.ResumeLayout(False)
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_jksm.ResumeLayout(False)
        CType(Me.Icon_jksm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_description.ResumeLayout(False)
        Me.Panel_jksm_1.ResumeLayout(False)
        CType(Me.Icon_jksm_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLSE_logo_update As System.Windows.Forms.PictureBox
    Friend WithEvents N3DSS3DSC_header As System.Windows.Forms.Panel
    Friend WithEvents N3DSS3DSC_title As System.Windows.Forms.Label
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Text_camera_fea_tipsun As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Text_sound_fea_tipsun As System.Windows.Forms.Label
    Friend WithEvents Panel_jksm As System.Windows.Forms.Panel
    Friend WithEvents Icon_jksm As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_description As System.Windows.Forms.Panel
    Friend WithEvents Text_description As System.Windows.Forms.Label
    Friend WithEvents Panel_jksm_1 As System.Windows.Forms.Panel
    Friend WithEvents Icon_jksm_1 As System.Windows.Forms.PictureBox
End Class
