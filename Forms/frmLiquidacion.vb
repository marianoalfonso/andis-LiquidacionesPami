Imports System.Data.SqlClient



Public Class frmLiquidacion



    Private Liquidacion As New clsLiquidacion
    Private sArea As String
    Private sNumeroLiquidacion As String
    Private sTotalFactura As Double
    Private sTotalFacturado As Double

    'VARIABLES PARA LA IMPRESION
    Private iNumLiq As Integer
    Private iNumeroLiquidacion As String
    Private iCuit As String
    Private iRazonSocial As String
    Private iPeriodo As String
    Private iTipoFactura As String
    Private iNumeroFactura As String
    Private iModulo As String
    Private iImporteFacturado As Double
    Private iNumeroDebito As String
    Private iImporteDebito As Double
    Private iNumeroBafc As String
    Private iImporteBafc As Double
    Public iImporteLiquidado As Double
    Private iLeyendaImporteLiquidado As String
    Private iLiquidadoAlFondo As Double
    Private iObservaciones As String
    Private iFechaLiquidacion As String
    Private iExpediente As String
    Private iReferencia As String
    Private iUsuario As String
    Private xImporteFacturado As Double  'ALMACENA EL IMPORTE FACTURADO ELECTRONICAMENTE

    'RECIBE LA VARIABLE DE AREA
    Public Property Area() As String
        Get
            Return sArea
        End Get
        Set(value As String)
            If value <> "" Then
                sArea = value
            End If
        End Set
    End Property





    Private Sub frmLiquidacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Liquidacion.Cuit = "20-22925061-3"
        'Liquidacion.Sucursal = "0001"
        'Liquidacion.Factura = "0001-00000987"
        'Liquidacion.Periodo = "02-2012"
        'Liquidacion.RazonSocial = "Centro de Dia el Sol Naciente"

        Call Configurar_Formulario()




    End Sub

    Sub Configurar_Formulario()
        cmbMonth.Items.Add("01")
        cmbMonth.Items.Add("02")
        cmbMonth.Items.Add("03")
        cmbMonth.Items.Add("04")
        cmbMonth.Items.Add("05")
        cmbMonth.Items.Add("06")
        cmbMonth.Items.Add("07")
        cmbMonth.Items.Add("08")
        cmbMonth.Items.Add("09")
        cmbMonth.Items.Add("10")
        cmbMonth.Items.Add("11")
        cmbMonth.Items.Add("12")
        'cmbYear.Items.Add("2012")
        'cmbYear.Items.Add("2013")
        'cmbYear.Items.Add("2014")
        'cmbYear.Items.Add("2015")
        'cmbYear.Items.Add("2016")
        'cmbYear.Items.Add("2017")
        cmbYear.Items.Add("2018")
        cmbYear.Items.Add("2019")
        cmbYear.Items.Add("2020")
        cmbYear.Items.Add("2021")
        cmbYear.Items.Add("2022")
        cmbYear.Items.Add("2023")
        cmbYear.Items.Add("2024")
        cmbYear.Items.Add("2025")
        cmbYear.Items.Add("2026")
        cmbYear.Items.Add("2027")
        cmbYear.Items.Add("2028")
        cmbYear.Items.Add("2029")
        cmbYear.Items.Add("2030")
        cmbTipoComprobante.Items.Add("Factura")
        cmbTipoComprobante.Items.Add("Factura B")
        cmbTipoComprobante.Items.Add("Factura C")
        cmbTipoComprobante.Items.Add("Recibo")
        Me.Top = 2
        Me.Left = 2
    End Sub

    Function Validar_Formulario() As Boolean
        If cmbMonth.Text = "" Then
            Return False
        End If
        If cmbMonth.Text = "" Then
            Return False
        End If
        If cmbFacturas.Text = "" Then
            Return False
        End If
        If mebMontoFactura.Text = "" Then
            Return False
        End If
        If Not IsNumeric(mebMontoFactura.Text) Then
            Return False
        Else
            mebMontoFactura.Text = Replace(mebMontoFactura.Text, ",", ".")
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        Dim Da As New SqlDataAdapter(Cmd)
        Dim Dt As New DataTable()
        Dim iContador As Integer
        Dim sCuit As String
        Dim sPeriodo As String
        Dim sFactura As String
        Dim sSucursal As String
        Dim tempMontoFactura As Double

        Try

            cmdCerrar.Visible = False

            If Not Validar_Formulario Then
                MsgBox("Debe completar los datos necesarios para la liquidacion.", vbInformation)
                Exit Sub
            End If

            'CONTROLAMOS QUE EL VALOR FACTURADO ELECTRONICAMENTE SEA IGUAL O MENOR DEL INFORMADO EN LA FACTURA
            tempMontoFactura = CDbl(mebMontoFactura.Text)
            If xImporteFacturado > tempMontoFactura Then
                MsgBox("El monto facturado es menor al informado en el detalle electronico. No es posible liquidar esta factura", vbCritical)
                Me.Close()
                Exit Sub
            End If


            sPeriodo = Trim(cmbMonth.Text) & Trim(cmbYear.Text)
            sCuit = Limpiar_Cadena(Trim(mebCuit.Text), "-")
            sFactura = Trim(cmbFacturas.Text)
            sSucursal = Mid(Trim(cmbFacturas.Text), 1, 4)

            txtImporteFacturado.TextAlign = HorizontalAlignment.Right
            'txtImporteFacturado.Text = Format(Totalizar_Facturacion(sArea, sCuit, sPeriodo, sSucursal, sFactura), "##,##0.00")
            txtImporteFacturado.Text = mebMontoFactura.Text

            '  sTotalFacturado = CDbl(Replace(txtImporteFacturado.Text, ".", ","))
            sTotalFacturado = txtImporteFacturado.Text
            '   mebMontoFactura.Text = CDbl(Replace(mebMontoFactura.Text, ".", ","))
            sTotalFactura = CDbl(mebMontoFactura.Text)


            Cmd.CommandText = "SP_GENERAR_LIQUIDACION"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@SUCURSAL", Trim(sSucursal))
            Cmd.Parameters.AddWithValue("@AREA", Trim(sArea))
            Cmd.Parameters.AddWithValue("@CUIT", Trim(sCuit))
            Cmd.Parameters.AddWithValue("@PERIODO", Trim(sPeriodo))
            Cmd.Parameters.AddWithValue("@NUMERO_FACTURA", Trim(sFactura))
            Cmd.Parameters.AddWithValue("@p_TOTAL_FACTURA", sTotalFactura)
            Cmd.Parameters.AddWithValue("@p_TOTAL_FACTURADO", sTotalFacturado)
            Conn.Open()
            'Cmd.ExecuteNonQuery()
            REM SI EJECUTO EL NONQUERY ME VUELVE A EJECUTAR EL STORE

            Da.Fill(Dt)
            DataGridView1.DataSource = Dt

            'CONTROLAR RESULTADOS SI EXISTEN
            Me.DataGridView1.Font = New System.Drawing.Font("Times New Roman", 8)
            DataGridView1.Columns(0).Visible = False
            sNumeroLiquidacion = DataGridView1.Rows(0).Cells(0).Value
            lblNumeroLiquidacion.Text = Str(sNumeroLiquidacion) + "/12"
            For iContador = 8 To 15
                DataGridView1.Columns(iContador).Visible = False
            Next
            'ALINEAMOS AL CENTRO LAS CABECERAS
            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).HeaderText = "Beneficio"
            DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(2).Width = 170
            DataGridView1.Columns(2).HeaderText = "Nombre"
            DataGridView1.Columns(3).Width = 80
            DataGridView1.Columns(3).HeaderText = "Tipo"
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(4).Width = 300
            DataGridView1.Columns(4).HeaderText = "Detalle Prestacion"
            DataGridView1.Columns(5).Width = 80
            DataGridView1.Columns(5).HeaderText = "Imp. Facturado"
            DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(5).DefaultCellStyle.Format = "##,##0.00"
            DataGridView1.Columns(6).Width = 80
            DataGridView1.Columns(6).HeaderText = "Imp. Autorizado"
            DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(6).DefaultCellStyle.Format = "##,##0.00"
            DataGridView1.Columns(7).HeaderText = "Saldo"
            DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(7).DefaultCellStyle.Format = "##,##0.00"
            DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)

            Dim iValorAuxiliar As Double
            For Each row As DataGridViewRow In DataGridView1.Rows
                iValorAuxiliar = row.Cells(7).Value
                If iValorAuxiliar < 0 Then
                    row.Cells(7).Style.BackColor = Color.Red
                ElseIf iValorAuxiliar > 0 Then
                    row.Cells(7).Style.BackColor = Color.GreenYellow
                End If
            Next

            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()

            Call Mostrar_Debitos(sNumeroLiquidacion)
            'txtImporteFacturado.TextAlign = HorizontalAlignment.Right
            'txtImporteFacturado.Text = Format(Totalizar_Facturacion(sArea, sCuit, sPeriodo, sSucursal, sFactura), "##,##0.00")
            txtImporteLiquidado.TextAlign = HorizontalAlignment.Right
            txtImporteLiquidado.Text = Format(Totalizar_Liquidacion(sNumeroLiquidacion), "##,##0.00")
            txtImporteDebitado.TextAlign = HorizontalAlignment.Right
            txtImporteDebitado.Text = Format(Totalizar_Debitos(sNumeroLiquidacion), "##,##0.00")

            DataGridView1.ReadOnly = True
            Button2.Enabled = False
            cmdConfirmarLiquidacion.Visible = True
            cmdCancelarLiquidacion.Visible = True

        Catch ex As Exception
            MsgBox("Error generando la liquidacion", vbCritical)
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
        End Try
    End Sub

    Sub Mostrar_Debitos(Num_liq As Integer)
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        Dim Da As New SqlDataAdapter(Cmd)
        Dim Dt As New DataTable()
        Dim iNumeroDebito As Integer
        Try
            Cmd.CommandText = "SP_OBTENER_DETALLE_DEBITO"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@p_NUMERO_LIQUIDACION", Num_liq)
            Conn.Open()
            Cmd.ExecuteNonQuery()
            Da.Fill(Dt)
            dgvDebitos.DataSource = Dt

            iNumeroDebito = dgvDebitos.Rows(0).Cells(0).Value
            Me.dgvDebitos.Font = New System.Drawing.Font("Times New Roman", 8)
            lblNumeroDebito.Text = Str(iNumeroDebito) + "/12"
            dgvDebitos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDebitos.Columns(0).Visible = False
            dgvDebitos.Columns(1).HeaderText = "Beneficio"
            dgvDebitos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            dgvDebitos.Columns(2).Width = 240
            dgvDebitos.Columns(2).HeaderText = "Nombre"
            dgvDebitos.Columns(3).Width = 220
            dgvDebitos.Columns(3).HeaderText = "Tipo Debito"
            dgvDebitos.Columns(4).HeaderText = "Saldo"
            dgvDebitos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvDebitos.Columns(4).DefaultCellStyle.Format = "##,##0.00"
            dgvDebitos.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 9, FontStyle.Bold)
            dgvDebitos.ReadOnly = True

            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
        Catch ex As Exception
            MsgBox("Error mostrando los debitos", vbCritical)
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
        End Try
    End Sub

    Function Totalizar_Facturacion(lArea As Char, lCuit As String, lPeriodo As String, lSucursal As String, lNumeroFactura As String) As Double
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        Try
            Cmd.CommandText = "SP_TOTALIZAR_FACTURACION"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@p_AREA", Trim(lArea))
            Cmd.Parameters.AddWithValue("@p_CUIT", Trim(lCuit))
            Cmd.Parameters.AddWithValue("@p_PERIODO", Trim(lPeriodo))
            Cmd.Parameters.AddWithValue("@p_SUCURSAL", Trim(lSucursal))
            Cmd.Parameters.AddWithValue("@p_NUMEROFACTURA", Trim(lNumeroFactura))
            Cmd.Parameters.Add("@p_TOTALFACTURADO", SqlDbType.Money)
            Cmd.Parameters("@p_TOTALFACTURADO").Direction = ParameterDirection.Output
            Conn.Open()
            Cmd.ExecuteScalar()
            Dim output_TotalFacturacion As Double = Cmd.Parameters("@p_TOTALFACTURADO").Value
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            Return output_TotalFacturacion
        Catch ex As Exception
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            MsgBox("Error totalizando la facturacion", vbCritical)
            Return 0
        End Try

    End Function

    Function Totalizar_Liquidacion(Num_Liq As Integer) As Double
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand

        Try
            If Num_Liq > 0 Then
                Cmd.CommandText = "SP_TOTALIZAR_LIQUIDACION"
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn
                Cmd.Parameters.AddWithValue("@p_NUMERO_LIQUIDACION", Num_Liq)
                Cmd.Parameters.Add("@p_TOTALLIQUIDADO", SqlDbType.Money)
                Cmd.Parameters("@p_TOTALLIQUIDADO").Direction = ParameterDirection.Output
                Conn.Open()
                Cmd.ExecuteScalar()
                Dim output_TotalLiquidacion As Double = Cmd.Parameters("@p_TOTALLIQUIDADO").Value
                Conn.Close()
                Conn.Dispose()
                Cmd.Dispose()
                Return output_TotalLiquidacion
            Else
                Return 0
            End If
        Catch ex As Exception
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            MsgBox("Error totalizando la liquidacion", vbCritical)
            Return 0
        End Try
    End Function

    Function Totalizar_Debitos(Num_Liq As Integer) As Double
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand

        Try
            If Num_Liq > 0 Then
                Cmd.CommandText = "SP_TOTALIZAR_DEBITO"
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn
                Cmd.Parameters.AddWithValue("@p_NUMERO_LIQUIDACION", Num_Liq)
                Cmd.Parameters.Add("@p_TOTALDEBITADO", SqlDbType.Money)
                Cmd.Parameters("@p_TOTALDEBITADO").Direction = ParameterDirection.Output
                Conn.Open()
                Cmd.ExecuteScalar()

                Dim output_TotalDebito As Double = Cmd.Parameters("@p_TOTALDEBITADO").Value
                Conn.Close()
                Conn.Dispose()
                Cmd.Dispose()
                Return output_TotalDebito
            Else
                Return 0
            End If
        Catch ex As Exception
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            MsgBox("Error totalizando los debitos", vbCritical)
            Return 0
        End Try
    End Function

    Private Sub cmdAceptarPeriodo_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdAceptarPeriodo.Click
        If Validar_Periodo() Then
            lblAutorizacionExistente.Text = "Se encontro una autorizacion valida para el periodo"
            gbxCuit.Visible = True
        Else
            lblAutorizacionExistente.Text = "No existe una autorizacion valida para el periodo"
        End If
    End Sub

    'VALIDA LA SELECCION VALIDA DE UN PERIODO PARA UNA NUEVA LIQUIDACION
    Function Validar_Periodo() As Boolean
        Dim sPeriodo As String

        Try
            If cmbMonth.Text <> "" Then
                If cmbYear.Text <> "" Then

                    Dim Conn As New SqlConnection(gsConexion)
                    Dim Cmd As New SqlCommand

                    sPeriodo = Trim(cmbMonth.Text) & Trim(cmbYear.Text)
                    Cmd.CommandText = "SP_CHEQUEAR_AUTORIZACION_PERIODO"
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.Connection = Conn
                    Cmd.Parameters.AddWithValue("@p_PERIODO", sPeriodo)
                    '   Cmd.Parameters.AddWithValue("@p_AREA", sArea)
                    Cmd.Parameters.Add("@p_VALIDO", SqlDbType.Char, 1)
                    Cmd.Parameters("@p_VALIDO").Direction = ParameterDirection.Output
                    Conn.Open()
                    Cmd.ExecuteScalar()
                    Dim output_Registros As Integer = CInt(Cmd.Parameters("@p_VALIDO").Value)
                    Conn.Close()
                    If output_Registros = 1 Then
                        Return True
                    ElseIf output_Registros = 0 Then
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub btnBuscarCuit_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarCuit.Click
        Try
            Dim sPeriodo As String
            Dim sCuit As String
            Dim Conn As New SqlConnection(gsConexion)
            Dim Cmd As New SqlCommand
            Dim Dr As SqlDataReader

            sPeriodo = Trim(cmbMonth.Text) & Trim(cmbYear.Text)
            sCuit = Limpiar_Cadena(Trim(mebCuit.Text), "-")

            Cmd.CommandText = "SP_OBTENER_FACTURACIONES"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@p_PERIODO", sPeriodo)
            Cmd.Parameters.AddWithValue("@p_CUIT", sCuit)

            Conn.Open()

            Dr = Cmd.ExecuteReader()
            If Dr.Read = Nothing Then
                lblRazonSocialPrestador.Text = "No existen facturas de este prestador para el periodo seleccionado"
            Else
                lblSeleccioneFactura.Visible = True
                cmbFacturas.Visible = True
                Label9.Visible = True
                cmbTipoComprobante.Visible = True
                lblMontoLiquidado.Visible = True
                mebMontoFactura.Visible = True
                Label8.Visible = True
                mebExpediente.Visible = True
                'CARGAMOS EL PRIMER ITEM YA LEIDO
                lblRazonSocialPrestador.Text = Trim(Dr.Item("FAC_RAZONSOCIAL"))
                cmbFacturas.Items.Add(Dr.Item("FAC_NUMEROFACTURA"))
                While Dr.Read = True
                    lblRazonSocialPrestador.Text = Trim(Dr.Item("FAC_RAZONSOCIAL"))
                    cmbFacturas.Items.Add(Dr.Item("FAC_NUMEROFACTURA"))
                End While
                mebCuit.Enabled = False
            End If
            Dr.Close()
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCancelarLiquidacion_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelarLiquidacion.Click
        Dim iNumeroLiquidacion As Integer
        Try
            iNumeroLiquidacion = DataGridView1.Rows(0).Cells(0).Value
            Call Cancelar_Liquidacion(iNumeroLiquidacion)
            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
            Me.Close()
        End Try


    End Sub

    Sub CancelarLiquidacion(iNumLiq As Integer)
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        Dim iNumeroLiquidacion As Integer
        Try
            iNumeroLiquidacion = DataGridView1.Rows(0).Cells(0).Value
            Cmd.CommandText = "SP_ELIMINAR_LIQUIDACION"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@p_NUMEROLIQUIDACION", iNumeroLiquidacion)
            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            MsgBox("Liquidacion Cancelada", vbInformation)
        Catch ex As Exception
            MsgBox("Error actualizando saldos de la autorizacion", vbCritical)
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
        End Try
    End Sub

    Private Sub cmdConfirmarLiquidacion_Click(sender As System.Object, e As System.EventArgs) Handles cmdConfirmarLiquidacion.Click
        Dim sNumeroLiquidacion As Integer
        Try
            cmdConfirmarLiquidacion.Enabled = False
            cmdCancelarLiquidacion.Enabled = False
            sNumeroLiquidacion = DataGridView1.Rows(0).Cells(0).Value
            If Not Actualizar_Autorizacion(sNumeroLiquidacion) Then
                MsgBox("Error Actualizando los saldos de la autorizacion en curso. Se cancela el proceso", vbCritical)
                cmdCancelarLiquidacion.PerformClick()
            Else
                'iImporteLiquidado
                If Asignar_Variables_Impresion() Then
                    'Call Imprimir_Reporte1()
                    'Call Imprimir_Reporte2()
                    'Dim auxImporteLiquidado As Double = CDbl(Me.txtImporteLiquidado.Text)
                    'If auxImporteLiquidado > gsMontoNotaElevacion Then
                    '    Call Imprimir_Reporte3()
                    'Else
                    '    Call Imprimir_Reporte4()
                    'End If


                    Dim sURL As String = urlReport & sNumeroLiquidacion & "&p_NUMERO_LIQUIDACION=" & sNumeroLiquidacion
                    Shell("C:\Program Files\Internet Explorer\iexplore.exe " & sURL, vbMaximizedFocus)


                Else
                    MsgBox("Error Actualizando valores de impresion. Se cancela el proceso", vbCritical)
                    cmdCancelarLiquidacion.PerformClick()
                End If
                MsgBox("Liquidacion cerrada sin errores.", vbInformation)
                Me.Close()
                Me.Dispose()
                Me.DestroyHandle()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Function Asignar_Variables_Impresion() As Boolean
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        'Dim iNumeroLiquidacion As Integer
        Try
            Dim auxString As String = Trim(lblNumeroLiquidacion.Text)
            iNumLiq = CInt(auxString.Substring(0, (auxString.Length) - 3))
            iNumeroLiquidacion = auxString
            iCuit = Trim(mebCuit.Text)
            iRazonSocial = Trim(lblRazonSocialPrestador.Text)
            iPeriodo = ConvertirPeriodo(Trim(cmbMonth.Text) & Trim(cmbYear.Text))
            iTipoFactura = Trim(cmbTipoComprobante.Text)
            iNumeroFactura = Trim(cmbFacturas.Text)
            iModulo = ConvertirModulo(sArea) & " PAMI"
            'iImporteFacturado = CDbl(txtImporteFacturado.Text)
            iImporteFacturado = sTotalFactura
            iImporteFacturado = CDbl(mebMontoFactura.Text)
            auxString = Trim(lblNumeroDebito.Text)
            iNumeroDebito = auxString.Substring(0, (auxString.Length) - 3)
            iImporteDebito = CDbl(txtImporteDebitado.Text)
            iNumeroBafc = ""
            iImporteBafc = 0
            iImporteLiquidado = CDbl(txtImporteLiquidado.Text)
            auxString = Format(iImporteLiquidado, "0.00").ToString
            'auxString = Replace(auxString, ",", ".")
            Dim cadena() As String
            cadena = auxString.Split(",")
            '           iLeyendaImporteLiquidado = Num2Text(cadena(0)) & " PESOS CON " & Num2Text(cadena(1)) & " CENTAVOS"
            iLeyendaImporteLiquidado = ""
            iLiquidadoAlFondo = 0
            iObservaciones = Trim(LCase(txtObservaciones.Text))
            auxString = Now.ToString("dd") & " de " & Now.ToString("MMMM") & " de " & Now.ToString("yyyy")
            iFechaLiquidacion = auxString
            iExpediente = Trim(mebExpediente.Text)
            iReferencia = "Facturacion " & ConvertirModulo(sArea)

            iUsuario = ""

            Cmd.CommandText = "SP_INSERTAR_ANEXOLIQUIDACIONES"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@ANX_NUMLIQ", iNumLiq)
            Cmd.Parameters.AddWithValue("@ANX_NUMEROLIQUIDACION", iNumeroLiquidacion)
            Cmd.Parameters.AddWithValue("@ANX_CUIT", iCuit)
            Cmd.Parameters.AddWithValue("@ANX_RAZONSOCIAL", iRazonSocial)
            Cmd.Parameters.AddWithValue("@ANX_PERIODO", iPeriodo)
            Cmd.Parameters.AddWithValue("@ANX_TIPOFACTURA", iTipoFactura)
            Cmd.Parameters.AddWithValue("@ANX_NUMEROFACTURA", iNumeroFactura)
            Cmd.Parameters.AddWithValue("@ANX_MODULO", iModulo)
            Cmd.Parameters.AddWithValue("@ANX_IMPORTEFACTURADO", iImporteFacturado)
            Cmd.Parameters.AddWithValue("@AUX_NUMERODEBITO", iNumeroDebito)
            Cmd.Parameters.AddWithValue("@ANX_IMPORTEDEBITO", iImporteDebito)
            Cmd.Parameters.AddWithValue("@ANX_NUMEROBAFC", iNumeroBafc)
            Cmd.Parameters.AddWithValue("@ANX_IMPORTEBAFC", iImporteBafc)
            Cmd.Parameters.AddWithValue("@ANX_IMPORTELIQUIDADO", iImporteLiquidado)
            Cmd.Parameters.AddWithValue("@ANX_LEYENDAIMPORTELIQUIDADO", iLeyendaImporteLiquidado)
            Cmd.Parameters.AddWithValue("@ANX_LIQUIDADOALFONDO", iLiquidadoAlFondo)
            Cmd.Parameters.AddWithValue("@ANX_OBSERVACIONES", iObservaciones)
            Cmd.Parameters.AddWithValue("@ANX_FECHALIQUIDACION", iFechaLiquidacion)
            Cmd.Parameters.AddWithValue("@ANX_EXPEDIENTE", iExpediente)
            Cmd.Parameters.AddWithValue("@ANX_REFERENCIA", iReferencia)
            Cmd.Parameters.AddWithValue("@ANX_USUARIO", iUsuario)
            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("Error actualizando datos de liquidacion extensivos", vbCritical)
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            Return False
        End Try
    End Function

    'Sub Imprimir_Reporte1()
    '    Dim iNumeroLiquidacion As String
    '    iNumeroLiquidacion = DataGridView1.Rows(0).Cells(0).Value
    '    Dim frmReporte1 As New frmReporte1
    '    frmReporte1.NumeroLiquidacion = iNumeroLiquidacion
    '    frmReporte1.MdiParent = frmDefault
    '    frmReporte1.WindowState = FormWindowState.Normal
    '    frmReporte1.Show()
    'End Sub

    'Sub Imprimir_Reporte2()
    '    Dim iNumeroLiquidacion As String
    '    iNumeroLiquidacion = DataGridView1.Rows(0).Cells(0).Value
    '    Dim frmReporte2 As New frmReporte2
    '    frmReporte2.NumeroLiquidacion = iNumeroLiquidacion
    '    frmReporte2.MdiParent = frmDefault
    '    frmReporte2.WindowState = FormWindowState.Normal
    '    frmReporte2.Show()
    'End Sub

    'Sub Imprimir_Reporte3()
    '    Dim iNumeroLiquidacion As String
    '    iNumeroLiquidacion = DataGridView1.Rows(0).Cells(0).Value
    '    Dim frmReporte3 As New frmReporte3
    '    frmReporte3.NumeroLiquidacion = iNumeroLiquidacion
    '    frmReporte3.MdiParent = frmDefault
    '    frmReporte3.WindowState = FormWindowState.Normal
    '    frmReporte3.Show()
    'End Sub

    'Sub Imprimir_Reporte4()
    '    Dim iNumeroLiquidacion As String
    '    iNumeroLiquidacion = DataGridView1.Rows(0).Cells(0).Value
    '    Dim frmReporte4 As New frmReporte4
    '    frmReporte4.NumeroLiquidacion = iNumeroLiquidacion
    '    frmReporte4.MdiParent = frmDefault
    '    frmReporte4.WindowState = FormWindowState.Normal
    '    frmReporte4.Show()
    'End Sub

    Function Actualizar_Autorizacion(ByVal iNumLiq As Integer) As Boolean
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        Try
            Cmd.CommandText = "SP_ACTUALIZAR_VALORES_AUTORIZACIONES"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@p_NUMERO_LIQUIDACION", iNumLiq)
            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("Error actualizando saldos de la autorizacion", vbCritical)
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            Return False
        End Try
    End Function

    Function Cancelar_Liquidacion(iNumLiq As Integer) As Boolean
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        Try
            Cmd.CommandText = "SP_ELIMINAR_LIQUIDACION"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@p_NUMEROLIQUIDACION", iNumLiq)
            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("Error cancelando y eliminando la liquidacion", vbCritical)
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            Return False
        End Try
    End Function

    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
        Me.Dispose()
        Me.DestroyHandle()
    End Sub

    Private Sub lblCuit_Click(sender As System.Object, e As System.EventArgs) Handles lblCuit.Click

    End Sub

    Private Sub mebCuit_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mebCuit.MaskInputRejected

    End Sub

    Private Sub cmbFacturas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFacturas.SelectedIndexChanged

        Dim xPeriodo As String = Trim(cmbMonth.Text) & Trim(cmbYear.Text)
        Dim xCuit As String = Limpiar_Cadena(Trim(mebCuit.Text), "-")
        Dim xFactura As String = Trim(cmbFacturas.Text)
        Dim xSucursal As String = Mid(Trim(cmbFacturas.Text), 1, 4)
        'ximportefacturado = Format(Totalizar_Facturacion(sArea, xCuit, xPeriodo, xSucursal, xFactura), "##,##0.00"))
        xImporteFacturado = Totalizar_Facturacion(sArea, xCuit, xPeriodo, xSucursal, xFactura)
    End Sub

    Private Sub mebMontoFactura_TextChanged(sender As System.Object, e As System.EventArgs) Handles mebMontoFactura.TextChanged

    End Sub

End Class