<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtbUsername = New System.Windows.Forms.TextBox()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.LblRegister = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        resources.ApplyResources(Me.lblUsername, "lblUsername")
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsername.Name = "lblUsername"
        '
        'lblPassword
        '
        resources.ApplyResources(Me.lblPassword, "lblPassword")
        Me.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPassword.Name = "lblPassword"
        '
        'txtbUsername
        '
        resources.ApplyResources(Me.txtbUsername, "txtbUsername")
        Me.txtbUsername.Name = "txtbUsername"
        '
        'txtbPassword
        '
        resources.ApplyResources(Me.txtbPassword, "txtbPassword")
        Me.txtbPassword.Name = "txtbPassword"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        resources.ApplyResources(Me.btnLogin, "btnLogin")
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        resources.ApplyResources(Me.btnRegister, "btnRegister")
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'lbllogin
        '
        resources.ApplyResources(Me.lbllogin, "lbllogin")
        Me.lbllogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbllogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbllogin.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbllogin.Name = "lbllogin"
        '
        'LblRegister
        '
        resources.ApplyResources(Me.LblRegister, "LblRegister")
        Me.LblRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRegister.Name = "LblRegister"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblRegister)
        Me.Controls.Add(Me.lbllogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtbPassword)
        Me.Controls.Add(Me.txtbUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtbUsername As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lbllogin As Label
    Friend WithEvents LblRegister As Label
    Friend WithEvents Button1 As Button
End Class
