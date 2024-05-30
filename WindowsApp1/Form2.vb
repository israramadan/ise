Imports System.Drawing.Text
Imports System.Drawing.Printing
Imports System.IO
Imports System.ComponentModel
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowOGV()
    End Sub
    Private Sub InsertDta()
        Dim writer As New StreamWriter("All.yam", True)


        Dim Extraline As String = TextBox1.Text & "|" & TextBox2.Text & "|" & TextBox3.Text & "|" & TextBox4.Text & "|" & TextBox5.Text
            writer.WriteLine(Extraline)
            writer.Close()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

    End Sub
    Private Sub ShowOGV()
        DataGridView1.Rows.Clear()
        Using objReader As New StreamReader("all.yam")
            Do While objReader.Peek() <> -1
                Dim line As String = objReader.ReadLine
                Dim splitline() As String = line.Split("|")
                Dim TextBox1 As String = splitline(0)
                Dim TextBox2 As String = splitline(1)
                Dim TextBox3 As String = splitline(2)
                Dim TextBox4 As String = splitline(3)
                Dim TextBox5 As String = splitline(4)
                If TextBox2 <> "_" Then
                    Me.DataGridView1.Rows.Add(TextBox1, TextBox2, TextBox3, TextBox4, TextBox5)
                End If
            Loop
        End Using
    End Sub
    Private Sub new_id()
        Dim jumbofile As String = Application.StartupPath & "/all.yam"
        If System.IO.File.Exists(jumbofile) Then
            Dim lines() As String = IO.File.ReadAllLines(jumbofile)


        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InsertDta()
        ShowOGV()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class