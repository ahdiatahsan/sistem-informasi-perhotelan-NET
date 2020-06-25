using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Perhotelan
{
    public partial class f_riwayat_tamu
    {
        public f_riwayat_tamu()
        {
            InitializeComponent();
            _Panel1.Name = "Panel1";
            _Label1.Name = "Label1";
            _Dgv_tamu.Name = "Dgv_tamu";
            _T_cari.Name = "T_cari";
            _B_cari.Name = "B_cari";
            _Column1.Name = "Column1";
            _Column2.Name = "Column2";
            _Column3.Name = "Column3";
            _Column4.Name = "Column4";
            _Column5.Name = "Column5";
            _Column6.Name = "Column6";
            _Column7.Name = "Column7";
            _Column8.Name = "Column8";
            _Column9.Name = "Column9";
            _Column10.Name = "Column10";
            _Column11.Name = "Column11";
            _Column12.Name = "Column12";
            _Column13.Name = "Column13";
            _B_refresh.Name = "B_refresh";
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

        public void tampil_riwayat_tamu()
        {
            try
            {
                koneksi();
                Dgv_tamu.Rows.Clear();
                string sql = "select * from tb_riwayat_tamu";
                da = new OdbcDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Dgv_tamu.Rows.Add(row.ItemArray);
                }
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Menampilkan Data", Constants.vbInformation, "Pemberitahuan");
            }
        }

        private void f_riwayat_tamu_Load(object sender, EventArgs e)
        {
            tampil_riwayat_tamu();
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
                    string sql = "select * from tb_riwayat_tamu where " 
                                 + "id like '%" + T_cari.Text + "%'" 
                                 + " OR nama_tamu like '%" + T_cari.Text + "%'" 
                                 + " OR jenis_kelamin like '%" + T_cari.Text + "%'" 
                                 + " OR alamat like '%" + T_cari.Text + "%'" 
                                 + " OR no_telp like '%" + T_cari.Text + "%'" 
                                 + " OR no_kamar like '%" + T_cari.Text + "%'" 
                                 + " OR lantai like '%" + T_cari.Text + "%'" 
                                 + " OR tipe_kamar like '%" + T_cari.Text + "%'" 
                                 + " OR durasi like '%" + T_cari.Text + "%'" 
                                 + " OR total_biaya like '%" + T_cari.Text + "%'"
                                 + " OR cek_in like '%" + T_cari.Text + "%'" 
                                 + " OR cek_out like '%" + T_cari.Text + "%'" 
                                 + " order by id asc";
                    da = new OdbcDataAdapter(sql, conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        Dgv_tamu.Rows.Add(row.ItemArray);
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

        private void B_refresh_Click_1(object sender, EventArgs e)
        {
            tampil_riwayat_tamu();
        }

        private void f_riwayat_tamu_Closed(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_tamu.Visible = true;
        }
    }
}