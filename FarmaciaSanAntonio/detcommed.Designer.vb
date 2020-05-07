<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detcommed
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
        Me.tipoMed = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gananciaMed = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lotemed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fechacadMed = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.precommed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nommed = New System.Windows.Forms.TextBox()
        Me.cvemed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnre10 = New System.Windows.Forms.Button()
        Me.aniadirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cantidadm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tipoMed
        '
        Me.tipoMed.FormattingEnabled = True
        Me.tipoMed.Items.AddRange(New Object() {"1", "2", "3"})
        Me.tipoMed.Location = New System.Drawing.Point(132, 292)
        Me.tipoMed.Name = "tipoMed"
        Me.tipoMed.Size = New System.Drawing.Size(142, 21)
        Me.tipoMed.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "TIPO MED:"
        '
        'gananciaMed
        '
        Me.gananciaMed.Location = New System.Drawing.Point(132, 159)
        Me.gananciaMed.Name = "gananciaMed"
        Me.gananciaMed.Size = New System.Drawing.Size(142, 20)
        Me.gananciaMed.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "GANANCIA:"
        '
        'lotemed
        '
        Me.lotemed.Location = New System.Drawing.Point(132, 225)
        Me.lotemed.Name = "lotemed"
        Me.lotemed.Size = New System.Drawing.Size(142, 20)
        Me.lotemed.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "LOTE:"
        '
        'fechacadMed
        '
        Me.fechacadMed.Location = New System.Drawing.Point(132, 258)
        Me.fechacadMed.Margin = New System.Windows.Forms.Padding(2)
        Me.fechacadMed.Name = "fechacadMed"
        Me.fechacadMed.Size = New System.Drawing.Size(142, 20)
        Me.fechacadMed.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "FECHACAD:"
        '
        'precommed
        '
        Me.precommed.Location = New System.Drawing.Point(132, 127)
        Me.precommed.Name = "precommed"
        Me.precommed.Size = New System.Drawing.Size(142, 20)
        Me.precommed.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "PRECIO DE COMPRA:"
        '
        'nommed
        '
        Me.nommed.Enabled = False
        Me.nommed.Location = New System.Drawing.Point(132, 95)
        Me.nommed.Name = "nommed"
        Me.nommed.Size = New System.Drawing.Size(142, 20)
        Me.nommed.TabIndex = 79
        '
        'cvemed
        '
        Me.cvemed.Enabled = False
        Me.cvemed.Location = New System.Drawing.Point(132, 60)
        Me.cvemed.Name = "cvemed"
        Me.cvemed.Size = New System.Drawing.Size(142, 20)
        Me.cvemed.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "NOMBRE DE MED:"
        '
        'btnre10
        '
        Me.btnre10.Location = New System.Drawing.Point(146, 328)
        Me.btnre10.Name = "btnre10"
        Me.btnre10.Size = New System.Drawing.Size(75, 23)
        Me.btnre10.TabIndex = 76
        Me.btnre10.Text = "REGRESAR"
        Me.btnre10.UseVisualStyleBackColor = True
        '
        'aniadirm
        '
        Me.aniadirm.Location = New System.Drawing.Point(66, 328)
        Me.aniadirm.Name = "aniadirm"
        Me.aniadirm.Size = New System.Drawing.Size(75, 23)
        Me.aniadirm.TabIndex = 75
        Me.aniadirm.Text = "AÑADIR"
        Me.aniadirm.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "CANTIDAD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "CVEMED:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "AÑADIR MEDICAMENTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cantidadm
        '
        Me.cantidadm.Location = New System.Drawing.Point(132, 191)
        Me.cantidadm.MaxLength = 5
        Me.cantidadm.Name = "cantidadm"
        Me.cantidadm.Size = New System.Drawing.Size(142, 20)
        Me.cantidadm.TabIndex = 91
        '
        'detcommed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 379)
        Me.Controls.Add(Me.cantidadm)
        Me.Controls.Add(Me.tipoMed)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gananciaMed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lotemed)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fechacadMed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.precommed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nommed)
        Me.Controls.Add(Me.cvemed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnre10)
        Me.Controls.Add(Me.aniadirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "detcommed"
        Me.Text = "detcommed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tipoMed As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gananciaMed As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lotemed As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents fechacadMed As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents precommed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nommed As TextBox
    Friend WithEvents cvemed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnre10 As Button
    Friend WithEvents aniadirm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cantidadm As TextBox
End Class
