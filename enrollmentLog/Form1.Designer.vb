<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        bttnlog = New RoundCornerButton()
        txtfldPassword = New RoundCornerTextbox()
        txtbxUsername = New RoundCornerTextbox()
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
        Panel1.Controls.Add(bttnlog)
        Panel1.Controls.Add(txtfldPassword)
        Panel1.Controls.Add(txtbxUsername)
        Panel1.Controls.Add(pctrCsdlogo)
        Panel1.Controls.Add(labelPassword)
        Panel1.Controls.Add(io)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(446, 417)
        Panel1.TabIndex = 0
        ' 
        ' bttnlog
        ' 
        bttnlog.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        bttnlog.FlatStyle = FlatStyle.Flat
        bttnlog.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bttnlog.ForeColor = Color.White
        bttnlog.Location = New Point(32, 300)
        bttnlog.Name = "bttnlog"
        bttnlog.Size = New Size(94, 38)
        bttnlog.TabIndex = 9
        bttnlog.Text = "Login"
        bttnlog.UseVisualStyleBackColor = False
        ' 
        ' txtfldPassword
        ' 
        txtfldPassword.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfldPassword.Location = New Point(32, 252)
        txtfldPassword.Name = "txtfldPassword"
        txtfldPassword.Size = New Size(380, 34)
        txtfldPassword.TabIndex = 8
        ' 
        ' txtbxUsername
        ' 
        txtbxUsername.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtbxUsername.Location = New Point(32, 175)
        txtbxUsername.Name = "txtbxUsername"
        txtbxUsername.Size = New Size(380, 34)
        txtbxUsername.TabIndex = 7
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
        labelPassword.Location = New Point(30, 229)
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
        io.Location = New Point(32, 152)
        io.Name = "io"
        io.Size = New Size(88, 20)
        io.TabIndex = 2
        io.Text = "Username"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 419)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pctrCsdlogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents io As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents bttnLogin As Button
    Friend WithEvents pctrCsdlogo As PictureBox
    Friend WithEvents txtbxUsername As RoundCornerTextbox
    Friend WithEvents txtfldPassword As RoundCornerTextbox
    Friend WithEvents bttnlog As RoundCornerButton

End Class
