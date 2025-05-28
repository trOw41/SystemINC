Imports System.ComponentModel
Imports System.Threading

Namespace SysInc
    Partial Public Class DiskAnalyzer
        Inherits System.Windows.Forms.Form

        Interface IDiskAnalyze
            Event Load(sender As Object, e As EventArgs)
        End Interface

        ' *** WICHTIG: ChartDiskUsage als Klassenmember deklarieren ***
        Private ChartDiskUsage As System.Windows.Forms.DataVisualization.Charting.Chart

        ' ... (Ihre anderen Member wie MusicExtensions, VideoExtensions, etc.) ...
        Private ReadOnly MusicExtensions As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
            ".mp3", ".wav", ".flac", ".aac", ".ogg", ".wma", ".m4a"
        }
        Private ReadOnly VideoExtensions As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
            ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv", ".webm", ".3gp"
        }
        Private ReadOnly TextExtensions As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
            ".txt", ".doc", ".docx", ".pdf", ".rtf", ".odt", ".log", ".md"
        }
        Private ReadOnly Controls As Control

        Public Sub New(controls As Control)
            Me.Controls = controls
        End Sub

        Private ReadOnly MusicSize As Long
        Private ReadOnly VideoSize As Long
        Private ReadOnly TextSize As Long
        Private ReadOnly OtherSize As Long
        Private ReadOnly TotalScannedFiles As Long
        Private ReadOnly TotalScannedFolders As Long
        Private ReadOnly CancellationTokenSource As CancellationTokenSource
        Public ReadOnly Property Components As IContainer

        Public Sub New(chartDiskUsage As Chart, musicExtensions As HashSet(Of String), videoExtensions As HashSet(Of String), textExtensions As HashSet(Of String), controls As Object, musicSize As Long, videoSize As Long, textSize As Long, otherSize As Long, totalScannedFiles As Long, totalScannedFolders As Long, cancellationTokenSource As CancellationTokenSource, components As IContainer)
            Me.ChartDiskUsage = chartDiskUsage
            Me.MusicExtensions = musicExtensions
            Me.VideoExtensions = videoExtensions
            Me.TextExtensions = textExtensions
            Me.Controls = controls
            Me.MusicSize = musicSize
            Me.VideoSize = videoSize
            Me.TextSize = textSize
            Me.OtherSize = otherSize
            Me.TotalScannedFiles = totalScannedFiles
            Me.TotalScannedFolders = totalScannedFolders
            Me.CancellationTokenSource = cancellationTokenSource
            Me.Components = components
        End Sub

        Public Sub New(components As IContainer, chartDiskUsage As Chart, musicExtensions As HashSet(Of String), videoExtensions As HashSet(Of String), textExtensions As HashSet(Of String), controls As Object, musicSize As Long, videoSize As Long, textSize As Long, otherSize As Long, totalScannedFiles As Long, totalScannedFolders As Long, cancellationTokenSource As CancellationTokenSource)
            Me.Components = components
            Me.ChartDiskUsage = chartDiskUsage
            Me.MusicExtensions = musicExtensions
            Me.VideoExtensions = videoExtensions
            Me.TextExtensions = textExtensions
            Me.Controls = controls
            Me.MusicSize = musicSize
            Me.VideoSize = videoSize
            Me.TextSize = textSize
            Me.OtherSize = otherSize
            Me.TotalScannedFiles = totalScannedFiles
            Me.TotalScannedFolders = totalScannedFolders
            Me.CancellationTokenSource = cancellationTokenSource
        End Sub

        Private Sub FormDiskAnalyzer_Load(sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

            If Me.ChartDiskUsage Is Nothing Then
                ChartDiskUsage = New System.Windows.Forms.DataVisualization.Charting.Chart With {
                    .Name = "ChartDiskUsage",
                    .Size = New Size(700, 400),
                    .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right ' Für Resizing
                    }
                Dim chartArea1 As New ChartArea("ChartArea1")
                ChartDiskUsage.ChartAreas.Add(chartArea1)
                Dim legend1 As New Legend("Legend1")
                ChartDiskUsage.Legends.Add(legend1)
                Me.Controls.Controls.Add(ChartDiskUsage)
            End If
            InitializeChart()
        End Sub

        Private Sub InitializeChart()
            ' Sicherstellen, dass das Chart-Objekt nicht Nothing ist
            If ChartDiskUsage Is Nothing Then Return
            ChartDiskUsage.Series.Clear()
            ChartDiskUsage.Titles.Clear()
            ChartDiskUsage.Titles.Add("Dateityp-Verteilung")

            Dim series1 As New Series("DiskUsage") With {
                .ChartType = SeriesChartType.Pie,
                .IsValueShownAsLabel = True, ' Werte als Beschriftung anzeigen
                .LabelFormat = "{0.00}%",    ' Formatierung als Prozent
                .LegendText = "#VALX",       ' Legendentext zeigt den Kategorienamen
                .Font = New Font("Arial", 10, FontStyle.Bold)
            }

            ChartDiskUsage.Series.Add(series1)
            If ChartDiskUsage.ChartAreas.Count > 0 Then
                ChartDiskUsage.ChartAreas(0).Area3DStyle.Enable3D = True
                ChartDiskUsage.ChartAreas(0).Area3DStyle.Rotation = 30
                ChartDiskUsage.ChartAreas(0).Area3DStyle.Inclination = 45
            End If
        End Sub

        Private Sub UpdateChart()
            Dim totalSize As Long = MusicSize + VideoSize + TextSize + OtherSize

            If totalSize = 0 Then
                ChartDiskUsage.Series("DiskUsage").Points.Clear()
                'lblStatus.Text = "Keine Daten gefunden."
                Return
            End If

            Dim musicPercentage As Double = If(totalSize > 0, CDbl(MusicSize) / totalSize * 100, 0)
            Dim videoPercentage As Double = If(totalSize > 0, CDbl(VideoSize) / totalSize * 100, 0)
            Dim textPercentage As Double = If(totalSize > 0, CDbl(TextSize) / totalSize * 100, 0)
            Dim otherPercentage As Double = If(totalSize > 0, CDbl(OtherSize) / totalSize * 100, 0)

            ChartDiskUsage.Series("DiskUsage").Points.Clear()

            ' Hinzufügen der Punkte mit spezifischen Farben
            If musicPercentage > 0 Then
                Dim idx = ChartDiskUsage.Series("DiskUsage").Points.AddXY("Musik", musicPercentage)
                ChartDiskUsage.Series("DiskUsage").Points(idx).Color = Color.Blue
            End If
            If videoPercentage > 0 Then
                Dim idx = ChartDiskUsage.Series("DiskUsage").Points.AddXY("Video", videoPercentage)
                ChartDiskUsage.Series("DiskUsage").Points(idx).Color = Color.Red
            End If
            If textPercentage > 0 Then
                Dim idx = ChartDiskUsage.Series("DiskUsage").Points.AddXY("Text", textPercentage)
                ChartDiskUsage.Series("DiskUsage").Points(idx).Color = Color.Green
            End If
            If otherPercentage > 0 Then
                Dim idx = ChartDiskUsage.Series("DiskUsage").Points.AddXY("Andere", otherPercentage)
                ChartDiskUsage.Series("DiskUsage").Points(idx).Color = Color.Gray
            End If

            ' progressBarScan.Value = progressBarScan.Maximum
            'lblStatus.Text = $"Analyse abgeschlossen. Gesamt gescannte Dateien: {TotalScannedFiles}, Ordner: {TotalScannedFolders}"
        End Sub

    End Class
End Namespace