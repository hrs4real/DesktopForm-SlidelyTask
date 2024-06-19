Imports System.Net.Http
Imports Newtonsoft.Json
Public Class ViewForm

    Private Class SubmissionData
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class


    Private currentIndex As Integer = 0

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        Dim apiUrl As String = $"http://localhost:3000/read?index={index}"

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim submission = JsonConvert.DeserializeObject(Of SubmissionData)(jsonResponse)
                TextBox1.Text = submission.name
                TextBox2.Text = submission.email
                TextBox3.Text = submission.phone
                TextBox4.Text = submission.github_link
                TextBox5.Text = submission.stopwatch_time
            Else
                MessageBox.Show("No data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub
    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "View Submissions"
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        Me.KeyPreview = True
        LoadSubmission(currentIndex)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        Else
            MessageBox.Show("This is the first submission.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class