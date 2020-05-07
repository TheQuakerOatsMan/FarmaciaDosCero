<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modEmpleados
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
        Me.PanelEmp = New System.Windows.Forms.Panel()
        Me.ACTIVO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PUESTO = New System.Windows.Forms.ComboBox()
        Me.TELEMP = New System.Windows.Forms.TextBox()
        Me.CORREOEMP = New System.Windows.Forms.TextBox()
        Me.DIREMP = New System.Windows.Forms.TextBox()
        Me.NOMEMP = New System.Windows.Forms.TextBox()
        Me.EDADEMP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CVEMP = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.modE = New System.Windows.Forms.Button()
        Me.modN = New System.Windows.Forms.Button()
        Me.modEGral = New System.Windows.Forms.Button()
        Me.modP = New System.Windows.Forms.Button()
        Me.btnApli = New System.Windows.Forms.Button()
        Me.salirME = New System.Windows.Forms.Button()
        Me.btnre2 = New System.Windows.Forms.Button()
        Me.btncan = New System.Windows.Forms.Button()
        Me.moT = New System.Windows.Forms.Button()
        Me.btnBB = New System.Windows.Forms.Button()
        Me.DEPTO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEmp
        '
        Me.PanelEmp.BackColor = System.Drawing.Color.Lavender
        Me.PanelEmp.Controls.Add(Me.DEPTO)
        Me.PanelEmp.Controls.Add(Me.Label10)
        Me.PanelEmp.Controls.Add(Me.ACTIVO)
        Me.PanelEmp.Controls.Add(Me.Label9)
        Me.PanelEmp.Controls.Add(Me.Label8)
        Me.PanelEmp.Controls.Add(Me.PUESTO)
        Me.PanelEmp.Controls.Add(Me.TELEMP)
        Me.PanelEmp.Controls.Add(Me.CORREOEMP)
        Me.PanelEmp.Controls.Add(Me.DIREMP)
        Me.PanelEmp.Controls.Add(Me.NOMEMP)
        Me.PanelEmp.Controls.Add(Me.EDADEMP)
        Me.PanelEmp.Controls.Add(Me.Label7)
        Me.PanelEmp.Controls.Add(Me.Label6)
        Me.PanelEmp.Controls.Add(Me.Label5)
        Me.PanelEmp.Controls.Add(Me.Label4)
        Me.PanelEmp.Controls.Add(Me.Label3)
        Me.PanelEmp.Controls.Add(Me.Label2)
        Me.PanelEmp.Controls.Add(Me.CVEMP)
        Me.PanelEmp.Controls.Add(Me.Label1)
        Me.PanelEmp.Location = New System.Drawing.Point(12, 24)
        Me.PanelEmp.Name = "PanelEmp"
        Me.PanelEmp.Size = New System.Drawing.Size(462, 314)
        Me.PanelEmp.TabIndex = 52
        '
        'ACTIVO
        '
        Me.ACTIVO.Enabled = False
        Me.ACTIVO.Location = New System.Drawing.Point(142, 289)
        Me.ACTIVO.MaxLength = 15
        Me.ACTIVO.Name = "ACTIVO"
        Me.ACTIVO.Size = New System.Drawing.Size(121, 20)
        Me.ACTIVO.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "ACTIVO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MetroDF", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 17)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "MOD EMPLEADOS"
        '
        'PUESTO
        '
        Me.PUESTO.Enabled = False
        Me.PUESTO.FormattingEnabled = True
        Me.PUESTO.Items.AddRange(New Object() {"CAJERO(A)", "MOSTRADOR", "ADMINISTRADOR(A)", "ENC. DE TIENDA", "CONTADOR", "AUX. CONTABLE"})
        Me.PUESTO.Location = New System.Drawing.Point(142, 235)
        Me.PUESTO.Name = "PUESTO"
        Me.PUESTO.Size = New System.Drawing.Size(121, 21)
        Me.PUESTO.TabIndex = 45
        '
        'TELEMP
        '
        Me.TELEMP.Enabled = False
        Me.TELEMP.Location = New System.Drawing.Point(142, 176)
        Me.TELEMP.MaxLength = 16
        Me.TELEMP.Name = "TELEMP"
        Me.TELEMP.Size = New System.Drawing.Size(162, 20)
        Me.TELEMP.TabIndex = 44
        '
        'CORREOEMP
        '
        Me.CORREOEMP.Enabled = False
        Me.CORREOEMP.Location = New System.Drawing.Point(142, 150)
        Me.CORREOEMP.MaxLength = 30
        Me.CORREOEMP.Name = "CORREOEMP"
        Me.CORREOEMP.Size = New System.Drawing.Size(312, 20)
        Me.CORREOEMP.TabIndex = 43
        '
        'DIREMP
        '
        Me.DIREMP.Enabled = False
        Me.DIREMP.Location = New System.Drawing.Point(142, 117)
        Me.DIREMP.MaxLength = 20
        Me.DIREMP.Name = "DIREMP"
        Me.DIREMP.Size = New System.Drawing.Size(312, 20)
        Me.DIREMP.TabIndex = 42
        '
        'NOMEMP
        '
        Me.NOMEMP.Enabled = False
        Me.NOMEMP.Location = New System.Drawing.Point(142, 91)
        Me.NOMEMP.MaxLength = 50
        Me.NOMEMP.Name = "NOMEMP"
        Me.NOMEMP.Size = New System.Drawing.Size(312, 20)
        Me.NOMEMP.TabIndex = 41
        '
        'EDADEMP
        '
        Me.EDADEMP.Enabled = False
        Me.EDADEMP.FormattingEnabled = True
        Me.EDADEMP.Location = New System.Drawing.Point(142, 202)
        Me.EDADEMP.Name = "EDADEMP"
        Me.EDADEMP.Size = New System.Drawing.Size(121, 21)
        Me.EDADEMP.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "PUESTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "EDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "TELEFONO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "CORREO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "DIRECCION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "NOMBRE EMPLEADO"
        '
        'CVEMP
        '
        Me.CVEMP.Enabled = False
        Me.CVEMP.FormattingEnabled = True
        Me.CVEMP.Location = New System.Drawing.Point(142, 59)
        Me.CVEMP.Name = "CVEMP"
        Me.CVEMP.Size = New System.Drawing.Size(121, 21)
        Me.CVEMP.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "CVEMP"
        '
        'modE
        '
        Me.modE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.modE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modE.ForeColor = System.Drawing.Color.DarkCyan
        Me.modE.Location = New System.Drawing.Point(542, 152)
        Me.modE.Name = "modE"
        Me.modE.Size = New System.Drawing.Size(192, 36)
        Me.modE.TabIndex = 72
        Me.modE.Text = "MOD EDAD"
        Me.modE.UseVisualStyleBackColor = False
        '
        'modN
        '
        Me.modN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.modN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modN.ForeColor = System.Drawing.Color.DarkCyan
        Me.modN.Location = New System.Drawing.Point(542, 68)
        Me.modN.Name = "modN"
        Me.modN.Size = New System.Drawing.Size(192, 36)
        Me.modN.TabIndex = 71
        Me.modN.Text = "MOD NOMBRE"
        Me.modN.UseVisualStyleBackColor = False
        '
        'modEGral
        '
        Me.modEGral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.modEGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modEGral.ForeColor = System.Drawing.Color.DarkCyan
        Me.modEGral.Location = New System.Drawing.Point(542, 232)
        Me.modEGral.Name = "modEGral"
        Me.modEGral.Size = New System.Drawing.Size(192, 36)
        Me.modEGral.TabIndex = 70
        Me.modEGral.Text = "MOD GRAL"
        Me.modEGral.UseVisualStyleBackColor = False
        '
        'modP
        '
        Me.modP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.modP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modP.ForeColor = System.Drawing.Color.DarkCyan
        Me.modP.Location = New System.Drawing.Point(542, 190)
        Me.modP.Name = "modP"
        Me.modP.Size = New System.Drawing.Size(192, 36)
        Me.modP.TabIndex = 69
        Me.modP.Text = "MOD PUESTO"
        Me.modP.UseVisualStyleBackColor = False
        '
        'btnApli
        '
        Me.btnApli.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApli.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApli.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnApli.Location = New System.Drawing.Point(542, 320)
        Me.btnApli.Name = "btnApli"
        Me.btnApli.Size = New System.Drawing.Size(192, 36)
        Me.btnApli.TabIndex = 73
        Me.btnApli.Text = "APLICAR CAMBIOS"
        Me.btnApli.UseVisualStyleBackColor = False
        '
        'salirME
        '
        Me.salirME.BackColor = System.Drawing.Color.DarkCyan
        Me.salirME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirME.ForeColor = System.Drawing.Color.White
        Me.salirME.Location = New System.Drawing.Point(658, 388)
        Me.salirME.Name = "salirME"
        Me.salirME.Size = New System.Drawing.Size(119, 36)
        Me.salirME.TabIndex = 74
        Me.salirME.Text = "SALIR"
        Me.salirME.UseVisualStyleBackColor = False
        '
        'btnre2
        '
        Me.btnre2.BackColor = System.Drawing.Color.DarkCyan
        Me.btnre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre2.ForeColor = System.Drawing.Color.White
        Me.btnre2.Location = New System.Drawing.Point(469, 388)
        Me.btnre2.Name = "btnre2"
        Me.btnre2.Size = New System.Drawing.Size(160, 36)
        Me.btnre2.TabIndex = 75
        Me.btnre2.Text = "REGRESAR"
        Me.btnre2.UseVisualStyleBackColor = False
        Me.btnre2.Visible = False
        '
        'btncan
        '
        Me.btncan.BackColor = System.Drawing.Color.DarkCyan
        Me.btncan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncan.ForeColor = System.Drawing.Color.White
        Me.btncan.Location = New System.Drawing.Point(542, 274)
        Me.btncan.Name = "btncan"
        Me.btncan.Size = New System.Drawing.Size(192, 36)
        Me.btncan.TabIndex = 76
        Me.btncan.Text = "Cancelar"
        Me.btncan.UseVisualStyleBackColor = False
        '
        'moT
        '
        Me.moT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.moT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moT.ForeColor = System.Drawing.Color.DarkCyan
        Me.moT.Location = New System.Drawing.Point(542, 110)
        Me.moT.Name = "moT"
        Me.moT.Size = New System.Drawing.Size(192, 36)
        Me.moT.TabIndex = 77
        Me.moT.Text = "MOD TEL"
        Me.moT.UseVisualStyleBackColor = False
        '
        'btnBB
        '
        Me.btnBB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBB.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnBB.Location = New System.Drawing.Point(12, 366)
        Me.btnBB.Name = "btnBB"
        Me.btnBB.Size = New System.Drawing.Size(192, 36)
        Me.btnBB.TabIndex = 78
        Me.btnBB.Text = "BUSQUEDA"
        Me.btnBB.UseVisualStyleBackColor = False
        Me.btnBB.Visible = False
        '
        'DEPTO
        '
        Me.DEPTO.Enabled = False
        Me.DEPTO.FormattingEnabled = True
        Me.DEPTO.Items.AddRange(New Object() {"COMPRAS", "VENTAS", "GERENCIA"})
        Me.DEPTO.Location = New System.Drawing.Point(142, 261)
        Me.DEPTO.Name = "DEPTO"
        Me.DEPTO.Size = New System.Drawing.Size(121, 21)
        Me.DEPTO.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "DEPTO"
        '
        'modEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBB)
        Me.Controls.Add(Me.moT)
        Me.Controls.Add(Me.btncan)
        Me.Controls.Add(Me.btnre2)
        Me.Controls.Add(Me.salirME)
        Me.Controls.Add(Me.btnApli)
        Me.Controls.Add(Me.modE)
        Me.Controls.Add(Me.modN)
        Me.Controls.Add(Me.modEGral)
        Me.Controls.Add(Me.modP)
        Me.Controls.Add(Me.PanelEmp)
        Me.Name = "modEmpleados"
        Me.Text = "modEmpleados"
        Me.PanelEmp.ResumeLayout(False)
        Me.PanelEmp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEmp As Panel
    Friend WithEvents ACTIVO As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PUESTO As ComboBox
    Friend WithEvents TELEMP As TextBox
    Friend WithEvents CORREOEMP As TextBox
    Friend WithEvents DIREMP As TextBox
    Friend WithEvents NOMEMP As TextBox
    Friend WithEvents EDADEMP As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CVEMP As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents modE As Button
    Friend WithEvents modN As Button
    Friend WithEvents modEGral As Button
    Friend WithEvents modP As Button
    Friend WithEvents btnApli As Button
    Friend WithEvents salirME As Button
    Friend WithEvents btnre2 As Button
    Friend WithEvents btncan As Button
    Friend WithEvents moT As Button
    Friend WithEvents btnBB As Button
    Friend WithEvents DEPTO As ComboBox
    Friend WithEvents Label10 As Label
End Class
