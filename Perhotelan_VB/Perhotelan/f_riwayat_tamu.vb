Imports System.Data.Odbc

Public Class f_riwayat_tamu

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

    Sub tampil_riwayat_tamu()
        Try
            koneksi()
            Dgv_tamu.Rows.Clear()
            Dim sql As String = "select * from tb_riwayat_tamu"
            da = New OdbcDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                Dgv_tamu.Rows.Add(row("id"), row("nama_tamu"), row("jenis_kelamin"),
                                   row("alamat"), row("no_telp"), row("no_kamar"), row("durasi"),
                                   row("cek_in"), row("cek_out"))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", vbInformation, "Pemberitahuan")
        End Try
    End Sub
    Private Sub f_riwayat_tamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_riwayat_tamu()
    End Sub

    Private Sub B_cari_Click(sender As Object, e As EventArgs) Handles B_cari.Click
        If T_cari.Text = "" Then
            MsgBox("Kolom Pencarian Masih Kosong", vbInformation, "Pemberitahuan")
        Else
            koneksi()
            Dgv_tamu.Rows.Clear()
            Try
                Dim sql As String = "select * from tb_riwayat_tamu where " +
                                    "id like '%" + T_cari.Text + "%'" +
                                    " OR nama_tamu like '%" + T_cari.Text + "%'" +
                                    " OR jenis_kelamin like '%" + T_cari.Text + "%'" +
                                    " OR alamat like '%" + T_cari.Text + "%'" +
                                    " OR no_telp like '%" + T_cari.Text + "%'" +
                                    " OR no_kamar like '%" + T_cari.Text + "%'" +
                                    " OR lantai like '%" + T_cari.Text + "%'" +
                                    " OR tipe_kamar like '%" + T_cari.Text + "%'" +
                                    " OR durasi like '%" + T_cari.Text + "%'" +
                                    " OR total_biaya like '%" + T_cari.Text + "%'" +
                                    " OR cek_in like '%" + T_cari.Text + "%'" +
                                    " OR cek_out like '%" + T_cari.Text + "%'" +
                                    " order by id asc"
                da = New OdbcDataAdapter(sql, conn)
                dt = New DataTable
                da.Fill(dt)
                For Each row In dt.Rows
                    Dgv_tamu.Rows.Add(row("id"), row("nama_tamu"), row("jenis_kelamin"),
                                   row("alamat"), row("no_telp"), row("no_kamar"), row("durasi"),
                                   row("cek_in"), row("cek_out"))
                Next
                dt.Rows.Clear()
            Catch ex As Exception
                MsgBox("Data Tidak Ditemukan", vbInformation, "Pemberitahuan")
            End Try
        End If
    End Sub

    Private Sub T_cari_KeyDown(sender As Object, e As KeyEventArgs) Handles T_cari.KeyDown
        If e.KeyCode = Keys.Enter Then
            B_cari_Click(sender, e)
        End If
    End Sub

    Private Sub B_refresh_Click_1(sender As Object, e As EventArgs) Handles B_refresh.Click
        tampil_riwayat_tamu()
    End Sub

    Private Sub f_riwayat_tamu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        f_tamu.Visible = True
    End Sub

End Class