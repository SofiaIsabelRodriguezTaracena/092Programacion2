Public Class Form1

    Const precioarroz As Double = 2.0
    Const preciofrijol As Double = 1.75
    Const precioazucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim PagosinIva As Double = 0
    Dim valordeliva As Double = 0
    Dim pagoconiva As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0


    Private Sub Buttonaceptar_Click(sender As Object, e As EventArgs) Handles Buttonaceptar.Click
        PagosinIva = (Val(tarroz.Text) * precioarroz) + (Val(tfrijol.Text) * preciofrijol) + (Val(tazucar.Text) * precioazucar)
        valordeliva = PagosinIva * IVA
        pagoconiva = PagosinIva + valordeliva
        descuento = pagoconiva * 0.025
        pagofinal = pagoconiva - descuento

        LR1.Text = PagosinIva
        LR2.Text = valordeliva
        LR3.Text = pagoconiva
        LR5.Text = descuento
        LR6.Text = pagofinal


    End Sub

    Private Sub Buttonlimpiar_Click(sender As Object, e As EventArgs) Handles Buttonlimpiar.Click
        tarroz.Text = "0"
        tfrijol.Text = "0"
        tazucar.Text = "0"
        LR1.Text = "0"
        LR2.Text = "0"
        LR3.Text = "0"
        LR5.Text = "0"
        LR6.Text = "0"

    End Sub

    Private Sub Buttonsalir_Click(sender As Object, e As EventArgs) Handles Buttonsalir.Click
        Me.Close()
    End Sub

    Private Sub tarroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tarroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tfrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tfrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tazucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tazucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
