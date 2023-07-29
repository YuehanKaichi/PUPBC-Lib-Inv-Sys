Imports System.Data.SqlClient
Public Class Borrow
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
    Private Sub borBut_Click(sender As Object, e As EventArgs) Handles borBut.Click
        buttonBorrowConf.Show()
        returnButtonFunc.Close()
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles statusBox.TextChanged
        If statusBox.Text = "Before due" Then
            conn.Open()
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter("SELECT pupLibBorrow.studentID as 'Student ID', pupLibBorrow.studentName as 'Student Name',
                pupLibBorrow.cnYear as 'Course and Year', pupLibBorrow.Book_ID as 'Book ID', 
                pupLibBooks.Book_title as 'Book Title', 
                pupLibBorrow.borrowDate as 'Date Borrowed', pupLibBorrow.DueDate as 'Date to be returned' 
                FROM pupLibBorrow
                JOIN pupLibBooks ON pupLibBorrow.Book_ID = pupLibBooks.Book_ID
                WHERE pupLibBorrow.DueDate > GETDATE();", conn)
            adapter.Fill(table)

            dt1.DataSource = table
            conn.Close()
        ElseIf statusBox.Text = "Past due" Then
            conn.Open()
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter("SELECT pupLibBorrow.studentID as 'Student ID', pupLibBorrow.studentName as 'Student Name',
                pupLibBorrow.cnYear as 'Course and Year', pupLibBorrow.Book_ID as 'Book ID', 
                pupLibBooks.Book_title as 'Book Title', 
                pupLibBorrow.borrowDate as 'Date Borrowed', pupLibBorrow.DueDate as 'Date to be returned' 
                FROM pupLibBorrow
                JOIN pupLibBooks ON pupLibBorrow.Book_ID = pupLibBooks.Book_ID
                WHERE pupLibBorrow.DueDate < GETDATE();", conn)
            adapter.Fill(table)

            dt1.DataSource = table
            conn.Close()
        Else
            conn.Open()
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter("SELECT pupLibBorrow.studentID as 'Student ID', pupLibBorrow.studentName as 'Student Name',
        pupLibBorrow.cnYear as 'Course and Year', pupLibBorrow.Book_ID as 'Book ID', 
        pupLibBooks.Book_title as 'Book Title', 
        pupLibBorrow.borrowDate as 'Date Borrowed', pupLibBorrow.DueDate as 'Date to be returned' 
        FROM pupLibBorrow
        JOIN pupLibBooks ON pupLibBorrow.Book_ID = pupLibBooks.Book_ID;", conn)
            adapter.Fill(table)

            dt1.DataSource = table
            conn.Close()
        End If
    End Sub

    Private filteredRows As New List(Of DataGridViewRow)()

    Private Sub returnBut_Click(sender As Object, e As EventArgs) Handles returnBut.Click
        returnButtonFunc.Show()
        borrowButtonFunc.Close()
    End Sub

    Private Sub refreshButton_Click_1(sender As Object, e As EventArgs) Handles refreshButton.Click
        If statusBox.Text = "Before due" Then
            conn.Open()
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter("SELECT pupLibBorrow.studentID as 'Student ID', pupLibBorrow.studentName as 'Student Name',
                pupLibBorrow.cnYear as 'Course and Year', pupLibBorrow.Book_ID as 'Book ID', 
                pupLibBooks.Book_title as 'Book Title', 
                pupLibBorrow.borrowDate as 'Date Borrowed', pupLibBorrow.DueDate as 'Date to be returned' 
                FROM pupLibBorrow
                JOIN pupLibBooks ON pupLibBorrow.Book_ID = pupLibBooks.Book_ID
                WHERE pupLibBorrow.DueDate > GETDATE();", conn)
            adapter.Fill(table)

            dt1.DataSource = table
            conn.Close()
        ElseIf statusBox.Text = "Past due" Then
            conn.Open()
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter("SELECT pupLibBorrow.studentID as 'Student ID', pupLibBorrow.studentName as 'Student Name',
                pupLibBorrow.cnYear as 'Course and Year', pupLibBorrow.Book_ID as 'Book ID', 
                pupLibBooks.Book_title as 'Book Title', 
                pupLibBorrow.borrowDate as 'Date Borrowed', pupLibBorrow.DueDate as 'Date to be returned' 
                FROM pupLibBorrow
                JOIN pupLibBooks ON pupLibBorrow.Book_ID = pupLibBooks.Book_ID
                WHERE pupLibBorrow.DueDate < GETDATE();", conn)
            adapter.Fill(table)

            dt1.DataSource = table
            conn.Close()
        Else
            conn.Open()
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter("SELECT pupLibBorrow.studentID as 'Student ID', pupLibBorrow.studentName as 'Student Name',
        pupLibBorrow.cnYear as 'Course and Year', pupLibBorrow.Book_ID as 'Book ID', 
        pupLibBooks.Book_title as 'Book Title', 
        pupLibBorrow.borrowDate as 'Date Borrowed', pupLibBorrow.DueDate as 'Date to be returned' 
        FROM pupLibBorrow
        JOIN pupLibBooks ON pupLibBorrow.Book_ID = pupLibBooks.Book_ID;", conn)
            adapter.Fill(table)

            dt1.DataSource = table
            conn.Close()
        End If
    End Sub

    Private Sub Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusBox.Text = "All"
        Timer1.Enabled = True

        'show database to table
        conn.Open()
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter("SELECT pupLibBorrow.studentID as 'Student ID', pupLibBorrow.studentName as 'Student Name',
        pupLibBorrow.cnYear as 'Course and Year', pupLibBorrow.Book_ID as 'Book ID', 
        pupLibBooks.Book_title as 'Book Title', 
        pupLibBorrow.borrowDate as 'Date Borrowed', pupLibBorrow.DueDate as 'Date to be returned' 
        FROM pupLibBorrow
        JOIN pupLibBooks ON pupLibBorrow.Book_ID = pupLibBooks.Book_ID;", conn)
        adapter.Fill(table)

        dt1.DataSource = table
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
        Dim query As String = "SELECT COUNT(*) FROM pupLibBorrow WHERE dueDate < GETDATE()"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                Dim pastDueCount As Integer = CInt(command.ExecuteScalar())

                ' Display the notification message
                Dim message As String = $"{pastDueCount} borrowed books are past due."
                NotifyIcon1.ShowBalloonTip(60000, "Past Due Books", message, ToolTipIcon.Warning)
            End Using
        End Using
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

End Class