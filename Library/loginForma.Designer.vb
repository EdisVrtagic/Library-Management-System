<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForma))
        Me.loginelipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.cekbox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.copyrg = New System.Windows.Forms.Label()
        Me.loginbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.minimiz = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.izlazak = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fblogo = New System.Windows.Forms.PictureBox()
        Me.ipialogo = New System.Windows.Forms.PictureBox()
        Me.ytlogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.alogbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usern = New Guna.UI2.WinForms.Guna2TextBox()
        Me.nesk = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ipialogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ytlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginelipse
        '
        Me.loginelipse.BorderRadius = 25
        Me.loginelipse.TargetControl = Me
        '
        'cekbox
        '
        Me.cekbox.AutoSize = True
        Me.cekbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cekbox.CheckedState.BorderRadius = 2
        Me.cekbox.CheckedState.BorderThickness = 0
        Me.cekbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cekbox.ForeColor = System.Drawing.Color.Black
        Me.cekbox.Location = New System.Drawing.Point(499, 288)
        Me.cekbox.Name = "cekbox"
        Me.cekbox.Size = New System.Drawing.Size(119, 21)
        Me.cekbox.TabIndex = 24
        Me.cekbox.Text = "Show password"
        Me.cekbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cekbox.UncheckedState.BorderRadius = 2
        Me.cekbox.UncheckedState.BorderThickness = 0
        Me.cekbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cekbox.UseVisualStyleBackColor = True
        '
        'copyrg
        '
        Me.copyrg.AutoSize = True
        Me.copyrg.BackColor = System.Drawing.Color.Transparent
        Me.copyrg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.copyrg.ForeColor = System.Drawing.Color.Black
        Me.copyrg.Location = New System.Drawing.Point(539, 531)
        Me.copyrg.Name = "copyrg"
        Me.copyrg.Size = New System.Drawing.Size(155, 17)
        Me.copyrg.TabIndex = 23
        Me.copyrg.Text = "Copyright (c) Library 2022"
        '
        'loginbtn
        '
        Me.loginbtn.Animated = True
        Me.loginbtn.AutoRoundedCorners = True
        Me.loginbtn.BackColor = System.Drawing.Color.Transparent
        Me.loginbtn.BorderRadius = 15
        Me.loginbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.loginbtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.loginbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(499, 249)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(229, 33)
        Me.loginbtn.TabIndex = 21
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseTransparentBackground = True
        '
        'pass
        '
        Me.pass.AutoRoundedCorners = True
        Me.pass.BackColor = System.Drawing.Color.LightCyan
        Me.pass.BorderRadius = 15
        Me.pass.BorderThickness = 0
        Me.pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass.DefaultText = ""
        Me.pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pass.FillColor = System.Drawing.Color.LightCyan
        Me.pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pass.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.pass.ForeColor = System.Drawing.Color.Black
        Me.pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pass.IconLeft = CType(resources.GetObject("pass.IconLeft"), System.Drawing.Image)
        Me.pass.Location = New System.Drawing.Point(499, 198)
        Me.pass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.pass.PlaceholderText = "Password"
        Me.pass.SelectedText = ""
        Me.pass.Size = New System.Drawing.Size(229, 33)
        Me.pass.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(537, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Welcome to Library"
        '
        'minimiz
        '
        Me.minimiz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimiz.BackColor = System.Drawing.Color.Transparent
        Me.minimiz.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.minimiz.FillColor = System.Drawing.Color.Transparent
        Me.minimiz.IconColor = System.Drawing.Color.Black
        Me.minimiz.Location = New System.Drawing.Point(689, -1)
        Me.minimiz.Name = "minimiz"
        Me.minimiz.Size = New System.Drawing.Size(39, 36)
        Me.minimiz.TabIndex = 33
        '
        'izlazak
        '
        Me.izlazak.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.izlazak.BackColor = System.Drawing.Color.Transparent
        Me.izlazak.FillColor = System.Drawing.Color.Transparent
        Me.izlazak.IconColor = System.Drawing.Color.Black
        Me.izlazak.Location = New System.Drawing.Point(730, -2)
        Me.izlazak.Name = "izlazak"
        Me.izlazak.Size = New System.Drawing.Size(48, 37)
        Me.izlazak.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-15, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 570)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'fblogo
        '
        Me.fblogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.fblogo.Image = CType(resources.GetObject("fblogo.Image"), System.Drawing.Image)
        Me.fblogo.Location = New System.Drawing.Point(142, 509)
        Me.fblogo.Name = "fblogo"
        Me.fblogo.Size = New System.Drawing.Size(48, 39)
        Me.fblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fblogo.TabIndex = 35
        Me.fblogo.TabStop = False
        '
        'ipialogo
        '
        Me.ipialogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ipialogo.Image = CType(resources.GetObject("ipialogo.Image"), System.Drawing.Image)
        Me.ipialogo.Location = New System.Drawing.Point(196, 509)
        Me.ipialogo.Name = "ipialogo"
        Me.ipialogo.Size = New System.Drawing.Size(48, 39)
        Me.ipialogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ipialogo.TabIndex = 36
        Me.ipialogo.TabStop = False
        '
        'ytlogo
        '
        Me.ytlogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ytlogo.Image = CType(resources.GetObject("ytlogo.Image"), System.Drawing.Image)
        Me.ytlogo.Location = New System.Drawing.Point(250, 509)
        Me.ytlogo.Name = "ytlogo"
        Me.ytlogo.Size = New System.Drawing.Size(48, 39)
        Me.ytlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ytlogo.TabIndex = 37
        Me.ytlogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(182, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Sponsored by"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(563, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Your dream book"
        '
        'alogbtn
        '
        Me.alogbtn.Animated = True
        Me.alogbtn.AutoRoundedCorners = True
        Me.alogbtn.BackColor = System.Drawing.Color.Transparent
        Me.alogbtn.BorderRadius = 15
        Me.alogbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.alogbtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.alogbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.alogbtn.ForeColor = System.Drawing.Color.White
        Me.alogbtn.Location = New System.Drawing.Point(566, 364)
        Me.alogbtn.Name = "alogbtn"
        Me.alogbtn.Size = New System.Drawing.Size(106, 33)
        Me.alogbtn.TabIndex = 42
        Me.alogbtn.Text = "Admin login"
        Me.alogbtn.UseTransparentBackground = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(511, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "By logging in,you are agreeing to the"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(563, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Terms of Service"
        '
        'usern
        '
        Me.usern.AutoRoundedCorners = True
        Me.usern.BorderRadius = 15
        Me.usern.BorderThickness = 0
        Me.usern.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usern.DefaultText = ""
        Me.usern.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usern.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usern.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usern.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usern.FillColor = System.Drawing.Color.LightCyan
        Me.usern.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usern.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.usern.ForeColor = System.Drawing.Color.Black
        Me.usern.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usern.IconLeft = CType(resources.GetObject("usern.IconLeft"), System.Drawing.Image)
        Me.usern.Location = New System.Drawing.Point(499, 157)
        Me.usern.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.usern.Name = "usern"
        Me.usern.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usern.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.usern.PlaceholderText = "Username"
        Me.usern.SelectedText = ""
        Me.usern.Size = New System.Drawing.Size(229, 33)
        Me.usern.TabIndex = 45
        '
        'nesk
        '
        Me.nesk.AutoSize = True
        Me.nesk.BackColor = System.Drawing.Color.Transparent
        Me.nesk.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nesk.ForeColor = System.Drawing.Color.Black
        Me.nesk.Location = New System.Drawing.Point(506, 473)
        Me.nesk.Name = "nesk"
        Me.nesk.Size = New System.Drawing.Size(0, 17)
        Me.nesk.TabIndex = 46
        '
        'loginForma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(777, 566)
        Me.Controls.Add(Me.nesk)
        Me.Controls.Add(Me.usern)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.alogbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ytlogo)
        Me.Controls.Add(Me.ipialogo)
        Me.Controls.Add(Me.fblogo)
        Me.Controls.Add(Me.copyrg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.cekbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.minimiz)
        Me.Controls.Add(Me.izlazak)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "loginForma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ipialogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ytlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cekbox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents copyrg As Label
    Friend WithEvents loginbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents minimiz As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents izlazak As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ytlogo As PictureBox
    Friend WithEvents ipialogo As PictureBox
    Friend WithEvents fblogo As PictureBox
    Friend WithEvents loginelipse As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label2 As Label
    Friend WithEvents alogbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usern As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents nesk As Label
End Class
