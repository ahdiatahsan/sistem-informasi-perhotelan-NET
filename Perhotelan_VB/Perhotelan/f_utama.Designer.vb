<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_utama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_utama))
        Me.B_karyawan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_kamar = New System.Windows.Forms.Button()
        Me.B_tamu = New System.Windows.Forms.Button()
        Me.B_logout = New System.Windows.Forms.Button()
        Me.B_cekout = New System.Windows.Forms.Button()
        Me.B_cekin = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'B_karyawan
        '
        Me.B_karyawan.BackColor = System.Drawing.Color.Snow
        Me.B_karyawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_karyawan.Image = CType(resources.GetObject("B_karyawan.Image"), System.Drawing.Image)
        Me.B_karyawan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_karyawan.Location = New System.Drawing.Point(63, 204)
        Me.B_karyawan.Name = "B_karyawan"
        Me.B_karyawan.Size = New System.Drawing.Size(124, 78)
        Me.B_karyawan.TabIndex = 0
        Me.B_karyawan.TabStop = False
        Me.B_karyawan.Text = "Karyawan"
        Me.B_karyawan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.B_karyawan, "Menu Data Karyawan")
        Me.B_karyawan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MENU :"
        '
        'B_kamar
        '
        Me.B_kamar.BackColor = System.Drawing.Color.Snow
        Me.B_kamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_kamar.Image = CType(resources.GetObject("B_kamar.Image"), System.Drawing.Image)
        Me.B_kamar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_kamar.Location = New System.Drawing.Point(222, 204)
        Me.B_kamar.Name = "B_kamar"
        Me.B_kamar.Size = New System.Drawing.Size(124, 78)
        Me.B_kamar.TabIndex = 7
        Me.B_kamar.TabStop = False
        Me.B_kamar.Text = "Kamar"
        Me.B_kamar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.B_kamar, "Menu Data Kamar")
        Me.B_kamar.UseVisualStyleBackColor = False
        '
        'B_tamu
        '
        Me.B_tamu.BackColor = System.Drawing.Color.Snow
        Me.B_tamu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_tamu.Image = CType(resources.GetObject("B_tamu.Image"), System.Drawing.Image)
        Me.B_tamu.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_tamu.Location = New System.Drawing.Point(376, 204)
        Me.B_tamu.Name = "B_tamu"
        Me.B_tamu.Size = New System.Drawing.Size(124, 78)
        Me.B_tamu.TabIndex = 8
        Me.B_tamu.TabStop = False
        Me.B_tamu.Text = "Tamu"
        Me.B_tamu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.B_tamu, "Menu Data Tamu")
        Me.B_tamu.UseVisualStyleBackColor = False
        '
        'B_logout
        '
        Me.B_logout.BackColor = System.Drawing.Color.Snow
        Me.B_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_logout.Image = CType(resources.GetObject("B_logout.Image"), System.Drawing.Image)
        Me.B_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_logout.Location = New System.Drawing.Point(376, 300)
        Me.B_logout.Name = "B_logout"
        Me.B_logout.Size = New System.Drawing.Size(124, 78)
        Me.B_logout.TabIndex = 11
        Me.B_logout.TabStop = False
        Me.B_logout.Text = "Logout"
        Me.B_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.B_logout, "Logout")
        Me.B_logout.UseVisualStyleBackColor = False
        '
        'B_cekout
        '
        Me.B_cekout.BackColor = System.Drawing.Color.Snow
        Me.B_cekout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_cekout.Image = CType(resources.GetObject("B_cekout.Image"), System.Drawing.Image)
        Me.B_cekout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_cekout.Location = New System.Drawing.Point(222, 300)
        Me.B_cekout.Name = "B_cekout"
        Me.B_cekout.Size = New System.Drawing.Size(124, 78)
        Me.B_cekout.TabIndex = 10
        Me.B_cekout.TabStop = False
        Me.B_cekout.Text = "Check-Out"
        Me.B_cekout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.B_cekout, "Menu Data Check-Out")
        Me.B_cekout.UseVisualStyleBackColor = False
        '
        'B_cekin
        '
        Me.B_cekin.BackColor = System.Drawing.Color.Snow
        Me.B_cekin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_cekin.Image = CType(resources.GetObject("B_cekin.Image"), System.Drawing.Image)
        Me.B_cekin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B_cekin.Location = New System.Drawing.Point(63, 300)
        Me.B_cekin.Name = "B_cekin"
        Me.B_cekin.Size = New System.Drawing.Size(124, 78)
        Me.B_cekin.TabIndex = 9
        Me.B_cekin.TabStop = False
        Me.B_cekin.Text = "Check-In"
        Me.B_cekin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.B_cekin, "Menu Data Check-In")
        Me.B_cekin.UseVisualStyleBackColor = False
        '
        'f_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(567, 425)
        Me.Controls.Add(Me.B_logout)
        Me.Controls.Add(Me.B_cekout)
        Me.Controls.Add(Me.B_cekin)
        Me.Controls.Add(Me.B_tamu)
        Me.Controls.Add(Me.B_kamar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_karyawan)
        Me.Font = New System.Drawing.Font("Poppins SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "f_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Perhotelan | Menu Utama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_karyawan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents B_kamar As Button
    Friend WithEvents B_tamu As Button
    Friend WithEvents B_logout As Button
    Friend WithEvents B_cekout As Button
    Friend WithEvents B_cekin As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
