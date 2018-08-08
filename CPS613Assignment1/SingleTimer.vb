Public Class SingleTimer

    Public Shared SelectedTimer As SingleTimer

    Private _Title As String
    Private _AlarmFrequency As Integer
    Private _AlarmDuration As Integer
    Public Property Title As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

    Public Property AlarmFrequency As Integer
        Get
            Return _AlarmFrequency
        End Get
        Set(ByVal value As Integer)
            _AlarmFrequency = value
        End Set
    End Property

    Public Property AlarmDuration As Integer
        Get
            Return _AlarmDuration
        End Get
        Set(ByVal value As Integer)
            _AlarmDuration = value
        End Set
    End Property

    Public Sub SelectTimer()
        BackColor = Color.DimGray
        RadioButton1.Checked = True
    End Sub

    Public Sub deSelectTimer()
        BackColor = Color.DarkGray
        RadioButton1.Checked = False

    End Sub

    Private Sub SingleTimer_Click(sender As Object, ByVal e As EventArgs) Handles Me.Click
        SelectedTimer = sender
        sender.SelectTimer()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        disableButton(StartButton)
        disableButton(ClearButton)
        MinCounter.ForeColor = Color.LawnGreen
        SecCounter.ForeColor = Color.LawnGreen
        Timer.Start()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        enableButton(StartButton)
        enableButton(ClearButton)
        MinCounter.ForeColor = Color.Black
        SecCounter.ForeColor = Color.Black
        Timer.Stop()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        MinCounter.ForeColor = Color.Black
        SecCounter.ForeColor = Color.Black
        MinCounter.reset()
        SecCounter.reset()
        Timer.Stop()
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If SecCounter.isZero() And MinCounter.isZero() Then

            If MinCounter.ForeColor = Color.DarkGray Then
                MinCounter.ForeColor = Color.Red
                SecCounter.ForeColor = Color.Red
            ElseIf MinCounter.ForeColor = Color.Red Then
                MinCounter.ForeColor = Color.DarkGray
                SecCounter.ForeColor = Color.DarkGray
            Else
                MinCounter.ForeColor = Color.Red
                SecCounter.ForeColor = Color.Red
            End If
            Console.Beep(AlarmFrequency, AlarmDuration)
        ElseIf SecCounter.isZero() Then
            SecCounter.increaseBy(59)
            MinCounter.increaseBy(-1)
        Else SecCounter.decrement()
        End If
    End Sub

    Public Sub AddSecondsToSelected(extraSecs As Integer)
        SecCounter.increaseBy(extraSecs)
        If MinCounter.Text < 99 Then
            If SecCounter.Text > 59 Then
                SecCounter.increaseBy(-60)
                MinCounter.increaseBy(1)
            End If
        Else
            If SecCounter.Text > 59 Then
                SecCounter.setValue(59)
            End If
        End If
    End Sub

    Public Sub AddMinutesToSelected(extraMin As Integer)
        MinCounter.increaseBy(extraMin)
        If MinCounter.Text > 99 Then
            MinCounter.setToMax()
            SecCounter.setValue(59)
        End If
    End Sub

    Public Sub enableButton(button As Button)
        button.Enabled = True
        button.ForeColor = Color.Black
    End Sub

    Public Sub disableButton(button As Button)
        button.Enabled = False
        button.ForeColor = Color.LightGray
    End Sub
End Class
