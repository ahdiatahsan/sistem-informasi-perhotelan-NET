using System;
using System.Data;
using System.Data.Odbc;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    public partial class f_cekout
    {
        public f_cekout()
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
            _Label22.Name = "Label22";
            _Label23.Name = "Label23";
            _Label5.Name = "Label5";
            _Label10.Name = "Label10";
            _Label14.Name = "Label14";
            _Label15.Name = "Label15";
            _Label16.Name = "Label16";
            _Label17.Name = "Label17";
            _Label18.Name = "Label18";
            _Label19.Name = "Label19";
            _Label20.Name = "Label20";
            _Label21.Name = "Label21";
            _L_id.Name = "L_id";
            _L_nama.Name = "L_nama";
            _L_jk.Name = "L_jk";
            _L_alamat.Name = "L_alamat";
            _L_telp.Name = "L_telp";
            _L_durasi.Name = "L_durasi";
            _L_total.Name = "L_total";
            _Label24.Name = "Label24";
            _Label25.Name = "Label25";
            _L_cekin.Name = "L_cekin";
            _Label26.Name = "Label26";
            _Label27.Name = "Label27";
            _L_cekout.Name = "L_cekout";
            _Label29.Name = "Label29";
            _Label30.Name = "Label30";
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
            L_id.Text = "-";
            L_kamar.Text = "-";
            L_tipe.Text = "-";
            L_lantai.Text = "-";
            L_harga.Text = "0";
            C_id.SelectedIndex = 0;
            L_nama.Text = "-";
            L_jk.Text = "-";
            L_alamat.Text = "-";
            L_telp.Text = "-";
            L_durasi.Text = "-";
            L_total.Text = "-";
        }

        public void simpan()
        {
            koneksi();
            try
            {
                string sql = "insert into tb_riwayat_tamu values( NULL, " + "'" + L_nama.Text + "', " + "'" + L_jk.Text + "', " + "'" + L_alamat.Text + "', " + "'" + L_telp.Text + "', " + "'" + L_kamar.Text + "', " + "'" + L_lantai.Text + "', " + "'" + L_tipe.Text + "', " + "'" + L_harga.Text + "', " + "'" + L_durasi.Text + "', " + "'" + L_total.Text + "', " + "'" + L_cekin.Text + "', " + "'" + L_cekout.Text + "') ";
                cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Simpan Data", Constants.vbInformation, "Pemberitahuan");
            }

            try
            {
                string sql2 = "update tb_kamar set" + " status='Kosong' where id='" + L_id.Text + "'";
                cmd = new OdbcCommand(sql2, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Simpan Data", Constants.vbInformation, "Pemberitahuan");
            }

            try
            {
                string sql3 = "delete from tb_tamu where id='" + C_id.Text + "'";
                cmd = new OdbcCommand(sql3, conn);
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
            var tanggal = DateTime.Now;
            string strTanggal = tanggal.ToString("yyyy-MM-dd");
            try
            {
                cmd = new OdbcCommand(@"select tb_tamu.*, tb_kamar.* from tb_tamu inner join tb_kamar
                                   on tb_tamu.id_kamar = tb_kamar.id 
                                   where tb_tamu.id='" + C_id.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    L_nama.Text = Conversions.ToString(dr["nama_tamu"]);
                    L_jk.Text = Conversions.ToString(dr["jenis_kelamin"]);
                    L_alamat.Text = Conversions.ToString(dr["alamat"]);
                    L_telp.Text = Conversions.ToString(dr["no_telp"]);
                    L_durasi.Text = Conversions.ToString(dr["durasi"]);
                    L_cekin.Text = Conversions.ToString(dr["cek_in"]);
                    L_cekout.Text = strTanggal;
                    L_id.Text = Conversions.ToString(dr["id_kamar"]);
                    L_kamar.Text = Conversions.ToString(dr["no_kamar"]);
                    L_lantai.Text = Conversions.ToString(dr["lantai"]);
                    L_tipe.Text = Conversions.ToString(dr["tipe_kamar"]);
                    L_harga.Text = Conversions.ToString(dr["harga"]);
                    int total_biaya = Conversions.ToInteger(Operators.MultiplyObject(dr["harga"], dr["durasi"]));
                    L_total.Text = total_biaya.ToString();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void f_cekout_Load(object sender, EventArgs e)
        {
            koneksi();
            string sql = "select * from tb_tamu";
            cmd = new OdbcCommand(sql, conn);
            da = new OdbcDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            C_id.DataSource = dt;
            C_id.DisplayMember = "id";
            C_id.ValueMember = "id";
        }

        private void B_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void B_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(C_id.Text))
            {
                Interaction.MsgBox("Kolom ID Tamu Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                C_id.Focus();
            }
            else if (string.IsNullOrEmpty(L_id.Text))
            {
                Interaction.MsgBox("Data Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                C_id.Focus();
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