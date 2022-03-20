Imports System.Data.SqlClient

Public Class frmEliminarLiquidacion
    'testing
    Private Sub btnBuscarCuit_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarCuit.Click
        Try
            Dim sCuit As String
            Dim Conn As New SqlConnection(gsConexion)
            Dim Cmd As New SqlCommand
            Dim Da As New SqlDataAdapter(Cmd)
            Dim Dt As New DataTable()
            sCuit = Limpiar_Cadena(Trim(mebCuit.Text), "-")
            Cmd.CommandText = "SP_LISTAR_LIQUIDACIONES_PRESTADOR"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@p_CUITPRESTADOR", sCuit)
            Conn.Open()
            Da.Fill(Dt)
            dgvLiquidaciones.DataSource = Dt
            Me.dgvLiquidaciones.Font = New System.Drawing.Font("Times New Roman", 10)
            dgvLiquidaciones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvLiquidaciones.Columns(0).Width = 300
            dgvLiquidaciones.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            dgvLiquidaciones.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            dgvLiquidaciones.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
        Catch ex As Exception
            MsgBox(Err.Description)

        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
        Me.Dispose()
        Me.DestroyHandle()
    End Sub

    Private Sub cmdEliminarLiquidacion_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminarLiquidacion.Click

        Dim Password As String
        Password = InputBox("Ingrese Password:", vbCritical)
        If Password <> "kitesurf" Then
            MsgBox("Error. No tiene autorizacion para eliminar facturaciones", vbCritical)
            Exit Sub
        End If

        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        Dim iNumLiq As Integer
        Try
            iNumLiq = dgvLiquidaciones.Rows(dgvLiquidaciones.CurrentRow.Index).Cells(1).Value
            Cmd.CommandText = "SP_ELIMINAR_LIQUIDACION_IMPORTES"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@p_NUMEROLIQUIDACION", iNumLiq)
            Conn.Open()
            Cmd.ExecuteNonQuery()
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
            btnBuscarCuit.PerformClick()
            MsgBox("Liquidacion eliminada", vbInformation)
        Catch ex As Exception
            If Err.Number = 91 Then
                Err.Clear()
            Else
                MsgBox("Error eliminando la autorizacion", vbCritical)
            End If
            Conn.Close()
            Conn.Dispose()
            Cmd.Dispose()
        End Try
    End Sub

    Private Sub frmEliminarLiquidacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = 10
        GroupBox1.Visible = False
    End Sub





    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'GroupBox1.Visible = True
        'chkLiquidacion.Checked = False
        'chkDebitos.Checked = False
    End Sub


    Private Sub btnReimprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnReimprimir.Click
        Dim sNumeroLiquidacion As Long
        'Dim auxImporteLiquidado As Double

        Try
            sNumeroLiquidacion = dgvLiquidaciones.Rows(dgvLiquidaciones.CurrentRow.Index).Cells(1).Value
            'auxImporteLiquidado = Totalizar_Liquidacion(iNumeroLiquidacion)

            Dim sURL As String = urlReport & sNumeroLiquidacion & "&p_NUMERO_LIQUIDACION=" & sNumeroLiquidacion
            Shell("C:\Program Files\Internet Explorer\iexplore.exe " & sURL, vbMaximizedFocus)

            ' '' '' ''VERIFICAR PORQUE GENERA ERROR (NO BORRAR)
            ' ''Dim sClose As Boolean
            ' ''sClose = bImprimir_Reporte(iNumeroLiquidacion, "C:\Users\22925061\Desktop\x\reporte.pdf")
            ' ''If Not sClose Then
            ' ''    MsgBox("error imprimiendo la liquidacion", vbCritical)
            ' ''End If
            ' '' '' ''VERIFICAR PORQUE GENERA ERROR (NO BORRAR)

        Catch ex As Exception
            MsgBox("error imprimiendo la liquidacion", vbCritical)
        End Try

    End Sub



    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '    Dim iNumLiq As Long

    '    If chkDebitos.Checked = True Then
    '        Call Imprimir_Reporte2()
    '    End If
    '    If chkLiquidacion.Checked = True Then
    '        Call Imprimir_Reporte1()
    '        iNumLiq = dgvLiquidaciones.Rows(dgvLiquidaciones.CurrentRow.Index).Cells(1).Value
    '        Dim auxImporteLiquidado As Double = Totalizar_Liquidacion(iNumLiq)
    '        If auxImporteLiquidado > gsMontoNotaElevacion Then
    '            Call Imprimir_Reporte3()
    '        Else
    '            Call Imprimir_Reporte4()
    '        End If
    '    End If

    'End Sub

    'Sub Imprimir_Reporte1()
    '    Dim iNumeroLiquidacion As String
    '    iNumeroLiquidacion = dgvLiquidaciones.Rows(dgvLiquidaciones.CurrentRow.Index).Cells(1).Value
    '    Dim frmReporte1 As New frmReporte1
    '    frmReporte1.NumeroLiquidacion = iNumeroLiquidacion
    '    frmReporte1.MdiParent = frmDefault
    '    frmReporte1.WindowState = FormWindowState.Normal
    '    frmReporte1.Show()
    'End Sub

    'Sub Imprimir_Reporte2()
    '    Dim iNumeroLiquidacion As String
    '    iNumeroLiquidacion = dgvLiquidaciones.Rows(dgvLiquidaciones.CurrentRow.Index).Cells(1).Value
    '    Dim frmReporte2 As New frmReporte2
    '    frmReporte2.NumeroLiquidacion = iNumeroLiquidacion
    '    frmReporte2.MdiParent = frmDefault
    '    frmReporte2.WindowState = FormWindowState.Normal
    '    frmReporte2.Show()
    'End Sub

    'Sub Imprimir_Reporte3()
    '    Dim iNumeroLiquidacion As String
    '    iNumeroLiquidacion = dgvLiquidaciones.Rows(dgvLiquidaciones.CurrentRow.Index).Cells(1).Value
    '    Dim frmReporte3 As New frmReporte3
    '    frmReporte3.NumeroLiquidacion = iNumeroLiquidacion
    '    frmReporte3.MdiParent = frmDefault
    '    frmReporte3.WindowState = FormWindowState.Normal
    '    frmReporte3.Show()
    'End Sub

    'Sub Imprimir_Reporte4()
    '    Dim iNumeroLiquidacion As String
    '    iNumeroLiquidacion = dgvLiquidaciones.Rows(dgvLiquidaciones.CurrentRow.Index).Cells(1).Value
    '    Dim frmReporte4 As New frmReporte4
    '    frmReporte4.NumeroLiquidacion = iNumeroLiquidacion
    '    frmReporte4.MdiParent = frmDefault
    '    frmReporte4.WindowState = FormWindowState.Normal
    '    frmReporte4.Show()
    'End Sub

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



End Class