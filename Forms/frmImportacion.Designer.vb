<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportacion
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
        Me.brnCerrar = New System.Windows.Forms.Button()
        Me.lvArchivos = New System.Windows.Forms.ListView()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnSeleccionarTodos = New System.Windows.Forms.Button()
        Me.lblArchivosPendientes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtArchivosAImportar = New System.Windows.Forms.TextBox()
        Me.txtArchivosImportados = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombreArchivo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'brnCerrar
        '
        Me.brnCerrar.Location = New System.Drawing.Point(642, 378)
        Me.brnCerrar.Name = "brnCerrar"
        Me.brnCerrar.Size = New System.Drawing.Size(78, 26)
        Me.brnCerrar.TabIndex = 0
        Me.brnCerrar.Text = "Cerrar"
        Me.brnCerrar.UseVisualStyleBackColor = True
        '
        'lvArchivos
        '
        Me.lvArchivos.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvArchivos.CheckBoxes = True
        Me.lvArchivos.GridLines = True
        Me.lvArchivos.HotTracking = True
        Me.lvArchivos.HoverSelection = True
        Me.lvArchivos.Location = New System.Drawing.Point(35, 37)
        Me.lvArchivos.Name = "lvArchivos"
        Me.lvArchivos.Size = New System.Drawing.Size(712, 304)
        Me.lvArchivos.TabIndex = 2
        Me.lvArchivos.UseCompatibleStateImageBehavior = False
        Me.lvArchivos.View = System.Windows.Forms.View.List
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(556, 378)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(80, 26)
        Me.btnImportar.TabIndex = 4
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnSeleccionarTodos
        '
        Me.btnSeleccionarTodos.Location = New System.Drawing.Point(46, 353)
        Me.btnSeleccionarTodos.Name = "btnSeleccionarTodos"
        Me.btnSeleccionarTodos.Size = New System.Drawing.Size(118, 33)
        Me.btnSeleccionarTodos.TabIndex = 5
        Me.btnSeleccionarTodos.Tag = "marcados"
        Me.btnSeleccionarTodos.Text = "Seleccionar Todos"
        Me.btnSeleccionarTodos.UseVisualStyleBackColor = True
        '
        'lblArchivosPendientes
        '
        Me.lblArchivosPendientes.AutoSize = True
        Me.lblArchivosPendientes.Location = New System.Drawing.Point(206, 353)
        Me.lblArchivosPendientes.Name = "lblArchivosPendientes"
        Me.lblArchivosPendientes.Size = New System.Drawing.Size(0, 13)
        Me.lblArchivosPendientes.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "A importar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(409, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Importados:"
        '
        'txtArchivosAImportar
        '
        Me.txtArchivosAImportar.Location = New System.Drawing.Point(473, 346)
        Me.txtArchivosAImportar.Name = "txtArchivosAImportar"
        Me.txtArchivosAImportar.Size = New System.Drawing.Size(74, 20)
        Me.txtArchivosAImportar.TabIndex = 9
        '
        'txtArchivosImportados
        '
        Me.txtArchivosImportados.Location = New System.Drawing.Point(473, 369)
        Me.txtArchivosImportados.Name = "txtArchivosImportados"
        Me.txtArchivosImportados.Size = New System.Drawing.Size(74, 20)
        Me.txtArchivosImportados.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Archivo en Proceso:"
        '
        'lblNombreArchivo
        '
        Me.lblNombreArchivo.AutoSize = True
        Me.lblNombreArchivo.Location = New System.Drawing.Point(152, 12)
        Me.lblNombreArchivo.Name = "lblNombreArchivo"
        Me.lblNombreArchivo.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreArchivo.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Eliminar Importaciones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmImportacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNombreArchivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtArchivosImportados)
        Me.Controls.Add(Me.txtArchivosAImportar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblArchivosPendientes)
        Me.Controls.Add(Me.btnSeleccionarTodos)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.lvArchivos)
        Me.Controls.Add(Me.brnCerrar)
        Me.Name = "frmImportacion"
        Me.Text = "frmImportacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents brnCerrar As System.Windows.Forms.Button
    Friend WithEvents lvArchivos As System.Windows.Forms.ListView
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionarTodos As System.Windows.Forms.Button
    Friend WithEvents lblArchivosPendientes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtArchivosAImportar As System.Windows.Forms.TextBox
    Friend WithEvents txtArchivosImportados As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNombreArchivo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
