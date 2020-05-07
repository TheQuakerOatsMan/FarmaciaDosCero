<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detvmed
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
        Me.prevtamed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cantvm = New System.Windows.Forms.ComboBox()
        Me.nommed = New System.Windows.Forms.TextBox()
        Me.cvemed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnre10 = New System.Windows.Forms.Button()
        Me.aniadirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgrec = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'prevtamed
        '
        Me.prevtamed.Enabled = False
        Me.prevtamed.Location = New System.Drawing.Point(219, 124)
        Me.prevtamed.Name = "prevtamed"
        Me.prevtamed.Size = New System.Drawing.Size(73, 20)
        Me.prevtamed.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "PRECIOVTAMED:"
        '
        'cantvm
        '
        Me.cantvm.FormattingEnabled = True
        Me.cantvm.Location = New System.Drawing.Point(119, 151)
        Me.cantvm.Name = "cantvm"
        Me.cantvm.Size = New System.Drawing.Size(59, 21)
        Me.cantvm.TabIndex = 19
        '
        'nommed
        '
        Me.nommed.Enabled = False
        Me.nommed.Location = New System.Drawing.Point(150, 88)
        Me.nommed.Name = "nommed"
        Me.nommed.Size = New System.Drawing.Size(142, 20)
        Me.nommed.TabIndex = 18
        '
        'cvemed
        '
        Me.cvemed.Enabled = False
        Me.cvemed.Location = New System.Drawing.Point(245, 57)
        Me.cvemed.Name = "cvemed"
        Me.cvemed.Size = New System.Drawing.Size(47, 20)
        Me.cvemed.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "NOMBREMED:"
        '
        'btnre10
        '
        Me.btnre10.Location = New System.Drawing.Point(186, 234)
        Me.btnre10.Name = "btnre10"
        Me.btnre10.Size = New System.Drawing.Size(75, 23)
        Me.btnre10.TabIndex = 15
        Me.btnre10.Text = "REGRESAR"
        Me.btnre10.UseVisualStyleBackColor = True
        '
        'aniadirm
        '
        Me.aniadirm.Location = New System.Drawing.Point(24, 234)
        Me.aniadirm.Name = "aniadirm"
        Me.aniadirm.Size = New System.Drawing.Size(142, 23)
        Me.aniadirm.TabIndex = 14
        Me.aniadirm.Text = "AÑADIR MEDICAMENTO"
        Me.aniadirm.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CANTIDAD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "CVEPROD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "AÑADIR MEDICAMENTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgrec
        '
        Me.imgrec.Location = New System.Drawing.Point(219, 188)
        Me.imgrec.MaxLength = 100
        Me.imgrec.Name = "imgrec"
        Me.imgrec.Size = New System.Drawing.Size(347, 20)
        Me.imgrec.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "IMG RECT (INGESA LA RECETA):"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(572, 186)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 24
        Me.btnadd.Text = "AGREGAR"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'detvmed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 294)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.imgrec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prevtamed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cantvm)
        Me.Controls.Add(Me.nommed)
        Me.Controls.Add(Me.cvemed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnre10)
        Me.Controls.Add(Me.aniadirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "detvmed"
        Me.Text = "detvmed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prevtamed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cantvm As ComboBox
    Friend WithEvents nommed As TextBox
    Friend WithEvents cvemed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnre10 As Button
    Friend WithEvents aniadirm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents imgrec As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnadd As Button
End Class
