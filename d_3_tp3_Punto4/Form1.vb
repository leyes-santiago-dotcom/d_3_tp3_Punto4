Public Class Form1
    '3. Realizar un algoritmo que permita cargar una
    'matriz de 10 por 8 elementos, y obtener un 
    'vector de 10 elementos formado por los mínimos de cada fila. 
    Dim Matriz(10, 8), Vector(10), Minimo, Indice As Integer
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Minimo = 999999
        Indice = 1
        For c = 1 To 8
            dtvMatriz.Columns.Add("", "")
        Next
        dtvMatriz.Rows.Add(10)
        For f = 1 To 10
            For c = 1 To 8
                Matriz(f, c) = 100 * Rnd()
                If Matriz(f, c) < Minimo Then
                    Minimo = Matriz(f, c)
                End If
            Next
            Vector(Indice) = Minimo
            Indice = Indice + 1
            Minimo = 999999
        Next
        dtvMatriz.Item(0, 0).Value = "La Matriz Ingresada es"
        For f = 1 To 10
            For c = 1 To 8
                dtvMatriz.Item(c - 1, f - 1).Value = Matriz(f, c)
            Next
        Next
        lstVector.Items.Add("El Vector de los Mínimos es")
        For t = 1 To 10
            lstVector.Items.Add(Vector(t))
        Next
    End Sub
End Class
