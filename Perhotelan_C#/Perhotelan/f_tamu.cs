using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    public partial class f_tamu
    {
        public f_tamu()
        {
            InitializeComponent();
            _Panel1.Name = "Panel1";
            _Label1.Name = "Label1";
            _Dgv_tamu.Name = "Dgv_tamu";
            _T_cari.Name = "T_cari";
            _B_cari.Name = "B_cari";
            _B_refresh.Name = "B_refresh";
            _B_edit.Name = "B_edit";
            _B_tambah.Name = "B_tambah";
            _B_riwayat.Name = "B_riwayat";
            _Column1.Name = "Column1";
            _Column2.Name = "Column2";
            _Column3.Name = "Column3";
            _Column4.Name = "Column4";
            _Column5.Name = "Column5";
            _Column6.Name = "Column6";
            _Column7.Name = "Column7";
            _Column8.Name = "Column8";
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

        public void tampil_tamu()
        {
            try
            {
                koneksi();
                Dgv_tamu.Rows.Clear();
                string sql = @"select tb_tamu.*, tb_kamar.no_kamar from tb_tamu 
                                 inner join tb_kamar on tb_tamu.id_kamar = tb_kamar.id";
                da = new OdbcDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Dgv_tamu.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[8], row[6], row[7]);
                }
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Menampilkan Data", Constants.vbInformation, "Pemberitahuan");
            }
        }

        private void f_tamu_Load(object sender, EventArgs e)
        {
            tampil_tamu();
        }

        private void B_refresh_Click(object sender, EventArgs e)
        {
            tampil_tamu();
        }

        private void B_tambah_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_cekin.ShowDialog();
            Visible = false;
        }

        private void B_edit_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_edit_tamu.T_nama.Focus();
            My.MyProject.Forms.f_edit_tamu.L_id.Text = Conversions.ToString(Dgv_tamu[0, Dgv_tamu.CurrentRow.Index].Value);
            My.MyProject.Forms.f_edit_tamu.ShowDialog();
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
                Dgv_tamu.Rows.Clear();
                try
                {
                    string sql = @"select tb_tamu.*, tb_kamar.no_kamar from tb_tamu inner join 
                                     tb_kamar on tb_tamu.id_kamar = tb_kamar.id where " 
                                     + "tb_tamu.id like '%" + T_cari.Text + "%'" 
                                     + " OR tb_tamu.nama_tamu like '%" + T_cari.Text + "%'" 
                                     + " OR tb_tamu.jenis_kelamin like '%" + T_cari.Text + "%'" 
                                     + " OR tb_tamu.alamat like '%" + T_cari.Text + "%'" 
                                     + " OR tb_tamu.no_telp like '%" + T_cari.Text + "%'" 
                                     + " OR tb_kamar.no_kamar like '%" + T_cari.Text + "%'" 
                                     + " OR tb_tamu.durasi like '%" + T_cari.Text + "%'" 
                                     + " OR tb_tamu.cek_in like '%" + T_cari.Text + "%'" 
                                     + " order by id asc";
                    da = new OdbcDataAdapter(sql, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        Dgv_tamu.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[8], row[6], row[7]);
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

        private void B_riwayat_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_riwayat_tamu.ShowDialog();
            Visible = false;
        }
    }
}