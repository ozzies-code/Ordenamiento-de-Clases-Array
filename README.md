# Ordenamiento de Clases Array

 Este proyecto hace el llenado de un TextBox con Arreglos numericos 
 de manera aleatoria con la funcion Rnd( ), Adicionalmente se trabaja 
 con una Barra de Progreso que mostrara la carga de cada elemento del 
 arreglo en el textbox. Tambien se emplearan los Metodos Ordenar () 
 y Revertir() para luego volver a cargar todo el arreglo en pantalla.

 # Descripcion

 Se hace la siguiente declaracion del Arreglo: Dim RandArray(0 To 2999) 
 As Long. Posteriormente se definen los limites superior e inferior
 de la Barra de Progreso que mostrara la carga de todos los elementos del
 Arreglo en el TextBox. Despues se recorre y rellena el Arreglo Numerico
 conn la funcion Rnd() con numeros Aleatorios tipo Long. Y en ese orden
 aleatorio apareceran en el cuadro de texto. Se llama a la funcion 
 Array.Sort a traves de la siguiente instruccion: Array.Sort(RandArray)
 Este proyecto ordenara todo el arreglo al hacer clic en el correspondiente
 boton recorriendo luego todo el arreglo y mostrandolo por pantalla en 
 el TextBox y la Barra de Progreso mostrara el avance de la carga del
 Arreglo. el mismo proceso ocurrira con el metodo Array.Reverte para 
 invertir el orden del arreglo a traves de la siguiente instruccion:
 Array.Reverse(RandArray).
 
 # Actualizacion: 08/01/2025
 # Hora: 07:13

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# Array Class Sorting

This project fills a TextBox with random numeric arrays using the Rnd() function. 
Additionally, a Progress Bar is used to show the loading of each element 
of the array in the textbox. The Sort() and Reverse() methods will also be used to 
reload the entire array on the screen.

# Description

The following Array declaration is made: Dim RandArray(0 To 2999) As Long. 
The upper and lower limits of the Progress Bar are then defined to show 
the loading of all the elements of the Array in the TextBox. Then the Numeric Array 
is traversed and filled using the Rnd() function with random Long-type numbers. 
And in that random order they will appear in the text box. The Array.Sort function 
is called through the following instruction: Array.Sort(RandArray).
This project will sort the entire array by clicking on the corresponding
button, then going through the entire array and displaying it on the screen in
the TextBox and the Progress Bar will show the progress of the array loading.
The same process will occur with the Array.Reverte method to reverse the order of the
array through the following instruction:
Array.Reverse(RandArray).

# Update: 01/08/2025
# Time: 07:13

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/4ee45a01-ad18-4224-a900-eced7ebcf810)

Code of the Project:

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
