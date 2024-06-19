<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.Location = New Point(11, 74)
        Button1.Name = "Button1"
        Button1.Size = New Size(517, 46)
        Button1.TabIndex = 0
        Button1.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.Location = New Point(12, 129)
        Button2.Name = "Button2"
        Button2.Size = New Size(517, 50)
        Button2.TabIndex = 1
        Button2.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(517, 28)
        Label1.TabIndex = 2
        Label1.Text = "Harsh Srivastava, Slidely Task 2 - Slidely Form App"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(541, 197)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label

End Class
