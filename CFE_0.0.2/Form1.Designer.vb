<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.login_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.status = New System.Windows.Forms.Label()
        Me.remember_me_ck = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.log_as_cb = New System.Windows.Forms.ComboBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.usuario_txt = New System.Windows.Forms.TextBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.login_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login_btn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.login_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
        Me.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_btn.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.login_btn.Location = New System.Drawing.Point(29, 317)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(126, 43)
        Me.login_btn.TabIndex = 0
        Me.login_btn.Text = "Entrar"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 85)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Iniciar sesión"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.status)
        Me.Panel1.Controls.Add(Me.remember_me_ck)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.log_as_cb)
        Me.Panel1.Controls.Add(Me.password_txt)
        Me.Panel1.Controls.Add(Me.usuario_txt)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Controls.Add(Me.login_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(0, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 394)
        Me.Panel1.TabIndex = 2
        '
        'status
        '
        Me.status.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.status.ForeColor = System.Drawing.Color.Salmon
        Me.status.Location = New System.Drawing.Point(192, 262)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(161, 36)
        Me.status.TabIndex = 5
        Me.status.Text = "Cuenta inhabilitada, contacte a un empleado"
        '
        'remember_me_ck
        '
        Me.remember_me_ck.AutoSize = True
        Me.remember_me_ck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remember_me_ck.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.remember_me_ck.Location = New System.Drawing.Point(29, 269)
        Me.remember_me_ck.Name = "remember_me_ck"
        Me.remember_me_ck.Size = New System.Drawing.Size(132, 29)
        Me.remember_me_ck.TabIndex = 4
        Me.remember_me_ck.Text = "Recuerdame"
        Me.remember_me_ck.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(132, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Entrar como:"
        '
        'log_as_cb
        '
        Me.log_as_cb.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.log_as_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.log_as_cb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.log_as_cb.FormattingEnabled = True
        Me.log_as_cb.Location = New System.Drawing.Point(29, 217)
        Me.log_as_cb.Margin = New System.Windows.Forms.Padding(20)
        Me.log_as_cb.Name = "log_as_cb"
        Me.log_as_cb.Size = New System.Drawing.Size(324, 29)
        Me.log_as_cb.Sorted = True
        Me.log_as_cb.TabIndex = 2
        '
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.password_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.password_txt.Location = New System.Drawing.Point(29, 107)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(20)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.PlaceholderText = "Contraseña"
        Me.password_txt.Size = New System.Drawing.Size(324, 29)
        Me.password_txt.TabIndex = 1
        Me.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'usuario_txt
        '
        Me.usuario_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.usuario_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.usuario_txt.Location = New System.Drawing.Point(29, 38)
        Me.usuario_txt.Margin = New System.Windows.Forms.Padding(20)
        Me.usuario_txt.Name = "usuario_txt"
        Me.usuario_txt.PlaceholderText = "Nombre usuario"
        Me.usuario_txt.Size = New System.Drawing.Size(324, 29)
        Me.usuario_txt.TabIndex = 1
        Me.usuario_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.close_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.close_btn.Location = New System.Drawing.Point(227, 317)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(126, 43)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "Salir"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(382, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "CFE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents login_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents log_as_cb As ComboBox
    Friend WithEvents password_txt As TextBox
    Friend WithEvents usuario_txt As TextBox
    Friend WithEvents close_btn As Button
    Friend WithEvents remember_me_ck As CheckBox
    Friend WithEvents status As Label
End Class
