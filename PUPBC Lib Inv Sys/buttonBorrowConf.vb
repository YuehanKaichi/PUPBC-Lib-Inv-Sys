Imports System.Data.SqlClient
Public Class buttonBorrowConf
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
    Private Sub conButton_Click(sender As Object, e As EventArgs) Handles conButton.Click
        Dim bookIDToBorrow As String = idBox.Text

        If BookExists(bookIDToBorrow) Then
            borrowButtonFunc.Show()
            Me.Hide()
        Else
            ' The book doesn't exist, show an error message.
            MessageBox.Show("Book not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class