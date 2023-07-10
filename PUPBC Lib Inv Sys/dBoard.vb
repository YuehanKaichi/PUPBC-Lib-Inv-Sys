Imports System.Data.SqlClient
Public Class dBoard
    Dim bclick As Integer
    Dim cclick
    Dim conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=libinvsystem;Integrated Security=True")



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form2.Show()
        If (Form2.rmBox.Checked) Then

        Else
            Form2.unText.Text = ""
            Form2.pwText.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    'HOME
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles hbtn.Click
        hbtnForm.MdiParent = Me
        hbtnForm.Show()
        hbtnForm.Location.Offset(165, 41)
        profForm.Hide()
        hbtn.BackColor = ColorTranslator.FromOle(RGB(192, 0, 0))
        hbtn.ForeColor = Color.White
        ab.BackColor = Color.LightGray
        ab.ForeColor = Color.Black
        bb.BackColor = Color.LightGray
        bb.ForeColor = Color.Black

    End Sub

    'PROFILE
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ab.Click
        profForm.MdiParent = Me
        profForm.Show()
        profForm.Location.Offset(165, 41)
        hbtnForm.Hide()
        ab.BackColor = ColorTranslator.FromOle(RGB(192, 0, 0))
        ab.ForeColor = Color.White
        hbtn.BackColor = Color.LightGray
        hbtn.ForeColor = Color.Black
        bb.BackColor = Color.LightGray
        bb.ForeColor = Color.Black

    End Sub
    'BORROW
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles bb.Click
        Borrow.MdiParent = Me
        Borrow.Show()
        Borrow.Location.Offset(165, 41)
        profForm.Hide()
        bb.BackColor = ColorTranslator.FromOle(RGB(192, 0, 0))
        bb.ForeColor = Color.White
        ab.BackColor = Color.LightGray
        ab.ForeColor = Color.Black
        hbtn.BackColor = Color.LightGray
        hbtn.ForeColor = Color.Black
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


End Class