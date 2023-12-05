Public Class Form2

    Sub childforms(ByVal panel As Form)
        pnlOldStud.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panel.Show()
    End Sub


    Private Sub lblSurname_Click(sender As Object, e As EventArgs) Handles lblSurname.Click

    End Sub

    Private Sub bttnContinuee_Click(sender As Object, e As EventArgs) Handles bttnContinuee.Click

    End Sub

    Private Sub bttnNewstudent_Click(sender As Object, e As EventArgs) Handles bttnNewstudent.Click
        childforms(mode)
    End Sub
End Class