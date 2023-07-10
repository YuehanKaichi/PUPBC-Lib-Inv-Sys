Imports System.Data.SqlClient
Public Class hbtnForm
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addForm.Show()
    End Sub

    Private Sub hbtnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note' FROM pupLibBooks", conn)
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
        Dim adapter As New SqlDataAdapter("SELECT book_id as 'Book ID', Book_title as 'Book Title', Book_author as 'Author', Date_published as 'Date Published', quantity as 'Quantity', note as 'note' FROM pupLibBooks", conn)
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
End Class