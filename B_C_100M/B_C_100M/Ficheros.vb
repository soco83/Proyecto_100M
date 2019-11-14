Public Class Ficheros

    'se genera la estructura para poder gestionar el fichero de productos
    Structure productos
        <VBFixedString(5)> Dim codigo As String
        <VBFixedString(20)> Dim nombre As String
        Dim precio As Single
    End Structure
    'variable que se usa para referenciar a la estructura de productos.
    Dim product As productos

    'se genera la estructura para poder gestionar el fichero de usuarios
    Structure usuarios
        <VBFixedString(10)> Dim codigo As String
        <VBFixedString(20)> Dim nombre As String
        <VBFixedString(20)> Dim contrasenna As String
        <VBFixedString(30)> Dim apellido1 As String
        <VBFixedString(30)> Dim apellido2 As String
        <VBFixedString(9)> Dim dni As String
        <VBFixedString(9)> Dim telefono As String
        <VBFixedString(30)> Dim email As String
        <VBFixedString(30)> Dim direccion As String

    End Structure
    'variable que se  usa para referenciar a la estructura de usuarios.
    Public users As usuarios

    'Metodo para registrar al usuario pasando por parametro un objeto de tipo usuario. 
    'este metodo se puede utilizar para modificar un registro.
    Public Sub guardarUsuario(ByVal user As Usuario)
        'c será la variable que guardará el codigo del usuario para poder sacar el usuario que se pide.
        Dim c As Integer
        Try
            FileOpen(1, "ficheros\usuarios", OpenMode.Random, OpenAccess.Write,, Len(users))
            If user.getCodigo = "" Then
                c = CInt(FileLen(1) / Len(users) + 1)
            Else
                c = Val(user.getCodigo)
            End If

            users.codigo = c
            users.nombre = user.getNombre
            users.contrasenna = user.getPassword
            users.apellido1 = user.getApe1
            users.apellido2 = user.getApe2
            users.dni = user.getDNI
            users.direccion = user.getDireccion
            users.email = user.getEmail

            FilePut(1, users, 2)
            MsgBox("Registro guardado correctamente.", 64, "Información")
        Catch ex As Exception
            MsgBox(Err.Description & "Fallo en al guardar el registro, por favor vuelva a intentarlo", 48, "Fallo escritura")
            registrarErrores(Err.Description)
        End Try
        FileClose(1)
    End Sub

    'metodo para la lectura de un registro de tipo usuario. se pasa por parametro el codigo para buscar en el fichero.
    'retorna un objeto de tipo usuario para poder trabajar con él.
    Public Function leerUsuario(ByVal codigo As Integer) As Usuario

        Try
            FileOpen(1, "ficheros\usuarios", OpenMode.Random, OpenAccess.Read,, Len(users))
            FileGet(1, users, codigo)

        Catch ex As Exception
            MsgBox("Fallo en la lectura, por favor vuelva a intentarlo", 48, "Fallo lectura")
            registrarErrores(Err.Description)
        End Try
        FileClose(1)
        Try
            Dim user As New Usuario(users.codigo.Trim(" "), users.contrasenna.Trim(" "), users.nombre.Trim(" "), users.apellido1.Trim(" "), users.apellido2.Trim(" "), users.dni.Trim(" "), users.email.Trim(" "), users.direccion.Trim(" "), users.telefono.Trim(" "))
        Catch ex As Exception
            MsgBox("Porfavor, selecciona un usuario a editar.", 64, "Seleccion un usuario")
        End Try

        Return user
    End Function


    'metodo que verifica si el nombre y la contraseña coincide con algun registro del fichero para poder entrar al programa.
    'se pasa por parametro 
    Public Function verifUser(ByVal nombre As String, ByVal contrasenna As String) As Boolean
        Dim verif As Boolean
        Dim c As Integer = 1
        Try
            FileOpen(1, "ficheros\usuarios", OpenMode.Random, OpenAccess.Read,, Len(users))
            While Not EOF(1)
                FileGet(1, users, c)
                If users.nombre.Trim(" ") = nombre And users.contrasenna.Trim(" ") = contrasenna Then
                    verif = True
                    Exit While
                Else
                    verif = False

                End If
                c = c + 1

            End While

        Catch ex As Exception
            MsgBox("Fallo en la lectura, por favor vuelva a intentarlo", 48, "Fallo Lectura")
            registrarErrores(Err.Description)
        End Try

        FileClose(1)
        Return verif


    End Function
    'metodo para listar los usuarios que devuelve una List de todos ellos, si se ha borrado alguno se obvia ese registro para que no se muestre.
    Public Function listarUsuario() As List(Of Usuario)
        Dim c As Integer = 1
        Dim list As New List(Of Usuario)
        Try
            FileOpen(1, "ficheros\usuarios", OpenMode.Random, OpenAccess.Read,, Len(users))
            While Not EOF(1)
                FileGet(1, users, c)
                If Not String.IsNullOrWhiteSpace(users.codigo) Then
                    Dim user As New Usuario(users.codigo.Trim(" "), users.contrasenna.Trim(" "), users.nombre.Trim(" "), users.apellido1.Trim(" "), users.apellido2.Trim(" "), users.dni.Trim(" "), users.email.Trim(" "), users.direccion.Trim(" "), users.telefono.Trim(" "))
                    list.Add(user)
                    c = c + 1
                Else
                    c = c + 1
                End If

            End While


        Catch ex As Exception
            MsgBox("Fallo en la lectura, por favor vuelva a intentarlo", 48, "Fallo Lectura")
            registrarErrores(Err.Description)
        End Try


        FileClose(1)
        Return list

    End Function


    'Metodo para borrar un registro de tipo usuario. se pasa por parametro el codigo para buscar en el fichero.

    Public Sub borrarUsuario(ByVal codigo As Integer)

        Try
            If codigo = 1 Then
                MsgBox("no se puede borrar al administrador.", 64, "Fallo al borrar")
                Exit Sub
            End If
            FileOpen(1, "ficheros\usuarios", OpenMode.Random, OpenAccess.Write,, Len(users))
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
            MsgBox("Fallo al borrar el registro, por favor vuelva a intentarlo", 48, "Fallos al borrar")
            registrarErrores(Err.Description)
        End Try
        FileClose(1)

    End Sub
    'Metodo para Guardar un registro de tipo producto. Se pasa por parametro un objeto de tipo producto
    Public Sub guardarProducto(ByVal producto As Producto)
        Dim c As Integer = producto.getCodigo
        Try
            FileOpen(2, "ficheros\productos", OpenMode.Random, OpenAccess.Write,, Len(product))

            product.codigo = producto.getCodigo
            product.nombre = producto.getNombre
            product.precio = producto.getPrecio

            FilePut(2, product, c)

            'MsgBox("Registro guardado correctamente.", 64, "Información")
        Catch ex As Exception
            MsgBox("Se produjo un fallo en la escritura del registro, por favor vuelva a intentarlo.", 48, "Fallo escritura")
            registrarErrores(Err.Description)
        End Try
        FileClose(2)

    End Sub

    'Metodo para leer un registro de tipo producto. se pasa por parametro el codigo para buscar el registro.
    Public Function leerProducto(ByVal codigo As Integer) As Producto
        FileClose(2)
        Try
            FileOpen(2, "ficheros\productos", OpenMode.Random, OpenAccess.Read,, Len(product))
            FileGet(2, product, codigo)
        Catch ex As Exception
            MsgBox("Se produjo un fallo en la lectura del registro, por favor vuelva a intentarlo", 48, "Fallo lectura")
            registrarErrores(Err.Description)
        End Try

        Dim prod As New Producto(product.codigo.Trim(" "), product.nombre.Trim(" "), product.precio)
        FileClose(2)
        Return prod
    End Function

    'Metodo para borrar un registro de tipo producto. se pasa por parametro el codigo para buscar el registro. 
    Public Sub borrarProducto(ByVal codigo As Integer)
        FileClose(2)
        Try
            FileOpen(2, "ficheros\productos", OpenMode.Random, OpenAccess.Write,, Len(product))
            product.codigo = ""
            product.nombre = ""
            product.precio = 0
            FilePut(2, product, codigo)
            MsgBox("registro borrado correctamente", 64, "Información")
        Catch ex As Exception
            MsgBox("Se produjo un fallo al borrar el registro, por favor vuelva a intentarlo", 48, "Fallos al borrar")
            registrarErrores(Err.Description)
        End Try
        FileClose(2)

    End Sub

    'metodo para listar todos los productos que haya en el fichero. 
    'devuelve el la lista con todos los productos
    Public Function listarProductos() As List(Of Producto)
        Dim c As Integer = 1
        FileClose(2)
        Dim list As New List(Of Producto)
        Try

            FileOpen(2, "ficheros\productos", OpenMode.Random, OpenAccess.Read,, Len(product))
            While Not EOF(2)
                FileGet(2, product, c)
                If product.codigo.Trim(" ") <> "" Then
                    Dim productoLista As New Producto(product.codigo.Trim(" "), product.nombre.Trim(" "), product.precio)
                    list.Add(productoLista)
                    c = c + 1
                End If

            End While

        Catch ex As Exception
            MsgBox("Fallo en la lectura, por favor vuelva a intentarlo", 48, "Fallo Lectura")
            registrarErrores(Err.Description)
        End Try

        FileClose(2)
        Return list
    End Function

    'metodo para registrar los errores en un fichero. Se pasa por parametro el mensaje de error.
    Public Sub registrarErrores(ByVal mError As String)
        Try
            FileOpen(3, "ficheros\errores", OpenMode.Append, OpenAccess.Read,,)

            PrintLine(3, mError, Now)

        Catch ex As Exception
            MsgBox("Se produjo un fallo en la escritura del registro, por favor vuelva a intentarlo", 48, "Fallo escritura")

        End Try
        FileClose(3)

    End Sub

    'metodo para registrar los accesos de todos los usuarios que entran a la aplicacion.
    'Se pasa por parametro el nombre y la contraseña del usuario que accede.
    Public Sub registrarAcesso(ByVal nombre As String, ByVal contrasenna As String)
        Try
            FileOpen(4, "ficheros\fich_accesos", OpenMode.Append, OpenAccess.Write,,)

            PrintLine(4, nombre, contrasenna, Now)
        Catch ex As Exception
            MsgBox("Se produjo un fallo en la escritura del registro, por favor vuelva a intentarlo", 48, "Fallo escritura")
            registrarErrores(Err.Description)
        End Try
        FileClose(4)

    End Sub



End Class
