Imports B_C_100M
Public Class GestionUsuarios
    Public opentype, codigo As Integer
    Dim file As New Ficheros

    'Este form deberá servir tanto como para crear como para editar usuarios.
    'si el form fue llamado desde el botón crear, los TextBox aparecerán vacíos y el
    '   título del form (el Label LbTitulo) será "Nuevo usuario"
    'si fue llamado desde editar, el form aparecerá con, en los TextBox los datos del
    '   usuario a ediar y en el Label del título "Editar usuario"
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If opentype = 1 Then
            'crear un nuevo usuario
            LbTitulo.Text = "Nuevo usuario"
        ElseIf opentype = 2 Then
            'editar usuario seleccionado
            LbTitulo.Text = "Editar usuario"
            Dim user As New Usuario()
            user = file.leerUsuario(codigo + 1)
            txBCodigo.Text = user.getCodigo
            TxBApe1.Text = user.getApe1
            TxBApe2.Text = user.getApe2
            TxBNombre.Text = user.getNombre
            TxBPassWord.Text = user.getPassword
            TxBDNI.Text = user.getDNI
            TxBDireccion.Text = user.getDireccion
            TxBEmail.Text = user.getEmail
            TxBTel.Text = user.getTel
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxBNombre.Text = "" Or TxBApe1.Text = "" Or TxBDNI.Text = "" Or TxBPassWord.Text = "" Or txBCodigo.Text = "" Then
            MsgBox("Los campos de nombre, primer apellido, D.N.I., contraseña y rol son obligatorios.", MsgBoxStyle.Information)
        Else

            Dim file As New Ficheros
            'se crea el usuario
            Dim user As New Usuario(txBCodigo.Text, TxBPassWord.Text, TxBNombre.Text, TxBApe1.Text, TxBApe2.Text, TxBDNI.Text, TxBTel.Text, TxBEmail.Text, TxBDireccion.Text)
            file.guardarUsuario(user)

        End If
    End Sub
End Class
