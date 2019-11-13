Public Class Producto
    'Es la clase donde se creará el producto que se elija en el menú para metelo luego al listbox.


    'se añade los atributos de la clase los cuales son el nombre para saber que montado se elije,
    'la cantidad para saber cuantos productos iguales se elijen y que modifique el precio.
    'el precio y el tipo de montadito(aun por ver)
    Dim codigo, nombre As String
    Dim cantidad As Integer
    Dim precio As Single
    Dim precioTotalUnitario As Single


    'este es el constructor de la clase el cual solo se pasa el nombre y la cantidad.
    Public Sub New(ByVal codigo As String, ByVal nombre As String, ByVal precio As Single) ', ByVal precio As Single)
        Me.codigo = codigo
        Me.nombre = nombre
        Me.precio = precio
    End Sub

    Public Sub New()

    End Sub

    Public Sub New(ByVal nombre As String, ByVal precio As Single)
        Me.nombre = nombre
        Me.precio = precio
    End Sub

    'funciones que devuelven el codigo, el nombre, la cantidad y el precio.

    Public Function getCodigo() As String
        Return Me.codigo
    End Function
    Public Function getNombre() As String

        Return Me.nombre

    End Function

    Public Function getCantidad() As Integer

        Return Me.cantidad

    End Function

    Public Function getPrecio() As Single
        Return Me.precio
    End Function


    Public Sub setPrecio(ByVal precio As Single)
        Me.Precio = precio
    End Sub

    Public Sub setCantidad(ByVal cantidad As Integer)
        Me.cantidad = cantidad
    End Sub
End Class
