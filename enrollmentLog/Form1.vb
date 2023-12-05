Public Class Form1



#Region "CustomizeComponents"
    Private Sub CustomizeComponents()
        txtfldPassword.UseSystemPasswordChar = True

    End Sub

    Private Sub bttnlog_Click(sender As Object, e As EventArgs) Handles bttnlog.Click
        addAdmin.Show()
    End Sub
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CustomizeComponents()

    End Sub

End Class
