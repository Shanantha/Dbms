Imports System.Buffers
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form3
    Dim ww1 As New SqlCommand
    Dim conn As SqlConnection = New SqlConnection()
    Dim dss As DataSet
    Dim sadap As SqlDataAdapter
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=LAPTOP-P0VL9FHH\SQLEXPRESS;Initial Catalog=ex;Integrated Security=True"
        conn.Open()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxfloor.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxoccupancy.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String
        str1 = "insert into hallaccomdation values('" & TextBoxdate.Text & "','" & TextBoxtime.Text & "','" & TextBoxyear.Text & "','" & ComboBoxfloor.Text & "','" & ComboBoxroomno.Text & "','" & ComboBoxoccupancy.Text & "')"
        Dim ww As New SqlCommand(str1, conn)
        ww.ExecuteNonQuery()
        MsgBox("inserted successfully")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String
        query = "delete from  hallaccomdation  where roomno = " & ComboBoxroomno.Text & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("successfully deleted")

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxyear.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxdate.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxtime.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBoxroomno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxroomno.SelectedIndexChanged

    End Sub
End Class