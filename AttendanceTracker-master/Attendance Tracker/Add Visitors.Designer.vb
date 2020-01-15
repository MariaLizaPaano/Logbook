<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Visitors
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Visitor_IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Time_inLabel As System.Windows.Forms.Label
        Dim Time_outLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Me.CheckIn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WewDataSet = New Attendance_Tracker.wewDataSet()
        Me.MARIAABADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MARIAABADTableAdapter = New Attendance_Tracker.wewDataSetTableAdapters.MARIAABADTableAdapter()
        Me.TableAdapterManager = New Attendance_Tracker.wewDataSetTableAdapters.TableAdapterManager()
        Me.Visitor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Time_inTextBox = New System.Windows.Forms.TextBox()
        Me.Time_outTextBox = New System.Windows.Forms.TextBox()
        Me.DestinationTextBox = New System.Windows.Forms.TextBox()
        Me.AddNew = New System.Windows.Forms.Button()
        Visitor_IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Time_inLabel = New System.Windows.Forms.Label()
        Time_outLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.WewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MARIAABADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Visitor_IDLabel
        '
        Visitor_IDLabel.AutoSize = True
        Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitor_IDLabel.Location = New System.Drawing.Point(125, 246)
        Visitor_IDLabel.Name = "Visitor_IDLabel"
        Visitor_IDLabel.Size = New System.Drawing.Size(96, 25)
        Visitor_IDLabel.TabIndex = 13
        Visitor_IDLabel.Text = "Visitor ID:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(123, 290)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(112, 25)
        Last_NameLabel.TabIndex = 14
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(123, 334)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(112, 25)
        First_NameLabel.TabIndex = 15
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(123, 379)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(133, 25)
        Middle_NameLabel.TabIndex = 16
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.Location = New System.Drawing.Point(125, 423)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(149, 25)
        Phone_NumberLabel.TabIndex = 17
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(125, 460)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(59, 25)
        DateLabel.TabIndex = 18
        DateLabel.Text = "Date:"
        '
        'Time_inLabel
        '
        Time_inLabel.AutoSize = True
        Time_inLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Time_inLabel.Location = New System.Drawing.Point(125, 504)
        Time_inLabel.Name = "Time_inLabel"
        Time_inLabel.Size = New System.Drawing.Size(82, 25)
        Time_inLabel.TabIndex = 19
        Time_inLabel.Text = "Time in:"
        '
        'Time_outLabel
        '
        Time_outLabel.AutoSize = True
        Time_outLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Time_outLabel.Location = New System.Drawing.Point(125, 545)
        Time_outLabel.Name = "Time_outLabel"
        Time_outLabel.Size = New System.Drawing.Size(94, 25)
        Time_outLabel.TabIndex = 20
        Time_outLabel.Text = "Time out:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinationLabel.Location = New System.Drawing.Point(125, 591)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(115, 25)
        DestinationLabel.TabIndex = 21
        DestinationLabel.Text = "Destination:"
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(337, 651)
        Me.CheckIn.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(324, 43)
        Me.CheckIn.TabIndex = 11
        Me.CheckIn.Text = "Check in"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1078, 192)
        Me.Panel2.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(120, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 46)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Visitor"
        '
        'WewDataSet
        '
        Me.WewDataSet.DataSetName = "wewDataSet"
        Me.WewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MARIAABADBindingSource
        '
        Me.MARIAABADBindingSource.DataMember = "MARIAABAD"
        Me.MARIAABADBindingSource.DataSource = Me.WewDataSet
        '
        'MARIAABADTableAdapter
        '
        Me.MARIAABADTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MARIAABADTableAdapter = Me.MARIAABADTableAdapter
        Me.TableAdapterManager.UpdateOrder = Attendance_Tracker.wewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Visitor_IDTextBox
        '
        Me.Visitor_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Visitor ID", True))
        Me.Visitor_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visitor_IDTextBox.Location = New System.Drawing.Point(339, 226)
        Me.Visitor_IDTextBox.Multiline = True
        Me.Visitor_IDTextBox.Name = "Visitor_IDTextBox"
        Me.Visitor_IDTextBox.Size = New System.Drawing.Size(324, 45)
        Me.Visitor_IDTextBox.TabIndex = 14
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(339, 277)
        Me.Last_NameTextBox.Multiline = True
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(324, 38)
        Me.Last_NameTextBox.TabIndex = 15
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(339, 321)
        Me.First_NameTextBox.Multiline = True
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(324, 38)
        Me.First_NameTextBox.TabIndex = 16
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Middle Name", True))
        Me.Middle_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(339, 366)
        Me.Middle_NameTextBox.Multiline = True
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(324, 38)
        Me.Middle_NameTextBox.TabIndex = 17
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(337, 412)
        Me.Phone_NumberTextBox.Multiline = True
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(326, 36)
        Me.Phone_NumberTextBox.TabIndex = 18
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MARIAABADBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(337, 455)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(326, 30)
        Me.DateDateTimePicker.TabIndex = 19
        '
        'Time_inTextBox
        '
        Me.Time_inTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Time in", True))
        Me.Time_inTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_inTextBox.Location = New System.Drawing.Point(337, 491)
        Me.Time_inTextBox.Multiline = True
        Me.Time_inTextBox.Name = "Time_inTextBox"
        Me.Time_inTextBox.Size = New System.Drawing.Size(326, 38)
        Me.Time_inTextBox.TabIndex = 20
        '
        'Time_outTextBox
        '
        Me.Time_outTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Time out", True))
        Me.Time_outTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_outTextBox.Location = New System.Drawing.Point(337, 535)
        Me.Time_outTextBox.Multiline = True
        Me.Time_outTextBox.Name = "Time_outTextBox"
        Me.Time_outTextBox.Size = New System.Drawing.Size(326, 35)
        Me.Time_outTextBox.TabIndex = 21
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MARIAABADBindingSource, "Destination", True))
        Me.DestinationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationTextBox.Location = New System.Drawing.Point(337, 576)
        Me.DestinationTextBox.Multiline = True
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(326, 40)
        Me.DestinationTextBox.TabIndex = 22
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(680, 651)
        Me.AddNew.Margin = New System.Windows.Forms.Padding(4)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(324, 43)
        Me.AddNew.TabIndex = 23
        Me.AddNew.Text = "Add New Visitor"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'Add_Visitors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Me.DestinationTextBox)
        Me.Controls.Add(Time_outLabel)
        Me.Controls.Add(Me.Time_outTextBox)
        Me.Controls.Add(Time_inLabel)
        Me.Controls.Add(Me.Time_inTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.Middle_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Visitor_IDLabel)
        Me.Controls.Add(Me.Visitor_IDTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CheckIn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_Visitors"
        Me.Size = New System.Drawing.Size(1078, 749)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.WewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MARIAABADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckIn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents WewDataSet As wewDataSet
    Friend WithEvents MARIAABADBindingSource As BindingSource
    Friend WithEvents MARIAABADTableAdapter As wewDataSetTableAdapters.MARIAABADTableAdapter
    Friend WithEvents TableAdapterManager As wewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Visitor_IDTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Middle_NameTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents Time_inTextBox As TextBox
    Friend WithEvents Time_outTextBox As TextBox
    Friend WithEvents DestinationTextBox As TextBox
    Friend WithEvents AddNew As Button
End Class
