Public Class Form1
    Private currentcount As String = "0"
    Private currentsollution = 0
    Private mode = 0


    Private Sub openLink(link As String)
        Try
            Process.Start(link)
        Catch
            MessageBox.Show("Your Browser doesnt support Link calls", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LlGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llGithub.LinkClicked
        openLink("https://github.com/Lalaluka/VBCalculator")
    End Sub

    Private Sub LlHomepage1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llHomepage1.LinkClicked
        openLink("http://www.calvin-schroeder.de/uebermich.html")
    End Sub

    Private Sub LlRickroll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llRickroll.LinkClicked
        openLink("https://www.youtube.com/watch?v=DLzxrzFCyOs")
    End Sub

    Private Sub BMathNumber1_Click(sender As Object, e As EventArgs) Handles bMathNumber1.Click
        numberset(1)
    End Sub

    Private Sub numberset(num As Long)
        If (mode <> 0) Then
            currentcount = currentcount + CStr(num)
            Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + CStr(num))
        Else
            If (currentcount <> 0) Then
                currentcount = currentcount + CStr(num)
            Else
                currentcount = num
            End If
            currentsollution = currentcount
            Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + CStr(num))
        End If
    End Sub

    Private Sub BMathNumber2_Click(sender As Object, e As EventArgs) Handles bMathNumber2.Click
        numberset(2)
    End Sub

    Private Sub BMathNumber3_Click(sender As Object, e As EventArgs) Handles bMathNumber3.Click
        numberset(3)
    End Sub

    Private Sub BMathNumber4_Click(sender As Object, e As EventArgs) Handles bMathNumber4.Click
        numberset(4)
    End Sub

    Private Sub BMathNumber5_Click(sender As Object, e As EventArgs) Handles bMathNumber5.Click
        numberset(5)
    End Sub

    Private Sub BMathNumber6_Click(sender As Object, e As EventArgs) Handles bMathNumber6.Click
        numberset(6)
    End Sub

    Private Sub BMathNumber7_Click(sender As Object, e As EventArgs) Handles bMathNumber7.Click
        numberset(7)
    End Sub

    Private Sub BMathNumber8_Click(sender As Object, e As EventArgs) Handles bMathNumber8.Click
        numberset(8)
    End Sub

    Private Sub BMathNumber9_Click(sender As Object, e As EventArgs) Handles bMathNumber9.Click
        numberset(9)
    End Sub

    Private Sub BPlus_Click(sender As Object, e As EventArgs) Handles BPlus.Click
        If mode <> 0 Then
            calculate()
        End If
        mode = 1
        Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + "+")
        currentcount = "0"
    End Sub

    Private Sub BMathNumber0_Click(sender As Object, e As EventArgs) Handles bMathNumber0.Click
        numberset(0)
    End Sub

    Private Sub BMinus_Click(sender As Object, e As EventArgs) Handles BMinus.Click
        If mode <> 0 Then
            calculate()
        End If
        mode = 2
        Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + "-")
        currentcount = "0"
    End Sub

    Private Sub BTimes_Click(sender As Object, e As EventArgs) Handles BTimes.Click
        If mode <> 0 Then
            calculate()
        End If
        mode = 3
        Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + "*")
        currentcount = "0"
    End Sub

    Private Sub BTrough_Click(sender As Object, e As EventArgs) Handles BTrough.Click
        If mode <> 0 Then
            calculate()
        End If
        mode = 4
        Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + "/")
        currentcount = "0"
    End Sub

    Private Sub BNew_Click(sender As Object, e As EventArgs) Handles BNew.Click
        currentcount = "0"
        currentsollution = 0
        mode = 0
        Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + vbCrLf)
    End Sub

    Private Sub BEnter_Click(sender As Object, e As EventArgs) Handles BEnter.Click
        calculate()
        mode = 0
        Me.Ergebnisverlauf.Text = (Me.Ergebnisverlauf.Text + "=" + CStr(currentsollution))
    End Sub

    Private Sub calculate()
        Select Case mode
            Case 1
                currentsollution = CULng(currentsollution) + CULng(currentcount)
            Case 2
                currentsollution = currentsollution - currentcount
            Case 3
                currentsollution = currentsollution * currentcount
            Case 4
                currentsollution = currentsollution / currentcount
        End Select
    End Sub
End Class
