<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BooksPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BooksPage))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bookelips = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.bominimiz = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.paneltreci = New Guna.UI2.WinForms.Guna2Panel()
        Me.addcate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.resbo = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.kori = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.delbo = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.editbo = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.addbo = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.librlogo = New System.Windows.Forms.PictureBox()
        Me.nbka = New System.Windows.Forms.TextBox()
        Me.tnkat = New Guna.UI.WinForms.GunaLabel()
        Me.au = New Guna.UI.WinForms.GunaLabel()
        Me.managus = New Guna.UI.WinForms.GunaLabel()
        Me.diglibr = New Guna.UI.WinForms.GunaLabel()
        Me.KIme = New System.Windows.Forms.TextBox()
        Me.KaK = New System.Windows.Forms.ComboBox()
        Me.kk = New Guna.UI.WinForms.GunaLabel()
        Me.nkn = New Guna.UI.WinForms.GunaLabel()
        Me.AutK = New System.Windows.Forms.TextBox()
        Me.di = New Guna.UI.WinForms.GunaLabel()
        Me.SBK = New System.Windows.Forms.TextBox()
        Me.serbr = New Guna.UI.WinForms.GunaLabel()
        Me.BookDG = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DIZ = New System.Windows.Forms.TextBox()
        Me.brkn = New System.Windows.Forms.ComboBox()
        Me.kkkkk = New Guna.UI.WinForms.GunaLabel()
        Me.adkl = New System.Windows.Forms.ComboBox()
        Me.idad = New System.Windows.Forms.ComboBox()
        Me.paneltreci.SuspendLayout()
        CType(Me.librlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bookelips
        '
        Me.bookelips.BorderRadius = 20
        Me.bookelips.TargetControl = Me
        '
        'bominimiz
        '
        Me.bominimiz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bominimiz.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.bominimiz.FillColor = System.Drawing.Color.Transparent
        Me.bominimiz.IconColor = System.Drawing.Color.Black
        Me.bominimiz.Location = New System.Drawing.Point(1012, 0)
        Me.bominimiz.Name = "bominimiz"
        Me.bominimiz.Size = New System.Drawing.Size(30, 30)
        Me.bominimiz.TabIndex = 36
        '
        'paneltreci
        '
        Me.paneltreci.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.paneltreci.BorderColor = System.Drawing.Color.Transparent
        Me.paneltreci.Controls.Add(Me.addcate)
        Me.paneltreci.Controls.Add(Me.resbo)
        Me.paneltreci.Controls.Add(Me.kori)
        Me.paneltreci.Controls.Add(Me.delbo)
        Me.paneltreci.Controls.Add(Me.editbo)
        Me.paneltreci.Controls.Add(Me.addbo)
        Me.paneltreci.Controls.Add(Me.librlogo)
        Me.paneltreci.CustomBorderColor = System.Drawing.Color.Transparent
        Me.paneltreci.Dock = System.Windows.Forms.DockStyle.Left
        Me.paneltreci.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.paneltreci.Location = New System.Drawing.Point(0, 0)
        Me.paneltreci.Name = "paneltreci"
        Me.paneltreci.Size = New System.Drawing.Size(169, 580)
        Me.paneltreci.TabIndex = 39
        '
        'addcate
        '
        Me.addcate.Animated = True
        Me.addcate.AutoRoundedCorners = True
        Me.addcate.BackColor = System.Drawing.Color.Transparent
        Me.addcate.BorderRadius = 21
        Me.addcate.CustomizableEdges.BottomRight = False
        Me.addcate.CustomizableEdges.TopRight = False
        Me.addcate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addcate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addcate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addcate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addcate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addcate.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addcate.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addcate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addcate.ForeColor = System.Drawing.Color.White
        Me.addcate.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.addcate.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addcate.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.addcate.Location = New System.Drawing.Point(21, 153)
        Me.addcate.Name = "addcate"
        Me.addcate.Size = New System.Drawing.Size(148, 45)
        Me.addcate.TabIndex = 67
        Me.addcate.Text = "Add category"
        Me.addcate.UseTransparentBackground = True
        '
        'resbo
        '
        Me.resbo.Animated = True
        Me.resbo.AutoRoundedCorners = True
        Me.resbo.BackColor = System.Drawing.Color.Transparent
        Me.resbo.BorderRadius = 21
        Me.resbo.CustomizableEdges.BottomRight = False
        Me.resbo.CustomizableEdges.TopRight = False
        Me.resbo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.resbo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.resbo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.resbo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.resbo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.resbo.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.resbo.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.resbo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.resbo.ForeColor = System.Drawing.Color.White
        Me.resbo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.resbo.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.resbo.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.resbo.Location = New System.Drawing.Point(21, 408)
        Me.resbo.Name = "resbo"
        Me.resbo.Size = New System.Drawing.Size(148, 45)
        Me.resbo.TabIndex = 65
        Me.resbo.Text = "Reset"
        Me.resbo.UseTransparentBackground = True
        '
        'kori
        '
        Me.kori.Animated = True
        Me.kori.AutoRoundedCorners = True
        Me.kori.BackColor = System.Drawing.Color.Transparent
        Me.kori.BorderRadius = 21
        Me.kori.CustomizableEdges.BottomRight = False
        Me.kori.CustomizableEdges.TopRight = False
        Me.kori.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.kori.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.kori.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.kori.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.kori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.kori.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.kori.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.kori.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.kori.ForeColor = System.Drawing.Color.White
        Me.kori.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.kori.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.kori.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.kori.Location = New System.Drawing.Point(21, 357)
        Me.kori.Name = "kori"
        Me.kori.Size = New System.Drawing.Size(148, 45)
        Me.kori.TabIndex = 63
        Me.kori.Text = "Users"
        Me.kori.UseTransparentBackground = True
        '
        'delbo
        '
        Me.delbo.Animated = True
        Me.delbo.AutoRoundedCorners = True
        Me.delbo.BackColor = System.Drawing.Color.Transparent
        Me.delbo.BorderRadius = 21
        Me.delbo.CustomizableEdges.BottomRight = False
        Me.delbo.CustomizableEdges.TopRight = False
        Me.delbo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.delbo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.delbo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.delbo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.delbo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.delbo.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.delbo.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.delbo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.delbo.ForeColor = System.Drawing.Color.White
        Me.delbo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.delbo.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.delbo.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.delbo.Location = New System.Drawing.Point(21, 306)
        Me.delbo.Name = "delbo"
        Me.delbo.Size = New System.Drawing.Size(148, 45)
        Me.delbo.TabIndex = 62
        Me.delbo.Text = "Delete book"
        Me.delbo.UseTransparentBackground = True
        '
        'editbo
        '
        Me.editbo.Animated = True
        Me.editbo.AutoRoundedCorners = True
        Me.editbo.BackColor = System.Drawing.Color.Transparent
        Me.editbo.BorderRadius = 21
        Me.editbo.CustomizableEdges.BottomRight = False
        Me.editbo.CustomizableEdges.TopRight = False
        Me.editbo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.editbo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.editbo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editbo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.editbo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.editbo.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.editbo.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.editbo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.editbo.ForeColor = System.Drawing.Color.White
        Me.editbo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.editbo.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.editbo.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.editbo.Location = New System.Drawing.Point(21, 255)
        Me.editbo.Name = "editbo"
        Me.editbo.Size = New System.Drawing.Size(148, 45)
        Me.editbo.TabIndex = 61
        Me.editbo.Text = "Edit book"
        Me.editbo.UseTransparentBackground = True
        '
        'addbo
        '
        Me.addbo.Animated = True
        Me.addbo.AutoRoundedCorners = True
        Me.addbo.BackColor = System.Drawing.Color.Transparent
        Me.addbo.BorderRadius = 21
        Me.addbo.CustomizableEdges.BottomRight = False
        Me.addbo.CustomizableEdges.TopRight = False
        Me.addbo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addbo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addbo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addbo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addbo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addbo.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addbo.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addbo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addbo.ForeColor = System.Drawing.Color.White
        Me.addbo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.addbo.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.addbo.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.addbo.Location = New System.Drawing.Point(21, 204)
        Me.addbo.Name = "addbo"
        Me.addbo.Size = New System.Drawing.Size(148, 45)
        Me.addbo.TabIndex = 60
        Me.addbo.Text = "Add book"
        Me.addbo.UseTransparentBackground = True
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
        'nbka
        '
        Me.nbka.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nbka.ForeColor = System.Drawing.Color.Black
        Me.nbka.Location = New System.Drawing.Point(535, 61)
        Me.nbka.Name = "nbka"
        Me.nbka.Size = New System.Drawing.Size(187, 25)
        Me.nbka.TabIndex = 79
        '
        'tnkat
        '
        Me.tnkat.AutoSize = True
        Me.tnkat.BackColor = System.Drawing.Color.Transparent
        Me.tnkat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tnkat.ForeColor = System.Drawing.Color.Black
        Me.tnkat.Location = New System.Drawing.Point(428, 64)
        Me.tnkat.Name = "tnkat"
        Me.tnkat.Size = New System.Drawing.Size(101, 17)
        Me.tnkat.TabIndex = 78
        Me.tnkat.Text = "Nova kategorija"
        '
        'au
        '
        Me.au.AutoSize = True
        Me.au.BackColor = System.Drawing.Color.Transparent
        Me.au.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.au.ForeColor = System.Drawing.Color.Black
        Me.au.Location = New System.Drawing.Point(489, 157)
        Me.au.Name = "au"
        Me.au.Size = New System.Drawing.Size(40, 17)
        Me.au.TabIndex = 77
        Me.au.Text = "Autor"
        '
        'managus
        '
        Me.managus.AutoSize = True
        Me.managus.BackColor = System.Drawing.Color.Transparent
        Me.managus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.managus.ForeColor = System.Drawing.Color.Black
        Me.managus.Location = New System.Drawing.Point(566, 30)
        Me.managus.Name = "managus"
        Me.managus.Size = New System.Drawing.Size(126, 17)
        Me.managus.TabIndex = 73
        Me.managus.Text = "Upravljanje knjigama"
        '
        'diglibr
        '
        Me.diglibr.AutoSize = True
        Me.diglibr.BackColor = System.Drawing.Color.Transparent
        Me.diglibr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.diglibr.ForeColor = System.Drawing.Color.Black
        Me.diglibr.Location = New System.Drawing.Point(576, 8)
        Me.diglibr.Name = "diglibr"
        Me.diglibr.Size = New System.Drawing.Size(109, 21)
        Me.diglibr.TabIndex = 71
        Me.diglibr.Text = "Digital Library"
        '
        'KIme
        '
        Me.KIme.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.KIme.ForeColor = System.Drawing.Color.Black
        Me.KIme.Location = New System.Drawing.Point(535, 92)
        Me.KIme.Name = "KIme"
        Me.KIme.Size = New System.Drawing.Size(187, 25)
        Me.KIme.TabIndex = 74
        '
        'KaK
        '
        Me.KaK.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.KaK.ForeColor = System.Drawing.Color.Black
        Me.KaK.FormattingEnabled = True
        Me.KaK.Location = New System.Drawing.Point(535, 123)
        Me.KaK.Name = "KaK"
        Me.KaK.Size = New System.Drawing.Size(187, 25)
        Me.KaK.TabIndex = 72
        '
        'kk
        '
        Me.kk.AutoSize = True
        Me.kk.BackColor = System.Drawing.Color.Transparent
        Me.kk.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.kk.ForeColor = System.Drawing.Color.Black
        Me.kk.Location = New System.Drawing.Point(461, 126)
        Me.kk.Name = "kk"
        Me.kk.Size = New System.Drawing.Size(68, 17)
        Me.kk.TabIndex = 69
        Me.kk.Text = "Kategorija"
        '
        'nkn
        '
        Me.nkn.AutoSize = True
        Me.nkn.BackColor = System.Drawing.Color.Transparent
        Me.nkn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nkn.ForeColor = System.Drawing.Color.Black
        Me.nkn.Location = New System.Drawing.Point(485, 95)
        Me.nkn.Name = "nkn"
        Me.nkn.Size = New System.Drawing.Size(44, 17)
        Me.nkn.TabIndex = 68
        Me.nkn.Text = "Knjiga"
        '
        'AutK
        '
        Me.AutK.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AutK.ForeColor = System.Drawing.Color.Black
        Me.AutK.Location = New System.Drawing.Point(535, 154)
        Me.AutK.Name = "AutK"
        Me.AutK.Size = New System.Drawing.Size(187, 25)
        Me.AutK.TabIndex = 80
        '
        'di
        '
        Me.di.AutoSize = True
        Me.di.BackColor = System.Drawing.Color.Transparent
        Me.di.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.di.ForeColor = System.Drawing.Color.Black
        Me.di.Location = New System.Drawing.Point(438, 188)
        Me.di.Name = "di"
        Me.di.Size = New System.Drawing.Size(91, 17)
        Me.di.TabIndex = 81
        Me.di.Text = "Datum izdanja"
        '
        'SBK
        '
        Me.SBK.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SBK.ForeColor = System.Drawing.Color.Black
        Me.SBK.Location = New System.Drawing.Point(535, 217)
        Me.SBK.Name = "SBK"
        Me.SBK.Size = New System.Drawing.Size(187, 25)
        Me.SBK.TabIndex = 85
        '
        'serbr
        '
        Me.serbr.AutoSize = True
        Me.serbr.BackColor = System.Drawing.Color.Transparent
        Me.serbr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.serbr.ForeColor = System.Drawing.Color.Black
        Me.serbr.Location = New System.Drawing.Point(453, 220)
        Me.serbr.Name = "serbr"
        Me.serbr.Size = New System.Drawing.Size(76, 17)
        Me.serbr.TabIndex = 84
        Me.serbr.Text = "Serijski broj"
        '
        'BookDG
        '
        Me.BookDG.AllowUserToResizeColumns = False
        Me.BookDG.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.BookDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BookDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookDG.BackgroundColor = System.Drawing.Color.LightCyan
        Me.BookDG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BookDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookDG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BookDG.ColumnHeadersHeight = 28
        Me.BookDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BookDG.DefaultCellStyle = DataGridViewCellStyle3
        Me.BookDG.EnableHeadersVisualStyles = False
        Me.BookDG.GridColor = System.Drawing.Color.LightGray
        Me.BookDG.Location = New System.Drawing.Point(175, 279)
        Me.BookDG.Name = "BookDG"
        Me.BookDG.RowHeadersVisible = False
        Me.BookDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.BookDG.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan
        Me.BookDG.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.BookDG.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BookDG.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BookDG.RowTemplate.Height = 25
        Me.BookDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BookDG.Size = New System.Drawing.Size(860, 293)
        Me.BookDG.TabIndex = 86
        Me.BookDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BookDG.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BookDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.BookDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.BookDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.BookDG.ThemeStyle.BackColor = System.Drawing.Color.LightCyan
        Me.BookDG.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.BookDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BookDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BookDG.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BookDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BookDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BookDG.ThemeStyle.HeaderStyle.Height = 28
        Me.BookDG.ThemeStyle.ReadOnly = False
        Me.BookDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BookDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BookDG.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BookDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BookDG.ThemeStyle.RowsStyle.Height = 25
        Me.BookDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DIZ
        '
        Me.DIZ.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DIZ.ForeColor = System.Drawing.Color.Black
        Me.DIZ.Location = New System.Drawing.Point(535, 185)
        Me.DIZ.Name = "DIZ"
        Me.DIZ.Size = New System.Drawing.Size(187, 25)
        Me.DIZ.TabIndex = 87
        '
        'brkn
        '
        Me.brkn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.brkn.ForeColor = System.Drawing.Color.Black
        Me.brkn.FormattingEnabled = True
        Me.brkn.Location = New System.Drawing.Point(234, 126)
        Me.brkn.Name = "brkn"
        Me.brkn.Size = New System.Drawing.Size(187, 25)
        Me.brkn.TabIndex = 88
        '
        'kkkkk
        '
        Me.kkkkk.AutoSize = True
        Me.kkkkk.BackColor = System.Drawing.Color.Transparent
        Me.kkkkk.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.kkkkk.ForeColor = System.Drawing.Color.Black
        Me.kkkkk.Location = New System.Drawing.Point(484, 251)
        Me.kkkkk.Name = "kkkkk"
        Me.kkkkk.Size = New System.Drawing.Size(45, 17)
        Me.kkkkk.TabIndex = 89
        Me.kkkkk.Text = "Admin"
        '
        'adkl
        '
        Me.adkl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.adkl.ForeColor = System.Drawing.Color.Black
        Me.adkl.FormattingEnabled = True
        Me.adkl.Location = New System.Drawing.Point(535, 248)
        Me.adkl.Name = "adkl"
        Me.adkl.Size = New System.Drawing.Size(187, 25)
        Me.adkl.TabIndex = 90
        '
        'idad
        '
        Me.idad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.idad.ForeColor = System.Drawing.Color.Black
        Me.idad.FormattingEnabled = True
        Me.idad.Location = New System.Drawing.Point(234, 157)
        Me.idad.Name = "idad"
        Me.idad.Size = New System.Drawing.Size(187, 25)
        Me.idad.TabIndex = 91
        '
        'BooksPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1043, 580)
        Me.Controls.Add(Me.idad)
        Me.Controls.Add(Me.kkkkk)
        Me.Controls.Add(Me.adkl)
        Me.Controls.Add(Me.brkn)
        Me.Controls.Add(Me.DIZ)
        Me.Controls.Add(Me.BookDG)
        Me.Controls.Add(Me.SBK)
        Me.Controls.Add(Me.serbr)
        Me.Controls.Add(Me.di)
        Me.Controls.Add(Me.AutK)
        Me.Controls.Add(Me.nbka)
        Me.Controls.Add(Me.tnkat)
        Me.Controls.Add(Me.paneltreci)
        Me.Controls.Add(Me.au)
        Me.Controls.Add(Me.bominimiz)
        Me.Controls.Add(Me.nkn)
        Me.Controls.Add(Me.managus)
        Me.Controls.Add(Me.kk)
        Me.Controls.Add(Me.diglibr)
        Me.Controls.Add(Me.KaK)
        Me.Controls.Add(Me.KIme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BooksPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BooksPage"
        Me.paneltreci.ResumeLayout(False)
        CType(Me.librlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bookelips As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents bominimiz As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents paneltreci As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents addcate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents resbo As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents kori As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents delbo As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents editbo As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents addbo As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents librlogo As PictureBox
    Friend WithEvents di As Guna.UI.WinForms.GunaLabel
    Friend WithEvents AutK As TextBox
    Friend WithEvents nbka As TextBox
    Friend WithEvents tnkat As Guna.UI.WinForms.GunaLabel
    Friend WithEvents au As Guna.UI.WinForms.GunaLabel
    Friend WithEvents nkn As Guna.UI.WinForms.GunaLabel
    Friend WithEvents managus As Guna.UI.WinForms.GunaLabel
    Friend WithEvents kk As Guna.UI.WinForms.GunaLabel
    Friend WithEvents diglibr As Guna.UI.WinForms.GunaLabel
    Friend WithEvents KaK As ComboBox
    Friend WithEvents KIme As TextBox
    Friend WithEvents SBK As TextBox
    Friend WithEvents serbr As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BookDG As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DIZ As TextBox
    Friend WithEvents brkn As ComboBox
    Friend WithEvents kkkkk As Guna.UI.WinForms.GunaLabel
    Friend WithEvents adkl As ComboBox
    Friend WithEvents idad As ComboBox
End Class
