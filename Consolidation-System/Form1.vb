Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDate.CustomFormat = "MM/dd/yyyy"
        dtDate.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub txtTotalOrders_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalOrders.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            lblPercent.Text = Val(txtTotalOrders.Text) / 100
            lblConviFee.Text = Val(lblPercent.Text) * 5
            lblTotalSales.Text = Val(txtTotalOrders.Text) - Val(lblConviFee.Text)
        End If
    End Sub
End Class
