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


        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)
        rad.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(btnRound.Width, 20, btn.Width, btn.Height - 10)
        rad.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        btnRound.Region = New Region(rad)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCornerButton(btnRound)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles logPanel.Paint

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
    End Sub
End Class