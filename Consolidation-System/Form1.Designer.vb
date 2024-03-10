<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrderDetails = New System.Windows.Forms.TextBox()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalOrders = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblConviFee = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCFSUF = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDCharges = New System.Windows.Forms.TextBox()
        Me.txtMerchants = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtRealProductAmount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPlusPercent5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgList
        '
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgList.Location = New System.Drawing.Point(0, 275)
        Me.dgList.Name = "dgList"
        Me.dgList.Size = New System.Drawing.Size(913, 225)
        Me.dgList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date:"
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(99, 12)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(100, 20)
        Me.dtDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Order Details:"
        '
        'txtOrderDetails
        '
        Me.txtOrderDetails.Location = New System.Drawing.Point(99, 51)
        Me.txtOrderDetails.Name = "txtOrderDetails"
        Me.txtOrderDetails.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderDetails.TabIndex = 4
        '
        'txtItems
        '
        Me.txtItems.Location = New System.Drawing.Point(99, 87)
        Me.txtItems.Multiline = True
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(100, 39)
        Me.txtItems.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Items:"
        '
        'txtTotalOrders
        '
        Me.txtTotalOrders.Location = New System.Drawing.Point(326, 87)
        Me.txtTotalOrders.Name = "txtTotalOrders"
        Me.txtTotalOrders.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalOrders.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Orders:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(326, 12)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(221, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Customer Name:"
        '
        'lblPercent
        '
        Me.lblPercent.BackColor = System.Drawing.Color.White
        Me.lblPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(560, 12)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(100, 20)
        Me.lblPercent.TabIndex = 11
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConviFee
        '
        Me.lblConviFee.BackColor = System.Drawing.Color.White
        Me.lblConviFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConviFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConviFee.Location = New System.Drawing.Point(560, 51)
        Me.lblConviFee.Name = "lblConviFee"
        Me.lblConviFee.Size = New System.Drawing.Size(100, 20)
        Me.lblConviFee.TabIndex = 12
        Me.lblConviFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BackColor = System.Drawing.Color.White
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(795, 12)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(103, 20)
        Me.lblTotalSales.TabIndex = 14
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(452, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Percent:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(451, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Convience Fee:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(451, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "CF/SUF:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(681, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total Sales:"
        '
        'txtCFSUF
        '
        Me.txtCFSUF.Location = New System.Drawing.Point(560, 87)
        Me.txtCFSUF.Name = "txtCFSUF"
        Me.txtCFSUF.Size = New System.Drawing.Size(100, 20)
        Me.txtCFSUF.TabIndex = 20
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(326, 51)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(100, 20)
        Me.txtDestination.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(221, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Destination:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(681, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Delivery Charges:"
        '
        'txtDCharges
        '
        Me.txtDCharges.Location = New System.Drawing.Point(795, 48)
        Me.txtDCharges.Name = "txtDCharges"
        Me.txtDCharges.Size = New System.Drawing.Size(103, 20)
        Me.txtDCharges.TabIndex = 25
        '
        'txtMerchants
        '
        Me.txtMerchants.Location = New System.Drawing.Point(795, 88)
        Me.txtMerchants.Name = "txtMerchants"
        Me.txtMerchants.Size = New System.Drawing.Size(103, 20)
        Me.txtMerchants.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(683, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Merchants:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(711, 246)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 23)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add to List"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(808, 246)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 23)
        Me.btnEdit.TabIndex = 29
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(160, 247)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 23)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(19, 249)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(135, 20)
        Me.txtSearch.TabIndex = 31
        '
        'txtRealProductAmount
        '
        Me.txtRealProductAmount.Location = New System.Drawing.Point(795, 151)
        Me.txtRealProductAmount.Name = "txtRealProductAmount"
        Me.txtRealProductAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtRealProductAmount.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(658, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Real Product Amount:"
        '
        'lblPlusPercent5
        '
        Me.lblPlusPercent5.BackColor = System.Drawing.Color.White
        Me.lblPlusPercent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlusPercent5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlusPercent5.Location = New System.Drawing.Point(795, 184)
        Me.lblPlusPercent5.Name = "lblPlusPercent5"
        Me.lblPlusPercent5.Size = New System.Drawing.Size(100, 20)
        Me.lblPlusPercent5.TabIndex = 34
        Me.lblPlusPercent5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(695, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Plus 5 Percent:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblPlusPercent5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRealProductAmount)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMerchants)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDCharges)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCFSUF)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.lblConviFee)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalOrders)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItems)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOrderDetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgList)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidated Form"
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrderDetails As TextBox
    Friend WithEvents txtItems As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalOrders As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblConviFee As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCFSUF As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDCharges As TextBox
    Friend WithEvents txtMerchants As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtRealProductAmount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPlusPercent5 As Label
    Friend WithEvents Label15 As Label
End Class
