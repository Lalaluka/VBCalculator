Public Class Form1
    Private curentcount = 0
    Private modeset = False
    Private mode = vbNull


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

    Private Sub PUserpanel1_Paint(sender As Object, e As PaintEventArgs) Handles pUserpanel1.Paint

    End Sub

    Private Sub BMathNumber1_Click(sender As Object, e As EventArgs) Handles bMathNumber1.Click
        numberset(1)
    End Sub

    Private Sub numberset(num As Long)
        If modeset Then

        Else
            curentcount = curentcount + 1
        End If
        'Just some dumb shit to debug
        Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + CStr(curentcount))
        If (curentcount <> 0) Then
            MessageBox.Show("YAYA", curentcount, MessageBoxButtons.OK)
        Else

        End If
        MessageBox.Show("Your Browser doesnt support Link calls", curentcount, MessageBoxButtons.OK)
    End Sub
End Class
