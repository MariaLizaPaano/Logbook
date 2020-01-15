Public Class Add_Visitors
    Private Sub Add_Visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MARIAABADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MARIAABADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WewDataSet)

    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click

    End Sub

    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        Try
            With AddNew
                If .Text = "Add New" Then
                    MARIAABADBindingSource.AddNew()
                    .Text = "CANCEL"


                End If
            End With

            With Last_NameTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                    .Select()

                End If
            End With
        Catch ex As Exception
            MsgBox("ERROR!: " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "adding failed")

        End Try
    End Sub

    Private Sub RefreshData()
        Try
            Me.MARIAABADBindingSource.Filter = Nothing
            Me.MARIAABADTableAdapter.Fill(Me.WewDataSet.MARIAABAD)
        Catch ex As Exception
            MsgBox("Refresh Failed")
        End Try
    End Sub
End Class
