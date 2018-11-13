<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marketcrashers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Marketcrashers))
        Me.SMPMCSE_header = New System.Windows.Forms.Panel()
        Me.SMPMCSE_title = New System.Windows.Forms.Label()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.Panel_menu_open = New System.Windows.Forms.Panel()
        Me.Text_menu_save = New System.Windows.Forms.Label()
        Me.Text_menu_open = New System.Windows.Forms.Label()
        Me.SMPMCSE_logo = New System.Windows.Forms.PictureBox()
        Me.Fea_assets = New System.Windows.Forms.Panel()
        Me.Title_assets = New System.Windows.Forms.Label()
        Me.valu_assets = New System.Windows.Forms.NumericUpDown()
        Me.Panel_jksm = New System.Windows.Forms.Panel()
        Me.Icon_jksm = New System.Windows.Forms.PictureBox()
        Me.Panel_chkpt = New System.Windows.Forms.Panel()
        Me.Icon_chkpt = New System.Windows.Forms.PictureBox()
        Me.SMPMCSE_header.SuspendLayout()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_menu_open.SuspendLayout()
        CType(Me.SMPMCSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fea_assets.SuspendLayout()
        CType(Me.valu_assets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_jksm.SuspendLayout()
        CType(Me.Icon_jksm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_chkpt.SuspendLayout()
        CType(Me.Icon_chkpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SMPMCSE_header
        '
        Me.SMPMCSE_header.BackColor = System.Drawing.Color.White
        Me.SMPMCSE_header.Controls.Add(Me.SMPMCSE_title)
        Me.SMPMCSE_header.Controls.Add(Me.Closebutton)
        Me.SMPMCSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.SMPMCSE_header.Location = New System.Drawing.Point(60, 0)
        Me.SMPMCSE_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SMPMCSE_header.Name = "SMPMCSE_header"
        Me.SMPMCSE_header.Size = New System.Drawing.Size(474, 30)
        Me.SMPMCSE_header.TabIndex = 54
        '
        'SMPMCSE_title
        '
        Me.SMPMCSE_title.Location = New System.Drawing.Point(14, 9)
        Me.SMPMCSE_title.Name = "SMPMCSE_title"
        Me.SMPMCSE_title.Size = New System.Drawing.Size(400, 13)
        Me.SMPMCSE_title.TabIndex = 3
        Me.SMPMCSE_title.Text = "StreetPass Mii Plaza - StreetPass Trader / Market Crashers Save Editor"
        Me.SMPMCSE_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.close
        Me.Closebutton.Location = New System.Drawing.Point(429, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 30)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'Panel_menu_open
        '
        Me.Panel_menu_open.BackColor = System.Drawing.Color.Transparent
        Me.Panel_menu_open.BackgroundImage = CType(resources.GetObject("Panel_menu_open.BackgroundImage"), System.Drawing.Image)
        Me.Panel_menu_open.Controls.Add(Me.Text_menu_save)
        Me.Panel_menu_open.Controls.Add(Me.Text_menu_open)
        Me.Panel_menu_open.Location = New System.Drawing.Point(62, 34)
        Me.Panel_menu_open.Name = "Panel_menu_open"
        Me.Panel_menu_open.Size = New System.Drawing.Size(68, 25)
        Me.Panel_menu_open.TabIndex = 55
        '
        'Text_menu_save
        '
        Me.Text_menu_save.BackColor = System.Drawing.Color.Transparent
        Me.Text_menu_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_menu_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_menu_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_menu_save.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Text_menu_save.Location = New System.Drawing.Point(0, 0)
        Me.Text_menu_save.Name = "Text_menu_save"
        Me.Text_menu_save.Size = New System.Drawing.Size(68, 25)
        Me.Text_menu_save.TabIndex = 1
        Me.Text_menu_save.Text = "Save"
        Me.Text_menu_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Text_menu_save.Visible = False
        '
        'Text_menu_open
        '
        Me.Text_menu_open.BackColor = System.Drawing.Color.Transparent
        Me.Text_menu_open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_menu_open.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_menu_open.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_menu_open.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Text_menu_open.Location = New System.Drawing.Point(0, 0)
        Me.Text_menu_open.Name = "Text_menu_open"
        Me.Text_menu_open.Size = New System.Drawing.Size(68, 25)
        Me.Text_menu_open.TabIndex = 0
        Me.Text_menu_open.Text = "Open"
        Me.Text_menu_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SMPMCSE_logo
        '
        Me.SMPMCSE_logo.BackColor = System.Drawing.Color.Transparent
        Me.SMPMCSE_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SMPMCSE_logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.SMPMCSE_logo.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.icon_trader1
        Me.SMPMCSE_logo.Location = New System.Drawing.Point(0, 0)
        Me.SMPMCSE_logo.Name = "SMPMCSE_logo"
        Me.SMPMCSE_logo.Size = New System.Drawing.Size(60, 60)
        Me.SMPMCSE_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SMPMCSE_logo.TabIndex = 53
        Me.SMPMCSE_logo.TabStop = False
        '
        'Fea_assets
        '
        Me.Fea_assets.BackColor = System.Drawing.Color.Transparent
        Me.Fea_assets.BackgroundImage = Global._3ds_Save_Editors_Library.My.Resources.Resources.trader_bg_fund
        Me.Fea_assets.Controls.Add(Me.Title_assets)
        Me.Fea_assets.Controls.Add(Me.valu_assets)
        Me.Fea_assets.Location = New System.Drawing.Point(77, 102)
        Me.Fea_assets.Name = "Fea_assets"
        Me.Fea_assets.Size = New System.Drawing.Size(380, 50)
        Me.Fea_assets.TabIndex = 56
        '
        'Title_assets
        '
        Me.Title_assets.Location = New System.Drawing.Point(93, 0)
        Me.Title_assets.Name = "Title_assets"
        Me.Title_assets.Size = New System.Drawing.Size(185, 23)
        Me.Title_assets.TabIndex = 1
        Me.Title_assets.Text = "Total Assets"
        Me.Title_assets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valu_assets
        '
        Me.valu_assets.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_assets.Location = New System.Drawing.Point(130, 28)
        Me.valu_assets.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.valu_assets.Name = "valu_assets"
        Me.valu_assets.Size = New System.Drawing.Size(120, 16)
        Me.valu_assets.TabIndex = 0
        Me.valu_assets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_assets.ThousandsSeparator = True
        '
        'Panel_jksm
        '
        Me.Panel_jksm.BackColor = System.Drawing.Color.Transparent
        Me.Panel_jksm.BackgroundImage = CType(resources.GetObject("Panel_jksm.BackgroundImage"), System.Drawing.Image)
        Me.Panel_jksm.Controls.Add(Me.Icon_jksm)
        Me.Panel_jksm.Location = New System.Drawing.Point(501, 35)
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
        'Panel_chkpt
        '
        Me.Panel_chkpt.BackColor = System.Drawing.Color.Transparent
        Me.Panel_chkpt.BackgroundImage = CType(resources.GetObject("Panel_chkpt.BackgroundImage"), System.Drawing.Image)
        Me.Panel_chkpt.Controls.Add(Me.Icon_chkpt)
        Me.Panel_chkpt.Location = New System.Drawing.Point(469, 35)
        Me.Panel_chkpt.Name = "Panel_chkpt"
        Me.Panel_chkpt.Size = New System.Drawing.Size(31, 25)
        Me.Panel_chkpt.TabIndex = 58
        '
        'Icon_chkpt
        '
        Me.Icon_chkpt.Cursor = System.Windows.Forms.Cursors.Help
        Me.Icon_chkpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_chkpt.Image = Global._3ds_Save_Editors_Library.My.Resources.Resources.compat_chkpt
        Me.Icon_chkpt.Location = New System.Drawing.Point(0, 0)
        Me.Icon_chkpt.Name = "Icon_chkpt"
        Me.Icon_chkpt.Size = New System.Drawing.Size(31, 25)
        Me.Icon_chkpt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_chkpt.TabIndex = 1
        Me.Icon_chkpt.TabStop = False
        '
        'Marketcrashers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(534, 216)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_jksm)
        Me.Controls.Add(Me.Panel_chkpt)
        Me.Controls.Add(Me.Fea_assets)
        Me.Controls.Add(Me.Panel_menu_open)
        Me.Controls.Add(Me.SMPMCSE_header)
        Me.Controls.Add(Me.SMPMCSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Marketcrashers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marketcrashers"
        Me.SMPMCSE_header.ResumeLayout(False)
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_menu_open.ResumeLayout(False)
        CType(Me.SMPMCSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fea_assets.ResumeLayout(False)
        CType(Me.valu_assets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_jksm.ResumeLayout(False)
        CType(Me.Icon_jksm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_chkpt.ResumeLayout(False)
        CType(Me.Icon_chkpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_menu_open As System.Windows.Forms.Panel
    Friend WithEvents Text_menu_save As System.Windows.Forms.Label
    Friend WithEvents Text_menu_open As System.Windows.Forms.Label
    Friend WithEvents SMPMCSE_header As System.Windows.Forms.Panel
    Friend WithEvents SMPMCSE_title As System.Windows.Forms.Label
    Friend WithEvents Closebutton As System.Windows.Forms.PictureBox
    Friend WithEvents SMPMCSE_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Fea_assets As System.Windows.Forms.Panel
    Friend WithEvents Title_assets As System.Windows.Forms.Label
    Friend WithEvents valu_assets As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel_jksm As System.Windows.Forms.Panel
    Friend WithEvents Icon_jksm As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_chkpt As System.Windows.Forms.Panel
    Friend WithEvents Icon_chkpt As System.Windows.Forms.PictureBox
End Class
