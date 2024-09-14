<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
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
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.cbxParttime = New System.Windows.Forms.CheckBox()
        Me.cbxFulltime = New System.Windows.Forms.CheckBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.txtbName = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cbTemporary = New System.Windows.Forms.CheckBox()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btmSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.BackColor = System.Drawing.Color.PaleVioletRed
        Me.lblStaff.Font = New System.Drawing.Font("Lucida Fax", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaff.Location = New System.Drawing.Point(191, 31)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(191, 32)
        Me.lblStaff.TabIndex = 25
        Me.lblStaff.Text = "Staff Profile"
        '
        'cbxParttime
        '
        Me.cbxParttime.AutoSize = True
        Me.cbxParttime.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxParttime.Location = New System.Drawing.Point(271, 139)
        Me.cbxParttime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxParttime.Name = "cbxParttime"
        Me.cbxParttime.Size = New System.Drawing.Size(111, 22)
        Me.cbxParttime.TabIndex = 28
        Me.cbxParttime.Text = "Part Time"
        Me.cbxParttime.UseVisualStyleBackColor = True
        '
        'cbxFulltime
        '
        Me.cbxFulltime.AutoSize = True
        Me.cbxFulltime.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFulltime.Location = New System.Drawing.Point(153, 139)
        Me.cbxFulltime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxFulltime.Name = "cbxFulltime"
        Me.cbxFulltime.Size = New System.Drawing.Size(110, 22)
        Me.cbxFulltime.TabIndex = 27
        Me.cbxFulltime.Text = "Full Time"
        Me.cbxFulltime.UseVisualStyleBackColor = True
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(68, 139)
        Me.LblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(61, 18)
        Me.LblStatus.TabIndex = 26
        Me.LblStatus.Text = "Status"
        '
        'txtbName
        '
        Me.txtbName.Location = New System.Drawing.Point(221, 88)
        Me.txtbName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbName.Name = "txtbName"
        Me.txtbName.Size = New System.Drawing.Size(214, 26)
        Me.txtbName.TabIndex = 30
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(111, 96)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(94, 18)
        Me.lblname.TabIndex = 29
        Me.lblname.Text = "Full Name"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(32, 565)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(240, 43)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Delete staff"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnEdit.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(32, 516)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(240, 43)
        Me.btnEdit.TabIndex = 31
        Me.btnEdit.Text = "Edit staff information"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'cbTemporary
        '
        Me.cbTemporary.AutoSize = True
        Me.cbTemporary.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTemporary.Location = New System.Drawing.Point(391, 139)
        Me.cbTemporary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbTemporary.Name = "cbTemporary"
        Me.cbTemporary.Size = New System.Drawing.Size(124, 22)
        Me.cbTemporary.TabIndex = 33
        Me.cbTemporary.Text = "Temporary"
        Me.cbTemporary.UseVisualStyleBackColor = True
        '
        'btnAddStaff
        '
        Me.btnAddStaff.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnAddStaff.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.Location = New System.Drawing.Point(278, 565)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(240, 43)
        Me.btnAddStaff.TabIndex = 35
        Me.btnAddStaff.Text = "Add staff"
        Me.btnAddStaff.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(278, 516)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(240, 43)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "Save Information"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btmSearch
        '
        Me.btmSearch.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btmSearch.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmSearch.Location = New System.Drawing.Point(143, 614)
        Me.btmSearch.Name = "btmSearch"
        Me.btmSearch.Size = New System.Drawing.Size(240, 48)
        Me.btmSearch.TabIndex = 36
        Me.btmSearch.Text = "Search"
        Me.btmSearch.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(83, 198)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(402, 290)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 228)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(218, 26)
        Me.TextBox1.TabIndex = 36
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 112)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(218, 26)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(153, 189)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(218, 26)
        Me.TextBox3.TabIndex = 35
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(153, 148)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(218, 26)
        Me.TextBox4.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 151)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Responsibilities"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 231)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Availability"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Working Hours"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(155, 32)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(218, 26)
        Me.TextBox5.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 120)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Job Title"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(155, 72)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(218, 26)
        Me.TextBox6.TabIndex = 4
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 709)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btmSearch)
        Me.Controls.Add(Me.btnAddStaff)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbTemporary)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtbName)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.cbxParttime)
        Me.Controls.Add(Me.cbxFulltime)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.lblStaff)
        Me.Name = "StaffForm"
        Me.Text = "Staff Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStaff As Label
    Friend WithEvents cbxParttime As CheckBox
    Friend WithEvents cbxFulltime As CheckBox
    Friend WithEvents LblStatus As Label
    Friend WithEvents txtbName As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents cbTemporary As CheckBox
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btmSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
