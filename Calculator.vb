Imports System

Public Class Calculator
    ' Adds two numbers and returns the sum
    Public Function AddNumbers(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

    ' Subtracts the second number from the first and returns the result
    Public Function SubtractNumbers(a As Integer, b As Integer) As Integer
        Return a - b
    End Function

    ' Multiplies two numbers and returns the product
    Public Function MultiplyNumbers(a As Integer, b As Integer) As Integer
        Return a * b
    End Function

    ' Divides the first number by the second and returns the quotient
    ' Throws an exception if the divisor is zero
    Public Function DivideNumbers(a As Integer, b As Integer) As Integer
        If b = 0 Then
            Throw New DivideByZeroException("Cannot divide by zero.")
        Else
            Return a \ b ' Using integer division
        End If
    End Function

    ' Raises the first number to the power of the second and returns the result
    Public Function PowerNumber(a As Integer, b As Integer) As Integer
        Return CInt(Math.Pow(a, b))
    End Function    

    ' Returns the integer part of the square root of the given number
    Public Function SqrtNumber(a As Integer) As Integer
        Return CInt(Math.Sqrt(a))
    End Function

    Public Shared Sub Main()
        ' Example code to test the Calculator
        Dim calc As New Calculator()
        Console.WriteLine("Adding 5 + 3: " & calc.AddNumbers(5, 3))
        Console.WriteLine("Subtracting 5 - 3: " & calc.SubtractNumbers(5, 3))
        Console.WriteLine("Multiplying 5 * 3: " & calc.MultiplyNumbers(5, 3))
        Try
            Console.WriteLine("Dividing 5 / 0: " & calc.DivideNumbers(5, 0))
        Catch ex As DivideByZeroException
            Console.WriteLine(ex.Message)
        End Try
        Console.WriteLine("5 raised to the power of 3: " & calc.PowerNumber(5, 3))
        Console.WriteLine("Square root of 25: " & calc.SqrtNumber(25))

        Console.ReadLine() ' To keep the console window open
    End Sub
End Class
