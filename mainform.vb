Imports System.Diagnostics
Imports System.Net

Public Class mainform
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        rtbAnswer.Text = "Thinking..."
        ' Create a request to the website URL
        Dim request As HttpWebRequest = DirectCast(
            WebRequest.Create($"http://hoho9155.pythonanywhere.com/ask/{txtQuestion.Text.Trim()}"),
            HttpWebRequest
        )

        ' Get the response from the website
        Try
            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                ' Check if the response is successful
                If response.StatusCode = HttpStatusCode.OK Then
                    ' Get the response stream
                    Using stream As System.IO.Stream = response.GetResponseStream()
                        ' Read the content from the stream
                        Dim reader As New System.IO.StreamReader(stream)
                        Dim content As String = reader.ReadToEnd()

                        ' Display the content in a text box or perform further processing
                        rtbAnswer.Text = content
                    End Using
                Else
                    ' Handle unsuccessful response code here
                    rtbAnswer.Text = $"Error occurred. Status code: {response.StatusCode}"
                End If
            End Using
        Catch ex As Exception
            rtbAnswer.Text = ex.Message
        End Try

    End Sub

    Private Sub txtQuestion_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQuestion.KeyUp
        If e.KeyCode = Keys.Enter Then
            ' btnSend_Click(sender, e)
        End If
    End Sub
End Class
