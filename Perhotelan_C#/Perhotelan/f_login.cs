using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    public partial class f_login
    {
        public f_login()
        {
            InitializeComponent();
            _B_login.Name = "B_login";
            _B_reset.Name = "B_reset";
            _T_username.Name = "T_username";
            _T_password.Name = "T_password";
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

        public void masuk()
        {
            koneksi();
            try
            {
                cmd = new OdbcCommand("select * from tb_admin", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (Conversions.ToBoolean(!Operators.ConditionalCompareObjectEqual(T_username.Text, dr["username"], false)))
                {
                    Interaction.MsgBox("Username Salah", Constants.vbInformation, "Pemberitahuan");
                }
                else if (Conversions.ToBoolean(!Operators.ConditionalCompareObjectEqual(T_password.Text, dr["password"], false)))
                {
                    Interaction.MsgBox("Password Salah", Constants.vbInformation, "Pemberitahuan");
                }
                else if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(T_username.Text, dr["username"], false), Operators.ConditionalCompareObjectEqual(T_password.Text, dr["password"], false))))
                {
                    T_username.Clear();
                    T_password.Clear();
                    Interaction.MsgBox("Login Berhasil", Constants.vbInformation, "Pemberitahuan");
                    Visible = false;
                    My.MyProject.Forms.f_utama.Show();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Login Gagal", Constants.vbInformation, "Pemberitahuan");
            }
        }

        private void B_login_Click(object sender, EventArgs e)
        {
            masuk();
        }

        private void f_login_Load(object sender, EventArgs e)
        {
        }

        private void B_reset_Click(object sender, EventArgs e)
        {
            T_username.Clear();
            T_password.Clear();
        }

        private void T_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                B_login_Click(sender, e);
            }
        }

        private void T_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                B_login_Click(sender, e);
            }
        }
    }
}