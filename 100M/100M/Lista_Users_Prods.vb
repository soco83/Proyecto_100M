Imports B_C_100M
Public Class Lista_Users_Prods
    Public openType As Integer
    Dim listaUser As New List(Of Usuario)
    Dim listaProduct As New List(Of Producto)
    Dim file As New Ficheros
    Private Sub ListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'coger todos los elementos del fichero de productos o usuarios y meterlos
        Select Case openType
            Case 1
                'se ha llegado aquí para ver USUARIOS
                LbTitulo.Text += " usuarios"

                listaUser = file.listarUsuario
                For Each listaU In listaUser
                    LBVista.Items.Add(listaU.getNombre & " " & listaU.getApe1 & " " & listaU.getApe2)
                Next

            Case 2
                'se ha llegado aquí para ver PRODUCTOS
                LbTitulo.Text += " productos"
                BtnBorrar.Visible = False
                listaProduct = file.listarProductos
                For Each listaP In listaProduct
                    LBVista.Items.Add(listaP.getCodigo & " " & listaP.getNombre & " " & listaP.getPrecio)
                Next
        End Select
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        'ir a la ventana de GestionProductos, en la que aparecerán todos los datos del producto seleccionado
        Select Case openType
            Case 1
                GestionUsuarios.opentype = 2
                GestionUsuarios.codigo = LBVista.SelectedIndex
                GestionUsuarios.Show()
            Case 2
                GestionProductos.openType = 2
                GestionProductos.codigo = LBVista.SelectedIndex
                GestionProductos.Show()
        End Select
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'borra el producto seleccionado, requiere confirmación
        Dim a As Integer = MsgBox("¿Seguro que desea Borrar el registro?", 292, "Confirmación")
        If a = MsgBoxResult.Yes Then
            Select Case openType
                Case 1
                    If Not LBVista.SelectedIndex = 0 Then
                        file.borrarUsuario(LBVista.SelectedIndex + 1)
                    End If
                    listaUser.Clear()
                    LBVista.Items.Clear()
                    listaUser = file.listarUsuario
                    For Each listaU In listaUser
                        LBVista.Items.Add(listaU.getNombre & " " & listaU.getApe1 & " " & listaU.getApe2)
                    Next

                Case 2
                    file.borrarProducto(LBVista.SelectedIndex + 1)
                    listaProduct.Clear()
                    LBVista.Items.Clear()
                    listaProduct = file.listarProductos
                    For Each listaP In listaProduct
                        LBVista.Items.Add(listaP.getCodigo & " " & listaP.getNombre & " " & listaP.getPrecio)
                    Next
            End Select
        End If

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub
End Class