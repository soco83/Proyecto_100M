Public Class venta
    'se declaran dos variables.La variable listaProductos es una coleccion donde se gestionará todos los productos. 
    Dim listaProductos As List(Of Producto)
    Dim precioTotal As Single

    'metodo para añadir productos a la list creada para luego pasarlo a la lista.
    'se pasa por parametro un objeto de tipo producto.
    Public Sub annadirProducto(ByVal producto As Producto)
        Dim i As Integer
        If listaProductos.Count = 0 Then
            listaProductos.Add(producto)
        Else
            For i = 0 To listaProductos.Count - 1
                If listaProductos.ElementAt(i).getNombre = producto.getNombre Then
                    listaProductos.ElementAt(i).setCantidad(listaProductos.ElementAt(i).getCantidad + 1)

                Else
                    listaProductos.Add(producto)
                End If
            Next i

        End If
        Me.modificarPrecioTotal()
    End Sub

    Public Sub borrarLinea(ByVal codigo As Integer)
        Dim i As Integer
        For i = 0 To listaProductos.Count - 1
            If listaProductos.ElementAt(i).getCodigo = codigo Then
                listaProductos.RemoveAt(i)
                modificarPrecioTotal()
            End If
        Next i
    End Sub


    Private Sub modificarPrecioTotal()
        Dim i As Integer
        precioTotal = 0
        For i = 0 To listaProductos.Count - 1
            precioTotal = precioTotal + listaProductos.ElementAt(i).getPrecio()

        Next i

    End Sub

    Public Sub annadirCantidadFija(ByVal codigo As Integer, ByVal cantidad As Integer)

    End Sub

End Class
