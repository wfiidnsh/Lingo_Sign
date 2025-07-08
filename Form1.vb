Public Class Form1
    Public Class Form1

        Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click

            Form2.Show()

            Me.Hide() ' Optional: hide Form1

        End Sub

        Private Sub Hide()
            Throw New NotImplementedException()
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
