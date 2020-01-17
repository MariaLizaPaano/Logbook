Public Class Add_Vehicles
    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        makebx.Text = ""
        platebx.Clear()
        modelbx.Clear()
        colorbx.Clear()
        Label1.Text = ""

    End Sub

    Private Sub Add_Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function clearer()
        makebx.Text = ""
        platebx.Clear()
        modelbx.Clear()
        colorbx.Clear()
        Label1.Text = ""
    End Function
End Class
