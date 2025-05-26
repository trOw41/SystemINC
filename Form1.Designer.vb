<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        MenüToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        BeendenToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        SystemToolStripMenuItem = New ToolStripMenuItem()
        ExportSysteminformationAsXMLToolStripMenuItem = New ToolStripMenuItem()
        InfoToolStripMenuItem = New ToolStripMenuItem()
        ÜberToolStripMenuItem = New ToolStripMenuItem()
        SystemINCToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        EULAToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        HilfeToolStripMenuItem1 = New ToolStripMenuItem()
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Console = New RichTextBox()
        Button3 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        HddBar1 = New ProgressBar()
        HDDLabel = New Label()
        Button1 = New Button()
        HDDBox = New ListBox()
        SystemView = New ListView()
        ImageList1 = New ImageList(components)
        TP1 = New TableLayoutPanel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        HelpProvider1 = New HelpProvider()
        Panel3 = New Panel()
        ErrorProvider1 = New ErrorProvider(components)
        BindingSource1 = New BindingSource(components)
        ToolStripSeparator1 = New ToolStripSeparator()
        ExportAsToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TP1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        resources.ApplyResources(MenuStrip1, "MenuStrip1")
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        ErrorProvider1.SetError(MenuStrip1, resources.GetString("MenuStrip1.Error"))
        MenuStrip1.GripMargin = New Padding(10)
        HelpProvider1.SetHelpKeyword(MenuStrip1, resources.GetString("MenuStrip1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(MenuStrip1, resources.GetObject("MenuStrip1.HelpNavigator"))
        HelpProvider1.SetHelpString(MenuStrip1, resources.GetString("MenuStrip1.HelpString"))
        ErrorProvider1.SetIconAlignment(MenuStrip1, resources.GetObject("MenuStrip1.IconAlignment"))
        ErrorProvider1.SetIconPadding(MenuStrip1, resources.GetObject("MenuStrip1.IconPadding"))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenüToolStripMenuItem, SystemToolStripMenuItem, InfoToolStripMenuItem})
        MenuStrip1.Name = "MenuStrip1"
        HelpProvider1.SetShowHelp(MenuStrip1, resources.GetObject("MenuStrip1.ShowHelp"))
        MenuStrip1.ShowItemToolTips = True
        ' 
        ' MenüToolStripMenuItem
        ' 
        resources.ApplyResources(MenüToolStripMenuItem, "MenüToolStripMenuItem")
        MenüToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripSeparator4, BeendenToolStripMenuItem, ToolStripSeparator5})
        MenüToolStripMenuItem.Name = "MenüToolStripMenuItem"
        ' 
        ' ToolStripSeparator4
        ' 
        resources.ApplyResources(ToolStripSeparator4, "ToolStripSeparator4")
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ' 
        ' BeendenToolStripMenuItem
        ' 
        resources.ApplyResources(BeendenToolStripMenuItem, "BeendenToolStripMenuItem")
        BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        ' 
        ' ToolStripSeparator5
        ' 
        resources.ApplyResources(ToolStripSeparator5, "ToolStripSeparator5")
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ' 
        ' SystemToolStripMenuItem
        ' 
        resources.ApplyResources(SystemToolStripMenuItem, "SystemToolStripMenuItem")
        SystemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportSysteminformationAsXMLToolStripMenuItem, ToolStripSeparator1, ExportAsToolStripMenuItem})
        SystemToolStripMenuItem.Image = My.Resources.Resources._031_computer
        SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        ' 
        ' ExportSysteminformationAsXMLToolStripMenuItem
        ' 
        resources.ApplyResources(ExportSysteminformationAsXMLToolStripMenuItem, "ExportSysteminformationAsXMLToolStripMenuItem")
        ExportSysteminformationAsXMLToolStripMenuItem.Image = My.Resources.Resources._004_computer_science
        ExportSysteminformationAsXMLToolStripMenuItem.Name = "ExportSysteminformationAsXMLToolStripMenuItem"
        ' 
        ' InfoToolStripMenuItem
        ' 
        resources.ApplyResources(InfoToolStripMenuItem, "InfoToolStripMenuItem")
        InfoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ÜberToolStripMenuItem, ToolStripSeparator2, HilfeToolStripMenuItem1})
        InfoToolStripMenuItem.Image = My.Resources.Resources._018_information_button
        InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        ' 
        ' ÜberToolStripMenuItem
        ' 
        resources.ApplyResources(ÜberToolStripMenuItem, "ÜberToolStripMenuItem")
        ÜberToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SystemINCToolStripMenuItem, ToolStripSeparator3, EULAToolStripMenuItem})
        ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        ' 
        ' SystemINCToolStripMenuItem
        ' 
        resources.ApplyResources(SystemINCToolStripMenuItem, "SystemINCToolStripMenuItem")
        SystemINCToolStripMenuItem.Name = "SystemINCToolStripMenuItem"
        ' 
        ' ToolStripSeparator3
        ' 
        resources.ApplyResources(ToolStripSeparator3, "ToolStripSeparator3")
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ' 
        ' EULAToolStripMenuItem
        ' 
        resources.ApplyResources(EULAToolStripMenuItem, "EULAToolStripMenuItem")
        EULAToolStripMenuItem.Name = "EULAToolStripMenuItem"
        ' 
        ' ToolStripSeparator2
        ' 
        resources.ApplyResources(ToolStripSeparator2, "ToolStripSeparator2")
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ' 
        ' HilfeToolStripMenuItem1
        ' 
        resources.ApplyResources(HilfeToolStripMenuItem1, "HilfeToolStripMenuItem1")
        HilfeToolStripMenuItem1.Image = My.Resources.Resources._028_faq
        HilfeToolStripMenuItem1.Name = "HilfeToolStripMenuItem1"
        ' 
        ' Panel1
        ' 
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Console)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(HDDBox)
        Panel1.Controls.Add(SystemView)
        ErrorProvider1.SetError(Panel1, resources.GetString("Panel1.Error"))
        HelpProvider1.SetHelpKeyword(Panel1, resources.GetString("Panel1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Panel1, resources.GetObject("Panel1.HelpNavigator"))
        HelpProvider1.SetHelpString(Panel1, resources.GetString("Panel1.HelpString"))
        ErrorProvider1.SetIconAlignment(Panel1, resources.GetObject("Panel1.IconAlignment"))
        ErrorProvider1.SetIconPadding(Panel1, resources.GetObject("Panel1.IconPadding"))
        Panel1.Name = "Panel1"
        HelpProvider1.SetShowHelp(Panel1, resources.GetObject("Panel1.ShowHelp"))
        ' 
        ' Label5
        ' 
        resources.ApplyResources(Label5, "Label5")
        ErrorProvider1.SetError(Label5, resources.GetString("Label5.Error"))
        Label5.ForeColor = Color.AliceBlue
        HelpProvider1.SetHelpKeyword(Label5, resources.GetString("Label5.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Label5, resources.GetObject("Label5.HelpNavigator"))
        HelpProvider1.SetHelpString(Label5, resources.GetString("Label5.HelpString"))
        ErrorProvider1.SetIconAlignment(Label5, resources.GetObject("Label5.IconAlignment"))
        ErrorProvider1.SetIconPadding(Label5, resources.GetObject("Label5.IconPadding"))
        Label5.Name = "Label5"
        HelpProvider1.SetShowHelp(Label5, resources.GetObject("Label5.ShowHelp"))
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        ErrorProvider1.SetError(Label4, resources.GetString("Label4.Error"))
        Label4.ForeColor = Color.AliceBlue
        HelpProvider1.SetHelpKeyword(Label4, resources.GetString("Label4.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Label4, resources.GetObject("Label4.HelpNavigator"))
        HelpProvider1.SetHelpString(Label4, resources.GetString("Label4.HelpString"))
        ErrorProvider1.SetIconAlignment(Label4, resources.GetObject("Label4.IconAlignment"))
        ErrorProvider1.SetIconPadding(Label4, resources.GetObject("Label4.IconPadding"))
        Label4.Name = "Label4"
        HelpProvider1.SetShowHelp(Label4, resources.GetObject("Label4.ShowHelp"))
        ' 
        ' Button4
        ' 
        resources.ApplyResources(Button4, "Button4")
        ErrorProvider1.SetError(Button4, resources.GetString("Button4.Error"))
        Button4.ForeColor = Color.Gold
        HelpProvider1.SetHelpKeyword(Button4, resources.GetString("Button4.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Button4, resources.GetObject("Button4.HelpNavigator"))
        HelpProvider1.SetHelpString(Button4, resources.GetString("Button4.HelpString"))
        ErrorProvider1.SetIconAlignment(Button4, resources.GetObject("Button4.IconAlignment"))
        ErrorProvider1.SetIconPadding(Button4, resources.GetObject("Button4.IconPadding"))
        Button4.Name = "Button4"
        HelpProvider1.SetShowHelp(Button4, resources.GetObject("Button4.ShowHelp"))
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        resources.ApplyResources(Button5, "Button5")
        ErrorProvider1.SetError(Button5, resources.GetString("Button5.Error"))
        Button5.ForeColor = Color.Gold
        HelpProvider1.SetHelpKeyword(Button5, resources.GetString("Button5.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Button5, resources.GetObject("Button5.HelpNavigator"))
        HelpProvider1.SetHelpString(Button5, resources.GetString("Button5.HelpString"))
        ErrorProvider1.SetIconAlignment(Button5, resources.GetObject("Button5.IconAlignment"))
        ErrorProvider1.SetIconPadding(Button5, resources.GetObject("Button5.IconPadding"))
        Button5.Name = "Button5"
        HelpProvider1.SetShowHelp(Button5, resources.GetObject("Button5.ShowHelp"))
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Console
        ' 
        resources.ApplyResources(Console, "Console")
        Console.BackColor = SystemColors.ActiveCaptionText
        Console.BorderStyle = BorderStyle.FixedSingle
        ErrorProvider1.SetError(Console, resources.GetString("Console.Error"))
        Console.ForeColor = SystemColors.Window
        HelpProvider1.SetHelpKeyword(Console, resources.GetString("Console.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Console, resources.GetObject("Console.HelpNavigator"))
        HelpProvider1.SetHelpString(Console, resources.GetString("Console.HelpString"))
        ErrorProvider1.SetIconAlignment(Console, resources.GetObject("Console.IconAlignment"))
        ErrorProvider1.SetIconPadding(Console, resources.GetObject("Console.IconPadding"))
        Console.Name = "Console"
        HelpProvider1.SetShowHelp(Console, resources.GetObject("Console.ShowHelp"))
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        ErrorProvider1.SetError(Button3, resources.GetString("Button3.Error"))
        Button3.ForeColor = Color.Gold
        HelpProvider1.SetHelpKeyword(Button3, resources.GetString("Button3.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Button3, resources.GetObject("Button3.HelpNavigator"))
        HelpProvider1.SetHelpString(Button3, resources.GetString("Button3.HelpString"))
        ErrorProvider1.SetIconAlignment(Button3, resources.GetObject("Button3.IconAlignment"))
        ErrorProvider1.SetIconPadding(Button3, resources.GetObject("Button3.IconPadding"))
        Button3.Name = "Button3"
        HelpProvider1.SetShowHelp(Button3, resources.GetObject("Button3.ShowHelp"))
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        resources.ApplyResources(Button2, "Button2")
        ErrorProvider1.SetError(Button2, resources.GetString("Button2.Error"))
        Button2.ForeColor = Color.Gold
        HelpProvider1.SetHelpKeyword(Button2, resources.GetString("Button2.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Button2, resources.GetObject("Button2.HelpNavigator"))
        HelpProvider1.SetHelpString(Button2, resources.GetString("Button2.HelpString"))
        ErrorProvider1.SetIconAlignment(Button2, resources.GetObject("Button2.IconAlignment"))
        ErrorProvider1.SetIconPadding(Button2, resources.GetObject("Button2.IconPadding"))
        Button2.Name = "Button2"
        HelpProvider1.SetShowHelp(Button2, resources.GetObject("Button2.ShowHelp"))
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Controls.Add(HddBar1)
        Panel2.Controls.Add(HDDLabel)
        ErrorProvider1.SetError(Panel2, resources.GetString("Panel2.Error"))
        Panel2.ForeColor = SystemColors.ActiveCaptionText
        HelpProvider1.SetHelpKeyword(Panel2, resources.GetString("Panel2.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Panel2, resources.GetObject("Panel2.HelpNavigator"))
        HelpProvider1.SetHelpString(Panel2, resources.GetString("Panel2.HelpString"))
        ErrorProvider1.SetIconAlignment(Panel2, resources.GetObject("Panel2.IconAlignment"))
        ErrorProvider1.SetIconPadding(Panel2, resources.GetObject("Panel2.IconPadding"))
        Panel2.Name = "Panel2"
        HelpProvider1.SetShowHelp(Panel2, resources.GetObject("Panel2.ShowHelp"))
        ' 
        ' HddBar1
        ' 
        resources.ApplyResources(HddBar1, "HddBar1")
        ErrorProvider1.SetError(HddBar1, resources.GetString("HddBar1.Error"))
        HddBar1.ForeColor = Color.GreenYellow
        HelpProvider1.SetHelpKeyword(HddBar1, resources.GetString("HddBar1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(HddBar1, resources.GetObject("HddBar1.HelpNavigator"))
        HelpProvider1.SetHelpString(HddBar1, resources.GetString("HddBar1.HelpString"))
        ErrorProvider1.SetIconAlignment(HddBar1, resources.GetObject("HddBar1.IconAlignment"))
        ErrorProvider1.SetIconPadding(HddBar1, resources.GetObject("HddBar1.IconPadding"))
        HddBar1.Name = "HddBar1"
        HelpProvider1.SetShowHelp(HddBar1, resources.GetObject("HddBar1.ShowHelp"))
        HddBar1.Step = 1
        HddBar1.Value = 15
        ' 
        ' HDDLabel
        ' 
        resources.ApplyResources(HDDLabel, "HDDLabel")
        HDDLabel.BackColor = Color.Transparent
        ErrorProvider1.SetError(HDDLabel, resources.GetString("HDDLabel.Error"))
        HDDLabel.FlatStyle = FlatStyle.Flat
        HDDLabel.ForeColor = SystemColors.ActiveCaptionText
        HelpProvider1.SetHelpKeyword(HDDLabel, resources.GetString("HDDLabel.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(HDDLabel, resources.GetObject("HDDLabel.HelpNavigator"))
        HelpProvider1.SetHelpString(HDDLabel, resources.GetString("HDDLabel.HelpString"))
        ErrorProvider1.SetIconAlignment(HDDLabel, resources.GetObject("HDDLabel.IconAlignment"))
        ErrorProvider1.SetIconPadding(HDDLabel, resources.GetObject("HDDLabel.IconPadding"))
        HDDLabel.Name = "HDDLabel"
        HelpProvider1.SetShowHelp(HDDLabel, resources.GetObject("HDDLabel.ShowHelp"))
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        ErrorProvider1.SetError(Button1, resources.GetString("Button1.Error"))
        Button1.ForeColor = Color.Gold
        HelpProvider1.SetHelpKeyword(Button1, resources.GetString("Button1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Button1, resources.GetObject("Button1.HelpNavigator"))
        HelpProvider1.SetHelpString(Button1, resources.GetString("Button1.HelpString"))
        ErrorProvider1.SetIconAlignment(Button1, resources.GetObject("Button1.IconAlignment"))
        ErrorProvider1.SetIconPadding(Button1, resources.GetObject("Button1.IconPadding"))
        Button1.Name = "Button1"
        HelpProvider1.SetShowHelp(Button1, resources.GetObject("Button1.ShowHelp"))
        Button1.UseVisualStyleBackColor = True
        ' 
        ' HDDBox
        ' 
        resources.ApplyResources(HDDBox, "HDDBox")
        HDDBox.BackColor = SystemColors.ActiveBorder
        HDDBox.BorderStyle = BorderStyle.FixedSingle
        ErrorProvider1.SetError(HDDBox, resources.GetString("HDDBox.Error"))
        HDDBox.ForeColor = SystemColors.MenuText
        HDDBox.FormattingEnabled = True
        HelpProvider1.SetHelpKeyword(HDDBox, resources.GetString("HDDBox.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(HDDBox, resources.GetObject("HDDBox.HelpNavigator"))
        HelpProvider1.SetHelpString(HDDBox, resources.GetString("HDDBox.HelpString"))
        ErrorProvider1.SetIconAlignment(HDDBox, resources.GetObject("HDDBox.IconAlignment"))
        ErrorProvider1.SetIconPadding(HDDBox, resources.GetObject("HDDBox.IconPadding"))
        HDDBox.Name = "HDDBox"
        HelpProvider1.SetShowHelp(HDDBox, resources.GetObject("HDDBox.ShowHelp"))
        ' 
        ' SystemView
        ' 
        resources.ApplyResources(SystemView, "SystemView")
        SystemView.BackColor = SystemColors.ActiveBorder
        SystemView.BorderStyle = BorderStyle.FixedSingle
        ErrorProvider1.SetError(SystemView, resources.GetString("SystemView.Error"))
        SystemView.ForeColor = SystemColors.ActiveCaptionText
        SystemView.FullRowSelect = True
        SystemView.GridLines = True
        HelpProvider1.SetHelpKeyword(SystemView, resources.GetString("SystemView.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(SystemView, resources.GetObject("SystemView.HelpNavigator"))
        HelpProvider1.SetHelpString(SystemView, resources.GetString("SystemView.HelpString"))
        ErrorProvider1.SetIconAlignment(SystemView, resources.GetObject("SystemView.IconAlignment"))
        ErrorProvider1.SetIconPadding(SystemView, resources.GetObject("SystemView.IconPadding"))
        SystemView.Name = "SystemView"
        HelpProvider1.SetShowHelp(SystemView, resources.GetObject("SystemView.ShowHelp"))
        SystemView.ShowItemToolTips = True
        SystemView.SmallImageList = ImageList1
        SystemView.UseCompatibleStateImageBehavior = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "015-os.png")
        ImageList1.Images.SetKeyName(1, "005-information-technology.png")
        ImageList1.Images.SetKeyName(2, "031-computer.png")
        ImageList1.Images.SetKeyName(3, "017-profile-user.png")
        ImageList1.Images.SetKeyName(4, "042-mergers-and-acquisitions.png")
        ImageList1.Images.SetKeyName(5, "023-cpu.png")
        ImageList1.Images.SetKeyName(6, "029-ram-1.png")
        ImageList1.Images.SetKeyName(7, "028-ram.png")
        ImageList1.Images.SetKeyName(8, "032-monitor.png")
        ImageList1.Images.SetKeyName(9, "034-ip-address.png")
        ImageList1.Images.SetKeyName(10, "037-folder-1.png")
        ImageList1.Images.SetKeyName(11, "036-folder.png")
        ImageList1.Images.SetKeyName(12, "044-wifi-1.png")
        ImageList1.Images.SetKeyName(13, "011-system-administration.png")
        ImageList1.Images.SetKeyName(14, "045-firmware.png")
        ImageList1.Images.SetKeyName(15, "022-processor.png")
        ImageList1.Images.SetKeyName(16, "026-graphics-card.png")
        ' 
        ' TP1
        ' 
        resources.ApplyResources(TP1, "TP1")
        TP1.BackColor = SystemColors.ActiveCaption
        TP1.Controls.Add(PictureBox2, 1, 0)
        TP1.Controls.Add(PictureBox3, 2, 0)
        TP1.Controls.Add(PictureBox1, 0, 0)
        TP1.Controls.Add(Label2, 1, 1)
        TP1.Controls.Add(Label3, 2, 1)
        ErrorProvider1.SetError(TP1, resources.GetString("TP1.Error"))
        TP1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        HelpProvider1.SetHelpKeyword(TP1, resources.GetString("TP1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(TP1, resources.GetObject("TP1.HelpNavigator"))
        HelpProvider1.SetHelpString(TP1, resources.GetString("TP1.HelpString"))
        ErrorProvider1.SetIconAlignment(TP1, resources.GetObject("TP1.IconAlignment"))
        ErrorProvider1.SetIconPadding(TP1, resources.GetObject("TP1.IconPadding"))
        TP1.Name = "TP1"
        HelpProvider1.SetShowHelp(TP1, resources.GetObject("TP1.ShowHelp"))
        ' 
        ' PictureBox2
        ' 
        resources.ApplyResources(PictureBox2, "PictureBox2")
        ErrorProvider1.SetError(PictureBox2, resources.GetString("PictureBox2.Error"))
        HelpProvider1.SetHelpKeyword(PictureBox2, resources.GetString("PictureBox2.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(PictureBox2, resources.GetObject("PictureBox2.HelpNavigator"))
        HelpProvider1.SetHelpString(PictureBox2, resources.GetString("PictureBox2.HelpString"))
        ErrorProvider1.SetIconAlignment(PictureBox2, resources.GetObject("PictureBox2.IconAlignment"))
        ErrorProvider1.SetIconPadding(PictureBox2, resources.GetObject("PictureBox2.IconPadding"))
        PictureBox2.Image = My.Resources.Resources._005_hacker
        PictureBox2.Name = "PictureBox2"
        HelpProvider1.SetShowHelp(PictureBox2, resources.GetObject("PictureBox2.ShowHelp"))
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        resources.ApplyResources(PictureBox3, "PictureBox3")
        ErrorProvider1.SetError(PictureBox3, resources.GetString("PictureBox3.Error"))
        HelpProvider1.SetHelpKeyword(PictureBox3, resources.GetString("PictureBox3.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(PictureBox3, resources.GetObject("PictureBox3.HelpNavigator"))
        HelpProvider1.SetHelpString(PictureBox3, resources.GetString("PictureBox3.HelpString"))
        ErrorProvider1.SetIconAlignment(PictureBox3, resources.GetObject("PictureBox3.IconAlignment"))
        ErrorProvider1.SetIconPadding(PictureBox3, resources.GetObject("PictureBox3.IconPadding"))
        PictureBox3.Image = My.Resources.Resources._010_stethoscope
        PictureBox3.Name = "PictureBox3"
        HelpProvider1.SetShowHelp(PictureBox3, resources.GetObject("PictureBox3.ShowHelp"))
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        resources.ApplyResources(PictureBox1, "PictureBox1")
        ErrorProvider1.SetError(PictureBox1, resources.GetString("PictureBox1.Error"))
        HelpProvider1.SetHelpKeyword(PictureBox1, resources.GetString("PictureBox1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(PictureBox1, resources.GetObject("PictureBox1.HelpNavigator"))
        HelpProvider1.SetHelpString(PictureBox1, resources.GetString("PictureBox1.HelpString"))
        ErrorProvider1.SetIconAlignment(PictureBox1, resources.GetObject("PictureBox1.IconAlignment"))
        ErrorProvider1.SetIconPadding(PictureBox1, resources.GetObject("PictureBox1.IconPadding"))
        PictureBox1.Image = My.Resources.Resources._020_computer_1
        PictureBox1.Name = "PictureBox1"
        HelpProvider1.SetShowHelp(PictureBox1, resources.GetObject("PictureBox1.ShowHelp"))
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        ErrorProvider1.SetError(Label2, resources.GetString("Label2.Error"))
        HelpProvider1.SetHelpKeyword(Label2, resources.GetString("Label2.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Label2, resources.GetObject("Label2.HelpNavigator"))
        HelpProvider1.SetHelpString(Label2, resources.GetString("Label2.HelpString"))
        ErrorProvider1.SetIconAlignment(Label2, resources.GetObject("Label2.IconAlignment"))
        ErrorProvider1.SetIconPadding(Label2, resources.GetObject("Label2.IconPadding"))
        Label2.Name = "Label2"
        HelpProvider1.SetShowHelp(Label2, resources.GetObject("Label2.ShowHelp"))
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.BackColor = SystemColors.ActiveCaption
        ErrorProvider1.SetError(Label3, resources.GetString("Label3.Error"))
        HelpProvider1.SetHelpKeyword(Label3, resources.GetString("Label3.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Label3, resources.GetObject("Label3.HelpNavigator"))
        HelpProvider1.SetHelpString(Label3, resources.GetString("Label3.HelpString"))
        ErrorProvider1.SetIconAlignment(Label3, resources.GetObject("Label3.IconAlignment"))
        ErrorProvider1.SetIconPadding(Label3, resources.GetObject("Label3.IconPadding"))
        Label3.Name = "Label3"
        HelpProvider1.SetShowHelp(Label3, resources.GetObject("Label3.ShowHelp"))
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.AutoEllipsis = True
        ErrorProvider1.SetError(Label1, resources.GetString("Label1.Error"))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        HelpProvider1.SetHelpKeyword(Label1, resources.GetString("Label1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Label1, resources.GetObject("Label1.HelpNavigator"))
        HelpProvider1.SetHelpString(Label1, resources.GetString("Label1.HelpString"))
        ErrorProvider1.SetIconAlignment(Label1, resources.GetObject("Label1.IconAlignment"))
        ErrorProvider1.SetIconPadding(Label1, resources.GetObject("Label1.IconPadding"))
        Label1.LiveSetting = Automation.AutomationLiveSetting.Polite
        Label1.Name = "Label1"
        HelpProvider1.SetShowHelp(Label1, resources.GetObject("Label1.ShowHelp"))
        Label1.UseCompatibleTextRendering = True
        ' 
        ' HelpProvider1
        ' 
        resources.ApplyResources(HelpProvider1, "HelpProvider1")
        ' 
        ' Panel3
        ' 
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.BackColor = SystemColors.ControlDarkDark
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(TP1)
        ErrorProvider1.SetError(Panel3, resources.GetString("Panel3.Error"))
        HelpProvider1.SetHelpKeyword(Panel3, resources.GetString("Panel3.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Panel3, resources.GetObject("Panel3.HelpNavigator"))
        HelpProvider1.SetHelpString(Panel3, resources.GetString("Panel3.HelpString"))
        ErrorProvider1.SetIconAlignment(Panel3, resources.GetObject("Panel3.IconAlignment"))
        ErrorProvider1.SetIconPadding(Panel3, resources.GetObject("Panel3.IconPadding"))
        Panel3.Name = "Panel3"
        HelpProvider1.SetShowHelp(Panel3, resources.GetObject("Panel3.ShowHelp"))
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        resources.ApplyResources(ErrorProvider1, "ErrorProvider1")
        ' 
        ' ToolStripSeparator1
        ' 
        resources.ApplyResources(ToolStripSeparator1, "ToolStripSeparator1")
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ' 
        ' ExportAsToolStripMenuItem
        ' 
        resources.ApplyResources(ExportAsToolStripMenuItem, "ExportAsToolStripMenuItem")
        ExportAsToolStripMenuItem.Image = My.Resources.Resources._010_recommendations
        ExportAsToolStripMenuItem.Name = "ExportAsToolStripMenuItem"
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        HelpButton = True
        HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Me, resources.GetObject("$this.HelpNavigator"))
        HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        HelpProvider1.SetShowHelp(Me, resources.GetObject("$this.ShowHelp"))
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TP1.ResumeLayout(False)
        TP1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub




    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SystemView As ListView
    Friend WithEvents TP1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HDDLabel As Label
    Friend WithEvents HddBar1 As ProgressBar
    Friend WithEvents HDDBox As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Console As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label5 As Label
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemINCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EULAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents HilfeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportSysteminformationAsXMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExportAsToolStripMenuItem As ToolStripMenuItem
End Class
