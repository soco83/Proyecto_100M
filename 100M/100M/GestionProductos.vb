Imports B_C_100M

Public Class GestionProductos
    Public openType, codigo As Integer
    Public file As New Ficheros
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxBCodigo.Text = "" Or TxBNombre.Text = "" Or TxBPrecio.Text = "" Then
            MsgBox("Los campos de categoría, nombre y precio son obligatorios. Por favor rellénelos.", MsgBoxStyle.Information)
        Else
            'se crea el producto
            Dim prod As New Producto(TxBCodigo.Text, TxBNombre.Text, CSng(TxBPrecio.Text))
            file.guardarProducto(prod)
            'se mete el nuevo producto en el fichero de los productos
            Me.Close()
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
        If openType = 1 Then
            'crear un nuevo usuario
            LbTitulo.Text = "Nuevo producto"
        ElseIf openType = 2 Then
            'editar usuario seleccionado
            LbTitulo.Text = "Editar producto"

        End If
    End Sub
End Class