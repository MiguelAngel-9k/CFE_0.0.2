Public Class add_consume
    Private Sub charge_consume_btn_Click(sender As Object, e As EventArgs) Handles charge_consume_btn.Click
        MessageBox.Show("Se agrego el consumo", "Agregar consumo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()
        employee_form.Show()
    End Sub

    Private Sub find_service_btn_Click(sender As Object, e As EventArgs) Handles find_service_btn.Click
        charge_consume_btn.Enabled = True
    End Sub

    Private Sub gen_consume_btn_Click(sender As Object, e As EventArgs) Handles gen_consume_btn.Click

        charge_consume_btn.Enabled = True

        basic_lbl.Text = 0
        intermidate_lbl.Text = 0
        excedent_lbl.Text = 0

        Dim total_consume = Convert.ToInt32(total_consume_txt.Text)
        Dim consume_lvl = 100
        Dim ind As Integer = 0
        Dim labels() As Label = {basic_lbl, intermidate_lbl, excedent_lbl}

        While (consume_lvl >= 50)

            If total_consume >= consume_lvl Then
                total_consume -= consume_lvl.ToString()
                labels(ind).Text = consume_lvl.ToString()
            ElseIf total_consume < 100 And total_consume <> 0 Then
                labels(0).Text = total_consume
                total_consume = 0
                Exit While
            End If

        consume_lvl /= 2
            ind += 1
        End While

        If total_consume > 0 Then
            labels(ind).Text = total_consume.ToString()
        End If
    End Sub
End Class