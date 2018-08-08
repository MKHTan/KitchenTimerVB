Public Class TimerCenter
    Private Sub Seconds_Click(sender As Object, e As EventArgs) Handles Second1.Click, Seconds3.Click, Seconds10.Click
        If SingleTimer1.RadioButton1.Checked = True Then
            If sender Is Second1 Then
                SingleTimer1.AddSecondsToSelected(1)
            ElseIf sender Is Seconds3 Then
                SingleTimer1.AddSecondsToSelected(3)
            ElseIf sender Is Seconds10 Then
                SingleTimer1.AddSecondsToSelected(10)
            End If
        ElseIf SingleTimer2.RadioButton1.Checked = True Then
            If sender Is Second1 Then
                SingleTimer2.AddSecondsToSelected(1)
            ElseIf sender Is Seconds3 Then
                SingleTimer2.AddSecondsToSelected(3)
            ElseIf sender Is Seconds10 Then
                SingleTimer2.AddSecondsToSelected(10)
            End If
        ElseIf SingleTimer3.RadioButton1.Checked = True Then
            If sender Is Second1 Then
                SingleTimer3.AddSecondsToSelected(1)
            ElseIf sender Is Seconds3 Then
                SingleTimer3.AddSecondsToSelected(3)
            ElseIf sender Is Seconds10 Then
                SingleTimer3.AddSecondsToSelected(10)
            End If
        ElseIf SingleTimer4.RadioButton1.Checked = True Then
            If sender Is Second1 Then
                SingleTimer4.AddSecondsToSelected(1)
            ElseIf sender Is Seconds3 Then
                SingleTimer4.AddSecondsToSelected(3)
            ElseIf sender Is Seconds10 Then
                SingleTimer4.AddSecondsToSelected(10)
            End If
        End If
    End Sub
    Private Sub Minutes_Click(sender As Object, e As EventArgs) Handles Minute1.Click, Minutes3.Click, Minutes10.Click
        If SingleTimer1.RadioButton1.Checked = True Then
            If sender Is Minute1 Then
                SingleTimer1.AddMinutesToSelected(1)
            ElseIf sender Is Minutes3 Then
                SingleTimer1.AddMinutesToSelected(3)
            ElseIf sender Is Minutes10 Then
                SingleTimer1.AddMinutesToSelected(10)
            End If
        ElseIf SingleTimer2.RadioButton1.Checked = True Then
            If sender Is Minute1 Then
                SingleTimer2.AddMinutesToSelected(1)
            ElseIf sender Is Minutes3 Then
                SingleTimer2.AddMinutesToSelected(3)
            ElseIf sender Is Minutes10 Then
                SingleTimer2.AddMinutesToSelected(10)
            End If
        ElseIf SingleTimer3.RadioButton1.Checked = True Then
            If sender Is Minute1 Then
                SingleTimer3.AddMinutesToSelected(1)
            ElseIf sender Is Minutes3 Then
                SingleTimer3.AddMinutesToSelected(3)
            ElseIf sender Is Minutes10 Then
                SingleTimer3.AddMinutesToSelected(10)
            End If
        ElseIf SingleTimer4.RadioButton1.Checked = True Then
            If sender Is Minute1 Then
                SingleTimer4.AddMinutesToSelected(1)
            ElseIf sender Is Minutes3 Then
                SingleTimer4.AddMinutesToSelected(3)
            ElseIf sender Is Minutes10 Then
                SingleTimer4.AddMinutesToSelected(10)
            End If
        End If
    End Sub

    Private Sub TimerCenter_Click(sender As Object, e As MouseEventArgs) Handles Me.Click
        SingleTimer1.deSelectTimer()
        SingleTimer2.deSelectTimer()
        SingleTimer3.deSelectTimer()
        SingleTimer4.deSelectTimer()
    End Sub

    Private Sub SingleTimer1_Click(sender As Object, e As EventArgs) Handles SingleTimer1.Click
        SingleTimer2.deSelectTimer()
        SingleTimer3.deSelectTimer()
        SingleTimer4.deSelectTimer()
    End Sub

    Private Sub SingleTimer2_Click(sender As Object, e As EventArgs) Handles SingleTimer2.Click
        SingleTimer1.deSelectTimer()
        SingleTimer3.deSelectTimer()
        SingleTimer4.deSelectTimer()
    End Sub

    Private Sub SingleTimer3_Click(sender As Object, e As EventArgs) Handles SingleTimer3.Click
        SingleTimer1.deSelectTimer()
        SingleTimer2.deSelectTimer()
        SingleTimer4.deSelectTimer()
    End Sub

    Private Sub SingleTimer4_Click(sender As Object, e As EventArgs) Handles SingleTimer4.Click
        SingleTimer1.deSelectTimer()
        SingleTimer2.deSelectTimer()
        SingleTimer3.deSelectTimer()
    End Sub
End Class