Imports System.Data.Odbc

Public Class f_cekin

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
        C_id.SelectedIndex = 0
        L_kamar.Text = "-"
        L_tipe.Text = "-"
        L_lantai.Text = "-"
        L_harga.Text = "0"
        T_nama.Clear()
        C_jk.SelectedIndex = 0
        T_alamat.Clear()
        T_telp.Clear()
        T_durasi.Clear()
    End Sub

    Sub simpan()
        koneksi()
        Try
            Dim sql As String = "insert into tb_tamu values( NULL, " +
                                "'" + T_nama.Text + "', " +
                                "'" + C_jk.Text + "', " +
                                "'" + T_alamat.Text + "', " +
                                "'" + T_telp.Text + "', " +
                                "'" + C_id.Text + "', " +
                                "'" + T_durasi.Text + "', " +
                                "curdate() )"
            cmd = New OdbcCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Gagal Simpan Data", vbInformation, "Pemberitahuan")
        End Try

        Try
            Dim sql2 As String = "update tb_kamar set" +
                                " status='Terisi' where id='" + C_id.Text + "'"
            cmd = New OdbcCommand(sql2, conn)
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
        Try
            cmd = New OdbcCommand("select * from tb_kamar where id='" + C_id.Text + "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                L_kamar.Text = dr.Item("no_kamar")
                L_lantai.Text = dr.Item("lantai")
                L_tipe.Text = dr.Item("tipe_kamar")
                L_harga.Text = dr.Item("harga")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub f_cekin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Dim sql As String = "select * from tb_kamar where status='Kosong'"
        cmd = New OdbcCommand(sql, conn)
        da = New OdbcDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        C_id.DataSource = dt
        C_id.DisplayMember = "id"
        C_id.ValueMember = "id"
        C_jk.SelectedIndex = 0
    End Sub

    Private Sub B_reset_Click(sender As Object, e As EventArgs) Handles B_reset.Click
        reset()
    End Sub

    Private Sub B_simpan_Click(sender As Object, e As EventArgs) Handles B_simpan.Click
        If C_id.Text = "" Then
            MsgBox("Kolom ID Kamar Masih Kosong!", vbInformation, "Pemberitahuan")
            C_id.Focus()
        ElseIf T_nama.Text = "" Then
            MsgBox("Kolom Nama Tamu Masih Kosong!", vbInformation, "Pemberitahuan")
            T_nama.Focus()
        ElseIf C_jk.SelectedIndex = 0 Then
            MsgBox("Kolom Jenis Kelamin Tamu Masih Kosong!", vbInformation, "Pemberitahuan")
            C_jk.Focus()
        ElseIf T_alamat.Text = "" Then
            MsgBox("Kolom Alamat Tamu Masih Kosong!", vbInformation, "Pemberitahuan")
            T_alamat.Focus()
        ElseIf T_telp.Text = "" Then
            MsgBox("Kolom No. Telp Tamu Masih Kosong!", vbInformation, "Pemberitahuan")
            T_telp.Focus()
        ElseIf T_durasi.Text = "" Then
            MsgBox("Kolom Durasi Inap Masih Kosong!", vbInformation, "Pemberitahuan")
            T_durasi.Focus()
        Else
            simpan()
        End If
    End Sub

    Private Sub C_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_id.SelectedIndexChanged
        ketemu()
    End Sub
End Class