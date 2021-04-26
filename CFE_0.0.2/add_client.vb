Public Class add_client
    Private Sub add_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub save_changes_btn_Click(sender As Object, e As EventArgs) Handles save_changes_btn.Click

        Dim res As DialogResult = MessageBox.Show("Los cambios de guardaran. ¿Estas seguro de los cambios?", "Cambios al cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If res = DialogResult.Yes Then
            Me.Close()

            employee_form.Show()
        End If

    End Sub
End Class