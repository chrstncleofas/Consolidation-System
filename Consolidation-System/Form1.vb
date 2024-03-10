Imports Npgsql
Public Class Form1
    Dim con As New NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=password;Database=ConsolidationdDb")
    Dim command As NpgsqlCommand
    Dim adapter As New NpgsqlDataAdapter
    Dim dt As New DataTable
    Private Sub refreshData()
        dt.Clear()
        con.Open()
        Dim query As String = "SELECT * FROM public.database"
        adapter = New NpgsqlDataAdapter(query, con)
        adapter.Fill(dt)
        dgList.DataSource = dt
        con.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        refreshData()
    End Sub
End Class
