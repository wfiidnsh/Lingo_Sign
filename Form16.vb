Public Class Form16
    Public Sub New(product As String, quantity As Integer, total As Decimal)
        InitializeComponent()
        lblProduct.Text = "Product: " & product
        lblQuantity.Text = "Quantity: " & quantity
        lblTotal.Text = "Total: RM" & total.ToString()

        lblOrderID.Text = "Order ID: #" & Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper()

    End Sub

    Private Sub btnBackHome_Click(sender As Object, e As EventArgs) Handles btnBackHome.Click
        Dim BackHome As New Form14()
        Form14.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class