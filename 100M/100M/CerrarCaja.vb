Public Class CerrarCaja
    Public recaudacion, total As Single
    Private Sub CerrarCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total += recaudacion
        LbRecaudacion.Text = total
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'se guarda el registro en el fichero
        Me.Close()
    End Sub
End Class