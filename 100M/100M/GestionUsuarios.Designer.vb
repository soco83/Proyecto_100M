<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
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
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbApe1 = New System.Windows.Forms.Label()
        Me.LbApe2 = New System.Windows.Forms.Label()
        Me.LbDNI = New System.Windows.Forms.Label()
        Me.LbEmail = New System.Windows.Forms.Label()
        Me.LbTel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxBEmail = New System.Windows.Forms.TextBox()
        Me.TxBDNI = New System.Windows.Forms.TextBox()
        Me.TxBApe2 = New System.Windows.Forms.TextBox()
        Me.TxBTel = New System.Windows.Forms.TextBox()
        Me.TxBNombre = New System.Windows.Forms.TextBox()
        Me.TxBApe1 = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(12, 9)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(99, 26)
        Me.LbNombre.TabIndex = 0
        Me.LbNombre.Text = "Nombre*"
        '
        'LbApe1
        '
        Me.LbApe1.AutoSize = True
        Me.LbApe1.Location = New System.Drawing.Point(12, 47)
        Me.LbApe1.Name = "LbApe1"
        Me.LbApe1.Size = New System.Drawing.Size(167, 26)
        Me.LbApe1.TabIndex = 1
        Me.LbApe1.Text = "Primer apellido*"
        '
        'LbApe2
        '
        Me.LbApe2.AutoSize = True
        Me.LbApe2.Location = New System.Drawing.Point(12, 85)
        Me.LbApe2.Name = "LbApe2"
        Me.LbApe2.Size = New System.Drawing.Size(180, 26)
        Me.LbApe2.TabIndex = 2
        Me.LbApe2.Text = "Segundo apellido"
        '
        'LbDNI
        '
        Me.LbDNI.AutoSize = True
        Me.LbDNI.Location = New System.Drawing.Point(12, 123)
        Me.LbDNI.Name = "LbDNI"
        Me.LbDNI.Size = New System.Drawing.Size(77, 26)
        Me.LbDNI.TabIndex = 3
        Me.LbDNI.Text = "D.N.I.*"
        '
        'LbEmail
        '
        Me.LbEmail.AutoSize = True
        Me.LbEmail.Location = New System.Drawing.Point(12, 161)
        Me.LbEmail.Name = "LbEmail"
        Me.LbEmail.Size = New System.Drawing.Size(189, 26)
        Me.LbEmail.TabIndex = 4
        Me.LbEmail.Text = "Correo electrónico"
        '
        'LbTel
        '
        Me.LbTel.AutoSize = True
        Me.LbTel.Location = New System.Drawing.Point(12, 199)
        Me.LbTel.Name = "LbTel"
        Me.LbTel.Size = New System.Drawing.Size(95, 26)
        Me.LbTel.TabIndex = 5
        Me.LbTel.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "* : campos obligatorios"
        '
        'TxBEmail
        '
        Me.TxBEmail.Location = New System.Drawing.Point(207, 158)
        Me.TxBEmail.Name = "TxBEmail"
        Me.TxBEmail.Size = New System.Drawing.Size(193, 32)
        Me.TxBEmail.TabIndex = 7
        '
        'TxBDNI
        '
        Me.TxBDNI.Location = New System.Drawing.Point(207, 120)
        Me.TxBDNI.Name = "TxBDNI"
        Me.TxBDNI.Size = New System.Drawing.Size(193, 32)
        Me.TxBDNI.TabIndex = 8
        '
        'TxBApe2
        '
        Me.TxBApe2.Location = New System.Drawing.Point(207, 82)
        Me.TxBApe2.Name = "TxBApe2"
        Me.TxBApe2.Size = New System.Drawing.Size(193, 32)
        Me.TxBApe2.TabIndex = 9
        '
        'TxBTel
        '
        Me.TxBTel.Location = New System.Drawing.Point(207, 196)
        Me.TxBTel.Name = "TxBTel"
        Me.TxBTel.Size = New System.Drawing.Size(193, 32)
        Me.TxBTel.TabIndex = 10
        '
        'TxBNombre
        '
        Me.TxBNombre.Location = New System.Drawing.Point(207, 6)
        Me.TxBNombre.Name = "TxBNombre"
        Me.TxBNombre.Size = New System.Drawing.Size(193, 32)
        Me.TxBNombre.TabIndex = 11
        '
        'TxBApe1
        '
        Me.TxBApe1.Location = New System.Drawing.Point(207, 44)
        Me.TxBApe1.Name = "TxBApe1"
        Me.TxBApe1.Size = New System.Drawing.Size(193, 32)
        Me.TxBApe1.TabIndex = 12
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(138, 234)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(135, 39)
        Me.BtnAceptar.TabIndex = 13
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 381)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxBApe1)
        Me.Controls.Add(Me.TxBNombre)
        Me.Controls.Add(Me.TxBTel)
        Me.Controls.Add(Me.TxBApe2)
        Me.Controls.Add(Me.TxBDNI)
        Me.Controls.Add(Me.TxBEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbTel)
        Me.Controls.Add(Me.LbEmail)
        Me.Controls.Add(Me.LbDNI)
        Me.Controls.Add(Me.LbApe2)
        Me.Controls.Add(Me.LbApe1)
        Me.Controls.Add(Me.LbNombre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "GestionUsuarios"
        Me.Text = "Gestión de usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbNombre As Label
    Friend WithEvents LbApe1 As Label
    Friend WithEvents LbApe2 As Label
    Friend WithEvents LbDNI As Label
    Friend WithEvents LbEmail As Label
    Friend WithEvents LbTel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxBEmail As TextBox
    Friend WithEvents TxBDNI As TextBox
    Friend WithEvents TxBApe2 As TextBox
    Friend WithEvents TxBTel As TextBox
    Friend WithEvents TxBNombre As TextBox
    Friend WithEvents TxBApe1 As TextBox
    Friend WithEvents BtnAceptar As Button
End Class
