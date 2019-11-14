Imports B_C_100M
Imports B_C_Validaciones
Public Class GestionUsuarios
    Public opentype, codigo As Integer
    Dim file As New Ficheros
    Dim val As New Validar

    'Este form deberá servir tanto como para crear como para editar usuarios.
    'si el form fue llamado desde el botón crear, los TextBox aparecerán vacíos y el
    '   título del form (el Label LbTitulo) será "Nuevo usuario"
    'si fue llamado desde editar, el form aparecerá con, en los TextBox los datos del
    '   usuario a ediar y en el Label del título "Editar usuario"
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If opentype = 1 Then
            'crear un nuevo usuario
            LbTitulo.Text = "Nuevo usuario"
            LNombre.Hide()
            LApe1.Hide()
            LApe2.Hide()
            LDNI.Hide()
            LCorreo.Hide()
            LTel.Hide()

        ElseIf opentype = 2 Then
            'editar usuario seleccionado
            LbTitulo.Text = "Editar usuario"
            LApe1.Hide()
            LApe2.Hide()
            LDNI.Hide()
            LCorreo.Hide()
            LTel.Hide()
            Dim user As New Usuario()
            user = file.leerUsuario(codigo + 1)
            TxbCodigo.Text = user.getCodigo
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

    Private Sub TxBNombre_TextChanged(sender As Object, e As EventArgs) Handles TxBNombre.TextChanged
        If Not val.validarNombre(TxBNombre.Text) Then
            LNombre.Show()
        Else
            LNombre.Hide()
        End If

    End Sub

    Private Sub TxBApe1_TextChanged(sender As Object, e As EventArgs) Handles TxBApe1.TextChanged
        If Not val.validarNombre(TxBApe1.Text) Then
            LApe1.Show()
        Else
            LApe1.Hide()
        End If

    End Sub

    Private Sub TxBApe2_TextChanged(sender As Object, e As EventArgs) Handles TxBApe2.TextChanged
        If Not val.validarNombre(TxBApe2.Text) Then
            LApe2.Show()
        Else
            LApe2.Hide()
        End If
    End Sub

    Private Sub TxBDNI_TextChanged(sender As Object, e As EventArgs) Handles TxBDNI.TextChanged
        If Not val.validarDni(TxBDNI.Text) Then
            LDNI.Show()
        Else
            LDNI.Hide()

        End If
    End Sub

    Private Sub TxBEmail_TextChanged(sender As Object, e As EventArgs) Handles TxBEmail.TextChanged
        If Not val.validarMail(TxBEmail.Text) Then
            LCorreo.Show()
        Else
            LCorreo.Hide()

        End If
    End Sub

    Private Sub TxBTel_TextChanged(sender As Object, e As EventArgs) Handles TxBTel.TextChanged
        If Not val.validarNum(TxBTel.Text) Then
            LTel.Show()
        Else
            LTel.Hide()

        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim validacion As Boolean = val.validarNombre(TxBApe1.Text) And val.validarNombre(TxBApe1.Text) And val.validarDni(TxBDNI.Text)
        If Not val.validarMail(TxBEmail.Text) And TxBEmail.Text <> "" Then
            MsgBox("E-mail inválido, por favor vuelva a escribirlo ", 64, "Campo erroneo")
            Exit Sub
        End If

        If Not val.validarNum(TxBTel.Text) And TxBTel.Text <> "" Then
            MsgBox("telefono inválido, por favor vuelva a escribirlo", 64, "Campo erroneo")
            Exit Sub
        End If
        If Not val.validarNombre(TxBApe2.Text) And TxBApe2.Text <> "" Then
            MsgBox("Apellido invalido, por favor vuelva a escribirlo", 64, "Campo erroneo")
        End If

        If TxBNombre.Text = "" Or TxBApe1.Text = "" Or TxBDNI.Text = "" Or TxBPassWord.Text = "" Or TxbCodigo.Text = "" Then
            MsgBox("Los campos de nombre, primer apellido, D.N.I., contraseña y rol son obligatorios.", MsgBoxStyle.Information)
        ElseIf Not validacion Then
            MsgBox("Los campos no son correctos, por favor vuelva a introducirlos", 64, "Campos incorrectos")
        Else

            Dim file As New Ficheros
            'se crea el usuario
            Dim user As New Usuario(TxbCodigo.Text, TxBPassWord.Text, TxBNombre.Text, TxBApe1.Text, TxBApe2.Text, TxBDNI.Text, TxBTel.Text, TxBEmail.Text, TxBDireccion.Text)
            file.guardarUsuario(user)



        End If
    End Sub
End Class
