Public Class N3DSSE_library

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
    'Avertissement utilisation : Cheating for yourself, don't ruin online experience of other players | Trichez pour vous-même, ne ruinez pas l'expérience en ligne des autres joueurs

    Private Sub Icon_3DSS3DSCSE_Click(sender As Object, e As EventArgs) Handles Icon_3DSS3DSCSE.Click
        Me.Hide()
        _3dsCamera_3dsSound.ShowDialog()
    End Sub

    Private Sub N3DSSE_library_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fdialog.BackgroundImage = My.Resources.N3DSSEL_fdialog
    End Sub

    Private Sub Info_3DSSEL_Click(sender As Object, e As EventArgs) Handles Info_3DSSEL.Click
        fdialog.Description.Text = "Team Kirby Clash Deluxe Save Editor : Confirme to work with EU|US version" & vbNewLine & "3DS Sound and 3DS Camera Save Editor : Confirme to work with EU version"
        fdialog.ShowDialog()
    End Sub
End Class
