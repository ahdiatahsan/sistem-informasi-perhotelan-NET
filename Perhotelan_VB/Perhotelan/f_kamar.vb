Imports System.Data.Odbc

Public Class f_kamar

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

    Sub tampil_kamar()
        Try
            koneksi()
            Dgv_kamar.Rows.Clear()
            Dim sql As String = "select * from tb_kamar"
            da = New OdbcDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                Dgv_kamar.Rows.Add(row("id"), row("no_kamar"), row("lantai"), row("tipe_kamar"), row("harga"), row("status"))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", vbInformation, "Pemberitahuan")
        End Try
    End Sub
    Private Sub f_kamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_kamar()
    End Sub

    Private Sub B_refresh_Click(sender As Object, e As EventArgs) Handles B_refresh.Click
        tampil_kamar()
    End Sub

    Private Sub B_tambah_Click(sender As Object, e As EventArgs) Handles B_tambah.Click
        f_input_edit_kamar.L_header.Text = "Tambah Data"
        f_input_edit_kamar.L_id.Visible = False
        f_input_edit_kamar.T_id.Visible = True
        f_input_edit_kamar.T_lantai.Focus()
        f_input_edit_kamar.ShowDialog()
    End Sub

    Private Sub B_edit_Click(sender As Object, e As EventArgs) Handles B_edit.Click
        f_input_edit_kamar.L_header.Text = "Edit Data"
        f_input_edit_kamar.L_id.Visible = True
        f_input_edit_kamar.T_id.Visible = False
        f_input_edit_kamar.T_lantai.Focus()
        f_input_edit_kamar.L_id.Text = Dgv_kamar.Item(0, Dgv_kamar.CurrentRow.Index).Value
        f_input_edit_kamar.ShowDialog()
    End Sub

    Private Sub B_hapus_Click(sender As Object, e As EventArgs) Handles B_hapus.Click
        If (MessageBox.Show("Yakin Ingin Menghapus Data Dengan ID : " & Dgv_kamar.Item(0, Dgv_kamar.CurrentRow.Index).Value & " ?",
                            "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
            koneksi()
            Try
                cmd = New OdbcCommand("delete from tb_kamar where id='" &
                                      Dgv_kamar.Item(0, Dgv_kamar.CurrentRow.Index).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus Data", vbInformation, "Pemberitahuan")
                tampil_kamar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub B_cari_Click(sender As Object, e As EventArgs) Handles B_cari.Click
        If T_cari.Text = "" Then
            MsgBox("Kolom Pencarian Masih Kosong", vbInformation, "Pemberitahuan")
        Else
            koneksi()
            Dgv_kamar.Rows.Clear()
            Try
                Dim sql As String = "select * from tb_kamar where " +
                                    "id like '%" + T_cari.Text + "%'" +
                                    " OR lantai like '%" + T_cari.Text + "%'" +
                                    " OR no_kamar like '%" + T_cari.Text + "%'" +
                                    " OR tipe_kamar like '%" + T_cari.Text + "%'" +
                                    " OR harga like '%" + T_cari.Text + "%'" +
                                    " OR status like '%" + T_cari.Text + "%'" +
                                    " order by id asc"
                da = New OdbcDataAdapter(sql, conn)
                dt = New DataTable
                da.Fill(dt)
                For Each row In dt.Rows
                    Dgv_kamar.Rows.Add(row("id"), row("no_kamar"), row("lantai"), row("tipe_kamar"), row("harga"), row("status"))
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
End Class