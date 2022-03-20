Imports System.Data.SqlClient

Public Class clsLiquidacion
    Private sArea As Char
    Private sCuit As String
    Private sRazonSocial As String
    Private sPeriodo As String
    Private sSucursal As String
    Private sFactura As String

    Public Property Area() As Char
        Get
            Return sArea
        End Get
        Set(value As Char)
            If value = "" Then
                sArea = value
            End If
        End Set
    End Property

    Public Property Cuit() As String
        Get
            Return sCuit
        End Get
        Set(ByVal value As String)
            If value <> "" Then
                sCuit = value
            End If
        End Set
    End Property

    Public Property RazonSocial() As String
        Get
            Return sRazonSocial
        End Get
        Set(ByVal value As String)
            If value <> "" Then
                sRazonSocial = value
            End If
        End Set
    End Property

    Public Property Periodo() As String
        Get
            Return sPeriodo
        End Get
        Set(ByVal value As String)
            If value <> "" Then
                sPeriodo = value
            End If
        End Set
    End Property

    Public Property Sucursal() As String
        Get
            Return sSucursal
        End Get
        Set(ByVal value As String)
            If value <> "" Then
                sSucursal = value
            End If
        End Set
    End Property

    Public Property Factura() As String
        Get
            Return sFactura
        End Get
        Set(ByVal value As String)
            If value <> "" Then
                sFactura = value
            End If
        End Set
    End Property

    Public Function Facturar() As DataTable
        Dim Conn As New SqlConnection(gsConexion)
        Dim Cmd As New SqlCommand
        Dim Da As New SqlDataAdapter(Cmd)

        Try
            Cmd.CommandText = "SP_GENERAR_LIQUIDACION"
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = Conn
            Cmd.Parameters.AddWithValue("@SUCURSAL", Trim(sSucursal))
            Cmd.Parameters.AddWithValue("@AREA", Trim(sArea))
            Cmd.Parameters.AddWithValue("@CUIT", Trim(sCuit))
            Cmd.Parameters.AddWithValue("@PERIODO", Trim(sPeriodo))
            Conn.Open()
            'Cmd.ExecuteReader()






        Catch ex As Exception

        End Try





    End Function





End Class
