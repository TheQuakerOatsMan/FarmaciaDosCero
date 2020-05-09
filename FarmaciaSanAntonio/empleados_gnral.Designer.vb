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
        Me.EMPLEADOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioVentasDataSet4 = New FarmaciaSanAntonio.FarmSAntonioVentasDataSet4()
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioDataSet7 = New FarmaciaSanAntonio.FarmSAntonioDataSet7()
        Me.EMPLEADOSTableAdapter = New FarmaciaSanAntonio.FarmSAntonioDataSet7TableAdapters.EMPLEADOSTableAdapter()
        Me.salirempt = New System.Windows.Forms.Button()
        Me.EMPLEADOSTableAdapter1 = New FarmaciaSanAntonio.FarmSAntonioVentasDataSet4TableAdapters.EMPLEADOSTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioVentasDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 8)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(784, 347)
        Me.DataGridView1.TabIndex = 0
        '
        'EMPLEADOSBindingSource1
        '
        Me.EMPLEADOSBindingSource1.DataMember = "EMPLEADOS"
        Me.EMPLEADOSBindingSource1.DataSource = Me.FarmSAntonioVentasDataSet4
        '
        'FarmSAntonioVentasDataSet4
        '
        Me.FarmSAntonioVentasDataSet4.DataSetName = "FarmSAntonioVentasDataSet4"
        Me.FarmSAntonioVentasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "empleados_gnral"
        Me.Text = "empleados_gnral"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioVentasDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FarmSAntonioDataSet7 As FarmSAntonioDataSet7
    Friend WithEvents EMPLEADOSBindingSource As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As FarmSAntonioDataSet7TableAdapters.EMPLEADOSTableAdapter
    Friend WithEvents salirempt As Button
    Friend WithEvents FarmSAntonioVentasDataSet4 As FarmSAntonioVentasDataSet4
    Friend WithEvents EMPLEADOSBindingSource1 As BindingSource
    Friend WithEvents EMPLEADOSTableAdapter1 As FarmSAntonioVentasDataSet4TableAdapters.EMPLEADOSTableAdapter
End Class
