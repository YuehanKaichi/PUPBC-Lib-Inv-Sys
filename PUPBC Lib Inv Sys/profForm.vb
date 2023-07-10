Imports System.Data.SqlClient
Public Class profForm
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cpwbtn.Click
        cpassForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles edtbtn.Click
        If edtbtn.Text = "Save" Then
            Using conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
                Dim query As String = "update bookAdmin SET fname = @firstN, mname = @midN, sname = @lastN, username = @usname, email = @eMail"

                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@firstN", fnameBox.Text)
                    command.Parameters.AddWithValue("@midN", mnamebox.Text)
                    command.Parameters.AddWithValue("@lastN", lnamebox.Text)
                    command.Parameters.AddWithValue("@usname", usnBox.Text)
                    command.Parameters.AddWithValue("@eMail", emailBox.Text)

                    conn.Open()
                    command.ExecuteNonQuery()
                    Dim strsql As String
                    strsql = "Select id, fname, mname, sname, username, password, email from bookAdmin"
                    Dim cmd2 As New SqlCommand(strsql, conn)
                    Dim myreader As SqlDataReader
                    myreader = cmd2.ExecuteReader
                    myreader.Read()
                    dBoard.Label2.Text = myreader("fname")
                End Using
            End Using

            fnameBox.Enabled = False
            mnamebox.Enabled = False
            lnamebox.Enabled = False
            emailBox.Enabled = False
            usnBox.Enabled = False

            edtbtn.Text = "Edit Profile"
            cpwbtn.Visible = False

            MessageBox.Show("Successfuly updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            fnameBox.Enabled = True
            mnamebox.Enabled = True
            lnamebox.Enabled = True
            emailBox.Enabled = True
            usnBox.Enabled = True

            edtbtn.Text = "Save"
            cpwbtn.Visible = True

        End If
    End Sub
End Class