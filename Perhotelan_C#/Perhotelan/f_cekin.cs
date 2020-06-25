using System;
using System.Data;
using System.Data.Odbc;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    public partial class f_cekin
    {
        public f_cekin()
        {
            InitializeComponent();
            _L_header.Name = "L_header";
            _Panel1.Name = "Panel1";
            _Label1.Name = "Label1";
            _Label2.Name = "Label2";
            _Label3.Name = "Label3";
            _Label4.Name = "Label4";
            _C_id.Name = "C_id";
            _Label6.Name = "Label6";
            _Label7.Name = "Label7";
            _Label8.Name = "Label8";
            _Label9.Name = "Label9";
            _B_simpan.Name = "B_simpan";
            _B_reset.Name = "B_reset";
            _Label11.Name = "Label11";
            _Label12.Name = "Label12";
            _GroupBox1.Name = "GroupBox1";
            _L_harga.Name = "L_harga";
            _L_tipe.Name = "L_tipe";
            _L_lantai.Name = "L_lantai";
            _L_kamar.Name = "L_kamar";
            _GroupBox2.Name = "GroupBox2";
            _Label24.Name = "Label24";
            _Label22.Name = "Label22";
            _T_durasi.Name = "T_durasi";
            _Label23.Name = "Label23";
            _Label5.Name = "Label5";
            _T_nama.Name = "T_nama";
            _Label10.Name = "Label10";
            _Label13.Name = "Label13";
            _Label14.Name = "Label14";
            _Label15.Name = "Label15";
            _Label16.Name = "Label16";
            _Label17.Name = "Label17";
            _C_jk.Name = "C_jk";
            _T_telp.Name = "T_telp";
            _Label18.Name = "Label18";
            _Label19.Name = "Label19";
            _T_alamat.Name = "T_alamat";
            _Label20.Name = "Label20";
            _Label21.Name = "Label21";
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
            C_id.SelectedIndex = 0;
            L_kamar.Text = "-";
            L_tipe.Text = "-";
            L_lantai.Text = "-";
            L_harga.Text = "0";
            T_nama.Clear();
            C_jk.SelectedIndex = 0;
            T_alamat.Clear();
            T_telp.Clear();
            T_durasi.Clear();
        }

        public void simpan()
        {
            koneksi();
            try
            {
                string sql = "insert into tb_tamu values( NULL, " + "'" + T_nama.Text + "', " + "'" + C_jk.Text + "', " + "'" + T_alamat.Text + "', " + "'" + T_telp.Text + "', " + "'" + C_id.Text + "', " + "'" + T_durasi.Text + "', " + "curdate() )";
                cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Simpan Data", Constants.vbInformation, "Pemberitahuan");
            }

            try
            {
                string sql2 = "update tb_kamar set" + " status='Terisi' where id='" + C_id.Text + "'";
                cmd = new OdbcCommand(sql2, conn);
                cmd.ExecuteNonQuery();
                reset();
                My.MyProject.Forms.f_tamu.tampil_tamu();
                Close();
                Interaction.MsgBox("Berhasil Simpan Data", Constants.vbInformation, "Pemberitahuan");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Simpan Data", Constants.vbInformation, "Pemberitahuan");
            }
        }

        public void ketemu()
        {
            koneksi();
            try
            {
                cmd = new OdbcCommand("select * from tb_kamar where id='" + C_id.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    L_kamar.Text = Conversions.ToString(dr["no_kamar"]);
                    L_lantai.Text = Conversions.ToString(dr["lantai"]);
                    L_tipe.Text = Conversions.ToString(dr["tipe_kamar"]);
                    L_harga.Text = Conversions.ToString(dr["harga"]);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void f_cekin_Load(object sender, EventArgs e)
        {
            koneksi();
            string sql = "select * from tb_kamar where status='Kosong'";
            cmd = new OdbcCommand(sql, conn);
            da = new OdbcDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            C_id.DataSource = dt;
            C_id.DisplayMember = "id";
            C_id.ValueMember = "id";
            C_jk.SelectedIndex = 0;
        }

        private void B_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void B_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(C_id.Text))
            {
                Interaction.MsgBox("Kolom ID Kamar Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                C_id.Focus();
            }
            else if (string.IsNullOrEmpty(T_nama.Text))
            {
                Interaction.MsgBox("Kolom Nama Tamu Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                T_nama.Focus();
            }
            else if (C_jk.SelectedIndex == 0)
            {
                Interaction.MsgBox("Kolom Jenis Kelamin Tamu Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                C_jk.Focus();
            }
            else if (string.IsNullOrEmpty(T_alamat.Text))
            {
                Interaction.MsgBox("Kolom Alamat Tamu Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                T_alamat.Focus();
            }
            else if (string.IsNullOrEmpty(T_telp.Text))
            {
                Interaction.MsgBox("Kolom No. Telp Tamu Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                T_telp.Focus();
            }
            else if (string.IsNullOrEmpty(T_durasi.Text))
            {
                Interaction.MsgBox("Kolom Durasi Inap Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                T_durasi.Focus();
            }
            else
            {
                simpan();
            }
        }

        private void C_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketemu();
        }
    }
}