Imports System.Data.SqlClient
Public Class returnButtonFunc
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles conButton.Click
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
                MessageBox.Show("Book has been returned")
                idBox.Text = ""
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Invalid input: " + ex.Message)
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class