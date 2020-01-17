Public Class Add_Vehicles
    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        ComboBox1.Text = ""
        Visitor_IDTextBox.Clear()
        First_NameTextBox.Clear()
        Middle_NameTextBox.Clear()
        Label1.Text = ""

    End Sub

    Private Sub Add_Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
    End Sub
End Class
