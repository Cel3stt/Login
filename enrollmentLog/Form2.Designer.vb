<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pnlOldStud = New Panel()
        bttnContinuee = New RoundCornerButton()
        txtfldFirstname = New RoundCornerTextbox()
        txtfldSurname = New RoundCornerTextbox()
        txtfldStudentNo = New RoundCornerTextbox()
        lblStudentno = New Label()
        lblFirstname = New Label()
        lblSurname = New Label()
        bttnOldstudent = New Label()
        bttnNewstudent = New Label()
        pctrCsdlogo = New PictureBox()
        pnlOldStud.SuspendLayout()
        CType(pctrCsdlogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlOldStud
        ' 
        pnlOldStud.BackColor = Color.FromArgb(CByte(41), CByte(41), CByte(41))
        pnlOldStud.Controls.Add(bttnContinuee)
        pnlOldStud.Controls.Add(txtfldFirstname)
        pnlOldStud.Controls.Add(txtfldSurname)
        pnlOldStud.Controls.Add(txtfldStudentNo)
        pnlOldStud.Controls.Add(lblStudentno)
        pnlOldStud.Controls.Add(lblFirstname)
        pnlOldStud.Controls.Add(lblSurname)
        pnlOldStud.Controls.Add(bttnOldstudent)
        pnlOldStud.Controls.Add(bttnNewstudent)
        pnlOldStud.Controls.Add(pctrCsdlogo)
        pnlOldStud.Location = New Point(0, -2)
        pnlOldStud.Name = "pnlOldStud"
        pnlOldStud.Size = New Size(452, 508)
        pnlOldStud.TabIndex = 1
        ' 
        ' bttnContinuee
        ' 
        bttnContinuee.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        bttnContinuee.FlatStyle = FlatStyle.Flat
        bttnContinuee.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bttnContinuee.ForeColor = Color.White
        bttnContinuee.Location = New Point(31, 432)
        bttnContinuee.Name = "bttnContinuee"
        bttnContinuee.Size = New Size(113, 42)
        bttnContinuee.TabIndex = 20
        bttnContinuee.Text = "Continue"
        bttnContinuee.UseVisualStyleBackColor = False
        ' 
        ' txtfldFirstname
        ' 
        txtfldFirstname.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfldFirstname.Location = New Point(30, 377)
        txtfldFirstname.Name = "txtfldFirstname"
        txtfldFirstname.Size = New Size(344, 34)
        txtfldFirstname.TabIndex = 19
        ' 
        ' txtfldSurname
        ' 
        txtfldSurname.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfldSurname.Location = New Point(30, 300)
        txtfldSurname.Name = "txtfldSurname"
        txtfldSurname.Size = New Size(344, 34)
        txtfldSurname.TabIndex = 18
        ' 
        ' txtfldStudentNo
        ' 
        txtfldStudentNo.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtfldStudentNo.Location = New Point(31, 224)
        txtfldStudentNo.Name = "txtfldStudentNo"
        txtfldStudentNo.Size = New Size(344, 34)
        txtfldStudentNo.TabIndex = 17
        ' 
        ' lblStudentno
        ' 
        lblStudentno.AutoSize = True
        lblStudentno.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudentno.ForeColor = Color.White
        lblStudentno.Location = New Point(30, 199)
        lblStudentno.Name = "lblStudentno"
        lblStudentno.Size = New Size(156, 24)
        lblStudentno.TabIndex = 16
        lblStudentno.Text = "Student Number"
        ' 
        ' lblFirstname
        ' 
        lblFirstname.AutoSize = True
        lblFirstname.Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirstname.ForeColor = Color.White
        lblFirstname.Location = New Point(30, 352)
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
        lblSurname.Location = New Point(30, 275)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(87, 24)
        lblSurname.TabIndex = 10
        lblSurname.Text = "Surname"
        ' 
        ' bttnOldstudent
        ' 
        bttnOldstudent.AutoSize = True
        bttnOldstudent.Font = New Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bttnOldstudent.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
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
        bttnNewstudent.ForeColor = Color.White
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
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(452, 505)
        Controls.Add(pnlOldStud)
        Name = "Form2"
        Text = "Form2"
        pnlOldStud.ResumeLayout(False)
        pnlOldStud.PerformLayout()
        CType(pctrCsdlogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlOldStud As Panel
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents bttnOldstudent As Label
    Friend WithEvents bttnNewstudent As Label
    Friend WithEvents pctrCsdlogo As PictureBox
    Friend WithEvents lblStudentno As Label
    Friend WithEvents txtfldFirstname As RoundCornerTextbox
    Friend WithEvents txtfldSurname As RoundCornerTextbox
    Friend WithEvents txtfldStudentNo As RoundCornerTextbox
    Friend WithEvents bttnContinuee As RoundCornerButton
End Class
