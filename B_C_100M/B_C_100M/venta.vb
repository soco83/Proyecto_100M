Public Class venta
    'se declaran dos variables.La variable listaProductos es una coleccion donde se gestionará todos los productos. 
    Dim listaProductos As New List(Of Producto)
    Dim precioTotal As Single

    'metodo para añadir productos a la list creada para luego pasarlo a la lista.
    'se pasa por parametro un objeto de tipo producto.
    Public Sub annadirProducto(ByVal producto As Producto)
        Dim i As Integer
        If listaProductos.Count = 0 Then
            producto.setCantidad(1)
            producto.setPrecioUnitario(producto.getPrecio)
            listaProductos.Add(producto)
            modificarPrecioTotal()
        Else

            For Each list In listaProductos
                If list.getNombre = producto.getNombre Then
                    list.setCantidad(list.getCantidad + 1)
                    list.setPrecioUnitario(list.getPrecioTotalUnitario + list.getPrecio)
                    modificarPrecioTotal()
                    Exit Sub
                End If
            Next
            producto.setCantidad(1)
            producto.setPrecioUnitario(producto.getPrecio)
            listaProductos.Add(producto)
            modificarPrecioTotal()
        End If
        Me.modificarPrecioTotal()
    End Sub

    Public Sub borrarLinea(ByVal codigo As Integer)
        Dim i As Integer
        For i = 0 To listaProductos.Count - 1
            If listaProductos.ElementAt(i).getCodigo = codigo - 1 Then
                listaProductos.RemoveAt(i)
                modificarPrecioTotal()
            End If
        Next i
    End Sub


    Private Sub modificarPrecioTotal()
        Dim i As Integer
        precioTotal = 0
        For i = 0 To listaProductos.Count - 1
            precioTotal = precioTotal + listaProductos.ElementAt(i).getPrecioTotalUnitario

        Next i

    End Sub
    Public Function getLista() As List(Of Producto)
        Return listaProductos
    End Function


    Public Sub annadirCantidadFija(ByVal codigo As Integer, ByVal cantidad As Integer)

    End Sub

End Class
