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
        Me.nuevatarifa = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'nuevatarifa
        '
        Me.nuevatarifa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nuevatarifa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.nuevatarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nuevatarifa.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nuevatarifa.Location = New System.Drawing.Point(130, 12)
        Me.nuevatarifa.Name = "nuevatarifa"
        Me.nuevatarifa.Size = New System.Drawing.Size(110, 26)
        Me.nuevatarifa.TabIndex = 0
        Me.nuevatarifa.Text = "Nueva tarifa"
        Me.nuevatarifa.UseVisualStyleBackColor = False
        '
        'employee_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(529, 531)
        Me.Controls.Add(Me.new_contract_btn)
        Me.Controls.Add(Me.add_consume_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.find_client_txt)
        Me.Controls.Add(Me.nuevatarifa)
        Me.Controls.Add(Me.add_client_btn)
        Me.Controls.Add(Me.delete_client_btn)
        Me.Controls.Add(Me.close_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "employee_form"
        Me.Text = "CFE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents nuevatarifa As Button
End Class
