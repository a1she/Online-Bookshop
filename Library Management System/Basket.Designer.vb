<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Basket
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
        Me.gpOrderSummary = New System.Windows.Forms.GroupBox()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblProductTotal = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.rbPaperback = New System.Windows.Forms.RadioButton()
        Me.rbHardBack = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOrderAuther = New System.Windows.Forms.Label()
        Me.txtbOrderAuthor = New System.Windows.Forms.TextBox()
        Me.lblOrderNAme = New System.Windows.Forms.Label()
        Me.txtbOrderName = New System.Windows.Forms.TextBox()
        Me.ORderPic = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gpOrderSummary.SuspendLayout()
        CType(Me.ORderPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gpOrderSummary.Location = New System.Drawing.Point(51, 110)
        Me.gpOrderSummary.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpOrderSummary.Name = "gpOrderSummary"
        Me.gpOrderSummary.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpOrderSummary.Size = New System.Drawing.Size(345, 188)
        Me.gpOrderSummary.TabIndex = 3
        Me.gpOrderSummary.TabStop = False
        Me.gpOrderSummary.Text = "Order Summary"
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnDeleteOrder.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrder.Location = New System.Drawing.Point(29, 127)
        Me.btnDeleteOrder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(74, 40)
        Me.btnDeleteOrder.TabIndex = 32
        Me.btnDeleteOrder.Text = "Delete Product"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "10+"})
        Me.ComboBox1.Location = New System.Drawing.Point(192, 116)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 22)
        Me.ComboBox1.TabIndex = 0
        '
        'lblProductTotal
        '
        Me.lblProductTotal.AutoSize = True
        Me.lblProductTotal.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductTotal.Location = New System.Drawing.Point(165, 146)
        Me.lblProductTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductTotal.Name = "lblProductTotal"
        Me.lblProductTotal.Size = New System.Drawing.Size(14, 14)
        Me.lblProductTotal.TabIndex = 12
        Me.lblProductTotal.Text = "£"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(192, 141)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(82, 20)
        Me.TextBox4.TabIndex = 11
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.Location = New System.Drawing.Point(132, 121)
        Me.LblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(58, 14)
        Me.LblQuantity.TabIndex = 10
        Me.LblQuantity.Text = "Quantity:"
        '
        'rbPaperback
        '
        Me.rbPaperback.AutoSize = True
        Me.rbPaperback.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPaperback.Location = New System.Drawing.Point(217, 94)
        Me.rbPaperback.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbPaperback.Name = "rbPaperback"
        Me.rbPaperback.Size = New System.Drawing.Size(81, 18)
        Me.rbPaperback.TabIndex = 4
        Me.rbPaperback.TabStop = True
        Me.rbPaperback.Text = "Paperback"
        Me.rbPaperback.UseVisualStyleBackColor = True
        '
        'rbHardBack
        '
        Me.rbHardBack.AutoSize = True
        Me.rbHardBack.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHardBack.Location = New System.Drawing.Point(139, 93)
        Me.rbHardBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbHardBack.Name = "rbHardBack"
        Me.rbHardBack.Size = New System.Drawing.Size(78, 18)
        Me.rbHardBack.TabIndex = 3
        Me.rbHardBack.TabStop = True
        Me.rbHardBack.Text = "Hardback"
        Me.rbHardBack.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 14)
        Me.Label5.TabIndex = 8
        '
        'lblOrderAuther
        '
        Me.lblOrderAuther.AutoSize = True
        Me.lblOrderAuther.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderAuther.Location = New System.Drawing.Point(134, 63)
        Me.lblOrderAuther.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderAuther.Name = "lblOrderAuther"
        Me.lblOrderAuther.Size = New System.Drawing.Size(45, 14)
        Me.lblOrderAuther.TabIndex = 6
        Me.lblOrderAuther.Text = "Author"
        '
        'txtbOrderAuthor
        '
        Me.txtbOrderAuthor.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbOrderAuthor.Location = New System.Drawing.Point(181, 63)
        Me.txtbOrderAuthor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbOrderAuthor.Name = "txtbOrderAuthor"
        Me.txtbOrderAuthor.Size = New System.Drawing.Size(124, 20)
        Me.txtbOrderAuthor.TabIndex = 5
        '
        'lblOrderNAme
        '
        Me.lblOrderNAme.AutoSize = True
        Me.lblOrderNAme.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNAme.Location = New System.Drawing.Point(137, 40)
        Me.lblOrderNAme.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderNAme.Name = "lblOrderNAme"
        Me.lblOrderNAme.Size = New System.Drawing.Size(41, 14)
        Me.lblOrderNAme.TabIndex = 4
        Me.lblOrderNAme.Text = "Name:"
        '
        'txtbOrderName
        '
        Me.txtbOrderName.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbOrderName.Location = New System.Drawing.Point(181, 38)
        Me.txtbOrderName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbOrderName.Name = "txtbOrderName"
        Me.txtbOrderName.Size = New System.Drawing.Size(124, 20)
        Me.txtbOrderName.TabIndex = 3
        '
        'ORderPic
        '
        Me.ORderPic.Location = New System.Drawing.Point(29, 29)
        Me.ORderPic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ORderPic.Name = "ORderPic"
        Me.ORderPic.Size = New System.Drawing.Size(74, 88)
        Me.ORderPic.TabIndex = 1
        Me.ORderPic.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(149, 317)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Checkout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Your Basket ..."
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 8)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 37)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Home Page"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Basket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 421)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.gpOrderSummary)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Basket"
        Me.Text = "Basket"
        Me.gpOrderSummary.ResumeLayout(False)
        Me.gpOrderSummary.PerformLayout()
        CType(Me.ORderPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpOrderSummary As GroupBox
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblProductTotal As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LblQuantity As Label
    Friend WithEvents rbPaperback As RadioButton
    Friend WithEvents rbHardBack As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOrderAuther As Label
    Friend WithEvents txtbOrderAuthor As TextBox
    Friend WithEvents lblOrderNAme As Label
    Friend WithEvents txtbOrderName As TextBox
    Friend WithEvents ORderPic As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
