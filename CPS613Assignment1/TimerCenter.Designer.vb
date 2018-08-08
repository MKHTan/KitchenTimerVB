<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimerCenter
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
        Me.Second1 = New System.Windows.Forms.Button()
        Me.Seconds3 = New System.Windows.Forms.Button()
        Me.Seconds10 = New System.Windows.Forms.Button()
        Me.Minutes10 = New System.Windows.Forms.Button()
        Me.Minutes3 = New System.Windows.Forms.Button()
        Me.Minute1 = New System.Windows.Forms.Button()
        Me.SingleTimer4 = New CPS613Assignment1.SingleTimer()
        Me.SingleTimer3 = New CPS613Assignment1.SingleTimer()
        Me.SingleTimer2 = New CPS613Assignment1.SingleTimer()
        Me.SingleTimer1 = New CPS613Assignment1.SingleTimer()
        Me.SuspendLayout()
        '
        'Second1
        '
        Me.Second1.Location = New System.Drawing.Point(304, 201)
        Me.Second1.Name = "Second1"
        Me.Second1.Size = New System.Drawing.Size(75, 23)
        Me.Second1.TabIndex = 0
        Me.Second1.Text = "1 Second"
        Me.Second1.UseVisualStyleBackColor = True
        '
        'Seconds3
        '
        Me.Seconds3.Location = New System.Drawing.Point(385, 201)
        Me.Seconds3.Name = "Seconds3"
        Me.Seconds3.Size = New System.Drawing.Size(75, 23)
        Me.Seconds3.TabIndex = 1
        Me.Seconds3.Text = "3 Seconds"
        Me.Seconds3.UseVisualStyleBackColor = True
        '
        'Seconds10
        '
        Me.Seconds10.Location = New System.Drawing.Point(466, 201)
        Me.Seconds10.Name = "Seconds10"
        Me.Seconds10.Size = New System.Drawing.Size(75, 23)
        Me.Seconds10.TabIndex = 2
        Me.Seconds10.Text = "10 Seconds"
        Me.Seconds10.UseVisualStyleBackColor = True
        '
        'Minutes10
        '
        Me.Minutes10.Location = New System.Drawing.Point(466, 230)
        Me.Minutes10.Name = "Minutes10"
        Me.Minutes10.Size = New System.Drawing.Size(75, 23)
        Me.Minutes10.TabIndex = 5
        Me.Minutes10.Text = "10 Minutes"
        Me.Minutes10.UseVisualStyleBackColor = True
        '
        'Minutes3
        '
        Me.Minutes3.Location = New System.Drawing.Point(385, 230)
        Me.Minutes3.Name = "Minutes3"
        Me.Minutes3.Size = New System.Drawing.Size(75, 23)
        Me.Minutes3.TabIndex = 4
        Me.Minutes3.Text = "3 Minutes"
        Me.Minutes3.UseVisualStyleBackColor = True
        '
        'Minute1
        '
        Me.Minute1.Location = New System.Drawing.Point(304, 230)
        Me.Minute1.Name = "Minute1"
        Me.Minute1.Size = New System.Drawing.Size(75, 23)
        Me.Minute1.TabIndex = 3
        Me.Minute1.Text = "1 Minute"
        Me.Minute1.UseVisualStyleBackColor = True
        '
        'SingleTimer4
        '
        Me.SingleTimer4.AlarmDuration = 150
        Me.SingleTimer4.AlarmFrequency = 1750
        Me.SingleTimer4.BackColor = System.Drawing.Color.DarkGray
        Me.SingleTimer4.Location = New System.Drawing.Point(586, 269)
        Me.SingleTimer4.Name = "SingleTimer4"
        Me.SingleTimer4.Size = New System.Drawing.Size(264, 212)
        Me.SingleTimer4.TabIndex = 9
        Me.SingleTimer4.Title = "BottomRight"
        '
        'SingleTimer3
        '
        Me.SingleTimer3.AlarmDuration = 250
        Me.SingleTimer3.AlarmFrequency = 1200
        Me.SingleTimer3.BackColor = System.Drawing.Color.DarkGray
        Me.SingleTimer3.Location = New System.Drawing.Point(12, 269)
        Me.SingleTimer3.Name = "SingleTimer3"
        Me.SingleTimer3.Size = New System.Drawing.Size(264, 212)
        Me.SingleTimer3.TabIndex = 8
        Me.SingleTimer3.Title = "BottomLeft"
        '
        'SingleTimer2
        '
        Me.SingleTimer2.AlarmDuration = 200
        Me.SingleTimer2.AlarmFrequency = 500
        Me.SingleTimer2.BackColor = System.Drawing.Color.DimGray
        Me.SingleTimer2.Location = New System.Drawing.Point(586, 12)
        Me.SingleTimer2.Name = "SingleTimer2"
        Me.SingleTimer2.Size = New System.Drawing.Size(264, 212)
        Me.SingleTimer2.TabIndex = 7
        Me.SingleTimer2.Title = "TopRight"
        '
        'SingleTimer1
        '
        Me.SingleTimer1.AlarmDuration = 200
        Me.SingleTimer1.AlarmFrequency = 200
        Me.SingleTimer1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.SingleTimer1.BackColor = System.Drawing.Color.DarkGray
        Me.SingleTimer1.Location = New System.Drawing.Point(12, 12)
        Me.SingleTimer1.Name = "SingleTimer1"
        Me.SingleTimer1.Size = New System.Drawing.Size(264, 212)
        Me.SingleTimer1.TabIndex = 6
        Me.SingleTimer1.Title = "TopLeft"
        '
        'TimerCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(862, 493)
        Me.Controls.Add(Me.SingleTimer4)
        Me.Controls.Add(Me.SingleTimer3)
        Me.Controls.Add(Me.SingleTimer2)
        Me.Controls.Add(Me.SingleTimer1)
        Me.Controls.Add(Me.Minutes10)
        Me.Controls.Add(Me.Minutes3)
        Me.Controls.Add(Me.Minute1)
        Me.Controls.Add(Me.Seconds10)
        Me.Controls.Add(Me.Seconds3)
        Me.Controls.Add(Me.Second1)
        Me.Name = "TimerCenter"
        Me.Text = "Kitchen Timer - Matthew Koa Hea Tan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Second1 As Button
    Friend WithEvents Seconds3 As Button
    Friend WithEvents Seconds10 As Button
    Friend WithEvents Minutes10 As Button
    Friend WithEvents Minutes3 As Button
    Friend WithEvents Minute1 As Button
    Friend WithEvents SingleTimer1 As SingleTimer
    Friend WithEvents SingleTimer2 As SingleTimer
    Friend WithEvents SingleTimer3 As SingleTimer
    Friend WithEvents SingleTimer4 As SingleTimer
End Class
