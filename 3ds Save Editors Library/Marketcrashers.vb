Imports PackageIO
Public Class Marketcrashers
    Dim applicationpath = Application.StartupPath
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim mgTrd0 As String
    Dim Assets = &H1598

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

    Private Sub SMPMCSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPMCSE_header.MouseDown, SMPMCSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub SMPMCSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPMCSE_header.MouseUp, SMPMCSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub SMPMCSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SMPMCSE_header.MouseMove, SMPMCSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Public Sub makebakmgTrd0()
        Try
            My.Computer.FileSystem.CopyFile(
                          mgTrd0,
                        applicationpath & "\backup\Market Crashers\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\mgTrd0.dat")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Dim open As New OpenFileDialog
        fdialog.Description.Text = "Open mgTrd0.dat" & vbNewLine & "StreetPass Mii Plaza - StreetPass Trader / Market Crashers Save Editor will make a backup of your save file, check ''backup'' folder"
        fdialog.ShowDialog()
        open.Filter = "DAT files|*mgTrd0.dat"
        open.Title = "Open save mgTrd0.dat"
        open.ShowDialog()
        mgTrd0 = open.FileName
        readfilesavemmgTrd0()
        makebakmgTrd0()
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        writefilesavemgTrd0()
    End Sub

    Public Sub readfilesavemmgTrd0()
        Try
            Dim Reader As New PackageIO.Reader(mgTrd0, PackageIO.Endian.Little)
            Reader.Position = Assets
            valu_assets.Value = Reader.ReadUInt32
            Text_menu_save.Visible = True
        Catch ex As Exception
            fdialog.Description.Text = "Failed to read mgTrd0.dat, make sure you have opened a good save file or report this issue"
            fdialog.ShowDialog()
            Text_menu_save.Visible = False
        End Try
    End Sub

    Public Sub writefilesavemgTrd0()
        Try
            Dim Writer As New PackageIO.Writer(mgTrd0, PackageIO.Endian.Little)
            Writer.Position = Assets
            Writer.WriteUInt32(valu_assets.Value)
            fdialog.Description.Text = "Editing of mgTrd0.dat has been saved"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Description.Text = "Failed to edit mgTrd0.dat, make sure you have opened a save file or report this issue"
            fdialog.ShowDialog()
        End Try
    End Sub

End Class