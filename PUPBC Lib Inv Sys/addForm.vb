Imports System.Data
Imports System.Data.SqlClient

Public Class addForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
        Dim cmd As New SqlCommand("insertbooks", conn)
        If (tBox.Text.Equals("")) Then
            MessageBox.Show("Enter Book title", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (aBox.Text.Equals("")) Then
            MessageBox.Show("Enter Book author", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (dpBox.Text.Equals("")) Then
            MessageBox.Show("Enter Date Published", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (qBox.Text.Equals("")) Then
            MessageBox.Show("Enter Book quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@BookID", idBox.Text)
            cmd.Parameters.AddWithValue("@bookTitle", tBox.Text)
            cmd.Parameters.AddWithValue("@bookAuthor", aBox.Text)
            cmd.Parameters.AddWithValue("@bookPublished", dpBox.Text)
            cmd.Parameters.AddWithValue("@bookQuantity", qBox.Text)
            cmd.Parameters.AddWithValue("@bookNote", nBox.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data inserted successfully", "Books Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tBox.Text = ""
            aBox.Text = ""
            dpBox.Text = ""
            qBox.Text = ""
            nBox.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dpBox_ValueChanged(sender As Object, e As EventArgs) Handles dpBox.ValueChanged
        If dpBox.Value.Date >= DateTime.Today.ToShortDateString Then
            MessageBox.Show("Enter Date Published", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
End Class