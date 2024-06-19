Imports System.Net.Http
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json

Public Class CreateForm

    Private Class SubmissionData
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class

    Private elapsedTime As Integer = 0
    Private isRunning As Boolean = False
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            Button2.PerformClick()
        End If
    End Sub
    Private Sub CreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Create Submission"
        Me.KeyPreview = True
        Timer1.Start()
        isRunning = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isRunning Then
            elapsedTime += 1
            Label6.Text = TimeSpan.FromSeconds(elapsedTime).ToString("hh\:mm\:ss")
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isRunning Then
            Timer1.Stop()
            isRunning = False
        Else
            Timer1.Start()
            isRunning = True
        End If
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim phoneNum As String = TextBox3.Text
        Dim githubLink As String = TextBox4.Text
        Dim timer As String = TimeSpan.FromSeconds(elapsedTime).ToString("hh\:mm\:ss")

        If String.IsNullOrWhiteSpace(name) OrElse
           String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(phoneNum) OrElse
           String.IsNullOrWhiteSpace(githubLink) Then
            MessageBox.Show("All fields are required. Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim data As New SubmissionData With {
            .name = name,
            .email = email,
            .phone = phoneNum,
            .github_link = githubLink,
            .stopwatch_time = timer
        }


        Dim jsonData As String = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented)


        Dim apiUrl As String = "http://localhost:3000/submit"
        Using client As New HttpClient()
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Data posted successfully!" & Environment.NewLine &
                                          "Name: " & name & Environment.NewLine &
                                         "Email: " & email & Environment.NewLine &
                                        "Phone Number: " & phoneNum & Environment.NewLine &
                                       "GitHub Link: " & githubLink & Environment.NewLine &
                                      "Timer: " & timer, "Information Submission", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to post data. Status Code: " & response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using


        Me.Close()

    End Sub
End Class