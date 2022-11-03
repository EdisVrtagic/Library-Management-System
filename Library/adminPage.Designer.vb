<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminPage
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminPage))
        Me.apminimiz = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.RPla = New System.Windows.Forms.TextBox()
        Me.RLoz = New System.Windows.Forms.TextBox()
        Me.RIme = New System.Windows.Forms.TextBox()
        Me.RSpol = New System.Windows.Forms.ComboBox()
        Me.emsal = New Guna.UI.WinForms.GunaLabel()
        Me.empa = New Guna.UI.WinForms.GunaLabel()
        Me.emsp = New Guna.UI.WinForms.GunaLabel()
        Me.emime = New Guna.UI.WinForms.GunaLabel()
        Me.managem = New Guna.UI.WinForms.GunaLabel()
        Me.diglibr = New Guna.UI.WinForms.GunaLabel()
        Me.apageel = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.StaffDG = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.paneldrugi = New Guna.UI2.WinForms.Guna2Panel()
        Me.addpos = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.zlogou = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.zres = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.delz = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.editz = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.addz = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.librlogo = New System.Windows.Forms.PictureBox()
        Me.zpoz = New System.Windows.Forms.ComboBox()
        Me.pozic = New Guna.UI.WinForms.GunaLabel()
        Me.npoz = New System.Windows.Forms.TextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.pozz = New System.Windows.Forms.ComboBox()
        CType(Me.StaffDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneldrugi.SuspendLayout()
        CType(Me.librlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'apminimiz
        '
        Me.apminimiz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apminimiz.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.apminimiz.FillColor = System.Drawing.Color.Transparent
        Me.apminimiz.IconColor = System.Drawing.Color.Black
        Me.apminimiz.Location = New System.Drawing.Point(1013, 0)
        Me.apminimiz.Name = "apminimiz"
        Me.apminimiz.Size = New System.Drawing.Size(30, 30)
        Me.apminimiz.TabIndex = 34
        '
        'RPla
        '
        Me.RPla.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RPla.ForeColor = System.Drawing.Color.Black
        Me.RPla.Location = New System.Drawing.Point(538, 218)
        Me.RPla.Name = "RPla"
        Me.RPla.Size = New System.Drawing.Size(187, 25)
        Me.RPla.TabIndex = 45
        '
        'RLoz
        '
        Me.RLoz.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RLoz.ForeColor = System.Drawing.Color.Black
        Me.RLoz.Location = New System.Drawing.Point(538, 187)
        Me.RLoz.Name = "RLoz"
        Me.RLoz.Size = New System.Drawing.Size(187, 25)
        Me.RLoz.TabIndex = 44
        '
        'RIme
        '
        Me.RIme.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RIme.ForeColor = System.Drawing.Color.Black
        Me.RIme.Location = New System.Drawing.Point(538, 94)
        Me.RIme.Name = "RIme"
        Me.RIme.Size = New System.Drawing.Size(187, 25)
        Me.RIme.TabIndex = 43
        '
        'RSpol
        '
        Me.RSpol.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RSpol.ForeColor = System.Drawing.Color.Black
        Me.RSpol.FormattingEnabled = True
        Me.RSpol.Items.AddRange(New Object() {"Muško", "Žensko"})
        Me.RSpol.Location = New System.Drawing.Point(538, 125)
        Me.RSpol.Name = "RSpol"
        Me.RSpol.Size = New System.Drawing.Size(187, 25)
        Me.RSpol.TabIndex = 42
        '
        'emsal
        '
        Me.emsal.AutoSize = True
        Me.emsal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.emsal.ForeColor = System.Drawing.Color.Black
        Me.emsal.Location = New System.Drawing.Point(496, 221)
        Me.emsal.Name = "emsal"
        Me.emsal.Size = New System.Drawing.Size(36, 17)
        Me.emsal.TabIndex = 41
        Me.emsal.Text = "Plata"
        '
        'empa
        '
        Me.empa.AutoSize = True
        Me.empa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.empa.ForeColor = System.Drawing.Color.Black
        Me.empa.Location = New System.Drawing.Point(481, 190)
        Me.empa.Name = "empa"
        Me.empa.Size = New System.Drawing.Size(51, 17)
        Me.empa.TabIndex = 40
        Me.empa.Text = "Lozinka"
        '
        'emsp
        '
        Me.emsp.AutoSize = True
        Me.emsp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.emsp.ForeColor = System.Drawing.Color.Black
        Me.emsp.Location = New System.Drawing.Point(498, 128)
        Me.emsp.Name = "emsp"
        Me.emsp.Size = New System.Drawing.Size(34, 17)
        Me.emsp.TabIndex = 39
        Me.emsp.Text = "Spol"
        '
        'emime
        '
        Me.emime.AutoSize = True
        Me.emime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.emime.ForeColor = System.Drawing.Color.Black
        Me.emime.Location = New System.Drawing.Point(462, 97)
        Me.emime.Name = "emime"
        Me.emime.Size = New System.Drawing.Size(70, 17)
        Me.emime.TabIndex = 38
        Me.emime.Text = "Zaposlenik"
        '
        'managem
        '
        Me.managem.AutoSize = True
        Me.managem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.managem.ForeColor = System.Drawing.Color.Black
        Me.managem.Location = New System.Drawing.Point(550, 29)
        Me.managem.Name = "managem"
        Me.managem.Size = New System.Drawing.Size(153, 17)
        Me.managem.TabIndex = 43
        Me.managem.Text = "Upravljanje zaposlenicima"
        '
        'diglibr
        '
        Me.diglibr.AutoSize = True
        Me.diglibr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.diglibr.ForeColor = System.Drawing.Color.Black
        Me.diglibr.Location = New System.Drawing.Point(572, 8)
        Me.diglibr.Name = "diglibr"
        Me.diglibr.Size = New System.Drawing.Size(109, 21)
        Me.diglibr.TabIndex = 42
        Me.diglibr.Text = "Digital Library"
        '
        'apageel
        '
        Me.apageel.BorderRadius = 20
        Me.apageel.TargetControl = Me
        '
        'StaffDG
        '
        Me.StaffDG.AllowUserToResizeColumns = False
        Me.StaffDG.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.StaffDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.StaffDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StaffDG.BackgroundColor = System.Drawing.Color.LightCyan
        Me.StaffDG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StaffDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StaffDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StaffDG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.StaffDG.ColumnHeadersHeight = 28
        Me.StaffDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StaffDG.DefaultCellStyle = DataGridViewCellStyle6
        Me.StaffDG.EnableHeadersVisualStyles = False
        Me.StaffDG.GridColor = System.Drawing.Color.LightGray
        Me.StaffDG.Location = New System.Drawing.Point(174, 253)
        Me.StaffDG.Name = "StaffDG"
        Me.StaffDG.RowHeadersVisible = False
        Me.StaffDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.StaffDG.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan
        Me.StaffDG.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.StaffDG.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.StaffDG.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.StaffDG.RowTemplate.Height = 25
        Me.StaffDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StaffDG.Size = New System.Drawing.Size(860, 316)
        Me.StaffDG.TabIndex = 57
        Me.StaffDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.StaffDG.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.StaffDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.StaffDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.StaffDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.StaffDG.ThemeStyle.BackColor = System.Drawing.Color.LightCyan
        Me.StaffDG.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.StaffDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.StaffDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StaffDG.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StaffDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.StaffDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.StaffDG.ThemeStyle.HeaderStyle.Height = 28
        Me.StaffDG.ThemeStyle.ReadOnly = False
        Me.StaffDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.StaffDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StaffDG.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StaffDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.StaffDG.ThemeStyle.RowsStyle.Height = 25
        Me.StaffDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StaffDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'paneldrugi
        '
        Me.paneldrugi.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.paneldrugi.BorderColor = System.Drawing.Color.Transparent
        Me.paneldrugi.Controls.Add(Me.addpos)
        Me.paneldrugi.Controls.Add(Me.zlogou)
        Me.paneldrugi.Controls.Add(Me.zres)
        Me.paneldrugi.Controls.Add(Me.delz)
        Me.paneldrugi.Controls.Add(Me.editz)
        Me.paneldrugi.Controls.Add(Me.addz)
        Me.paneldrugi.Controls.Add(Me.librlogo)
        Me.paneldrugi.CustomBorderColor = System.Drawing.Color.Transparent
        Me.paneldrugi.Dock = System.Windows.Forms.DockStyle.Left
        Me.paneldrugi.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.paneldrugi.Location = New System.Drawing.Point(0, 0)
        Me.paneldrugi.Name = "paneldrugi"
        Me.paneldrugi.Size = New System.Drawing.Size(169, 580)
        Me.paneldrugi.TabIndex = 58
        '
        'addpos
        '
        Me.addpos.Animated = True
        Me.addpos.AutoRoundedCorners = True
        Me.addpos.BackColor = System.Drawing.Color.Transparent
        Me.addpos.BorderRadius = 21
        Me.addpos.CustomizableEdges.BottomRight = False
        Me.addpos.CustomizableEdges.TopRight = False
        Me.addpos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addpos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addpos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addpos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addpos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addpos.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addpos.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addpos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addpos.ForeColor = System.Drawing.Color.White
        Me.addpos.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.addpos.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addpos.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.addpos.Location = New System.Drawing.Point(21, 149)
        Me.addpos.Name = "addpos"
        Me.addpos.Size = New System.Drawing.Size(148, 45)
        Me.addpos.TabIndex = 65
        Me.addpos.Text = "Add role"
        Me.addpos.UseTransparentBackground = True
        '
        'zlogou
        '
        Me.zlogou.Animated = True
        Me.zlogou.AutoRoundedCorners = True
        Me.zlogou.BackColor = System.Drawing.Color.Transparent
        Me.zlogou.BorderRadius = 21
        Me.zlogou.CustomizableEdges.BottomRight = False
        Me.zlogou.CustomizableEdges.TopRight = False
        Me.zlogou.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.zlogou.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.zlogou.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.zlogou.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.zlogou.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.zlogou.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.zlogou.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.zlogou.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.zlogou.ForeColor = System.Drawing.Color.White
        Me.zlogou.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.zlogou.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.zlogou.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.zlogou.Location = New System.Drawing.Point(21, 404)
        Me.zlogou.Name = "zlogou"
        Me.zlogou.Size = New System.Drawing.Size(148, 45)
        Me.zlogou.TabIndex = 64
        Me.zlogou.Text = "Logout"
        Me.zlogou.UseTransparentBackground = True
        '
        'zres
        '
        Me.zres.Animated = True
        Me.zres.AutoRoundedCorners = True
        Me.zres.BackColor = System.Drawing.Color.Transparent
        Me.zres.BorderRadius = 21
        Me.zres.CustomizableEdges.BottomRight = False
        Me.zres.CustomizableEdges.TopRight = False
        Me.zres.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.zres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.zres.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.zres.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.zres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.zres.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.zres.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.zres.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.zres.ForeColor = System.Drawing.Color.White
        Me.zres.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.zres.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.zres.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.zres.Location = New System.Drawing.Point(21, 353)
        Me.zres.Name = "zres"
        Me.zres.Size = New System.Drawing.Size(148, 45)
        Me.zres.TabIndex = 63
        Me.zres.Text = "Reset"
        Me.zres.UseTransparentBackground = True
        '
        'delz
        '
        Me.delz.Animated = True
        Me.delz.AutoRoundedCorners = True
        Me.delz.BackColor = System.Drawing.Color.Transparent
        Me.delz.BorderRadius = 21
        Me.delz.CustomizableEdges.BottomRight = False
        Me.delz.CustomizableEdges.TopRight = False
        Me.delz.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.delz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.delz.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.delz.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.delz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.delz.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.delz.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.delz.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.delz.ForeColor = System.Drawing.Color.White
        Me.delz.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.delz.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.delz.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.delz.Location = New System.Drawing.Point(21, 302)
        Me.delz.Name = "delz"
        Me.delz.Size = New System.Drawing.Size(148, 45)
        Me.delz.TabIndex = 62
        Me.delz.Text = "Delete profile"
        Me.delz.UseTransparentBackground = True
        '
        'editz
        '
        Me.editz.Animated = True
        Me.editz.AutoRoundedCorners = True
        Me.editz.BackColor = System.Drawing.Color.Transparent
        Me.editz.BorderRadius = 21
        Me.editz.CustomizableEdges.BottomRight = False
        Me.editz.CustomizableEdges.TopRight = False
        Me.editz.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editz.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editz.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editz.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.editz.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.editz.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.editz.ForeColor = System.Drawing.Color.White
        Me.editz.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.editz.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.editz.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.editz.Location = New System.Drawing.Point(21, 251)
        Me.editz.Name = "editz"
        Me.editz.Size = New System.Drawing.Size(148, 45)
        Me.editz.TabIndex = 61
        Me.editz.Text = "Edit profile"
        Me.editz.UseTransparentBackground = True
        '
        'addz
        '
        Me.addz.Animated = True
        Me.addz.AutoRoundedCorners = True
        Me.addz.BackColor = System.Drawing.Color.Transparent
        Me.addz.BorderRadius = 21
        Me.addz.CustomizableEdges.BottomRight = False
        Me.addz.CustomizableEdges.TopRight = False
        Me.addz.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addz.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addz.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addz.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addz.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addz.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addz.ForeColor = System.Drawing.Color.White
        Me.addz.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.addz.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addz.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.addz.Location = New System.Drawing.Point(21, 200)
        Me.addz.Name = "addz"
        Me.addz.Size = New System.Drawing.Size(148, 45)
        Me.addz.TabIndex = 60
        Me.addz.Text = "Add profile"
        Me.addz.UseTransparentBackground = True
        '
        'librlogo
        '
        Me.librlogo.Image = CType(resources.GetObject("librlogo.Image"), System.Drawing.Image)
        Me.librlogo.Location = New System.Drawing.Point(27, 24)
        Me.librlogo.Name = "librlogo"
        Me.librlogo.Size = New System.Drawing.Size(119, 79)
        Me.librlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.librlogo.TabIndex = 35
        Me.librlogo.TabStop = False
        '
        'zpoz
        '
        Me.zpoz.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.zpoz.ForeColor = System.Drawing.Color.Black
        Me.zpoz.FormattingEnabled = True
        Me.zpoz.Location = New System.Drawing.Point(538, 156)
        Me.zpoz.Name = "zpoz"
        Me.zpoz.Size = New System.Drawing.Size(187, 25)
        Me.zpoz.TabIndex = 60
        '
        'pozic
        '
        Me.pozic.AutoSize = True
        Me.pozic.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pozic.ForeColor = System.Drawing.Color.Black
        Me.pozic.Location = New System.Drawing.Point(481, 159)
        Me.pozic.Name = "pozic"
        Me.pozic.Size = New System.Drawing.Size(51, 17)
        Me.pozic.TabIndex = 59
        Me.pozic.Text = "Pozicija"
        '
        'npoz
        '
        Me.npoz.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.npoz.ForeColor = System.Drawing.Color.Black
        Me.npoz.Location = New System.Drawing.Point(538, 63)
        Me.npoz.Name = "npoz"
        Me.npoz.Size = New System.Drawing.Size(187, 25)
        Me.npoz.TabIndex = 62
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(445, 66)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(87, 17)
        Me.GunaLabel1.TabIndex = 61
        Me.GunaLabel1.Text = "Nova pozicija"
        '
        'pozz
        '
        Me.pozz.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pozz.ForeColor = System.Drawing.Color.Black
        Me.pozz.FormattingEnabled = True
        Me.pozz.Location = New System.Drawing.Point(776, 63)
        Me.pozz.Name = "pozz"
        Me.pozz.Size = New System.Drawing.Size(187, 25)
        Me.pozz.TabIndex = 63
        '
        'adminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1043, 580)
        Me.Controls.Add(Me.pozz)
        Me.Controls.Add(Me.npoz)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.zpoz)
        Me.Controls.Add(Me.pozic)
        Me.Controls.Add(Me.paneldrugi)
        Me.Controls.Add(Me.StaffDG)
        Me.Controls.Add(Me.managem)
        Me.Controls.Add(Me.RPla)
        Me.Controls.Add(Me.diglibr)
        Me.Controls.Add(Me.RLoz)
        Me.Controls.Add(Me.RIme)
        Me.Controls.Add(Me.RSpol)
        Me.Controls.Add(Me.emsal)
        Me.Controls.Add(Me.empa)
        Me.Controls.Add(Me.emsp)
        Me.Controls.Add(Me.emime)
        Me.Controls.Add(Me.apminimiz)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "adminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminPage"
        CType(Me.StaffDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneldrugi.ResumeLayout(False)
        CType(Me.librlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents apminimiz As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents RPla As TextBox
    Friend WithEvents RLoz As TextBox
    Friend WithEvents RIme As TextBox
    Friend WithEvents RSpol As ComboBox
    Friend WithEvents emsal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents empa As Guna.UI.WinForms.GunaLabel
    Friend WithEvents emsp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents emime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents managem As Guna.UI.WinForms.GunaLabel
    Friend WithEvents diglibr As Guna.UI.WinForms.GunaLabel
    Friend WithEvents apageel As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents StaffDG As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents paneldrugi As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents zlogou As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents zres As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents delz As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents editz As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents addz As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents librlogo As PictureBox
    Friend WithEvents zpoz As ComboBox
    Friend WithEvents pozic As Guna.UI.WinForms.GunaLabel
    Friend WithEvents npoz As TextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents addpos As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pozz As ComboBox
End Class
