Imports System.IO

Public Class Dialog1
    Private _displayText As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "discription.txt")
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TextBox1 IsNot Nothing Then
            If File.Exists(_displayText) Then
                TextBox1.Text = File.ReadAllText(_displayText)
            Else
                TextBox1.Text = "Es wurde kein Text zur Anzeige übergeben."
                Debug.WriteLine("Warnung: TextBox-Steuerelement in Dialog1 nicht gefunden.")
            End If
        Else
            Debug.WriteLine("Fehler: TextBox1 ist nicht vorhanden oder nicht initialisiert.")
        End If
    End Sub
End Class
