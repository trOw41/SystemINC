Imports System.Drawing.Text
Imports System.IO
Public NotInheritable Class About



    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Version As String = "1.0.0.1"
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = $"Info {ApplicationTitle }"
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", Version)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Dim licensePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LICENSE.txt")
        Dim text As String = My.Resources.LICENSE.ToString
        If text IsNot Nothing Then
            If File.Exists(licensePath) Then
                text = File.ReadAllText(licensePath)
            End If
            EulaBox.Text = text
        Else
            EulaBox.Text = "Es wurde kein Text zur Anzeige übergeben."

        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
