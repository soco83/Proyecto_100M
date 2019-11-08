Public Class Inicio
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim a As Integer = MsgBox("¿Seguro que desea salir?", 292)
        If a = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class