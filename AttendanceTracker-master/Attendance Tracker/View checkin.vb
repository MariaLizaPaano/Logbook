﻿Public Class View_Visitors
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
        TextBox1.ForeColor = Color.FromArgb(78, 184, 206)
        Panel1.BackColor = Color.FromArgb(78, 184, 206)

    End Sub

    Private Sub MARIAABADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MARIAABADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WewDataSet)

    End Sub

    Private Sub View_Visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
