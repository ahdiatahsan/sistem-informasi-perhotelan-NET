<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_karyawan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dgv_karyawan = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_cari = New System.Windows.Forms.TextBox()
        Me.B_cari = New System.Windows.Forms.Button()
        Me.B_tambah = New System.Windows.Forms.Button()
        Me.B_edit = New System.Windows.Forms.Button()
        Me.B_hapus = New System.Windows.Forms.Button()
        Me.B_refresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv_karyawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(10, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 67)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(238, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Karyawan"
        '
        'Dgv_karyawan
        '
        Me.Dgv_karyawan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_karyawan.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.Dgv_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_karyawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Dgv_karyawan.Location = New System.Drawing.Point(10, 121)
        Me.Dgv_karyawan.Name = "Dgv_karyawan"
        Me.Dgv_karyawan.ReadOnly = True
        Me.Dgv_karyawan.Size = New System.Drawing.Size(538, 218)
        Me.Dgv_karyawan.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 55
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Karyawan"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis Kelamin"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Alamat"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 105
        '
        'Column5
        '
        Me.Column5.HeaderText = "No. Telp"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 105
        '
        'T_cari
        '
        Me.T_cari.Location = New System.Drawing.Point(10, 90)
        Me.T_cari.Name = "T_cari"
        Me.T_cari.Size = New System.Drawing.Size(582, 25)
        Me.T_cari.TabIndex = 2
        '
        'B_cari
        '
        Me.B_cari.BackColor = System.Drawing.Color.Snow
        Me.B_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_cari.Image = CType(resources.GetObject("B_cari.Image"), System.Drawing.Image)
        Me.B_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_cari.Location = New System.Drawing.Point(598, 90)
        Me.B_cari.Name = "B_cari"
        Me.B_cari.Size = New System.Drawing.Size(71, 25)
        Me.B_cari.TabIndex = 3
        Me.B_cari.Text = "Cari"
        Me.B_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_cari.UseVisualStyleBackColor = False
        '
        'B_tambah
        '
        Me.B_tambah.BackColor = System.Drawing.Color.Snow
        Me.B_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_tambah.Image = CType(resources.GetObject("B_tambah.Image"), System.Drawing.Image)
        Me.B_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_tambah.Location = New System.Drawing.Point(554, 121)
        Me.B_tambah.Name = "B_tambah"
        Me.B_tambah.Size = New System.Drawing.Size(115, 50)
        Me.B_tambah.TabIndex = 4
        Me.B_tambah.Text = "           Tambah"
        Me.B_tambah.UseVisualStyleBackColor = False
        '
        'B_edit
        '
        Me.B_edit.BackColor = System.Drawing.Color.Snow
        Me.B_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_edit.Image = CType(resources.GetObject("B_edit.Image"), System.Drawing.Image)
        Me.B_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_edit.Location = New System.Drawing.Point(554, 177)
        Me.B_edit.Name = "B_edit"
        Me.B_edit.Size = New System.Drawing.Size(115, 50)
        Me.B_edit.TabIndex = 5
        Me.B_edit.Text = "   Edit"
        Me.B_edit.UseVisualStyleBackColor = False
        '
        'B_hapus
        '
        Me.B_hapus.BackColor = System.Drawing.Color.Snow
        Me.B_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_hapus.Image = CType(resources.GetObject("B_hapus.Image"), System.Drawing.Image)
        Me.B_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_hapus.Location = New System.Drawing.Point(554, 233)
        Me.B_hapus.Name = "B_hapus"
        Me.B_hapus.Size = New System.Drawing.Size(115, 50)
        Me.B_hapus.TabIndex = 6
        Me.B_hapus.Text = "        Hapus"
        Me.B_hapus.UseVisualStyleBackColor = False
        '
        'B_refresh
        '
        Me.B_refresh.BackColor = System.Drawing.Color.Snow
        Me.B_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_refresh.Image = CType(resources.GetObject("B_refresh.Image"), System.Drawing.Image)
        Me.B_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_refresh.Location = New System.Drawing.Point(554, 289)
        Me.B_refresh.Name = "B_refresh"
        Me.B_refresh.Size = New System.Drawing.Size(115, 50)
        Me.B_refresh.TabIndex = 7
        Me.B_refresh.Text = "         Refresh"
        Me.B_refresh.UseVisualStyleBackColor = False
        '
        'f_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(678, 346)
        Me.Controls.Add(Me.B_refresh)
        Me.Controls.Add(Me.B_hapus)
        Me.Controls.Add(Me.B_edit)
        Me.Controls.Add(Me.B_tambah)
        Me.Controls.Add(Me.B_cari)
        Me.Controls.Add(Me.T_cari)
        Me.Controls.Add(Me.Dgv_karyawan)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "f_karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Karyawan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv_karyawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Dgv_karyawan As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents T_cari As TextBox
    Friend WithEvents B_cari As Button
    Friend WithEvents B_tambah As Button
    Friend WithEvents B_edit As Button
    Friend WithEvents B_hapus As Button
    Friend WithEvents B_refresh As Button
End Class
