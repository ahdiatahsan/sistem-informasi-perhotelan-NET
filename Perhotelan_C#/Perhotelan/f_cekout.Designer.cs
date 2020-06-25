using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    [DesignerGenerated()]
    public partial class f_cekout : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(f_cekout));
            _L_header = new Label();
            _Panel1 = new Panel();
            _Label1 = new Label();
            _Label2 = new Label();
            _Label3 = new Label();
            _Label4 = new Label();
            _C_id = new ComboBox();
            _C_id.SelectedIndexChanged += new EventHandler(C_id_SelectedIndexChanged);
            _Label6 = new Label();
            _Label7 = new Label();
            _Label8 = new Label();
            _Label9 = new Label();
            _B_simpan = new Button();
            _B_simpan.Click += new EventHandler(B_simpan_Click);
            _B_reset = new Button();
            _B_reset.Click += new EventHandler(B_reset_Click);
            _Label11 = new Label();
            _Label12 = new Label();
            _GroupBox1 = new GroupBox();
            _L_harga = new Label();
            _L_tipe = new Label();
            _L_lantai = new Label();
            _L_kamar = new Label();
            _GroupBox2 = new GroupBox();
            _Label22 = new Label();
            _Label23 = new Label();
            _Label5 = new Label();
            _Label10 = new Label();
            _Label14 = new Label();
            _Label15 = new Label();
            _Label16 = new Label();
            _Label17 = new Label();
            _Label18 = new Label();
            _Label19 = new Label();
            _Label20 = new Label();
            _Label21 = new Label();
            _L_id = new Label();
            _L_nama = new Label();
            _L_jk = new Label();
            _L_alamat = new Label();
            _L_telp = new Label();
            _L_durasi = new Label();
            _L_total = new Label();
            _Label24 = new Label();
            _Label25 = new Label();
            _L_cekin = new Label();
            _Label26 = new Label();
            _Label27 = new Label();
            _L_cekout = new Label();
            _Label29 = new Label();
            _Label30 = new Label();
            _Panel1.SuspendLayout();
            _GroupBox1.SuspendLayout();
            _GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // L_header
            // 
            _L_header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _L_header.BackColor = Color.Transparent;
            _L_header.Font = new Font("Poppins SemiBold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _L_header.ForeColor = Color.White;
            _L_header.Location = new Point(0, 15);
            _L_header.Name = "_L_header";
            _L_header.Size = new Size(862, 42);
            _L_header.TabIndex = 0;
            _L_header.Text = "Check Out Tamu";
            _L_header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Panel1.Controls.Add(_L_header);
            _Panel1.Location = new Point(-2, 0);
            _Panel1.Name = "_Panel1";
            _Panel1.Size = new Size(859, 76);
            _Panel1.TabIndex = 1;
            // 
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.BackColor = Color.Transparent;
            _Label1.Location = new Point(17, 38);
            _Label1.Name = "_Label1";
            _Label1.RightToLeft = RightToLeft.Yes;
            _Label1.Size = new Size(67, 22);
            _Label1.TabIndex = 2;
            _Label1.Text = "ID Kamar";
            // 
            // Label2
            // 
            _Label2.AutoSize = true;
            _Label2.BackColor = Color.Transparent;
            _Label2.Location = new Point(17, 118);
            _Label2.Name = "_Label2";
            _Label2.Size = new Size(48, 22);
            _Label2.TabIndex = 4;
            _Label2.Text = "Lantai";
            // 
            // Label3
            // 
            _Label3.AutoSize = true;
            _Label3.BackColor = Color.Transparent;
            _Label3.Location = new Point(17, 158);
            _Label3.Name = "_Label3";
            _Label3.Size = new Size(80, 22);
            _Label3.TabIndex = 6;
            _Label3.Text = "Tipe Kamar";
            // 
            // Label4
            // 
            _Label4.AutoSize = true;
            _Label4.BackColor = Color.Transparent;
            _Label4.Location = new Point(17, 196);
            _Label4.Name = "_Label4";
            _Label4.Size = new Size(93, 22);
            _Label4.TabIndex = 8;
            _Label4.Text = "Harga Kamar";
            // 
            // C_id
            // 
            _C_id.DropDownStyle = ComboBoxStyle.DropDownList;
            _C_id.FormattingEnabled = true;
            _C_id.Items.AddRange(new object[] { "- Pilih -", "Standard", "Deluxe", "Suite" });
            _C_id.Location = new Point(158, 30);
            _C_id.Name = "_C_id";
            _C_id.Size = new Size(237, 30);
            _C_id.TabIndex = 12;
            _C_id.TabStop = false;
            // 
            // Label6
            // 
            _Label6.AutoSize = true;
            _Label6.BackColor = Color.Transparent;
            _Label6.Location = new Point(139, 38);
            _Label6.Name = "_Label6";
            _Label6.Size = new Size(13, 22);
            _Label6.TabIndex = 13;
            _Label6.Text = ":";
            // 
            // Label7
            // 
            _Label7.AutoSize = true;
            _Label7.BackColor = Color.Transparent;
            _Label7.Location = new Point(139, 117);
            _Label7.Name = "_Label7";
            _Label7.Size = new Size(13, 22);
            _Label7.TabIndex = 14;
            _Label7.Text = ":";
            // 
            // Label8
            // 
            _Label8.AutoSize = true;
            _Label8.BackColor = Color.Transparent;
            _Label8.Location = new Point(139, 158);
            _Label8.Name = "_Label8";
            _Label8.Size = new Size(13, 22);
            _Label8.TabIndex = 15;
            _Label8.Text = ":";
            // 
            // Label9
            // 
            _Label9.AutoSize = true;
            _Label9.BackColor = Color.Transparent;
            _Label9.Location = new Point(139, 198);
            _Label9.Name = "_Label9";
            _Label9.Size = new Size(13, 22);
            _Label9.TabIndex = 16;
            _Label9.Text = ":";
            // 
            // B_simpan
            // 
            _B_simpan.BackColor = Color.DeepSkyBlue;
            _B_simpan.FlatStyle = FlatStyle.Popup;
            _B_simpan.Font = new Font("Poppins SemiBold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _B_simpan.ForeColor = Color.White;
            _B_simpan.ImageAlign = ContentAlignment.MiddleLeft;
            _B_simpan.Location = new Point(668, 429);
            _B_simpan.Name = "_B_simpan";
            _B_simpan.Size = new Size(83, 43);
            _B_simpan.TabIndex = 18;
            _B_simpan.TabStop = false;
            _B_simpan.Text = "Simpan";
            _B_simpan.UseVisualStyleBackColor = false;
            // 
            // B_reset
            // 
            _B_reset.BackColor = Color.Firebrick;
            _B_reset.FlatStyle = FlatStyle.Popup;
            _B_reset.Font = new Font("Poppins SemiBold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _B_reset.ForeColor = Color.White;
            _B_reset.Location = new Point(758, 429);
            _B_reset.Name = "_B_reset";
            _B_reset.Size = new Size(83, 43);
            _B_reset.TabIndex = 19;
            _B_reset.TabStop = false;
            _B_reset.Text = "Reset";
            _B_reset.UseVisualStyleBackColor = false;
            // 
            // Label11
            // 
            _Label11.AutoSize = true;
            _Label11.BackColor = Color.Transparent;
            _Label11.Location = new Point(139, 77);
            _Label11.Name = "_Label11";
            _Label11.Size = new Size(13, 22);
            _Label11.TabIndex = 23;
            _Label11.Text = ":";
            // 
            // Label12
            // 
            _Label12.AutoSize = true;
            _Label12.BackColor = Color.Transparent;
            _Label12.Location = new Point(17, 78);
            _Label12.Name = "_Label12";
            _Label12.Size = new Size(75, 22);
            _Label12.TabIndex = 21;
            _Label12.Text = "No. Kamar";
            // 
            // GroupBox1
            // 
            _GroupBox1.BackColor = Color.Transparent;
            _GroupBox1.Controls.Add(_L_total);
            _GroupBox1.Controls.Add(_L_id);
            _GroupBox1.Controls.Add(_Label24);
            _GroupBox1.Controls.Add(_L_harga);
            _GroupBox1.Controls.Add(_Label25);
            _GroupBox1.Controls.Add(_L_tipe);
            _GroupBox1.Controls.Add(_L_durasi);
            _GroupBox1.Controls.Add(_L_lantai);
            _GroupBox1.Controls.Add(_L_kamar);
            _GroupBox1.Controls.Add(_Label11);
            _GroupBox1.Controls.Add(_Label12);
            _GroupBox1.Controls.Add(_Label9);
            _GroupBox1.Controls.Add(_Label22);
            _GroupBox1.Controls.Add(_Label8);
            _GroupBox1.Controls.Add(_Label23);
            _GroupBox1.Controls.Add(_Label7);
            _GroupBox1.Controls.Add(_Label6);
            _GroupBox1.Controls.Add(_Label4);
            _GroupBox1.Controls.Add(_Label3);
            _GroupBox1.Controls.Add(_Label2);
            _GroupBox1.Controls.Add(_Label1);
            _GroupBox1.FlatStyle = FlatStyle.Flat;
            _GroupBox1.Location = new Point(14, 95);
            _GroupBox1.Name = "_GroupBox1";
            _GroupBox1.Size = new Size(420, 319);
            _GroupBox1.TabIndex = 24;
            _GroupBox1.TabStop = false;
            _GroupBox1.Text = "Kamar";
            // 
            // L_harga
            // 
            _L_harga.AutoSize = true;
            _L_harga.BackColor = Color.Transparent;
            _L_harga.Location = new Point(158, 198);
            _L_harga.Name = "_L_harga";
            _L_harga.Size = new Size(93, 22);
            _L_harga.TabIndex = 27;
            _L_harga.Text = "Harga Kamar";
            // 
            // L_tipe
            // 
            _L_tipe.AutoSize = true;
            _L_tipe.BackColor = Color.Transparent;
            _L_tipe.Location = new Point(158, 158);
            _L_tipe.Name = "_L_tipe";
            _L_tipe.Size = new Size(80, 22);
            _L_tipe.TabIndex = 26;
            _L_tipe.Text = "Tipe Kamar";
            // 
            // L_lantai
            // 
            _L_lantai.AutoSize = true;
            _L_lantai.BackColor = Color.Transparent;
            _L_lantai.Location = new Point(158, 118);
            _L_lantai.Name = "_L_lantai";
            _L_lantai.Size = new Size(48, 22);
            _L_lantai.TabIndex = 25;
            _L_lantai.Text = "Lantai";
            // 
            // L_kamar
            // 
            _L_kamar.AutoSize = true;
            _L_kamar.BackColor = Color.Transparent;
            _L_kamar.Location = new Point(158, 77);
            _L_kamar.Name = "_L_kamar";
            _L_kamar.Size = new Size(75, 22);
            _L_kamar.TabIndex = 24;
            _L_kamar.Text = "No. Kamar";
            // 
            // GroupBox2
            // 
            _GroupBox2.BackColor = Color.Transparent;
            _GroupBox2.Controls.Add(_L_cekout);
            _GroupBox2.Controls.Add(_Label29);
            _GroupBox2.Controls.Add(_Label30);
            _GroupBox2.Controls.Add(_L_cekin);
            _GroupBox2.Controls.Add(_Label26);
            _GroupBox2.Controls.Add(_Label27);
            _GroupBox2.Controls.Add(_L_telp);
            _GroupBox2.Controls.Add(_L_alamat);
            _GroupBox2.Controls.Add(_L_jk);
            _GroupBox2.Controls.Add(_L_nama);
            _GroupBox2.Controls.Add(_Label5);
            _GroupBox2.Controls.Add(_Label10);
            _GroupBox2.Controls.Add(_Label14);
            _GroupBox2.Controls.Add(_Label15);
            _GroupBox2.Controls.Add(_Label16);
            _GroupBox2.Controls.Add(_Label17);
            _GroupBox2.Controls.Add(_Label18);
            _GroupBox2.Controls.Add(_C_id);
            _GroupBox2.Controls.Add(_Label19);
            _GroupBox2.Controls.Add(_Label20);
            _GroupBox2.Controls.Add(_Label21);
            _GroupBox2.FlatStyle = FlatStyle.Flat;
            _GroupBox2.Location = new Point(440, 95);
            _GroupBox2.Name = "_GroupBox2";
            _GroupBox2.Size = new Size(420, 319);
            _GroupBox2.TabIndex = 25;
            _GroupBox2.TabStop = false;
            _GroupBox2.Text = "Tamu";
            // 
            // Label22
            // 
            _Label22.AutoSize = true;
            _Label22.BackColor = Color.Transparent;
            _Label22.Location = new Point(139, 236);
            _Label22.Name = "_Label22";
            _Label22.Size = new Size(13, 22);
            _Label22.TabIndex = 26;
            _Label22.Text = ":";
            // 
            // Label23
            // 
            _Label23.AutoSize = true;
            _Label23.BackColor = Color.Transparent;
            _Label23.Location = new Point(17, 236);
            _Label23.Name = "_Label23";
            _Label23.Size = new Size(79, 22);
            _Label23.TabIndex = 24;
            _Label23.Text = "Durasi Inap";
            // 
            // Label5
            // 
            _Label5.AutoSize = true;
            _Label5.BackColor = Color.Transparent;
            _Label5.Location = new Point(139, 77);
            _Label5.Name = "_Label5";
            _Label5.Size = new Size(13, 22);
            _Label5.TabIndex = 23;
            _Label5.Text = ":";
            // 
            // Label10
            // 
            _Label10.AutoSize = true;
            _Label10.BackColor = Color.Transparent;
            _Label10.Location = new Point(17, 78);
            _Label10.Name = "_Label10";
            _Label10.Size = new Size(103, 22);
            _Label10.TabIndex = 21;
            _Label10.Text = "Nama Lengkap";
            // 
            // Label14
            // 
            _Label14.AutoSize = true;
            _Label14.BackColor = Color.Transparent;
            _Label14.Location = new Point(139, 196);
            _Label14.Name = "_Label14";
            _Label14.Size = new Size(13, 22);
            _Label14.TabIndex = 16;
            _Label14.Text = ":";
            // 
            // Label15
            // 
            _Label15.AutoSize = true;
            _Label15.BackColor = Color.Transparent;
            _Label15.Location = new Point(139, 156);
            _Label15.Name = "_Label15";
            _Label15.Size = new Size(13, 22);
            _Label15.TabIndex = 15;
            _Label15.Text = ":";
            // 
            // Label16
            // 
            _Label16.AutoSize = true;
            _Label16.BackColor = Color.Transparent;
            _Label16.Location = new Point(139, 117);
            _Label16.Name = "_Label16";
            _Label16.Size = new Size(13, 22);
            _Label16.TabIndex = 14;
            _Label16.Text = ":";
            // 
            // Label17
            // 
            _Label17.AutoSize = true;
            _Label17.BackColor = Color.Transparent;
            _Label17.Location = new Point(139, 38);
            _Label17.Name = "_Label17";
            _Label17.Size = new Size(13, 22);
            _Label17.TabIndex = 13;
            _Label17.Text = ":";
            // 
            // Label18
            // 
            _Label18.AutoSize = true;
            _Label18.BackColor = Color.Transparent;
            _Label18.Location = new Point(17, 195);
            _Label18.Name = "_Label18";
            _Label18.Size = new Size(58, 22);
            _Label18.TabIndex = 8;
            _Label18.Text = "No. Telp";
            // 
            // Label19
            // 
            _Label19.AutoSize = true;
            _Label19.BackColor = Color.Transparent;
            _Label19.Location = new Point(17, 156);
            _Label19.Name = "_Label19";
            _Label19.Size = new Size(55, 22);
            _Label19.TabIndex = 6;
            _Label19.Text = "Alamat";
            // 
            // Label20
            // 
            _Label20.AutoSize = true;
            _Label20.BackColor = Color.Transparent;
            _Label20.Location = new Point(17, 118);
            _Label20.Name = "_Label20";
            _Label20.Size = new Size(93, 22);
            _Label20.TabIndex = 4;
            _Label20.Text = "Jenis Kelamin";
            // 
            // Label21
            // 
            _Label21.AutoSize = true;
            _Label21.BackColor = Color.Transparent;
            _Label21.Location = new Point(18, 38);
            _Label21.Name = "_Label21";
            _Label21.RightToLeft = RightToLeft.Yes;
            _Label21.Size = new Size(61, 22);
            _Label21.TabIndex = 2;
            _Label21.Text = "ID Tamu";
            // 
            // L_id
            // 
            _L_id.AutoSize = true;
            _L_id.BackColor = Color.Transparent;
            _L_id.Location = new Point(158, 38);
            _L_id.Name = "_L_id";
            _L_id.Size = new Size(72, 22);
            _L_id.TabIndex = 28;
            _L_id.Text = "ID_Kamar";
            // 
            // L_nama
            // 
            _L_nama.AutoSize = true;
            _L_nama.BackColor = Color.Transparent;
            _L_nama.Location = new Point(158, 77);
            _L_nama.Name = "_L_nama";
            _L_nama.Size = new Size(87, 22);
            _L_nama.TabIndex = 29;
            _L_nama.Text = "Nama Tamu";
            // 
            // L_jk
            // 
            _L_jk.AutoSize = true;
            _L_jk.BackColor = Color.Transparent;
            _L_jk.Location = new Point(158, 118);
            _L_jk.Name = "_L_jk";
            _L_jk.Size = new Size(93, 22);
            _L_jk.TabIndex = 30;
            _L_jk.Text = "Jenis Kelamin";
            // 
            // L_alamat
            // 
            _L_alamat.AutoSize = true;
            _L_alamat.BackColor = Color.Transparent;
            _L_alamat.Location = new Point(158, 156);
            _L_alamat.Name = "_L_alamat";
            _L_alamat.Size = new Size(55, 22);
            _L_alamat.TabIndex = 31;
            _L_alamat.Text = "Alamat";
            // 
            // L_telp
            // 
            _L_telp.AutoSize = true;
            _L_telp.BackColor = Color.Transparent;
            _L_telp.Location = new Point(158, 195);
            _L_telp.Name = "_L_telp";
            _L_telp.Size = new Size(58, 22);
            _L_telp.TabIndex = 32;
            _L_telp.Text = "No. Telp";
            // 
            // L_durasi
            // 
            _L_durasi.AutoSize = true;
            _L_durasi.BackColor = Color.Transparent;
            _L_durasi.Location = new Point(158, 236);
            _L_durasi.Name = "_L_durasi";
            _L_durasi.Size = new Size(79, 22);
            _L_durasi.TabIndex = 33;
            _L_durasi.Text = "Durasi Inap";
            // 
            // L_total
            // 
            _L_total.AutoSize = true;
            _L_total.BackColor = Color.Transparent;
            _L_total.Location = new Point(158, 277);
            _L_total.Name = "_L_total";
            _L_total.Size = new Size(80, 22);
            _L_total.TabIndex = 36;
            _L_total.Text = "Total Bayar";
            // 
            // Label24
            // 
            _Label24.AutoSize = true;
            _Label24.BackColor = Color.Transparent;
            _Label24.Location = new Point(139, 277);
            _Label24.Name = "_Label24";
            _Label24.Size = new Size(13, 22);
            _Label24.TabIndex = 35;
            _Label24.Text = ":";
            // 
            // Label25
            // 
            _Label25.AutoSize = true;
            _Label25.BackColor = Color.Transparent;
            _Label25.Location = new Point(17, 277);
            _Label25.Name = "_Label25";
            _Label25.Size = new Size(80, 22);
            _Label25.TabIndex = 34;
            _Label25.Text = "Total Bayar";
            // 
            // L_cekin
            // 
            _L_cekin.AutoSize = true;
            _L_cekin.BackColor = Color.Transparent;
            _L_cekin.Location = new Point(158, 235);
            _L_cekin.Name = "_L_cekin";
            _L_cekin.Size = new Size(67, 22);
            _L_cekin.TabIndex = 35;
            _L_cekin.Text = "Check_In";
            // 
            // Label26
            // 
            _Label26.AutoSize = true;
            _Label26.BackColor = Color.Transparent;
            _Label26.Location = new Point(139, 236);
            _Label26.Name = "_Label26";
            _Label26.Size = new Size(13, 22);
            _Label26.TabIndex = 34;
            _Label26.Text = ":";
            // 
            // Label27
            // 
            _Label27.AutoSize = true;
            _Label27.BackColor = Color.Transparent;
            _Label27.Location = new Point(17, 235);
            _Label27.Name = "_Label27";
            _Label27.Size = new Size(67, 22);
            _Label27.TabIndex = 33;
            _Label27.Text = "Check_In";
            // 
            // L_cekout
            // 
            _L_cekout.AutoSize = true;
            _L_cekout.BackColor = Color.Transparent;
            _L_cekout.Location = new Point(158, 275);
            _L_cekout.Name = "_L_cekout";
            _L_cekout.Size = new Size(78, 22);
            _L_cekout.TabIndex = 38;
            _L_cekout.Text = "Check_Out";
            // 
            // Label29
            // 
            _Label29.AutoSize = true;
            _Label29.BackColor = Color.Transparent;
            _Label29.Location = new Point(139, 275);
            _Label29.Name = "_Label29";
            _Label29.Size = new Size(13, 22);
            _Label29.TabIndex = 37;
            _Label29.Text = ":";
            // 
            // Label30
            // 
            _Label30.AutoSize = true;
            _Label30.BackColor = Color.Transparent;
            _Label30.Location = new Point(17, 274);
            _Label30.Name = "_Label30";
            _Label30.Size = new Size(78, 22);
            _Label30.TabIndex = 36;
            _Label30.Text = "Check_Out";
            // 
            // f_cekout
            // 
            AutoScaleDimensions = new SizeF(7.0F, 22.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 484);
            Controls.Add(_GroupBox2);
            Controls.Add(_GroupBox1);
            Controls.Add(_B_reset);
            Controls.Add(_B_simpan);
            Controls.Add(_Panel1);
            Font = new Font("Poppins SemiBold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "f_cekout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Out Tamu";
            _Panel1.ResumeLayout(false);
            _GroupBox1.ResumeLayout(false);
            _GroupBox1.PerformLayout();
            _GroupBox2.ResumeLayout(false);
            _GroupBox2.PerformLayout();
            Load += new EventHandler(f_cekout_Load);
            ResumeLayout(false);
        }

        private Label _L_header;

        internal Label L_header
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_header;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_header != null)
                {
                }

                _L_header = value;
                if (_L_header != null)
                {
                }
            }
        }

        private Panel _Panel1;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }

        private Label _Label1;

        internal Label Label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label1 != null)
                {
                }

                _Label1 = value;
                if (_Label1 != null)
                {
                }
            }
        }

        private Label _Label2;

        internal Label Label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label2 != null)
                {
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                }
            }
        }

        private Label _Label3;

        internal Label Label3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label3 != null)
                {
                }

                _Label3 = value;
                if (_Label3 != null)
                {
                }
            }
        }

        private Label _Label4;

        internal Label Label4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label4 != null)
                {
                }

                _Label4 = value;
                if (_Label4 != null)
                {
                }
            }
        }

        private ComboBox _C_id;

        internal ComboBox C_id
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _C_id;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_C_id != null)
                {
                    _C_id.SelectedIndexChanged -= C_id_SelectedIndexChanged;
                }

                _C_id = value;
                if (_C_id != null)
                {
                    _C_id.SelectedIndexChanged += C_id_SelectedIndexChanged;
                }
            }
        }

        private Label _Label6;

        internal Label Label6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label6 != null)
                {
                }

                _Label6 = value;
                if (_Label6 != null)
                {
                }
            }
        }

        private Label _Label7;

        internal Label Label7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label7 != null)
                {
                }

                _Label7 = value;
                if (_Label7 != null)
                {
                }
            }
        }

        private Label _Label8;

        internal Label Label8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label8 != null)
                {
                }

                _Label8 = value;
                if (_Label8 != null)
                {
                }
            }
        }

        private Label _Label9;

        internal Label Label9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label9 != null)
                {
                }

                _Label9 = value;
                if (_Label9 != null)
                {
                }
            }
        }

        private Button _B_simpan;

        internal Button B_simpan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_simpan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_simpan != null)
                {
                    _B_simpan.Click -= B_simpan_Click;
                }

                _B_simpan = value;
                if (_B_simpan != null)
                {
                    _B_simpan.Click += B_simpan_Click;
                }
            }
        }

        private Button _B_reset;

        internal Button B_reset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_reset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_reset != null)
                {
                    _B_reset.Click -= B_reset_Click;
                }

                _B_reset = value;
                if (_B_reset != null)
                {
                    _B_reset.Click += B_reset_Click;
                }
            }
        }

        private Label _Label11;

        internal Label Label11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label11 != null)
                {
                }

                _Label11 = value;
                if (_Label11 != null)
                {
                }
            }
        }

        private Label _Label12;

        internal Label Label12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label12 != null)
                {
                }

                _Label12 = value;
                if (_Label12 != null)
                {
                }
            }
        }

        private GroupBox _GroupBox1;

        internal GroupBox GroupBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox1 != null)
                {
                }

                _GroupBox1 = value;
                if (_GroupBox1 != null)
                {
                }
            }
        }

        private Label _L_harga;

        internal Label L_harga
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_harga;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_harga != null)
                {
                }

                _L_harga = value;
                if (_L_harga != null)
                {
                }
            }
        }

        private Label _L_tipe;

        internal Label L_tipe
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_tipe;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_tipe != null)
                {
                }

                _L_tipe = value;
                if (_L_tipe != null)
                {
                }
            }
        }

        private Label _L_lantai;

        internal Label L_lantai
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_lantai;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_lantai != null)
                {
                }

                _L_lantai = value;
                if (_L_lantai != null)
                {
                }
            }
        }

        private Label _L_kamar;

        internal Label L_kamar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_kamar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_kamar != null)
                {
                }

                _L_kamar = value;
                if (_L_kamar != null)
                {
                }
            }
        }

        private GroupBox _GroupBox2;

        internal GroupBox GroupBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox2 != null)
                {
                }

                _GroupBox2 = value;
                if (_GroupBox2 != null)
                {
                }
            }
        }

        private Label _Label5;

        internal Label Label5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label5 != null)
                {
                }

                _Label5 = value;
                if (_Label5 != null)
                {
                }
            }
        }

        private Label _Label10;

        internal Label Label10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label10 != null)
                {
                }

                _Label10 = value;
                if (_Label10 != null)
                {
                }
            }
        }

        private Label _Label14;

        internal Label Label14
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label14;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label14 != null)
                {
                }

                _Label14 = value;
                if (_Label14 != null)
                {
                }
            }
        }

        private Label _Label15;

        internal Label Label15
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label15;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label15 != null)
                {
                }

                _Label15 = value;
                if (_Label15 != null)
                {
                }
            }
        }

        private Label _Label16;

        internal Label Label16
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label16;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label16 != null)
                {
                }

                _Label16 = value;
                if (_Label16 != null)
                {
                }
            }
        }

        private Label _Label17;

        internal Label Label17
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label17;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label17 != null)
                {
                }

                _Label17 = value;
                if (_Label17 != null)
                {
                }
            }
        }

        private Label _Label18;

        internal Label Label18
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label18;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label18 != null)
                {
                }

                _Label18 = value;
                if (_Label18 != null)
                {
                }
            }
        }

        private Label _Label19;

        internal Label Label19
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label19;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label19 != null)
                {
                }

                _Label19 = value;
                if (_Label19 != null)
                {
                }
            }
        }

        private Label _Label20;

        internal Label Label20
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label20;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label20 != null)
                {
                }

                _Label20 = value;
                if (_Label20 != null)
                {
                }
            }
        }

        private Label _Label21;

        internal Label Label21
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label21;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label21 != null)
                {
                }

                _Label21 = value;
                if (_Label21 != null)
                {
                }
            }
        }

        private Label _Label22;

        internal Label Label22
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label22;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label22 != null)
                {
                }

                _Label22 = value;
                if (_Label22 != null)
                {
                }
            }
        }

        private Label _Label23;

        internal Label Label23
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label23;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label23 != null)
                {
                }

                _Label23 = value;
                if (_Label23 != null)
                {
                }
            }
        }

        private Label _L_id;

        internal Label L_id
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_id;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_id != null)
                {
                }

                _L_id = value;
                if (_L_id != null)
                {
                }
            }
        }

        private Label _L_total;

        internal Label L_total
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_total;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_total != null)
                {
                }

                _L_total = value;
                if (_L_total != null)
                {
                }
            }
        }

        private Label _Label24;

        internal Label Label24
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label24;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label24 != null)
                {
                }

                _Label24 = value;
                if (_Label24 != null)
                {
                }
            }
        }

        private Label _Label25;

        internal Label Label25
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label25;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label25 != null)
                {
                }

                _Label25 = value;
                if (_Label25 != null)
                {
                }
            }
        }

        private Label _L_durasi;

        internal Label L_durasi
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_durasi;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_durasi != null)
                {
                }

                _L_durasi = value;
                if (_L_durasi != null)
                {
                }
            }
        }

        private Label _L_telp;

        internal Label L_telp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_telp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_telp != null)
                {
                }

                _L_telp = value;
                if (_L_telp != null)
                {
                }
            }
        }

        private Label _L_alamat;

        internal Label L_alamat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_alamat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_alamat != null)
                {
                }

                _L_alamat = value;
                if (_L_alamat != null)
                {
                }
            }
        }

        private Label _L_jk;

        internal Label L_jk
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_jk;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_jk != null)
                {
                }

                _L_jk = value;
                if (_L_jk != null)
                {
                }
            }
        }

        private Label _L_nama;

        internal Label L_nama
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_nama;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_nama != null)
                {
                }

                _L_nama = value;
                if (_L_nama != null)
                {
                }
            }
        }

        private Label _L_cekin;

        internal Label L_cekin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_cekin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_cekin != null)
                {
                }

                _L_cekin = value;
                if (_L_cekin != null)
                {
                }
            }
        }

        private Label _Label26;

        internal Label Label26
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label26;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label26 != null)
                {
                }

                _Label26 = value;
                if (_Label26 != null)
                {
                }
            }
        }

        private Label _Label27;

        internal Label Label27
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label27;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label27 != null)
                {
                }

                _Label27 = value;
                if (_Label27 != null)
                {
                }
            }
        }

        private Label _L_cekout;

        internal Label L_cekout
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _L_cekout;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_L_cekout != null)
                {
                }

                _L_cekout = value;
                if (_L_cekout != null)
                {
                }
            }
        }

        private Label _Label29;

        internal Label Label29
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label29;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label29 != null)
                {
                }

                _Label29 = value;
                if (_Label29 != null)
                {
                }
            }
        }

        private Label _Label30;

        internal Label Label30
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label30;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label30 != null)
                {
                }

                _Label30 = value;
                if (_Label30 != null)
                {
                }
            }
        }
    }
}