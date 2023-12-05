Public Class addAdmin
    Private Sub txtfldPassword_TextChanged(sender As Object, e As EventArgs) Handles txtfldPassword.TextChanged

    End Sub

#Region "Customize Controls"
    Private Sub CustomizeComponents()

        txtbxUsername.AutoSize = False
        txtbxUsername.Size = New Size(380, 34)

        txtfldPassword.AutoSize = False
        txtfldPassword.Size = New Size(380, 34)
        txtfldPassword.UseSystemPasswordChar = True

        txtConPass.AutoSize = False
        txtConPass.Size = New Size(380, 34)
        txtConPass.UseSystemPasswordChar = True

    End Sub
#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CustomizeComponents()

    End Sub


End Class