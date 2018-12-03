Imports System.IO

Public Class Read
    Structure Human
        Dim ratings() As Double
        Dim name As String

    End Structure
    Dim rdr As Human
    Public Property data As Human




    Sub Import(path As String, readln As Integer, person As Integer)
        Try
            FileOpen(1, path, OpenMode.Input, OpenAccess.Read)
            GoTo goodOpen
        Catch ex As Exception
            Try
                FileClose(1)
                FileOpen(1, path, OpenMode.Input, OpenAccess.Read)
                GoTo goodOpen
            Catch ex2 As Exception
                MsgBox(ex2)
            End Try

        End Try


goodOpen:
        Dim Strlines(readln) As String


        Try




            For i As Integer = 1 To (person * 2) - 1
                Strlines(1) = LineInput(1)
                Strlines(2) = LineInput(2)

            Next
            rdr.name = Strlines(1)
            ReDim rdr.ratings(UBound(Strlines(2).Split(" ")))
            For i As Integer = 1 To UBound((Strlines(2).Split(" ")))
                rdr.ratings(i) = Val(Strlines(2).Split(" ")(i))
            Next
            data = rdr



        Catch ex As Exception
            MsgBox("Out Of Range")

        End Try

    End Sub

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
