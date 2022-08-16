Public Class Form2

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Subtotal
        Mostrar_Resultados()

        If (Form1.CheckBox4.Checked) Then
            Descuento1 = Subtotal * 0.1
        ElseIf (Form1.CheckBox1.Checked) Then
            Descuento1 = Subtotal * 0.08
        ElseIf (Form1.CheckBox2.Checked) Then
            Descuento1 = Subtotal * 0.03
        End If
        TextBox2.Text = Descuento1

        If Subtotal > 50 And Subtotal < 100 Then
            Descuento2 = Subtotal * 0.03
        ElseIf Subtotal > 110 And Subtotal < 200 Then
            Descuento2 = Subtotal * 0.05
        ElseIf Subtotal > 200 And Subtotal < 300 Then
        Else : Descuento1 = 0
        End If
        TextBox3.Text = Descuento2
        Total = Subtotal - Descuento1 - Descuento2
        TextBox4.Text = Total
    End Sub
End Class