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
    Dim Quests1_1 = &H119C
    Dim Quests1_2 = &H11A4
    Dim Quests1_3 = &H11AC
    Dim Quests1_4 = &H11B4
    Dim Quests1_5 = &H11BC
    Dim Quests1_6 = &H11C4
    Dim Quests1_7 = &H11CC
    Dim Quests1_8 = &H11D4
    Dim Quests1_9 = &H11DC
    Dim Quests1_10 = &H11E4
    Dim Quests1_11 = &H11EC
    Dim Quests1_12 = &H11F4
    Dim Quests1_13 = &H11FC
    Dim Quests1_14 = &H1204
    Dim Quests1_15 = &H120C
    Dim Quests1_16 = &H1214
    Dim Quests1_17 = &H121C
    Dim Quests1_18 = &H1224
    Dim Quests1_19 = &H122C
    Dim Quests1_20 = &H1234
    Dim Quests2_1 = &H123C
    Dim Quests2_2 = &H1244
    Dim Quests2_3 = &H124C
    Dim Quests2_4 = &H1254
    Dim Quests2_5 = &H125C
    Dim Quests2_6 = &H1264
    Dim Quests2_7 = &H126C
    Dim Quests2_8 = &H1274
    Dim Quests2_9 = &H127C
    Dim Quests2_10 = &H1284
    Dim Quests2_11 = &H128C
    Dim Quests2_12 = &H1294
    Dim Quests2_13 = &H129C
    Dim Quests2_14 = &H12A4
    Dim Quests2_15 = &H12AC
    Dim Quests2_16 = &H12B4
    Dim Quests2_17 = &H12BC
    Dim Quests2_18 = &H12C4
    Dim Quests2_19 = &H12CC
    Dim Quests2_20 = &H12D4
    Dim TghQuest1_1 = &H12DC
    Dim TghQuest1_2 = &H12E4
    Dim TghQuest1_3 = &H12EC
    Dim TghQuest1_4 = &H12F4
    Dim TghQuest1_5 = &H12FC
    Dim TghQuest1_6 = &H1304
    Dim TghQuest1_7 = &H130C
    Dim TghQuest1_8 = &H1314
    Dim TghQuest1_9 = &H131C
    Dim TghQuest1_10 = &H1324
    Dim TghQuest1_11 = &H132C
    Dim TghQuest1_12 = &H1334
    Dim TghQuest1_13 = &H133C
    Dim TghQuest1_14 = &H1344
    Dim TghQuest1_15 = &H134C
    Dim TghQuest1_16 = &H1354
    Dim TghQuest1_17 = &H135C
    Dim TghQuest1_18 = &H1364
    Dim TghQuest1_19 = &H136C
    Dim TghQuest1_20 = &H1374
    Dim TghQuest1_21 = &H137C
    Dim TghQuest1_22 = &H1384
    Dim TghQuest1_23 = &H138C
    Dim TghQuest1_24 = &H1394
    Dim TghQuest1_25 = &H139C
    Dim TghQuest1_26 = &H13A4
    Dim TghQuest1_27 = &H13AC
    Dim TghQuest1_28 = &H13B4
    Dim TghQuest2_1 = &H13BC
    Dim TghQuest2_2 = &H13C4
    Dim TghQuest2_3 = &H13CC
    Dim TghQuest2_4 = &H13D4
    Dim TghQuest2_5 = &H13DC
    Dim TghQuest2_6 = &H13E4
    Dim TghQuest2_7 = &H13EC
    Dim TghQuest2_8 = &H13F4
    Dim TghQuest2_9 = &H13FC
    Dim TghQuest2_10 = &H1404
    Dim TghQuest2_11 = &H140C
    Dim TghQuest2_12 = &H1414
    Dim TghQuest2_13 = &H141C
    Dim TghQuest2_14 = &H1424
    Dim TghQuest2_15 = &H142C
    Dim TghQuest2_16 = &H1434
    Dim TghQuest2_17 = &H143C
    Dim TghQuest2_18 = &H1444
    Dim TghQuest2_19 = &H144C
    Dim TghQuest2_20 = &H1454
    Dim TghQuest2_21 = &H145C
    Dim TghQuest2_22 = &H1464
    Dim TghQuest2_23 = &H146C
    Dim TghQuest2_24 = &H1474
    Dim TghQuest2_25 = &H147C
    Dim TghQuest2_26 = &H1484
    Dim TghQuest2_27 = &H148C
    Dim TghQuest2_28 = &H1494
    Dim TgherQuest1_1 = &H149C
    Dim TgherQuest1_2 = &H14A4
    Dim TgherQuest1_3 = &H14AC
    Dim TgherQuest1_4 = &H14B4
    Dim TgherQuest1_5 = &H14BC
    Dim TgherQuest1_6 = &H14C4
    Dim TgherQuest1_7 = &H14CC
    Dim TgherQuest1_8 = &H14D4
    Dim TgherQuest1_9 = &H14DC
    Dim TgherQuest1_10 = &H14E4
    Dim TgherQuest1_11 = &H14EC
    Dim TgherQuest1_12 = &H14F4
    Dim TgherQuest1_13 = &H14FC
    Dim TgherQuest1_14 = &H1504
    Dim TgherQuest1_15 = &H150C
    Dim TgherQuest1_16 = &H1514
    Dim TgherQuest1_17 = &H151C
    Dim TgherQuest1_18 = &H1524
    Dim TgherQuest1_19 = &H152C
    Dim TgherQuest1_20 = &H1534
    Dim TgherQuest1_21 = &H153C
    Dim TgherQuest1_22 = &H1544
    Dim TgherQuest1_23 = &H154C
    Dim TgherQuest1_24 = &H1554
    Dim TgherQuest1_25 = &H155C
    Dim TgherQuest1_26 = &H1564
    Dim TgherQuest1_27 = &H156C
    Dim TgherQuest1_28 = &H1574
    Dim TgherQuest1_29 = &H157C
    Dim TgherQuest1_30 = &H1584
    Dim TgherQuest1_31 = &H158C
    Dim TgherQuest1_32 = &H1594
    Dim TgherQuest2_1 = &H159C
    Dim TgherQuest2_2 = &H15A4
    Dim TgherQuest2_3 = &H15AC
    Dim TgherQuest2_4 = &H15B4
    Dim TgherQuest2_5 = &H15BC
    Dim TgherQuest2_6 = &H15C4
    Dim TgherQuest2_7 = &H15CC
    Dim TgherQuest2_8 = &H15D4
    Dim TgherQuest2_9 = &H15DC
    Dim TgherQuest2_10 = &H15E4
    Dim TgherQuest2_11 = &H15EC
    Dim TgherQuest2_12 = &H15F4
    Dim TgherQuest2_13 = &H15FC
    Dim TgherQuest2_14 = &H1604
    Dim TgherQuest2_15 = &H160C
    Dim TgherQuest2_16 = &H1614
    Dim TgherQuest2_17 = &H161C
    Dim TgherQuest2_18 = &H1624
    Dim TgherQuest2_19 = &H162C
    Dim TgherQuest2_20 = &H1634
    Dim TgherQuest2_21 = &H163C
    Dim TgherQuest2_22 = &H1644
    Dim TgherQuest2_23 = &H164C
    Dim TgherQuest2_24 = &H1654
    Dim TgherQuest2_25 = &H165C
    Dim TgherQuest3_1 = &H1664
    Dim TgherQuest3_2 = &H166C
    Dim TgherQuest3_3 = &H1674
    Dim TgherQuest3_4 = &H167C
    Dim TgherQuest3_5 = &H1684
    Dim TgherQuest3_6 = &H168C
    Dim TgherQuest3_7 = &H1694
    Dim TgherQuest3_8 = &H169C
    Dim TgherQuest3_9 = &H16A4
    Dim TgherQuest3_10 = &H16AC
    Dim TgherQuest3_11 = &H16B4
    Dim TgherQuest3_12 = &H16BC
    Dim TgherQuest3_13 = &H16C4
    Dim TgherQuest3_14 = &H16CC
    Dim TgherQuest3_15 = &H16D4
    Dim TgherQuest3_16 = &H16DC
    Dim PlayLevel_1 = &H16E4
    Dim PlayLevel_2 = &H16EC
    Dim PlayLevel_3 = &H16F4
    Dim PlayLevel_4 = &H16FC
    Dim PlayLevel_5 = &H1704
    Dim PlayLevel_6 = &H170C
    Dim PlayLevel_7 = &H1714
    Dim PlayLevel_8 = &H171C
    Dim PlayLevel_9 = &H1724
    Dim PlayLevel_10 = &H172C
    Dim PlayLevel_11 = &H1734
    Dim PlayLevel_12 = &H173C
    Dim PlayLevel_13 = &H1744
    Dim PlayLevel_14 = &H174C
    Dim PlayLevel_15 = &H1754
    Dim PlayLevel_16 = &H175C
    Dim PlayLevel_17 = &H1764
    Dim PlayLevel_18 = &H176C
    Dim PlayLevel_19 = &H1774
    Dim PlayLevel_20 = &H177C
    Dim Shoppe_1 = &H1784
    Dim Shoppe_2 = &H178C
    Dim Shoppe_3 = &H1794
    Dim Shoppe_4 = &H179C
    Dim Shoppe_5 = &H17A4
    Dim Shoppe_6 = &H17AC
    Dim Shoppe_7 = &H17B4
    Dim Shoppe_8 = &H17BC
    Dim Shoppe_9 = &H17C4
    Dim Shoppe_10 = &H17CC
    Dim Shoppe_11 = &H17D4
    Dim Shoppe_12 = &H17DC
    Dim Shoppe_13 = &H17E4
    Dim Shoppe_14 = &H17EC
    Dim Shoppe_15 = &H17F4
    Dim Shoppe_16 = &H17FC
    Dim Shoppe_17 = &H1804
    Dim Shoppe_18 = &H180C
    Dim Shoppe_19 = &H1814
    Dim Shoppe_20 = &H181C
    Dim MoreMissions1_1 = &H1824
    Dim MoreMissions1_2 = &H182C
    Dim MoreMissions1_3 = &H1834
    Dim MoreMissions1_4 = &H183C
    Dim MoreMissions1_5 = &H1844
    Dim MoreMissions1_6 = &H184C
    Dim MoreMissions1_7 = &H1854
    Dim MoreMissions1_8 = &H185C
    Dim MoreMissions1_9 = &H1864
    Dim MoreMissions1_10 = &H186C
    Dim MoreMissions1_11 = &H1874
    Dim MoreMissions1_12 = &H187C
    Dim MoreMissions1_13 = &H1884
    Dim MoreMissions1_14 = &H188C
    Dim MoreMissions1_15 = &H1894
    Dim MoreMissions1_16 = &H189C
    Dim MoreMissions1_17 = &H18A4
    Dim MoreMissions1_18 = &H18AC
    Dim MoreMissions1_19 = &H18B4
    Dim MoreMissions1_20 = &H18BC
    Dim MoreMissions1_21 = &H18C4
    Dim MoreMissions1_22 = &H18CC
    Dim MoreMissions2_1 = &H18D4
    Dim MoreMissions2_2 = &H18DC
    Dim MoreMissions2_3 = &H18E4
    Dim MoreMissions2_4 = &H18EC
    Dim MoreMissions2_5 = &H18F4
    Dim MoreMissions2_6 = &H18FC
    Dim MoreMissions2_7 = &H1904
    Dim MoreMissions2_8 = &H190C
    Dim MoreMissions2_9 = &H1914
    Dim MoreMissions2_10 = &H191C
    Dim MoreMissions2_11 = &H1924
    Dim MoreMissions2_12 = &H192C
    Dim MoreMissions2_13 = &H1934
    Dim MoreMissions2_14 = &H193C
    Dim MoreMissions2_15 = &H1944
    Dim MoreMissions2_16 = &H194C
    Dim MoreMissions2_17 = &H1954
    Dim MoreMissions2_18 = &H195C
    Dim MoreMissions2_19 = &H1964
    Dim MoreMissions2_20 = &H196C
    Dim MoreMissions2_21 = &H1974
    Dim MoreMissions2_22 = &H197C
    Dim MoreMissions2_23 = &H1984
    Dim MoreMissions2_24 = &H198C
    Dim MoreMissions2_25 = &H1994

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

    Public Sub hidepages()
        Panel_page_1.Visible = False
        Panel_page_3.Visible = False
        Panel_page_5.Visible = False
        Panel_page_7.Visible = False
        Panel_page_9.Visible = False
        Panel_page_11.Visible = False
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
            Reader.Position = Quests1_1
            valu_quests1_1.Value = Reader.ReadUInt32
            Reader.Position = Quests1_2
            valu_quests1_2.Value = Reader.ReadUInt32
            Reader.Position = Quests1_3
            valu_quests1_3.Value = Reader.ReadUInt32
            Reader.Position = Quests1_4
            valu_quests1_4.Value = Reader.ReadUInt32
            Reader.Position = Quests1_5
            valu_quests1_5.Value = Reader.ReadUInt32
            Reader.Position = Quests1_6
            valu_quests1_6.Value = Reader.ReadUInt32
            Reader.Position = Quests1_7
            valu_quests1_7.Value = Reader.ReadUInt32
            Reader.Position = Quests1_8
            valu_quests1_8.Value = Reader.ReadUInt32
            Reader.Position = Quests1_9
            valu_quests1_9.Value = Reader.ReadUInt32
            Reader.Position = Quests1_10
            valu_quests1_10.Value = Reader.ReadUInt32
            Reader.Position = Quests1_11
            valu_quests1_11.Value = Reader.ReadUInt32
            Reader.Position = Quests1_12
            valu_quests1_12.Value = Reader.ReadUInt32
            Reader.Position = Quests1_13
            valu_quests1_13.Value = Reader.ReadUInt32
            Reader.Position = Quests1_14
            valu_quests1_14.Value = Reader.ReadUInt32
            Reader.Position = Quests1_15
            valu_quests1_15.Value = Reader.ReadUInt32
            Reader.Position = Quests1_16
            valu_quests1_16.Value = Reader.ReadUInt32
            Reader.Position = Quests1_17
            valu_quests1_17.Value = Reader.ReadUInt32
            Reader.Position = Quests1_18
            valu_quests1_18.Value = Reader.ReadUInt32
            Reader.Position = Quests1_19
            valu_quests1_19.Value = Reader.ReadUInt32
            Reader.Position = Quests1_20
            valu_quests1_20.Value = Reader.ReadUInt32
            Reader.Position = Quests2_1
            valu_quests2_1.Value = Reader.ReadUInt32
            Reader.Position = Quests2_2
            valu_quests2_2.Value = Reader.ReadUInt32
            Reader.Position = Quests2_3
            valu_quests2_3.Value = Reader.ReadUInt32
            Reader.Position = Quests2_4
            valu_quests2_4.Value = Reader.ReadUInt32
            Reader.Position = Quests2_5
            valu_quests2_5.Value = Reader.ReadUInt32
            Reader.Position = Quests2_6
            valu_quests2_6.Value = Reader.ReadUInt32
            Reader.Position = Quests2_7
            valu_quests2_7.Value = Reader.ReadUInt32
            Reader.Position = Quests2_8
            valu_quests2_8.Value = Reader.ReadUInt32
            Reader.Position = Quests2_9
            valu_quests2_9.Value = Reader.ReadUInt32
            Reader.Position = Quests2_10
            valu_quests2_10.Value = Reader.ReadUInt32
            Reader.Position = Quests2_11
            valu_quests2_11.Value = Reader.ReadUInt32
            Reader.Position = Quests2_12
            valu_quests2_12.Value = Reader.ReadUInt32
            Reader.Position = Quests2_13
            valu_quests2_13.Value = Reader.ReadUInt32
            Reader.Position = Quests2_14
            valu_quests2_14.Value = Reader.ReadUInt32
            Reader.Position = Quests2_15
            valu_quests2_15.Value = Reader.ReadUInt32
            Reader.Position = Quests2_16
            valu_quests2_16.Value = Reader.ReadUInt32
            Reader.Position = Quests2_17
            valu_quests2_17.Value = Reader.ReadUInt32
            Reader.Position = Quests2_18
            valu_quests2_18.Value = Reader.ReadUInt32
            Reader.Position = Quests2_19
            valu_quests2_19.Value = Reader.ReadUInt32
            Reader.Position = Quests2_20
            valu_quests2_20.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_1
            valu_tghquest1_1.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_2
            valu_tghquest1_2.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_3
            valu_tghquest1_3.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_4
            valu_tghquest1_4.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_5
            valu_tghquest1_5.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_6
            valu_tghquest1_6.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_7
            valu_tghquest1_7.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_8
            valu_tghquest1_8.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_9
            valu_tghquest1_9.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_10
            valu_tghquest1_10.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_11
            valu_tghquest1_11.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_12
            valu_tghquest1_12.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_13
            valu_tghquest1_13.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_14
            valu_tghquest1_14.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_15
            valu_tghquest1_15.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_16
            valu_tghquest1_16.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_17
            valu_tghquest1_17.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_18
            valu_tghquest1_18.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_19
            valu_tghquest1_19.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_20
            valu_tghquest1_20.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_21
            valu_tghquest1_21.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_22
            valu_tghquest1_22.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_23
            valu_tghquest1_23.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_24
            valu_tghquest1_24.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_25
            valu_tghquest1_25.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_26
            valu_tghquest1_26.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_27
            valu_tghquest1_27.Value = Reader.ReadUInt32
            Reader.Position = TghQuest1_28
            valu_tghquest1_28.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_1
            valu_tghquest2_1.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_2
            valu_tghquest2_2.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_3
            valu_tghquest2_3.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_4
            valu_tghquest2_4.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_5
            valu_tghquest2_5.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_6
            valu_tghquest2_6.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_7
            valu_tghquest2_7.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_8
            valu_tghquest2_8.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_9
            valu_tghquest2_9.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_10
            valu_tghquest2_10.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_11
            valu_tghquest2_11.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_12
            valu_tghquest2_12.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_13
            valu_tghquest2_13.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_14
            valu_tghquest2_14.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_15
            valu_tghquest2_15.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_16
            valu_tghquest2_16.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_17
            valu_tghquest2_17.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_18
            valu_tghquest2_18.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_19
            valu_tghquest2_19.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_20
            valu_tghquest2_20.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_21
            valu_tghquest2_21.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_22
            valu_tghquest2_22.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_23
            valu_tghquest2_23.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_24
            valu_tghquest2_24.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_25
            valu_tghquest2_25.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_26
            valu_tghquest2_26.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_27
            valu_tghquest2_27.Value = Reader.ReadUInt32
            Reader.Position = TghQuest2_28
            valu_tghquest2_28.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_1
            valu_tgherquest1_1.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_2
            valu_tgherquest1_2.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_3
            valu_tgherquest1_3.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_4
            valu_tgherquest1_4.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_5
            valu_tgherquest1_5.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_6
            valu_tgherquest1_6.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_7
            valu_tgherquest1_7.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_8
            valu_tgherquest1_8.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_9
            valu_tgherquest1_9.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_10
            valu_tgherquest1_10.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_11
            valu_tgherquest1_11.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_12
            valu_tgherquest1_12.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_13
            valu_tgherquest1_13.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_14
            valu_tgherquest1_14.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_15
            valu_tgherquest1_15.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_16
            valu_tgherquest1_16.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_17
            valu_tgherquest1_17.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_18
            valu_tgherquest1_18.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_19
            valu_tgherquest1_19.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_20
            valu_tgherquest1_20.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_21
            valu_tgherquest1_21.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_22
            valu_tgherquest1_22.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_23
            valu_tgherquest1_23.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_24
            valu_tgherquest1_24.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_25
            valu_tgherquest1_25.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_26
            valu_tgherquest1_26.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_27
            valu_tgherquest1_27.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_28
            valu_tgherquest1_28.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_29
            valu_tgherquest1_29.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_30
            valu_tgherquest1_30.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_31
            valu_tgherquest1_31.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest1_32
            valu_tgherquest1_32.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_1
            valu_tgherquest2_1.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_2
            valu_tgherquest2_2.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_3
            valu_tgherquest2_3.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_4
            valu_tgherquest2_4.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_5
            valu_tgherquest2_5.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_6
            valu_tgherquest2_6.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_7
            valu_tgherquest2_7.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_8
            valu_tgherquest2_8.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_9
            valu_tgherquest2_9.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_10
            valu_tgherquest2_10.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_11
            valu_tgherquest2_11.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_12
            valu_tgherquest2_12.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_13
            valu_tgherquest2_13.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_14
            valu_tgherquest2_14.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_15
            valu_tgherquest2_15.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_16
            valu_tgherquest2_16.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_17
            valu_tgherquest2_17.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_18
            valu_tgherquest2_18.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_19
            valu_tgherquest2_19.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_20
            valu_tgherquest2_20.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_21
            valu_tgherquest2_21.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_22
            valu_tgherquest2_22.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_23
            valu_tgherquest2_23.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_24
            valu_tgherquest2_24.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest2_25
            valu_tgherquest2_25.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_1
            valu_tgherquest3_1.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_2
            valu_tgherquest3_2.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_3
            valu_tgherquest3_3.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_4
            valu_tgherquest3_4.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_5
            valu_tgherquest3_5.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_6
            valu_tgherquest3_6.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_7
            valu_tgherquest3_7.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_8
            valu_tgherquest3_8.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_9
            valu_tgherquest3_9.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_10
            valu_tgherquest3_10.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_11
            valu_tgherquest3_11.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_12
            valu_tgherquest3_12.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_13
            valu_tgherquest3_13.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_14
            valu_tgherquest3_14.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_15
            valu_tgherquest3_15.Value = Reader.ReadUInt32
            Reader.Position = TgherQuest3_16
            valu_tgherquest3_16.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_1
            valu_playlevel_1.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_2
            valu_playlevel_2.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_3
            valu_playlevel_3.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_4
            valu_playlevel_4.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_5
            valu_playlevel_5.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_6
            valu_playlevel_6.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_7
            valu_playlevel_7.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_8
            valu_playlevel_8.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_9
            valu_playlevel_9.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_10
            valu_playlevel_10.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_11
            valu_playlevel_11.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_12
            valu_playlevel_12.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_13
            valu_playlevel_13.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_14
            valu_playlevel_14.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_15
            valu_playlevel_15.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_16
            valu_playlevel_16.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_17
            valu_playlevel_17.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_18
            valu_playlevel_18.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_19
            valu_playlevel_19.Value = Reader.ReadUInt32
            Reader.Position = PlayLevel_20
            valu_playlevel_20.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_1
            valu_shoppe_1.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_2
            valu_shoppe_2.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_3
            valu_shoppe_3.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_4
            valu_shoppe_4.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_5
            valu_shoppe_5.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_6
            valu_shoppe_6.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_7
            valu_shoppe_7.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_8
            valu_shoppe_8.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_9
            valu_shoppe_9.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_10
            valu_shoppe_10.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_11
            valu_shoppe_11.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_12
            valu_shoppe_12.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_13
            valu_shoppe_13.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_14
            valu_shoppe_14.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_15
            valu_shoppe_15.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_16
            valu_shoppe_16.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_17
            valu_shoppe_17.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_18
            valu_shoppe_18.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_19
            valu_shoppe_19.Value = Reader.ReadUInt32
            Reader.Position = Shoppe_20
            valu_shoppe_20.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_1
            valu_moremissions1_1.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_2
            valu_moremissions1_2.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_3
            valu_moremissions1_3.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_4
            valu_moremissions1_4.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_5
            valu_moremissions1_5.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_6
            valu_moremissions1_6.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_7
            valu_moremissions1_7.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_8
            valu_moremissions1_8.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_9
            valu_moremissions1_9.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_10
            valu_moremissions1_10.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_11
            valu_moremissions1_11.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_12
            valu_moremissions1_12.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_13
            valu_moremissions1_13.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_14
            valu_moremissions1_14.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_15
            valu_moremissions1_15.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_16
            valu_moremissions1_16.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_17
            valu_moremissions1_17.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_18
            valu_moremissions1_18.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_19
            valu_moremissions1_19.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_20
            valu_moremissions1_20.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_21
            valu_moremissions1_21.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions1_22
            valu_moremissions1_22.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_1
            valu_moremissions2_1.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_2
            valu_moremissions2_2.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_3
            valu_moremissions2_3.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_4
            valu_moremissions2_4.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_5
            valu_moremissions2_5.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_6
            valu_moremissions2_6.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_7
            valu_moremissions2_7.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_8
            valu_moremissions2_8.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_9
            valu_moremissions2_9.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_10
            valu_moremissions2_10.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_11
            valu_moremissions2_11.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_12
            valu_moremissions2_12.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_13
            valu_moremissions2_13.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_14
            valu_moremissions2_14.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_15
            valu_moremissions2_15.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_16
            valu_moremissions2_16.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_17
            valu_moremissions2_17.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_18
            valu_moremissions2_18.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_19
            valu_moremissions2_19.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_20
            valu_moremissions2_20.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_21
            valu_moremissions2_21.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_22
            valu_moremissions2_22.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_23
            valu_moremissions2_23.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_24
            valu_moremissions2_24.Value = Reader.ReadUInt32
            Reader.Position = MoreMissions2_25
            valu_moremissions2_25.Value = Reader.ReadUInt32
            Text_menu_save.Visible = True
        Catch ex As Exception
            fdialog.Description.Text = "Failed to read your Team Kirby Clash Deluxe save file, make sure you have opened a good savedata.dat file or report this issue"
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
            Writer.Position = Quests1_1
            Writer.WriteUInt32(valu_quests1_1.Value)
            Writer.Position = Quests1_2
            Writer.WriteUInt32(valu_quests1_2.Value)
            Writer.Position = Quests1_3
            Writer.WriteUInt32(valu_quests1_3.Value)
            Writer.Position = Quests1_4
            Writer.WriteUInt32(valu_quests1_4.Value)
            Writer.Position = Quests1_5
            Writer.WriteUInt32(valu_quests1_5.Value)
            Writer.Position = Quests1_6
            Writer.WriteUInt32(valu_quests1_6.Value)
            Writer.Position = Quests1_7
            Writer.WriteUInt32(valu_quests1_7.Value)
            Writer.Position = Quests1_8
            Writer.WriteUInt32(valu_quests1_8.Value)
            Writer.Position = Quests1_9
            Writer.WriteUInt32(valu_quests1_9.Value)
            Writer.Position = Quests1_10
            Writer.WriteUInt32(valu_quests1_10.Value)
            Writer.Position = Quests1_11
            Writer.WriteUInt32(valu_quests1_11.Value)
            Writer.Position = Quests1_12
            Writer.WriteUInt32(valu_quests1_12.Value)
            Writer.Position = Quests1_13
            Writer.WriteUInt32(valu_quests1_13.Value)
            Writer.Position = Quests1_14
            Writer.WriteUInt32(valu_quests1_14.Value)
            Writer.Position = Quests1_15
            Writer.WriteUInt32(valu_quests1_15.Value)
            Writer.Position = Quests1_16
            Writer.WriteUInt32(valu_quests1_16.Value)
            Writer.Position = Quests1_17
            Writer.WriteUInt32(valu_quests1_17.Value)
            Writer.Position = Quests1_18
            Writer.WriteUInt32(valu_quests1_18.Value)
            Writer.Position = Quests1_19
            Writer.WriteUInt32(valu_quests1_19.Value)
            Writer.Position = Quests1_20
            Writer.WriteUInt32(valu_quests1_20.Value)
            Writer.Position = Quests1_1
            Writer.WriteUInt32(valu_quests1_1.Value)
            Writer.Position = Quests2_2
            Writer.WriteUInt32(valu_quests2_2.Value)
            Writer.Position = Quests2_3
            Writer.WriteUInt32(valu_quests2_3.Value)
            Writer.Position = Quests2_4
            Writer.WriteUInt32(valu_quests2_4.Value)
            Writer.Position = Quests2_5
            Writer.WriteUInt32(valu_quests2_5.Value)
            Writer.Position = Quests2_6
            Writer.WriteUInt32(valu_quests2_6.Value)
            Writer.Position = Quests2_7
            Writer.WriteUInt32(valu_quests2_7.Value)
            Writer.Position = Quests2_8
            Writer.WriteUInt32(valu_quests2_8.Value)
            Writer.Position = Quests2_9
            Writer.WriteUInt32(valu_quests2_9.Value)
            Writer.Position = Quests2_10
            Writer.WriteUInt32(valu_quests2_10.Value)
            Writer.Position = Quests2_11
            Writer.WriteUInt32(valu_quests2_11.Value)
            Writer.Position = Quests2_12
            Writer.WriteUInt32(valu_quests2_12.Value)
            Writer.Position = Quests2_13
            Writer.WriteUInt32(valu_quests2_13.Value)
            Writer.Position = Quests2_14
            Writer.WriteUInt32(valu_quests2_14.Value)
            Writer.Position = Quests2_15
            Writer.WriteUInt32(valu_quests2_15.Value)
            Writer.Position = Quests2_16
            Writer.WriteUInt32(valu_quests2_16.Value)
            Writer.Position = Quests2_17
            Writer.WriteUInt32(valu_quests2_17.Value)
            Writer.Position = Quests2_18
            Writer.WriteUInt32(valu_quests2_18.Value)
            Writer.Position = Quests2_19
            Writer.WriteUInt32(valu_quests2_19.Value)
            Writer.Position = Quests2_20
            Writer.WriteUInt32(valu_quests2_20.Value)
            Writer.Position = TghQuest1_1
            Writer.WriteUInt32(valu_tghquest1_1.Value)
            Writer.Position = TghQuest1_2
            Writer.WriteUInt32(valu_tghquest1_2.Value)
            Writer.Position = TghQuest1_3
            Writer.WriteUInt32(valu_tghquest1_3.Value)
            Writer.Position = TghQuest1_4
            Writer.WriteUInt32(valu_tghquest1_4.Value)
            Writer.Position = TghQuest1_5
            Writer.WriteUInt32(valu_tghquest1_5.Value)
            Writer.Position = TghQuest1_6
            Writer.WriteUInt32(valu_tghquest1_6.Value)
            Writer.Position = TghQuest1_7
            Writer.WriteUInt32(valu_tghquest1_7.Value)
            Writer.Position = TghQuest1_8
            Writer.WriteUInt32(valu_tghquest1_8.Value)
            Writer.Position = TghQuest1_9
            Writer.WriteUInt32(valu_tghquest1_9.Value)
            Writer.Position = TghQuest1_10
            Writer.WriteUInt32(valu_tghquest1_10.Value)
            Writer.Position = TghQuest1_11
            Writer.WriteUInt32(valu_tghquest1_11.Value)
            Writer.Position = TghQuest1_12
            Writer.WriteUInt32(valu_tghquest1_12.Value)
            Writer.Position = TghQuest1_13
            Writer.WriteUInt32(valu_tghquest1_13.Value)
            Writer.Position = TghQuest1_14
            Writer.WriteUInt32(valu_tghquest1_14.Value)
            Writer.Position = TghQuest1_15
            Writer.WriteUInt32(valu_tghquest1_15.Value)
            Writer.Position = TghQuest1_16
            Writer.WriteUInt32(valu_tghquest1_16.Value)
            Writer.Position = TghQuest1_17
            Writer.WriteUInt32(valu_tghquest1_17.Value)
            Writer.Position = TghQuest1_18
            Writer.WriteUInt32(valu_tghquest1_18.Value)
            Writer.Position = TghQuest1_19
            Writer.WriteUInt32(valu_tghquest1_19.Value)
            Writer.Position = TghQuest1_20
            Writer.WriteUInt32(valu_tghquest1_20.Value)
            Writer.Position = TghQuest1_21
            Writer.WriteUInt32(valu_tghquest1_21.Value)
            Writer.Position = TghQuest1_22
            Writer.WriteUInt32(valu_tghquest1_22.Value)
            Writer.Position = TghQuest1_23
            Writer.WriteUInt32(valu_tghquest1_23.Value)
            Writer.Position = TghQuest1_24
            Writer.WriteUInt32(valu_tghquest1_24.Value)
            Writer.Position = TghQuest1_25
            Writer.WriteUInt32(valu_tghquest1_25.Value)
            Writer.Position = TghQuest1_26
            Writer.WriteUInt32(valu_tghquest1_26.Value)
            Writer.Position = TghQuest1_27
            Writer.WriteUInt32(valu_tghquest1_27.Value)
            Writer.Position = TghQuest1_28
            Writer.WriteUInt32(valu_tghquest1_28.Value)
            Writer.Position = TghQuest2_1
            Writer.WriteUInt32(valu_tghquest2_1.Value)
            Writer.Position = TghQuest2_2
            Writer.WriteUInt32(valu_tghquest2_2.Value)
            Writer.Position = TghQuest2_3
            Writer.WriteUInt32(valu_tghquest2_3.Value)
            Writer.Position = TghQuest2_4
            Writer.WriteUInt32(valu_tghquest2_4.Value)
            Writer.Position = TghQuest2_5
            Writer.WriteUInt32(valu_tghquest2_5.Value)
            Writer.Position = TghQuest2_6
            Writer.WriteUInt32(valu_tghquest2_6.Value)
            Writer.Position = TghQuest2_7
            Writer.WriteUInt32(valu_tghquest2_7.Value)
            Writer.Position = TghQuest2_8
            Writer.WriteUInt32(valu_tghquest2_8.Value)
            Writer.Position = TghQuest2_9
            Writer.WriteUInt32(valu_tghquest2_9.Value)
            Writer.Position = TghQuest2_10
            Writer.WriteUInt32(valu_tghquest2_10.Value)
            Writer.Position = TghQuest2_11
            Writer.WriteUInt32(valu_tghquest2_11.Value)
            Writer.Position = TghQuest2_12
            Writer.WriteUInt32(valu_tghquest2_12.Value)
            Writer.Position = TghQuest2_13
            Writer.WriteUInt32(valu_tghquest2_13.Value)
            Writer.Position = TghQuest2_14
            Writer.WriteUInt32(valu_tghquest2_14.Value)
            Writer.Position = TghQuest2_15
            Writer.WriteUInt32(valu_tghquest2_15.Value)
            Writer.Position = TghQuest2_16
            Writer.WriteUInt32(valu_tghquest2_16.Value)
            Writer.Position = TghQuest2_17
            Writer.WriteUInt32(valu_tghquest2_17.Value)
            Writer.Position = TghQuest2_18
            Writer.WriteUInt32(valu_tghquest2_18.Value)
            Writer.Position = TghQuest2_19
            Writer.WriteUInt32(valu_tghquest2_19.Value)
            Writer.Position = TghQuest2_20
            Writer.WriteUInt32(valu_tghquest2_20.Value)
            Writer.Position = TghQuest2_21
            Writer.WriteUInt32(valu_tghquest2_21.Value)
            Writer.Position = TghQuest2_22
            Writer.WriteUInt32(valu_tghquest2_22.Value)
            Writer.Position = TghQuest2_23
            Writer.WriteUInt32(valu_tghquest2_23.Value)
            Writer.Position = TghQuest2_24
            Writer.WriteUInt32(valu_tghquest2_24.Value)
            Writer.Position = TghQuest2_25
            Writer.WriteUInt32(valu_tghquest2_25.Value)
            Writer.Position = TghQuest2_26
            Writer.WriteUInt32(valu_tghquest2_26.Value)
            Writer.Position = TghQuest2_27
            Writer.WriteUInt32(valu_tghquest2_27.Value)
            Writer.Position = TghQuest2_28
            Writer.WriteUInt32(valu_tghquest2_28.Value)
            Writer.Position = TgherQuest1_1
            Writer.WriteUInt32(valu_tgherquest1_1.Value)
            Writer.Position = TgherQuest1_2
            Writer.WriteUInt32(valu_tgherquest1_2.Value)
            Writer.Position = TgherQuest1_3
            Writer.WriteUInt32(valu_tgherquest1_3.Value)
            Writer.Position = TgherQuest1_4
            Writer.WriteUInt32(valu_tgherquest1_4.Value)
            Writer.Position = TgherQuest1_5
            Writer.WriteUInt32(valu_tgherquest1_5.Value)
            Writer.Position = TgherQuest1_6
            Writer.WriteUInt32(valu_tgherquest1_6.Value)
            Writer.Position = TgherQuest1_7
            Writer.WriteUInt32(valu_tgherquest1_7.Value)
            Writer.Position = TgherQuest1_8
            Writer.WriteUInt32(valu_tgherquest1_8.Value)
            Writer.Position = TgherQuest1_9
            Writer.WriteUInt32(valu_tgherquest1_9.Value)
            Writer.Position = TgherQuest1_10
            Writer.WriteUInt32(valu_tgherquest1_10.Value)
            Writer.Position = TgherQuest1_11
            Writer.WriteUInt32(valu_tgherquest1_11.Value)
            Writer.Position = TgherQuest1_12
            Writer.WriteUInt32(valu_tgherquest1_12.Value)
            Writer.Position = TgherQuest1_13
            Writer.WriteUInt32(valu_tgherquest1_13.Value)
            Writer.Position = TgherQuest1_14
            Writer.WriteUInt32(valu_tgherquest1_14.Value)
            Writer.Position = TgherQuest1_15
            Writer.WriteUInt32(valu_tgherquest1_15.Value)
            Writer.Position = TgherQuest1_16
            Writer.WriteUInt32(valu_tgherquest1_16.Value)
            Writer.Position = TgherQuest1_17
            Writer.WriteUInt32(valu_tgherquest1_17.Value)
            Writer.Position = TgherQuest1_18
            Writer.WriteUInt32(valu_tgherquest1_18.Value)
            Writer.Position = TgherQuest1_19
            Writer.WriteUInt32(valu_tgherquest1_19.Value)
            Writer.Position = TgherQuest1_20
            Writer.WriteUInt32(valu_tgherquest1_20.Value)
            Writer.Position = TgherQuest1_21
            Writer.WriteUInt32(valu_tgherquest1_21.Value)
            Writer.Position = TgherQuest1_22
            Writer.WriteUInt32(valu_tgherquest1_22.Value)
            Writer.Position = TgherQuest1_23
            Writer.WriteUInt32(valu_tgherquest1_23.Value)
            Writer.Position = TgherQuest1_24
            Writer.WriteUInt32(valu_tgherquest1_24.Value)
            Writer.Position = TgherQuest1_25
            Writer.WriteUInt32(valu_tgherquest1_25.Value)
            Writer.Position = TgherQuest1_26
            Writer.WriteUInt32(valu_tgherquest1_26.Value)
            Writer.Position = TgherQuest1_27
            Writer.WriteUInt32(valu_tgherquest1_27.Value)
            Writer.Position = TgherQuest1_28
            Writer.WriteUInt32(valu_tgherquest1_28.Value)
            Writer.Position = TgherQuest1_29
            Writer.WriteUInt32(valu_tgherquest1_29.Value)
            Writer.Position = TgherQuest1_30
            Writer.WriteUInt32(valu_tgherquest1_30.Value)
            Writer.Position = TgherQuest1_31
            Writer.WriteUInt32(valu_tgherquest1_31.Value)
            Writer.Position = TgherQuest1_32
            Writer.WriteUInt32(valu_tgherquest1_32.Value)
            Writer.Position = TgherQuest2_1
            Writer.WriteUInt32(valu_tgherquest2_1.Value)
            Writer.Position = TgherQuest2_2
            Writer.WriteUInt32(valu_tgherquest2_2.Value)
            Writer.Position = TgherQuest2_3
            Writer.WriteUInt32(valu_tgherquest2_3.Value)
            Writer.Position = TgherQuest2_4
            Writer.WriteUInt32(valu_tgherquest2_4.Value)
            Writer.Position = TgherQuest2_5
            Writer.WriteUInt32(valu_tgherquest2_5.Value)
            Writer.Position = TgherQuest2_6
            Writer.WriteUInt32(valu_tgherquest2_6.Value)
            Writer.Position = TgherQuest2_7
            Writer.WriteUInt32(valu_tgherquest2_7.Value)
            Writer.Position = TgherQuest2_8
            Writer.WriteUInt32(valu_tgherquest2_8.Value)
            Writer.Position = TgherQuest2_9
            Writer.WriteUInt32(valu_tgherquest2_9.Value)
            Writer.Position = TgherQuest2_10
            Writer.WriteUInt32(valu_tgherquest2_10.Value)
            Writer.Position = TgherQuest2_11
            Writer.WriteUInt32(valu_tgherquest2_11.Value)
            Writer.Position = TgherQuest2_12
            Writer.WriteUInt32(valu_tgherquest2_12.Value)
            Writer.Position = TgherQuest2_13
            Writer.WriteUInt32(valu_tgherquest2_13.Value)
            Writer.Position = TgherQuest2_14
            Writer.WriteUInt32(valu_tgherquest2_14.Value)
            Writer.Position = TgherQuest2_15
            Writer.WriteUInt32(valu_tgherquest2_15.Value)
            Writer.Position = TgherQuest2_16
            Writer.WriteUInt32(valu_tgherquest2_16.Value)
            Writer.Position = TgherQuest2_17
            Writer.WriteUInt32(valu_tgherquest2_17.Value)
            Writer.Position = TgherQuest2_18
            Writer.WriteUInt32(valu_tgherquest2_18.Value)
            Writer.Position = TgherQuest2_19
            Writer.WriteUInt32(valu_tgherquest2_19.Value)
            Writer.Position = TgherQuest2_20
            Writer.WriteUInt32(valu_tgherquest2_20.Value)
            Writer.Position = TgherQuest2_21
            Writer.WriteUInt32(valu_tgherquest2_21.Value)
            Writer.Position = TgherQuest2_22
            Writer.WriteUInt32(valu_tgherquest2_22.Value)
            Writer.Position = TgherQuest2_23
            Writer.WriteUInt32(valu_tgherquest2_23.Value)
            Writer.Position = TgherQuest2_24
            Writer.WriteUInt32(valu_tgherquest2_24.Value)
            Writer.Position = TgherQuest2_25
            Writer.WriteUInt32(valu_tgherquest2_25.Value)
            Writer.Position = TgherQuest3_1
            Writer.WriteUInt32(valu_tgherquest3_1.Value)
            Writer.Position = TgherQuest3_2
            Writer.WriteUInt32(valu_tgherquest3_2.Value)
            Writer.Position = TgherQuest3_3
            Writer.WriteUInt32(valu_tgherquest3_3.Value)
            Writer.Position = TgherQuest3_4
            Writer.WriteUInt32(valu_tgherquest3_4.Value)
            Writer.Position = TgherQuest3_5
            Writer.WriteUInt32(valu_tgherquest3_5.Value)
            Writer.Position = TgherQuest3_6
            Writer.WriteUInt32(valu_tgherquest3_6.Value)
            Writer.Position = TgherQuest3_7
            Writer.WriteUInt32(valu_tgherquest3_7.Value)
            Writer.Position = TgherQuest3_8
            Writer.WriteUInt32(valu_tgherquest3_8.Value)
            Writer.Position = TgherQuest3_9
            Writer.WriteUInt32(valu_tgherquest3_9.Value)
            Writer.Position = TgherQuest3_10
            Writer.WriteUInt32(valu_tgherquest3_10.Value)
            Writer.Position = TgherQuest3_11
            Writer.WriteUInt32(valu_tgherquest3_11.Value)
            Writer.Position = TgherQuest3_12
            Writer.WriteUInt32(valu_tgherquest3_12.Value)
            Writer.Position = TgherQuest3_13
            Writer.WriteUInt32(valu_tgherquest3_13.Value)
            Writer.Position = TgherQuest3_14
            Writer.WriteUInt32(valu_tgherquest3_14.Value)
            Writer.Position = TgherQuest3_15
            Writer.WriteUInt32(valu_tgherquest3_15.Value)
            Writer.Position = TgherQuest3_16
            Writer.WriteUInt32(valu_tgherquest3_16.Value)
            Writer.Position = PlayLevel_1
            Writer.WriteUInt32(valu_playlevel_1.Value)
            Writer.Position = PlayLevel_2
            Writer.WriteUInt32(valu_playlevel_2.Value)
            Writer.Position = PlayLevel_3
            Writer.WriteUInt32(valu_playlevel_3.Value)
            Writer.Position = PlayLevel_4
            Writer.WriteUInt32(valu_playlevel_4.Value)
            Writer.Position = PlayLevel_5
            Writer.WriteUInt32(valu_playlevel_5.Value)
            Writer.Position = PlayLevel_6
            Writer.WriteUInt32(valu_playlevel_6.Value)
            Writer.Position = PlayLevel_7
            Writer.WriteUInt32(valu_playlevel_7.Value)
            Writer.Position = PlayLevel_8
            Writer.WriteUInt32(valu_playlevel_8.Value)
            Writer.Position = PlayLevel_9
            Writer.WriteUInt32(valu_playlevel_9.Value)
            Writer.Position = PlayLevel_10
            Writer.WriteUInt32(valu_playlevel_10.Value)
            Writer.Position = PlayLevel_11
            Writer.WriteUInt32(valu_playlevel_11.Value)
            Writer.Position = PlayLevel_12
            Writer.WriteUInt32(valu_playlevel_12.Value)
            Writer.Position = PlayLevel_13
            Writer.WriteUInt32(valu_playlevel_13.Value)
            Writer.Position = PlayLevel_14
            Writer.WriteUInt32(valu_playlevel_14.Value)
            Writer.Position = PlayLevel_15
            Writer.WriteUInt32(valu_playlevel_15.Value)
            Writer.Position = PlayLevel_16
            Writer.WriteUInt32(valu_playlevel_16.Value)
            Writer.Position = PlayLevel_17
            Writer.WriteUInt32(valu_playlevel_17.Value)
            Writer.Position = PlayLevel_18
            Writer.WriteUInt32(valu_playlevel_18.Value)
            Writer.Position = PlayLevel_19
            Writer.WriteUInt32(valu_playlevel_19.Value)
            Writer.Position = PlayLevel_20
            Writer.WriteUInt32(valu_playlevel_20.Value)
            Writer.Position = Shoppe_1
            Writer.WriteUInt32(valu_shoppe_1.Value)
            Writer.Position = Shoppe_2
            Writer.WriteUInt32(valu_shoppe_2.Value)
            Writer.Position = Shoppe_3
            Writer.WriteUInt32(valu_shoppe_3.Value)
            Writer.Position = Shoppe_4
            Writer.WriteUInt32(valu_shoppe_4.Value)
            Writer.Position = Shoppe_5
            Writer.WriteUInt32(valu_shoppe_5.Value)
            Writer.Position = Shoppe_6
            Writer.WriteUInt32(valu_shoppe_6.Value)
            Writer.Position = Shoppe_7
            Writer.WriteUInt32(valu_shoppe_7.Value)
            Writer.Position = Shoppe_8
            Writer.WriteUInt32(valu_shoppe_8.Value)
            Writer.Position = Shoppe_9
            Writer.WriteUInt32(valu_shoppe_9.Value)
            Writer.Position = Shoppe_10
            Writer.WriteUInt32(valu_shoppe_10.Value)
            Writer.Position = Shoppe_11
            Writer.WriteUInt32(valu_shoppe_11.Value)
            Writer.Position = Shoppe_12
            Writer.WriteUInt32(valu_shoppe_12.Value)
            Writer.Position = Shoppe_13
            Writer.WriteUInt32(valu_shoppe_13.Value)
            Writer.Position = Shoppe_14
            Writer.WriteUInt32(valu_shoppe_14.Value)
            Writer.Position = Shoppe_15
            Writer.WriteUInt32(valu_shoppe_15.Value)
            Writer.Position = Shoppe_16
            Writer.WriteUInt32(valu_shoppe_16.Value)
            Writer.Position = Shoppe_17
            Writer.WriteUInt32(valu_shoppe_17.Value)
            Writer.Position = Shoppe_18
            Writer.WriteUInt32(valu_shoppe_18.Value)
            Writer.Position = Shoppe_19
            Writer.WriteUInt32(valu_shoppe_19.Value)
            Writer.Position = Shoppe_20
            Writer.WriteUInt32(valu_shoppe_20.Value)
            Writer.Position = MoreMissions1_1
            Writer.WriteUInt32(valu_moremissions1_1.Value)
            Writer.Position = MoreMissions1_2
            Writer.WriteUInt32(valu_moremissions1_2.Value)
            Writer.Position = MoreMissions1_3
            Writer.WriteUInt32(valu_moremissions1_3.Value)
            Writer.Position = MoreMissions1_4
            Writer.WriteUInt32(valu_moremissions1_4.Value)
            Writer.Position = MoreMissions1_5
            Writer.WriteUInt32(valu_moremissions1_5.Value)
            Writer.Position = MoreMissions1_6
            Writer.WriteUInt32(valu_moremissions1_6.Value)
            Writer.Position = MoreMissions1_7
            Writer.WriteUInt32(valu_moremissions1_7.Value)
            Writer.Position = MoreMissions1_8
            Writer.WriteUInt32(valu_moremissions1_8.Value)
            Writer.Position = MoreMissions1_9
            Writer.WriteUInt32(valu_moremissions1_9.Value)
            Writer.Position = MoreMissions1_10
            Writer.WriteUInt32(valu_moremissions1_10.Value)
            Writer.Position = MoreMissions1_11
            Writer.WriteUInt32(valu_moremissions1_11.Value)
            Writer.Position = MoreMissions1_12
            Writer.WriteUInt32(valu_moremissions1_12.Value)
            Writer.Position = MoreMissions1_13
            Writer.WriteUInt32(valu_moremissions1_13.Value)
            Writer.Position = MoreMissions1_14
            Writer.WriteUInt32(valu_moremissions1_14.Value)
            Writer.Position = MoreMissions1_15
            Writer.WriteUInt32(valu_moremissions1_15.Value)
            Writer.Position = MoreMissions1_16
            Writer.WriteUInt32(valu_moremissions1_16.Value)
            Writer.Position = MoreMissions1_17
            Writer.WriteUInt32(valu_moremissions1_17.Value)
            Writer.Position = MoreMissions1_18
            Writer.WriteUInt32(valu_moremissions1_18.Value)
            Writer.Position = MoreMissions1_19
            Writer.WriteUInt32(valu_moremissions1_19.Value)
            Writer.Position = MoreMissions1_20
            Writer.WriteUInt32(valu_moremissions1_20.Value)
            Writer.Position = MoreMissions1_21
            Writer.WriteUInt32(valu_moremissions1_21.Value)
            Writer.Position = MoreMissions1_22
            Writer.WriteUInt32(valu_moremissions1_22.Value)
            Writer.Position = MoreMissions2_1
            Writer.WriteUInt32(valu_moremissions2_1.Value)
            Writer.Position = MoreMissions2_2
            Writer.WriteUInt32(valu_moremissions2_2.Value)
            Writer.Position = MoreMissions2_3
            Writer.WriteUInt32(valu_moremissions2_3.Value)
            Writer.Position = MoreMissions2_4
            Writer.WriteUInt32(valu_moremissions2_4.Value)
            Writer.Position = MoreMissions2_5
            Writer.WriteUInt32(valu_moremissions2_5.Value)
            Writer.Position = MoreMissions2_6
            Writer.WriteUInt32(valu_moremissions2_6.Value)
            Writer.Position = MoreMissions2_7
            Writer.WriteUInt32(valu_moremissions2_7.Value)
            Writer.Position = MoreMissions2_8
            Writer.WriteUInt32(valu_moremissions2_8.Value)
            Writer.Position = MoreMissions2_9
            Writer.WriteUInt32(valu_moremissions2_9.Value)
            Writer.Position = MoreMissions2_10
            Writer.WriteUInt32(valu_moremissions2_10.Value)
            Writer.Position = MoreMissions2_11
            Writer.WriteUInt32(valu_moremissions2_11.Value)
            Writer.Position = MoreMissions2_12
            Writer.WriteUInt32(valu_moremissions2_12.Value)
            Writer.Position = MoreMissions2_13
            Writer.WriteUInt32(valu_moremissions2_13.Value)
            Writer.Position = MoreMissions2_14
            Writer.WriteUInt32(valu_moremissions2_14.Value)
            Writer.Position = MoreMissions2_15
            Writer.WriteUInt32(valu_moremissions2_15.Value)
            Writer.Position = MoreMissions2_16
            Writer.WriteUInt32(valu_moremissions2_16.Value)
            Writer.Position = MoreMissions2_17
            Writer.WriteUInt32(valu_moremissions2_17.Value)
            Writer.Position = MoreMissions2_18
            Writer.WriteUInt32(valu_moremissions2_18.Value)
            Writer.Position = MoreMissions2_19
            Writer.WriteUInt32(valu_moremissions2_19.Value)
            Writer.Position = MoreMissions2_20
            Writer.WriteUInt32(valu_moremissions2_20.Value)
            Writer.Position = MoreMissions2_21
            Writer.WriteUInt32(valu_moremissions2_21.Value)
            Writer.Position = MoreMissions2_22
            Writer.WriteUInt32(valu_moremissions2_22.Value)
            Writer.Position = MoreMissions2_23
            Writer.WriteUInt32(valu_moremissions2_23.Value)
            Writer.Position = MoreMissions2_24
            Writer.WriteUInt32(valu_moremissions2_24.Value)
            Writer.Position = MoreMissions2_25
            Writer.WriteUInt32(valu_moremissions2_25.Value)
            fdialog.Description.Text = "savedata.dat has been succesfully edited"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Description.Text = "Oops... Something goes wrong" & vbNewLine & "Failed to saves changes in your Team Kirby Clash Deluxe save file, make sure you have opened a good savedata.dat file or report this issue"
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
            fdialog.Description.Text = "Failed to read your Team Kirby Clash Deluxe save file, make sure you have opened a good savedata.dat file or report this issue"
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
            fdialog.Description.Text = "Failed to read your Team Kirby Clash Deluxe save file, make sure you have opened a good savedata.dat file or report this issue"
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
        fdialog.Description.Text = "Open savedata.dat" & vbNewLine & "Team Kirby Clash Deluxe Save Editor will make a backup of your save file before any changes, check ''backup'' folder"
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

    Private Sub Icon_p1_arrowright_Click(sender As Object, e As EventArgs) Handles Icon_p1_arrowright.Click
        hidepages()
        Panel_page_3.Visible = True
    End Sub

    Private Sub Icon_p3_arrowleft_Click(sender As Object, e As EventArgs) Handles Icon_p3_arrowleft.Click
        hidepages()
        Panel_page_1.Visible = True
    End Sub

    Private Sub Icon_p3_arrowright_Click(sender As Object, e As EventArgs) Handles Icon_p3_arrowright.Click
        hidepages()
        Panel_page_5.Visible = True
    End Sub

    Private Sub Icon_p5_arrowleft_Click(sender As Object, e As EventArgs) Handles Icon_p5_arrowleft.Click
        hidepages()
        Panel_page_3.Visible = True
    End Sub

    Private Sub Icon_p5_arrowright_Click(sender As Object, e As EventArgs) Handles Icon_p5_arrowright.Click
        hidepages()
        Panel_page_7.Visible = True
    End Sub

    Private Sub Icon_p7_arrowleft_Click(sender As Object, e As EventArgs) Handles Icon_p7_arrowleft.Click
        hidepages()
        Panel_page_5.Visible = True
    End Sub

    Private Sub Icon_p7_arrowright_Click(sender As Object, e As EventArgs) Handles Icon_p7_arrowright.Click
        hidepages()
        Panel_page_9.Visible = True
    End Sub

    Private Sub Icon_p9_arrowleft_Click(sender As Object, e As EventArgs) Handles Icon_p9_arrowleft.Click
        hidepages()
        Panel_page_7.Visible = True
    End Sub

    Private Sub Icon_p9_arrowright_Click(sender As Object, e As EventArgs) Handles Icon_p9_arrowright.Click
        hidepages()
        Panel_page_11.Visible = True
    End Sub

    Private Sub Icon_p11_arrowleft_Click(sender As Object, e As EventArgs) Handles Icon_p11_arrowleft.Click
        hidepages()
        Panel_page_9.Visible = True
    End Sub

    Private Sub Icon_quests1_1_Click(sender As Object, e As EventArgs) Handles Icon_quests1_1.Click
        If valu_quests1_1.Value = 0 Then
            valu_quests1_1.Value = 1
        ElseIf valu_quests1_1.Value = 1 Then
            valu_quests1_1.Value = 4
        ElseIf valu_quests1_1.Value = 4 Then
            valu_quests1_1.Value = 0
        Else
            valu_quests1_1.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_1.ValueChanged
        If valu_quests1_1.Value = 0 Then
            Icon_quests1_1.Image = Nothing
        ElseIf valu_quests1_1.Value = 1 Then
            Icon_quests1_1.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_1.Value = 4 Then
            Icon_quests1_1.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_2_Click(sender As Object, e As EventArgs) Handles Icon_quests1_2.Click
        If valu_quests1_2.Value = 0 Then
            valu_quests1_2.Value = 1
        ElseIf valu_quests1_2.Value = 1 Then
            valu_quests1_2.Value = 4
        ElseIf valu_quests1_2.Value = 4 Then
            valu_quests1_2.Value = 0
        Else
            valu_quests1_2.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_2.ValueChanged
        If valu_quests1_2.Value = 0 Then
            Icon_quests1_2.Image = Nothing
        ElseIf valu_quests1_2.Value = 1 Then
            Icon_quests1_2.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_2.Value = 4 Then
            Icon_quests1_2.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_3_Click(sender As Object, e As EventArgs) Handles Icon_quests1_3.Click
        If valu_quests1_3.Value = 0 Then
            valu_quests1_3.Value = 1
        ElseIf valu_quests1_3.Value = 1 Then
            valu_quests1_3.Value = 4
        ElseIf valu_quests1_3.Value = 4 Then
            valu_quests1_3.Value = 0
        Else
            valu_quests1_3.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_3.ValueChanged
        If valu_quests1_3.Value = 0 Then
            Icon_quests1_3.Image = Nothing
        ElseIf valu_quests1_3.Value = 1 Then
            Icon_quests1_3.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_3.Value = 4 Then
            Icon_quests1_3.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_4_Click(sender As Object, e As EventArgs) Handles Icon_quests1_4.Click
        If valu_quests1_4.Value = 0 Then
            valu_quests1_4.Value = 1
        ElseIf valu_quests1_4.Value = 1 Then
            valu_quests1_4.Value = 4
        ElseIf valu_quests1_4.Value = 4 Then
            valu_quests1_4.Value = 0
        Else
            valu_quests1_4.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_4.ValueChanged
        If valu_quests1_4.Value = 0 Then
            Icon_quests1_4.Image = Nothing
        ElseIf valu_quests1_4.Value = 1 Then
            Icon_quests1_4.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_4.Value = 4 Then
            Icon_quests1_4.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_5_Click(sender As Object, e As EventArgs) Handles Icon_quests1_5.Click
        If valu_quests1_5.Value = 0 Then
            valu_quests1_5.Value = 1
        ElseIf valu_quests1_5.Value = 1 Then
            valu_quests1_5.Value = 4
        ElseIf valu_quests1_5.Value = 4 Then
            valu_quests1_5.Value = 0
        Else
            valu_quests1_5.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_5.ValueChanged
        If valu_quests1_5.Value = 0 Then
            Icon_quests1_5.Image = Nothing
        ElseIf valu_quests1_5.Value = 1 Then
            Icon_quests1_5.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_5.Value = 4 Then
            Icon_quests1_5.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_6_Click(sender As Object, e As EventArgs) Handles Icon_quests1_6.Click
        If valu_quests1_6.Value = 0 Then
            valu_quests1_6.Value = 1
        ElseIf valu_quests1_6.Value = 1 Then
            valu_quests1_6.Value = 4
        ElseIf valu_quests1_6.Value = 4 Then
            valu_quests1_6.Value = 0
        Else
            valu_quests1_6.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_6.ValueChanged
        If valu_quests1_6.Value = 0 Then
            Icon_quests1_6.Image = Nothing
        ElseIf valu_quests1_6.Value = 1 Then
            Icon_quests1_6.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_6.Value = 4 Then
            Icon_quests1_6.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_7_Click(sender As Object, e As EventArgs) Handles Icon_quests1_7.Click
        If valu_quests1_7.Value = 0 Then
            valu_quests1_7.Value = 1
        ElseIf valu_quests1_7.Value = 1 Then
            valu_quests1_7.Value = 4
        ElseIf valu_quests1_7.Value = 4 Then
            valu_quests1_7.Value = 0
        Else
            valu_quests1_7.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_7.ValueChanged
        If valu_quests1_7.Value = 0 Then
            Icon_quests1_7.Image = Nothing
        ElseIf valu_quests1_7.Value = 1 Then
            Icon_quests1_7.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_7.Value = 4 Then
            Icon_quests1_7.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_8_Click(sender As Object, e As EventArgs) Handles Icon_quests1_8.Click
        If valu_quests1_8.Value = 0 Then
            valu_quests1_8.Value = 1
        ElseIf valu_quests1_8.Value = 1 Then
            valu_quests1_8.Value = 4
        ElseIf valu_quests1_8.Value = 4 Then
            valu_quests1_8.Value = 0
        Else
            valu_quests1_8.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_8.ValueChanged
        If valu_quests1_8.Value = 0 Then
            Icon_quests1_8.Image = Nothing
        ElseIf valu_quests1_8.Value = 1 Then
            Icon_quests1_8.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_8.Value = 4 Then
            Icon_quests1_8.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_9_Click(sender As Object, e As EventArgs) Handles Icon_quests1_9.Click
        If valu_quests1_9.Value = 0 Then
            valu_quests1_9.Value = 1
        ElseIf valu_quests1_9.Value = 1 Then
            valu_quests1_9.Value = 4
        ElseIf valu_quests1_9.Value = 4 Then
            valu_quests1_9.Value = 0
        Else
            valu_quests1_9.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_9.ValueChanged
        If valu_quests1_9.Value = 0 Then
            Icon_quests1_9.Image = Nothing
        ElseIf valu_quests1_9.Value = 1 Then
            Icon_quests1_9.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_9.Value = 4 Then
            Icon_quests1_9.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_10_Click(sender As Object, e As EventArgs) Handles Icon_quests1_10.Click
        If valu_quests1_10.Value = 0 Then
            valu_quests1_10.Value = 1
        ElseIf valu_quests1_10.Value = 1 Then
            valu_quests1_10.Value = 4
        ElseIf valu_quests1_10.Value = 4 Then
            valu_quests1_10.Value = 0
        Else
            valu_quests1_10.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_10.ValueChanged
        If valu_quests1_10.Value = 0 Then
            Icon_quests1_10.Image = Nothing
        ElseIf valu_quests1_10.Value = 1 Then
            Icon_quests1_10.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_10.Value = 4 Then
            Icon_quests1_10.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_11_Click(sender As Object, e As EventArgs) Handles Icon_quests1_11.Click
        If valu_quests1_11.Value = 0 Then
            valu_quests1_11.Value = 1
        ElseIf valu_quests1_11.Value = 1 Then
            valu_quests1_11.Value = 4
        ElseIf valu_quests1_11.Value = 4 Then
            valu_quests1_11.Value = 0
        Else
            valu_quests1_11.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_11.ValueChanged
        If valu_quests1_11.Value = 0 Then
            Icon_quests1_11.Image = Nothing
        ElseIf valu_quests1_11.Value = 1 Then
            Icon_quests1_11.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_11.Value = 4 Then
            Icon_quests1_11.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_12_Click(sender As Object, e As EventArgs) Handles Icon_quests1_12.Click
        If valu_quests1_12.Value = 0 Then
            valu_quests1_12.Value = 1
        ElseIf valu_quests1_12.Value = 1 Then
            valu_quests1_12.Value = 4
        ElseIf valu_quests1_12.Value = 4 Then
            valu_quests1_12.Value = 0
        Else
            valu_quests1_12.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_12.ValueChanged
        If valu_quests1_12.Value = 0 Then
            Icon_quests1_12.Image = Nothing
        ElseIf valu_quests1_12.Value = 1 Then
            Icon_quests1_12.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_12.Value = 4 Then
            Icon_quests1_12.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_13_Click(sender As Object, e As EventArgs) Handles Icon_quests1_13.Click
        If valu_quests1_13.Value = 0 Then
            valu_quests1_13.Value = 1
        ElseIf valu_quests1_13.Value = 1 Then
            valu_quests1_13.Value = 4
        ElseIf valu_quests1_13.Value = 4 Then
            valu_quests1_13.Value = 0
        Else
            valu_quests1_13.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_13.ValueChanged
        If valu_quests1_13.Value = 0 Then
            Icon_quests1_13.Image = Nothing
        ElseIf valu_quests1_13.Value = 1 Then
            Icon_quests1_13.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_13.Value = 4 Then
            Icon_quests1_13.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_14_Click(sender As Object, e As EventArgs) Handles Icon_quests1_14.Click
        If valu_quests1_14.Value = 0 Then
            valu_quests1_14.Value = 1
        ElseIf valu_quests1_14.Value = 1 Then
            valu_quests1_14.Value = 4
        ElseIf valu_quests1_14.Value = 4 Then
            valu_quests1_14.Value = 0
        Else
            valu_quests1_14.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_14.ValueChanged
        If valu_quests1_14.Value = 0 Then
            Icon_quests1_14.Image = Nothing
        ElseIf valu_quests1_14.Value = 1 Then
            Icon_quests1_14.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_14.Value = 4 Then
            Icon_quests1_14.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_15_Click(sender As Object, e As EventArgs) Handles Icon_quests1_15.Click
        If valu_quests1_15.Value = 0 Then
            valu_quests1_15.Value = 1
        ElseIf valu_quests1_15.Value = 1 Then
            valu_quests1_15.Value = 4
        ElseIf valu_quests1_15.Value = 4 Then
            valu_quests1_15.Value = 0
        Else
            valu_quests1_15.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_15.ValueChanged
        If valu_quests1_15.Value = 0 Then
            Icon_quests1_15.Image = Nothing
        ElseIf valu_quests1_15.Value = 1 Then
            Icon_quests1_15.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_15.Value = 4 Then
            Icon_quests1_15.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_16_Click(sender As Object, e As EventArgs) Handles Icon_quests1_16.Click
        If valu_quests1_16.Value = 0 Then
            valu_quests1_16.Value = 1
        ElseIf valu_quests1_16.Value = 1 Then
            valu_quests1_16.Value = 4
        ElseIf valu_quests1_16.Value = 4 Then
            valu_quests1_16.Value = 0
        Else
            valu_quests1_16.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_16.ValueChanged
        If valu_quests1_16.Value = 0 Then
            Icon_quests1_16.Image = Nothing
        ElseIf valu_quests1_16.Value = 1 Then
            Icon_quests1_16.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_16.Value = 4 Then
            Icon_quests1_16.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_17_Click(sender As Object, e As EventArgs) Handles Icon_quests1_17.Click
        If valu_quests1_17.Value = 0 Then
            valu_quests1_17.Value = 1
        ElseIf valu_quests1_17.Value = 1 Then
            valu_quests1_17.Value = 4
        ElseIf valu_quests1_17.Value = 4 Then
            valu_quests1_17.Value = 0
        Else
            valu_quests1_17.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_17.ValueChanged
        If valu_quests1_17.Value = 0 Then
            Icon_quests1_17.Image = Nothing
        ElseIf valu_quests1_17.Value = 1 Then
            Icon_quests1_17.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_17.Value = 4 Then
            Icon_quests1_17.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_18_Click(sender As Object, e As EventArgs) Handles Icon_quests1_18.Click
        If valu_quests1_18.Value = 0 Then
            valu_quests1_18.Value = 1
        ElseIf valu_quests1_18.Value = 1 Then
            valu_quests1_18.Value = 4
        ElseIf valu_quests1_18.Value = 4 Then
            valu_quests1_18.Value = 0
        Else
            valu_quests1_18.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_18.ValueChanged
        If valu_quests1_18.Value = 0 Then
            Icon_quests1_18.Image = Nothing
        ElseIf valu_quests1_18.Value = 1 Then
            Icon_quests1_18.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_18.Value = 4 Then
            Icon_quests1_18.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_19_Click(sender As Object, e As EventArgs) Handles Icon_quests1_19.Click
        If valu_quests1_19.Value = 0 Then
            valu_quests1_19.Value = 1
        ElseIf valu_quests1_19.Value = 1 Then
            valu_quests1_19.Value = 4
        ElseIf valu_quests1_19.Value = 4 Then
            valu_quests1_19.Value = 0
        Else
            valu_quests1_19.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_19.ValueChanged
        If valu_quests1_19.Value = 0 Then
            Icon_quests1_19.Image = Nothing
        ElseIf valu_quests1_19.Value = 1 Then
            Icon_quests1_19.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_19.Value = 4 Then
            Icon_quests1_19.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests1_20_Click(sender As Object, e As EventArgs) Handles Icon_quests1_20.Click
        If valu_quests1_20.Value = 0 Then
            valu_quests1_20.Value = 1
        ElseIf valu_quests1_20.Value = 1 Then
            valu_quests1_20.Value = 4
        ElseIf valu_quests1_20.Value = 4 Then
            valu_quests1_20.Value = 0
        Else
            valu_quests1_20.Value = 0
        End If
    End Sub

    Private Sub valu_quests1_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests1_20.ValueChanged
        If valu_quests1_20.Value = 0 Then
            Icon_quests1_20.Image = Nothing
        ElseIf valu_quests1_20.Value = 1 Then
            Icon_quests1_20.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests1_20.Value = 4 Then
            Icon_quests1_20.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_1_Click(sender As Object, e As EventArgs) Handles Icon_quests2_1.Click
        If valu_quests2_1.Value = 0 Then
            valu_quests2_1.Value = 1
        ElseIf valu_quests2_1.Value = 1 Then
            valu_quests2_1.Value = 4
        ElseIf valu_quests2_1.Value = 4 Then
            valu_quests2_1.Value = 0
        Else
            valu_quests2_1.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_1.ValueChanged
        If valu_quests2_1.Value = 0 Then
            Icon_quests2_1.Image = Nothing
        ElseIf valu_quests2_1.Value = 1 Then
            Icon_quests2_1.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_1.Value = 4 Then
            Icon_quests2_1.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_2_Click(sender As Object, e As EventArgs) Handles Icon_quests2_2.Click
        If valu_quests2_2.Value = 0 Then
            valu_quests2_2.Value = 1
        ElseIf valu_quests2_2.Value = 1 Then
            valu_quests2_2.Value = 4
        ElseIf valu_quests2_2.Value = 4 Then
            valu_quests2_2.Value = 0
        Else
            valu_quests2_2.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_2.ValueChanged
        If valu_quests2_2.Value = 0 Then
            Icon_quests2_2.Image = Nothing
        ElseIf valu_quests2_2.Value = 1 Then
            Icon_quests2_2.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_2.Value = 4 Then
            Icon_quests2_2.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_3_Click(sender As Object, e As EventArgs) Handles Icon_quests2_3.Click
        If valu_quests2_3.Value = 0 Then
            valu_quests2_3.Value = 1
        ElseIf valu_quests2_3.Value = 1 Then
            valu_quests2_3.Value = 4
        ElseIf valu_quests2_3.Value = 4 Then
            valu_quests2_3.Value = 0
        Else
            valu_quests2_3.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_3.ValueChanged
        If valu_quests2_3.Value = 0 Then
            Icon_quests2_3.Image = Nothing
        ElseIf valu_quests2_3.Value = 1 Then
            Icon_quests2_3.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_3.Value = 4 Then
            Icon_quests2_3.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_4_Click(sender As Object, e As EventArgs) Handles Icon_quests2_4.Click
        If valu_quests2_4.Value = 0 Then
            valu_quests2_4.Value = 1
        ElseIf valu_quests2_4.Value = 1 Then
            valu_quests2_4.Value = 4
        ElseIf valu_quests2_4.Value = 4 Then
            valu_quests2_4.Value = 0
        Else
            valu_quests2_4.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_4.ValueChanged
        If valu_quests2_4.Value = 0 Then
            Icon_quests2_4.Image = Nothing
        ElseIf valu_quests2_4.Value = 1 Then
            Icon_quests2_4.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_4.Value = 4 Then
            Icon_quests2_4.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_5_Click(sender As Object, e As EventArgs) Handles Icon_quests2_5.Click
        If valu_quests2_5.Value = 0 Then
            valu_quests2_5.Value = 1
        ElseIf valu_quests2_5.Value = 1 Then
            valu_quests2_5.Value = 4
        ElseIf valu_quests2_5.Value = 4 Then
            valu_quests2_5.Value = 0
        Else
            valu_quests2_5.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_5.ValueChanged
        If valu_quests2_5.Value = 0 Then
            Icon_quests2_5.Image = Nothing
        ElseIf valu_quests2_5.Value = 1 Then
            Icon_quests2_5.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_5.Value = 4 Then
            Icon_quests2_5.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_6_Click(sender As Object, e As EventArgs) Handles Icon_quests2_6.Click
        If valu_quests2_6.Value = 0 Then
            valu_quests2_6.Value = 1
        ElseIf valu_quests2_6.Value = 1 Then
            valu_quests2_6.Value = 4
        ElseIf valu_quests2_6.Value = 4 Then
            valu_quests2_6.Value = 0
        Else
            valu_quests2_6.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_6.ValueChanged
        If valu_quests2_6.Value = 0 Then
            Icon_quests2_6.Image = Nothing
        ElseIf valu_quests2_6.Value = 1 Then
            Icon_quests2_6.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_6.Value = 4 Then
            Icon_quests2_6.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_7_Click(sender As Object, e As EventArgs) Handles Icon_quests2_7.Click
        If valu_quests2_7.Value = 0 Then
            valu_quests2_7.Value = 1
        ElseIf valu_quests2_7.Value = 1 Then
            valu_quests2_7.Value = 4
        ElseIf valu_quests2_7.Value = 4 Then
            valu_quests2_7.Value = 0
        Else
            valu_quests2_7.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_7.ValueChanged
        If valu_quests2_7.Value = 0 Then
            Icon_quests2_7.Image = Nothing
        ElseIf valu_quests2_7.Value = 1 Then
            Icon_quests2_7.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_7.Value = 4 Then
            Icon_quests2_7.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_8_Click(sender As Object, e As EventArgs) Handles Icon_quests2_8.Click
        If valu_quests2_8.Value = 0 Then
            valu_quests2_8.Value = 1
        ElseIf valu_quests2_8.Value = 1 Then
            valu_quests2_8.Value = 4
        ElseIf valu_quests2_8.Value = 4 Then
            valu_quests2_8.Value = 0
        Else
            valu_quests2_8.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_8.ValueChanged
        If valu_quests2_8.Value = 0 Then
            Icon_quests2_8.Image = Nothing
        ElseIf valu_quests2_8.Value = 1 Then
            Icon_quests2_8.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_8.Value = 4 Then
            Icon_quests2_8.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_9_Click(sender As Object, e As EventArgs) Handles Icon_quests2_9.Click
        If valu_quests2_9.Value = 0 Then
            valu_quests2_9.Value = 1
        ElseIf valu_quests2_9.Value = 1 Then
            valu_quests2_9.Value = 4
        ElseIf valu_quests2_9.Value = 4 Then
            valu_quests2_9.Value = 0
        Else
            valu_quests2_9.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_9.ValueChanged
        If valu_quests2_9.Value = 0 Then
            Icon_quests2_9.Image = Nothing
        ElseIf valu_quests2_9.Value = 1 Then
            Icon_quests2_9.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_9.Value = 4 Then
            Icon_quests2_9.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_10_Click(sender As Object, e As EventArgs) Handles Icon_quests2_10.Click
        If valu_quests2_10.Value = 0 Then
            valu_quests2_10.Value = 1
        ElseIf valu_quests2_10.Value = 1 Then
            valu_quests2_10.Value = 4
        ElseIf valu_quests2_10.Value = 4 Then
            valu_quests2_10.Value = 0
        Else
            valu_quests2_10.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_10.ValueChanged
        If valu_quests2_10.Value = 0 Then
            Icon_quests2_10.Image = Nothing
        ElseIf valu_quests2_10.Value = 1 Then
            Icon_quests2_10.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_10.Value = 4 Then
            Icon_quests2_10.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_11_Click(sender As Object, e As EventArgs) Handles Icon_quests2_11.Click
        If valu_quests2_11.Value = 0 Then
            valu_quests2_11.Value = 1
        ElseIf valu_quests2_11.Value = 1 Then
            valu_quests2_11.Value = 4
        ElseIf valu_quests2_11.Value = 4 Then
            valu_quests2_11.Value = 0
        Else
            valu_quests2_11.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_11.ValueChanged
        If valu_quests2_11.Value = 0 Then
            Icon_quests2_11.Image = Nothing
        ElseIf valu_quests2_11.Value = 1 Then
            Icon_quests2_11.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_11.Value = 4 Then
            Icon_quests2_11.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_12_Click(sender As Object, e As EventArgs) Handles Icon_quests2_12.Click
        If valu_quests2_12.Value = 0 Then
            valu_quests2_12.Value = 1
        ElseIf valu_quests2_12.Value = 1 Then
            valu_quests2_12.Value = 4
        ElseIf valu_quests2_12.Value = 4 Then
            valu_quests2_12.Value = 0
        Else
            valu_quests2_12.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_12.ValueChanged
        If valu_quests2_12.Value = 0 Then
            Icon_quests2_12.Image = Nothing
        ElseIf valu_quests2_12.Value = 1 Then
            Icon_quests2_12.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_12.Value = 4 Then
            Icon_quests2_12.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_13_Click(sender As Object, e As EventArgs) Handles Icon_quests2_13.Click
        If valu_quests2_13.Value = 0 Then
            valu_quests2_13.Value = 1
        ElseIf valu_quests2_13.Value = 1 Then
            valu_quests2_13.Value = 4
        ElseIf valu_quests2_13.Value = 4 Then
            valu_quests2_13.Value = 0
        Else
            valu_quests2_13.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_13.ValueChanged
        If valu_quests2_13.Value = 0 Then
            Icon_quests2_13.Image = Nothing
        ElseIf valu_quests2_13.Value = 1 Then
            Icon_quests2_13.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_13.Value = 4 Then
            Icon_quests2_13.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_14_Click(sender As Object, e As EventArgs) Handles Icon_quests2_14.Click
        If valu_quests2_14.Value = 0 Then
            valu_quests2_14.Value = 1
        ElseIf valu_quests2_14.Value = 1 Then
            valu_quests2_14.Value = 4
        ElseIf valu_quests2_14.Value = 4 Then
            valu_quests2_14.Value = 0
        Else
            valu_quests2_14.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_14.ValueChanged
        If valu_quests2_14.Value = 0 Then
            Icon_quests2_14.Image = Nothing
        ElseIf valu_quests2_14.Value = 1 Then
            Icon_quests2_14.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_14.Value = 4 Then
            Icon_quests2_14.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_15_Click(sender As Object, e As EventArgs) Handles Icon_quests2_15.Click
        If valu_quests2_15.Value = 0 Then
            valu_quests2_15.Value = 1
        ElseIf valu_quests2_15.Value = 1 Then
            valu_quests2_15.Value = 4
        ElseIf valu_quests2_15.Value = 4 Then
            valu_quests2_15.Value = 0
        Else
            valu_quests2_15.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_15.ValueChanged
        If valu_quests2_15.Value = 0 Then
            Icon_quests2_15.Image = Nothing
        ElseIf valu_quests2_15.Value = 1 Then
            Icon_quests2_15.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_15.Value = 4 Then
            Icon_quests2_15.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_16_Click(sender As Object, e As EventArgs) Handles Icon_quests2_16.Click
        If valu_quests2_16.Value = 0 Then
            valu_quests2_16.Value = 1
        ElseIf valu_quests2_16.Value = 1 Then
            valu_quests2_16.Value = 4
        ElseIf valu_quests2_16.Value = 4 Then
            valu_quests2_16.Value = 0
        Else
            valu_quests2_16.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_16.ValueChanged
        If valu_quests2_16.Value = 0 Then
            Icon_quests2_16.Image = Nothing
        ElseIf valu_quests2_16.Value = 1 Then
            Icon_quests2_16.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_16.Value = 4 Then
            Icon_quests2_16.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_17_Click(sender As Object, e As EventArgs) Handles Icon_quests2_17.Click
        If valu_quests2_17.Value = 0 Then
            valu_quests2_17.Value = 1
        ElseIf valu_quests2_17.Value = 1 Then
            valu_quests2_17.Value = 4
        ElseIf valu_quests2_17.Value = 4 Then
            valu_quests2_17.Value = 0
        Else
            valu_quests2_17.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_17.ValueChanged
        If valu_quests2_17.Value = 0 Then
            Icon_quests2_17.Image = Nothing
        ElseIf valu_quests2_17.Value = 1 Then
            Icon_quests2_17.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_17.Value = 4 Then
            Icon_quests2_17.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_18_Click(sender As Object, e As EventArgs) Handles Icon_quests2_18.Click
        If valu_quests2_18.Value = 0 Then
            valu_quests2_18.Value = 1
        ElseIf valu_quests2_18.Value = 1 Then
            valu_quests2_18.Value = 4
        ElseIf valu_quests2_18.Value = 4 Then
            valu_quests2_18.Value = 0
        Else
            valu_quests2_18.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_18.ValueChanged
        If valu_quests2_18.Value = 0 Then
            Icon_quests2_18.Image = Nothing
        ElseIf valu_quests2_18.Value = 1 Then
            Icon_quests2_18.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_18.Value = 4 Then
            Icon_quests2_18.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_19_Click(sender As Object, e As EventArgs) Handles Icon_quests2_19.Click
        If valu_quests2_19.Value = 0 Then
            valu_quests2_19.Value = 1
        ElseIf valu_quests2_19.Value = 1 Then
            valu_quests2_19.Value = 4
        ElseIf valu_quests2_19.Value = 4 Then
            valu_quests2_19.Value = 0
        Else
            valu_quests2_19.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_19.ValueChanged
        If valu_quests2_19.Value = 0 Then
            Icon_quests2_19.Image = Nothing
        ElseIf valu_quests2_19.Value = 1 Then
            Icon_quests2_19.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_19.Value = 4 Then
            Icon_quests2_19.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_quests2_20_Click(sender As Object, e As EventArgs) Handles Icon_quests2_20.Click
        If valu_quests2_20.Value = 0 Then
            valu_quests2_20.Value = 1
        ElseIf valu_quests2_20.Value = 1 Then
            valu_quests2_20.Value = 4
        ElseIf valu_quests2_20.Value = 4 Then
            valu_quests2_20.Value = 0
        Else
            valu_quests2_20.Value = 0
        End If
    End Sub

    Private Sub valu_quests2_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_quests2_20.ValueChanged
        If valu_quests2_20.Value = 0 Then
            Icon_quests2_20.Image = Nothing
        ElseIf valu_quests2_20.Value = 1 Then
            Icon_quests2_20.Image = My.Resources.icon_medal_act2
        ElseIf valu_quests2_20.Value = 4 Then
            Icon_quests2_20.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_1_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_1.Click
        If valu_tghquest1_1.Value = 0 Then
            valu_tghquest1_1.Value = 1
        ElseIf valu_tghquest1_1.Value = 1 Then
            valu_tghquest1_1.Value = 4
        ElseIf valu_tghquest1_1.Value = 4 Then
            valu_tghquest1_1.Value = 0
        Else
            valu_tghquest1_1.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_1.ValueChanged
        If valu_tghquest1_1.Value = 0 Then
            Icon_tghquest1_1.Image = Nothing
        ElseIf valu_tghquest1_1.Value = 1 Then
            Icon_tghquest1_1.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_1.Value = 4 Then
            Icon_tghquest1_1.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_2_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_2.Click
        If valu_tghquest1_2.Value = 0 Then
            valu_tghquest1_2.Value = 1
        ElseIf valu_tghquest1_2.Value = 1 Then
            valu_tghquest1_2.Value = 4
        ElseIf valu_tghquest1_2.Value = 4 Then
            valu_tghquest1_2.Value = 0
        Else
            valu_tghquest1_2.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_2.ValueChanged
        If valu_tghquest1_2.Value = 0 Then
            Icon_tghquest1_2.Image = Nothing
        ElseIf valu_tghquest1_2.Value = 1 Then
            Icon_tghquest1_2.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_2.Value = 4 Then
            Icon_tghquest1_2.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_3_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_3.Click
        If valu_tghquest1_3.Value = 0 Then
            valu_tghquest1_3.Value = 1
        ElseIf valu_tghquest1_3.Value = 1 Then
            valu_tghquest1_3.Value = 4
        ElseIf valu_tghquest1_3.Value = 4 Then
            valu_tghquest1_3.Value = 0
        Else
            valu_tghquest1_3.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_3.ValueChanged
        If valu_tghquest1_3.Value = 0 Then
            Icon_tghquest1_3.Image = Nothing
        ElseIf valu_tghquest1_3.Value = 1 Then
            Icon_tghquest1_3.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_3.Value = 4 Then
            Icon_tghquest1_3.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_4_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_4.Click
        If valu_tghquest1_4.Value = 0 Then
            valu_tghquest1_4.Value = 1
        ElseIf valu_tghquest1_4.Value = 1 Then
            valu_tghquest1_4.Value = 4
        ElseIf valu_tghquest1_4.Value = 4 Then
            valu_tghquest1_4.Value = 0
        Else
            valu_tghquest1_4.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_4.ValueChanged
        If valu_tghquest1_4.Value = 0 Then
            Icon_tghquest1_4.Image = Nothing
        ElseIf valu_tghquest1_4.Value = 1 Then
            Icon_tghquest1_4.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_4.Value = 4 Then
            Icon_tghquest1_4.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_5_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_5.Click
        If valu_tghquest1_5.Value = 0 Then
            valu_tghquest1_5.Value = 1
        ElseIf valu_tghquest1_5.Value = 1 Then
            valu_tghquest1_5.Value = 4
        ElseIf valu_tghquest1_5.Value = 4 Then
            valu_tghquest1_5.Value = 0
        Else
            valu_tghquest1_5.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_5.ValueChanged
        If valu_tghquest1_5.Value = 0 Then
            Icon_tghquest1_5.Image = Nothing
        ElseIf valu_tghquest1_5.Value = 1 Then
            Icon_tghquest1_5.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_5.Value = 4 Then
            Icon_tghquest1_5.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_6_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_6.Click
        If valu_tghquest1_6.Value = 0 Then
            valu_tghquest1_6.Value = 1
        ElseIf valu_tghquest1_6.Value = 1 Then
            valu_tghquest1_6.Value = 4
        ElseIf valu_tghquest1_6.Value = 4 Then
            valu_tghquest1_6.Value = 0
        Else
            valu_tghquest1_6.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_6.ValueChanged
        If valu_tghquest1_6.Value = 0 Then
            Icon_tghquest1_6.Image = Nothing
        ElseIf valu_tghquest1_6.Value = 1 Then
            Icon_tghquest1_6.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_6.Value = 4 Then
            Icon_tghquest1_6.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_7_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_7.Click
        If valu_tghquest1_7.Value = 0 Then
            valu_tghquest1_7.Value = 1
        ElseIf valu_tghquest1_7.Value = 1 Then
            valu_tghquest1_7.Value = 4
        ElseIf valu_tghquest1_7.Value = 4 Then
            valu_tghquest1_7.Value = 0
        Else
            valu_tghquest1_7.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_7.ValueChanged
        If valu_tghquest1_7.Value = 0 Then
            Icon_tghquest1_7.Image = Nothing
        ElseIf valu_tghquest1_7.Value = 1 Then
            Icon_tghquest1_7.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_7.Value = 4 Then
            Icon_tghquest1_7.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_8_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_8.Click
        If valu_tghquest1_8.Value = 0 Then
            valu_tghquest1_8.Value = 1
        ElseIf valu_tghquest1_8.Value = 1 Then
            valu_tghquest1_8.Value = 4
        ElseIf valu_tghquest1_8.Value = 4 Then
            valu_tghquest1_8.Value = 0
        Else
            valu_tghquest1_8.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_8.ValueChanged
        If valu_tghquest1_8.Value = 0 Then
            Icon_tghquest1_8.Image = Nothing
        ElseIf valu_tghquest1_8.Value = 1 Then
            Icon_tghquest1_8.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_8.Value = 4 Then
            Icon_tghquest1_8.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_9_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_9.Click
        If valu_tghquest1_9.Value = 0 Then
            valu_tghquest1_9.Value = 1
        ElseIf valu_tghquest1_9.Value = 1 Then
            valu_tghquest1_9.Value = 4
        ElseIf valu_tghquest1_9.Value = 4 Then
            valu_tghquest1_9.Value = 0
        Else
            valu_tghquest1_9.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_9.ValueChanged
        If valu_tghquest1_9.Value = 0 Then
            Icon_tghquest1_9.Image = Nothing
        ElseIf valu_tghquest1_9.Value = 1 Then
            Icon_tghquest1_9.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_9.Value = 4 Then
            Icon_tghquest1_9.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_10_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_10.Click
        If valu_tghquest1_10.Value = 0 Then
            valu_tghquest1_10.Value = 1
        ElseIf valu_tghquest1_10.Value = 1 Then
            valu_tghquest1_10.Value = 4
        ElseIf valu_tghquest1_10.Value = 4 Then
            valu_tghquest1_10.Value = 0
        Else
            valu_tghquest1_10.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_10.ValueChanged
        If valu_tghquest1_10.Value = 0 Then
            Icon_tghquest1_10.Image = Nothing
        ElseIf valu_tghquest1_10.Value = 1 Then
            Icon_tghquest1_10.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_10.Value = 4 Then
            Icon_tghquest1_10.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_11_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_11.Click
        If valu_tghquest1_11.Value = 0 Then
            valu_tghquest1_11.Value = 1
        ElseIf valu_tghquest1_11.Value = 1 Then
            valu_tghquest1_11.Value = 4
        ElseIf valu_tghquest1_11.Value = 4 Then
            valu_tghquest1_11.Value = 0
        Else
            valu_tghquest1_11.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_11.ValueChanged
        If valu_tghquest1_11.Value = 0 Then
            Icon_tghquest1_11.Image = Nothing
        ElseIf valu_tghquest1_11.Value = 1 Then
            Icon_tghquest1_11.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_11.Value = 4 Then
            Icon_tghquest1_11.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_12_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_12.Click
        If valu_tghquest1_12.Value = 0 Then
            valu_tghquest1_12.Value = 1
        ElseIf valu_tghquest1_12.Value = 1 Then
            valu_tghquest1_12.Value = 4
        ElseIf valu_tghquest1_12.Value = 4 Then
            valu_tghquest1_12.Value = 0
        Else
            valu_tghquest1_12.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_12.ValueChanged
        If valu_tghquest1_12.Value = 0 Then
            Icon_tghquest1_12.Image = Nothing
        ElseIf valu_tghquest1_12.Value = 1 Then
            Icon_tghquest1_12.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_12.Value = 4 Then
            Icon_tghquest1_12.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_13_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_13.Click
        If valu_tghquest1_13.Value = 0 Then
            valu_tghquest1_13.Value = 1
        ElseIf valu_tghquest1_13.Value = 1 Then
            valu_tghquest1_13.Value = 4
        ElseIf valu_tghquest1_13.Value = 4 Then
            valu_tghquest1_13.Value = 0
        Else
            valu_tghquest1_13.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_13.ValueChanged
        If valu_tghquest1_13.Value = 0 Then
            Icon_tghquest1_13.Image = Nothing
        ElseIf valu_tghquest1_13.Value = 1 Then
            Icon_tghquest1_13.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_13.Value = 4 Then
            Icon_tghquest1_13.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_14_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_14.Click
        If valu_tghquest1_14.Value = 0 Then
            valu_tghquest1_14.Value = 1
        ElseIf valu_tghquest1_14.Value = 1 Then
            valu_tghquest1_14.Value = 4
        ElseIf valu_tghquest1_14.Value = 4 Then
            valu_tghquest1_14.Value = 0
        Else
            valu_tghquest1_14.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_14.ValueChanged
        If valu_tghquest1_14.Value = 0 Then
            Icon_tghquest1_14.Image = Nothing
        ElseIf valu_tghquest1_14.Value = 1 Then
            Icon_tghquest1_14.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_14.Value = 4 Then
            Icon_tghquest1_14.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_15_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_15.Click
        If valu_tghquest1_15.Value = 0 Then
            valu_tghquest1_15.Value = 1
        ElseIf valu_tghquest1_15.Value = 1 Then
            valu_tghquest1_15.Value = 4
        ElseIf valu_tghquest1_15.Value = 4 Then
            valu_tghquest1_15.Value = 0
        Else
            valu_tghquest1_15.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_15.ValueChanged
        If valu_tghquest1_15.Value = 0 Then
            Icon_tghquest1_15.Image = Nothing
        ElseIf valu_tghquest1_15.Value = 1 Then
            Icon_tghquest1_15.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_15.Value = 4 Then
            Icon_tghquest1_15.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_16_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_16.Click
        If valu_tghquest1_16.Value = 0 Then
            valu_tghquest1_16.Value = 1
        ElseIf valu_tghquest1_16.Value = 1 Then
            valu_tghquest1_16.Value = 4
        ElseIf valu_tghquest1_16.Value = 4 Then
            valu_tghquest1_16.Value = 0
        Else
            valu_tghquest1_16.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_16.ValueChanged
        If valu_tghquest1_16.Value = 0 Then
            Icon_tghquest1_16.Image = Nothing
        ElseIf valu_tghquest1_16.Value = 1 Then
            Icon_tghquest1_16.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_16.Value = 4 Then
            Icon_tghquest1_16.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_17_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_17.Click
        If valu_tghquest1_17.Value = 0 Then
            valu_tghquest1_17.Value = 1
        ElseIf valu_tghquest1_17.Value = 1 Then
            valu_tghquest1_17.Value = 4
        ElseIf valu_tghquest1_17.Value = 4 Then
            valu_tghquest1_17.Value = 0
        Else
            valu_tghquest1_17.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_17.ValueChanged
        If valu_tghquest1_17.Value = 0 Then
            Icon_tghquest1_17.Image = Nothing
        ElseIf valu_tghquest1_17.Value = 1 Then
            Icon_tghquest1_17.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_17.Value = 4 Then
            Icon_tghquest1_17.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_18_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_18.Click
        If valu_tghquest1_18.Value = 0 Then
            valu_tghquest1_18.Value = 1
        ElseIf valu_tghquest1_18.Value = 1 Then
            valu_tghquest1_18.Value = 4
        ElseIf valu_tghquest1_18.Value = 4 Then
            valu_tghquest1_18.Value = 0
        Else
            valu_tghquest1_18.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_18.ValueChanged
        If valu_tghquest1_18.Value = 0 Then
            Icon_tghquest1_18.Image = Nothing
        ElseIf valu_tghquest1_18.Value = 1 Then
            Icon_tghquest1_18.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_18.Value = 4 Then
            Icon_tghquest1_18.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_19_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_19.Click
        If valu_tghquest1_19.Value = 0 Then
            valu_tghquest1_19.Value = 1
        ElseIf valu_tghquest1_19.Value = 1 Then
            valu_tghquest1_19.Value = 4
        ElseIf valu_tghquest1_19.Value = 4 Then
            valu_tghquest1_19.Value = 0
        Else
            valu_tghquest1_19.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_19.ValueChanged
        If valu_tghquest1_19.Value = 0 Then
            Icon_tghquest1_19.Image = Nothing
        ElseIf valu_tghquest1_19.Value = 1 Then
            Icon_tghquest1_19.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_19.Value = 4 Then
            Icon_tghquest1_19.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_20_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_20.Click
        If valu_tghquest1_20.Value = 0 Then
            valu_tghquest1_20.Value = 1
        ElseIf valu_tghquest1_20.Value = 1 Then
            valu_tghquest1_20.Value = 4
        ElseIf valu_tghquest1_20.Value = 4 Then
            valu_tghquest1_20.Value = 0
        Else
            valu_tghquest1_20.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_20.ValueChanged
        If valu_tghquest1_20.Value = 0 Then
            Icon_tghquest1_20.Image = Nothing
        ElseIf valu_tghquest1_20.Value = 1 Then
            Icon_tghquest1_20.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_20.Value = 4 Then
            Icon_tghquest1_20.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_21_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_21.Click
        If valu_tghquest1_21.Value = 0 Then
            valu_tghquest1_21.Value = 1
        ElseIf valu_tghquest1_21.Value = 1 Then
            valu_tghquest1_21.Value = 4
        ElseIf valu_tghquest1_21.Value = 4 Then
            valu_tghquest1_21.Value = 0
        Else
            valu_tghquest1_21.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_21_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_21.ValueChanged
        If valu_tghquest1_21.Value = 0 Then
            Icon_tghquest1_21.Image = Nothing
        ElseIf valu_tghquest1_21.Value = 1 Then
            Icon_tghquest1_21.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_21.Value = 4 Then
            Icon_tghquest1_21.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_22_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_22.Click
        If valu_tghquest1_22.Value = 0 Then
            valu_tghquest1_22.Value = 1
        ElseIf valu_tghquest1_22.Value = 1 Then
            valu_tghquest1_22.Value = 4
        ElseIf valu_tghquest1_22.Value = 4 Then
            valu_tghquest1_22.Value = 0
        Else
            valu_tghquest1_22.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_22_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_22.ValueChanged
        If valu_tghquest1_22.Value = 0 Then
            Icon_tghquest1_22.Image = Nothing
        ElseIf valu_tghquest1_22.Value = 1 Then
            Icon_tghquest1_22.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_22.Value = 4 Then
            Icon_tghquest1_22.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_23_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_23.Click
        If valu_tghquest1_23.Value = 0 Then
            valu_tghquest1_23.Value = 1
        ElseIf valu_tghquest1_23.Value = 1 Then
            valu_tghquest1_23.Value = 4
        ElseIf valu_tghquest1_23.Value = 4 Then
            valu_tghquest1_23.Value = 0
        Else
            valu_tghquest1_23.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_23_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_23.ValueChanged
        If valu_tghquest1_23.Value = 0 Then
            Icon_tghquest1_23.Image = Nothing
        ElseIf valu_tghquest1_23.Value = 1 Then
            Icon_tghquest1_23.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_23.Value = 4 Then
            Icon_tghquest1_23.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_24_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_24.Click
        If valu_tghquest1_24.Value = 0 Then
            valu_tghquest1_24.Value = 1
        ElseIf valu_tghquest1_24.Value = 1 Then
            valu_tghquest1_24.Value = 4
        ElseIf valu_tghquest1_24.Value = 4 Then
            valu_tghquest1_24.Value = 0
        Else
            valu_tghquest1_24.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_24_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_24.ValueChanged
        If valu_tghquest1_24.Value = 0 Then
            Icon_tghquest1_24.Image = Nothing
        ElseIf valu_tghquest1_24.Value = 1 Then
            Icon_tghquest1_24.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_24.Value = 4 Then
            Icon_tghquest1_24.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_25_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_25.Click
        If valu_tghquest1_25.Value = 0 Then
            valu_tghquest1_25.Value = 1
        ElseIf valu_tghquest1_25.Value = 1 Then
            valu_tghquest1_25.Value = 4
        ElseIf valu_tghquest1_25.Value = 4 Then
            valu_tghquest1_25.Value = 0
        Else
            valu_tghquest1_25.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_25_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_25.ValueChanged
        If valu_tghquest1_25.Value = 0 Then
            Icon_tghquest1_25.Image = Nothing
        ElseIf valu_tghquest1_25.Value = 1 Then
            Icon_tghquest1_25.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_25.Value = 4 Then
            Icon_tghquest1_25.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_26_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_26.Click
        If valu_tghquest1_26.Value = 0 Then
            valu_tghquest1_26.Value = 1
        ElseIf valu_tghquest1_26.Value = 1 Then
            valu_tghquest1_26.Value = 4
        ElseIf valu_tghquest1_26.Value = 4 Then
            valu_tghquest1_26.Value = 0
        Else
            valu_tghquest1_26.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_26_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_26.ValueChanged
        If valu_tghquest1_26.Value = 0 Then
            Icon_tghquest1_26.Image = Nothing
        ElseIf valu_tghquest1_26.Value = 1 Then
            Icon_tghquest1_26.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_26.Value = 4 Then
            Icon_tghquest1_26.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_27_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_27.Click
        If valu_tghquest1_27.Value = 0 Then
            valu_tghquest1_27.Value = 1
        ElseIf valu_tghquest1_27.Value = 1 Then
            valu_tghquest1_27.Value = 4
        ElseIf valu_tghquest1_27.Value = 4 Then
            valu_tghquest1_27.Value = 0
        Else
            valu_tghquest1_27.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_27_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_27.ValueChanged
        If valu_tghquest1_27.Value = 0 Then
            Icon_tghquest1_27.Image = Nothing
        ElseIf valu_tghquest1_27.Value = 1 Then
            Icon_tghquest1_27.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_27.Value = 4 Then
            Icon_tghquest1_27.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest1_28_Click(sender As Object, e As EventArgs) Handles Icon_tghquest1_28.Click
        If valu_tghquest1_28.Value = 0 Then
            valu_tghquest1_28.Value = 1
        ElseIf valu_tghquest1_28.Value = 1 Then
            valu_tghquest1_28.Value = 4
        ElseIf valu_tghquest1_28.Value = 4 Then
            valu_tghquest1_28.Value = 0
        Else
            valu_tghquest1_28.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest1_28_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest1_28.ValueChanged
        If valu_tghquest1_28.Value = 0 Then
            Icon_tghquest1_28.Image = Nothing
        ElseIf valu_tghquest1_28.Value = 1 Then
            Icon_tghquest1_28.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest1_28.Value = 4 Then
            Icon_tghquest1_28.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_1_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_1.Click
        If valu_tghquest2_1.Value = 0 Then
            valu_tghquest2_1.Value = 1
        ElseIf valu_tghquest2_1.Value = 1 Then
            valu_tghquest2_1.Value = 4
        ElseIf valu_tghquest2_1.Value = 4 Then
            valu_tghquest2_1.Value = 0
        Else
            valu_tghquest2_1.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_1.ValueChanged
        If valu_tghquest2_1.Value = 0 Then
            Icon_tghquest2_1.Image = Nothing
        ElseIf valu_tghquest2_1.Value = 1 Then
            Icon_tghquest2_1.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_1.Value = 4 Then
            Icon_tghquest2_1.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_2_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_2.Click
        If valu_tghquest2_2.Value = 0 Then
            valu_tghquest2_2.Value = 1
        ElseIf valu_tghquest2_2.Value = 1 Then
            valu_tghquest2_2.Value = 4
        ElseIf valu_tghquest2_2.Value = 4 Then
            valu_tghquest2_2.Value = 0
        Else
            valu_tghquest2_2.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_2.ValueChanged
        If valu_tghquest2_2.Value = 0 Then
            Icon_tghquest2_2.Image = Nothing
        ElseIf valu_tghquest2_2.Value = 1 Then
            Icon_tghquest2_2.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_2.Value = 4 Then
            Icon_tghquest2_2.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_3_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_3.Click
        If valu_tghquest2_3.Value = 0 Then
            valu_tghquest2_3.Value = 1
        ElseIf valu_tghquest2_3.Value = 1 Then
            valu_tghquest2_3.Value = 4
        ElseIf valu_tghquest2_3.Value = 4 Then
            valu_tghquest2_3.Value = 0
        Else
            valu_tghquest2_3.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_3.ValueChanged
        If valu_tghquest2_3.Value = 0 Then
            Icon_tghquest2_3.Image = Nothing
        ElseIf valu_tghquest2_3.Value = 1 Then
            Icon_tghquest2_3.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_3.Value = 4 Then
            Icon_tghquest2_3.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_4_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_4.Click
        If valu_tghquest2_4.Value = 0 Then
            valu_tghquest2_4.Value = 1
        ElseIf valu_tghquest2_4.Value = 1 Then
            valu_tghquest2_4.Value = 4
        ElseIf valu_tghquest2_4.Value = 4 Then
            valu_tghquest2_4.Value = 0
        Else
            valu_tghquest2_4.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_4.ValueChanged
        If valu_tghquest2_4.Value = 0 Then
            Icon_tghquest2_4.Image = Nothing
        ElseIf valu_tghquest2_4.Value = 1 Then
            Icon_tghquest2_4.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_4.Value = 4 Then
            Icon_tghquest2_4.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_5_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_5.Click
        If valu_tghquest2_5.Value = 0 Then
            valu_tghquest2_5.Value = 1
        ElseIf valu_tghquest2_5.Value = 1 Then
            valu_tghquest2_5.Value = 4
        ElseIf valu_tghquest2_5.Value = 4 Then
            valu_tghquest2_5.Value = 0
        Else
            valu_tghquest2_5.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_5.ValueChanged
        If valu_tghquest2_5.Value = 0 Then
            Icon_tghquest2_5.Image = Nothing
        ElseIf valu_tghquest2_5.Value = 1 Then
            Icon_tghquest2_5.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_5.Value = 4 Then
            Icon_tghquest2_5.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_6_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_6.Click
        If valu_tghquest2_6.Value = 0 Then
            valu_tghquest2_6.Value = 1
        ElseIf valu_tghquest2_6.Value = 1 Then
            valu_tghquest2_6.Value = 4
        ElseIf valu_tghquest2_6.Value = 4 Then
            valu_tghquest2_6.Value = 0
        Else
            valu_tghquest2_6.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_6.ValueChanged
        If valu_tghquest2_6.Value = 0 Then
            Icon_tghquest2_6.Image = Nothing
        ElseIf valu_tghquest2_6.Value = 1 Then
            Icon_tghquest2_6.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_6.Value = 4 Then
            Icon_tghquest2_6.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_7_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_7.Click
        If valu_tghquest2_7.Value = 0 Then
            valu_tghquest2_7.Value = 1
        ElseIf valu_tghquest2_7.Value = 1 Then
            valu_tghquest2_7.Value = 4
        ElseIf valu_tghquest2_7.Value = 4 Then
            valu_tghquest2_7.Value = 0
        Else
            valu_tghquest2_7.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_7.ValueChanged
        If valu_tghquest2_7.Value = 0 Then
            Icon_tghquest2_7.Image = Nothing
        ElseIf valu_tghquest2_7.Value = 1 Then
            Icon_tghquest2_7.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_7.Value = 4 Then
            Icon_tghquest2_7.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_8_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_8.Click
        If valu_tghquest2_8.Value = 0 Then
            valu_tghquest2_8.Value = 1
        ElseIf valu_tghquest2_8.Value = 1 Then
            valu_tghquest2_8.Value = 4
        ElseIf valu_tghquest2_8.Value = 4 Then
            valu_tghquest2_8.Value = 0
        Else
            valu_tghquest2_8.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_8.ValueChanged
        If valu_tghquest2_8.Value = 0 Then
            Icon_tghquest2_8.Image = Nothing
        ElseIf valu_tghquest2_8.Value = 1 Then
            Icon_tghquest2_8.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_8.Value = 4 Then
            Icon_tghquest2_8.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_9_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_9.Click
        If valu_tghquest2_9.Value = 0 Then
            valu_tghquest2_9.Value = 1
        ElseIf valu_tghquest2_9.Value = 1 Then
            valu_tghquest2_9.Value = 4
        ElseIf valu_tghquest2_9.Value = 4 Then
            valu_tghquest2_9.Value = 0
        Else
            valu_tghquest2_9.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_9.ValueChanged
        If valu_tghquest2_9.Value = 0 Then
            Icon_tghquest2_9.Image = Nothing
        ElseIf valu_tghquest2_9.Value = 1 Then
            Icon_tghquest2_9.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_9.Value = 4 Then
            Icon_tghquest2_9.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_10_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_10.Click
        If valu_tghquest2_10.Value = 0 Then
            valu_tghquest2_10.Value = 1
        ElseIf valu_tghquest2_10.Value = 1 Then
            valu_tghquest2_10.Value = 4
        ElseIf valu_tghquest2_10.Value = 4 Then
            valu_tghquest2_10.Value = 0
        Else
            valu_tghquest2_10.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_10.ValueChanged
        If valu_tghquest2_10.Value = 0 Then
            Icon_tghquest2_10.Image = Nothing
        ElseIf valu_tghquest2_10.Value = 1 Then
            Icon_tghquest2_10.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_10.Value = 4 Then
            Icon_tghquest2_10.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_11_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_11.Click
        If valu_tghquest2_11.Value = 0 Then
            valu_tghquest2_11.Value = 1
        ElseIf valu_tghquest2_11.Value = 1 Then
            valu_tghquest2_11.Value = 4
        ElseIf valu_tghquest2_11.Value = 4 Then
            valu_tghquest2_11.Value = 0
        Else
            valu_tghquest2_11.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_11.ValueChanged
        If valu_tghquest2_11.Value = 0 Then
            Icon_tghquest2_11.Image = Nothing
        ElseIf valu_tghquest2_11.Value = 1 Then
            Icon_tghquest2_11.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_11.Value = 4 Then
            Icon_tghquest2_11.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_12_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_12.Click
        If valu_tghquest2_12.Value = 0 Then
            valu_tghquest2_12.Value = 1
        ElseIf valu_tghquest2_12.Value = 1 Then
            valu_tghquest2_12.Value = 4
        ElseIf valu_tghquest2_12.Value = 4 Then
            valu_tghquest2_12.Value = 0
        Else
            valu_tghquest2_12.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_12.ValueChanged
        If valu_tghquest2_12.Value = 0 Then
            Icon_tghquest2_12.Image = Nothing
        ElseIf valu_tghquest2_12.Value = 1 Then
            Icon_tghquest2_12.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_12.Value = 4 Then
            Icon_tghquest2_12.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_13_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_13.Click
        If valu_tghquest2_13.Value = 0 Then
            valu_tghquest2_13.Value = 1
        ElseIf valu_tghquest2_13.Value = 1 Then
            valu_tghquest2_13.Value = 4
        ElseIf valu_tghquest2_13.Value = 4 Then
            valu_tghquest2_13.Value = 0
        Else
            valu_tghquest2_13.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_13.ValueChanged
        If valu_tghquest2_13.Value = 0 Then
            Icon_tghquest2_13.Image = Nothing
        ElseIf valu_tghquest2_13.Value = 1 Then
            Icon_tghquest2_13.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_13.Value = 4 Then
            Icon_tghquest2_13.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_14_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_14.Click
        If valu_tghquest2_14.Value = 0 Then
            valu_tghquest2_14.Value = 1
        ElseIf valu_tghquest2_14.Value = 1 Then
            valu_tghquest2_14.Value = 4
        ElseIf valu_tghquest2_14.Value = 4 Then
            valu_tghquest2_14.Value = 0
        Else
            valu_tghquest2_14.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_14.ValueChanged
        If valu_tghquest2_14.Value = 0 Then
            Icon_tghquest2_14.Image = Nothing
        ElseIf valu_tghquest2_14.Value = 1 Then
            Icon_tghquest2_14.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_14.Value = 4 Then
            Icon_tghquest2_14.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_15_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_15.Click
        If valu_tghquest2_15.Value = 0 Then
            valu_tghquest2_15.Value = 1
        ElseIf valu_tghquest2_15.Value = 1 Then
            valu_tghquest2_15.Value = 4
        ElseIf valu_tghquest2_15.Value = 4 Then
            valu_tghquest2_15.Value = 0
        Else
            valu_tghquest2_15.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_15.ValueChanged
        If valu_tghquest2_15.Value = 0 Then
            Icon_tghquest2_15.Image = Nothing
        ElseIf valu_tghquest2_15.Value = 1 Then
            Icon_tghquest2_15.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_15.Value = 4 Then
            Icon_tghquest2_15.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_16_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_16.Click
        If valu_tghquest2_16.Value = 0 Then
            valu_tghquest2_16.Value = 1
        ElseIf valu_tghquest2_16.Value = 1 Then
            valu_tghquest2_16.Value = 4
        ElseIf valu_tghquest2_16.Value = 4 Then
            valu_tghquest2_16.Value = 0
        Else
            valu_tghquest2_16.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_16.ValueChanged
        If valu_tghquest2_16.Value = 0 Then
            Icon_tghquest2_16.Image = Nothing
        ElseIf valu_tghquest2_16.Value = 1 Then
            Icon_tghquest2_16.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_16.Value = 4 Then
            Icon_tghquest2_16.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_17_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_17.Click
        If valu_tghquest2_17.Value = 0 Then
            valu_tghquest2_17.Value = 1
        ElseIf valu_tghquest2_17.Value = 1 Then
            valu_tghquest2_17.Value = 4
        ElseIf valu_tghquest2_17.Value = 4 Then
            valu_tghquest2_17.Value = 0
        Else
            valu_tghquest2_17.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_17.ValueChanged
        If valu_tghquest2_17.Value = 0 Then
            Icon_tghquest2_17.Image = Nothing
        ElseIf valu_tghquest2_17.Value = 1 Then
            Icon_tghquest2_17.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_17.Value = 4 Then
            Icon_tghquest2_17.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_18_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_18.Click
        If valu_tghquest2_18.Value = 0 Then
            valu_tghquest2_18.Value = 1
        ElseIf valu_tghquest2_18.Value = 1 Then
            valu_tghquest2_18.Value = 4
        ElseIf valu_tghquest2_18.Value = 4 Then
            valu_tghquest2_18.Value = 0
        Else
            valu_tghquest2_18.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_18.ValueChanged
        If valu_tghquest2_18.Value = 0 Then
            Icon_tghquest2_18.Image = Nothing
        ElseIf valu_tghquest2_18.Value = 1 Then
            Icon_tghquest2_18.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_18.Value = 4 Then
            Icon_tghquest2_18.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_19_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_19.Click
        If valu_tghquest2_19.Value = 0 Then
            valu_tghquest2_19.Value = 1
        ElseIf valu_tghquest2_19.Value = 1 Then
            valu_tghquest2_19.Value = 4
        ElseIf valu_tghquest2_19.Value = 4 Then
            valu_tghquest2_19.Value = 0
        Else
            valu_tghquest2_19.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_19.ValueChanged
        If valu_tghquest2_19.Value = 0 Then
            Icon_tghquest2_19.Image = Nothing
        ElseIf valu_tghquest2_19.Value = 1 Then
            Icon_tghquest2_19.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_19.Value = 4 Then
            Icon_tghquest2_19.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_20_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_20.Click
        If valu_tghquest2_20.Value = 0 Then
            valu_tghquest2_20.Value = 1
        ElseIf valu_tghquest2_20.Value = 1 Then
            valu_tghquest2_20.Value = 4
        ElseIf valu_tghquest2_20.Value = 4 Then
            valu_tghquest2_20.Value = 0
        Else
            valu_tghquest2_20.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_20.ValueChanged
        If valu_tghquest2_20.Value = 0 Then
            Icon_tghquest2_20.Image = Nothing
        ElseIf valu_tghquest2_20.Value = 1 Then
            Icon_tghquest2_20.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_20.Value = 4 Then
            Icon_tghquest2_20.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_21_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_21.Click
        If valu_tghquest2_21.Value = 0 Then
            valu_tghquest2_21.Value = 1
        ElseIf valu_tghquest2_21.Value = 1 Then
            valu_tghquest2_21.Value = 4
        ElseIf valu_tghquest2_21.Value = 4 Then
            valu_tghquest2_21.Value = 0
        Else
            valu_tghquest2_21.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_21_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_21.ValueChanged
        If valu_tghquest2_21.Value = 0 Then
            Icon_tghquest2_21.Image = Nothing
        ElseIf valu_tghquest2_21.Value = 1 Then
            Icon_tghquest2_21.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_21.Value = 4 Then
            Icon_tghquest2_21.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_22_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_22.Click
        If valu_tghquest2_22.Value = 0 Then
            valu_tghquest2_22.Value = 1
        ElseIf valu_tghquest2_22.Value = 1 Then
            valu_tghquest2_22.Value = 4
        ElseIf valu_tghquest2_22.Value = 4 Then
            valu_tghquest2_22.Value = 0
        Else
            valu_tghquest2_22.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_22_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_22.ValueChanged
        If valu_tghquest2_22.Value = 0 Then
            Icon_tghquest2_22.Image = Nothing
        ElseIf valu_tghquest2_22.Value = 1 Then
            Icon_tghquest2_22.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_22.Value = 4 Then
            Icon_tghquest2_22.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_23_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_23.Click
        If valu_tghquest2_23.Value = 0 Then
            valu_tghquest2_23.Value = 1
        ElseIf valu_tghquest2_23.Value = 1 Then
            valu_tghquest2_23.Value = 4
        ElseIf valu_tghquest2_23.Value = 4 Then
            valu_tghquest2_23.Value = 0
        Else
            valu_tghquest2_23.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_23_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_23.ValueChanged
        If valu_tghquest2_23.Value = 0 Then
            Icon_tghquest2_23.Image = Nothing
        ElseIf valu_tghquest2_23.Value = 1 Then
            Icon_tghquest2_23.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_23.Value = 4 Then
            Icon_tghquest2_23.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_24_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_24.Click
        If valu_tghquest2_24.Value = 0 Then
            valu_tghquest2_24.Value = 1
        ElseIf valu_tghquest2_24.Value = 1 Then
            valu_tghquest2_24.Value = 4
        ElseIf valu_tghquest2_24.Value = 4 Then
            valu_tghquest2_24.Value = 0
        Else
            valu_tghquest2_24.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_24_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_24.ValueChanged
        If valu_tghquest2_24.Value = 0 Then
            Icon_tghquest2_24.Image = Nothing
        ElseIf valu_tghquest2_24.Value = 1 Then
            Icon_tghquest2_24.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_24.Value = 4 Then
            Icon_tghquest2_24.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_25_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_25.Click
        If valu_tghquest2_25.Value = 0 Then
            valu_tghquest2_25.Value = 1
        ElseIf valu_tghquest2_25.Value = 1 Then
            valu_tghquest2_25.Value = 4
        ElseIf valu_tghquest2_25.Value = 4 Then
            valu_tghquest2_25.Value = 0
        Else
            valu_tghquest2_25.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_25_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_25.ValueChanged
        If valu_tghquest2_25.Value = 0 Then
            Icon_tghquest2_25.Image = Nothing
        ElseIf valu_tghquest2_25.Value = 1 Then
            Icon_tghquest2_25.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_25.Value = 4 Then
            Icon_tghquest2_25.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_26_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_26.Click
        If valu_tghquest2_26.Value = 0 Then
            valu_tghquest2_26.Value = 1
        ElseIf valu_tghquest2_26.Value = 1 Then
            valu_tghquest2_26.Value = 4
        ElseIf valu_tghquest2_26.Value = 4 Then
            valu_tghquest2_26.Value = 0
        Else
            valu_tghquest2_26.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_26_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_26.ValueChanged
        If valu_tghquest2_26.Value = 0 Then
            Icon_tghquest2_26.Image = Nothing
        ElseIf valu_tghquest2_26.Value = 1 Then
            Icon_tghquest2_26.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_26.Value = 4 Then
            Icon_tghquest2_26.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_27_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_27.Click
        If valu_tghquest2_27.Value = 0 Then
            valu_tghquest2_27.Value = 1
        ElseIf valu_tghquest2_27.Value = 1 Then
            valu_tghquest2_27.Value = 4
        ElseIf valu_tghquest2_27.Value = 4 Then
            valu_tghquest2_27.Value = 0
        Else
            valu_tghquest2_27.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_27_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_27.ValueChanged
        If valu_tghquest2_27.Value = 0 Then
            Icon_tghquest2_27.Image = Nothing
        ElseIf valu_tghquest2_27.Value = 1 Then
            Icon_tghquest2_27.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_27.Value = 4 Then
            Icon_tghquest2_27.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tghquest2_28_Click(sender As Object, e As EventArgs) Handles Icon_tghquest2_28.Click
        If valu_tghquest2_28.Value = 0 Then
            valu_tghquest2_28.Value = 1
        ElseIf valu_tghquest2_28.Value = 1 Then
            valu_tghquest2_28.Value = 4
        ElseIf valu_tghquest2_28.Value = 4 Then
            valu_tghquest2_28.Value = 0
        Else
            valu_tghquest2_28.Value = 0
        End If
    End Sub

    Private Sub valu_tghquest2_28_ValueChanged(sender As Object, e As EventArgs) Handles valu_tghquest2_28.ValueChanged
        If valu_tghquest2_28.Value = 0 Then
            Icon_tghquest2_28.Image = Nothing
        ElseIf valu_tghquest2_28.Value = 1 Then
            Icon_tghquest2_28.Image = My.Resources.icon_medal_act2
        ElseIf valu_tghquest2_28.Value = 4 Then
            Icon_tghquest2_28.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_1_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_1.Click
        If valu_tgherquest1_1.Value = 0 Then
            valu_tgherquest1_1.Value = 1
        ElseIf valu_tgherquest1_1.Value = 1 Then
            valu_tgherquest1_1.Value = 4
        ElseIf valu_tgherquest1_1.Value = 4 Then
            valu_tgherquest1_1.Value = 0
        Else
            valu_tgherquest1_1.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_1.ValueChanged
        If valu_tgherquest1_1.Value = 0 Then
            Icon_tgherquest1_1.Image = Nothing
        ElseIf valu_tgherquest1_1.Value = 1 Then
            Icon_tgherquest1_1.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_1.Value = 4 Then
            Icon_tgherquest1_1.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_2_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_2.Click
        If valu_tgherquest1_2.Value = 0 Then
            valu_tgherquest1_2.Value = 1
        ElseIf valu_tgherquest1_2.Value = 1 Then
            valu_tgherquest1_2.Value = 4
        ElseIf valu_tgherquest1_2.Value = 4 Then
            valu_tgherquest1_2.Value = 0
        Else
            valu_tgherquest1_2.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_2.ValueChanged
        If valu_tgherquest1_2.Value = 0 Then
            Icon_tgherquest1_2.Image = Nothing
        ElseIf valu_tgherquest1_2.Value = 1 Then
            Icon_tgherquest1_2.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_2.Value = 4 Then
            Icon_tgherquest1_2.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_3_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_3.Click
        If valu_tgherquest1_3.Value = 0 Then
            valu_tgherquest1_3.Value = 1
        ElseIf valu_tgherquest1_3.Value = 1 Then
            valu_tgherquest1_3.Value = 4
        ElseIf valu_tgherquest1_3.Value = 4 Then
            valu_tgherquest1_3.Value = 0
        Else
            valu_tgherquest1_3.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_3.ValueChanged
        If valu_tgherquest1_3.Value = 0 Then
            Icon_tgherquest1_3.Image = Nothing
        ElseIf valu_tgherquest1_3.Value = 1 Then
            Icon_tgherquest1_3.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_3.Value = 4 Then
            Icon_tgherquest1_3.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_4_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_4.Click
        If valu_tgherquest1_4.Value = 0 Then
            valu_tgherquest1_4.Value = 1
        ElseIf valu_tgherquest1_4.Value = 1 Then
            valu_tgherquest1_4.Value = 4
        ElseIf valu_tgherquest1_4.Value = 4 Then
            valu_tgherquest1_4.Value = 0
        Else
            valu_tgherquest1_4.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_4.ValueChanged
        If valu_tgherquest1_4.Value = 0 Then
            Icon_tgherquest1_4.Image = Nothing
        ElseIf valu_tgherquest1_4.Value = 1 Then
            Icon_tgherquest1_4.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_4.Value = 4 Then
            Icon_tgherquest1_4.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_5_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_5.Click
        If valu_tgherquest1_5.Value = 0 Then
            valu_tgherquest1_5.Value = 1
        ElseIf valu_tgherquest1_5.Value = 1 Then
            valu_tgherquest1_5.Value = 4
        ElseIf valu_tgherquest1_5.Value = 4 Then
            valu_tgherquest1_5.Value = 0
        Else
            valu_tgherquest1_5.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_5.ValueChanged
        If valu_tgherquest1_5.Value = 0 Then
            Icon_tgherquest1_5.Image = Nothing
        ElseIf valu_tgherquest1_5.Value = 1 Then
            Icon_tgherquest1_5.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_5.Value = 4 Then
            Icon_tgherquest1_5.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_6_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_6.Click
        If valu_tgherquest1_6.Value = 0 Then
            valu_tgherquest1_6.Value = 1
        ElseIf valu_tgherquest1_6.Value = 1 Then
            valu_tgherquest1_6.Value = 4
        ElseIf valu_tgherquest1_6.Value = 4 Then
            valu_tgherquest1_6.Value = 0
        Else
            valu_tgherquest1_6.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_6.ValueChanged
        If valu_tgherquest1_6.Value = 0 Then
            Icon_tgherquest1_6.Image = Nothing
        ElseIf valu_tgherquest1_6.Value = 1 Then
            Icon_tgherquest1_6.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_6.Value = 4 Then
            Icon_tgherquest1_6.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_7_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_7.Click
        If valu_tgherquest1_7.Value = 0 Then
            valu_tgherquest1_7.Value = 1
        ElseIf valu_tgherquest1_7.Value = 1 Then
            valu_tgherquest1_7.Value = 4
        ElseIf valu_tgherquest1_7.Value = 4 Then
            valu_tgherquest1_7.Value = 0
        Else
            valu_tgherquest1_7.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_7.ValueChanged
        If valu_tgherquest1_7.Value = 0 Then
            Icon_tgherquest1_7.Image = Nothing
        ElseIf valu_tgherquest1_7.Value = 1 Then
            Icon_tgherquest1_7.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_7.Value = 4 Then
            Icon_tgherquest1_7.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_8_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_8.Click
        If valu_tgherquest1_8.Value = 0 Then
            valu_tgherquest1_8.Value = 1
        ElseIf valu_tgherquest1_8.Value = 1 Then
            valu_tgherquest1_8.Value = 4
        ElseIf valu_tgherquest1_8.Value = 4 Then
            valu_tgherquest1_8.Value = 0
        Else
            valu_tgherquest1_8.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_8.ValueChanged
        If valu_tgherquest1_8.Value = 0 Then
            Icon_tgherquest1_8.Image = Nothing
        ElseIf valu_tgherquest1_8.Value = 1 Then
            Icon_tgherquest1_8.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_8.Value = 4 Then
            Icon_tgherquest1_8.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_9_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_9.Click
        If valu_tgherquest1_9.Value = 0 Then
            valu_tgherquest1_9.Value = 1
        ElseIf valu_tgherquest1_9.Value = 1 Then
            valu_tgherquest1_9.Value = 4
        ElseIf valu_tgherquest1_9.Value = 4 Then
            valu_tgherquest1_9.Value = 0
        Else
            valu_tgherquest1_9.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_9.ValueChanged
        If valu_tgherquest1_9.Value = 0 Then
            Icon_tgherquest1_9.Image = Nothing
        ElseIf valu_tgherquest1_9.Value = 1 Then
            Icon_tgherquest1_9.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_9.Value = 4 Then
            Icon_tgherquest1_9.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_10_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_10.Click
        If valu_tgherquest1_10.Value = 0 Then
            valu_tgherquest1_10.Value = 1
        ElseIf valu_tgherquest1_10.Value = 1 Then
            valu_tgherquest1_10.Value = 4
        ElseIf valu_tgherquest1_10.Value = 4 Then
            valu_tgherquest1_10.Value = 0
        Else
            valu_tgherquest1_10.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_10.ValueChanged
        If valu_tgherquest1_10.Value = 0 Then
            Icon_tgherquest1_10.Image = Nothing
        ElseIf valu_tgherquest1_10.Value = 1 Then
            Icon_tgherquest1_10.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_10.Value = 4 Then
            Icon_tgherquest1_10.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_11_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_11.Click
        If valu_tgherquest1_11.Value = 0 Then
            valu_tgherquest1_11.Value = 1
        ElseIf valu_tgherquest1_11.Value = 1 Then
            valu_tgherquest1_11.Value = 4
        ElseIf valu_tgherquest1_11.Value = 4 Then
            valu_tgherquest1_11.Value = 0
        Else
            valu_tgherquest1_11.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_11.ValueChanged
        If valu_tgherquest1_11.Value = 0 Then
            Icon_tgherquest1_11.Image = Nothing
        ElseIf valu_tgherquest1_11.Value = 1 Then
            Icon_tgherquest1_11.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_11.Value = 4 Then
            Icon_tgherquest1_11.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_12_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_12.Click
        If valu_tgherquest1_12.Value = 0 Then
            valu_tgherquest1_12.Value = 1
        ElseIf valu_tgherquest1_12.Value = 1 Then
            valu_tgherquest1_12.Value = 4
        ElseIf valu_tgherquest1_12.Value = 4 Then
            valu_tgherquest1_12.Value = 0
        Else
            valu_tgherquest1_12.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_12.ValueChanged
        If valu_tgherquest1_12.Value = 0 Then
            Icon_tgherquest1_12.Image = Nothing
        ElseIf valu_tgherquest1_12.Value = 1 Then
            Icon_tgherquest1_12.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_12.Value = 4 Then
            Icon_tgherquest1_12.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_13_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_13.Click
        If valu_tgherquest1_13.Value = 0 Then
            valu_tgherquest1_13.Value = 1
        ElseIf valu_tgherquest1_13.Value = 1 Then
            valu_tgherquest1_13.Value = 4
        ElseIf valu_tgherquest1_13.Value = 4 Then
            valu_tgherquest1_13.Value = 0
        Else
            valu_tgherquest1_13.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_13.ValueChanged
        If valu_tgherquest1_13.Value = 0 Then
            Icon_tgherquest1_13.Image = Nothing
        ElseIf valu_tgherquest1_13.Value = 1 Then
            Icon_tgherquest1_13.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_13.Value = 4 Then
            Icon_tgherquest1_13.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_14_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_14.Click
        If valu_tgherquest1_14.Value = 0 Then
            valu_tgherquest1_14.Value = 1
        ElseIf valu_tgherquest1_14.Value = 1 Then
            valu_tgherquest1_14.Value = 4
        ElseIf valu_tgherquest1_14.Value = 4 Then
            valu_tgherquest1_14.Value = 0
        Else
            valu_tgherquest1_14.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_14.ValueChanged
        If valu_tgherquest1_14.Value = 0 Then
            Icon_tgherquest1_14.Image = Nothing
        ElseIf valu_tgherquest1_14.Value = 1 Then
            Icon_tgherquest1_14.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_14.Value = 4 Then
            Icon_tgherquest1_14.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_15_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_15.Click
        If valu_tgherquest1_15.Value = 0 Then
            valu_tgherquest1_15.Value = 1
        ElseIf valu_tgherquest1_15.Value = 1 Then
            valu_tgherquest1_15.Value = 4
        ElseIf valu_tgherquest1_15.Value = 4 Then
            valu_tgherquest1_15.Value = 0
        Else
            valu_tgherquest1_15.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_15.ValueChanged
        If valu_tgherquest1_15.Value = 0 Then
            Icon_tgherquest1_15.Image = Nothing
        ElseIf valu_tgherquest1_15.Value = 1 Then
            Icon_tgherquest1_15.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_15.Value = 4 Then
            Icon_tgherquest1_15.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_16_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_16.Click
        If valu_tgherquest1_16.Value = 0 Then
            valu_tgherquest1_16.Value = 1
        ElseIf valu_tgherquest1_16.Value = 1 Then
            valu_tgherquest1_16.Value = 4
        ElseIf valu_tgherquest1_16.Value = 4 Then
            valu_tgherquest1_16.Value = 0
        Else
            valu_tgherquest1_16.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_16.ValueChanged
        If valu_tgherquest1_16.Value = 0 Then
            Icon_tgherquest1_16.Image = Nothing
        ElseIf valu_tgherquest1_16.Value = 1 Then
            Icon_tgherquest1_16.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_16.Value = 4 Then
            Icon_tgherquest1_16.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_17_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_17.Click
        If valu_tgherquest1_17.Value = 0 Then
            valu_tgherquest1_17.Value = 1
        ElseIf valu_tgherquest1_17.Value = 1 Then
            valu_tgherquest1_17.Value = 4
        ElseIf valu_tgherquest1_17.Value = 4 Then
            valu_tgherquest1_17.Value = 0
        Else
            valu_tgherquest1_17.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_17.ValueChanged
        If valu_tgherquest1_17.Value = 0 Then
            Icon_tgherquest1_17.Image = Nothing
        ElseIf valu_tgherquest1_17.Value = 1 Then
            Icon_tgherquest1_17.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_17.Value = 4 Then
            Icon_tgherquest1_17.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_18_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_18.Click
        If valu_tgherquest1_18.Value = 0 Then
            valu_tgherquest1_18.Value = 1
        ElseIf valu_tgherquest1_18.Value = 1 Then
            valu_tgherquest1_18.Value = 4
        ElseIf valu_tgherquest1_18.Value = 4 Then
            valu_tgherquest1_18.Value = 0
        Else
            valu_tgherquest1_18.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_18.ValueChanged
        If valu_tgherquest1_18.Value = 0 Then
            Icon_tgherquest1_18.Image = Nothing
        ElseIf valu_tgherquest1_18.Value = 1 Then
            Icon_tgherquest1_18.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_18.Value = 4 Then
            Icon_tgherquest1_18.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_19_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_19.Click
        If valu_tgherquest1_19.Value = 0 Then
            valu_tgherquest1_19.Value = 1
        ElseIf valu_tgherquest1_19.Value = 1 Then
            valu_tgherquest1_19.Value = 4
        ElseIf valu_tgherquest1_19.Value = 4 Then
            valu_tgherquest1_19.Value = 0
        Else
            valu_tgherquest1_19.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_19.ValueChanged
        If valu_tgherquest1_19.Value = 0 Then
            Icon_tgherquest1_19.Image = Nothing
        ElseIf valu_tgherquest1_19.Value = 1 Then
            Icon_tgherquest1_19.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_19.Value = 4 Then
            Icon_tgherquest1_19.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_20_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_20.Click
        If valu_tgherquest1_20.Value = 0 Then
            valu_tgherquest1_20.Value = 1
        ElseIf valu_tgherquest1_20.Value = 1 Then
            valu_tgherquest1_20.Value = 4
        ElseIf valu_tgherquest1_20.Value = 4 Then
            valu_tgherquest1_20.Value = 0
        Else
            valu_tgherquest1_20.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_20.ValueChanged
        If valu_tgherquest1_20.Value = 0 Then
            Icon_tgherquest1_20.Image = Nothing
        ElseIf valu_tgherquest1_20.Value = 1 Then
            Icon_tgherquest1_20.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_20.Value = 4 Then
            Icon_tgherquest1_20.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_21_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_21.Click
        If valu_tgherquest1_21.Value = 0 Then
            valu_tgherquest1_21.Value = 1
        ElseIf valu_tgherquest1_21.Value = 1 Then
            valu_tgherquest1_21.Value = 4
        ElseIf valu_tgherquest1_21.Value = 4 Then
            valu_tgherquest1_21.Value = 0
        Else
            valu_tgherquest1_21.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_21_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_21.ValueChanged
        If valu_tgherquest1_21.Value = 0 Then
            Icon_tgherquest1_21.Image = Nothing
        ElseIf valu_tgherquest1_21.Value = 1 Then
            Icon_tgherquest1_21.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_21.Value = 4 Then
            Icon_tgherquest1_21.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_22_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_22.Click
        If valu_tgherquest1_22.Value = 0 Then
            valu_tgherquest1_22.Value = 1
        ElseIf valu_tgherquest1_22.Value = 1 Then
            valu_tgherquest1_22.Value = 4
        ElseIf valu_tgherquest1_22.Value = 4 Then
            valu_tgherquest1_22.Value = 0
        Else
            valu_tgherquest1_22.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_22_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_22.ValueChanged
        If valu_tgherquest1_22.Value = 0 Then
            Icon_tgherquest1_22.Image = Nothing
        ElseIf valu_tgherquest1_22.Value = 1 Then
            Icon_tgherquest1_22.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_22.Value = 4 Then
            Icon_tgherquest1_22.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_23_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_23.Click
        If valu_tgherquest1_23.Value = 0 Then
            valu_tgherquest1_23.Value = 1
        ElseIf valu_tgherquest1_23.Value = 1 Then
            valu_tgherquest1_23.Value = 4
        ElseIf valu_tgherquest1_23.Value = 4 Then
            valu_tgherquest1_23.Value = 0
        Else
            valu_tgherquest1_23.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_23_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_23.ValueChanged
        If valu_tgherquest1_23.Value = 0 Then
            Icon_tgherquest1_23.Image = Nothing
        ElseIf valu_tgherquest1_23.Value = 1 Then
            Icon_tgherquest1_23.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_23.Value = 4 Then
            Icon_tgherquest1_23.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_24_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_24.Click
        If valu_tgherquest1_24.Value = 0 Then
            valu_tgherquest1_24.Value = 1
        ElseIf valu_tgherquest1_24.Value = 1 Then
            valu_tgherquest1_24.Value = 4
        ElseIf valu_tgherquest1_24.Value = 4 Then
            valu_tgherquest1_24.Value = 0
        Else
            valu_tgherquest1_24.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_24_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_24.ValueChanged
        If valu_tgherquest1_24.Value = 0 Then
            Icon_tgherquest1_24.Image = Nothing
        ElseIf valu_tgherquest1_24.Value = 1 Then
            Icon_tgherquest1_24.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_24.Value = 4 Then
            Icon_tgherquest1_24.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_25_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_25.Click
        If valu_tgherquest1_25.Value = 0 Then
            valu_tgherquest1_25.Value = 1
        ElseIf valu_tgherquest1_25.Value = 1 Then
            valu_tgherquest1_25.Value = 4
        ElseIf valu_tgherquest1_25.Value = 4 Then
            valu_tgherquest1_25.Value = 0
        Else
            valu_tgherquest1_25.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_25_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_25.ValueChanged
        If valu_tgherquest1_25.Value = 0 Then
            Icon_tgherquest1_25.Image = Nothing
        ElseIf valu_tgherquest1_25.Value = 1 Then
            Icon_tgherquest1_25.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_25.Value = 4 Then
            Icon_tgherquest1_25.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_26_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_26.Click
        If valu_tgherquest1_26.Value = 0 Then
            valu_tgherquest1_26.Value = 1
        ElseIf valu_tgherquest1_26.Value = 1 Then
            valu_tgherquest1_26.Value = 4
        ElseIf valu_tgherquest1_26.Value = 4 Then
            valu_tgherquest1_26.Value = 0
        Else
            valu_tgherquest1_26.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_26_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_26.ValueChanged
        If valu_tgherquest1_26.Value = 0 Then
            Icon_tgherquest1_26.Image = Nothing
        ElseIf valu_tgherquest1_26.Value = 1 Then
            Icon_tgherquest1_26.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_26.Value = 4 Then
            Icon_tgherquest1_26.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_27_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_27.Click
        If valu_tgherquest1_27.Value = 0 Then
            valu_tgherquest1_27.Value = 1
        ElseIf valu_tgherquest1_27.Value = 1 Then
            valu_tgherquest1_27.Value = 4
        ElseIf valu_tgherquest1_27.Value = 4 Then
            valu_tgherquest1_27.Value = 0
        Else
            valu_tgherquest1_27.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_27_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_27.ValueChanged
        If valu_tgherquest1_27.Value = 0 Then
            Icon_tgherquest1_27.Image = Nothing
        ElseIf valu_tgherquest1_27.Value = 1 Then
            Icon_tgherquest1_27.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_27.Value = 4 Then
            Icon_tgherquest1_27.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_28_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_28.Click
        If valu_tgherquest1_28.Value = 0 Then
            valu_tgherquest1_28.Value = 1
        ElseIf valu_tgherquest1_28.Value = 1 Then
            valu_tgherquest1_28.Value = 4
        ElseIf valu_tgherquest1_28.Value = 4 Then
            valu_tgherquest1_28.Value = 0
        Else
            valu_tgherquest1_28.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_28_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_28.ValueChanged
        If valu_tgherquest1_28.Value = 0 Then
            Icon_tgherquest1_28.Image = Nothing
        ElseIf valu_tgherquest1_28.Value = 1 Then
            Icon_tgherquest1_28.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_28.Value = 4 Then
            Icon_tgherquest1_28.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_29_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_29.Click
        If valu_tgherquest1_29.Value = 0 Then
            valu_tgherquest1_29.Value = 1
        ElseIf valu_tgherquest1_29.Value = 1 Then
            valu_tgherquest1_29.Value = 4
        ElseIf valu_tgherquest1_29.Value = 4 Then
            valu_tgherquest1_29.Value = 0
        Else
            valu_tgherquest1_29.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_29_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_29.ValueChanged
        If valu_tgherquest1_29.Value = 0 Then
            Icon_tgherquest1_29.Image = Nothing
        ElseIf valu_tgherquest1_29.Value = 1 Then
            Icon_tgherquest1_29.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_29.Value = 4 Then
            Icon_tgherquest1_29.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_30_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_30.Click
        If valu_tgherquest1_30.Value = 0 Then
            valu_tgherquest1_30.Value = 1
        ElseIf valu_tgherquest1_30.Value = 1 Then
            valu_tgherquest1_30.Value = 4
        ElseIf valu_tgherquest1_30.Value = 4 Then
            valu_tgherquest1_30.Value = 0
        Else
            valu_tgherquest1_30.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_30_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_30.ValueChanged
        If valu_tgherquest1_30.Value = 0 Then
            Icon_tgherquest1_30.Image = Nothing
        ElseIf valu_tgherquest1_30.Value = 1 Then
            Icon_tgherquest1_30.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_30.Value = 4 Then
            Icon_tgherquest1_30.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_31_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_31.Click
        If valu_tgherquest1_31.Value = 0 Then
            valu_tgherquest1_31.Value = 1
        ElseIf valu_tgherquest1_31.Value = 1 Then
            valu_tgherquest1_31.Value = 4
        ElseIf valu_tgherquest1_31.Value = 4 Then
            valu_tgherquest1_31.Value = 0
        Else
            valu_tgherquest1_31.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_31_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_31.ValueChanged
        If valu_tgherquest1_31.Value = 0 Then
            Icon_tgherquest1_31.Image = Nothing
        ElseIf valu_tgherquest1_31.Value = 1 Then
            Icon_tgherquest1_31.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_31.Value = 4 Then
            Icon_tgherquest1_31.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest1_32_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest1_32.Click
        If valu_tgherquest1_32.Value = 0 Then
            valu_tgherquest1_32.Value = 1
        ElseIf valu_tgherquest1_32.Value = 1 Then
            valu_tgherquest1_32.Value = 4
        ElseIf valu_tgherquest1_32.Value = 4 Then
            valu_tgherquest1_32.Value = 0
        Else
            valu_tgherquest1_32.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest1_32_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest1_32.ValueChanged
        If valu_tgherquest1_32.Value = 0 Then
            Icon_tgherquest1_32.Image = Nothing
        ElseIf valu_tgherquest1_32.Value = 1 Then
            Icon_tgherquest1_32.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest1_32.Value = 4 Then
            Icon_tgherquest1_32.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_1_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_1.Click
        If valu_tgherquest2_1.Value = 0 Then
            valu_tgherquest2_1.Value = 1
        ElseIf valu_tgherquest2_1.Value = 1 Then
            valu_tgherquest2_1.Value = 4
        ElseIf valu_tgherquest2_1.Value = 4 Then
            valu_tgherquest2_1.Value = 0
        Else
            valu_tgherquest2_1.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_1.ValueChanged
        If valu_tgherquest2_1.Value = 0 Then
            Icon_tgherquest2_1.Image = Nothing
        ElseIf valu_tgherquest2_1.Value = 1 Then
            Icon_tgherquest2_1.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_1.Value = 4 Then
            Icon_tgherquest2_1.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_2_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_2.Click
        If valu_tgherquest2_2.Value = 0 Then
            valu_tgherquest2_2.Value = 1
        ElseIf valu_tgherquest2_2.Value = 1 Then
            valu_tgherquest2_2.Value = 4
        ElseIf valu_tgherquest2_2.Value = 4 Then
            valu_tgherquest2_2.Value = 0
        Else
            valu_tgherquest2_2.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_2.ValueChanged
        If valu_tgherquest2_2.Value = 0 Then
            Icon_tgherquest2_2.Image = Nothing
        ElseIf valu_tgherquest2_2.Value = 1 Then
            Icon_tgherquest2_2.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_2.Value = 4 Then
            Icon_tgherquest2_2.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_3_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_3.Click
        If valu_tgherquest2_3.Value = 0 Then
            valu_tgherquest2_3.Value = 1
        ElseIf valu_tgherquest2_3.Value = 1 Then
            valu_tgherquest2_3.Value = 4
        ElseIf valu_tgherquest2_3.Value = 4 Then
            valu_tgherquest2_3.Value = 0
        Else
            valu_tgherquest2_3.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_3.ValueChanged
        If valu_tgherquest2_3.Value = 0 Then
            Icon_tgherquest2_3.Image = Nothing
        ElseIf valu_tgherquest2_3.Value = 1 Then
            Icon_tgherquest2_3.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_3.Value = 4 Then
            Icon_tgherquest2_3.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_4_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_4.Click
        If valu_tgherquest2_4.Value = 0 Then
            valu_tgherquest2_4.Value = 1
        ElseIf valu_tgherquest2_4.Value = 1 Then
            valu_tgherquest2_4.Value = 4
        ElseIf valu_tgherquest2_4.Value = 4 Then
            valu_tgherquest2_4.Value = 0
        Else
            valu_tgherquest2_4.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_4.ValueChanged
        If valu_tgherquest2_4.Value = 0 Then
            Icon_tgherquest2_4.Image = Nothing
        ElseIf valu_tgherquest2_4.Value = 1 Then
            Icon_tgherquest2_4.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_4.Value = 4 Then
            Icon_tgherquest2_4.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_5_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_5.Click
        If valu_tgherquest2_5.Value = 0 Then
            valu_tgherquest2_5.Value = 1
        ElseIf valu_tgherquest2_5.Value = 1 Then
            valu_tgherquest2_5.Value = 4
        ElseIf valu_tgherquest2_5.Value = 4 Then
            valu_tgherquest2_5.Value = 0
        Else
            valu_tgherquest2_5.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_5.ValueChanged
        If valu_tgherquest2_5.Value = 0 Then
            Icon_tgherquest2_5.Image = Nothing
        ElseIf valu_tgherquest2_5.Value = 1 Then
            Icon_tgherquest2_5.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_5.Value = 4 Then
            Icon_tgherquest2_5.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_6_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_6.Click
        If valu_tgherquest2_6.Value = 0 Then
            valu_tgherquest2_6.Value = 1
        ElseIf valu_tgherquest2_6.Value = 1 Then
            valu_tgherquest2_6.Value = 4
        ElseIf valu_tgherquest2_6.Value = 4 Then
            valu_tgherquest2_6.Value = 0
        Else
            valu_tgherquest2_6.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_6.ValueChanged
        If valu_tgherquest2_6.Value = 0 Then
            Icon_tgherquest2_6.Image = Nothing
        ElseIf valu_tgherquest2_6.Value = 1 Then
            Icon_tgherquest2_6.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_6.Value = 4 Then
            Icon_tgherquest2_6.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_7_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_7.Click
        If valu_tgherquest2_7.Value = 0 Then
            valu_tgherquest2_7.Value = 1
        ElseIf valu_tgherquest2_7.Value = 1 Then
            valu_tgherquest2_7.Value = 4
        ElseIf valu_tgherquest2_7.Value = 4 Then
            valu_tgherquest2_7.Value = 0
        Else
            valu_tgherquest2_7.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_7.ValueChanged
        If valu_tgherquest2_7.Value = 0 Then
            Icon_tgherquest2_7.Image = Nothing
        ElseIf valu_tgherquest2_7.Value = 1 Then
            Icon_tgherquest2_7.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_7.Value = 4 Then
            Icon_tgherquest2_7.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_8_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_8.Click
        If valu_tgherquest2_8.Value = 0 Then
            valu_tgherquest2_8.Value = 1
        ElseIf valu_tgherquest2_8.Value = 1 Then
            valu_tgherquest2_8.Value = 4
        ElseIf valu_tgherquest2_8.Value = 4 Then
            valu_tgherquest2_8.Value = 0
        Else
            valu_tgherquest2_8.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_8.ValueChanged
        If valu_tgherquest2_8.Value = 0 Then
            Icon_tgherquest2_8.Image = Nothing
        ElseIf valu_tgherquest2_8.Value = 1 Then
            Icon_tgherquest2_8.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_8.Value = 4 Then
            Icon_tgherquest2_8.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_9_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_9.Click
        If valu_tgherquest2_9.Value = 0 Then
            valu_tgherquest2_9.Value = 1
        ElseIf valu_tgherquest2_9.Value = 1 Then
            valu_tgherquest2_9.Value = 4
        ElseIf valu_tgherquest2_9.Value = 4 Then
            valu_tgherquest2_9.Value = 0
        Else
            valu_tgherquest2_9.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_9.ValueChanged
        If valu_tgherquest2_9.Value = 0 Then
            Icon_tgherquest2_9.Image = Nothing
        ElseIf valu_tgherquest2_9.Value = 1 Then
            Icon_tgherquest2_9.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_9.Value = 4 Then
            Icon_tgherquest2_9.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_10_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_10.Click
        If valu_tgherquest2_10.Value = 0 Then
            valu_tgherquest2_10.Value = 1
        ElseIf valu_tgherquest2_10.Value = 1 Then
            valu_tgherquest2_10.Value = 4
        ElseIf valu_tgherquest2_10.Value = 4 Then
            valu_tgherquest2_10.Value = 0
        Else
            valu_tgherquest2_10.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_10.ValueChanged
        If valu_tgherquest2_10.Value = 0 Then
            Icon_tgherquest2_10.Image = Nothing
        ElseIf valu_tgherquest2_10.Value = 1 Then
            Icon_tgherquest2_10.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_10.Value = 4 Then
            Icon_tgherquest2_10.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_11_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_11.Click
        If valu_tgherquest2_11.Value = 0 Then
            valu_tgherquest2_11.Value = 1
        ElseIf valu_tgherquest2_11.Value = 1 Then
            valu_tgherquest2_11.Value = 4
        ElseIf valu_tgherquest2_11.Value = 4 Then
            valu_tgherquest2_11.Value = 0
        Else
            valu_tgherquest2_11.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_11.ValueChanged
        If valu_tgherquest2_11.Value = 0 Then
            Icon_tgherquest2_11.Image = Nothing
        ElseIf valu_tgherquest2_11.Value = 1 Then
            Icon_tgherquest2_11.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_11.Value = 4 Then
            Icon_tgherquest2_11.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_12_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_12.Click
        If valu_tgherquest2_12.Value = 0 Then
            valu_tgherquest2_12.Value = 1
        ElseIf valu_tgherquest2_12.Value = 1 Then
            valu_tgherquest2_12.Value = 4
        ElseIf valu_tgherquest2_12.Value = 4 Then
            valu_tgherquest2_12.Value = 0
        Else
            valu_tgherquest2_12.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_12.ValueChanged
        If valu_tgherquest2_12.Value = 0 Then
            Icon_tgherquest2_12.Image = Nothing
        ElseIf valu_tgherquest2_12.Value = 1 Then
            Icon_tgherquest2_12.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_12.Value = 4 Then
            Icon_tgherquest2_12.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_13_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_13.Click
        If valu_tgherquest2_13.Value = 0 Then
            valu_tgherquest2_13.Value = 1
        ElseIf valu_tgherquest2_13.Value = 1 Then
            valu_tgherquest2_13.Value = 4
        ElseIf valu_tgherquest2_13.Value = 4 Then
            valu_tgherquest2_13.Value = 0
        Else
            valu_tgherquest2_13.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_13.ValueChanged
        If valu_tgherquest2_13.Value = 0 Then
            Icon_tgherquest2_13.Image = Nothing
        ElseIf valu_tgherquest2_13.Value = 1 Then
            Icon_tgherquest2_13.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_13.Value = 4 Then
            Icon_tgherquest2_13.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_14_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_14.Click
        If valu_tgherquest2_14.Value = 0 Then
            valu_tgherquest2_14.Value = 1
        ElseIf valu_tgherquest2_14.Value = 1 Then
            valu_tgherquest2_14.Value = 4
        ElseIf valu_tgherquest2_14.Value = 4 Then
            valu_tgherquest2_14.Value = 0
        Else
            valu_tgherquest2_14.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_14.ValueChanged
        If valu_tgherquest2_14.Value = 0 Then
            Icon_tgherquest2_14.Image = Nothing
        ElseIf valu_tgherquest2_14.Value = 1 Then
            Icon_tgherquest2_14.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_14.Value = 4 Then
            Icon_tgherquest2_14.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_15_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_15.Click
        If valu_tgherquest2_15.Value = 0 Then
            valu_tgherquest2_15.Value = 1
        ElseIf valu_tgherquest2_15.Value = 1 Then
            valu_tgherquest2_15.Value = 4
        ElseIf valu_tgherquest2_15.Value = 4 Then
            valu_tgherquest2_15.Value = 0
        Else
            valu_tgherquest2_15.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_15.ValueChanged
        If valu_tgherquest2_15.Value = 0 Then
            Icon_tgherquest2_15.Image = Nothing
        ElseIf valu_tgherquest2_15.Value = 1 Then
            Icon_tgherquest2_15.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_15.Value = 4 Then
            Icon_tgherquest2_15.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_16_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_16.Click
        If valu_tgherquest2_16.Value = 0 Then
            valu_tgherquest2_16.Value = 1
        ElseIf valu_tgherquest2_16.Value = 1 Then
            valu_tgherquest2_16.Value = 4
        ElseIf valu_tgherquest2_16.Value = 4 Then
            valu_tgherquest2_16.Value = 0
        Else
            valu_tgherquest2_16.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_16.ValueChanged
        If valu_tgherquest2_16.Value = 0 Then
            Icon_tgherquest2_16.Image = Nothing
        ElseIf valu_tgherquest2_16.Value = 1 Then
            Icon_tgherquest2_16.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_16.Value = 4 Then
            Icon_tgherquest2_16.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_17_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_17.Click
        If valu_tgherquest2_17.Value = 0 Then
            valu_tgherquest2_17.Value = 1
        ElseIf valu_tgherquest2_17.Value = 1 Then
            valu_tgherquest2_17.Value = 4
        ElseIf valu_tgherquest2_17.Value = 4 Then
            valu_tgherquest2_17.Value = 0
        Else
            valu_tgherquest2_17.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_17.ValueChanged
        If valu_tgherquest2_17.Value = 0 Then
            Icon_tgherquest2_17.Image = Nothing
        ElseIf valu_tgherquest2_17.Value = 1 Then
            Icon_tgherquest2_17.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_17.Value = 4 Then
            Icon_tgherquest2_17.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_18_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_18.Click
        If valu_tgherquest2_18.Value = 0 Then
            valu_tgherquest2_18.Value = 1
        ElseIf valu_tgherquest2_18.Value = 1 Then
            valu_tgherquest2_18.Value = 4
        ElseIf valu_tgherquest2_18.Value = 4 Then
            valu_tgherquest2_18.Value = 0
        Else
            valu_tgherquest2_18.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_18.ValueChanged
        If valu_tgherquest2_18.Value = 0 Then
            Icon_tgherquest2_18.Image = Nothing
        ElseIf valu_tgherquest2_18.Value = 1 Then
            Icon_tgherquest2_18.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_18.Value = 4 Then
            Icon_tgherquest2_18.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_19_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_19.Click
        If valu_tgherquest2_19.Value = 0 Then
            valu_tgherquest2_19.Value = 1
        ElseIf valu_tgherquest2_19.Value = 1 Then
            valu_tgherquest2_19.Value = 4
        ElseIf valu_tgherquest2_19.Value = 4 Then
            valu_tgherquest2_19.Value = 0
        Else
            valu_tgherquest2_19.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_19.ValueChanged
        If valu_tgherquest2_19.Value = 0 Then
            Icon_tgherquest2_19.Image = Nothing
        ElseIf valu_tgherquest2_19.Value = 1 Then
            Icon_tgherquest2_19.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_19.Value = 4 Then
            Icon_tgherquest2_19.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_20_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_20.Click
        If valu_tgherquest2_20.Value = 0 Then
            valu_tgherquest2_20.Value = 1
        ElseIf valu_tgherquest2_20.Value = 1 Then
            valu_tgherquest2_20.Value = 4
        ElseIf valu_tgherquest2_20.Value = 4 Then
            valu_tgherquest2_20.Value = 0
        Else
            valu_tgherquest2_20.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_20.ValueChanged
        If valu_tgherquest2_20.Value = 0 Then
            Icon_tgherquest2_20.Image = Nothing
        ElseIf valu_tgherquest2_20.Value = 1 Then
            Icon_tgherquest2_20.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_20.Value = 4 Then
            Icon_tgherquest2_20.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_21_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_21.Click
        If valu_tgherquest2_21.Value = 0 Then
            valu_tgherquest2_21.Value = 1
        ElseIf valu_tgherquest2_21.Value = 1 Then
            valu_tgherquest2_21.Value = 4
        ElseIf valu_tgherquest2_21.Value = 4 Then
            valu_tgherquest2_21.Value = 0
        Else
            valu_tgherquest2_21.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_21_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_21.ValueChanged
        If valu_tgherquest2_21.Value = 0 Then
            Icon_tgherquest2_21.Image = Nothing
        ElseIf valu_tgherquest2_21.Value = 1 Then
            Icon_tgherquest2_21.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_21.Value = 4 Then
            Icon_tgherquest2_21.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_22_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_22.Click
        If valu_tgherquest2_22.Value = 0 Then
            valu_tgherquest2_22.Value = 1
        ElseIf valu_tgherquest2_22.Value = 1 Then
            valu_tgherquest2_22.Value = 4
        ElseIf valu_tgherquest2_22.Value = 4 Then
            valu_tgherquest2_22.Value = 0
        Else
            valu_tgherquest2_22.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_22_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_22.ValueChanged
        If valu_tgherquest2_22.Value = 0 Then
            Icon_tgherquest2_22.Image = Nothing
        ElseIf valu_tgherquest2_22.Value = 1 Then
            Icon_tgherquest2_22.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_22.Value = 4 Then
            Icon_tgherquest2_22.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_23_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_23.Click
        If valu_tgherquest2_23.Value = 0 Then
            valu_tgherquest2_23.Value = 1
        ElseIf valu_tgherquest2_23.Value = 1 Then
            valu_tgherquest2_23.Value = 4
        ElseIf valu_tgherquest2_23.Value = 4 Then
            valu_tgherquest2_23.Value = 0
        Else
            valu_tgherquest2_23.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_23_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_23.ValueChanged
        If valu_tgherquest2_23.Value = 0 Then
            Icon_tgherquest2_23.Image = Nothing
        ElseIf valu_tgherquest2_23.Value = 1 Then
            Icon_tgherquest2_23.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_23.Value = 4 Then
            Icon_tgherquest2_23.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_24_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_24.Click
        If valu_tgherquest2_24.Value = 0 Then
            valu_tgherquest2_24.Value = 1
        ElseIf valu_tgherquest2_24.Value = 1 Then
            valu_tgherquest2_24.Value = 4
        ElseIf valu_tgherquest2_24.Value = 4 Then
            valu_tgherquest2_24.Value = 0
        Else
            valu_tgherquest2_24.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_24_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_24.ValueChanged
        If valu_tgherquest2_24.Value = 0 Then
            Icon_tgherquest2_24.Image = Nothing
        ElseIf valu_tgherquest2_24.Value = 1 Then
            Icon_tgherquest2_24.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_24.Value = 4 Then
            Icon_tgherquest2_24.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest2_25_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest2_25.Click
        If valu_tgherquest2_25.Value = 0 Then
            valu_tgherquest2_25.Value = 1
        ElseIf valu_tgherquest2_25.Value = 1 Then
            valu_tgherquest2_25.Value = 4
        ElseIf valu_tgherquest2_25.Value = 4 Then
            valu_tgherquest2_25.Value = 0
        Else
            valu_tgherquest2_25.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest2_25_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest2_25.ValueChanged
        If valu_tgherquest2_25.Value = 0 Then
            Icon_tgherquest2_25.Image = Nothing
        ElseIf valu_tgherquest2_25.Value = 1 Then
            Icon_tgherquest2_25.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest2_25.Value = 4 Then
            Icon_tgherquest2_25.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_1_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_1.Click
        If valu_tgherquest3_1.Value = 0 Then
            valu_tgherquest3_1.Value = 1
        ElseIf valu_tgherquest3_1.Value = 1 Then
            valu_tgherquest3_1.Value = 4
        ElseIf valu_tgherquest3_1.Value = 4 Then
            valu_tgherquest3_1.Value = 0
        Else
            valu_tgherquest3_1.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_1.ValueChanged
        If valu_tgherquest3_1.Value = 0 Then
            Icon_tgherquest3_1.Image = Nothing
        ElseIf valu_tgherquest3_1.Value = 1 Then
            Icon_tgherquest3_1.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_1.Value = 4 Then
            Icon_tgherquest3_1.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_2_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_2.Click
        If valu_tgherquest3_2.Value = 0 Then
            valu_tgherquest3_2.Value = 1
        ElseIf valu_tgherquest3_2.Value = 1 Then
            valu_tgherquest3_2.Value = 4
        ElseIf valu_tgherquest3_2.Value = 4 Then
            valu_tgherquest3_2.Value = 0
        Else
            valu_tgherquest3_2.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_2.ValueChanged
        If valu_tgherquest3_2.Value = 0 Then
            Icon_tgherquest3_2.Image = Nothing
        ElseIf valu_tgherquest3_2.Value = 1 Then
            Icon_tgherquest3_2.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_2.Value = 4 Then
            Icon_tgherquest3_2.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_3_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_3.Click
        If valu_tgherquest3_3.Value = 0 Then
            valu_tgherquest3_3.Value = 1
        ElseIf valu_tgherquest3_3.Value = 1 Then
            valu_tgherquest3_3.Value = 4
        ElseIf valu_tgherquest3_3.Value = 4 Then
            valu_tgherquest3_3.Value = 0
        Else
            valu_tgherquest3_3.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_3.ValueChanged
        If valu_tgherquest3_3.Value = 0 Then
            Icon_tgherquest3_3.Image = Nothing
        ElseIf valu_tgherquest3_3.Value = 1 Then
            Icon_tgherquest3_3.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_3.Value = 4 Then
            Icon_tgherquest3_3.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_4_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_4.Click
        If valu_tgherquest3_4.Value = 0 Then
            valu_tgherquest3_4.Value = 1
        ElseIf valu_tgherquest3_4.Value = 1 Then
            valu_tgherquest3_4.Value = 4
        ElseIf valu_tgherquest3_4.Value = 4 Then
            valu_tgherquest3_4.Value = 0
        Else
            valu_tgherquest3_4.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_4.ValueChanged
        If valu_tgherquest3_4.Value = 0 Then
            Icon_tgherquest3_4.Image = Nothing
        ElseIf valu_tgherquest3_4.Value = 1 Then
            Icon_tgherquest3_4.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_4.Value = 4 Then
            Icon_tgherquest3_4.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_5_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_5.Click
        If valu_tgherquest3_5.Value = 0 Then
            valu_tgherquest3_5.Value = 1
        ElseIf valu_tgherquest3_5.Value = 1 Then
            valu_tgherquest3_5.Value = 4
        ElseIf valu_tgherquest3_5.Value = 4 Then
            valu_tgherquest3_5.Value = 0
        Else
            valu_tgherquest3_5.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_5.ValueChanged
        If valu_tgherquest3_5.Value = 0 Then
            Icon_tgherquest3_5.Image = Nothing
        ElseIf valu_tgherquest3_5.Value = 1 Then
            Icon_tgherquest3_5.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_5.Value = 4 Then
            Icon_tgherquest3_5.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_6_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_6.Click
        If valu_tgherquest3_6.Value = 0 Then
            valu_tgherquest3_6.Value = 1
        ElseIf valu_tgherquest3_6.Value = 1 Then
            valu_tgherquest3_6.Value = 4
        ElseIf valu_tgherquest3_6.Value = 4 Then
            valu_tgherquest3_6.Value = 0
        Else
            valu_tgherquest3_6.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_6.ValueChanged
        If valu_tgherquest3_6.Value = 0 Then
            Icon_tgherquest3_6.Image = Nothing
        ElseIf valu_tgherquest3_6.Value = 1 Then
            Icon_tgherquest3_6.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_6.Value = 4 Then
            Icon_tgherquest3_6.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_7_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_7.Click
        If valu_tgherquest3_7.Value = 0 Then
            valu_tgherquest3_7.Value = 1
        ElseIf valu_tgherquest3_7.Value = 1 Then
            valu_tgherquest3_7.Value = 4
        ElseIf valu_tgherquest3_7.Value = 4 Then
            valu_tgherquest3_7.Value = 0
        Else
            valu_tgherquest3_7.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_7.ValueChanged
        If valu_tgherquest3_7.Value = 0 Then
            Icon_tgherquest3_7.Image = Nothing
        ElseIf valu_tgherquest3_7.Value = 1 Then
            Icon_tgherquest3_7.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_7.Value = 4 Then
            Icon_tgherquest3_7.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_8_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_8.Click
        If valu_tgherquest3_8.Value = 0 Then
            valu_tgherquest3_8.Value = 1
        ElseIf valu_tgherquest3_8.Value = 1 Then
            valu_tgherquest3_8.Value = 4
        ElseIf valu_tgherquest3_8.Value = 4 Then
            valu_tgherquest3_8.Value = 0
        Else
            valu_tgherquest3_8.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_8.ValueChanged
        If valu_tgherquest3_8.Value = 0 Then
            Icon_tgherquest3_8.Image = Nothing
        ElseIf valu_tgherquest3_8.Value = 1 Then
            Icon_tgherquest3_8.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_8.Value = 4 Then
            Icon_tgherquest3_8.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_9_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_9.Click
        If valu_tgherquest3_9.Value = 0 Then
            valu_tgherquest3_9.Value = 1
        ElseIf valu_tgherquest3_9.Value = 1 Then
            valu_tgherquest3_9.Value = 4
        ElseIf valu_tgherquest3_9.Value = 4 Then
            valu_tgherquest3_9.Value = 0
        Else
            valu_tgherquest3_9.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_9.ValueChanged
        If valu_tgherquest3_9.Value = 0 Then
            Icon_tgherquest3_9.Image = Nothing
        ElseIf valu_tgherquest3_9.Value = 1 Then
            Icon_tgherquest3_9.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_9.Value = 4 Then
            Icon_tgherquest3_9.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_10_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_10.Click
        If valu_tgherquest3_10.Value = 0 Then
            valu_tgherquest3_10.Value = 1
        ElseIf valu_tgherquest3_10.Value = 1 Then
            valu_tgherquest3_10.Value = 4
        ElseIf valu_tgherquest3_10.Value = 4 Then
            valu_tgherquest3_10.Value = 0
        Else
            valu_tgherquest3_10.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_10.ValueChanged
        If valu_tgherquest3_10.Value = 0 Then
            Icon_tgherquest3_10.Image = Nothing
        ElseIf valu_tgherquest3_10.Value = 1 Then
            Icon_tgherquest3_10.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_10.Value = 4 Then
            Icon_tgherquest3_10.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_11_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_11.Click
        If valu_tgherquest3_11.Value = 0 Then
            valu_tgherquest3_11.Value = 1
        ElseIf valu_tgherquest3_11.Value = 1 Then
            valu_tgherquest3_11.Value = 4
        ElseIf valu_tgherquest3_11.Value = 4 Then
            valu_tgherquest3_11.Value = 0
        Else
            valu_tgherquest3_11.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_11.ValueChanged
        If valu_tgherquest3_11.Value = 0 Then
            Icon_tgherquest3_11.Image = Nothing
        ElseIf valu_tgherquest3_11.Value = 1 Then
            Icon_tgherquest3_11.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_11.Value = 4 Then
            Icon_tgherquest3_11.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_12_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_12.Click
        If valu_tgherquest3_12.Value = 0 Then
            valu_tgherquest3_12.Value = 1
        ElseIf valu_tgherquest3_12.Value = 1 Then
            valu_tgherquest3_12.Value = 4
        ElseIf valu_tgherquest3_12.Value = 4 Then
            valu_tgherquest3_12.Value = 0
        Else
            valu_tgherquest3_12.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_12.ValueChanged
        If valu_tgherquest3_12.Value = 0 Then
            Icon_tgherquest3_12.Image = Nothing
        ElseIf valu_tgherquest3_12.Value = 1 Then
            Icon_tgherquest3_12.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_12.Value = 4 Then
            Icon_tgherquest3_12.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_13_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_13.Click
        If valu_tgherquest3_13.Value = 0 Then
            valu_tgherquest3_13.Value = 1
        ElseIf valu_tgherquest3_13.Value = 1 Then
            valu_tgherquest3_13.Value = 4
        ElseIf valu_tgherquest3_13.Value = 4 Then
            valu_tgherquest3_13.Value = 0
        Else
            valu_tgherquest3_13.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_13.ValueChanged
        If valu_tgherquest3_13.Value = 0 Then
            Icon_tgherquest3_13.Image = Nothing
        ElseIf valu_tgherquest3_13.Value = 1 Then
            Icon_tgherquest3_13.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_13.Value = 4 Then
            Icon_tgherquest3_13.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_14_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_14.Click
        If valu_tgherquest3_14.Value = 0 Then
            valu_tgherquest3_14.Value = 1
        ElseIf valu_tgherquest3_14.Value = 1 Then
            valu_tgherquest3_14.Value = 4
        ElseIf valu_tgherquest3_14.Value = 4 Then
            valu_tgherquest3_14.Value = 0
        Else
            valu_tgherquest3_14.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_14.ValueChanged
        If valu_tgherquest3_14.Value = 0 Then
            Icon_tgherquest3_14.Image = Nothing
        ElseIf valu_tgherquest3_14.Value = 1 Then
            Icon_tgherquest3_14.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_14.Value = 4 Then
            Icon_tgherquest3_14.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_15_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_15.Click
        If valu_tgherquest3_15.Value = 0 Then
            valu_tgherquest3_15.Value = 1
        ElseIf valu_tgherquest3_15.Value = 1 Then
            valu_tgherquest3_15.Value = 4
        ElseIf valu_tgherquest3_15.Value = 4 Then
            valu_tgherquest3_15.Value = 0
        Else
            valu_tgherquest3_15.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_15.ValueChanged
        If valu_tgherquest3_15.Value = 0 Then
            Icon_tgherquest3_15.Image = Nothing
        ElseIf valu_tgherquest3_15.Value = 1 Then
            Icon_tgherquest3_15.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_15.Value = 4 Then
            Icon_tgherquest3_15.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_tgherquest3_16_Click(sender As Object, e As EventArgs) Handles Icon_tgherquest3_16.Click
        If valu_tgherquest3_16.Value = 0 Then
            valu_tgherquest3_16.Value = 1
        ElseIf valu_tgherquest3_16.Value = 1 Then
            valu_tgherquest3_16.Value = 4
        ElseIf valu_tgherquest3_16.Value = 4 Then
            valu_tgherquest3_16.Value = 0
        Else
            valu_tgherquest3_16.Value = 0
        End If
    End Sub

    Private Sub valu_tgherquest3_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_tgherquest3_16.ValueChanged
        If valu_tgherquest3_16.Value = 0 Then
            Icon_tgherquest3_16.Image = Nothing
        ElseIf valu_tgherquest3_16.Value = 1 Then
            Icon_tgherquest3_16.Image = My.Resources.icon_medal_act2
        ElseIf valu_tgherquest3_16.Value = 4 Then
            Icon_tgherquest3_16.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_playlevel_1_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_1.Click
        If valu_playlevel_1.Value = 0 Then
            valu_playlevel_1.Value = 1
        ElseIf valu_playlevel_1.Value = 1 Then
            valu_playlevel_1.Value = 4
        ElseIf valu_playlevel_1.Value = 4 Then
            valu_playlevel_1.Value = 0
        Else
            valu_playlevel_1.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_1.ValueChanged
        If valu_playlevel_1.Value = 0 Then
            Icon_playlevel_1.Image = Nothing
        ElseIf valu_playlevel_1.Value = 1 Then
            Icon_playlevel_1.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_1.Value = 4 Then
            Icon_playlevel_1.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_2_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_2.Click
        If valu_playlevel_2.Value = 0 Then
            valu_playlevel_2.Value = 1
        ElseIf valu_playlevel_2.Value = 1 Then
            valu_playlevel_2.Value = 4
        ElseIf valu_playlevel_2.Value = 4 Then
            valu_playlevel_2.Value = 0
        Else
            valu_playlevel_2.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_2.ValueChanged
        If valu_playlevel_2.Value = 0 Then
            Icon_playlevel_2.Image = Nothing
        ElseIf valu_playlevel_2.Value = 1 Then
            Icon_playlevel_2.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_2.Value = 4 Then
            Icon_playlevel_2.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_3_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_3.Click
        If valu_playlevel_3.Value = 0 Then
            valu_playlevel_3.Value = 1
        ElseIf valu_playlevel_3.Value = 1 Then
            valu_playlevel_3.Value = 4
        ElseIf valu_playlevel_3.Value = 4 Then
            valu_playlevel_3.Value = 0
        Else
            valu_playlevel_3.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_3.ValueChanged
        If valu_playlevel_3.Value = 0 Then
            Icon_playlevel_3.Image = Nothing
        ElseIf valu_playlevel_3.Value = 1 Then
            Icon_playlevel_3.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_3.Value = 4 Then
            Icon_playlevel_3.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_4_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_4.Click
        If valu_playlevel_4.Value = 0 Then
            valu_playlevel_4.Value = 1
        ElseIf valu_playlevel_4.Value = 1 Then
            valu_playlevel_4.Value = 4
        ElseIf valu_playlevel_4.Value = 4 Then
            valu_playlevel_4.Value = 0
        Else
            valu_playlevel_4.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_4.ValueChanged
        If valu_playlevel_4.Value = 0 Then
            Icon_playlevel_4.Image = Nothing
        ElseIf valu_playlevel_4.Value = 1 Then
            Icon_playlevel_4.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_4.Value = 4 Then
            Icon_playlevel_4.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_5_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_5.Click
        If valu_playlevel_5.Value = 0 Then
            valu_playlevel_5.Value = 1
        ElseIf valu_playlevel_5.Value = 1 Then
            valu_playlevel_5.Value = 4
        ElseIf valu_playlevel_5.Value = 4 Then
            valu_playlevel_5.Value = 0
        Else
            valu_playlevel_5.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_5.ValueChanged
        If valu_playlevel_5.Value = 0 Then
            Icon_playlevel_5.Image = Nothing
        ElseIf valu_playlevel_5.Value = 1 Then
            Icon_playlevel_5.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_5.Value = 4 Then
            Icon_playlevel_5.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_6_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_6.Click
        If valu_playlevel_6.Value = 0 Then
            valu_playlevel_6.Value = 1
        ElseIf valu_playlevel_6.Value = 1 Then
            valu_playlevel_6.Value = 4
        ElseIf valu_playlevel_6.Value = 4 Then
            valu_playlevel_6.Value = 0
        Else
            valu_playlevel_6.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_6.ValueChanged
        If valu_playlevel_6.Value = 0 Then
            Icon_playlevel_6.Image = Nothing
        ElseIf valu_playlevel_6.Value = 1 Then
            Icon_playlevel_6.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_6.Value = 4 Then
            Icon_playlevel_6.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_7_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_7.Click
        If valu_playlevel_7.Value = 0 Then
            valu_playlevel_7.Value = 1
        ElseIf valu_playlevel_7.Value = 1 Then
            valu_playlevel_7.Value = 4
        ElseIf valu_playlevel_7.Value = 4 Then
            valu_playlevel_7.Value = 0
        Else
            valu_playlevel_7.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_7.ValueChanged
        If valu_playlevel_7.Value = 0 Then
            Icon_playlevel_7.Image = Nothing
        ElseIf valu_playlevel_7.Value = 1 Then
            Icon_playlevel_7.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_7.Value = 4 Then
            Icon_playlevel_7.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_8_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_8.Click
        If valu_playlevel_8.Value = 0 Then
            valu_playlevel_8.Value = 1
        ElseIf valu_playlevel_8.Value = 1 Then
            valu_playlevel_8.Value = 4
        ElseIf valu_playlevel_8.Value = 4 Then
            valu_playlevel_8.Value = 0
        Else
            valu_playlevel_8.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_8.ValueChanged
        If valu_playlevel_8.Value = 0 Then
            Icon_playlevel_8.Image = Nothing
        ElseIf valu_playlevel_8.Value = 1 Then
            Icon_playlevel_8.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_8.Value = 4 Then
            Icon_playlevel_8.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_9_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_9.Click
        If valu_playlevel_9.Value = 0 Then
            valu_playlevel_9.Value = 1
        ElseIf valu_playlevel_9.Value = 1 Then
            valu_playlevel_9.Value = 4
        ElseIf valu_playlevel_9.Value = 4 Then
            valu_playlevel_9.Value = 0
        Else
            valu_playlevel_9.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_9.ValueChanged
        If valu_playlevel_9.Value = 0 Then
            Icon_playlevel_9.Image = Nothing
        ElseIf valu_playlevel_9.Value = 1 Then
            Icon_playlevel_9.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_9.Value = 4 Then
            Icon_playlevel_9.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_10_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_10.Click
        If valu_playlevel_10.Value = 0 Then
            valu_playlevel_10.Value = 1
        ElseIf valu_playlevel_10.Value = 1 Then
            valu_playlevel_10.Value = 4
        ElseIf valu_playlevel_10.Value = 4 Then
            valu_playlevel_10.Value = 0
        Else
            valu_playlevel_10.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_10.ValueChanged
        If valu_playlevel_10.Value = 0 Then
            Icon_playlevel_10.Image = Nothing
        ElseIf valu_playlevel_10.Value = 1 Then
            Icon_playlevel_10.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_10.Value = 4 Then
            Icon_playlevel_10.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_11_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_11.Click
        If valu_playlevel_11.Value = 0 Then
            valu_playlevel_11.Value = 1
        ElseIf valu_playlevel_11.Value = 1 Then
            valu_playlevel_11.Value = 4
        ElseIf valu_playlevel_11.Value = 4 Then
            valu_playlevel_11.Value = 0
        Else
            valu_playlevel_11.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_11.ValueChanged
        If valu_playlevel_11.Value = 0 Then
            Icon_playlevel_11.Image = Nothing
        ElseIf valu_playlevel_11.Value = 1 Then
            Icon_playlevel_11.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_11.Value = 4 Then
            Icon_playlevel_11.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_12_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_12.Click
        If valu_playlevel_12.Value = 0 Then
            valu_playlevel_12.Value = 1
        ElseIf valu_playlevel_12.Value = 1 Then
            valu_playlevel_12.Value = 4
        ElseIf valu_playlevel_12.Value = 4 Then
            valu_playlevel_12.Value = 0
        Else
            valu_playlevel_12.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_12.ValueChanged
        If valu_playlevel_12.Value = 0 Then
            Icon_playlevel_12.Image = Nothing
        ElseIf valu_playlevel_12.Value = 1 Then
            Icon_playlevel_12.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_12.Value = 4 Then
            Icon_playlevel_12.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_13_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_13.Click
        If valu_playlevel_13.Value = 0 Then
            valu_playlevel_13.Value = 1
        ElseIf valu_playlevel_13.Value = 1 Then
            valu_playlevel_13.Value = 4
        ElseIf valu_playlevel_13.Value = 4 Then
            valu_playlevel_13.Value = 0
        Else
            valu_playlevel_13.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_13.ValueChanged
        If valu_playlevel_13.Value = 0 Then
            Icon_playlevel_13.Image = Nothing
        ElseIf valu_playlevel_13.Value = 1 Then
            Icon_playlevel_13.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_13.Value = 4 Then
            Icon_playlevel_13.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_14_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_14.Click
        If valu_playlevel_14.Value = 0 Then
            valu_playlevel_14.Value = 1
        ElseIf valu_playlevel_14.Value = 1 Then
            valu_playlevel_14.Value = 4
        ElseIf valu_playlevel_14.Value = 4 Then
            valu_playlevel_14.Value = 0
        Else
            valu_playlevel_14.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_14.ValueChanged
        If valu_playlevel_14.Value = 0 Then
            Icon_playlevel_14.Image = Nothing
        ElseIf valu_playlevel_14.Value = 1 Then
            Icon_playlevel_14.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_14.Value = 4 Then
            Icon_playlevel_14.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_15_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_15.Click
        If valu_playlevel_15.Value = 0 Then
            valu_playlevel_15.Value = 1
        ElseIf valu_playlevel_15.Value = 1 Then
            valu_playlevel_15.Value = 4
        ElseIf valu_playlevel_15.Value = 4 Then
            valu_playlevel_15.Value = 0
        Else
            valu_playlevel_15.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_15.ValueChanged
        If valu_playlevel_15.Value = 0 Then
            Icon_playlevel_15.Image = Nothing
        ElseIf valu_playlevel_15.Value = 1 Then
            Icon_playlevel_15.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_15.Value = 4 Then
            Icon_playlevel_15.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_16_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_16.Click
        If valu_playlevel_16.Value = 0 Then
            valu_playlevel_16.Value = 1
        ElseIf valu_playlevel_16.Value = 1 Then
            valu_playlevel_16.Value = 4
        ElseIf valu_playlevel_16.Value = 4 Then
            valu_playlevel_16.Value = 0
        Else
            valu_playlevel_16.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_16.ValueChanged
        If valu_playlevel_16.Value = 0 Then
            Icon_playlevel_16.Image = Nothing
        ElseIf valu_playlevel_16.Value = 1 Then
            Icon_playlevel_16.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_16.Value = 4 Then
            Icon_playlevel_16.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_17_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_17.Click
        If valu_playlevel_17.Value = 0 Then
            valu_playlevel_17.Value = 1
        ElseIf valu_playlevel_17.Value = 1 Then
            valu_playlevel_17.Value = 4
        ElseIf valu_playlevel_17.Value = 4 Then
            valu_playlevel_17.Value = 0
        Else
            valu_playlevel_17.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_17.ValueChanged
        If valu_playlevel_17.Value = 0 Then
            Icon_playlevel_17.Image = Nothing
        ElseIf valu_playlevel_17.Value = 1 Then
            Icon_playlevel_17.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_17.Value = 4 Then
            Icon_playlevel_17.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_18_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_18.Click
        If valu_playlevel_18.Value = 0 Then
            valu_playlevel_18.Value = 1
        ElseIf valu_playlevel_18.Value = 1 Then
            valu_playlevel_18.Value = 4
        ElseIf valu_playlevel_18.Value = 4 Then
            valu_playlevel_18.Value = 0
        Else
            valu_playlevel_18.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_18.ValueChanged
        If valu_playlevel_18.Value = 0 Then
            Icon_playlevel_18.Image = Nothing
        ElseIf valu_playlevel_18.Value = 1 Then
            Icon_playlevel_18.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_18.Value = 4 Then
            Icon_playlevel_18.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_19_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_19.Click
        If valu_playlevel_19.Value = 0 Then
            valu_playlevel_19.Value = 1
        ElseIf valu_playlevel_19.Value = 1 Then
            valu_playlevel_19.Value = 4
        ElseIf valu_playlevel_19.Value = 4 Then
            valu_playlevel_19.Value = 0
        Else
            valu_playlevel_19.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_19.ValueChanged
        If valu_playlevel_19.Value = 0 Then
            Icon_playlevel_19.Image = Nothing
        ElseIf valu_playlevel_19.Value = 1 Then
            Icon_playlevel_19.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_19.Value = 4 Then
            Icon_playlevel_19.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_playlevel_20_Click(sender As Object, e As EventArgs) Handles Icon_playlevel_20.Click
        If valu_playlevel_20.Value = 0 Then
            valu_playlevel_20.Value = 1
        ElseIf valu_playlevel_20.Value = 1 Then
            valu_playlevel_20.Value = 4
        ElseIf valu_playlevel_20.Value = 4 Then
            valu_playlevel_20.Value = 0
        Else
            valu_playlevel_20.Value = 0
        End If
    End Sub

    Private Sub valu_playlevel_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_playlevel_20.ValueChanged
        If valu_playlevel_20.Value = 0 Then
            Icon_playlevel_20.Image = Nothing
        ElseIf valu_playlevel_20.Value = 1 Then
            Icon_playlevel_20.Image = My.Resources.icon_medal_act1
        ElseIf valu_playlevel_20.Value = 4 Then
            Icon_playlevel_20.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_1_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_1.Click
        If valu_shoppe_1.Value = 0 Then
            valu_shoppe_1.Value = 1
        ElseIf valu_shoppe_1.Value = 1 Then
            valu_shoppe_1.Value = 4
        ElseIf valu_shoppe_1.Value = 4 Then
            valu_shoppe_1.Value = 0
        Else
            valu_shoppe_1.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_1.ValueChanged
        If valu_shoppe_1.Value = 0 Then
            Icon_shoppe_1.Image = Nothing
        ElseIf valu_shoppe_1.Value = 1 Then
            Icon_shoppe_1.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_1.Value = 4 Then
            Icon_shoppe_1.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_2_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_2.Click
        If valu_shoppe_2.Value = 0 Then
            valu_shoppe_2.Value = 1
        ElseIf valu_shoppe_2.Value = 1 Then
            valu_shoppe_2.Value = 4
        ElseIf valu_shoppe_2.Value = 4 Then
            valu_shoppe_2.Value = 0
        Else
            valu_shoppe_2.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_2.ValueChanged
        If valu_shoppe_2.Value = 0 Then
            Icon_shoppe_2.Image = Nothing
        ElseIf valu_shoppe_2.Value = 1 Then
            Icon_shoppe_2.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_2.Value = 4 Then
            Icon_shoppe_2.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_3_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_3.Click
        If valu_shoppe_3.Value = 0 Then
            valu_shoppe_3.Value = 1
        ElseIf valu_shoppe_3.Value = 1 Then
            valu_shoppe_3.Value = 4
        ElseIf valu_shoppe_3.Value = 4 Then
            valu_shoppe_3.Value = 0
        Else
            valu_shoppe_3.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_3.ValueChanged
        If valu_shoppe_3.Value = 0 Then
            Icon_shoppe_3.Image = Nothing
        ElseIf valu_shoppe_3.Value = 1 Then
            Icon_shoppe_3.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_3.Value = 4 Then
            Icon_shoppe_3.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_4_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_4.Click
        If valu_shoppe_4.Value = 0 Then
            valu_shoppe_4.Value = 1
        ElseIf valu_shoppe_4.Value = 1 Then
            valu_shoppe_4.Value = 4
        ElseIf valu_shoppe_4.Value = 4 Then
            valu_shoppe_4.Value = 0
        Else
            valu_shoppe_4.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_4.ValueChanged
        If valu_shoppe_4.Value = 0 Then
            Icon_shoppe_4.Image = Nothing
        ElseIf valu_shoppe_4.Value = 1 Then
            Icon_shoppe_4.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_4.Value = 4 Then
            Icon_shoppe_4.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_5_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_5.Click
        If valu_shoppe_5.Value = 0 Then
            valu_shoppe_5.Value = 1
        ElseIf valu_shoppe_5.Value = 1 Then
            valu_shoppe_5.Value = 4
        ElseIf valu_shoppe_5.Value = 4 Then
            valu_shoppe_5.Value = 0
        Else
            valu_shoppe_5.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_5.ValueChanged
        If valu_shoppe_5.Value = 0 Then
            Icon_shoppe_5.Image = Nothing
        ElseIf valu_shoppe_5.Value = 1 Then
            Icon_shoppe_5.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_5.Value = 4 Then
            Icon_shoppe_5.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_6_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_6.Click
        If valu_shoppe_6.Value = 0 Then
            valu_shoppe_6.Value = 1
        ElseIf valu_shoppe_6.Value = 1 Then
            valu_shoppe_6.Value = 4
        ElseIf valu_shoppe_6.Value = 4 Then
            valu_shoppe_6.Value = 0
        Else
            valu_shoppe_6.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_6.ValueChanged
        If valu_shoppe_6.Value = 0 Then
            Icon_shoppe_6.Image = Nothing
        ElseIf valu_shoppe_6.Value = 1 Then
            Icon_shoppe_6.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_6.Value = 4 Then
            Icon_shoppe_6.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_7_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_7.Click
        If valu_shoppe_7.Value = 0 Then
            valu_shoppe_7.Value = 1
        ElseIf valu_shoppe_7.Value = 1 Then
            valu_shoppe_7.Value = 4
        ElseIf valu_shoppe_7.Value = 4 Then
            valu_shoppe_7.Value = 0
        Else
            valu_shoppe_7.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_7.ValueChanged
        If valu_shoppe_7.Value = 0 Then
            Icon_shoppe_7.Image = Nothing
        ElseIf valu_shoppe_7.Value = 1 Then
            Icon_shoppe_7.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_7.Value = 4 Then
            Icon_shoppe_7.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_8_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_8.Click
        If valu_shoppe_8.Value = 0 Then
            valu_shoppe_8.Value = 1
        ElseIf valu_shoppe_8.Value = 1 Then
            valu_shoppe_8.Value = 4
        ElseIf valu_shoppe_8.Value = 4 Then
            valu_shoppe_8.Value = 0
        Else
            valu_shoppe_8.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_8.ValueChanged
        If valu_shoppe_8.Value = 0 Then
            Icon_shoppe_8.Image = Nothing
        ElseIf valu_shoppe_8.Value = 1 Then
            Icon_shoppe_8.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_8.Value = 4 Then
            Icon_shoppe_8.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_9_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_9.Click
        If valu_shoppe_9.Value = 0 Then
            valu_shoppe_9.Value = 1
        ElseIf valu_shoppe_9.Value = 1 Then
            valu_shoppe_9.Value = 4
        ElseIf valu_shoppe_9.Value = 4 Then
            valu_shoppe_9.Value = 0
        Else
            valu_shoppe_9.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_9.ValueChanged
        If valu_shoppe_9.Value = 0 Then
            Icon_shoppe_9.Image = Nothing
        ElseIf valu_shoppe_9.Value = 1 Then
            Icon_shoppe_9.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_9.Value = 4 Then
            Icon_shoppe_9.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_10_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_10.Click
        If valu_shoppe_10.Value = 0 Then
            valu_shoppe_10.Value = 1
        ElseIf valu_shoppe_10.Value = 1 Then
            valu_shoppe_10.Value = 4
        ElseIf valu_shoppe_10.Value = 4 Then
            valu_shoppe_10.Value = 0
        Else
            valu_shoppe_10.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_10.ValueChanged
        If valu_shoppe_10.Value = 0 Then
            Icon_shoppe_10.Image = Nothing
        ElseIf valu_shoppe_10.Value = 1 Then
            Icon_shoppe_10.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_10.Value = 4 Then
            Icon_shoppe_10.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_11_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_11.Click
        If valu_shoppe_11.Value = 0 Then
            valu_shoppe_11.Value = 1
        ElseIf valu_shoppe_11.Value = 1 Then
            valu_shoppe_11.Value = 4
        ElseIf valu_shoppe_11.Value = 4 Then
            valu_shoppe_11.Value = 0
        Else
            valu_shoppe_11.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_11.ValueChanged
        If valu_shoppe_11.Value = 0 Then
            Icon_shoppe_11.Image = Nothing
        ElseIf valu_shoppe_11.Value = 1 Then
            Icon_shoppe_11.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_11.Value = 4 Then
            Icon_shoppe_11.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_12_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_12.Click
        If valu_shoppe_12.Value = 0 Then
            valu_shoppe_12.Value = 1
        ElseIf valu_shoppe_12.Value = 1 Then
            valu_shoppe_12.Value = 4
        ElseIf valu_shoppe_12.Value = 4 Then
            valu_shoppe_12.Value = 0
        Else
            valu_shoppe_12.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_12.ValueChanged
        If valu_shoppe_12.Value = 0 Then
            Icon_shoppe_12.Image = Nothing
        ElseIf valu_shoppe_12.Value = 1 Then
            Icon_shoppe_12.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_12.Value = 4 Then
            Icon_shoppe_12.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_13_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_13.Click
        If valu_shoppe_13.Value = 0 Then
            valu_shoppe_13.Value = 1
        ElseIf valu_shoppe_13.Value = 1 Then
            valu_shoppe_13.Value = 4
        ElseIf valu_shoppe_13.Value = 4 Then
            valu_shoppe_13.Value = 0
        Else
            valu_shoppe_13.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_13.ValueChanged
        If valu_shoppe_13.Value = 0 Then
            Icon_shoppe_13.Image = Nothing
        ElseIf valu_shoppe_13.Value = 1 Then
            Icon_shoppe_13.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_13.Value = 4 Then
            Icon_shoppe_13.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_14_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_14.Click
        If valu_shoppe_14.Value = 0 Then
            valu_shoppe_14.Value = 1
        ElseIf valu_shoppe_14.Value = 1 Then
            valu_shoppe_14.Value = 4
        ElseIf valu_shoppe_14.Value = 4 Then
            valu_shoppe_14.Value = 0
        Else
            valu_shoppe_14.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_14.ValueChanged
        If valu_shoppe_14.Value = 0 Then
            Icon_shoppe_14.Image = Nothing
        ElseIf valu_shoppe_14.Value = 1 Then
            Icon_shoppe_14.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_14.Value = 4 Then
            Icon_shoppe_14.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_15_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_15.Click
        If valu_shoppe_15.Value = 0 Then
            valu_shoppe_15.Value = 1
        ElseIf valu_shoppe_15.Value = 1 Then
            valu_shoppe_15.Value = 4
        ElseIf valu_shoppe_15.Value = 4 Then
            valu_shoppe_15.Value = 0
        Else
            valu_shoppe_15.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_15.ValueChanged
        If valu_shoppe_15.Value = 0 Then
            Icon_shoppe_15.Image = Nothing
        ElseIf valu_shoppe_15.Value = 1 Then
            Icon_shoppe_15.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_15.Value = 4 Then
            Icon_shoppe_15.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_16_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_16.Click
        If valu_shoppe_16.Value = 0 Then
            valu_shoppe_16.Value = 1
        ElseIf valu_shoppe_16.Value = 1 Then
            valu_shoppe_16.Value = 4
        ElseIf valu_shoppe_16.Value = 4 Then
            valu_shoppe_16.Value = 0
        Else
            valu_shoppe_16.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_16.ValueChanged
        If valu_shoppe_16.Value = 0 Then
            Icon_shoppe_16.Image = Nothing
        ElseIf valu_shoppe_16.Value = 1 Then
            Icon_shoppe_16.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_16.Value = 4 Then
            Icon_shoppe_16.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_17_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_17.Click
        If valu_shoppe_17.Value = 0 Then
            valu_shoppe_17.Value = 1
        ElseIf valu_shoppe_17.Value = 1 Then
            valu_shoppe_17.Value = 4
        ElseIf valu_shoppe_17.Value = 4 Then
            valu_shoppe_17.Value = 0
        Else
            valu_shoppe_17.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_17.ValueChanged
        If valu_shoppe_17.Value = 0 Then
            Icon_shoppe_17.Image = Nothing
        ElseIf valu_shoppe_17.Value = 1 Then
            Icon_shoppe_17.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_17.Value = 4 Then
            Icon_shoppe_17.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_18_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_18.Click
        If valu_shoppe_18.Value = 0 Then
            valu_shoppe_18.Value = 1
        ElseIf valu_shoppe_18.Value = 1 Then
            valu_shoppe_18.Value = 4
        ElseIf valu_shoppe_18.Value = 4 Then
            valu_shoppe_18.Value = 0
        Else
            valu_shoppe_18.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_18.ValueChanged
        If valu_shoppe_18.Value = 0 Then
            Icon_shoppe_18.Image = Nothing
        ElseIf valu_shoppe_18.Value = 1 Then
            Icon_shoppe_18.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_18.Value = 4 Then
            Icon_shoppe_18.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_19_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_19.Click
        If valu_shoppe_19.Value = 0 Then
            valu_shoppe_19.Value = 1
        ElseIf valu_shoppe_19.Value = 1 Then
            valu_shoppe_19.Value = 4
        ElseIf valu_shoppe_19.Value = 4 Then
            valu_shoppe_19.Value = 0
        Else
            valu_shoppe_19.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_19.ValueChanged
        If valu_shoppe_19.Value = 0 Then
            Icon_shoppe_19.Image = Nothing
        ElseIf valu_shoppe_19.Value = 1 Then
            Icon_shoppe_19.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_19.Value = 4 Then
            Icon_shoppe_19.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_shoppe_20_Click(sender As Object, e As EventArgs) Handles Icon_shoppe_20.Click
        If valu_shoppe_20.Value = 0 Then
            valu_shoppe_20.Value = 1
        ElseIf valu_shoppe_20.Value = 1 Then
            valu_shoppe_20.Value = 4
        ElseIf valu_shoppe_20.Value = 4 Then
            valu_shoppe_20.Value = 0
        Else
            valu_shoppe_20.Value = 0
        End If
    End Sub

    Private Sub valu_shoppe_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_shoppe_20.ValueChanged
        If valu_shoppe_20.Value = 0 Then
            Icon_shoppe_20.Image = Nothing
        ElseIf valu_shoppe_20.Value = 1 Then
            Icon_shoppe_20.Image = My.Resources.icon_medal_act1
        ElseIf valu_shoppe_20.Value = 4 Then
            Icon_shoppe_20.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_1_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_1.Click
        If valu_moremissions1_1.Value = 0 Then
            valu_moremissions1_1.Value = 1
        ElseIf valu_moremissions1_1.Value = 1 Then
            valu_moremissions1_1.Value = 4
        ElseIf valu_moremissions1_1.Value = 4 Then
            valu_moremissions1_1.Value = 0
        Else
            valu_moremissions1_1.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_1.ValueChanged
        If valu_moremissions1_1.Value = 0 Then
            Icon_moremissions1_1.Image = Nothing
        ElseIf valu_moremissions1_1.Value = 1 Then
            Icon_moremissions1_1.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_1.Value = 4 Then
            Icon_moremissions1_1.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_2_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_2.Click
        If valu_moremissions1_2.Value = 0 Then
            valu_moremissions1_2.Value = 1
        ElseIf valu_moremissions1_2.Value = 1 Then
            valu_moremissions1_2.Value = 4
        ElseIf valu_moremissions1_2.Value = 4 Then
            valu_moremissions1_2.Value = 0
        Else
            valu_moremissions1_2.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_2.ValueChanged
        If valu_moremissions1_2.Value = 0 Then
            Icon_moremissions1_2.Image = Nothing
        ElseIf valu_moremissions1_2.Value = 1 Then
            Icon_moremissions1_2.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_2.Value = 4 Then
            Icon_moremissions1_2.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_3_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_3.Click
        If valu_moremissions1_3.Value = 0 Then
            valu_moremissions1_3.Value = 1
        ElseIf valu_moremissions1_3.Value = 1 Then
            valu_moremissions1_3.Value = 4
        ElseIf valu_moremissions1_3.Value = 4 Then
            valu_moremissions1_3.Value = 0
        Else
            valu_moremissions1_3.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_3.ValueChanged
        If valu_moremissions1_3.Value = 0 Then
            Icon_moremissions1_3.Image = Nothing
        ElseIf valu_moremissions1_3.Value = 1 Then
            Icon_moremissions1_3.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_3.Value = 4 Then
            Icon_moremissions1_3.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_4_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_4.Click
        If valu_moremissions1_4.Value = 0 Then
            valu_moremissions1_4.Value = 1
        ElseIf valu_moremissions1_4.Value = 1 Then
            valu_moremissions1_4.Value = 4
        ElseIf valu_moremissions1_4.Value = 4 Then
            valu_moremissions1_4.Value = 0
        Else
            valu_moremissions1_4.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_4.ValueChanged
        If valu_moremissions1_4.Value = 0 Then
            Icon_moremissions1_4.Image = Nothing
        ElseIf valu_moremissions1_4.Value = 1 Then
            Icon_moremissions1_4.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_4.Value = 4 Then
            Icon_moremissions1_4.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_5_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_5.Click
        If valu_moremissions1_5.Value = 0 Then
            valu_moremissions1_5.Value = 1
        ElseIf valu_moremissions1_5.Value = 1 Then
            valu_moremissions1_5.Value = 4
        ElseIf valu_moremissions1_5.Value = 4 Then
            valu_moremissions1_5.Value = 0
        Else
            valu_moremissions1_5.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_5.ValueChanged
        If valu_moremissions1_5.Value = 0 Then
            Icon_moremissions1_5.Image = Nothing
        ElseIf valu_moremissions1_5.Value = 1 Then
            Icon_moremissions1_5.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_5.Value = 4 Then
            Icon_moremissions1_5.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_6_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_6.Click
        If valu_moremissions1_6.Value = 0 Then
            valu_moremissions1_6.Value = 1
        ElseIf valu_moremissions1_6.Value = 1 Then
            valu_moremissions1_6.Value = 4
        ElseIf valu_moremissions1_6.Value = 4 Then
            valu_moremissions1_6.Value = 0
        Else
            valu_moremissions1_6.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_6.ValueChanged
        If valu_moremissions1_6.Value = 0 Then
            Icon_moremissions1_6.Image = Nothing
        ElseIf valu_moremissions1_6.Value = 1 Then
            Icon_moremissions1_6.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_6.Value = 4 Then
            Icon_moremissions1_6.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_7_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_7.Click
        If valu_moremissions1_7.Value = 0 Then
            valu_moremissions1_7.Value = 1
        ElseIf valu_moremissions1_7.Value = 1 Then
            valu_moremissions1_7.Value = 4
        ElseIf valu_moremissions1_7.Value = 4 Then
            valu_moremissions1_7.Value = 0
        Else
            valu_moremissions1_7.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_7.ValueChanged
        If valu_moremissions1_7.Value = 0 Then
            Icon_moremissions1_7.Image = Nothing
        ElseIf valu_moremissions1_7.Value = 1 Then
            Icon_moremissions1_7.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_7.Value = 4 Then
            Icon_moremissions1_7.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_8_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_8.Click
        If valu_moremissions1_8.Value = 0 Then
            valu_moremissions1_8.Value = 1
        ElseIf valu_moremissions1_8.Value = 1 Then
            valu_moremissions1_8.Value = 4
        ElseIf valu_moremissions1_8.Value = 4 Then
            valu_moremissions1_8.Value = 0
        Else
            valu_moremissions1_8.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_8.ValueChanged
        If valu_moremissions1_8.Value = 0 Then
            Icon_moremissions1_8.Image = Nothing
        ElseIf valu_moremissions1_8.Value = 1 Then
            Icon_moremissions1_8.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_8.Value = 4 Then
            Icon_moremissions1_8.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_9_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_9.Click
        If valu_moremissions1_9.Value = 0 Then
            valu_moremissions1_9.Value = 1
        ElseIf valu_moremissions1_9.Value = 1 Then
            valu_moremissions1_9.Value = 4
        ElseIf valu_moremissions1_9.Value = 4 Then
            valu_moremissions1_9.Value = 0
        Else
            valu_moremissions1_9.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_9.ValueChanged
        If valu_moremissions1_9.Value = 0 Then
            Icon_moremissions1_9.Image = Nothing
        ElseIf valu_moremissions1_9.Value = 1 Then
            Icon_moremissions1_9.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_9.Value = 4 Then
            Icon_moremissions1_9.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_10_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_10.Click
        If valu_moremissions1_10.Value = 0 Then
            valu_moremissions1_10.Value = 1
        ElseIf valu_moremissions1_10.Value = 1 Then
            valu_moremissions1_10.Value = 4
        ElseIf valu_moremissions1_10.Value = 4 Then
            valu_moremissions1_10.Value = 0
        Else
            valu_moremissions1_10.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_10.ValueChanged
        If valu_moremissions1_10.Value = 0 Then
            Icon_moremissions1_10.Image = Nothing
        ElseIf valu_moremissions1_10.Value = 1 Then
            Icon_moremissions1_10.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_10.Value = 4 Then
            Icon_moremissions1_10.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_11_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_11.Click
        If valu_moremissions1_11.Value = 0 Then
            valu_moremissions1_11.Value = 1
        ElseIf valu_moremissions1_11.Value = 1 Then
            valu_moremissions1_11.Value = 4
        ElseIf valu_moremissions1_11.Value = 4 Then
            valu_moremissions1_11.Value = 0
        Else
            valu_moremissions1_11.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_11.ValueChanged
        If valu_moremissions1_11.Value = 0 Then
            Icon_moremissions1_11.Image = Nothing
        ElseIf valu_moremissions1_11.Value = 1 Then
            Icon_moremissions1_11.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_11.Value = 4 Then
            Icon_moremissions1_11.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_12_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_12.Click
        If valu_moremissions1_12.Value = 0 Then
            valu_moremissions1_12.Value = 1
        ElseIf valu_moremissions1_12.Value = 1 Then
            valu_moremissions1_12.Value = 4
        ElseIf valu_moremissions1_12.Value = 4 Then
            valu_moremissions1_12.Value = 0
        Else
            valu_moremissions1_12.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_12.ValueChanged
        If valu_moremissions1_12.Value = 0 Then
            Icon_moremissions1_12.Image = Nothing
        ElseIf valu_moremissions1_12.Value = 1 Then
            Icon_moremissions1_12.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_12.Value = 4 Then
            Icon_moremissions1_12.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_13_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_13.Click
        If valu_moremissions1_13.Value = 0 Then
            valu_moremissions1_13.Value = 1
        ElseIf valu_moremissions1_13.Value = 1 Then
            valu_moremissions1_13.Value = 4
        ElseIf valu_moremissions1_13.Value = 4 Then
            valu_moremissions1_13.Value = 0
        Else
            valu_moremissions1_13.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_13.ValueChanged
        If valu_moremissions1_13.Value = 0 Then
            Icon_moremissions1_13.Image = Nothing
        ElseIf valu_moremissions1_13.Value = 1 Then
            Icon_moremissions1_13.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_13.Value = 4 Then
            Icon_moremissions1_13.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_14_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_14.Click
        If valu_moremissions1_14.Value = 0 Then
            valu_moremissions1_14.Value = 1
        ElseIf valu_moremissions1_14.Value = 1 Then
            valu_moremissions1_14.Value = 4
        ElseIf valu_moremissions1_14.Value = 4 Then
            valu_moremissions1_14.Value = 0
        Else
            valu_moremissions1_14.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_14.ValueChanged
        If valu_moremissions1_14.Value = 0 Then
            Icon_moremissions1_14.Image = Nothing
        ElseIf valu_moremissions1_14.Value = 1 Then
            Icon_moremissions1_14.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_14.Value = 4 Then
            Icon_moremissions1_14.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_15_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_15.Click
        If valu_moremissions1_15.Value = 0 Then
            valu_moremissions1_15.Value = 1
        ElseIf valu_moremissions1_15.Value = 1 Then
            valu_moremissions1_15.Value = 4
        ElseIf valu_moremissions1_15.Value = 4 Then
            valu_moremissions1_15.Value = 0
        Else
            valu_moremissions1_15.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_15.ValueChanged
        If valu_moremissions1_15.Value = 0 Then
            Icon_moremissions1_15.Image = Nothing
        ElseIf valu_moremissions1_15.Value = 1 Then
            Icon_moremissions1_15.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_15.Value = 4 Then
            Icon_moremissions1_15.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_16_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_16.Click
        If valu_moremissions1_16.Value = 0 Then
            valu_moremissions1_16.Value = 1
        ElseIf valu_moremissions1_16.Value = 1 Then
            valu_moremissions1_16.Value = 4
        ElseIf valu_moremissions1_16.Value = 4 Then
            valu_moremissions1_16.Value = 0
        Else
            valu_moremissions1_16.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_16.ValueChanged
        If valu_moremissions1_16.Value = 0 Then
            Icon_moremissions1_16.Image = Nothing
        ElseIf valu_moremissions1_16.Value = 1 Then
            Icon_moremissions1_16.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_16.Value = 4 Then
            Icon_moremissions1_16.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_17_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_17.Click
        If valu_moremissions1_17.Value = 0 Then
            valu_moremissions1_17.Value = 1
        ElseIf valu_moremissions1_17.Value = 1 Then
            valu_moremissions1_17.Value = 4
        ElseIf valu_moremissions1_17.Value = 4 Then
            valu_moremissions1_17.Value = 0
        Else
            valu_moremissions1_17.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_17.ValueChanged
        If valu_moremissions1_17.Value = 0 Then
            Icon_moremissions1_17.Image = Nothing
        ElseIf valu_moremissions1_17.Value = 1 Then
            Icon_moremissions1_17.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_17.Value = 4 Then
            Icon_moremissions1_17.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_18_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_18.Click
        If valu_moremissions1_18.Value = 0 Then
            valu_moremissions1_18.Value = 1
        ElseIf valu_moremissions1_18.Value = 1 Then
            valu_moremissions1_18.Value = 4
        ElseIf valu_moremissions1_18.Value = 4 Then
            valu_moremissions1_18.Value = 0
        Else
            valu_moremissions1_18.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_18.ValueChanged
        If valu_moremissions1_18.Value = 0 Then
            Icon_moremissions1_18.Image = Nothing
        ElseIf valu_moremissions1_18.Value = 1 Then
            Icon_moremissions1_18.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_18.Value = 4 Then
            Icon_moremissions1_18.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_19_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_19.Click
        If valu_moremissions1_19.Value = 0 Then
            valu_moremissions1_19.Value = 1
        ElseIf valu_moremissions1_19.Value = 1 Then
            valu_moremissions1_19.Value = 4
        ElseIf valu_moremissions1_19.Value = 4 Then
            valu_moremissions1_19.Value = 0
        Else
            valu_moremissions1_19.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_19.ValueChanged
        If valu_moremissions1_19.Value = 0 Then
            Icon_moremissions1_19.Image = Nothing
        ElseIf valu_moremissions1_19.Value = 1 Then
            Icon_moremissions1_19.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_19.Value = 4 Then
            Icon_moremissions1_19.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_20_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_20.Click
        If valu_moremissions1_20.Value = 0 Then
            valu_moremissions1_20.Value = 1
        ElseIf valu_moremissions1_20.Value = 1 Then
            valu_moremissions1_20.Value = 4
        ElseIf valu_moremissions1_20.Value = 4 Then
            valu_moremissions1_20.Value = 0
        Else
            valu_moremissions1_20.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_20.ValueChanged
        If valu_moremissions1_20.Value = 0 Then
            Icon_moremissions1_20.Image = Nothing
        ElseIf valu_moremissions1_20.Value = 1 Then
            Icon_moremissions1_20.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_20.Value = 4 Then
            Icon_moremissions1_20.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_21_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_21.Click
        If valu_moremissions1_21.Value = 0 Then
            valu_moremissions1_21.Value = 1
        ElseIf valu_moremissions1_21.Value = 1 Then
            valu_moremissions1_21.Value = 4
        ElseIf valu_moremissions1_21.Value = 4 Then
            valu_moremissions1_21.Value = 0
        Else
            valu_moremissions1_21.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_21_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_21.ValueChanged
        If valu_moremissions1_21.Value = 0 Then
            Icon_moremissions1_21.Image = Nothing
        ElseIf valu_moremissions1_21.Value = 1 Then
            Icon_moremissions1_21.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_21.Value = 4 Then
            Icon_moremissions1_21.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions1_22_Click(sender As Object, e As EventArgs) Handles Icon_moremissions1_22.Click
        If valu_moremissions1_22.Value = 0 Then
            valu_moremissions1_22.Value = 1
        ElseIf valu_moremissions1_22.Value = 1 Then
            valu_moremissions1_22.Value = 4
        ElseIf valu_moremissions1_22.Value = 4 Then
            valu_moremissions1_22.Value = 0
        Else
            valu_moremissions1_22.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions1_22_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions1_22.ValueChanged
        If valu_moremissions1_22.Value = 0 Then
            Icon_moremissions1_22.Image = Nothing
        ElseIf valu_moremissions1_22.Value = 1 Then
            Icon_moremissions1_22.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions1_22.Value = 4 Then
            Icon_moremissions1_22.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_1_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_1.Click
        If valu_moremissions2_1.Value = 0 Then
            valu_moremissions2_1.Value = 1
        ElseIf valu_moremissions2_1.Value = 1 Then
            valu_moremissions2_1.Value = 4
        ElseIf valu_moremissions2_1.Value = 4 Then
            valu_moremissions2_1.Value = 0
        Else
            valu_moremissions2_1.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_1.ValueChanged
        If valu_moremissions2_1.Value = 0 Then
            Icon_moremissions2_1.Image = Nothing
        ElseIf valu_moremissions2_1.Value = 1 Then
            Icon_moremissions2_1.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_1.Value = 4 Then
            Icon_moremissions2_1.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_2_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_2.Click
        If valu_moremissions2_2.Value = 0 Then
            valu_moremissions2_2.Value = 1
        ElseIf valu_moremissions2_2.Value = 1 Then
            valu_moremissions2_2.Value = 4
        ElseIf valu_moremissions2_2.Value = 4 Then
            valu_moremissions2_2.Value = 0
        Else
            valu_moremissions2_2.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_2.ValueChanged
        If valu_moremissions2_2.Value = 0 Then
            Icon_moremissions2_2.Image = Nothing
        ElseIf valu_moremissions2_2.Value = 1 Then
            Icon_moremissions2_2.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_2.Value = 4 Then
            Icon_moremissions2_2.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_3_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_3.Click
        If valu_moremissions2_3.Value = 0 Then
            valu_moremissions2_3.Value = 1
        ElseIf valu_moremissions2_3.Value = 1 Then
            valu_moremissions2_3.Value = 4
        ElseIf valu_moremissions2_3.Value = 4 Then
            valu_moremissions2_3.Value = 0
        Else
            valu_moremissions2_3.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_3.ValueChanged
        If valu_moremissions2_3.Value = 0 Then
            Icon_moremissions2_3.Image = Nothing
        ElseIf valu_moremissions2_3.Value = 1 Then
            Icon_moremissions2_3.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_3.Value = 4 Then
            Icon_moremissions2_3.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_4_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_4.Click
        If valu_moremissions2_4.Value = 0 Then
            valu_moremissions2_4.Value = 1
        ElseIf valu_moremissions2_4.Value = 1 Then
            valu_moremissions2_4.Value = 4
        ElseIf valu_moremissions2_4.Value = 4 Then
            valu_moremissions2_4.Value = 0
        Else
            valu_moremissions2_4.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_4.ValueChanged
        If valu_moremissions2_4.Value = 0 Then
            Icon_moremissions2_4.Image = Nothing
        ElseIf valu_moremissions2_4.Value = 1 Then
            Icon_moremissions2_4.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_4.Value = 4 Then
            Icon_moremissions2_4.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_5_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_5.Click
        If valu_moremissions2_5.Value = 0 Then
            valu_moremissions2_5.Value = 1
        ElseIf valu_moremissions2_5.Value = 1 Then
            valu_moremissions2_5.Value = 4
        ElseIf valu_moremissions2_5.Value = 4 Then
            valu_moremissions2_5.Value = 0
        Else
            valu_moremissions2_5.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_5.ValueChanged
        If valu_moremissions2_5.Value = 0 Then
            Icon_moremissions2_5.Image = Nothing
        ElseIf valu_moremissions2_5.Value = 1 Then
            Icon_moremissions2_5.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_5.Value = 4 Then
            Icon_moremissions2_5.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_6_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_6.Click
        If valu_moremissions2_6.Value = 0 Then
            valu_moremissions2_6.Value = 1
        ElseIf valu_moremissions2_6.Value = 1 Then
            valu_moremissions2_6.Value = 4
        ElseIf valu_moremissions2_6.Value = 4 Then
            valu_moremissions2_6.Value = 0
        Else
            valu_moremissions2_6.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_6.ValueChanged
        If valu_moremissions2_6.Value = 0 Then
            Icon_moremissions2_6.Image = Nothing
        ElseIf valu_moremissions2_6.Value = 1 Then
            Icon_moremissions2_6.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_6.Value = 4 Then
            Icon_moremissions2_6.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_7_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_7.Click
        If valu_moremissions2_7.Value = 0 Then
            valu_moremissions2_7.Value = 1
        ElseIf valu_moremissions2_7.Value = 1 Then
            valu_moremissions2_7.Value = 4
        ElseIf valu_moremissions2_7.Value = 4 Then
            valu_moremissions2_7.Value = 0
        Else
            valu_moremissions2_7.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_7.ValueChanged
        If valu_moremissions2_7.Value = 0 Then
            Icon_moremissions2_7.Image = Nothing
        ElseIf valu_moremissions2_7.Value = 1 Then
            Icon_moremissions2_7.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_7.Value = 4 Then
            Icon_moremissions2_7.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_8_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_8.Click
        If valu_moremissions2_8.Value = 0 Then
            valu_moremissions2_8.Value = 1
        ElseIf valu_moremissions2_8.Value = 1 Then
            valu_moremissions2_8.Value = 4
        ElseIf valu_moremissions2_8.Value = 4 Then
            valu_moremissions2_8.Value = 0
        Else
            valu_moremissions2_8.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_8.ValueChanged
        If valu_moremissions2_8.Value = 0 Then
            Icon_moremissions2_8.Image = Nothing
        ElseIf valu_moremissions2_8.Value = 1 Then
            Icon_moremissions2_8.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_8.Value = 4 Then
            Icon_moremissions2_8.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_9_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_9.Click
        If valu_moremissions2_9.Value = 0 Then
            valu_moremissions2_9.Value = 1
        ElseIf valu_moremissions2_9.Value = 1 Then
            valu_moremissions2_9.Value = 4
        ElseIf valu_moremissions2_9.Value = 4 Then
            valu_moremissions2_9.Value = 0
        Else
            valu_moremissions2_9.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_9.ValueChanged
        If valu_moremissions2_9.Value = 0 Then
            Icon_moremissions2_9.Image = Nothing
        ElseIf valu_moremissions2_9.Value = 1 Then
            Icon_moremissions2_9.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_9.Value = 4 Then
            Icon_moremissions2_9.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_10_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_10.Click
        If valu_moremissions2_10.Value = 0 Then
            valu_moremissions2_10.Value = 1
        ElseIf valu_moremissions2_10.Value = 1 Then
            valu_moremissions2_10.Value = 4
        ElseIf valu_moremissions2_10.Value = 4 Then
            valu_moremissions2_10.Value = 0
        Else
            valu_moremissions2_10.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_10.ValueChanged
        If valu_moremissions2_10.Value = 0 Then
            Icon_moremissions2_10.Image = Nothing
        ElseIf valu_moremissions2_10.Value = 1 Then
            Icon_moremissions2_10.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_10.Value = 4 Then
            Icon_moremissions2_10.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_11_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_11.Click
        If valu_moremissions2_11.Value = 0 Then
            valu_moremissions2_11.Value = 1
        ElseIf valu_moremissions2_11.Value = 1 Then
            valu_moremissions2_11.Value = 4
        ElseIf valu_moremissions2_11.Value = 4 Then
            valu_moremissions2_11.Value = 0
        Else
            valu_moremissions2_11.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_11.ValueChanged
        If valu_moremissions2_11.Value = 0 Then
            Icon_moremissions2_11.Image = Nothing
        ElseIf valu_moremissions2_11.Value = 1 Then
            Icon_moremissions2_11.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_11.Value = 4 Then
            Icon_moremissions2_11.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_12_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_12.Click
        If valu_moremissions2_12.Value = 0 Then
            valu_moremissions2_12.Value = 1
        ElseIf valu_moremissions2_12.Value = 1 Then
            valu_moremissions2_12.Value = 4
        ElseIf valu_moremissions2_12.Value = 4 Then
            valu_moremissions2_12.Value = 0
        Else
            valu_moremissions2_12.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_12.ValueChanged
        If valu_moremissions2_12.Value = 0 Then
            Icon_moremissions2_12.Image = Nothing
        ElseIf valu_moremissions2_12.Value = 1 Then
            Icon_moremissions2_12.Image = My.Resources.icon_medal_act2
        ElseIf valu_moremissions2_12.Value = 4 Then
            Icon_moremissions2_12.Image = My.Resources.icon_medal_done2
        End If
    End Sub

    Private Sub Icon_moremissions2_13_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_13.Click
        If valu_moremissions2_13.Value = 0 Then
            valu_moremissions2_13.Value = 1
        ElseIf valu_moremissions2_13.Value = 1 Then
            valu_moremissions2_13.Value = 4
        ElseIf valu_moremissions2_13.Value = 4 Then
            valu_moremissions2_13.Value = 0
        Else
            valu_moremissions2_13.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_13.ValueChanged
        If valu_moremissions2_13.Value = 0 Then
            Icon_moremissions2_13.Image = Nothing
        ElseIf valu_moremissions2_13.Value = 1 Then
            Icon_moremissions2_13.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_13.Value = 4 Then
            Icon_moremissions2_13.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_14_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_14.Click
        If valu_moremissions2_14.Value = 0 Then
            valu_moremissions2_14.Value = 1
        ElseIf valu_moremissions2_14.Value = 1 Then
            valu_moremissions2_14.Value = 4
        ElseIf valu_moremissions2_14.Value = 4 Then
            valu_moremissions2_14.Value = 0
        Else
            valu_moremissions2_14.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_14.ValueChanged
        If valu_moremissions2_14.Value = 0 Then
            Icon_moremissions2_14.Image = Nothing
        ElseIf valu_moremissions2_14.Value = 1 Then
            Icon_moremissions2_14.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_14.Value = 4 Then
            Icon_moremissions2_14.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_15_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_15.Click
        If valu_moremissions2_15.Value = 0 Then
            valu_moremissions2_15.Value = 1
        ElseIf valu_moremissions2_15.Value = 1 Then
            valu_moremissions2_15.Value = 4
        ElseIf valu_moremissions2_15.Value = 4 Then
            valu_moremissions2_15.Value = 0
        Else
            valu_moremissions2_15.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_15.ValueChanged
        If valu_moremissions2_15.Value = 0 Then
            Icon_moremissions2_15.Image = Nothing
        ElseIf valu_moremissions2_15.Value = 1 Then
            Icon_moremissions2_15.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_15.Value = 4 Then
            Icon_moremissions2_15.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_16_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_16.Click
        If valu_moremissions2_16.Value = 0 Then
            valu_moremissions2_16.Value = 1
        ElseIf valu_moremissions2_16.Value = 1 Then
            valu_moremissions2_16.Value = 4
        ElseIf valu_moremissions2_16.Value = 4 Then
            valu_moremissions2_16.Value = 0
        Else
            valu_moremissions2_16.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_16.ValueChanged
        If valu_moremissions2_16.Value = 0 Then
            Icon_moremissions2_16.Image = Nothing
        ElseIf valu_moremissions2_16.Value = 1 Then
            Icon_moremissions2_16.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_16.Value = 4 Then
            Icon_moremissions2_16.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_17_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_17.Click
        If valu_moremissions2_17.Value = 0 Then
            valu_moremissions2_17.Value = 1
        ElseIf valu_moremissions2_17.Value = 1 Then
            valu_moremissions2_17.Value = 4
        ElseIf valu_moremissions2_17.Value = 4 Then
            valu_moremissions2_17.Value = 0
        Else
            valu_moremissions2_17.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_17.ValueChanged
        If valu_moremissions2_17.Value = 0 Then
            Icon_moremissions2_17.Image = Nothing
        ElseIf valu_moremissions2_17.Value = 1 Then
            Icon_moremissions2_17.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_17.Value = 4 Then
            Icon_moremissions2_17.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_18_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_18.Click
        If valu_moremissions2_18.Value = 0 Then
            valu_moremissions2_18.Value = 1
        ElseIf valu_moremissions2_18.Value = 1 Then
            valu_moremissions2_18.Value = 4
        ElseIf valu_moremissions2_18.Value = 4 Then
            valu_moremissions2_18.Value = 0
        Else
            valu_moremissions2_18.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_18.ValueChanged
        If valu_moremissions2_18.Value = 0 Then
            Icon_moremissions2_18.Image = Nothing
        ElseIf valu_moremissions2_18.Value = 1 Then
            Icon_moremissions2_18.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_18.Value = 4 Then
            Icon_moremissions2_18.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_19_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_19.Click
        If valu_moremissions2_19.Value = 0 Then
            valu_moremissions2_19.Value = 1
        ElseIf valu_moremissions2_19.Value = 1 Then
            valu_moremissions2_19.Value = 4
        ElseIf valu_moremissions2_19.Value = 4 Then
            valu_moremissions2_19.Value = 0
        Else
            valu_moremissions2_19.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_19_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_19.ValueChanged
        If valu_moremissions2_19.Value = 0 Then
            Icon_moremissions2_19.Image = Nothing
        ElseIf valu_moremissions2_19.Value = 1 Then
            Icon_moremissions2_19.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_19.Value = 4 Then
            Icon_moremissions2_19.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_20_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_20.Click
        If valu_moremissions2_20.Value = 0 Then
            valu_moremissions2_20.Value = 1
        ElseIf valu_moremissions2_20.Value = 1 Then
            valu_moremissions2_20.Value = 4
        ElseIf valu_moremissions2_20.Value = 4 Then
            valu_moremissions2_20.Value = 0
        Else
            valu_moremissions2_20.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_20_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_20.ValueChanged
        If valu_moremissions2_20.Value = 0 Then
            Icon_moremissions2_20.Image = Nothing
        ElseIf valu_moremissions2_20.Value = 1 Then
            Icon_moremissions2_20.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_20.Value = 4 Then
            Icon_moremissions2_20.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_21_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_21.Click
        If valu_moremissions2_21.Value = 0 Then
            valu_moremissions2_21.Value = 1
        ElseIf valu_moremissions2_21.Value = 1 Then
            valu_moremissions2_21.Value = 4
        ElseIf valu_moremissions2_21.Value = 4 Then
            valu_moremissions2_21.Value = 0
        Else
            valu_moremissions2_21.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_21_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_21.ValueChanged
        If valu_moremissions2_21.Value = 0 Then
            Icon_moremissions2_21.Image = Nothing
        ElseIf valu_moremissions2_21.Value = 1 Then
            Icon_moremissions2_21.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_21.Value = 4 Then
            Icon_moremissions2_21.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_22_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_22.Click
        If valu_moremissions2_22.Value = 0 Then
            valu_moremissions2_22.Value = 1
        ElseIf valu_moremissions2_22.Value = 1 Then
            valu_moremissions2_22.Value = 4
        ElseIf valu_moremissions2_22.Value = 4 Then
            valu_moremissions2_22.Value = 0
        Else
            valu_moremissions2_22.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_22_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_22.ValueChanged
        If valu_moremissions2_22.Value = 0 Then
            Icon_moremissions2_22.Image = Nothing
        ElseIf valu_moremissions2_22.Value = 1 Then
            Icon_moremissions2_22.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_22.Value = 4 Then
            Icon_moremissions2_22.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_23_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_23.Click
        If valu_moremissions2_23.Value = 0 Then
            valu_moremissions2_23.Value = 1
        ElseIf valu_moremissions2_23.Value = 1 Then
            valu_moremissions2_23.Value = 4
        ElseIf valu_moremissions2_23.Value = 4 Then
            valu_moremissions2_23.Value = 0
        Else
            valu_moremissions2_23.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_23_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_23.ValueChanged
        If valu_moremissions2_23.Value = 0 Then
            Icon_moremissions2_23.Image = Nothing
        ElseIf valu_moremissions2_23.Value = 1 Then
            Icon_moremissions2_23.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_23.Value = 4 Then
            Icon_moremissions2_23.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_24_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_24.Click
        If valu_moremissions2_24.Value = 0 Then
            valu_moremissions2_24.Value = 1
        ElseIf valu_moremissions2_24.Value = 1 Then
            valu_moremissions2_24.Value = 4
        ElseIf valu_moremissions2_24.Value = 4 Then
            valu_moremissions2_24.Value = 0
        Else
            valu_moremissions2_24.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_24_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_24.ValueChanged
        If valu_moremissions2_24.Value = 0 Then
            Icon_moremissions2_24.Image = Nothing
        ElseIf valu_moremissions2_24.Value = 1 Then
            Icon_moremissions2_24.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_24.Value = 4 Then
            Icon_moremissions2_24.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Icon_moremissions2_25_Click(sender As Object, e As EventArgs) Handles Icon_moremissions2_25.Click
        If valu_moremissions2_25.Value = 0 Then
            valu_moremissions2_25.Value = 1
        ElseIf valu_moremissions2_25.Value = 1 Then
            valu_moremissions2_25.Value = 4
        ElseIf valu_moremissions2_25.Value = 4 Then
            valu_moremissions2_25.Value = 0
        Else
            valu_moremissions2_25.Value = 0
        End If
    End Sub

    Private Sub valu_moremissions2_25_ValueChanged(sender As Object, e As EventArgs) Handles valu_moremissions2_25.ValueChanged
        If valu_moremissions2_25.Value = 0 Then
            Icon_moremissions2_25.Image = Nothing
        ElseIf valu_moremissions2_25.Value = 1 Then
            Icon_moremissions2_25.Image = My.Resources.icon_medal_act1
        ElseIf valu_moremissions2_25.Value = 4 Then
            Icon_moremissions2_25.Image = My.Resources.icon_medal_done1
        End If
    End Sub

    Private Sub Text_setall_moremissions2_Click(sender As Object, e As EventArgs) Handles Text_setall_moremissions2.Click
        If valu_moremissions2_1.Value = 0 Then
            valu_moremissions2_1.Value = 1
            valu_moremissions2_2.Value = 1
            valu_moremissions2_3.Value = 1
            valu_moremissions2_4.Value = 1
            valu_moremissions2_5.Value = 1
            valu_moremissions2_6.Value = 1
            valu_moremissions2_7.Value = 1
            valu_moremissions2_8.Value = 1
            valu_moremissions2_9.Value = 1
            valu_moremissions2_10.Value = 1
            valu_moremissions2_11.Value = 1
            valu_moremissions2_12.Value = 1
            valu_moremissions2_13.Value = 1
            valu_moremissions2_14.Value = 1
            valu_moremissions2_15.Value = 1
            valu_moremissions2_16.Value = 1
            valu_moremissions2_17.Value = 1
            valu_moremissions2_18.Value = 1
            valu_moremissions2_19.Value = 1
            valu_moremissions2_20.Value = 1
            valu_moremissions2_21.Value = 1
            valu_moremissions2_22.Value = 1
            valu_moremissions2_23.Value = 1
            valu_moremissions2_24.Value = 1
            valu_moremissions2_25.Value = 1
        ElseIf valu_moremissions2_1.Value = 1 Then
            valu_moremissions2_1.Value = 4
            valu_moremissions2_2.Value = 4
            valu_moremissions2_3.Value = 4
            valu_moremissions2_4.Value = 4
            valu_moremissions2_5.Value = 4
            valu_moremissions2_6.Value = 4
            valu_moremissions2_7.Value = 4
            valu_moremissions2_8.Value = 4
            valu_moremissions2_9.Value = 4
            valu_moremissions2_10.Value = 4
            valu_moremissions2_11.Value = 4
            valu_moremissions2_12.Value = 4
            valu_moremissions2_13.Value = 4
            valu_moremissions2_14.Value = 4
            valu_moremissions2_15.Value = 4
            valu_moremissions2_16.Value = 4
            valu_moremissions2_17.Value = 4
            valu_moremissions2_18.Value = 4
            valu_moremissions2_19.Value = 4
            valu_moremissions2_20.Value = 4
            valu_moremissions2_21.Value = 4
            valu_moremissions2_22.Value = 4
            valu_moremissions2_23.Value = 4
            valu_moremissions2_24.Value = 4
            valu_moremissions2_25.Value = 4
        ElseIf valu_moremissions2_1.Value = 4 Then
            valu_moremissions2_1.Value = 0
            valu_moremissions2_2.Value = 0
            valu_moremissions2_3.Value = 0
            valu_moremissions2_4.Value = 0
            valu_moremissions2_5.Value = 0
            valu_moremissions2_6.Value = 0
            valu_moremissions2_7.Value = 0
            valu_moremissions2_8.Value = 0
            valu_moremissions2_9.Value = 0
            valu_moremissions2_10.Value = 0
            valu_moremissions2_11.Value = 0
            valu_moremissions2_12.Value = 0
            valu_moremissions2_13.Value = 0
            valu_moremissions2_14.Value = 0
            valu_moremissions2_15.Value = 0
            valu_moremissions2_16.Value = 0
            valu_moremissions2_17.Value = 0
            valu_moremissions2_18.Value = 0
            valu_moremissions2_19.Value = 0
            valu_moremissions2_20.Value = 0
            valu_moremissions2_21.Value = 0
            valu_moremissions2_22.Value = 0
            valu_moremissions2_23.Value = 0
            valu_moremissions2_24.Value = 0
            valu_moremissions2_25.Value = 0
        End If
    End Sub

    Private Sub Text_setall_moremissions1_Click(sender As Object, e As EventArgs) Handles Text_setall_moremissions1.Click
        If valu_moremissions1_1.Value = 0 Then
            valu_moremissions1_1.Value = 1
            valu_moremissions1_2.Value = 1
            valu_moremissions1_3.Value = 1
            valu_moremissions1_4.Value = 1
            valu_moremissions1_5.Value = 1
            valu_moremissions1_6.Value = 1
            valu_moremissions1_7.Value = 1
            valu_moremissions1_8.Value = 1
            valu_moremissions1_9.Value = 1
            valu_moremissions1_10.Value = 1
            valu_moremissions1_11.Value = 1
            valu_moremissions1_12.Value = 1
            valu_moremissions1_13.Value = 1
            valu_moremissions1_14.Value = 1
            valu_moremissions1_15.Value = 1
            valu_moremissions1_16.Value = 1
            valu_moremissions1_17.Value = 1
            valu_moremissions1_18.Value = 1
            valu_moremissions1_19.Value = 1
            valu_moremissions1_20.Value = 1
            valu_moremissions1_21.Value = 1
            valu_moremissions1_22.Value = 1
        ElseIf valu_moremissions1_1.Value = 1 Then
            valu_moremissions1_1.Value = 4
            valu_moremissions1_2.Value = 4
            valu_moremissions1_3.Value = 4
            valu_moremissions1_4.Value = 4
            valu_moremissions1_5.Value = 4
            valu_moremissions1_6.Value = 4
            valu_moremissions1_7.Value = 4
            valu_moremissions1_8.Value = 4
            valu_moremissions1_9.Value = 4
            valu_moremissions1_10.Value = 4
            valu_moremissions1_11.Value = 4
            valu_moremissions1_12.Value = 4
            valu_moremissions1_13.Value = 4
            valu_moremissions1_14.Value = 4
            valu_moremissions1_15.Value = 4
            valu_moremissions1_16.Value = 4
            valu_moremissions1_17.Value = 4
            valu_moremissions1_18.Value = 4
            valu_moremissions1_19.Value = 4
            valu_moremissions1_20.Value = 4
            valu_moremissions1_21.Value = 4
            valu_moremissions1_22.Value = 4
        ElseIf valu_moremissions1_1.Value = 4 Then
            valu_moremissions1_1.Value = 0
            valu_moremissions1_2.Value = 0
            valu_moremissions1_3.Value = 0
            valu_moremissions1_4.Value = 0
            valu_moremissions1_5.Value = 0
            valu_moremissions1_6.Value = 0
            valu_moremissions1_7.Value = 0
            valu_moremissions1_8.Value = 0
            valu_moremissions1_9.Value = 0
            valu_moremissions1_10.Value = 0
            valu_moremissions1_11.Value = 0
            valu_moremissions1_12.Value = 0
            valu_moremissions1_13.Value = 0
            valu_moremissions1_14.Value = 0
            valu_moremissions1_15.Value = 0
            valu_moremissions1_16.Value = 0
            valu_moremissions1_17.Value = 0
            valu_moremissions1_18.Value = 0
            valu_moremissions1_19.Value = 0
            valu_moremissions1_20.Value = 0
            valu_moremissions1_21.Value = 0
            valu_moremissions1_22.Value = 0
        End If
    End Sub

    Private Sub Text_setall_shoppe_Click(sender As Object, e As EventArgs) Handles Text_setall_shoppe.Click
        If valu_shoppe_1.Value = 0 Then
            valu_shoppe_1.Value = 1
            valu_shoppe_2.Value = 1
            valu_shoppe_3.Value = 1
            valu_shoppe_4.Value = 1
            valu_shoppe_5.Value = 1
            valu_shoppe_6.Value = 1
            valu_shoppe_7.Value = 1
            valu_shoppe_8.Value = 1
            valu_shoppe_9.Value = 1
            valu_shoppe_10.Value = 1
            valu_shoppe_11.Value = 1
            valu_shoppe_12.Value = 1
            valu_shoppe_13.Value = 1
            valu_shoppe_14.Value = 1
            valu_shoppe_15.Value = 1
            valu_shoppe_16.Value = 1
            valu_shoppe_17.Value = 1
            valu_shoppe_18.Value = 1
            valu_shoppe_19.Value = 1
            valu_shoppe_20.Value = 1
        ElseIf valu_shoppe_1.Value = 1 Then
            valu_shoppe_1.Value = 4
            valu_shoppe_2.Value = 4
            valu_shoppe_3.Value = 4
            valu_shoppe_4.Value = 4
            valu_shoppe_5.Value = 4
            valu_shoppe_6.Value = 4
            valu_shoppe_7.Value = 4
            valu_shoppe_8.Value = 4
            valu_shoppe_9.Value = 4
            valu_shoppe_10.Value = 4
            valu_shoppe_11.Value = 4
            valu_shoppe_12.Value = 4
            valu_shoppe_13.Value = 4
            valu_shoppe_14.Value = 4
            valu_shoppe_15.Value = 4
            valu_shoppe_16.Value = 4
            valu_shoppe_17.Value = 4
            valu_shoppe_18.Value = 4
            valu_shoppe_19.Value = 4
            valu_shoppe_20.Value = 4
        ElseIf valu_shoppe_1.Value = 4 Then
            valu_shoppe_1.Value = 0
            valu_shoppe_2.Value = 0
            valu_shoppe_3.Value = 0
            valu_shoppe_4.Value = 0
            valu_shoppe_5.Value = 0
            valu_shoppe_6.Value = 0
            valu_shoppe_7.Value = 0
            valu_shoppe_8.Value = 0
            valu_shoppe_9.Value = 0
            valu_shoppe_10.Value = 0
            valu_shoppe_11.Value = 0
            valu_shoppe_12.Value = 0
            valu_shoppe_13.Value = 0
            valu_shoppe_14.Value = 0
            valu_shoppe_15.Value = 0
            valu_shoppe_16.Value = 0
            valu_shoppe_17.Value = 0
            valu_shoppe_18.Value = 0
            valu_shoppe_19.Value = 0
            valu_shoppe_20.Value = 0
        End If
    End Sub

    Private Sub Text_setall_playlevel_Click(sender As Object, e As EventArgs) Handles Text_setall_playlevel.Click
        If valu_playlevel_1.Value = 0 Then
            valu_playlevel_1.Value = 1
            valu_playlevel_2.Value = 1
            valu_playlevel_3.Value = 1
            valu_playlevel_4.Value = 1
            valu_playlevel_5.Value = 1
            valu_playlevel_6.Value = 1
            valu_playlevel_7.Value = 1
            valu_playlevel_8.Value = 1
            valu_playlevel_9.Value = 1
            valu_playlevel_10.Value = 1
            valu_playlevel_11.Value = 1
            valu_playlevel_12.Value = 1
            valu_playlevel_13.Value = 1
            valu_playlevel_14.Value = 1
            valu_playlevel_15.Value = 1
            valu_playlevel_16.Value = 1
            valu_playlevel_17.Value = 1
            valu_playlevel_18.Value = 1
            valu_playlevel_19.Value = 1
            valu_playlevel_20.Value = 1
        ElseIf valu_playlevel_1.Value = 1 Then
            valu_playlevel_1.Value = 4
            valu_playlevel_2.Value = 4
            valu_playlevel_3.Value = 4
            valu_playlevel_4.Value = 4
            valu_playlevel_5.Value = 4
            valu_playlevel_6.Value = 4
            valu_playlevel_7.Value = 4
            valu_playlevel_8.Value = 4
            valu_playlevel_9.Value = 4
            valu_playlevel_10.Value = 4
            valu_playlevel_11.Value = 4
            valu_playlevel_12.Value = 4
            valu_playlevel_13.Value = 4
            valu_playlevel_14.Value = 4
            valu_playlevel_15.Value = 4
            valu_playlevel_16.Value = 4
            valu_playlevel_17.Value = 4
            valu_playlevel_18.Value = 4
            valu_playlevel_19.Value = 4
            valu_playlevel_20.Value = 4
        ElseIf valu_playlevel_1.Value = 4 Then
            valu_playlevel_1.Value = 0
            valu_playlevel_2.Value = 0
            valu_playlevel_3.Value = 0
            valu_playlevel_4.Value = 0
            valu_playlevel_5.Value = 0
            valu_playlevel_6.Value = 0
            valu_playlevel_7.Value = 0
            valu_playlevel_8.Value = 0
            valu_playlevel_9.Value = 0
            valu_playlevel_10.Value = 0
            valu_playlevel_11.Value = 0
            valu_playlevel_12.Value = 0
            valu_playlevel_13.Value = 0
            valu_playlevel_14.Value = 0
            valu_playlevel_15.Value = 0
            valu_playlevel_16.Value = 0
            valu_playlevel_17.Value = 0
            valu_playlevel_18.Value = 0
            valu_playlevel_19.Value = 0
            valu_playlevel_20.Value = 0
        End If
    End Sub

    Private Sub Text_setall_tgherquest3_Click(sender As Object, e As EventArgs) Handles Text_setall_tgherquest3.Click
        If valu_tgherquest3_1.Value = 0 Then
            valu_tgherquest3_1.Value = 1
            valu_tgherquest3_2.Value = 1
            valu_tgherquest3_3.Value = 1
            valu_tgherquest3_4.Value = 1
            valu_tgherquest3_5.Value = 1
            valu_tgherquest3_6.Value = 1
            valu_tgherquest3_7.Value = 1
            valu_tgherquest3_8.Value = 1
            valu_tgherquest3_9.Value = 1
            valu_tgherquest3_10.Value = 1
            valu_tgherquest3_11.Value = 1
            valu_tgherquest3_12.Value = 1
            valu_tgherquest3_13.Value = 1
            valu_tgherquest3_14.Value = 1
            valu_tgherquest3_15.Value = 1
            valu_tgherquest3_16.Value = 1
        ElseIf valu_tgherquest3_1.Value = 1 Then
            valu_tgherquest3_1.Value = 4
            valu_tgherquest3_2.Value = 4
            valu_tgherquest3_3.Value = 4
            valu_tgherquest3_4.Value = 4
            valu_tgherquest3_5.Value = 4
            valu_tgherquest3_6.Value = 4
            valu_tgherquest3_7.Value = 4
            valu_tgherquest3_8.Value = 4
            valu_tgherquest3_9.Value = 4
            valu_tgherquest3_10.Value = 4
            valu_tgherquest3_11.Value = 4
            valu_tgherquest3_12.Value = 4
            valu_tgherquest3_13.Value = 4
            valu_tgherquest3_14.Value = 4
            valu_tgherquest3_15.Value = 4
            valu_tgherquest3_16.Value = 4
        ElseIf valu_tgherquest3_1.Value = 4 Then
            valu_tgherquest3_1.Value = 0
            valu_tgherquest3_2.Value = 0
            valu_tgherquest3_3.Value = 0
            valu_tgherquest3_4.Value = 0
            valu_tgherquest3_5.Value = 0
            valu_tgherquest3_6.Value = 0
            valu_tgherquest3_7.Value = 0
            valu_tgherquest3_8.Value = 0
            valu_tgherquest3_9.Value = 0
            valu_tgherquest3_10.Value = 0
            valu_tgherquest3_11.Value = 0
            valu_tgherquest3_12.Value = 0
            valu_tgherquest3_13.Value = 0
            valu_tgherquest3_14.Value = 0
            valu_tgherquest3_15.Value = 0
            valu_tgherquest3_16.Value = 0
        End If
    End Sub

    Private Sub Text_setall_tgherquest2_Click(sender As Object, e As EventArgs) Handles Text_setall_tgherquest2.Click
        If valu_tgherquest2_1.Value = 0 Then
            valu_tgherquest2_1.Value = 1
            valu_tgherquest2_2.Value = 1
            valu_tgherquest2_3.Value = 1
            valu_tgherquest2_4.Value = 1
            valu_tgherquest2_5.Value = 1
            valu_tgherquest2_6.Value = 1
            valu_tgherquest2_7.Value = 1
            valu_tgherquest2_8.Value = 1
            valu_tgherquest2_9.Value = 1
            valu_tgherquest2_10.Value = 1
            valu_tgherquest2_11.Value = 1
            valu_tgherquest2_12.Value = 1
            valu_tgherquest2_13.Value = 1
            valu_tgherquest2_14.Value = 1
            valu_tgherquest2_15.Value = 1
            valu_tgherquest2_16.Value = 1
            valu_tgherquest2_17.Value = 1
            valu_tgherquest2_18.Value = 1
            valu_tgherquest2_19.Value = 1
            valu_tgherquest2_20.Value = 1
            valu_tgherquest2_21.Value = 1
            valu_tgherquest2_22.Value = 1
            valu_tgherquest2_23.Value = 1
            valu_tgherquest2_24.Value = 1
            valu_tgherquest2_25.Value = 1
        ElseIf valu_tgherquest2_1.Value = 1 Then
            valu_tgherquest2_1.Value = 4
            valu_tgherquest2_2.Value = 4
            valu_tgherquest2_3.Value = 4
            valu_tgherquest2_4.Value = 4
            valu_tgherquest2_5.Value = 4
            valu_tgherquest2_6.Value = 4
            valu_tgherquest2_7.Value = 4
            valu_tgherquest2_8.Value = 4
            valu_tgherquest2_9.Value = 4
            valu_tgherquest2_10.Value = 4
            valu_tgherquest2_11.Value = 4
            valu_tgherquest2_12.Value = 4
            valu_tgherquest2_13.Value = 4
            valu_tgherquest2_14.Value = 4
            valu_tgherquest2_15.Value = 4
            valu_tgherquest2_16.Value = 4
            valu_tgherquest2_17.Value = 4
            valu_tgherquest2_18.Value = 4
            valu_tgherquest2_19.Value = 4
            valu_tgherquest2_20.Value = 4
            valu_tgherquest2_21.Value = 4
            valu_tgherquest2_22.Value = 4
            valu_tgherquest2_23.Value = 4
            valu_tgherquest2_24.Value = 4
            valu_tgherquest2_25.Value = 4
        ElseIf valu_tgherquest2_1.Value = 4 Then
            valu_tgherquest2_1.Value = 0
            valu_tgherquest2_2.Value = 0
            valu_tgherquest2_3.Value = 0
            valu_tgherquest2_4.Value = 0
            valu_tgherquest2_5.Value = 0
            valu_tgherquest2_6.Value = 0
            valu_tgherquest2_7.Value = 0
            valu_tgherquest2_8.Value = 0
            valu_tgherquest2_9.Value = 0
            valu_tgherquest2_10.Value = 0
            valu_tgherquest2_11.Value = 0
            valu_tgherquest2_12.Value = 0
            valu_tgherquest2_13.Value = 0
            valu_tgherquest2_14.Value = 0
            valu_tgherquest2_15.Value = 0
            valu_tgherquest2_16.Value = 0
            valu_tgherquest2_17.Value = 0
            valu_tgherquest2_18.Value = 0
            valu_tgherquest2_19.Value = 0
            valu_tgherquest2_20.Value = 0
            valu_tgherquest2_21.Value = 0
            valu_tgherquest2_22.Value = 0
            valu_tgherquest2_23.Value = 0
            valu_tgherquest2_24.Value = 0
            valu_tgherquest2_25.Value = 0
        End If
    End Sub

    Private Sub Text_setall_tgherquest1_Click(sender As Object, e As EventArgs) Handles Text_setall_tgherquest1.Click
        If valu_tgherquest1_1.Value = 0 Then
            valu_tgherquest1_1.Value = 1
            valu_tgherquest1_2.Value = 1
            valu_tgherquest1_3.Value = 1
            valu_tgherquest1_4.Value = 1
            valu_tgherquest1_5.Value = 1
            valu_tgherquest1_6.Value = 1
            valu_tgherquest1_7.Value = 1
            valu_tgherquest1_8.Value = 1
            valu_tgherquest1_9.Value = 1
            valu_tgherquest1_10.Value = 1
            valu_tgherquest1_11.Value = 1
            valu_tgherquest1_12.Value = 1
            valu_tgherquest1_13.Value = 1
            valu_tgherquest1_14.Value = 1
            valu_tgherquest1_15.Value = 1
            valu_tgherquest1_16.Value = 1
            valu_tgherquest1_17.Value = 1
            valu_tgherquest1_18.Value = 1
            valu_tgherquest1_19.Value = 1
            valu_tgherquest1_20.Value = 1
            valu_tgherquest1_21.Value = 1
            valu_tgherquest1_22.Value = 1
            valu_tgherquest1_23.Value = 1
            valu_tgherquest1_24.Value = 1
            valu_tgherquest1_25.Value = 1
            valu_tgherquest1_26.Value = 1
            valu_tgherquest1_27.Value = 1
            valu_tgherquest1_28.Value = 1
            valu_tgherquest1_29.Value = 1
            valu_tgherquest1_30.Value = 1
            valu_tgherquest1_31.Value = 1
            valu_tgherquest1_32.Value = 1
        ElseIf valu_tgherquest1_1.Value = 1 Then
            valu_tgherquest1_1.Value = 4
            valu_tgherquest1_2.Value = 4
            valu_tgherquest1_3.Value = 4
            valu_tgherquest1_4.Value = 4
            valu_tgherquest1_5.Value = 4
            valu_tgherquest1_6.Value = 4
            valu_tgherquest1_7.Value = 4
            valu_tgherquest1_8.Value = 4
            valu_tgherquest1_9.Value = 4
            valu_tgherquest1_10.Value = 4
            valu_tgherquest1_11.Value = 4
            valu_tgherquest1_12.Value = 4
            valu_tgherquest1_13.Value = 4
            valu_tgherquest1_14.Value = 4
            valu_tgherquest1_15.Value = 4
            valu_tgherquest1_16.Value = 4
            valu_tgherquest1_17.Value = 4
            valu_tgherquest1_18.Value = 4
            valu_tgherquest1_19.Value = 4
            valu_tgherquest1_20.Value = 4
            valu_tgherquest1_21.Value = 4
            valu_tgherquest1_22.Value = 4
            valu_tgherquest1_23.Value = 4
            valu_tgherquest1_24.Value = 4
            valu_tgherquest1_25.Value = 4
            valu_tgherquest1_26.Value = 4
            valu_tgherquest1_27.Value = 4
            valu_tgherquest1_28.Value = 4
            valu_tgherquest1_29.Value = 4
            valu_tgherquest1_30.Value = 4
            valu_tgherquest1_31.Value = 4
            valu_tgherquest1_32.Value = 4
        ElseIf valu_tgherquest1_1.Value = 4 Then
            valu_tgherquest1_1.Value = 0
            valu_tgherquest1_2.Value = 0
            valu_tgherquest1_3.Value = 0
            valu_tgherquest1_4.Value = 0
            valu_tgherquest1_5.Value = 0
            valu_tgherquest1_6.Value = 0
            valu_tgherquest1_7.Value = 0
            valu_tgherquest1_8.Value = 0
            valu_tgherquest1_9.Value = 0
            valu_tgherquest1_10.Value = 0
            valu_tgherquest1_11.Value = 0
            valu_tgherquest1_12.Value = 0
            valu_tgherquest1_13.Value = 0
            valu_tgherquest1_14.Value = 0
            valu_tgherquest1_15.Value = 0
            valu_tgherquest1_16.Value = 0
            valu_tgherquest1_17.Value = 0
            valu_tgherquest1_18.Value = 0
            valu_tgherquest1_19.Value = 0
            valu_tgherquest1_20.Value = 0
            valu_tgherquest1_21.Value = 0
            valu_tgherquest1_22.Value = 0
            valu_tgherquest1_23.Value = 0
            valu_tgherquest1_24.Value = 0
            valu_tgherquest1_25.Value = 0
            valu_tgherquest1_26.Value = 0
            valu_tgherquest1_27.Value = 0
            valu_tgherquest1_28.Value = 0
            valu_tgherquest1_29.Value = 0
            valu_tgherquest1_30.Value = 0
            valu_tgherquest1_31.Value = 0
            valu_tgherquest1_32.Value = 0
        End If
    End Sub

    Private Sub Text_setall_tghquest2_Click(sender As Object, e As EventArgs) Handles Text_setall_tghquest2.Click
        If valu_tghquest2_1.Value = 0 Then
            valu_tghquest2_1.Value = 1
            valu_tghquest2_2.Value = 1
            valu_tghquest2_3.Value = 1
            valu_tghquest2_4.Value = 1
            valu_tghquest2_5.Value = 1
            valu_tghquest2_6.Value = 1
            valu_tghquest2_7.Value = 1
            valu_tghquest2_8.Value = 1
            valu_tghquest2_9.Value = 1
            valu_tghquest2_10.Value = 1
            valu_tghquest2_11.Value = 1
            valu_tghquest2_12.Value = 1
            valu_tghquest2_13.Value = 1
            valu_tghquest2_14.Value = 1
            valu_tghquest2_15.Value = 1
            valu_tghquest2_16.Value = 1
            valu_tghquest2_17.Value = 1
            valu_tghquest2_18.Value = 1
            valu_tghquest2_19.Value = 1
            valu_tghquest2_20.Value = 1
            valu_tghquest2_21.Value = 1
            valu_tghquest2_22.Value = 1
            valu_tghquest2_23.Value = 1
            valu_tghquest2_24.Value = 1
            valu_tghquest2_25.Value = 1
            valu_tghquest2_26.Value = 1
            valu_tghquest2_27.Value = 1
            valu_tghquest2_28.Value = 1
        ElseIf valu_tghquest2_1.Value = 1 Then
            valu_tghquest2_1.Value = 4
            valu_tghquest2_2.Value = 4
            valu_tghquest2_3.Value = 4
            valu_tghquest2_4.Value = 4
            valu_tghquest2_5.Value = 4
            valu_tghquest2_6.Value = 4
            valu_tghquest2_7.Value = 4
            valu_tghquest2_8.Value = 4
            valu_tghquest2_9.Value = 4
            valu_tghquest2_10.Value = 4
            valu_tghquest2_11.Value = 4
            valu_tghquest2_12.Value = 4
            valu_tghquest2_13.Value = 4
            valu_tghquest2_14.Value = 4
            valu_tghquest2_15.Value = 4
            valu_tghquest2_16.Value = 4
            valu_tghquest2_17.Value = 4
            valu_tghquest2_18.Value = 4
            valu_tghquest2_19.Value = 4
            valu_tghquest2_20.Value = 4
            valu_tghquest2_21.Value = 4
            valu_tghquest2_22.Value = 4
            valu_tghquest2_23.Value = 4
            valu_tghquest2_24.Value = 4
            valu_tghquest2_25.Value = 4
            valu_tghquest2_26.Value = 4
            valu_tghquest2_27.Value = 4
            valu_tghquest2_28.Value = 4
        ElseIf valu_tghquest2_1.Value = 4 Then
            valu_tghquest2_1.Value = 0
            valu_tghquest2_2.Value = 0
            valu_tghquest2_3.Value = 0
            valu_tghquest2_4.Value = 0
            valu_tghquest2_5.Value = 0
            valu_tghquest2_6.Value = 0
            valu_tghquest2_7.Value = 0
            valu_tghquest2_8.Value = 0
            valu_tghquest2_9.Value = 0
            valu_tghquest2_10.Value = 0
            valu_tghquest2_11.Value = 0
            valu_tghquest2_12.Value = 0
            valu_tghquest2_13.Value = 0
            valu_tghquest2_14.Value = 0
            valu_tghquest2_15.Value = 0
            valu_tghquest2_16.Value = 0
            valu_tghquest2_17.Value = 0
            valu_tghquest2_18.Value = 0
            valu_tghquest2_19.Value = 0
            valu_tghquest2_20.Value = 0
            valu_tghquest2_21.Value = 0
            valu_tghquest2_22.Value = 0
            valu_tghquest2_23.Value = 0
            valu_tghquest2_24.Value = 0
            valu_tghquest2_25.Value = 0
            valu_tghquest2_26.Value = 0
            valu_tghquest2_27.Value = 0
            valu_tghquest2_28.Value = 0
        End If
    End Sub

    Private Sub Text_setall_tghquest1_Click(sender As Object, e As EventArgs) Handles Text_setall_tghquest1.Click
        If valu_tghquest1_1.Value = 0 Then
            valu_tghquest1_1.Value = 1
            valu_tghquest1_2.Value = 1
            valu_tghquest1_3.Value = 1
            valu_tghquest1_4.Value = 1
            valu_tghquest1_5.Value = 1
            valu_tghquest1_6.Value = 1
            valu_tghquest1_7.Value = 1
            valu_tghquest1_8.Value = 1
            valu_tghquest1_9.Value = 1
            valu_tghquest1_10.Value = 1
            valu_tghquest1_11.Value = 1
            valu_tghquest1_12.Value = 1
            valu_tghquest1_13.Value = 1
            valu_tghquest1_14.Value = 1
            valu_tghquest1_15.Value = 1
            valu_tghquest1_16.Value = 1
            valu_tghquest1_17.Value = 1
            valu_tghquest1_18.Value = 1
            valu_tghquest1_19.Value = 1
            valu_tghquest1_20.Value = 1
            valu_tghquest1_21.Value = 1
            valu_tghquest1_22.Value = 1
            valu_tghquest1_23.Value = 1
            valu_tghquest1_24.Value = 1
            valu_tghquest1_25.Value = 1
            valu_tghquest1_26.Value = 1
            valu_tghquest1_27.Value = 1
            valu_tghquest1_28.Value = 1
        ElseIf valu_tghquest1_1.Value = 1 Then
            valu_tghquest1_1.Value = 4
            valu_tghquest1_2.Value = 4
            valu_tghquest1_3.Value = 4
            valu_tghquest1_4.Value = 4
            valu_tghquest1_5.Value = 4
            valu_tghquest1_6.Value = 4
            valu_tghquest1_7.Value = 4
            valu_tghquest1_8.Value = 4
            valu_tghquest1_9.Value = 4
            valu_tghquest1_10.Value = 4
            valu_tghquest1_11.Value = 4
            valu_tghquest1_12.Value = 4
            valu_tghquest1_13.Value = 4
            valu_tghquest1_14.Value = 4
            valu_tghquest1_15.Value = 4
            valu_tghquest1_16.Value = 4
            valu_tghquest1_17.Value = 4
            valu_tghquest1_18.Value = 4
            valu_tghquest1_19.Value = 4
            valu_tghquest1_20.Value = 4
            valu_tghquest1_21.Value = 4
            valu_tghquest1_22.Value = 4
            valu_tghquest1_23.Value = 4
            valu_tghquest1_24.Value = 4
            valu_tghquest1_25.Value = 4
            valu_tghquest1_26.Value = 4
            valu_tghquest1_27.Value = 4
            valu_tghquest1_28.Value = 4
        ElseIf valu_tghquest1_1.Value = 4 Then
            valu_tghquest1_1.Value = 0
            valu_tghquest1_2.Value = 0
            valu_tghquest1_3.Value = 0
            valu_tghquest1_4.Value = 0
            valu_tghquest1_5.Value = 0
            valu_tghquest1_6.Value = 0
            valu_tghquest1_7.Value = 0
            valu_tghquest1_8.Value = 0
            valu_tghquest1_9.Value = 0
            valu_tghquest1_10.Value = 0
            valu_tghquest1_11.Value = 0
            valu_tghquest1_12.Value = 0
            valu_tghquest1_13.Value = 0
            valu_tghquest1_14.Value = 0
            valu_tghquest1_15.Value = 0
            valu_tghquest1_16.Value = 0
            valu_tghquest1_17.Value = 0
            valu_tghquest1_18.Value = 0
            valu_tghquest1_19.Value = 0
            valu_tghquest1_20.Value = 0
            valu_tghquest1_21.Value = 0
            valu_tghquest1_22.Value = 0
            valu_tghquest1_23.Value = 0
            valu_tghquest1_24.Value = 0
            valu_tghquest1_25.Value = 0
            valu_tghquest1_26.Value = 0
            valu_tghquest1_27.Value = 0
            valu_tghquest1_28.Value = 0
        End If
    End Sub

    Private Sub Text_setall_quests2_Click(sender As Object, e As EventArgs) Handles Text_setall_quests2.Click
        If valu_quests2_1.Value = 0 Then
            valu_quests2_1.Value = 1
            valu_quests2_2.Value = 1
            valu_quests2_3.Value = 1
            valu_quests2_4.Value = 1
            valu_quests2_5.Value = 1
            valu_quests2_6.Value = 1
            valu_quests2_7.Value = 1
            valu_quests2_8.Value = 1
            valu_quests2_9.Value = 1
            valu_quests2_10.Value = 1
            valu_quests2_11.Value = 1
            valu_quests2_12.Value = 1
            valu_quests2_13.Value = 1
            valu_quests2_14.Value = 1
            valu_quests2_15.Value = 1
            valu_quests2_16.Value = 1
            valu_quests2_17.Value = 1
            valu_quests2_18.Value = 1
            valu_quests2_19.Value = 1
            valu_quests2_20.Value = 1
        ElseIf valu_quests2_1.Value = 1 Then
            valu_quests2_1.Value = 4
            valu_quests2_2.Value = 4
            valu_quests2_3.Value = 4
            valu_quests2_4.Value = 4
            valu_quests2_5.Value = 4
            valu_quests2_6.Value = 4
            valu_quests2_7.Value = 4
            valu_quests2_8.Value = 4
            valu_quests2_9.Value = 4
            valu_quests2_10.Value = 4
            valu_quests2_11.Value = 4
            valu_quests2_12.Value = 4
            valu_quests2_13.Value = 4
            valu_quests2_14.Value = 4
            valu_quests2_15.Value = 4
            valu_quests2_16.Value = 4
            valu_quests2_17.Value = 4
            valu_quests2_18.Value = 4
            valu_quests2_19.Value = 4
            valu_quests2_20.Value = 4
        ElseIf valu_quests2_1.Value = 4 Then
            valu_quests2_1.Value = 0
            valu_quests2_2.Value = 0
            valu_quests2_3.Value = 0
            valu_quests2_4.Value = 0
            valu_quests2_5.Value = 0
            valu_quests2_6.Value = 0
            valu_quests2_7.Value = 0
            valu_quests2_8.Value = 0
            valu_quests2_9.Value = 0
            valu_quests2_10.Value = 0
            valu_quests2_11.Value = 0
            valu_quests2_12.Value = 0
            valu_quests2_13.Value = 0
            valu_quests2_14.Value = 0
            valu_quests2_15.Value = 0
            valu_quests2_16.Value = 0
            valu_quests2_17.Value = 0
            valu_quests2_18.Value = 0
            valu_quests2_19.Value = 0
            valu_quests2_20.Value = 0
        End If
    End Sub

    Private Sub Text_setall_quests1_Click(sender As Object, e As EventArgs) Handles Text_setall_quests1.Click
        If valu_quests1_1.Value = 0 Then
            valu_quests1_1.Value = 1
            valu_quests1_2.Value = 1
            valu_quests1_3.Value = 1
            valu_quests1_4.Value = 1
            valu_quests1_5.Value = 1
            valu_quests1_6.Value = 1
            valu_quests1_7.Value = 1
            valu_quests1_8.Value = 1
            valu_quests1_9.Value = 1
            valu_quests1_10.Value = 1
            valu_quests1_11.Value = 1
            valu_quests1_12.Value = 1
            valu_quests1_13.Value = 1
            valu_quests1_14.Value = 1
            valu_quests1_15.Value = 1
            valu_quests1_16.Value = 1
            valu_quests1_17.Value = 1
            valu_quests1_18.Value = 1
            valu_quests1_19.Value = 1
            valu_quests1_20.Value = 1
        ElseIf valu_quests1_1.Value = 1 Then
            valu_quests1_1.Value = 4
            valu_quests1_2.Value = 4
            valu_quests1_3.Value = 4
            valu_quests1_4.Value = 4
            valu_quests1_5.Value = 4
            valu_quests1_6.Value = 4
            valu_quests1_7.Value = 4
            valu_quests1_8.Value = 4
            valu_quests1_9.Value = 4
            valu_quests1_10.Value = 4
            valu_quests1_11.Value = 4
            valu_quests1_12.Value = 4
            valu_quests1_13.Value = 4
            valu_quests1_14.Value = 4
            valu_quests1_15.Value = 4
            valu_quests1_16.Value = 4
            valu_quests1_17.Value = 4
            valu_quests1_18.Value = 4
            valu_quests1_19.Value = 4
            valu_quests1_20.Value = 4
        ElseIf valu_quests1_1.Value = 4 Then
            valu_quests1_1.Value = 0
            valu_quests1_2.Value = 0
            valu_quests1_3.Value = 0
            valu_quests1_4.Value = 0
            valu_quests1_5.Value = 0
            valu_quests1_6.Value = 0
            valu_quests1_7.Value = 0
            valu_quests1_8.Value = 0
            valu_quests1_9.Value = 0
            valu_quests1_10.Value = 0
            valu_quests1_11.Value = 0
            valu_quests1_12.Value = 0
            valu_quests1_13.Value = 0
            valu_quests1_14.Value = 0
            valu_quests1_15.Value = 0
            valu_quests1_16.Value = 0
            valu_quests1_17.Value = 0
            valu_quests1_18.Value = 0
            valu_quests1_19.Value = 0
            valu_quests1_20.Value = 0
        End If
    End Sub
End Class