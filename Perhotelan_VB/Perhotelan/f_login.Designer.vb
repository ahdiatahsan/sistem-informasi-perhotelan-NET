<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_login))
        Me.B_login = New System.Windows.Forms.Button()
        Me.B_reset = New System.Windows.Forms.Button()
        Me.T_username = New System.Windows.Forms.TextBox()
        Me.T_password = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'B_login
        '
        Me.B_login.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.B_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_login.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_login.ForeColor = System.Drawing.Color.White
        Me.B_login.Location = New System.Drawing.Point(152, 309)
        Me.B_login.Name = "B_login"
        Me.B_login.Size = New System.Drawing.Size(71, 36)
        Me.B_login.TabIndex = 2
        Me.B_login.Text = "Login"
        Me.B_login.UseVisualStyleBackColor = False
        '
        'B_reset
        '
        Me.B_reset.BackColor = System.Drawing.Color.Firebrick
        Me.B_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_reset.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_reset.ForeColor = System.Drawing.Color.White
        Me.B_reset.Location = New System.Drawing.Point(229, 309)
        Me.B_reset.Name = "B_reset"
        Me.B_reset.Size = New System.Drawing.Size(71, 36)
        Me.B_reset.TabIndex = 3
        Me.B_reset.Text = "Reset"
        Me.B_reset.UseVisualStyleBackColor = False
        '
        'T_username
        '
        Me.T_username.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_username.Location = New System.Drawing.Point(50, 168)
        Me.T_username.Name = "T_username"
        Me.T_username.Size = New System.Drawing.Size(250, 25)
        Me.T_username.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.T_username, "Masukkan Username Anda")
        '
        'T_password
        '
        Me.T_password.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_password.Location = New System.Drawing.Point(50, 248)
        Me.T_password.Name = "T_password"
        Me.T_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.T_password.Size = New System.Drawing.Size(250, 25)
        Me.T_password.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.T_password, "Masukkan Password Anda")
        '
        'f_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(351, 400)
        Me.Controls.Add(Me.T_password)
        Me.Controls.Add(Me.T_username)
        Me.Controls.Add(Me.B_reset)
        Me.Controls.Add(Me.B_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "f_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Informasi Perhotelan | Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_login As Button
    Friend WithEvents B_reset As Button
    Friend WithEvents T_username As TextBox
    Friend WithEvents T_password As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
