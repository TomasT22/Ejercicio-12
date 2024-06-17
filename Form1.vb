Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim numero, resto, suma As Integer
        suma = 0
        resto = 0
        numero = txtIngresar.Text
        Do While numero >= 10
            suma = 0
            Do While numero > 0
                resto = numero Mod 10
                suma = suma + resto
                numero = (numero - resto) / 10
            Loop
            numero = suma
        Loop
        lblMinimaUnidad.Text = "La minima unidad es: " & numero
    End Sub
End Class
