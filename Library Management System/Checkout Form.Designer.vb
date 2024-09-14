<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckoutForm
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
        Me.lblReviewOrder = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblGrandtotal = New System.Windows.Forms.Label()
        Me.txtbPromoCode = New System.Windows.Forms.TextBox()
        Me.lblPromoCode = New System.Windows.Forms.Label()
        Me.txtbGrandTotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtbSubtotal = New System.Windows.Forms.TextBox()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.txtbDelivery = New System.Windows.Forms.TextBox()
        Me.GpMethod = New System.Windows.Forms.GroupBox()
        Me.cbxDelivery = New System.Windows.Forms.CheckedListBox()
        Me.btnExtraItems = New System.Windows.Forms.Button()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.BtnCalcelOrder = New System.Windows.Forms.Button()
        Me.ORderPic = New System.Windows.Forms.PictureBox()
        Me.txtbOrderName = New System.Windows.Forms.TextBox()
        Me.lblOrderNAme = New System.Windows.Forms.Label()
        Me.txtbOrderAuthor = New System.Windows.Forms.TextBox()
        Me.lblOrderAuther = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbHardBack = New System.Windows.Forms.RadioButton()
        Me.rbPaperback = New System.Windows.Forms.RadioButton()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblProductTotal = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.gpOrderSummary = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GpMethod.SuspendLayout()
        CType(Me.ORderPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpOrderSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReviewOrder
        '
        Me.lblReviewOrder.AutoSize = True
        Me.lblReviewOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblReviewOrder.Font = New System.Drawing.Font("Lucida Fax", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviewOrder.Location = New System.Drawing.Point(311, 47)
        Me.lblReviewOrder.Name = "lblReviewOrder"
        Me.lblReviewOrder.Size = New System.Drawing.Size(198, 22)
        Me.lblReviewOrder.TabIndex = 0
        Me.lblReviewOrder.Text = "Review Your Order"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblGrandtotal)
        Me.GroupBox2.Controls.Add(Me.txtbPromoCode)
        Me.GroupBox2.Controls.Add(Me.lblPromoCode)
        Me.GroupBox2.Controls.Add(Me.txtbGrandTotal)
        Me.GroupBox2.Controls.Add(Me.lblSubtotal)
        Me.GroupBox2.Controls.Add(Me.txtbSubtotal)
        Me.GroupBox2.Controls.Add(Me.lblDelivery)
        Me.GroupBox2.Controls.Add(Me.txtbDelivery)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(198, 431)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(529, 173)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Billing Summary"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(283, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 14)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "£"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(283, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 14)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "£"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(283, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 14)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "£"
        '
        'lblGrandtotal
        '
        Me.lblGrandtotal.AutoSize = True
        Me.lblGrandtotal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandtotal.Location = New System.Drawing.Point(52, 135)
        Me.lblGrandtotal.Name = "lblGrandtotal"
        Me.lblGrandtotal.Size = New System.Drawing.Size(65, 14)
        Me.lblGrandtotal.TabIndex = 12
        Me.lblGrandtotal.Text = "Grandtotal"
        '
        'txtbPromoCode
        '
        Me.txtbPromoCode.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPromoCode.Location = New System.Drawing.Point(307, 95)
        Me.txtbPromoCode.Name = "txtbPromoCode"
        Me.txtbPromoCode.Size = New System.Drawing.Size(100, 20)
        Me.txtbPromoCode.TabIndex = 11
        '
        'lblPromoCode
        '
        Me.lblPromoCode.AutoSize = True
        Me.lblPromoCode.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromoCode.Location = New System.Drawing.Point(52, 103)
        Me.lblPromoCode.Name = "lblPromoCode"
        Me.lblPromoCode.Size = New System.Drawing.Size(121, 14)
        Me.lblPromoCode.TabIndex = 10
        Me.lblPromoCode.Text = "Add Promotion Code"
        '
        'txtbGrandTotal
        '
        Me.txtbGrandTotal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbGrandTotal.Location = New System.Drawing.Point(307, 127)
        Me.txtbGrandTotal.Name = "txtbGrandTotal"
        Me.txtbGrandTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtbGrandTotal.TabIndex = 9
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(52, 40)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(52, 14)
        Me.lblSubtotal.TabIndex = 8
        Me.lblSubtotal.Text = "Subtotal"
        '
        'txtbSubtotal
        '
        Me.txtbSubtotal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbSubtotal.Location = New System.Drawing.Point(307, 32)
        Me.txtbSubtotal.Name = "txtbSubtotal"
        Me.txtbSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtbSubtotal.TabIndex = 7
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivery.Location = New System.Drawing.Point(52, 72)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(55, 14)
        Me.lblDelivery.TabIndex = 6
        Me.lblDelivery.Text = "Delivery"
        '
        'txtbDelivery
        '
        Me.txtbDelivery.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbDelivery.Location = New System.Drawing.Point(307, 64)
        Me.txtbDelivery.Name = "txtbDelivery"
        Me.txtbDelivery.Size = New System.Drawing.Size(100, 20)
        Me.txtbDelivery.TabIndex = 5
        '
        'GpMethod
        '
        Me.GpMethod.Controls.Add(Me.cbxDelivery)
        Me.GpMethod.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpMethod.Location = New System.Drawing.Point(592, 225)
        Me.GpMethod.Name = "GpMethod"
        Me.GpMethod.Size = New System.Drawing.Size(304, 182)
        Me.GpMethod.TabIndex = 30
        Me.GpMethod.TabStop = False
        Me.GpMethod.Text = "Delivery Method"
        '
        'cbxDelivery
        '
        Me.cbxDelivery.BackColor = System.Drawing.SystemColors.Control
        Me.cbxDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cbxDelivery.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDelivery.FormattingEnabled = True
        Me.cbxDelivery.Items.AddRange(New Object() {"Express (1-2 days) : £4.99", "Tracked (3-4 days) : £2.50", "Standard (5-6 days) : Free"})
        Me.cbxDelivery.Location = New System.Drawing.Point(16, 59)
        Me.cbxDelivery.Name = "cbxDelivery"
        Me.cbxDelivery.Size = New System.Drawing.Size(265, 60)
        Me.cbxDelivery.TabIndex = 28
        '
        'btnExtraItems
        '
        Me.btnExtraItems.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnExtraItems.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtraItems.Location = New System.Drawing.Point(642, 136)
        Me.btnExtraItems.Name = "btnExtraItems"
        Me.btnExtraItems.Size = New System.Drawing.Size(213, 73)
        Me.btnExtraItems.TabIndex = 31
        Me.btnExtraItems.Text = "Add Extra Items"
        Me.btnExtraItems.UseVisualStyleBackColor = False
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnProcessOrder.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessOrder.Location = New System.Drawing.Point(84, 648)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(354, 62)
        Me.btnProcessOrder.TabIndex = 32
        Me.btnProcessOrder.Text = "Continue to Payment"
        Me.btnProcessOrder.UseVisualStyleBackColor = False
        '
        'BtnCalcelOrder
        '
        Me.BtnCalcelOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnCalcelOrder.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcelOrder.Location = New System.Drawing.Point(542, 648)
        Me.BtnCalcelOrder.Name = "BtnCalcelOrder"
        Me.BtnCalcelOrder.Size = New System.Drawing.Size(354, 62)
        Me.BtnCalcelOrder.TabIndex = 33
        Me.BtnCalcelOrder.Text = "Cancel Order"
        Me.BtnCalcelOrder.UseVisualStyleBackColor = False
        '
        'ORderPic
        '
        Me.ORderPic.Location = New System.Drawing.Point(25, 46)
        Me.ORderPic.Name = "ORderPic"
        Me.ORderPic.Size = New System.Drawing.Size(111, 135)
        Me.ORderPic.TabIndex = 1
        Me.ORderPic.TabStop = False
        '
        'txtbOrderName
        '
        Me.txtbOrderName.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbOrderName.Location = New System.Drawing.Point(241, 35)
        Me.txtbOrderName.Name = "txtbOrderName"
        Me.txtbOrderName.Size = New System.Drawing.Size(184, 20)
        Me.txtbOrderName.TabIndex = 3
        '
        'lblOrderNAme
        '
        Me.lblOrderNAme.AutoSize = True
        Me.lblOrderNAme.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNAme.Location = New System.Drawing.Point(176, 38)
        Me.lblOrderNAme.Name = "lblOrderNAme"
        Me.lblOrderNAme.Size = New System.Drawing.Size(41, 14)
        Me.lblOrderNAme.TabIndex = 4
        Me.lblOrderNAme.Text = "Name:"
        '
        'txtbOrderAuthor
        '
        Me.txtbOrderAuthor.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbOrderAuthor.Location = New System.Drawing.Point(241, 74)
        Me.txtbOrderAuthor.Name = "txtbOrderAuthor"
        Me.txtbOrderAuthor.Size = New System.Drawing.Size(184, 20)
        Me.txtbOrderAuthor.TabIndex = 5
        '
        'lblOrderAuther
        '
        Me.lblOrderAuther.AutoSize = True
        Me.lblOrderAuther.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderAuther.Location = New System.Drawing.Point(171, 74)
        Me.lblOrderAuther.Name = "lblOrderAuther"
        Me.lblOrderAuther.Size = New System.Drawing.Size(45, 14)
        Me.lblOrderAuther.TabIndex = 6
        Me.lblOrderAuther.Text = "Author"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 14)
        Me.Label5.TabIndex = 8
        '
        'rbHardBack
        '
        Me.rbHardBack.AutoSize = True
        Me.rbHardBack.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHardBack.Location = New System.Drawing.Point(179, 120)
        Me.rbHardBack.Name = "rbHardBack"
        Me.rbHardBack.Size = New System.Drawing.Size(78, 18)
        Me.rbHardBack.TabIndex = 3
        Me.rbHardBack.TabStop = True
        Me.rbHardBack.Text = "Hardback"
        Me.rbHardBack.UseVisualStyleBackColor = True
        '
        'rbPaperback
        '
        Me.rbPaperback.AutoSize = True
        Me.rbPaperback.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPaperback.Location = New System.Drawing.Point(296, 122)
        Me.rbPaperback.Name = "rbPaperback"
        Me.rbPaperback.Size = New System.Drawing.Size(81, 18)
        Me.rbPaperback.TabIndex = 4
        Me.rbPaperback.TabStop = True
        Me.rbPaperback.Text = "Paperback"
        Me.rbPaperback.UseVisualStyleBackColor = True
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.Location = New System.Drawing.Point(182, 175)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(58, 14)
        Me.LblQuantity.TabIndex = 10
        Me.LblQuantity.Text = "Quantity:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(272, 206)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 20)
        Me.TextBox4.TabIndex = 11
        '
        'lblProductTotal
        '
        Me.lblProductTotal.AutoSize = True
        Me.lblProductTotal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductTotal.Location = New System.Drawing.Point(231, 214)
        Me.lblProductTotal.Name = "lblProductTotal"
        Me.lblProductTotal.Size = New System.Drawing.Size(14, 14)
        Me.lblProductTotal.TabIndex = 12
        Me.lblProductTotal.Text = "£"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "10+"})
        Me.ComboBox1.Location = New System.Drawing.Point(272, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 0
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnDeleteOrder.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrder.Location = New System.Drawing.Point(25, 198)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(111, 62)
        Me.btnDeleteOrder.TabIndex = 32
        Me.btnDeleteOrder.Text = "Delete Product"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'gpOrderSummary
        '
        Me.gpOrderSummary.Controls.Add(Me.btnDeleteOrder)
        Me.gpOrderSummary.Controls.Add(Me.ComboBox1)
        Me.gpOrderSummary.Controls.Add(Me.lblProductTotal)
        Me.gpOrderSummary.Controls.Add(Me.TextBox4)
        Me.gpOrderSummary.Controls.Add(Me.LblQuantity)
        Me.gpOrderSummary.Controls.Add(Me.rbPaperback)
        Me.gpOrderSummary.Controls.Add(Me.rbHardBack)
        Me.gpOrderSummary.Controls.Add(Me.Label5)
        Me.gpOrderSummary.Controls.Add(Me.lblOrderAuther)
        Me.gpOrderSummary.Controls.Add(Me.txtbOrderAuthor)
        Me.gpOrderSummary.Controls.Add(Me.lblOrderNAme)
        Me.gpOrderSummary.Controls.Add(Me.txtbOrderName)
        Me.gpOrderSummary.Controls.Add(Me.ORderPic)
        Me.gpOrderSummary.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpOrderSummary.Location = New System.Drawing.Point(59, 117)
        Me.gpOrderSummary.Name = "gpOrderSummary"
        Me.gpOrderSummary.Size = New System.Drawing.Size(517, 290)
        Me.gpOrderSummary.TabIndex = 2
        Me.gpOrderSummary.TabStop = False
        Me.gpOrderSummary.Text = "Order Summary"
        '
        'CheckoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 754)
        Me.Controls.Add(Me.BtnCalcelOrder)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.btnExtraItems)
        Me.Controls.Add(Me.GpMethod)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpOrderSummary)
        Me.Controls.Add(Me.lblReviewOrder)
        Me.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CheckoutForm"
        Me.Text = "Checkout Form"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GpMethod.ResumeLayout(False)
        CType(Me.ORderPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpOrderSummary.ResumeLayout(False)
        Me.gpOrderSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblReviewOrder As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GpMethod As GroupBox
    Friend WithEvents cbxDelivery As CheckedListBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtbSubtotal As TextBox
    Friend WithEvents lblDelivery As Label
    Friend WithEvents txtbDelivery As TextBox
    Friend WithEvents btnExtraItems As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblGrandtotal As Label
    Friend WithEvents txtbPromoCode As TextBox
    Friend WithEvents lblPromoCode As Label
    Friend WithEvents txtbGrandTotal As TextBox
    Friend WithEvents btnProcessOrder As Button
    Friend WithEvents BtnCalcelOrder As Button
    Friend WithEvents ORderPic As PictureBox
    Friend WithEvents txtbOrderName As TextBox
    Friend WithEvents lblOrderNAme As Label
    Friend WithEvents txtbOrderAuthor As TextBox
    Friend WithEvents lblOrderAuther As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbHardBack As RadioButton
    Friend WithEvents rbPaperback As RadioButton
    Friend WithEvents LblQuantity As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblProductTotal As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents gpOrderSummary As GroupBox
End Class
