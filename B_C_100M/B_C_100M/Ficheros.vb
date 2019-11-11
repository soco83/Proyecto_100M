Public Class Ficheros

    'se genera la estructura para poder gestionar el fichero de productos
    Structure productos
        <VBFixedArray(5)> Dim codigo As String
        <VBFixedArray(20)> Dim nombre As String
        Dim precio As Single
    End Structure
    'variable que se usa para referenciar a la estructura de productos.
    Dim product As productos

    'se genera la estructura para poder gestionar el fichero de usuarios
    Structure usuarios
        <VBFixedArray(5)> Dim codigo As String
        <VBFixedArray(15)> Dim nombre As String
        <VBFixedArray(10)> Dim contrasenna As String
        <VBFixedArray(15)> Dim apellido1, apellido2 As String
        <VBFixedArray(9)> Dim dni, telefono As String
        <VBFixedArray(25)> Dim email As String
        <VBFixedArray(30)> Dim direccion As String
    End Structure
    'variable que se  usa para referenciar a la estructura de usuarios.
    Dim users As usuarios

    'Metodo para registrar al usuario pasando por parametro un objeto de tipo usuario. 
    'este metodo se puede utilizar para modificar un registro.
    Public Sub guardarUsuario(ByVal user As Usuario)
        'c será la variable que guardará el codigo del usuario para poder sacar el usuario que se pide.
        Dim c As Integer = Val(user.getCodigo)
        Try
            FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Write,, Len(users))
            users.codigo = user.getCodigo
            users.nombre = user.getNombre
            users.contrasenna = user.getPassword
            users.apellido1 = user.getApe1
            users.apellido2 = user.getApe2
            users.dni = user.getDNI
            users.direccion = user.getDireccion
            users.email = user.getEmail

            FilePut(1, users, c)
            MsgBox("Registro guardado correctamente.", 64, "Información")
        Catch ex As Exception
            MsgBox("Se produjo un fallo en la escritura del registro, por favor vuelva a intentarlo", 48, "Fallo escritura")
        End Try
        FileClose()
    End Sub

    'metodo para la lectura de un registro de tipo usuario. se pasa por parametro el codigo para buscar en el fichero.
    'retorna un objeto de tipo usuario para poder trabajar con él.
    Public Function leerUsuario(ByVal codigo As Integer) As Usuario
        Try
            FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Read,, Len(users))
            FileGet(1, users, codigo)
        Catch ex As Exception
            MsgBox("Se produjo un fallo en la lectura del registro, por favor vuelva a intentarlo", 48, "Fallo lectura")
        End Try
        Dim user As New Usuario(users.codigo, users.contrasenna, users.nombre, users.apellido1, users.apellido2, users.dni, users.email, users.direccion, users.telefono)
        FileClose()
        Return user
    End Function

    'Metodo para borrar un registro de tipo usuario. se pasa por parametro el codigo para buscar en el fichero.

    Public Sub borrarUsusario(ByVal codigo As Integer)
        Try
            FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Write,, Len(users))
            users.codigo = ""
            users.nombre = ""
            users.contrasenna = ""
            users.apellido1 = ""
            users.apellido2 = ""
            users.dni = ""
            users.direccion = ""
            users.email = ""
            FilePut(1, users, codigo)
            MsgBox("registro borrado correctamente", 64, "Información")
        Catch ex As Exception
            MsgBox("Se produjo un fallo al borrar el registro, por favor vuelva a intentarlo", 48, "Fallos al borrar")
        End Try
        FileClose()

    End Sub
    'Metodo para Guardar un registro de tipo producto. Se pasa por parametro un objeto de tipo producto
    Public Sub guardarProducto(ByVal producto As Producto)
        Dim c As Integer = producto.getCodigo
        Try
            FileOpen(2, "productos", OpenMode.Random, OpenAccess.Write,, Len(product))

            product.codigo = producto.getCodigo
            product.nombre = producto.getNombre
            product.precio = producto.getPrecio

            FilePut(2, product, c)

            MsgBox("registro guardado correctamente", 64, "Información")
        Catch ex As Exception
            MsgBox("Se produjo un fallo en la escritura del registro, por favor vuelva a intentarlo", 48, "Fallo escritura")
        End Try
        FileClose()

    End Sub

    'Metodo para leer un registro de tipo producto. se pasa por parametro el codigo para buscar el registro.
    Public Function leerProducto(ByVal codigo As Integer) As Producto
        Try
            FileOpen(2, "productos", OpenMode.Random, OpenAccess.Read,, Len(product))
            FileGet(2, product, codigo)
        Catch ex As Exception
            MsgBox("Se produjo un fallo en la lectura del registro, por favor vuelva a intentarlo", 48, "Fallo lectura")
        End Try
        Dim prod As New Producto(product.codigo, product.nombre) ', product.precio)
        Return prod
    End Function

    'Metodo para borrar un registro de tipo producto. se pasa por parametro el codigo para buscar el registro. 
    Public Sub borrarProducto(ByVal codigo As Integer)
        Try
            FileOpen(2, "productos", OpenMode.Random, OpenAccess.Read,, Len(product))
            product.codigo = ""
            product.nombre = ""
            product.precio = 0
            MsgBox("registro borrado correctamente", 64, "Información")
        Catch ex As Exception
            MsgBox("Se produjo un fallo al borrar el registro, por favor vuelva a intentarlo", 48, "Fallos al borrar")
        End Try
        FileClose()

    End Sub
    'metodo para registrar los errores en un fichero. Se pasa por parametro el mensaje de error.
    Public Sub registrarErrores(ByVal mError As String)
        Try
            FileOpen(3, "errores", OpenMode.Append, OpenAccess.Read,,)

            PrintLine(3, mError, Now)

        Catch ex As Exception
            MsgBox("Se produjo un fallo en la escritura del registro, por favor vuelva a intentarlo", 48, "Fallo escritura")
        End Try
        FileClose()

    End Sub

    'metodo para registrar los accesos de todos los usuarios que entran a la aplicacion.
    'Se pasa por parametro el nombre y la contraseña del usuario que accede.
    Public Sub registrarAcesso(ByVal nombre As String, ByVal contrasenna As String)
        Try
            FileOpen(4, "fich_accesos", OpenMode.Append, OpenAccess.Write,,)

            PrintLine(4, nombre, contrasenna, Now)
        Catch ex As Exception
            MsgBox("Se produjo un fallo en la escritura del registro, por favor vuelva a intentarlo", 48, "Fallo escritura")
        End Try
    End Sub



End Class
