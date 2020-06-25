using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    [DesignerGenerated()]
    public partial class f_utama : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(f_utama));
            _B_karyawan = new Button();
            _B_karyawan.Click += new EventHandler(B_karyawan_Click);
            _Label1 = new Label();
            _B_kamar = new Button();
            _B_kamar.Click += new EventHandler(B_kamar_Click);
            _B_tamu = new Button();
            _B_tamu.Click += new EventHandler(B_tamu_Click);
            _B_logout = new Button();
            _B_logout.Click += new EventHandler(B_logout_Click);
            _B_cekout = new Button();
            _B_cekout.Click += new EventHandler(B_cekout_Click);
            _B_cekin = new Button();
            _B_cekin.Click += new EventHandler(B_cekin_Click);
            _ToolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // B_karyawan
            // 
            _B_karyawan.BackColor = Color.Snow;
            _B_karyawan.FlatStyle = FlatStyle.Flat;
            _B_karyawan.Image = (Image)resources.GetObject("B_karyawan.Image");
            _B_karyawan.ImageAlign = ContentAlignment.TopCenter;
            _B_karyawan.Location = new Point(63, 204);
            _B_karyawan.Name = "_B_karyawan";
            _B_karyawan.Size = new Size(124, 78);
            _B_karyawan.TabIndex = 0;
            _B_karyawan.TabStop = false;
            _B_karyawan.Text = "Karyawan";
            _B_karyawan.TextAlign = ContentAlignment.BottomCenter;
            _ToolTip1.SetToolTip(_B_karyawan, "Menu Data Karyawan");
            _B_karyawan.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.BackColor = Color.Transparent;
            _Label1.Font = new Font("Poppins SemiBold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label1.Location = new Point(58, 163);
            _Label1.Name = "_Label1";
            _Label1.Size = new Size(64, 28);
            _Label1.TabIndex = 6;
            _Label1.Text = "MENU :";
            // 
            // B_kamar
            // 
            _B_kamar.BackColor = Color.Snow;
            _B_kamar.FlatStyle = FlatStyle.Flat;
            _B_kamar.Image = (Image)resources.GetObject("B_kamar.Image");
            _B_kamar.ImageAlign = ContentAlignment.TopCenter;
            _B_kamar.Location = new Point(222, 204);
            _B_kamar.Name = "_B_kamar";
            _B_kamar.Size = new Size(124, 78);
            _B_kamar.TabIndex = 7;
            _B_kamar.TabStop = false;
            _B_kamar.Text = "Kamar";
            _B_kamar.TextAlign = ContentAlignment.BottomCenter;
            _ToolTip1.SetToolTip(_B_kamar, "Menu Data Kamar");
            _B_kamar.UseVisualStyleBackColor = false;
            // 
            // B_tamu
            // 
            _B_tamu.BackColor = Color.Snow;
            _B_tamu.FlatStyle = FlatStyle.Flat;
            _B_tamu.Image = (Image)resources.GetObject("B_tamu.Image");
            _B_tamu.ImageAlign = ContentAlignment.TopCenter;
            _B_tamu.Location = new Point(376, 204);
            _B_tamu.Name = "_B_tamu";
            _B_tamu.Size = new Size(124, 78);
            _B_tamu.TabIndex = 8;
            _B_tamu.TabStop = false;
            _B_tamu.Text = "Tamu";
            _B_tamu.TextAlign = ContentAlignment.BottomCenter;
            _ToolTip1.SetToolTip(_B_tamu, "Menu Data Tamu");
            _B_tamu.UseVisualStyleBackColor = false;
            // 
            // B_logout
            // 
            _B_logout.BackColor = Color.Snow;
            _B_logout.FlatStyle = FlatStyle.Flat;
            _B_logout.Image = (Image)resources.GetObject("B_logout.Image");
            _B_logout.ImageAlign = ContentAlignment.TopCenter;
            _B_logout.Location = new Point(376, 300);
            _B_logout.Name = "_B_logout";
            _B_logout.Size = new Size(124, 78);
            _B_logout.TabIndex = 11;
            _B_logout.TabStop = false;
            _B_logout.Text = "Logout";
            _B_logout.TextAlign = ContentAlignment.BottomCenter;
            _ToolTip1.SetToolTip(_B_logout, "Logout");
            _B_logout.UseVisualStyleBackColor = false;
            // 
            // B_cekout
            // 
            _B_cekout.BackColor = Color.Snow;
            _B_cekout.FlatStyle = FlatStyle.Flat;
            _B_cekout.Image = (Image)resources.GetObject("B_cekout.Image");
            _B_cekout.ImageAlign = ContentAlignment.TopCenter;
            _B_cekout.Location = new Point(222, 300);
            _B_cekout.Name = "_B_cekout";
            _B_cekout.Size = new Size(124, 78);
            _B_cekout.TabIndex = 10;
            _B_cekout.TabStop = false;
            _B_cekout.Text = "Check-Out";
            _B_cekout.TextAlign = ContentAlignment.BottomCenter;
            _ToolTip1.SetToolTip(_B_cekout, "Menu Data Check-Out");
            _B_cekout.UseVisualStyleBackColor = false;
            // 
            // B_cekin
            // 
            _B_cekin.BackColor = Color.Snow;
            _B_cekin.FlatStyle = FlatStyle.Flat;
            _B_cekin.Image = (Image)resources.GetObject("B_cekin.Image");
            _B_cekin.ImageAlign = ContentAlignment.TopCenter;
            _B_cekin.Location = new Point(63, 300);
            _B_cekin.Name = "_B_cekin";
            _B_cekin.Size = new Size(124, 78);
            _B_cekin.TabIndex = 9;
            _B_cekin.TabStop = false;
            _B_cekin.Text = "Check-In";
            _B_cekin.TextAlign = ContentAlignment.BottomCenter;
            _ToolTip1.SetToolTip(_B_cekin, "Menu Data Check-In");
            _B_cekin.UseVisualStyleBackColor = false;
            // 
            // f_utama
            // 
            AutoScaleDimensions = new SizeF(7.0F, 22.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(567, 425);
            Controls.Add(_B_logout);
            Controls.Add(_B_cekout);
            Controls.Add(_B_cekin);
            Controls.Add(_B_tamu);
            Controls.Add(_B_kamar);
            Controls.Add(_Label1);
            Controls.Add(_B_karyawan);
            Font = new Font("Poppins SemiBold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "f_utama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem Informasi Perhotelan | Menu Utama";
            Load += new EventHandler(f_utama_Load);
            Closed += new EventHandler(f_utama_Closed);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button _B_karyawan;

        internal Button B_karyawan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_karyawan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_karyawan != null)
                {
                    _B_karyawan.Click -= B_karyawan_Click;
                }

                _B_karyawan = value;
                if (_B_karyawan != null)
                {
                    _B_karyawan.Click += B_karyawan_Click;
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

        private Button _B_kamar;

        internal Button B_kamar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_kamar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_kamar != null)
                {
                    _B_kamar.Click -= B_kamar_Click;
                }

                _B_kamar = value;
                if (_B_kamar != null)
                {
                    _B_kamar.Click += B_kamar_Click;
                }
            }
        }

        private Button _B_tamu;

        internal Button B_tamu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_tamu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_tamu != null)
                {
                    _B_tamu.Click -= B_tamu_Click;
                }

                _B_tamu = value;
                if (_B_tamu != null)
                {
                    _B_tamu.Click += B_tamu_Click;
                }
            }
        }

        private Button _B_logout;

        internal Button B_logout
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_logout;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_logout != null)
                {
                    _B_logout.Click -= B_logout_Click;
                }

                _B_logout = value;
                if (_B_logout != null)
                {
                    _B_logout.Click += B_logout_Click;
                }
            }
        }

        private Button _B_cekout;

        internal Button B_cekout
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_cekout;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_cekout != null)
                {
                    _B_cekout.Click -= B_cekout_Click;
                }

                _B_cekout = value;
                if (_B_cekout != null)
                {
                    _B_cekout.Click += B_cekout_Click;
                }
            }
        }

        private Button _B_cekin;

        internal Button B_cekin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_cekin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_cekin != null)
                {
                    _B_cekin.Click -= B_cekin_Click;
                }

                _B_cekin = value;
                if (_B_cekin != null)
                {
                    _B_cekin.Click += B_cekin_Click;
                }
            }
        }

        private ToolTip _ToolTip1;

        internal ToolTip ToolTip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolTip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolTip1 != null)
                {
                }

                _ToolTip1 = value;
                if (_ToolTip1 != null)
                {
                }
            }
        }
    }
}