using System;
using System.Data;
using System.Data.Odbc;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    public partial class f_input_edit_kamar
    {
        public f_input_edit_kamar()
        {
            InitializeComponent();
            _L_header.Name = "L_header";
            _Panel1.Name = "Panel1";
            _Label1.Name = "Label1";
            _T_id.Name = "T_id";
            _T_lantai.Name = "T_lantai";
            _Label2.Name = "Label2";
            _Label3.Name = "Label3";
            _T_harga.Name = "T_harga";
            _Label4.Name = "Label4";
            _C_tipe.Name = "C_tipe";
            _Label6.Name = "Label6";
            _Label7.Name = "Label7";
            _Label8.Name = "Label8";
            _Label9.Name = "Label9";
            _B_simpan.Name = "B_simpan";
            _B_reset.Name = "B_reset";
            _L_id.Name = "L_id";
            _Label11.Name = "Label11";
            _T_nomor.Name = "T_nomor";
            _Label12.Name = "Label12";
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
            T_id.Clear();
            T_lantai.Clear();
            T_nomor.Clear();
            C_tipe.SelectedIndex = 0;
            T_harga.Clear();
        }

        public void simpan()
        {
            koneksi();
            try
            {
                string sql = "insert into tb_kamar values( NULL, " + "'" + T_nomor.Text + "', " + "'" + T_lantai.Text + "', " + "'" + C_tipe.Text + "', " + "'" + T_harga.Text + "', " + "'Kosong' )";
                cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();
                reset();
                My.MyProject.Forms.f_kamar.tampil_kamar();
                Close();
                Interaction.MsgBox("Berhasil Simpan Data", Constants.vbInformation, "Pemberitahuan");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Gagal Simpan Data", Constants.vbInformation, "Pemberitahuan");
            }
        }

        public void simpanUpdate()
        {
            koneksi();
            try
            {
                string sql = "update tb_kamar set" + " lantai='" + T_lantai.Text + "', " + " tipe_kamar='" + C_tipe.Text + "', " + " harga='" + T_harga.Text + "', " + " no_kamar='" + T_nomor.Text + "'" + " where id='" + L_id.Text + "'";
                cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();
                reset();
                My.MyProject.Forms.f_kamar.tampil_kamar();
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
                cmd = new OdbcCommand("select * from tb_kamar where id='" + L_id.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    T_nomor.Text = Conversions.ToString(dr["no_kamar"]);
                    T_lantai.Text = Conversions.ToString(dr["lantai"]);
                    C_tipe.Text = Conversions.ToString(dr["tipe_kamar"]);
                    T_harga.Text = Conversions.ToString(dr["harga"]);
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

        private void f_input_edit_karyawan_Load(object sender, EventArgs e)
        {
            C_tipe.SelectedIndex = 0;
            T_nomor.Focus();
            if (L_header.Text == "Edit Data")
            {
                ketemu();
            }
        }

        private void B_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void B_simpan_Click(object sender, EventArgs e)
        {
            if (L_header.Text == "Tambah Data")
            {
                if (string.IsNullOrEmpty(T_lantai.Text))
                {
                    Interaction.MsgBox("Kolom Lantai Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                    T_lantai.Focus();
                }
                else if (C_tipe.SelectedIndex == 0)
                {
                    Interaction.MsgBox("Kolom Tipe Kamar Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                    C_tipe.Focus();
                }
                else if (string.IsNullOrEmpty(T_harga.Text))
                {
                    Interaction.MsgBox("Kolom Harga Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                    T_harga.Focus();
                }
                else if (string.IsNullOrEmpty(T_nomor.Text))
                {
                    Interaction.MsgBox("Kolom No. Kamar Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                    T_nomor.Focus();
                }
                else
                {
                    simpan();
                }
            }
            else if (L_header.Text == "Edit Data")
            {
                if (string.IsNullOrEmpty(T_lantai.Text))
                {
                    Interaction.MsgBox("Kolom Lantai Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                    T_lantai.Focus();
                }
                else if (!(C_tipe.SelectedIndex == 1 | C_tipe.SelectedIndex == 2))
                {
                    Interaction.MsgBox("Kolom Tipe Kamar Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                    C_tipe.Focus();
                }
                else if (string.IsNullOrEmpty(T_harga.Text))
                {
                    Interaction.MsgBox("Kolom Harga Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                    T_harga.Focus();
                }
                else if (string.IsNullOrEmpty(T_nomor.Text))
                {
                    Interaction.MsgBox("Kolom No. Kamar Masih Kosong!", Constants.vbInformation, "Pemberitahuan");
                    T_nomor.Focus();
                }
                else
                {
                    koneksi();
                    try
                    {
                        cmd = new OdbcCommand("select * from tb_kamar where id='" + L_id.Text + "'", conn);
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
}