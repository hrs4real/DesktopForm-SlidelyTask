Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Slidely Form App"
        Me.KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim viewForm As New ViewForm()
        viewForm.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim createForm As New CreateForm()
        createForm.Show()
    End Sub



End Class
