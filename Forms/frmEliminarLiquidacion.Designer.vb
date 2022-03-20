<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarLiquidacion
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
        Me.mebCuit = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscarCuit = New System.Windows.Forms.Button()
        Me.lblCuit = New System.Windows.Forms.Label()
        Me.dgvLiquidaciones = New System.Windows.Forms.DataGridView()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdEliminarLiquidacion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chkDebitos = New System.Windows.Forms.CheckBox()
        Me.chkLiquidacion = New System.Windows.Forms.CheckBox()
        Me.btnReimprimir = New System.Windows.Forms.Button()
        CType(Me.dgvLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mebCuit
        '
        Me.mebCuit.Location = New System.Drawing.Point(62, 23)
        Me.mebCuit.Mask = "00-00000000-0"
        Me.mebCuit.Name = "mebCuit"
        Me.mebCuit.Size = New System.Drawing.Size(107, 20)
        Me.mebCuit.TabIndex = 6
        '
        'btnBuscarCuit
        '
        Me.btnBuscarCuit.Location = New System.Drawing.Point(178, 21)
        Me.btnBuscarCuit.Name = "btnBuscarCuit"
        Me.btnBuscarCuit.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCuit.TabIndex = 5
        Me.btnBuscarCuit.Text = "Aceptar"
        Me.btnBuscarCuit.UseVisualStyleBackColor = True
        '
        'lblCuit
        '
        Me.lblCuit.AutoSize = True
        Me.lblCuit.Location = New System.Drawing.Point(16, 28)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(25, 13)
        Me.lblCuit.TabIndex = 4
        Me.lblCuit.Text = "Cuit"
        '
        'dgvLiquidaciones
        '
        Me.dgvLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLiquidaciones.Location = New System.Drawing.Point(12, 50)
        Me.dgvLiquidaciones.Name = "dgvLiquidaciones"
        Me.dgvLiquidaciones.Size = New System.Drawing.Size(688, 252)
        Me.dgvLiquidaciones.TabIndex = 8
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(625, 342)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrar.TabIndex = 9
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdEliminarLiquidacion
        '
        Me.cmdEliminarLiquidacion.Location = New System.Drawing.Point(12, 309)
        Me.cmdEliminarLiquidacion.Name = "cmdEliminarLiquidacion"
        Me.cmdEliminarLiquidacion.Size = New System.Drawing.Size(158, 23)
        Me.cmdEliminarLiquidacion.TabIndex = 10
        Me.cmdEliminarLiquidacion.Text = "Eliminar Liquidacion"
        Me.cmdEliminarLiquidacion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Reimprimir Liquidacion"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.chkDebitos)
        Me.GroupBox1.Controls.Add(Me.chkLiquidacion)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 307)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 55)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Ok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chkDebitos
        '
        Me.chkDebitos.AutoSize = True
        Me.chkDebitos.Location = New System.Drawing.Point(7, 36)
        Me.chkDebitos.Name = "chkDebitos"
        Me.chkDebitos.Size = New System.Drawing.Size(62, 17)
        Me.chkDebitos.TabIndex = 1
        Me.chkDebitos.Text = "Debitos"
        Me.chkDebitos.UseVisualStyleBackColor = True
        '
        'chkLiquidacion
        '
        Me.chkLiquidacion.AutoSize = True
        Me.chkLiquidacion.Location = New System.Drawing.Point(7, 12)
        Me.chkLiquidacion.Name = "chkLiquidacion"
        Me.chkLiquidacion.Size = New System.Drawing.Size(80, 17)
        Me.chkLiquidacion.TabIndex = 0
        Me.chkLiquidacion.Text = "Liquidacion"
        Me.chkLiquidacion.UseVisualStyleBackColor = True
        '
        'btnReimprimir
        '
        Me.btnReimprimir.Location = New System.Drawing.Point(178, 309)
        Me.btnReimprimir.Name = "btnReimprimir"
        Me.btnReimprimir.Size = New System.Drawing.Size(159, 23)
        Me.btnReimprimir.TabIndex = 13
        Me.btnReimprimir.Text = "Reimprimir Liquidacion"
        Me.btnReimprimir.UseVisualStyleBackColor = True
        '
        'frmEliminarLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 377)
        Me.Controls.Add(Me.btnReimprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdEliminarLiquidacion)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.dgvLiquidaciones)
        Me.Controls.Add(Me.mebCuit)
        Me.Controls.Add(Me.btnBuscarCuit)
        Me.Controls.Add(Me.lblCuit)
        Me.Name = "frmEliminarLiquidacion"
        Me.Text = "frmEliminarLiquidacion"
        CType(Me.dgvLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mebCuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnBuscarCuit As System.Windows.Forms.Button
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents dgvLiquidaciones As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminarLiquidacion As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chkDebitos As System.Windows.Forms.CheckBox
    Friend WithEvents chkLiquidacion As System.Windows.Forms.CheckBox
    Friend WithEvents btnReimprimir As System.Windows.Forms.Button
End Class
