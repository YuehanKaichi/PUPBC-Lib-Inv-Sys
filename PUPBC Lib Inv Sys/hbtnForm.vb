Imports System.Data.SqlClient
Public Class hbtnForm
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addForm.Show()
    End Sub

    Private Sub hbtnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks ORDER BY book_id ASC", conn)
        adapter.Fill(table)

        dt1.DataSource = table

        'count number of books
        Dim cmd1 As New SqlCommand("Select count(*) from pupLibBooks", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        numBooks.Text = count1 + " Books"
        conn.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks ORDER BY book_id ASC", conn)
        adapter.Fill(table)

        dt1.DataSource = table

        'count number of books
        Dim cmd1 As New SqlCommand("Select count(*) from pupLibBooks", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        numBooks.Text = count1 + " Books"
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deleteFunc.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updateFunc.Show()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the "ding" sound when Enter is pressed.
            PerformSearch(TextBox1.Text)
        End If
    End Sub
    Private Sub PerformSearch(searchTerm As String)
        ' Clear any previous filters
        dt1.ClearSelection()
        dt1.CurrentCell = Nothing

        If String.IsNullOrWhiteSpace(searchTerm) Then
            ' If the search term is empty, show all data
            For Each row As DataGridViewRow In dt1.Rows
                row.Visible = True
            Next
        Else
            ' Perform the search and hide rows that do not match the search term
            For Each row As DataGridViewRow In dt1.Rows
                Dim matchFound As Boolean = False
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 Then
                        matchFound = True
                        Exit For
                    End If
                Next

                row.Visible = matchFound
            Next
        End If
    End Sub

    Private Sub ccbox_TextChanged(sender As Object, e As EventArgs) Handles ccbox.TextChanged
        conn.Open()
        Select Case ccbox.Text
            Case "All"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "A - General Works"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'A%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "B - Religion and Philosophy"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'B%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "C - Auxiliary Science to History"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'C%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "D - History of the Old World"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'D%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "E - U.S History"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'E%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "F - History of the American"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'F%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "G - Geography and Anthropology"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'G%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "H - Special Sciences"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'H%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "J - Political Sciences"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'J%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "K - Law"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'K%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "L - Education"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'L%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "M - Music"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'M%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "N - Fine Art"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'N%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "P - Language and Literature"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'P%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "Q - Math and Science"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'Q%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "R - Medicine"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'R%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "S - Agriculture"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'S%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "T - Engineering and Techonology"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'T%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "U - Military Science"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'U%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "V - Naval Science"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'V%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
            Case "Z - Library Science"
                Dim table As New DataTable()
                Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note', avail as 'Availability' FROM pupLibBooks WHERE book_id LIKE 'Z%' ORDER BY book_id ASC", conn)
                adapter.Fill(table)

                dt1.DataSource = table
        End Select

        'count number of books
        Dim cmd1 As New SqlCommand("Select count(*) from pupLibBooks", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        numBooks.Text = count1 + " Books"
        conn.Close()
    End Sub
End Class