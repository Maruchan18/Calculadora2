Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        tbresultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        DeterminarConcatenar()
        tbresultado.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        DeterminarConcatenar()
        tbresultado.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        DeterminarConcatenar()
        tbresultado.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        DeterminarConcatenar()
        tbresultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        DeterminarConcatenar()
        tbresultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        DeterminarConcatenar()
        tbresultado.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        DeterminarConcatenar()
        tbresultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        DeterminarConcatenar()
        tbresultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        DeterminarConcatenar()
        tbresultado.Text &= "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        DeterminarConcatenar()
        tbresultado.Text &= "0"
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        OperacionProceso()
        Operacion = ""
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        DeterminarConcatenar()
        If InStr(tbresultado.Text, ".", CompareMethod.Text) = 0 Then
            tbresultado.Text &= "."
        End If
    End Sub

    Private Sub btnmul_Click(sender As Object, e As EventArgs) Handles btnmul.Click
        OperacionProceso()
        Operacion = "*"
    End Sub

    Private Sub btnres_Click(sender As Object, e As EventArgs) Handles btnres.Click
        OperacionProceso()
        Operacion = "-"
    End Sub

    Private Sub btnsum_Click(sender As Object, e As EventArgs) Handles btnsum.Click
        OperacionProceso()
        Operacion = "+"
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        OperacionProceso()
        Operacion = "/"
    End Sub
    Private Sub DeterminarConcatenar()
        If Bandera = True Then
            tbresultado.Text = ""
            Bandera = False
        ElseIf tbresultado.Text = "0" Then
            tbresultado.Text = ""
        End If
    End Sub
    Private Sub OperacionProceso()
        Bandera = True
        Valor2 = Val(tbresultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
                Case "^"
                    ValorResultado ^= Valor2
                Case "√"
                    ValorResultado = ValorResultado ^ (1 / Valor2)
            End Select
            tbresultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnpot_Click(sender As Object, e As EventArgs) Handles btnpot.Click
        OperacionProceso()
        Operacion = "^"
    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        OperacionProceso()
        Operacion = "√"
    End Sub
End Class
