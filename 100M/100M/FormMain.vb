Imports B_C_100M
Imports System.Drawing.Printing
Public Class FormMain
    Public nombreUsuario As String
    Dim precio, total As Single
    Public elClienteHaPagado, aDevolver As Single
    Public seHaPagado As Boolean = False

    Dim file As New Ficheros




    Private Sub Cerrar_SesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Cerrar_SesionToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        LbFechaHora.Text = Now
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'se carga por defecto al iniciarse el form el primer grupo de botones.
        FLPcasa.Visible = True
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
        FLPpicar.Visible = False

        TxBUsuarioConectado.Text = nombreUsuario
        If Not nombreUsuario = "admin" Then 'file.leerUsuario(4).getNombre Then
            UsuariosToolStripMenuItem.Visible = False
            ProductosToolStripMenuItem.Visible = False
        Else
            UsuariosToolStripMenuItem.Visible = True
            ProductosToolStripMenuItem.Visible = True
        End If
    End Sub

    'métodos que controlan lo que hacen los botones de cada grupo
    'se crea un objeto de la clase Button y se iguala al objeto sender:
    '   esto se hace para saber cuál de los botones dentro del grupo se ha presionado
    'sabiendo eso ya se puede diferenciar, y no hay que programar 100+ métodos. xd

    ' ESTOS BOTONES SOLO INTRODUCEN LOS DATOS DE LOS PRODUCTOS QUE REPRESENTAN EN EL TEXBOX DE ABAJO
    Private Sub BtnCasa_Click(sender As Object, e As EventArgs) Handles m18.Click, m17.Click, m16.Click, m15.Click, m14.Click, m13.Click, m12.Click, m11.Click, m10.Click, m09.Click, m08.Click, m07.Click, m06.Click, m05.Click, m04.Click, m03.Click, m02.Click, m01.Click
        Dim botonActual As Button
        botonActual = sender
        'a partir de aquí ya se ha diferenciado.
        TxBDatos.Text = botonActual.Text
        precio = 1
    End Sub
    Private Sub BtnsClasics_Click(sender As Object, e As EventArgs) Handles m59.Click, m58.Click, m57.Click, m56.Click, m55.Click, m54.Click, m53.Click, m52.Click, m51.Click, m50.Click, m49.Click, m48.Click, m47.Click, m46.Click, m45.Click, m44.Click, m43.Click, m42.Click, m41.Click, m40.Click, m39.Click, m38.Click, m37.Click, m36.Click, m35.Click, m34.Click, m33.Click, m32.Click, m31.Click, m30.Click, m29.Click, m28.Click, m27.Click, m26.Click, m25.Click, m24.Click, m23.Click, m22.Click, m21.Click, m20.Click, m19.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
        precio = 1.2
    End Sub
    Private Sub BtnsEspecials_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button30.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
        precio = 1.5
    End Sub
    Private Sub BtnsDulces_Click(sender As Object, e As EventArgs) Handles m94.Click, m93.Click, m92.Click, m91.Click, m90.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
        precio = 1.5
    End Sub
    Private Sub BtnsSuper_Click(sender As Object, e As EventArgs) Handles m99.Click, m98.Click, m97.Click, m96.Click, m95.Click, m100.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
        precio = 2
    End Sub
    Private Sub BtnsDrinks_Click(sender As Object, e As EventArgs) Handles Button47.Click, Button46.Click, Button45.Click, Button44.Click, Button43.Click, Button42.Click, Button41.Click, Button40.Click, Button39.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
        Select Case TxBDatos.Text
            Case "Refresco cola/fanta"
                precio = 1.8
            Case "Refresco acuarius/nestea", "Moster", "Jarra Heineken"
                precio = 2
            Case "Appletiser"
                precio = 2.2
            Case "Agua"
                precio = 1.3
            Case "Zumo", "Vino"
                precio = 1.7
            Case "Batido", "Jarra tinto", "Jarra Cruzcampo", "Jarra Ladrón"
                precio = 1.5
            Case "Infusiones", "Caña Cruzcampo", "Café", "Caña Radler"
                precio = 1
            Case "Vaso Paulaner"
                precio = 2.5
        End Select
    End Sub
    Private Sub BtnsPicar_Click(sender As Object, e As EventArgs) Handles Button58.Click, Button57.Click, Button56.Click, Button55.Click, Button54.Click, Button53.Click, Button52.Click, Button51.Click, Button50.Click, Button49.Click, Button48.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
        Select Case TxBDatos.Text
            Case "Aceitunas", "Chips"
                precio = 1
            Case "Nachos guacamole", "Nachos queso", "Patatas mayo.", "Patatas queso", "Patatas trufa", "Palomitas queso", "Palomitas pollo", "Salchichas"
                precio = 2
            Case "Alitas de pollo"
                precio = 2.5
        End Select
    End Sub

    'método que añade lo que haya en el TextBox de datos al tiquet
    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Dim TEXT_MAL As String = "- Haz click en un producto para ver sus datos -"

        Dim prod As New Producto(1, TxBDatos.Text, precio)

        If Not TxBDatos.Text = TEXT_MAL Then
            'se comprueba que en el tiquet no esté ya el producto.
            If Not LBTiquet.Items.Contains(prod.getNombre()) Then
                'si el producto no está en el tiquet, se añade el nombre al LBTiquet
                '   y la cantidad a esa misma posición, que al principio es 1.
                LBTiquet.Items.Add(prod.getNombre())
                LBCantidad.Items.Insert(LBTiquet.Items.IndexOf(prod.getNombre()), 1)
                LBPrecio.Items.Insert(LBTiquet.Items.IndexOf(prod.getNombre()), precio)

            ElseIf LBTiquet.Items.Contains(prod.getNombre()) Then
                'si sí está, se recoge el valor de la cantidad del LBCantidad en la
                '   posición del producto que se quiere aumentar y se aumenta en 1.
                '   Después se borra ese registro y se vuelve a introducir con el valor
                '   de la cantidad actualizado.
                Dim cant As Integer = CInt(LBCantidad.Items.Item(LBTiquet.Items.IndexOf(prod.getNombre())))
                cant += 1

                Dim price As Single = CSng(LBPrecio.Items.Item(LBTiquet.Items.IndexOf(prod.getNombre())))
                price += precio

                LBCantidad.Items.RemoveAt(LBTiquet.Items.IndexOf(prod.getNombre()))
                LBCantidad.Items.Insert(LBTiquet.Items.IndexOf(prod.getNombre()), cant)

                LBPrecio.Items.RemoveAt(LBTiquet.Items.IndexOf(prod.getNombre()))
                LBPrecio.Items.Insert(LBTiquet.Items.IndexOf(prod.getNombre()), price)
            End If
            actualizarPrecio()
        Else
            MsgBox("Selecciona un producto a meter en el tiquet.")
        End If
    End Sub

    Public Sub actualizarPrecio()
        total = 0
        Try
            For a = 0 To LBTiquet.Items.Count
                total += CSng(LBPrecio.Items.Item(a))
            Next
        Catch ex As Exception

        End Try
        LbPrecioTotal.Text = total
    End Sub

    'métodos de los botones de las categorías de productos
    '   que controlan que grupo de botones aparece en pantalla.
    Private Sub BtnMenuCasa_Click(sender As Object, e As EventArgs) Handles BtnMenuCasa.Click
        FLPcasa.Visible = True
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
        FLPpicar.Visible = False
    End Sub
    Private Sub BtnMenuClasicos_Click(sender As Object, e As EventArgs) Handles BtnMenuClasicos.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = True
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
        FLPpicar.Visible = False
    End Sub
    Private Sub BtnMenuEspeciales_Click(sender As Object, e As EventArgs) Handles BtnMenuEspeciales.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = True
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
        FLPpicar.Visible = False
    End Sub
    Private Sub BtnMenuDulces_Click(sender As Object, e As EventArgs) Handles BtnMenuDulces.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = True
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
        FLPpicar.Visible = False
    End Sub
    Private Sub BtnMenuSuper_Click(sender As Object, e As EventArgs) Handles BtnMenuSuper.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = True
        FLPDrinks.Visible = False
        FLPpicar.Visible = False
    End Sub
    Private Sub BtnMenuDrinks_Click(sender As Object, e As EventArgs) Handles BtnMenuDrinks.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = True
        FLPpicar.Visible = False
    End Sub
    Private Sub BtnMenuPicar_Click(sender As Object, e As EventArgs) Handles BtnMenuPicar.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
        FLPpicar.Visible = True
    End Sub

    Private Sub NuevoUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUToolStripMenuItem.Click
        'llama al form donde se crean usuarios nuevos
        GestionUsuarios.opentype = 1
        GestionUsuarios.Show()
    End Sub
    Private Sub VerListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListaToolStripMenuItem.Click
        'llama al form donde se visualiza la lista de usuarios
        Lista_Users_Prods.openType = 1
        Lista_Users_Prods.Show()
    End Sub

    Private Sub NuevoPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoPToolStripMenuItem1.Click
        'llama al form donde se crean productos nuevos
        GestionProductos.openType = 1
        GestionProductos.Show()
    End Sub
    Private Sub VerListaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerListaToolStripMenuItem1.Click
        'llama al form donde se visualiza la lista de productos
        Lista_Users_Prods.openType = 2
        Lista_Users_Prods.Show()
    End Sub

    Private Sub CajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CajaToolStripMenuItem.Click

    End Sub

    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        Pago.importe = total
        Pago.Show()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        If seHaPagado = True Then
            Try
                AddHandler PrintDocument1.PrintPage, AddressOf imprimirTiquet
                PrintDocument1.Print()
            Catch ex As Exception
                MsgBox("Error durante la impresión del tiquet. Compruebe que la impresora está conectada al ordenador, está enchufada, tiene papel y tinta...", MsgBoxStyle.Exclamation)
            End Try
        Else
            MsgBox("Todavía no se ha pagado, diríjase a la ventana de pago.", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub imprimirTiquet(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim foto As String = "C:\Users\Óscar\OneDrive\Pictures\Saved Pictures\Desarrollo de interfaces (DAM2)\100M_inicio.png"
        Try
            Dim y As Integer = 0

            'se imprime la imagen del principio
            ev.Graphics.DrawImage(Image.FromFile(foto), 120, y, 318, 159)
            y += 120

            'se imprime la cabecera de información del local
            Dim cabecera As String
            cabecera = "Princesa 7" & vbCrLf & "28008 Madrid" & vbCrLf & "MontaPrincesa 7 SL" & vbCrLf & "CIF: B8598903" & vbCrLf & "FACTURA SIMPLIFICADA"
            ev.Graphics.DrawString(cabecera, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 100

            'separador
            Dim separador As String = "------------------------------------------------"
            ev.Graphics.DrawString(separador, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 20

            'se imprimen datos secundarios
            Dim secundarios As String
            secundarios = "Nº T422154213        PN 0262" & vbCrLf & "   " & Now
            ev.Graphics.DrawString(secundarios, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 40

            'se imprime el cuerpo del tiquet, los productos.
            Dim a As Integer
            Dim tiquet As String
            tiquet = ""
            For a = 0 To LBTiquet.Items.Count - 1
                '                      (que quieres imprimir,                                                                                   cómo lo quieres imprimir,                color, coordenada x en el papel, coordenada y)
                ev.Graphics.DrawString(LBCantidad.Items.Item(a) & "   " & LBTiquet.Items.Item(a).ToString.Trim("\n") & "                " & LBPrecio.Items.Item(a), New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
                'salto de línea
                y += 20
            Next

            'separador  
            ev.Graphics.DrawString(separador, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 20

            'se imprime el total del tiquet
            Dim euros As String = "             TOTAL: " & total & "€" & vbCrLf & "              IVA INCLUIDO"
            ev.Graphics.DrawString(euros, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 40

            'separador  
            ev.Graphics.DrawString(separador, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 20

            'se imprime el apartado de impuestos del tiquet
            Dim impuestos As String
            Dim baseImponible, iva As Single
            iva = total * 0.1
            baseImponible = total - iva
            impuestos = "Base Imp       %IVA        IVA" & vbCrLf &
                        "     " & baseImponible & "          10         " & iva & vbCrLf &
                        "              Forma de pago:" & vbCrLf &
                        " EFECTIVO:" & elClienteHaPagado & vbCrLf &
                        " ENTREGA: " & elClienteHaPagado & vbCrLf &
                        " DEVOLUCIÓN: " & aDevolver & vbCrLf &
                        "           Le antendió: " & nombreUsuario
            ev.Graphics.DrawString(impuestos, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 140

            'separador  
            ev.Graphics.DrawString(separador, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 40

            'separador  
            ev.Graphics.DrawString(separador, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 20

            'se imprime la despedida
            Dim despedia As String = "              CONSERVE SU TIQUET" & vbCrLf &
                                     "         HASTA LA RETIRADA DE SU PRODUCTO" & vbCrLf &
                                     "             GRACIAS POR SU VISITA"
            ev.Graphics.DrawString(despedia, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBorrarLinea_Click(sender As Object, e As EventArgs) Handles BtnBorrarLinea.Click
        Try
            LBCantidad.Items.RemoveAt(LBTiquet.Items.IndexOf(LBTiquet.SelectedItem))
            LBPrecio.Items.RemoveAt(LBTiquet.Items.IndexOf(LBTiquet.SelectedItem))
            LBTiquet.Items.Remove(LBTiquet.SelectedItem)
            actualizarPrecio()
        Catch ex As ArgumentNullException
            MsgBox("Selecciona un producto a eliminar del tiquet.", MsgBoxStyle.Information)
        End Try
    End Sub
End Class
