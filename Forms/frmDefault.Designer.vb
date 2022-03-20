<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefault
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImportacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarArchivosDiscapacidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaLiquidacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalizarAutorizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarLiquidacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportacionToolStripMenuItem, Me.LiquidacionToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.VersionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImportacionToolStripMenuItem
        '
        Me.ImportacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarArchivosDiscapacidadToolStripMenuItem})
        Me.ImportacionToolStripMenuItem.Name = "ImportacionToolStripMenuItem"
        Me.ImportacionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ImportacionToolStripMenuItem.Text = "Configuracion"
        '
        'ImportarArchivosDiscapacidadToolStripMenuItem
        '
        Me.ImportarArchivosDiscapacidadToolStripMenuItem.Name = "ImportarArchivosDiscapacidadToolStripMenuItem"
        Me.ImportarArchivosDiscapacidadToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.ImportarArchivosDiscapacidadToolStripMenuItem.Text = "Importar archivos pendientes"
        '
        'LiquidacionToolStripMenuItem
        '
        Me.LiquidacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaLiquidacionToolStripMenuItem})
        Me.LiquidacionToolStripMenuItem.Name = "LiquidacionToolStripMenuItem"
        Me.LiquidacionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.LiquidacionToolStripMenuItem.Text = "Liquidacion"
        '
        'NuevaLiquidacionToolStripMenuItem
        '
        Me.NuevaLiquidacionToolStripMenuItem.Name = "NuevaLiquidacionToolStripMenuItem"
        Me.NuevaLiquidacionToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NuevaLiquidacionToolStripMenuItem.Text = "Nueva Liquidacion"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalizarAutorizacionesToolStripMenuItem, Me.EliminarLiquidacionToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'AnalizarAutorizacionesToolStripMenuItem
        '
        Me.AnalizarAutorizacionesToolStripMenuItem.Enabled = False
        Me.AnalizarAutorizacionesToolStripMenuItem.Name = "AnalizarAutorizacionesToolStripMenuItem"
        Me.AnalizarAutorizacionesToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.AnalizarAutorizacionesToolStripMenuItem.Text = "Analizar Autorizaciones"
        '
        'EliminarLiquidacionToolStripMenuItem
        '
        Me.EliminarLiquidacionToolStripMenuItem.Name = "EliminarLiquidacionToolStripMenuItem"
        Me.EliminarLiquidacionToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.EliminarLiquidacionToolStripMenuItem.Text = "Eliminar/Reimprimir Liquidacion"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frmDefault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(730, 312)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDefault"
        Me.Text = "Programa Federal Incluir Salud - Liquidacion PNC Pami"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImportacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarArchivosDiscapacidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiquidacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaLiquidacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalizarAutorizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarLiquidacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
