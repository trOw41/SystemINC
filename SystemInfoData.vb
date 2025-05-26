' SystemInfoData.vb
Public Class SystemInfoData
    Public Property Id As Integer
    Public Property Timestamp As DateTime
    Public Property OSSystem As String
    Public Property SystemType As String
    Public Property ComputerName As String
    Public Property UserName As String
    Public Property DomainName As String
    Public Property ProcessorCount As Integer
    Public Property TotalPhysicalMemory As String
    Public Property AvailablePhysicalMemory As String
    Public Property HostName As String
    Public Property IPAddresses As String
    Public Property SystemDirectory As String
    Public Property ProgramDirectory As String
    Public Property NetworkAdapterNames As String
    Public Property NetworkAdapterMacAddresses As String
    Public Property BIOSVersion As String
    Public Property ProcessorInformation As String
    Public Property GraphicsCardInformation As String

    Public Sub New(osSystem As String, systemType As String, computerName As String, userName As String,
                   domainName As String, processorCount As Integer, totalPhysicalMemory As String,
                   availablePhysicalMemory As String, hostName As String, ipAddresses As String,
                   systemDirectory As String, programDirectory As String, networkAdapterNames As String,
                   networkAdapterMacAddresses As String, biosVersion As String,
                   processorInformation As String, graphicsCardInformation As String)
        Me.Timestamp = DateTime.UtcNow
        Me.OSSystem = osSystem
        Me.SystemType = systemType
        Me.ComputerName = computerName
        Me.UserName = userName
        Me.DomainName = domainName
        Me.ProcessorCount = processorCount
        Me.TotalPhysicalMemory = totalPhysicalMemory
        Me.AvailablePhysicalMemory = availablePhysicalMemory
        Me.HostName = hostName
        Me.IPAddresses = ipAddresses
        Me.SystemDirectory = systemDirectory
        Me.ProgramDirectory = programDirectory
        Me.NetworkAdapterNames = networkAdapterNames
        Me.NetworkAdapterMacAddresses = networkAdapterMacAddresses
        Me.BIOSVersion = biosVersion
        Me.ProcessorInformation = processorInformation
        Me.GraphicsCardInformation = graphicsCardInformation
    End Sub

    Public Sub New()
        Me.Timestamp = DateTime.UtcNow
    End Sub
End Class