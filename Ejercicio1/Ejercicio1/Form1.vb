Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim Datos As Distancia = New Distancia()
        Distanciaaa.Text = Datos.CalcularDistancia(Txt1.Text, txt2.Text, txt3.Text, txt4.Text)
    End Sub
End Class
