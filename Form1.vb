Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1

    Private cmdProcess As Process
    Private isShellRunning As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        If Not isShellRunning Then
            StartShell()
            Button1.Text = "Shell beenden"
        Else
            StopShell()
            Button1.Text = "Shell starten"
        End If

    End Sub

    Private Sub StartShell()
        Try
            ' Initialisiere den Process-Objekt
            cmdProcess = New Process()

            ' Konfiguriere die Starteinstellungen
            With cmdProcess.StartInfo
                .FileName = "cmd.exe" ' Oder "powershell.exe"
                .UseShellExecute = False ' Sehr wichtig: Keine Shell zum Starten verwenden
                .RedirectStandardOutput = True ' Standardausgabe umleiten
                .RedirectStandardError = True  ' Standardfehler umleiten
                .RedirectStandardInput = True  ' Standardeingabe umleiten
                .CreateNoWindow = True         ' Kein separates Konsolenfenster erstellen
                .StandardOutputEncoding = Encoding.UTF8 ' Wichtig für Umlaute etc.
                .StandardErrorEncoding = Encoding.UTF8
            End With

            ' Starten des Prozesses
            cmdProcess.Start()
            isShellRunning = True
            ' UI-Update im UI-Thread
            Me.Invoke(Sub()
                          Console.AppendText("Shell gestartet. Geben Sie Befehle ein und drücken Sie Enter oder den Senden-Button." & Environment.NewLine)
                          Console.ScrollToCaret()
                      End Sub)


            ' Asynchrones Auslesen der Standardausgabe
            AddHandler cmdProcess.OutputDataReceived, AddressOf OutputReceived
            cmdProcess.BeginOutputReadLine()

            ' Asynchrones Auslesen der Standardfehlerausgabe
            AddHandler cmdProcess.ErrorDataReceived, AddressOf ErrorReceived
            cmdProcess.BeginErrorReadLine()

            ' Event-Handler für das Beenden des Prozesses
            AddHandler cmdProcess.Exited, AddressOf ProcessExited
            cmdProcess.EnableRaisingEvents = True ' Wichtig, damit das Exited-Event ausgelöst wird

        Catch ex As Exception
            ' UI-Update im UI-Thread
            Me.Invoke(Sub()
                          Console.AppendText($"Fehler beim Starten der Shell: {ex.Message}{Environment.NewLine}")
                          Console.ScrollToCaret()
                      End Sub)
            isShellRunning = False
        End Try
    End Sub

    Private Sub StopShell()
        If cmdProcess IsNot Nothing AndAlso Not cmdProcess.HasExited Then
            Try
                ' Befehl "exit" an die Shell senden
                cmdProcess.StandardInput.WriteLine("exit")
                cmdProcess.WaitForExit(2000) ' 2 Sekunden warten, bis Prozess beendet wird

                If Not cmdProcess.HasExited Then
                    ' Wenn der Prozess nach dem Warten immer noch läuft, ihn zwangsweise beenden
                    cmdProcess.Kill()
                    ' UI-Update im UI-Thread
                    Me.Invoke(Sub()
                                  Console.AppendText("Shell zwangsweise beendet." & Environment.NewLine)
                                  Console.ScrollToCaret()
                              End Sub)
                Else
                    ' UI-Update im UI-Thread
                    Me.Invoke(Sub()
                                  Console.AppendText("Shell sauber beendet." & Environment.NewLine)
                                  Console.ScrollToCaret()
                              End Sub)
                End If
            Catch ex As Exception
                ' UI-Update im UI-Thread
                Me.Invoke(Sub()
                              Console.AppendText($"Fehler beim Beenden der Shell: {ex.Message}{Environment.NewLine}")
                              Console.ScrollToCaret()
                          End Sub)
            Finally
                ' Aufräumen (Handlers entfernen und Prozess entsorgen) - kann direkt erfolgen, da es nicht aus einem Callbak kommt
                RemoveHandler cmdProcess.OutputDataReceived, AddressOf OutputReceived
                RemoveHandler cmdProcess.ErrorDataReceived, AddressOf ErrorReceived
                RemoveHandler cmdProcess.Exited, AddressOf ProcessExited
                cmdProcess.Dispose()
                cmdProcess = Nothing
                isShellRunning = False
            End Try
        Else
            ' UI-Update im UI-Thread
            Me.Invoke(Sub()
                          Console.AppendText("Shell ist nicht aktiv." & Environment.NewLine)
                          Console.ScrollToCaret()
                      End Sub)
        End If
    End Sub

    ' Callback für die Standardausgabe
    Private Sub OutputReceived(sender As Object, e As DataReceivedEventArgs)
        ' WICHTIG: UI-Updates müssen im UI-Thread erfolgen.
        If Not String.IsNullOrEmpty(e.Data) Then
            ' Überprüfen, ob Invoke erforderlich ist (immer der Fall, wenn aus einem Hintergrundthread auf UI zugegriffen wird)
            If Console.InvokeRequired Then
                Console.Invoke(Sub()
                                   Console.AppendText(e.Data & Environment.NewLine)
                                   Console.ScrollToCaret()
                               End Sub)
            Else
                ' Dies sollte selten, wenn überhaupt, von einem Hintergrundthread aus aufgerufen werden,
                ' aber als Fallback, falls der Aufruf doch im UI-Thread landet.
                Console.AppendText(e.Data & Environment.NewLine)
                Console.ScrollToCaret()
            End If
        End If
    End Sub

    ' Callback für die Standardfehlerausgabe
    Private Sub ErrorReceived(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then
            If Console.InvokeRequired Then
                Console.Invoke(Sub()
                                   Console.SelectionStart = Console.TextLength
                                   Console.SelectionLength = 0
                                   Console.SelectionColor = Color.Red
                                   Console.AppendText(e.Data & Environment.NewLine)
                                   Console.SelectionColor = Console.ForeColor ' Farbe zurücksetzen
                                   Console.ScrollToCaret()
                               End Sub)
            Else
                Console.SelectionStart = Console.TextLength
                Console.SelectionLength = 0
                Console.SelectionColor = Color.Red
                Console.AppendText(e.Data & Environment.NewLine)
                Console.SelectionColor = Console.ForeColor ' Farbe zurücksetzen
                Console.ScrollToCaret()
            End If
        End If
    End Sub

    ' Callback, wenn der Prozess beendet wird
    Private Sub ProcessExited(sender As Object, e As EventArgs)
        ' Alle UI-Updates müssen im UI-Thread erfolgen
        Me.Invoke(Sub()
                      Console.AppendText($"Shell-Prozess beendet mit Exit Code: {cmdProcess.ExitCode}{Environment.NewLine}")
                      Console.ScrollToCaret()
                      isShellRunning = False
                      Button1.Text = "Shell starten"
                      ' Aufräumen (Handlers entfernen und Prozess entsorgen)
                      ' Diese Entfernung kann hier erfolgen, da Invoke den Kontext switcht.
                      RemoveHandler cmdProcess.OutputDataReceived, AddressOf OutputReceived
                      RemoveHandler cmdProcess.ErrorDataReceived, AddressOf ErrorReceived
                      RemoveHandler cmdProcess.Exited, AddressOf ProcessExited
                      cmdProcess.Dispose()
                      cmdProcess = Nothing
                  End Sub)
    End Sub

    ' Senden eines Befehls an die Shell über den Senden-Button

    ' Senden eines Befehls an die Shell über Enter in der InputTextBox
    Private Sub Console_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Console.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True ' Verhindert den Piepton beim Drücken von Enter
            SendCommand()
        End If
    End Sub

    Private Sub SendCommand()
        ' Diese Methode wird direkt von UI-Events aufgerufen, ist also bereits im UI-Thread
        If cmdProcess IsNot Nothing AndAlso Not cmdProcess.HasExited AndAlso isShellRunning Then
            Dim command As String = Console.Text.Trim()
            If Not String.IsNullOrEmpty(command) Then
                Try
                    ' Befehl in der RichTextBox anzeigen (als Echo)
                    Console.SelectionStart = Console.TextLength
                    Console.SelectionLength = 0
                    Console.SelectionColor = Color.Green ' Befehl grün färben
                    Console.AppendText($"> {command}{Environment.NewLine}")
                    Console.SelectionColor = Console.ForeColor ' Farbe zurücksetzen

                    ' Befehl an die Standardeingabe der Shell senden
                    cmdProcess.StandardInput.WriteLine(command)
                    Console.Clear() ' Eingabefeld leeren

                    ' Scrollen zum Ende der RichTextBox
                    Console.ScrollToCaret()

                Catch ex As Exception
                    Console.AppendText($"Fehler beim Senden des Befehls: {ex.Message}{Environment.NewLine}")
                End Try
            End If
        Else
            Console.AppendText("Shell ist nicht gestartet oder wurde beendet." & Environment.NewLine)
            Console.ScrollToCaret()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplaySystemInformation()
        PopulateHDDBox()
    End Sub

    Private Sub DisplaySystemInformation()
        With SystemView
            .View = View.Details
            .GridLines = True
            .FullRowSelect = True
            .Columns.Add("Kategorie", 150, HorizontalAlignment.Left)
            .Columns.Add("Information", 350, HorizontalAlignment.Left) ' Breiter, um längere Texte aufzunehmen
        End With

        ' Systeminformationen abrufen und hinzufügen
        AddSystemInfo("Betriebssystem", GetOSInformation())
        AddSystemInfo("Systemtyp", Environment.Is64BitOperatingSystem.ToString() & " Bit-System")
        AddSystemInfo("Computername", Environment.MachineName)
        AddSystemInfo("Benutzername", Environment.UserName)
        AddSystemInfo("Domainname", Environment.UserDomainName)
        AddSystemInfo("Anzahl Prozessoren", Environment.ProcessorCount.ToString())
        AddSystemInfo("Arbeitsspeicher (Physikalisch)", GetTotalPhysicalMemory())
        AddSystemInfo("Verfügbarer Arbeitsspeicher", GetAvailablePhysicalMemory())
        AddSystemInfo("Hostname", Dns.GetHostName())
        AddSystemInfo("IP-Adressen", GetLocalIPAddresses())
        AddSystemInfo("System-Verzeichnis", Environment.SystemDirectory)
        AddSystemInfo("Programm-Verzeichnis", Environment.CurrentDirectory)
        AddSystemInfo("Netzwerkkarten (Name)", GetNetworkAdapterNames())
        AddSystemInfo("Netzwerkkarten (MAC-Adressen)", GetNetworkAdapterMacAddresses())
        AddSystemInfo("BIOS-Version", GetBIOSVersion())
        AddSystemInfo("Prozessor-Information", GetProcessorInformation())
        AddSystemInfo("Grafikkarte", GetGraphicsCardInformation())
        ' Hinweis: Die allgemeine Festplatteninfo wird hier nicht mehr direkt hinzugefügt,
        ' da wir eine dedizierte Box dafür haben.
        ' AddSystemInfo("Festplatteninformationen", GetDriveInformation())
    End Sub

    ' Hilfsfunktion zum Hinzufügen von Einträgen zur ListView
    Private Sub AddSystemInfo(ByVal category As String, ByVal information As String)
        Dim item As New ListViewItem(category)
        item.SubItems.Add(information)
        SystemView.Items.Add(item)
    End Sub

    ' NEU: Befüllt die HDDBox mit Festplatteninformationen
    Private Sub PopulateHDDBox()
        HDDBox.Items.Clear() ' Vor dem Befüllen leeren

        Try
            For Each d As DriveInfo In DriveInfo.GetDrives()
                If d.IsReady Then
                    ' Anzeigename in der ListBox
                    HDDBox.Items.Add($"{d.Name} ({d.DriveType}) - {d.TotalSize / (1024 * 1024 * 1024):N2} GB")
                Else
                    HDDBox.Items.Add($"{d.Name} ({d.DriveType}) - Nicht bereit")
                End If
            Next
        Catch ex As Exception
            HDDBox.Items.Add($"Fehler beim Laden der Laufwerke: {ex.Message}")
        End Try
    End Sub

    ' NEU: Event-Handler für die Auswahländerung in der HDDBox
    Private Sub HDDBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDDBox.SelectedIndexChanged
        UpdateHDDDetails()
    End Sub

    ' NEU: Aktualisiert HDDLabel und HDDBar1 basierend auf der Auswahl in HDDBox
    Private Sub UpdateHDDDetails()
        If HDDBox.SelectedIndex = -1 Then
            ' Nichts ausgewählt
            HDDLabel.Text = "Kein Laufwerk ausgewählt."
            HddBar1.Value = 0
            HddBar1.Maximum = 100
            Return
        End If

        Try
            ' Den ausgewählten Laufwerksnamen extrahieren (z.B. "C:\")
            Dim selectedItemText As String = HDDBox.SelectedItem.ToString()
            Dim driveName As String = selectedItemText.Substring(0, length:=selectedItemText.IndexOf(" "c)) ' Nimmt den Teil vor dem ersten Leerzeichen

            Dim selectedDrive As New DriveInfo(driveName)

            If selectedDrive.IsReady Then
                Dim totalSizeGB As Double = selectedDrive.TotalSize / (1024 * 1024 * 1024)
                Dim freeSpaceGB As Double = selectedDrive.AvailableFreeSpace / (1024 * 1024 * 1024)
                Dim usedSpaceGB As Double = totalSizeGB - freeSpaceGB

                ' HDDLabel aktualisieren
                HDDLabel.Text = $"Laufwerk: {selectedDrive.Name} ({selectedDrive.DriveType}){Environment.NewLine}" &
                                $"Gesamt: {totalSizeGB:N2} GB{Environment.NewLine}" &
                                $"Frei: {freeSpaceGB:N2} GB ({freeSpaceGB / totalSizeGB:P2}){Environment.NewLine}" &
                                $"Belegt: {usedSpaceGB:N2} GB ({usedSpaceGB / totalSizeGB:P2})"

                ' HDDBar1 aktualisieren
                HddBar1.Maximum = 100 ' Prozentuale Anzeige
                If totalSizeGB > 0 Then
                    HddBar1.Value = CInt((usedSpaceGB / totalSizeGB) * 100)
                Else
                    HddBar1.Value = 0
                End If
                ' Sicherstellen, dass der Wert nicht außerhalb des Bereichs liegt
                If HddBar1.Value > HddBar1.Maximum Then HddBar1.Value = HddBar1.Maximum
                If HddBar1.Value < HddBar1.Minimum Then HddBar1.Value = HddBar1.Minimum

            Else
                HDDLabel.Text = $"Laufwerk: {selectedDrive.Name} ({selectedDrive.DriveType}) - Nicht bereit."
                HddBar1.Value = 0
            End If

        Catch ex As Exception
            HDDLabel.Text = $"Fehler beim Abrufen der Laufwerksdetails: {ex.Message}"
            HddBar1.Value = 0
        End Try
    End Sub


    ' Region: Funktionen zum Abrufen spezifischer Systeminformationen (WMI-basiert)
    ' ... (Der Rest der WMI-Funktionen bleibt unverändert) ...

    Private Function GetOSInformation() As String
        Try
            Using searcher As New ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem")
                For Each o As ManagementObject In searcher.Get()
                    Return o("Caption").ToString()
                Next
            End Using
        Catch ex As Exception
            Return "Fehler beim Abrufen des Betriebssystems: " & ex.Message
        End Try
        Return "Nicht verfügbar"
    End Function

    Private Function GetTotalPhysicalMemory() As String
        Try
            Using searcher As New ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem")
                For Each o As ManagementObject In searcher.Get()
                    Dim totalMemoryBytes As ULong = Convert.ToUInt64(o("TotalPhysicalMemory"))
                    Return (totalMemoryBytes / (1024 * 1024)).ToString("N0") & " MB" ' In MB
                Next
            End Using
        Catch ex As Exception
            Return "Fehler beim Abrufen des Gesamtarbeitsspeichers: " & ex.Message
        End Try
        Return "Nicht verfügbar"
    End Function

    Private Function GetAvailablePhysicalMemory() As String
        Try
            Using searcher As New ManagementObjectSearcher("SELECT FreePhysicalMemory FROM Win32_OperatingSystem")
                For Each o As ManagementObject In searcher.Get()
                    Dim freeMemoryBytes As ULong = Convert.ToUInt64(o("FreePhysicalMemory"))
                    Return (freeMemoryBytes / 1024).ToString("N0") & " MB" ' In MB
                Next
            End Using
        Catch ex As Exception
            Return "Fehler beim Abrufen des verfügbaren Arbeitsspeichers: " & ex.Message
        End Try
        Return "Nicht verfügbar"
    End Function

    Private Function GetLocalIPAddresses() As String
        Dim ipAddresses As New List(Of String)
        Try
            Dim host As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
            For Each ip As IPAddress In host.AddressList
                If ip.AddressFamily = Sockets.AddressFamily.InterNetwork Then ' Nur IPv4-Adressen
                    ipAddresses.Add(ip.ToString())
                End If
            Next
            If ipAddresses.Count > 0 Then
                Return String.Join(", ", ipAddresses.ToArray())
            Else
                Return "Keine IPv4-Adressen gefunden."
            End If
        Catch ex As Exception
            Return "Fehler beim Abrufen der IP-Adressen: " & ex.Message
        End Try
    End Function

    Private Function GetNetworkAdapterNames() As String
        Dim adapterNames As New List(Of String)
        Try
            Using searcher As New ManagementObjectSearcher("SELECT Description FROM Win32_NetworkAdapter WHERE NetConnectionStatus = 2") ' 2 = verbunden
                For Each o As ManagementObject In searcher.Get()
                    adapterNames.Add(o("Description").ToString())
                Next
            End Using
            If adapterNames.Count > 0 Then
                Return String.Join(", ", adapterNames.ToArray())
            Else
                Return "Keine verbundenen Netzwerkkarten gefunden."
            End If
        Catch ex As Exception
            Return "Fehler beim Abrufen der Netzwerkkartennamen: " & ex.Message
        End Try
    End Function

    Private Function GetNetworkAdapterMacAddresses() As String
        Dim macAddresses As New List(Of String)
        Try
            Using searcher As New ManagementObjectSearcher("SELECT MACAddress FROM Win32_NetworkAdapter WHERE NetConnectionStatus = 2") ' 2 = verbunden
                For Each o As ManagementObject In searcher.Get()
                    If o("MACAddress") IsNot Nothing Then
                        macAddresses.Add(o("MACAddress").ToString())
                    End If
                Next
            End Using
            If macAddresses.Count > 0 Then
                Return String.Join(", ", macAddresses.ToArray())
            Else
                Return "Keine MAC-Adressen für verbundene Netzwerkkarten gefunden."
            End If
        Catch ex As Exception
            Return "Fehler beim Abrufen der MAC-Adressen: " & ex.Message
        End Try
    End Function

    Private Function GetBIOSVersion() As String
        Try
            Using searcher As New ManagementObjectSearcher("SELECT SMBIOSBIOSVersion FROM Win32_BIOS")
                For Each o As ManagementObject In searcher.Get()
                    If o("SMBIOSBIOSVersion") IsNot Nothing Then
                        Return o("SMBIOSBIOSVersion").ToString()
                    End If
                Next
            End Using
        Catch ex As Exception
            Return "Fehler beim Abrufen der BIOS-Version: " & ex.Message
        End Try
        Return "Nicht verfügbar"
    End Function

    Private Function GetProcessorInformation() As String
        Try
            Using searcher As New ManagementObjectSearcher("SELECT Name FROM Win32_Processor")
                Dim processorNames As New List(Of String)
                For Each o As ManagementObject In searcher.Get()
                    If o("Name") IsNot Nothing Then
                        processorNames.Add(o("Name").ToString())
                    End If
                Next
                If processorNames.Count > 0 Then
                    Return String.Join(", ", processorNames.ToArray())
                Else
                    Return "Keine Prozessorinformationen gefunden."
                End If
            End Using
        Catch ex As Exception
            Return "Fehler beim Abrufen der Prozessorinformationen: " & ex.Message
        End Try
    End Function

    Private Function GetGraphicsCardInformation() As String
        Try
            Using searcher As New ManagementObjectSearcher("SELECT Caption FROM Win32_VideoController")
                Dim graphicsCards As New List(Of String)
                For Each o As ManagementObject In searcher.Get()
                    If o("Caption") IsNot Nothing Then
                        graphicsCards.Add(o("Caption").ToString())
                    End If
                Next
                If graphicsCards.Count > 0 Then
                    Return String.Join(", ", graphicsCards.ToArray())
                Else
                    Return "Keine Grafikkarteninformationen gefunden."
                End If
            End Using
        Catch ex As Exception
            Return "Fehler beim Abrufen der Grafikkarteninformationen: " & ex.Message
        End Try
    End Function

    Public Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Close()
    End Sub


    Public Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim res As DialogResult = MessageBox.Show(Me, "Möchten Sie die Anwendung wirklich schließen?", "Beenden", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If res = DialogResult.OK Then
            If isShellRunning Then
                StopShell() ' Shell sauber beenden, bevor das Formular schließt
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ÜberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜberToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub HilfeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HilfeToolStripMenuItem.Click
        FormFAQ.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not TP1.Visible = True Then
            TP1.Visible = True
        Else
            TP1.Visible = False
        End If
    End Sub
End Class


