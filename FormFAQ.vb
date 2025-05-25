Imports System.IO

Public Class FormFAQ
    Private faqContent As Dictionary(Of String, String)

    Private Sub FormFAQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFaqContent() ' FAQ-Inhalte initialisieren
        LoadFaqContentFromXml()
        PopulateIndexBox()     ' IndexBox füllen
        IndexBox.SelectedIndex = 0 ' Keine Auswahl in der IndexBox
        ' Optional: Ersten FAQ-Eintrag beim Laden anzeigen
        If faqTreeView.Nodes.Count > 1 Then
            faqTreeView.SelectedNode = faqTreeView.Nodes(1) ' Wählt "1. Was ist FastArchiver?"
        End If

    End Sub

    Public Sub InitializeFaqContent()
        faqContent = New Dictionary(Of String, String) From {
        {"s1", "SystemINC ist ein kleines Programm, das Ihnen hilft, wichtige Informationen über Ihren Computer schnell und einfach einzusehen. Sie können damit grundlegende Details Ihres Systems abrufen, Festplatten überwachen und sogar einfache Befehle in einer integrierten Konsole ausführen."},
        {"s2", "Starten Sie SystemINC, indem Sie die ausführbare Datei (meist SystemINC.exe) auf Ihrem Computer doppelklicken."},
        {"s3", "Die Systemübersicht zeigt allgemeine Details über Ihren Computer, wie das Betriebssystem, den Prozessor, den Arbeitsspeicher und Ihre Netzwerkeinstellungen." & Environment.NewLine & Environment.NewLine &
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


    Private Sub LoadFaqContentFromXml()
        faqContent.Clear() ' Dictionary vor dem Neubefüllen leeren

        Dim xmlFilePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SystemINC_FAQ.xml")

        If File.Exists(xmlFilePath) Then
            Try
                Dim doc As XDocument = XDocument.Load(xmlFilePath)

                ' Durch alle <Section> Elemente iterieren
                For Each sectionElement As XElement In doc.Descendants("Section")
                    ' Optional: Hier könnten Sie die Section-Titel oder IDs für eine übergeordnete Struktur speichern
                    ' Dim sectionTitle As String = sectionElement.Attribute("title")?.Value
                    ' Dim sectionId As String = sectionElement.Attribute("id")?.Value

                    ' Durch alle <Question> Elemente innerhalb der Section iterieren
                    For Each questionElement As XElement In sectionElement.Descendants("Question")
                        Dim questionId As String = questionElement.Attribute("id")?.Value
                        Dim questionTitle As String = questionElement.Element("Title")?.Value
                        Dim answerText As String = questionElement.Element("Answer")?.Value

                        If Not String.IsNullOrEmpty(questionId) AndAlso Not String.IsNullOrEmpty(questionTitle) Then
                            ' HTML-Listenpunkte in Zeilenumbrüche umwandeln, wenn vorhanden
                            ' Dies ist eine einfache Konvertierung, für komplexere HTML-Tags ist ein HTML-Parser nötig.
                            answerText = answerText.Replace("<ul>", "").Replace("</ul>", "")
                            answerText = answerText.Replace("<li>", "- ").Replace("</li>", Environment.NewLine)
                            answerText = answerText.Replace("<strong>", "").Replace("</strong>", "") ' Formatierung entfernen

                            ' Füge die Frage und Antwort zum Dictionary hinzu
                            ' Als Key könnten Sie auch den questionTitle verwenden, wenn dieser eindeutig ist.
                            If Not faqContent.ContainsKey(questionId) Then
                                faqContent.Add(questionId, answerText.Trim())
                            Else
                                ' Optional: Fehlermeldung, wenn eine ID doppelt vorkommt
                                Debug.WriteLine($"Warnung: Doppelte FAQ-ID gefunden: {questionId}")
                            End If
                        End If
                    Next
                Next

                'Console.AppendText($"FAQ-Inhalte aus '{xmlFilePath}' erfolgreich geladen.{Environment.NewLine}")

            Catch ex As Exception
                'Console.AppendText($"Fehler beim Laden der FAQ aus XML: {ex.Message}{Environment.NewLine}")
                ' Optional: Detaillierte Fehlerprotokollierung
                Debug.WriteLine($"XML-Ladefehler: {ex.ToString()}")
            End Try
        Else
            'Console.AppendText($"FAQ-Datei '{xmlFilePath}' nicht gefunden.{Environment.NewLine}")
        End If
    End Sub




    Private Sub PopulateIndexBox()
        IndexBox.Items.Clear()
        For Each node As TreeNode In faqTreeView.Nodes
            If node.Name <> "index" Then ' Den Wurzelknoten "Inhalt:" ausschließen
                IndexBox.Items.Add(node.Text)
            End If
        Next
    End Sub

    Private Sub IndexView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles faqTreeView.AfterSelect
        If e.Node IsNot Nothing Then

            Dim value As String = Nothing

            If faqContent.TryGetValue(e.Node.Name, value) Then
                FaqText.Text = value
            Else
                FaqText.Text = "Wählen Sie einen Eintrag aus dem Inhaltsverzeichnis."
            End If
        Else
            FaqText.Text = "Wählen Sie einen Eintrag aus dem Inhaltsverzeichnis."
        End If
    End Sub

    Private Sub IndexBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IndexBox.SelectedIndexChanged
        If IndexBox.SelectedItem IsNot Nothing Then
            Dim selectedText As String = IndexBox.SelectedItem.ToString()
            For Each node As TreeNode In faqTreeView.Nodes
                If node.Text = selectedText Then
                    faqTreeView.SelectedNode = node
                    Exit For
                ElseIf node.Nodes.Count > 0 Then ' Auch in den Kindknoten suchen
                    For Each childNode As TreeNode In node.Nodes
                        If childNode.Text = selectedText Then
                            faqTreeView.SelectedNode = childNode
                            Exit For
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub SchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchließenToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class