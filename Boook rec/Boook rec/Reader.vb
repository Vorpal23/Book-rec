Imports System.IO

Public Class Read


    Public Sub New()


    End Sub

    Property Name As String
    Property Scores As Single()



    Function rec(p As Read) As Integer
        Dim most As Integer = 0
        Dim bok As Integer
        For i As Integer = 1 To UBound(Me.Scores)
            If p.Scores(i) > most And Me.Scores(i) = 0 Then
                most = p.Scores(i)
                bok = i

            End If

        Next
        Return bok
    End Function








    Function Compare(p As Read) As Integer
        Dim Likeness As Integer = 0
        Dim i As Integer
        Dim x As Read

        x = New Read


        If p.Scores IsNot Nothing Then

            For i = 1 To 55

                Likeness += p.Scores(i) * Me.Scores(i)
            Next
            Compare = Likeness




            End If





    End Function




    Sub Import(Sl1 As String)
        Dim tmp(82) As Single



goodOpen:












        ReDim Scores((UBound(Sl1.Split(" "))))
        ReDim tmp(UBound(Sl1.Split(" ")))
        For i As Integer = 1 To UBound((Sl1.Split(" ")))
            tmp(i) = Val(Sl1.Split(" ")(i))
        Next
        Me.Scores = tmp





        'MsgBox(ex.ToString)



    End Sub






    Function Assoc(Pos) As String
        Dim Books(10000)
        Dim co As Integer = 1
        Try
            Return Books(Pos)

        Catch ex As Exception
            MsgBox("Could not find Books")
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
