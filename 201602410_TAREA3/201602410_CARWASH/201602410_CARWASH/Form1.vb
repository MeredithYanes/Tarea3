Public Class Form1
        

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (CheckBox1.Checked) And (RadioButton1.Checked) Then
            A = LE_P
        ElseIf (CheckBox1.Checked) And (RadioButton2.Checked) Then
            A = LE_M
        ElseIf (CheckBox1.Checked) And (RadioButton3.Checked) Then
            A = LE_G
        Else : A = 0
        End If

        If (CheckBox2.Checked) And (RadioButton1.Checked) Then
            B = En_P
        ElseIf (CheckBox2.Checked) And (RadioButton2.Checked) Then
            B = En_M
        ElseIf (CheckBox2.Checked) And (RadioButton3.Checked) Then
            B = En_G
        Else : B = 0
        End If

        If (CheckBox3.Checked) And (RadioButton1.Checked) Then
            C = LI_P
        ElseIf (CheckBox3.Checked) And (RadioButton2.Checked) Then
            C = LI_M
        ElseIf (CheckBox3.Checked) And (RadioButton3.Checked) Then
            C = LI_G
        Else : C = 0
        End If

        If (CheckBox4.Checked) And (RadioButton1.Checked) Then
            D = Pu_P
        ElseIf (CheckBox4.Checked) And (RadioButton2.Checked) Then
            D = Pu_M
        ElseIf (CheckBox4.Checked) And (RadioButton3.Checked) Then
            D = Pu_G
        Else : D = 0
        End If

        If (CheckBox3.Checked) And (RadioButton1.Checked) Then
            F = LM_P
        ElseIf (CheckBox3.Checked) And (RadioButton2.Checked) Then
            F = LM_M
        ElseIf (CheckBox3.Checked) And (RadioButton3.Checked) Then
            F = LM_G
        Else : F = 0
        End If

        Subtotal = A + B + C + D
        Me.Hide()
        Form2.Show()
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class
