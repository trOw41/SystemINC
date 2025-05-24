<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        MenüToolStripMenuItem = New ToolStripMenuItem()
        BeendenToolStripMenuItem = New ToolStripMenuItem()
        InfoToolStripMenuItem = New ToolStripMenuItem()
        HilfeToolStripMenuItem = New ToolStripMenuItem()
        ÜberToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Console = New RichTextBox()
        Panel2 = New Panel()
        HddBar1 = New ProgressBar()
        HDDLabel = New Label()
        HDDBox = New ListBox()
        SystemView = New ListView()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        HelpProvider1 = New HelpProvider()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        resources.ApplyResources(MenuStrip1, "MenuStrip1")
        MenuStrip1.BackColor = Color.Lavender
        ErrorProvider1.SetError(MenuStrip1, resources.GetString("MenuStrip1.Error"))
        MenuStrip1.GripMargin = New Padding(0)
        HelpProvider1.SetHelpKeyword(MenuStrip1, resources.GetString("MenuStrip1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(MenuStrip1, resources.GetObject("MenuStrip1.HelpNavigator"))
        HelpProvider1.SetHelpString(MenuStrip1, resources.GetString("MenuStrip1.HelpString"))
        ErrorProvider1.SetIconAlignment(MenuStrip1, resources.GetObject("MenuStrip1.IconAlignment"))
        ErrorProvider1.SetIconPadding(MenuStrip1, resources.GetObject("MenuStrip1.IconPadding"))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenüToolStripMenuItem, InfoToolStripMenuItem})
        MenuStrip1.Name = "MenuStrip1"
        HelpProvider1.SetShowHelp(MenuStrip1, resources.GetObject("MenuStrip1.ShowHelp"))
        MenuStrip1.ShowItemToolTips = True
        ' 
        ' MenüToolStripMenuItem
        ' 
        resources.ApplyResources(MenüToolStripMenuItem, "MenüToolStripMenuItem")
        MenüToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BeendenToolStripMenuItem})
        MenüToolStripMenuItem.Image = My.Resources.Resources.icons8_mappe_144
        MenüToolStripMenuItem.Name = "MenüToolStripMenuItem"
        ' 
        ' BeendenToolStripMenuItem
        ' 
        resources.ApplyResources(BeendenToolStripMenuItem, "BeendenToolStripMenuItem")
        BeendenToolStripMenuItem.Image = My.Resources.Resources.icons8_löschen_144
        BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        ' 
        ' InfoToolStripMenuItem
        ' 
        resources.ApplyResources(InfoToolStripMenuItem, "InfoToolStripMenuItem")
        InfoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HilfeToolStripMenuItem, ÜberToolStripMenuItem})
        InfoToolStripMenuItem.Image = My.Resources.Resources._011_warning
        InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        ' 
        ' HilfeToolStripMenuItem
        ' 
        resources.ApplyResources(HilfeToolStripMenuItem, "HilfeToolStripMenuItem")
        HilfeToolStripMenuItem.Image = My.Resources.Resources._002_tablet
        HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        ' 
        ' ÜberToolStripMenuItem
        ' 
        resources.ApplyResources(ÜberToolStripMenuItem, "ÜberToolStripMenuItem")
        ÜberToolStripMenuItem.Image = My.Resources.Resources._009_technology
        ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        ' 
        ' Panel1
        ' 
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Console)
        Panel1.Controls.Add(Panel2)
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
        ' Button4
        ' 
        resources.ApplyResources(Button4, "Button4")
        ErrorProvider1.SetError(Button4, resources.GetString("Button4.Error"))
        Button4.ForeColor = SystemColors.ControlText
        HelpProvider1.SetHelpKeyword(Button4, resources.GetString("Button4.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Button4, resources.GetObject("Button4.HelpNavigator"))
        HelpProvider1.SetHelpString(Button4, resources.GetString("Button4.HelpString"))
        ErrorProvider1.SetIconAlignment(Button4, resources.GetObject("Button4.IconAlignment"))
        ErrorProvider1.SetIconPadding(Button4, resources.GetObject("Button4.IconPadding"))
        Button4.Name = "Button4"
        HelpProvider1.SetShowHelp(Button4, resources.GetObject("Button4.ShowHelp"))
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        ErrorProvider1.SetError(Button3, resources.GetString("Button3.Error"))
        Button3.ForeColor = SystemColors.ControlText
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
        Button2.ForeColor = SystemColors.ControlText
        HelpProvider1.SetHelpKeyword(Button2, resources.GetString("Button2.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Button2, resources.GetObject("Button2.HelpNavigator"))
        HelpProvider1.SetHelpString(Button2, resources.GetString("Button2.HelpString"))
        ErrorProvider1.SetIconAlignment(Button2, resources.GetObject("Button2.IconAlignment"))
        ErrorProvider1.SetIconPadding(Button2, resources.GetObject("Button2.IconPadding"))
        Button2.Name = "Button2"
        HelpProvider1.SetShowHelp(Button2, resources.GetObject("Button2.ShowHelp"))
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        ErrorProvider1.SetError(Button1, resources.GetString("Button1.Error"))
        Button1.ForeColor = SystemColors.ControlText
        HelpProvider1.SetHelpKeyword(Button1, resources.GetString("Button1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Button1, resources.GetObject("Button1.HelpNavigator"))
        HelpProvider1.SetHelpString(Button1, resources.GetString("Button1.HelpString"))
        ErrorProvider1.SetIconAlignment(Button1, resources.GetObject("Button1.IconAlignment"))
        ErrorProvider1.SetIconPadding(Button1, resources.GetObject("Button1.IconPadding"))
        Button1.Name = "Button1"
        HelpProvider1.SetShowHelp(Button1, resources.GetObject("Button1.ShowHelp"))
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Console
        ' 
        resources.ApplyResources(Console, "Console")
        Console.BackColor = SystemColors.ActiveCaptionText
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
        ' Panel2
        ' 
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Controls.Add(HddBar1)
        Panel2.Controls.Add(HDDLabel)
        ErrorProvider1.SetError(Panel2, resources.GetString("Panel2.Error"))
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
        HddBar1.Style = ProgressBarStyle.Continuous
        ' 
        ' HDDLabel
        ' 
        resources.ApplyResources(HDDLabel, "HDDLabel")
        HDDLabel.BackColor = Color.Transparent
        ErrorProvider1.SetError(HDDLabel, resources.GetString("HDDLabel.Error"))
        HDDLabel.FlatStyle = FlatStyle.Flat
        HDDLabel.ForeColor = Color.LightBlue
        HelpProvider1.SetHelpKeyword(HDDLabel, resources.GetString("HDDLabel.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(HDDLabel, resources.GetObject("HDDLabel.HelpNavigator"))
        HelpProvider1.SetHelpString(HDDLabel, resources.GetString("HDDLabel.HelpString"))
        ErrorProvider1.SetIconAlignment(HDDLabel, resources.GetObject("HDDLabel.IconAlignment"))
        ErrorProvider1.SetIconPadding(HDDLabel, resources.GetObject("HDDLabel.IconPadding"))
        HDDLabel.Name = "HDDLabel"
        HelpProvider1.SetShowHelp(HDDLabel, resources.GetObject("HDDLabel.ShowHelp"))
        ' 
        ' HDDBox
        ' 
        resources.ApplyResources(HDDBox, "HDDBox")
        HDDBox.BackColor = SystemColors.ActiveBorder
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
        HelpProvider1.SetHelpKeyword(SystemView, resources.GetString("SystemView.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(SystemView, resources.GetObject("SystemView.HelpNavigator"))
        HelpProvider1.SetHelpString(SystemView, resources.GetString("SystemView.HelpString"))
        ErrorProvider1.SetIconAlignment(SystemView, resources.GetObject("SystemView.IconAlignment"))
        ErrorProvider1.SetIconPadding(SystemView, resources.GetObject("SystemView.IconPadding"))
        SystemView.Name = "SystemView"
        HelpProvider1.SetShowHelp(SystemView, resources.GetObject("SystemView.ShowHelp"))
        SystemView.UseCompatibleStateImageBehavior = False
        ' 
        ' TableLayoutPanel1
        ' 
        resources.ApplyResources(TableLayoutPanel1, "TableLayoutPanel1")
        TableLayoutPanel1.BackColor = Color.AliceBlue
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(PictureBox2, 1, 0)
        TableLayoutPanel1.Controls.Add(PictureBox3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 1)
        TableLayoutPanel1.Controls.Add(Label2, 1, 1)
        TableLayoutPanel1.Controls.Add(Label3, 2, 1)
        ErrorProvider1.SetError(TableLayoutPanel1, resources.GetString("TableLayoutPanel1.Error"))
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        HelpProvider1.SetHelpKeyword(TableLayoutPanel1, resources.GetString("TableLayoutPanel1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(TableLayoutPanel1, resources.GetObject("TableLayoutPanel1.HelpNavigator"))
        HelpProvider1.SetHelpString(TableLayoutPanel1, resources.GetString("TableLayoutPanel1.HelpString"))
        ErrorProvider1.SetIconAlignment(TableLayoutPanel1, resources.GetObject("TableLayoutPanel1.IconAlignment"))
        ErrorProvider1.SetIconPadding(TableLayoutPanel1, resources.GetObject("TableLayoutPanel1.IconPadding"))
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        HelpProvider1.SetShowHelp(TableLayoutPanel1, resources.GetObject("TableLayoutPanel1.ShowHelp"))
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
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        ErrorProvider1.SetError(Label1, resources.GetString("Label1.Error"))
        HelpProvider1.SetHelpKeyword(Label1, resources.GetString("Label1.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Label1, resources.GetObject("Label1.HelpNavigator"))
        HelpProvider1.SetHelpString(Label1, resources.GetString("Label1.HelpString"))
        ErrorProvider1.SetIconAlignment(Label1, resources.GetObject("Label1.IconAlignment"))
        ErrorProvider1.SetIconPadding(Label1, resources.GetObject("Label1.IconPadding"))
        Label1.Name = "Label1"
        HelpProvider1.SetShowHelp(Label1, resources.GetObject("Label1.ShowHelp"))
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
        ErrorProvider1.SetError(Label3, resources.GetString("Label3.Error"))
        HelpProvider1.SetHelpKeyword(Label3, resources.GetString("Label3.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Label3, resources.GetObject("Label3.HelpNavigator"))
        HelpProvider1.SetHelpString(Label3, resources.GetString("Label3.HelpString"))
        ErrorProvider1.SetIconAlignment(Label3, resources.GetObject("Label3.IconAlignment"))
        ErrorProvider1.SetIconPadding(Label3, resources.GetObject("Label3.IconPadding"))
        Label3.Name = "Label3"
        HelpProvider1.SetShowHelp(Label3, resources.GetObject("Label3.ShowHelp"))
        ' 
        ' HelpProvider1
        ' 
        resources.ApplyResources(HelpProvider1, "HelpProvider1")
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        resources.ApplyResources(ErrorProvider1, "ErrorProvider1")
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        HelpButton = True
        HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        HelpProvider1.SetHelpNavigator(Me, resources.GetObject("$this.HelpNavigator"))
        HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        HelpProvider1.SetShowHelp(Me, resources.GetObject("$this.ShowHelp"))
        TransparencyKey = SystemColors.ControlDarkDark
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub




    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SystemView As ListView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
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
    Friend WithEvents ÜberToolStripMenuItem As ToolStripMenuItem
End Class
