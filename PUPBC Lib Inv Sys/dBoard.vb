Imports System.Data.SqlClient
Public Class dBoard
    Dim bclick As Integer
    Dim cclick
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    'HOME
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles hbtn.Click
        hbtnForm.MdiParent = Me
        hbtnForm.Show()
        hbtnForm.Location.Offset(165, 41)
        profForm.Close()
        hbtn.BackColor = ColorTranslator.FromOle(RGB(192, 0, 0))
        hbtn.ForeColor = Color.White
        ab.BackColor = Color.WhiteSmoke
        ab.ForeColor = Color.Black

    End Sub

    'PROFILE
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ab.Click
        profForm.MdiParent = Me
        profForm.Show()
        profForm.Location.Offset(165, 41)
        hbtnForm.Close()
        ab.BackColor = ColorTranslator.FromOle(RGB(192, 0, 0))
        ab.ForeColor = Color.White
        hbtn.BackColor = Color.WhiteSmoke
        hbtn.ForeColor = Color.Black

    End Sub


End Class