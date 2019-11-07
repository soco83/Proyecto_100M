Public Class FormMain
    Private Sub Cerrar_SesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Cerrar_SesionToolStripMenuItem.Click
        'Dim a As Integer = MsgBox("¿Seguro que desea salir?", MsgBoxStyle.YesNo)
        'If a = MsgBoxResult.Yes Then
        '    End
        'End If
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FLPcasa.Visible = True
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
    End Sub

    'métodos que controlan lo que hacen los botones de cada grupo
    Private Sub BtnCasa_Click(sender As Object, e As EventArgs) Handles m18.Click, m17.Click, m16.Click, m15.Click, m14.Click, m13.Click, m12.Click, m11.Click, m10.Click, m09.Click, m08.Click, m07.Click, m06.Click, m05.Click, m04.Click, m03.Click, m02.Click, m01.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
    End Sub
    Private Sub BtnsClasics_Click(sender As Object, e As EventArgs) Handles m59.Click, m58.Click, m57.Click, m56.Click, m55.Click, m54.Click, m53.Click, m52.Click, m51.Click, m50.Click, m49.Click, m48.Click, m47.Click, m46.Click, m45.Click, m44.Click, m43.Click, m42.Click, m41.Click, m40.Click, m39.Click, m38.Click, m37.Click, m36.Click, m35.Click, m34.Click, m33.Click, m32.Click, m31.Click, m30.Click, m29.Click, m28.Click, m27.Click, m26.Click, m25.Click, m24.Click, m23.Click, m22.Click, m21.Click, m20.Click, m19.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
    End Sub
    Private Sub BtnsEspecials_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button30.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
    End Sub
    Private Sub BtnsDulces_Click(sender As Object, e As EventArgs) Handles m94.Click, m93.Click, m92.Click, m91.Click, m90.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
    End Sub
    Private Sub BtnsSuper_Click(sender As Object, e As EventArgs) Handles m99.Click, m98.Click, m97.Click, m96.Click, m95.Click, m100.Click
        'Dim name As String = m99.Name
        'If name = m99.Name Then
        '    MsgBox("boton 99")
        'End If
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
    End Sub
    Private Sub BtnsDrinks_Click(sender As Object, e As EventArgs) Handles Button47.Click, Button46.Click, Button45.Click, Button44.Click, Button43.Click, Button42.Click, Button41.Click, Button40.Click, Button39.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click
        Dim botonActual As Button
        botonActual = sender
        TxBDatos.Text = botonActual.Text
    End Sub

    'métodos de los botones que controlan que grupo de botones aparece en pantalla
    Private Sub BtnMenuCasa_Click(sender As Object, e As EventArgs) Handles BtnMenuCasa.Click
        FLPcasa.Visible = True
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
    End Sub
    Private Sub BtnMenuClasicos_Click(sender As Object, e As EventArgs) Handles BtnMenuClasicos.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = True
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
    End Sub
    Private Sub BtnMenuEspeciales_Click(sender As Object, e As EventArgs) Handles BtnMenuEspeciales.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = True
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
    End Sub
    Private Sub BtnMenuDulces_Click(sender As Object, e As EventArgs) Handles BtnMenuDulces.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = True
        FLPSuper.Visible = False
        FLPDrinks.Visible = False
    End Sub
    Private Sub BtnMenuSuper_Click(sender As Object, e As EventArgs) Handles BtnMenuSuper.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = True
        FLPDrinks.Visible = False
    End Sub
    Private Sub BtnMenuDrinks_Click(sender As Object, e As EventArgs) Handles BtnMenuDrinks.Click
        FLPcasa.Visible = False
        FLPClasic.Visible = False
        FLPespecials.Visible = False
        FLPdulces.Visible = False
        FLPSuper.Visible = False
        FLPDrinks.Visible = True
    End Sub


End Class
