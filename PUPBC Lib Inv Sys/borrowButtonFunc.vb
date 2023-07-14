Imports System.Data.SqlClient
Public Class borrowButtonFunc
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentID As String = sID.Text
        Dim studentName As String = sName.Text
        Dim courseAndYear As String = cnYeartxt.Text
        Dim bookID As String = bID.Text
        Dim borrowDate As DateTime = DateTime.Now
        Dim dueDate As DateTime = borrowDate.AddDays(3)

        Dim bookExists As Boolean = False
        Dim bookAvailable As Boolean = False

        Using connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
            connection.Open()

            Dim checkBookQuery As String = "SELECT * FROM pupLibBooks WHERE book_ID = @bookID AND avail = 'available'"
            Using command As New SqlCommand(checkBookQuery, connection)
                command.Parameters.AddWithValue("@bookID", bookID)
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    bookExists = True
                    bookAvailable = True
                End If
            End Using

            connection.Close()
        End Using

        If bookExists AndAlso bookAvailable Then
            Using connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
                connection.Open()

                Dim insertQuery As String = "INSERT INTO pupLibBorrow (studentID, studentName, cnYear, book_ID, borrowDate, dueDate) VALUES (@studentID, @studentName, @courseAndYear, @bookID, @borrowDate, @dueDate)"
                Using command As New SqlCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@studentID", studentID)
                    command.Parameters.AddWithValue("@studentName", studentName)
                    command.Parameters.AddWithValue("@courseAndYear", courseAndYear)
                    command.Parameters.AddWithValue("@bookID", bookID)
                    command.Parameters.AddWithValue("@borrowDate", borrowDate)
                    command.Parameters.AddWithValue("@dueDate", dueDate)
                    command.ExecuteNonQuery()
                End Using

                connection.Close()
            End Using

            ' Update the pupLibBooks table to mark the book as borrowed
            Using connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
                connection.Open()

                Dim updateQuery As String = "UPDATE pupLibBooks SET avail = 'borrowed' WHERE book_ID = @bookID"
                Using command As New SqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@bookID", bookID)
                    command.ExecuteNonQuery()
                End Using

                connection.Close()
            End Using

            MessageBox.Show("Book borrowed successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The book is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub


End Class