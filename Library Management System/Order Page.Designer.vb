<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderPage
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
        Me.txtbID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxOrder = New System.Windows.Forms.GroupBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtbNumber = New System.Windows.Forms.TextBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbDeliveryDate = New System.Windows.Forms.TextBox()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.txtbOrderNumber = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtbOrderDate = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtbEmail = New System.Windows.Forms.TextBox()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.txtbPostcode = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtbAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxCustomer = New System.Windows.Forms.TextBox()
        Me.gbxDelivery = New System.Windows.Forms.GroupBox()
        Me.cbxDelivery = New System.Windows.Forms.CheckedListBox()
        Me.gpMethod = New System.Windows.Forms.GroupBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.gbTotal = New System.Windows.Forms.GroupBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.txtbTotal = New System.Windows.Forms.TextBox()
        Me.lblShippingCountry = New System.Windows.Forms.Label()
        Me.txtbShippingCountry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbShippingCity = New System.Windows.Forms.TextBox()
        Me.lblShippingPostcode = New System.Windows.Forms.Label()
        Me.txtbShippingPostcode = New System.Windows.Forms.TextBox()
        Me.lblShippingAddress = New System.Windows.Forms.Label()
        Me.txtbShippingAddress = New System.Windows.Forms.TextBox()
        Me.gbxOrder.SuspendLayout()
        Me.gbxDelivery.SuspendLayout()
        Me.gpMethod.SuspendLayout()
        Me.gbTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbID
        '
        Me.txtbID.Location = New System.Drawing.Point(367, 50)
        Me.txtbID.Name = "txtbID"
        Me.txtbID.Size = New System.Drawing.Size(240, 26)
        Me.txtbID.TabIndex = 0
        Me.txtbID.Tag = "N/A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "N/A"
        Me.Label1.Text = "Order ID"
        '
        'gbxOrder
        '
        Me.gbxOrder.Controls.Add(Me.lblPhone)
        Me.gbxOrder.Controls.Add(Me.txtbNumber)
        Me.gbxOrder.Controls.Add(Me.lblCustomer)
        Me.gbxOrder.Controls.Add(Me.Label8)
        Me.gbxOrder.Controls.Add(Me.txtbDeliveryDate)
        Me.gbxOrder.Controls.Add(Me.lblOrderNumber)
        Me.gbxOrder.Controls.Add(Me.txtbOrderNumber)
        Me.gbxOrder.Controls.Add(Me.lblDate)
        Me.gbxOrder.Controls.Add(Me.txtbOrderDate)
        Me.gbxOrder.Controls.Add(Me.lblEmail)
        Me.gbxOrder.Controls.Add(Me.txtbEmail)
        Me.gbxOrder.Controls.Add(Me.lblPostcode)
        Me.gbxOrder.Controls.Add(Me.txtbPostcode)
        Me.gbxOrder.Controls.Add(Me.lblAddress)
        Me.gbxOrder.Controls.Add(Me.txtbAddress)
        Me.gbxOrder.Controls.Add(Me.Label2)
        Me.gbxOrder.Controls.Add(Me.txtboxCustomer)
        Me.gbxOrder.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOrder.Location = New System.Drawing.Point(47, 141)
        Me.gbxOrder.Name = "gbxOrder"
        Me.gbxOrder.Size = New System.Drawing.Size(775, 238)
        Me.gbxOrder.TabIndex = 2
        Me.gbxOrder.TabStop = False
        Me.gbxOrder.Text = "Order Summary"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(7, 193)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(128, 18)
        Me.lblPhone.TabIndex = 15
        Me.lblPhone.Text = "Phone Number"
        '
        'txtbNumber
        '
        Me.txtbNumber.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbNumber.Location = New System.Drawing.Point(156, 190)
        Me.txtbNumber.Name = "txtbNumber"
        Me.txtbNumber.Size = New System.Drawing.Size(200, 26)
        Me.txtbNumber.TabIndex = 16
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(7, 39)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(142, 18)
        Me.lblCustomer.TabIndex = 14
        Me.lblCustomer.Text = "Customer Name "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(396, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Ex. Delivery Date"
        '
        'txtbDeliveryDate
        '
        Me.txtbDeliveryDate.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbDeliveryDate.Location = New System.Drawing.Point(546, 110)
        Me.txtbDeliveryDate.Name = "txtbDeliveryDate"
        Me.txtbDeliveryDate.Size = New System.Drawing.Size(200, 26)
        Me.txtbDeliveryDate.TabIndex = 5
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNumber.Location = New System.Drawing.Point(405, 79)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(125, 18)
        Me.lblOrderNumber.TabIndex = 12
        Me.lblOrderNumber.Text = "Order Number"
        '
        'txtbOrderNumber
        '
        Me.txtbOrderNumber.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbOrderNumber.Location = New System.Drawing.Point(546, 76)
        Me.txtbOrderNumber.Name = "txtbOrderNumber"
        Me.txtbOrderNumber.Size = New System.Drawing.Size(200, 26)
        Me.txtbOrderNumber.TabIndex = 13
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(424, 39)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(96, 18)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Order Date"
        '
        'txtbOrderDate
        '
        Me.txtbOrderDate.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbOrderDate.Location = New System.Drawing.Point(546, 36)
        Me.txtbOrderDate.Name = "txtbOrderDate"
        Me.txtbOrderDate.Size = New System.Drawing.Size(200, 26)
        Me.txtbOrderDate.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(28, 155)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 18)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'txtbEmail
        '
        Me.txtbEmail.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbEmail.Location = New System.Drawing.Point(155, 152)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(200, 26)
        Me.txtbEmail.TabIndex = 9
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostcode.Location = New System.Drawing.Point(28, 118)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(80, 18)
        Me.lblPostcode.TabIndex = 6
        Me.lblPostcode.Text = "Postcode"
        '
        'txtbPostcode
        '
        Me.txtbPostcode.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPostcode.Location = New System.Drawing.Point(155, 115)
        Me.txtbPostcode.Name = "txtbPostcode"
        Me.txtbPostcode.Size = New System.Drawing.Size(200, 26)
        Me.txtbPostcode.TabIndex = 7
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(28, 82)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(73, 18)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address"
        '
        'txtbAddress
        '
        Me.txtbAddress.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbAddress.Location = New System.Drawing.Point(155, 76)
        Me.txtbAddress.Name = "txtbAddress"
        Me.txtbAddress.Size = New System.Drawing.Size(200, 26)
        Me.txtbAddress.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 3
        '
        'txtboxCustomer
        '
        Me.txtboxCustomer.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxCustomer.Location = New System.Drawing.Point(155, 36)
        Me.txtboxCustomer.Name = "txtboxCustomer"
        Me.txtboxCustomer.Size = New System.Drawing.Size(200, 26)
        Me.txtboxCustomer.TabIndex = 3
        '
        'gbxDelivery
        '
        Me.gbxDelivery.Controls.Add(Me.lblShippingCountry)
        Me.gbxDelivery.Controls.Add(Me.txtbShippingCountry)
        Me.gbxDelivery.Controls.Add(Me.Label6)
        Me.gbxDelivery.Controls.Add(Me.lblShippingPostcode)
        Me.gbxDelivery.Controls.Add(Me.txtbShippingCity)
        Me.gbxDelivery.Controls.Add(Me.lblShippingAddress)
        Me.gbxDelivery.Controls.Add(Me.txtbShippingAddress)
        Me.gbxDelivery.Controls.Add(Me.txtbShippingPostcode)
        Me.gbxDelivery.Location = New System.Drawing.Point(63, 385)
        Me.gbxDelivery.Name = "gbxDelivery"
        Me.gbxDelivery.Size = New System.Drawing.Size(419, 201)
        Me.gbxDelivery.TabIndex = 8
        Me.gbxDelivery.TabStop = False
        Me.gbxDelivery.Text = "Delivery Information"
        '
        'cbxDelivery
        '
        Me.cbxDelivery.BackColor = System.Drawing.SystemColors.Control
        Me.cbxDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cbxDelivery.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDelivery.FormattingEnabled = True
        Me.cbxDelivery.Items.AddRange(New Object() {"Express (1-2 days) : £4.99", "Tracked (3-4 days) : £2.50", "Standard (5-6 days) : Free"})
        Me.cbxDelivery.Location = New System.Drawing.Point(15, 25)
        Me.cbxDelivery.Name = "cbxDelivery"
        Me.cbxDelivery.Size = New System.Drawing.Size(265, 69)
        Me.cbxDelivery.TabIndex = 28
        '
        'gpMethod
        '
        Me.gpMethod.Controls.Add(Me.cbxDelivery)
        Me.gpMethod.Location = New System.Drawing.Point(495, 394)
        Me.gpMethod.Name = "gpMethod"
        Me.gpMethod.Size = New System.Drawing.Size(304, 117)
        Me.gpMethod.TabIndex = 29
        Me.gpMethod.TabStop = False
        Me.gpMethod.Text = "Delivery Method"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCheck.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(114, 617)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(193, 73)
        Me.btnCheck.TabIndex = 30
        Me.btnCheck.Text = "Check Order"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(338, 617)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(193, 73)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete Order"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnConfirm.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(554, 617)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(193, 73)
        Me.btnConfirm.TabIndex = 32
        Me.btnConfirm.Text = "Confirm Order"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'gbTotal
        '
        Me.gbTotal.Controls.Add(Me.LblTotal)
        Me.gbTotal.Controls.Add(Me.txtbTotal)
        Me.gbTotal.Location = New System.Drawing.Point(495, 517)
        Me.gbTotal.Name = "gbTotal"
        Me.gbTotal.Size = New System.Drawing.Size(304, 69)
        Me.gbTotal.TabIndex = 33
        Me.gbTotal.TabStop = False
        Me.gbTotal.Text = "Total"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(40, 28)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(19, 18)
        Me.LblTotal.TabIndex = 34
        Me.LblTotal.Text = "£"
        '
        'txtbTotal
        '
        Me.txtbTotal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbTotal.Location = New System.Drawing.Point(78, 25)
        Me.txtbTotal.Name = "txtbTotal"
        Me.txtbTotal.Size = New System.Drawing.Size(202, 26)
        Me.txtbTotal.TabIndex = 6
        '
        'lblShippingCountry
        '
        Me.lblShippingCountry.AutoSize = True
        Me.lblShippingCountry.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingCountry.Location = New System.Drawing.Point(68, 145)
        Me.lblShippingCountry.Name = "lblShippingCountry"
        Me.lblShippingCountry.Size = New System.Drawing.Size(74, 18)
        Me.lblShippingCountry.TabIndex = 27
        Me.lblShippingCountry.Text = "Country"
        '
        'txtbShippingCountry
        '
        Me.txtbShippingCountry.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbShippingCountry.Location = New System.Drawing.Point(180, 140)
        Me.txtbShippingCountry.Name = "txtbShippingCountry"
        Me.txtbShippingCountry.Size = New System.Drawing.Size(209, 26)
        Me.txtbShippingCountry.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "City"
        '
        'txtbShippingCity
        '
        Me.txtbShippingCity.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbShippingCity.Location = New System.Drawing.Point(178, 77)
        Me.txtbShippingCity.Name = "txtbShippingCity"
        Me.txtbShippingCity.Size = New System.Drawing.Size(209, 26)
        Me.txtbShippingCity.TabIndex = 26
        '
        'lblShippingPostcode
        '
        Me.lblShippingPostcode.AutoSize = True
        Me.lblShippingPostcode.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingPostcode.Location = New System.Drawing.Point(62, 116)
        Me.lblShippingPostcode.Name = "lblShippingPostcode"
        Me.lblShippingPostcode.Size = New System.Drawing.Size(80, 18)
        Me.lblShippingPostcode.TabIndex = 21
        Me.lblShippingPostcode.Text = "Postcode"
        '
        'txtbShippingPostcode
        '
        Me.txtbShippingPostcode.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbShippingPostcode.Location = New System.Drawing.Point(180, 108)
        Me.txtbShippingPostcode.Name = "txtbShippingPostcode"
        Me.txtbShippingPostcode.Size = New System.Drawing.Size(209, 26)
        Me.txtbShippingPostcode.TabIndex = 22
        '
        'lblShippingAddress
        '
        Me.lblShippingAddress.AutoSize = True
        Me.lblShippingAddress.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShippingAddress.Location = New System.Drawing.Point(40, 53)
        Me.lblShippingAddress.Name = "lblShippingAddress"
        Me.lblShippingAddress.Size = New System.Drawing.Size(124, 18)
        Me.lblShippingAddress.TabIndex = 19
        Me.lblShippingAddress.Text = "Street Address"
        '
        'txtbShippingAddress
        '
        Me.txtbShippingAddress.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbShippingAddress.Location = New System.Drawing.Point(178, 45)
        Me.txtbShippingAddress.Name = "txtbShippingAddress"
        Me.txtbShippingAddress.Size = New System.Drawing.Size(209, 26)
        Me.txtbShippingAddress.TabIndex = 20
        '
        'OrderPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 773)
        Me.Controls.Add(Me.gbTotal)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.gpMethod)
        Me.Controls.Add(Me.gbxDelivery)
        Me.Controls.Add(Me.gbxOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbID)
        Me.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "OrderPage"
        Me.Text = "Order Page"
        Me.gbxOrder.ResumeLayout(False)
        Me.gbxOrder.PerformLayout()
        Me.gbxDelivery.ResumeLayout(False)
        Me.gbxDelivery.PerformLayout()
        Me.gpMethod.ResumeLayout(False)
        Me.gbTotal.ResumeLayout(False)
        Me.gbTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbxOrder As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxCustomer As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtbEmail As TextBox
    Friend WithEvents lblPostcode As Label
    Friend WithEvents txtbPostcode As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtbAddress As TextBox
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents txtbOrderNumber As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtbOrderDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbDeliveryDate As TextBox
    Friend WithEvents gbxDelivery As GroupBox
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtbNumber As TextBox
    Friend WithEvents cbxDelivery As CheckedListBox
    Friend WithEvents gpMethod As GroupBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents gbTotal As GroupBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents txtbTotal As TextBox
    Friend WithEvents lblShippingCountry As Label
    Friend WithEvents txtbShippingCountry As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbShippingCity As TextBox
    Friend WithEvents lblShippingPostcode As Label
    Friend WithEvents txtbShippingPostcode As TextBox
    Friend WithEvents lblShippingAddress As Label
    Friend WithEvents txtbShippingAddress As TextBox
End Class
