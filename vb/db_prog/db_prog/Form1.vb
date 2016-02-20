Imports System.Data.OleDb
Public Class Form1
    Dim dbcon = New OleDbConnection("provider = Microsoft.ACE.OLEDB.12.0;Data Source= my_db.accdb")

    Dim dbcmd = New OleDbCommand
    Dim recordcount As Integer

   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'My_dbDataSet1.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.My_dbDataSet1.student)
        Dim query As String = "select * from student"
        dbcon.Open()
        dbcmd = New OleDbCommand(query, dbcon)
        Dim dbdt = New DataTable
        Dim dbda As New OleDbDataAdapter(dbcmd)
        recordcount = dbda.Fill(dbdt)
        DataGridView1.DataSource = dbdt
        For Each r As DataColumn In dbdt.Columns
            combobox1.items.Add(r.ToString)
            ComboBox1.Items.Add("name")
            combobox1.items.Add("Register no.")
            combobox1.items.Add("semester")
        Next r


    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dbcon.open()
        Dim query As String = "INSERT INTO student"
        Dim id As Integer = CInt(TextBox1.Text)

        Dim sn As String = TextBox3.Text
        Dim regno As String = TextBox4.Text
        Dim sem As String = TextBox5.Text
        Dim cr As String = TextBox6.Text
        Using dbcmd = New OleDbCommand(query, dbcon)
            ''dbcad.Parameter.AddThisValue("s",Cint(TextBox1.Text))
            ''dbcad.Parameters.AddthisValue("?",TextBox3.Text)
            ''dbcad.Parameters.AddthisValue("?",TextBox   

        End Using
    End Sub
End Class
