<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentDetails
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
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtbCardNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbCVV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gpbShipping = New System.Windows.Forms.GroupBox()
        Me.lblShippingCountry = New System.Windows.Forms.Label()
        Me.txtbShippingCountry = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbShippingCity = New System.Windows.Forms.TextBox()
        Me.lblShippingPostcode = New System.Windows.Forms.Label()
        Me.txtbShippingPostcode = New System.Windows.Forms.TextBox()
        Me.lblShippingAddress = New System.Windows.Forms.Label()
        Me.txtbShippingAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.btnRviewOrder = New System.Windows.Forms.Button()
        Me.lblPurchase = New System.Windows.Forms.Label()
        Me.gpbShipping.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(197, 31)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(88, 18)
        Me.lblFirstname.TabIndex = 0
        Me.lblFirstname.Text = "Firstname"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(174, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 26)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(329, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 26)
        Me.TextBox2.TabIndex = 3
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(361, 31)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(80, 18)
        Me.lblSurname.TabIndex = 2
        Me.lblSurname.Text = "Surname"
        '
        'txtbCardNumber
        '
        Me.txtbCardNumber.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbCardNumber.Location = New System.Drawing.Point(174, 38)
        Me.txtbCardNumber.Name = "txtbCardNumber"
        Me.txtbCardNumber.Size = New System.Drawing.Size(297, 26)
        Me.txtbCardNumber.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Card Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Expiry Date"
        '
        'txtbCVV
        '
        Me.txtbCVV.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbCVV.Location = New System.Drawing.Point(174, 120)
        Me.txtbCVV.Name = "txtbCVV"
        Me.txtbCVV.Size = New System.Drawing.Size(140, 26)
        Me.txtbCVV.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CVV Code"
        '
        'gpbShipping
        '
        Me.gpbShipping.Controls.Add(Me.lblShippingCountry)
        Me.gpbShipping.Controls.Add(Me.txtbShippingCountry)
        Me.gpbShipping.Controls.Add(Me.lblName)
        Me.gpbShipping.Controls.Add(Me.Label6)
        Me.gpbShipping.Controls.Add(Me.txtbShippingCity)
        Me.gpbShipping.Controls.Add(Me.lblShippingPostcode)
        Me.gpbShipping.Controls.Add(Me.txtbShippingPostcode)
        Me.gpbShipping.Controls.Add(Me.lblShippingAddress)
        Me.gpbShipping.Controls.Add(Me.txtbShippingAddress)
        Me.gpbShipping.Controls.Add(Me.lblFirstname)
        Me.gpbShipping.Controls.Add(Me.TextBox1)
        Me.gpbShipping.Controls.Add(Me.lblSurname)
        Me.gpbShipping.Controls.Add(Me.TextBox2)
        Me.gpbShipping.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbShipping.Location = New System.Drawing.Point(51, 102)
        Me.gpbShipping.Name = "gpbShipping"
        Me.gpbShipping.Size = New System.Drawing.Size(529, 239)
        Me.gpbShipping.TabIndex = 10
        Me.gpbShipping.TabStop = False
        Me.gpbShipping.Text = "Billing Details"
        '
        'lblShippingCountry
        '
        Me.lblShippingCountry.AutoSize = True
        Me.lblShippingCountry.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingCountry.Location = New System.Drawing.Point(70, 180)
        Me.lblShippingCountry.Name = "lblShippingCountry"
        Me.lblShippingCountry.Size = New System.Drawing.Size(74, 18)
        Me.lblShippingCountry.TabIndex = 17
        Me.lblShippingCountry.Text = "Country"
        '
        'txtbShippingCountry
        '
        Me.txtbShippingCountry.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbShippingCountry.Location = New System.Drawing.Point(174, 180)
        Me.txtbShippingCountry.Name = "txtbShippingCountry"
        Me.txtbShippingCountry.Size = New System.Drawing.Size(297, 26)
        Me.txtbShippingCountry.TabIndex = 18
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(83, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 18)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "City"
        '
        'txtbShippingCity
        '
        Me.txtbShippingCity.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbShippingCity.Location = New System.Drawing.Point(174, 116)
        Me.txtbShippingCity.Name = "txtbShippingCity"
        Me.txtbShippingCity.Size = New System.Drawing.Size(297, 26)
        Me.txtbShippingCity.TabIndex = 15
        '
        'lblShippingPostcode
        '
        Me.lblShippingPostcode.AutoSize = True
        Me.lblShippingPostcode.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingPostcode.Location = New System.Drawing.Point(64, 151)
        Me.lblShippingPostcode.Name = "lblShippingPostcode"
        Me.lblShippingPostcode.Size = New System.Drawing.Size(80, 18)
        Me.lblShippingPostcode.TabIndex = 10
        Me.lblShippingPostcode.Text = "Postcode"
        '
        'txtbShippingPostcode
        '
        Me.txtbShippingPostcode.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbShippingPostcode.Location = New System.Drawing.Point(174, 148)
        Me.txtbShippingPostcode.Name = "txtbShippingPostcode"
        Me.txtbShippingPostcode.Size = New System.Drawing.Size(297, 26)
        Me.txtbShippingPostcode.TabIndex = 11
        '
        'lblShippingAddress
        '
        Me.lblShippingAddress.AutoSize = True
        Me.lblShippingAddress.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingAddress.Location = New System.Drawing.Point(44, 87)
        Me.lblShippingAddress.Name = "lblShippingAddress"
        Me.lblShippingAddress.Size = New System.Drawing.Size(124, 18)
        Me.lblShippingAddress.TabIndex = 8
        Me.lblShippingAddress.Text = "Street Address"
        '
        'txtbShippingAddress
        '
        Me.txtbShippingAddress.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbShippingAddress.Location = New System.Drawing.Point(174, 84)
        Me.txtbShippingAddress.Name = "txtbShippingAddress"
        Me.txtbShippingAddress.Size = New System.Drawing.Size(297, 26)
        Me.txtbShippingAddress.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpExpiryDate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtbCardNumber)
        Me.GroupBox2.Controls.Add(Me.txtbCVV)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(51, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(529, 183)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Card Details"
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpiryDate.Location = New System.Drawing.Point(174, 79)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(200, 26)
        Me.dtpExpiryDate.TabIndex = 10
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.Location = New System.Drawing.Point(51, 568)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(252, 62)
        Me.btnConfirmPayment.TabIndex = 34
        Me.btnConfirmPayment.Text = "Confirm Payment"
        Me.btnConfirmPayment.UseVisualStyleBackColor = False
        '
        'btnRviewOrder
        '
        Me.btnRviewOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRviewOrder.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRviewOrder.Location = New System.Drawing.Point(309, 568)
        Me.btnRviewOrder.Name = "btnRviewOrder"
        Me.btnRviewOrder.Size = New System.Drawing.Size(252, 62)
        Me.btnRviewOrder.TabIndex = 36
        Me.btnRviewOrder.Text = "Back to Review Order"
        Me.btnRviewOrder.UseVisualStyleBackColor = False
        '
        'lblPurchase
        '
        Me.lblPurchase.AutoSize = True
        Me.lblPurchase.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblPurchase.Font = New System.Drawing.Font("Lucida Fax", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchase.Location = New System.Drawing.Point(121, 40)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(379, 32)
        Me.lblPurchase.TabIndex = 37
        Me.lblPurchase.Text = "Complete Your Purchase"
        '
        'PaymentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 695)
        Me.Controls.Add(Me.lblPurchase)
        Me.Controls.Add(Me.btnRviewOrder)
        Me.Controls.Add(Me.btnConfirmPayment)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpbShipping)
        Me.Name = "PaymentDetails"
        Me.Text = "Payment Details"
        Me.gpbShipping.ResumeLayout(False)
        Me.gpbShipping.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstname As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtbCardNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbCVV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents gpbShipping As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbShippingCity As TextBox
    Friend WithEvents lblShippingPostcode As Label
    Friend WithEvents txtbShippingPostcode As TextBox
    Friend WithEvents lblShippingAddress As Label
    Friend WithEvents txtbShippingAddress As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpExpiryDate As DateTimePicker
    Friend WithEvents lblName As Label
    Friend WithEvents lblShippingCountry As Label
    Friend WithEvents txtbShippingCountry As TextBox
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents btnRviewOrder As Button
    Friend WithEvents lblPurchase As Label
End Class
