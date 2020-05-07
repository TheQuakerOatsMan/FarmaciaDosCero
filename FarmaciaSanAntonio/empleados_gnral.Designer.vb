<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleados_gnral
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
        Me.CVEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIREMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREOEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDADEMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUESTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioDataSet7 = New FarmaciaSanAntonio.FarmSAntonioDataSet7()
        Me.EMPLEADOSTableAdapter = New FarmaciaSanAntonio.FarmSAntonioDataSet7TableAdapters.EMPLEADOSTableAdapter()
        Me.salirempt = New System.Windows.Forms.Button()
        Me.FarmSAntonioVentasDataSet4 = New FarmaciaSanAntonio.FarmSAntonioVentasDataSet4()
        Me.EMPLEADOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLEADOSTableAdapter1 = New FarmaciaSanAntonio.FarmSAntonioVentasDataSet4TableAdapters.EMPLEADOSTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioVentasDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CVEMPDataGridViewTextBoxColumn, Me.NOMEMPDataGridViewTextBoxColumn, Me.DIREMPDataGridViewTextBoxColumn, Me.CORREOEMPDataGridViewTextBoxColumn, Me.TELEMPDataGridViewTextBoxColumn, Me.EDADEMPDataGridViewTextBoxColumn, Me.PUESTODataGridViewTextBoxColumn, Me.ACTIVODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPLEADOSBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(8, 8)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(784, 347)
        Me.DataGridView1.TabIndex = 0
        '
        'CVEMPDataGridViewTextBoxColumn
        '
        Me.CVEMPDataGridViewTextBoxColumn.DataPropertyName = "CVEMP"
        Me.CVEMPDataGridViewTextBoxColumn.HeaderText = "CVEMP"
        Me.CVEMPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CVEMPDataGridViewTextBoxColumn.Name = "CVEMPDataGridViewTextBoxColumn"
        Me.CVEMPDataGridViewTextBoxColumn.Width = 150
        '
        'NOMEMPDataGridViewTextBoxColumn
        '
        Me.NOMEMPDataGridViewTextBoxColumn.DataPropertyName = "NOMEMP"
        Me.NOMEMPDataGridViewTextBoxColumn.HeaderText = "NOMEMP"
        Me.NOMEMPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NOMEMPDataGridViewTextBoxColumn.Name = "NOMEMPDataGridViewTextBoxColumn"
        Me.NOMEMPDataGridViewTextBoxColumn.Width = 150
        '
        'DIREMPDataGridViewTextBoxColumn
        '
        Me.DIREMPDataGridViewTextBoxColumn.DataPropertyName = "DIREMP"
        Me.DIREMPDataGridViewTextBoxColumn.HeaderText = "DIREMP"
        Me.DIREMPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DIREMPDataGridViewTextBoxColumn.Name = "DIREMPDataGridViewTextBoxColumn"
        Me.DIREMPDataGridViewTextBoxColumn.Width = 150
        '
        'CORREOEMPDataGridViewTextBoxColumn
        '
        Me.CORREOEMPDataGridViewTextBoxColumn.DataPropertyName = "CORREOEMP"
        Me.CORREOEMPDataGridViewTextBoxColumn.HeaderText = "CORREOEMP"
        Me.CORREOEMPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CORREOEMPDataGridViewTextBoxColumn.Name = "CORREOEMPDataGridViewTextBoxColumn"
        Me.CORREOEMPDataGridViewTextBoxColumn.Width = 150
        '
        'TELEMPDataGridViewTextBoxColumn
        '
        Me.TELEMPDataGridViewTextBoxColumn.DataPropertyName = "TELEMP"
        Me.TELEMPDataGridViewTextBoxColumn.HeaderText = "TELEMP"
        Me.TELEMPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TELEMPDataGridViewTextBoxColumn.Name = "TELEMPDataGridViewTextBoxColumn"
        Me.TELEMPDataGridViewTextBoxColumn.Width = 150
        '
        'EDADEMPDataGridViewTextBoxColumn
        '
        Me.EDADEMPDataGridViewTextBoxColumn.DataPropertyName = "EDADEMP"
        Me.EDADEMPDataGridViewTextBoxColumn.HeaderText = "EDADEMP"
        Me.EDADEMPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EDADEMPDataGridViewTextBoxColumn.Name = "EDADEMPDataGridViewTextBoxColumn"
        Me.EDADEMPDataGridViewTextBoxColumn.Width = 150
        '
        'PUESTODataGridViewTextBoxColumn
        '
        Me.PUESTODataGridViewTextBoxColumn.DataPropertyName = "PUESTO"
        Me.PUESTODataGridViewTextBoxColumn.HeaderText = "PUESTO"
        Me.PUESTODataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PUESTODataGridViewTextBoxColumn.Name = "PUESTODataGridViewTextBoxColumn"
        Me.PUESTODataGridViewTextBoxColumn.Width = 150
        '
        'ACTIVODataGridViewTextBoxColumn
        '
        Me.ACTIVODataGridViewTextBoxColumn.DataPropertyName = "ACTIVO"
        Me.ACTIVODataGridViewTextBoxColumn.HeaderText = "ACTIVO"
        Me.ACTIVODataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ACTIVODataGridViewTextBoxColumn.Name = "ACTIVODataGridViewTextBoxColumn"
        Me.ACTIVODataGridViewTextBoxColumn.Width = 150
        '
        'EMPLEADOSBindingSource
        '
        Me.EMPLEADOSBindingSource.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource.DataSource = Me.FarmSAntonioDataSet7
        '
        'FarmSAntonioDataSet7
        '
        Me.FarmSAntonioDataSet7.DataSetName = "FarmSAntonioDataSet7"
        Me.FarmSAntonioDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOSTableAdapter
        '
        Me.EMPLEADOSTableAdapter.ClearBeforeFill = True
        '
        'salirempt
        '
        Me.salirempt.BackColor = System.Drawing.Color.DarkCyan
        Me.salirempt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.salirempt.ForeColor = System.Drawing.Color.White
        Me.salirempt.Location = New System.Drawing.Point(659, 361)
        Me.salirempt.Name = "salirempt"
        Me.salirempt.Size = New System.Drawing.Size(98, 38)
        Me.salirempt.TabIndex = 2
        Me.salirempt.Text = "SALIR"
        Me.salirempt.UseVisualStyleBackColor = False
        '
        'FarmSAntonioVentasDataSet4
        '
        Me.FarmSAntonioVentasDataSet4.DataSetName = "FarmSAntonioVentasDataSet4"
        Me.FarmSAntonioVentasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLEADOSBindingSource1
        '
        Me.EMPLEADOSBindingSource1.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource1.DataSource = Me.FarmSAntonioVentasDataSet4
        '
        'EMPLEADOSTableAdapter1
        '
        Me.EMPLEADOSTableAdapter1.ClearBeforeFill = True
        '
        'empleados_gnral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.para
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salirempt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "empleados_gnral"
        Me.Text = "empleados_gnral"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioVentasDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FarmSAntonioDataSet7 As FarmSAntonioDataSet7
    Friend WithEvents EMPLEADOSBindingSource As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As FarmSAntonioDataSet7TableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents CVEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIREMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CORREOEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EDADEMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PUESTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents salirempt As Button
    Friend WithEvents FarmSAntonioVentasDataSet4 As FarmSAntonioVentasDataSet4
    Friend WithEvents EMPLEADOSBindingSource1 As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter1 As FarmSAntonioVentasDataSet4TableAdapters.EMPLEADOSTableAdapter
End Class
