﻿Imports B_C_100M
Imports B_C_Validaciones
Public Class GestionProductos
    Public openType, codigo As Integer
    Public file As New Ficheros
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxBCodigo.Text = "" Or TxBNombre.Text = "" Or TxBPrecio.Text = "" Then
            MsgBox("Los campos de categoría, nombre y precio son obligatorios. Por favor rellénelos.", MsgBoxStyle.Information)
        Else

            Dim prod As New Producto(TxBCodigo.Text, TxBNombre.Text, CSng(TxBPrecio.Text))
            file.guardarProducto(prod)

            'Me.Close()
        End If
    End Sub

    Private Sub TxBPrecioEspecial_TextChanged(sender As Object, e As EventArgs)
        Dim chars As Char() = TxBPrecio.Text.ToCharArray
        For i = 0 To chars.Length
            If Not IsNumeric(chars(i)) Then
                TxBPrecio.Clear()
                TxBPrecio.Focus()
            End If
        Next

    End Sub

    Private Sub GestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbRol.Visible = False
        TxBCodigo.Visible = False
        If openType = 1 Then
            'crear un nuevo usuario
            LbTitulo.Text = "Nuevo producto"
        ElseIf openType = 2 Then
            'editar usuario seleccionado
            LbTitulo.Text = "Editar producto"
            Try
                Dim productos As Producto
                productos = file.leerProducto(codigo + 1)
                TxBCodigo.Text = productos.getCodigo
                TxBNombre.Text = productos.getNombre
                TxBPrecio.Text = productos.getPrecio
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub
End Class