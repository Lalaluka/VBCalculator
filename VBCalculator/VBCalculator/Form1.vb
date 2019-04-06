Public Class Form1
    Private Sub LlGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llGithub.LinkClicked
        openLink("https://github.com/Lalaluka/VBCalculator")
    End Sub

    Private Sub openLink(link As String)
        Try
            Process.Start(link)
        Catch
            MessageBox.Show("Your Browser doesnt support Link calls", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LlHomepage1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llHomepage1.LinkClicked
        openLink("http://www.calvin-schroeder.de/uebermich.html")
    End Sub

    Private Sub LlRickroll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llRickroll.LinkClicked
        openLink("https://www.youtube.com/watch?v=DLzxrzFCyOs")
    End Sub
End Class
