
Public Class Form1
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Me.Hide()
        Carga_tarifa.Show()

    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class
