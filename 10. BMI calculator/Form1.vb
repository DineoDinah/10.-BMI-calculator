Imports System.Diagnostics.Eventing.Reader

Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		'Declaration of variables
		Dim height, weight, bmi As Double

		weight = Val(TextBox1.Text)
		height = Val(TextBox2.Text)

		bmi = (weight / (height) ^ 2).ToString("F2") ' BMI formula rounder to 2 decimal places

		TextBox3.Text = bmi

		If bmi < 18 Then
			TextBox4.Text = "You are underweight"

		ElseIf 18 <= bmi And bmi < 26 Then
			TextBox4.Text = "You are normal"

		Else
			TextBox4.Text = "you are overweight"


		End If



	End Sub
End Class
