Imports System.Data
Imports System.Data.SqlClient

Public Class addForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Step 1: Get the year from the textbox.
        Dim inputYear As Integer
        If Integer.TryParse(dpBox.Text, inputYear) Then
            ' Step 2: Convert the year into a valid DateTime object.
            Dim inputDate As DateTime
            Try
                inputDate = New DateTime(inputYear, 1, 1)

                ' Step 3: Compare the DateTime object with the current date.
                If inputDate <= DateTime.Today Then
                    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
                    Dim cmd As New SqlCommand("insertbooks", conn)
                    Dim maincc As String = ""
                    Select Case mccBox.Text
                        Case "A - General Works"
                            maincc = "A"
                        Case "B - Religion and Philosophy"
                            maincc = "B"
                        Case "C - Auxiliary Science to History"
                            maincc = "C"
                        Case "D - History of the Old World"
                            maincc = "D"
                        Case "E - U.S History"
                            maincc = "E"
                        Case "F - History of the American"
                            maincc = "F"
                        Case "G - Geography and Anthropology"
                            maincc = "G"
                        Case "H - Special Sciences"
                            maincc = "H"
                        Case "J - Political Sciences"
                            maincc = "J"
                        Case "K - Law"
                            maincc = "K"
                        Case "L - Education"
                            maincc = "L"
                        Case "M - Music"
                            maincc = "M"
                        Case "N - Fine Art"
                            maincc = "N"
                        Case "P - Language and Literature"
                            maincc = "P"
                        Case "Q - Math and Science"
                            maincc = "Q"
                        Case "R - Medicine"
                            maincc = "R"
                        Case "S - Agriculture"
                            maincc = "S"
                        Case "T - Engineering and Techonology"
                            maincc = "T"
                        Case "U - Military Science"
                            maincc = "U"
                        Case "V - Naval Science"
                            maincc = "V"
                        Case "Z - Library Science"
                            maincc = "Z"
                    End Select
                    If (tBox.Text.Equals("")) Then
                        MessageBox.Show("Enter Book title", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf (aBox.Text.Equals("")) Then
                        MessageBox.Show("Enter Book author", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf (dpBox.Text.Equals("")) Then
                        MessageBox.Show("Enter Date Published", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else

                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@BookID", maincc + idBox.Text + " " + dpBox.Text)
                        cmd.Parameters.AddWithValue("@bookTitle", tBox.Text)
                        cmd.Parameters.AddWithValue("@bookAuthor", aBox.Text)
                        cmd.Parameters.AddWithValue("@bookPublished", dpBox.Text)
                        cmd.Parameters.AddWithValue("@bookNote", nBox.Text)
                        conn.Open()
                        cmd.ExecuteNonQuery()

                        'refresh table
                        Dim table As New DataTable()
                        Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', note as 'note', avail as 'Availability' FROM pupLibBooks ORDER BY book_id ASC", conn)
                        adapter.Fill(table)

                        hbtnForm.dt1.DataSource = table

                        'count number of books
                        Dim cmd1 As New SqlCommand("Select count(*) from pupLibBooks", conn)
                        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
                        hbtnForm.numBooks.Text = count1 + " Books"

                        conn.Close()
                        MessageBox.Show("Data inserted successfully", "Books Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        tBox.Text = ""
                        aBox.Text = ""
                        dpBox.Text = ""
                        nBox.Text = ""
                        mccBox.Text = ""
                        idBox.Text = ""

                    End If
                Else
                    MessageBox.Show("The year is greater than today's date.")
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid year format. Please enter a valid year.")
            End Try
        Else
            MessageBox.Show("Invalid year format. Please enter a valid year.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dpBox_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dpBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dpBox.KeyPress
        ' Check if the input character is a numeric digit (0-9) or special keys (Backspace and Delete)
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
            ' Prevent the input character from being processed by the textbox
            e.Handled = True
        End If
    End Sub
End Class