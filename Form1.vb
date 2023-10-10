Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "123" Then
            MsgBox("Log in Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class
