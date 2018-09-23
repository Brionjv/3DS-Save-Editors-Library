Public Class BattlegroundZ

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

    Private Sub BattlegroundZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub hidepanels()
        Panel_main.Visible = False
        Panel_rarezombiesedit.Visible = False
        Panel_weaponsedit.Visible = False
    End Sub

    Private Sub Icon_rarezombiesedit_return_Click(sender As Object, e As EventArgs) Handles Icon_rarezombiesedit_return.Click
        hidepanels()
        Panel_main.Visible = True
    End Sub

    Private Sub Icon_weaponsedit_return_Click(sender As Object, e As EventArgs) Handles Icon_weaponsedit_return.Click
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

    Private Sub Icon_rarezombiesedit_Click(sender As Object, e As EventArgs) Handles Icon_rarezombiesedit.Click
        hidepanels()
        Panel_rarezombiesedit.Visible = True
    End Sub

    Private Sub Icon_weaponsedi_Click(sender As Object, e As EventArgs) Handles Icon_weaponsedit.Click
        hidepanels()
        Panel_weaponsedit.Visible = True
    End Sub

    Private Sub Text_weaponsedit_unlockall_Click(sender As Object, e As EventArgs) Handles Text_weaponsedit_unlockall.Click
        valu_weapon_1.Value = 4095
        valu_weapon_2.Value = 4095
        valu_weapon_3.Value = 4095
        valu_weapon_4.Value = 4095
        valu_weapon_5.Value = 4095
        valu_weapon_6.Value = 4095
        valu_weapon_7.Value = 4095
        valu_weapon_8.Value = 4095
        valu_weapon_9.Value = 4095
        valu_weapon_10.Value = 4095
        valu_weapon_11.Value = 4095
        valu_weapon_12.Value = 4095
        valu_weapon_13.Value = 4095
        valu_weapon_14.Value = 4095
        valu_weapon_15.Value = 4095
        valu_weapon_16.Value = 4095
        valu_weapon_17.Value = 4095
        valu_weapon_18.Value = 4095
        valu_weapon_19.Value = 4095
        valu_weapon_20.Value = 4095
        valu_weapon_21.Value = 4095
        valu_weapon_22.Value = 4095
        valu_weapon_23.Value = 4095
        valu_weapon_24.Value = 4095
        valu_weapon_25.Value = 4095
        valu_weapon_26.Value = 4095
    End Sub
End Class