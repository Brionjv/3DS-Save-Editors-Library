Public Class _3dsCamera_3dsSound

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub
End Class