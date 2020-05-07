<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProxCad
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NomProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salircapt = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomProd, Me.Lote, Me.FechaCad})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1176, 534)
        Me.DataGridView1.TabIndex = 0
        '
        'NomProd
        '
        Me.NomProd.Frozen = True
        Me.NomProd.HeaderText = "Nombre"
        Me.NomProd.MinimumWidth = 8
        Me.NomProd.Name = "NomProd"
        Me.NomProd.ReadOnly = True
        Me.NomProd.Width = 101
        '
        'Lote
        '
        Me.Lote.Frozen = True
        Me.Lote.HeaderText = "Lote"
        Me.Lote.MinimumWidth = 8
        Me.Lote.Name = "Lote"
        Me.Lote.ReadOnly = True
        Me.Lote.Width = 77
        '
        'FechaCad
        '
        Me.FechaCad.Frozen = True
        Me.FechaCad.HeaderText = "Fecha Cad"
        Me.FechaCad.MinimumWidth = 8
        Me.FechaCad.Name = "FechaCad"
        Me.FechaCad.ReadOnly = True
        Me.FechaCad.Width = 123
        '
        'salircapt
        '
        Me.salircapt.BackColor = System.Drawing.Color.DarkCyan
        Me.salircapt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.salircapt.ForeColor = System.Drawing.Color.White
        Me.salircapt.Location = New System.Drawing.Point(988, 555)
        Me.salircapt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.salircapt.Name = "salircapt"
        Me.salircapt.Size = New System.Drawing.Size(147, 58)
        Me.salircapt.TabIndex = 4
        Me.salircapt.Text = "SALIR"
        Me.salircapt.UseVisualStyleBackColor = False
        '
        'ProxCad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.para
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.salircapt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ProxCad"
        Me.Text = "ProxCad"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NomProd As DataGridViewTextBoxColumn
    Friend WithEvents Lote As DataGridViewTextBoxColumn
    Friend WithEvents FechaCad As DataGridViewTextBoxColumn
    Friend WithEvents salircapt As Button
End Class
