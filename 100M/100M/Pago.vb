Public Class Pago
    Public importe As Single
    Private Sub Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbImporte.Text = importe
    End Sub

    Private Sub TxBHaPagado_TextChanged(sender As Object, e As EventArgs) Handles TxBHaPagado.TextChanged
        Dim haPagado As Single
        Try
            haPagado = CSng(TxBHaPagado.Text)
            LbADevolver.Text = CSng(TxBHaPagado.Text) - importe
        Catch ex As Exception
            TxBHaPagado.Clear()
            TxBHaPagado.Focus()
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If CInt(TxBHaPagado.Text) < CInt(LbImporte.Text) Then
            MsgBox("Introduce un valor superior o igual al importe")
        Else
            FormMain.elClienteHaPagado = CSng(TxBHaPagado.Text)
            FormMain.aDevolver = CSng(LbADevolver.Text)
            FormMain.seHaPagado = True
            MsgBox("ahora se introduciría la venta en el registro")

            Me.Close()
        End If
    End Sub
End Class