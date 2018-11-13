Imports PackageIO
Public Class AR_Games
    Dim _menu As String
    Dim applicationpath = Application.StartupPath
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer

    Private Sub AR_Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fdialog.BackgroundImage = My.Resources._3DSARG_fdialog
    End Sub

    Private Sub _3DSARG_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles _3DSARG_header.MouseDown, _3DSARG_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub _3DSARG_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles _3DSARG_header.MouseUp, _3DSARG_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub _3DSARG_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles _3DSARG_header.MouseMove, _3DSARG_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
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

    Private Sub Fea_unlockgames_Click(sender As Object, e As EventArgs) Handles Fea_unlockgames.Click
        fdialog.Description.Text = "All AR games will be unlocked" & vbNewLine & "Open menu save file" & vbNewLine & "3DS AR Games Save Editor will make a backup of your save file in case, check ''backup'' folder"
        fdialog.ShowDialog()
        Dim open As New OpenFileDialog
        open.Title = "Open menu file"
        open.ShowDialog()
        _menu = open.FileName
        Try
            My.Computer.FileSystem.CopyFile(
                          _menu,
                        applicationpath & "\backup\AR Games Augmented Reality\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\menu")
        Catch ex As Exception
        End Try
        Try
            Dim Writer As New PackageIO.Writer(_menu, PackageIO.Endian.Little)
            Writer.Position = &H0
            Writer.WriteUInt32(33488899)
            Writer.Position = &H4
            Writer.WriteUInt32(392232963)
            fdialog.Description.Text = "All AR games unlocked" & vbNewLine & "(3ds AR games Save Editor can be closed)"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Description.Text = "Failed to unlock all AR games, retry or report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub Fea_unlockgames_MouseLeave(sender As Object, e As EventArgs) Handles Fea_unlockgames.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Fea_unlockgames_MouseMove(sender As Object, e As EventArgs) Handles Fea_unlockgames.MouseMove
        Text_description.Text = "Click to unlock all AR games"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_jksm_MouseLeave(sender As Object, e As EventArgs) Handles Icon_jksm.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_jksm_MouseMove(sender As Object, e As EventArgs) Handles Icon_jksm.MouseMove
        Text_description.Text = "Your save file is here on your SD card :" & vbNewLine & "JKSV\SysSaves\AR Games Augmented Reality\*your folder name\menu"
        Panel_description.Visible = True
    End Sub
End Class