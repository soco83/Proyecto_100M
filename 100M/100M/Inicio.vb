﻿Imports B_C_100M
Public Class Inicio
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim file As New Ficheros

        If file.verifUser(TxBNombre.Text, TxBPassword.Text) Then
            FormMain.nombreUsuario = TxBNombre.Text
            file.registrarAcesso(TxBNombre.Text, TxBPassword.Text)
            TxBNombre.Clear()
            TxBPassword.Clear()
            FormMain.Show()
            Me.Hide()
        Else
            MsgBox("Nombre y/o contraseña incorrectos, por favor vuelva a intentarlo.", 64, "Fallo de inicio de sesión")
            TxBNombre.Clear()
            TxBPassword.Clear()
            TxBNombre.Focus()
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim a As Integer = MsgBox("¿Seguro que desea salir?.", 292, "Confirmación de salida")
        If a = MsgBoxResult.Yes Then
            Try
                Application.Exit()
            Catch ex As Exception
                MsgBox("No se ha podido salir, intentelo de nuevo.", MsgBoxStyle.Critical, "ERROR al salir")
            End Try
        End If
    End Sub


End Class