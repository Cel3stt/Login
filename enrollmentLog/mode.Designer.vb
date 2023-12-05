<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mode))
        pnlNewStud = New Panel()
        bttnEnrolll = New RoundCornerButton()
        txtfldFirstname = New RoundCornerTextbox()
        txtfldSurname = New RoundCornerTextbox()
        lblFirstname = New Label()
        lblSurname = New Label()
        bttnOldstudent = New Label()
        bttnNewstudent = New Label()
        pctrCsdlogo = New PictureBox()
        pnlNewStud.SuspendLayout()
        CType(pctrCsdlogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlNewStud
        ' 
        pnlNewStud.BackColor = Color.FromArgb(CByte(41), CByte(41), CByte(41))
        pnlNewStud.Controls.Add(bttnEnrolll)
        pnlNewStud.Controls.Add(txtfldFirstname)
        pnlNewStud.Controls.Add(txtfldSurname)
        pnlNewStud.Controls.Add(lblFirstname)
        pnlNewStud.Controls.Add(lblSurname)
        pnlNewStud.Controls.Add(bttnOldstudent)
        pnlNewStud.Controls.Add(bttnNewstudent)
        pnlNewStud.Controls.Add(pctrCsdlogo)
        pnlNewStud.Location = New Point(1, 1)
        pnlNewStud.Name = "pnlNewStud"
        pnlNewStud.Size = New Size(452, 508)
        pnlNewStud.TabIndex = 0
        ' 
        ' bttnEnrolll
        ' 
        bttnEnrolll.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        bttnEnrolll.FlatStyle = FlatStyle.Flat
        bttnEnrolll.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bttnEnrolll.ForeColor = Color.White
        bttnEnrolll.Location = New Point(31, 364)
        bttnEnrolll.Name = "bttnEnrolll"
        bttnEnrolll.Size = New Size(114, 42)
        bttnEnrolll.TabIndex = 17
        bttnEnrolll.Text = "Enroll"
        bttnEnrolll.UseVisualStyleBackColor = False
        ' 
        ' txtfldFirstname
        ' 
        txtfldFirstname.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfldFirstname.Location = New Point(31, 307)
        txtfldFirstname.Name = "txtfldFirstname"
        txtfldFirstname.Size = New Size(342, 34)
        txtfldFirstname.TabIndex = 16
        ' 
        ' txtfldSurname
        ' 
        txtfldSurname.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfldSurname.Location = New Point(31, 217)
        txtfldSurname.Name = "txtfldSurname"
        txtfldSurname.Size = New Size(342, 34)
        txtfldSurname.TabIndex = 15
        ' 
        ' lblFirstname
        ' 
        lblFirstname.AutoSize = True
        lblFirstname.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirstname.ForeColor = Color.White
        lblFirstname.Location = New Point(29, 282)
        lblFirstname.Name = "lblFirstname"
        lblFirstname.Size = New Size(95, 24)
        lblFirstname.TabIndex = 12
        lblFirstname.Text = "Firstname"
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblSurname.ForeColor = Color.White
        lblSurname.Location = New Point(31, 190)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(87, 24)
        lblSurname.TabIndex = 10
        lblSurname.Text = "Surname"
        ' 
        ' bttnOldstudent
        ' 
        bttnOldstudent.AutoSize = True
        bttnOldstudent.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bttnOldstudent.ForeColor = Color.White
        bttnOldstudent.Location = New Point(198, 150)
        bttnOldstudent.Name = "bttnOldstudent"
        bttnOldstudent.Size = New Size(123, 24)
        bttnOldstudent.TabIndex = 9
        bttnOldstudent.Text = "Old Student"
        ' 
        ' bttnNewstudent
        ' 
        bttnNewstudent.AutoSize = True
        bttnNewstudent.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bttnNewstudent.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        bttnNewstudent.Location = New Point(31, 150)
        bttnNewstudent.Name = "bttnNewstudent"
        bttnNewstudent.Size = New Size(133, 24)
        bttnNewstudent.TabIndex = 8
        bttnNewstudent.Text = "New Student"
        ' 
        ' pctrCsdlogo
        ' 
        pctrCsdlogo.Image = CType(resources.GetObject("pctrCsdlogo.Image"), Image)
        pctrCsdlogo.Location = New Point(31, 11)
        pctrCsdlogo.Name = "pctrCsdlogo"
        pctrCsdlogo.Size = New Size(123, 114)
        pctrCsdlogo.SizeMode = PictureBoxSizeMode.StretchImage
        pctrCsdlogo.TabIndex = 7
        pctrCsdlogo.TabStop = False
        ' 
        ' mode
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(452, 505)
        Controls.Add(pnlNewStud)
        Name = "mode"
        Text = "mode"
        pnlNewStud.ResumeLayout(False)
        pnlNewStud.PerformLayout()
        CType(pctrCsdlogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlNewStud As Panel
    Friend WithEvents pctrCsdlogo As PictureBox
    Friend WithEvents bttnNewstudent As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents bttnOldstudent As Label
    Friend WithEvents txtbxSurname As TextBox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents txtfldSurname As RoundCornerTextbox
    Friend WithEvents txtfldFirstname As RoundCornerTextbox
    Friend WithEvents bttnEnrolll As RoundCornerButton

End Class
