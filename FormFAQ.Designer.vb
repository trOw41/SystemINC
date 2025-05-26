<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFAQ
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer
    Private MenuStrip1 As MenuStrip
    Private WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Private WithEvents SchließenToolStripMenuItem As ToolStripMenuItem
    Private WithEvents IndexBox As ToolStripComboBox
    Private WithEvents faqTreeView As TreeView

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFAQ))
        MenuStrip1 = New MenuStrip()
        DateiToolStripMenuItem = New ToolStripMenuItem()
        SchließenToolStripMenuItem = New ToolStripMenuItem()
        ToolStripTextBox1 = New ToolStripTextBox()
        IndexBox = New ToolStripComboBox()
        faqTreeView = New TreeView()
        ImageList1 = New ImageList(components)
        FaqText = New RichTextBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLight
        MenuStrip1.Font = New Font("Arial", 9F)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DateiToolStripMenuItem, ToolStripTextBox1, IndexBox})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(741, 27)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DateiToolStripMenuItem
        ' 
        DateiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SchließenToolStripMenuItem})
        DateiToolStripMenuItem.Image = CType(resources.GetObject("DateiToolStripMenuItem.Image"), Image)
        DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        DateiToolStripMenuItem.Size = New Size(64, 23)
        DateiToolStripMenuItem.Text = "Datei"
        ' 
        ' SchließenToolStripMenuItem
        ' 
        SchließenToolStripMenuItem.Image = CType(resources.GetObject("SchließenToolStripMenuItem.Image"), Image)
        SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        SchließenToolStripMenuItem.Size = New Size(130, 22)
        SchließenToolStripMenuItem.Text = "Schließen"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.BackColor = SystemColors.Control
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.ReadOnly = True
        ToolStripTextBox1.Size = New Size(50, 23)
        ToolStripTextBox1.Text = "Inhalt:"
        ' 
        ' IndexBox
        ' 
        IndexBox.DropDownStyle = ComboBoxStyle.DropDownList
        IndexBox.Name = "IndexBox"
        IndexBox.Size = New Size(121, 23)
        ' 
        ' faqTreeView
        ' 
        faqTreeView.BackColor = SystemColors.Control
        faqTreeView.Font = New Font("Arial", 10F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(1), True)
        faqTreeView.FullRowSelect = True
        faqTreeView.HotTracking = True
        faqTreeView.ImageIndex = 0
        faqTreeView.ImageList = ImageList1
        faqTreeView.Location = New Point(12, 30)
        faqTreeView.Name = "faqTreeView"
        faqTreeView.SelectedImageIndex = 1
        faqTreeView.ShowNodeToolTips = True
        faqTreeView.ShowPlusMinus = False
        faqTreeView.Size = New Size(222, 493)
        faqTreeView.StateImageList = ImageList1
        faqTreeView.TabIndex = 1
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "MapClose.ico")
        ImageList1.Images.SetKeyName(1, "MapOpen.ico")
        ' 
        ' FaqText
        ' 
        FaqText.BackColor = Color.MintCream
        FaqText.Font = New Font("Arial", 11F)
        FaqText.Location = New Point(240, 30)
        FaqText.Name = "FaqText"
        FaqText.Size = New Size(489, 493)
        FaqText.TabIndex = 0
        FaqText.Text = ""
        ' 
        ' FormFAQ
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(741, 541)
        Controls.Add(FaqText)
        Controls.Add(faqTreeView)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Fixed3D
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormFAQ"
        Text = "Häufig gestellte Fragen (FAQ) zu FastArchiver"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()


    End Sub

    Private WithEvents FaqText As RichTextBox
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ImageList1 As ImageList
End Class
