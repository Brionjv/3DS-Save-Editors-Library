Imports PackageIO
Imports System.IO
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
    Dim Station = &H30
    Dim Hopital = &H31
    Dim Parking = &H32
    Dim Ruelle = &H33
    Dim Stade = &H34
    Dim Rififistade = &H35
    Dim ComEntree = &H36
    Dim Galerie = &H37
    Dim Place = &H38
    Dim Entrepot = &H39
    Dim Airerestauration = &H3A
    Dim Rififiairerestauration = &H3B
    Dim Quartierresidentiel = &H3C
    Dim Chantier = &H3D
    Dim Stationservice = &H3E
    Dim Autoroute = &H3F
    Dim Champmais = &H40
    Dim Rififiquartierresidentiel = &H41
    Dim Tunnel = &H42
    Dim Cimetiere = &H43
    Dim Centraleelectrique = &H44
    Dim Barrage = &H45
    Dim Reservoir = &H46
    Dim Rifificimetiere = &H47
    Dim ViroEntree = &H48
    Dim Reservoirtoxique = &H49
    Dim Laboratoire = &H4A
    Dim Ascenseur = &H4B
    Dim Toit = &H4C
    Dim Rififitoit = &H4D

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

    Private Sub SMPBZSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPBZSE_header.MouseDown, SMPBZSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub SMPBZSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPBZSE_header.MouseUp, SMPBZSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub SMPBZSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPBZSE_header.MouseMove, SMPBZSE_title.MouseMove
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
            Reader.Position = Station
            valu_station.Value = Reader.ReadByte
            Reader.Position = Hopital
            valu_hopital.Value = Reader.ReadByte
            Reader.Position = Parking
            valu_parking.Value = Reader.ReadByte
            Reader.Position = Ruelle
            valu_ruelle.Value = Reader.ReadByte
            Reader.Position = Stade
            valu_stade.Value = Reader.ReadByte
            Reader.Position = Rififistade
            valu_rififistade.Value = Reader.ReadByte
            Reader.Position = ComEntree
            valu_comentree.Value = Reader.ReadByte
            Reader.Position = Galerie
            valu_galerie.Value = Reader.ReadByte
            Reader.Position = Place
            valu_place.Value = Reader.ReadByte
            Reader.Position = Entrepot
            valu_entrepot.Value = Reader.ReadByte
            Reader.Position = Airerestauration
            valu_airerestauration.Value = Reader.ReadByte
            Reader.Position = Rififiairerestauration
            valu_rififiairerestauration.Value = Reader.ReadByte
            Reader.Position = Quartierresidentiel
            valu_quartresidentiel.Value = Reader.ReadByte
            Reader.Position = Chantier
            valu_chantier.Value = Reader.ReadByte
            Reader.Position = Stationservice
            valu_stationserv.Value = Reader.ReadByte
            Reader.Position = Autoroute
            valu_autoroute.Value = Reader.ReadByte
            Reader.Position = Champmais
            valu_champmais.Value = Reader.ReadByte
            Reader.Position = Rififiquartierresidentiel
            valu_rififiquartresidentiel.Value = Reader.ReadByte
            Reader.Position = Tunnel
            valu_tunnel.Value = Reader.ReadByte
            Reader.Position = Cimetiere
            valu_cimetiere.Value = Reader.ReadByte
            Reader.Position = Centraleelectrique
            valu_centrelec.Value = Reader.ReadByte
            Reader.Position = Barrage
            valu_barrage.Value = Reader.ReadByte
            Reader.Position = Reservoir
            valu_reservoir.Value = Reader.ReadByte
            Reader.Position = Rifificimetiere
            valu_rifificimetiere.Value = Reader.ReadByte
            Reader.Position = ViroEntree
            valu_viroentree.Value = Reader.ReadByte
            Reader.Position = Reservoirtoxique
            valu_reservoirtox.Value = Reader.ReadByte
            Reader.Position = Laboratoire
            valu_laboratoire.Value = Reader.ReadByte
            Reader.Position = Ascenseur
            valu_ascenseur.Value = Reader.ReadByte
            Reader.Position = Toit
            valu_toit.Value = Reader.ReadByte
            Reader.Position = Rififitoit
            valu_rififitoit.Value = Reader.ReadByte
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

            Dim fs As New FileStream(mgZmb0, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            fs.Position = Station
            fs.WriteByte(valu_station.Value)
            fs.Position = Hopital
            fs.WriteByte(valu_hopital.Value)
            fs.Position = Parking
            fs.WriteByte(valu_parking.Value)
            fs.Position = Ruelle
            fs.WriteByte(valu_ruelle.Value)
            fs.Position = Stade
            fs.WriteByte(valu_stade.Value)
            fs.Position = Rififistade
            fs.WriteByte(valu_rififistade.Value)
            fs.Position = ComEntree
            fs.WriteByte(valu_comentree.Value)
            fs.Position = Galerie
            fs.WriteByte(valu_galerie.Value)
            fs.Position = Place
            fs.WriteByte(valu_place.Value)
            fs.Position = Entrepot
            fs.WriteByte(valu_entrepot.Value)
            fs.Position = Airerestauration
            fs.WriteByte(valu_airerestauration.Value)
            fs.Position = Rififiairerestauration
            fs.WriteByte(valu_rififiairerestauration.Value)
            fs.Position = Quartierresidentiel
            fs.WriteByte(valu_quartresidentiel.Value)
            fs.Position = Chantier
            fs.WriteByte(valu_chantier.Value)
            fs.Position = Stationservice
            fs.WriteByte(valu_stationserv.Value)
            fs.Position = Autoroute
            fs.WriteByte(valu_autoroute.Value)
            fs.Position = Champmais
            fs.WriteByte(valu_champmais.Value)
            fs.Position = Rififiquartierresidentiel
            fs.WriteByte(valu_rififiquartresidentiel.Value)
            fs.Position = Tunnel
            fs.WriteByte(valu_tunnel.Value)
            fs.Position = Cimetiere
            fs.WriteByte(valu_cimetiere.Value)
            fs.Position = Centraleelectrique
            fs.WriteByte(valu_centrelec.Value)
            fs.Position = Barrage
            fs.WriteByte(valu_barrage.Value)
            fs.Position = Reservoir
            fs.WriteByte(valu_reservoir.Value)
            fs.Position = Rifificimetiere
            fs.WriteByte(valu_rifificimetiere.Value)
            fs.Position = ViroEntree
            fs.WriteByte(valu_viroentree.Value)
            fs.Position = Reservoirtoxique
            fs.WriteByte(valu_reservoirtox.Value)
            fs.Position = Laboratoire
            fs.WriteByte(valu_laboratoire.Value)
            fs.Position = Ascenseur
            fs.WriteByte(valu_ascenseur.Value)
            fs.Position = Toit
            fs.WriteByte(valu_toit.Value)
            fs.Position = Rififitoit
            fs.WriteByte(valu_rififitoit.Value)
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

    Private Sub Icon_station_Click(sender As Object, e As EventArgs) Handles Icon_station.Click
        If valu_station.Value = 4 Then
            valu_station.Value = 0
        Else
            valu_station.Value = valu_station.Value + 1
        End If
    End Sub

    Private Sub valu_station_ValueChanged(sender As Object, e As EventArgs) Handles valu_station.ValueChanged
        If valu_station.Value = 0 Then
            Icon_station.Image = My.Resources.icon_level_na
        ElseIf valu_station.Value = 1 Then
            Icon_station.Image = My.Resources.icon_level_enable
        ElseIf valu_station.Value = 2 Then
            Icon_station.Image = My.Resources.icon_level_enable
        ElseIf valu_station.Value = 3 Then
            Icon_station.Image = My.Resources.icon_level_clear
        ElseIf valu_station.Value = 4 Then
            Icon_station.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_hopital_Click(sender As Object, e As EventArgs) Handles Icon_hopital.Click
        If valu_hopital.Value = 4 Then
            valu_hopital.Value = 0
        Else
            valu_hopital.Value = valu_hopital.Value + 1
        End If
    End Sub

    Private Sub valu_hopital_ValueChanged(sender As Object, e As EventArgs) Handles valu_hopital.ValueChanged
        If valu_hopital.Value = 0 Then
            Icon_hopital.Image = My.Resources.icon_level_na
        ElseIf valu_hopital.Value = 1 Then
            Icon_hopital.Image = My.Resources.icon_level_enable
        ElseIf valu_hopital.Value = 2 Then
            Icon_hopital.Image = My.Resources.icon_level_enable
        ElseIf valu_hopital.Value = 3 Then
            Icon_hopital.Image = My.Resources.icon_level_clear
        ElseIf valu_hopital.Value = 4 Then
            Icon_hopital.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_parking_Click(sender As Object, e As EventArgs) Handles Icon_parking.Click
        If valu_parking.Value = 4 Then
            valu_parking.Value = 0
        Else
            valu_parking.Value = valu_parking.Value + 1
        End If
    End Sub

    Private Sub valu_parking_ValueChanged(sender As Object, e As EventArgs) Handles valu_parking.ValueChanged
        If valu_parking.Value = 0 Then
            Icon_parking.Image = My.Resources.icon_level_na
        ElseIf valu_parking.Value = 1 Then
            Icon_parking.Image = My.Resources.icon_level_enable
        ElseIf valu_parking.Value = 2 Then
            Icon_parking.Image = My.Resources.icon_level_enable
        ElseIf valu_parking.Value = 3 Then
            Icon_parking.Image = My.Resources.icon_level_clear
        ElseIf valu_parking.Value = 4 Then
            Icon_parking.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_ruelle_Click(sender As Object, e As EventArgs) Handles Icon_ruelle.Click
        If valu_ruelle.Value = 4 Then
            valu_ruelle.Value = 0
        Else
            valu_ruelle.Value = valu_ruelle.Value + 1
        End If
    End Sub

    Private Sub valu_ruelle_ValueChanged(sender As Object, e As EventArgs) Handles valu_ruelle.ValueChanged
        If valu_ruelle.Value = 0 Then
            Icon_ruelle.Image = My.Resources.icon_level_na
        ElseIf valu_ruelle.Value = 1 Then
            Icon_ruelle.Image = My.Resources.icon_level_enable
        ElseIf valu_ruelle.Value = 2 Then
            Icon_ruelle.Image = My.Resources.icon_level_enable
        ElseIf valu_ruelle.Value = 3 Then
            Icon_ruelle.Image = My.Resources.icon_level_clear
        ElseIf valu_ruelle.Value = 4 Then
            Icon_ruelle.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_stade_Click(sender As Object, e As EventArgs) Handles Icon_stade.Click
        If valu_stade.Value = 4 Then
            valu_stade.Value = 0
        Else
            valu_stade.Value = valu_stade.Value + 1
        End If
    End Sub

    Private Sub valu_stade_ValueChanged(sender As Object, e As EventArgs) Handles valu_stade.ValueChanged
        If valu_stade.Value = 0 Then
            Icon_stade.Image = My.Resources.icon_level_na
        ElseIf valu_stade.Value = 1 Then
            Icon_stade.Image = My.Resources.icon_level_enable
        ElseIf valu_stade.Value = 2 Then
            Icon_stade.Image = My.Resources.icon_level_enable
        ElseIf valu_stade.Value = 3 Then
            Icon_stade.Image = My.Resources.icon_level_clear
        ElseIf valu_stade.Value = 4 Then
            Icon_stade.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_rififistade_Click(sender As Object, e As EventArgs) Handles Icon_rififistade.Click
        If valu_rififistade.Value = 4 Then
            valu_rififistade.Value = 0
        Else
            valu_rififistade.Value = valu_rififistade.Value + 1
        End If
    End Sub

    Private Sub valu_rififistade_ValueChanged(sender As Object, e As EventArgs) Handles valu_rififistade.ValueChanged
        If valu_rififistade.Value = 0 Then
            Icon_rififistade.Image = My.Resources.icon_level_na
        ElseIf valu_rififistade.Value = 1 Then
            Icon_rififistade.Image = My.Resources.icon_level_enable
        ElseIf valu_rififistade.Value = 2 Then
            Icon_rififistade.Image = My.Resources.icon_level_enable
        ElseIf valu_rififistade.Value = 3 Then
            Icon_rififistade.Image = My.Resources.icon_level_clear
        ElseIf valu_rififistade.Value = 4 Then
            Icon_rififistade.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_comentree_Click(sender As Object, e As EventArgs) Handles Icon_comentree.Click
        If valu_comentree.Value = 4 Then
            valu_comentree.Value = 0
        Else
            valu_comentree.Value = valu_comentree.Value + 1
        End If
    End Sub

    Private Sub valu_comentree_ValueChanged(sender As Object, e As EventArgs) Handles valu_comentree.ValueChanged
        If valu_comentree.Value = 0 Then
            Icon_comentree.Image = My.Resources.icon_level_na
        ElseIf valu_comentree.Value = 1 Then
            Icon_comentree.Image = My.Resources.icon_level_enable
        ElseIf valu_comentree.Value = 2 Then
            Icon_comentree.Image = My.Resources.icon_level_enable
        ElseIf valu_comentree.Value = 3 Then
            Icon_comentree.Image = My.Resources.icon_level_clear
        ElseIf valu_comentree.Value = 4 Then
            Icon_comentree.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_galerie_Click(sender As Object, e As EventArgs) Handles Icon_galerie.Click
        If valu_galerie.Value = 4 Then
            valu_galerie.Value = 0
        Else
            valu_galerie.Value = valu_galerie.Value + 1
        End If
    End Sub

    Private Sub valu_galerie_ValueChanged(sender As Object, e As EventArgs) Handles valu_galerie.ValueChanged
        If valu_galerie.Value = 0 Then
            Icon_galerie.Image = My.Resources.icon_level_na
        ElseIf valu_galerie.Value = 1 Then
            Icon_galerie.Image = My.Resources.icon_level_enable
        ElseIf valu_galerie.Value = 2 Then
            Icon_galerie.Image = My.Resources.icon_level_enable
        ElseIf valu_galerie.Value = 3 Then
            Icon_galerie.Image = My.Resources.icon_level_clear
        ElseIf valu_galerie.Value = 4 Then
            Icon_galerie.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_place_Click(sender As Object, e As EventArgs) Handles Icon_place.Click
        If valu_place.Value = 4 Then
            valu_place.Value = 0
        Else
            valu_place.Value = valu_place.Value + 1
        End If
    End Sub

    Private Sub valu_place_ValueChanged(sender As Object, e As EventArgs) Handles valu_place.ValueChanged
        If valu_place.Value = 0 Then
            Icon_place.Image = My.Resources.icon_level_na
        ElseIf valu_place.Value = 1 Then
            Icon_place.Image = My.Resources.icon_level_enable
        ElseIf valu_place.Value = 2 Then
            Icon_place.Image = My.Resources.icon_level_enable
        ElseIf valu_place.Value = 3 Then
            Icon_place.Image = My.Resources.icon_level_clear
        ElseIf valu_place.Value = 4 Then
            Icon_place.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_entrepot_Click(sender As Object, e As EventArgs) Handles Icon_entrepot.Click
        If valu_entrepot.Value = 4 Then
            valu_entrepot.Value = 0
        Else
            valu_entrepot.Value = valu_entrepot.Value + 1
        End If
    End Sub

    Private Sub valu_entrepot_ValueChanged(sender As Object, e As EventArgs) Handles valu_entrepot.ValueChanged
        If valu_entrepot.Value = 0 Then
            Icon_entrepot.Image = My.Resources.icon_level_na
        ElseIf valu_entrepot.Value = 1 Then
            Icon_entrepot.Image = My.Resources.icon_level_enable
        ElseIf valu_entrepot.Value = 2 Then
            Icon_entrepot.Image = My.Resources.icon_level_enable
        ElseIf valu_entrepot.Value = 3 Then
            Icon_entrepot.Image = My.Resources.icon_level_clear
        ElseIf valu_entrepot.Value = 4 Then
            Icon_entrepot.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_airerestauration_Click(sender As Object, e As EventArgs) Handles Icon_airerestauration.Click
        If valu_airerestauration.Value = 4 Then
            valu_airerestauration.Value = 0
        Else
            valu_airerestauration.Value = valu_airerestauration.Value + 1
        End If
    End Sub

    Private Sub valu_airerestauration_ValueChanged(sender As Object, e As EventArgs) Handles valu_airerestauration.ValueChanged
        If valu_airerestauration.Value = 0 Then
            Icon_airerestauration.Image = My.Resources.icon_level_na
        ElseIf valu_airerestauration.Value = 1 Then
            Icon_airerestauration.Image = My.Resources.icon_level_enable
        ElseIf valu_airerestauration.Value = 2 Then
            Icon_airerestauration.Image = My.Resources.icon_level_enable
        ElseIf valu_airerestauration.Value = 3 Then
            Icon_airerestauration.Image = My.Resources.icon_level_clear
        ElseIf valu_airerestauration.Value = 4 Then
            Icon_airerestauration.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_rififiairerestauration_Click(sender As Object, e As EventArgs) Handles Icon_rififiairerestauration.Click
        If valu_rififiairerestauration.Value = 4 Then
            valu_rififiairerestauration.Value = 0
        Else
            valu_rififiairerestauration.Value = valu_rififiairerestauration.Value + 1
        End If
    End Sub

    Private Sub valu_rififiairerestauration_ValueChanged(sender As Object, e As EventArgs) Handles valu_rififiairerestauration.ValueChanged
        If valu_rififiairerestauration.Value = 0 Then
            Icon_rififiairerestauration.Image = My.Resources.icon_level_na
        ElseIf valu_rififiairerestauration.Value = 1 Then
            Icon_rififiairerestauration.Image = My.Resources.icon_level_enable
        ElseIf valu_rififiairerestauration.Value = 2 Then
            Icon_rififiairerestauration.Image = My.Resources.icon_level_enable
        ElseIf valu_rififiairerestauration.Value = 3 Then
            Icon_rififiairerestauration.Image = My.Resources.icon_level_clear
        ElseIf valu_rififiairerestauration.Value = 4 Then
            Icon_rififiairerestauration.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_quartresidentiel_Click(sender As Object, e As EventArgs) Handles Icon_quartresidentiel.Click
        If valu_quartresidentiel.Value = 4 Then
            valu_quartresidentiel.Value = 0
        Else
            valu_quartresidentiel.Value = valu_quartresidentiel.Value + 1
        End If
    End Sub

    Private Sub valu_quartresidentiel_ValueChanged(sender As Object, e As EventArgs) Handles valu_quartresidentiel.ValueChanged
        If valu_quartresidentiel.Value = 0 Then
            Icon_quartresidentiel.Image = My.Resources.icon_level_na
        ElseIf valu_quartresidentiel.Value = 1 Then
            Icon_quartresidentiel.Image = My.Resources.icon_level_enable
        ElseIf valu_quartresidentiel.Value = 2 Then
            Icon_quartresidentiel.Image = My.Resources.icon_level_enable
        ElseIf valu_quartresidentiel.Value = 3 Then
            Icon_quartresidentiel.Image = My.Resources.icon_level_clear
        ElseIf valu_quartresidentiel.Value = 4 Then
            Icon_quartresidentiel.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_chantier_Click(sender As Object, e As EventArgs) Handles Icon_chantier.Click
        If valu_chantier.Value = 4 Then
            valu_chantier.Value = 0
        Else
            valu_chantier.Value = valu_chantier.Value + 1
        End If
    End Sub

    Private Sub valu_chantier_ValueChanged(sender As Object, e As EventArgs) Handles valu_chantier.ValueChanged
        If valu_chantier.Value = 0 Then
            Icon_chantier.Image = My.Resources.icon_level_na
        ElseIf valu_chantier.Value = 1 Then
            Icon_chantier.Image = My.Resources.icon_level_enable
        ElseIf valu_chantier.Value = 2 Then
            Icon_chantier.Image = My.Resources.icon_level_enable
        ElseIf valu_chantier.Value = 3 Then
            Icon_chantier.Image = My.Resources.icon_level_clear
        ElseIf valu_chantier.Value = 4 Then
            Icon_chantier.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_stationserv_Click(sender As Object, e As EventArgs) Handles Icon_stationserv.Click
        If valu_stationserv.Value = 4 Then
            valu_stationserv.Value = 0
        Else
            valu_stationserv.Value = valu_stationserv.Value + 1
        End If
    End Sub

    Private Sub valu_stationserv_ValueChanged(sender As Object, e As EventArgs) Handles valu_stationserv.ValueChanged
        If valu_stationserv.Value = 0 Then
            Icon_stationserv.Image = My.Resources.icon_level_na
        ElseIf valu_stationserv.Value = 1 Then
            Icon_stationserv.Image = My.Resources.icon_level_enable
        ElseIf valu_stationserv.Value = 2 Then
            Icon_stationserv.Image = My.Resources.icon_level_enable
        ElseIf valu_stationserv.Value = 3 Then
            Icon_stationserv.Image = My.Resources.icon_level_clear
        ElseIf valu_stationserv.Value = 4 Then
            Icon_stationserv.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_autoroute_Click(sender As Object, e As EventArgs) Handles Icon_autoroute.Click
        If valu_autoroute.Value = 4 Then
            valu_autoroute.Value = 0
        Else
            valu_autoroute.Value = valu_autoroute.Value + 1
        End If
    End Sub

    Private Sub valu_autoroute_ValueChanged(sender As Object, e As EventArgs) Handles valu_autoroute.ValueChanged
        If valu_autoroute.Value = 0 Then
            Icon_autoroute.Image = My.Resources.icon_level_na
        ElseIf valu_autoroute.Value = 1 Then
            Icon_autoroute.Image = My.Resources.icon_level_enable
        ElseIf valu_autoroute.Value = 2 Then
            Icon_autoroute.Image = My.Resources.icon_level_enable
        ElseIf valu_autoroute.Value = 3 Then
            Icon_autoroute.Image = My.Resources.icon_level_clear
        ElseIf valu_autoroute.Value = 4 Then
            Icon_autoroute.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_champmais_Click(sender As Object, e As EventArgs) Handles Icon_champmais.Click
        If valu_champmais.Value = 4 Then
            valu_champmais.Value = 0
        Else
            valu_champmais.Value = valu_champmais.Value + 1
        End If
    End Sub

    Private Sub valu_champmais_ValueChanged(sender As Object, e As EventArgs) Handles valu_champmais.ValueChanged
        If valu_champmais.Value = 0 Then
            Icon_champmais.Image = My.Resources.icon_level_na
        ElseIf valu_champmais.Value = 1 Then
            Icon_champmais.Image = My.Resources.icon_level_enable
        ElseIf valu_champmais.Value = 2 Then
            Icon_champmais.Image = My.Resources.icon_level_enable
        ElseIf valu_champmais.Value = 3 Then
            Icon_champmais.Image = My.Resources.icon_level_clear
        ElseIf valu_champmais.Value = 4 Then
            Icon_champmais.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_rififiquartresidentiel_Click(sender As Object, e As EventArgs) Handles Icon_rififiquartresidentiel.Click
        If valu_rififiquartresidentiel.Value = 4 Then
            valu_rififiquartresidentiel.Value = 0
        Else
            valu_rififiquartresidentiel.Value = valu_rififiquartresidentiel.Value + 1
        End If
    End Sub

    Private Sub valu_rififiquartresidentiel_ValueChanged(sender As Object, e As EventArgs) Handles valu_rififiquartresidentiel.ValueChanged
        If valu_rififiquartresidentiel.Value = 0 Then
            Icon_rififiquartresidentiel.Image = My.Resources.icon_level_na
        ElseIf valu_rififiquartresidentiel.Value = 1 Then
            Icon_rififiquartresidentiel.Image = My.Resources.icon_level_enable
        ElseIf valu_rififiquartresidentiel.Value = 2 Then
            Icon_rififiquartresidentiel.Image = My.Resources.icon_level_enable
        ElseIf valu_rififiquartresidentiel.Value = 3 Then
            Icon_rififiquartresidentiel.Image = My.Resources.icon_level_clear
        ElseIf valu_rififiquartresidentiel.Value = 4 Then
            Icon_rififiquartresidentiel.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_tunnel_Click(sender As Object, e As EventArgs) Handles Icon_tunnel.Click
        If valu_tunnel.Value = 4 Then
            valu_tunnel.Value = 0
        Else
            valu_tunnel.Value = valu_tunnel.Value + 1
        End If
    End Sub

    Private Sub valu_tunnel_ValueChanged(sender As Object, e As EventArgs) Handles valu_tunnel.ValueChanged
        If valu_tunnel.Value = 0 Then
            Icon_tunnel.Image = My.Resources.icon_level_na
        ElseIf valu_tunnel.Value = 1 Then
            Icon_tunnel.Image = My.Resources.icon_level_enable
        ElseIf valu_tunnel.Value = 2 Then
            Icon_tunnel.Image = My.Resources.icon_level_enable
        ElseIf valu_tunnel.Value = 3 Then
            Icon_tunnel.Image = My.Resources.icon_level_clear
        ElseIf valu_tunnel.Value = 4 Then
            Icon_tunnel.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_cimetiere_Click(sender As Object, e As EventArgs) Handles Icon_cimetiere.Click
        If valu_cimetiere.Value = 4 Then
            valu_cimetiere.Value = 0
        Else
            valu_cimetiere.Value = valu_cimetiere.Value + 1
        End If
    End Sub

    Private Sub valu_cimetiere_ValueChanged(sender As Object, e As EventArgs) Handles valu_cimetiere.ValueChanged
        If valu_cimetiere.Value = 0 Then
            Icon_cimetiere.Image = My.Resources.icon_level_na
        ElseIf valu_cimetiere.Value = 1 Then
            Icon_cimetiere.Image = My.Resources.icon_level_enable
        ElseIf valu_cimetiere.Value = 2 Then
            Icon_cimetiere.Image = My.Resources.icon_level_enable
        ElseIf valu_cimetiere.Value = 3 Then
            Icon_cimetiere.Image = My.Resources.icon_level_clear
        ElseIf valu_cimetiere.Value = 4 Then
            Icon_cimetiere.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_centrelec_Click(sender As Object, e As EventArgs) Handles Icon_centrelec.Click
        If valu_centrelec.Value = 4 Then
            valu_centrelec.Value = 0
        Else
            valu_centrelec.Value = valu_centrelec.Value + 1
        End If
    End Sub

    Private Sub valu_centrelec_ValueChanged(sender As Object, e As EventArgs) Handles valu_centrelec.ValueChanged
        If valu_centrelec.Value = 0 Then
            Icon_centrelec.Image = My.Resources.icon_level_na
        ElseIf valu_centrelec.Value = 1 Then
            Icon_centrelec.Image = My.Resources.icon_level_enable
        ElseIf valu_centrelec.Value = 2 Then
            Icon_centrelec.Image = My.Resources.icon_level_enable
        ElseIf valu_centrelec.Value = 3 Then
            Icon_centrelec.Image = My.Resources.icon_level_clear
        ElseIf valu_centrelec.Value = 4 Then
            Icon_centrelec.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_barrage_Click(sender As Object, e As EventArgs) Handles Icon_barrage.Click
        If valu_barrage.Value = 4 Then
            valu_barrage.Value = 0
        Else
            valu_barrage.Value = valu_barrage.Value + 1
        End If
    End Sub

    Private Sub valu_barrage_ValueChanged(sender As Object, e As EventArgs) Handles valu_barrage.ValueChanged
        If valu_barrage.Value = 0 Then
            Icon_barrage.Image = My.Resources.icon_level_na
        ElseIf valu_barrage.Value = 1 Then
            Icon_barrage.Image = My.Resources.icon_level_enable
        ElseIf valu_barrage.Value = 2 Then
            Icon_barrage.Image = My.Resources.icon_level_enable
        ElseIf valu_barrage.Value = 3 Then
            Icon_barrage.Image = My.Resources.icon_level_clear
        ElseIf valu_barrage.Value = 4 Then
            Icon_barrage.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_reservoir_Click(sender As Object, e As EventArgs) Handles Icon_reservoir.Click
        If valu_reservoir.Value = 4 Then
            valu_reservoir.Value = 0
        Else
            valu_reservoir.Value = valu_reservoir.Value + 1
        End If
    End Sub

    Private Sub valu_reservoir_ValueChanged(sender As Object, e As EventArgs) Handles valu_reservoir.ValueChanged
        If valu_reservoir.Value = 0 Then
            Icon_reservoir.Image = My.Resources.icon_level_na
        ElseIf valu_reservoir.Value = 1 Then
            Icon_reservoir.Image = My.Resources.icon_level_enable
        ElseIf valu_reservoir.Value = 2 Then
            Icon_reservoir.Image = My.Resources.icon_level_enable
        ElseIf valu_reservoir.Value = 3 Then
            Icon_reservoir.Image = My.Resources.icon_level_clear
        ElseIf valu_reservoir.Value = 4 Then
            Icon_reservoir.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_rifificimetiere_Click(sender As Object, e As EventArgs) Handles Icon_rifificimetiere.Click
        If valu_rifificimetiere.Value = 4 Then
            valu_rifificimetiere.Value = 0
        Else
            valu_rifificimetiere.Value = valu_rifificimetiere.Value + 1
        End If
    End Sub

    Private Sub valu_rifificimetiere_ValueChanged(sender As Object, e As EventArgs) Handles valu_rifificimetiere.ValueChanged
        If valu_rifificimetiere.Value = 0 Then
            Icon_rifificimetiere.Image = My.Resources.icon_level_na
        ElseIf valu_rifificimetiere.Value = 1 Then
            Icon_rifificimetiere.Image = My.Resources.icon_level_enable
        ElseIf valu_rifificimetiere.Value = 2 Then
            Icon_rifificimetiere.Image = My.Resources.icon_level_enable
        ElseIf valu_rifificimetiere.Value = 3 Then
            Icon_rifificimetiere.Image = My.Resources.icon_level_clear
        ElseIf valu_rifificimetiere.Value = 4 Then
            Icon_rifificimetiere.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_viroentree_Click(sender As Object, e As EventArgs) Handles Icon_viroentree.Click
        If valu_viroentree.Value = 4 Then
            valu_viroentree.Value = 0
        Else
            valu_viroentree.Value = valu_viroentree.Value + 1
        End If
    End Sub

    Private Sub valu_viroentree_ValueChanged(sender As Object, e As EventArgs) Handles valu_viroentree.ValueChanged
        If valu_viroentree.Value = 0 Then
            Icon_viroentree.Image = My.Resources.icon_level_na
        ElseIf valu_viroentree.Value = 1 Then
            Icon_viroentree.Image = My.Resources.icon_level_enable
        ElseIf valu_viroentree.Value = 2 Then
            Icon_viroentree.Image = My.Resources.icon_level_enable
        ElseIf valu_viroentree.Value = 3 Then
            Icon_viroentree.Image = My.Resources.icon_level_clear
        ElseIf valu_viroentree.Value = 4 Then
            Icon_viroentree.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_reservoirtox_Click(sender As Object, e As EventArgs) Handles Icon_reservoirtox.Click
        If valu_reservoirtox.Value = 4 Then
            valu_reservoirtox.Value = 0
        Else
            valu_reservoirtox.Value = valu_reservoirtox.Value + 1
        End If
    End Sub

    Private Sub valu_reservoirtox_ValueChanged(sender As Object, e As EventArgs) Handles valu_reservoirtox.ValueChanged
        If valu_reservoirtox.Value = 0 Then
            Icon_reservoirtox.Image = My.Resources.icon_level_na
        ElseIf valu_reservoirtox.Value = 1 Then
            Icon_reservoirtox.Image = My.Resources.icon_level_enable
        ElseIf valu_reservoirtox.Value = 2 Then
            Icon_reservoirtox.Image = My.Resources.icon_level_enable
        ElseIf valu_reservoirtox.Value = 3 Then
            Icon_reservoirtox.Image = My.Resources.icon_level_clear
        ElseIf valu_reservoirtox.Value = 4 Then
            Icon_reservoirtox.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_laboratoire_Click(sender As Object, e As EventArgs) Handles Icon_laboratoire.Click
        If valu_laboratoire.Value = 4 Then
            valu_laboratoire.Value = 0
        Else
            valu_laboratoire.Value = valu_laboratoire.Value + 1
        End If
    End Sub

    Private Sub valu_laboratoire_ValueChanged(sender As Object, e As EventArgs) Handles valu_laboratoire.ValueChanged
        If valu_laboratoire.Value = 0 Then
            Icon_laboratoire.Image = My.Resources.icon_level_na
        ElseIf valu_laboratoire.Value = 1 Then
            Icon_laboratoire.Image = My.Resources.icon_level_enable
        ElseIf valu_laboratoire.Value = 2 Then
            Icon_laboratoire.Image = My.Resources.icon_level_enable
        ElseIf valu_laboratoire.Value = 3 Then
            Icon_laboratoire.Image = My.Resources.icon_level_clear
        ElseIf valu_laboratoire.Value = 4 Then
            Icon_laboratoire.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_ascenseur_Click(sender As Object, e As EventArgs) Handles Icon_ascenseur.Click
        If valu_ascenseur.Value = 4 Then
            valu_ascenseur.Value = 0
        Else
            valu_ascenseur.Value = valu_ascenseur.Value + 1
        End If
    End Sub

    Private Sub valu_ascenseur_ValueChanged(sender As Object, e As EventArgs) Handles valu_ascenseur.ValueChanged
        If valu_ascenseur.Value = 0 Then
            Icon_ascenseur.Image = My.Resources.icon_level_na
        ElseIf valu_ascenseur.Value = 1 Then
            Icon_ascenseur.Image = My.Resources.icon_level_enable
        ElseIf valu_ascenseur.Value = 2 Then
            Icon_ascenseur.Image = My.Resources.icon_level_enable
        ElseIf valu_ascenseur.Value = 3 Then
            Icon_ascenseur.Image = My.Resources.icon_level_clear
        ElseIf valu_ascenseur.Value = 4 Then
            Icon_ascenseur.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_Toit_Click(sender As Object, e As EventArgs) Handles Icon_toit.Click
        If valu_Toit.Value = 4 Then
            valu_Toit.Value = 0
        Else
            valu_Toit.Value = valu_Toit.Value + 1
        End If
    End Sub

    Private Sub valu_Toit_ValueChanged(sender As Object, e As EventArgs) Handles valu_toit.ValueChanged
        If valu_Toit.Value = 0 Then
            Icon_Toit.Image = My.Resources.icon_level_na
        ElseIf valu_Toit.Value = 1 Then
            Icon_Toit.Image = My.Resources.icon_level_enable
        ElseIf valu_Toit.Value = 2 Then
            Icon_Toit.Image = My.Resources.icon_level_enable
        ElseIf valu_Toit.Value = 3 Then
            Icon_Toit.Image = My.Resources.icon_level_clear
        ElseIf valu_Toit.Value = 4 Then
            Icon_Toit.Image = My.Resources.icon_level_lock
        End If
    End Sub

    Private Sub Icon_rififiToit_Click(sender As Object, e As EventArgs) Handles Icon_rififitoit.Click
        If valu_rififiToit.Value = 4 Then
            valu_rififiToit.Value = 0
        Else
            valu_rififiToit.Value = valu_rififiToit.Value + 1
        End If
    End Sub

    Private Sub valu_rififiToit_ValueChanged(sender As Object, e As EventArgs) Handles valu_rififitoit.ValueChanged
        If valu_rififiToit.Value = 0 Then
            Icon_rififiToit.Image = My.Resources.icon_level_na
        ElseIf valu_rififiToit.Value = 1 Then
            Icon_rififiToit.Image = My.Resources.icon_level_enable
        ElseIf valu_rififiToit.Value = 2 Then
            Icon_rififiToit.Image = My.Resources.icon_level_enable
        ElseIf valu_rififiToit.Value = 3 Then
            Icon_rififiToit.Image = My.Resources.icon_level_clear
        ElseIf valu_rififiToit.Value = 4 Then
            Icon_rififiToit.Image = My.Resources.icon_level_lock
        End If
    End Sub

End Class