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
        ToolStripSeparator1 = New ToolStripSeparator()
        ExportAsToolStripMenuItem = New ToolStripMenuItem()
        InfoToolStripMenuItem = New ToolStripMenuItem()
        ÜberToolStripMenuItem = New ToolStripMenuItem()
        SystemINCToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        EULAToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        InfoMenu = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        HilfeToolStripMenuItem1 = New ToolStripMenuItem()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Button4 = New Button()
        Console = New RichTextBox()
        Button3 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        HDDLabel = New LinkLabel()
        HDDBox = New ListBox()
        HddBar1 = New ProgressBar()
        SHButton = New Button()
        SystemView = New ListView()
        ImageList1 = New ImageList(components)
        Label4 = New Label()
        Button5 = New Button()
        Label1 = New Label()
        Panel3 = New Panel()
        ServiceButton = New Button()
        tskmgr = New Button()
        BindingSource1 = New BindingSource(components)
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        resources.ApplyResources(MenuStrip1, "MenuStrip1")
        MenuStrip1.AllowClickThrough = True
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.BackgroundImage = My.Resources.Resources._011_system_administration
        MenuStrip1.GripMargin = New Padding(10)
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenüToolStripMenuItem, SystemToolStripMenuItem, InfoToolStripMenuItem})
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.ShowItemToolTips = True
        MenuStrip1.Stretch = False
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
        ÜberToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SystemINCToolStripMenuItem, ToolStripSeparator3, EULAToolStripMenuItem, ToolStripSeparator6, InfoMenu})
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
        ' ToolStripSeparator6
        ' 
        resources.ApplyResources(ToolStripSeparator6, "ToolStripSeparator6")
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ' 
        ' InfoMenu
        ' 
        resources.ApplyResources(InfoMenu, "InfoMenu")
        InfoMenu.Name = "InfoMenu"
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
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Console)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(SHButton)
        Panel1.Controls.Add(SystemView)
        Panel1.Name = "Panel1"
        ' 
        ' PictureBox1
        ' 
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Image = My.Resources.Resources._028_faq
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.AutoEllipsis = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.ForeColor = Color.Gainsboro
        Label2.Name = "Label2"
        Label2.UseCompatibleTextRendering = True
        ' 
        ' TextBox1
        ' 
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.Name = "TextBox1"
        ' 
        ' Label5
        ' 
        resources.ApplyResources(Label5, "Label5")
        Label5.AutoEllipsis = True
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.FlatStyle = FlatStyle.Popup
        Label5.ForeColor = Color.Gainsboro
        Label5.Name = "Label5"
        ' 
        ' Button4
        ' 
        resources.ApplyResources(Button4, "Button4")
        Button4.ForeColor = SystemColors.GradientInactiveCaption
        Button4.Name = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Console
        ' 
        resources.ApplyResources(Console, "Console")
        Console.BackColor = SystemColors.ActiveCaptionText
        Console.BorderStyle = BorderStyle.FixedSingle
        Console.ForeColor = SystemColors.Info
        Console.Name = "Console"
        Console.ReadOnly = True
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        Button3.ForeColor = SystemColors.GradientInactiveCaption
        Button3.Name = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        resources.ApplyResources(Button2, "Button2")
        Button2.ForeColor = SystemColors.GradientInactiveCaption
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        resources.ApplyResources(Panel2, "Panel2")
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(HDDLabel)
        Panel2.Controls.Add(HDDBox)
        Panel2.Controls.Add(HddBar1)
        Panel2.ForeColor = SystemColors.ActiveCaptionText
        Panel2.Name = "Panel2"
        ' 
        ' HDDLabel
        ' 
        resources.ApplyResources(HDDLabel, "HDDLabel")
        HDDLabel.ForeColor = SystemColors.ActiveCaptionText
        HDDLabel.LinkBehavior = LinkBehavior.HoverUnderline
        HDDLabel.LinkColor = SystemColors.ActiveCaptionText
        HDDLabel.Name = "HDDLabel"
        HDDLabel.TabStop = True
        HDDLabel.VisitedLinkColor = Color.Silver
        ' 
        ' HDDBox
        ' 
        resources.ApplyResources(HDDBox, "HDDBox")
        HDDBox.BackColor = SystemColors.ControlDark
        HDDBox.ForeColor = SystemColors.ActiveCaptionText
        HDDBox.FormattingEnabled = True
        HDDBox.Name = "HDDBox"
        ' 
        ' HddBar1
        ' 
        resources.ApplyResources(HddBar1, "HddBar1")
        HddBar1.BackColor = SystemColors.ControlLightLight
        HddBar1.ForeColor = Color.GreenYellow
        HddBar1.Name = "HddBar1"
        HddBar1.Step = 1
        HddBar1.Value = 50
        ' 
        ' SHButton
        ' 
        resources.ApplyResources(SHButton, "SHButton")
        SHButton.ForeColor = SystemColors.GradientInactiveCaption
        SHButton.Name = "SHButton"
        SHButton.UseVisualStyleBackColor = True
        ' 
        ' SystemView
        ' 
        resources.ApplyResources(SystemView, "SystemView")
        SystemView.BackColor = SystemColors.ActiveBorder
        SystemView.BorderStyle = BorderStyle.FixedSingle
        SystemView.ForeColor = SystemColors.ActiveCaptionText
        SystemView.FullRowSelect = True
        SystemView.GridLines = True
        SystemView.Name = "SystemView"
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
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.FlatStyle = FlatStyle.Flat
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Name = "Label4"
        ' 
        ' Button5
        ' 
        resources.ApplyResources(Button5, "Button5")
        Button5.ForeColor = SystemColors.InactiveCaptionText
        Button5.Name = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.AutoEllipsis = True
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.LiveSetting = Automation.AutomationLiveSetting.Polite
        Label1.Name = "Label1"
        Label1.UseCompatibleTextRendering = True
        ' 
        ' Panel3
        ' 
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.BackColor = SystemColors.ControlLight
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(ServiceButton)
        Panel3.Controls.Add(tskmgr)
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Label4)
        Panel3.Name = "Panel3"
        ' 
        ' ServiceButton
        ' 
        resources.ApplyResources(ServiceButton, "ServiceButton")
        ServiceButton.ForeColor = SystemColors.InactiveCaptionText
        ServiceButton.Name = "ServiceButton"
        ServiceButton.UseVisualStyleBackColor = True
        ' 
        ' tskmgr
        ' 
        resources.ApplyResources(tskmgr, "tskmgr")
        tskmgr.ForeColor = SystemColors.InactiveCaptionText
        tskmgr.Name = "tskmgr"
        tskmgr.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        HelpButton = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub




    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SystemView As ListView
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HddBar1 As ProgressBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Console As RichTextBox
    Friend WithEvents SHButton As Button
    Friend WithEvents Label1 As Label
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HDDBox As ListBox
    Friend WithEvents HDDLabel As LinkLabel
    Friend WithEvents tskmgr As Button
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents InfoMenu As ToolStripMenuItem
    Friend WithEvents ServiceButton As Button
    Friend WithEvents Button1 As Button
End Class
