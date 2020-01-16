Public Class Add_Visitors
    Private Sub Add_Visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MARIAABADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MARIAABADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WewDataSet)

    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        Timer1.Start()
        Visitor_IDTextBox.Clear()
        Last_NameTextBox.Clear()
        First_NameTextBox.Clear()
        Middle_NameTextBox.Clear()
        Phone_NumberTextBox.Clear()
        ComboBox1.Text = ""
        'Label
        Timer1.ToString()

        Label1.Text = "Checked In Sucessfully"

    End Sub

    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        'clear
        Visitor_IDTextBox.Clear()
        Last_NameTextBox.Clear()
        First_NameTextBox.Clear()
        Middle_NameTextBox.Clear()
        Phone_NumberTextBox.Clear()
        ComboBox1.Text = ""
        'Label
        Label1.Text = ""
    End Sub

    Private Sub RefreshData()
        Try
            Me.MARIAABADBindingSource.Filter = Nothing
            Me.MARIAABADTableAdapter.Fill(Me.WewDataSet.MARIAABAD)
        Catch ex As Exception
            MsgBox("Refresh Failed")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
