Imports System.Buffers
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form6
    Dim ww1 As New SqlCommand
    Dim conn As SqlConnection = New SqlConnection()
    Dim dss As DataSet
    Dim sadap As SqlDataAdapter
    Dim myreader As SqlDataReader
    Dim myreader1 As SqlDataReader

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=LAPTOP-P0VL9FHH\SQLEXPRESS;Initial Catalog=ex;Integrated Security=True"
        conn.Open()
        Dim myCmd As New SqlCommand
        myCmd = conn.CreateCommand
        myCmd.CommandText = "SELECT floor,roomno,no_of_occupancy from hallaccomdation"
        myreader = myCmd.ExecuteReader()
        Do While myReader.Read()
            ComboBox1.Items.Add(myreader.GetString(0))
            ComboBox2.Items.Add(myreader.GetString(1))
            ComboBox3.Items.Add(myreader.GetString(2))
        Loop
        myreader.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        'room size
        Dim ww As Integer
        conn.Open()
        ww = ComboBox3.Text
        Dim myCmd1 As New SqlCommand
        myCmd1 = conn.CreateCommand
        myCmd1.CommandText = "SELECT course from studetail where class<='" & ww & "'"
        myreader1 = myCmd1.ExecuteReader()
        Do While myreader1.Read()
            ComboBox4.Items.Add(myreader1.GetString(0))

        Loop
        myreader1.Close()

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ' recommended course

        Dim k As Integer
        Dim ww As String
        ww = ComboBox4.Text
        Dim myCmd1 As New SqlCommand
        myCmd1 = conn.CreateCommand
        myCmd1.CommandText = "SELECT class from studetail where course='" & ww & "'"
        myreader = myCmd1.ExecuteReader()
        Do While myreader.Read()
            k = (myreader.GetString(0))

        Loop
        myreader.Close()

        TextBox1.Text = Val(ComboBox3.Text) - k
        MsgBox(k)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' save
        Dim str1 As String
        str1 = "insert into roomallotment values('" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "')"
        Dim ww As New SqlCommand(str1, conn)
        ww.ExecuteNonQuery()
        MsgBox("inserted successfully")
        conn.Close()
        ListBox1.Items.Add(ComboBox4.Text + TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String
        query = "delete from roomallotment   where roomno = " & ComboBox2.Text & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        MsgBox("successfully deleted")
        conn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn.Close()
    End Sub
End Class