Imports System.Data.Odbc

Public Class f_login

    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet

    Sub koneksi()
        Try
            conn = New OdbcConnection
            conn.ConnectionString = "dsn=db_hotel"
            conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Ke Database Gagal", vbInformation, "Pemberitahuan")
        End Try
    End Sub

    Sub masuk()
        koneksi()
        Try
            cmd = New OdbcCommand("select * from tb_admin", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not T_username.Text = dr.Item("username") Then
                MsgBox("Username Salah", vbInformation, "Pemberitahuan")
            ElseIf Not T_password.Text = dr.Item("password") Then
                MsgBox("Password Salah", vbInformation, "Pemberitahuan")
            ElseIf T_username.Text = dr.Item("username") And T_password.Text = dr.Item("password") Then
                T_username.Clear()
                T_password.Clear()
                MsgBox("Login Berhasil", vbInformation, "Pemberitahuan")
                Me.Visible = False
                f_utama.Show()
            End If
        Catch ex As Exception
            MsgBox("Login Gagal", vbInformation, "Pemberitahuan")
        End Try
    End Sub

    Private Sub B_login_Click(sender As Object, e As EventArgs) Handles B_login.Click
        masuk()
    End Sub

    Private Sub f_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B_reset_Click(sender As Object, e As EventArgs) Handles B_reset.Click
        T_username.Clear()
        T_password.Clear()
    End Sub

    Private Sub T_username_KeyDown(sender As Object, e As KeyEventArgs) Handles T_username.KeyDown
        If e.KeyCode = Keys.Enter Then
            B_login_Click(sender, e)
        End If
    End Sub

    Private Sub T_password_KeyDown(sender As Object, e As KeyEventArgs) Handles T_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            B_login_Click(sender, e)
        End If
    End Sub

End Class
