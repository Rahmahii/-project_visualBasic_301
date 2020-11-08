Imports System.IO
Imports System.Console

Module Module1

    Sub Main()
        Dim choice As ConsoleKeyInfo
        Dim file = "myFile.txt"
        Dim reader As StreamReader = IO.File.OpenText(file)
        Dim line As String = reader.ReadLine()
        Dim dEmployees As New Dictionary(Of String, String)
        Dim a() As String
        While line IsNot Nothing
            a = Split(line, ", ")
            dEmployees.Add(a(0), a(1))
            line = reader.ReadLine()
        End While
        Do
            DisplyMenu()
            choice = ReadKey()

            Select Case choice.KeyChar
                Case "1"
                    WriteLine("1")
                Case "2"
                    WriteLine("2")
                Case "3"
                    WriteLine("3")
                Case "4"
                    WriteLine("4")
            End Select


        Loop While choice.KeyChar <> "5"
        reader.Close()



    End Sub
    Sub DisplyMenu()

        WriteLine("Please enter your choice number")
        WriteLine("1-Find the salary for employees")
        WriteLine("2-Print the sum, minimum and maximum of salaries")
        WriteLine("3-Add a new employee with his/her salary")
        WriteLine("4-Delete an existing employee by his/her name")
        WriteLine("5-Exit")


    End Sub

End Module
