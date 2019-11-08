Public Class Ficheros
    'se genera la estructura para poder gestionar el fichero de productos
    Structure productos
        Dim cod As Integer
        <VBFixedArray(20)> Dim nombre As String
        Dim precio As Single
    End Structure
    Dim product As productos

    'se genera la estructura para poder gestionar el fichero de usuarios
    Structure usuarios
        <VBFixedArray(15)> Dim nombre As String
        <VBFixedArray(10)> Dim contrasenna As String
        <VBFixedArray(15)> Dim apellido1, apellido2 As String
        <VBFixedArray(9)> Dim dni, telefono As String
        <VBFixedArray(25)> Dim email As String
        <VBFixedArray(30)> Dim direccion As String
    End Structure
    Dim usuario As usuarios

    Public Sub guardarUsuario(ByVal user As Usuario)
        Dim usuario As Usuario = user
        Try
            FileOpen(1, "usuarios", OpenMode.Random, OpenAccess.Write,, Len(usuario))

        Catch ex As Exception

        End Try
    End Sub

End Class
