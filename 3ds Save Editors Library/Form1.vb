Public Class Form1

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

    Private Sub Closebutton_MouseMove(sender As Object, e As MouseEventArgs) Handles Closebutton.MouseMove

    End Sub
End Class
