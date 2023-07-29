Imports System.Data.SqlClient
Public Class returnButtonFunc

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles conButton.Click
        Dim bookIDToReturn As String = idBox.Text

        If BookExists(bookIDToReturn) Then
            Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
            Try
                ' SQL statements
                Dim deleteQuery As String = "DELETE FROM pupLibBorrow WHERE Book_ID = @BookID"
                Dim updateQuery As String = "UPDATE pupLibBooks SET Avail = 'Available' WHERE Book_ID = @BookIDUpdate"

                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Delete the row from pupLibBorrow table
                    Using deleteCommand As New SqlCommand(deleteQuery, connection)
                        deleteCommand.Parameters.AddWithValue("@BookID", idBox.Text)
                        deleteCommand.ExecuteNonQuery()
                    End Using

                    ' Update the Avail column in pupLibBooks table
                    Using updateCommand As New SqlCommand(updateQuery, connection)
                        updateCommand.Parameters.AddWithValue("@BookIDUpdate", idBox.Text)
                        updateCommand.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Book has been returned", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    idBox.Text = ""

                    'refresh the table
                    Dim table As New DataTable()
                    Dim adapter As New SqlDataAdapter("SELECT pupLibBorrow.studentID as 'Student ID', pupLibBorrow.studentName as 'Student Name',
        pupLibBorrow.cnYear as 'Course and Year', pupLibBorrow.Book_ID as 'Book ID', 
        pupLibBooks.Book_title as 'Book Title', 
        pupLibBorrow.borrowDate as 'Date Borrowed', pupLibBorrow.DueDate as 'Date to be returned' 
        FROM pupLibBorrow
        JOIN pupLibBooks ON pupLibBorrow.Book_ID = pupLibBooks.Book_ID;", connection)
                    adapter.Fill(table)

                    Borrow.dt1.DataSource = table
                    connection.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Invalid input: " + ex.Message)
            End Try

        Else
            ' The book doesn't exist, show an error message.
            MessageBox.Show("Book not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub returnButtonFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class