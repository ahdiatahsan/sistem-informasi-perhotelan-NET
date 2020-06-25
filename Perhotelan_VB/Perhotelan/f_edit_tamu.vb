Imports System.Data.Odbc

Public Class f_edit_tamu

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

    Sub reset()
        T_nama.Clear()
        C_jk.SelectedIndex = 0
        T_alamat.Clear()
        T_telp.Clear()
    End Sub

    Sub simpanUpdate()
        koneksi()
        Try
            Dim sql As String = "update tb_tamu set" +
                                " nama_tamu='" + T_nama.Text + "', " +
                                " jenis_kelamin='" + C_jk.Text + "', " +
                                " alamat='" + T_alamat.Text + "', " +
                                " no_telp='" + T_telp.Text + "'" +
                                " where id='" + L_id.Text + "'"
            cmd = New OdbcCommand(sql, conn)
            cmd.ExecuteNonQuery()
            reset()
            f_tamu.tampil_tamu()
            Me.Close()
            MsgBox("Berhasil Edit Data", vbInformation, "Pemberitahuan")
        Catch ex As Exception
            MsgBox("Gagal Edit Data", vbInformation, "Pemberitahuan")
        End Try
    End Sub

    Sub ketemu()
        koneksi()
        Try
            cmd = New OdbcCommand("select * from tb_tamu where id='" + L_id.Text + "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                T_nama.Text = dr.Item("nama_tamu")
                C_jk.Text = dr.Item("jenis_kelamin")
                T_alamat.Text = dr.Item("alamat")
                T_telp.Text = dr.Item("no_telp")
            Else
                Me.Close()
                MsgBox("Data Tidak Ditemukan", vbInformation, "Pemberitahuan")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub f_edit_tamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C_jk.SelectedIndex = 0
        ketemu()
    End Sub

    Private Sub B_reset_Click(sender As Object, e As EventArgs) Handles B_reset.Click
        reset()
    End Sub

    Private Sub B_simpan_Click(sender As Object, e As EventArgs) Handles B_simpan.Click
        If T_nama.Text = "" Then
            MsgBox("Kolom Nama Masih Kosong!", vbInformation, "Pemberitahuan")
            T_nama.Focus()
        ElseIf Not (C_jk.SelectedIndex = 1 Or C_jk.SelectedIndex = 2) Then
            MsgBox("Kolom Jenis Kelamin Masih Kosong!", vbInformation, "Pemberitahuan")
            C_jk.Focus()
        ElseIf T_alamat.Text = "" Then
            MsgBox("Kolom Alamat Masih Kosong!", vbInformation, "Pemberitahuan")
            T_alamat.Focus()
        ElseIf T_telp.Text = "" Then
            MsgBox("Kolom No. Telp Masih Kosong!", vbInformation, "Pemberitahuan")
            T_telp.Focus()
        Else
            koneksi()
            Try
                cmd = New OdbcCommand("select * from tb_tamu where id='" + L_id.Text + "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    simpanUpdate()
                Else
                    MsgBox("Data Tidak Ditemukan", vbInformation, "Pemberitahuan")
                    Me.Close()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class