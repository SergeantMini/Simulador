Imports System.Threading.Tasks
Imports System.Timers
Public Class Form1
    'el color de aire es blanco
    'color de solución de sistema es azul
    'color de solución de calibración es amarillo
    'color de muestra de sangre es rojo

    Public Function CerrarTodoPaso()
        CBPinch1.CheckState = CheckState.Indeterminate
        CBPinch2.CheckState = CheckState.Indeterminate
        CBPinch3.CheckState = CheckState.Indeterminate
        CBPinch4.CheckState = CheckState.Indeterminate
        CBPos1.CheckState = CheckState.Indeterminate
        CBPos2.CheckState = CheckState.Indeterminate
        CBPos3.CheckState = CheckState.Indeterminate
        CBPos4.CheckState = CheckState.Indeterminate
        Return 0
    End Function

    Public Function Paso1y2()
        If (CBPos2.CheckState = CheckState.Indeterminate) Then
            Console.WriteLine("Abriendo válvula selectora en posición de solución del sistema")
            CBPos2.CheckState = CheckState.Unchecked
        End If
        If (CBPinch3.CheckState = CheckState.Indeterminate) Then
            Console.WriteLine("Abriendo válvula pinch 3")
            CBPinch3.CheckState = CheckState.Unchecked
        End If
        LSensGota1.BackColor = Color.LightBlue
        LValvSelect.BackColor = Color.LightBlue
        LPinch3.BackColor = Color.LightBlue
        LSensColor.BackColor = Color.LightBlue
        LCeldaMedicion.BackColor = Color.LightBlue
        Return 0
    End Function

    Public Function Paso3()
        CerrarTodoPaso()
        LSensGota1.BackColor = SystemColors.ButtonFace
        LValvSelect.BackColor = SystemColors.ButtonFace
        LPinch3.BackColor = Color.LightBlue
        LSensColor.BackColor = Color.LightBlue
        LCeldaMedicion.BackColor = Color.LightBlue
        Console.WriteLine("Solución flush en celda de medición")
    End Function

    Private Sub BComienzo_Click(sender As Object, e As EventArgs) Handles BComienzo.Click
        If (LMuestraSangre.BackColor = Color.Firebrick) Then
            Console.WriteLine("Hay muestra de sangre en el depósito")
            'LSensGota3.BackColor = Color.Firebrick
            Paso1y2()
        ElseIf (LMuestraSangre.BackColor = SystemColors.ButtonFace) Then
            MessageBox.Show("Ingresar una muestra de sangre")
        End If

    End Sub

    Private Sub BAgregarMuestra_Click(sender As Object, e As EventArgs) Handles BAgregarMuestra.Click
        LMuestraSangre.BackColor = Color.Firebrick
        Console.WriteLine("Se ingresó una muestra de sangre en el sistema")
    End Sub
End Class