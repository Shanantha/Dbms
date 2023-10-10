Imports System.Buffers
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form2
    Dim conn As SqlConnection = New SqlConnection()
    Dim dss As DataSet
    Dim sadap As SqlDataAdapter
    Dim cmd As SqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=LAPTOP-P0VL9FHH\SQLEXPRESS;Initial Catalog=;Persist Security Info=True;User ID=sa;Password=admin123;Integrated Security=True"

        conn.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
    End Sub
End Class