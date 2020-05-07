<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodosMed
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
        Me.MEDICAMENTOSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DECOMPRASGERENCIA = New FarmaciaSanAntonio.DECOMPRASGERENCIA()
        Me.MEDICAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioDataSet10 = New FarmaciaSanAntonio.FarmSAntonioDataSet10()
        Me.MEDICAMENTOSTableAdapter = New FarmaciaSanAntonio.FarmSAntonioDataSet10TableAdapters.MEDICAMENTOSTableAdapter()
        Me.salirmedt = New System.Windows.Forms.Button()
        Me.DEVENTAS = New FarmaciaSanAntonio.DEVENTAS()
        Me.MEDICAMENTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICAMENTOSTableAdapter1 = New FarmaciaSanAntonio.DEVENTASTableAdapters.MEDICAMENTOSTableAdapter()
        Me.MEDICAMENTOSTableAdapter2 = New FarmaciaSanAntonio.DECOMPRASGERENCIATableAdapters.MEDICAMENTOSTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DECOMPRASGERENCIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEVENTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICAMENTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MEDICAMENTOSBindingSource2
        '
        Me.MEDICAMENTOSBindingSource2.DataMember = "MEDICAMENTOS"
        Me.MEDICAMENTOSBindingSource2.DataSource = Me.DECOMPRASGERENCIA
        '
        'DECOMPRASGERENCIA
        '
        Me.DECOMPRASGERENCIA.DataSetName = "DECOMPRASGERENCIA"
        Me.DECOMPRASGERENCIA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICAMENTOSBindingSource
        '
        Me.MEDICAMENTOSBindingSource.DataMember = "MEDICAMENTOS"
        Me.MEDICAMENTOSBindingSource.DataSource = Me.FarmSAntonioDataSet10
        '
        'FarmSAntonioDataSet10
        '
        Me.FarmSAntonioDataSet10.DataSetName = "FarmSAntonioDataSet10"
        Me.FarmSAntonioDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICAMENTOSTableAdapter
        '
        Me.MEDICAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'salirmedt
        '
        Me.salirmedt.BackColor = System.Drawing.Color.DarkCyan
        Me.salirmedt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.salirmedt.ForeColor = System.Drawing.Color.White
        Me.salirmedt.Location = New System.Drawing.Point(659, 361)
        Me.salirmedt.Name = "salirmedt"
        Me.salirmedt.Size = New System.Drawing.Size(98, 38)
        Me.salirmedt.TabIndex = 4
        Me.salirmedt.Text = "SALIR"
        Me.salirmedt.UseVisualStyleBackColor = False
        '
        'DEVENTAS
        '
        Me.DEVENTAS.DataSetName = "DEVENTAS"
        Me.DEVENTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEDICAMENTOSBindingSource1
        '
        Me.MEDICAMENTOSBindingSource1.DataMember = "MEDICAMENTOS"
        Me.MEDICAMENTOSBindingSource1.DataSource = Me.DEVENTAS
        '
        'MEDICAMENTOSTableAdapter1
        '
        Me.MEDICAMENTOSTableAdapter1.ClearBeforeFill = True
        '
        'MEDICAMENTOSTableAdapter2
        '
        Me.MEDICAMENTOSTableAdapter2.ClearBeforeFill = True
        '
        'TodosMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.para
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salirmedt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TodosMed"
        Me.Text = "TodosMed"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DECOMPRASGERENCIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEVENTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICAMENTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FarmSAntonioDataSet10 As FarmSAntonioDataSet10
    Friend WithEvents MEDICAMENTOSBindingSource As BindingSource
    Friend WithEvents MEDICAMENTOSTableAdapter As FarmSAntonioDataSet10TableAdapters.MEDICAMENTOSTableAdapter
    Friend WithEvents salirmedt As Button
    Friend WithEvents DEVENTAS As DEVENTAS
    Friend WithEvents MEDICAMENTOSBindingSource1 As BindingSource
    Friend WithEvents MEDICAMENTOSTableAdapter1 As DEVENTASTableAdapters.MEDICAMENTOSTableAdapter
    Friend WithEvents DECOMPRASGERENCIA As DECOMPRASGERENCIA
    Friend WithEvents MEDICAMENTOSBindingSource2 As BindingSource
    Friend WithEvents MEDICAMENTOSTableAdapter2 As DECOMPRASGERENCIATableAdapters.MEDICAMENTOSTableAdapter
End Class
