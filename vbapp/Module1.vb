Imports System.Console

Module Module1

    Sub Main()





        'Dim string1 As String = "Hello world"
        'Dim string2 As String
        'Dim string3 As String
        'Dim string4 As String
        'Dim string5 As String
        'Dim string6 As String

        'Dim mychar As Char
        'mychar = Convert.ToChar(ReadLine())
        'WriteLine("Char is " + mychar)
        'WriteLine(string1)
        'string2 = UCase(string1)
        'WriteLine(string2)
        'string3 = LCase(string1)
        'WriteLine(string3)
        'string4 = string1.Substring(4, 5)
        'WriteLine(string4)
        'string5 = string1.Clone
        'WriteLine(string5)
        'string6 = string1.GetHashCode
        'WriteLine(string6)


        'Dim m1, m2, m3, m4, m5, tot, age As Integer
        'Dim name As String
        'Dim avg As Double
        'Console.WriteLine("Enter the name of student: ")
        'name = Console.ReadLine()
        'Console.WriteLine("Enter 5 subject marks:")
        'm1 = Integer.Parse(Console.ReadLine())
        'm2 = Integer.Parse(Console.ReadLine())
        'm3 = Integer.Parse(Console.ReadLine())
        'm4 = Integer.Parse(Console.ReadLine())
        'm5 = Integer.Parse(Console.ReadLine())
        'Console.WriteLine("Enter the age of student: ")
        'age = Integer.Parse(Console.ReadLine())
        'tot = m1 + m2 + m3 + m4 + m5
        'avg = tot / 5
        'Console.WriteLine("Name of Student is {0} and he is {1} years old he has Scored {2} out of 500 with an average of {3}", name, age, tot, avg)

        'Dim i As Integer = 10

        'If i Mod 2 = 0 Then
        '    Console.WriteLine("true")
        'Else
        '    Console.WriteLine("false")
        'End If

        'If i = 5 Then
        '    Console.WriteLine("five")
        'ElseIf i = 7 Then
        '    Console.WriteLine("seven")
        'ElseIf i = 10 Then
        '    Console.WriteLine("ten")
        'Else
        '    Console.WriteLine("number not 5,7,10")
        'End If

        'Dim num As Char
        'Console.WriteLine("enter a or b or c: ")
        'num = ReadLine()

        'Select Case num
        '    Case "a"
        '        Console.WriteLine("a")
        '    Case "b"
        '        Console.WriteLine("b")
        '    Case "c"
        '        Console.WriteLine("c")
        '    Case Else
        '        Console.WriteLine("invalid")
        'End Select

        'Dim f As Integer

        'For vr As Integer = 0 To 4 Step 1
        '    Console.WriteLine("enter num: ")
        '    f = Console.ReadLine()
        '    If f Mod 2 = 0 Then
        '        Console.WriteLine("even")
        '    Else
        '        Console.WriteLine("odd")
        '    End If
        'Dim a1 As Integer = 10
        'Dim a2 As String = "10"
        'If a1 = a2 Then
        '    Console.WriteLine("true")
        'Else
        '    Console.WriteLine("false")
        'End If
        'Next

        Dim i, e As Integer
        i = 5
        e = 0
        While e < i
            e += 1
        End While
        Console.WriteLine("loop executed " & e & " times")

        Dim ab As Integer
        ab = 0
        Do
            Console.WriteLine("Iteration number :" & ab)
            ab += 1
        Loop While (ab < 10)

        Dim arr As Integer() = New Integer() {3, 6, 9, 369}
        For ivar As Integer = 0 To arr.Length - 1
            Console.WriteLine(arr(ivar))
        Next
        Array.Reverse(arr)

        For Each ivar As Integer In arr
            Console.WriteLine(ivar)
        Next

        Dim arr2(2, 2) As Integer
        arr2(0, 0) = 3
        arr2(0, 1) = 6
        arr2(1, 0) = 9
        arr2(1, 1) = 12


        For c As Integer = 0 To 2
            For c1 As Integer = 0 To 2
                Console.WriteLine(arr2(c, c1))
            Next
        Next
        Read()
    End Sub

End Module
