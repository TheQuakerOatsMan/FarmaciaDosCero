Public Class proveedores
    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        menuprin.Enabled = True
        menuprin.Visible = True
        Close()
    End Sub

    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuprin.Enabled = False
        menuprin.Visible = False
        consulta = New ADODB.Recordset
        consulta = conexion.Execute("select cveprov from proveedores order by cveprov")

        While Not consulta.EOF
            CVEPROV.Items.Add(consulta.Fields(0).Value) 'si no jala fijate en referencias y en propiedades, y le ponemos la opcion 5 en false'
            consulta.MoveNext()
        End While

    End Sub

    Private Sub binserta_Click(sender As Object, e As EventArgs) Handles binserta.Click
        ban = New ADODB.Parameter
        Dim clave As Integer
        clave = 0
        comanC = New ADODB.Command
        With comanC
            .CommandText = "PROVAUTO"
            .CommandType = CommandType.StoredProcedure
            '.Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Val(CVEPROV.Text))) ' sirve para un entero decimal o money para el tipo de dato fecha se busca como date y para el tipo de dato money se busca como currency'
            .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 50, NOMPROV.Text))
            .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 30, EMPRESA.Text))
            .Parameters.Append(.CreateParameter("2", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 50, DIRPROV.Text))
            .Parameters.Append(.CreateParameter("3", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 50, DIREMPSA.Text))
            .Parameters.Append(.CreateParameter("4", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 15, TELPROV.Text))
            .Parameters.Append(.CreateParameter("5", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, ESTADO.Text))
            .Parameters.Append(.CreateParameter("6", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 8, CODIGOP.Text))
            .Parameters.Append(.CreateParameter("7", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 30, LOCALIDAD.Text))
            .Parameters.Append(.CreateParameter("8", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 30, CORREOPROV.Text))
            .Parameters.Append(.CreateParameter("9", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , claveUser)) 'BANDERA val(nombredelcampo.Text)'
            .Parameters.Append(.CreateParameter("10", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0)) 'BANDERA val(nombredelcampo.Text)'
            .ActiveConnection = conexionc
            .Execute()
            ban.Value = .Parameters(10).Value

        End With
        If ban.Value = 1 Then
            MsgBox("EL NOMBRE DEL PROVEEDOR ESTA VACIO")
        Else
            If ban.Value = 2 Then
                MsgBox("El NOMBRE NO DEBE DE TENER CARACTERES NUMERICOS")
            Else
                If ban.Value = 3 Then
                    MsgBox("LA EMPRESA DEL PROVEEDOR NO DEBE DE ESTAR VACIA")
                Else
                    If ban.Value = 4 Then
                        MsgBox("LA DIRECCION DE LA EMPRESA NO DEBE DE ESTAR VACIA")
                    Else
                        If ban.Value = 5 Then
                            MsgBox("EL TELEFONO DEL PROVEEDOR NO DEBE DE ESTAR VACIO")
                        Else
                            If ban.Value = 6 Then
                                MsgBox("EL TELEFONO TIENE LETRAS")
                            Else
                                If ban.Value = 7 Then
                                    MsgBox("EL ESTADO NO DEBE DE ESTAR VACIO")
                                Else
                                    If ban.Value = 8 Then
                                        MsgBox("EL CODIGO POSTAL NO DEBE DE ESTAR VACIO")
                                    Else
                                        If ban.Value = 9 Then
                                            MsgBox("EL CODIGO POSTAL TIENE LETRAS")
                                        Else
                                            If ban.Value = 10 Then
                                                MsgBox("LA LOCALIDAD DEBE NO DEBE DE ESTAR VACIA")
                                            Else
                                                If ban.Value = 11 Then
                                                    MsgBox("EL CORREO DEL PROVEEDOR NO DEBE DE ESTAR VACIO")
                                                Else
                                                    If ban.Value = 21 Then
                                                        MsgBox("ESTE PROVEEDOR YA SE ENCUENTRA REGISTRADO EN LA BASE DE DATOS")
                                                    Else
                                                        If ban.Value = 50 Then
                                                            MsgBox("LA CLAVE DEL EMPLEADO NO PUEDE ESTA VACIA ")
                                                        Else
                                                            If ban.Value = 51 Then
                                                                MsgBox("EL USUARIO NO EXISTE")
                                                            Else
                                                                If ban.Value = 52 Then
                                                                    MsgBox("SESION NO INICIADA, INICIE UNA SESION PARA CONTINUAR")
                                                                Else
                                                                    consql = ("select max(cveprov) from proveedores")
                                                                    consultaC = New ADODB.Recordset
                                                                    consultaC = conexionc.Execute(consql)
                                                                    If Not consultaC.EOF Then
                                                                        clave = consultaC.Fields(0).Value
                                                                    End If
                                                                    MsgBox("La cve del proveedor es: " & clave & " insercion correcta")
                                                                    NOMPROV.Text = ""
                                                                    EMPRESA.Text = ""
                                                                    DIRPROV.Text = ""
                                                                    DIREMPSA.Text = ""
                                                                    TELPROV.Text = ""
                                                                    ESTADO.Text = ""
                                                                    CODIGOP.Text = ""
                                                                    LOCALIDAD.Text = ""
                                                                    CORREOPROV.Text = ""
                                                                    'AÑADIR LOS CAMPOS QUE FALTAN'
                                                                    clave = 0
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
                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub bconsult_Click(sender As Object, e As EventArgs) Handles bconsult.Click
        consulta2 = New ADODB.Recordset
        consulta2 = conexionc.Execute("select * from proveedores where cveprov=" & CVEPROV.Text)
        If Not consulta2.EOF Then
            NOMPROV.Text = consulta2.Fields(1).Value
            EMPRESA.Text = consulta2.Fields(2).Value
            DIRPROV.Text = consulta2.Fields(3).Value
            DIREMPSA.Text = consulta2.Fields(4).Value
            TELPROV.Text = consulta2.Fields(5).Value
            ESTADO.Text = consulta2.Fields(6).Value
            CODIGOP.Text = consulta2.Fields(7).Value
            LOCALIDAD.Text = consulta2.Fields(8).Value
            CORREOPROV.Text = consulta2.Fields(9).Value
            ACTIVO.Text = consulta2.Fields(10).Value
        Else
            MsgBox("La cve del proveedor esta vacia o esta dada de baja")
        End If
    End Sub
End Class