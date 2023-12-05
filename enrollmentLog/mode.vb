Public Class mode

    Sub childforms(ByVal panel As Form)
        pnlNewStud.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlNewStud.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub mode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblFirstname.Click

    End Sub

    Private Sub RoundCornerTextbox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxSurname.TextChanged, txtbxSurname.TextChanged

    End Sub

    Private Sub bttnOldstudent_Click(sender As Object, e As EventArgs) Handles bttnOldstudent.Click
        childforms(Form2)
    End Sub

    Private Sub bttnEnrolll_Click(sender As Object, e As EventArgs) Handles bttnEnrolll.Click

    End Sub
End Class