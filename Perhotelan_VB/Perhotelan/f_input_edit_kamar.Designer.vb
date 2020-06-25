<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_input_edit_kamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_input_edit_kamar))
        Me.L_header = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_id = New System.Windows.Forms.TextBox()
        Me.T_lantai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_harga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C_tipe = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.B_simpan = New System.Windows.Forms.Button()
        Me.B_reset = New System.Windows.Forms.Button()
        Me.L_id = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.T_nomor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_header
        '
        Me.L_header.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_header.BackColor = System.Drawing.Color.Transparent
        Me.L_header.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_header.ForeColor = System.Drawing.Color.White
        Me.L_header.Location = New System.Drawing.Point(0, 15)
        Me.L_header.Name = "L_header"
        Me.L_header.Size = New System.Drawing.Size(408, 42)
        Me.L_header.TabIndex = 0
        Me.L_header.Text = "Label Header"
        Me.L_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Kamar"
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
        'T_lantai
        '
        Me.T_lantai.Location = New System.Drawing.Point(153, 178)
        Me.T_lantai.MaxLength = 2
        Me.T_lantai.Name = "T_lantai"
        Me.T_lantai.Size = New System.Drawing.Size(240, 25)
        Me.T_lantai.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lantai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipe Kamar"
        '
        'T_harga
        '
        Me.T_harga.Location = New System.Drawing.Point(153, 263)
        Me.T_harga.MaxLength = 15
        Me.T_harga.Name = "T_harga"
        Me.T_harga.Size = New System.Drawing.Size(240, 25)
        Me.T_harga.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Harga Kamar"
        '
        'C_tipe
        '
        Me.C_tipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_tipe.FormattingEnabled = True
        Me.C_tipe.Items.AddRange(New Object() {"- Pilih -", "Standard", "Deluxe", "Suite"})
        Me.C_tipe.Location = New System.Drawing.Point(153, 219)
        Me.C_tipe.Name = "C_tipe"
        Me.C_tipe.Size = New System.Drawing.Size(237, 30)
        Me.C_tipe.TabIndex = 12
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
        Me.Label7.Location = New System.Drawing.Point(134, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(134, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(134, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 22)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = ":"
        '
        'B_simpan
        '
        Me.B_simpan.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.B_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_simpan.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_simpan.ForeColor = System.Drawing.Color.White
        Me.B_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_simpan.Location = New System.Drawing.Point(217, 306)
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
        Me.B_reset.Location = New System.Drawing.Point(307, 306)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(134, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 22)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = ":"
        '
        'T_nomor
        '
        Me.T_nomor.Location = New System.Drawing.Point(153, 138)
        Me.T_nomor.MaxLength = 3
        Me.T_nomor.Name = "T_nomor"
        Me.T_nomor.Size = New System.Drawing.Size(240, 25)
        Me.T_nomor.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(12, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 22)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "No. Kamar"
        '
        'f_input_edit_kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(405, 361)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.T_nomor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.L_id)
        Me.Controls.Add(Me.B_reset)
        Me.Controls.Add(Me.B_simpan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C_tipe)
        Me.Controls.Add(Me.T_harga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.T_lantai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.T_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "f_input_edit_kamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Kamar"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_header As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents T_id As TextBox
    Friend WithEvents T_lantai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T_harga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents C_tipe As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents B_simpan As Button
    Friend WithEvents B_reset As Button
    Friend WithEvents L_id As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents T_nomor As TextBox
    Friend WithEvents Label12 As Label
End Class
