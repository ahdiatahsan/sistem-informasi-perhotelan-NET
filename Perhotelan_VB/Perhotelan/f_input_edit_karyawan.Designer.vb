<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_input_edit_karyawan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_input_edit_karyawan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.L_header = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_id = New System.Windows.Forms.TextBox()
        Me.T_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_alamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T_telp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.C_jk = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.B_simpan = New System.Windows.Forms.Button()
        Me.B_reset = New System.Windows.Forms.Button()
        Me.L_id = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.L_header)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 76)
        Me.Panel1.TabIndex = 1
        '
        'L_header
        '
        Me.L_header.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_header.BackColor = System.Drawing.Color.Transparent
        Me.L_header.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_header.ForeColor = System.Drawing.Color.White
        Me.L_header.Location = New System.Drawing.Point(0, 17)
        Me.L_header.Name = "L_header"
        Me.L_header.Size = New System.Drawing.Size(408, 42)
        Me.L_header.TabIndex = 1
        Me.L_header.Text = "Label Header"
        Me.L_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Karyawan"
        '
        'T_id
        '
        Me.T_id.Enabled = False
        Me.T_id.Location = New System.Drawing.Point(153, 98)
        Me.T_id.Name = "T_id"
        Me.T_id.ReadOnly = True
        Me.T_id.Size = New System.Drawing.Size(240, 25)
        Me.T_id.TabIndex = 3
        '
        'T_nama
        '
        Me.T_nama.Location = New System.Drawing.Point(153, 138)
        Me.T_nama.Name = "T_nama"
        Me.T_nama.Size = New System.Drawing.Size(240, 25)
        Me.T_nama.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jenis Kelamin"
        '
        'T_alamat
        '
        Me.T_alamat.Location = New System.Drawing.Point(153, 222)
        Me.T_alamat.Name = "T_alamat"
        Me.T_alamat.Size = New System.Drawing.Size(240, 25)
        Me.T_alamat.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Alamat"
        '
        'T_telp
        '
        Me.T_telp.Location = New System.Drawing.Point(153, 264)
        Me.T_telp.MaxLength = 15
        Me.T_telp.Name = "T_telp"
        Me.T_telp.Size = New System.Drawing.Size(240, 25)
        Me.T_telp.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "No. Telp"
        '
        'C_jk
        '
        Me.C_jk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_jk.FormattingEnabled = True
        Me.C_jk.Items.AddRange(New Object() {"- Pilih -", "Laki-Laki", "Perempuan"})
        Me.C_jk.Location = New System.Drawing.Point(153, 178)
        Me.C_jk.Name = "C_jk"
        Me.C_jk.Size = New System.Drawing.Size(237, 30)
        Me.C_jk.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(134, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(134, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(134, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(134, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 22)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(134, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 22)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = ":"
        '
        'B_simpan
        '
        Me.B_simpan.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.B_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_simpan.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_simpan.ForeColor = System.Drawing.Color.White
        Me.B_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_simpan.Location = New System.Drawing.Point(223, 302)
        Me.B_simpan.Name = "B_simpan"
        Me.B_simpan.Size = New System.Drawing.Size(83, 43)
        Me.B_simpan.TabIndex = 18
        Me.B_simpan.Text = "Simpan"
        Me.B_simpan.UseVisualStyleBackColor = False
        '
        'B_reset
        '
        Me.B_reset.BackColor = System.Drawing.Color.Firebrick
        Me.B_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_reset.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_reset.ForeColor = System.Drawing.Color.White
        Me.B_reset.Location = New System.Drawing.Point(310, 302)
        Me.B_reset.Name = "B_reset"
        Me.B_reset.Size = New System.Drawing.Size(83, 43)
        Me.B_reset.TabIndex = 19
        Me.B_reset.Text = "Reset"
        Me.B_reset.UseVisualStyleBackColor = False
        '
        'L_id
        '
        Me.L_id.AutoSize = True
        Me.L_id.BackColor = System.Drawing.Color.Transparent
        Me.L_id.Location = New System.Drawing.Point(153, 99)
        Me.L_id.Name = "L_id"
        Me.L_id.Size = New System.Drawing.Size(35, 22)
        Me.L_id.TabIndex = 20
        Me.L_id.Text = "L_id"
        '
        'f_input_edit_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(405, 356)
        Me.Controls.Add(Me.L_id)
        Me.Controls.Add(Me.B_reset)
        Me.Controls.Add(Me.B_simpan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C_jk)
        Me.Controls.Add(Me.T_telp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.T_alamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.T_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.T_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "f_input_edit_karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Karyawan "
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents T_id As TextBox
    Friend WithEvents T_nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T_alamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents T_telp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents C_jk As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents B_simpan As Button
    Friend WithEvents B_reset As Button
    Friend WithEvents L_id As Label
    Friend WithEvents L_header As Label
End Class
