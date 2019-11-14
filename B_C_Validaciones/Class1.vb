Public Class Validar
    Dim a, i, j As Integer
    Dim c, x As Char

    Public Function validarTel(ByVal tel As String) As Boolean
        'Valida sin prefijo asumiendo español +34
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<> "

        For a = 1 To tel.Length
            c = GetChar(tel, a)
            For i = 1 To s.Length
                If c = GetChar(s, a) Then
                    valido = False
                End If
            Next
            If Not IsNumeric(c) Then
                valido = False
            End If
        Next
        If IsNumeric(tel) Then
            If CLng(tel) > 600000000 And CLng(tel) < 740000000 Then
                valido = True
            Else valido = False
            End If
        End If

        Return valido
    End Function
    Public Function validarDni(ByVal dni As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<> "
        Dim aux As String


        For a = 1 To dni.Length
            c = GetChar(dni, a)
            If Not IsNumeric(c) And a < dni.Length Then
                valido = False
            End If
            For i = 1 To s.Length
                If c = GetChar(s, a) Then
                    valido = False
                End If
            Next
            If dni.Length <> 9 Then
                valido = False
            End If
            If a = dni.Length Then
                If IsNumeric(c) Then
                    valido = False
                End If
            End If
            'If a = dni.Length And valido = True Then
            'aux = dni.Remove(dni.Length - 1)

            'If UCase(c) <> letraNif(aux) Then
            'valido = False
            'End If
            'End If



        Next

        Return valido
    End Function
    Public Function letraNif(ByVal dni As Integer) As Char
        Dim x2 As Integer
        Dim y As Integer
        Dim nletra As Integer
        Dim letra As Char
        x2 = (dni / 23)
        y = (x2 * 23)
        nletra = dni - y
        Dim tab() As Char = {"T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "O", "H", "L", "C", "K", "E", "G", "V"}
        letra = tab(nletra)

        Return letra
    End Function
    Public Function validarMail(ByVal mail As String) As Boolean
        Dim valido As Boolean = True
        Dim dom As Integer = 30
        Dim ext As Integer = 40
        Dim nopunto As Boolean = True
        Dim noarroba As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;:-_<>"
        Dim s2 As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;:-_<>."
        If mail.Contains(".") And mail.Contains("@") Then
            valido = True
        Else
            valido = False
        End If

        For a = 1 To mail.Length
            c = GetChar(mail, a)
            If c = "@" And noarroba = True Then
                dom = a
                noarroba = False
            End If
            If a > dom Then
                For i = 1 To s.Length
                    If c = GetChar(s, i) Then
                        valido = False
                    End If
                Next
                'Se permiten números en el dominio
                If c = "." And nopunto = True Then
                    ext = a
                    nopunto = False
                End If
                If a > ext Then
                    For i = 1 To s2.Length
                        If c = GetChar(s2, i) Then
                            valido = False
                        End If
                    Next
                    If IsNumeric(c) Then
                        valido = False
                    End If
                End If
            End If
        Next
        If dom > ext Then
            valido = False
        End If

        If mail.Length = ext Then
            valido = False
        End If
        If Not mail.Substring(dom).Contains(".") Then
            valido = False
        End If
        Return valido
    End Function
    Public Function validarNombre(ByVal nom As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To nom.Length
            c = GetChar(nom, i)
            If IsNumeric(c) Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If
        Next
        Return valido
    End Function
    Public Function validarApel(ByVal ape As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To ape.Length
            c = GetChar(ape, i)
            If IsNumeric(c) Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If
        Next
        Return valido
    End Function
    Public Function validarCalle(ByVal cal As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To cal.Length
            c = GetChar(cal, i)
            If IsNumeric(c) Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If
        Next
        Return valido
    End Function
    Public Function validarNum(ByVal num As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To num.Length
            c = GetChar(num, i)
            If Not IsNumeric(c) Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If

        Next
        If IsNumeric(num) Then
            If CInt(num) < 1 Or CInt(num) > 200 Then
                valido = False
            End If
        End If

        Return valido
    End Function
    Public Function validarEsc(ByVal esc As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To esc.Length
            c = GetChar(esc, i)
            If Not IsNumeric(c) Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If

        Next
        If IsNumeric(esc) Then
            If CInt(esc) < 1 Or CInt(esc) > 10 Then
                valido = False
            End If
        End If
        Return valido
    End Function
    Public Function validarPiso(ByVal piso As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To piso.Length
            c = GetChar(piso, i)
            If Not IsNumeric(c) Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If

        Next
        If IsNumeric(piso) Then

            If CInt(piso) < 1 Or CInt(piso) > 30 Then
                valido = False
            End If
        End If
        Return valido
    End Function


    Public Function validarLetra(ByVal letra As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To letra.Length
            c = GetChar(letra, i)
            If IsNumeric(c) Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If
        Next
        If letra.Length > 1 Then
            valido = False
        End If
        Return valido
    End Function

    Public Function validarCP(ByVal cp As String) As Boolean
        Dim valido As Boolean = True
        Dim prim As Integer
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To cp.Length

            c = GetChar(cp, i)

            If Not IsNumeric(c) Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If

            If i = 1 Then
                prim = CInt(c.ToString)
                If prim > 5 Then
                    valido = False
                End If
            End If

        Next

        If cp.Length < 5 Or cp.Length > 5 Then
            valido = False
        End If
        Return valido
    End Function
    Public Function validarPrecio(ByVal num As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç.;:-_<>"
        For i = 1 To num.Length
            c = GetChar(num, i)
            If Not IsNumeric(c) And c <> "," Then
                valido = False
            Else
                For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next
            End If

        Next
        Return valido
    End Function

    Public Function validarDescr(ByVal descr As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%¬/()=?'¿¡€`^[*+]¨´{ç}Ç;.-_<>"
        For i = 1 To descr.Length
            c = GetChar(descr, i)
            For j = 1 To s.Length
                    If c = GetChar(s, j) Then
                        valido = False
                    End If
                Next


        Next
        Return valido
    End Function
    Public Function validarNumProd(ByVal num As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#$%&¬/()=?'¿¡€`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To num.Length
            c = GetChar(num, i)
            If Not IsNumeric(c) Then
                valido = False
            End If
            For j = 1 To s.Length
                If c = GetChar(s, j) Then
                    valido = False
                End If
            Next

        Next
        If IsNumeric(num) Then
            If CInt(num) > 200 Then
                valido = False
            End If
        End If

        Return valido
    End Function
    Public Function validarDescu(ByVal descu As String) As Boolean
        Dim valido As Boolean = True
        Dim s As String = "ºª\!|@·#&¬/()=?'¿¡`^[*+]¨´{ç}Ç,;.:-_<>"
        For i = 1 To descu.Length
            c = GetChar(descu, i)
            For j = 1 To s.Length
                If c = GetChar(s, j) Then
                    valido = False
                End If
            Next
        Next
        Return valido
    End Function

End Class

