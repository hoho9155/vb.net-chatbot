Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class mainform

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        rtbAnswer.Text = "Thinking..."
        Try
            ' Replace "YOUR_URL_HERE" with the actual URL you want to stream from
            Dim url As String = $"http://hoho9155.pythonanywhere.com/ask/{txtQuestion.Text.Trim()}"

            Dim request As WebRequest = WebRequest.Create(url)
            Dim response As WebResponse = request.GetResponse()

            Dim stream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(stream)

            rtbAnswer.Text = ""

            While True
                Dim line As String = reader.ReadLine()

                If line Is Nothing Then
                    Exit While
                End If

                rtbAnswer.AppendText(line & Environment.NewLine)
                Application.DoEvents()
            End While
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub txtQuestion_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQuestion.KeyUp
        If e.KeyCode = Keys.Enter Then
            ' btnSend_Click(sender, e)
        End If
    End Sub


End Class
