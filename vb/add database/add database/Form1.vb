Imports System.Data.OleDb
Public Class Form1
    Dim connectionString As String = "provider = Microsoft.ACE.OLEDB.12.0; DataSource = MYDATA1.accdb"
    'connect to the database using the connection string



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbcon = New OleDbConnection(connectionString)
        dbcon.Open()
        Dim query As String = "INSERT INTO MYDATA1_details([MYDATA1_ID],[MYDATA1_Name],[MYDATA1_Price])Values(?,?,?)"
        Using dbcmd = New OleDbCommand(query, dbcon)
            dbcmd.Parameters.AddWithValue("?", CInt(TextBox1.Text))
            dbcmd.Parameters.AddWithValue("?", TextBox2.Text)
            dbcmd.Parameters.AddWithValue("?", CInt(TextBox3.Text))
            dbcmd.ExecuteNonQuery()


        End Using
        MsgBox("record is saved")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        dbcon.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dbcon = New OleDbConnection(connectionString)
        dbcon.Open()
        Dim query As String = "SELECT * FROM product_details"
        Dim dbcmd = New OleDbCommand(query, dbcon)
        Dim dba As New OleDbDataAdapter(dbcmd)
        Dim drows As Integer
        Dim dt As New DataTable
        drows = dba.Fill(dt)
        DataGridView1.DataSource = dt
        dbcon.Close()
    End Sub

End Class
