using System;

namespace Perhotelan
{
    public partial class f_utama
    {
        public f_utama()
        {
            InitializeComponent();
            _B_karyawan.Name = "B_karyawan";
            _Label1.Name = "Label1";
            _B_kamar.Name = "B_kamar";
            _B_tamu.Name = "B_tamu";
            _B_logout.Name = "B_logout";
            _B_cekout.Name = "B_cekout";
            _B_cekin.Name = "B_cekin";
        }

        private void f_utama_Load(object sender, EventArgs e)
        {
        }

        private void f_utama_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void B_logout_Click(object sender, EventArgs e)
        {
            Visible = false;
            My.MyProject.Forms.f_login.Show();
        }

        private void B_karyawan_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_karyawan.ShowDialog();
        }

        private void B_kamar_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_kamar.ShowDialog();
        }

        private void B_tamu_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_tamu.ShowDialog();
        }

        private void B_cekin_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_cekin.ShowDialog();
        }

        private void B_cekout_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.f_cekout.ShowDialog();
        }
    }
}