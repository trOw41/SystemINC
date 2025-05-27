Imports System.IO
Imports System.Net
Imports System.Text


Public Class Form1

    Private cmdProcess As Process
    Private isShellRunning As Boolean = False
    Private errorList As List(Of String)
    Private ex0 As ErrObject
    Private DateStamp As Date
    Private Const ICON_OS As Integer = 0
    Private Const ICON_SYSTEM_TYPE As Integer = 1
    Private Const ICON_COMPUTER_NAME As Integer = 2
    Private Const ICON_USER_NAME As Integer = 3
    Private Const ICON_DOMAIN_NAME As Integer = 4
    Private Const ICON_PROCESSOR_COUNT As Integer = 5
    Private Const ICON_RAM As Integer = 6
    Private Const ICON_AVAIL_RAM As Integer = 7
    Private Const ICON_HOSTNAME As Integer = 8
    Private Const ICON_IP_ADDRESSES As Integer = 9
    Private Const ICON_SYSTEM_DIR As Integer = 10
    Private Const ICON_PROGRAM_DIR As Integer = 11
    Private Const ICON_NETWORK_ADAPTER As Integer = 12
    Private Const ICON_MAC_ADDRESS As Integer = 13
    Private Const ICON_BIOS As Integer = 14
    Private Const ICON_PROCESSOR_INFO As Integer = 15
    Private Const ICON_GRAPHICS_CARD As Integer = 16
    Private _systemInfoRepository As SystemInfoRepository
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

            cmdProcess = New Process()


            With cmdProcess.StartInfo
                .FileName = "cmd.exe"
                .UseShellExecute = False
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .RedirectStandardInput = True
                .CreateNoWindow = True
                .StandardOutputEncoding = Encoding.UTF8
                .StandardErrorEncoding = Encoding.UTF8
            End With


            cmdProcess.Start()
            isShellRunning = True

            Me.Invoke(Sub()
                          Console.AppendText("Shell gestartet. Geben Sie Befehle ein und drücken Sie Enter oder den Senden-Button." & Environment.NewLine)
                          Console.ScrollToCaret()
                      End Sub)



            AddHandler cmdProcess.OutputDataReceived, AddressOf OutputReceived
            cmdProcess.BeginOutputReadLine()


            AddHandler cmdProcess.ErrorDataReceived, AddressOf ErrorReceived
            cmdProcess.BeginErrorReadLine()


            AddHandler cmdProcess.Exited, AddressOf ProcessExited
            cmdProcess.EnableRaisingEvents = True

        Catch ex As Exception

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

                cmdProcess.StandardInput.WriteLine("exit")
                cmdProcess.WaitForExit(2000)

                If Not cmdProcess.HasExited Then

                    cmdProcess.Kill()

                    Me.Invoke(Sub()
                                  Console.AppendText("Shell zwangsweise beendet." & Environment.NewLine)
                                  Console.ScrollToCaret()
                              End Sub)
                Else

                    Me.Invoke(Sub()
                                  Console.AppendText("Shell sauber beendet." & Environment.NewLine)
                                  Console.ScrollToCaret()
                              End Sub)
                End If
            Catch ex As Exception

                Me.Invoke(Sub()
                              Console.AppendText($"Fehler beim Beenden der Shell: {ex.Message}{Environment.NewLine}")
                              Console.ScrollToCaret()
                          End Sub)
            Finally

                RemoveHandler cmdProcess.OutputDataReceived, AddressOf OutputReceived
                RemoveHandler cmdProcess.ErrorDataReceived, AddressOf ErrorReceived
                RemoveHandler cmdProcess.Exited, AddressOf ProcessExited
                cmdProcess.Dispose()
                cmdProcess = Nothing
                isShellRunning = False
            End Try
        Else

            Me.Invoke(Sub()
                          Console.AppendText("Shell ist nicht aktiv." & Environment.NewLine)
                          Console.ScrollToCaret()
                      End Sub)
        End If
    End Sub


    Private Sub OutputReceived(sender As Object, e As DataReceivedEventArgs)

        If Not String.IsNullOrEmpty(e.Data) Then

            If Console.InvokeRequired Then
                Console.Invoke(Sub()
                                   Console.AppendText(e.Data & Environment.NewLine)
                                   Console.ScrollToCaret()
                               End Sub)
            Else

                Console.AppendText(e.Data & Environment.NewLine)
                Console.ScrollToCaret()
            End If
        End If
    End Sub


    Private Sub ErrorReceived(sender As Object, e As DataReceivedEventArgs)
        If Not String.IsNullOrEmpty(e.Data) Then
            If Console.InvokeRequired Then
                Console.Invoke(Sub()
                                   Console.SelectionStart = Console.TextLength
                                   Console.SelectionLength = 0
                                   Console.SelectionColor = Color.Red
                                   Console.AppendText(e.Data & Environment.NewLine)
                                   Console.SelectionColor = Console.ForeColor
                                   Console.ScrollToCaret()
                               End Sub)
            Else
                Console.SelectionStart = Console.TextLength
                Console.SelectionLength = 0
                Console.SelectionColor = Color.Red
                Console.AppendText(e.Data & Environment.NewLine)
                Console.SelectionColor = Console.ForeColor
                Console.ScrollToCaret()
            End If
        End If
    End Sub

    Private Sub ProcessExited(sender As Object, e As EventArgs)

        Me.Invoke(Sub()
                      Console.AppendText($"Shell-Prozess beendet mit Exit Code: {cmdProcess.ExitCode}{Environment.NewLine}")
                      Console.ScrollToCaret()
                      isShellRunning = False
                      Button1.Text = "Shell starten"

                      RemoveHandler cmdProcess.OutputDataReceived, AddressOf OutputReceived
                      RemoveHandler cmdProcess.ErrorDataReceived, AddressOf ErrorReceived
                      RemoveHandler cmdProcess.Exited, AddressOf ProcessExited
                      cmdProcess.Dispose()
                      cmdProcess = Nothing
                  End Sub)
    End Sub


    Private Sub Console_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendCommand()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _systemInfoRepository = New SystemInfoRepository()
        Dim currentInfo As New SystemInfoData(
            osSystem:=GetOSInformation(),
            systemType:=Environment.Is64BitOperatingSystem.ToString() & " Bit-System",
            computerName:=Environment.MachineName,
            userName:=Environment.UserName,
            domainName:=Environment.UserDomainName,
            processorCount:=Environment.ProcessorCount,
            totalPhysicalMemory:=GetTotalPhysicalMemory(),
            availablePhysicalMemory:=GetAvailablePhysicalMemory(),
            hostName:=Dns.GetHostName(),
            ipAddresses:=GetLocalIPAddresses(),
            systemDirectory:=Environment.SystemDirectory,
            programDirectory:=Environment.CurrentDirectory,
            networkAdapterNames:=GetNetworkAdapterNames(),
            networkAdapterMacAddresses:=GetNetworkAdapterMacAddresses(),
            biosVersion:=GetBIOSVersion(),
            processorInformation:=GetProcessorInformation(),
            graphicsCardInformation:=GetGraphicsCardInformation()
        )


        Try
            _systemInfoRepository.SaveSystemInfo(currentInfo)
            'Console.WriteLine("Systeminformationen erfolgreich über Repository gespeichert.")
        Catch ex As Exception

            'Console.WriteLine($"Fehler beim Speichern der Systeminformationen über Repository: {ex.Message}")
        End Try


        DisplaySystemInformation()
        PopulateHDDBox()
        IsUserAdministrator()
        FormFAQ.InitializeStandardFaqContent()
        GetOSAndRootDirectories()
    End Sub


    Private Sub DisplaySystemInformation()
        With SystemView
            .View = View.Details
            .GridLines = True
            .FullRowSelect = True
            .SmallImageList = Me.ImageList1
            ' .LargeImageList = Me.ImageList1 
            .Columns.Clear()
            .Columns.Add("Category:", 180, HorizontalAlignment.Left)
            .Columns.Add("Information:", 350, HorizontalAlignment.Left)
        End With

        AddSystemInfo("OS System:", GetOSInformation(), ICON_OS)
        AddSystemInfo("System-Typ:", Environment.Is64BitOperatingSystem.ToString() & " Bit-System:", ICON_SYSTEM_TYPE)
        AddSystemInfo("PC/host:", Environment.MachineName, ICON_COMPUTER_NAME)
        AddSystemInfo("User:", Environment.UserName, ICON_USER_NAME)
        AddSystemInfo("Domain:", Environment.UserDomainName, ICON_DOMAIN_NAME)
        AddSystemInfo("Core x :", Environment.ProcessorCount.ToString(), ICON_PROCESSOR_COUNT)
        AddSystemInfo("RAM (Phys.):", GetTotalPhysicalMemory(), ICON_RAM)
        AddSystemInfo("RAM (free):", GetAvailablePhysicalMemory(), ICON_AVAIL_RAM)
        AddSystemInfo("Host:", Dns.GetHostName(), ICON_HOSTNAME)
        AddSystemInfo("IP-Adress:", GetLocalIPAddresses(), ICON_IP_ADDRESSES)
        AddSystemInfo("System-dir:", Environment.SystemDirectory, ICON_SYSTEM_DIR)
        AddSystemInfo("Prog. Dir:", Environment.CurrentDirectory, ICON_PROGRAM_DIR)
        AddSystemInfo("Network (Name):", GetNetworkAdapterNames(), ICON_NETWORK_ADAPTER)
        AddSystemInfo("Network (MAC-Adressen):", GetNetworkAdapterMacAddresses(), ICON_MAC_ADDRESS)
        AddSystemInfo("BIOS V.:", GetBIOSVersion(), ICON_BIOS)
        AddSystemInfo("CPU-Info", GetProcessorInformation(), ICON_PROCESSOR_INFO)
        AddSystemInfo("GPU-Info", GetGraphicsCardInformation(), ICON_GRAPHICS_CARD)
    End Sub
    Private Sub AddSystemInfo(ByVal category As String, ByVal information As String, ByVal imageIndex As Integer)
        Dim item As New ListViewItem(category, imageIndex)
        item.SubItems.Add(information)
        SystemView.Items.Add(item)
    End Sub

    Private Sub AddSystemInfo(ByVal category As String, ByVal information As String)
        Dim item As New ListViewItem(category)
        item.SubItems.Add(information)
        SystemView.Items.Add(item)
    End Sub
    Private Function EnsureAdminRightsAndCreateDirectory(directoryPath As String) As Boolean
        If Not IsUserAdministrator() Then

            Dim currentProcessInfo As New ProcessStartInfo With {
                .FileName = Application.ExecutablePath,
                .Arguments = "",
                .Verb = "runas"
            }
            Try
                Process.Start(currentProcessInfo)
                Return True
            Catch ex As System.ComponentModel.Win32Exception When ex.NativeErrorCode = 1223
                MessageBox.Show("Administratorrechte sind erforderlich, um den Ordner zu erstellen.", "Berechtigung erforderlich", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Catch ex As Exception
                MessageBox.Show($"Fehler beim Anfordern von Administratorrechten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
            Return False
        Else
            Try
                If Not Directory.Exists(directoryPath) Then
                    Directory.CreateDirectory(directoryPath)
                End If
                Return True
            Catch ex As Exception
                MessageBox.Show($"Fehler beim Erstellen des Ordners: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If
    End Function
    Private Function IsUserAdministrator() As Boolean
        Dim identity As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
        Dim principal As New System.Security.Principal.WindowsPrincipal(identity)
        Return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator)
    End Function
    Private Sub PopulateHDDBox()
        HDDBox.Items.Clear()

        Try
            For Each d As DriveInfo In DriveInfo.GetDrives()
                If d.IsReady Then

                    HDDBox.Items.Add($"{d.Name} ({d.DriveType}) - {d.TotalSize / (1024 * 1024 * 1024):N2} GB")
                Else
                    HDDBox.Items.Add($"{d.Name} ({d.DriveType}) - Nicht bereit")
                End If
            Next
        Catch ex As Exception
            HDDBox.Items.Add($"Fehler beim Laden der Laufwerke: {ex.Message}")
        End Try
    End Sub

    Private Sub HDDBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDDBox.SelectedIndexChanged
        UpdateHDDDetails()
    End Sub

    Private Sub UpdateHDDDetails()
        If HDDBox.SelectedIndex = -1 Then
            HDDLabel.Text = "Kein Laufwerk ausgewählt."
            HddBar1.Value = 0
            HddBar1.Maximum = 100
            Return
        End If

        Try

            Dim selectedItemText As String = HDDBox.SelectedItem.ToString()
            Dim driveName As String = selectedItemText.Substring(0, length:=selectedItemText.IndexOf(" "c))
            Dim selectedDrive As New DriveInfo(driveName)

            If selectedDrive.IsReady Then
                Dim totalSizeGB As Double = selectedDrive.TotalSize / (1024 * 1024 * 1024)
                Dim freeSpaceGB As Double = selectedDrive.AvailableFreeSpace / (1024 * 1024 * 1024)
                Dim usedSpaceGB As Double = totalSizeGB - freeSpaceGB
                HDDLabel.Text = $"Laufwerk: {selectedDrive.Name} ({selectedDrive.DriveType}){Environment.NewLine}" &
                                $"Gesamt: {totalSizeGB:N2} GB{Environment.NewLine}" &
                                $"Frei: {freeSpaceGB:N2} GB ({freeSpaceGB / totalSizeGB:P2}){Environment.NewLine}" &
                                $"Belegt: {usedSpaceGB:N2} GB ({usedSpaceGB / totalSizeGB:P2})"
                HddBar1.Maximum = 100
                If totalSizeGB > 0 Then
                    HddBar1.Value = CInt((usedSpaceGB / totalSizeGB) * 100)
                Else
                    HddBar1.Value = 0
                End If
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
                If ip.AddressFamily = Sockets.AddressFamily.InterNetwork Then
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
                StopShell()
            End If
        Else
            e.Cancel = True
        End If
    End Sub



    Private Sub GetOSAndRootDirectories()
        Try

            Dim systemDirectory As String = Environment.SystemDirectory

            Dim rootDirectory As String = Path.GetPathRoot(systemDirectory)

            My.Settings.OS_RootDir = rootDirectory
            MessageBox.Show($"OS Verzeichniss: {rootDirectory}")
        Catch ex As Exception

            MessageBox.Show($"Fehler beim Abrufen der Verzeichnisse: {ex.Message}")
        End Try
    End Sub

    Private Sub HilfeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormFAQ.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not Console.Visible = True Then
            Console.Visible = True
            TextBox1.Visible = True
        Else
            Console.Visible = False
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As Boolean = IsUserAdministrator()

        Dim programPath As String = My.Settings.OS_RootDir & "Windows\System32\diskmgmt.msc"
        If res = True Then

            If Not Console.Visible = True Then
                Console.Visible = True
            End If
            Try
                Process.Start(programPath)
            Catch ex As Exception
                Dim errInt As String = ex.StackTrace

                If errorList Is Nothing Or errorList IsNot Nothing Then
                    errorList.Add(errInt & "," & Date.Now)
                    Label1.Text = $"Fehler beim Starten des Programms:" & ex.StackTrace & $" |Err.Code: {errInt}"
                Else
                    MessageBox.Show(errInt)
                End If

            End Try
        ElseIf res = False Then
            EnsureAdminRightsAndCreateDirectory(programPath)
            MessageBox.Show("No Admin rights granted please do and restart Disk-Mangement Tool")

        End If
    End Sub
    Private Sub ExportSystemInfoAsXML(filePath As String)
        Try
            Dim currentInfo As New SystemInfoData(
                osSystem:=GetOSInformation(),
                systemType:=Environment.Is64BitOperatingSystem.ToString() & " Bit-System",
                computerName:=Environment.MachineName,
                userName:=Environment.UserName,
                domainName:=Environment.UserDomainName,
                processorCount:=Environment.ProcessorCount,
                totalPhysicalMemory:=GetTotalPhysicalMemory(),
                availablePhysicalMemory:=GetAvailablePhysicalMemory(),
                hostName:=Dns.GetHostName(),
                ipAddresses:=GetLocalIPAddresses(),
                systemDirectory:=Environment.SystemDirectory,
                programDirectory:=Environment.CurrentDirectory,
                networkAdapterNames:=GetNetworkAdapterNames(),
                networkAdapterMacAddresses:=GetNetworkAdapterMacAddresses(),
                biosVersion:=GetBIOSVersion(),
                processorInformation:=GetProcessorInformation(),
                graphicsCardInformation:=GetGraphicsCardInformation()
            )

            Dim xmlDoc As New XDocument(
                New XDeclaration("1.0", "utf-8", "yes"),
                New XProcessingInstruction("xml-stylesheet", "type='text/xsl' href='SystemInfoExport.xsl'"),
                New XElement("SystemInformationExport",
                    New XAttribute("ExportTimestamp", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")),
                    CreateSystemInfoElement(currentInfo)
                )
            )

            xmlDoc.Save(filePath)

            'Öffnen der exportierten XML-Datei 
            Try
                Process.Start("explorer.exe", filePath)
                MessageBox.Show($"Systeminformationen erfolgreich nach '{filePath}' exportiert und geöffnet.", "Export erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch exOpenFile As Exception
                MessageBox.Show($"Systeminformationen erfolgreich nach '{filePath}' exportiert, konnte aber nicht automatisch geöffnet werden: {exOpenFile.Message}", "Export erfolgreich (Öffnen fehlgeschlagen)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Debug.WriteLine($"Fehler beim automatischen Öffnen der XML-Datei: {exOpenFile.Message}")
            End Try
        Catch ex As Exception
            MessageBox.Show($"Fehler beim Exportieren der Systeminformationen: {ex.Message}", "Exportfehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"XML-Exportfehler: {ex.Message}")
        End Try
    End Sub


    Private Function CreateSystemInfoElement(data As SystemInfoData) As XElement
        Return New XElement("SystemInfoEntry",
            New XElement("Timestamp", data.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")),
            New XElement("OSSystem", data.OSSystem),
            New XElement("SystemType", data.SystemType),
            New XElement("ComputerName", data.ComputerName),
            New XElement("UserName", data.UserName),
            New XElement("DomainName", data.DomainName),
            New XElement("ProcessorCount", data.ProcessorCount),
            New XElement("TotalPhysicalMemory", data.TotalPhysicalMemory),
            New XElement("AvailablePhysicalMemory", data.AvailablePhysicalMemory),
            New XElement("HostName", data.HostName),
            New XElement("IPAddresses", data.IPAddresses),
            New XElement("SystemDirectory", data.SystemDirectory),
            New XElement("ProgramDirectory", data.ProgramDirectory),
            New XElement("NetworkAdapterNames", data.NetworkAdapterNames),
            New XElement("NetworkAdapterMacAddresses", data.NetworkAdapterMacAddresses),
            New XElement("BIOSVersion", data.BIOSVersion),
            New XElement("ProcessorInformation", data.ProcessorInformation),
            New XElement("GraphicsCardInformation", data.GraphicsCardInformation)
        )
    End Function
    Private Sub SystemINCToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SystemINCToolStripMenuItem.Click
        Dialog1.Show()
    End Sub

    Private Sub EULAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EULAToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub HilfeToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles HilfeToolStripMenuItem1.Click
        FormFAQ.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Dim getItem As ToolStripItem = e.ClickedItem
        If getItem IsNot Nothing Then
            Select Case getItem.Name
                Case "BeendenToolStripMenuItem"
                    BeendenToolStripMenuItem_Click(sender, e)
                Case "HilfeToolStripMenuItem"
                    HilfeToolStripMenuItem_Click(sender, e)
                Case "SystemINCToolStripMenuItem"
                    SystemINCToolStripMenuItem_Click_1(sender, e)
                Case "EULAToolStripMenuItem"
                    EULAToolStripMenuItem_Click(sender, e)
                Case "HilfeToolStripMenuItem1"
                    HilfeToolStripMenuItem1_Click_1(sender, e)
                Case "ExportSysteminformationAsXMLToolStripMenuItem"
                    ExportSysteminformationAsXMLToolStripMenuItem_Click(sender, e)
                Case "Export as.."

            End Select
        End If
    End Sub

    Private Sub ExportSysteminformationAsXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportSysteminformationAsXMLToolStripMenuItem.Click
        Dim exportDialog As New SaveFileDialog With {
            .Filter = "XML-Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*",
            .Title = "Systeminformationen exportieren",
            .FileName = "SystemInfoExport_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".xml"
        }

        If exportDialog.ShowDialog() = DialogResult.OK Then
            Dim destinationFilePath As String = exportDialog.FileName
            Dim destinationDirectory As String = Path.GetDirectoryName(destinationFilePath)
            Dim sourceXslPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SystemInfoExport.xsl")
            Dim destinationXslPath As String = Path.Combine(destinationDirectory, "SystemInfoExport.xsl")
            Try

                If File.Exists(sourceXslPath) Then
                    File.Copy(sourceXslPath, destinationXslPath, True)
                    MessageBox.Show($"XSLT-Datei kopiert nach: {destinationXslPath}")
                Else
                    MessageBox.Show("Warnung: XSLT-Stylesheet 'SystemInfoExport.xsl' nicht gefunden. Die exportierte XML-Datei wird im Browser unformatiert angezeigt.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ExportSystemInfoAsXML(destinationFilePath)
            Catch ex As Exception
                MessageBox.Show($"Fehler beim Kopieren der XSLT-Datei oder Export: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Debug.WriteLine($"XSLT-Kopierfehler: {ex.Message}")
            End Try
        End If
    End Sub


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Optional: Hier können Sie Code hinzufügen, der beim Anzeigen des Formulars ausgeführt werden soll.
        ' Zum Beispiel, um die Konsole standardmäßig anzuzeigen.
        If HDDBox.Items.Count > 0 Then
            HDDBox.SelectedIndex = 0 ' Wählen Sie das erste Laufwerk aus, wenn verfügbar
            UpdateHDDDetails() ' Aktualisieren Sie die Details des ausgewählten Laufwerks
        Else
            HDDLabel.Text = "Keine Laufwerke gefunden."
        End If
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Prüfen, ob die gedrückte Taste die Enter-Taste ist (ASCII-Wert 13)
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Sendet den Befehl
            SendCommand()

            ' Verhindert, dass die Enter-Taste selbst in die Textbox eingefügt wird
            e.Handled = True
        End If
    End Sub

    Private Sub SendCommand()

        If cmdProcess IsNot Nothing AndAlso Not cmdProcess.HasExited AndAlso isShellRunning Then
            Dim command As String = TextBox1.Text.Trim()
            If Not String.IsNullOrEmpty(command) Then
                Try

                    Console.SelectionColor = Color.FloralWhite
                    Console.AppendText($"> {command}{Environment.NewLine}")
                    Console.SelectionColor = Console.ForeColor

                    ' Befehl an die Standardeingabe der Shell senden
                    cmdProcess.StandardInput.WriteLine(command)
                    TextBox1.Clear() ' Eingabefeld leeren

                    ' Scrollen zum Ende der RichTextBox
                    Console.ScrollToCaret() ' Sicherstellen, dass 'Console' hier der Name Ihrer RichTextBox ist

                Catch ex As Exception
                    ' Beispiel: rtbConsole.AppendText($"Fehler beim Senden des Befehls: {ex.Message}{Environment.NewLine}")
                    Console.AppendText($"Fehler beim Senden des Befehls: {ex.Message}{Environment.NewLine}")
                End Try
            End If
        Else
            ' Beispiel: rtbConsole.AppendText("Shell ist nicht gestartet oder wurde beendet." & Environment.NewLine)
            Console.AppendText("Shell ist nicht gestartet oder wurde beendet." & Environment.NewLine)
        End If
    End Sub
End Class

