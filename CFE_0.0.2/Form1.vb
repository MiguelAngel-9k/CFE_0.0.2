
Public Class Form1
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Me.Hide()
        employee_form.Show()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class
