Public Class detvtam

    Friend cventa As Integer
    Private Sub detvtapro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnre8_Click(sender As Object, e As EventArgs) Handles btnre8.Click
        NewVenta.Panel2.Enabled = True
        Close()
    End Sub

    Private Sub aniadirp_Click(sender As Object, e As EventArgs) Handles aniadirp.Click

        ban = New ADODB.Parameter
        comanV = New ADODB.Command
        With comanV
            .CommandText = "DETVPRO"
            .CommandType = CommandType.StoredProcedure
            '.Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(CVEPROV.Text))) ' sirve para un entero decimal o money para el tipo de dato fecha se busca como date y para el tipo de dato money se busca como currency'
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , cventa))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cveprod.Text)))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cantvp.SelectedItem)))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , claveUser))
            .Parameters.Append(.CreateParameter("4", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
            .ActiveConnection = conexionv
            .Execute()
            ban.Value = .Parameters(4).Value

        End With
        If ban.Value = 1 Then
            MsgBox("LA CVE DE LA VENTA ESTA VACIA")
        Else
            If ban.Value = 2 Then
                MsgBox("LA CVE DE LA VENTA NO EXISTE, MODIFICALA")
            Else
                If ban.Value = 3 Then
                    MsgBox("LA CVE DEL PRODUCTO NO EXISTE")
                Else
                    If ban.Value = 4 Then
                        MsgBox("LA CVE DEL PRODUCTO NO EXISTE, MODIFICALA")
                    Else
                        If ban.Value = 5 Then
                            MsgBox("LA CANTIDAD VENDIDA ESTA VACIA O ES MENOR A 1")
                        Else
                            If ban.Value = 6 Then
                                MsgBox("ESTE PRODUCTO HA SIDO DADO DE BAJA")
                            Else
                                If ban.Value = 7 Then
                                    MsgBox("LA CANTIDAD SOLICITADA EXCEDE LAS EXISTENCIAS DE ESTE PRODUCTO")
                                Else
                                    If ban.Value = 8 Then
                                        MsgBox("LA CANTIDAD SOLICITADA EXCEDE LAS EXISTENCIAS DE ESTE PRODUCTO")
                                    Else
                                        If ban.Value = 9 Then
                                            MsgBox("SESION NO INICIADA")
                                        Else
                                            MsgBox("DETALLE EXITOSO")
                                            'AÑADIR LOS CAMPOS QUE FALTAN'
                                            cantvp.SelectedText = ""
                                            NewVenta.Panel2.Enabled = True
                                            ''NewVenta.cargadaprod()
                                            NewVenta.actualizardatos()
                                            NewVenta.cargadatos()
                                            NewVenta.btnCoVta.Enabled = True
                                            Close()
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class