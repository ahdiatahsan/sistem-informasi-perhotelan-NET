using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    [DesignerGenerated()]
    public partial class f_input_edit_karyawan : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(f_input_edit_karyawan));
            _Panel1 = new Panel();
            _L_header = new Label();
            _Label1 = new Label();
            _T_id = new TextBox();
            _T_nama = new TextBox();
            _Label2 = new Label();
            _Label3 = new Label();
            _T_alamat = new TextBox();
            _Label4 = new Label();
            _T_telp = new TextBox();
            _Label5 = new Label();
            _C_jk = new ComboBox();
            _Label6 = new Label();
            _Label7 = new Label();
            _Label8 = new Label();
            _Label9 = new Label();
            _Label10 = new Label();
            _B_simpan = new Button();
            _B_simpan.Click += new EventHandler(B_simpan_Click);
            _B_reset = new Button();
            _B_reset.Click += new EventHandler(B_reset_Click);
            _L_id = new Label();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _Panel1.Controls.Add(_L_header);
            _Panel1.Location = new Point(-2, 0);
            _Panel1.Name = "_Panel1";
            _Panel1.Size = new Size(408, 76);
            _Panel1.TabIndex = 1;
            // 
            // L_header
            // 
            _L_header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _L_header.BackColor = Color.Transparent;
            _L_header.Font = new Font("Poppins SemiBold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _L_header.ForeColor = Color.White;
            _L_header.Location = new Point(0, 17);
            _L_header.Name = "_L_header";
            _L_header.Size = new Size(408, 42);
            _L_header.TabIndex = 1;
            _L_header.Text = "Label Header";
            _L_header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.BackColor = Color.Transparent;
            _Label1.Location = new Point(12, 99);
            _Label1.Name = "_Label1";
            _Label1.Size = new Size(87, 22);
            _Label1.TabIndex = 2;
            _Label1.Text = "ID Karyawan";
            // 
            // T_id
            // 
            _T_id.Enabled = false;
            _T_id.Location = new Point(153, 98);
            _T_id.Name = "_T_id";
            _T_id.ReadOnly = true;
            _T_id.Size = new Size(240, 25);
            _T_id.TabIndex = 3;
            // 
            // T_nama
            // 
            _T_nama.Location = new Point(153, 138);
            _T_nama.Name = "_T_nama";
            _T_nama.Size = new Size(240, 25);
            _T_nama.TabIndex = 5;
            // 
            // Label2
            // 
            _Label2.AutoSize = true;
            _Label2.BackColor = Color.Transparent;
            _Label2.Location = new Point(12, 139);
            _Label2.Name = "_Label2";
            _Label2.Size = new Size(113, 22);
            _Label2.TabIndex = 4;
            _Label2.Text = "Nama Karyawan";
            // 
            // Label3
            // 
            _Label3.AutoSize = true;
            _Label3.BackColor = Color.Transparent;
            _Label3.Location = new Point(12, 181);
            _Label3.Name = "_Label3";
            _Label3.Size = new Size(93, 22);
            _Label3.TabIndex = 6;
            _Label3.Text = "Jenis Kelamin";
            // 
            // T_alamat
            // 
            _T_alamat.Location = new Point(153, 222);
            _T_alamat.Name = "_T_alamat";
            _T_alamat.Size = new Size(240, 25);
            _T_alamat.TabIndex = 9;
            // 
            // Label4
            // 
            _Label4.AutoSize = true;
            _Label4.BackColor = Color.Transparent;
            _Label4.Location = new Point(12, 222);
            _Label4.Name = "_Label4";
            _Label4.Size = new Size(55, 22);
            _Label4.TabIndex = 8;
            _Label4.Text = "Alamat";
            // 
            // T_telp
            // 
            _T_telp.Location = new Point(153, 264);
            _T_telp.MaxLength = 15;
            _T_telp.Name = "_T_telp";
            _T_telp.Size = new Size(240, 25);
            _T_telp.TabIndex = 11;
            // 
            // Label5
            // 
            _Label5.AutoSize = true;
            _Label5.BackColor = Color.Transparent;
            _Label5.Location = new Point(12, 264);
            _Label5.Name = "_Label5";
            _Label5.Size = new Size(58, 22);
            _Label5.TabIndex = 10;
            _Label5.Text = "No. Telp";
            // 
            // C_jk
            // 
            _C_jk.DropDownStyle = ComboBoxStyle.DropDownList;
            _C_jk.FormattingEnabled = true;
            _C_jk.Items.AddRange(new object[] { "- Pilih -", "Laki-Laki", "Perempuan" });
            _C_jk.Location = new Point(153, 178);
            _C_jk.Name = "_C_jk";
            _C_jk.Size = new Size(237, 30);
            _C_jk.TabIndex = 12;
            // 
            // Label6
            // 
            _Label6.AutoSize = true;
            _Label6.BackColor = Color.Transparent;
            _Label6.Location = new Point(134, 99);
            _Label6.Name = "_Label6";
            _Label6.Size = new Size(13, 22);
            _Label6.TabIndex = 13;
            _Label6.Text = ":";
            // 
            // Label7
            // 
            _Label7.AutoSize = true;
            _Label7.BackColor = Color.Transparent;
            _Label7.Location = new Point(134, 138);
            _Label7.Name = "_Label7";
            _Label7.Size = new Size(13, 22);
            _Label7.TabIndex = 14;
            _Label7.Text = ":";
            // 
            // Label8
            // 
            _Label8.AutoSize = true;
            _Label8.BackColor = Color.Transparent;
            _Label8.Location = new Point(134, 181);
            _Label8.Name = "_Label8";
            _Label8.Size = new Size(13, 22);
            _Label8.TabIndex = 15;
            _Label8.Text = ":";
            // 
            // Label9
            // 
            _Label9.AutoSize = true;
            _Label9.BackColor = Color.Transparent;
            _Label9.Location = new Point(134, 225);
            _Label9.Name = "_Label9";
            _Label9.Size = new Size(13, 22);
            _Label9.TabIndex = 16;
            _Label9.Text = ":";
            // 
            // Label10
            // 
            _Label10.AutoSize = true;
            _Label10.BackColor = Color.Transparent;
            _Label10.Location = new Point(134, 267);
            _Label10.Name = "_Label10";
            _Label10.Size = new Size(13, 22);
            _Label10.TabIndex = 17;
            _Label10.Text = ":";
            // 
            // B_simpan
            // 
            _B_simpan.BackColor = Color.DeepSkyBlue;
            _B_simpan.FlatStyle = FlatStyle.Popup;
            _B_simpan.Font = new Font("Poppins SemiBold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _B_simpan.ForeColor = Color.White;
            _B_simpan.ImageAlign = ContentAlignment.MiddleLeft;
            _B_simpan.Location = new Point(223, 302);
            _B_simpan.Name = "_B_simpan";
            _B_simpan.Size = new Size(83, 43);
            _B_simpan.TabIndex = 18;
            _B_simpan.Text = "Simpan";
            _B_simpan.UseVisualStyleBackColor = false;
            // 
            // B_reset
            // 
            _B_reset.BackColor = Color.Firebrick;
            _B_reset.FlatStyle = FlatStyle.Popup;
            _B_reset.Font = new Font("Poppins SemiBold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _B_reset.ForeColor = Color.White;
            _B_reset.Location = new Point(310, 302);
            _B_reset.Name = "_B_reset";
            _B_reset.Size = new Size(83, 43);
            _B_reset.TabIndex = 19;
            _B_reset.Text = "Reset";
            _B_reset.UseVisualStyleBackColor = false;
            // 
            // L_id
            // 
            _L_id.AutoSize = true;
            _L_id.BackColor = Color.Transparent;
            _L_id.Location = new Point(153, 99);
            _L_id.Name = "_L_id";
            _L_id.Size = new Size(35, 22);
            _L_id.TabIndex = 20;
            _L_id.Text = "L_id";
            // 
            // f_input_edit_karyawan
            // 
            AutoScaleDimensions = new SizeF(7.0F, 22.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(405, 356);
            Controls.Add(_L_id);
            Controls.Add(_B_reset);
            Controls.Add(_B_simpan);
            Controls.Add(_Label10);
            Controls.Add(_Label9);
            Controls.Add(_Label8);
            Controls.Add(_Label7);
            Controls.Add(_Label6);
            Controls.Add(_C_jk);
            Controls.Add(_T_telp);
            Controls.Add(_Label5);
            Controls.Add(_T_alamat);
            Controls.Add(_Label4);
            Controls.Add(_Label3);
            Controls.Add(_T_nama);
            Controls.Add(_Label2);
            Controls.Add(_T_id);
            Controls.Add(_Label1);
            Controls.Add(_Panel1);
            Font = new Font("Poppins SemiBold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "f_input_edit_karyawan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Karyawan ";
            _Panel1.ResumeLayout(false);
            Load += new EventHandler(f_input_edit_karyawan_Load);
            ResumeLayout(false);
            PerformLayout();
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

        private TextBox _T_id;

        internal TextBox T_id
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_id;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_id != null)
                {
                }

                _T_id = value;
                if (_T_id != null)
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
    }
}