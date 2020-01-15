Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()

    End Sub



    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Clear()
        TextBox3.ForeColor = Color.FromArgb(78, 184, 206)
        Panel3.BackColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
        TextBox2.PasswordChar = "*"
        TextBox2.ForeColor = Color.FromArgb(78, 184, 206)
        Panel2.BackColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
        TextBox1.ForeColor = Color.FromArgb(78, 184, 206)
        Panel1.BackColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub

End Class
