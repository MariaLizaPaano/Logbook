Public Class Add_Visitors
    Private Sub Add_Visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visitor_IDTextBox.Clear()
        Last_NameTextBox.Clear()
        First_NameTextBox.Clear()
        Middle_NameTextBox.Clear()
        Phone_NumberTextBox.Clear()
        ComboBox1.Text = ""
        Label1.Text = ""
        Label1.Text = ""
        Label1.Text = ""
        Label1.Text = ""
        Label1.Text = ""
    End Sub

    Private Sub MARIAABADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MARIAABADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WewDataSet)

    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click

        Dim alpha As String = "ABCDEFGHIJKLMNOPQRSTUVabcdefghijklmnopqrstuvwxyz"
        Dim errored As Boolean = False
        Dim err As String

        Timer1.Start()

        '   Visitor_IDTextBox.Clear()
        '   Last_NameTextBox.Clear()
        ''   First_NameTextBox.Clear()
        '  Middle_NameTextBox.Clear()
        '  Phone_NumberTextBox.Clear()
        '  ComboBox1.Text = ""
        'Label

        ' Timer1.ToString()

        'Label1.Text = "Checked In Sucessfully"


        'If (Visitor_IDTextBox.Text = "" Or Last_NameTextBox.Text = "" Or First_NameTextBox.Text = "" Or Middle_NameTextBox.Text = "" Or Phone_NumberTextBox.Text.Contains(num)) Then
        'MessageBox.Show("Please input all Text Boxes")
        'Label1.Text = ("Please input all Text Boxes")
        'Else
        'ssageBox.Show("Checked In Successfully")
        'Label1.Text = ("Checked In Successfully")
        'End If

        If Visitor_IDTextBox.Text = "" Then

        End If

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

    Public Function Is_Alpha(Text As String) As Boolean
        Dim AlphaNumericValidator As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim b_Result As Boolean

        If InStr(AlphaNumericValidator, Text) > 0 Then
            b_Result = True
        Else
            b_Result = False
        End If

        Return b_Result

    End Function

    Public Function Is_number(Text As String) As Boolean
        Dim num As String = "0123456789"
        Dim b_Result As Boolean

        If InStr(num, Text) > 0 Then
            b_Result = True
        Else
            b_Result = False
        End If

        Return b_Result

    End Function
End Class
