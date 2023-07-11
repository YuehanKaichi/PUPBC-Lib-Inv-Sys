Imports System.Data.SqlClient
Public Class deleteFunc
    Private Sub DeleteBook(ByVal bookId As Integer)
        Dim delquery As String = "DELETE from pupLibBooks where Book_ID = @bookid"

        Using connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
            Using command As New SqlCommand(delquery, connection)
                command.Parameters.AddWithValue("@BookID", bookId)
                Try
                    ' Show a dialog message
                    Dim mesresult As DialogResult = MessageBox.Show("Are you sure to delete this book?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If mesresult = DialogResult.Yes Then
                        ' Open the database connection
                        connection.Open()

                        ' Execute the delete command
                        command.ExecuteNonQuery()

                        'show success message
                        MessageBox.Show("Book deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Catch ex As Exception
                    ' Show an error message
                    MessageBox.Show("Error deleting book: " & ex.Message)

                Finally
                    ' Close the database connection
                    connection.Close()
                End Try

            End Using
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Prompt the user for the book ID to delete
        Dim bookId As Integer
        If Integer.TryParse(idBox.Text, bookId) Then
            ' Call the delete function with the book ID
            DeleteBook(bookId)
            idBox.Text = ""
        Else
            MessageBox.Show("Invalid Book ID.")
            idBox.Text = ""
        End If
    End Sub
End Class