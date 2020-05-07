Public Class empleados_gnral
    Private Sub empleados_gnral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmSAntonioVentasDataSet4.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter1.Fill(Me.FarmSAntonioVentasDataSet4.EMPLEADOS)

        menuprin.Enabled = False
    End Sub

    Private Sub salirempt_Click(sender As Object, e As EventArgs) Handles salirempt.Click
        menuprin.Enabled = True
        Close()
    End Sub
End Class