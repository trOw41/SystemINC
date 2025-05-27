Imports System.IO

Public Class FormFAQ

    Private faqContent As New Dictionary(Of String, String)()


    Private xmlFilePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FAQ.xml")
    Private Const ICON_FOLDER As Integer = 0
    Private Const ICON_QUESTION As Integer = 1
    Private Const ICON_ANSWER As Integer = 2

    Private Sub FormFAQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists(xmlFilePath) Then
            LoadFaqContentFromXml()

        Else
            MessageBox.Show($"Die FAQ-Datei '{xmlFilePath}' wurde nicht gefunden. Standardinhalte werden verwendet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            InitializeStandardFaqContent()
        End If


        InitializeFaqTreeView()


        PopulateIndexBox()


        FaqText.Text = "Wählen Sie eine Frage aus dem Inhaltsverzeichnis, um die Antwort anzuzeigen."
    End Sub


    Private Sub LoadFaqContentFromXml()
        faqContent.Clear()

        Try
            Dim doc As XDocument = XDocument.Load(xmlFilePath)


            For Each sectionElement As XElement In doc.Descendants("Section")
                Dim sectionTitle As String = sectionElement.Element("Title")?.Value
                Dim sectionId As String = sectionElement.Attribute("id")?.Value


                'faqContent.Add($"Section_{sectionId}", sectionTitle)

                ' Durch alle <Question> Elemente innerhalb der Section iterieren
                For Each questionElement As XElement In sectionElement.Descendants("Question")
                    Dim questionId As String = questionElement.Attribute("id")?.Value
                    Dim questionTitle As String = questionElement.Element("Title")?.Value
                    Dim answerText As String = questionElement.Element("Answer")?.Value

                    If Not String.IsNullOrEmpty(questionId) AndAlso Not String.IsNullOrEmpty(questionTitle) Then

                        answerText = answerText.Replace("<ul>", Environment.NewLine & "• ").Replace("</ul>", "")
                        answerText = answerText.Replace("<li>", "• ").Replace("</li>", Environment.NewLine)
                        answerText = answerText.Replace("<strong>", "").Replace("</strong>", "")
                        If Not faqContent.ContainsKey(questionId) Then
                            faqContent.Add(questionId, answerText.Trim())
                        Else
                            Debug.WriteLine($"Warnung: Doppelte FAQ-ID gefunden: {questionId}")
                        End If
                    End If
                Next
            Next

            'MessageBox.Show($"FAQ-Inhalte aus '{xmlFilePath}' erfolgreich geladen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"Fehler beim Laden der FAQ aus XML: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"XML-Ladefehler: {ex.ToString()}")
            ' Wenn XML-Laden fehlschlägt, versuchen Sie die Standardinhalte zu laden
            InitializeStandardFaqContent()
        End Try
    End Sub

    Public Sub InitializeStandardFaqContent()
        faqContent.Clear()

        faqContent = New Dictionary(Of String, String) From {
            {"s1", "SystemINC ist ein kleines Programm, das Ihnen hilft, wichtige Informationen über Ihren Computer schnell und einfach einzusehen. Sie können damit grundlegende Details Ihres Systems abrufen, Festplatten überwachen und sogar einfache Befehle in einer integrierten Konsole ausführen."},
            {"s2", "Starten Sie SystemINC, indem Sie die ausführbare Datei (meist SystemINC.exe) auf Ihrem Computer doppelklicken."},
            {"s3", "Die Systemübersicht zeigt allgemeine Details über Ihren Computer, wie das Betriebssystem, den Prozessor, den Arbeitsspeicher und Ihre Netzwerkkarten." & Environment.NewLine & Environment.NewLine &
                   "Die Festplatteninformationen konzentrieren sich nur auf Ihre Speicherlaufwerke (Festplatten, SSDs, USB-Laufwerke) und zeigen deren Größe und Belegung an."},
            {"s4", "Hier finden Sie eine Vielzahl von Informationen, unter anderem:" & Environment.NewLine &
                   "- Betriebssystem: Name Ihrer Windows-Version und ob es sich um ein 32- oder 64-Bit-System handelt." & Environment.NewLine &
                   "- Computer-/Benutzername: Der Name Ihres Computers und Ihr angemeldeter Benutzername." & Environment.NewLine &
                   "- Prozessoren: Die Anzahl der CPU-Kerne." & Environment.NewLine &
                   "- Arbeitsspeicher: Die Gesamtgröße des installierten Arbeitsspeichers und wie viel davon gerade frei ist." & Environment.NewLine &
                   "- Netzwerk: Ihre lokalen IP-Adressen und die Namen Ihrer Netzwerkkarten." & Environment.NewLine &
                   "- BIOS-Version: Informationen zu Ihrem System-BIOS." & Environment.NewLine &
                   "- Grafikkarte: Der Name Ihrer installierten Grafikkarte(n)."},
            {"s5", "Nein, die angezeigten Informationen sind schreibgeschützt und dienen nur zur Ansicht."},
            {"s6", "Auf der linken Seite des Programms sehen Sie eine Liste (die 'HDDBox'), die alle erkannten Speicherlaufwerke auf Ihrem Computer auflistet, z.B. 'C:\\ (Lokaler Datenträger) - 500.00 GB'."},
            {"s7", "Klicken Sie einfach auf den Namen des Laufwerks in der Liste. Die Details werden dann daneben angezeigt."},
            {"s8", "Für das ausgewählte Laufwerk sehen Sie:" & Environment.NewLine &
                   "- Den Laufwerksnamen und -typ (z.B. C:\\, Lokaler Datenträger)." & Environment.NewLine &
                   "- Die Gesamtgröße des Laufwerks." & Environment.NewLine &
                   "- Den freien Speicherplatz (in GB und als Prozentsatz)." & Environment.NewLine &
                   "- Den belegten Speicherplatz (in GB und als Prozentsatz)." & Environment.NewLine &
                   "- Eine Fortschrittsleiste (Progress Bar), die visuell darstellt, wie viel Speicherplatz belegt ist."},
            {"s9", "Dies kann bei bestimmten Laufwerkstypen (z.B. leere CD/DVD-Laufwerke oder nicht angeschlossene Netzlaufwerke) auftreten, wenn das System nicht sofort auf sie zugreifen kann."},
            {"s10", "Die Shell-Konsole ermöglicht es Ihnen, Befehle direkt an das Betriebssystem zu senden, ähnlich wie bei der Windows-Eingabeaufforderung (cmd.exe). Dies ist nützlich für Benutzer, die mit Kommandozeilenbefehlen vertraut sind, um z.B. Netzwerkdiagnosen (ipconfig), Verzeichnisinhalte (dir) oder andere Systemoperationen durchzuführen, ohne ein separates Konsolenfenster öffnen zu müssen."},
            {"s11", "Klicken Sie auf den Button, der mit 'Shell starten' beschriftet ist. Der Text in der Konsole wird dies bestätigen."},
            {"s12", "Geben Sie Ihren Befehl in das kleine Textfeld unterhalb der Konsole ein und drücken Sie dann die Enter-Taste auf Ihrer Tastatur oder klicken Sie auf den 'Senden'-Button daneben."},
            {"s13", "Die Antworten und Ausgaben der Shell erscheinen direkt in der großen Konsole (RichTextBox). Ihre eingegebenen Befehle werden dort zur besseren Unterscheidung grün angezeigt."},
            {"s14", "Fehlermeldungen der Shell werden in der Konsole rot dargestellt, um sie leichter erkennbar zu machen."},
            {"s15", "Klicken Sie erneut auf den Button, der nun mit 'Shell beenden' beschriftet ist. Alternativ können Sie auch den Befehl 'exit' in die Konsole eingeben und Enter drücken."},
            {"s16", "Ja, wenn ein entsprechender Button im Programm vorhanden ist (z.B. ein Button zum Starten von Notepad), können Sie darauf klicken, um die verknüpfte Anwendung zu öffnen."},
            {"s17", "Sollte ein Programm nicht gefunden werden oder ein Fehler beim Start auftreten, wird eine entsprechende Fehlermeldung in der integrierten Shell-Konsole angezeigt."}
        }
    End Sub

    Private Sub InitializeFaqTreeView()

        faqTreeView.BeginUpdate()
        faqTreeView.Nodes.Clear()

        If faqTreeView.ImageList Is Nothing Then
            faqTreeView.ImageList = New ImageList()
            faqTreeView.ImageList.Images.Add("folder", My.Resources.icons8_mappe_144) ' Index 0
            faqTreeView.ImageList.Images.Add("question", My.Resources._014_speech_bubble) ' Index 1
            ' faqTreeView.ImageList.Images.Add("answer", My.Resources._028_faq) ' Index 2
        End If

        Dim doc As XDocument = Nothing
        Try
            If File.Exists(xmlFilePath) Then
                doc = XDocument.Load(xmlFilePath)
            End If
        Catch ex As Exception

            Debug.WriteLine($"Fehler beim Laden der XML für TreeView: {ex.Message}")
        End Try

        Try

            If doc IsNot Nothing Then


                Dim rootNode As New TreeNode(doc.Root.Element("Meta").Element("Title")?.Value) With {
                    .Name = "root",
                    .ImageIndex = ICON_FOLDER,
                    .SelectedImageIndex = ICON_FOLDER
                }
                faqTreeView.Nodes.Add(rootNode)

                For Each sectionElement As XElement In doc.Descendants("Section")
                    Dim sectionTitle As String = sectionElement.Attribute("title")?.Value
                    Dim sectionId As String = sectionElement.Attribute("id")?.Value

                    Dim sectionNode As New TreeNode(sectionTitle)
                    sectionNode.Name = sectionId
                    sectionNode.Tag = sectionId
                    sectionNode.ImageIndex = ICON_FOLDER
                    sectionNode.SelectedImageIndex = ICON_FOLDER
                    rootNode.Nodes.Add(sectionNode)


                    For Each questionElement As XElement In sectionElement.Descendants("Question")
                        Dim questionId As String = questionElement.Attribute("id")?.Value
                        Dim questionTitle As String = questionElement.Element("Title")?.Value

                        Dim questionNode As New TreeNode(questionTitle)
                        questionNode.Name = questionId
                        questionNode.Tag = questionId
                        questionNode.ImageIndex = ICON_QUESTION
                        questionNode.SelectedImageIndex = ICON_QUESTION
                        sectionNode.Nodes.Add(questionNode)
                    Next
                Next


            Else

                Dim rootNode As New TreeNode("Inhalt (Standard)")
                rootNode.Name = "root_fallback"
                rootNode.ImageIndex = ICON_FOLDER
                rootNode.SelectedImageIndex = ICON_FOLDER
                faqTreeView.Nodes.Add(rootNode)


                For Each kvp As KeyValuePair(Of String, String) In faqContent
                    Dim node As New TreeNode(kvp.Key)
                    node.Name = kvp.Key
                    node.Tag = kvp.Key
                    node.ImageIndex = ICON_QUESTION
                    node.SelectedImageIndex = ICON_QUESTION
                    rootNode.Nodes.Add(node)
                Next



                rootNode.ExpandAll()
            End If
            faqTreeView.EndUpdate()
        Catch ex As Exception
            MessageBox.Show($"Fehler beim Verarbeiten der XML-Struktur: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"XML-Verarbeitungsfehler: {ex.Message}")
        End Try
        If faqTreeView.Nodes.Count > 0 AndAlso faqTreeView.Nodes(0).Nodes.Count > 0 Then
            faqTreeView.SelectedNode = faqTreeView.Nodes(0).Nodes(0)
        End If
    End Sub

    Private Sub PopulateIndexBox()
        IndexBox.Items.Clear()
        IndexBox.Items.Add("Wählen Sie eine Frage aus dem Inhaltsverzeichnis")

        For Each sectionNode As TreeNode In faqTreeView.Nodes(0).Nodes
            For Each questionNode As TreeNode In sectionNode.Nodes
                IndexBox.Items.Add(questionNode.Text)
            Next
        Next

        IndexBox.SelectedIndex = 0
    End Sub

    Private Sub IndexView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles faqTreeView.AfterSelect
        If e.Node IsNot Nothing Then

            Dim questionId As String = e.Node.Name
            Dim answerText As String = Nothing
            If faqContent.TryGetValue(questionId, answerText) Then
                FaqText.Text = answerText
            Else

                FaqText.Text = "Wählen Sie eine Frage aus dem Inhaltsverzeichnis, um die Antwort anzuzeigen."
            End If
        Else
            FaqText.Text = "Wählen Sie einen Eintrag aus dem Inhaltsverzeichnis."
        End If
    End Sub


    Private Sub IndexBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IndexBox.SelectedIndexChanged
        If IndexBox.SelectedItem IsNot Nothing AndAlso IndexBox.SelectedIndex > 0 Then
            Dim selectedText As String = IndexBox.SelectedItem.ToString()

            Dim foundNode As TreeNode = Nothing
            If faqTreeView.Nodes.Count > 0 Then
                For Each sectionNode As TreeNode In faqTreeView.Nodes(0).Nodes
                    For Each questionNode As TreeNode In sectionNode.Nodes
                        If questionNode.Text = selectedText Then
                            foundNode = questionNode
                            Exit For
                        End If
                    Next
                    If foundNode IsNot Nothing Then Exit For
                Next
            End If

            If foundNode IsNot Nothing Then
                faqTreeView.SelectedNode = foundNode
                faqTreeView.Focus()
            Else
                FaqText.Text = "Die ausgewählte Frage konnte im Inhaltsverzeichnis nicht gefunden werden."
            End If
        ElseIf IndexBox.SelectedIndex = 0 Then

            FaqText.Text = "Wählen Sie eine Frage aus dem Inhaltsverzeichnis, um die Antwort anzuzeigen."

            If faqTreeView.Nodes.Count > 0 Then
                faqTreeView.SelectedNode = faqTreeView.Nodes(0)
            End If
        End If
    End Sub

    Private Sub SchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchließenToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class