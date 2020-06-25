using System;
using System.Data;
using System.Data.Odbc;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    public partial class f_edit_tamu
    {
        public f_edit_tamu()
        {
            InitializeComponent();
            _Panel1.Name = "Panel1";
            _L_header.Name = "L_header";
            _Label1.Name = "Label1";
            _T_nama.Name = "T_nama";
            _Label2.Name = "Label2";
            _Label3.Name = "Label3";
            _T_alamat.Name = "T_alamat";
            _Label4.Name = "Label4";
            _T_telp.Name = "T_telp";
            _Label5.Name = "Label5";
            _C_jk.Name = "C_jk";
            _Label6.Name = "Label6";
            _Label7.Name = "Label7";
            _Label8.Name = "Label8";
            _Label9.Name = "Label9";
            _Label10.Name = "Label10";
            _B_simpan.Name = "B_simpan";
            _B_reset.Name = "B_reset";
            _L_id.Name = "L_id";
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

        public void reset()
        {
            T_nama.Clear();
            C_jk.SelectedIndex = 0;
            T_alamat.Clear();
            T_telp.Clear();
        }

        public void simpanUpdate()
        {
            koneksi();
            try
            {
                string sql = "update tb_tamu set" + " nama_tamu='" + T_nama.Text + "', " + " jenis_kelamin='" + C_jk.Text + "', " + " alamat='" + T_alamat.Text + "', " + " no_telp='" + T_telp.Text + "'" + " where id='" + L_id.Text + "'";
                cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();
                reset();
                My.MyProject.Forms.f_tamu.tampil_tamu();
                Close();
                Interaction.MsgBox("Berhasil Edit Data", Constants.vbInformation, "Pemberitahuan");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Edit Data", Constants.vbInformation, "Pemberitahuan");
            }
        }

        public void ketemu()
        {
            koneksi();
            try
            {
                cmd = new OdbcCommand("select * from tb_tamu where id='" + L_id.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    T_nama.Text = Conversions.ToString(dr["nama_tamu"]);
                    C_jk.Text = Conversions.ToString(dr["jenis_kelamin"]);
                    T_alamat.Text = Conversions.ToString(dr["alamat"]);
                    T_telp.Text = Conversions.ToString(dr["no_telp"]);
                }
                else
                {
                    Close();
                    Interaction.MsgBox("Data Tidak Ditemukan", Constants.vbInformation, "Pemberitahuan");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void f_edit_tamu_Load(object sender, EventArgs e)
        {
            C_jk.SelectedIndex = 0;
            ketemu();
        }

        private void B_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void B_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(T_nama.Text))
            {
                Interaction.MsgBox("Kolom Nama Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                T_nama.Focus();
            }
            else if (!(C_jk.SelectedIndex == 1 | C_jk.SelectedIndex == 2))
            {
                Interaction.MsgBox("Kolom Jenis Kelamin Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                C_jk.Focus();
            }
            else if (string.IsNullOrEmpty(T_alamat.Text))
            {
                Interaction.MsgBox("Kolom Alamat Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                T_alamat.Focus();
            }
            else if (string.IsNullOrEmpty(T_telp.Text))
            {
                Interaction.MsgBox("Kolom No. Telp Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                T_telp.Focus();
            }
            else
            {
                koneksi();
                try
                {
                    cmd = new OdbcCommand("select * from tb_tamu where id='" + L_id.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        simpanUpdate();
                    }
                    else
                    {
                        Interaction.MsgBox("Data Tidak Ditemukan", Constants.vbInformation, "Pemberitahuan");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}