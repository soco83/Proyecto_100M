<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CerrarCaja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CerrarCaja))
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.Lbeuros = New System.Windows.Forms.Label()
        Me.LbRecaudacion = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbTitulo
        '
        Me.LbTitulo.AutoSize = True
        Me.LbTitulo.Location = New System.Drawing.Point(16, 9)
        Me.LbTitulo.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(215, 26)
        Me.LbTitulo.TabIndex = 0
        Me.LbTitulo.Text = "Recaudación del día:"
        '
        'Lbeuros
        '
        Me.Lbeuros.AutoSize = True
        Me.Lbeuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbeuros.Location = New System.Drawing.Point(225, 46)
        Me.Lbeuros.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Lbeuros.Name = "Lbeuros"
        Me.Lbeuros.Size = New System.Drawing.Size(47, 52)
        Me.Lbeuros.TabIndex = 1
        Me.Lbeuros.Text = "€"
        '
        'LbRecaudacion
        '
        Me.LbRecaudacion.AutoSize = True
        Me.LbRecaudacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRecaudacion.Location = New System.Drawing.Point(16, 46)
        Me.LbRecaudacion.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LbRecaudacion.Name = "LbRecaudacion"
        Me.LbRecaudacion.Size = New System.Drawing.Size(115, 52)
        Me.LbRecaudacion.TabIndex = 2
        Me.LbRecaudacion.Text = "label"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(12, 112)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(264, 65)
        Me.BtnCerrar.TabIndex = 3
        Me.BtnCerrar.Text = "Cerrar caja"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'CerrarCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 189)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LbRecaudacion)
        Me.Controls.Add(Me.Lbeuros)
        Me.Controls.Add(Me.LbTitulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "CerrarCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cerrar caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTitulo As Label
    Friend WithEvents Lbeuros As Label
    Friend WithEvents LbRecaudacion As Label
    Friend WithEvents BtnCerrar As Button
End Class
