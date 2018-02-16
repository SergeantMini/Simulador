Imports System.Threading.Tasks
Imports System.Timers
Public Class Form1
    Dim timer As New Timer(1500)

    Private Sub BComienzo_Click(sender As Object, e As EventArgs) Handles BComienzo.Click
        LMuestraSangre.BackColor = Color.Firebrick
        'timer
        timer.Start()
        LMuestraSangre.BackColor = SystemColors.ButtonFace
        timer.Start()
        LSensGota3.BackColor = Color.Firebrick


    End Sub
End Class
