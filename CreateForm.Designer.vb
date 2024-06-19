<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Timer1 = New Timer(components)
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(565, 42)
        Label1.TabIndex = 4
        Label1.Text = "Harsh Srivastava, Slidely Task 2 - Create Submissions"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Location = New Point(138, 186)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(425, 33)
        TextBox4.TabIndex = 22
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Location = New Point(138, 140)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(425, 27)
        TextBox3.TabIndex = 21
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(138, 104)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(425, 27)
        TextBox2.TabIndex = 20
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(138, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(425, 27)
        TextBox1.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(43, 179)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 40)
        Label5.TabIndex = 17
        Label5.Text = "Github Link " & vbCrLf & "for task 2"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(43, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 16
        Label4.Text = "Phone no."
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(57, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 15
        Label3.Text = "Email"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(57, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 14
        Label2.Text = "Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(43, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(341, 29)
        Button1.TabIndex = 23
        Button1.Text = "Toogle Stopwatch (CTRL + T)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(43, 281)
        Button2.Name = "Button2"
        Button2.Size = New Size(520, 29)
        Button2.TabIndex = 25
        Button2.Text = "SUBMIT (CTRL + S)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(454, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 23)
        Label6.TabIndex = 26
        Label6.Text = "00:00:00"
        ' 
        ' CreateForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(589, 345)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CreateForm"
        Text = "CreateForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
End Class
