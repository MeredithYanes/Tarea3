Module Module1
    Public Const LE_P = 25
    Public Const LE_M = 35
    Public Const LE_G = 45
    Public Const En_P = 30
    Public Const En_M = 40
    Public Const En_G = 50
    Public Const LI_P = 30
    Public Const LI_M = 40
    Public Const LI_G = 50
    Public Const Pu_P = 90
    Public Const Pu_M = 100
    Public Const Pu_G = 110
    Public Const LM_P = 100
    Public Const LM_M = 125
    Public Const LM_G = 300

    Public A As Integer
    Public B As Integer
    Public C As Integer
    Public D As Integer
    Public F As Integer

    Public Subtotal As Integer
    Public Descuento1 As Double
    Public Descuento2 As Double
    Public Total As Double

    Sub LIMPIAR_ENTRADAS()
       Form1.CheckBox1.Checked = False
        'Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.CheckBox4.Checked = False
        Form1.CheckBox5.Checked = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form2.TextBox1.Clear()
        Form2.TextBox2.Clear()
        Form2.TextBox3.Clear()
        Form2.TextBox4.Clear()
    End Sub
    Sub Mostrar_Resultados()
        MsgBox(Subtotal)
    End Sub
End Module
