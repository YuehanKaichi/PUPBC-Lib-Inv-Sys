Imports System.Data
Imports System.Data.SqlClient

Public Class addForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        ElseIf (qBox.Text.Equals("")) Then
            MessageBox.Show("Enter Book quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim selectedDate As DateTime = dpBox.Value
            Dim selectedYear As Integer = selectedDate.Year
            Dim yearPub = selectedYear.ToString
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@BookID", maincc + idBox.Text)
            cmd.Parameters.AddWithValue("@bookTitle", tBox.Text)
            cmd.Parameters.AddWithValue("@bookAuthor", aBox.Text)
            cmd.Parameters.AddWithValue("@bookPublished", yearPub)
            cmd.Parameters.AddWithValue("@bookQuantity", qBox.Text)
            cmd.Parameters.AddWithValue("@bookNote", nBox.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data inserted successfully", "Books Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tBox.Text = ""
            aBox.Text = ""
            dpBox.Text = DateTime.Today
            qBox.Text = ""
            nBox.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dpBox_ValueChanged(sender As Object, e As EventArgs) Handles dpBox.ValueChanged
        If dpBox.Value.Date > DateTime.Today.ToShortDateString Then
            MessageBox.Show("Enter Date Published", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
End Class