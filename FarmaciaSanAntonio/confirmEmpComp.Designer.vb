<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmEmpComp
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
        Me.procombox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIng = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'procombox
        '
        Me.procombox.FormattingEnabled = True
        Me.procombox.Location = New System.Drawing.Point(83, 72)
        Me.procombox.Margin = New System.Windows.Forms.Padding(2)
        Me.procombox.Name = "procombox"
        Me.procombox.Size = New System.Drawing.Size(125, 21)
        Me.procombox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CONFRIMACION DE EMPLEADO"
        '
        'btnIng
        '
        Me.btnIng.Location = New System.Drawing.Point(12, 113)
        Me.btnIng.Name = "btnIng"
        Me.btnIng.Size = New System.Drawing.Size(87, 27)
        Me.btnIng.TabIndex = 8
        Me.btnIng.Text = "INGRESAR"
        Me.btnIng.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "CVEPROV:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(116, 113)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'confirmEmpComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 173)
        Me.Controls.Add(Me.procombox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnIng)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "confirmEmpComp"
        Me.Text = "confirmEmpComp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents procombox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIng As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelar As Button
End Class
