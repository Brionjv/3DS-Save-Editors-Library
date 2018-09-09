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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        TeamKirbyClashDeluxe.ShowDialog()
    End Sub
    'Avertissement utilisation : Cheating for yourself, don't ruin online experience of other users | Trichez pour vous-même, ne ruinez pas l'expérience en ligne des autres utilisateurs

    Private Sub Closebutton_MouseMove(sender As Object, e As MouseEventArgs) Handles Closebutton.MouseMove

    End Sub
End Class
