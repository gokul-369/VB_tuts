Imports System.Console

Module Module1

    Class test
        Dim num1, num2, sum As Integer

        Public Sub setData()
            Console.WriteLine("Enter the numbers:")
            num1 = Integer.Parse(Console.ReadLine())
            num2 = Integer.Parse(Console.ReadLine())
        End Sub

        Public Function setData1(ByVal n1 As Integer, ByVal n2 As Integer)
            Dim Result As Integer
            Result = n1 + n2
            Return Result
        End Function

        Public Function add()
            sum = num1 + num2
        End Function

        Public Sub display()
            Console.WriteLine("the numbers are {0} and {1} and sum is {2}", num1, num2, sum)
        End Sub

    End Class
    Class test1

        Dim n1, n2, sum As Integer

        Public Sub New()
            Console.WriteLine("Enter the Numbers")
            n1 = Integer.Parse(Console.ReadLine())
            n2 = Integer.Parse(Console.ReadLine())
        End Sub

        Public Sub New(ByVal a As Integer, ByVal b As Integer)
            n1 = a
            n2 = b
        End Sub

        Public Sub New(ByVal e As test1)
            n1 = e.n1
            n2 = e.n2
        End Sub

        Public Sub add()
            sum = n1 + n2
            Console.WriteLine("num1:{0}, num2:{1}, sum:{2}", n1, n2, sum)
        End Sub

    End Class
    Class abs
        Dim empId As Integer
        Dim name As String
        Dim Sal As Integer
        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal sal As Integer)
            empId = id
            Me.name = name
            Me.Sal = sal
        End Sub
        Public Sub display()
            Console.WriteLine("name and id are:{0} and {1}", name, empId)
        End Sub
        Private Sub ShowSal()
            Console.WriteLine("sal of {0} is {1} ", name, Sal)
        End Sub

    End Class
    Class parent
        Dim Ename, Des As String
        Public Eid, Sal As Integer

        Public Sub New()
            Console.WriteLine("Enter details")
            Ename = Console.ReadLine()
            Des = Console.ReadLine()
            Eid = Integer.Parse(Console.ReadLine)
            Sal = Integer.Parse(Console.ReadLine)
        End Sub

        Public Sub display()
            Console.WriteLine("Name :{0} Designation:{1} Id:{2} Sal:{3}", Ename, Des, Eid, Sal)
        End Sub

    End Class
    Class child
        Inherits parent
        Public Sub hike()
            Sal = Sal + 2000
        End Sub

        Public Sub show()
            display()
        End Sub

    End Class
    Interface i1
        Sub show()
    End Interface
    Class c
        Implements i1
        Sub Display()
            Console.WriteLine("hello from c1")
        End Sub

        Sub show() Implements i1.show
            Console.WriteLine("hello from interface method")
        End Sub
    End Class
    Class fun
        Public Sub cal()
            Console.WriteLine(4 * 4)
        End Sub
        Public Sub cal(ByVal e As Integer)
            Console.WriteLine(e * e)
        End Sub
        Public Sub cal(ByVal e As Integer, ByVal f As Integer)
            Console.WriteLine(e * f)
        End Sub
        Public Sub cal(ByVal e As Double, ByVal f As Double)
            Console.WriteLine(e * f)
        End Sub


    End Class
    Class op
        Private x As Double
        Private y As Double

        Public Sub New()
        End Sub
        Public Sub New(ByVal Real As Double, ByVal Img As Double)
            x = Real
            y = Img
        End Sub

        Public Shared Operator +(ByVal c1 As op, ByVal c2 As op)
            Dim c3 As New op()
            c3.x = c1.x + c2.x
            c3.y = c1.y + c2.y
            Return c3
        End Operator

        Public Sub display()
            Console.WriteLine("{0}+{1}i", x, y)
        End Sub
    End Class

    Sub Main()
        Dim c1 = New op(2.0, 4.0)
        Dim c2 = New op(9.0, 3.0)
        Dim c3 = New op()
        c3 = c1 + c2
        Console.WriteLine("c1=")
        c1.display()
        Console.WriteLine("c2=")
        c2.display()
        Console.WriteLine("c3=")
        c3.display()


        'Dim f As New fun()
        'f.cal()
        'f.cal(2)
        'f.cal(2, 8)
        'f.cal(9.0, 9.8)

        'Dim c As New c()
        'c.Display()
        'c.show()

        'Dim c As New child()
        'c.show()
        'c.hike()
        'c.show()

        'Dim t As New abs(1001, "gokul", 40000)
        't.display()

        'Dim t As New test1()
        't.add()
        'Dim t1 As New test1(23, 98)
        't1.add()
        'Dim t2 As New test1(t)
        't2.add()

        'Dim t As New test()
        't.setData()
        't.add()
        't.display()
        'Dim res As Integer = t.setData1(10, 70)
        'Console.WriteLine("new result is {0}", res)

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

        'Dim i, e As Integer
        'i = 5
        'e = 0
        'While e < i
        '    e += 1
        'End While
        'Console.WriteLine("loop executed " & e & " times")

        'Dim ab As Integer
        'ab = 0
        'Do
        '    Console.WriteLine("Iteration number :" & ab)
        '    ab += 1
        'Loop While (ab < 10)

        'Dim arr As Integer() = New Integer() {3, 6, 9, 369}
        'For ivar As Integer = 0 To arr.Length - 1
        '    Console.WriteLine(arr(ivar))
        'Next
        'Array.Reverse(arr)

        'For Each ivar As Integer In arr
        '    Console.WriteLine(ivar)
        'Next

        'Dim arr2(2, 2) As Integer
        'arr2(0, 0) = 3
        'arr2(0, 1) = 6
        'arr2(1, 0) = 9
        'arr2(1, 1) = 12


        'For c As Integer = 0 To 2
        '    For c1 As Integer = 0 To 2
        '        Console.WriteLine(arr2(c, c1))
        '    Next
        'Next
        Read()
    End Sub

End Module
