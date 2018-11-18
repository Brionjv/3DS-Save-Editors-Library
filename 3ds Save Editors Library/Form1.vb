Imports System.Net
Public Class N3DSSE_library
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer

    Public Sub warnonline()
        fdialog.Description.Text = "Cheating for yourself, don't ruin online experience of other players"
        fdialog.ShowDialog()
    End Sub

    Private Sub N3DSSEL_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles N3DSSEL_header.MouseDown, N3DSSEL_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub N3DSSEL_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles N3DSSEL_header.MouseUp, N3DSSEL_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub N3DSSEL_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles N3DSSEL_header.MouseMove, N3DSSEL_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Icon_TKCDSE_Click(sender As Object, e As EventArgs) Handles Icon_TKCDSE.Click
        Me.Hide()
        TeamKirbyClashDeluxe.ShowDialog()
    End Sub

    Private Sub Icon_TKCDSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_TKCDSE.MouseLeave
        Icon_TKCDSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_TKCDSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_TKCDSE.MouseMove
        Icon_TKCDSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to access to Team Kirby Clash Deluxe Save Editor" & vbNewLine & "Confirme to work with EU|US version"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_3DSS3DSCSE_Click(sender As Object, e As EventArgs) Handles Icon_3DSS3DSCSE.Click
        Me.Hide()
        _3dsCamera_3dsSound.ShowDialog()
    End Sub

    Private Sub Icon_3DSS3DSCSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_3DSS3DSCSE.MouseLeave
        Icon_3DSS3DSCSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_3DSS3DSCSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_3DSS3DSCSE.MouseMove
        Icon_3DSS3DSCSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to access to 3DS Sound and 3DS Camera Save Editor" & vbNewLine & "Confirme to work with EU version"
        Panel_description.Visible = True
    End Sub

    Private Sub N3DSSE_library_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.setting_chkupdate = valu_update.Value
    End Sub

    Private Sub N3DSSE_library_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Checkupdates()
    End Sub

    Private Sub N3DSSE_library_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fdialog.BackgroundImage = My.Resources.N3DSSEL_fdialog
        Try
            valu_update.Value = My.Settings.setting_chkupdate
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Info_3DSSEL_Click(sender As Object, e As EventArgs)
        fdialog.Description.Text = "Team Kirby Clash Deluxe Save Editor : Confirme to work with EU|US version" & vbNewLine & "3DS Sound and 3DS Camera Save Editor : Confirme to work with EU version"
        fdialog.ShowDialog()
    End Sub

    Public Sub Checkupdates()
        If valu_update.Value = 0 Then
            Try
                Dim MAJ As New WebClient
                Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/3DS-Save-Editors-Library/master/Version.txt")
                If Text_N3DSSEL_version.Text = lastupdate Then
                    N3DSSEL_logo.Visible = True
                    N3DSSEL_logo_update.Visible = False
                Else
                    N3DSSEL_logo.Visible = False
                    N3DSSEL_logo_update.Visible = True
                    fdialog.Description.Text = "An update is available, click on 3DS Save Editors Library icon to download new version"
                    fdialog.ShowDialog()
                End If
            Catch ex As Exception
                fdialog.Description.Text = "An error has occured when checking updates"
                fdialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Menu_update_Click(sender As Object, e As EventArgs) Handles Menu_update.Click
        If valu_update.Value = 0 Then
            valu_update.Value = 1
        ElseIf valu_update.Value = 1 Then
            valu_update.Value = 0
        End If
    End Sub

    Private Sub Menu_update_MouseLeave(sender As Object, e As EventArgs) Handles Menu_update.MouseLeave
        Menu_update.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_update_MouseMove(sender As Object, e As EventArgs) Handles Menu_update.MouseMove
        Menu_update.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to enable or disable update checks"
        Panel_description.Visible = True
    End Sub

    Private Sub valu_update_ValueChanged(sender As Object, e As EventArgs) Handles valu_update.ValueChanged
        If valu_update.Value = 0 Then
            Menu_update.Image = My.Resources.icon_update_act
        ElseIf valu_update.Value = 1 Then
            Menu_update.Image = My.Resources.icon_update
        End If
    End Sub

    Private Sub Menu_unknow_Click(sender As Object, e As EventArgs) Handles Menu_unknow.Click
        If valu_unknow.Value = 0 Then
            valu_unknow.Value = 1
        ElseIf valu_unknow.Value = 1 Then
            valu_unknow.Value = 0
        End If
    End Sub

    Private Sub Menu_unknow_MouseLeave(sender As Object, e As EventArgs) Handles Menu_unknow.MouseLeave
        Menu_unknow.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Menu_unknow_MouseMove(sender As Object, e As EventArgs) Handles Menu_unknow.MouseMove
        Menu_unknow.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to see possible save editors, you are free to contribute" & vbNewLine & "See Github page or GBAtemp page"
        Panel_description.Visible = True
    End Sub

    Private Sub valu_unknow_ValueChanged(sender As Object, e As EventArgs) Handles valu_unknow.ValueChanged
        If valu_unknow.Value = 0 Then
            Menu_unknow.Image = My.Resources.icon_unknow
            Unknow_1.Visible = False
            Unknow_2.Visible = False
            Unknow_3.Visible = False
            Unknow_4.Visible = False
        ElseIf valu_unknow.Value = 1 Then
            Menu_unknow.Image = My.Resources.icon_unknow_act
            Unknow_1.Visible = True
            Unknow_2.Visible = True
            Unknow_3.Visible = True
            Unknow_4.Visible = True
        End If
    End Sub

    Private Sub N3DSSEL_logo_update_Click(sender As Object, e As EventArgs) Handles N3DSSEL_logo_update.Click
        Process.Start("https://github.com/Brionjv/3DS-Save-Editors-Library/releases")
    End Sub

    Private Sub Icon_3DSSEL_Click(sender As Object, e As EventArgs) Handles Icon_3DSSEL.Click
        Process.Start("https://github.com/Brionjv/3DS-Save-Editors-Library")
    End Sub

    Private Sub Icon_3DSSEL_MouseLeave(sender As Object, e As EventArgs) Handles Icon_3DSSEL.MouseLeave
        Icon_3DSSEL.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_3DSSEL_MouseMove(sender As Object, e As EventArgs) Handles Icon_3DSSEL.MouseMove
        Icon_3DSSEL.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to access to 3DS Save Editors Library page (Github)"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_3DSSEL_1_Click(sender As Object, e As EventArgs) Handles Icon_3DSSEL_1.Click
        Process.Start("https://gbatemp.net/threads/release-3ds-save-editors-library.518626/")
    End Sub

    Private Sub Icon_3DSSEL_1_MouseLeave(sender As Object, e As EventArgs) Handles Icon_3DSSEL_1.MouseLeave
        Icon_3DSSEL_1.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_3DSSEL_1_MouseMove(sender As Object, e As EventArgs) Handles Icon_3DSSEL_1.MouseMove
        Icon_3DSSEL_1.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to access to 3DS Save Editors Library page (Gbatemp.net)"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_MiitopiaSE_Click(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.Click
        Process.Start("https://github.com/Brionjv/Miitopia-Save-Editor/releases")
    End Sub

    Private Sub Icon_MiitopiaSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.MouseLeave
        Icon_MiitopiaSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MiitopiaSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_MiitopiaSE.MouseMove
        Icon_MiitopiaSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to download and try Miitopia Save Editor"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_ChibiRoboZLSE_Click(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.Click
        Process.Start("https://github.com/Brionjv/Chibi-Robo-ZL-Save-Editor/releases")
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.MouseLeave
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_ChibiRoboZLSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_ChibiRoboZLSE.MouseMove
        Icon_ChibiRoboZLSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to download and try Chibi Robo zip Lash Save Editor"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_PMSSSE_Click(sender As Object, e As EventArgs) Handles Icon_PMSSSE.Click
        Process.Start("https://github.com/Brionjv/Paper-Mario-SS-Save-Editor/releases")
    End Sub

    Private Sub Icon_PaparMarioSSSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_PMSSSE.MouseLeave
        Icon_PMSSSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_PaparMarioSSSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_PMSSSE.MouseMove
        Icon_PMSSSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to download and try Paper Mario Sticker Star Save Editor"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_IronfallISE_Click(sender As Object, e As EventArgs) Handles Icon_IronfallISE.Click
        Process.Start("https://github.com/Brionjv/Ironfall-Invasion-Save-Editor/releases")
    End Sub

    Private Sub Icon_IronfallISE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_IronfallISE.MouseLeave
        Icon_IronfallISE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_IronfallISE_MouseMove(sender As Object, e As EventArgs) Handles Icon_IronfallISE.MouseMove
        Icon_IronfallISE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to download and try Ironfall Invasion Save Editor"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_3DSNCSE_Click(sender As Object, e As EventArgs) Handles Icon_3DSNCSE.Click
        Process.Start("https://github.com/Brionjv/3ds-Nintendogs-cats-Save-Editor/releases")
    End Sub

    Private Sub Icon_3DSNCSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_3DSNCSE.MouseLeave
        Icon_3DSNCSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_NintendogscatSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_3DSNCSE.MouseMove
        Icon_3DSNCSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to download and try 3ds Nintendogs + cats Save Editor"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_MPITSE_Click(sender As Object, e As EventArgs) Handles Icon_MPITSE.Click
        Process.Start("https://github.com/Brionjv/Mario-Party-IT-Save-Editor/releases")
    End Sub

    Private Sub Icon_MPITSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MPITSE.MouseLeave
        Icon_MPITSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_MPITSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_MPITSE.MouseMove
        Icon_MPITSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to download and try Mario Party Island Tour Save Editor"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_TLSE_Click(sender As Object, e As EventArgs) Handles Icon_TLSE.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Private Sub Icon_TLSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_TLSE.MouseLeave
        Icon_TLSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_TLSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_TLSE.MouseMove
        Icon_TLSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to download and try Tomodachi Life Save Editor"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_ARGSE_Click(sender As Object, e As EventArgs) Handles Icon_ARGSE.Click
        Me.Hide()
        AR_Games.ShowDialog()
    End Sub

    Private Sub Icon_ARGSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_ARGSE.MouseLeave
        Icon_ARGSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_ARGSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_ARGSE.MouseMove
        Icon_ARGSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to access to 3DS AR Games Save Editor" & vbNewLine & "Confirme to work with EU version"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_SMPBZSE_Click(sender As Object, e As EventArgs) Handles Icon_SMPBZSE.Click
        Me.Hide()
        BattlegroundZ.ShowDialog()
    End Sub

    Private Sub Icon_SMPBZSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_SMPBZSE.MouseLeave
        Icon_SMPBZSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_SMPBZSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_SMPBZSE.MouseMove
        Icon_SMPBZSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to access to StreetPass Mii Plaza - StreetPass Zombies / Battleground Z Save Editor" & vbNewLine & "Confirme to work with EU version"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_SMPTS_Click(sender As Object, e As EventArgs) Handles Icon_SMPTS.Click
        Me.Hide()
        Marketcrashers.ShowDialog()
    End Sub

    Private Sub Icon_SMPTS_MouseLeave(sender As Object, e As EventArgs) Handles Icon_SMPTS.MouseLeave
        Icon_SMPTS.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_SMPTS_MouseMove(sender As Object, e As EventArgs) Handles Icon_SMPTS.MouseMove
        Icon_SMPTS.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to access to StreetPass Mii Plaza - StreetPass Trader / Market Crashers Save Editor" & vbNewLine & "Confirme to work with EU version"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_CSSE_Click(sender As Object, e As EventArgs) Handles Icon_CSSE.Click
        Me.Hide()
        CaveStory3D.ShowDialog()
    End Sub

    Private Sub Icon_CSSE_MouseLeave(sender As Object, e As EventArgs) Handles Icon_CSSE.MouseLeave
        Icon_CSSE.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_CSSE_MouseMove(sender As Object, e As EventArgs) Handles Icon_CSSE.MouseMove
        Icon_CSSE.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Click to access to Cave Story 3D Save Editor" & vbNewLine & "Confirme to work with EU version"
        Panel_description.Visible = True
    End Sub

    Private Sub Unknow_1_Click(sender As Object, e As EventArgs) Handles Unknow_1.Click
    End Sub

    Private Sub Unknow_1_MouseLeave(sender As Object, e As EventArgs) Handles Unknow_1.MouseLeave
        Unknow_1.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Unknow_1_MouseMove(sender As Object, e As EventArgs) Handles Unknow_1.MouseMove
        Unknow_1.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "Luigi's Mansion" & vbNewLine & "To do"
        Panel_description.Visible = True
    End Sub

    Private Sub Unknow_2_Click(sender As Object, e As EventArgs) Handles Unknow_2.Click
    End Sub

    Private Sub Unknow_2_MouseLeave(sender As Object, e As EventArgs) Handles Unknow_2.MouseLeave
        Unknow_2.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Unknow_2_MouseMove(sender As Object, e As EventArgs) Handles Unknow_2.MouseMove
        Unknow_2.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "StreetPass Fishing / Ultimate Angler" & vbNewLine & "Possible ??"
        Panel_description.Visible = True
    End Sub

    Private Sub Unknow_3_Click(sender As Object, e As EventArgs) Handles Unknow_3.Click
    End Sub

    Private Sub Unknow_3_MouseLeave(sender As Object, e As EventArgs) Handles Unknow_3.MouseLeave
        Unknow_3.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Unknow_3_MouseMove(sender As Object, e As EventArgs) Handles Unknow_3.MouseMove
        Unknow_3.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "StreetPass Chef / Feed Mii" & vbNewLine & "Possible ??"
        Panel_description.Visible = True
    End Sub

    Private Sub Unknow_4_Click(sender As Object, e As EventArgs) Handles Unknow_4.Click
    End Sub

    Private Sub Unknow_4_MouseLeave(sender As Object, e As EventArgs) Handles Unknow_4.MouseLeave
        Unknow_4.BorderStyle = BorderStyle.None
        Panel_description.Visible = False
    End Sub

    Private Sub Unknow_4_MouseMove(sender As Object, e As EventArgs) Handles Unknow_4.MouseMove
        Unknow_4.BorderStyle = BorderStyle.FixedSingle
        Text_description.Text = "StreetPass Squad / Mii Force" & vbNewLine & "Possible ??"
        Panel_description.Visible = True
    End Sub

End Class
