Imports B_C_100M
Imports B_C_100M.Bebidas

Public Class GestionProductos
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If CBCategoria.Text = "" Or TxBNombre.Text = "" Or TxBPrecio.Text = "" Then
            MsgBox("Los campos de categoría, nombre y precio son obligatorios. Por favor rellénelos.", MsgBoxStyle.Information)
        Else
            'se crea el producto
            Dim a As New Bebidas(TxBNombre.Text, 1)
            'se mete el nuevo producto en el fichero de los productos
            Me.Close()
        End If
    End Sub

    Private Sub TxBPrecioEspecial_TextChanged(sender As Object, e As EventArgs) Handles TxBPrecioEspecial.TextChanged
        Dim chars As Char() = TxBPrecio.Text.ToCharArray
        For i = 0 To chars.Length
            If Not IsNumeric(chars(i)) Then

            End If
        Next

    End Sub
End Class