<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodasVentas
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
        Me.CVEVTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPOPAGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAVTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioDataSet9 = New FarmaciaSanAntonio.FarmSAntonioDataSet9()
        Me.VENTASTableAdapter = New FarmaciaSanAntonio.FarmSAntonioDataSet9TableAdapters.VENTASTableAdapter()
        Me.salirvent = New System.Windows.Forms.Button()
        Me.FarmSAntonioVentasDataSet = New FarmaciaSanAntonio.FarmSAntonioVentasDataSet()
        Me.VENTASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VENTASTableAdapter1 = New FarmaciaSanAntonio.FarmSAntonioVentasDataSetTableAdapters.VENTASTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioVentasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVEVTADataGridViewTextBoxColumn, Me.SUBTOTALDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.TIPOPAGDataGridViewTextBoxColumn, Me.FECHAVTADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VENTASBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(8, 8)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(784, 347)
        Me.DataGridView1.TabIndex = 0
        '
        'CVEVTADataGridViewTextBoxColumn
        '
        Me.CVEVTADataGridViewTextBoxColumn.DataPropertyName = "CVEVTA"
        Me.CVEVTADataGridViewTextBoxColumn.HeaderText = "CVEVTA"
        Me.CVEVTADataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CVEVTADataGridViewTextBoxColumn.Name = "CVEVTADataGridViewTextBoxColumn"
        '
        'SUBTOTALDataGridViewTextBoxColumn
        '
        Me.SUBTOTALDataGridViewTextBoxColumn.DataPropertyName = "SUBTOTAL"
        Me.SUBTOTALDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL"
        Me.SUBTOTALDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SUBTOTALDataGridViewTextBoxColumn.Name = "SUBTOTALDataGridViewTextBoxColumn"
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        '
        'TIPOPAGDataGridViewTextBoxColumn
        '
        Me.TIPOPAGDataGridViewTextBoxColumn.DataPropertyName = "TIPOPAG"
        Me.TIPOPAGDataGridViewTextBoxColumn.HeaderText = "TIPOPAG"
        Me.TIPOPAGDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TIPOPAGDataGridViewTextBoxColumn.Name = "TIPOPAGDataGridViewTextBoxColumn"
        '
        'FECHAVTADataGridViewTextBoxColumn
        '
        Me.FECHAVTADataGridViewTextBoxColumn.DataPropertyName = "FECHAVTA"
        Me.FECHAVTADataGridViewTextBoxColumn.HeaderText = "FECHAVTA"
        Me.FECHAVTADataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FECHAVTADataGridViewTextBoxColumn.Name = "FECHAVTADataGridViewTextBoxColumn"
        '
        'VENTASBindingSource
        '
        Me.VENTASBindingSource.DataMember = "VENTAS"
        Me.VENTASBindingSource.DataSource = Me.FarmSAntonioDataSet9
        '
        'FarmSAntonioDataSet9
        '
        Me.FarmSAntonioDataSet9.DataSetName = "FarmSAntonioDataSet9"
        Me.FarmSAntonioDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENTASTableAdapter
        '
        Me.VENTASTableAdapter.ClearBeforeFill = True
        '
        'salirvent
        '
        Me.salirvent.BackColor = System.Drawing.Color.DarkCyan
        Me.salirvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.salirvent.ForeColor = System.Drawing.Color.White
        Me.salirvent.Location = New System.Drawing.Point(659, 361)
        Me.salirvent.Name = "salirvent"
        Me.salirvent.Size = New System.Drawing.Size(98, 38)
        Me.salirvent.TabIndex = 3
        Me.salirvent.Text = "SALIR"
        Me.salirvent.UseVisualStyleBackColor = False
        '
        'FarmSAntonioVentasDataSet
        '
        Me.FarmSAntonioVentasDataSet.DataSetName = "FarmSAntonioVentasDataSet"
        Me.FarmSAntonioVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VENTASBindingSource1
        '
        Me.VENTASBindingSource1.DataMember = "VENTAS"
        Me.VENTASBindingSource1.DataSource = Me.FarmSAntonioVentasDataSet
        '
        'VENTASTableAdapter1
        '
        Me.VENTASTableAdapter1.ClearBeforeFill = True
        '
        'TodasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.para
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salirvent)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TodasVentas"
        Me.Text = "TodasVentas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioVentasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FarmSAntonioDataSet9 As FarmSAntonioDataSet9
    Friend WithEvents VENTASBindingSource As BindingSource
    Friend WithEvents VENTASTableAdapter As FarmSAntonioDataSet9TableAdapters.VENTASTableAdapter
    Friend WithEvents CVEVTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIPOPAGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHAVTADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents salirvent As Button
    Friend WithEvents FarmSAntonioVentasDataSet As FarmSAntonioVentasDataSet
    Friend WithEvents VENTASBindingSource1 As BindingSource
    Friend WithEvents VENTASTableAdapter1 As FarmSAntonioVentasDataSetTableAdapters.VENTASTableAdapter
End Class
