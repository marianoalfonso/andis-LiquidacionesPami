Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Imports System.Configuration




Public Class frmDefault

    Private Sub frmDefault_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Configurar_Formulario()
    End Sub

    Sub Configurar_Formulario()

        Me.Text = gsSistema + " - " + UCase(gsArea)
    End Sub

    Private Sub ConectarSQLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim miConexion As New ConexionSQL

        Try
            miConexion.Conectar()
            MsgBox(miConexion.Estado)

            miConexion.Cerrar()
            MsgBox(miConexion.Estado)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ImportarArchivosDiscapacidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarArchivosDiscapacidadToolStripMenuItem.Click
        Dim frmImportacion As New frmImportacion
        frmImportacion.MdiParent = Me
        frmImportacion.WindowState = FormWindowState.Maximized
        frmImportacion.Area = UCase(Mid(Login.cmbArea.Text, 1, 1))
        frmImportacion.Show()
    End Sub


    Private Sub NuevaLiquidacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaLiquidacionToolStripMenuItem.Click
        Dim frmLiquidacion As New frmLiquidacion
        frmLiquidacion.MdiParent = Me
        frmLiquidacion.WindowState = FormWindowState.Normal
        frmLiquidacion.Area = UCase(gsArea.Substring(0, 1))
        'frmLiquidacion.Area = "D" 'CAMBIAR POR PARAMETRIZACION
        frmLiquidacion.Show()

    End Sub


    Private Sub KrustyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Try
            Dim Conn As New SqlConnection(gsConexion)
            Conn.Open()

            Conn.Close()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AnalizarAutorizacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnalizarAutorizacionesToolStripMenuItem.Click
        Try
            Dim frmAnalizarAutorizacion As New frmAnalizarAutorizacion
            frmAnalizarAutorizacion.MdiParent = Me
            frmAnalizarAutorizacion.Show()
        Catch ex As Exception
            MsgBox(Err.Description)
            Me.Close()
        End Try
    End Sub

    Private Sub EliminarLiquidacionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarLiquidacionToolStripMenuItem.Click
        Try

            Dim frmEliminarLiquidacion As New frmEliminarLiquidacion
            frmEliminarLiquidacion.MdiParent = Me
            frmEliminarLiquidacion.Show()

        Catch ex As Exception
            MsgBox(Err.Description)
            Me.Close()
        End Try
    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VersionToolStripMenuItem.Click
        Try
            Dim frmAboutBox As New frmAboutBox
            frmAboutBox.MdiParent = Me
            frmAboutBox.Show()
        Catch ex As Exception
            MsgBox(Err.Description)
            Me.Close()
        End Try
    End Sub
End Class