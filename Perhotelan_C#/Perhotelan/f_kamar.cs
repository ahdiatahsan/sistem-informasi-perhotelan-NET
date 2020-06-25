using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    public partial class f_kamar
    {
        public f_kamar()
        {
            InitializeComponent();
            _Panel1.Name = "Panel1";
            _Label1.Name = "Label1";
            _Dgv_kamar.Name = "Dgv_kamar";
            _T_cari.Name = "T_cari";
            _B_cari.Name = "B_cari";
            _B_tambah.Name = "B_tambah";
            _B_edit.Name = "B_edit";
            _B_hapus.Name = "B_hapus";
            _B_refresh.Name = "B_refresh";
            _Column1.Name = "Column1";
            _Column2.Name = "Column2";
            _Column3.Name = "Column3";
            _Column4.Name = "Column4";
            _Column5.Name = "Column5";
            _Column6.Name = "Column6";
        }

        private OdbcConnection conn;
        private OdbcCommand cmd;
        private OdbcDataReader dr;
        private OdbcDataAdapter da;
        private DataTable dt;
        private DataSet ds;

        public void koneksi()
        {
            try
            {
                conn = new OdbcConnection();
                conn.ConnectionString = "dsn=db_hotel";
                conn.Open();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Koneksi Ke Database Gagal", Constants.vbInformation, "Pemberitahuan");
            }
        }

        public void tampil_kamar()
        {
            try
            {
                koneksi();
                Dgv_kamar.Rows.Clear();
                string sql = "select * from tb_kamar";
                da = new OdbcDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Dgv_kamar.Rows.Add(row.ItemArray);
                }
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Menampilkan Data", Constants.vbInformation, "Pemberitahuan");
            }
        }

        private void f_kamar_Load(object sender, EventArgs e)
        {
            tampil_kamar();
        }

        private void B_refresh_Click(object sender, EventArgs e)
        {
            tampil_kamar();
        }

        private void B_tambah_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_input_edit_kamar.L_header.Text = "Tambah Data";
            My.MyProject.Forms.f_input_edit_kamar.L_id.Visible = false;
            My.MyProject.Forms.f_input_edit_kamar.T_id.Visible = true;
            My.MyProject.Forms.f_input_edit_kamar.T_lantai.Focus();
            My.MyProject.Forms.f_input_edit_kamar.ShowDialog();
        }

        private void B_edit_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_input_edit_kamar.L_header.Text = "Edit Data";
            My.MyProject.Forms.f_input_edit_kamar.L_id.Visible = true;
            My.MyProject.Forms.f_input_edit_kamar.T_id.Visible = false;
            My.MyProject.Forms.f_input_edit_kamar.T_lantai.Focus();
            My.MyProject.Forms.f_input_edit_kamar.L_id.Text = Conversions.ToString(Dgv_kamar[0, Dgv_kamar.CurrentRow.Index].Value);
            My.MyProject.Forms.f_input_edit_kamar.ShowDialog();
        }

        private void B_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Yakin Ingin Menghapus Data Dengan ID : ", Dgv_kamar[0, Dgv_kamar.CurrentRow.Index].Value), " ?")), "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                koneksi();
                try
                {
                    cmd = new OdbcCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from tb_kamar where id='", Dgv_kamar[0, Dgv_kamar.CurrentRow.Index].Value), "'")), conn);
                    cmd.ExecuteNonQuery();
                    Interaction.MsgBox("Berhasil Menghapus Data", Constants.vbInformation, "Pemberitahuan");
                    tampil_kamar();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
            }
        }

        private void B_cari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(T_cari.Text))
            {
                Interaction.MsgBox("Kolom Pencarian Masih Kosong", Constants.vbInformation, "Pemberitahuan");
            }
            else
            {
                koneksi();
                Dgv_kamar.Rows.Clear();
                try
                {
                    string sql = "select * from tb_kamar where " + "id like '%" + T_cari.Text + "%'" 
                                 + " OR lantai like '%" + T_cari.Text + "%'" 
                                 + " OR no_kamar like '%" + T_cari.Text + "%'" 
                                 + " OR tipe_kamar like '%" + T_cari.Text + "%'" 
                                 + " OR harga like '%" + T_cari.Text + "%'" 
                                 + " OR status like '%" + T_cari.Text + "%'" 
                                 + " order by id asc";
                    da = new OdbcDataAdapter(sql, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        Dgv_kamar.Rows.Add(row.ItemArray);
                    }
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Data Tidak Ditemukan", Constants.vbInformation, "Pemberitahuan");
                }
            }
        }

        private void T_cari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                B_cari_Click(sender, e);
            }
        }
    }
}