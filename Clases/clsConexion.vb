Imports System.Data.SqlClient

Public Class ConexionSQL
    Private objConn As New SqlConnection
    Dim Conn As New SqlConnection(gsConexion)

    Public ReadOnly Property Estado() As Integer
        Get
            Return objConn.State
        End Get
    End Property

    Public Sub Conectar()
        '       objConn = New SqlConnection(strConn)
        objConn.Open()
    End Sub

    Public Sub Cerrar()
        objConn.Close()
    End Sub

End Class
