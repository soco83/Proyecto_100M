Public Class Usuario
    Dim codigo, password, nombre, ape1, ape2, dni, email, direccion As String
    Dim tel As String


    Public Sub New(ByVal codigo As String, ByVal password As String, ByVal nombre As String, ByVal ape1 As String, ByVal ape2 As String, ByVal dni As String, ByVal email As String, ByVal direccion As String, ByVal tel As String)
        Me.codigo = codigo
        Me.password = password
        Me.nombre = nombre
        Me.ape1 = ape1
        Me.ape2 = ape2
        Me.dni = dni
        Me.email = email
        Me.direccion = direccion
        Me.tel = tel
    End Sub


    Public Function getCodigo()
        Return Me.codigo
    End Function
    Public Function getPassword()
        Return Me.password
    End Function
    Public Function getNombre()
        Return Me.nombre
    End Function
    Public Function getApe1()
        Return Me.ape1
    End Function
    Public Function getApe2()
        Return Me.ape2
    End Function
    Public Function getDNI()
        Return Me.dni
    End Function
    Public Function getEmail()
        Return Me.email
    End Function
    Public Function getDireccion()
        Return Me.dni
    End Function
    Public Function getTel()
        Return Me.tel
    End Function

    Public Sub setPasword(ByRef password As String)
        Me.password = password
    End Sub
    Public Sub setNombre(ByRef nombre As String)
        Me.nombre = nombre
    End Sub
    Public Sub setApe1(ByRef ape1 As String)
        Me.ape1 = ape1
    End Sub
    Public Sub setApe2(ByRef ape2 As String)
        Me.ape2 = ape2
    End Sub
    Public Sub setDNI(ByRef dni As String)
        Me.dni = dni
    End Sub
    Public Sub setEmail(ByRef email As String)
        Me.email = email
    End Sub
    Public Sub setDireccion(ByRef direccion As String)
        Me.dni = direccion
    End Sub
    Public Sub setTel(ByRef tel As String)
        Me.tel = tel
    End Sub
End Class
