Public Class Form1
    Dim RandArray(0 To 2999) As Long

    'Abre el objeto barra de progreso y muestra el numero de elementos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = UBound(RandArray)
        Label2.Text = UBound(RandArray) + 1

    End Sub

    Private Sub btnllenar_Click(sender As Object, e As EventArgs) Handles btnllenar.Click
        'Completa el arreglo con numeros aleatorios, y los despliega en un cuadro de texto
        Dim i As Integer

        For i = 0 To UBound(RandArray) 'Ubond: Funcion que devuelve el indice superior de un Arreglo
            RandArray(i) = Int(Rnd() * 1000000)
            txtOrder.Text = txtOrder.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i 'hacer que avance la barra de progreso
        Next i
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        'Ordena el arreglo mediante el metodo Array.Sort
        Dim i As Integer
        txtOrder.Text = ""
        Array.Sort(RandArray)

        For i = 0 To UBound(RandArray) 'Ubond: Funcion que devuelve el indice superior de un Arreglo
            txtOrder.Text = txtOrder.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i 'mueve la barra de avance
        Next i
    End Sub

    Private Sub btnRevertir_Click(sender As Object, e As EventArgs) Handles btnRevertir.Click
        'Revierte de los elementos del arreglo, utilizando Array.Reverse
        Dim i As Integer
        txtOrder.Text = ""
        Array.Reverse(RandArray)

        For i = 0 To UBound(RandArray) 'Ubond: Funcion que devuelve el indice superior de un Arreglo
            txtOrder.Text = txtOrder.Text & RandArray(i) & vbCrLf
            ProgressBar1.Value = i 'hacer que avance la barra de progreso
        Next i
    End Sub
End Class
