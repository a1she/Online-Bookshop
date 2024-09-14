<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Staff
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
        Me.txtbName = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.GdPersonal = New System.Windows.Forms.GroupBox()
        Me.txtbAvailability = New System.Windows.Forms.TextBox()
        Me.txtbJob = New System.Windows.Forms.TextBox()
        Me.txtbWork = New System.Windows.Forms.TextBox()
        Me.txtbResponsibilities = New System.Windows.Forms.TextBox()
        Me.lblResponsibilities = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblWork = New System.Windows.Forms.Label()
        Me.txtb1email = New System.Windows.Forms.TextBox()
        Me.lblJob = New System.Windows.Forms.Label()
        Me.txtbNumber = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GdPersonal.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbName
        '
        Me.txtbName.Location = New System.Drawing.Point(227, 42)
        Me.txtbName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbName.Name = "txtbName"
        Me.txtbName.Size = New System.Drawing.Size(214, 26)
        Me.txtbName.TabIndex = 39
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(117, 50)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(94, 18)
        Me.lblname.TabIndex = 38
        Me.lblname.Text = "Full Name"
        '
        'GdPersonal
        '
        Me.GdPersonal.Controls.Add(Me.txtbAvailability)
        Me.GdPersonal.Controls.Add(Me.txtbJob)
        Me.GdPersonal.Controls.Add(Me.txtbWork)
        Me.GdPersonal.Controls.Add(Me.txtbResponsibilities)
        Me.GdPersonal.Controls.Add(Me.lblResponsibilities)
        Me.GdPersonal.Controls.Add(Me.lblNumber)
        Me.GdPersonal.Controls.Add(Me.lblAvailability)
        Me.GdPersonal.Controls.Add(Me.lblEmail)
        Me.GdPersonal.Controls.Add(Me.lblWork)
        Me.GdPersonal.Controls.Add(Me.txtb1email)
        Me.GdPersonal.Controls.Add(Me.lblJob)
        Me.GdPersonal.Controls.Add(Me.txtbNumber)
        Me.GdPersonal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GdPersonal.Location = New System.Drawing.Point(66, 89)
        Me.GdPersonal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GdPersonal.Name = "GdPersonal"
        Me.GdPersonal.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GdPersonal.Size = New System.Drawing.Size(402, 290)
        Me.GdPersonal.TabIndex = 34
        Me.GdPersonal.TabStop = False
        Me.GdPersonal.Text = "Personal Information"
        '
        'txtbAvailability
        '
        Me.txtbAvailability.Location = New System.Drawing.Point(153, 228)
        Me.txtbAvailability.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbAvailability.Name = "txtbAvailability"
        Me.txtbAvailability.Size = New System.Drawing.Size(218, 26)
        Me.txtbAvailability.TabIndex = 36
        '
        'txtbJob
        '
        Me.txtbJob.Location = New System.Drawing.Point(153, 112)
        Me.txtbJob.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbJob.Name = "txtbJob"
        Me.txtbJob.Size = New System.Drawing.Size(218, 26)
        Me.txtbJob.TabIndex = 16
        '
        'txtbWork
        '
        Me.txtbWork.Location = New System.Drawing.Point(153, 189)
        Me.txtbWork.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbWork.Name = "txtbWork"
        Me.txtbWork.Size = New System.Drawing.Size(218, 26)
        Me.txtbWork.TabIndex = 35
        '
        'txtbResponsibilities
        '
        Me.txtbResponsibilities.Location = New System.Drawing.Point(153, 148)
        Me.txtbResponsibilities.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbResponsibilities.Name = "txtbResponsibilities"
        Me.txtbResponsibilities.Size = New System.Drawing.Size(218, 26)
        Me.txtbResponsibilities.TabIndex = 33
        '
        'lblResponsibilities
        '
        Me.lblResponsibilities.AutoSize = True
        Me.lblResponsibilities.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsibilities.Location = New System.Drawing.Point(6, 151)
        Me.lblResponsibilities.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResponsibilities.Name = "lblResponsibilities"
        Me.lblResponsibilities.Size = New System.Drawing.Size(134, 18)
        Me.lblResponsibilities.TabIndex = 34
        Me.lblResponsibilities.Text = "Responsibilities"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(12, 75)
        Me.lblNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(128, 18)
        Me.lblNumber.TabIndex = 17
        Me.lblNumber.Text = "Phone Number"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailability.Location = New System.Drawing.Point(28, 231)
        Me.lblAvailability.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(98, 18)
        Me.lblAvailability.TabIndex = 32
        Me.lblAvailability.Text = "Availability"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(47, 35)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 18)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'lblWork
        '
        Me.lblWork.AutoSize = True
        Me.lblWork.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWork.Location = New System.Drawing.Point(15, 192)
        Me.lblWork.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWork.Name = "lblWork"
        Me.lblWork.Size = New System.Drawing.Size(130, 18)
        Me.lblWork.TabIndex = 31
        Me.lblWork.Text = "Working Hours"
        '
        'txtb1email
        '
        Me.txtb1email.Location = New System.Drawing.Point(155, 32)
        Me.txtb1email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtb1email.Name = "txtb1email"
        Me.txtb1email.Size = New System.Drawing.Size(218, 26)
        Me.txtb1email.TabIndex = 3
        '
        'lblJob
        '
        Me.lblJob.AutoSize = True
        Me.lblJob.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJob.Location = New System.Drawing.Point(28, 120)
        Me.lblJob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJob.Name = "lblJob"
        Me.lblJob.Size = New System.Drawing.Size(76, 18)
        Me.lblJob.TabIndex = 5
        Me.lblJob.Text = "Job Title"
        '
        'txtbNumber
        '
        Me.txtbNumber.Location = New System.Drawing.Point(155, 72)
        Me.txtbNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbNumber.Name = "txtbNumber"
        Me.txtbNumber.Size = New System.Drawing.Size(218, 26)
        Me.txtbNumber.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnSave.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(258, 396)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(240, 43)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Confirm"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnEdit.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(12, 396)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(240, 43)
        Me.btnEdit.TabIndex = 41
        Me.btnEdit.Text = "Cancel"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Add_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 490)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtbName)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.GdPersonal)
        Me.Name = "Add_Staff"
        Me.Text = "Add_Staff"
        Me.GdPersonal.ResumeLayout(False)
        Me.GdPersonal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbName As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents GdPersonal As GroupBox
    Friend WithEvents txtbAvailability As TextBox
    Friend WithEvents txtbJob As TextBox
    Friend WithEvents txtbWork As TextBox
    Friend WithEvents txtbResponsibilities As TextBox
    Friend WithEvents lblResponsibilities As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblWork As Label
    Friend WithEvents txtb1email As TextBox
    Friend WithEvents lblJob As Label
    Friend WithEvents txtbNumber As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
End Class
