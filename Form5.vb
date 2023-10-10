Imports System.Buffers
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form5
    Dim ww As New SqlCommand
    Dim conn As SqlConnection = New SqlConnection()

    Dim dss As DataSet

    Dim sadap As SqlDataAdapter



    Dim cmd As SqlCommand
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String
        str1 = "insert into timetableentery values('" & TextBoxdate.Text & "','" & TextBoxtime.Text & "','" & TextBoxyear.Text & "','" & ComboBoxdepartmentID.Text & "','" & ComboBoxcoursecode.Text & "')"
        Dim ww As New SqlCommand(str1, conn)
        ww.ExecuteNonQuery()
        MsgBox("inserted successfully")
        conn.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ("Data Source=LAPTOP-P0VL9FHH\SQLEXPRESS;Initial Catalog=ex;Integrated Security=True")
        conn.Open()
    End Sub
End Class