<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(client_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tarif_lbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.client_name_lbl = New System.Windows.Forms.Label()
        Me.employee_name_lbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.no_med_lbl = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.no_service_lbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido joherz"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 80)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "JOSÉ ANTONIO HERNANDEZ ORTEGA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(418, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "11/04/2021"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "jose@gmail.es"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(341, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "HOJA12051992HNLDR"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 42)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Contratos vigentes"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(486, 191)
        Me.DataGridView1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Recibos"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(79, 438)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 29)
        Me.ComboBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(394, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cerrar sesión"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(95, 506)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(286, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Información del contrato"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.tarif_lbl)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.client_name_lbl)
        Me.Panel1.Controls.Add(Me.employee_name_lbl)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.no_med_lbl)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.no_service_lbl)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(12, 541)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 199)
        Me.Panel1.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(402, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 17)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "12/24/2020"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(431, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "66634"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(343, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 17)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Nuevo León"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(282, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 17)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Apodaca"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(118, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(144, 17)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Av. independencia  #133"
        '
        'tarif_lbl
        '
        Me.tarif_lbl.AutoSize = True
        Me.tarif_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tarif_lbl.Location = New System.Drawing.Point(118, 34)
        Me.tarif_lbl.Name = "tarif_lbl"
        Me.tarif_lbl.Size = New System.Drawing.Size(66, 17)
        Me.tarif_lbl.TabIndex = 18
        Me.tarif_lbl.Text = "Domestica"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(343, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "HOJA12051992HNLDR"
        '
        'client_name_lbl
        '
        Me.client_name_lbl.AutoSize = True
        Me.client_name_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.client_name_lbl.Location = New System.Drawing.Point(86, 62)
        Me.client_name_lbl.Name = "client_name_lbl"
        Me.client_name_lbl.Size = New System.Drawing.Size(120, 17)
        Me.client_name_lbl.TabIndex = 19
        Me.client_name_lbl.Text = "Juan ortega sanchez"
        '
        'employee_name_lbl
        '
        Me.employee_name_lbl.AutoSize = True
        Me.employee_name_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.employee_name_lbl.Location = New System.Drawing.Point(307, 171)
        Me.employee_name_lbl.Name = "employee_name_lbl"
        Me.employee_name_lbl.Size = New System.Drawing.Size(167, 17)
        Me.employee_name_lbl.TabIndex = 20
        Me.employee_name_lbl.Text = "Jose antonio hernedez perez"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(118, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 21)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Tarifa"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(17, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 21)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(183, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Elaborado por"
        '
        'no_med_lbl
        '
        Me.no_med_lbl.AutoSize = True
        Me.no_med_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.no_med_lbl.Location = New System.Drawing.Point(31, 111)
        Me.no_med_lbl.Name = "no_med_lbl"
        Me.no_med_lbl.Size = New System.Drawing.Size(61, 17)
        Me.no_med_lbl.TabIndex = 14
        Me.no_med_lbl.Text = "78945213"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(219, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 21)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Dirección"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(12, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 21)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "No medidor"
        '
        'no_service_lbl
        '
        Me.no_service_lbl.AutoSize = True
        Me.no_service_lbl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.no_service_lbl.Location = New System.Drawing.Point(13, 34)
        Me.no_service_lbl.Name = "no_service_lbl"
        Me.no_service_lbl.Size = New System.Drawing.Size(90, 17)
        Me.no_service_lbl.TabIndex = 12
        Me.no_service_lbl.Text = "342342458123"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(11, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 21)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "No servicio"
        '
        'client_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(510, 752)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "client_form"
        Me.Text = "CFE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents no_service_lbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents no_med_lbl As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tarif_lbl As Label
    Friend WithEvents client_name_lbl As Label
    Friend WithEvents employee_name_lbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
