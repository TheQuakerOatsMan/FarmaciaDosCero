

Public Class ProxCad
    Private Sub salircapt_Click(sender As Object, e As EventArgs) Handles salircapt.Click
        menuprin.Enabled = True
        Close()
    End Sub

    Private Sub ProxCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaC = New ADODB.Recordset
        consultaC.Open("SELECT FECHACAD, NOMED, NOMP FROM MEDICAMENTOS, PRODUCTOS, CADUCIDAD WHERE CVEMED In (Select CVEMED FROM DETCADMED WHERE CVECAD In (Select CVECAD FROM CADUCIDAD WHERE CVECAD In (Select CVECAD FROM DETCADPRO WHERE CVEPROD In (Select CVEPROD FROM PRODUCTOS))))", modulo.conexionc)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As New DataSet
        ODA.Fill(ds, modulo.consultaC, "Table1")
        DataGridView1.DataSource = ds.Tables("Table1").DefaultView
    End Sub
End Class