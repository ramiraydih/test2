<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Itemplaces
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PlacesIDLabel As System.Windows.Forms.Label
        Dim PlacesNameLabel As System.Windows.Forms.Label
        Dim PlacesDateLabel As System.Windows.Forms.Label
        Dim PlacesTimeLabel As System.Windows.Forms.Label
        Dim PlacesUserLabel As System.Windows.Forms.Label
        Me.PlacesID = New System.Windows.Forms.TextBox()
        Me.PlacesName = New System.Windows.Forms.TextBox()
        Me.PlacesDate = New System.Windows.Forms.DateTimePicker()
        Me.PlacesTime = New System.Windows.Forms.DateTimePicker()
        Me.PlacesUser = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        PlacesIDLabel = New System.Windows.Forms.Label()
        PlacesNameLabel = New System.Windows.Forms.Label()
        PlacesDateLabel = New System.Windows.Forms.Label()
        PlacesTimeLabel = New System.Windows.Forms.Label()
        PlacesUserLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlacesIDLabel
        '
        PlacesIDLabel.AutoSize = True
        PlacesIDLabel.Location = New System.Drawing.Point(58, 80)
        PlacesIDLabel.Name = "PlacesIDLabel"
        PlacesIDLabel.Size = New System.Drawing.Size(55, 13)
        PlacesIDLabel.TabIndex = 1
        PlacesIDLabel.Text = "Places ID:"
        '
        'PlacesNameLabel
        '
        PlacesNameLabel.AutoSize = True
        PlacesNameLabel.Location = New System.Drawing.Point(42, 129)
        PlacesNameLabel.Name = "PlacesNameLabel"
        PlacesNameLabel.Size = New System.Drawing.Size(71, 13)
        PlacesNameLabel.TabIndex = 3
        PlacesNameLabel.Text = "Places Name:"
        '
        'PlacesDateLabel
        '
        PlacesDateLabel.AutoSize = True
        PlacesDateLabel.Location = New System.Drawing.Point(46, 167)
        PlacesDateLabel.Name = "PlacesDateLabel"
        PlacesDateLabel.Size = New System.Drawing.Size(67, 13)
        PlacesDateLabel.TabIndex = 5
        PlacesDateLabel.Text = "Places Date:"
        '
        'PlacesTimeLabel
        '
        PlacesTimeLabel.AutoSize = True
        PlacesTimeLabel.Location = New System.Drawing.Point(47, 212)
        PlacesTimeLabel.Name = "PlacesTimeLabel"
        PlacesTimeLabel.Size = New System.Drawing.Size(66, 13)
        PlacesTimeLabel.TabIndex = 7
        PlacesTimeLabel.Text = "Places Time:"
        '
        'PlacesUserLabel
        '
        PlacesUserLabel.AutoSize = True
        PlacesUserLabel.Location = New System.Drawing.Point(47, 248)
        PlacesUserLabel.Name = "PlacesUserLabel"
        PlacesUserLabel.Size = New System.Drawing.Size(66, 13)
        PlacesUserLabel.TabIndex = 9
        PlacesUserLabel.Text = "Places User:"
        '
        'PlacesID
        '
        Me.PlacesID.Location = New System.Drawing.Point(119, 77)
        Me.PlacesID.Name = "PlacesID"
        Me.PlacesID.Size = New System.Drawing.Size(132, 20)
        Me.PlacesID.TabIndex = 2
        '
        'PlacesName
        '
        Me.PlacesName.Location = New System.Drawing.Point(119, 126)
        Me.PlacesName.Name = "PlacesName"
        Me.PlacesName.Size = New System.Drawing.Size(132, 20)
        Me.PlacesName.TabIndex = 4
        '
        'PlacesDate
        '
        Me.PlacesDate.Location = New System.Drawing.Point(119, 163)
        Me.PlacesDate.Name = "PlacesDate"
        Me.PlacesDate.Size = New System.Drawing.Size(132, 20)
        Me.PlacesDate.TabIndex = 6
        '
        'PlacesTime
        '
        Me.PlacesTime.Location = New System.Drawing.Point(119, 208)
        Me.PlacesTime.Name = "PlacesTime"
        Me.PlacesTime.Size = New System.Drawing.Size(132, 20)
        Me.PlacesTime.TabIndex = 8
        '
        'PlacesUser
        '
        Me.PlacesUser.Location = New System.Drawing.Point(119, 245)
        Me.PlacesUser.Name = "PlacesUser"
        Me.PlacesUser.Size = New System.Drawing.Size(132, 20)
        Me.PlacesUser.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(357, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(468, 204)
        Me.DataGridView1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(576, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(403, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "الغاء"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Itemplaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 427)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(PlacesUserLabel)
        Me.Controls.Add(Me.PlacesUser)
        Me.Controls.Add(PlacesTimeLabel)
        Me.Controls.Add(Me.PlacesTime)
        Me.Controls.Add(PlacesDateLabel)
        Me.Controls.Add(Me.PlacesDate)
        Me.Controls.Add(PlacesNameLabel)
        Me.Controls.Add(Me.PlacesName)
        Me.Controls.Add(PlacesIDLabel)
        Me.Controls.Add(Me.PlacesID)
        Me.Name = "Itemplaces"
        Me.Text = "Itemplaces"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlacesID As System.Windows.Forms.TextBox
    Friend WithEvents PlacesName As System.Windows.Forms.TextBox
    Friend WithEvents PlacesDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PlacesTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents PlacesUser As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
