Imports System.Data.SqlClient
Public Class deleteFunc


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Function BookExists(bookID As String) As Boolean
        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM pupLibBooks WHERE book_ID = @BookID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@BookID", bookID)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bookIDToDelete As String = idBox.Text

        If BookExists(bookIDToDelete) Then
            Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
            Try
                ' SQL statements
                Dim deleteQuery As String = "DELETE FROM pupLibBooks WHERE Book_ID = @BookID"

                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    'dialog
                    Dim mesresultt As DialogResult = MessageBox.Show("Are you sure to delete this book?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If mesresultt = DialogResult.Yes Then
                        ' Delete the row from pupLibBorrow table
                        Using deleteCommand As New SqlCommand(deleteQuery, connection)
                            deleteCommand.Parameters.AddWithValue("@BookID", idBox.Text)
                            deleteCommand.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Book successfully deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        'refresh table
                        Dim table As New DataTable()
                        Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', note as 'note', avail as 'Availability' FROM pupLibBooks ORDER BY book_id ASC", connection)
                        adapter.Fill(table)

                        hbtnForm.dt1.DataSource = table

                        'count number of books
                        Dim cmd1 As New SqlCommand("Select count(*) from pupLibBooks", connection)
                        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
                        hbtnForm.numBooks.Text = count1 + " Books"
                        idBox.Text = ""
                    End If
                End Using




            Catch ex As Exception
                MessageBox.Show("Error Deleting Books" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' The book doesn't exist, show an error message.
            MessageBox.Show("Book not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class