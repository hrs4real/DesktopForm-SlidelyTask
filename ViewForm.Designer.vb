<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(613, 42)
        Label1.TabIndex = 3
        Label1.Text = "Harsh Srivastava, Slidely Task 2 - View Submissions"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(59, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 4
        Label2.Text = "Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(59, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 5
        Label3.Text = "Email"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(45, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 6
        Label4.Text = "Phone no."
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(45, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 40)
        Label5.TabIndex = 7
        Label5.Text = "Github Link " & vbCrLf & "for task 2"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(45, 249)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 40)
        Label6.TabIndex = 8
        Label6.Text = "Stopwatch " & vbCrLf & "Time"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(141, 78)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(451, 27)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(141, 116)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(451, 27)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Location = New Point(141, 152)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(451, 27)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Location = New Point(141, 198)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(451, 33)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox5.Location = New Point(141, 256)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(451, 27)
        TextBox5.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(86, 314)
        Button1.Name = "Button1"
        Button1.Size = New Size(216, 29)
        Button1.TabIndex = 14
        Button1.Text = "PREVIOUS (CTRL + P)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(305, 314)
        Button2.Name = "Button2"
        Button2.Size = New Size(240, 29)
        Button2.TabIndex = 15
        Button2.Text = "NEXT (CTRL + N)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ViewForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(637, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ViewForm"
        Text = "ViewForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
