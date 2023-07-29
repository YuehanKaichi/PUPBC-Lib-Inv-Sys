Imports System.Data.SqlClient
Public Class updateConf
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
        Dim bookIDToUpdate As String = idBox.Text

        If BookExists(bookIDToUpdate) Then
            updateFunc.Show()
            Me.Hide()

            ' Assuming you have a TextBox named "idboxId" to enter the book ID
            Dim bookId As String = idBox.Text

            ' Call the function to populate the text boxes with data for the given book ID
            updateFunc.LoadDataIntoTextBoxes(bookId)
        Else
            ' The book doesn't exist, show an error message.
            MessageBox.Show("Book not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class