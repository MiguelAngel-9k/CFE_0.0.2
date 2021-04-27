Public Class employee_form
    Private Sub employee_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Form1.Close()
    End Sub

    Private Sub add_client_btn_Click(sender As Object, e As EventArgs) Handles add_client_btn.Click, Button2.Click
        Me.Close()
        add_client.Show()
    End Sub

    Private Sub delete_client_btn_Click(sender As Object, e As EventArgs) Handles delete_client_btn.Click

        Dim res As DialogResult = MessageBox.Show(
                                            "El cliente se eliminara asi como sus contratos vigentes ¿Está seguro?",
                                            "Dar de baja cliente",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If (res = DialogResult.OK) Then
            'Se dara de baja al cliente
            client_name_lbl.Text = "Nombre del cliente"
            client_gender_lbl.Text = "Genero"
            client_email_lbl.Text = "correo@cliente.com"
            client_user_lbl.Text = "Usuario"
            client_CURP_lbl.Text = "CURP del cliente"
            client_birthdate_lbl.Text = "dia/mes/año"
            count_status_ck.Checked = True
            count_status_ck.ForeColor = Color.Salmon
            new_contract_btn.Enabled = False
            add_consume_btn.Enabled = False
            delete_client_btn.Enabled = False
        End If

        Return
    End Sub

    Private Sub count_status_ck_CheckedChanged(sender As Object, e As EventArgs) Handles count_status_ck.CheckedChanged
        If count_status_ck.Checked = False Then
            count_status_ck.ForeColor = Color.Salmon
            count_status_ck.Text = "Inhabilitada"
        Else
            count_status_ck.ForeColor = Color.Green
            count_status_ck.Text = "habilitada"
        End If
    End Sub

    Private Sub edit_client_btn_Click(sender As Object, e As EventArgs) Handles edit_client_btn.Click
        add_client.add_client_title_lbl.Text = "Editar Cliente"

        add_client.contract_panel.Visible = False
        add_client.Height = 422
        add_client.save_changes_btn.Visible = True
        add_client.save_client_btn.Visible = False
        add_client.canel_client_info_btn.Visible = False

        add_client.Show()
        Me.Close()
    End Sub

    Private Sub add_consume_btn_Click(sender As Object, e As EventArgs) Handles add_consume_btn.Click
        add_consume.Show()
        Me.Close()
    End Sub
End Class