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
		Label1 = New Label()
		Label2 = New Label()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		TextBox4 = New TextBox()
		Label3 = New Label()
		Label4 = New Label()
		Button1 = New Button()
		Label5 = New Label()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(12, 63)
		Label1.Name = "Label1"
		Label1.Size = New Size(150, 25)
		Label1.TabIndex = 0
		Label1.Text = "Enter Your weight"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(2, 127)
		Label2.Name = "Label2"
		Label2.Size = New Size(196, 25)
		Label2.TabIndex = 1
		Label2.Text = "Enter your Height in(M)"
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(220, 57)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 2
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(220, 121)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 3
		' 
		' TextBox3
		' 
		TextBox3.Location = New Point(220, 180)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(150, 31)
		TextBox3.TabIndex = 4
		' 
		' TextBox4
		' 
		TextBox4.BackColor = SystemColors.ControlDark
		TextBox4.Location = New Point(220, 243)
		TextBox4.Name = "TextBox4"
		TextBox4.Size = New Size(506, 31)
		TextBox4.TabIndex = 5
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(12, 186)
		Label3.Name = "Label3"
		Label3.Size = New Size(100, 25)
		Label3.TabIndex = 6
		Label3.Text = "Your BMI is"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(21, 243)
		Label4.Name = "Label4"
		Label4.Size = New Size(91, 25)
		Label4.TabIndex = 7
		Label4.Text = "Comment"
		' 
		' Button1
		' 
		Button1.BackColor = SystemColors.Info
		Button1.Location = New Point(46, 315)
		Button1.Name = "Button1"
		Button1.Size = New Size(179, 64)
		Button1.TabIndex = 8
		Button1.Text = "Calculate"
		Button1.UseVisualStyleBackColor = False
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Showcard Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point)
		Label5.Location = New Point(157, 9)
		Label5.Name = "Label5"
		Label5.Size = New Size(213, 30)
		Label5.TabIndex = 9
		Label5.Text = "BMI Calculator"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ActiveCaption
		ClientSize = New Size(800, 450)
		Controls.Add(Label5)
		Controls.Add(Button1)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(TextBox4)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Label5 As Label
End Class
