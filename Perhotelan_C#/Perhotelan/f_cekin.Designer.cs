using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    [DesignerGenerated()]
    public partial class f_cekin : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(f_cekin));
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
            _Label24 = new Label();
            _Label22 = new Label();
            _T_durasi = new TextBox();
            _Label23 = new Label();
            _Label5 = new Label();
            _T_nama = new TextBox();
            _Label10 = new Label();
            _Label13 = new Label();
            _Label14 = new Label();
            _Label15 = new Label();
            _Label16 = new Label();
            _Label17 = new Label();
            _C_jk = new ComboBox();
            _T_telp = new TextBox();
            _Label18 = new Label();
            _Label19 = new Label();
            _T_alamat = new TextBox();
            _Label20 = new Label();
            _Label21 = new Label();
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
            _L_header.Text = "Check In Tamu";
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
            _Label4.Location = new Point(17, 198);
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
            _C_id.Location = new Point(158, 35);
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
            _Label9.Location = new Point(139, 201);
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
            _B_simpan.Location = new Point(668, 408);
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
            _B_reset.Location = new Point(758, 408);
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
            _GroupBox1.Controls.Add(_L_harga);
            _GroupBox1.Controls.Add(_L_tipe);
            _GroupBox1.Controls.Add(_L_lantai);
            _GroupBox1.Controls.Add(_L_kamar);
            _GroupBox1.Controls.Add(_Label11);
            _GroupBox1.Controls.Add(_Label12);
            _GroupBox1.Controls.Add(_Label9);
            _GroupBox1.Controls.Add(_Label8);
            _GroupBox1.Controls.Add(_Label7);
            _GroupBox1.Controls.Add(_Label6);
            _GroupBox1.Controls.Add(_C_id);
            _GroupBox1.Controls.Add(_Label4);
            _GroupBox1.Controls.Add(_Label3);
            _GroupBox1.Controls.Add(_Label2);
            _GroupBox1.Controls.Add(_Label1);
            _GroupBox1.FlatStyle = FlatStyle.Flat;
            _GroupBox1.Location = new Point(14, 95);
            _GroupBox1.Name = "_GroupBox1";
            _GroupBox1.Size = new Size(420, 297);
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
            _GroupBox2.Controls.Add(_Label24);
            _GroupBox2.Controls.Add(_Label22);
            _GroupBox2.Controls.Add(_T_durasi);
            _GroupBox2.Controls.Add(_Label23);
            _GroupBox2.Controls.Add(_Label5);
            _GroupBox2.Controls.Add(_T_nama);
            _GroupBox2.Controls.Add(_Label10);
            _GroupBox2.Controls.Add(_Label13);
            _GroupBox2.Controls.Add(_Label14);
            _GroupBox2.Controls.Add(_Label15);
            _GroupBox2.Controls.Add(_Label16);
            _GroupBox2.Controls.Add(_Label17);
            _GroupBox2.Controls.Add(_C_jk);
            _GroupBox2.Controls.Add(_T_telp);
            _GroupBox2.Controls.Add(_Label18);
            _GroupBox2.Controls.Add(_Label19);
            _GroupBox2.Controls.Add(_T_alamat);
            _GroupBox2.Controls.Add(_Label20);
            _GroupBox2.Controls.Add(_Label21);
            _GroupBox2.FlatStyle = FlatStyle.Flat;
            _GroupBox2.Location = new Point(440, 95);
            _GroupBox2.Name = "_GroupBox2";
            _GroupBox2.Size = new Size(420, 297);
            _GroupBox2.TabIndex = 25;
            _GroupBox2.TabStop = false;
            _GroupBox2.Text = "Tamu";
            // 
            // Label24
            // 
            _Label24.AutoSize = true;
            _Label24.BackColor = Color.Transparent;
            _Label24.Location = new Point(226, 246);
            _Label24.Name = "_Label24";
            _Label24.Size = new Size(62, 22);
            _Label24.TabIndex = 27;
            _Label24.Text = "- Malam";
            // 
            // Label22
            // 
            _Label22.AutoSize = true;
            _Label22.BackColor = Color.Transparent;
            _Label22.Location = new Point(139, 248);
            _Label22.Name = "_Label22";
            _Label22.Size = new Size(13, 22);
            _Label22.TabIndex = 26;
            _Label22.Text = ":";
            // 
            // T_durasi
            // 
            _T_durasi.Location = new Point(158, 245);
            _T_durasi.MaxLength = 2;
            _T_durasi.Name = "_T_durasi";
            _T_durasi.Size = new Size(61, 25);
            _T_durasi.TabIndex = 25;
            _T_durasi.TabStop = false;
            // 
            // Label23
            // 
            _Label23.AutoSize = true;
            _Label23.BackColor = Color.Transparent;
            _Label23.Location = new Point(17, 245);
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
            // T_nama
            // 
            _T_nama.Location = new Point(158, 77);
            _T_nama.Name = "_T_nama";
            _T_nama.Size = new Size(240, 25);
            _T_nama.TabIndex = 22;
            _T_nama.TabStop = false;
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
            // Label13
            // 
            _Label13.AutoSize = true;
            _Label13.BackColor = Color.Transparent;
            _Label13.Location = new Point(158, 38);
            _Label13.Name = "_Label13";
            _Label13.Size = new Size(16, 22);
            _Label13.TabIndex = 20;
            _Label13.Text = "-";
            // 
            // Label14
            // 
            _Label14.AutoSize = true;
            _Label14.BackColor = Color.Transparent;
            _Label14.Location = new Point(139, 205);
            _Label14.Name = "_Label14";
            _Label14.Size = new Size(13, 22);
            _Label14.TabIndex = 16;
            _Label14.Text = ":";
            // 
            // Label15
            // 
            _Label15.AutoSize = true;
            _Label15.BackColor = Color.Transparent;
            _Label15.Location = new Point(139, 161);
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
            // C_jk
            // 
            _C_jk.DropDownStyle = ComboBoxStyle.DropDownList;
            _C_jk.FormattingEnabled = true;
            _C_jk.Items.AddRange(new object[] { "- Pilih -", "Laki-Laki", "Perempuan" });
            _C_jk.Location = new Point(158, 115);
            _C_jk.Name = "_C_jk";
            _C_jk.Size = new Size(237, 30);
            _C_jk.TabIndex = 12;
            _C_jk.TabStop = false;
            // 
            // T_telp
            // 
            _T_telp.Location = new Point(158, 202);
            _T_telp.MaxLength = 15;
            _T_telp.Name = "_T_telp";
            _T_telp.Size = new Size(240, 25);
            _T_telp.TabIndex = 9;
            _T_telp.TabStop = false;
            // 
            // Label18
            // 
            _Label18.AutoSize = true;
            _Label18.BackColor = Color.Transparent;
            _Label18.Location = new Point(17, 202);
            _Label18.Name = "_Label18";
            _Label18.Size = new Size(58, 22);
            _Label18.TabIndex = 8;
            _Label18.Text = "No. Telp";
            // 
            // Label19
            // 
            _Label19.AutoSize = true;
            _Label19.BackColor = Color.Transparent;
            _Label19.Location = new Point(17, 161);
            _Label19.Name = "_Label19";
            _Label19.Size = new Size(55, 22);
            _Label19.TabIndex = 6;
            _Label19.Text = "Alamat";
            // 
            // T_alamat
            // 
            _T_alamat.Location = new Point(158, 158);
            _T_alamat.Name = "_T_alamat";
            _T_alamat.Size = new Size(240, 25);
            _T_alamat.TabIndex = 5;
            _T_alamat.TabStop = false;
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
            _Label21.Location = new Point(17, 38);
            _Label21.Name = "_Label21";
            _Label21.RightToLeft = RightToLeft.Yes;
            _Label21.Size = new Size(61, 22);
            _Label21.TabIndex = 2;
            _Label21.Text = "ID Tamu";
            // 
            // f_cekin
            // 
            AutoScaleDimensions = new SizeF(7.0F, 22.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 463);
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
            Name = "f_cekin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check In Tamu";
            _Panel1.ResumeLayout(false);
            _GroupBox1.ResumeLayout(false);
            _GroupBox1.PerformLayout();
            _GroupBox2.ResumeLayout(false);
            _GroupBox2.PerformLayout();
            Load += new EventHandler(f_cekin_Load);
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

        private TextBox _T_nama;

        internal TextBox T_nama
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_nama;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_nama != null)
                {
                }

                _T_nama = value;
                if (_T_nama != null)
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

        private Label _Label13;

        internal Label Label13
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label13;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label13 != null)
                {
                }

                _Label13 = value;
                if (_Label13 != null)
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

        private ComboBox _C_jk;

        internal ComboBox C_jk
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _C_jk;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_C_jk != null)
                {
                }

                _C_jk = value;
                if (_C_jk != null)
                {
                }
            }
        }

        private TextBox _T_telp;

        internal TextBox T_telp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_telp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_telp != null)
                {
                }

                _T_telp = value;
                if (_T_telp != null)
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

        private TextBox _T_alamat;

        internal TextBox T_alamat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_alamat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_alamat != null)
                {
                }

                _T_alamat = value;
                if (_T_alamat != null)
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

        private TextBox _T_durasi;

        internal TextBox T_durasi
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_durasi;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_durasi != null)
                {
                }

                _T_durasi = value;
                if (_T_durasi != null)
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
    }
}