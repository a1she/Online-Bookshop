<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetail
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
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.txtbUserID = New System.Windows.Forms.TextBox()
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
        Me.gbOverdue = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btmSearch = New System.Windows.Forms.Button()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GdPersonal.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(72, 70)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(66, 14)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'txtbUserID
        '
        Me.txtbUserID.Location = New System.Drawing.Point(159, 70)
        Me.txtbUserID.Name = "txtbUserID"
        Me.txtbUserID.Size = New System.Drawing.Size(100, 20)
        Me.txtbUserID.TabIndex = 1
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
        Me.GdPersonal.Location = New System.Drawing.Point(51, 135)
        Me.GdPersonal.Name = "GdPersonal"
        Me.GdPersonal.Size = New System.Drawing.Size(258, 156)
        Me.GdPersonal.TabIndex = 2
        Me.GdPersonal.TabStop = False
        Me.GdPersonal.Text = "Personal Information"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(88, 123)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(147, 20)
        Me.txtNumber.TabIndex = 16
        '
        'txtbEmail
        '
        Me.txtbEmail.Location = New System.Drawing.Point(88, 100)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(147, 20)
        Me.txtbEmail.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email"
        '
        'txtbDob
        '
        Me.txtbDob.Location = New System.Drawing.Point(88, 74)
        Me.txtbDob.Name = "txtbDob"
        Me.txtbDob.Size = New System.Drawing.Size(147, 20)
        Me.txtbDob.TabIndex = 6
        '
        'txtb1name
        '
        Me.txtb1name.Location = New System.Drawing.Point(88, 22)
        Me.txtb1name.Name = "txtb1name"
        Me.txtb1name.Size = New System.Drawing.Size(147, 20)
        Me.txtb1name.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Surname"
        '
        'txtbForename
        '
        Me.txtbForename.Location = New System.Drawing.Point(88, 48)
        Me.txtbForename.Name = "txtbForename"
        Me.txtbForename.Size = New System.Drawing.Size(147, 20)
        Me.txtbForename.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Forename"
        '
        'gbOverdue
        '
        Me.gbOverdue.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOverdue.Location = New System.Drawing.Point(46, 298)
        Me.gbOverdue.Name = "gbOverdue"
        Me.gbOverdue.Size = New System.Drawing.Size(263, 82)
        Me.gbOverdue.TabIndex = 15
        Me.gbOverdue.TabStop = False
        Me.gbOverdue.Text = "Orders"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Status"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(139, 102)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 18)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Active"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(218, 104)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(70, 18)
        Me.CheckBox2.TabIndex = 21
        Me.CheckBox2.Text = "Inactive"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 22)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Customer Profile"
        '
        'btmSearch
        '
        Me.btmSearch.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btmSearch.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmSearch.Location = New System.Drawing.Point(91, 461)
        Me.btmSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btmSearch.Name = "btmSearch"
        Me.btmSearch.Size = New System.Drawing.Size(160, 31)
        Me.btmSearch.TabIndex = 41
        Me.btmSearch.Text = "Search"
        Me.btmSearch.UseVisualStyleBackColor = False
        '
        'btnAddStaff
        '
        Me.btnAddStaff.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddStaff.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.Location = New System.Drawing.Point(181, 429)
        Me.btnAddStaff.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(160, 28)
        Me.btnAddStaff.TabIndex = 40
        Me.btnAddStaff.Text = "Add Customer"
        Me.btnAddStaff.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(181, 397)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 28)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save Information"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(17, 429)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(160, 28)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "Delete Customer"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnEdit.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(17, 397)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(160, 28)
        Me.btnEdit.TabIndex = 37
        Me.btnEdit.Text = "Edit Information"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'CustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 514)
        Me.Controls.Add(Me.btmSearch)
        Me.Controls.Add(Me.btnAddStaff)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbOverdue)
        Me.Controls.Add(Me.GdPersonal)
        Me.Controls.Add(Me.txtbUserID)
        Me.Controls.Add(Me.LblUsername)
        Me.Name = "CustomerDetail"
        Me.Text = "Customer Details"
        Me.GdPersonal.ResumeLayout(False)
        Me.GdPersonal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents txtbUserID As TextBox
    Friend WithEvents GdPersonal As GroupBox
    Friend WithEvents txtb1name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbDob As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbForename As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbOverdue As GroupBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btmSearch As Button
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
