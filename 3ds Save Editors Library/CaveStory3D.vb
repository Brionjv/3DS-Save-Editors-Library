Public Class CaveStory3D
    Dim applicationpath = Application.StartupPath
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim profileX As String
    Dim Maxhp = &H1C
    Dim Hp = &H20
    Dim Weapon_1 = &H38
    Dim LVweapons_1 = &H3C
    Dim Exp_1 = &H40
    Dim Maxmuni_1 = &H44
    Dim Muni_1 = &H48
    Dim Weapon_2 = &H4C
    Dim LVweapons_2 = &H50
    Dim Exp_2 = &H54
    Dim Maxmuni_2 = &H58
    Dim Muni_2 = &H5C
    Dim Weapon_3 = &H60
    Dim LVweapons_3 = &H64
    Dim Exp_3 = &H68
    Dim Maxmuni_3 = &H6C
    Dim Muni_3 = &H70
    Dim Weapon_4 = &H74
    Dim LVweapons_4 = &H78
    Dim Exp_4 = &H7C
    Dim Maxmuni_4 = &H80
    Dim Muni_4 = &H84
    Dim Weapon_5 = &H88
    Dim LVweapons_5 = &H8C
    Dim Exp_5 = &H90
    Dim Maxmuni_5 = &H94
    Dim Muni_5 = &H98
    Dim Weapon_6 = &H9C
    Dim LVweapons_6 = &HA0
    Dim Exp_6 = &HA4
    Dim Maxmuni_6 = &HA8
    Dim Muni_6 = &HAC
    Dim Weapon_7 = &HB0
    Dim LVweapons_7 = &HB4
    Dim Exp_7 = &HB8
    Dim Maxmuni_7 = &HBC
    Dim Muni_7 = &HC0

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

    Private Sub CS3DSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CS3DSE_header.MouseDown, CS3DSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub CS3DSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CS3DSE_header.MouseUp, CS3DSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub CS3DSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CS3DSE_header.MouseMove, CS3DSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Dim open As New OpenFileDialog
        fdialog.Description.Text = "Open profile1.dat, profile2.dat or profile3.dat" & vbNewLine & "Cave Story Save Editor will make a backup of your save file, check ''backup'' folder"
        fdialog.ShowDialog()
        open.Filter = "DAT files|*.dat"
        open.Title = "Open save profileX.dat"
        open.ShowDialog()
        profileX = open.FileName
        readprofileX()
        makebakprofileX()
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        writeprofileX()
    End Sub

    Public Sub makebakprofileX()
        Try
            My.Computer.FileSystem.CopyFile(
                          profileX,
                        applicationpath & "\backup\Cave Story 3D\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\profileX.dat")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub readprofileX()
        Try
            Dim Reader As New PackageIO.Reader(profileX, PackageIO.Endian.Little)
            Reader.Position = Maxhp
            valu_maxhp.Value = Reader.ReadUInt32
            Reader.Position = Hp
            valu_hp.Value = Reader.ReadUInt32
            Reader.Position = Weapon_1
            valu_select_weapon_1.Value = Reader.ReadUInt32
            Reader.Position = LVweapons_1
            valu_lv_weapon_1.Value = Reader.ReadUInt32
            Reader.Position = Exp_1
            valu_exp_weapon_1.Value = Reader.ReadUInt32
            Reader.Position = Maxmuni_1
            valu_maxmuni_weapon_1.Value = Reader.ReadUInt32
            Reader.Position = Muni_1
            valu_muni_weapon_1.Value = Reader.ReadUInt32
            Reader.Position = Weapon_2
            valu_select_weapon_2.Value = Reader.ReadUInt32
            Reader.Position = LVweapons_2
            valu_lv_weapon_2.Value = Reader.ReadUInt32
            Reader.Position = Exp_2
            valu_exp_weapon_2.Value = Reader.ReadUInt32
            Reader.Position = Maxmuni_2
            valu_maxmuni_weapon_2.Value = Reader.ReadUInt32
            Reader.Position = Muni_2
            valu_muni_weapon_2.Value = Reader.ReadUInt32
            Reader.Position = Weapon_3
            valu_select_weapon_3.Value = Reader.ReadUInt32
            Reader.Position = LVweapons_3
            valu_lv_weapon_3.Value = Reader.ReadUInt32
            Reader.Position = Exp_3
            valu_exp_weapon_3.Value = Reader.ReadUInt32
            Reader.Position = Maxmuni_3
            valu_maxmuni_weapon_3.Value = Reader.ReadUInt32
            Reader.Position = Muni_3
            valu_muni_weapon_3.Value = Reader.ReadUInt32
            Reader.Position = Weapon_4
            valu_select_weapon_4.Value = Reader.ReadUInt32
            Reader.Position = LVweapons_4
            valu_lv_weapon_4.Value = Reader.ReadUInt32
            Reader.Position = Exp_4
            valu_exp_weapon_4.Value = Reader.ReadUInt32
            Reader.Position = Maxmuni_4
            valu_maxmuni_weapon_4.Value = Reader.ReadUInt32
            Reader.Position = Muni_4
            valu_muni_weapon_4.Value = Reader.ReadUInt32
            Reader.Position = Weapon_5
            valu_select_weapon_5.Value = Reader.ReadUInt32
            Reader.Position = LVweapons_5
            valu_lv_weapon_5.Value = Reader.ReadUInt32
            Reader.Position = Exp_5
            valu_exp_weapon_5.Value = Reader.ReadUInt32
            Reader.Position = Maxmuni_5
            valu_maxmuni_weapon_5.Value = Reader.ReadUInt32
            Reader.Position = Muni_5
            valu_muni_weapon_5.Value = Reader.ReadUInt32
            Reader.Position = Weapon_6
            valu_select_weapon_6.Value = Reader.ReadUInt32
            Reader.Position = LVweapons_6
            valu_lv_weapon_6.Value = Reader.ReadUInt32
            Reader.Position = Exp_6
            valu_exp_weapon_6.Value = Reader.ReadUInt32
            Reader.Position = Maxmuni_6
            valu_maxmuni_weapon_6.Value = Reader.ReadUInt32
            Reader.Position = Muni_6
            valu_muni_weapon_6.Value = Reader.ReadUInt32
            Reader.Position = Weapon_7
            valu_select_weapon_7.Value = Reader.ReadUInt32
            Reader.Position = LVweapons_7
            valu_lv_weapon_7.Value = Reader.ReadUInt32
            Reader.Position = Exp_7
            valu_exp_weapon_7.Value = Reader.ReadUInt32
            Reader.Position = Maxmuni_7
            valu_maxmuni_weapon_7.Value = Reader.ReadUInt32
            Reader.Position = Muni_7
            valu_muni_weapon_7.Value = Reader.ReadUInt32
            Text_menu_save.Visible = True
        Catch ex As Exception
            fdialog.Description.Text = "Failed to read profile1.dat, profile2.dat or profile3.dat, make sure you have opened a good save file or report this issue"
            fdialog.ShowDialog()
            Text_menu_save.Visible = False
        End Try
    End Sub

    Public Sub writeprofileX()
        Try
            Dim Writer As New PackageIO.Writer(profileX, PackageIO.Endian.Little)
            Writer.Position = Maxhp
            Writer.WriteUInt32(valu_maxhp.Value)
            Writer.Position = Hp
            Writer.WriteUInt32(valu_hp.Value)
            Writer.Position = Weapon_1
            Writer.WriteUInt32(valu_select_weapon_1.Value)
            Writer.Position = LVweapons_1
            Writer.WriteUInt32(valu_lv_weapon_1.Value)
            Writer.Position = Exp_1
            Writer.WriteUInt32(valu_exp_weapon_1.Value)
            Writer.Position = Maxmuni_1
            Writer.WriteUInt32(valu_maxmuni_weapon_1.Value)
            Writer.Position = Muni_1
            Writer.WriteUInt32(valu_muni_weapon_1.Value)
            Writer.Position = Weapon_2
            Writer.WriteUInt32(valu_select_weapon_2.Value)
            Writer.Position = LVweapons_2
            Writer.WriteUInt32(valu_lv_weapon_2.Value)
            Writer.Position = Exp_2
            Writer.WriteUInt32(valu_exp_weapon_2.Value)
            Writer.Position = Maxmuni_2
            Writer.WriteUInt32(valu_maxmuni_weapon_2.Value)
            Writer.Position = Muni_2
            Writer.WriteUInt32(valu_muni_weapon_2.Value)
            Writer.Position = Weapon_3
            Writer.WriteUInt32(valu_select_weapon_3.Value)
            Writer.Position = LVweapons_3
            Writer.WriteUInt32(valu_lv_weapon_3.Value)
            Writer.Position = Exp_3
            Writer.WriteUInt32(valu_exp_weapon_3.Value)
            Writer.Position = Maxmuni_3
            Writer.WriteUInt32(valu_maxmuni_weapon_3.Value)
            Writer.Position = Muni_3
            Writer.WriteUInt32(valu_muni_weapon_3.Value)
            Writer.Position = Weapon_4
            Writer.WriteUInt32(valu_select_weapon_4.Value)
            Writer.Position = LVweapons_4
            Writer.WriteUInt32(valu_lv_weapon_4.Value)
            Writer.Position = Exp_4
            Writer.WriteUInt32(valu_exp_weapon_4.Value)
            Writer.Position = Maxmuni_4
            Writer.WriteUInt32(valu_maxmuni_weapon_4.Value)
            Writer.Position = Muni_4
            Writer.WriteUInt32(valu_muni_weapon_4.Value)
            Writer.Position = Weapon_5
            Writer.WriteUInt32(valu_select_weapon_5.Value)
            Writer.Position = LVweapons_5
            Writer.WriteUInt32(valu_lv_weapon_5.Value)
            Writer.Position = Exp_5
            Writer.WriteUInt32(valu_exp_weapon_5.Value)
            Writer.Position = Maxmuni_5
            Writer.WriteUInt32(valu_maxmuni_weapon_5.Value)
            Writer.Position = Muni_5
            Writer.WriteUInt32(valu_muni_weapon_5.Value)
            Writer.Position = Weapon_6
            Writer.WriteUInt32(valu_select_weapon_6.Value)
            Writer.Position = LVweapons_6
            Writer.WriteUInt32(valu_lv_weapon_6.Value)
            Writer.Position = Exp_6
            Writer.WriteUInt32(valu_exp_weapon_6.Value)
            Writer.Position = Maxmuni_6
            Writer.WriteUInt32(valu_maxmuni_weapon_6.Value)
            Writer.Position = Muni_6
            Writer.WriteUInt32(valu_muni_weapon_6.Value)
            Writer.Position = Weapon_7
            Writer.WriteUInt32(valu_select_weapon_7.Value)
            Writer.Position = LVweapons_7
            Writer.WriteUInt32(valu_lv_weapon_7.Value)
            Writer.Position = Exp_7
            Writer.WriteUInt32(valu_exp_weapon_7.Value)
            Writer.Position = Maxmuni_7
            Writer.WriteUInt32(valu_maxmuni_weapon_7.Value)
            Writer.Position = Muni_7
            Writer.WriteUInt32(valu_muni_weapon_7.Value)
            fdialog.Description.Text = "Editing of profile1.dat, profile2.dat or profile3.dat has been saved"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Description.Text = "Failed to edit profile1.dat, profile2.dat or profile3.dat, make sure you have opened a save file or report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub valu_select_weapon_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_select_weapon_1.ValueChanged
        If valu_select_weapon_1.Value = 0 Then
            Icon_weapon_1.Image = Nothing
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(0)
        ElseIf valu_select_weapon_1.Value = 1 Then
            Icon_weapon_1.Image = My.Resources.snake
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(1)
        ElseIf valu_select_weapon_1.Value = 2 Then
            Icon_weapon_1.Image = My.Resources.Polarstar
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(2)
        ElseIf valu_select_weapon_1.Value = 3 Then
            Icon_weapon_1.Image = My.Resources.Fireball
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(3)
        ElseIf valu_select_weapon_1.Value = 4 Then
            Icon_weapon_1.Image = My.Resources.Machinegun
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(4)
        ElseIf valu_select_weapon_1.Value = 5 Then
            Icon_weapon_1.Image = My.Resources.Missilelauncher
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(5)
        ElseIf valu_select_weapon_1.Value = 6 Then
            Icon_weapon_1.Image = My.Resources.Bubblineunav
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(6)
        ElseIf valu_select_weapon_1.Value = 7 Then
            Icon_weapon_1.Image = My.Resources.Bubbline
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(7)
        ElseIf valu_select_weapon_1.Value = 8 Then
            Icon_weapon_1.Image = My.Resources.Bladeunav
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(8)
        ElseIf valu_select_weapon_1.Value = 9 Then
            Icon_weapon_1.Image = My.Resources.Blade
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(9)
        ElseIf valu_select_weapon_1.Value = 10 Then
            Icon_weapon_1.Image = My.Resources.Supermissile
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(10)
        ElseIf valu_select_weapon_1.Value = 11 Then
            Icon_weapon_1.Image = My.Resources.Nemesisunav
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(11)
        ElseIf valu_select_weapon_1.Value = 12 Then
            Icon_weapon_1.Image = My.Resources.Nemesis
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(12)
        ElseIf valu_select_weapon_1.Value = 13 Then
            Icon_weapon_1.Image = My.Resources.Spur
            Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(13)
        End If
    End Sub

    Private Sub Select_weapon_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_weapon_1.SelectedIndexChanged
        If Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(0) Then
            valu_select_weapon_1.Value = 0
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(1) Then
            valu_select_weapon_1.Value = 1
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(2) Then
            valu_select_weapon_1.Value = 2
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(3) Then
            valu_select_weapon_1.Value = 3
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(4) Then
            valu_select_weapon_1.Value = 4
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(5) Then
            valu_select_weapon_1.Value = 5
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(6) Then
            valu_select_weapon_1.Value = 6
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(7) Then
            valu_select_weapon_1.Value = 7
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(8) Then
            valu_select_weapon_1.Value = 8
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(9) Then
            valu_select_weapon_1.Value = 9
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(10) Then
            valu_select_weapon_1.Value = 10
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(11) Then
            valu_select_weapon_1.Value = 11
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(12) Then
            valu_select_weapon_1.Value = 12
        ElseIf Select_weapon_1.SelectedItem = Select_weapon_1.Items.Item(13) Then
            valu_select_weapon_1.Value = 13
        End If
    End Sub

    Private Sub valu_select_weapon_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_select_weapon_2.ValueChanged
        If valu_select_weapon_2.Value = 0 Then
            Icon_weapon_2.Image = Nothing
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(0)
        ElseIf valu_select_weapon_2.Value = 1 Then
            Icon_weapon_2.Image = My.Resources.snake
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(1)
        ElseIf valu_select_weapon_2.Value = 2 Then
            Icon_weapon_2.Image = My.Resources.Polarstar
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(2)
        ElseIf valu_select_weapon_2.Value = 3 Then
            Icon_weapon_2.Image = My.Resources.Fireball
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(3)
        ElseIf valu_select_weapon_2.Value = 4 Then
            Icon_weapon_2.Image = My.Resources.Machinegun
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(4)
        ElseIf valu_select_weapon_2.Value = 5 Then
            Icon_weapon_2.Image = My.Resources.Missilelauncher
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(5)
        ElseIf valu_select_weapon_2.Value = 6 Then
            Icon_weapon_2.Image = My.Resources.Bubblineunav
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(6)
        ElseIf valu_select_weapon_2.Value = 7 Then
            Icon_weapon_2.Image = My.Resources.Bubbline
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(7)
        ElseIf valu_select_weapon_2.Value = 8 Then
            Icon_weapon_2.Image = My.Resources.Bladeunav
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(8)
        ElseIf valu_select_weapon_2.Value = 9 Then
            Icon_weapon_2.Image = My.Resources.Blade
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(9)
        ElseIf valu_select_weapon_2.Value = 10 Then
            Icon_weapon_2.Image = My.Resources.Supermissile
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(10)
        ElseIf valu_select_weapon_2.Value = 11 Then
            Icon_weapon_2.Image = My.Resources.Nemesisunav
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(11)
        ElseIf valu_select_weapon_2.Value = 12 Then
            Icon_weapon_2.Image = My.Resources.Nemesis
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(12)
        ElseIf valu_select_weapon_2.Value = 13 Then
            Icon_weapon_2.Image = My.Resources.Spur
            Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(13)
        End If
    End Sub

    Private Sub Select_weapon_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_weapon_2.SelectedIndexChanged
        If Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(0) Then
            valu_select_weapon_2.Value = 0
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(1) Then
            valu_select_weapon_2.Value = 1
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(2) Then
            valu_select_weapon_2.Value = 2
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(3) Then
            valu_select_weapon_2.Value = 3
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(4) Then
            valu_select_weapon_2.Value = 4
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(5) Then
            valu_select_weapon_2.Value = 5
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(6) Then
            valu_select_weapon_2.Value = 6
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(7) Then
            valu_select_weapon_2.Value = 7
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(8) Then
            valu_select_weapon_2.Value = 8
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(9) Then
            valu_select_weapon_2.Value = 9
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(10) Then
            valu_select_weapon_2.Value = 10
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(11) Then
            valu_select_weapon_2.Value = 11
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(12) Then
            valu_select_weapon_2.Value = 12
        ElseIf Select_weapon_2.SelectedItem = Select_weapon_2.Items.Item(13) Then
            valu_select_weapon_2.Value = 13
        End If
    End Sub

    Private Sub valu_select_weapon_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_select_weapon_3.ValueChanged
        If valu_select_weapon_3.Value = 0 Then
            Icon_weapon_3.Image = Nothing
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(0)
        ElseIf valu_select_weapon_3.Value = 1 Then
            Icon_weapon_3.Image = My.Resources.snake
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(1)
        ElseIf valu_select_weapon_3.Value = 2 Then
            Icon_weapon_3.Image = My.Resources.Polarstar
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(2)
        ElseIf valu_select_weapon_3.Value = 3 Then
            Icon_weapon_3.Image = My.Resources.Fireball
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(3)
        ElseIf valu_select_weapon_3.Value = 4 Then
            Icon_weapon_3.Image = My.Resources.Machinegun
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(4)
        ElseIf valu_select_weapon_3.Value = 5 Then
            Icon_weapon_3.Image = My.Resources.Missilelauncher
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(5)
        ElseIf valu_select_weapon_3.Value = 6 Then
            Icon_weapon_3.Image = My.Resources.Bubblineunav
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(6)
        ElseIf valu_select_weapon_3.Value = 7 Then
            Icon_weapon_3.Image = My.Resources.Bubbline
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(7)
        ElseIf valu_select_weapon_3.Value = 8 Then
            Icon_weapon_3.Image = My.Resources.Bladeunav
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(8)
        ElseIf valu_select_weapon_3.Value = 9 Then
            Icon_weapon_3.Image = My.Resources.Blade
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(9)
        ElseIf valu_select_weapon_3.Value = 10 Then
            Icon_weapon_3.Image = My.Resources.Supermissile
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(10)
        ElseIf valu_select_weapon_3.Value = 11 Then
            Icon_weapon_3.Image = My.Resources.Nemesisunav
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(11)
        ElseIf valu_select_weapon_3.Value = 12 Then
            Icon_weapon_3.Image = My.Resources.Nemesis
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(12)
        ElseIf valu_select_weapon_3.Value = 13 Then
            Icon_weapon_3.Image = My.Resources.Spur
            Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(13)
        End If
    End Sub

    Private Sub Select_weapon_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_weapon_3.SelectedIndexChanged
        If Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(0) Then
            valu_select_weapon_3.Value = 0
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(1) Then
            valu_select_weapon_3.Value = 1
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(2) Then
            valu_select_weapon_3.Value = 2
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(3) Then
            valu_select_weapon_3.Value = 3
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(4) Then
            valu_select_weapon_3.Value = 4
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(5) Then
            valu_select_weapon_3.Value = 5
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(6) Then
            valu_select_weapon_3.Value = 6
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(7) Then
            valu_select_weapon_3.Value = 7
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(8) Then
            valu_select_weapon_3.Value = 8
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(9) Then
            valu_select_weapon_3.Value = 9
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(10) Then
            valu_select_weapon_3.Value = 10
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(11) Then
            valu_select_weapon_3.Value = 11
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(12) Then
            valu_select_weapon_3.Value = 12
        ElseIf Select_weapon_3.SelectedItem = Select_weapon_3.Items.Item(13) Then
            valu_select_weapon_3.Value = 13
        End If
    End Sub

    Private Sub valu_select_weapon_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_select_weapon_4.ValueChanged
        If valu_select_weapon_4.Value = 0 Then
            Icon_weapon_4.Image = Nothing
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(0)
        ElseIf valu_select_weapon_4.Value = 1 Then
            Icon_weapon_4.Image = My.Resources.snake
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(1)
        ElseIf valu_select_weapon_4.Value = 2 Then
            Icon_weapon_4.Image = My.Resources.Polarstar
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(2)
        ElseIf valu_select_weapon_4.Value = 3 Then
            Icon_weapon_4.Image = My.Resources.Fireball
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(3)
        ElseIf valu_select_weapon_4.Value = 4 Then
            Icon_weapon_4.Image = My.Resources.Machinegun
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(4)
        ElseIf valu_select_weapon_4.Value = 5 Then
            Icon_weapon_4.Image = My.Resources.Missilelauncher
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(5)
        ElseIf valu_select_weapon_4.Value = 6 Then
            Icon_weapon_4.Image = My.Resources.Bubblineunav
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(6)
        ElseIf valu_select_weapon_4.Value = 7 Then
            Icon_weapon_4.Image = My.Resources.Bubbline
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(7)
        ElseIf valu_select_weapon_4.Value = 8 Then
            Icon_weapon_4.Image = My.Resources.Bladeunav
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(8)
        ElseIf valu_select_weapon_4.Value = 9 Then
            Icon_weapon_4.Image = My.Resources.Blade
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(9)
        ElseIf valu_select_weapon_4.Value = 10 Then
            Icon_weapon_4.Image = My.Resources.Supermissile
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(10)
        ElseIf valu_select_weapon_4.Value = 11 Then
            Icon_weapon_4.Image = My.Resources.Nemesisunav
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(11)
        ElseIf valu_select_weapon_4.Value = 12 Then
            Icon_weapon_4.Image = My.Resources.Nemesis
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(12)
        ElseIf valu_select_weapon_4.Value = 13 Then
            Icon_weapon_4.Image = My.Resources.Spur
            Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(13)
        End If
    End Sub

    Private Sub Select_weapon_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_weapon_4.SelectedIndexChanged
        If Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(0) Then
            valu_select_weapon_4.Value = 0
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(1) Then
            valu_select_weapon_4.Value = 1
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(2) Then
            valu_select_weapon_4.Value = 2
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(3) Then
            valu_select_weapon_4.Value = 3
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(4) Then
            valu_select_weapon_4.Value = 4
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(5) Then
            valu_select_weapon_4.Value = 5
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(6) Then
            valu_select_weapon_4.Value = 6
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(7) Then
            valu_select_weapon_4.Value = 7
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(8) Then
            valu_select_weapon_4.Value = 8
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(9) Then
            valu_select_weapon_4.Value = 9
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(10) Then
            valu_select_weapon_4.Value = 10
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(11) Then
            valu_select_weapon_4.Value = 11
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(12) Then
            valu_select_weapon_4.Value = 12
        ElseIf Select_weapon_4.SelectedItem = Select_weapon_4.Items.Item(13) Then
            valu_select_weapon_4.Value = 13
        End If
    End Sub

    Private Sub valu_select_weapon_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_select_weapon_5.ValueChanged
        If valu_select_weapon_5.Value = 0 Then
            Icon_weapon_5.Image = Nothing
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(0)
        ElseIf valu_select_weapon_5.Value = 1 Then
            Icon_weapon_5.Image = My.Resources.snake
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(1)
        ElseIf valu_select_weapon_5.Value = 2 Then
            Icon_weapon_5.Image = My.Resources.Polarstar
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(2)
        ElseIf valu_select_weapon_5.Value = 3 Then
            Icon_weapon_5.Image = My.Resources.Fireball
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(3)
        ElseIf valu_select_weapon_5.Value = 4 Then
            Icon_weapon_5.Image = My.Resources.Machinegun
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(4)
        ElseIf valu_select_weapon_5.Value = 5 Then
            Icon_weapon_5.Image = My.Resources.Missilelauncher
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(5)
        ElseIf valu_select_weapon_5.Value = 6 Then
            Icon_weapon_5.Image = My.Resources.Bubblineunav
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(6)
        ElseIf valu_select_weapon_5.Value = 7 Then
            Icon_weapon_5.Image = My.Resources.Bubbline
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(7)
        ElseIf valu_select_weapon_5.Value = 8 Then
            Icon_weapon_5.Image = My.Resources.Bladeunav
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(8)
        ElseIf valu_select_weapon_5.Value = 9 Then
            Icon_weapon_5.Image = My.Resources.Blade
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(9)
        ElseIf valu_select_weapon_5.Value = 10 Then
            Icon_weapon_5.Image = My.Resources.Supermissile
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(10)
        ElseIf valu_select_weapon_5.Value = 11 Then
            Icon_weapon_5.Image = My.Resources.Nemesisunav
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(11)
        ElseIf valu_select_weapon_5.Value = 12 Then
            Icon_weapon_5.Image = My.Resources.Nemesis
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(12)
        ElseIf valu_select_weapon_5.Value = 13 Then
            Icon_weapon_5.Image = My.Resources.Spur
            Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(13)
        End If
    End Sub

    Private Sub Select_weapon_5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_weapon_5.SelectedIndexChanged
        If Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(0) Then
            valu_select_weapon_5.Value = 0
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(1) Then
            valu_select_weapon_5.Value = 1
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(2) Then
            valu_select_weapon_5.Value = 2
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(3) Then
            valu_select_weapon_5.Value = 3
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(4) Then
            valu_select_weapon_5.Value = 4
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(5) Then
            valu_select_weapon_5.Value = 5
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(6) Then
            valu_select_weapon_5.Value = 6
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(7) Then
            valu_select_weapon_5.Value = 7
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(8) Then
            valu_select_weapon_5.Value = 8
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(9) Then
            valu_select_weapon_5.Value = 9
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(10) Then
            valu_select_weapon_5.Value = 10
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(11) Then
            valu_select_weapon_5.Value = 11
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(12) Then
            valu_select_weapon_5.Value = 12
        ElseIf Select_weapon_5.SelectedItem = Select_weapon_5.Items.Item(13) Then
            valu_select_weapon_5.Value = 13
        End If
    End Sub

    Private Sub valu_select_weapon_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_select_weapon_6.ValueChanged
        If valu_select_weapon_6.Value = 0 Then
            Icon_weapon_6.Image = Nothing
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(0)
        ElseIf valu_select_weapon_6.Value = 1 Then
            Icon_weapon_6.Image = My.Resources.snake
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(1)
        ElseIf valu_select_weapon_6.Value = 2 Then
            Icon_weapon_6.Image = My.Resources.Polarstar
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(2)
        ElseIf valu_select_weapon_6.Value = 3 Then
            Icon_weapon_6.Image = My.Resources.Fireball
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(3)
        ElseIf valu_select_weapon_6.Value = 4 Then
            Icon_weapon_6.Image = My.Resources.Machinegun
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(4)
        ElseIf valu_select_weapon_6.Value = 5 Then
            Icon_weapon_6.Image = My.Resources.Missilelauncher
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(5)
        ElseIf valu_select_weapon_6.Value = 6 Then
            Icon_weapon_6.Image = My.Resources.Bubblineunav
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(6)
        ElseIf valu_select_weapon_6.Value = 7 Then
            Icon_weapon_6.Image = My.Resources.Bubbline
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(7)
        ElseIf valu_select_weapon_6.Value = 8 Then
            Icon_weapon_6.Image = My.Resources.Bladeunav
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(8)
        ElseIf valu_select_weapon_6.Value = 9 Then
            Icon_weapon_6.Image = My.Resources.Blade
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(9)
        ElseIf valu_select_weapon_6.Value = 10 Then
            Icon_weapon_6.Image = My.Resources.Supermissile
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(10)
        ElseIf valu_select_weapon_6.Value = 11 Then
            Icon_weapon_6.Image = My.Resources.Nemesisunav
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(11)
        ElseIf valu_select_weapon_6.Value = 12 Then
            Icon_weapon_6.Image = My.Resources.Nemesis
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(12)
        ElseIf valu_select_weapon_6.Value = 13 Then
            Icon_weapon_6.Image = My.Resources.Spur
            Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(13)
        End If
    End Sub

    Private Sub Select_weapon_6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_weapon_6.SelectedIndexChanged
        If Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(0) Then
            valu_select_weapon_6.Value = 0
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(1) Then
            valu_select_weapon_6.Value = 1
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(2) Then
            valu_select_weapon_6.Value = 2
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(3) Then
            valu_select_weapon_6.Value = 3
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(4) Then
            valu_select_weapon_6.Value = 4
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(5) Then
            valu_select_weapon_6.Value = 5
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(6) Then
            valu_select_weapon_6.Value = 6
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(7) Then
            valu_select_weapon_6.Value = 7
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(8) Then
            valu_select_weapon_6.Value = 8
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(9) Then
            valu_select_weapon_6.Value = 9
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(10) Then
            valu_select_weapon_6.Value = 10
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(11) Then
            valu_select_weapon_6.Value = 11
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(12) Then
            valu_select_weapon_6.Value = 12
        ElseIf Select_weapon_6.SelectedItem = Select_weapon_6.Items.Item(13) Then
            valu_select_weapon_6.Value = 13
        End If
    End Sub

    Private Sub valu_select_weapon_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_select_weapon_7.ValueChanged
        If valu_select_weapon_7.Value = 0 Then
            Icon_weapon_7.Image = Nothing
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(0)
        ElseIf valu_select_weapon_7.Value = 1 Then
            Icon_weapon_7.Image = My.Resources.snake
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(1)
        ElseIf valu_select_weapon_7.Value = 2 Then
            Icon_weapon_7.Image = My.Resources.Polarstar
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(2)
        ElseIf valu_select_weapon_7.Value = 3 Then
            Icon_weapon_7.Image = My.Resources.Fireball
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(3)
        ElseIf valu_select_weapon_7.Value = 4 Then
            Icon_weapon_7.Image = My.Resources.Machinegun
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(4)
        ElseIf valu_select_weapon_7.Value = 5 Then
            Icon_weapon_7.Image = My.Resources.Missilelauncher
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(5)
        ElseIf valu_select_weapon_7.Value = 6 Then
            Icon_weapon_7.Image = My.Resources.Bubblineunav
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(6)
        ElseIf valu_select_weapon_7.Value = 7 Then
            Icon_weapon_7.Image = My.Resources.Bubbline
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(7)
        ElseIf valu_select_weapon_7.Value = 8 Then
            Icon_weapon_7.Image = My.Resources.Bladeunav
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(8)
        ElseIf valu_select_weapon_7.Value = 9 Then
            Icon_weapon_7.Image = My.Resources.Blade
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(9)
        ElseIf valu_select_weapon_7.Value = 10 Then
            Icon_weapon_7.Image = My.Resources.Supermissile
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(10)
        ElseIf valu_select_weapon_7.Value = 11 Then
            Icon_weapon_7.Image = My.Resources.Nemesisunav
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(11)
        ElseIf valu_select_weapon_7.Value = 12 Then
            Icon_weapon_7.Image = My.Resources.Nemesis
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(12)
        ElseIf valu_select_weapon_7.Value = 13 Then
            Icon_weapon_7.Image = My.Resources.Spur
            Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(13)
        End If
    End Sub

    Private Sub Select_weapon_7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_weapon_7.SelectedIndexChanged
        If Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(0) Then
            valu_select_weapon_7.Value = 0
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(1) Then
            valu_select_weapon_7.Value = 1
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(2) Then
            valu_select_weapon_7.Value = 2
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(3) Then
            valu_select_weapon_7.Value = 3
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(4) Then
            valu_select_weapon_7.Value = 4
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(5) Then
            valu_select_weapon_7.Value = 5
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(6) Then
            valu_select_weapon_7.Value = 6
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(7) Then
            valu_select_weapon_7.Value = 7
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(8) Then
            valu_select_weapon_7.Value = 8
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(9) Then
            valu_select_weapon_7.Value = 9
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(10) Then
            valu_select_weapon_7.Value = 10
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(11) Then
            valu_select_weapon_7.Value = 11
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(12) Then
            valu_select_weapon_7.Value = 12
        ElseIf Select_weapon_7.SelectedItem = Select_weapon_7.Items.Item(13) Then
            valu_select_weapon_7.Value = 13
        End If
    End Sub

    Private Sub CaveStory3D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fdialog.BackgroundImage = My.Resources.CS3DSE_fdialog
    End Sub
End Class