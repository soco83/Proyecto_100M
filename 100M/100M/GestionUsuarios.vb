Public Class GestionUsuarios

    'ste form deberá servir tanto como para crear como para editar usuarios.
    'si el form fue llamado desde el botón crear, los TextBox aparecerán vacíos y el
    '   título del form (el Label LbTitulo) será "Nuevo usuario"
    'si fue llamado desde editar, el form aparecerá con, en los TextBox los datos del
    '   usuario a ediar y en el Label del título "Editar usuario"
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxBNombre.Text = "" Or TxBApe1.Text = "" Or TxBDNI.Text = "" Or TxBPassWord.Text = "" Or CBRoles.Text = "" Then
            MsgBox("Los campos de nombre, primer apellido, D.N.I., contraseña y rol son obligatorios.", MsgBoxStyle.Information)
        Else
            'se crea el usuario
            'Dim user As New Usuario() --> no se como se hace
            Me.Close()
        End If
    End Sub
End Class
