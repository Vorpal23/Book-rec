Public Class Form1
    Public Reader(86) As Read
    Function Compare(a As Read, b As Read) As Integer
        Dim Likeness As Integer
        Dim i As Integer
        Dim x As Read

        'Try


        For i = 1 To 55


                    Likeness += a.Scores(i) * b.Scores(i)
                Next


                Return Likeness


        ' Catch ex As Exception
        ' MsgBox(ex.ToString)

        ' End Try



    End Function
    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cus As New Read
        Dim i As Integer


        FileOpen(1, "Z:\BookRecomendationProject\readerratings.txt", OpenMode.Input, OpenAccess.Read)

        For i = 1 To 86
            Reader(i) = New Read With {
                .Name = LineInput(1)
            }
            Reader(i).Import(LineInput(1))
            ListBox1.Items.Add(Reader(i).Name)


        Next
        FileOpen(5, "Z:\BookRecomendationProject\books.txt", OpenMode.Input, OpenAccess.Read)
        Dim strline As String = LineInput(5)

        Do While Not EOF(5)
            strline = LineInput(5)
            ListBox2.Items.Add(strline)
        Loop


    End Sub



    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim p1 As Read = Reader(ListBox1.SelectedIndex + 1)
        Dim l As Integer = 0
        Dim index As Integer
        Dim i As Integer
        MsgBox(Reader(1).GetType.ToString)
        Dim com As New Read

        For i = 1 To 86
            com = Reader(i)


            If Compare(p1, com) > l And Not p1.Name = com.Name Then
                l = p1.Compare(Reader(i))
                index = i

            End If

        Next
        MsgBox(Reader(index).Name)
    End Sub

    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cus As New Read
        Dim i As Integer
        FileOpen(5, "Z:\BookRecomendationProject\books.txt", OpenMode.Input, OpenAccess.Read)
        Dim strline As String = LineInput(5)
        Do While Not EOF(5)
            strline = LineInput(5)
            ListBox2.Items.Add(strline)
        Loop
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click

    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick

    End Sub
End Class
