Public Class _3dsCamera_3dsSound
    Dim SNOTE As String
    Dim _BACKUP As String
    Dim applicationpath = Application.StartupPath
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer

    Private Sub N3DSS3DSC_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles N3DSS3DSC_header.MouseDown, N3DSS3DSC_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub N3DSS3DSC_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles N3DSS3DSC_header.MouseUp, N3DSS3DSC_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub N3DSS3DSC_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles N3DSS3DSC_header.MouseMove, N3DSS3DSC_title.MouseMove
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
        N3DSSE_library.Show()
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Text_sound_fea_tipsun_Click(sender As Object, e As EventArgs) Handles Text_sound_fea_tipsun.Click
        Dim open As New OpenFileDialog
        fdialog.Description.Text = "Open SNOTE.BIN" & vbNewLine & "3DS Sound and 3DS Camera Save Editor will make a backup of your save file, check ''backup'' folder"
        fdialog.ShowDialog()
        open.Filter = "BIN files|*SNOTE.BIN"
        open.Title = "Open save SNOTE.BIN"
        open.ShowDialog()
        SNOTE = open.FileName
        makebakSNOTE()
        patchSNOTE()
    End Sub

    Public Sub makebakSNOTE()
        Try
            My.Computer.FileSystem.CopyFile(
                          SNOTE,
                        applicationpath & "\backup\Nintendo 3DS Sound\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\SNOTE.BIN")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub patchSNOTE()
        Try
            Dim Writer As New PackageIO.Writer(SNOTE, PackageIO.Endian.Little)
            Writer.Position = &H68
            Writer.WriteHexString("5555555555555555555555555555555555555555555555")
            fdialog.Description.Text = "All tips has been unlocked"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Description.Text = "An error has occurred"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub _3dsCamera_3dsSound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fdialog.BackgroundImage = My.Resources._3DSS3DSC_fdialog
    End Sub

    Private Sub Text_camera_fea_tipsun_Click(sender As Object, e As EventArgs) Handles Text_camera_fea_tipsun.Click
        Dim openc As New OpenFileDialog
        fdialog.Description.Text = "Open BACKUP.BIN" & vbNewLine & "3DS Sound and 3DS Camera Save Editor will make a backup of your save file, check ''backup'' folder"
        fdialog.ShowDialog()
        openc.Filter = "BIN files|*BACKUP.BIN"
        openc.Title = "Open save BACKUP.BIN"
        openc.ShowDialog()
        _BACKUP = openc.FileName
        makebakBACKUP()
        patchBACKUP()
    End Sub

    Public Sub makebakBACKUP()
        Try
            My.Computer.FileSystem.CopyFile(
                          _BACKUP,
                        applicationpath & "\backup\Nintendo 3DS Camera\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\BACKUP.BIN")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub patchBACKUP()
        Try
            Dim Writerc As New PackageIO.Writer(_BACKUP, PackageIO.Endian.Little)
            Writerc.Position = &H3740
            Writerc.WriteHexString("55555555555555515555555555555555555555555555555555555555")
            fdialog.Description.Text = "All tips has been unlocked"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Description.Text = "An error has occurred"
            fdialog.ShowDialog()
        End Try
    End Sub
End Class