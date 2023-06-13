Imports System.Data.SqlClient
Public Class hbtnForm
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
    Private Sub dt1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt1.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter("SELECT * FROM BOOKS", conn)
        adapter.Fill(table)

        dt1.DataSource = table
    End Sub
End Class