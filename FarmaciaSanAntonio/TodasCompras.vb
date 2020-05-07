Public Class TodasCompras
    Private Sub TodasCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioComprasDataSet.COMPRAS' Puede moverla o quitarla según sea necesario.
        Me.COMPRASTableAdapter1.Fill(Me.FarmSAntonioComprasDataSet.COMPRAS)
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioDataSet11.COMPRAS' Puede moverla o quitarla según sea necesario.
        Me.COMPRASTableAdapter.Fill(Me.FarmSAntonioDataSet11.COMPRAS)
        menuprin.Enabled = False
    End Sub

    Private Sub salircomt_Click(sender As Object, e As EventArgs) Handles salircomt.Click
        menuprin.Enabled = True
        Close()
    End Sub
End Class