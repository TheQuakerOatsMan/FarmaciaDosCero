Public Class detvmed
    Private Sub detvmed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend cventa As Integer

    Private Sub aniadirm_Click(sender As Object, e As EventArgs) Handles aniadirm.Click
        ban = New ADODB.Parameter
        comanV = New ADODB.Command
        With comanV
            .CommandText = "DETVME"
            .CommandType = CommandType.StoredProcedure
            '.Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(CVEPROV.Text))) ' sirve para un entero decimal o money para el tipo de dato fecha se busca como date y para el tipo de dato money se busca como currency'
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , cventa))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cvemed.Text)))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(cantvm.SelectedItem)))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, imgrec.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , claveUser))
            .Parameters.Append(.CreateParameter("5", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
            .ActiveConnection = conexionv
            .Execute()
            ban.Value = .Parameters(5).Value

        End With
        If ban.Value = 1 Then
            MsgBox("LA CVE DE LA VENTA ESTA VACIA")
        Else
            If ban.Value = 2 Then
                MsgBox("LA CVE DE LA VENTA NO EXISTE, MODIFICALA")
            Else
                If ban.Value = 3 Then
                    MsgBox("LA CVE DEL MEDICAMENTO ESTA VACIA")
                Else
                    If ban.Value = 4 Then
                        MsgBox("LA CVE DEL MEDICAMENTO NO EXISTE, MODIFICALA")
                    Else
                        If ban.Value = 5 Then
                            MsgBox("LA CANTIDAD VENDIDA ESTA VACIA O ES MENOR A 1")
                        Else
                            If ban.Value = 6 Then
                                MsgBox("LA RUTA DE LA IMAGEN NO EXISTE O ESTA VACIA")
                            Else
                                If ban.Value = 8 Then
                                    MsgBox("ESTE MEDICAMENTO HA SIDO DADO DE BAJA")
                                Else
                                    If ban.Value = 9 Then
                                        MsgBox("LA CANTIDAD SOLICITADA EXCEDE LAS EXISTENCIAS DE ESTE MEDICAMENTO")
                                    Else
                                        If ban.Value = 11 Then
                                            MsgBox("LA CANTIDAD SOLICITADA EXCEDE LAS EXISTENCIAS DE ESTE MEDICAMENTO")
                                        Else
                                            If ban.Value = 12 Then
                                                MsgBox("SESION NO INICIADA")
                                            Else
                                                MsgBox("DETALLE EXITOSO")
                                                'AÑADIR LOS CAMPOS QUE FALTAN'
                                                cantvm.SelectedText = ""
                                                ''NewVenta.cagadamed()
                                                NewVenta.actualizardatos()
                                                NewVenta.cargadatos()
                                                NewVenta.Panel3.Enabled = True
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
        End If

    End Sub

    Private Sub btnre10_Click(sender As Object, e As EventArgs) Handles btnre10.Click
        NewVenta.Panel3.Enabled = True
        Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            Dim archivo As New OpenFileDialog
            archivo.Filter = "ARCHIVO PDF|*.pdf"
            If archivo.ShowDialog = DialogResult.OK Then
                imgrec.Text = archivo.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class