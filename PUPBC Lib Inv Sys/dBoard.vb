Imports System.Data.SqlClient
Public Class dBoard
    Dim bclick As Integer

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        hpanel.Location = New Point(68, 56)
        If (bclick = 0) Then
            home.BackColor = ColorTranslator.FromOle(RGB(192, 0, 0))
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addForm.Show()
    End Sub

    '  Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    ' Dim constr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True"
    'Dim con As SqlConnection
    'Dim dr As SqlDataReader
    'Dim showBook As SqlCommand
    'Dim i As Integer
    '
    'con.Open()
    'String query 
    ' End Sub
End Class