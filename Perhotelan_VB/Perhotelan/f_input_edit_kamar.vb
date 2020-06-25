Imports System.Data.Odbc

Public Class f_input_edit_kamar

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
        T_id.Clear()
        T_lantai.Clear()
        T_nomor.Clear()
        C_tipe.SelectedIndex = 0
        T_harga.Clear()
    End Sub

    Sub simpan()
        koneksi()
        Try
            Dim sql As String = "insert into tb_kamar values( NULL, " +
                                "'" + T_nomor.Text + "', " +
                                "'" + T_lantai.Text + "', " +
                                "'" + C_tipe.Text + "', " +
                                "'" + T_harga.Text + "', " +
                                "'Kosong' )"
            cmd = New OdbcCommand(sql, conn)
            cmd.ExecuteNonQuery()
            reset()
            f_kamar.tampil_kamar()
            Me.Close()
            MsgBox("Berhasil Simpan Data", vbInformation, "Pemberitahuan")
        Catch ex As Exception
            MsgBox("Gagal Simpan Data", vbInformation, "Pemberitahuan")
        End Try
    End Sub

    Sub simpanUpdate()
        koneksi()
        Try
            Dim sql As String = "update tb_kamar set" +
                                " lantai='" + T_lantai.Text + "', " +
                                " tipe_kamar='" + C_tipe.Text + "', " +
                                " harga='" + T_harga.Text + "', " +
                                " no_kamar='" + T_nomor.Text + "'" +
                                " where id='" + L_id.Text + "'"
            cmd = New OdbcCommand(sql, conn)
            cmd.ExecuteNonQuery()
            reset()
            f_kamar.tampil_kamar()
            Me.Close()
            MsgBox("Berhasil Edit Data", vbInformation, "Pemberitahuan")
        Catch ex As Exception
            MsgBox("Gagal Edit Data", vbInformation, "Pemberitahuan")
        End Try
    End Sub

    Sub ketemu()
        koneksi()
        Try
            cmd = New OdbcCommand("select * from tb_kamar where id='" + L_id.Text + "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                T_nomor.Text = dr.Item("no_kamar")
                T_lantai.Text = dr.Item("lantai")
                C_tipe.Text = dr.Item("tipe_kamar")
                T_harga.Text = dr.Item("harga")
            Else
                Me.Close()
                MsgBox("Data Tidak Ditemukan", vbInformation, "Pemberitahuan")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub f_input_edit_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C_tipe.SelectedIndex = 0
        T_nomor.Focus()
        If L_header.Text = "Edit Data" Then
            ketemu()
        End If
    End Sub

    Private Sub B_reset_Click(sender As Object, e As EventArgs) Handles B_reset.Click
        reset()
    End Sub

    Private Sub B_simpan_Click(sender As Object, e As EventArgs) Handles B_simpan.Click
        If L_header.Text = "Tambah Data" Then
            If T_lantai.Text = "" Then
                MsgBox("Kolom Lantai Masih Kosong!", vbInformation, "Pemberitahuan")
                T_lantai.Focus()
            ElseIf C_tipe.SelectedIndex = 0 Then
                MsgBox("Kolom Tipe Kamar Masih Kosong!", vbInformation, "Pemberitahuan")
                C_tipe.Focus()
            ElseIf T_harga.Text = "" Then
                MsgBox("Kolom Harga Masih Kosong!", vbInformation, "Pemberitahuan")
                T_harga.Focus()
            ElseIf T_nomor.Text = "" Then
                MsgBox("Kolom No. Kamar Masih Kosong!", vbInformation, "Pemberitahuan")
                T_nomor.Focus()
            Else
                simpan()
            End If
        ElseIf L_header.Text = "Edit Data" Then
            If T_lantai.Text = "" Then
                MsgBox("Kolom Lantai Masih Kosong!", vbInformation, "Pemberitahuan")
                T_lantai.Focus()
            ElseIf Not (C_tipe.SelectedIndex = 1 Or C_tipe.SelectedIndex = 2) Then
                MsgBox("Kolom Tipe Kamar Masih Kosong!", vbInformation, "Pemberitahuan")
                C_tipe.Focus()
            ElseIf T_harga.Text = "" Then
                MsgBox("Kolom Harga Masih Kosong!", vbInformation, "Pemberitahuan")
                T_harga.Focus()
            ElseIf T_nomor.Text = "" Then
                MsgBox("Kolom No. Kamar Masih Kosong!", vbInformation, "Pemberitahuan")
                T_nomor.Focus()
            Else
                koneksi()
                Try
                    cmd = New OdbcCommand("select * from tb_kamar where id='" + L_id.Text + "'", conn)
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
        End If
    End Sub

End Class