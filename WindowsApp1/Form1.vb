Public Class Form1
    Dim pass As String = "11223311"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = pass Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("  خطأ في الرمز  ", "رسالة خطأ")
            TextBox2.Text = ("")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
