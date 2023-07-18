Imports System.Drawing.Imaging
Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Dim constr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Private Sub RoundCornerButton(btn As Button)

        btn.FlatAppearance.BorderSize = 0
        btn.FlatStyle = FlatStyle.Flat
        btn.BackColor = Color.Yellow


    End Sub
    Private Sub RoundCornerButton2(btnn As Button)

        btnn.FlatAppearance.BorderSize = 0
        btnn.FlatStyle = FlatStyle.Flat
        btnn.BackColor = Color.Yellow


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundCornerButton(btnRound)
        RoundCornerButton(extbtn)
    End Sub

    Private Sub btnRound_Click(sender As Object, e As EventArgs) Handles btnRound.Click
        Try
            Using con As New SqlConnection(constr)
                con.Open()
                Dim sql As String = "select username, password from bookAdmin where username = @username AND password = @password"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("username", unText.Text)
                cmd.Parameters.AddWithValue("password", pwText.Text)
                adapter = New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)
                If (ds.Tables(0).Rows.Count > 0) Then
                    MessageBox.Show("Welcome Admin", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dBoard.Show()
         
                    Me.Hide()
                Else
                        MessageBox.Show("Wrong Credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                Dim strsql As String
                strsql = "Select id, fname, mname, sname, username, password, email from bookAdmin"

                Dim cmd2 As New SqlCommand(strsql, con)
                Dim myreader As SqlDataReader
                myreader = cmd2.ExecuteReader

                myreader.Read()
                'NOTE!!!  try to put it inside the condition to work
                profForm.fnameBox.Text = myreader("fname")
                profForm.mnamebox.Text = myreader("mname")
                profForm.lnamebox.Text = myreader("sname")
                profForm.emailBox.Text = myreader("email")
                profForm.usnBox.Text = myreader("username")
                dBoard.Label2.Text = myreader("fname")
                dBoard.Label3.Text = myreader("id")


                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles extbtn.Click
        Form1.Close()
    End Sub


End Class