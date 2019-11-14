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
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.LbDireccion = New System.Windows.Forms.Label()
        Me.TxBDireccion = New System.Windows.Forms.TextBox()
        Me.TxBPassWord = New System.Windows.Forms.TextBox()
        Me.LbPassword = New System.Windows.Forms.Label()
        Me.LBSeparador = New System.Windows.Forms.Label()
        Me.TxbCodigo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(14, 47)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(99, 26)
        Me.LbNombre.TabIndex = 0
        Me.LbNombre.Text = "Nombre*"
        '
        'LbApe1
        '
        Me.LbApe1.AutoSize = True
        Me.LbApe1.Location = New System.Drawing.Point(14, 150)
        Me.LbApe1.Name = "LbApe1"
        Me.LbApe1.Size = New System.Drawing.Size(167, 26)
        Me.LbApe1.TabIndex = 1
        Me.LbApe1.Text = "Primer apellido*"
        '
        'LbApe2
        '
        Me.LbApe2.AutoSize = True
        Me.LbApe2.Location = New System.Drawing.Point(14, 188)
        Me.LbApe2.Name = "LbApe2"
        Me.LbApe2.Size = New System.Drawing.Size(180, 26)
        Me.LbApe2.TabIndex = 2
        Me.LbApe2.Text = "Segundo apellido"
        '
        'LbDNI
        '
        Me.LbDNI.AutoSize = True
        Me.LbDNI.Location = New System.Drawing.Point(14, 226)
        Me.LbDNI.Name = "LbDNI"
        Me.LbDNI.Size = New System.Drawing.Size(77, 26)
        Me.LbDNI.TabIndex = 3
        Me.LbDNI.Text = "D.N.I.*"
        '
        'LbEmail
        '
        Me.LbEmail.AutoSize = True
        Me.LbEmail.Location = New System.Drawing.Point(14, 264)
        Me.LbEmail.Name = "LbEmail"
        Me.LbEmail.Size = New System.Drawing.Size(189, 26)
        Me.LbEmail.TabIndex = 4
        Me.LbEmail.Text = "Correo electrónico"
        '
        'LbTel
        '
        Me.LbTel.AutoSize = True
        Me.LbTel.Location = New System.Drawing.Point(14, 302)
        Me.LbTel.Name = "LbTel"
        Me.LbTel.Size = New System.Drawing.Size(95, 26)
        Me.LbTel.TabIndex = 5
        Me.LbTel.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "* : campos obligatorios"
        '
        'TxBEmail
        '
        Me.TxBEmail.Location = New System.Drawing.Point(209, 261)
        Me.TxBEmail.MaxLength = 30
        Me.TxBEmail.Name = "TxBEmail"
        Me.TxBEmail.Size = New System.Drawing.Size(351, 32)
        Me.TxBEmail.TabIndex = 6
        '
        'TxBDNI
        '
        Me.TxBDNI.Location = New System.Drawing.Point(209, 223)
        Me.TxBDNI.MaxLength = 9
        Me.TxBDNI.Name = "TxBDNI"
        Me.TxBDNI.Size = New System.Drawing.Size(351, 32)
        Me.TxBDNI.TabIndex = 5
        '
        'TxBApe2
        '
        Me.TxBApe2.Location = New System.Drawing.Point(209, 185)
        Me.TxBApe2.MaxLength = 30
        Me.TxBApe2.Name = "TxBApe2"
        Me.TxBApe2.Size = New System.Drawing.Size(351, 32)
        Me.TxBApe2.TabIndex = 4
        '
        'TxBTel
        '
        Me.TxBTel.Location = New System.Drawing.Point(209, 299)
        Me.TxBTel.MaxLength = 9
        Me.TxBTel.Name = "TxBTel"
        Me.TxBTel.Size = New System.Drawing.Size(351, 32)
        Me.TxBTel.TabIndex = 7
        '
        'TxBNombre
        '
        Me.TxBNombre.Location = New System.Drawing.Point(209, 44)
        Me.TxBNombre.MaxLength = 20
        Me.TxBNombre.Name = "TxBNombre"
        Me.TxBNombre.Size = New System.Drawing.Size(351, 32)
        Me.TxBNombre.TabIndex = 1
        '
        'TxBApe1
        '
        Me.TxBApe1.Location = New System.Drawing.Point(209, 147)
        Me.TxBApe1.MaxLength = 30
        Me.TxBApe1.Name = "TxBApe1"
        Me.TxBApe1.Size = New System.Drawing.Size(351, 32)
        Me.TxBApe1.TabIndex = 3
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(138, 416)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(135, 39)
        Me.BtnAceptar.TabIndex = 10
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'LbTitulo
        '
        Me.LbTitulo.AutoSize = True
        Me.LbTitulo.Location = New System.Drawing.Point(133, 9)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(70, 26)
        Me.LbTitulo.TabIndex = 14
        Me.LbTitulo.Text = "label2"
        '
        'LbDireccion
        '
        Me.LbDireccion.AutoSize = True
        Me.LbDireccion.Location = New System.Drawing.Point(14, 340)
        Me.LbDireccion.Name = "LbDireccion"
        Me.LbDireccion.Size = New System.Drawing.Size(103, 26)
        Me.LbDireccion.TabIndex = 15
        Me.LbDireccion.Text = "Dirección"
        '
        'TxBDireccion
        '
        Me.TxBDireccion.Location = New System.Drawing.Point(209, 337)
        Me.TxBDireccion.MaxLength = 30
        Me.TxBDireccion.Name = "TxBDireccion"
        Me.TxBDireccion.Size = New System.Drawing.Size(351, 32)
        Me.TxBDireccion.TabIndex = 8
        '
        'TxBPassWord
        '
        Me.TxBPassWord.Location = New System.Drawing.Point(209, 82)
        Me.TxBPassWord.MaxLength = 20
        Me.TxBPassWord.Name = "TxBPassWord"
        Me.TxBPassWord.Size = New System.Drawing.Size(351, 32)
        Me.TxBPassWord.TabIndex = 2
        '
        'LbPassword
        '
        Me.LbPassword.AutoSize = True
        Me.LbPassword.Location = New System.Drawing.Point(14, 85)
        Me.LbPassword.Name = "LbPassword"
        Me.LbPassword.Size = New System.Drawing.Size(144, 26)
        Me.LbPassword.TabIndex = 19
        Me.LbPassword.Text = "Constraseña*"
        '
        'LBSeparador
        '
        Me.LBSeparador.AutoSize = True
        Me.LBSeparador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSeparador.Location = New System.Drawing.Point(16, 117)
        Me.LBSeparador.Name = "LBSeparador"
        Me.LBSeparador.Size = New System.Drawing.Size(544, 17)
        Me.LBSeparador.TabIndex = 23
        Me.LBSeparador.Text = "___________________________________________________________________"
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(325, 416)
        Me.TxbCodigo.Name = "TxbCodigo"
        Me.TxbCodigo.Size = New System.Drawing.Size(235, 32)
        Me.TxbCodigo.TabIndex = 24
        Me.TxbCodigo.Text = "métase aquí el código"
        Me.TxbCodigo.Visible = False
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 508)
        Me.Controls.Add(Me.TxbCodigo)
        Me.Controls.Add(Me.LBSeparador)
        Me.Controls.Add(Me.TxBPassWord)
        Me.Controls.Add(Me.LbPassword)
        Me.Controls.Add(Me.TxBDireccion)
        Me.Controls.Add(Me.LbDireccion)
        Me.Controls.Add(Me.LbTitulo)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents LbTitulo As Label
    Friend WithEvents LbDireccion As Label
    Friend WithEvents TxBDireccion As TextBox
    Friend WithEvents TxBPassWord As TextBox
    Friend WithEvents LbPassword As Label
    Friend WithEvents LBSeparador As Label
    Friend WithEvents TxbCodigo As TextBox
End Class
