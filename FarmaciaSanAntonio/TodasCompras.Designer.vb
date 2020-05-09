<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodasCompras
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.COMPRASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioComprasDataSet = New FarmaciaSanAntonio.FarmSAntonioComprasDataSet()
        Me.salircomt = New System.Windows.Forms.Button()
        Me.COMPRASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioDataSet11 = New FarmaciaSanAntonio.FarmSAntonioDataSet11()
        Me.COMPRASTableAdapter = New FarmaciaSanAntonio.FarmSAntonioDataSet11TableAdapters.COMPRASTableAdapter()
        Me.COMPRASTableAdapter1 = New FarmaciaSanAntonio.FarmSAntonioComprasDataSetTableAdapters.COMPRASTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPRASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioComprasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPRASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 8)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(784, 347)
        Me.DataGridView1.TabIndex = 0
        '
        'COMPRASBindingSource1
        '
        Me.COMPRASBindingSource1.DataMember = "COMPRAS"
        Me.COMPRASBindingSource1.DataSource = Me.FarmSAntonioComprasDataSet
        '
        'FarmSAntonioComprasDataSet
        '
        Me.FarmSAntonioComprasDataSet.DataSetName = "FarmSAntonioComprasDataSet"
        Me.FarmSAntonioComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'salircomt
        '
        Me.salircomt.BackColor = System.Drawing.Color.DarkCyan
        Me.salircomt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.salircomt.ForeColor = System.Drawing.Color.White
        Me.salircomt.Location = New System.Drawing.Point(659, 361)
        Me.salircomt.Name = "salircomt"
        Me.salircomt.Size = New System.Drawing.Size(98, 38)
        Me.salircomt.TabIndex = 3
        Me.salircomt.Text = "SALIR"
        Me.salircomt.UseVisualStyleBackColor = False
        '
        'COMPRASBindingSource
        '
        Me.COMPRASBindingSource.DataMember = "COMPRAS"
        Me.COMPRASBindingSource.DataSource = Me.FarmSAntonioDataSet11
        '
        'FarmSAntonioDataSet11
        '
        Me.FarmSAntonioDataSet11.DataSetName = "FarmSAntonioDataSet11"
        Me.FarmSAntonioDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMPRASTableAdapter
        '
        Me.COMPRASTableAdapter.ClearBeforeFill = True
        '
        'COMPRASTableAdapter1
        '
        Me.COMPRASTableAdapter1.ClearBeforeFill = True
        '
        'TodasCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.para
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salircomt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TodasCompras"
        Me.Text = "TodasCompras"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPRASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioComprasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPRASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FarmSAntonioDataSet11 As FarmSAntonioDataSet11
    Friend WithEvents COMPRASBindingSource As BindingSource
    Friend WithEvents COMPRASTableAdapter As FarmSAntonioDataSet11TableAdapters.COMPRASTableAdapter
    Friend WithEvents salircomt As Button
    Friend WithEvents FarmSAntonioComprasDataSet As FarmSAntonioComprasDataSet
    Friend WithEvents COMPRASBindingSource1 As BindingSource
    Friend WithEvents COMPRASTableAdapter1 As FarmSAntonioComprasDataSetTableAdapters.COMPRASTableAdapter
End Class
