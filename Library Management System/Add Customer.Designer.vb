<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Customer
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
        Me.GdPersonal = New System.Windows.Forms.GroupBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtbEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbDob = New System.Windows.Forms.TextBox()
        Me.txtb1name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbForename = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbUserID = New System.Windows.Forms.TextBox()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GdPersonal.SuspendLayout()
        Me.SuspendLayout()
        '
        'GdPersonal
        '
        Me.GdPersonal.Controls.Add(Me.txtNumber)
        Me.GdPersonal.Controls.Add(Me.txtbEmail)
        Me.GdPersonal.Controls.Add(Me.Label6)
        Me.GdPersonal.Controls.Add(Me.Label4)
        Me.GdPersonal.Controls.Add(Me.txtbDob)
        Me.GdPersonal.Controls.Add(Me.txtb1name)
        Me.GdPersonal.Controls.Add(Me.Label3)
        Me.GdPersonal.Controls.Add(Me.Label1)
        Me.GdPersonal.Controls.Add(Me.txtbForename)
        Me.GdPersonal.Controls.Add(Me.Label2)
        Me.GdPersonal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GdPersonal.Location = New System.Drawing.Point(71, 98)
        Me.GdPersonal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GdPersonal.Name = "GdPersonal"
        Me.GdPersonal.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GdPersonal.Size = New System.Drawing.Size(387, 240)
        Me.GdPersonal.TabIndex = 24
        Me.GdPersonal.TabStop = False
        Me.GdPersonal.Text = "Personal Information"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(132, 189)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(218, 26)
        Me.txtNumber.TabIndex = 16
        '
        'txtbEmail
        '
        Me.txtbEmail.Location = New System.Drawing.Point(132, 154)
        Me.txtbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(218, 26)
        Me.txtbEmail.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email"
        '
        'txtbDob
        '
        Me.txtbDob.Location = New System.Drawing.Point(132, 114)
        Me.txtbDob.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbDob.Name = "txtbDob"
        Me.txtbDob.Size = New System.Drawing.Size(218, 26)
        Me.txtbDob.TabIndex = 6
        '
        'txtb1name
        '
        Me.txtb1name.Location = New System.Drawing.Point(132, 34)
        Me.txtb1name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtb1name.Name = "txtb1name"
        Me.txtb1name.Size = New System.Drawing.Size(218, 26)
        Me.txtb1name.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Surname"
        '
        'txtbForename
        '
        Me.txtbForename.Location = New System.Drawing.Point(132, 74)
        Me.txtbForename.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbForename.Name = "txtbForename"
        Me.txtbForename.Size = New System.Drawing.Size(218, 26)
        Me.txtbForename.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Forename"
        '
        'txtbUserID
        '
        Me.txtbUserID.Location = New System.Drawing.Point(247, 50)
        Me.txtbUserID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbUserID.Name = "txtbUserID"
        Me.txtbUserID.Size = New System.Drawing.Size(148, 26)
        Me.txtbUserID.TabIndex = 23
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(116, 50)
        Me.LblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(93, 18)
        Me.LblUsername.TabIndex = 22
        Me.LblUsername.Text = "Username"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(269, 346)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(228, 48)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Confirm"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnEdit.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(35, 346)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(228, 48)
        Me.btnEdit.TabIndex = 28
        Me.btnEdit.Text = "Cancel"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Add_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 460)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GdPersonal)
        Me.Controls.Add(Me.txtbUserID)
        Me.Controls.Add(Me.LblUsername)
        Me.Name = "Add_Customer"
        Me.Text = "Add_Customer"
        Me.GdPersonal.ResumeLayout(False)
        Me.GdPersonal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GdPersonal As GroupBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtbEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbDob As TextBox
    Friend WithEvents txtb1name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbForename As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbUserID As TextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
