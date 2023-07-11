Imports System.Data.SqlClient
Public Class Borrow
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
    Private Sub borBut_Click(sender As Object, e As EventArgs) Handles borBut.Click
        borrowButtonFunc.Show()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchText As String = TextBox1.Text.Trim().ToLower()
        Try
            For Each row As DataGridViewRow In dt1.Rows
                If row.IsNewRow Then Continue For

                Dim matchFound As Boolean = False

                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchText) Then
                        matchFound = True
                        Exit For
                    End If
                Next
                row.Visible = matchFound
            Next
        Catch ex As Exception
            MessageBox.Show("Invalid input: " & ex.Message)
        End Try

    End Sub

    Private Sub returnBut_Click(sender As Object, e As EventArgs) Handles returnBut.Click
        returnButtonFunc.Show()
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
End Class