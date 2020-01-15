Public Class View_Students
    Private Sub MARIAABADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MARIAABADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WewDataSet)

    End Sub
End Class
