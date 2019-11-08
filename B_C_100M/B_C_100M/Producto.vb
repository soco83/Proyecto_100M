Public Class Producto
    'Es la clase donde se creará el producto que se elija en el menú para metelo luego al listbox.


    'se añade los atributos de la clase los cuales son el nombre para saber que montado se elije,
    'la cantidad para saber cuantos productos iguales se elijen y que modifique el precio.
    'el precio y el tipo de montadito(aun por ver)
    Dim nombre As String
    Dim cantidad As Integer
    Dim precio As Single



    'este es el constructor de la clase el cual solo se pasa el nombre y la cantidad.
    Public Sub New(ByVal nombre As String, ByVal cantidad As Integer)
        Me.nombre = nombre
        Me.cantidad = cantidad

    End Sub

    'se pone el proceso para que le pase al hijo para obtener el precio.
    Public Sub ponerPrecio()

    End Sub
    'funciones que devuelven el nombre, la cantidad y el precio.
    Public Function getNombre() As String

        Return Me.nombre

    End Function

    Public Function getCantidad() As Integer

        Return Me.cantidad

    End Function

    Public Function getPrecio() As Single
        Return Me.precio
    End Function

    'se pone el set precio para poder poner el precio en los hijos
    Public Sub setPrecio(ByVal precio As Single)
        Me.Precio = precio
    End Sub
    'se pone el set cantidad para poder cambiarla en los hijos
    Public Sub setCantidad(ByVal cantidad As Integer)
        Me.cantidad = cantidad
    End Sub
End Class



Public Class Montadito
    Inherits Producto
    'esta es la clase montadito que hereda de la clase producto y el cual tiene un atributo mas que es el tipo.

    'se define el atributo tipo para poder adjudicar un tipo a cada montado que se elija y asi poder darle precio
    Dim tipo As t_montadito

    'se pone el constructor el cual hereda del padre y se pone tambien el tipo del montadito.
    Public Sub New(ByVal nombre As String, ByVal cantidad As Integer, ByVal tipo As t_montadito)

        MyBase.New(nombre, cantidad)
        Me.tipo = tipo
    End Sub

    'Este será el enum de los tipos de los montaditos 
    Enum t_montadito
        deLaCasa
        clasicos
        especiales
        dulces
        superMontys
    End Enum

    'se sobreescribe el metodo del padre para poner el precio(cuando vea mas de ficheros lo cambiare para que recoja el precio de los ficheros)
    Public Overloads Sub ponerPrecio()
        Select Case tipo
            Case t_montadito.deLaCasa
                setPrecio(1)
            Case t_montadito.clasicos
                setPrecio(1.2)
            Case t_montadito.especiales
                setPrecio(1.5)
            Case t_montadito.dulces
                setPrecio(1.5)
            Case t_montadito.superMontys
                setPrecio(2)
        End Select

    End Sub
    'metodo para aumentar en 1 la cantidad del producto.
    Public Sub aumentarCantidad()
        Dim cantidad As Integer
        cantidad = getCantidad()
        cantidad = cantidad + 1
        setCantidad(cantidad)
    End Sub



End Class

Public Class Bebidas
    Inherits Producto
    'clase para todas las bebidas. 

    Dim tipo As t_bebidas

    'constructor de la clase bebidas que hereda de producto
    Public Sub New(ByVal nombre As String, ByVal cantidad As Integer, ByVal tipo As t_bebidas)

        MyBase.New(nombre, cantidad)
        Me.tipo = tipo
    End Sub
    'los enums del tipo de bebida
    Enum t_bebidas
        refresco1_8
        refresco_2
        apletiser
        monster
        agua
        zumo
        batidos
        cafe
        infusiones
        vino
        canna
        jarra_2
        jarra1_5
        paulaner2_5
    End Enum
    'metodo para seleccionar el precio de las bebidas dependiendo del tipo
    Public Overloads Sub ponerPrecio()
        Select Case tipo
            Case t_bebidas.refresco1_8

            Case t_bebidas.refresco_2

            Case t_bebidas.apletiser

            Case t_bebidas.monster

            Case t_bebidas.agua

            Case t_bebidas.zumo

            Case t_bebidas.batidos

            Case t_bebidas.cafe

            Case t_bebidas.infusiones

            Case t_bebidas.vino

            Case t_bebidas.canna

            Case t_bebidas.jarra_2

            Case t_bebidas.jarra1_5

            Case t_bebidas.paulaner2_5


        End Select
    End Sub

End Class
