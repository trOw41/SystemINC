' SystemInfoRepository.vb
Imports System.Data.SQLite
Imports System.IO
Imports System.Collections.Generic ' Für List(Of T)

Public Class SystemInfoRepository

    Private Const DB_FILE_NAME As String = "SystemInfo.db"
    Private ReadOnly DB_PATH As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_FILE_NAME)
    Private ReadOnly CONNECTION_STRING As String = $"Data Source={DB_PATH};Version=3;"

    Public Sub New()

        InitializeDatabase()
    End Sub

    Private Sub InitializeDatabase()
        Try
            If Not File.Exists(DB_PATH) Then
                SQLiteConnection.CreateFile(DB_PATH)
                Console.WriteLine($"Datenbankdatei '{DB_FILE_NAME}' erstellt.")
            End If

            Using connection As New SQLiteConnection(CONNECTION_STRING)
                connection.Open()

                Dim createTableSql As String = "
                CREATE TABLE IF NOT EXISTS SystemInfoReadings (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Timestamp TEXT NOT NULL,
                    OSSystem TEXT,
                    SystemType TEXT,
                    ComputerName TEXT,
                    UserName TEXT,
                    DomainName TEXT,
                    ProcessorCount INTEGER,
                    TotalPhysicalMemory TEXT,
                    AvailablePhysicalMemory TEXT,
                    HostName TEXT,
                    IPAddresses TEXT,
                    SystemDirectory TEXT,
                    ProgramDirectory TEXT,
                    NetworkAdapterNames TEXT,
                    NetworkAdapterMacAddresses TEXT,
                    BIOSVersion TEXT,
                    ProcessorInformation TEXT,
                    GraphicsCardInformation TEXT
                );"

                Using command As New SQLiteCommand(createTableSql, connection)
                    command.ExecuteNonQuery()
                End Using
                Console.WriteLine("Tabelle 'SystemInfoReadings' überprüft/erstellt.")
            End Using
        Catch ex As Exception

            MessageBox.Show($"Fehler bei der Datenbankinitialisierung: {ex.Message}", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"Datenbankinitialisierungsfehler: {ex.ToString()}")
        End Try
    End Sub


    Public Sub SaveSystemInfo(ByVal data As SystemInfoData)
        If data Is Nothing Then
            Throw New ArgumentNullException("data", "SystemInfoData-Objekt darf nicht Null sein.")
        End If

        Try
            Using connection As New SQLiteConnection(CONNECTION_STRING)
                connection.Open()

                Dim insertSql As String = "
                INSERT INTO SystemInfoReadings (
                    Timestamp, OSSystem, SystemType, ComputerName, UserName, DomainName,
                    ProcessorCount, TotalPhysicalMemory, AvailablePhysicalMemory, HostName,
                    IPAddresses, SystemDirectory, ProgramDirectory, NetworkAdapterNames,
                    NetworkAdapterMacAddresses, BIOSVersion, ProcessorInformation, GraphicsCardInformation
                ) VALUES (
                    @Timestamp, @OSSystem, @SystemType, @ComputerName, @UserName, @DomainName,
                    @ProcessorCount, @TotalPhysicalMemory, @AvailablePhysicalMemory, @HostName,
                    @IPAddresses, @SystemDirectory, @ProgramDirectory, @NetworkAdapterNames,
                    @NetworkAdapterMacAddresses, @BIOSVersion, @ProcessorInformation, @GraphicsCardInformation
                );"

                Using command As New SQLiteCommand(insertSql, connection)

                    command.Parameters.AddWithValue("@Timestamp", data.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"))
                    command.Parameters.AddWithValue("@OSSystem", data.OSSystem)
                    command.Parameters.AddWithValue("@SystemType", data.SystemType)
                    command.Parameters.AddWithValue("@ComputerName", data.ComputerName)
                    command.Parameters.AddWithValue("@UserName", data.UserName)
                    command.Parameters.AddWithValue("@DomainName", data.DomainName)
                    command.Parameters.AddWithValue("@ProcessorCount", data.ProcessorCount)
                    command.Parameters.AddWithValue("@TotalPhysicalMemory", data.TotalPhysicalMemory)
                    command.Parameters.AddWithValue("@AvailablePhysicalMemory", data.AvailablePhysicalMemory)
                    command.Parameters.AddWithValue("@HostName", data.HostName)
                    command.Parameters.AddWithValue("@IPAddresses", data.IPAddresses)
                    command.Parameters.AddWithValue("@SystemDirectory", data.SystemDirectory)
                    command.Parameters.AddWithValue("@ProgramDirectory", data.ProgramDirectory)
                    command.Parameters.AddWithValue("@NetworkAdapterNames", data.NetworkAdapterNames)
                    command.Parameters.AddWithValue("@NetworkAdapterMacAddresses", data.NetworkAdapterMacAddresses)
                    command.Parameters.AddWithValue("@BIOSVersion", data.BIOSVersion)
                    command.Parameters.AddWithValue("@ProcessorInformation", data.ProcessorInformation)
                    command.Parameters.AddWithValue("@GraphicsCardInformation", data.GraphicsCardInformation)

                    command.ExecuteNonQuery()
                End Using
                Console.WriteLine("Systeminformationen erfolgreich in der Datenbank gespeichert.")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Fehler beim Speichern der Systeminformationen: {ex.Message}", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"Speicherfehler in Repository: {ex.ToString()}")

            Throw
        End Try
    End Sub


    Public Function GetLastSystemInfoReadings(count As Integer) As List(Of SystemInfoData)
        Dim readings As New List(Of SystemInfoData)()
        Try
            Using connection As New SQLiteConnection(CONNECTION_STRING)
                connection.Open()
                Dim selectSql As String = $"SELECT * FROM SystemInfoReadings ORDER BY Timestamp DESC LIMIT {count};"
                Using command As New SQLiteCommand(selectSql, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim data As New SystemInfoData()
                            data.Id = reader.GetInt32(reader.GetOrdinal("Id"))
                            data.Timestamp = DateTime.Parse(reader.GetString(reader.GetOrdinal("Timestamp")))
                            data.OSSystem = reader.GetString(reader.GetOrdinal("OSSystem"))
                            data.SystemType = reader.GetString(reader.GetOrdinal("SystemType"))
                            data.ComputerName = reader.GetString(reader.GetOrdinal("ComputerName"))
                            data.UserName = reader.GetString(reader.GetOrdinal("UserName"))
                            data.DomainName = reader.GetString(reader.GetOrdinal("DomainName"))
                            data.ProcessorCount = reader.GetInt32(reader.GetOrdinal("ProcessorCount"))
                            data.TotalPhysicalMemory = reader.GetString(reader.GetOrdinal("TotalPhysicalMemory"))
                            data.AvailablePhysicalMemory = reader.GetString(reader.GetOrdinal("AvailablePhysicalMemory"))
                            data.HostName = reader.GetString(reader.GetOrdinal("HostName"))
                            data.IPAddresses = reader.GetString(reader.GetOrdinal("IPAddresses"))
                            data.SystemDirectory = reader.GetString(reader.GetOrdinal("SystemDirectory"))
                            data.ProgramDirectory = reader.GetString(reader.GetOrdinal("ProgramDirectory"))
                            data.NetworkAdapterNames = reader.GetString(reader.GetOrdinal("NetworkAdapterNames"))
                            data.NetworkAdapterMacAddresses = reader.GetString(reader.GetOrdinal("NetworkAdapterMacAddresses"))
                            data.BIOSVersion = reader.GetString(reader.GetOrdinal("BIOSVersion"))
                            data.ProcessorInformation = reader.GetString(reader.GetOrdinal("ProcessorInformation"))
                            data.GraphicsCardInformation = reader.GetString(reader.GetOrdinal("GraphicsCardInformation"))
                            readings.Add(data)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Fehler beim Abrufen der Systeminformationen: {ex.Message}", "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"Abruffehler in Repository: {ex.ToString()}")
        End Try
        Return readings
    End Function

End Class