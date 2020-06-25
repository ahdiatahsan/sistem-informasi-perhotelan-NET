Imports System.Data.Odbc

Public Class f_tamu

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

    Sub tampil_tamu()
        Try
            koneksi()
            Dgv_tamu.Rows.Clear()
            Dim sql As String = "select tb_tamu.*, tb_kamar.no_kamar from tb_tamu 
                                 inner join tb_kamar on tb_tamu.id_kamar = tb_kamar.id"
            da = New OdbcDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                Dgv_tamu.Rows.Add(row("id"), row("nama_tamu"), row("jenis_kelamin"),
                                   row("alamat"), row("no_telp"), row("no_kamar"), row("durasi"),
                                   row("cek_in"))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", vbInformation, "Pemberitahuan")
        End Try
    End Sub
    Private Sub f_tamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_tamu()
    End Sub

    Private Sub B_refresh_Click(sender As Object, e As EventArgs) Handles B_refresh.Click
        tampil_tamu()
    End Sub

    Private Sub B_tambah_Click(sender As Object, e As EventArgs) Handles B_tambah.Click
        f_cekin.ShowDialog()
        Me.Visible = False
    End Sub

    Private Sub B_edit_Click(sender As Object, e As EventArgs) Handles B_edit.Click
        f_edit_tamu.T_nama.Focus()
        f_edit_tamu.L_id.Text = Dgv_tamu.Item(0, Dgv_tamu.CurrentRow.Index).Value
        f_edit_tamu.ShowDialog()
    End Sub

    Private Sub B_cari_Click(sender As Object, e As EventArgs) Handles B_cari.Click
        If T_cari.Text = "" Then
            MsgBox("Kolom Pencarian Masih Kosong", vbInformation, "Pemberitahuan")
        Else
            koneksi()
            Dgv_tamu.Rows.Clear()
            Try
                Dim sql As String = "select tb_tamu.*, tb_kamar.no_kamar from tb_tamu inner join 
                                     tb_kamar on tb_tamu.id_kamar = tb_kamar.id where " +
                                    "tb_tamu.id like '%" + T_cari.Text + "%'" +
                                    " OR tb_tamu.nama_tamu like '%" + T_cari.Text + "%'" +
                                    " OR tb_tamu.jenis_kelamin like '%" + T_cari.Text + "%'" +
                                    " OR tb_tamu.alamat like '%" + T_cari.Text + "%'" +
                                    " OR tb_tamu.no_telp like '%" + T_cari.Text + "%'" +
                                    " OR tb_kamar.no_kamar like '%" + T_cari.Text + "%'" +
                                    " OR tb_tamu.durasi like '%" + T_cari.Text + "%'" +
                                    " OR tb_tamu.cek_in like '%" + T_cari.Text + "%'" +
                                    " order by id asc"
                da = New OdbcDataAdapter(sql, conn)
                dt = New DataTable
                da.Fill(dt)
                For Each row In dt.Rows
                    Dgv_tamu.Rows.Add(row("id"), row("nama_tamu"), row("jenis_kelamin"),
                                   row("alamat"), row("no_telp"), row("no_kamar"), row("durasi"),
                                   row("cek_in"))
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

    Private Sub B_riwayat_Click(sender As Object, e As EventArgs) Handles B_riwayat.Click
        f_riwayat_tamu.ShowDialog()
        Me.Visible = False
    End Sub

End Class