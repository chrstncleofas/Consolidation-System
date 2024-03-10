Public Class Form1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtTotalOrders_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalOrders.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            lblPercent.Text = Val(txtTotalOrders.Text) / 100
            lblConviFee.Text = Val(lblPercent.Text) * 5
            lblTotalSales.Text = Val(txtTotalOrders.Text) - Val(lblConviFee.Text)
        End If
    End Sub
End Class
