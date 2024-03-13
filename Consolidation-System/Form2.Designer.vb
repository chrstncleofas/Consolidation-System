<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPlusPercent5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRealProductAmount = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtMerchants = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDCharges = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCFSUF = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblConviFee = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalOrders = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderDetails = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker()
        Me.btnFilter = New System.Windows.Forms.Button()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgList
        '
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgList.Location = New System.Drawing.Point(0, 288)
        Me.dgList.Name = "dgList"
        Me.dgList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgList.Size = New System.Drawing.Size(913, 212)
        Me.dgList.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(813, 258)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(93, 23)
        Me.btnPrint.TabIndex = 71
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(714, 258)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 23)
        Me.btnClear.TabIndex = 70
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(696, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Plus 5 Percent:"
        '
        'lblPlusPercent5
        '
        Me.lblPlusPercent5.BackColor = System.Drawing.Color.White
        Me.lblPlusPercent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlusPercent5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlusPercent5.Location = New System.Drawing.Point(796, 196)
        Me.lblPlusPercent5.Name = "lblPlusPercent5"
        Me.lblPlusPercent5.Size = New System.Drawing.Size(100, 20)
        Me.lblPlusPercent5.TabIndex = 68
        Me.lblPlusPercent5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(659, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Real Product Amount:"
        '
        'txtRealProductAmount
        '
        Me.txtRealProductAmount.Location = New System.Drawing.Point(796, 163)
        Me.txtRealProductAmount.Name = "txtRealProductAmount"
        Me.txtRealProductAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtRealProductAmount.TabIndex = 66
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(615, 258)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 23)
        Me.btnEdit.TabIndex = 63
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(518, 258)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 23)
        Me.btnAdd.TabIndex = 62
        Me.btnAdd.Text = "Add to List"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtMerchants
        '
        Me.txtMerchants.Location = New System.Drawing.Point(796, 115)
        Me.txtMerchants.Name = "txtMerchants"
        Me.txtMerchants.Size = New System.Drawing.Size(103, 20)
        Me.txtMerchants.TabIndex = 61
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(684, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Merchants:"
        '
        'txtDCharges
        '
        Me.txtDCharges.Location = New System.Drawing.Point(796, 75)
        Me.txtDCharges.Name = "txtDCharges"
        Me.txtDCharges.Size = New System.Drawing.Size(103, 20)
        Me.txtDCharges.TabIndex = 59
        Me.txtDCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(682, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Delivery Charges:"
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(327, 78)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(100, 20)
        Me.txtDestination.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(222, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Destination:"
        '
        'txtCFSUF
        '
        Me.txtCFSUF.Location = New System.Drawing.Point(561, 114)
        Me.txtCFSUF.Name = "txtCFSUF"
        Me.txtCFSUF.Size = New System.Drawing.Size(100, 20)
        Me.txtCFSUF.TabIndex = 55
        Me.txtCFSUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(682, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Total Sales:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(452, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "CF/SUF:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(452, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Convience Fee:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Percent:"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BackColor = System.Drawing.Color.White
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(796, 39)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(103, 20)
        Me.lblTotalSales.TabIndex = 50
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblConviFee
        '
        Me.lblConviFee.BackColor = System.Drawing.Color.White
        Me.lblConviFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConviFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConviFee.Location = New System.Drawing.Point(561, 78)
        Me.lblConviFee.Name = "lblConviFee"
        Me.lblConviFee.Size = New System.Drawing.Size(100, 20)
        Me.lblConviFee.TabIndex = 49
        Me.lblConviFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercent
        '
        Me.lblPercent.BackColor = System.Drawing.Color.White
        Me.lblPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(561, 39)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(100, 20)
        Me.lblPercent.TabIndex = 48
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(327, 39)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(222, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Customer Name:"
        '
        'txtTotalOrders
        '
        Me.txtTotalOrders.Location = New System.Drawing.Point(327, 114)
        Me.txtTotalOrders.Name = "txtTotalOrders"
        Me.txtTotalOrders.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalOrders.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Total Orders:"
        '
        'txtItems
        '
        Me.txtItems.Location = New System.Drawing.Point(100, 114)
        Me.txtItems.Multiline = True
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(100, 39)
        Me.txtItems.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Items:"
        '
        'txtOrderDetails
        '
        Me.txtOrderDetails.Location = New System.Drawing.Point(100, 78)
        Me.txtOrderDetails.Name = "txtOrderDetails"
        Me.txtOrderDetails.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderDetails.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Order Details:"
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(100, 39)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(100, 20)
        Me.dtDate.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Date:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(913, 24)
        Me.MenuStrip1.TabIndex = 72
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(12, 226)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePickerStartDate.TabIndex = 73
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(12, 252)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePickerEndDate.TabIndex = 74
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(154, 237)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 75
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.DateTimePickerEndDate)
        Me.Controls.Add(Me.DateTimePickerStartDate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblPlusPercent5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRealProductAmount)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgList As DataGridView
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents lblPlusPercent5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtRealProductAmount As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtMerchants As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDCharges As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCFSUF As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblConviFee As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalOrders As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItems As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOrderDetails As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePickerStartDate As DateTimePicker
    Friend WithEvents DateTimePickerEndDate As DateTimePicker
    Friend WithEvents btnFilter As Button
End Class
