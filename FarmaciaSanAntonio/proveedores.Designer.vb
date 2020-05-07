<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores
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
        Me.bsalir = New System.Windows.Forms.Button()
        Me.bconsult = New System.Windows.Forms.Button()
        Me.binserta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ESTADO = New System.Windows.Forms.ComboBox()
        Me.CVEPROV = New System.Windows.Forms.ComboBox()
        Me.NOMPROV = New System.Windows.Forms.TextBox()
        Me.DIRPROV = New System.Windows.Forms.TextBox()
        Me.EMPRESA = New System.Windows.Forms.TextBox()
        Me.DIREMPSA = New System.Windows.Forms.TextBox()
        Me.TELPROV = New System.Windows.Forms.TextBox()
        Me.CODIGOP = New System.Windows.Forms.TextBox()
        Me.CORREOPROV = New System.Windows.Forms.TextBox()
        Me.LOCALIDAD = New System.Windows.Forms.TextBox()
        Me.ACTIVO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bsalir
        '
        Me.bsalir.BackColor = System.Drawing.Color.Teal
        Me.bsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsalir.ForeColor = System.Drawing.Color.White
        Me.bsalir.Location = New System.Drawing.Point(602, 291)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(126, 32)
        Me.bsalir.TabIndex = 3
        Me.bsalir.Text = "SALIR"
        Me.bsalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bsalir.UseVisualStyleBackColor = False
        '
        'bconsult
        '
        Me.bconsult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bconsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bconsult.ForeColor = System.Drawing.Color.DarkCyan
        Me.bconsult.Location = New System.Drawing.Point(602, 230)
        Me.bconsult.Name = "bconsult"
        Me.bconsult.Size = New System.Drawing.Size(126, 32)
        Me.bconsult.TabIndex = 4
        Me.bconsult.Text = "CONSULTAR"
        Me.bconsult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bconsult.UseVisualStyleBackColor = False
        '
        'binserta
        '
        Me.binserta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.binserta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.binserta.ForeColor = System.Drawing.Color.DarkCyan
        Me.binserta.Location = New System.Drawing.Point(602, 167)
        Me.binserta.Name = "binserta"
        Me.binserta.Size = New System.Drawing.Size(126, 32)
        Me.binserta.TabIndex = 5
        Me.binserta.Text = "INSERTAR"
        Me.binserta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.binserta.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CVEPROV:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NOMPROV:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "EMPRESA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DIRPROV:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DIREMPSA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TELPROV:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ESTADO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "CODIGOP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 331)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "LOCALIDAD:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "CORREOPROV:"
        '
        'ESTADO
        '
        Me.ESTADO.FormattingEnabled = True
        Me.ESTADO.Items.AddRange(New Object() {"AGUASCALIENTES", "BAJA CALIFORNIA", "BAJA CALIFORNIA SUR", "CAMPECHE", "CHIAPAS", "CHIHUAHUA", "COAHUILA", "COLIMA", "DURANGO", "ESTADO DE MÉXICO", "GUANAJUATO", "GUERRERO", "HIDALGO", "JALISCO", "MICHOACÁN DE OCAMPO", "MORELOS", "NAYARIT", "NUEVO LEÓN", "OAXACA", "PUEBLA", "QUERÉTARO", "QUINTANA ROO", "SAN LUIS POTOSÍ", "SINALOA", "SONORA", "TABASCO", "TAMAULIPAS", "TLAXCALA", "VERACRUZ", "YUCATÁN", "ZACATECAS"})
        Me.ESTADO.Location = New System.Drawing.Point(169, 242)
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.Size = New System.Drawing.Size(156, 21)
        Me.ESTADO.TabIndex = 16
        Me.ESTADO.Text = "SELECCIONA UN ESTADO"
        '
        'CVEPROV
        '
        Me.CVEPROV.FormattingEnabled = True
        Me.CVEPROV.Location = New System.Drawing.Point(169, 19)
        Me.CVEPROV.Name = "CVEPROV"
        Me.CVEPROV.Size = New System.Drawing.Size(121, 21)
        Me.CVEPROV.TabIndex = 17
        '
        'NOMPROV
        '
        Me.NOMPROV.Location = New System.Drawing.Point(169, 51)
        Me.NOMPROV.MaxLength = 49
        Me.NOMPROV.Name = "NOMPROV"
        Me.NOMPROV.Size = New System.Drawing.Size(300, 20)
        Me.NOMPROV.TabIndex = 18
        '
        'DIRPROV
        '
        Me.DIRPROV.Location = New System.Drawing.Point(169, 119)
        Me.DIRPROV.MaxLength = 49
        Me.DIRPROV.Name = "DIRPROV"
        Me.DIRPROV.Size = New System.Drawing.Size(300, 20)
        Me.DIRPROV.TabIndex = 19
        '
        'EMPRESA
        '
        Me.EMPRESA.Location = New System.Drawing.Point(169, 83)
        Me.EMPRESA.MaxLength = 29
        Me.EMPRESA.Name = "EMPRESA"
        Me.EMPRESA.Size = New System.Drawing.Size(300, 20)
        Me.EMPRESA.TabIndex = 20
        '
        'DIREMPSA
        '
        Me.DIREMPSA.Location = New System.Drawing.Point(169, 159)
        Me.DIREMPSA.MaxLength = 49
        Me.DIREMPSA.Name = "DIREMPSA"
        Me.DIREMPSA.Size = New System.Drawing.Size(300, 20)
        Me.DIREMPSA.TabIndex = 21
        '
        'TELPROV
        '
        Me.TELPROV.Location = New System.Drawing.Point(169, 196)
        Me.TELPROV.MaxLength = 14
        Me.TELPROV.Name = "TELPROV"
        Me.TELPROV.Size = New System.Drawing.Size(300, 20)
        Me.TELPROV.TabIndex = 22
        '
        'CODIGOP
        '
        Me.CODIGOP.Location = New System.Drawing.Point(169, 293)
        Me.CODIGOP.MaxLength = 7
        Me.CODIGOP.Name = "CODIGOP"
        Me.CODIGOP.Size = New System.Drawing.Size(300, 20)
        Me.CODIGOP.TabIndex = 23
        '
        'CORREOPROV
        '
        Me.CORREOPROV.Location = New System.Drawing.Point(169, 369)
        Me.CORREOPROV.MaxLength = 29
        Me.CORREOPROV.Name = "CORREOPROV"
        Me.CORREOPROV.Size = New System.Drawing.Size(300, 20)
        Me.CORREOPROV.TabIndex = 24
        '
        'LOCALIDAD
        '
        Me.LOCALIDAD.Location = New System.Drawing.Point(169, 331)
        Me.LOCALIDAD.MaxLength = 29
        Me.LOCALIDAD.Name = "LOCALIDAD"
        Me.LOCALIDAD.Size = New System.Drawing.Size(300, 20)
        Me.LOCALIDAD.TabIndex = 25
        '
        'ACTIVO
        '
        Me.ACTIVO.Location = New System.Drawing.Point(169, 418)
        Me.ACTIVO.MaxLength = 29
        Me.ACTIVO.Name = "ACTIVO"
        Me.ACTIVO.Size = New System.Drawing.Size(300, 20)
        Me.ACTIVO.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 418)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "STATUS (ACTIVO):"
        '
        'proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.para
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ACTIVO)
        Me.Controls.Add(Me.LOCALIDAD)
        Me.Controls.Add(Me.CORREOPROV)
        Me.Controls.Add(Me.CODIGOP)
        Me.Controls.Add(Me.TELPROV)
        Me.Controls.Add(Me.DIREMPSA)
        Me.Controls.Add(Me.EMPRESA)
        Me.Controls.Add(Me.DIRPROV)
        Me.Controls.Add(Me.NOMPROV)
        Me.Controls.Add(Me.CVEPROV)
        Me.Controls.Add(Me.ESTADO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.binserta)
        Me.Controls.Add(Me.bconsult)
        Me.Controls.Add(Me.bsalir)
        Me.Name = "proveedores"
        Me.Text = "proveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bsalir As Button
    Friend WithEvents bconsult As Button
    Friend WithEvents binserta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ESTADO As ComboBox
    Friend WithEvents CVEPROV As ComboBox
    Friend WithEvents NOMPROV As TextBox
    Friend WithEvents DIRPROV As TextBox
    Friend WithEvents EMPRESA As TextBox
    Friend WithEvents DIREMPSA As TextBox
    Friend WithEvents TELPROV As TextBox
    Friend WithEvents CODIGOP As TextBox
    Friend WithEvents CORREOPROV As TextBox
    Friend WithEvents LOCALIDAD As TextBox
    Friend WithEvents ACTIVO As TextBox
    Friend WithEvents Label11 As Label
End Class
