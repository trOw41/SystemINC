Imports System.IO
Imports System.Windows.Forms

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


    Private Sub Dialog1_load(sender As Object, e As EventArgs)
        If Me.Controls.ContainsKey("TextBox") AndAlso TypeOf Me.Controls("TextBox") Is TextBox Then
            Dim targetTextBox As TextBox = DirectCast(Me.Controls("TextBox"), TextBox)
            If Not String.IsNullOrEmpty(_displayText) Then
                targetTextBox.Text = _displayText
            Else
                targetTextBox.Text = "Es wurde kein Text zur Anzeige übergeben."
            End If
        Else

            Debug.WriteLine("Warnung: TextBox-Steuerelement in Dialog1 nicht gefunden.")
        End If
    End Sub
End Class
