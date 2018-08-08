Public MustInherit Class Counter
    Inherits Label

    Public value As Integer
    Public maxValue As Integer = 99


    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here

    End Sub

    Function isMax() As Boolean
        If value > maxValue Then
            Return True
        Else Return False
        End If
    End Function

    Function isZero() As Boolean
        If value = 0 Then
            Return True
        Else Return False
        End If
    End Function

    Public Sub reset()
        value = 0
        value.ToString("00")
        Text = String.Format("{0:00}", value)
    End Sub

    Public Sub setToMax()
        value = maxValue
        value.ToString("00")
        Text = String.Format("{0:00}", value)
    End Sub

    Public Sub setValue(newvalue As Integer)
        value = newvalue
        value.ToString("00")
        Text = String.Format("{0:00}", value)
    End Sub
End Class
