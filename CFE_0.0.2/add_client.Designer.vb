<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_client
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_client))
        Me.add_client_title_lbl = New System.Windows.Forms.Label()
        Me.personal_info_panel = New System.Windows.Forms.Panel()
        Me.canel_client_info_btn = New System.Windows.Forms.Button()
        Me.save_client_btn = New System.Windows.Forms.Button()
        Me.client_curp_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.birthday_dtp = New System.Windows.Forms.DateTimePicker()
        Me.male_rbtn = New System.Windows.Forms.RadioButton()
        Me.female_rbtn = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.client_email_txt = New System.Windows.Forms.TextBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.last_name_txt = New System.Windows.Forms.TextBox()
        Me.Flast_name_txt = New System.Windows.Forms.TextBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.cliente_middle_name_txt = New System.Windows.Forms.TextBox()
        Me.client_name_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.save_changes_btn = New System.Windows.Forms.Button()
        Me.contract_panel = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tarif_lbl = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.client_name_lbl = New System.Windows.Forms.Label()
        Me.employee_name_lbl = New System.Windows.Forms.Label()
        Me.no_med_lbl = New System.Windows.Forms.Label()
        Me.no_service_lbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.domestic_rbtn = New System.Windows.Forms.RadioButton()
        Me.industrial_rbtn = New System.Windows.Forms.RadioButton()
        Me.state_cb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.city_txt = New System.Windows.Forms.TextBox()
        Me.zipCode_txt = New System.Windows.Forms.TextBox()
        Me.street_txt = New System.Windows.Forms.TextBox()
        Me.no_dom_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.personal_info_panel.SuspendLayout()
        Me.contract_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'add_client_title_lbl
        '
        Me.add_client_title_lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.add_client_title_lbl.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.add_client_title_lbl.Location = New System.Drawing.Point(0, 0)
        Me.add_client_title_lbl.Name = "add_client_title_lbl"
        Me.add_client_title_lbl.Size = New System.Drawing.Size(719, 75)
        Me.add_client_title_lbl.TabIndex = 0
        Me.add_client_title_lbl.Text = "Cliente nuevo"
        Me.add_client_title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'personal_info_panel
        '
        Me.personal_info_panel.Controls.Add(Me.canel_client_info_btn)
        Me.personal_info_panel.Controls.Add(Me.save_client_btn)
        Me.personal_info_panel.Controls.Add(Me.client_curp_txt)
        Me.personal_info_panel.Controls.Add(Me.Label4)
        Me.personal_info_panel.Controls.Add(Me.birthday_dtp)
        Me.personal_info_panel.Controls.Add(Me.male_rbtn)
        Me.personal_info_panel.Controls.Add(Me.female_rbtn)
        Me.personal_info_panel.Controls.Add(Me.Label8)
        Me.personal_info_panel.Controls.Add(Me.Label3)
        Me.personal_info_panel.Controls.Add(Me.client_email_txt)
        Me.personal_info_panel.Controls.Add(Me.password_txt)
        Me.personal_info_panel.Controls.Add(Me.last_name_txt)
        Me.personal_info_panel.Controls.Add(Me.Flast_name_txt)
        Me.personal_info_panel.Controls.Add(Me.username_txt)
        Me.personal_info_panel.Controls.Add(Me.cliente_middle_name_txt)
        Me.personal_info_panel.Controls.Add(Me.client_name_txt)
        Me.personal_info_panel.Controls.Add(Me.Label2)
        Me.personal_info_panel.Controls.Add(Me.save_changes_btn)
        Me.personal_info_panel.Location = New System.Drawing.Point(12, 89)
        Me.personal_info_panel.Name = "personal_info_panel"
        Me.personal_info_panel.Padding = New System.Windows.Forms.Padding(10)
        Me.personal_info_panel.Size = New System.Drawing.Size(695, 274)
        Me.personal_info_panel.TabIndex = 1
        '
        'canel_client_info_btn
        '
        Me.canel_client_info_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.canel_client_info_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.canel_client_info_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.canel_client_info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.canel_client_info_btn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.canel_client_info_btn.Location = New System.Drawing.Point(471, 219)
        Me.canel_client_info_btn.Name = "canel_client_info_btn"
        Me.canel_client_info_btn.Size = New System.Drawing.Size(100, 37)
        Me.canel_client_info_btn.TabIndex = 3
        Me.canel_client_info_btn.Text = "Cancelar"
        Me.canel_client_info_btn.UseVisualStyleBackColor = False
        '
        'save_client_btn
        '
        Me.save_client_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.save_client_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.save_client_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.save_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_client_btn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.save_client_btn.Location = New System.Drawing.Point(577, 219)
        Me.save_client_btn.Name = "save_client_btn"
        Me.save_client_btn.Size = New System.Drawing.Size(100, 37)
        Me.save_client_btn.TabIndex = 3
        Me.save_client_btn.Text = "Guardar"
        Me.save_client_btn.UseVisualStyleBackColor = False
        '
        'client_curp_txt
        '
        Me.client_curp_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.client_curp_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_curp_txt.Location = New System.Drawing.Point(214, 219)
        Me.client_curp_txt.Name = "client_curp_txt"
        Me.client_curp_txt.PlaceholderText = "CURP"
        Me.client_curp_txt.Size = New System.Drawing.Size(185, 29)
        Me.client_curp_txt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(145, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha de nacimiento"
        '
        'birthday_dtp
        '
        Me.birthday_dtp.CalendarFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.birthday_dtp.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.birthday_dtp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.birthday_dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthday_dtp.Location = New System.Drawing.Point(299, 189)
        Me.birthday_dtp.Name = "birthday_dtp"
        Me.birthday_dtp.Size = New System.Drawing.Size(98, 23)
        Me.birthday_dtp.TabIndex = 4
        '
        'male_rbtn
        '
        Me.male_rbtn.AutoSize = True
        Me.male_rbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.male_rbtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.male_rbtn.Location = New System.Drawing.Point(37, 187)
        Me.male_rbtn.Name = "male_rbtn"
        Me.male_rbtn.Size = New System.Drawing.Size(83, 25)
        Me.male_rbtn.TabIndex = 3
        Me.male_rbtn.TabStop = True
        Me.male_rbtn.Text = "Hombre"
        Me.male_rbtn.UseVisualStyleBackColor = True
        '
        'female_rbtn
        '
        Me.female_rbtn.AutoSize = True
        Me.female_rbtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.female_rbtn.Location = New System.Drawing.Point(37, 218)
        Me.female_rbtn.Name = "female_rbtn"
        Me.female_rbtn.Size = New System.Drawing.Size(66, 25)
        Me.female_rbtn.TabIndex = 3
        Me.female_rbtn.TabStop = True
        Me.female_rbtn.Text = "Mujer"
        Me.female_rbtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(430, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 32)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(25, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre completo"
        '
        'client_email_txt
        '
        Me.client_email_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.client_email_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_email_txt.Location = New System.Drawing.Point(430, 169)
        Me.client_email_txt.Name = "client_email_txt"
        Me.client_email_txt.PlaceholderText = "tu-correo@dominio.com"
        Me.client_email_txt.Size = New System.Drawing.Size(247, 29)
        Me.client_email_txt.TabIndex = 1
        '
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.password_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.password_txt.Location = New System.Drawing.Point(430, 134)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PlaceholderText = "Contraseña"
        Me.password_txt.Size = New System.Drawing.Size(247, 29)
        Me.password_txt.TabIndex = 1
        '
        'last_name_txt
        '
        Me.last_name_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.last_name_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.last_name_txt.Location = New System.Drawing.Point(214, 134)
        Me.last_name_txt.Name = "last_name_txt"
        Me.last_name_txt.PlaceholderText = "Apellido materno"
        Me.last_name_txt.Size = New System.Drawing.Size(183, 29)
        Me.last_name_txt.TabIndex = 1
        '
        'Flast_name_txt
        '
        Me.Flast_name_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Flast_name_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Flast_name_txt.Location = New System.Drawing.Point(25, 134)
        Me.Flast_name_txt.Name = "Flast_name_txt"
        Me.Flast_name_txt.PlaceholderText = "Apellido paterno"
        Me.Flast_name_txt.Size = New System.Drawing.Size(183, 29)
        Me.Flast_name_txt.TabIndex = 1
        '
        'username_txt
        '
        Me.username_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.username_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.username_txt.Location = New System.Drawing.Point(430, 99)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.PlaceholderText = "Nombre de usuario"
        Me.username_txt.Size = New System.Drawing.Size(247, 29)
        Me.username_txt.TabIndex = 1
        '
        'cliente_middle_name_txt
        '
        Me.cliente_middle_name_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cliente_middle_name_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cliente_middle_name_txt.Location = New System.Drawing.Point(214, 99)
        Me.cliente_middle_name_txt.Name = "cliente_middle_name_txt"
        Me.cliente_middle_name_txt.PlaceholderText = "Segundo nombre"
        Me.cliente_middle_name_txt.Size = New System.Drawing.Size(183, 29)
        Me.cliente_middle_name_txt.TabIndex = 1
        '
        'client_name_txt
        '
        Me.client_name_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.client_name_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_name_txt.Location = New System.Drawing.Point(25, 99)
        Me.client_name_txt.Name = "client_name_txt"
        Me.client_name_txt.PlaceholderText = "Nombre"
        Me.client_name_txt.Size = New System.Drawing.Size(183, 29)
        Me.client_name_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 45)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos personales"
        '
        'save_changes_btn
        '
        Me.save_changes_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.save_changes_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.save_changes_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.save_changes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_changes_btn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.save_changes_btn.Location = New System.Drawing.Point(521, 219)
        Me.save_changes_btn.Name = "save_changes_btn"
        Me.save_changes_btn.Size = New System.Drawing.Size(156, 37)
        Me.save_changes_btn.TabIndex = 3
        Me.save_changes_btn.Text = "Guardar cambios"
        Me.save_changes_btn.UseVisualStyleBackColor = False
        Me.save_changes_btn.Visible = False
        '
        'contract_panel
        '
        Me.contract_panel.Controls.Add(Me.Button5)
        Me.contract_panel.Controls.Add(Me.Button3)
        Me.contract_panel.Controls.Add(Me.tarif_lbl)
        Me.contract_panel.Controls.Add(Me.Button4)
        Me.contract_panel.Controls.Add(Me.Button1)
        Me.contract_panel.Controls.Add(Me.client_name_lbl)
        Me.contract_panel.Controls.Add(Me.employee_name_lbl)
        Me.contract_panel.Controls.Add(Me.no_med_lbl)
        Me.contract_panel.Controls.Add(Me.no_service_lbl)
        Me.contract_panel.Controls.Add(Me.Label14)
        Me.contract_panel.Controls.Add(Me.Label13)
        Me.contract_panel.Controls.Add(Me.Label12)
        Me.contract_panel.Controls.Add(Me.Label11)
        Me.contract_panel.Controls.Add(Me.Label10)
        Me.contract_panel.Controls.Add(Me.domestic_rbtn)
        Me.contract_panel.Controls.Add(Me.industrial_rbtn)
        Me.contract_panel.Controls.Add(Me.state_cb)
        Me.contract_panel.Controls.Add(Me.Label5)
        Me.contract_panel.Controls.Add(Me.Label9)
        Me.contract_panel.Controls.Add(Me.Label6)
        Me.contract_panel.Controls.Add(Me.city_txt)
        Me.contract_panel.Controls.Add(Me.zipCode_txt)
        Me.contract_panel.Controls.Add(Me.street_txt)
        Me.contract_panel.Controls.Add(Me.no_dom_txt)
        Me.contract_panel.Controls.Add(Me.Label7)
        Me.contract_panel.Location = New System.Drawing.Point(12, 393)
        Me.contract_panel.Name = "contract_panel"
        Me.contract_panel.Padding = New System.Windows.Forms.Padding(10)
        Me.contract_panel.Size = New System.Drawing.Size(695, 285)
        Me.contract_panel.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(471, 229)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 37)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Cancelar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(191, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 37)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tarif_lbl
        '
        Me.tarif_lbl.AutoSize = True
        Me.tarif_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tarif_lbl.Location = New System.Drawing.Point(521, 197)
        Me.tarif_lbl.Name = "tarif_lbl"
        Me.tarif_lbl.Size = New System.Drawing.Size(66, 17)
        Me.tarif_lbl.TabIndex = 10
        Me.tarif_lbl.Text = "Domestica"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(577, 229)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Firmar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(297, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'client_name_lbl
        '
        Me.client_name_lbl.AutoSize = True
        Me.client_name_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_name_lbl.Location = New System.Drawing.Point(521, 160)
        Me.client_name_lbl.Name = "client_name_lbl"
        Me.client_name_lbl.Size = New System.Drawing.Size(120, 17)
        Me.client_name_lbl.TabIndex = 10
        Me.client_name_lbl.Text = "Juan ortega sanchez"
        '
        'employee_name_lbl
        '
        Me.employee_name_lbl.AutoSize = True
        Me.employee_name_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.employee_name_lbl.Location = New System.Drawing.Point(521, 127)
        Me.employee_name_lbl.Name = "employee_name_lbl"
        Me.employee_name_lbl.Size = New System.Drawing.Size(167, 17)
        Me.employee_name_lbl.TabIndex = 10
        Me.employee_name_lbl.Text = "Jose antonio hernedez perez"
        '
        'no_med_lbl
        '
        Me.no_med_lbl.AutoSize = True
        Me.no_med_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.no_med_lbl.Location = New System.Drawing.Point(596, 85)
        Me.no_med_lbl.Name = "no_med_lbl"
        Me.no_med_lbl.Size = New System.Drawing.Size(61, 17)
        Me.no_med_lbl.TabIndex = 10
        Me.no_med_lbl.Text = "78945213"
        '
        'no_service_lbl
        '
        Me.no_service_lbl.AutoSize = True
        Me.no_service_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.no_service_lbl.Location = New System.Drawing.Point(432, 85)
        Me.no_service_lbl.Name = "no_service_lbl"
        Me.no_service_lbl.Size = New System.Drawing.Size(90, 17)
        Me.no_service_lbl.TabIndex = 10
        Me.no_service_lbl.Text = "342342458123"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(430, 193)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 21)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Tarifa"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(430, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 21)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(430, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 21)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Empleado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(577, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 21)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "No medidor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(430, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "No servicio"
        '
        'domestic_rbtn
        '
        Me.domestic_rbtn.AutoSize = True
        Me.domestic_rbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.domestic_rbtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.domestic_rbtn.Location = New System.Drawing.Point(298, 172)
        Me.domestic_rbtn.Name = "domestic_rbtn"
        Me.domestic_rbtn.Size = New System.Drawing.Size(99, 25)
        Me.domestic_rbtn.TabIndex = 7
        Me.domestic_rbtn.TabStop = True
        Me.domestic_rbtn.Text = "Domestico"
        Me.domestic_rbtn.UseVisualStyleBackColor = True
        '
        'industrial_rbtn
        '
        Me.industrial_rbtn.AutoSize = True
        Me.industrial_rbtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.industrial_rbtn.Location = New System.Drawing.Point(213, 172)
        Me.industrial_rbtn.Name = "industrial_rbtn"
        Me.industrial_rbtn.Size = New System.Drawing.Size(89, 25)
        Me.industrial_rbtn.TabIndex = 8
        Me.industrial_rbtn.TabStop = True
        Me.industrial_rbtn.Text = "Industrial"
        Me.industrial_rbtn.UseVisualStyleBackColor = True
        '
        'state_cb
        '
        Me.state_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.state_cb.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.state_cb.FormattingEnabled = True
        Me.state_cb.Location = New System.Drawing.Point(86, 169)
        Me.state_cb.Name = "state_cb"
        Me.state_cb.Size = New System.Drawing.Size(121, 29)
        Me.state_cb.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(25, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(432, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(245, 32)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Información contrato"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(25, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 32)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Domicilio"
        '
        'city_txt
        '
        Me.city_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.city_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.city_txt.Location = New System.Drawing.Point(214, 134)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.PlaceholderText = "Ciudad"
        Me.city_txt.Size = New System.Drawing.Size(183, 29)
        Me.city_txt.TabIndex = 1
        '
        'zipCode_txt
        '
        Me.zipCode_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.zipCode_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.zipCode_txt.Location = New System.Drawing.Point(25, 134)
        Me.zipCode_txt.Name = "zipCode_txt"
        Me.zipCode_txt.PlaceholderText = "Codigo postal"
        Me.zipCode_txt.Size = New System.Drawing.Size(183, 29)
        Me.zipCode_txt.TabIndex = 1
        '
        'street_txt
        '
        Me.street_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.street_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.street_txt.Location = New System.Drawing.Point(214, 99)
        Me.street_txt.Name = "street_txt"
        Me.street_txt.PlaceholderText = "Calle"
        Me.street_txt.Size = New System.Drawing.Size(183, 29)
        Me.street_txt.TabIndex = 1
        '
        'no_dom_txt
        '
        Me.no_dom_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.no_dom_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.no_dom_txt.Location = New System.Drawing.Point(25, 99)
        Me.no_dom_txt.Name = "no_dom_txt"
        Me.no_dom_txt.PlaceholderText = "Numero"
        Me.no_dom_txt.Size = New System.Drawing.Size(183, 29)
        Me.no_dom_txt.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 45)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Contrato"
        '
        'add_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(719, 696)
        Me.Controls.Add(Me.contract_panel)
        Me.Controls.Add(Me.personal_info_panel)
        Me.Controls.Add(Me.add_client_title_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(735, 735)
        Me.MinimizeBox = False
        Me.Name = "add_client"
        Me.Text = "Agregar cliente"
        Me.personal_info_panel.ResumeLayout(False)
        Me.personal_info_panel.PerformLayout()
        Me.contract_panel.ResumeLayout(False)
        Me.contract_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents add_client_title_lbl As Label
    Friend WithEvents personal_info_panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents client_name_txt As TextBox
    Friend WithEvents cliente_middle_name_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents last_name_txt As TextBox
    Friend WithEvents Flast_name_txt As TextBox
    Friend WithEvents client_curp_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents birthday_dtp As DateTimePicker
    Friend WithEvents male_rbtn As RadioButton
    Friend WithEvents female_rbtn As RadioButton
    Friend WithEvents contract_panel As Panel
    Friend WithEvents domestic_rbtn As RadioButton
    Friend WithEvents industrial_rbtn As RadioButton
    Friend WithEvents state_cb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents city_txt As TextBox
    Friend WithEvents zipCode_txt As TextBox
    Friend WithEvents street_txt As TextBox
    Friend WithEvents no_dom_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents save_client_btn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents client_email_txt As TextBox
    Friend WithEvents password_txt As TextBox
    Friend WithEvents username_txt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tarif_lbl As Label
    Friend WithEvents client_name_lbl As Label
    Friend WithEvents employee_name_lbl As Label
    Friend WithEvents no_med_lbl As Label
    Friend WithEvents no_service_lbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents canel_client_info_btn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents save_changes_btn As Button
End Class
