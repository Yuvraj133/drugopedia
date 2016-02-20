Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form4.Show()
        Form4.Label1.Text = "Welcome "
        Form4.RichTextBox1.LoadFile("C:\Users\USER\Desktop\vb\Depressants.rtf", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form5.Show()
        Form5.Label1.Text = "Welcome "
        Form5.RichTextBox1.LoadFile("C:\Users\USER\Desktop\vb\Hallucinogens.rtf", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Form3.Show()
        Form3.Label1.Text = "Welcome "
        Form3.RichTextBox1.LoadFile("C:\Users\USER\Desktop\vb\stimulants.rtf", RichTextBoxStreamType.PlainText)


    End Sub
End Class