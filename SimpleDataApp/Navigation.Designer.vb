<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navigation
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
        Me._lbl1 = New System.Windows.Forms.Label()
        Me._btnGotoAdd = New System.Windows.Forms.Button()
        Me._btnGoToFillOrCancel = New System.Windows.Forms.Button()
        Me._btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_lbl1
        '
        Me._lbl1.AutoSize = True
        Me._lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lbl1.Location = New System.Drawing.Point(67, 32)
        Me._lbl1.Margin = New System.Windows.Forms.Padding(12)
        Me._lbl1.Name = "_lbl1"
        Me._lbl1.Size = New System.Drawing.Size(273, 25)
        Me._lbl1.TabIndex = 0
        Me._lbl1.Text = "What do you want to do?"
        '
        '_btnGotoAdd
        '
        Me._btnGotoAdd.Location = New System.Drawing.Point(12, 93)
        Me._btnGotoAdd.Margin = New System.Windows.Forms.Padding(12, 24, 12, 24)
        Me._btnGotoAdd.Name = "_btnGotoAdd"
        Me._btnGotoAdd.Size = New System.Drawing.Size(380, 40)
        Me._btnGotoAdd.TabIndex = 1
        Me._btnGotoAdd.Text = "Add an accounnt"
        Me._btnGotoAdd.UseVisualStyleBackColor = True
        '
        '_btnGoToFillOrCancel
        '
        Me._btnGoToFillOrCancel.Location = New System.Drawing.Point(12, 160)
        Me._btnGoToFillOrCancel.Margin = New System.Windows.Forms.Padding(12, 24, 12, 24)
        Me._btnGoToFillOrCancel.Name = "_btnGoToFillOrCancel"
        Me._btnGoToFillOrCancel.Size = New System.Drawing.Size(380, 40)
        Me._btnGoToFillOrCancel.TabIndex = 2
        Me._btnGoToFillOrCancel.Text = "Fill or cancel an order"
        Me._btnGoToFillOrCancel.UseVisualStyleBackColor = True
        '
        '_btnExit
        '
        Me._btnExit.Location = New System.Drawing.Point(272, 227)
        Me._btnExit.Name = "_btnExit"
        Me._btnExit.Size = New System.Drawing.Size(120, 40)
        Me._btnExit.TabIndex = 3
        Me._btnExit.Text = "Exit"
        Me._btnExit.UseVisualStyleBackColor = True
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 281)
        Me.Controls.Add(Me._btnExit)
        Me.Controls.Add(Me._btnGoToFillOrCancel)
        Me.Controls.Add(Me._btnGotoAdd)
        Me.Controls.Add(Me._lbl1)
        Me.Name = "Navigation"
        Me.Text = "Navigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _lbl1 As Label
    Friend WithEvents _btnGotoAdd As Button
    Friend WithEvents _btnGoToFillOrCancel As Button
    Friend WithEvents _btnExit As Button
End Class
