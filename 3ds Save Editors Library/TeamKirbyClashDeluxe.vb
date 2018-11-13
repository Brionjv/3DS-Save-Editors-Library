Imports PackageIO
Imports System.IO

Public Class TeamKirbyClashDeluxe
    Dim savedata As String
    Dim applicationpath = Application.StartupPath
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim Tree = &H19B8
    Dim Apples = &H199C
    Dim FireFragments = &H19BC
    Dim WaterFragments = &H19C0
    Dim LighFragments = &H19C4
    Dim RareFragments = &H19C8
    Dim SwordHero = &HD54
    Dim DoctorHealmore = &HD60
    Dim HammerLord = &HD6C
    Dim BeamMage = &HD78
    Dim staminapot = &H1B43
    Dim attackpot = &H1B47
    Dim exporb = &H1B4B
    Dim vigor = &H1B98
    Dim Area_1 = &HD84
    Dim Area_2 = &HD85
    Dim Area_3 = &HD86
    Dim Area_4 = &HD87
    Dim Area_5 = &HD88
    Dim Area_6 = &HD89
    Dim Playtime = &H1B74
    Dim Completmission = &H1B90
    Dim Multibattles = &H1B94
    Dim Multiencounters = &H1B64
    Dim Profmessage = &H1BB4
    Dim HighScores As String
    Dim Rank As String
    Dim Time As String
    Dim HighScores_1 As String
    Dim Rank_1 As String
    Dim Time_1 As String
    Dim HighScores_2 As String
    Dim Rank_2 As String
    Dim Time_2 As String
    Dim HighScores_3 As String
    Dim Rank_3 As String
    Dim Time_3 As String
    Dim HighScores_4 As String
    Dim Rank_4 As String
    Dim Time_4 As String
    Dim HighScores_5 As String
    Dim Rank_5 As String
    Dim Time_5 As String
    Dim HighScores_6 As String
    Dim Rank_6 As String
    Dim Time_6 As String
    Dim HighScores_7 As String
    Dim Rank_7 As String
    Dim Time_7 As String
    Dim HighScores_8 As String
    Dim Rank_8 As String
    Dim Time_8 As String
    Dim Level As String
    Dim Level_1 As String
    Dim Level_2 As String
    Dim Level_3 As String
    Dim Level_4 As String
    Dim Level_5 As String
    Dim Level_6 As String
    Dim Level_7 As String
    Dim Level_8 As String
    Dim Cptlevel_1 As String
    Dim Cptlevel_2 As String
    Dim Cptlevel_3 As String
    Dim Cptlevel_4 As String
    Dim Cptlevel_5 As String
    Dim Cptlevel_6 As String
    Dim Cptlevel_7 As String
    Dim Cptlevel_8 As String

    Private Sub TKCD_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TKCD_header.MouseDown, TKCD_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TKCD_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TKCD_header.MouseUp, TKCD_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TKCD_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TKCD_header.MouseMove, TKCD_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Public Sub hidepanels()
        Panel_itemsediting.Visible = False
        Panel_highscoresediting.Visible = False
        Panel_lvlareaediting.Visible = False
        Panel_missionsediting.Visible = False
    End Sub

    Public Sub hidepanelsarea()
        Panel_quest6.Visible = False
        Panel_quest7.Visible = False
        Panel_quest8.Visible = False
    End Sub

    Private Sub readfilesavedata()
        Try
            Dim Reader As New PackageIO.Reader(savedata, PackageIO.Endian.Little)
            Reader.Position = Tree
            valu_tree.Value = Reader.ReadUInt16
            Reader.Position = Apples
            valu_apples.Value = Reader.ReadUInt16
            Reader.Position = FireFragments
            valu_frag_red.Value = Reader.ReadUInt16
            Reader.Position = WaterFragments
            valu_frag_blue.Value = Reader.ReadUInt16
            Reader.Position = LighFragments
            valu_frag_yellow.Value = Reader.ReadUInt16
            Reader.Position = RareFragments
            valu_frag_rare.Value = Reader.ReadUInt16
            Reader.Position = SwordHero
            valu_swordhero.Value = Reader.ReadUInt32
            Reader.Position = DoctorHealmore
            valu_doctorhealmore.Value = Reader.ReadUInt32
            Reader.Position = HammerLord
            valu_hammerlord.Value = Reader.ReadUInt32
            Reader.Position = BeamMage
            valu_beammage.Value = Reader.ReadUInt32
            Reader.Position = staminapot
            valu_staminapot.Value = Reader.ReadByte
            Reader.Position = attackpot
            valu_attackpot.Value = Reader.ReadByte
            Reader.Position = exporb
            valu_exporb.Value = Reader.ReadByte
            Reader.Position = vigor
            valu_vigor.Value = Reader.ReadByte
            Reader.Position = Area_1
            valu_area_1.Value = Reader.ReadByte
            Reader.Position = Area_2
            valu_area_2.Value = Reader.ReadByte
            Reader.Position = Area_3
            valu_area_3.Value = Reader.ReadByte
            Reader.Position = Area_4
            valu_area_4.Value = Reader.ReadByte
            Reader.Position = Area_5
            valu_area_5.Value = Reader.ReadByte
            Reader.Position = Area_6
            valu_area_6.Value = Reader.ReadByte
            Reader.Position = Completmission
            valu_competmissions.Value = Reader.ReadUInt32
            Reader.Position = Playtime
            valu_playtime.Value = Reader.ReadUInt32
            Reader.Position = Multibattles
            valu_multibattles.Value = Reader.ReadUInt16
            Reader.Position = Multiencounters
            valu_multiencounters.Value = Reader.ReadUInt16
            Reader.Position = Profmessage
            Text_profmessage.Text = Reader.ReadUnicodeString(16)
            Text_menu_save.Visible = True
        Catch ex As Exception
            fdialog.Description.Text = "Failed to read savedata.dat, make sure you have opened a good save file or report this issue"
            fdialog.ShowDialog()
            Text_menu_save.Visible = False
        End Try
    End Sub

    Private Sub writefilesavedata()
        Try
            Dim Writer As New PackageIO.Writer(savedata, PackageIO.Endian.Little)
            writer.Position = Tree
            Writer.WriteUInt16(valu_tree.Value)
            Writer.Position = Apples
            Writer.WriteUInt16(valu_apples.Value)
            Writer.Position = FireFragments
            Writer.WriteUInt16(valu_frag_red.Value)
            Writer.Position = WaterFragments
            Writer.WriteUInt16(valu_frag_blue.Value)
            Writer.Position = LighFragments
            Writer.WriteUInt16(valu_frag_yellow.Value)
            Writer.Position = RareFragments
            Writer.WriteUInt16(valu_frag_rare.Value)
            Writer.Position = SwordHero
            Writer.WriteUInt32(valu_swordhero.Value)
            Writer.Position = DoctorHealmore
            Writer.WriteUInt32(valu_doctorhealmore.Value)
            Writer.Position = HammerLord
            Writer.WriteUInt32(valu_hammerlord.Value)
            Writer.Position = BeamMage
            Writer.WriteUInt32(valu_beammage.Value)
            Writer.Position = HighScores_1
            Writer.WriteUInt32(valu_highscore1.Value)
            Writer.Position = HighScores_2
            Writer.WriteUInt32(valu_highscore2.Value)
            Writer.Position = HighScores_3
            Writer.WriteUInt32(valu_highscore3.Value)
            Writer.Position = HighScores_4
            Writer.WriteUInt32(valu_highscore4.Value)
            Writer.Position = HighScores_5
            Writer.WriteUInt32(valu_highscore5.Value)
            Writer.Position = Time_1
            Writer.WriteUInt16(valu_time_1.Value)
            Writer.Position = Time_2
            Writer.WriteUInt16(valu_time_2.Value)
            Writer.Position = Time_3
            Writer.WriteUInt16(valu_time_3.Value)
            Writer.Position = Time_4
            Writer.WriteUInt16(valu_time_4.Value)
            Writer.Position = Time_5
            Writer.WriteUInt16(valu_time_5.Value)
            Writer.Position = Level_1
            Writer.WriteUInt16(valu_level_1.Value)
            Writer.Position = Level_2
            Writer.WriteUInt16(valu_level_2.Value)
            Writer.Position = Level_3
            Writer.WriteUInt16(valu_level_3.Value)
            Writer.Position = Level_4
            Writer.WriteUInt16(valu_level_4.Value)
            Writer.Position = Level_5
            Writer.WriteUInt16(valu_level_5.Value)
            Writer.Position = Completmission
            Writer.WriteUInt32(valu_competmissions.Value)
            Writer.Position = Playtime
            Writer.WriteUInt32(valu_playtime.Value)
            Writer.Position = Multibattles
            Writer.WriteUInt16(valu_multibattles.Value)
            Writer.Position = Multiencounters
            Writer.WriteUInt16(valu_multiencounters.Value)
            Writer.Position = Profmessage
            Writer.WriteUnicodeString(Text_profmessage.Text)
            If Select_Area.SelectedItem = Select_Area.Items.Item(0) Or Select_Area.SelectedItem = Select_Area.Items.Item(1) Or Select_Area.SelectedItem = Select_Area.Items.Item(2) Or Select_Area.SelectedItem = Select_Area.Items.Item(3) Or Select_Area.SelectedItem = Select_Area.Items.Item(4) Then
                Writer.Position = HighScores_6
                Writer.WriteUInt32(valu_highscore6.Value)
                Writer.Position = Time_6
                Writer.WriteUInt16(valu_time_6.Value)
            End If
            If Select_Area.SelectedItem = Select_Area.Items.Item(0) Or Select_Area.SelectedItem = Select_Area.Items.Item(1) Or Select_Area.SelectedItem = Select_Area.Items.Item(2) Or Select_Area.SelectedItem = Select_Area.Items.Item(3) Then
                Writer.Position = HighScores_7
                Writer.WriteUInt32(valu_highscore7.Value)
                Writer.Position = Time_7
                Writer.WriteUInt16(valu_time_7.Value)
            End If
            If Select_Area.SelectedItem = Select_Area.Items.Item(0) Or Select_Area.SelectedItem = Select_Area.Items.Item(1) Or Select_Area.SelectedItem = Select_Area.Items.Item(2) Then
                Writer.Position = HighScores_8
                Writer.WriteUInt32(valu_highscore8.Value)
                Writer.Position = Time_8
                Writer.WriteUInt16(valu_time_8.Value)
            End If
            If Select_level.SelectedItem = Select_level.Items.Item(0) Or Select_level.SelectedItem = Select_level.Items.Item(1) Or Select_level.SelectedItem = Select_level.Items.Item(2) Or Select_level.SelectedItem = Select_level.Items.Item(3) Or Select_level.SelectedItem = Select_level.Items.Item(4) Then
                Writer.Position = Level_6
                Writer.WriteUInt16(valu_level_6.Value)
            End If
            If Select_level.SelectedItem = Select_level.Items.Item(0) Or Select_level.SelectedItem = Select_level.Items.Item(1) Or Select_level.SelectedItem = Select_level.Items.Item(2) Or Select_level.SelectedItem = Select_level.Items.Item(3) Then
                Writer.Position = Level_7
                Writer.WriteUInt16(valu_level_7.Value)
            End If
            If Select_level.SelectedItem = Select_level.Items.Item(0) Or Select_level.SelectedItem = Select_level.Items.Item(1) Or Select_level.SelectedItem = Select_level.Items.Item(2) Then
                Writer.Position = Level_8
                Writer.WriteUInt16(valu_level_8.Value)
            End If
            Dim fs As New FileStream(savedata, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            fs.Position = staminapot
            fs.WriteByte(valu_staminapot.Value)
            fs.Position = attackpot
            fs.WriteByte(valu_attackpot.Value)
            fs.Position = exporb
            fs.WriteByte(valu_exporb.Value)
            fs.Position = vigor
            fs.WriteByte(valu_vigor.Value)
            fs.Position = Area_1
            fs.WriteByte(valu_area_1.Value)
            fs.Position = Area_2
            fs.WriteByte(valu_area_2.Value)
            fs.Position = Area_3
            fs.WriteByte(valu_area_3.Value)
            fs.Position = Area_4
            fs.WriteByte(valu_area_4.Value)
            fs.Position = Area_5
            fs.WriteByte(valu_area_5.Value)
            fs.Position = Area_6
            fs.WriteByte(valu_area_6.Value)
            fs.Position = Rank_1
            fs.WriteByte(valu_rank_q1.Value)
            fs.Position = Rank_2
            fs.WriteByte(valu_rank_q2.Value)
            fs.Position = Rank_3
            fs.WriteByte(valu_rank_q3.Value)
            fs.Position = Rank_4
            fs.WriteByte(valu_rank_q4.Value)
            fs.Position = Rank_5
            fs.WriteByte(valu_rank_q5.Value)
            fs.Position = Cptlevel_1
            fs.WriteByte(valu_completed_level_1.Value)
            fs.Position = Cptlevel_2
            fs.WriteByte(valu_completed_level_2.Value)
            fs.Position = Cptlevel_3
            fs.WriteByte(valu_completed_level_3.Value)
            fs.Position = Cptlevel_4
            fs.WriteByte(valu_completed_level_4.Value)
            fs.Position = Cptlevel_5
            fs.WriteByte(valu_completed_level_5.Value)
            If Select_Area.SelectedItem = Select_Area.Items.Item(0) Or Select_Area.SelectedItem = Select_Area.Items.Item(1) Or Select_Area.SelectedItem = Select_Area.Items.Item(2) Or Select_Area.SelectedItem = Select_Area.Items.Item(3) Or Select_Area.SelectedItem = Select_Area.Items.Item(4) Then
                fs.Position = Rank_6
                fs.WriteByte(valu_rank_q6.Value)
                fs.Position = Cptlevel_6
                fs.WriteByte(valu_completed_level_6.Value)
            End If
            If Select_Area.SelectedItem = Select_Area.Items.Item(0) Or Select_Area.SelectedItem = Select_Area.Items.Item(1) Or Select_Area.SelectedItem = Select_Area.Items.Item(2) Or Select_Area.SelectedItem = Select_Area.Items.Item(3) Then
                fs.Position = Rank_7
                fs.WriteByte(valu_rank_q7.Value)
                fs.Position = Cptlevel_7
                fs.WriteByte(valu_completed_level_7.Value)
            End If
            If Select_Area.SelectedItem = Select_Area.Items.Item(0) Or Select_Area.SelectedItem = Select_Area.Items.Item(1) Or Select_Area.SelectedItem = Select_Area.Items.Item(2) Then
                fs.Position = Rank_8
                fs.WriteByte(valu_rank_q8.Value)
                fs.Position = Cptlevel_8
                fs.WriteByte(valu_completed_level_8.Value)
            End If
            fdialog.Description.Text = "savedata.dat has been succesfully edited"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Description.Text = "Failed to write savedata.dat, make sure you have opened a good save file or report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Public Sub readhighscores()
        Try
            Dim Reader As New PackageIO.Reader(savedata, PackageIO.Endian.Little)
            Reader.Position = HighScores
            HighScores_1 = Reader.Position
            valu_highscore1.Value = Reader.ReadUInt32
            Reader.Position = Time + 6
            Cptlevel_1 = Reader.Position
            valu_completed_level_1.Value = Reader.ReadByte
            Reader.Position = Rank
            Rank_1 = Reader.Position
            valu_rank_q1.Value = Reader.ReadByte
            Reader.Position = Time
            Time_1 = Reader.Position
            valu_time_1.Value = Reader.ReadUInt16
            Reader.Position = HighScores + &H10
            HighScores_2 = Reader.Position
            valu_highscore2.Value = Reader.ReadUInt32
            Reader.Position = Time + 6 + &H10
            Cptlevel_2 = Reader.Position
            valu_completed_level_2.Value = Reader.ReadByte
            Reader.Position = Rank + &H10
            Rank_2 = Reader.Position
            valu_rank_q2.Value = Reader.ReadByte
            Reader.Position = Time + &H10
            Time_2 = Reader.Position
            valu_time_2.Value = Reader.ReadUInt16
            Reader.Position = HighScores + &H20
            HighScores_3 = Reader.Position
            valu_highscore3.Value = Reader.ReadUInt32
            Reader.Position = Time + 6 + &H20
            Cptlevel_3 = Reader.Position
            valu_completed_level_3.Value = Reader.ReadByte
            Reader.Position = Rank + &H20
            Rank_3 = Reader.Position
            valu_rank_q3.Value = Reader.ReadByte
            Reader.Position = Time + &H20
            Time_3 = Reader.Position
            valu_time_3.Value = Reader.ReadUInt16
            Reader.Position = HighScores + &H30
            HighScores_4 = Reader.Position
            valu_highscore4.Value = Reader.ReadUInt32
            Reader.Position = Time + 6 + &H30
            Cptlevel_4 = Reader.Position
            valu_completed_level_4.Value = Reader.ReadByte
            Reader.Position = Rank + &H30
            Rank_4 = Reader.Position
            valu_rank_q4.Value = Reader.ReadByte
            Reader.Position = Time + &H30
            Time_4 = Reader.Position
            valu_time_4.Value = Reader.ReadUInt16
            Reader.Position = HighScores + &H40
            HighScores_5 = Reader.Position
            valu_highscore5.Value = Reader.ReadUInt32
            Reader.Position = Time + 6 + &H40
            Cptlevel_5 = Reader.Position
            valu_completed_level_5.Value = Reader.ReadByte
            Reader.Position = Rank + &H40
            Rank_5 = Reader.Position
            valu_rank_q5.Value = Reader.ReadByte
            Reader.Position = Time + &H40
            Time_5 = Reader.Position
            valu_time_5.Value = Reader.ReadUInt16
            Reader.Position = HighScores + &H50
            HighScores_6 = Reader.Position
            valu_highscore6.Value = Reader.ReadUInt32
            Reader.Position = Time + 6 + &H50
            Cptlevel_6 = Reader.Position
            valu_completed_level_6.Value = Reader.ReadByte
            Reader.Position = Rank + &H50
            Rank_6 = Reader.Position
            valu_rank_q6.Value = Reader.ReadByte
            Reader.Position = Time + &H50
            Time_6 = Reader.Position
            valu_time_6.Value = Reader.ReadUInt16
            Reader.Position = HighScores + &H60
            HighScores_7 = Reader.Position
            valu_highscore7.Value = Reader.ReadUInt32
            Reader.Position = Time + 6 + &H60
            Cptlevel_7 = Reader.Position
            valu_completed_level_7.Value = Reader.ReadByte
            Reader.Position = Rank + &H60
            Rank_7 = Reader.Position
            valu_rank_q7.Value = Reader.ReadByte
            Reader.Position = Time + &H60
            Time_7 = Reader.Position
            valu_time_7.Value = Reader.ReadUInt16
            Reader.Position = HighScores + &H70
            HighScores_8 = Reader.Position
            valu_highscore8.Value = Reader.ReadUInt32
            Reader.Position = Time + 6 + &H70
            Cptlevel_8 = Reader.Position
            valu_completed_level_8.Value = Reader.ReadByte
            Reader.Position = Rank + &H70
            Rank_8 = Reader.Position
            valu_rank_q8.Value = Reader.ReadByte
            Reader.Position = Time + &H70
            Time_8 = Reader.Position
            valu_time_8.Value = Reader.ReadUInt16
        Catch ex As Exception
            fdialog.Description.Text = "Failed to read savedata.dat, make sure you have opened a save file or report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Public Sub readlevels()
        Try
            Dim Reader As New PackageIO.Reader(savedata, PackageIO.Endian.Little)
            Reader.Position = Level
            Level_1 = Reader.Position
            valu_level_1.Value = Reader.ReadUInt16
            Reader.Position = Level + &H10
            Level_2 = Reader.Position
            valu_level_2.Value = Reader.ReadUInt16
            Reader.Position = Level + &H20
            Level_3 = Reader.Position
            valu_level_3.Value = Reader.ReadUInt16
            Reader.Position = Level + &H30
            Level_4 = Reader.Position
            valu_level_4.Value = Reader.ReadUInt16
            Reader.Position = Level + &H40
            Level_5 = Reader.Position
            valu_level_5.Value = Reader.ReadUInt16
            If Select_level.SelectedItem = Select_level.Items.Item(0) Or Select_level.SelectedItem = Select_level.Items.Item(1) Or Select_level.SelectedItem = Select_level.Items.Item(2) Or Select_level.SelectedItem = Select_level.Items.Item(3) Or Select_level.SelectedItem = Select_level.Items.Item(4) Then
                Reader.Position = Level + &H50
                Level_6 = Reader.Position
                valu_level_6.Value = Reader.ReadUInt16
            End If
            If Select_level.SelectedItem = Select_level.Items.Item(0) Or Select_level.SelectedItem = Select_level.Items.Item(1) Or Select_level.SelectedItem = Select_level.Items.Item(2) Or Select_level.SelectedItem = Select_level.Items.Item(3) Then
                Reader.Position = Level + &H60
                Level_7 = Reader.Position
                valu_level_7.Value = Reader.ReadUInt16
            End If
            If Select_level.SelectedItem = Select_level.Items.Item(0) Or Select_level.SelectedItem = Select_level.Items.Item(1) Or Select_level.SelectedItem = Select_level.Items.Item(2) Then
                Reader.Position = Level + &H70
                Level_8 = Reader.Position
                valu_level_8.Value = Reader.ReadUInt16
            End If
        Catch ex As Exception
            fdialog.Description.Text = "Failed to read savedata.dat, make sure you have opened a save file or report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Public Sub makebaksavedata()
        Try
            My.Computer.FileSystem.CopyFile(
                          savedata,
                        applicationpath & "\backup\Team Kirby Clash Deluxe\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedata.dat")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Text_menu_button_Click(sender As Object, e As EventArgs) Handles Text_menu_button.Click
        If Menu_panel.Visible = True Then
            Menu_panel.Visible = False
        Else
            Menu_panel.Visible = True
        End If
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        fdialog.BackgroundImage = My.Resources.N3DSSEL_fdialog
        Me.Close()
        N3DSSE_library.Show()
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Menu_itemsediting_Click(sender As Object, e As EventArgs) Handles Menu_itemsediting.Click, Menu_text_itemsediting.Click
        hidepanels()
        Panel_itemsediting.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_highscoreediting_Click(sender As Object, e As EventArgs) Handles Menu_highscoresediting.Click, Menu_text_highscoresediting.Click
        hidepanels()
        Panel_highscoresediting.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_lvlareaediting_Click(sender As Object, e As EventArgs) Handles Menu_lvlareaediting.Click, Menu_text_lvlareaediting.Click
        hidepanels()
        Panel_lvlareaediting.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_missionsediting_Click(sender As Object, e As EventArgs) Handles Menu_missionsediting.Click, Menu_text_missionsediting.Click
        hidepanels()
        Panel_missionsediting.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_width_Click(sender As Object, e As EventArgs) Handles Menu_width.Click
        If Menu_panel.Width = 34 Then
            Menu_panel.Width = 150
            Menu_width.Location = New Point(116, 0)
        Else
            Menu_panel.Width = 34
            Menu_width.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub Text_menu_opensave_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Dim open As New OpenFileDialog
        fdialog.Description.Text = "Open savedata.dat" & vbNewLine & "Team Kirby Clash Deluxe Save Editor will make a backup of your save file, check ''backup'' folder"
        fdialog.ShowDialog()
        open.Filter = "DAT files|*savedata.dat"
        open.Title = "Open save savedata.dat"
        open.ShowDialog()
        savedata = open.FileName
        readfilesavedata()
        TextBox_fpath.Text = savedata
        makebaksavedata()
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        writefilesavedata()
    End Sub

    Private Sub Select_Area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Area.SelectedIndexChanged
        hidepanelsarea()
        If Select_Area.SelectedItem = Select_Area.Items.Item(0) Then
            Panel_quest6.Visible = True
            Panel_quest7.Visible = True
            Panel_quest8.Visible = True
            Text_area.Text = ": The Grasslands​"
            Text_title_q1.Text = "Colossal Waddle Dee"
            Text_title_q2.Text = "Mr. Frosty"
            Text_title_q3.Text = "King Doo"
            Text_title_q4.Text = "Kibble Blade"
            Text_title_q5.Text = "Tough: Gigant Adge"
            Text_title_q6.Text = "Tough: Ice Dragon"
            Text_title_q7.Text = "Tougher: Blocky"
            Text_title_q8.Text = "Tougher: Miasmoros"
            HighScores = &HD90
            Rank = &HD94
            Time = &HD98
        ElseIf Select_Area.SelectedItem = Select_Area.Items.Item(1) Then
            Panel_quest6.Visible = True
            Panel_quest7.Visible = True
            Panel_quest8.Visible = True
            Text_area.Text = ": The Dunes​​"
            Text_title_q1.Text = "Gigant Edge"
            Text_title_q2.Text = "Kracko"
            Text_title_q3.Text = "Bonkers"
            Text_title_q4.Text = "Tough: King Doo"
            Text_title_q5.Text = "Tough: Blocky"
            Text_title_q6.Text = "Tougher: Mr. Frosty"
            Text_title_q7.Text = "Tougher: Kibble Blade"
            Text_title_q8.Text = "Tougher: Greater Doomer"
            HighScores = &HE30
            Rank = &HE34
            Time = &HE38
        ElseIf Select_Area.SelectedItem = Select_Area.Items.Item(2) Then
            Panel_quest6.Visible = True
            Panel_quest7.Visible = True
            Panel_quest8.Visible = True
            Text_area.Text = ": The Ruins​​"
            Text_title_q1.Text = "Colossal Double-Team"
            Text_title_q2.Text = "Blocky"
            Text_title_q3.Text = "Whispy Woods"
            Text_title_q4.Text = "Tough: Kibble Blade"
            Text_title_q5.Text = "Tough: Greater Doomer"
            Text_title_q6.Text = "Tough: Mr. Frosty"
            Text_title_q7.Text = "Tougher: King Doo"
            Text_title_q8.Text = "Tougher: Whispy Woods"
            HighScores = &HED0
            Rank = &HED4
            Time = &HED8
        ElseIf Select_Area.SelectedItem = Select_Area.Items.Item(3) Then
            Panel_quest6.Visible = True
            Panel_quest7.Visible = True
            Panel_quest8.Visible = False
            Text_area.Text = ": The Volcano​"
            Text_title_q1.Text = "Tough: Colossal Triple-Team"
            Text_title_q2.Text = "Tough: Miasmoros"
            Text_title_q3.Text = "Tough: Pyribbit"
            Text_title_q4.Text = "Tough: Bonkers"
            Text_title_q5.Text = "Tougher: Ice Dragon"
            Text_title_q6.Text = "Tougher: Telepathos"
            Text_title_q7.Text = "Tougher: Pyribbit"
            HighScores = &HF70
            Rank = &HF74
            Time = &HF78
        ElseIf Select_Area.SelectedItem = Select_Area.Items.Item(4) Then
            Panel_quest6.Visible = True
            Panel_quest7.Visible = False
            Panel_quest8.Visible = False
            Text_area.Text = ": The Empyrean​"
            Text_title_q1.Text = "Tough: Telepathos"
            Text_title_q2.Text = "Tough: Landia"
            Text_title_q3.Text = "Tough: Taranza"
            Text_title_q4.Text = "Tougher: Gigant Edge"
            Text_title_q5.Text = "Tougher: Bonkers"
            Text_title_q6.Text = "Tougher: Kracko"
            HighScores = &H1010
            Rank = &H1014
            Time = &H1018
        ElseIf Select_Area.SelectedItem = Select_Area.Items.Item(5) Then
            Panel_quest6.Visible = False
            Panel_quest7.Visible = False
            Panel_quest8.Visible = False
            Text_area.Text = ": Decisive Battlefield​"
            Text_title_q1.Text = "Tougher: Landia EX"
            Text_title_q2.Text = "Tougher: Parallel Susie"
            Text_title_q3.Text = "Tougher: Parallel Landia"
            Text_title_q4.Text = "Tougher: The Final Battle"
            Text_title_q5.Text = "Toughest: The True Final Battle"
            HighScores = &H10B0
            Rank = &H10B4
            Time = &H10B8
        End If
        readhighscores()
    End Sub

    Private Sub valu_tree_ValueChanged(sender As Object, e As EventArgs) Handles valu_tree.ValueChanged
        If valu_tree.Value <= 49 Then
            Select_tree.SelectedItem = Select_tree.Items.Item(0)
        ElseIf valu_tree.Value >= 50 And valu_tree.Value <= 399 Then
            Select_tree.SelectedItem = Select_tree.Items.Item(1)
        ElseIf valu_tree.Value >= 400 And valu_tree.Value <= 999 Then
            Select_tree.SelectedItem = Select_tree.Items.Item(2)
        ElseIf valu_tree.Value >= 1000 And valu_tree.Value <= 1699 Then
            Select_tree.SelectedItem = Select_tree.Items.Item(3)
        ElseIf valu_tree.Value >= 1700 And valu_tree.Value <= 2999 Then
            Select_tree.SelectedItem = Select_tree.Items.Item(4)
        ElseIf valu_tree.Value >= 3000 Then
            Select_tree.SelectedItem = Select_tree.Items.Item(5)
        End If
    End Sub

    Private Sub Select_tree_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_tree.SelectedIndexChanged
        If Select_tree.SelectedItem = Select_tree.Items.Item(0) Then
            valu_tree.Value = 0
        ElseIf Select_tree.SelectedItem = Select_tree.Items.Item(1) Then
            valu_tree.Value = 50
        ElseIf Select_tree.SelectedItem = Select_tree.Items.Item(2) Then
            valu_tree.Value = 400
        ElseIf Select_tree.SelectedItem = Select_tree.Items.Item(3) Then
            valu_tree.Value = 1000
        ElseIf Select_tree.SelectedItem = Select_tree.Items.Item(4) Then
            valu_tree.Value = 1700
        ElseIf Select_tree.SelectedItem = Select_tree.Items.Item(5) Then
            valu_tree.Value = 3000
        End If
    End Sub

    Private Sub TeamKirbyClashDeluxe_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.TKCD_settings_menu = Menu_panel.Width
    End Sub

    Private Sub TeamKirbyClashDeluxe_Load(sender As Object, e As EventArgs) Handles Me.Load
        fdialog.BackgroundImage = My.Resources.TKCD_fdialog
        Select_tree.SelectedItem = Select_tree.Items.Item(0)
        Try
            Menu_panel.Width = My.Settings.TKCD_settings_menu
        Catch ex As Exception
        End Try
        If Menu_panel.Width = 150 Then
            Menu_width.Location = New Point(116, 0)
        ElseIf Menu_panel.Width = 34 Then
            Menu_width.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub Check_available_level_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_level_1.CheckedChanged
        If Check_available_level_1.Checked = True Then
            valu_level_1.Value = 5
        End If
    End Sub

    Private Sub Check_NA_level_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_level_1.CheckedChanged
        If Check_NA_level_1.Checked = True Then
            valu_level_1.Value = 1
        End If
    End Sub

    Private Sub Check_new_level_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_new_level_1.CheckedChanged
        If Check_new_level_1.Checked = True Then
            valu_level_1.Value = 261
        End If
    End Sub

    Private Sub Check_available_level_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_level_2.CheckedChanged
        If Check_available_level_2.Checked = True Then
            valu_level_2.Value = 5
        End If
    End Sub

    Private Sub Check_NA_level_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_level_2.CheckedChanged
        If Check_NA_level_2.Checked = True Then
            valu_level_2.Value = 1
        End If
    End Sub

    Private Sub Check_new_level_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_new_level_2.CheckedChanged
        If Check_new_level_2.Checked = True Then
            valu_level_2.Value = 261
        End If
    End Sub

    Private Sub Check_available_level_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_level_3.CheckedChanged
        If Check_available_level_3.Checked = True Then
            valu_level_3.Value = 5
        End If
    End Sub

    Private Sub Check_NA_level_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_level_3.CheckedChanged
        If Check_NA_level_3.Checked = True Then
            valu_level_3.Value = 1
        End If
    End Sub

    Private Sub Check_new_level_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_new_level_3.CheckedChanged
        If Check_new_level_3.Checked = True Then
            valu_level_3.Value = 261
        End If
    End Sub

    Private Sub Check_available_level_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_level_4.CheckedChanged
        If Check_available_level_4.Checked = True Then
            valu_level_4.Value = 5
        End If
    End Sub

    Private Sub Check_NA_level_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_level_4.CheckedChanged
        If Check_NA_level_4.Checked = True Then
            valu_level_4.Value = 1
        End If
    End Sub

    Private Sub Check_new_level_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_new_level_4.CheckedChanged
        If Check_new_level_4.Checked = True Then
            valu_level_4.Value = 261
        End If
    End Sub

    Private Sub Check_available_level_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_level_5.CheckedChanged
        If Check_available_level_5.Checked = True Then
            valu_level_5.Value = 5
        End If
    End Sub

    Private Sub Check_NA_level_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_level_5.CheckedChanged
        If Check_NA_level_5.Checked = True Then
            valu_level_5.Value = 1
        End If
    End Sub

    Private Sub Check_new_level_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_new_level_5.CheckedChanged
        If Check_new_level_5.Checked = True Then
            valu_level_5.Value = 261
        End If
    End Sub

    Private Sub Check_available_level_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_level_6.CheckedChanged
        If Check_available_level_6.Checked = True Then
            valu_level_6.Value = 5
        End If
    End Sub

    Private Sub Check_NA_level_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_level_6.CheckedChanged
        If Check_NA_level_6.Checked = True Then
            valu_level_6.Value = 1
        End If
    End Sub

    Private Sub Check_new_level_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_new_level_6.CheckedChanged
        If Check_new_level_6.Checked = True Then
            valu_level_6.Value = 261
        End If
    End Sub

    Private Sub Check_available_level_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_level_7.CheckedChanged
        If Check_available_level_7.Checked = True Then
            valu_level_7.Value = 5
        End If
    End Sub

    Private Sub Check_NA_level_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_level_7.CheckedChanged
        If Check_NA_level_7.Checked = True Then
            valu_level_7.Value = 1
        End If
    End Sub

    Private Sub Check_new_level_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_new_level_7.CheckedChanged
        If Check_new_level_7.Checked = True Then
            valu_level_7.Value = 261
        End If
    End Sub

    Private Sub Check_available_level_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_level_8.CheckedChanged
        If Check_available_level_8.Checked = True Then
            valu_level_8.Value = 5
        End If
    End Sub

    Private Sub Check_NA_level_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_level_8.CheckedChanged
        If Check_NA_level_8.Checked = True Then
            valu_level_8.Value = 1
        End If
    End Sub

    Private Sub Check_new_level_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_new_level_8.CheckedChanged
        If Check_new_level_8.Checked = True Then
            valu_level_8.Value = 261
        End If
    End Sub

    Private Sub valu_level_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_level_1.ValueChanged
        If valu_level_1.Value = 5 Then
            Check_available_level_1.Checked = True
        ElseIf valu_level_1.Value = 1 Then
            Check_NA_level_1.Checked = True
        ElseIf valu_level_1.Value = 261 Then
            Check_new_level_1.Checked = True
        End If
    End Sub

    Private Sub valu_level_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_level_2.ValueChanged
        If valu_level_2.Value = 5 Then
            Check_available_level_2.Checked = True
        ElseIf valu_level_2.Value = 1 Then
            Check_NA_level_2.Checked = True
        ElseIf valu_level_2.Value = 261 Then
            Check_new_level_2.Checked = True
        End If
    End Sub

    Private Sub valu_level_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_level_3.ValueChanged
        If valu_level_3.Value = 5 Then
            Check_available_level_3.Checked = True
        ElseIf valu_level_3.Value = 1 Then
            Check_NA_level_3.Checked = True
        ElseIf valu_level_3.Value = 261 Then
            Check_new_level_3.Checked = True
        End If
    End Sub

    Private Sub valu_level_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_level_4.ValueChanged
        If valu_level_4.Value = 5 Then
            Check_available_level_4.Checked = True
        ElseIf valu_level_4.Value = 1 Then
            Check_NA_level_4.Checked = True
        ElseIf valu_level_4.Value = 261 Then
            Check_new_level_4.Checked = True
        End If
    End Sub

    Private Sub valu_level_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_level_5.ValueChanged
        If valu_level_5.Value = 5 Then
            Check_available_level_5.Checked = True
        ElseIf valu_level_5.Value = 1 Then
            Check_NA_level_5.Checked = True
        ElseIf valu_level_5.Value = 261 Then
            Check_new_level_5.Checked = True
        End If
    End Sub

    Private Sub valu_level_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_level_6.ValueChanged
        If valu_level_6.Value = 5 Then
            Check_available_level_6.Checked = True
        ElseIf valu_level_6.Value = 1 Then
            Check_NA_level_6.Checked = True
        ElseIf valu_level_6.Value = 261 Then
            Check_new_level_6.Checked = True
        End If
    End Sub

    Private Sub valu_level_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_level_7.ValueChanged
        If valu_level_7.Value = 5 Then
            Check_available_level_7.Checked = True
        ElseIf valu_level_7.Value = 1 Then
            Check_NA_level_7.Checked = True
        ElseIf valu_level_7.Value = 261 Then
            Check_new_level_7.Checked = True
        End If
    End Sub

    Private Sub valu_level_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_level_8.ValueChanged
        If valu_level_8.Value = 5 Then
            Check_available_level_8.Checked = True
        ElseIf valu_level_8.Value = 1 Then
            Check_NA_level_8.Checked = True
        ElseIf valu_level_8.Value = 261 Then
            Check_new_level_8.Checked = True
        End If
    End Sub

    Private Sub valu_area_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_area_1.ValueChanged
        If valu_area_1.Value = 1 Then
            Icon_area_1.Image = My.Resources.EN_arean_1
        ElseIf valu_area_1.Value = 5 Then
            Icon_area_1.Image = My.Resources.EN_area_1
        End If
    End Sub

    Private Sub valu_area_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_area_2.ValueChanged
        If valu_area_2.Value = 1 Then
            Icon_area_2.Image = My.Resources.EN_arean_2
        ElseIf valu_area_2.Value = 5 Then
            Icon_area_2.Image = My.Resources.EN_area_2
        End If
    End Sub

    Private Sub valu_area_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_area_3.ValueChanged
        If valu_area_3.Value = 1 Then
            Icon_area_3.Image = My.Resources.EN_arean_3
        ElseIf valu_area_3.Value = 5 Then
            Icon_area_3.Image = My.Resources.EN_area_3
        End If
    End Sub

    Private Sub valu_area_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_area_4.ValueChanged
        If valu_area_4.Value = 1 Then
            Icon_area_4.Image = My.Resources.EN_arean_4
        ElseIf valu_area_4.Value = 5 Then
            Icon_area_4.Image = My.Resources.EN_area_4
        End If
    End Sub

    Private Sub valu_area_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_area_5.ValueChanged
        If valu_area_5.Value = 1 Then
            Icon_area_5.Image = My.Resources.EN_arean_5
        ElseIf valu_area_5.Value = 5 Then
            Icon_area_5.Image = My.Resources.EN_area_5
        End If
    End Sub

    Private Sub valu_area_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_area_6.ValueChanged
        If valu_area_6.Value = 1 Then
            Icon_area_6.Image = My.Resources.EN_arean_6
        ElseIf valu_area_6.Value = 5 Then
            Icon_area_6.Image = My.Resources.EN_area_6
        End If
    End Sub

    Private Sub Icon_area_MouseMove(sender As Object, e As EventArgs) Handles Icon_area_1.MouseMove, Icon_area_2.MouseMove, Icon_area_3.MouseMove, Icon_area_4.MouseMove, Icon_area_5.MouseMove, Icon_area_6.MouseMove
        Text_description.Text = "Click to unlock an area"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_area_MouseLeave(sender As Object, e As EventArgs) Handles Icon_area_1.MouseLeave, Icon_area_2.MouseLeave, Icon_area_3.MouseLeave, Icon_area_4.MouseLeave, Icon_area_5.MouseLeave, Icon_area_6.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_area_1_Click(sender As Object, e As EventArgs) Handles Icon_area_1.Click
        If valu_area_1.Value = 1 Then
            valu_area_1.Value = 5
        ElseIf valu_area_1.Value = 5 Then
            valu_area_1.Value = 1
        End If
    End Sub

    Private Sub Icon_area_2_Click(sender As Object, e As EventArgs) Handles Icon_area_2.Click
        If valu_area_2.Value = 1 Then
            valu_area_2.Value = 5
        ElseIf valu_area_2.Value = 5 Then
            valu_area_2.Value = 1
        End If
    End Sub

    Private Sub Icon_area_3_Click(sender As Object, e As EventArgs) Handles Icon_area_3.Click
        If valu_area_3.Value = 1 Then
            valu_area_3.Value = 5
        ElseIf valu_area_3.Value = 5 Then
            valu_area_3.Value = 1
        End If
    End Sub

    Private Sub Icon_area_4_Click(sender As Object, e As EventArgs) Handles Icon_area_4.Click
        If valu_area_4.Value = 1 Then
            valu_area_4.Value = 5
        ElseIf valu_area_4.Value = 5 Then
            valu_area_4.Value = 1
        End If
    End Sub

    Private Sub Icon_area_5_Click(sender As Object, e As EventArgs) Handles Icon_area_5.Click
        If valu_area_5.Value = 1 Then
            valu_area_5.Value = 5
        ElseIf valu_area_5.Value = 5 Then
            valu_area_5.Value = 1
        End If
    End Sub

    Private Sub Icon_area_6_Click(sender As Object, e As EventArgs) Handles Icon_area_6.Click
        If valu_area_6.Value = 1 Then
            valu_area_6.Value = 5
        ElseIf valu_area_6.Value = 5 Then
            valu_area_6.Value = 1
        End If
    End Sub

    Private Sub Select_level_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_level.SelectedIndexChanged
        If Select_level.SelectedItem = Select_level.Items.Item(0) Then
            Panel_level_6.Visible = True
            Panel_level_7.Visible = True
            Panel_level_8.Visible = True
            Text_area.Text = ": The Grasslands"
            Text_level_1.Text = "Colossal Waddle Dee"
            Text_level_2.Text = "Mr. Frosty"
            Text_level_3.Text = "King Doo"
            Text_level_4.Text = "Kibble Blade"
            Text_level_5.Text = "Tough: Gigant Adge"
            Text_level_6.Text = "Tough: Ice Dragon"
            Text_level_7.Text = "Tougher: Blocky"
            Text_level_8.Text = "Tougher: Miasmoros"
            Level = &HD8C
        ElseIf Select_level.SelectedItem = Select_level.Items.Item(1) Then
            Panel_level_6.Visible = True
            Panel_level_7.Visible = True
            Panel_level_8.Visible = True
            Text_area.Text = ": The Dunes"
            Text_level_1.Text = "Gigant Edge"
            Text_level_2.Text = "Kracko"
            Text_level_3.Text = "Bonkers"
            Text_level_4.Text = "Tough: King Doo"
            Text_level_5.Text = "Tough: Blocky"
            Text_level_6.Text = "Tougher: Mr. Frosty"
            Text_level_7.Text = "Tougher: Kibble Blade"
            Text_level_8.Text = "Tougher: Greater Doomer"
            Level = &HE0C
        ElseIf Select_level.SelectedItem = Select_level.Items.Item(2) Then
            Panel_level_6.Visible = True
            Panel_level_7.Visible = True
            Panel_level_8.Visible = True
            Text_area.Text = ": The Ruins"
            Text_level_1.Text = "Colossal Double-Team"
            Text_level_2.Text = "Blocky"
            Text_level_3.Text = "Whispy Woods"
            Text_level_4.Text = "Tough: Kibble Blade"
            Text_level_5.Text = "Tough: Greater Doomer"
            Text_level_6.Text = "Tough: Mr. Frosty"
            Text_level_7.Text = "Tougher: King Doo"
            Text_level_8.Text = "Tougher: Whispy Woods"
            Level = &HE8C
        ElseIf Select_level.SelectedItem = Select_level.Items.Item(3) Then
            Panel_level_6.Visible = True
            Panel_level_7.Visible = True
            Panel_level_8.Visible = False
            Text_area.Text = ": The Volcano"
            Text_level_1.Text = "Tough: Colossal Triple-Team"
            Text_level_2.Text = "Tough: Miasmoros"
            Text_level_3.Text = "Tough: Pyribbit"
            Text_level_4.Text = "Tough: Bonkers"
            Text_level_5.Text = "Tougher: Ice Dragon"
            Text_level_6.Text = "Tougher: Telepathos"
            Text_level_7.Text = "Tougher: Pyribbit"
            Level = &HF0C
        ElseIf Select_level.SelectedItem = Select_level.Items.Item(4) Then
            Panel_level_6.Visible = True
            Panel_level_7.Visible = False
            Panel_level_8.Visible = False
            Text_area.Text = ": The Empyrean"
            Text_level_1.Text = "Tough: Telepathos"
            Text_level_2.Text = "Tough: Landia"
            Text_level_3.Text = "Tough: Taranza"
            Text_level_4.Text = "Tougher: Gigant Edge"
            Text_level_5.Text = "Tougher: Bonkers"
            Text_level_6.Text = "Tougher: Kracko"
            Level = &HF7C
        ElseIf Select_level.SelectedItem = Select_level.Items.Item(5) Then
            Panel_level_6.Visible = False
            Panel_level_7.Visible = False
            Panel_level_8.Visible = False
            Text_area.Text = ": Decisive Battlefield"
            Text_level_1.Text = "Tougher: Landia EX"
            Text_level_2.Text = "Tougher: Parallel Susie"
            Text_level_3.Text = "Tougher: Parallel Landia"
            Text_level_4.Text = "Tougher: The Final Battle"
            Text_level_5.Text = "Toughest: The True Final Battle"
            Level = &HFDC
        End If
        readlevels()
    End Sub

    Private Sub Text_vigor_Click(sender As Object, e As EventArgs) Handles Text_vigor.Click, Fea_vigor.Click
        valu_vigor.Value = 255
    End Sub

    Private Sub Fea_vigor_MouseMove(sender As Object, e As EventArgs) Handles Fea_vigor.MouseMove, Text_vigor.MouseMove
        Text_description.Text = "Click to max vigor"
        Panel_description.Visible = True
    End Sub

    Private Sub Fea_vigor_MouseLeave(sender As Object, e As EventArgs) Handles Fea_vigor.MouseLeave, Text_vigor.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Info_level_MouseMove(sender As Object, e As EventArgs) Handles Info_level.MouseMove
        Panel_info_level.Visible = True
    End Sub

    Private Sub Info_level_MouseLeave(sender As Object, e As EventArgs) Handles Info_level.MouseLeave
        Panel_info_level.Visible = False
    End Sub

    Private Sub valu_rank_q1_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_q1.ValueChanged
        If valu_rank_q1.Value = 0 And valu_completed_level_1.Value = 0 Then
            Icon_rank_q1.Image = My.Resources.TKCD_icon_rank_na
        ElseIf valu_rank_q1.Value = 0 And valu_completed_level_1.Value = 1 Then
            Icon_rank_q1.Image = My.Resources.TKCD_icon_rank_bronze
        ElseIf valu_rank_q1.Value = 1 And valu_completed_level_1.Value = 1 Then
            Icon_rank_q1.Image = My.Resources.TKCD_icon_rank_silver
        ElseIf valu_rank_q1.Value = 2 And valu_completed_level_1.Value = 1 Then
            Icon_rank_q1.Image = My.Resources.TKCD_icon_rank_gold
        ElseIf valu_rank_q1.Value = 3 And valu_completed_level_1.Value = 1 Then
            Icon_rank_q1.Image = My.Resources.TKCD_icon_rank_platinium
        End If
    End Sub

    Private Sub valu_rank_q2_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_q2.ValueChanged
        If valu_rank_q2.Value = 0 And valu_completed_level_2.Value = 0 Then
            Icon_rank_q2.Image = My.Resources.TKCD_icon_rank_na
        ElseIf valu_rank_q2.Value = 0 And valu_completed_level_2.Value = 1 Then
            Icon_rank_q2.Image = My.Resources.TKCD_icon_rank_bronze
        ElseIf valu_rank_q2.Value = 1 And valu_completed_level_2.Value = 1 Then
            Icon_rank_q2.Image = My.Resources.TKCD_icon_rank_silver
        ElseIf valu_rank_q2.Value = 2 And valu_completed_level_2.Value = 1 Then
            Icon_rank_q2.Image = My.Resources.TKCD_icon_rank_gold
        ElseIf valu_rank_q2.Value = 3 And valu_completed_level_2.Value = 1 Then
            Icon_rank_q2.Image = My.Resources.TKCD_icon_rank_platinium
        End If
    End Sub

    Private Sub valu_rank_q3_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_q3.ValueChanged
        If valu_rank_q3.Value = 0 And valu_completed_level_3.Value = 0 Then
            Icon_rank_q3.Image = My.Resources.TKCD_icon_rank_na
        ElseIf valu_rank_q3.Value = 0 And valu_completed_level_3.Value = 1 Then
            Icon_rank_q3.Image = My.Resources.TKCD_icon_rank_bronze
        ElseIf valu_rank_q3.Value = 1 And valu_completed_level_3.Value = 1 Then
            Icon_rank_q3.Image = My.Resources.TKCD_icon_rank_silver
        ElseIf valu_rank_q3.Value = 2 And valu_completed_level_3.Value = 1 Then
            Icon_rank_q3.Image = My.Resources.TKCD_icon_rank_gold
        ElseIf valu_rank_q3.Value = 3 And valu_completed_level_3.Value = 1 Then
            Icon_rank_q3.Image = My.Resources.TKCD_icon_rank_platinium
        End If
    End Sub

    Private Sub valu_rank_q4_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_q4.ValueChanged
        If valu_rank_q4.Value = 0 And valu_completed_level_4.Value = 0 Then
            Icon_rank_q4.Image = My.Resources.TKCD_icon_rank_na
        ElseIf valu_rank_q4.Value = 0 And valu_completed_level_4.Value = 1 Then
            Icon_rank_q4.Image = My.Resources.TKCD_icon_rank_bronze
        ElseIf valu_rank_q4.Value = 1 And valu_completed_level_4.Value = 1 Then
            Icon_rank_q4.Image = My.Resources.TKCD_icon_rank_silver
        ElseIf valu_rank_q4.Value = 2 And valu_completed_level_4.Value = 1 Then
            Icon_rank_q4.Image = My.Resources.TKCD_icon_rank_gold
        ElseIf valu_rank_q4.Value = 3 And valu_completed_level_4.Value = 1 Then
            Icon_rank_q4.Image = My.Resources.TKCD_icon_rank_platinium
        End If
    End Sub

    Private Sub valu_rank_q5_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_q5.ValueChanged
        If valu_rank_q5.Value = 0 And valu_completed_level_5.Value = 0 Then
            Icon_rank_q5.Image = My.Resources.TKCD_icon_rank_na
        ElseIf valu_rank_q5.Value = 0 And valu_completed_level_5.Value = 1 Then
            Icon_rank_q5.Image = My.Resources.TKCD_icon_rank_bronze
        ElseIf valu_rank_q5.Value = 1 And valu_completed_level_5.Value = 1 Then
            Icon_rank_q5.Image = My.Resources.TKCD_icon_rank_silver
        ElseIf valu_rank_q5.Value = 2 And valu_completed_level_5.Value = 1 Then
            Icon_rank_q5.Image = My.Resources.TKCD_icon_rank_gold
        ElseIf valu_rank_q5.Value = 3 And valu_completed_level_5.Value = 1 Then
            Icon_rank_q5.Image = My.Resources.TKCD_icon_rank_platinium
        End If
    End Sub

    Private Sub valu_rank_q6_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_q6.ValueChanged
        If valu_rank_q6.Value = 0 And valu_completed_level_6.Value = 0 Then
            Icon_rank_q6.Image = My.Resources.TKCD_icon_rank_na
        ElseIf valu_rank_q6.Value = 0 And valu_completed_level_6.Value = 1 Then
            Icon_rank_q6.Image = My.Resources.TKCD_icon_rank_bronze
        ElseIf valu_rank_q6.Value = 1 And valu_completed_level_6.Value = 1 Then
            Icon_rank_q6.Image = My.Resources.TKCD_icon_rank_silver
        ElseIf valu_rank_q6.Value = 2 And valu_completed_level_6.Value = 1 Then
            Icon_rank_q6.Image = My.Resources.TKCD_icon_rank_gold
        ElseIf valu_rank_q6.Value = 3 And valu_completed_level_6.Value = 1 Then
            Icon_rank_q6.Image = My.Resources.TKCD_icon_rank_platinium
        End If
    End Sub

    Private Sub valu_rank_q7_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_q7.ValueChanged
        If valu_rank_q7.Value = 0 And valu_completed_level_7.Value = 0 Then
            Icon_rank_q7.Image = My.Resources.TKCD_icon_rank_na
        ElseIf valu_rank_q7.Value = 0 And valu_completed_level_7.Value = 1 Then
            Icon_rank_q7.Image = My.Resources.TKCD_icon_rank_bronze
        ElseIf valu_rank_q7.Value = 1 And valu_completed_level_7.Value = 1 Then
            Icon_rank_q7.Image = My.Resources.TKCD_icon_rank_silver
        ElseIf valu_rank_q7.Value = 2 And valu_completed_level_7.Value = 1 Then
            Icon_rank_q7.Image = My.Resources.TKCD_icon_rank_gold
        ElseIf valu_rank_q7.Value = 3 And valu_completed_level_7.Value = 1 Then
            Icon_rank_q7.Image = My.Resources.TKCD_icon_rank_platinium
        End If
    End Sub

    Private Sub valu_rank_q8_ValueChanged(sender As Object, e As EventArgs) Handles valu_rank_q8.ValueChanged
        If valu_rank_q8.Value = 0 And valu_completed_level_8.Value = 0 Then
            Icon_rank_q8.Image = My.Resources.TKCD_icon_rank_na
        ElseIf valu_rank_q8.Value = 0 And valu_completed_level_8.Value = 1 Then
            Icon_rank_q8.Image = My.Resources.TKCD_icon_rank_bronze
        ElseIf valu_rank_q8.Value = 1 And valu_completed_level_8.Value = 1 Then
            Icon_rank_q8.Image = My.Resources.TKCD_icon_rank_silver
        ElseIf valu_rank_q8.Value = 2 And valu_completed_level_8.Value = 1 Then
            Icon_rank_q8.Image = My.Resources.TKCD_icon_rank_gold
        ElseIf valu_rank_q8.Value = 3 And valu_completed_level_8.Value = 1 Then
            Icon_rank_q8.Image = My.Resources.TKCD_icon_rank_platinium
        End If
    End Sub

    Private Sub Check_completed_level_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_completed_level_1.CheckedChanged
        If Check_completed_level_1.Checked = True Then
            valu_completed_level_1.Value = 1
        ElseIf Check_completed_level_1.Checked = False Then
            valu_completed_level_1.Value = 0
        End If
    End Sub

    Private Sub valu_completed_level_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_completed_level_1.ValueChanged
        If valu_completed_level_1.Value = 0 Then
            Check_completed_level_1.Checked = False
        ElseIf valu_completed_level_1.Value = 1 Then
            Check_completed_level_1.Checked = True
        End If
    End Sub

    Private Sub Check_completed_level_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_completed_level_2.CheckedChanged
        If Check_completed_level_2.Checked = True Then
            valu_completed_level_2.Value = 1
        ElseIf Check_completed_level_2.Checked = False Then
            valu_completed_level_2.Value = 0
        End If
    End Sub

    Private Sub valu_completed_level_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_completed_level_2.ValueChanged
        If valu_completed_level_2.Value = 0 Then
            Check_completed_level_2.Checked = False
        ElseIf valu_completed_level_2.Value = 1 Then
            Check_completed_level_2.Checked = True
        End If
    End Sub

    Private Sub Check_completed_level_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_completed_level_3.CheckedChanged
        If Check_completed_level_3.Checked = True Then
            valu_completed_level_3.Value = 1
        ElseIf Check_completed_level_3.Checked = False Then
            valu_completed_level_3.Value = 0
        End If
    End Sub

    Private Sub valu_completed_level_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_completed_level_3.ValueChanged
        If valu_completed_level_3.Value = 0 Then
            Check_completed_level_3.Checked = False
        ElseIf valu_completed_level_3.Value = 1 Then
            Check_completed_level_3.Checked = True
        End If
    End Sub

    Private Sub Check_completed_level_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_completed_level_4.CheckedChanged
        If Check_completed_level_4.Checked = True Then
            valu_completed_level_4.Value = 1
        ElseIf Check_completed_level_4.Checked = False Then
            valu_completed_level_4.Value = 0
        End If
    End Sub

    Private Sub valu_completed_level_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_completed_level_4.ValueChanged
        If valu_completed_level_4.Value = 0 Then
            Check_completed_level_4.Checked = False
        ElseIf valu_completed_level_4.Value = 1 Then
            Check_completed_level_4.Checked = True
        End If
    End Sub

    Private Sub Check_completed_level_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_completed_level_5.CheckedChanged
        If Check_completed_level_5.Checked = True Then
            valu_completed_level_5.Value = 1
        ElseIf Check_completed_level_5.Checked = False Then
            valu_completed_level_5.Value = 0
        End If
    End Sub

    Private Sub valu_completed_level_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_completed_level_5.ValueChanged
        If valu_completed_level_5.Value = 0 Then
            Check_completed_level_5.Checked = False
        ElseIf valu_completed_level_5.Value = 1 Then
            Check_completed_level_5.Checked = True
        End If
    End Sub

    Private Sub Check_completed_level_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_completed_level_6.CheckedChanged
        If Check_completed_level_6.Checked = True Then
            valu_completed_level_6.Value = 1
        ElseIf Check_completed_level_6.Checked = False Then
            valu_completed_level_6.Value = 0
        End If
    End Sub

    Private Sub valu_completed_level_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_completed_level_6.ValueChanged
        If valu_completed_level_6.Value = 0 Then
            Check_completed_level_6.Checked = False
        ElseIf valu_completed_level_6.Value = 1 Then
            Check_completed_level_6.Checked = True
        End If
    End Sub

    Private Sub Check_completed_level_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_completed_level_7.CheckedChanged
        If Check_completed_level_7.Checked = True Then
            valu_completed_level_7.Value = 1
        ElseIf Check_completed_level_7.Checked = False Then
            valu_completed_level_7.Value = 0
        End If
    End Sub

    Private Sub valu_completed_level_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_completed_level_7.ValueChanged
        If valu_completed_level_7.Value = 0 Then
            Check_completed_level_7.Checked = False
        ElseIf valu_completed_level_7.Value = 1 Then
            Check_completed_level_7.Checked = True
        End If
    End Sub

    Private Sub Check_completed_level_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_completed_level_8.CheckedChanged
        If Check_completed_level_8.Checked = True Then
            valu_completed_level_8.Value = 1
        ElseIf Check_completed_level_8.Checked = False Then
            valu_completed_level_8.Value = 0
        End If
    End Sub

    Private Sub valu_completed_level_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_completed_level_8.ValueChanged
        If valu_completed_level_8.Value = 0 Then
            Check_completed_level_8.Checked = False
        ElseIf valu_completed_level_8.Value = 1 Then
            Check_completed_level_8.Checked = True
        End If
    End Sub

    Private Sub Icon_rank_q1_Click(sender As Object, e As EventArgs) Handles Icon_rank_q1.Click
        If valu_rank_q1.Value >= 3 Then
            valu_rank_q1.Value = 0
        Else
            valu_rank_q1.Value = valu_rank_q1.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_q2_Click(sender As Object, e As EventArgs) Handles Icon_rank_q2.Click
        If valu_rank_q2.Value >= 3 Then
            valu_rank_q2.Value = 0
        Else
            valu_rank_q2.Value = valu_rank_q2.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_q3_Click(sender As Object, e As EventArgs) Handles Icon_rank_q3.Click
        If valu_rank_q3.Value >= 3 Then
            valu_rank_q3.Value = 0
        Else
            valu_rank_q3.Value = valu_rank_q3.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_q4_Click(sender As Object, e As EventArgs) Handles Icon_rank_q4.Click
        If valu_rank_q4.Value >= 3 Then
            valu_rank_q4.Value = 0
        Else
            valu_rank_q4.Value = valu_rank_q4.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_q5_Click(sender As Object, e As EventArgs) Handles Icon_rank_q5.Click
        If valu_rank_q5.Value >= 3 Then
            valu_rank_q5.Value = 0
        Else
            valu_rank_q5.Value = valu_rank_q5.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_q6_Click(sender As Object, e As EventArgs) Handles Icon_rank_q6.Click
        If valu_rank_q6.Value >= 3 Then
            valu_rank_q6.Value = 0
        Else
            valu_rank_q6.Value = valu_rank_q6.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_q7_Click(sender As Object, e As EventArgs) Handles Icon_rank_q7.Click
        If valu_rank_q7.Value >= 3 Then
            valu_rank_q7.Value = 0
        Else
            valu_rank_q7.Value = valu_rank_q7.Value + 1
        End If
    End Sub

    Private Sub Icon_rank_q8_Click(sender As Object, e As EventArgs) Handles Icon_rank_q8.Click
        If valu_rank_q8.Value >= 3 Then
            valu_rank_q8.Value = 0
        Else
            valu_rank_q8.Value = valu_rank_q8.Value + 1
        End If
    End Sub

    Private Sub Icon_chkpt_MouseLeave(sender As Object, e As EventArgs) Handles Icon_chkpt.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_chkpt_MouseMove(sender As Object, e As EventArgs) Handles Icon_chkpt.MouseMove
        Text_description.Text = "Your save file is here on your SD card :" & vbNewLine & "3ds\Checkpoint\saves\0x[your region title] Team Kirby Clash Deluxe\*your folder name\savedata.dat"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_jksm_MouseLeave(sender As Object, e As EventArgs) Handles Icon_jksm.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_jksm_MouseMove(sender As Object, e As EventArgs) Handles Icon_jksm.MouseMove
        Text_description.Text = "Your save file is here on your SD card :" & vbNewLine & "JKSV\Saves\Team Kirby Clash Deluxe\*your folder name\savedata.dat"
        Panel_description.Visible = True
    End Sub
End Class