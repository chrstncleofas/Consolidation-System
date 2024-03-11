Imports Microsoft.Office.Interop
Imports Npgsql
Public Class Form2
    Dim con As New NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=password;Database=ConsolidationdDb")
    Dim command As NpgsqlCommand
    Dim adapter As New NpgsqlDataAdapter
    Dim dt As New DataTable
    Private Sub refreshData()
        dt.Clear()
        con.Open()
        Dim query As String = "SELECT * FROM public.database ORDER BY id ASC"
        adapter = New NpgsqlDataAdapter(query, con)
        adapter.Fill(dt)
        dgList.DataSource = dt
        con.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDate.CustomFormat = "MM/dd/yyyy"
        dtDate.Format = DateTimePickerFormat.Custom
        refreshData()
    End Sub
    Private Sub txtTotalOrders_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalOrders.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            lblPercent.Text = Val(txtTotalOrders.Text) / 100
            lblConviFee.Text = Val(lblPercent.Text) * 5
            lblTotalSales.Text = Val(txtTotalOrders.Text) - Val(lblConviFee.Text)
        End If
    End Sub
    Private Sub txtRealProductAmount_TextChanged(sender As Object, e As EventArgs) Handles txtRealProductAmount.TextChanged
        lblPlusPercent5.Text = Val(txtRealProductAmount.Text) / 100 * 5 + Val(txtRealProductAmount.Text)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con.Open()
        Dim query As String = "INSERT INTO database (date, orderdetails, items, customername, destination, totalorders, percentage, convifee, cfsuf, totalsales, deliverycharges, merchants) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11, @val12)"
        command = New NpgsqlCommand(query, con)
        command.Parameters.AddWithValue("@val1", dtDate.Text)
        command.Parameters.AddWithValue("@val2", txtOrderDetails.Text)
        command.Parameters.AddWithValue("@val3", txtItems.Text)
        command.Parameters.AddWithValue("@val4", txtCustomerName.Text)
        command.Parameters.AddWithValue("@val5", txtDestination.Text)
        command.Parameters.AddWithValue("@val6", txtTotalOrders.Text)
        command.Parameters.AddWithValue("@val7", lblPercent.Text)
        command.Parameters.AddWithValue("@val8", lblConviFee.Text)
        command.Parameters.AddWithValue("@val9", txtCFSUF.Text)
        command.Parameters.AddWithValue("@val10", lblTotalSales.Text)
        command.Parameters.AddWithValue("@val11", txtDCharges.Text)
        command.Parameters.AddWithValue("@val12", txtMerchants.Text)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Adding data successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refreshData()
    End Sub
    Private Sub dgList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgList.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgList.Rows(e.RowIndex)
            dtDate.Text = row.Cells("date").Value.ToString
            txtOrderDetails.Text = row.Cells("orderdetails").Value.ToString
            txtItems.Text = row.Cells("items").Value.ToString
            txtCustomerName.Text = row.Cells("customername").Value.ToString
            txtDestination.Text = row.Cells("destination").Value.ToString
            txtTotalOrders.Text = row.Cells("totalorders").Value.ToString
            lblPercent.Text = row.Cells("percentage").Value.ToString
            lblConviFee.Text = row.Cells("convifee").Value.ToString
            lblConviFee.Text = row.Cells("convifee").Value.ToString
            txtCFSUF.Text = row.Cells("cfsuf").Value.ToString
            lblTotalSales.Text = row.Cells("totalsales").Value.ToString
            txtDCharges.Text = row.Cells("deliverycharges").Value.ToString
            txtMerchants.Text = row.Cells("merchants").Value.ToString
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOrderDetails.Text = ""
        txtItems.Text = ""
        txtCustomerName.Text = ""
        txtDestination.Text = ""
        txtTotalOrders.Text = ""
        lblPercent.Text = ""
        lblConviFee.Text = ""
        lblConviFee.Text = ""
        txtCFSUF.Text = ""
        lblTotalSales.Text = ""
        txtDCharges.Text = ""
        txtMerchants.Text = ""
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        con.Open()
        Dim query As String = "UPDATE database SET date=@val1, orderdetails=@val2, items=@val3, customername=@val4, destination=@val5, totalorders=@val6, percentage=@val7, convifee=@val8, cfsuf=@val9, totalsales=@val10, deliverycharges=@val11, merchants=@val12 WHERE ID=@id"
        command = New NpgsqlCommand(query, con)
        command.Parameters.AddWithValue("@val1", dtDate.Text)
        command.Parameters.AddWithValue("@val2", txtOrderDetails.Text)
        command.Parameters.AddWithValue("@val3", txtItems.Text)
        command.Parameters.AddWithValue("@val4", txtCustomerName.Text)
        command.Parameters.AddWithValue("@val5", txtDestination.Text)
        command.Parameters.AddWithValue("@val6", txtTotalOrders.Text)
        command.Parameters.AddWithValue("@val7", lblPercent.Text)
        command.Parameters.AddWithValue("@val8", lblConviFee.Text)
        command.Parameters.AddWithValue("@val9", txtCFSUF.Text)
        command.Parameters.AddWithValue("@val10", lblTotalSales.Text)
        command.Parameters.AddWithValue("@val11", txtDCharges.Text)
        command.Parameters.AddWithValue("@val12", txtMerchants.Text)
        command.Parameters.AddWithValue("@id", dgList.CurrentRow.Cells(0).Value)
        command.ExecuteNonQuery()
        MessageBox.Show("Edit data successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        refreshData()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ExportToExcel()
    End Sub
    Private Sub ExportToExcel()
        Dim excelApp As New Excel.Application
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim excelWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets(1), Excel.Worksheet)

        ' Ilagay ang mga header sa Excel
        For col As Integer = 0 To dgList.Columns.Count - 1
            excelWorksheet.Cells(1, col + 1) = dgList.Columns(col).HeaderText
        Next

        ' Ilagay ang mga cell data sa Excel
        For row As Integer = 0 To dgList.Rows.Count - 1
            For col As Integer = 0 To dgList.Columns.Count - 1
                excelWorksheet.Cells(row + 2, col + 1) = dgList.Rows(row).Cells(col).Value
            Next
        Next

        ' I-save ang Excel file
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog.FilterIndex = 1
        saveFileDialog.RestoreDirectory = True

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            excelWorkbook.SaveAs(filePath)
            excelWorkbook.Close()
            excelApp.Quit()
            ReleaseObject(excelWorksheet)
            ReleaseObject(excelWorkbook)
            ReleaseObject(excelApp)
            MessageBox.Show("Data successfully exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class