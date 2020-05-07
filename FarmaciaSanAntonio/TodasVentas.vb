Public Class TodasVentas
    Private Sub TodasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioVentasDataSet.VENTAS' Puede moverla o quitarla según sea necesario.
        Me.VENTASTableAdapter1.Fill(Me.FarmSAntonioVentasDataSet.VENTAS)
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioDataSet9.VENTAS' Puede moverla o quitarla según sea necesario.
        Me.VENTASTableAdapter.Fill(Me.FarmSAntonioDataSet9.VENTAS)
        menuprin.Enabled = False
    End Sub

    Private Sub salirvent_Click(sender As Object, e As EventArgs) Handles salirvent.Click
        menuprin.Enabled = True
        Close()
    End Sub
End Class