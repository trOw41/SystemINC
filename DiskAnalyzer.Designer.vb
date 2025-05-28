<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class DiskAnalyzer
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    'H
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Text = "DiskAnalyser"
        AddHandler Me.Load, AddressOf Me.DiskAnalyzer_Load
    End Sub

    Private Sub DiskAnalyzer_Load(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub
End Class
