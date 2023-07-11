Imports System.Data.SqlClient
Public Class borrowButtonFunc
    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
    Dim conn As New SqlConnection(connectionString)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bookID As Integer = Integer.Parse(bID.Text)
        Dim studentID As String = sID.Text
        Dim studentName As String = sName.Text
        Dim cnYear As String = Integer.Parse(cnYeartxt.Text)
        Dim borrowDate As DateTime = DateTime.Now
        Dim dueDate As DateTime = borrowDate.AddDays(3)

        ' Check if the book exists in the book database
        If IsBookAvailable(connectionString, bookID) Then
            ' Book is available, proceed with borrowing

            ' Perform the insert operation into the borrow table
            InsertBorrowRecord(connectionString, studentID, studentName, cnYear, bookID, borrowDate, dueDate)

            ' Display a success message
            MessageBox.Show("Book has been borrowed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Book is not available
            MessageBox.Show("Book not available.")
        End If
    End Sub

    Private Function IsBookAvailable(connectionString As String, bookID As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM pupLibBooks WHERE Book_ID = @BookID"
        Dim isAvailable As Boolean = False

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@BookID", bookID)
                connection.Open()
                Dim count As Integer = CInt(command.ExecuteScalar())
                isAvailable = count > 0
            End Using
        End Using

        Return isAvailable
    End Function

    Private Sub InsertBorrowRecord(connectionString As String, studentID As Integer, studentName As String, cnYear As Integer, bookID As Integer, borrowDate As DateTime, dueDate As DateTime)
        Dim query As String = "INSERT INTO pupLibBorrow (studentID, studentName, cnYear, Book_ID, BorrowDate, DueDate) VALUES (@StudentID, @StudentName, @CNYear, @BookID, @BorrowDate, @DueDate)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@StudentID", studentID)
                command.Parameters.AddWithValue("@StudentName", studentName)
                command.Parameters.AddWithValue("@CNYear", cnYear)
                command.Parameters.AddWithValue("@BookID", bookID)
                command.Parameters.AddWithValue("@BorrowDate", SqlDbType.Date).Value = borrowDate
                command.Parameters.AddWithValue("@DueDate", SqlDbType.Date).Value = dueDate
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class