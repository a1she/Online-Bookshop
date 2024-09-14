<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.grpboxInfo = New System.Windows.Forms.GroupBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grpboxInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 14)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Password"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRegister.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(99, 424)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(124, 44)
        Me.btnRegister.TabIndex = 18
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(104, 49)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(161, 20)
        Me.txtPassword.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(80, 252)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 165)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "     Create Your Account"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(19, 26)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(62, 14)
        Me.lblUsername.TabIndex = 22
        Me.lblUsername.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(104, 26)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(161, 20)
        Me.txtusername.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 28)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Password must be at least 8 characters long " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and include a number and a symbol"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 31)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Confirm Password"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(102, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(163, 20)
        Me.TextBox2.TabIndex = 21
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancel.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(235, 424)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 44)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'dtpdob
        '
        Me.dtpdob.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdob.Location = New System.Drawing.Point(88, 78)
        Me.dtpdob.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(147, 20)
        Me.dtpdob.TabIndex = 20
        '
        'grpboxInfo
        '
        Me.grpboxInfo.Controls.Add(Me.txtNumber)
        Me.grpboxInfo.Controls.Add(Me.dtpdob)
        Me.grpboxInfo.Controls.Add(Me.txtboxEmail)
        Me.grpboxInfo.Controls.Add(Me.lblNumber)
        Me.grpboxInfo.Controls.Add(Me.lblEmail)
        Me.grpboxInfo.Controls.Add(Me.txtSurname)
        Me.grpboxInfo.Controls.Add(Me.lblDob)
        Me.grpboxInfo.Controls.Add(Me.lblSurname)
        Me.grpboxInfo.Controls.Add(Me.txtForename)
        Me.grpboxInfo.Controls.Add(Me.lblForename)
        Me.grpboxInfo.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxInfo.Location = New System.Drawing.Point(99, 79)
        Me.grpboxInfo.Name = "grpboxInfo"
        Me.grpboxInfo.Size = New System.Drawing.Size(258, 158)
        Me.grpboxInfo.TabIndex = 23
        Me.grpboxInfo.TabStop = False
        Me.grpboxInfo.Text = "Personal Information"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(88, 123)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(147, 20)
        Me.txtNumber.TabIndex = 16
        '
        'txtboxEmail
        '
        Me.txtboxEmail.Location = New System.Drawing.Point(88, 100)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(147, 20)
        Me.txtboxEmail.TabIndex = 8
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(4, 126)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblNumber.TabIndex = 17
        Me.lblNumber.Text = "Phone Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(25, 103)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(88, 22)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(147, 20)
        Me.txtSurname.TabIndex = 3
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.Location = New System.Drawing.Point(11, 77)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(66, 13)
        Me.lblDob.TabIndex = 7
        Me.lblDob.Text = "Date of Birth"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(25, 25)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 3
        Me.lblSurname.Text = "Surname"
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(88, 48)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(147, 20)
        Me.txtForename.TabIndex = 4
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(23, 51)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(54, 13)
        Me.lblForename.TabIndex = 5
        Me.lblForename.Text = "Forename"
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblSignUp.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.Location = New System.Drawing.Point(170, 32)
        Me.lblSignUp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(114, 27)
        Me.lblSignUp.TabIndex = 24
        Me.lblSignUp.Text = "Sign Up!"
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 494)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.grpboxInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegister)
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpboxInfo.ResumeLayout(False)
        Me.grpboxInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpdob As DateTimePicker
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents grpboxInfo As GroupBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblDob As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtForename As TextBox
    Friend WithEvents lblForename As Label
    Friend WithEvents lblSignUp As Label
End Class
