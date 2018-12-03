Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Reader(5) As Read
        Dim i As Integer
        For i = 1 To 86
            Reader(i).Import("Z:\BookRecomendationProject\readerratings.txt", 2, i)
        Next


    End Sub
End Class
