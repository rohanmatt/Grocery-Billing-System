Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = Val(TextBox1.Text) * 2
            Label3.Text = "The total cost is " + TextBox2.Text
        ElseIf RadioButton2.Checked = True Then
            TextBox2.Text = Val(TextBox1.Text) * 4
            Label3.Text = "The total cost is " + TextBox2.Text
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Text = Val(TextBox1.Text) * 6
            Label3.Text = "The total cost is " + TextBox2.Text

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub
End Class
