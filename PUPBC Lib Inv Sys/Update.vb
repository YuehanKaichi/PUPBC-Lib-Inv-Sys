Imports System.Data.SqlClient
Public Class updateFunc

    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader

    Private Sub updateFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the connection
        connection = New SqlConnection(connectionString)
        connection.Open()
    End Sub

    Private Sub updateFunc_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close the connection when the form is closing
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Public Sub LoadDataIntoTextBoxes(bookId As String)
        Dim query As String = "SELECT book_id, book_title, book_author, date_published, note FROM pupLibBooks WHERE book_id = @BookId"

        ' Create and configure the command object
        command = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@BookId", bookId)

        ' Execute the query
        reader = command.ExecuteReader()

        ' Check if there are any rows returned
        If reader.HasRows Then
            reader.Read()

            ' Populate the text boxes with the corresponding column values
            idBox.Text = reader("book_id").ToString()
            tBox.Text = reader("book_title").ToString()
            aBox.Text = reader("book_author").ToString()
            dpBox.Text = reader("date_published").ToString()
            nBox.Text = reader("note").ToString()
        Else
            ' Handle the case when the book with the given ID is not found.
            ' For example, you can clear the text boxes or show an error message.
            idBox.Text = ""
            tBox.Text = ""
            aBox.Text = ""
            dpBox.Text = ""
            nBox.Text = ""
            MessageBox.Show("Book with ID " & bookId & " not found.")
        End If

        ' Close the reader after use
        reader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Update" Then
            Button2.Text = "Save"
            tBox.Enabled = True
            aBox.Enabled = True
            dpBox.Enabled = True
            nBox.Enabled = True

        Else
            ' Step 1: Get the year from the textbox.
            Dim inputYear As Integer
            If Integer.TryParse(dpBox.Text, inputYear) Then
                ' Step 2: Convert the year into a valid DateTime object.
                Dim inputDate As DateTime
                Try
                    inputDate = New DateTime(inputYear, 1, 1)

                    ' Step 3: Compare the DateTime object with the current date.
                    If inputDate <= DateTime.Today Then
                        Using conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
                            Dim query As String = "UPDATE pupLibBooks SET book_title = @bookTitle, Book_author = @author, Date_published = @datePublished, note = @note WHERE book_id = @bookId"

                            Using command As New SqlCommand(query, conn)
                                command.Parameters.AddWithValue("@bookId", updateConf.idBox.Text)
                                command.Parameters.AddWithValue("@bookTitle", tBox.Text)
                                command.Parameters.AddWithValue("@author", aBox.Text)
                                command.Parameters.AddWithValue("@datePublished", dpBox.Text)
                                command.Parameters.AddWithValue("@note", nBox.Text)
                                Try
                                    conn.Open()
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("Book successfully updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    tBox.Text = ""
                                    aBox.Text = ""
                                    dpBox.Text = ""
                                    nBox.Text = ""
                                    Me.Close()
                                    updateConf.idBox.Text = ""
                                    updateConf.Show()

                                    'refresh table
                                    Dim table As New DataTable()
                                    Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', note as 'note', avail as 'Availability' FROM pupLibBooks ORDER BY book_id ASC", conn)
                                    adapter.Fill(table)

                                    hbtnForm.dt1.DataSource = table

                                    'count number of books
                                    Dim cmd1 As New SqlCommand("Select count(*) from pupLibBooks", conn)
                                    Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
                                    hbtnForm.numBooks.Text = count1 + " Books"
                                Catch ex As Exception
                                    MessageBox.Show("Error updating book: " & ex.Message)
                                Finally
                                    conn.Close()
                                End Try

                            End Using
                        End Using
                    Else
                        MessageBox.Show("The year is greater than today's date.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Invalid year format. Please enter a valid year.")
                End Try
            Else
                MessageBox.Show("Invalid year format. Please enter a valid year.")
            End If
            Button2.Text = "Update"
        End If
    End Sub

    Private Sub dpBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dpBox.KeyPress
        ' Check if the input character is a numeric digit (0-9) or special keys (Backspace and Delete)
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
            ' Prevent the input character from being processed by the textbox
            e.Handled = True
        End If
    End Sub


End Class