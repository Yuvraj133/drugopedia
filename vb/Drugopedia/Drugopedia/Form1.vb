Imports System.Data.OleDb
Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub


   

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim cn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\vb\Drugopedia\Drugopedia\my_database.accdb"
        Dim myconnection = New OleDbConnection(cn)
        myconnection.Open()

        Dim Uname As String = TextBox1.Text
        Dim pas As String = TextBox2.Text
        Dim q1 As String = "SELECT * FROM db1 WHERE username=@Uname AND password=@pas "
        Dim cmd As New OleDbCommand(q1, myconnection)
        cmd.Parameters.AddWithValue("@Uname", Uname)
        cmd.Parameters.AddWithValue("@pas", pas)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        Dim name1 As String = ""
        Dim pass1 As String = ""

        While dr.Read
            name1 = dr("username").ToString
            pass1 = dr("password").ToString
        End While
        If dr.HasRows Then
            Me.Hide()
            Form2.Show()
            Form2.Label1.Text = "Welcome " & name1

        Else
            Dim q2 As String = "INSERT INTO db1([username],[password]) VALUES(@Uname,@pas)"
            Dim cmd1 As New OleDbCommand(q2, myconnection)
            cmd1.Parameters.AddWithValue("@Uname", Uname)
            cmd1.Parameters.AddWithValue("@pas", pas)
            cmd1.ExecuteNonQuery()
            MessageBox.Show("You have been successfully registered, please login to continue")

        End If
        cmd.Connection.Close()

        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
