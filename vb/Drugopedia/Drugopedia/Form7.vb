Public Class form7
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Form1.Show()

        End If
    End Sub
End Class