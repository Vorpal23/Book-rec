﻿Imports System.IO

Public Class Read
    Public Sub New()

    End Sub

    Property Name As String
    Property Scores As Single()












    Function Compare(p As Read) As Integer
        Dim Likeness As Integer
        Dim i As Integer
        Dim x As Read

        x = New Read

        Try
            If p.Scores IsNot Nothing Then

                For i = 1 To 55
                    If p.Scores(i) = Nothing Then p.Scores(i) = 0
                    If Me.Scores(i) = Nothing Then Me.Scores(i) = 0
                    Likeness += p.Scores(i) * Me.Scores(i)
                Next


                Return Likeness

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            End
        End Try



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






    Function Assoc(Pos, path) As String
        Dim Books(10000)
        Dim co As Integer = 1
        Try
            FileOpen(2, path, OpenMode.Input, OpenAccess.Read)
            Do While Not EOF(2)
                Books(co) = LineInput(2)
                co += 1

            Loop

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
