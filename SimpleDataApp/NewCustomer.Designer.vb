<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomer
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
        Me._grpAddAccount = New System.Windows.Forms.GroupBox()
        Me._txtCustomerId = New System.Windows.Forms.TextBox()
        Me._txtCustomerName = New System.Windows.Forms.TextBox()
        Me._lblCustomerID = New System.Windows.Forms.Label()
        Me._lblCustomerName = New System.Windows.Forms.Label()
        Me._grpCreateOrder = New System.Windows.Forms.GroupBox()
        Me._dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me._numOrderAmount = New System.Windows.Forms.NumericUpDown()
        Me._lblOrderDate = New System.Windows.Forms.Label()
        Me._lblOrderAmount = New System.Windows.Forms.Label()
        Me._btnCreateAccount = New System.Windows.Forms.Button()
        Me._btnPlaceOrder = New System.Windows.Forms.Button()
        Me._btnAddFinish = New System.Windows.Forms.Button()
        Me._btnAddAnotherAccount = New System.Windows.Forms.Button()
        Me._grpAddAccount.SuspendLayout()
        Me._grpCreateOrder.SuspendLayout()
        CType(Me._numOrderAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_grpAddAccount
        '
        Me._grpAddAccount.Controls.Add(Me._txtCustomerId)
        Me._grpAddAccount.Controls.Add(Me._txtCustomerName)
        Me._grpAddAccount.Controls.Add(Me._lblCustomerID)
        Me._grpAddAccount.Controls.Add(Me._lblCustomerName)
        Me._grpAddAccount.Location = New System.Drawing.Point(21, 21)
        Me._grpAddAccount.Margin = New System.Windows.Forms.Padding(12, 12, 12, 0)
        Me._grpAddAccount.Name = "_grpAddAccount"
        Me._grpAddAccount.Size = New System.Drawing.Size(240, 100)
        Me._grpAddAccount.TabIndex = 0
        Me._grpAddAccount.TabStop = False
        Me._grpAddAccount.Text = "Add Account"
        '
        '_txtCustomerId
        '
        Me._txtCustomerId.Location = New System.Drawing.Point(145, 62)
        Me._txtCustomerId.Margin = New System.Windows.Forms.Padding(12)
        Me._txtCustomerId.Name = "_txtCustomerId"
        Me._txtCustomerId.Size = New System.Drawing.Size(80, 20)
        Me._txtCustomerId.TabIndex = 2
        '
        '_txtCustomerName
        '
        Me._txtCustomerName.Location = New System.Drawing.Point(105, 25)
        Me._txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 12, 12, 12)
        Me._txtCustomerName.Name = "_txtCustomerName"
        Me._txtCustomerName.Size = New System.Drawing.Size(120, 20)
        Me._txtCustomerName.TabIndex = 1
        '
        '_lblCustomerID
        '
        Me._lblCustomerID.AutoSize = True
        Me._lblCustomerID.Location = New System.Drawing.Point(15, 65)
        Me._lblCustomerID.Margin = New System.Windows.Forms.Padding(12)
        Me._lblCustomerID.Name = "_lblCustomerID"
        Me._lblCustomerID.Size = New System.Drawing.Size(68, 13)
        Me._lblCustomerID.TabIndex = 1
        Me._lblCustomerID.Text = "Customer ID:"
        '
        '_lblCustomerName
        '
        Me._lblCustomerName.AutoSize = True
        Me._lblCustomerName.Location = New System.Drawing.Point(15, 28)
        Me._lblCustomerName.Margin = New System.Windows.Forms.Padding(12)
        Me._lblCustomerName.Name = "_lblCustomerName"
        Me._lblCustomerName.Size = New System.Drawing.Size(85, 13)
        Me._lblCustomerName.TabIndex = 0
        Me._lblCustomerName.Text = "Customer Name:"
        '
        '_grpCreateOrder
        '
        Me._grpCreateOrder.Controls.Add(Me._dtpOrderDate)
        Me._grpCreateOrder.Controls.Add(Me._numOrderAmount)
        Me._grpCreateOrder.Controls.Add(Me._lblOrderDate)
        Me._grpCreateOrder.Controls.Add(Me._lblOrderAmount)
        Me._grpCreateOrder.Location = New System.Drawing.Point(21, 129)
        Me._grpCreateOrder.Margin = New System.Windows.Forms.Padding(12, 8, 12, 12)
        Me._grpCreateOrder.Name = "_grpCreateOrder"
        Me._grpCreateOrder.Size = New System.Drawing.Size(240, 100)
        Me._grpCreateOrder.TabIndex = 3
        Me._grpCreateOrder.TabStop = False
        Me._grpCreateOrder.Text = "Create Order"
        '
        '_dtpOrderDate
        '
        Me._dtpOrderDate.CustomFormat = """dd/MM/yyyy"""
        Me._dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me._dtpOrderDate.Location = New System.Drawing.Point(105, 65)
        Me._dtpOrderDate.Name = "_dtpOrderDate"
        Me._dtpOrderDate.Size = New System.Drawing.Size(120, 20)
        Me._dtpOrderDate.TabIndex = 4
        Me._dtpOrderDate.Value = New Date(2024, 4, 25, 0, 0, 0, 0)
        '
        '_numOrderAmount
        '
        Me._numOrderAmount.Location = New System.Drawing.Point(105, 26)
        Me._numOrderAmount.Name = "_numOrderAmount"
        Me._numOrderAmount.Size = New System.Drawing.Size(120, 20)
        Me._numOrderAmount.TabIndex = 3
        Me._numOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me._numOrderAmount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        '_lblOrderDate
        '
        Me._lblOrderDate.AutoSize = True
        Me._lblOrderDate.Location = New System.Drawing.Point(15, 65)
        Me._lblOrderDate.Margin = New System.Windows.Forms.Padding(12)
        Me._lblOrderDate.Name = "_lblOrderDate"
        Me._lblOrderDate.Size = New System.Drawing.Size(62, 13)
        Me._lblOrderDate.TabIndex = 1
        Me._lblOrderDate.Text = "Order Date:"
        '
        '_lblOrderAmount
        '
        Me._lblOrderAmount.AutoSize = True
        Me._lblOrderAmount.Location = New System.Drawing.Point(15, 28)
        Me._lblOrderAmount.Margin = New System.Windows.Forms.Padding(12)
        Me._lblOrderAmount.Name = "_lblOrderAmount"
        Me._lblOrderAmount.Size = New System.Drawing.Size(75, 13)
        Me._lblOrderAmount.TabIndex = 0
        Me._lblOrderAmount.Text = "Order Amount:"
        '
        '_btnCreateAccount
        '
        Me._btnCreateAccount.Location = New System.Drawing.Point(272, 89)
        Me._btnCreateAccount.Name = "_btnCreateAccount"
        Me._btnCreateAccount.Size = New System.Drawing.Size(120, 32)
        Me._btnCreateAccount.TabIndex = 4
        Me._btnCreateAccount.Text = "Create Account"
        Me._btnCreateAccount.UseVisualStyleBackColor = True
        '
        '_btnPlaceOrder
        '
        Me._btnPlaceOrder.Location = New System.Drawing.Point(272, 197)
        Me._btnPlaceOrder.Name = "_btnPlaceOrder"
        Me._btnPlaceOrder.Size = New System.Drawing.Size(120, 32)
        Me._btnPlaceOrder.TabIndex = 5
        Me._btnPlaceOrder.Text = "Place Order"
        Me._btnPlaceOrder.UseVisualStyleBackColor = True
        '
        '_btnAddFinish
        '
        Me._btnAddFinish.Location = New System.Drawing.Point(21, 245)
        Me._btnAddFinish.Name = "_btnAddFinish"
        Me._btnAddFinish.Size = New System.Drawing.Size(80, 24)
        Me._btnAddFinish.TabIndex = 6
        Me._btnAddFinish.Text = "Finish"
        Me._btnAddFinish.UseVisualStyleBackColor = True
        '
        '_btnAddAnotherAccount
        '
        Me._btnAddAnotherAccount.Location = New System.Drawing.Point(232, 244)
        Me._btnAddAnotherAccount.Name = "_btnAddAnotherAccount"
        Me._btnAddAnotherAccount.Size = New System.Drawing.Size(160, 24)
        Me._btnAddAnotherAccount.TabIndex = 7
        Me._btnAddAnotherAccount.Text = "Add Another Account"
        Me._btnAddAnotherAccount.UseVisualStyleBackColor = True
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 281)
        Me.Controls.Add(Me._btnAddAnotherAccount)
        Me.Controls.Add(Me._btnAddFinish)
        Me.Controls.Add(Me._btnPlaceOrder)
        Me.Controls.Add(Me._btnCreateAccount)
        Me.Controls.Add(Me._grpCreateOrder)
        Me.Controls.Add(Me._grpAddAccount)
        Me.Name = "NewCustomer"
        Me.Text = "New Account and Order"
        Me._grpAddAccount.ResumeLayout(False)
        Me._grpAddAccount.PerformLayout()
        Me._grpCreateOrder.ResumeLayout(False)
        Me._grpCreateOrder.PerformLayout()
        CType(Me._numOrderAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _grpAddAccount As GroupBox
    Friend WithEvents _lblCustomerName As Label
    Friend WithEvents _lblCustomerID As Label
    Friend WithEvents _txtCustomerId As TextBox
    Friend WithEvents _txtCustomerName As TextBox
    Friend WithEvents _grpCreateOrder As GroupBox
    Friend WithEvents _lblOrderDate As Label
    Friend WithEvents _lblOrderAmount As Label
    Friend WithEvents _dtpOrderDate As DateTimePicker
    Friend WithEvents _numOrderAmount As NumericUpDown
    Friend WithEvents _btnCreateAccount As Button
    Friend WithEvents _btnPlaceOrder As Button
    Friend WithEvents _btnAddFinish As Button
    Friend WithEvents _btnAddAnotherAccount As Button
End Class
