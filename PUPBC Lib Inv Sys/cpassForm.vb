Imports System.Data.SqlClient
Public Class cpassForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If conPbox.Text = newPbox.Text Then

            Using conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
                Dim query As String = "update bookAdmin SET password = @Pass"

                Using command As New SqlCommand(query, conn)
                    command.Parameters.AddWithValue("@Pass", newPbox.Text)

                    conn.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Password successfuly changed", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Confirmation password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class