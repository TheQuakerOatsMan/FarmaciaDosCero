<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodosProd
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
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmSAntonioDataSet8 = New FarmaciaSanAntonio.FarmSAntonioDataSet8()
        Me.PRODUCTOSTableAdapter = New FarmaciaSanAntonio.FarmSAntonioDataSet8TableAdapters.PRODUCTOSTableAdapter()
        Me.salirprodt = New System.Windows.Forms.Button()
        Me.DEVENTASP = New FarmaciaSanAntonio.DEVENTASP()
        Me.PRODUCTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOSTableAdapter1 = New FarmaciaSanAntonio.DEVENTASPTableAdapters.PRODUCTOSTableAdapter()
        Me.DECOMPRASP = New FarmaciaSanAntonio.DECOMPRASP()
        Me.PRODUCTOSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOSTableAdapter2 = New FarmaciaSanAntonio.DECOMPRASPTableAdapters.PRODUCTOSTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmSAntonioDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEVENTASP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DECOMPRASP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 8)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(784, 347)
        Me.DataGridView1.TabIndex = 0
        '
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.FarmSAntonioDataSet8
        '
        'FarmSAntonioDataSet8
        '
        Me.FarmSAntonioDataSet8.DataSetName = "FarmSAntonioDataSet8"
        Me.FarmSAntonioDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'salirprodt
        '
        Me.salirprodt.BackColor = System.Drawing.Color.DarkCyan
        Me.salirprodt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.salirprodt.ForeColor = System.Drawing.Color.White
        Me.salirprodt.Location = New System.Drawing.Point(659, 361)
        Me.salirprodt.Name = "salirprodt"
        Me.salirprodt.Size = New System.Drawing.Size(98, 38)
        Me.salirprodt.TabIndex = 2
        Me.salirprodt.Text = "SALIR"
        Me.salirprodt.UseVisualStyleBackColor = False
        '
        'DEVENTASP
        '
        Me.DEVENTASP.DataSetName = "DEVENTASP"
        Me.DEVENTASP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOSBindingSource1
        '
        Me.PRODUCTOSBindingSource1.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource1.DataSource = Me.DEVENTASP
        '
        'PRODUCTOSTableAdapter1
        '
        Me.PRODUCTOSTableAdapter1.ClearBeforeFill = True
        '
        'DECOMPRASP
        '
        Me.DECOMPRASP.DataSetName = "DECOMPRASP"
        Me.DECOMPRASP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTOSBindingSource2
        '
        Me.PRODUCTOSBindingSource2.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource2.DataSource = Me.DECOMPRASP
        '
        'PRODUCTOSTableAdapter2
        '
        Me.PRODUCTOSTableAdapter2.ClearBeforeFill = True
        '
        'TodosProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmaciaSanAntonio.My.Resources.Resources.para
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salirprodt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TodosProd"
        Me.Text = "TodosProd"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmSAntonioDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEVENTASP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DECOMPRASP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FarmSAntonioDataSet8 As FarmSAntonioDataSet8
    Friend WithEvents PRODUCTOSBindingSource As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As FarmSAntonioDataSet8TableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents salirprodt As Button
    Friend WithEvents DEVENTASP As DEVENTASP
    Friend WithEvents PRODUCTOSBindingSource1 As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter1 As DEVENTASPTableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents DECOMPRASP As DECOMPRASP
    Friend WithEvents PRODUCTOSBindingSource2 As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter2 As DECOMPRASPTableAdapters.PRODUCTOSTableAdapter
End Class
