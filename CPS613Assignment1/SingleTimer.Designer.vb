<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Colon = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SecCounter = New CPS613Assignment1.SecondsCounter()
        Me.MinCounter = New CPS613Assignment1.MinutesCounter()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoCheck = False
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(128, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Colon
        '
        Me.Colon.AutoSize = True
        Me.Colon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon.Location = New System.Drawing.Point(123, 80)
        Me.Colon.Name = "Colon"
        Me.Colon.Size = New System.Drawing.Size(18, 25)
        Me.Colon.TabIndex = 2
        Me.Colon.Text = ":"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 129)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 4
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(93, 129)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 5
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(174, 129)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'SecCounter
        '
        Me.SecCounter.AutoSize = True
        Me.SecCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecCounter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SecCounter.Location = New System.Drawing.Point(147, 80)
        Me.SecCounter.Name = "SecCounter"
        Me.SecCounter.Size = New System.Drawing.Size(36, 25)
        Me.SecCounter.TabIndex = 8
        Me.SecCounter.Text = "00"
        '
        'MinCounter
        '
        Me.MinCounter.AutoSize = True
        Me.MinCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinCounter.Location = New System.Drawing.Point(88, 80)
        Me.MinCounter.Name = "MinCounter"
        Me.MinCounter.Size = New System.Drawing.Size(36, 25)
        Me.MinCounter.TabIndex = 7
        Me.MinCounter.Text = "00"
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SecCounter)
        Me.Controls.Add(Me.MinCounter)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Colon)
        Me.Controls.Add(Me.RadioButton1)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(264, 212)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Colon As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents MinCounter As MinutesCounter
    Friend WithEvents SecCounter As SecondsCounter
    Friend WithEvents Timer As Timer
End Class
