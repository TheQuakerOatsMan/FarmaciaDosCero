<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detcompro
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
        Me.gananciaProd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.loteprod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fechacadProd = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.precomprod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomprod = New System.Windows.Forms.TextBox()
        Me.cveprod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnre10 = New System.Windows.Forms.Button()
        Me.aniadirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cantP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'gananciaProd
        '
        Me.gananciaProd.Location = New System.Drawing.Point(126, 169)
        Me.gananciaProd.MaxLength = 3
        Me.gananciaProd.Name = "gananciaProd"
        Me.gananciaProd.Size = New System.Drawing.Size(142, 20)
        Me.gananciaProd.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "GANANCIA:"
        '
        'loteprod
        '
        Me.loteprod.Location = New System.Drawing.Point(126, 237)
        Me.loteprod.Name = "loteprod"
        Me.loteprod.Size = New System.Drawing.Size(142, 20)
        Me.loteprod.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "LOTE:"
        '
        'fechacadProd
        '
        Me.fechacadProd.Location = New System.Drawing.Point(126, 270)
        Me.fechacadProd.Margin = New System.Windows.Forms.Padding(2)
        Me.fechacadProd.Name = "fechacadProd"
        Me.fechacadProd.Size = New System.Drawing.Size(142, 20)
        Me.fechacadProd.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "FECHACAD:"
        '
        'precomprod
        '
        Me.precomprod.Location = New System.Drawing.Point(126, 137)
        Me.precomprod.MaxLength = 10
        Me.precomprod.Name = "precomprod"
        Me.precomprod.Size = New System.Drawing.Size(142, 20)
        Me.precomprod.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "PRECIO DE COMPRA:"
        '
        'nomprod
        '
        Me.nomprod.Enabled = False
        Me.nomprod.Location = New System.Drawing.Point(126, 105)
        Me.nomprod.Name = "nomprod"
        Me.nomprod.Size = New System.Drawing.Size(142, 20)
        Me.nomprod.TabIndex = 61
        '
        'cveprod
        '
        Me.cveprod.Enabled = False
        Me.cveprod.Location = New System.Drawing.Point(126, 70)
        Me.cveprod.Name = "cveprod"
        Me.cveprod.Size = New System.Drawing.Size(142, 20)
        Me.cveprod.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "NOMBRE DE PROD:"
        '
        'btnre10
        '
        Me.btnre10.Location = New System.Drawing.Point(141, 303)
        Me.btnre10.Name = "btnre10"
        Me.btnre10.Size = New System.Drawing.Size(75, 23)
        Me.btnre10.TabIndex = 58
        Me.btnre10.Text = "REGRESAR"
        Me.btnre10.UseVisualStyleBackColor = True
        '
        'aniadirm
        '
        Me.aniadirm.Location = New System.Drawing.Point(61, 303)
        Me.aniadirm.Name = "aniadirm"
        Me.aniadirm.Size = New System.Drawing.Size(75, 23)
        Me.aniadirm.TabIndex = 57
        Me.aniadirm.Text = "AÑADIR"
        Me.aniadirm.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "CANTIDAD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "CVEPROD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "AÑADIR PRODUCTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cantP
        '
        Me.cantP.Location = New System.Drawing.Point(126, 201)
        Me.cantP.MaxLength = 5
        Me.cantP.Name = "cantP"
        Me.cantP.Size = New System.Drawing.Size(142, 20)
        Me.cantP.TabIndex = 70
        '
        'detcompro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 360)
        Me.Controls.Add(Me.cantP)
        Me.Controls.Add(Me.gananciaProd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.loteprod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fechacadProd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.precomprod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nomprod)
        Me.Controls.Add(Me.cveprod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnre10)
        Me.Controls.Add(Me.aniadirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "detcompro"
        Me.Text = "detcompro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gananciaProd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents loteprod As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents fechacadProd As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents precomprod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nomprod As TextBox
    Friend WithEvents cveprod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnre10 As Button
    Friend WithEvents aniadirm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cantP As TextBox
End Class
