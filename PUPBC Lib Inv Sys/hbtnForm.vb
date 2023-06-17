Imports System.Data.SqlClient
Public Class hbtnForm
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
    Private Sub dt1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt1.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addForm.Show()
    End Sub

    Private Sub hbtnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter("SELECT b_title as 'Book Title', b_author as 'Author', b_published as 'Date Published', b_quan as 'Quantity',b_note as 'note' FROM BOOKS", conn)
        adapter.Fill(table)

        dt1.DataSource = table

        'count number of books
        Dim cmd1 As New SqlCommand("Select count(*) from Books", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        numBooks.Text = count1 + " Books"
        conn.Close()
    End Sub

End Class