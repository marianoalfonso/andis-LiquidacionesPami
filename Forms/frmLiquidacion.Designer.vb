<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacion
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAutorizacionExistente = New System.Windows.Forms.Label()
        Me.cmdAceptarPeriodo = New System.Windows.Forms.Button()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.gbxCuit = New System.Windows.Forms.GroupBox()
        Me.mebMontoFactura = New System.Windows.Forms.TextBox()
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mebExpediente = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMontoLiquidado = New System.Windows.Forms.Label()
        Me.lblSeleccioneFactura = New System.Windows.Forms.Label()
        Me.lblRazonSocialPrestador = New System.Windows.Forms.Label()
        Me.cmbFacturas = New System.Windows.Forms.ComboBox()
        Me.mebCuit = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscarCuit = New System.Windows.Forms.Button()
        Me.lblCuit = New System.Windows.Forms.Label()
        Me.dgvDebitos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtImporteDebitado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtImporteLiquidado = New System.Windows.Forms.TextBox()
        Me.txtImporteFacturado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumeroDebito = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNumeroLiquidacion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdConfirmarLiquidacion = New System.Windows.Forms.Button()
        Me.cmdCancelarLiquidacion = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxCuit.SuspendLayout()
        CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(549, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Liquidar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 225)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(982, 218)
        Me.DataGridView1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAutorizacionExistente)
        Me.GroupBox1.Controls.Add(Me.cmdAceptarPeriodo)
        Me.GroupBox1.Controls.Add(Me.lblPeriodo)
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Controls.Add(Me.cmbMonth)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 52)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'lblAutorizacionExistente
        '
        Me.lblAutorizacionExistente.AutoSize = True
        Me.lblAutorizacionExistente.Location = New System.Drawing.Point(282, 24)
        Me.lblAutorizacionExistente.Name = "lblAutorizacionExistente"
        Me.lblAutorizacionExistente.Size = New System.Drawing.Size(0, 13)
        Me.lblAutorizacionExistente.TabIndex = 14
        '
        'cmdAceptarPeriodo
        '
        Me.cmdAceptarPeriodo.Location = New System.Drawing.Point(200, 17)
        Me.cmdAceptarPeriodo.Name = "cmdAceptarPeriodo"
        Me.cmdAceptarPeriodo.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptarPeriodo.TabIndex = 13
        Me.cmdAceptarPeriodo.Text = "Aceptar"
        Me.cmdAceptarPeriodo.UseVisualStyleBackColor = True
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(36, 22)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
        Me.lblPeriodo.TabIndex = 12
        Me.lblPeriodo.Text = "Periodo"
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(128, 19)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(64, 21)
        Me.cmbYear.TabIndex = 11
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(85, 19)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(39, 21)
        Me.cmbMonth.TabIndex = 10
        '
        'gbxCuit
        '
        Me.gbxCuit.Controls.Add(Me.mebMontoFactura)
        Me.gbxCuit.Controls.Add(Me.cmbTipoComprobante)
        Me.gbxCuit.Controls.Add(Me.Label9)
        Me.gbxCuit.Controls.Add(Me.mebExpediente)
        Me.gbxCuit.Controls.Add(Me.Label8)
        Me.gbxCuit.Controls.Add(Me.lblMontoLiquidado)
        Me.gbxCuit.Controls.Add(Me.lblSeleccioneFactura)
        Me.gbxCuit.Controls.Add(Me.lblRazonSocialPrestador)
        Me.gbxCuit.Controls.Add(Me.cmbFacturas)
        Me.gbxCuit.Controls.Add(Me.mebCuit)
        Me.gbxCuit.Controls.Add(Me.btnBuscarCuit)
        Me.gbxCuit.Controls.Add(Me.lblCuit)
        Me.gbxCuit.Controls.Add(Me.Button2)
        Me.gbxCuit.Location = New System.Drawing.Point(14, 58)
        Me.gbxCuit.Name = "gbxCuit"
        Me.gbxCuit.Size = New System.Drawing.Size(645, 142)
        Me.gbxCuit.TabIndex = 11
        Me.gbxCuit.TabStop = False
        Me.gbxCuit.Visible = False
        '
        'mebMontoFactura
        '
        Me.mebMontoFactura.Location = New System.Drawing.Point(163, 88)
        Me.mebMontoFactura.Name = "mebMontoFactura"
        Me.mebMontoFactura.Size = New System.Drawing.Size(100, 20)
        Me.mebMontoFactura.TabIndex = 13
        Me.mebMontoFactura.Visible = False
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoComprobante.FormattingEnabled = True
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(163, 66)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(167, 21)
        Me.cmbTipoComprobante.TabIndex = 12
        Me.cmbTipoComprobante.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tipo Comprobante"
        Me.Label9.Visible = False
        '
        'mebExpediente
        '
        Me.mebExpediente.Location = New System.Drawing.Point(163, 110)
        Me.mebExpediente.Mask = "00000-0000000000-00-0"
        Me.mebExpediente.Name = "mebExpediente"
        Me.mebExpediente.Size = New System.Drawing.Size(136, 20)
        Me.mebExpediente.TabIndex = 10
        Me.mebExpediente.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(96, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Expediente"
        Me.Label8.Visible = False
        '
        'lblMontoLiquidado
        '
        Me.lblMontoLiquidado.AutoSize = True
        Me.lblMontoLiquidado.Location = New System.Drawing.Point(31, 91)
        Me.lblMontoLiquidado.Name = "lblMontoLiquidado"
        Me.lblMontoLiquidado.Size = New System.Drawing.Size(125, 13)
        Me.lblMontoLiquidado.TabIndex = 7
        Me.lblMontoLiquidado.Text = "Ingrese monto Facturado"
        Me.lblMontoLiquidado.Visible = False
        '
        'lblSeleccioneFactura
        '
        Me.lblSeleccioneFactura.AutoSize = True
        Me.lblSeleccioneFactura.Location = New System.Drawing.Point(39, 45)
        Me.lblSeleccioneFactura.Name = "lblSeleccioneFactura"
        Me.lblSeleccioneFactura.Size = New System.Drawing.Size(117, 13)
        Me.lblSeleccioneFactura.TabIndex = 6
        Me.lblSeleccioneFactura.Text = "Seleccione una factura"
        Me.lblSeleccioneFactura.Visible = False
        '
        'lblRazonSocialPrestador
        '
        Me.lblRazonSocialPrestador.AutoSize = True
        Me.lblRazonSocialPrestador.Location = New System.Drawing.Point(282, 18)
        Me.lblRazonSocialPrestador.Name = "lblRazonSocialPrestador"
        Me.lblRazonSocialPrestador.Size = New System.Drawing.Size(0, 13)
        Me.lblRazonSocialPrestador.TabIndex = 5
        '
        'cmbFacturas
        '
        Me.cmbFacturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFacturas.FormattingEnabled = True
        Me.cmbFacturas.Location = New System.Drawing.Point(163, 42)
        Me.cmbFacturas.Name = "cmbFacturas"
        Me.cmbFacturas.Size = New System.Drawing.Size(167, 21)
        Me.cmbFacturas.TabIndex = 4
        Me.cmbFacturas.Visible = False
        '
        'mebCuit
        '
        Me.mebCuit.Location = New System.Drawing.Point(84, 15)
        Me.mebCuit.Mask = "00-00000000-0"
        Me.mebCuit.Name = "mebCuit"
        Me.mebCuit.Size = New System.Drawing.Size(107, 20)
        Me.mebCuit.TabIndex = 3
        '
        'btnBuscarCuit
        '
        Me.btnBuscarCuit.Location = New System.Drawing.Point(200, 13)
        Me.btnBuscarCuit.Name = "btnBuscarCuit"
        Me.btnBuscarCuit.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCuit.TabIndex = 2
        Me.btnBuscarCuit.Text = "Aceptar"
        Me.btnBuscarCuit.UseVisualStyleBackColor = True
        '
        'lblCuit
        '
        Me.lblCuit.AutoSize = True
        Me.lblCuit.Location = New System.Drawing.Point(38, 20)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(25, 13)
        Me.lblCuit.TabIndex = 0
        Me.lblCuit.Text = "Cuit"
        '
        'dgvDebitos
        '
        Me.dgvDebitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDebitos.Location = New System.Drawing.Point(13, 517)
        Me.dgvDebitos.Name = "dgvDebitos"
        Me.dgvDebitos.Size = New System.Drawing.Size(756, 123)
        Me.dgvDebitos.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 501)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "DETALLE DEBITOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "DETALLE LIQUIDACION"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtImporteDebitado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtImporteLiquidado)
        Me.GroupBox2.Controls.Add(Me.txtImporteFacturado)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblNumeroDebito)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblNumeroLiquidacion)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(665, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(268, 195)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACION GENERAL"
        '
        'txtImporteDebitado
        '
        Me.txtImporteDebitado.Location = New System.Drawing.Point(151, 129)
        Me.txtImporteDebitado.Name = "txtImporteDebitado"
        Me.txtImporteDebitado.Size = New System.Drawing.Size(100, 20)
        Me.txtImporteDebitado.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Importe Debitado"
        '
        'txtImporteLiquidado
        '
        Me.txtImporteLiquidado.Location = New System.Drawing.Point(151, 106)
        Me.txtImporteLiquidado.Name = "txtImporteLiquidado"
        Me.txtImporteLiquidado.Size = New System.Drawing.Size(100, 20)
        Me.txtImporteLiquidado.TabIndex = 21
        '
        'txtImporteFacturado
        '
        Me.txtImporteFacturado.Location = New System.Drawing.Point(151, 82)
        Me.txtImporteFacturado.Name = "txtImporteFacturado"
        Me.txtImporteFacturado.Size = New System.Drawing.Size(100, 20)
        Me.txtImporteFacturado.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Importe Liquidado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Importe Facturado"
        '
        'lblNumeroDebito
        '
        Me.lblNumeroDebito.AutoSize = True
        Me.lblNumeroDebito.Location = New System.Drawing.Point(155, 66)
        Me.lblNumeroDebito.Name = "lblNumeroDebito"
        Me.lblNumeroDebito.Size = New System.Drawing.Size(0, 13)
        Me.lblNumeroDebito.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Numero de Debito"
        '
        'lblNumeroLiquidacion
        '
        Me.lblNumeroLiquidacion.AutoSize = True
        Me.lblNumeroLiquidacion.Location = New System.Drawing.Point(155, 41)
        Me.lblNumeroLiquidacion.Name = "lblNumeroLiquidacion"
        Me.lblNumeroLiquidacion.Size = New System.Drawing.Size(0, 13)
        Me.lblNumeroLiquidacion.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Numero de Liquidacion"
        '
        'cmdConfirmarLiquidacion
        '
        Me.cmdConfirmarLiquidacion.Location = New System.Drawing.Point(795, 525)
        Me.cmdConfirmarLiquidacion.Name = "cmdConfirmarLiquidacion"
        Me.cmdConfirmarLiquidacion.Size = New System.Drawing.Size(121, 23)
        Me.cmdConfirmarLiquidacion.TabIndex = 20
        Me.cmdConfirmarLiquidacion.Text = "Confirmar Liquidacion"
        Me.cmdConfirmarLiquidacion.UseVisualStyleBackColor = True
        Me.cmdConfirmarLiquidacion.Visible = False
        '
        'cmdCancelarLiquidacion
        '
        Me.cmdCancelarLiquidacion.Location = New System.Drawing.Point(795, 555)
        Me.cmdCancelarLiquidacion.Name = "cmdCancelarLiquidacion"
        Me.cmdCancelarLiquidacion.Size = New System.Drawing.Size(121, 23)
        Me.cmdCancelarLiquidacion.TabIndex = 21
        Me.cmdCancelarLiquidacion.Text = "Cancelar Liquidacion"
        Me.cmdCancelarLiquidacion.UseVisualStyleBackColor = True
        Me.cmdCancelarLiquidacion.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(131, 451)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(848, 39)
        Me.txtObservaciones.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 454)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Observaciones"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(919, 613)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrar.TabIndex = 27
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'frmLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 648)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.cmdCancelarLiquidacion)
        Me.Controls.Add(Me.cmdConfirmarLiquidacion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDebitos)
        Me.Controls.Add(Me.gbxCuit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmLiquidacion"
        Me.Text = "frmLiquidacion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxCuit.ResumeLayout(False)
        Me.gbxCuit.PerformLayout()
        CType(Me.dgvDebitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAutorizacionExistente As System.Windows.Forms.Label
    Friend WithEvents cmdAceptarPeriodo As System.Windows.Forms.Button
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents gbxCuit As System.Windows.Forms.GroupBox
    Friend WithEvents mebCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnBuscarCuit As System.Windows.Forms.Button
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents cmbFacturas As System.Windows.Forms.ComboBox
    Friend WithEvents lblRazonSocialPrestador As System.Windows.Forms.Label
    Friend WithEvents lblSeleccioneFactura As System.Windows.Forms.Label
    Friend WithEvents dgvDebitos As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumeroDebito As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNumeroLiquidacion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporteLiquidado As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteFacturado As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmarLiquidacion As System.Windows.Forms.Button
    Friend WithEvents cmdCancelarLiquidacion As System.Windows.Forms.Button
    Friend WithEvents lblMontoLiquidado As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtImporteDebitado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mebExpediente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mebMontoFactura As System.Windows.Forms.TextBox
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
End Class
