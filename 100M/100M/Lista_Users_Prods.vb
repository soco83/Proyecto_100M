Imports B_C_100M
Public Class Lista_Users_Prods
    Public openType As Integer
    Private Sub ListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'coger todos los elementos del fichero de productos o usuarios y meterlos
        Select Case openType
            Case 1
                'se ha llegado aquí para ver USUARIOS
                LbTitulo.Text += " usuarios"
            Case 2
                'se ha llegado aquí para ver PRODUCTOS
                LbTitulo.Text += " productos"
        End Select
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        'ir a la ventana de GestionProductos, en la que aparecerán todos los datos del producto seleccionado
        Select Case openType
            Case 1
                GestionUsuarios.opentype = 2
                GestionUsuarios.Show()
            Case 2
                GestionProductos.openType = 2
                GestionProductos.Show()
        End Select
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'borra el producto seleccionado, requiere confirmación

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub
End Class