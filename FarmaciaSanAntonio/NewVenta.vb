﻿Public Class NewVenta
    'CREEE ESTAS NUEVAS DOS VARIABLES PARA EL TIPO Y LA CVE'
    Friend clavevta As Integer
    Friend tpago As String

    Private Sub AgregarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTO SE AGREGO NUEVO'
        clavevta = Val(cvvta.Text)
        'YA LO DE AQUI ES DEL DATAGRID'
        'consultaV = New ADODB.Recordset
        'consultaV.Open("select * from MEDICAMENTOS order by CVEMED", modulo.conexionv)
        'Dim ODA As New OleDb.OleDbDataAdapter
        'Dim tb As New DataTable
        'Dim ds As New DataSet
        'ODA.Fill(ds, modulo.consultaV, "Table1")
        ' DataMed.DataSource = ds.Tables("Table1").DefaultView
        'consultaV2 = New ADODB.Recordset
        'consultaV2.Open("select * from PRODUCTOS order by CVEPROD", modulo.conexionv)
        'Dim ODA2 As New OleDb.OleDbDataAdapter
        'Dim tb2 As New DataTable
        'Dim ds2 As New DataSet
        'ODA2.Fill(ds2, modulo.consultaV2, "Table1")
        'DataProd.DataSource = ds2.Tables("Table1").DefaultView'


        confirmEmp.Enabled = False
        confirmEmp.Visible = False
        consulta2 = New ADODB.Recordset
        consulta2 = conexionv.Execute("select * from ventas where cvevta=" & cvvta.Text)
        If Not consulta2.EOF Then
            ctpag.Text = consulta2.Fields(3).Value
            subt.Text = FormatCurrency(consulta2.Fields(1).Value)
            iva.Text = FormatCurrency(consulta2.Fields(2).Value)
            totalvta.Text = FormatCurrency(Val(subt.Text) + Val(iva.Text))
        Else
            MsgBox("La cve de la venta esta vacia o no se encuentra")
        End If
        subt.Enabled = False
        iva.Enabled = False
        totalvta.Enabled = False
        btnCoVta.Enabled = False
        cargadatos()

    End Sub
    Public Sub cargadatos()
        consulta2 = New ADODB.Recordset
        consulta2.Open("select medicamentos.CVEMED, medicamentos.NOMED, medicamentos.PRECIOVTAM, detvtamed.IMGRECT, detvtamed.CANTVM from medicamentos inner join detvtamed on detvtamed.cvemed=medicamentos.cvemed where cvevta=" & cvvta.Text, modulo.conexionv)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As New DataSet
        ODA.Fill(ds, modulo.consulta2, "Table1")
        data1.DataSource = ds.Tables("Table1").DefaultView
        consulta3 = New ADODB.Recordset
        consulta3.Open("select productos.CVEPROD, productos.NOMP, productos.PRECIOVTAP, detvtapro.CANTVP from productos inner join detvtapro on detvtapro.cveprod=productos.cveprod where cvevta=" & cvvta.Text, modulo.conexionv)
        Dim ODA2 As New OleDb.OleDbDataAdapter
        Dim tb2 As New DataTable
        Dim ds2 As New DataSet
        ODA.Fill(ds2, modulo.consulta3, "Table1")
        data2.DataSource = ds2.Tables("Table1").DefaultView
    End Sub
    Public Sub cagadamed()
        consultaV = New ADODB.Recordset
        consultaV.Open("select * from MEDICAMENTOS order by CVEMED", modulo.conexionv)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As New DataSet
        ODA.Fill(ds, modulo.consultaV, "Table1")
        DataMedi.DataSource = ds.Tables("Table1").DefaultView
    End Sub
    Public Sub cargadaprod()
        consultaV2 = New ADODB.Recordset
        consultaV2.Open("select * from PRODUCTOS order by CVEPROD", modulo.conexionv)
        Dim ODA2 As New OleDb.OleDbDataAdapter
        Dim tb2 As New DataTable
        Dim ds2 As New DataSet
        ODA2.Fill(ds2, modulo.consultaV, "Table1")
        DataProd.DataSource = ds2.Tables("Table1").DefaultView
    End Sub
    Public Sub actualizardatos()
        Dim iva1 As Integer
        Dim sub1 As Integer
        consulta5 = New ADODB.Recordset
        consulta5 = conexionv.Execute("select * from ventas where cvevta=" & cvvta.Text)
        If Not consulta5.EOF Then
            subt.Text = FormatCurrency(consulta5.Fields(1).Value)
            iva.Text = FormatCurrency(consulta5.Fields(2).Value)
            sub1 = consulta5.Fields(1).Value
            iva1 = consulta5.Fields(2).Value
        Else
            MsgBox("La cve de la venta esta vacia o no se encuentra")
        End If
        totalvta.Text = FormatCurrency(sub1 + iva1)
        'ESTO PARA QUE CARGUE DE NUEVO LOS RESULTADOS DE LAS TABLAS, EN DADO CASO QUE HAYA COMPRADO EN UNA, SE HIZO ASI POR QUE 
        'EN EL OTRO CASO TENGO QUE CONDICIONAR, ESTO SACRIFICA MEMORIA, PERO COMO QUIERAS WE SI QUIERES PONLE UNA CONICION'


    End Sub

    Private Sub addPro_Click(sender As Object, e As EventArgs) Handles addProd.Click
        Dim frm As New detvtam
        If (DataProd.SelectedRows.Count() > 0) Then
            frm.nompro.Text = DataProd.CurrentRow.Cells(1).Value.ToString()
            frm.cveprod.Text = DataProd.CurrentRow.Cells(0).Value.ToString()
            frm.prevtaprod.Text = FormatCurrency(DataProd.CurrentRow.Cells(3).Value.ToString())
            Dim num As Integer
            num = 1 'Existencias'
            Dim existencias As Integer
            existencias = DataProd.CurrentRow.Cells(4).Value

            While Not num > existencias
                frm.cantvp.Items.Add(num)
                num = num + 1
            End While
            frm.cventa = Val(cvvta.Text)
            frm.ShowDialog()
        Else
            MessageBox.Show("Debe seleccionar una fila")
        End If
    End Sub

    Private Sub btnre_Click(sender As Object, e As EventArgs) Handles btnre.Click
        Panel2.Visible = False
        habilita()
    End Sub

    Private Sub btnre9_Click(sender As Object, e As EventArgs) Handles btnre9.Click
        Panel3.Visible = False
        habilita()
    End Sub

    Private Sub btndetvmed_Click(sender As Object, e As EventArgs) Handles btndetvmed.Click
        Dim frm As New detvmed
        If (DataMedi.SelectedRows.Count() > 0) Then
            frm.nommed.Text = DataMedi.CurrentRow.Cells(1).Value.ToString()
            frm.cvemed.Text = DataMedi.CurrentRow.Cells(0).Value.ToString()
            frm.prevtamed.Text = FormatCurrency(DataMedi.CurrentRow.Cells(3).Value.ToString())
            Dim num As Integer
            num = 1 'Existencias'
            Dim existencias As Integer
            existencias = DataMedi.CurrentRow.Cells(4).Value

            While Not num > existencias
                frm.cantvm.Items.Add(num)
                num = num + 1
            End While
            frm.cventa = Val(cvvta.Text)
            frm.ShowDialog()
        Else
            MessageBox.Show("Debe seleccionar una fila")
        End If
    End Sub

    Private Sub btnCoVta_Click(sender As Object, e As EventArgs)
        MessageBox.Show("VENTA REALIZADA CON EXITO")
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub

    Public Sub habilita()
        cvvta.Enabled = False
        Label1.Enabled = True
        Label2.Enabled = True
        Label5.Enabled = True
        panelTotal.Enabled = True
        addm.Enabled = True
        btnadd.Enabled = True
        btnCancel.Enabled = True
        data1.Enabled = True
        data2.Enabled = True
        ctpag.Enabled = True 'pa que cambie'
    End Sub
    Public Sub deshabilita()
        cvvta.Enabled = False
        Label1.Enabled = False
        Label2.Enabled = False
        Label5.Enabled = False
        panelTotal.Enabled = False
        addm.Enabled = False
        btnadd.Enabled = False
        btnCancel.Enabled = False
        data1.Enabled = False
        data2.Enabled = False
        ctpag.Enabled = False 'pa que cambie'
    End Sub

    Private Sub btnadd_Click_1(sender As Object, e As EventArgs) Handles btnadd.Click
        Panel2.Visible = True
        consultaV2 = New ADODB.Recordset
        consultaV2.Open("select * from PRODUCTOS order by CVEPROD", modulo.conexionv)
        Dim ODA2 As New OleDb.OleDbDataAdapter
        Dim tb2 As New DataTable
        Dim ds2 As New DataSet
        ODA2.Fill(ds2, modulo.consultaV2, "Table1")
        DataProd.DataSource = ds2.Tables("Table1").DefaultView
        deshabilita()
    End Sub

    Private Sub addm_Click_1(sender As Object, e As EventArgs) Handles addm.Click

        Panel3.Visible = True
        consultaV = New ADODB.Recordset
        consultaV.Open("select * from MEDICAMENTOS order by CVEMED", modulo.conexionv)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As New DataSet
        ODA.Fill(ds, modulo.consultaV, "Table1")
        DataMedi.DataSource = ds.Tables("Table1").DefaultView
        deshabilita()
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        ban = New ADODB.Parameter
        comanV = New ADODB.Command
        With comanV
            .CommandText = "BAJAVTAS"
            .CommandType = CommandType.StoredProcedure
            '.Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(CVEPROV.Text))) ' sirve para un entero decimal o money para el tipo de dato fecha se busca como date y para el tipo de dato money se busca como currency'
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cvvta.Text)))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , claveUser))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
            .ActiveConnection = conexionv
            .Execute()
            ban.Value = .Parameters(2).Value

        End With
        If ban.Value = 1 Then
            MsgBox("LA CVE DE LA VENTA SE ENCUENTRA VACIA")
        Else
            If ban.Value = 2 Then
                MsgBox("LA CVE DE LA VENTA NO EXISTE")
            Else
                If ban.Value = 3 Then
                    MsgBox("NO SE PUEDE BORRAR LA VENTA")
                Else
                    If ban.Value = 4 Then
                        MsgBox("SESION NO INICIADA")
                    Else
                        MsgBox("VENTA CANCELADA")
                        menuprin.Enabled = True
                        menuprin.Visible = True
                        Close()
                        'AÑADIR LOS CAMPOS QUE FALTAN'

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnCoVta_Click_1(sender As Object, e As EventArgs) Handles btnCoVta.Click

        'ESTA PARTE LA CHECAS SI LA DEJAMOS ASI O NO, LO QUE PASA ES QUE PODRIA QUEDAR ASI POR SI LA DOÑA LAHACE DE PEDO POR QUE NO
        '"ES FUNCIONAL" Y ASI ENTONCES POR ESO LO MODIFICQUE'

        If (ctpag.SelectedItem = 0) Then
            MsgBox("La cve del la venta es: " & clavevta & " INSERCION CORRECTA")
        Else
            If (tpago = ctpag.SelectedItem.ToString) Then 'AQUI ME DICE SI SE QUEDO EN EFECTIVO O NEL'
                MsgBox("La cve del la venta es: " & clavevta & " INSERCION CORRECTA")
            Else
                ban = New ADODB.Parameter
                comanV = New ADODB.Command
                With comanV
                    .CommandText = "MODTIPOPAG"
                    .CommandType = CommandType.StoredProcedure
                    '.Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(CVEPROV.Text))) ' sirve para un entero decimal o money para el tipo de dato fecha se busca como date y para el tipo de dato money se busca como currency'
                    .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cvvta.Text)))
                    .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 21, ctpag.SelectedItem.ToString))
                    .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , claveUser))
                    .Parameters.Append(.CreateParameter("3", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
                    .ActiveConnection = conexionv
                    .Execute()
                    ban.Value = .Parameters(3).Value
                End With

                If ban.Value = 1 Then
                    MsgBox("LA CVE DE LA VENTA NO PUEDE ESTAR VACIA")
                Else
                    If ban.Value = 2 Then
                        MsgBox("EL TIPO DE PAGO NO DEBE DE ESTAR VACIO")
                    Else
                        If ban.Value = 3 Then
                            MsgBox("EL TIPO DE PAGO TIENE NUMEROS")
                        Else
                            If ban.Value = 4 Then
                                MsgBox("EL TIPO DE PAGO EXCEDE EL RANGO")
                            Else
                                If ban.Value = 5 Then
                                    MsgBox("ESTA VENTA NO SE ENCUENTRA REGISTRADA")
                                Else
                                    If ban.Value = 6 Then
                                        MsgBox("SESION NO INICIADA, INICIE UNA SESION PARA CONTINUAR")
                                    Else
                                        MsgBox("TIPO DE PAGO ACTUALIZADO")

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                MsgBox("La cve del la venta es: " & clavevta & " INSERCION CORRECTA")
            End If

        End If
        MessageBox.Show("VENTA REALIZADA CON EXITO")

        'CHECA SI SE LA DEJAS ESTOS CAMBIOS A VER QUE
        'DICES Y SI NO, LO DEJAMOS COMO ESTABA ANTERIORMENTE '

        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub


End Class