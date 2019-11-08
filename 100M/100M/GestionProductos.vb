Public Class GestionProductos
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If CBCategoria.Text = "" Or TxBNombre.Text = "" Or TxBPrecio.Text = "" Then
            MsgBox("Los campos de categoría, nombre y precio son obligatorios. Por favor rellénelos.", MsgBoxStyle.Information)
        Else
            'se crea el producto
            'Dim prod As New Producto()
            Me.Close()
        End If
    End Sub

End Class