<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FillOrCancel
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
        Me._lblOrderId = New System.Windows.Forms.Label()
        Me._txtOrderId = New System.Windows.Forms.TextBox()
        Me._btnFindByOrderId = New System.Windows.Forms.Button()
        Me._lblFillDate = New System.Windows.Forms.Label()
        Me._dtpFillDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvCustomerOrders = New System.Windows.Forms.DataGridView()
        Me._btnCancelOrder = New System.Windows.Forms.Button()
        Me._btnFillOrder = New System.Windows.Forms.Button()
        Me._btnFinishUpdates = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_lblOrderId
        '
        Me._lblOrderId.AutoSize = True
        Me._lblOrderId.Location = New System.Drawing.Point(21, 21)
        Me._lblOrderId.Margin = New System.Windows.Forms.Padding(12)
        Me._lblOrderId.Name = "_lblOrderId"
        Me._lblOrderId.Size = New System.Drawing.Size(50, 13)
        Me._lblOrderId.TabIndex = 0
        Me._lblOrderId.Text = "Order ID:"
        '
        '_txtOrderId
        '
        Me._txtOrderId.Location = New System.Drawing.Point(86, 18)
        Me._txtOrderId.Name = "_txtOrderId"
        Me._txtOrderId.Size = New System.Drawing.Size(120, 20)
        Me._txtOrderId.TabIndex = 1
        '
        '_btnFindByOrderId
        '
        Me._btnFindByOrderId.Location = New System.Drawing.Point(224, 16)
        Me._btnFindByOrderId.Margin = New System.Windows.Forms.Padding(12)
        Me._btnFindByOrderId.Name = "_btnFindByOrderId"
        Me._btnFindByOrderId.Size = New System.Drawing.Size(100, 23)
        Me._btnFindByOrderId.TabIndex = 2
        Me._btnFindByOrderId.Text = "Find Order"
        Me._btnFindByOrderId.UseVisualStyleBackColor = True
        '
        '_lblFillDate
        '
        Me._lblFillDate.AutoSize = True
        Me._lblFillDate.Location = New System.Drawing.Point(21, 72)
        Me._lblFillDate.Margin = New System.Windows.Forms.Padding(3, 24, 3, 0)
        Me._lblFillDate.Name = "_lblFillDate"
        Me._lblFillDate.Size = New System.Drawing.Size(168, 13)
        Me._lblFillDate.TabIndex = 3
        Me._lblFillDate.Text = "If filling an order, specify filled date"
        '
        '_dtpFillDate
        '
        Me._dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me._dtpFillDate.Location = New System.Drawing.Point(204, 66)
        Me._dtpFillDate.Margin = New System.Windows.Forms.Padding(12, 24, 3, 3)
        Me._dtpFillDate.Name = "_dtpFillDate"
        Me._dtpFillDate.Size = New System.Drawing.Size(120, 20)
        Me._dtpFillDate.TabIndex = 4
        '
        'dgvCustomerOrders
        '
        Me.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerOrders.Location = New System.Drawing.Point(21, 97)
        Me.dgvCustomerOrders.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.dgvCustomerOrders.Name = "dgvCustomerOrders"
        Me.dgvCustomerOrders.Size = New System.Drawing.Size(360, 120)
        Me.dgvCustomerOrders.TabIndex = 5
        '
        '_btnCancelOrder
        '
        Me._btnCancelOrder.Location = New System.Drawing.Point(21, 244)
        Me._btnCancelOrder.Margin = New System.Windows.Forms.Padding(12, 24, 12, 12)
        Me._btnCancelOrder.Name = "_btnCancelOrder"
        Me._btnCancelOrder.Size = New System.Drawing.Size(100, 23)
        Me._btnCancelOrder.TabIndex = 6
        Me._btnCancelOrder.Text = "Cancel Order"
        Me._btnCancelOrder.UseVisualStyleBackColor = True
        '
        '_btnFillOrder
        '
        Me._btnFillOrder.Location = New System.Drawing.Point(141, 244)
        Me._btnFillOrder.Margin = New System.Windows.Forms.Padding(8, 24, 12, 12)
        Me._btnFillOrder.Name = "_btnFillOrder"
        Me._btnFillOrder.Size = New System.Drawing.Size(100, 23)
        Me._btnFillOrder.TabIndex = 7
        Me._btnFillOrder.Text = "Fill Order"
        Me._btnFillOrder.UseVisualStyleBackColor = True
        '
        '_btnFinishUpdates
        '
        Me._btnFinishUpdates.Location = New System.Drawing.Point(281, 244)
        Me._btnFinishUpdates.Margin = New System.Windows.Forms.Padding(12, 24, 12, 12)
        Me._btnFinishUpdates.Name = "_btnFinishUpdates"
        Me._btnFinishUpdates.Size = New System.Drawing.Size(100, 23)
        Me._btnFinishUpdates.TabIndex = 8
        Me._btnFinishUpdates.Text = "Finish"
        Me._btnFinishUpdates.UseVisualStyleBackColor = True
        '
        'FillOrCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 281)
        Me.Controls.Add(Me._btnFinishUpdates)
        Me.Controls.Add(Me._btnFillOrder)
        Me.Controls.Add(Me._btnCancelOrder)
        Me.Controls.Add(Me.dgvCustomerOrders)
        Me.Controls.Add(Me._dtpFillDate)
        Me.Controls.Add(Me._lblFillDate)
        Me.Controls.Add(Me._btnFindByOrderId)
        Me.Controls.Add(Me._txtOrderId)
        Me.Controls.Add(Me._lblOrderId)
        Me.Name = "FillOrCancel"
        Me.Text = "Fill or cancel an order"
        CType(Me.dgvCustomerOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _lblOrderId As Label
    Friend WithEvents _txtOrderId As TextBox
    Friend WithEvents _btnFindByOrderId As Button
    Friend WithEvents _lblFillDate As Label
    Friend WithEvents _dtpFillDate As DateTimePicker
    Friend WithEvents dgvCustomerOrders As DataGridView
    Friend WithEvents _btnCancelOrder As Button
    Friend WithEvents _btnFillOrder As Button
    Friend WithEvents _btnFinishUpdates As Button
End Class
