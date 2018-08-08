Public Class SecondsCounter
    Inherits Counter

    Public Shadows maxValue As Integer = 59
    Public Sub decrement()
        value -= 1
        value.ToString("00")
        Text = String.Format("{0:00}", value)
    End Sub

    Public Sub increaseBy(increment As Integer)
        value += increment
        value.ToString("00")
        Text = String.Format("{0:00}", value)
    End Sub

    Public Sub setMinutesCounter(newcounter As MinutesCounter)

    End Sub
End Class
