Imports System.Data.Odbc

Public Class f_cekout

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
        L_id.Text = "-"
        L_kamar.Text = "-"
        L_tipe.Text = "-"
        L_lantai.Text = "-"
        L_harga.Text = "0"
        C_id.SelectedIndex = 0
        L_nama.Text = "-"
        L_jk.Text = "-"
        L_alamat.Text = "-"
        L_telp.Text = "-"
        L_durasi.Text = "-"
        L_total.Text = "-"
    End Sub

    Sub simpan()
        koneksi()
        Try
            Dim sql As String = "insert into tb_riwayat_tamu values( NULL, " +
                                "'" + L_nama.Text + "', " +
                                "'" + L_jk.Text + "', " +
                                "'" + L_alamat.Text + "', " +
                                "'" + L_telp.Text + "', " +
                                "'" + L_kamar.Text + "', " +
                                "'" + L_lantai.Text + "', " +
                                "'" + L_tipe.Text + "', " +
                                "'" + L_harga.Text + "', " +
                                "'" + L_durasi.Text + "', " +
                                "'" + L_total.Text + "', " +
                                "'" + L_cekin.Text + "', " +
                                "'" + L_cekout.Text + "') "
            cmd = New OdbcCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Gagal Simpan Data", vbInformation, "Pemberitahuan")
        End Try

        Try
            Dim sql2 As String = "update tb_kamar set" +
                                " status='Kosong' where id='" + L_id.Text + "'"
            cmd = New OdbcCommand(sql2, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Gagal Simpan Data", vbInformation, "Pemberitahuan")
        End Try

        Try
            Dim sql3 As String = "delete from tb_tamu where id='" + C_id.Text + "'"
            cmd = New OdbcCommand(sql3, conn)
            cmd.ExecuteNonQuery()
            reset()
            f_tamu.tampil_tamu()
            Me.Close()
            MsgBox("Berhasil Simpan Data", vbInformation, "Pemberitahuan")
        Catch ex As Exception
            MsgBox("Gagal Simpan Data", vbInformation, "Pemberitahuan")
        End Try
    End Sub

    Sub ketemu()
        koneksi()
        Dim tanggal As Date = Date.Now()
        Dim strTanggal As String = tanggal.ToString("yyyy-MM-dd")
        Try
            cmd = New OdbcCommand("select tb_tamu.*, tb_kamar.* from tb_tamu inner join tb_kamar
                                   on tb_tamu.id_kamar = tb_kamar.id 
                                   where tb_tamu.id='" + C_id.Text + "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                L_nama.Text = dr.Item("nama_tamu")
                L_jk.Text = dr.Item("jenis_kelamin")
                L_alamat.Text = dr.Item("alamat")
                L_telp.Text = dr.Item("no_telp")
                L_durasi.Text = dr.Item("durasi")
                L_cekin.Text = dr.Item("cek_in")
                L_cekout.Text = strTanggal
                L_id.Text = dr.Item("id_kamar")
                L_kamar.Text = dr.Item("no_kamar")
                L_lantai.Text = dr.Item("lantai")
                L_tipe.Text = dr.Item("tipe_kamar")
                L_harga.Text = dr.Item("harga")
                Dim total_biaya As Integer = dr.Item("harga") * dr.Item("durasi")
                L_total.Text = total_biaya
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub f_cekout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Dim sql As String = "select * from tb_tamu"
        cmd = New OdbcCommand(sql, conn)
        da = New OdbcDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        C_id.DataSource = dt
        C_id.DisplayMember = "id"
        C_id.ValueMember = "id"
    End Sub

    Private Sub B_reset_Click(sender As Object, e As EventArgs) Handles B_reset.Click
        reset()
    End Sub

    Private Sub B_simpan_Click(sender As Object, e As EventArgs) Handles B_simpan.Click
        If C_id.Text = "" Then
            MsgBox("Kolom ID Tamu Masih Kosong!", vbInformation, "Pemberitahuan")
            C_id.Focus()
        ElseIf L_id.Text = "" Then
            MsgBox("Data Masih Kosong!", vbInformation, "Pemberitahuan")
            C_id.Focus()
        Else
            simpan()
        End If
    End Sub

    Private Sub C_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_id.SelectedIndexChanged
        ketemu()
    End Sub
End Class