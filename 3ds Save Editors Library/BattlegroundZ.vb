Imports PackageIO
Public Class BattlegroundZ
    Dim mgZmb0 As String
    Dim applicationpath = Application.StartupPath
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim Survivors = &H65C0
    Dim zombie_1 = &H6434
    Dim zombie_2 = &H643C
    Dim zombie_3 = &H6440
    Dim zombie_4 = &H6444
    Dim zombie_5 = &H6438
    Dim zombie_6 = &H6448
    Dim zombie_7 = &H644C
    Dim zombie_8 = &H6450
    Dim zombie_9 = &H6454
    Dim zombie_10 = &H645C
    Dim zombie_11 = &H6460
    Dim zombie_12 = &H6464
    Dim zombie_13 = &H6430
    Dim zombie_14 = &H649C
    Dim zombie_15 = &H64A0
    Dim zombie_16 = &H64A4
    Dim zombie_17 = &H64AC
    Dim zombie_18 = &H64BC
    Dim zombie_19 = &H64C0
    Dim zombie_20 = &H64A8
    Dim zombie_21 = &H64B4
    Dim zombie_22 = &H64B8
    Dim zombie_23 = &H6470
    Dim zombie_24 = &H6458
    Dim zombie_25 = &H6478
    Dim zombie_26 = &H647C
    Dim zombie_27 = &H6480
    Dim zombie_28 = &H6484
    Dim zombie_29 = &H6488
    Dim zombie_30 = &H6490
    Dim zombie_31 = &H648C
    Dim rarezombie_1 = &H654C
    Dim rarezombie_2 = &H6550
    Dim rarezombie_3 = &H6554
    Dim rarezombie_4 = &H6558
    Dim rarezombie_5 = &H655C
    Dim rarezombie_6 = &H6560
    Dim rarezombie_7 = &H6564
    Dim rarezombie_8 = &H6568
    Dim rarezombie_9 = &H656C
    Dim rarezombie_10 = &H6570
    Dim rarezombie_11 = &H6574
    Dim rarezombie_12 = &H6578
    Dim rarezombie_13 = &H657C
    Dim rarezombie_14 = &H6580
    Dim rarezombie_15 = &H6584
    Dim rarezombie_16 = &H6588
    Dim rarezombie_17 = &H658C
    Dim rarezombie_18 = &H6590
    Dim rarezombie_19 = &H6594
    Dim rarezombie_20 = &H6598
    Dim rarezombie_21 = &H659C
    Dim rarezombie_22 = &H65A0
    Dim rarezombie_23 = &H65A4
    Dim rarezombie_24 = &H65A8
    Dim rarezombie_25 = &H65AC
    Dim rarezombie_26 = &H65B0
    Dim weapon_1 = &H65CA
    Dim weapon_2 = &H65CC
    Dim weapon_3 = &H65CE
    Dim weapon_4 = &H65D0
    Dim weapon_5 = &H65D2
    Dim weapon_6 = &H65D4
    Dim weapon_7 = &H65D6
    Dim weapon_8 = &H65D8
    Dim weapon_9 = &H65DA
    Dim weapon_10 = &H65DC
    Dim weapon_11 = &H65DE
    Dim weapon_12 = &H65E0
    Dim weapon_13 = &H65E2
    Dim weapon_14 = &H65E4
    Dim weapon_15 = &H65E6
    Dim weapon_16 = &H65E8
    Dim weapon_17 = &H65EA
    Dim weapon_18 = &H65EC
    Dim weapon_19 = &H65EE
    Dim weapon_20 = &H65F0
    Dim weapon_21 = &H65F2
    Dim weapon_22 = &H65F4
    Dim weapon_23 = &H65F6
    Dim weapon_24 = &H65F8
    Dim weapon_25 = &H65FA
    Dim weapon_26 = &H65FC

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

    Private Sub TKCD_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPBZSE_header.MouseDown, SMPBZSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TKCD_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPBZSE_header.MouseUp, SMPBZSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TKCD_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPBZSE_header.MouseMove, SMPBZSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub BattlegroundZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fdialog.BackgroundImage = My.Resources.SMPBZSE_fdialog
    End Sub

    Public Sub readfilesavemgZmb0()
        Try
            Dim Reader As New PackageIO.Reader(mgZmb0, PackageIO.Endian.Little)
            Reader.Position = Survivors
            valu_survivors.Value = Reader.ReadUInt32
            Reader.Position = zombie_1
            valu_zombie_1.Value = Reader.ReadUInt32
            Reader.Position = zombie_2
            valu_zombie_2.Value = Reader.ReadUInt32
            Reader.Position = zombie_3
            valu_zombie_3.Value = Reader.ReadUInt32
            Reader.Position = zombie_4
            valu_zombie_4.Value = Reader.ReadUInt32
            Reader.Position = zombie_5
            valu_zombie_5.Value = Reader.ReadUInt32
            Reader.Position = zombie_6
            valu_zombie_6.Value = Reader.ReadUInt32
            Reader.Position = zombie_7
            valu_zombie_7.Value = Reader.ReadUInt32
            Reader.Position = zombie_8
            valu_zombie_8.Value = Reader.ReadUInt32
            Reader.Position = zombie_9
            valu_zombie_9.Value = Reader.ReadUInt32
            Reader.Position = zombie_10
            valu_zombie_10.Value = Reader.ReadUInt32
            Reader.Position = zombie_11
            valu_zombie_11.Value = Reader.ReadUInt32
            Reader.Position = zombie_12
            valu_zombie_12.Value = Reader.ReadUInt32
            Reader.Position = zombie_13
            valu_zombie_13.Value = Reader.ReadUInt32
            Reader.Position = zombie_14
            valu_zombie_14.Value = Reader.ReadUInt32
            Reader.Position = zombie_15
            valu_zombie_15.Value = Reader.ReadUInt32
            Reader.Position = zombie_16
            valu_zombie_16.Value = Reader.ReadUInt32
            Reader.Position = zombie_17
            valu_zombie_17.Value = Reader.ReadUInt32
            Reader.Position = zombie_18
            valu_zombie_18.Value = Reader.ReadUInt32
            Reader.Position = zombie_19
            valu_zombie_19.Value = Reader.ReadUInt32
            Reader.Position = zombie_20
            valu_zombie_20.Value = Reader.ReadUInt32
            Reader.Position = zombie_21
            valu_zombie_21.Value = Reader.ReadUInt32
            Reader.Position = zombie_22
            valu_zombie_22.Value = Reader.ReadUInt32
            Reader.Position = zombie_23
            valu_zombie_23.Value = Reader.ReadUInt32
            Reader.Position = zombie_24
            valu_zombie_24.Value = Reader.ReadUInt32
            Reader.Position = zombie_25
            valu_zombie_25.Value = Reader.ReadUInt32
            Reader.Position = zombie_26
            valu_zombie_26.Value = Reader.ReadUInt32
            Reader.Position = zombie_27
            valu_zombie_27.Value = Reader.ReadUInt32
            Reader.Position = zombie_28
            valu_zombie_28.Value = Reader.ReadUInt32
            Reader.Position = zombie_29
            valu_zombie_29.Value = Reader.ReadUInt32
            Reader.Position = zombie_30
            valu_zombie_30.Value = Reader.ReadUInt32
            Reader.Position = zombie_31
            valu_zombie_31.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_1
            valu_rzombie_1.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_2
            valu_rzombie_2.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_3
            valu_rzombie_3.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_4
            valu_rzombie_4.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_5
            valu_rzombie_5.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_6
            valu_rzombie_6.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_7
            valu_rzombie_7.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_8
            valu_rzombie_8.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_9
            valu_rzombie_9.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_10
            valu_rzombie_10.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_11
            valu_rzombie_11.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_12
            valu_rzombie_12.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_13
            valu_rzombie_13.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_14
            valu_rzombie_14.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_15
            valu_rzombie_15.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_16
            valu_rzombie_16.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_17
            valu_rzombie_17.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_18
            valu_rzombie_18.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_19
            valu_rzombie_19.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_20
            valu_rzombie_20.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_21
            valu_rzombie_21.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_22
            valu_rzombie_22.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_23
            valu_rzombie_23.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_24
            valu_rzombie_24.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_25
            valu_rzombie_25.Value = Reader.ReadUInt32
            Reader.Position = rarezombie_26
            valu_rzombie_26.Value = Reader.ReadUInt32
            Reader.Position = weapon_1
            valu_weapon_1.Value = Reader.ReadUInt16
            Reader.Position = weapon_2
            valu_weapon_2.Value = Reader.ReadUInt16
            Reader.Position = weapon_3
            valu_weapon_3.Value = Reader.ReadUInt16
            Reader.Position = weapon_4
            valu_weapon_4.Value = Reader.ReadUInt16
            Reader.Position = weapon_5
            valu_weapon_5.Value = Reader.ReadUInt16
            Reader.Position = weapon_6
            valu_weapon_6.Value = Reader.ReadUInt16
            Reader.Position = weapon_7
            valu_weapon_7.Value = Reader.ReadUInt16
            Reader.Position = weapon_8
            valu_weapon_8.Value = Reader.ReadUInt16
            Reader.Position = weapon_9
            valu_weapon_9.Value = Reader.ReadUInt16
            Reader.Position = weapon_10
            valu_weapon_10.Value = Reader.ReadUInt16
            Reader.Position = weapon_11
            valu_weapon_11.Value = Reader.ReadUInt16
            Reader.Position = weapon_12
            valu_weapon_12.Value = Reader.ReadUInt16
            Reader.Position = weapon_13
            valu_weapon_13.Value = Reader.ReadUInt16
            Reader.Position = weapon_14
            valu_weapon_14.Value = Reader.ReadUInt16
            Reader.Position = weapon_15
            valu_weapon_15.Value = Reader.ReadUInt16
            Reader.Position = weapon_16
            valu_weapon_16.Value = Reader.ReadUInt16
            Reader.Position = weapon_17
            valu_weapon_17.Value = Reader.ReadUInt16
            Reader.Position = weapon_18
            valu_weapon_18.Value = Reader.ReadUInt16
            Reader.Position = weapon_19
            valu_weapon_19.Value = Reader.ReadUInt16
            Reader.Position = weapon_20
            valu_weapon_20.Value = Reader.ReadUInt16
            Reader.Position = weapon_21
            valu_weapon_21.Value = Reader.ReadUInt16
            Reader.Position = weapon_22
            valu_weapon_22.Value = Reader.ReadUInt16
            Reader.Position = weapon_23
            valu_weapon_23.Value = Reader.ReadUInt16
            Reader.Position = weapon_24
            valu_weapon_24.Value = Reader.ReadUInt16
            Reader.Position = weapon_25
            valu_weapon_25.Value = Reader.ReadUInt16
            Reader.Position = weapon_26
            valu_weapon_26.Value = Reader.ReadUInt16
            Text_menu_save.Visible = True
        Catch ex As Exception
            fdialog.Description.Text = "Failed to read mgZmb0.dat, make sure you have opened a good save file or report this issue"
            fdialog.ShowDialog()
            Text_menu_save.Visible = False
        End Try
    End Sub

    Private Sub writefilesavemgZmb0()
        Try
            Dim Writer As New PackageIO.Writer(mgZmb0, PackageIO.Endian.Little)
            Writer.Position = Survivors
            Writer.WriteUInt32(valu_survivors.Value)
            Writer.Position = zombie_1
            Writer.WriteUInt32(valu_zombie_1.Value)
            Writer.Position = zombie_2
            Writer.WriteUInt32(valu_zombie_2.Value)
            Writer.Position = zombie_3
            Writer.WriteUInt32(valu_zombie_3.Value)
            Writer.Position = zombie_4
            Writer.WriteUInt32(valu_zombie_4.Value)
            Writer.Position = zombie_5
            Writer.WriteUInt32(valu_zombie_5.Value)
            Writer.Position = zombie_6
            Writer.WriteUInt32(valu_zombie_6.Value)
            Writer.Position = zombie_7
            Writer.WriteUInt32(valu_zombie_7.Value)
            Writer.Position = zombie_8
            Writer.WriteUInt32(valu_zombie_8.Value)
            Writer.Position = zombie_9
            Writer.WriteUInt32(valu_zombie_9.Value)
            Writer.Position = zombie_10
            Writer.WriteUInt32(valu_zombie_10.Value)
            Writer.Position = zombie_11
            Writer.WriteUInt32(valu_zombie_11.Value)
            Writer.Position = zombie_12
            Writer.WriteUInt32(valu_zombie_12.Value)
            Writer.Position = zombie_13
            Writer.WriteUInt32(valu_zombie_13.Value)
            Writer.Position = zombie_14
            Writer.WriteUInt32(valu_zombie_14.Value)
            Writer.Position = zombie_15
            Writer.WriteUInt32(valu_zombie_15.Value)
            Writer.Position = zombie_16
            Writer.WriteUInt32(valu_zombie_16.Value)
            Writer.Position = zombie_17
            Writer.WriteUInt32(valu_zombie_17.Value)
            Writer.Position = zombie_18
            Writer.WriteUInt32(valu_zombie_18.Value)
            Writer.Position = zombie_19
            Writer.WriteUInt32(valu_zombie_19.Value)
            Writer.Position = zombie_20
            Writer.WriteUInt32(valu_zombie_20.Value)
            Writer.Position = zombie_21
            Writer.WriteUInt32(valu_zombie_21.Value)
            Writer.Position = zombie_22
            Writer.WriteUInt32(valu_zombie_22.Value)
            Writer.Position = zombie_23
            Writer.WriteUInt32(valu_zombie_23.Value)
            Writer.Position = zombie_24
            Writer.WriteUInt32(valu_zombie_24.Value)
            Writer.Position = zombie_25
            Writer.WriteUInt32(valu_zombie_25.Value)
            Writer.Position = zombie_26
            Writer.WriteUInt32(valu_zombie_26.Value)
            Writer.Position = zombie_27
            Writer.WriteUInt32(valu_zombie_27.Value)
            Writer.Position = zombie_28
            Writer.WriteUInt32(valu_zombie_28.Value)
            Writer.Position = zombie_29
            Writer.WriteUInt32(valu_zombie_29.Value)
            Writer.Position = zombie_30
            Writer.WriteUInt32(valu_zombie_30.Value)
            Writer.Position = zombie_31
            Writer.WriteUInt32(valu_zombie_31.Value)
            Writer.Position = rarezombie_1
            Writer.WriteUInt32(valu_rzombie_1.Value)
            Writer.Position = rarezombie_2
            Writer.WriteUInt32(valu_rzombie_2.Value)
            Writer.Position = rarezombie_3
            Writer.WriteUInt32(valu_rzombie_3.Value)
            Writer.Position = rarezombie_4
            Writer.WriteUInt32(valu_rzombie_4.Value)
            Writer.Position = rarezombie_5
            Writer.WriteUInt32(valu_rzombie_5.Value)
            Writer.Position = rarezombie_6
            Writer.WriteUInt32(valu_rzombie_6.Value)
            Writer.Position = rarezombie_7
            Writer.WriteUInt32(valu_rzombie_7.Value)
            Writer.Position = rarezombie_8
            Writer.WriteUInt32(valu_rzombie_8.Value)
            Writer.Position = rarezombie_9
            Writer.WriteUInt32(valu_rzombie_9.Value)
            Writer.Position = rarezombie_10
            Writer.WriteUInt32(valu_rzombie_10.Value)
            Writer.Position = rarezombie_11
            Writer.WriteUInt32(valu_rzombie_11.Value)
            Writer.Position = rarezombie_12
            Writer.WriteUInt32(valu_rzombie_12.Value)
            Writer.Position = rarezombie_13
            Writer.WriteUInt32(valu_rzombie_13.Value)
            Writer.Position = rarezombie_14
            Writer.WriteUInt32(valu_rzombie_14.Value)
            Writer.Position = rarezombie_15
            Writer.WriteUInt32(valu_rzombie_15.Value)
            Writer.Position = rarezombie_16
            Writer.WriteUInt32(valu_rzombie_16.Value)
            Writer.Position = rarezombie_17
            Writer.WriteUInt32(valu_rzombie_17.Value)
            Writer.Position = rarezombie_18
            Writer.WriteUInt32(valu_rzombie_18.Value)
            Writer.Position = rarezombie_19
            Writer.WriteUInt32(valu_rzombie_19.Value)
            Writer.Position = rarezombie_20
            Writer.WriteUInt32(valu_rzombie_20.Value)
            Writer.Position = rarezombie_21
            Writer.WriteUInt32(valu_rzombie_21.Value)
            Writer.Position = rarezombie_22
            Writer.WriteUInt32(valu_rzombie_22.Value)
            Writer.Position = rarezombie_23
            Writer.WriteUInt32(valu_rzombie_23.Value)
            Writer.Position = rarezombie_24
            Writer.WriteUInt32(valu_rzombie_24.Value)
            Writer.Position = rarezombie_25
            Writer.WriteUInt32(valu_rzombie_25.Value)
            Writer.Position = rarezombie_26
            Writer.WriteUInt32(valu_rzombie_26.Value)
            Writer.Position = weapon_1
            Writer.WriteUInt16(valu_weapon_1.Value)
            Writer.Position = weapon_2
            Writer.WriteUInt16(valu_weapon_2.Value)
            Writer.Position = weapon_3
            Writer.WriteUInt16(valu_weapon_3.Value)
            Writer.Position = weapon_4
            Writer.WriteUInt16(valu_weapon_4.Value)
            Writer.Position = weapon_5
            Writer.WriteUInt16(valu_weapon_5.Value)
            Writer.Position = weapon_6
            Writer.WriteUInt16(valu_weapon_6.Value)
            Writer.Position = weapon_7
            Writer.WriteUInt16(valu_weapon_7.Value)
            Writer.Position = weapon_8
            Writer.WriteUInt16(valu_weapon_8.Value)
            Writer.Position = weapon_9
            Writer.WriteUInt16(valu_weapon_9.Value)
            Writer.Position = weapon_10
            Writer.WriteUInt16(valu_weapon_10.Value)
            Writer.Position = weapon_11
            Writer.WriteUInt16(valu_weapon_11.Value)
            Writer.Position = weapon_12
            Writer.WriteUInt16(valu_weapon_12.Value)
            Writer.Position = weapon_13
            Writer.WriteUInt16(valu_weapon_13.Value)
            Writer.Position = weapon_14
            Writer.WriteUInt16(valu_weapon_14.Value)
            Writer.Position = weapon_15
            Writer.WriteUInt16(valu_weapon_15.Value)
            Writer.Position = weapon_16
            Writer.WriteUInt16(valu_weapon_16.Value)
            Writer.Position = weapon_17
            Writer.WriteUInt16(valu_weapon_17.Value)
            Writer.Position = weapon_18
            Writer.WriteUInt16(valu_weapon_18.Value)
            Writer.Position = weapon_19
            Writer.WriteUInt16(valu_weapon_19.Value)
            Writer.Position = weapon_20
            Writer.WriteUInt16(valu_weapon_20.Value)
            Writer.Position = weapon_21
            Writer.WriteUInt16(valu_weapon_21.Value)
            Writer.Position = weapon_22
            Writer.WriteUInt16(valu_weapon_22.Value)
            Writer.Position = weapon_23
            Writer.WriteUInt16(valu_weapon_23.Value)
            Writer.Position = weapon_24
            Writer.WriteUInt16(valu_weapon_24.Value)
            Writer.Position = weapon_25
            Writer.WriteUInt16(valu_weapon_25.Value)
            Writer.Position = weapon_26
            Writer.WriteUInt16(valu_weapon_26.Value)
            fdialog.Description.Text = "Editing of mgZmb0.dat has been saved"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Description.Text = "Failed to edit mgZmb0.dat, make sure you have opened a save file or report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Public Sub hidepanels()
        Panel_main.Visible = False
        Panel_rarezombiesedit.Visible = False
        Panel_weaponsedit.Visible = False
        Panel_zombiesedit.Visible = False
        Panel_levelsedit.Visible = False
    End Sub

    Public Sub makebakmgZmb0()
        Try
            My.Computer.FileSystem.CopyFile(
                          mgZmb0,
                        applicationpath & "\backup\Battleground Z\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\mgZmb0.dat")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Icon_rarezombiesedit_return_Click(sender As Object, e As EventArgs) Handles Icon_rarezombiesedit_return.Click
        hidepanels()
        Panel_main.Visible = True
    End Sub

    Private Sub Icon_weaponsedit_return_Click(sender As Object, e As EventArgs) Handles Icon_weaponsedit_return.Click
        hidepanels()
        Panel_main.Visible = True
    End Sub

    Private Sub Icon_zombiesedit_return_Click(sender As Object, e As EventArgs) Handles Icon_zombiesedit_return.Click
        hidepanels()
        Panel_main.Visible = True
    End Sub

    Private Sub Icon_levelsedit_return_Click(sender As Object, e As EventArgs) Handles Icon_levelsedit_return.Click
        hidepanels()
        Panel_main.Visible = True
    End Sub

    Private Sub Text_rarezombiesedit_unlockall_Click(sender As Object, e As EventArgs) Handles Text_rarezombiesedit_unlockall.Click
        valu_rzombie_1.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_2.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_3.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_4.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_5.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_6.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_7.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_8.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_9.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_10.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_11.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_12.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_13.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_14.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_15.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_16.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_17.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_18.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_19.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_20.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_21.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_22.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_23.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_24.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_25.Value = valu_rarezombiesedit_unlockall.Value
        valu_rzombie_26.Value = valu_rarezombiesedit_unlockall.Value
    End Sub

    Private Sub Text_zombiesedit_unlockall_Click(sender As Object, e As EventArgs) Handles Text_zombiesedit_unlockall.Click
        valu_zombie_1.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_2.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_3.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_4.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_5.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_6.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_7.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_8.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_9.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_10.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_11.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_12.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_13.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_14.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_15.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_16.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_17.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_18.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_19.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_20.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_21.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_22.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_23.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_24.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_25.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_26.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_27.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_28.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_29.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_30.Value = valu_zombiesedit_unlockall.Value
        valu_zombie_31.Value = valu_zombiesedit_unlockall.Value
    End Sub

    Private Sub Icon_rarezombiesedit_Click(sender As Object, e As EventArgs) Handles Icon_rarezombiesedit.Click
        hidepanels()
        Panel_rarezombiesedit.Visible = True
    End Sub

    Private Sub Icon_weaponsedi_Click(sender As Object, e As EventArgs) Handles Icon_weaponsedit.Click
        hidepanels()
        Panel_weaponsedit.Visible = True
    End Sub

    Private Sub Icon_zombiesedit_Click(sender As Object, e As EventArgs) Handles Icon_zombiesedit.Click
        hidepanels()
        Panel_zombiesedit.Visible = True
    End Sub

    Private Sub Icon_levelsedit_Click(sender As Object, e As EventArgs) Handles Icon_levelsedit.Click
        hidepanels()
        Panel_levelsedit.Visible = True
    End Sub

    Private Sub Text_weaponsedit_unlockall_Click(sender As Object, e As EventArgs) Handles Text_weaponsedit_unlockall.Click
        valu_weapon_1.Value = 61695
        valu_weapon_2.Value = 61695
        valu_weapon_3.Value = 61695
        valu_weapon_4.Value = 61695
        valu_weapon_5.Value = 61695
        valu_weapon_6.Value = 61695
        valu_weapon_7.Value = 61695
        valu_weapon_8.Value = 61695
        valu_weapon_9.Value = 61695
        valu_weapon_10.Value = 61695
        valu_weapon_11.Value = 61695
        valu_weapon_12.Value = 61695
        valu_weapon_13.Value = 61695
        valu_weapon_14.Value = 61695
        valu_weapon_15.Value = 61695
        valu_weapon_16.Value = 61695
        valu_weapon_17.Value = 61695
        valu_weapon_18.Value = 61695
        valu_weapon_19.Value = 61695
        valu_weapon_20.Value = 61695
        valu_weapon_21.Value = 61695
        valu_weapon_22.Value = 61695
        valu_weapon_23.Value = 61695
        valu_weapon_24.Value = 61695
        valu_weapon_25.Value = 61695
        valu_weapon_26.Value = 61695
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Dim open As New OpenFileDialog
        fdialog.Description.Text = "Open mgZmb0.dat" & vbNewLine & "Battleground Z Save Editor will make a backup of your save file, check ''backup'' folder"
        fdialog.ShowDialog()
        open.Filter = "DAT files|*mgZmb0.dat"
        open.Title = "Open save mgZmb0.dat"
        open.ShowDialog()
        mgZmb0 = open.FileName
        readfilesavemgZmb0()
        makebakmgZmb0()
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        writefilesavemgZmb0()
    End Sub

End Class