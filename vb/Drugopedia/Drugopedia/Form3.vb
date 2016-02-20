Public Class Form3

   

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Form6.Show()
        Form6.RichTextBox1.LoadFile("C:\Users\USER\Desktop\vb\ECSTASY.rtf", RichTextBoxStreamType.RichText)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form6.Show()
        Form6.RichTextBox1.LoadFile("C:\Users\USER\Desktop\vb\COCAINE.rtf", RichTextBoxStreamType.RichText)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form6.Show()
        Form6.RichTextBox1.LoadFile("C:\Users\USER\Desktop\vb\CRYSTAL METH.rtf", RichTextBoxStreamType.RichText)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Form6.Show()
        Form6.RichTextBox1.LoadFile("C:\Users\USER\Desktop\vb\phentermine.rtf", RichTextBoxStreamType.RichText)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form6.Show()
        Form6.RichTextBox1.LoadFile("C:\Users\USER\Desktop\vb\amphetamine.rtf", RichTextBoxStreamType.RichText)
    End Sub
End Class