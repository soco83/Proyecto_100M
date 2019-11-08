<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxBPrecio = New System.Windows.Forms.TextBox()
        Me.TxBNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbPrecio = New System.Windows.Forms.Label()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TxBPrecioEspecial = New System.Windows.Forms.TextBox()
        Me.LbPrecioEspecial = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBCategoria
        '
        Me.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Items.AddRange(New Object() {"Mont. De la casa", "Mont. Clásico", "Mont. Especiales", "Mont. Dulces", "Mont. Super", "Bebidas", "Para picar"})
        Me.CBCategoria.Location = New System.Drawing.Point(209, 42)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(193, 34)
        Me.CBCategoria.TabIndex = 25
        '
        'LbRol
        '
        Me.LbRol.AutoSize = True
        Me.LbRol.Location = New System.Drawing.Point(14, 50)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(115, 26)
        Me.LbRol.TabIndex = 44
        Me.LbRol.Text = "Categoría*"
        '
        'LbTitulo
        '
        Me.LbTitulo.AutoSize = True
        Me.LbTitulo.Location = New System.Drawing.Point(97, 9)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(77, 26)
        Me.LbTitulo.TabIndex = 41
        Me.LbTitulo.Text = "Label2"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(138, 235)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(135, 39)
        Me.BtnAceptar.TabIndex = 40
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxBPrecio
        '
        Me.TxBPrecio.Location = New System.Drawing.Point(209, 120)
        Me.TxBPrecio.Name = "TxBPrecio"
        Me.TxBPrecio.Size = New System.Drawing.Size(193, 32)
        Me.TxBPrecio.TabIndex = 31
        '
        'TxBNombre
        '
        Me.TxBNombre.Location = New System.Drawing.Point(209, 82)
        Me.TxBNombre.Name = "TxBNombre"
        Me.TxBNombre.Size = New System.Drawing.Size(193, 32)
        Me.TxBNombre.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "* : campos obligatorios"
        '
        'LbPrecio
        '
        Me.LbPrecio.AutoSize = True
        Me.LbPrecio.Location = New System.Drawing.Point(14, 123)
        Me.LbPrecio.Name = "LbPrecio"
        Me.LbPrecio.Size = New System.Drawing.Size(83, 26)
        Me.LbPrecio.TabIndex = 26
        Me.LbPrecio.Text = "Precio*"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(14, 85)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(99, 26)
        Me.LbNombre.TabIndex = 24
        Me.LbNombre.Text = "Nombre*"
        '
        'TxBPrecioEspecial
        '
        Me.TxBPrecioEspecial.Location = New System.Drawing.Point(209, 158)
        Me.TxBPrecioEspecial.Name = "TxBPrecioEspecial"
        Me.TxBPrecioEspecial.Size = New System.Drawing.Size(193, 32)
        Me.TxBPrecioEspecial.TabIndex = 46
        '
        'LbPrecioEspecial
        '
        Me.LbPrecioEspecial.AutoSize = True
        Me.LbPrecioEspecial.Location = New System.Drawing.Point(14, 161)
        Me.LbPrecioEspecial.Name = "LbPrecioEspecial"
        Me.LbPrecioEspecial.Size = New System.Drawing.Size(160, 26)
        Me.LbPrecioEspecial.TabIndex = 45
        Me.LbPrecioEspecial.Text = "Precio especial"
        '
        'GestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 327)
        Me.Controls.Add(Me.TxBPrecioEspecial)
        Me.Controls.Add(Me.LbPrecioEspecial)
        Me.Controls.Add(Me.CBCategoria)
        Me.Controls.Add(Me.LbRol)
        Me.Controls.Add(Me.LbTitulo)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxBPrecio)
        Me.Controls.Add(Me.TxBNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbPrecio)
        Me.Controls.Add(Me.LbNombre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "GestionProductos"
        Me.Text = "Gestion de productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents LbRol As Label
    Friend WithEvents LbTitulo As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxBPrecio As TextBox
    Friend WithEvents TxBNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LbPrecio As Label
    Friend WithEvents LbNombre As Label
    Friend WithEvents TxBPrecioEspecial As TextBox
    Friend WithEvents LbPrecioEspecial As Label
End Class
