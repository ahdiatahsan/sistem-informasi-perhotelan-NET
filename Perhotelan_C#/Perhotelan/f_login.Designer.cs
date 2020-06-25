using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Perhotelan
{
    [DesignerGenerated()]
    public partial class f_login : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(f_login));
            _B_login = new Button();
            _B_login.Click += new EventHandler(B_login_Click);
            _B_reset = new Button();
            _B_reset.Click += new EventHandler(B_reset_Click);
            _T_username = new TextBox();
            _T_username.KeyDown += new KeyEventHandler(T_username_KeyDown);
            _T_password = new TextBox();
            _T_password.KeyDown += new KeyEventHandler(T_password_KeyDown);
            _ToolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // B_login
            // 
            _B_login.BackColor = Color.DeepSkyBlue;
            _B_login.FlatStyle = FlatStyle.Popup;
            _B_login.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _B_login.ForeColor = Color.White;
            _B_login.Location = new Point(152, 309);
            _B_login.Name = "_B_login";
            _B_login.Size = new Size(71, 36);
            _B_login.TabIndex = 2;
            _B_login.Text = "Login";
            _B_login.UseVisualStyleBackColor = false;
            // 
            // B_reset
            // 
            _B_reset.BackColor = Color.Firebrick;
            _B_reset.FlatStyle = FlatStyle.Popup;
            _B_reset.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _B_reset.ForeColor = Color.White;
            _B_reset.Location = new Point(229, 309);
            _B_reset.Name = "_B_reset";
            _B_reset.Size = new Size(71, 36);
            _B_reset.TabIndex = 3;
            _B_reset.Text = "Reset";
            _B_reset.UseVisualStyleBackColor = false;
            // 
            // T_username
            // 
            _T_username.Font = new Font("Poppins", 9.0F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _T_username.Location = new Point(50, 168);
            _T_username.Name = "_T_username";
            _T_username.Size = new Size(250, 25);
            _T_username.TabIndex = 4;
            _ToolTip1.SetToolTip(_T_username, "Masukkan Username Anda");
            // 
            // T_password
            // 
            _T_password.Font = new Font("Poppins", 9.0F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _T_password.Location = new Point(50, 248);
            _T_password.Name = "_T_password";
            _T_password.PasswordChar = '*';
            _T_password.Size = new Size(250, 25);
            _T_password.TabIndex = 5;
            _ToolTip1.SetToolTip(_T_password, "Masukkan Password Anda");
            // 
            // f_login
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(351, 400);
            Controls.Add(_T_password);
            Controls.Add(_T_username);
            Controls.Add(_B_reset);
            Controls.Add(_B_login);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "f_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem Informasi Perhotelan | Login";
            Load += new EventHandler(f_login_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button _B_login;

        internal Button B_login
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B_login;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B_login != null)
                {
                    _B_login.Click -= B_login_Click;
                }

                _B_login = value;
                if (_B_login != null)
                {
                    _B_login.Click += B_login_Click;
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

        private TextBox _T_username;

        internal TextBox T_username
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_username;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_username != null)
                {
                    _T_username.KeyDown -= T_username_KeyDown;
                }

                _T_username = value;
                if (_T_username != null)
                {
                    _T_username.KeyDown += T_username_KeyDown;
                }
            }
        }

        private TextBox _T_password;

        internal TextBox T_password
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _T_password;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_T_password != null)
                {
                    _T_password.KeyDown -= T_password_KeyDown;
                }

                _T_password = value;
                if (_T_password != null)
                {
                    _T_password.KeyDown += T_password_KeyDown;
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