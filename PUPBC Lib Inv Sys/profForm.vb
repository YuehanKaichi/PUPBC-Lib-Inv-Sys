Imports System.Data.SqlClient
Public Class profForm
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cpwbtn.Click
        cpassForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles edtbtn.Click
        nameBox.Enabled = True
        emailBox.Enabled = True
        usnBox.Enabled = True

        edtbtn.Text = "Save"
        cpwbtn.Visible = True

        If edtbtn.Text = "Save" Then

        End If
    End Sub
End Class