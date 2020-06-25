Public Class f_utama
    Private Sub f_utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub f_utama_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub B_logout_Click(sender As Object, e As EventArgs) Handles B_logout.Click
        Me.Visible = False
        f_login.Show()
    End Sub

    Private Sub B_karyawan_Click(sender As Object, e As EventArgs) Handles B_karyawan.Click
        f_karyawan.ShowDialog()
    End Sub

    Private Sub B_kamar_Click(sender As Object, e As EventArgs) Handles B_kamar.Click
        f_kamar.ShowDialog()
    End Sub

    Private Sub B_tamu_Click(sender As Object, e As EventArgs) Handles B_tamu.Click
        f_tamu.ShowDialog()
    End Sub

    Private Sub B_cekin_Click(sender As Object, e As EventArgs) Handles B_cekin.Click
        f_cekin.ShowDialog()
    End Sub

    Private Sub B_cekout_Click(sender As Object, e As EventArgs) Handles B_cekout.Click
        f_cekout.ShowDialog()
    End Sub
End Class