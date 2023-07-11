Imports System.Data.SqlClient
Public Class updateFunc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
            Dim query As String = "UPDATE pupLibBooks SET book_title = @bookTitle, Book_author = @author, Date_published = @datePublished, quantity = @quantity, note = @note WHERE book_id = @bookId"

            Using command As New SqlCommand(query, conn)
                command.Parameters.AddWithValue("@bookId", idBox.Text)
                command.Parameters.AddWithValue("@bookTitle", tBox.Text)
                command.Parameters.AddWithValue("@author", aBox.Text)
                command.Parameters.AddWithValue("@datePublished", dpBox.Text)
                command.Parameters.AddWithValue("@quantity", qBox.Text)
                command.Parameters.AddWithValue("@note", nBox.Text)
                Try
                    conn.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Book successfully updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    idBox.Text = ""
                    tBox.Text = ""
                    aBox.Text = ""
                    dpBox.Text = ""
                    qBox.Text = ""
                    nBox.Text = ""
                Catch ex As Exception
                    MessageBox.Show("Error updating book: " & ex.Message)
                Finally
                    conn.Close()
                End Try

            End Using
        End Using

    End Sub
End Class