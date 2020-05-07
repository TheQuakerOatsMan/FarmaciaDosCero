<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.binicio = New System.Windows.Forms.Button()
        Me.bsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MetroDF", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(188, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Farmacia San Antonio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'binicio
        '
        Me.binicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.binicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.binicio.ForeColor = System.Drawing.Color.DarkCyan
        Me.binicio.Location = New System.Drawing.Point(23, 74)
        Me.binicio.Name = "binicio"
        Me.binicio.Size = New System.Drawing.Size(126, 32)
        Me.binicio.TabIndex = 1
        Me.binicio.Text = "INICIO"
        Me.binicio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.binicio.UseVisualStyleBackColor = False
        '
        'bsalir
        '
        Me.bsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsalir.ForeColor = System.Drawing.Color.DarkCyan
        Me.bsalir.Location = New System.Drawing.Point(23, 124)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(126, 32)
        Me.bsalir.TabIndex = 2
        Me.bsalir.Text = "SALIR"
        Me.bsalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bsalir.UseVisualStyleBackColor = False
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.farma
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bsalir)
        Me.Controls.Add(Me.binicio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "inicio"
        Me.Text = "inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents binicio As Button
    Friend WithEvents bsalir As Button
End Class
