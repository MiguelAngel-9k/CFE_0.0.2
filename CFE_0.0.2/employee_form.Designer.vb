<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employee_form
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employee_form))
        Me.close_btn = New System.Windows.Forms.Button()
        Me.find_client_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.edit_client_btn = New System.Windows.Forms.Button()
        Me.count_status_ck = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.client_birthdate_lbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.client_CURP_lbl = New System.Windows.Forms.Label()
        Me.client_gender_lbl = New System.Windows.Forms.Label()
        Me.client_user_lbl = New System.Windows.Forms.Label()
        Me.client_email_lbl = New System.Windows.Forms.Label()
        Me.client_name_lbl = New System.Windows.Forms.Label()
        Me.add_consume_btn = New System.Windows.Forms.Button()
        Me.new_contract_btn = New System.Windows.Forms.Button()
        Me.add_client_btn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.delete_client_btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.personal_employee_info_panel = New System.Windows.Forms.Panel()
        Me.canel_employee_info_btn = New System.Windows.Forms.Button()
        Me.save_employee_btn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.client_curp_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.last_name_txt = New System.Windows.Forms.TextBox()
        Me.Flast_name_txt = New System.Windows.Forms.TextBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.cliente_middle_name_txt = New System.Windows.Forms.TextBox()
        Me.client_name_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.add_employee_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.personal_employee_info_panel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.close_btn.Location = New System.Drawing.Point(393, 493)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(110, 26)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "Cerrar sesión"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'find_client_txt
        '
        Me.find_client_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.find_client_txt.Location = New System.Drawing.Point(28, 83)
        Me.find_client_txt.Margin = New System.Windows.Forms.Padding(20)
        Me.find_client_txt.Name = "find_client_txt"
        Me.find_client_txt.PlaceholderText = "Buscar cliente por usuario, curp, no contrato"
        Me.find_client_txt.Size = New System.Drawing.Size(471, 29)
        Me.find_client_txt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(471, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 18)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(285, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "JOSÉ GUTIERRES HERNANDEZ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(409, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "11/04/2021"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.edit_client_btn)
        Me.Panel1.Controls.Add(Me.count_status_ck)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.client_birthdate_lbl)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.client_CURP_lbl)
        Me.Panel1.Controls.Add(Me.client_gender_lbl)
        Me.Panel1.Controls.Add(Me.client_user_lbl)
        Me.Panel1.Controls.Add(Me.client_email_lbl)
        Me.Panel1.Controls.Add(Me.client_name_lbl)
        Me.Panel1.Location = New System.Drawing.Point(28, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 298)
        Me.Panel1.TabIndex = 6
        '
        'edit_client_btn
        '
        Me.edit_client_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.edit_client_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.edit_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_client_btn.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.edit_client_btn.Location = New System.Drawing.Point(354, 115)
        Me.edit_client_btn.Name = "edit_client_btn"
        Me.edit_client_btn.Size = New System.Drawing.Size(117, 30)
        Me.edit_client_btn.TabIndex = 7
        Me.edit_client_btn.Text = "Editar"
        Me.edit_client_btn.UseVisualStyleBackColor = False
        '
        'count_status_ck
        '
        Me.count_status_ck.AutoSize = True
        Me.count_status_ck.Checked = True
        Me.count_status_ck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.count_status_ck.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.count_status_ck.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.count_status_ck.ForeColor = System.Drawing.Color.Green
        Me.count_status_ck.Location = New System.Drawing.Point(365, 29)
        Me.count_status_ck.Name = "count_status_ck"
        Me.count_status_ck.Size = New System.Drawing.Size(96, 25)
        Me.count_status_ck.TabIndex = 3
        Me.count_status_ck.Text = "Habilitada"
        Me.count_status_ck.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(471, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'client_birthdate_lbl
        '
        Me.client_birthdate_lbl.AutoSize = True
        Me.client_birthdate_lbl.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_birthdate_lbl.Location = New System.Drawing.Point(283, 60)
        Me.client_birthdate_lbl.Name = "client_birthdate_lbl"
        Me.client_birthdate_lbl.Size = New System.Drawing.Size(82, 21)
        Me.client_birthdate_lbl.TabIndex = 1
        Me.client_birthdate_lbl.Text = "12/05/1992"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(0, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Contratos vigentes"
        '
        'client_CURP_lbl
        '
        Me.client_CURP_lbl.AutoSize = True
        Me.client_CURP_lbl.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_CURP_lbl.Location = New System.Drawing.Point(12, 60)
        Me.client_CURP_lbl.Name = "client_CURP_lbl"
        Me.client_CURP_lbl.Size = New System.Drawing.Size(157, 21)
        Me.client_CURP_lbl.TabIndex = 1
        Me.client_CURP_lbl.Text = "HOJA12051992HNLDR"
        '
        'client_gender_lbl
        '
        Me.client_gender_lbl.AutoSize = True
        Me.client_gender_lbl.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_gender_lbl.Location = New System.Drawing.Point(381, 5)
        Me.client_gender_lbl.Name = "client_gender_lbl"
        Me.client_gender_lbl.Size = New System.Drawing.Size(77, 21)
        Me.client_gender_lbl.TabIndex = 1
        Me.client_gender_lbl.Text = "Masculino"
        '
        'client_user_lbl
        '
        Me.client_user_lbl.AutoSize = True
        Me.client_user_lbl.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_user_lbl.Location = New System.Drawing.Point(283, 33)
        Me.client_user_lbl.Name = "client_user_lbl"
        Me.client_user_lbl.Size = New System.Drawing.Size(53, 21)
        Me.client_user_lbl.TabIndex = 1
        Me.client_user_lbl.Text = "Joherz"
        '
        'client_email_lbl
        '
        Me.client_email_lbl.AutoSize = True
        Me.client_email_lbl.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_email_lbl.Location = New System.Drawing.Point(12, 30)
        Me.client_email_lbl.Name = "client_email_lbl"
        Me.client_email_lbl.Size = New System.Drawing.Size(105, 21)
        Me.client_email_lbl.TabIndex = 1
        Me.client_email_lbl.Text = "jose@gmail.es"
        '
        'client_name_lbl
        '
        Me.client_name_lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.client_name_lbl.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.client_name_lbl.Location = New System.Drawing.Point(0, 0)
        Me.client_name_lbl.Name = "client_name_lbl"
        Me.client_name_lbl.Size = New System.Drawing.Size(471, 26)
        Me.client_name_lbl.TabIndex = 0
        Me.client_name_lbl.Text = "JOSÉ ANOTONIO HERNADEZ ORTEGA"
        '
        'add_consume_btn
        '
        Me.add_consume_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.add_consume_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.add_consume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_consume_btn.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_consume_btn.Location = New System.Drawing.Point(30, 439)
        Me.add_consume_btn.Name = "add_consume_btn"
        Me.add_consume_btn.Size = New System.Drawing.Size(117, 30)
        Me.add_consume_btn.TabIndex = 7
        Me.add_consume_btn.Text = "Agregar consumo"
        Me.add_consume_btn.UseVisualStyleBackColor = False
        '
        'new_contract_btn
        '
        Me.new_contract_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.new_contract_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.new_contract_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.new_contract_btn.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.new_contract_btn.Location = New System.Drawing.Point(151, 439)
        Me.new_contract_btn.Name = "new_contract_btn"
        Me.new_contract_btn.Size = New System.Drawing.Size(117, 30)
        Me.new_contract_btn.TabIndex = 7
        Me.new_contract_btn.Text = "Nuevo contrato"
        Me.new_contract_btn.UseVisualStyleBackColor = False
        '
        'add_client_btn
        '
        Me.add_client_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.add_client_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.add_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_client_btn.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_client_btn.Location = New System.Drawing.Point(14, 12)
        Me.add_client_btn.Name = "add_client_btn"
        Me.add_client_btn.Size = New System.Drawing.Size(110, 26)
        Me.add_client_btn.TabIndex = 0
        Me.add_client_btn.Text = "Cliente nuevo"
        Me.add_client_btn.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'delete_client_btn
        '
        Me.delete_client_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.delete_client_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.delete_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_client_btn.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.delete_client_btn.Location = New System.Drawing.Point(391, 439)
        Me.delete_client_btn.Name = "delete_client_btn"
        Me.delete_client_btn.Size = New System.Drawing.Size(110, 30)
        Me.delete_client_btn.TabIndex = 0
        Me.delete_client_btn.Text = "Dar de baja"
        Me.delete_client_btn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(130, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 26)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Nueva tarifa"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'personal_employee_info_panel
        '
        Me.personal_employee_info_panel.Controls.Add(Me.canel_employee_info_btn)
        Me.personal_employee_info_panel.Controls.Add(Me.save_employee_btn)
        Me.personal_employee_info_panel.Controls.Add(Me.TextBox1)
        Me.personal_employee_info_panel.Controls.Add(Me.client_curp_txt)
        Me.personal_employee_info_panel.Controls.Add(Me.Label8)
        Me.personal_employee_info_panel.Controls.Add(Me.Label3)
        Me.personal_employee_info_panel.Controls.Add(Me.password_txt)
        Me.personal_employee_info_panel.Controls.Add(Me.last_name_txt)
        Me.personal_employee_info_panel.Controls.Add(Me.Flast_name_txt)
        Me.personal_employee_info_panel.Controls.Add(Me.username_txt)
        Me.personal_employee_info_panel.Controls.Add(Me.cliente_middle_name_txt)
        Me.personal_employee_info_panel.Controls.Add(Me.client_name_txt)
        Me.personal_employee_info_panel.Controls.Add(Me.Label5)
        Me.personal_employee_info_panel.Enabled = False
        Me.personal_employee_info_panel.Location = New System.Drawing.Point(505, 308)
        Me.personal_employee_info_panel.Name = "personal_employee_info_panel"
        Me.personal_employee_info_panel.Padding = New System.Windows.Forms.Padding(10)
        Me.personal_employee_info_panel.Size = New System.Drawing.Size(635, 213)
        Me.personal_employee_info_panel.TabIndex = 8
        '
        'canel_employee_info_btn
        '
        Me.canel_employee_info_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.canel_employee_info_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.canel_employee_info_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral
        Me.canel_employee_info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.canel_employee_info_btn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.canel_employee_info_btn.Location = New System.Drawing.Point(415, 169)
        Me.canel_employee_info_btn.Name = "canel_employee_info_btn"
        Me.canel_employee_info_btn.Size = New System.Drawing.Size(100, 29)
        Me.canel_employee_info_btn.TabIndex = 3
        Me.canel_employee_info_btn.Text = "Cancelar"
        Me.canel_employee_info_btn.UseVisualStyleBackColor = False
        '
        'save_employee_btn
        '
        Me.save_employee_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.save_employee_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.save_employee_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.save_employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_employee_btn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.save_employee_btn.Location = New System.Drawing.Point(521, 169)
        Me.save_employee_btn.Name = "save_employee_btn"
        Me.save_employee_btn.Size = New System.Drawing.Size(99, 29)
        Me.save_employee_btn.TabIndex = 3
        Me.save_employee_btn.Text = "Guardar"
        Me.save_employee_btn.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(216, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "RFC"
        Me.TextBox1.Size = New System.Drawing.Size(181, 29)
        Me.TextBox1.TabIndex = 6
        '
        'client_curp_txt
        '
        Me.client_curp_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.client_curp_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_curp_txt.Location = New System.Drawing.Point(25, 169)
        Me.client_curp_txt.Name = "client_curp_txt"
        Me.client_curp_txt.PlaceholderText = "CURP"
        Me.client_curp_txt.Size = New System.Drawing.Size(183, 29)
        Me.client_curp_txt.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(415, 64)
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
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.password_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.password_txt.Location = New System.Drawing.Point(415, 134)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PlaceholderText = "Contraseña"
        Me.password_txt.Size = New System.Drawing.Size(205, 29)
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
        Me.username_txt.Location = New System.Drawing.Point(415, 99)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.PlaceholderText = "Nombre de usuario"
        Me.username_txt.Size = New System.Drawing.Size(205, 29)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 45)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Datos personales"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(512, 78)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(635, 180)
        Me.DataGridView2.TabIndex = 9
        '
        'add_employee_btn
        '
        Me.add_employee_btn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.add_employee_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.add_employee_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.add_employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_employee_btn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_employee_btn.Location = New System.Drawing.Point(976, 28)
        Me.add_employee_btn.Name = "add_employee_btn"
        Me.add_employee_btn.Size = New System.Drawing.Size(168, 36)
        Me.add_employee_btn.TabIndex = 3
        Me.add_employee_btn.Text = "Agregar empleado"
        Me.add_employee_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(512, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 45)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Empleados"
        '
        'employee_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1164, 533)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.add_employee_btn)
        Me.Controls.Add(Me.personal_employee_info_panel)
        Me.Controls.Add(Me.new_contract_btn)
        Me.Controls.Add(Me.add_consume_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.find_client_txt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.add_client_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.delete_client_btn)
        Me.Controls.Add(Me.close_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "employee_form"
        Me.Text = "CFE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.personal_employee_info_panel.ResumeLayout(False)
        Me.personal_employee_info_panel.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents close_btn As Button
    Friend WithEvents find_client_txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents client_birthdate_lbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents client_CURP_lbl As Label
    Friend WithEvents client_gender_lbl As Label
    Friend WithEvents client_user_lbl As Label
    Friend WithEvents client_email_lbl As Label
    Friend WithEvents client_name_lbl As Label
    Friend WithEvents count_status_ck As CheckBox
    Friend WithEvents add_consume_btn As Button
    Friend WithEvents new_contract_btn As Button
    Friend WithEvents add_client_btn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents delete_client_btn As Button
    Friend WithEvents edit_client_btn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents personal_employee_info_panel As Panel
    Friend WithEvents canel_client_info_btn As Button
    Friend WithEvents save_employee_btn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents client_curp_txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents password_txt As TextBox
    Friend WithEvents last_name_txt As TextBox
    Friend WithEvents Flast_name_txt As TextBox
    Friend WithEvents username_txt As TextBox
    Friend WithEvents cliente_middle_name_txt As TextBox
    Friend WithEvents client_name_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents add_employee_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents canel_employee_info_btn As Button
End Class
