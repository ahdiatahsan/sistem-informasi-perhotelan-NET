using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    [DesignerGenerated()]
    public partial class f_input_edit_kamar : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(f_input_edit_kamar));
            _L_header = new Label();
            _Panel1 = new Panel();
            _Label1 = new Label();
            _T_id = new TextBox();
            _T_lantai = new TextBox();
            _Label2 = new Label();
            _Label3 = new Label();
            _T_harga = new TextBox();
            _Label4 = new Label();
            _C_tipe = new ComboBox();
            _Label6 = new Label();
            _Label7 = new Label();
            _Label8 = new Label();
            _Label9 = new Label();
            _B_simpan = new Button();
            _B_simpan.Click += new EventHandler(B_simpan_Click);
            _B_reset = new Button();
            _B_reset.Click += new EventHandler(B_reset_Click);
            _L_id = new Label();
            _Label11 = new Label();
            _T_nomor = new TextBox();
            _Label12 = new Label();
            _Panel1.SuspendLayout();
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
            _L_header.Size = new Size(408, 42);
            _L_header.TabIndex = 0;
            _L_header.Text = "Label Header";
            _L_header.TextAlign = ContentAlignment.MiddleCenter;
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
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.BackColor = Color.Transparent;
            _Label1.Location = new Point(12, 99);
            _Label1.Name = "_Label1";
            _Label1.RightToLeft = RightToLeft.Yes;
            _Label1.Size = new Size(67, 22);
            _Label1.TabIndex = 2;
            _Label1.Text = "ID Kamar";
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
            // T_lantai
            // 
            _T_lantai.Location = new Point(153, 178);
            _T_lantai.MaxLength = 2;
            _T_lantai.Name = "_T_lantai";
            _T_lantai.Size = new Size(240, 25);
            _T_lantai.TabIndex = 2;
            // 
            // Label2
            // 
            _Label2.AutoSize = true;
            _Label2.BackColor = Color.Transparent;
            _Label2.Location = new Point(12, 179);
            _Label2.Name = "_Label2";
            _Label2.Size = new Size(48, 22);
            _Label2.TabIndex = 4;
            _Label2.Text = "Lantai";
            // 
            // Label3
            // 
            _Label3.AutoSize = true;
            _Label3.BackColor = Color.Transparent;
            _Label3.Location = new Point(12, 222);
            _Label3.Name = "_Label3";
            _Label3.Size = new Size(80, 22);
            _Label3.TabIndex = 6;
            _Label3.Text = "Tipe Kamar";
            // 
            // T_harga
            // 
            _T_harga.Location = new Point(153, 263);
            _T_harga.MaxLength = 15;
            _T_harga.Name = "_T_harga";
            _T_harga.Size = new Size(240, 25);
            _T_harga.TabIndex = 3;
            // 
            // Label4
            // 
            _Label4.AutoSize = true;
            _Label4.BackColor = Color.Transparent;
            _Label4.Location = new Point(12, 263);
            _Label4.Name = "_Label4";
            _Label4.Size = new Size(93, 22);
            _Label4.TabIndex = 8;
            _Label4.Text = "Harga Kamar";
            // 
            // C_tipe
            // 
            _C_tipe.DropDownStyle = ComboBoxStyle.DropDownList;
            _C_tipe.FormattingEnabled = true;
            _C_tipe.Items.AddRange(new object[] { "- Pilih -", "Standard", "Deluxe", "Suite" });
            _C_tipe.Location = new Point(153, 219);
            _C_tipe.Name = "_C_tipe";
            _C_tipe.Size = new Size(237, 30);
            _C_tipe.TabIndex = 12;
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
            _Label7.Location = new Point(134, 178);
            _Label7.Name = "_Label7";
            _Label7.Size = new Size(13, 22);
            _Label7.TabIndex = 14;
            _Label7.Text = ":";
            // 
            // Label8
            // 
            _Label8.AutoSize = true;
            _Label8.BackColor = Color.Transparent;
            _Label8.Location = new Point(134, 222);
            _Label8.Name = "_Label8";
            _Label8.Size = new Size(13, 22);
            _Label8.TabIndex = 15;
            _Label8.Text = ":";
            // 
            // Label9
            // 
            _Label9.AutoSize = true;
            _Label9.BackColor = Color.Transparent;
            _Label9.Location = new Point(134, 266);
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
            _B_simpan.Location = new Point(217, 306);
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
            _B_reset.Location = new Point(307, 306);
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
            // Label11
            // 
            _Label11.AutoSize = true;
            _Label11.BackColor = Color.Transparent;
            _Label11.Location = new Point(134, 138);
            _Label11.Name = "_Label11";
            _Label11.Size = new Size(13, 22);
            _Label11.TabIndex = 23;
            _Label11.Text = ":";
            // 
            // T_nomor
            // 
            _T_nomor.Location = new Point(153, 138);
            _T_nomor.MaxLength = 3;
            _T_nomor.Name = "_T_nomor";
            _T_nomor.Size = new Size(240, 25);
            _T_nomor.TabIndex = 1;
            // 
            // Label12
            // 
            _Label12.AutoSize = true;
            _Label12.BackColor = Color.Transparent;
            _Label12.Location = new Point(12, 139);
            _Label12.Name = "_Label12";
            _Label12.Size = new Size(75, 22);
            _Label12.TabIndex = 21;
            _Label12.Text = "No. Kamar";
            // 
            // f_input_edit_kamar
            // 
            AutoScaleDimensions = new SizeF(7.0F, 22.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(405, 361);
            Controls.Add(_Label11);
            Controls.Add(_T_nomor);
            Controls.Add(_Label12);
            Controls.Add(_L_id);
            Controls.Add(_B_reset);
            Controls.Add(_B_simpan);
            Controls.Add(_Label9);
            Controls.Add(_Label8);
            Controls.Add(_Label7);
            Controls.Add(_Label6);
            Controls.Add(_C_tipe);
            Controls.Add(_T_harga);
            Controls.Add(_Label4);
            Controls.Add(_Label3);
            Controls.Add(_T_lantai);
            Controls.Add(_Label2);
            Controls.Add(_T_id);
            Controls.Add(_Label1);
            Controls.Add(_Panel1);
            Font = new Font("Poppins SemiBold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "f_input_edit_kamar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Kamar";
            _Panel1.ResumeLayout(false);
            Load += new EventHandler(f_input_edit_karyawan_Load);
            ResumeLayout(false);
            PerformLayout();
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

        private TextBox _T_lantai;

        internal TextBox T_lantai
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_lantai;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_lantai != null)
                {
                }

                _T_lantai = value;
                if (_T_lantai != null)
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

        private TextBox _T_harga;

        internal TextBox T_harga
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_harga;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_harga != null)
                {
                }

                _T_harga = value;
                if (_T_harga != null)
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

        private ComboBox _C_tipe;

        internal ComboBox C_tipe
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _C_tipe;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_C_tipe != null)
                {
                }

                _C_tipe = value;
                if (_C_tipe != null)
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

        private TextBox _T_nomor;

        internal TextBox T_nomor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_nomor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_nomor != null)
                {
                }

                _T_nomor = value;
                if (_T_nomor != null)
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
    }
}