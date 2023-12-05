<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(addAdmin))
        Panel1 = New Panel()
        bttnCancel = New RoundCornerButton()
        bttnlog = New RoundCornerButton()
        txtConPass = New RoundCornerTextbox()
        txtfldPassword = New RoundCornerTextbox()
        txtbxUsername = New RoundCornerTextbox()
        txtConfirmPass = New Label()
        pctrCsdlogo = New PictureBox()
        labelPassword = New Label()
        io = New Label()
        Panel1.SuspendLayout()
        CType(pctrCsdlogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(41), CByte(41), CByte(41))
        Panel1.Controls.Add(bttnCancel)
        Panel1.Controls.Add(bttnlog)
        Panel1.Controls.Add(txtConPass)
        Panel1.Controls.Add(txtfldPassword)
        Panel1.Controls.Add(txtbxUsername)
        Panel1.Controls.Add(txtConfirmPass)
        Panel1.Controls.Add(pctrCsdlogo)
        Panel1.Controls.Add(labelPassword)
        Panel1.Controls.Add(io)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(446, 417)
        Panel1.TabIndex = 1
        ' 
        ' bttnCancel
        ' 
        bttnCancel.BackColor = Color.Transparent
        bttnCancel.FlatStyle = FlatStyle.Flat
        bttnCancel.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bttnCancel.ForeColor = Color.White
        bttnCancel.Location = New Point(144, 351)
        bttnCancel.Name = "bttnCancel"
        bttnCancel.Size = New Size(94, 38)
        bttnCancel.TabIndex = 10
        bttnCancel.Text = "Cancel"
        bttnCancel.UseVisualStyleBackColor = False
        ' 
        ' bttnlog
        ' 
        bttnlog.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        bttnlog.FlatStyle = FlatStyle.Flat
        bttnlog.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bttnlog.ForeColor = Color.White
        bttnlog.Location = New Point(30, 351)
        bttnlog.Name = "bttnlog"
        bttnlog.Size = New Size(108, 38)
        bttnlog.TabIndex = 9
        bttnlog.Text = "Add User"
        bttnlog.UseVisualStyleBackColor = False
        ' 
        ' txtConPass
        ' 
        txtConPass.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtConPass.Location = New Point(30, 301)
        txtConPass.Name = "txtConPass"
        txtConPass.Size = New Size(380, 34)
        txtConPass.TabIndex = 8
        ' 
        ' txtfldPassword
        ' 
        txtfldPassword.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfldPassword.Location = New Point(30, 229)
        txtfldPassword.Name = "txtfldPassword"
        txtfldPassword.Size = New Size(380, 34)
        txtfldPassword.TabIndex = 8
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtbxUsername.Location = New Point(30, 155)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(380, 34)
        txtbxUsername.TabIndex = 7
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.AutoSize = True
        txtConfirmPass.Font = New Font("Gadugi", 10F, FontStyle.Bold, GraphicsUnit.Point)
        txtConfirmPass.ForeColor = Color.White
        txtConfirmPass.Location = New Point(28, 278)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.Size = New Size(155, 20)
        txtConfirmPass.TabIndex = 3
        txtConfirmPass.Text = "Confirm Password"
        ' 
        ' pctrCsdlogo
        ' 
        pctrCsdlogo.Image = CType(resources.GetObject("pctrCsdlogo.Image"), Image)
        pctrCsdlogo.Location = New Point(161, 2)
        pctrCsdlogo.Name = "pctrCsdlogo"
        pctrCsdlogo.Size = New Size(123, 114)
        pctrCsdlogo.SizeMode = PictureBoxSizeMode.StretchImage
        pctrCsdlogo.TabIndex = 6
        pctrCsdlogo.TabStop = False
        ' 
        ' labelPassword
        ' 
        labelPassword.AutoSize = True
        labelPassword.Font = New Font("Gadugi", 10F, FontStyle.Bold, GraphicsUnit.Point)
        labelPassword.ForeColor = Color.White
        labelPassword.Location = New Point(28, 206)
        labelPassword.Name = "labelPassword"
        labelPassword.Size = New Size(84, 20)
        labelPassword.TabIndex = 3
        labelPassword.Text = "Password"
        ' 
        ' io
        ' 
        io.AutoSize = True
        io.Font = New Font("Gadugi", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        io.ForeColor = Color.White
        io.Location = New Point(30, 132)
        io.Name = "io"
        io.Size = New Size(88, 20)
        io.TabIndex = 2
        io.Text = "Username"
        ' 
        ' addAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 419)
        Controls.Add(Panel1)
        Name = "addAdmin"
        Text = "addAdmin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pctrCsdlogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bttnlog As RoundCornerButton
    Friend WithEvents txtConPass As RoundCornerTextbox
    Friend WithEvents txtfldPassword As RoundCornerTextbox
    Friend WithEvents txtbxUsername As RoundCornerTextbox
    Friend WithEvents txtConfirmPass As Label
    Friend WithEvents pctrCsdlogo As PictureBox
    Friend WithEvents labelPassword As Label
    Friend WithEvents io As Label
    Friend WithEvents bttnCancel As RoundCornerButton
End Class
