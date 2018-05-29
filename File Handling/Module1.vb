
Module Module1

    Sub Main()
        Dim temp As myData
        For i = 1 To 5
            temp.data = Console.ReadLine()
            temp.id = i
            writeFileRandom(temp)
        Next
        Console.WriteLine(readFileRandom(3).Data)
        Console.ReadLine()


        'Dim file1 = New System.IO.StreamReader("test.txt")
        'file1.ReadLine()

    End Sub



    Sub writeFileRandom(ByVal rec As myData)
        FileOpen(1, "test.bat", OpenMode.Random, ,, Len(New myData))
        FilePut(1, rec, rec.id)
        FileClose(1)
    End Sub

    Function readFileRandom(ByVal key As Integer)
        Dim out As myData
        FileOpen(1, "test.bat", OpenMode.Random,,, Len(New myData))
        FileGet(1, out, key)
        Return out
    End Function

    Structure myData
        Dim data As String
        Dim id As Integer
    End Structure


End Module
