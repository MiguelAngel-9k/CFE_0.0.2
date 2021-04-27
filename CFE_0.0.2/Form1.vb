
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        log_as_cb.Items.Add("Cliente")
        log_as_cb.Items.Add("Administrador")
        log_as_cb.Items.Add("Empleado")

        log_as_cb.SelectedItem = "Empleado"
    End Sub
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Me.Hide()
        employee_form.Show()

        Dim selected = log_as_cb.SelectedItem.ToString

        If selected = "Cliente" Then

            client_form.Show()
            Me.Hide()
        ElseIf selected = "Administrador" Then

            employee_form.Width = 1180

            employee_form.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class
